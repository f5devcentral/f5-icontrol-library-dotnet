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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.DiskBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemDiskLogicalDisk))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemDiskApplicationVolume))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemDiskApplicationVolumeStatus))]
	public partial class SystemDisk : iControlInterface {
		public SystemDisk() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_array_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	public void add_array_member(
		SystemDiskLogicalDisk [] disks,
		string [] [] serial_numbers
	) {
		this.Invoke("add_array_member", new object [] {
				disks,
				serial_numbers});

	}
	public System.IAsyncResult Beginadd_array_member(SystemDiskLogicalDisk [] disks,string [] [] serial_numbers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_array_member", new object[] {
			disks,
			serial_numbers}, callback, asyncState);
	}
	public void Endadd_array_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_array_member_by_logical_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	public void add_array_member_by_logical_id(
		SystemDiskLogicalDisk [] disks,
		SystemDiskLogicalDisk [] [] names
	) {
		this.Invoke("add_array_member_by_logical_id", new object [] {
				disks,
				names});

	}
	public System.IAsyncResult Beginadd_array_member_by_logical_id(SystemDiskLogicalDisk [] disks,SystemDiskLogicalDisk [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_array_member_by_logical_id", new object[] {
			disks,
			names}, callback, asyncState);
	}
	public void Endadd_array_member_by_logical_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_application_volumes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	public void delete_all_application_volumes(

	) {
		this.Invoke("delete_all_application_volumes", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_application_volumes(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_application_volumes", new object[0], callback, asyncState);
	}
	public void Enddelete_all_application_volumes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_application_volume
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	public void delete_application_volume(
		SystemDiskApplicationVolume [] appvols
	) {
		this.Invoke("delete_application_volume", new object [] {
				appvols});

	}
	public System.IAsyncResult Begindelete_application_volume(SystemDiskApplicationVolume [] appvols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_application_volume", new object[] {
			appvols}, callback, asyncState);
	}
	public void Enddelete_application_volume(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_application_volume_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemDiskApplicationVolume [] get_application_volume_list(

	) {
		object [] results = this.Invoke("get_application_volume_list", new object [0]);
		return ((SystemDiskApplicationVolume [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_volume_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_volume_list", new object[0], callback, asyncState);
	}
	public SystemDiskApplicationVolume [] Endget_application_volume_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemDiskApplicationVolume [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_volume_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemDiskApplicationVolumeStatus [] get_application_volume_status(
		SystemDiskApplicationVolume [] appvols
	) {
		object [] results = this.Invoke("get_application_volume_status", new object [] {
				appvols});
		return ((SystemDiskApplicationVolumeStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_volume_status(SystemDiskApplicationVolume [] appvols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_volume_status", new object[] {
			appvols}, callback, asyncState);
	}
	public SystemDiskApplicationVolumeStatus [] Endget_application_volume_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemDiskApplicationVolumeStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_array_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_array_member(
		SystemDiskLogicalDisk [] disks
	) {
		object [] results = this.Invoke("get_array_member", new object [] {
				disks});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_array_member(SystemDiskLogicalDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_array_member", new object[] {
			disks}, callback, asyncState);
	}
	public string [] [] Endget_array_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_array_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemDiskRAIDStatus [] get_array_status(
		string [] serial_numbers
	) {
		object [] results = this.Invoke("get_array_status", new object [] {
				serial_numbers});
		return ((SystemDiskRAIDStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_array_status(string [] serial_numbers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_array_status", new object[] {
			serial_numbers}, callback, asyncState);
	}
	public SystemDiskRAIDStatus [] Endget_array_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemDiskRAIDStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bay_disk_serial_number
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_bay_disk_serial_number(
		long [] ids
	) {
		object [] results = this.Invoke("get_bay_disk_serial_number", new object [] {
				ids});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_bay_disk_serial_number(long [] ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bay_disk_serial_number", new object[] {
			ids}, callback, asyncState);
	}
	public string [] Endget_bay_disk_serial_number(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
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
	// get_list_of_bays
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_list_of_bays(

	) {
		object [] results = this.Invoke("get_list_of_bays", new object [0]);
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_list_of_bays(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list_of_bays", new object[0], callback, asyncState);
	}
	public long [] Endget_list_of_bays(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list_of_logical_disks
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemDiskLogicalDisk [] get_list_of_logical_disks(

	) {
		object [] results = this.Invoke("get_list_of_logical_disks", new object [0]);
		return ((SystemDiskLogicalDisk [])(results[0]));
	}
	public System.IAsyncResult Beginget_list_of_logical_disks(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list_of_logical_disks", new object[0], callback, asyncState);
	}
	public SystemDiskLogicalDisk [] Endget_list_of_logical_disks(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemDiskLogicalDisk [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_logical_disk_device_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_logical_disk_device_name(
		SystemDiskLogicalDisk [] disks
	) {
		object [] results = this.Invoke("get_logical_disk_device_name", new object [] {
				disks});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_logical_disk_device_name(SystemDiskLogicalDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logical_disk_device_name", new object[] {
			disks}, callback, asyncState);
	}
	public string [] Endget_logical_disk_device_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_logical_disk_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_logical_disk_format(
		SystemDiskLogicalDisk [] disks
	) {
		object [] results = this.Invoke("get_logical_disk_format", new object [] {
				disks});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_logical_disk_format(SystemDiskLogicalDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logical_disk_format", new object[] {
			disks}, callback, asyncState);
	}
	public string [] Endget_logical_disk_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_logical_disk_media
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_logical_disk_media(
		SystemDiskLogicalDisk [] disks
	) {
		object [] results = this.Invoke("get_logical_disk_media", new object [] {
				disks});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_logical_disk_media(SystemDiskLogicalDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logical_disk_media", new object[] {
			disks}, callback, asyncState);
	}
	public string [] Endget_logical_disk_media(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_logical_disk_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_logical_disk_size(
		SystemDiskLogicalDisk [] disks
	) {
		object [] results = this.Invoke("get_logical_disk_size", new object [] {
				disks});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_logical_disk_size(SystemDiskLogicalDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logical_disk_size", new object[] {
			disks}, callback, asyncState);
	}
	public long [] Endget_logical_disk_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_logical_disk_space_free
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_logical_disk_space_free(
		SystemDiskLogicalDisk [] disks
	) {
		object [] results = this.Invoke("get_logical_disk_space_free", new object [] {
				disks});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_logical_disk_space_free(SystemDiskLogicalDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logical_disk_space_free", new object[] {
			disks}, callback, asyncState);
	}
	public long [] Endget_logical_disk_space_free(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_logical_disk_space_in_use
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_logical_disk_space_in_use(
		SystemDiskLogicalDisk [] disks
	) {
		object [] results = this.Invoke("get_logical_disk_space_in_use", new object [] {
				disks});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_logical_disk_space_in_use(SystemDiskLogicalDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logical_disk_space_in_use", new object[] {
			disks}, callback, asyncState);
	}
	public long [] Endget_logical_disk_space_in_use(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_logical_disk_space_reserved
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_logical_disk_space_reserved(
		SystemDiskLogicalDisk [] disks
	) {
		object [] results = this.Invoke("get_logical_disk_space_reserved", new object [] {
				disks});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_logical_disk_space_reserved(SystemDiskLogicalDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logical_disk_space_reserved", new object[] {
			disks}, callback, asyncState);
	}
	public long [] Endget_logical_disk_space_reserved(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_logical_disk_user_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemDiskLogicalDiskUserMode [] get_logical_disk_user_mode(
		SystemDiskLogicalDisk [] disks
	) {
		object [] results = this.Invoke("get_logical_disk_user_mode", new object [] {
				disks});
		return ((SystemDiskLogicalDiskUserMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_logical_disk_user_mode(SystemDiskLogicalDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logical_disk_user_mode", new object[] {
			disks}, callback, asyncState);
	}
	public SystemDiskLogicalDiskUserMode [] Endget_logical_disk_user_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemDiskLogicalDiskUserMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_name(
		string [] serial_numbers
	) {
		object [] results = this.Invoke("get_name", new object [] {
				serial_numbers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_name(string [] serial_numbers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_name", new object[] {
			serial_numbers}, callback, asyncState);
	}
	public string [] Endget_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slot_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_slot_id(
		string [] serial_numbers
	) {
		object [] results = this.Invoke("get_slot_id", new object [] {
				serial_numbers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_slot_id(string [] serial_numbers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slot_id", new object[] {
			serial_numbers}, callback, asyncState);
	}
	public long [] Endget_slot_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
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
	// is_array_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_array_member(
		string [] serial_numbers
	) {
		object [] results = this.Invoke("is_array_member", new object [] {
				serial_numbers});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_array_member(string [] serial_numbers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_array_member", new object[] {
			serial_numbers}, callback, asyncState);
	}
	public bool [] Endis_array_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_raid_capable
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool is_raid_capable(

	) {
		object [] results = this.Invoke("is_raid_capable", new object [0]);
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginis_raid_capable(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_raid_capable", new object[0], callback, asyncState);
	}
	public bool Endis_raid_capable(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_array_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	public void remove_array_member(
		SystemDiskLogicalDisk [] disks,
		string [] [] serial_numbers
	) {
		this.Invoke("remove_array_member", new object [] {
				disks,
				serial_numbers});

	}
	public System.IAsyncResult Beginremove_array_member(SystemDiskLogicalDisk [] disks,string [] [] serial_numbers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_array_member", new object[] {
			disks,
			serial_numbers}, callback, asyncState);
	}
	public void Endremove_array_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_array_member_by_logical_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	public void remove_array_member_by_logical_id(
		SystemDiskLogicalDisk [] disks,
		SystemDiskLogicalDisk [] [] names
	) {
		this.Invoke("remove_array_member_by_logical_id", new object [] {
				disks,
				names});

	}
	public System.IAsyncResult Beginremove_array_member_by_logical_id(SystemDiskLogicalDisk [] disks,SystemDiskLogicalDisk [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_array_member_by_logical_id", new object[] {
			disks,
			names}, callback, asyncState);
	}
	public void Endremove_array_member_by_logical_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_logical_disk_space_reserved
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	public void set_logical_disk_space_reserved(
		SystemDiskLogicalDisk [] disks,
		long [] values
	) {
		this.Invoke("set_logical_disk_space_reserved", new object [] {
				disks,
				values});

	}
	public System.IAsyncResult Beginset_logical_disk_space_reserved(SystemDiskLogicalDisk [] disks,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_logical_disk_space_reserved", new object[] {
			disks,
			values}, callback, asyncState);
	}
	public void Endset_logical_disk_space_reserved(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_logical_disk_user_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Disk", 
		RequestNamespace="urn:iControl:System/Disk", ResponseNamespace="urn:iControl:System/Disk")]
	public void set_logical_disk_user_mode(
		SystemDiskLogicalDisk [] disks,
		SystemDiskLogicalDiskUserMode [] modes
	) {
		this.Invoke("set_logical_disk_user_mode", new object [] {
				disks,
				modes});

	}
	public System.IAsyncResult Beginset_logical_disk_user_mode(SystemDiskLogicalDisk [] disks,SystemDiskLogicalDiskUserMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_logical_disk_user_mode", new object[] {
			disks,
			modes}, callback, asyncState);
	}
	public void Endset_logical_disk_user_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Disk.APPVOwner", Namespace = "urn:iControl")]
	public enum SystemDiskAPPVOwner
	{
		APPV_OWNER_UNKNOWN,
		APPV_OWNER_UNASSIGNED,
		APPV_OWNER_DATASTOR,
		APPV_OWNER_MYSQL,
		APPV_OWNER_VCMP,
		APPV_OWNER_AVR,
		APPV_OWNER_AFM,
		APPV_OWNER_SWG,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Disk.APPVPreservabilityMode", Namespace = "urn:iControl")]
	public enum SystemDiskAPPVPreservabilityMode
	{
		APPV_MODE_UNKNOWN,
		APPV_MODE_DISCARDABLE,
		APPV_MODE_PRECIOUS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Disk.LogicalDiskUserMode", Namespace = "urn:iControl")]
	public enum SystemDiskLogicalDiskUserMode
	{
		LD_USER_MODE_UNKNOWN,
		LD_USER_MODE_NONE,
		LD_USER_MODE_MIXED,
		LD_USER_MODE_DATASTOR,
		LD_USER_MODE_CONTROL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Disk.RAIDStatus", Namespace = "urn:iControl")]
	public enum SystemDiskRAIDStatus
	{
		RAID_STATUS_UNDEFINED,
		RAID_STATUS_SYNCHRONIZED,
		RAID_STATUS_REPLICATING,
		RAID_STATUS_MISSING,
		RAID_STATUS_FAILED,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Disk.ApplicationVolume", Namespace = "urn:iControl")]
	public partial class SystemDiskApplicationVolume
	{
		private long slot_idField;
		public long slot_id
		{
			get { return this.slot_idField; }
			set { this.slot_idField = value; }
		}
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Disk.ApplicationVolumeStatus", Namespace = "urn:iControl")]
	public partial class SystemDiskApplicationVolumeStatus
	{
		private string logical_diskField;
		public string logical_disk
		{
			get { return this.logical_diskField; }
			set { this.logical_diskField = value; }
		}
		private string visibilityField;
		public string visibility
		{
			get { return this.visibilityField; }
			set { this.visibilityField = value; }
		}
		private long sizeField;
		public long size
		{
			get { return this.sizeField; }
			set { this.sizeField = value; }
		}
		private SystemDiskAPPVOwner ownerField;
		public SystemDiskAPPVOwner owner
		{
			get { return this.ownerField; }
			set { this.ownerField = value; }
		}
		private CommonEnabledState resizeableField;
		public CommonEnabledState resizeable
		{
			get { return this.resizeableField; }
			set { this.resizeableField = value; }
		}
		private SystemDiskAPPVPreservabilityMode preservabilityField;
		public SystemDiskAPPVPreservabilityMode preservability
		{
			get { return this.preservabilityField; }
			set { this.preservabilityField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Disk.LogicalDisk", Namespace = "urn:iControl")]
	public partial class SystemDiskLogicalDisk
	{
		private long slot_idField;
		public long slot_id
		{
			get { return this.slot_idField; }
			set { this.slot_idField = value; }
		}
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
	};

}
