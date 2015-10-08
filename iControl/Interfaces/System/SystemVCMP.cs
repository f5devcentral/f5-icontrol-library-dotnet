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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.VCMPBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonULong64))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonIPNetmask))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemVCMPVirtualDisk))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemVCMPVCMPStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemVCMPVirtualDiskStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemVCMPVCMPCompletionStatus))]
	public partial class SystemVCMP : iControlInterface {
		public SystemVCMP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_capability
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void add_capability(
		string [] guests,
		SystemVCMPVCMPCapabilityID [] [] capabilities,
		CommonULong64 [] [] values
	) {
		this.Invoke("add_capability", new object [] {
				guests,
				capabilities,
				values});

	}
	public System.IAsyncResult Beginadd_capability(string [] guests,SystemVCMPVCMPCapabilityID [] [] capabilities,CommonULong64 [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_capability", new object[] {
			guests,
			capabilities,
			values}, callback, asyncState);
	}
	public void Endadd_capability(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void add_vlan(
		string [] guests,
		string [] [] vlans
	) {
		this.Invoke("add_vlan", new object [] {
				guests,
				vlans});

	}
	public System.IAsyncResult Beginadd_vlan(string [] guests,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_vlan", new object[] {
			guests,
			vlans}, callback, asyncState);
	}
	public void Endadd_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void create(
		string [] guests,
		string [] hostnames,
		string [] images,
		CommonIPNetmask [] addresses,
		string [] gateways,
		string [] [] vlans
	) {
		this.Invoke("create", new object [] {
				guests,
				hostnames,
				images,
				addresses,
				gateways,
				vlans});

	}
	public System.IAsyncResult Begincreate(string [] guests,string [] hostnames,string [] images,CommonIPNetmask [] addresses,string [] gateways,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			guests,
			hostnames,
			images,
			addresses,
			gateways,
			vlans}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_guests
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void delete_all_guests(

	) {
		this.Invoke("delete_all_guests", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_guests(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_guests", new object[0], callback, asyncState);
	}
	public void Enddelete_all_guests(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_virtual_disks
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void delete_all_virtual_disks(

	) {
		this.Invoke("delete_all_virtual_disks", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_virtual_disks(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_virtual_disks", new object[0], callback, asyncState);
	}
	public void Enddelete_all_virtual_disks(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_guest
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void delete_guest(
		string [] guests
	) {
		this.Invoke("delete_guest", new object [] {
				guests});

	}
	public System.IAsyncResult Begindelete_guest(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_guest", new object[] {
			guests}, callback, asyncState);
	}
	public void Enddelete_guest(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_virtual_disk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void delete_virtual_disk(
		SystemVCMPVirtualDisk [] disks
	) {
		this.Invoke("delete_virtual_disk", new object [] {
				disks});

	}
	public System.IAsyncResult Begindelete_virtual_disk(SystemVCMPVirtualDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_virtual_disk", new object[] {
			disks}, callback, asyncState);
	}
	public void Enddelete_virtual_disk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemVCMPVCMPStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((SystemVCMPVCMPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public SystemVCMPVCMPStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemVCMPVCMPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_virtual_disk_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemVCMPVirtualDiskStatistics get_all_virtual_disk_statistics(

	) {
		object [] results = this.Invoke("get_all_virtual_disk_statistics", new object [0]);
		return ((SystemVCMPVirtualDiskStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_virtual_disk_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_virtual_disk_statistics", new object[0], callback, asyncState);
	}
	public SystemVCMPVirtualDiskStatistics Endget_all_virtual_disk_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemVCMPVirtualDiskStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_capability
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemVCMPVCMPCapabilityID [] [] get_capability(
		string [] guests
	) {
		object [] results = this.Invoke("get_capability", new object [] {
				guests});
		return ((SystemVCMPVCMPCapabilityID [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_capability(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_capability", new object[] {
			guests}, callback, asyncState);
	}
	public SystemVCMPVCMPCapabilityID [] [] Endget_capability(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemVCMPVCMPCapabilityID [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_capability_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] [] get_capability_value(
		string [] guests,
		SystemVCMPVCMPCapabilityID [] [] capabilities
	) {
		object [] results = this.Invoke("get_capability_value", new object [] {
				guests,
				capabilities});
		return ((CommonULong64 [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_capability_value(string [] guests,SystemVCMPVCMPCapabilityID [] [] capabilities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_capability_value", new object[] {
			guests,
			capabilities}, callback, asyncState);
	}
	public CommonULong64 [] [] Endget_capability_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_completion_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemVCMPVCMPCompletionStatus [] [] get_completion_status(
		string [] guests
	) {
		object [] results = this.Invoke("get_completion_status", new object [] {
				guests});
		return ((SystemVCMPVCMPCompletionStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_completion_status(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_completion_status", new object[] {
			guests}, callback, asyncState);
	}
	public SystemVCMPVCMPCompletionStatus [] [] Endget_completion_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemVCMPVCMPCompletionStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_guest_allowed_slots
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] [] get_guest_allowed_slots(
		string [] guests
	) {
		object [] results = this.Invoke("get_guest_allowed_slots", new object [] {
				guests});
		return ((short [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_guest_allowed_slots(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_guest_allowed_slots", new object[] {
			guests}, callback, asyncState);
	}
	public short [] [] Endget_guest_allowed_slots(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_guest_assigned_slots
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] [] get_guest_assigned_slots(
		string [] guests
	) {
		object [] results = this.Invoke("get_guest_assigned_slots", new object [] {
				guests});
		return ((short [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_guest_assigned_slots(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_guest_assigned_slots", new object[] {
			guests}, callback, asyncState);
	}
	public short [] [] Endget_guest_assigned_slots(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_guest_cores_per_slot
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_guest_cores_per_slot(
		string [] guests
	) {
		object [] results = this.Invoke("get_guest_cores_per_slot", new object [] {
				guests});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_guest_cores_per_slot(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_guest_cores_per_slot", new object[] {
			guests}, callback, asyncState);
	}
	public short [] Endget_guest_cores_per_slot(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_guest_min_slots
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_guest_min_slots(
		string [] guests
	) {
		object [] results = this.Invoke("get_guest_min_slots", new object [] {
				guests});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_guest_min_slots(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_guest_min_slots", new object[] {
			guests}, callback, asyncState);
	}
	public short [] Endget_guest_min_slots(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_guest_slots
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_guest_slots(
		string [] guests
	) {
		object [] results = this.Invoke("get_guest_slots", new object [] {
				guests});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_guest_slots(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_guest_slots", new object[] {
			guests}, callback, asyncState);
	}
	public short [] Endget_guest_slots(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_guest_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemVCMPVCMPGuestState [] get_guest_state(
		string [] guests
	) {
		object [] results = this.Invoke("get_guest_state", new object [] {
				guests});
		return ((SystemVCMPVCMPGuestState [])(results[0]));
	}
	public System.IAsyncResult Beginget_guest_state(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_guest_state", new object[] {
			guests}, callback, asyncState);
	}
	public SystemVCMPVCMPGuestState [] Endget_guest_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemVCMPVCMPGuestState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hostname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_hostname(
		string [] guests
	) {
		object [] results = this.Invoke("get_hostname", new object [] {
				guests});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_hostname(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hostname", new object[] {
			guests}, callback, asyncState);
	}
	public string [] Endget_hostname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_initial_image
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_initial_image(
		string [] guests
	) {
		object [] results = this.Invoke("get_initial_image", new object [] {
				guests});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_initial_image(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_initial_image", new object[] {
			guests}, callback, asyncState);
	}
	public string [] Endget_initial_image(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
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
	// get_management_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPNetmask [] get_management_address(
		string [] guests
	) {
		object [] results = this.Invoke("get_management_address", new object [] {
				guests});
		return ((CommonIPNetmask [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_address(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_address", new object[] {
			guests}, callback, asyncState);
	}
	public CommonIPNetmask [] Endget_management_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPNetmask [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_gateway
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_management_gateway(
		string [] guests
	) {
		object [] results = this.Invoke("get_management_gateway", new object [] {
				guests});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_gateway(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_gateway", new object[] {
			guests}, callback, asyncState);
	}
	public string [] Endget_management_gateway(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemVCMPVCMPNetworkMode [] get_network_mode(
		string [] guests
	) {
		object [] results = this.Invoke("get_network_mode", new object [] {
				guests});
		return ((SystemVCMPVCMPNetworkMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_mode(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_mode", new object[] {
			guests}, callback, asyncState);
	}
	public SystemVCMPVCMPNetworkMode [] Endget_network_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemVCMPVCMPNetworkMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slot_allocation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemVCMPVCMPSlotAllocation [] get_slot_allocation(
		string [] guests
	) {
		object [] results = this.Invoke("get_slot_allocation", new object [] {
				guests});
		return ((SystemVCMPVCMPSlotAllocation [])(results[0]));
	}
	public System.IAsyncResult Beginget_slot_allocation(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slot_allocation", new object[] {
			guests}, callback, asyncState);
	}
	public SystemVCMPVCMPSlotAllocation [] Endget_slot_allocation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemVCMPVCMPSlotAllocation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemVCMPVCMPStatistics get_statistics(
		string [] guests
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				guests});
		return ((SystemVCMPVCMPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			guests}, callback, asyncState);
	}
	public SystemVCMPVCMPStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemVCMPVCMPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
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
	// get_virtual_disk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_virtual_disk(
		string [] guests
	) {
		object [] results = this.Invoke("get_virtual_disk", new object [] {
				guests});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_virtual_disk(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_virtual_disk", new object[] {
			guests}, callback, asyncState);
	}
	public string [] Endget_virtual_disk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_virtual_disk_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemVCMPVirtualDisk [] get_virtual_disk_list(

	) {
		object [] results = this.Invoke("get_virtual_disk_list", new object [0]);
		return ((SystemVCMPVirtualDisk [])(results[0]));
	}
	public System.IAsyncResult Beginget_virtual_disk_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_virtual_disk_list", new object[0], callback, asyncState);
	}
	public SystemVCMPVirtualDisk [] Endget_virtual_disk_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemVCMPVirtualDisk [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_virtual_disk_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemVCMPVirtualDiskStatistics get_virtual_disk_statistics(
		SystemVCMPVirtualDisk [] disks
	) {
		object [] results = this.Invoke("get_virtual_disk_statistics", new object [] {
				disks});
		return ((SystemVCMPVirtualDiskStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_virtual_disk_statistics(SystemVCMPVirtualDisk [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_virtual_disk_statistics", new object[] {
			disks}, callback, asyncState);
	}
	public SystemVCMPVirtualDiskStatistics Endget_virtual_disk_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemVCMPVirtualDiskStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_vlan(
		string [] guests
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				guests});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			guests}, callback, asyncState);
	}
	public string [] [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_capabilities
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void remove_all_capabilities(
		string [] guests
	) {
		this.Invoke("remove_all_capabilities", new object [] {
				guests});

	}
	public System.IAsyncResult Beginremove_all_capabilities(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_capabilities", new object[] {
			guests}, callback, asyncState);
	}
	public void Endremove_all_capabilities(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_vlans
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void remove_all_vlans(
		string [] guests
	) {
		this.Invoke("remove_all_vlans", new object [] {
				guests});

	}
	public System.IAsyncResult Beginremove_all_vlans(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_vlans", new object[] {
			guests}, callback, asyncState);
	}
	public void Endremove_all_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_capability
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void remove_capability(
		string [] guests,
		SystemVCMPVCMPCapabilityID [] [] capabilities
	) {
		this.Invoke("remove_capability", new object [] {
				guests,
				capabilities});

	}
	public System.IAsyncResult Beginremove_capability(string [] guests,SystemVCMPVCMPCapabilityID [] [] capabilities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_capability", new object[] {
			guests,
			capabilities}, callback, asyncState);
	}
	public void Endremove_capability(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void remove_vlan(
		string [] guests,
		string [] [] vlans
	) {
		this.Invoke("remove_vlan", new object [] {
				guests,
				vlans});

	}
	public System.IAsyncResult Beginremove_vlan(string [] guests,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_vlan", new object[] {
			guests,
			vlans}, callback, asyncState);
	}
	public void Endremove_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void reset_statistics(
		string [] guests
	) {
		this.Invoke("reset_statistics", new object [] {
				guests});

	}
	public System.IAsyncResult Beginreset_statistics(string [] guests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			guests}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_capability_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_capability_value(
		string [] guests,
		SystemVCMPVCMPCapabilityID [] [] capabilities,
		CommonULong64 [] [] values
	) {
		this.Invoke("set_capability_value", new object [] {
				guests,
				capabilities,
				values});

	}
	public System.IAsyncResult Beginset_capability_value(string [] guests,SystemVCMPVCMPCapabilityID [] [] capabilities,CommonULong64 [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_capability_value", new object[] {
			guests,
			capabilities,
			values}, callback, asyncState);
	}
	public void Endset_capability_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_guest_allowed_slots
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_guest_allowed_slots(
		string [] guests,
		short [] [] allowed_slots
	) {
		this.Invoke("set_guest_allowed_slots", new object [] {
				guests,
				allowed_slots});

	}
	public System.IAsyncResult Beginset_guest_allowed_slots(string [] guests,short [] [] allowed_slots, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_guest_allowed_slots", new object[] {
			guests,
			allowed_slots}, callback, asyncState);
	}
	public void Endset_guest_allowed_slots(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_guest_cores_per_slot
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_guest_cores_per_slot(
		string [] guests,
		short [] cores_per_slots
	) {
		this.Invoke("set_guest_cores_per_slot", new object [] {
				guests,
				cores_per_slots});

	}
	public System.IAsyncResult Beginset_guest_cores_per_slot(string [] guests,short [] cores_per_slots, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_guest_cores_per_slot", new object[] {
			guests,
			cores_per_slots}, callback, asyncState);
	}
	public void Endset_guest_cores_per_slot(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_guest_min_slots
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_guest_min_slots(
		string [] guests,
		short [] min_slots
	) {
		this.Invoke("set_guest_min_slots", new object [] {
				guests,
				min_slots});

	}
	public System.IAsyncResult Beginset_guest_min_slots(string [] guests,short [] min_slots, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_guest_min_slots", new object[] {
			guests,
			min_slots}, callback, asyncState);
	}
	public void Endset_guest_min_slots(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_guest_slots
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_guest_slots(
		string [] guests,
		short [] slots
	) {
		this.Invoke("set_guest_slots", new object [] {
				guests,
				slots});

	}
	public System.IAsyncResult Beginset_guest_slots(string [] guests,short [] slots, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_guest_slots", new object[] {
			guests,
			slots}, callback, asyncState);
	}
	public void Endset_guest_slots(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_guest_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_guest_state(
		string [] guests,
		SystemVCMPVCMPGuestState [] states
	) {
		this.Invoke("set_guest_state", new object [] {
				guests,
				states});

	}
	public System.IAsyncResult Beginset_guest_state(string [] guests,SystemVCMPVCMPGuestState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_guest_state", new object[] {
			guests,
			states}, callback, asyncState);
	}
	public void Endset_guest_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_hostname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_hostname(
		string [] guests,
		string [] hostnames
	) {
		this.Invoke("set_hostname", new object [] {
				guests,
				hostnames});

	}
	public System.IAsyncResult Beginset_hostname(string [] guests,string [] hostnames, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hostname", new object[] {
			guests,
			hostnames}, callback, asyncState);
	}
	public void Endset_hostname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_initial_image
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_initial_image(
		string [] guests,
		string [] images
	) {
		this.Invoke("set_initial_image", new object [] {
				guests,
				images});

	}
	public System.IAsyncResult Beginset_initial_image(string [] guests,string [] images, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_initial_image", new object[] {
			guests,
			images}, callback, asyncState);
	}
	public void Endset_initial_image(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_management_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_management_address(
		string [] guests,
		CommonIPNetmask [] addresses
	) {
		this.Invoke("set_management_address", new object [] {
				guests,
				addresses});

	}
	public System.IAsyncResult Beginset_management_address(string [] guests,CommonIPNetmask [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_management_address", new object[] {
			guests,
			addresses}, callback, asyncState);
	}
	public void Endset_management_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_management_gateway
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_management_gateway(
		string [] guests,
		string [] gateways
	) {
		this.Invoke("set_management_gateway", new object [] {
				guests,
				gateways});

	}
	public System.IAsyncResult Beginset_management_gateway(string [] guests,string [] gateways, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_management_gateway", new object[] {
			guests,
			gateways}, callback, asyncState);
	}
	public void Endset_management_gateway(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_network_mode(
		string [] guests,
		SystemVCMPVCMPNetworkMode [] modes
	) {
		this.Invoke("set_network_mode", new object [] {
				guests,
				modes});

	}
	public System.IAsyncResult Beginset_network_mode(string [] guests,SystemVCMPVCMPNetworkMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_mode", new object[] {
			guests,
			modes}, callback, asyncState);
	}
	public void Endset_network_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_slot_allocation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_slot_allocation(
		string [] guests,
		SystemVCMPVCMPSlotAllocation [] allocs
	) {
		this.Invoke("set_slot_allocation", new object [] {
				guests,
				allocs});

	}
	public System.IAsyncResult Beginset_slot_allocation(string [] guests,SystemVCMPVCMPSlotAllocation [] allocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_slot_allocation", new object[] {
			guests,
			allocs}, callback, asyncState);
	}
	public void Endset_slot_allocation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_virtual_disk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/VCMP", 
		RequestNamespace="urn:iControl:System/VCMP", ResponseNamespace="urn:iControl:System/VCMP")]
	public void set_virtual_disk(
		string [] guests,
		string [] disks
	) {
		this.Invoke("set_virtual_disk", new object [] {
				guests,
				disks});

	}
	public System.IAsyncResult Beginset_virtual_disk(string [] guests,string [] disks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_virtual_disk", new object[] {
			guests,
			disks}, callback, asyncState);
	}
	public void Endset_virtual_disk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VCMPCapabilityID", Namespace = "urn:iControl")]
	public enum SystemVCMPVCMPCapabilityID
	{
		VCMP_CAPABILITY_UNKNOWN,
		VCMP_CAPABILITY_APPLIANCE_MODE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VCMPGuestState", Namespace = "urn:iControl")]
	public enum SystemVCMPVCMPGuestState
	{
		VCMP_GUEST_STATE_UNKNOWN,
		VCMP_GUEST_STATE_CONFIGURED,
		VCMP_GUEST_STATE_PROVISIONED,
		VCMP_GUEST_STATE_DEPLOYED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VCMPNetworkMode", Namespace = "urn:iControl")]
	public enum SystemVCMPVCMPNetworkMode
	{
		VCMP_NETWORK_MODE_UNKNOWN,
		VCMP_NETWORK_MODE_BRIDGED,
		VCMP_NETWORK_MODE_ISOLATED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VCMPOperatingSystem", Namespace = "urn:iControl")]
	public enum SystemVCMPVCMPOperatingSystem
	{
		VCMP_OPERATING_SYSTEM_UNKNOWN,
		VCMP_OPERATING_SYSTEM_TMOS,
		VCMP_OPERATING_SYSTEM_LINUX,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VCMPSlotAllocation", Namespace = "urn:iControl")]
	public enum SystemVCMPVCMPSlotAllocation
	{
		VCMP_SLOT_ALLOCATION_UNKNOWN,
		VCMP_SLOT_ALLOCATION_SINGLE,
		VCMP_SLOT_ALLOCATION_ALL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VCMPStatus", Namespace = "urn:iControl")]
	public enum SystemVCMPVCMPStatus
	{
		VCMP_STATUS_UNKNOWN,
		VCMP_STATUS_CREATED,
		VCMP_STATUS_STOPPED,
		VCMP_STATUS_WAIT_STARTING,
		VCMP_STATUS_STARTING,
		VCMP_STATUS_RUNNING,
		VCMP_STATUS_STOPPING,
		VCMP_STATUS_INSTALLING,
		VCMP_STATUS_DELETED,
		VCMP_STATUS_FAILED,
		VCMP_STATUS_INACTIVE,
		VCMP_STATUS_ACQUIRE_VDISK,
		VCMP_STATUS_WAIT_INSTALL,
		VCMP_STATUS_WAIT_MIGRATE,
		VCMP_STATUS_MIGRATE_VDISK,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VirtualDiskStatus", Namespace = "urn:iControl")]
	public enum SystemVCMPVirtualDiskStatus
	{
		VDISK_STATUS_UNKNOWN,
		VDISK_STATUS_CREATED,
		VDISK_STATUS_INSTALLING,
		VDISK_STATUS_MIGRATING,
		VDISK_STATUS_READY,
		VDISK_STATUS_IN_USE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VCMPCompletionStatus", Namespace = "urn:iControl")]
	public partial class SystemVCMPVCMPCompletionStatus
	{
		private long slot_idField;
		public long slot_id
		{
			get { return this.slot_idField; }
			set { this.slot_idField = value; }
		}
		private SystemVCMPVCMPGuestState requested_stateField;
		public SystemVCMPVCMPGuestState requested_state
		{
			get { return this.requested_stateField; }
			set { this.requested_stateField = value; }
		}
		private bool request_completeField;
		public bool request_complete
		{
			get { return this.request_completeField; }
			set { this.request_completeField = value; }
		}
		private SystemVCMPVCMPStatus statusField;
		public SystemVCMPVCMPStatus status
		{
			get { return this.statusField; }
			set { this.statusField = value; }
		}
		private string commentField;
		public string comment
		{
			get { return this.commentField; }
			set { this.commentField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VCMPStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemVCMPVCMPStatisticEntry
	{
		private string guestField;
		public string guest
		{
			get { return this.guestField; }
			set { this.guestField = value; }
		}
		private long vcmp_idField;
		public long vcmp_id
		{
			get { return this.vcmp_idField; }
			set { this.vcmp_idField = value; }
		}
		private long slot_idField;
		public long slot_id
		{
			get { return this.slot_idField; }
			set { this.slot_idField = value; }
		}
		private long pidField;
		public long pid
		{
			get { return this.pidField; }
			set { this.pidField = value; }
		}
		private string interface_namesField;
		public string interface_names
		{
			get { return this.interface_namesField; }
			set { this.interface_namesField = value; }
		}
		private string core_namesField;
		public string core_names
		{
			get { return this.core_namesField; }
			set { this.core_namesField = value; }
		}
		private string base_macField;
		public string base_mac
		{
			get { return this.base_macField; }
			set { this.base_macField = value; }
		}
		private long mac_sizeField;
		public long mac_size
		{
			get { return this.mac_sizeField; }
			set { this.mac_sizeField = value; }
		}
		private long coresField;
		public long cores
		{
			get { return this.coresField; }
			set { this.coresField = value; }
		}
		private string vdiskField;
		public string vdisk
		{
			get { return this.vdiskField; }
			set { this.vdiskField = value; }
		}
		private long startsField;
		public long starts
		{
			get { return this.startsField; }
			set { this.startsField = value; }
		}
		private long retriesField;
		public long retries
		{
			get { return this.retriesField; }
			set { this.retriesField = value; }
		}
		private long cpu_usage_recentField;
		public long cpu_usage_recent
		{
			get { return this.cpu_usage_recentField; }
			set { this.cpu_usage_recentField = value; }
		}
		private long cpu_usage_1minField;
		public long cpu_usage_1min
		{
			get { return this.cpu_usage_1minField; }
			set { this.cpu_usage_1minField = value; }
		}
		private long cpu_usage_5minsField;
		public long cpu_usage_5mins
		{
			get { return this.cpu_usage_5minsField; }
			set { this.cpu_usage_5minsField = value; }
		}
		private long update_timeField;
		public long update_time
		{
			get { return this.update_timeField; }
			set { this.update_timeField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VCMPStatistics", Namespace = "urn:iControl")]
	public partial class SystemVCMPVCMPStatistics
	{
		private SystemVCMPVCMPStatisticEntry [] statisticsField;
		public SystemVCMPVCMPStatisticEntry [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private CommonTimeStamp time_stampField;
		public CommonTimeStamp time_stamp
		{
			get { return this.time_stampField; }
			set { this.time_stampField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VirtualDisk", Namespace = "urn:iControl")]
	public partial class SystemVCMPVirtualDisk
	{
		private long slot_idField;
		public long slot_id
		{
			get { return this.slot_idField; }
			set { this.slot_idField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VirtualDiskStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemVCMPVirtualDiskStatisticEntry
	{
		private SystemVCMPVirtualDisk diskField;
		public SystemVCMPVirtualDisk disk
		{
			get { return this.diskField; }
			set { this.diskField = value; }
		}
		private SystemVCMPVCMPOperatingSystem osField;
		public SystemVCMPVCMPOperatingSystem os
		{
			get { return this.osField; }
			set { this.osField = value; }
		}
		private SystemVCMPVirtualDiskStatus statusField;
		public SystemVCMPVirtualDiskStatus status
		{
			get { return this.statusField; }
			set { this.statusField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VCMP.VirtualDiskStatistics", Namespace = "urn:iControl")]
	public partial class SystemVCMPVirtualDiskStatistics
	{
		private SystemVCMPVirtualDiskStatisticEntry [] statisticsField;
		public SystemVCMPVirtualDiskStatisticEntry [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private CommonTimeStamp time_stampField;
		public CommonTimeStamp time_stamp
		{
			get { return this.time_stampField; }
			set { this.time_stampField = value; }
		}
	};

}
