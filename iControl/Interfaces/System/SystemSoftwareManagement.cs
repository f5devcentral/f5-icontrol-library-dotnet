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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.SoftwareManagementBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSoftwareManagementSoftwareStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSoftwareManagementsoftwareBlockDeviceHotfix))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSoftwareManagementrepositoryImageID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSoftwareManagementsoftwareBlockDeviceImage))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSoftwareManagementHotFixInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSoftwareManagementInstallationID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSoftwareManagementsoftwareRepositoryHotfix))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSoftwareManagementsoftwareRepositoryImage))]
	public partial class SystemSoftwareManagement : iControlInterface {
		public SystemSoftwareManagement() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// cleanup_ramfs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	public void cleanup_ramfs(

	) {
		this.Invoke("cleanup_ramfs", new object [0]);

	}
	public System.IAsyncResult Begincleanup_ramfs(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("cleanup_ramfs", new object[0], callback, asyncState);
	}
	public void Endcleanup_ramfs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_ramfs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string create_ramfs(

	) {
		object [] results = this.Invoke("create_ramfs", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Begincreate_ramfs(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_ramfs", new object[0], callback, asyncState);
	}
	public string Endcreate_ramfs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// delete_software_image
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	public void delete_software_image(
		string [] image_filenames
	) {
		this.Invoke("delete_software_image", new object [] {
				image_filenames});

	}
	public System.IAsyncResult Begindelete_software_image(string [] image_filenames, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_software_image", new object[] {
			image_filenames}, callback, asyncState);
	}
	public void Enddelete_software_image(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_volume
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	public void delete_volume(
		string volume
	) {
		this.Invoke("delete_volume", new object [] {
				volume});

	}
	public System.IAsyncResult Begindelete_volume(string volume, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_volume", new object[] {
			volume}, callback, asyncState);
	}
	public void Enddelete_volume(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_software_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementSoftwareStatus [] get_all_software_status(

	) {
		object [] results = this.Invoke("get_all_software_status", new object [0]);
		return ((SystemSoftwareManagementSoftwareStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_software_status(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_software_status", new object[0], callback, asyncState);
	}
	public SystemSoftwareManagementSoftwareStatus [] Endget_all_software_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementSoftwareStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_block_device_software_hotfix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementsoftwareBlockDeviceHotfix [] get_block_device_software_hotfix(
		SystemSoftwareManagementrepositoryImageID [] imageIDs
	) {
		object [] results = this.Invoke("get_block_device_software_hotfix", new object [] {
				imageIDs});
		return ((SystemSoftwareManagementsoftwareBlockDeviceHotfix [])(results[0]));
	}
	public System.IAsyncResult Beginget_block_device_software_hotfix(SystemSoftwareManagementrepositoryImageID [] imageIDs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_block_device_software_hotfix", new object[] {
			imageIDs}, callback, asyncState);
	}
	public SystemSoftwareManagementsoftwareBlockDeviceHotfix [] Endget_block_device_software_hotfix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementsoftwareBlockDeviceHotfix [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_block_device_software_hotfix_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementrepositoryImageID [] get_block_device_software_hotfix_list(

	) {
		object [] results = this.Invoke("get_block_device_software_hotfix_list", new object [0]);
		return ((SystemSoftwareManagementrepositoryImageID [])(results[0]));
	}
	public System.IAsyncResult Beginget_block_device_software_hotfix_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_block_device_software_hotfix_list", new object[0], callback, asyncState);
	}
	public SystemSoftwareManagementrepositoryImageID [] Endget_block_device_software_hotfix_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementrepositoryImageID [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_block_device_software_image
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementsoftwareBlockDeviceImage [] get_block_device_software_image(
		SystemSoftwareManagementrepositoryImageID [] imageIDs
	) {
		object [] results = this.Invoke("get_block_device_software_image", new object [] {
				imageIDs});
		return ((SystemSoftwareManagementsoftwareBlockDeviceImage [])(results[0]));
	}
	public System.IAsyncResult Beginget_block_device_software_image(SystemSoftwareManagementrepositoryImageID [] imageIDs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_block_device_software_image", new object[] {
			imageIDs}, callback, asyncState);
	}
	public SystemSoftwareManagementsoftwareBlockDeviceImage [] Endget_block_device_software_image(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementsoftwareBlockDeviceImage [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_block_device_software_image_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementrepositoryImageID [] get_block_device_software_image_list(

	) {
		object [] results = this.Invoke("get_block_device_software_image_list", new object [0]);
		return ((SystemSoftwareManagementrepositoryImageID [])(results[0]));
	}
	public System.IAsyncResult Beginget_block_device_software_image_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_block_device_software_image_list", new object[0], callback, asyncState);
	}
	public SystemSoftwareManagementrepositoryImageID [] Endget_block_device_software_image_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementrepositoryImageID [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_boot_image_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public byte [] get_boot_image_information(
		bool save_active_config
	) {
		object [] results = this.Invoke("get_boot_image_information", new object [] {
				save_active_config});
		return ((byte [])(results[0]));
	}
	public System.IAsyncResult Beginget_boot_image_information(bool save_active_config, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_boot_image_information", new object[] {
			save_active_config}, callback, asyncState);
	}
	public byte [] Endget_boot_image_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((byte [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_boot_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_boot_location(

	) {
		object [] results = this.Invoke("get_boot_location", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_boot_location(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_boot_location", new object[0], callback, asyncState);
	}
	public string Endget_boot_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster_boot_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_cluster_boot_location(

	) {
		object [] results = this.Invoke("get_cluster_boot_location", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_boot_location(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_boot_location", new object[0], callback, asyncState);
	}
	public string Endget_cluster_boot_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hotfix_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementHotFixInformation [] get_hotfix_information(

	) {
		object [] results = this.Invoke("get_hotfix_information", new object [0]);
		return ((SystemSoftwareManagementHotFixInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_hotfix_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hotfix_information", new object[0], callback, asyncState);
	}
	public SystemSoftwareManagementHotFixInformation [] Endget_hotfix_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementHotFixInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_live_install_completion
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_live_install_completion(
		SystemSoftwareManagementInstallationID [] installation_ids
	) {
		object [] results = this.Invoke("get_live_install_completion", new object [] {
				installation_ids});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_live_install_completion(SystemSoftwareManagementInstallationID [] installation_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_live_install_completion", new object[] {
			installation_ids}, callback, asyncState);
	}
	public string [] Endget_live_install_completion(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rpm_package_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_rpm_package_information(

	) {
		object [] results = this.Invoke("get_rpm_package_information", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_rpm_package_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rpm_package_information", new object[0], callback, asyncState);
	}
	public string [] Endget_rpm_package_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_software_hotfix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementsoftwareRepositoryHotfix [] get_software_hotfix(
		SystemSoftwareManagementrepositoryImageID [] imageIDs
	) {
		object [] results = this.Invoke("get_software_hotfix", new object [] {
				imageIDs});
		return ((SystemSoftwareManagementsoftwareRepositoryHotfix [])(results[0]));
	}
	public System.IAsyncResult Beginget_software_hotfix(SystemSoftwareManagementrepositoryImageID [] imageIDs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_software_hotfix", new object[] {
			imageIDs}, callback, asyncState);
	}
	public SystemSoftwareManagementsoftwareRepositoryHotfix [] Endget_software_hotfix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementsoftwareRepositoryHotfix [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_software_hotfix_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementrepositoryImageID [] get_software_hotfix_list(

	) {
		object [] results = this.Invoke("get_software_hotfix_list", new object [0]);
		return ((SystemSoftwareManagementrepositoryImageID [])(results[0]));
	}
	public System.IAsyncResult Beginget_software_hotfix_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_software_hotfix_list", new object[0], callback, asyncState);
	}
	public SystemSoftwareManagementrepositoryImageID [] Endget_software_hotfix_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementrepositoryImageID [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_software_image
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementsoftwareRepositoryImage [] get_software_image(
		SystemSoftwareManagementrepositoryImageID [] imageIDs
	) {
		object [] results = this.Invoke("get_software_image", new object [] {
				imageIDs});
		return ((SystemSoftwareManagementsoftwareRepositoryImage [])(results[0]));
	}
	public System.IAsyncResult Beginget_software_image(SystemSoftwareManagementrepositoryImageID [] imageIDs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_software_image", new object[] {
			imageIDs}, callback, asyncState);
	}
	public SystemSoftwareManagementsoftwareRepositoryImage [] Endget_software_image(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementsoftwareRepositoryImage [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_software_image_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementrepositoryImageID [] get_software_image_list(

	) {
		object [] results = this.Invoke("get_software_image_list", new object [0]);
		return ((SystemSoftwareManagementrepositoryImageID [])(results[0]));
	}
	public System.IAsyncResult Beginget_software_image_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_software_image_list", new object[0], callback, asyncState);
	}
	public SystemSoftwareManagementrepositoryImageID [] Endget_software_image_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementrepositoryImageID [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_software_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSoftwareManagementSoftwareStatus [] get_software_status(
		SystemSoftwareManagementInstallationID [] installation_ids
	) {
		object [] results = this.Invoke("get_software_status", new object [] {
				installation_ids});
		return ((SystemSoftwareManagementSoftwareStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_software_status(SystemSoftwareManagementInstallationID [] installation_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_software_status", new object[] {
			installation_ids}, callback, asyncState);
	}
	public SystemSoftwareManagementSoftwareStatus [] Endget_software_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSoftwareManagementSoftwareStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
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
	// has_logical_volume_management
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool has_logical_volume_management(

	) {
		object [] results = this.Invoke("has_logical_volume_management", new object [0]);
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginhas_logical_volume_management(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("has_logical_volume_management", new object[0], callback, asyncState);
	}
	public bool Endhas_logical_volume_management(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// install_hotfix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	public void install_hotfix(
		string [] hotfix_files,
		bool reboot_system
	) {
		this.Invoke("install_hotfix", new object [] {
				hotfix_files,
				reboot_system});

	}
	public System.IAsyncResult Begininstall_hotfix(string [] hotfix_files,bool reboot_system, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_hotfix", new object[] {
			hotfix_files,
			reboot_system}, callback, asyncState);
	}
	public void Endinstall_hotfix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// install_hotfix_no_daemons
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	public void install_hotfix_no_daemons(
		string [] hotfix_files,
		bool reboot_system
	) {
		this.Invoke("install_hotfix_no_daemons", new object [] {
				hotfix_files,
				reboot_system});

	}
	public System.IAsyncResult Begininstall_hotfix_no_daemons(string [] hotfix_files,bool reboot_system, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_hotfix_no_daemons", new object[] {
			hotfix_files,
			reboot_system}, callback, asyncState);
	}
	public void Endinstall_hotfix_no_daemons(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// install_software_image
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	public void install_software_image(
		string install_volume,
		string product,
		string version,
		string build
	) {
		this.Invoke("install_software_image", new object [] {
				install_volume,
				product,
				version,
				build});

	}
	public System.IAsyncResult Begininstall_software_image(string install_volume,string product,string version,string build, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_software_image", new object[] {
			install_volume,
			product,
			version,
			build}, callback, asyncState);
	}
	public void Endinstall_software_image(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// install_software_image_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	public void install_software_image_v2(
		string volume,
		string product,
		string version,
		string build,
		bool create_volume,
		bool reboot,
		bool retry
	) {
		this.Invoke("install_software_image_v2", new object [] {
				volume,
				product,
				version,
				build,
				create_volume,
				reboot,
				retry});

	}
	public System.IAsyncResult Begininstall_software_image_v2(string volume,string product,string version,string build,bool create_volume,bool reboot,bool retry, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_software_image_v2", new object[] {
			volume,
			product,
			version,
			build,
			create_volume,
			reboot,
			retry}, callback, asyncState);
	}
	public void Endinstall_software_image_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_boot_image_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	public void set_boot_image_information(
		byte [] boot_image_information
	) {
		this.Invoke("set_boot_image_information", new object [] {
				boot_image_information});

	}
	public System.IAsyncResult Beginset_boot_image_information(byte [] boot_image_information, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_boot_image_information", new object[] {
			boot_image_information}, callback, asyncState);
	}
	public void Endset_boot_image_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_boot_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	public void set_boot_location(
		string location
	) {
		this.Invoke("set_boot_location", new object [] {
				location});

	}
	public System.IAsyncResult Beginset_boot_location(string location, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_boot_location", new object[] {
			location}, callback, asyncState);
	}
	public void Endset_boot_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cluster_boot_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SoftwareManagement", 
		RequestNamespace="urn:iControl:System/SoftwareManagement", ResponseNamespace="urn:iControl:System/SoftwareManagement")]
	public void set_cluster_boot_location(
		string location
	) {
		this.Invoke("set_cluster_boot_location", new object [] {
				location});

	}
	public System.IAsyncResult Beginset_cluster_boot_location(string location, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cluster_boot_location", new object[] {
			location}, callback, asyncState);
	}
	public void Endset_cluster_boot_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SoftwareManagement.SoftwareBlockDeviceAgent", Namespace = "urn:iControl")]
	public enum SystemSoftwareManagementSoftwareBlockDeviceAgent
	{
		DEVICE_AGENT_VCMP_VIRTUAL_CDROM,
		DEVICE_AGENT_UNKNOWN,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SoftwareManagement.HotFixInformation", Namespace = "urn:iControl")]
	public partial class SystemSoftwareManagementHotFixInformation
	{
		private string descriptionField;
		public string description
		{
			get { return this.descriptionField; }
			set { this.descriptionField = value; }
		}
		private string productField;
		public string product
		{
			get { return this.productField; }
			set { this.productField = value; }
		}
		private string idField;
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}
		private string version_resolvedField;
		public string version_resolved
		{
			get { return this.version_resolvedField; }
			set { this.version_resolvedField = value; }
		}
		private string [] packagesField;
		public string [] packages
		{
			get { return this.packagesField; }
			set { this.packagesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SoftwareManagement.InstallationID", Namespace = "urn:iControl")]
	public partial class SystemSoftwareManagementInstallationID
	{
		private long chassis_slot_idField;
		public long chassis_slot_id
		{
			get { return this.chassis_slot_idField; }
			set { this.chassis_slot_idField = value; }
		}
		private string install_volumeField;
		public string install_volume
		{
			get { return this.install_volumeField; }
			set { this.install_volumeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SoftwareManagement.SoftwareStatus", Namespace = "urn:iControl")]
	public partial class SystemSoftwareManagementSoftwareStatus
	{
		private SystemSoftwareManagementInstallationID installation_idField;
		public SystemSoftwareManagementInstallationID installation_id
		{
			get { return this.installation_idField; }
			set { this.installation_idField = value; }
		}
		private string productField;
		public string product
		{
			get { return this.productField; }
			set { this.productField = value; }
		}
		private string versionField;
		public string version
		{
			get { return this.versionField; }
			set { this.versionField = value; }
		}
		private string buildField;
		public string build
		{
			get { return this.buildField; }
			set { this.buildField = value; }
		}
		private string base_buildField;
		public string base_build
		{
			get { return this.base_buildField; }
			set { this.base_buildField = value; }
		}
		private bool activeField;
		public bool active
		{
			get { return this.activeField; }
			set { this.activeField = value; }
		}
		private string editionField;
		public string edition
		{
			get { return this.editionField; }
			set { this.editionField = value; }
		}
		private string statusField;
		public string status
		{
			get { return this.statusField; }
			set { this.statusField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SoftwareManagement.repositoryImageID", Namespace = "urn:iControl")]
	public partial class SystemSoftwareManagementrepositoryImageID
	{
		private long chassis_slot_idField;
		public long chassis_slot_id
		{
			get { return this.chassis_slot_idField; }
			set { this.chassis_slot_idField = value; }
		}
		private string filenameField;
		public string filename
		{
			get { return this.filenameField; }
			set { this.filenameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SoftwareManagement.softwareBlockDeviceHotfix", Namespace = "urn:iControl")]
	public partial class SystemSoftwareManagementsoftwareBlockDeviceHotfix
	{
		private long chassis_slot_idField;
		public long chassis_slot_id
		{
			get { return this.chassis_slot_idField; }
			set { this.chassis_slot_idField = value; }
		}
		private string filenameField;
		public string filename
		{
			get { return this.filenameField; }
			set { this.filenameField = value; }
		}
		private string productField;
		public string product
		{
			get { return this.productField; }
			set { this.productField = value; }
		}
		private string versionField;
		public string version
		{
			get { return this.versionField; }
			set { this.versionField = value; }
		}
		private string buildField;
		public string build
		{
			get { return this.buildField; }
			set { this.buildField = value; }
		}
		private string chksumField;
		public string chksum
		{
			get { return this.chksumField; }
			set { this.chksumField = value; }
		}
		private bool verifiedField;
		public bool verified
		{
			get { return this.verifiedField; }
			set { this.verifiedField = value; }
		}
		private string hotfix_idField;
		public string hotfix_id
		{
			get { return this.hotfix_idField; }
			set { this.hotfix_idField = value; }
		}
		private string hotfix_titleField;
		public string hotfix_title
		{
			get { return this.hotfix_titleField; }
			set { this.hotfix_titleField = value; }
		}
		private SystemSoftwareManagementSoftwareBlockDeviceAgent device_agentField;
		public SystemSoftwareManagementSoftwareBlockDeviceAgent device_agent
		{
			get { return this.device_agentField; }
			set { this.device_agentField = value; }
		}
		private string resource_idField;
		public string resource_id
		{
			get { return this.resource_idField; }
			set { this.resource_idField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SoftwareManagement.softwareBlockDeviceImage", Namespace = "urn:iControl")]
	public partial class SystemSoftwareManagementsoftwareBlockDeviceImage
	{
		private long chassis_slot_idField;
		public long chassis_slot_id
		{
			get { return this.chassis_slot_idField; }
			set { this.chassis_slot_idField = value; }
		}
		private string filenameField;
		public string filename
		{
			get { return this.filenameField; }
			set { this.filenameField = value; }
		}
		private string productField;
		public string product
		{
			get { return this.productField; }
			set { this.productField = value; }
		}
		private string versionField;
		public string version
		{
			get { return this.versionField; }
			set { this.versionField = value; }
		}
		private string buildField;
		public string build
		{
			get { return this.buildField; }
			set { this.buildField = value; }
		}
		private string chksumField;
		public string chksum
		{
			get { return this.chksumField; }
			set { this.chksumField = value; }
		}
		private bool verifiedField;
		public bool verified
		{
			get { return this.verifiedField; }
			set { this.verifiedField = value; }
		}
		private string build_dateField;
		public string build_date
		{
			get { return this.build_dateField; }
			set { this.build_dateField = value; }
		}
		private string last_modifiedField;
		public string last_modified
		{
			get { return this.last_modifiedField; }
			set { this.last_modifiedField = value; }
		}
		private string file_sizeField;
		public string file_size
		{
			get { return this.file_sizeField; }
			set { this.file_sizeField = value; }
		}
		private SystemSoftwareManagementSoftwareBlockDeviceAgent device_agentField;
		public SystemSoftwareManagementSoftwareBlockDeviceAgent device_agent
		{
			get { return this.device_agentField; }
			set { this.device_agentField = value; }
		}
		private string resource_idField;
		public string resource_id
		{
			get { return this.resource_idField; }
			set { this.resource_idField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SoftwareManagement.softwareRepositoryHotfix", Namespace = "urn:iControl")]
	public partial class SystemSoftwareManagementsoftwareRepositoryHotfix
	{
		private long chassis_slot_idField;
		public long chassis_slot_id
		{
			get { return this.chassis_slot_idField; }
			set { this.chassis_slot_idField = value; }
		}
		private string filenameField;
		public string filename
		{
			get { return this.filenameField; }
			set { this.filenameField = value; }
		}
		private string productField;
		public string product
		{
			get { return this.productField; }
			set { this.productField = value; }
		}
		private string versionField;
		public string version
		{
			get { return this.versionField; }
			set { this.versionField = value; }
		}
		private string buildField;
		public string build
		{
			get { return this.buildField; }
			set { this.buildField = value; }
		}
		private string chksumField;
		public string chksum
		{
			get { return this.chksumField; }
			set { this.chksumField = value; }
		}
		private bool verifiedField;
		public bool verified
		{
			get { return this.verifiedField; }
			set { this.verifiedField = value; }
		}
		private string hotfix_idField;
		public string hotfix_id
		{
			get { return this.hotfix_idField; }
			set { this.hotfix_idField = value; }
		}
		private string hotfix_titleField;
		public string hotfix_title
		{
			get { return this.hotfix_titleField; }
			set { this.hotfix_titleField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SoftwareManagement.softwareRepositoryImage", Namespace = "urn:iControl")]
	public partial class SystemSoftwareManagementsoftwareRepositoryImage
	{
		private long chassis_slot_idField;
		public long chassis_slot_id
		{
			get { return this.chassis_slot_idField; }
			set { this.chassis_slot_idField = value; }
		}
		private string filenameField;
		public string filename
		{
			get { return this.filenameField; }
			set { this.filenameField = value; }
		}
		private string productField;
		public string product
		{
			get { return this.productField; }
			set { this.productField = value; }
		}
		private string versionField;
		public string version
		{
			get { return this.versionField; }
			set { this.versionField = value; }
		}
		private string buildField;
		public string build
		{
			get { return this.buildField; }
			set { this.buildField = value; }
		}
		private string chksumField;
		public string chksum
		{
			get { return this.chksumField; }
			set { this.chksumField = value; }
		}
		private bool verifiedField;
		public bool verified
		{
			get { return this.verifiedField; }
			set { this.verifiedField = value; }
		}
		private string build_dateField;
		public string build_date
		{
			get { return this.build_dateField; }
			set { this.build_dateField = value; }
		}
		private string last_modifiedField;
		public string last_modified
		{
			get { return this.last_modifiedField; }
			set { this.last_modifiedField = value; }
		}
		private string file_sizeField;
		public string file_size
		{
			get { return this.file_sizeField; }
			set { this.file_sizeField = value; }
		}
	};

}
