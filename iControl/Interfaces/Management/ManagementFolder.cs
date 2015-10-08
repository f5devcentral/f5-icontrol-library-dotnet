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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.FolderBinding", Namespace="urn:iControl")]
	public partial class ManagementFolder : iControlInterface {
		public ManagementFolder() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	public void create(
		string [] folders
	) {
		this.Invoke("create", new object [] {
				folders});

	}
	public System.IAsyncResult Begincreate(string [] folders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			folders}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_folders
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	public void delete_all_folders(

	) {
		this.Invoke("delete_all_folders", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_folders(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_folders", new object[0], callback, asyncState);
	}
	public void Enddelete_all_folders(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_folder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	public void delete_folder(
		string [] folders
	) {
		this.Invoke("delete_folder", new object [] {
				folders});

	}
	public System.IAsyncResult Begindelete_folder(string [] folders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_folder", new object[] {
			folders}, callback, asyncState);
	}
	public void Enddelete_folder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] folders
	) {
		object [] results = this.Invoke("get_description", new object [] {
				folders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] folders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			folders}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_device_group(
		string [] folders
	) {
		object [] results = this.Invoke("get_device_group", new object [] {
				folders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_device_group(string [] folders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_group", new object[] {
			folders}, callback, asyncState);
	}
	public string [] Endget_device_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
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
	// get_no_reference_check_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_no_reference_check_state(
		string [] folders
	) {
		object [] results = this.Invoke("get_no_reference_check_state", new object [] {
				folders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_no_reference_check_state(string [] folders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_no_reference_check_state", new object[] {
			folders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_no_reference_check_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_traffic_group(
		string [] folders
	) {
		object [] results = this.Invoke("get_traffic_group", new object [] {
				folders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_group(string [] folders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_group", new object[] {
			folders}, callback, asyncState);
	}
	public string [] Endget_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
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
	// is_device_group_inherited
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_device_group_inherited(
		string [] folders
	) {
		object [] results = this.Invoke("is_device_group_inherited", new object [] {
				folders});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_device_group_inherited(string [] folders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_device_group_inherited", new object[] {
			folders}, callback, asyncState);
	}
	public bool [] Endis_device_group_inherited(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_traffic_group_inherited
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_traffic_group_inherited(
		string [] folders
	) {
		object [] results = this.Invoke("is_traffic_group_inherited", new object [] {
				folders});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_traffic_group_inherited(string [] folders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_traffic_group_inherited", new object[] {
			folders}, callback, asyncState);
	}
	public bool [] Endis_traffic_group_inherited(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	public void set_description(
		string [] folders,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				folders,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] folders,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			folders,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_device_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	public void set_device_group(
		string [] folders,
		string [] groups
	) {
		this.Invoke("set_device_group", new object [] {
				folders,
				groups});

	}
	public System.IAsyncResult Beginset_device_group(string [] folders,string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_device_group", new object[] {
			folders,
			groups}, callback, asyncState);
	}
	public void Endset_device_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_no_reference_check_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	public void set_no_reference_check_state(
		string [] folders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_no_reference_check_state", new object [] {
				folders,
				states});

	}
	public System.IAsyncResult Beginset_no_reference_check_state(string [] folders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_no_reference_check_state", new object[] {
			folders,
			states}, callback, asyncState);
	}
	public void Endset_no_reference_check_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Folder", 
		RequestNamespace="urn:iControl:Management/Folder", ResponseNamespace="urn:iControl:Management/Folder")]
	public void set_traffic_group(
		string [] folders,
		string [] groups
	) {
		this.Invoke("set_traffic_group", new object [] {
				folders,
				groups});

	}
	public System.IAsyncResult Beginset_traffic_group(string [] folders,string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_group", new object[] {
			folders,
			groups}, callback, asyncState);
	}
	public void Endset_traffic_group(System.IAsyncResult asyncResult) {
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
