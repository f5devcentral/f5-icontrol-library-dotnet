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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.ZoneBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementZoneInfo))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementViewZone))]
	public partial class ManagementZone : iControlInterface {
		public ManagementZone() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_zone_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	public void add_zone_file(
		ManagementZoneInfo [] zone_records,
		string [] src_file_names,
		bool [] sync_ptrs
	) {
		this.Invoke("add_zone_file", new object [] {
				zone_records,
				src_file_names,
				sync_ptrs});

	}
	public System.IAsyncResult Beginadd_zone_file(ManagementZoneInfo [] zone_records,string [] src_file_names,bool [] sync_ptrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_zone_file", new object[] {
			zone_records,
			src_file_names,
			sync_ptrs}, callback, asyncState);
	}
	public void Endadd_zone_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_zone_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	public void add_zone_option(
		ManagementZoneInfo [] zones
	) {
		this.Invoke("add_zone_option", new object [] {
				zones});

	}
	public System.IAsyncResult Beginadd_zone_option(ManagementZoneInfo [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_zone_option", new object[] {
			zones}, callback, asyncState);
	}
	public void Endadd_zone_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_zone_text
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	public void add_zone_text(
		ManagementZoneInfo [] zone_records,
		string [] [] text,
		bool [] sync_ptrs
	) {
		this.Invoke("add_zone_text", new object [] {
				zone_records,
				text,
				sync_ptrs});

	}
	public System.IAsyncResult Beginadd_zone_text(ManagementZoneInfo [] zone_records,string [] [] text,bool [] sync_ptrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_zone_text", new object[] {
			zone_records,
			text,
			sync_ptrs}, callback, asyncState);
	}
	public void Endadd_zone_text(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	public void delete_zone(
		ManagementViewZone [] view_zones
	) {
		this.Invoke("delete_zone", new object [] {
				view_zones});

	}
	public System.IAsyncResult Begindelete_zone(ManagementViewZone [] view_zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_zone", new object[] {
			view_zones}, callback, asyncState);
	}
	public void Enddelete_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_zone_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	public void delete_zone_option(
		ManagementZoneInfo [] zones
	) {
		this.Invoke("delete_zone_option", new object [] {
				zones});

	}
	public System.IAsyncResult Begindelete_zone_option(ManagementZoneInfo [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_zone_option", new object[] {
			zones}, callback, asyncState);
	}
	public void Enddelete_zone_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
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
	// get_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementZoneInfo [] get_zone(
		ManagementViewZone [] view_zones
	) {
		object [] results = this.Invoke("get_zone", new object [] {
				view_zones});
		return ((ManagementZoneInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_zone(ManagementViewZone [] view_zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_zone", new object[] {
			view_zones}, callback, asyncState);
	}
	public ManagementZoneInfo [] Endget_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementZoneInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_zone_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementViewZone [] get_zone_name(
		string [] view_names
	) {
		object [] results = this.Invoke("get_zone_name", new object [] {
				view_names});
		return ((ManagementViewZone [])(results[0]));
	}
	public System.IAsyncResult Beginget_zone_name(string [] view_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_zone_name", new object[] {
			view_names}, callback, asyncState);
	}
	public ManagementViewZone [] Endget_zone_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementViewZone [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_zone_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementZoneInfo [] get_zone_v2(
		ManagementViewZone [] view_zones
	) {
		object [] results = this.Invoke("get_zone_v2", new object [] {
				view_zones});
		return ((ManagementZoneInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_zone_v2(ManagementViewZone [] view_zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_zone_v2", new object[] {
			view_zones}, callback, asyncState);
	}
	public ManagementZoneInfo [] Endget_zone_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementZoneInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_zone_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	public void set_zone_option(
		ManagementZoneInfo [] zones
	) {
		this.Invoke("set_zone_option", new object [] {
				zones});

	}
	public System.IAsyncResult Beginset_zone_option(ManagementZoneInfo [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_zone_option", new object[] {
			zones}, callback, asyncState);
	}
	public void Endset_zone_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// transfer_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	public void transfer_zone(
		string [] server_names,
		string [] src_zone_names,
		string [] dst_view_names,
		ManagementZoneInfo [] zone_records
	) {
		this.Invoke("transfer_zone", new object [] {
				server_names,
				src_zone_names,
				dst_view_names,
				zone_records});

	}
	public System.IAsyncResult Begintransfer_zone(string [] server_names,string [] src_zone_names,string [] dst_view_names,ManagementZoneInfo [] zone_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("transfer_zone", new object[] {
			server_names,
			src_zone_names,
			dst_view_names,
			zone_records}, callback, asyncState);
	}
	public void Endtransfer_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// zone_exist
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Zone", 
		RequestNamespace="urn:iControl:Management/Zone", ResponseNamespace="urn:iControl:Management/Zone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] zone_exist(
		ManagementViewZone [] view_zones
	) {
		object [] results = this.Invoke("zone_exist", new object [] {
				view_zones});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginzone_exist(ManagementViewZone [] view_zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("zone_exist", new object[] {
			view_zones}, callback, asyncState);
	}
	public bool [] Endzone_exist(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
