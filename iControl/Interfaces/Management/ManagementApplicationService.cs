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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.ApplicationServiceBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementApplicationServiceScalarVar))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementApplicationServiceListVar))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementApplicationServiceTableVar))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementApplicationServiceScalarVarExtended))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementApplicationServiceListVarExtended))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementApplicationServiceTableVarExtended))]
	public partial class ManagementApplicationService : iControlInterface {
		public ManagementApplicationService() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void add_metadata(
		string [] apps,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				apps,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(string [] apps,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			apps,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// convert_to_generic
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void convert_to_generic(
		string [] apps
	) {
		this.Invoke("convert_to_generic", new object [] {
				apps});

	}
	public System.IAsyncResult Beginconvert_to_generic(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("convert_to_generic", new object[] {
			apps}, callback, asyncState);
	}
	public void Endconvert_to_generic(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void create(
		string [] apps,
		string [] templates,
		ManagementApplicationServiceScalarVar [] [] scalar_vars,
		ManagementApplicationServiceListVar [] [] list_vars,
		ManagementApplicationServiceTableVar [] [] table_vars
	) {
		this.Invoke("create", new object [] {
				apps,
				templates,
				scalar_vars,
				list_vars,
				table_vars});

	}
	public System.IAsyncResult Begincreate(string [] apps,string [] templates,ManagementApplicationServiceScalarVar [] [] scalar_vars,ManagementApplicationServiceListVar [] [] list_vars,ManagementApplicationServiceTableVar [] [] table_vars, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			apps,
			templates,
			scalar_vars,
			list_vars,
			table_vars}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_extended
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void create_extended(
		string [] apps,
		string [] templates,
		ManagementApplicationServiceScalarVarExtended [] [] scalar_vars,
		ManagementApplicationServiceListVarExtended [] [] list_vars,
		ManagementApplicationServiceTableVarExtended [] [] table_vars
	) {
		this.Invoke("create_extended", new object [] {
				apps,
				templates,
				scalar_vars,
				list_vars,
				table_vars});

	}
	public System.IAsyncResult Begincreate_extended(string [] apps,string [] templates,ManagementApplicationServiceScalarVarExtended [] [] scalar_vars,ManagementApplicationServiceListVarExtended [] [] list_vars,ManagementApplicationServiceTableVarExtended [] [] table_vars, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_extended", new object[] {
			apps,
			templates,
			scalar_vars,
			list_vars,
			table_vars}, callback, asyncState);
	}
	public void Endcreate_extended(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_generic
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void create_generic(
		string [] apps
	) {
		this.Invoke("create_generic", new object [] {
				apps});

	}
	public System.IAsyncResult Begincreate_generic(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_generic", new object[] {
			apps}, callback, asyncState);
	}
	public void Endcreate_generic(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_application_services
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void delete_all_application_services(

	) {
		this.Invoke("delete_all_application_services", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_application_services(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_application_services", new object[0], callback, asyncState);
	}
	public void Enddelete_all_application_services(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_application_service
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void delete_application_service(
		string [] apps
	) {
		this.Invoke("delete_application_service", new object [] {
				apps});

	}
	public System.IAsyncResult Begindelete_application_service(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_application_service", new object[] {
			apps}, callback, asyncState);
	}
	public void Enddelete_application_service(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] apps
	) {
		object [] results = this.Invoke("get_description", new object [] {
				apps});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			apps}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_device_group(
		string [] apps
	) {
		object [] results = this.Invoke("get_device_group", new object [] {
				apps});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_device_group(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_group", new object[] {
			apps}, callback, asyncState);
	}
	public string [] Endget_device_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
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
	// get_list_vars
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementApplicationServiceListVar [] [] get_list_vars(
		string [] apps
	) {
		object [] results = this.Invoke("get_list_vars", new object [] {
				apps});
		return ((ManagementApplicationServiceListVar [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_list_vars(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list_vars", new object[] {
			apps}, callback, asyncState);
	}
	public ManagementApplicationServiceListVar [] [] Endget_list_vars(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementApplicationServiceListVar [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list_vars_extended
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementApplicationServiceListVarExtended [] [] get_list_vars_extended(
		string [] apps
	) {
		object [] results = this.Invoke("get_list_vars_extended", new object [] {
				apps});
		return ((ManagementApplicationServiceListVarExtended [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_list_vars_extended(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list_vars_extended", new object[] {
			apps}, callback, asyncState);
	}
	public ManagementApplicationServiceListVarExtended [] [] Endget_list_vars_extended(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementApplicationServiceListVarExtended [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		string [] apps
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				apps});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			apps}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		string [] apps,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				apps,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(string [] apps,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			apps,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		string [] apps,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				apps,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(string [] apps,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			apps,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		string [] apps,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				apps,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(string [] apps,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			apps,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_scalar_vars
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementApplicationServiceScalarVar [] [] get_scalar_vars(
		string [] apps
	) {
		object [] results = this.Invoke("get_scalar_vars", new object [] {
				apps});
		return ((ManagementApplicationServiceScalarVar [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_scalar_vars(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_scalar_vars", new object[] {
			apps}, callback, asyncState);
	}
	public ManagementApplicationServiceScalarVar [] [] Endget_scalar_vars(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementApplicationServiceScalarVar [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_scalar_vars_extended
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementApplicationServiceScalarVarExtended [] [] get_scalar_vars_extended(
		string [] apps
	) {
		object [] results = this.Invoke("get_scalar_vars_extended", new object [] {
				apps});
		return ((ManagementApplicationServiceScalarVarExtended [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_scalar_vars_extended(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_scalar_vars_extended", new object[] {
			apps}, callback, asyncState);
	}
	public ManagementApplicationServiceScalarVarExtended [] [] Endget_scalar_vars_extended(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementApplicationServiceScalarVarExtended [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_strict_updates_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_strict_updates_state(
		string [] apps
	) {
		object [] results = this.Invoke("get_strict_updates_state", new object [] {
				apps});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_strict_updates_state(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_strict_updates_state", new object[] {
			apps}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_strict_updates_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_table_vars
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementApplicationServiceTableVar [] [] get_table_vars(
		string [] apps
	) {
		object [] results = this.Invoke("get_table_vars", new object [] {
				apps});
		return ((ManagementApplicationServiceTableVar [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_table_vars(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_table_vars", new object[] {
			apps}, callback, asyncState);
	}
	public ManagementApplicationServiceTableVar [] [] Endget_table_vars(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementApplicationServiceTableVar [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_table_vars_extended
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementApplicationServiceTableVarExtended [] [] get_table_vars_extended(
		string [] apps
	) {
		object [] results = this.Invoke("get_table_vars_extended", new object [] {
				apps});
		return ((ManagementApplicationServiceTableVarExtended [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_table_vars_extended(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_table_vars_extended", new object[] {
			apps}, callback, asyncState);
	}
	public ManagementApplicationServiceTableVarExtended [] [] Endget_table_vars_extended(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementApplicationServiceTableVarExtended [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_template(
		string [] apps
	) {
		object [] results = this.Invoke("get_template", new object [] {
				apps});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_template(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template", new object[] {
			apps}, callback, asyncState);
	}
	public string [] Endget_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_traffic_group(
		string [] apps
	) {
		object [] results = this.Invoke("get_traffic_group", new object [] {
				apps});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_group(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_group", new object[] {
			apps}, callback, asyncState);
	}
	public string [] Endget_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_device_group_inherited(
		string [] apps
	) {
		object [] results = this.Invoke("is_device_group_inherited", new object [] {
				apps});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_device_group_inherited(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_device_group_inherited", new object[] {
			apps}, callback, asyncState);
	}
	public bool [] Endis_device_group_inherited(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_template_modified
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_template_modified(
		string [] apps
	) {
		object [] results = this.Invoke("is_template_modified", new object [] {
				apps});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_template_modified(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_template_modified", new object[] {
			apps}, callback, asyncState);
	}
	public bool [] Endis_template_modified(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_traffic_group_inherited
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_traffic_group_inherited(
		string [] apps
	) {
		object [] results = this.Invoke("is_traffic_group_inherited", new object [] {
				apps});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_traffic_group_inherited(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_traffic_group_inherited", new object[] {
			apps}, callback, asyncState);
	}
	public bool [] Endis_traffic_group_inherited(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// modify
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void modify(
		string [] apps,
		string [] templates,
		ManagementApplicationServiceScalarVar [] [] scalar_vars,
		ManagementApplicationServiceListVar [] [] list_vars,
		ManagementApplicationServiceTableVar [] [] table_vars
	) {
		this.Invoke("modify", new object [] {
				apps,
				templates,
				scalar_vars,
				list_vars,
				table_vars});

	}
	public System.IAsyncResult Beginmodify(string [] apps,string [] templates,ManagementApplicationServiceScalarVar [] [] scalar_vars,ManagementApplicationServiceListVar [] [] list_vars,ManagementApplicationServiceTableVar [] [] table_vars, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("modify", new object[] {
			apps,
			templates,
			scalar_vars,
			list_vars,
			table_vars}, callback, asyncState);
	}
	public void Endmodify(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// modify_extended
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void modify_extended(
		string [] apps,
		string [] templates,
		ManagementApplicationServiceScalarVarExtended [] [] scalar_vars,
		ManagementApplicationServiceListVarExtended [] [] list_vars,
		ManagementApplicationServiceTableVarExtended [] [] table_vars
	) {
		this.Invoke("modify_extended", new object [] {
				apps,
				templates,
				scalar_vars,
				list_vars,
				table_vars});

	}
	public System.IAsyncResult Beginmodify_extended(string [] apps,string [] templates,ManagementApplicationServiceScalarVarExtended [] [] scalar_vars,ManagementApplicationServiceListVarExtended [] [] list_vars,ManagementApplicationServiceTableVarExtended [] [] table_vars, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("modify_extended", new object[] {
			apps,
			templates,
			scalar_vars,
			list_vars,
			table_vars}, callback, asyncState);
	}
	public void Endmodify_extended(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void remove_all_metadata(
		string [] apps
	) {
		this.Invoke("remove_all_metadata", new object [] {
				apps});

	}
	public System.IAsyncResult Beginremove_all_metadata(string [] apps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			apps}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void remove_metadata(
		string [] apps,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				apps,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(string [] apps,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			apps,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void set_description(
		string [] apps,
		string [] values
	) {
		this.Invoke("set_description", new object [] {
				apps,
				values});

	}
	public System.IAsyncResult Beginset_description(string [] apps,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			apps,
			values}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_device_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void set_device_group(
		string [] apps,
		string [] values
	) {
		this.Invoke("set_device_group", new object [] {
				apps,
				values});

	}
	public System.IAsyncResult Beginset_device_group(string [] apps,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_device_group", new object[] {
			apps,
			values}, callback, asyncState);
	}
	public void Endset_device_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void set_metadata_description(
		string [] apps,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				apps,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(string [] apps,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			apps,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void set_metadata_persistence(
		string [] apps,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				apps,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(string [] apps,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			apps,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void set_metadata_value(
		string [] apps,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				apps,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(string [] apps,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			apps,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_strict_updates_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void set_strict_updates_state(
		string [] apps,
		CommonEnabledState [] states
	) {
		this.Invoke("set_strict_updates_state", new object [] {
				apps,
				states});

	}
	public System.IAsyncResult Beginset_strict_updates_state(string [] apps,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_strict_updates_state", new object[] {
			apps,
			states}, callback, asyncState);
	}
	public void Endset_strict_updates_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationService", 
		RequestNamespace="urn:iControl:Management/ApplicationService", ResponseNamespace="urn:iControl:Management/ApplicationService")]
	public void set_traffic_group(
		string [] apps,
		string [] values
	) {
		this.Invoke("set_traffic_group", new object [] {
				apps,
				values});

	}
	public System.IAsyncResult Beginset_traffic_group(string [] apps,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_group", new object[] {
			apps,
			values}, callback, asyncState);
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ApplicationService.ListVar", Namespace = "urn:iControl")]
	public partial class ManagementApplicationServiceListVar
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string [] valuesField;
		public string [] values
		{
			get { return this.valuesField; }
			set { this.valuesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ApplicationService.ListVarExtended", Namespace = "urn:iControl")]
	public partial class ManagementApplicationServiceListVarExtended
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string [] valuesField;
		public string [] values
		{
			get { return this.valuesField; }
			set { this.valuesField = value; }
		}
		private bool encryptedField;
		public bool encrypted
		{
			get { return this.encryptedField; }
			set { this.encryptedField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ApplicationService.ScalarVar", Namespace = "urn:iControl")]
	public partial class ManagementApplicationServiceScalarVar
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string valueField;
		public string value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ApplicationService.ScalarVarExtended", Namespace = "urn:iControl")]
	public partial class ManagementApplicationServiceScalarVarExtended
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string valueField;
		public string value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool encryptedField;
		public bool encrypted
		{
			get { return this.encryptedField; }
			set { this.encryptedField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ApplicationService.TableVar", Namespace = "urn:iControl")]
	public partial class ManagementApplicationServiceTableVar
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string [] column_namesField;
		public string [] column_names
		{
			get { return this.column_namesField; }
			set { this.column_namesField = value; }
		}
		private string [] [] valuesField;
		public string [] [] values
		{
			get { return this.valuesField; }
			set { this.valuesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ApplicationService.TableVarExtended", Namespace = "urn:iControl")]
	public partial class ManagementApplicationServiceTableVarExtended
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string [] column_namesField;
		public string [] column_names
		{
			get { return this.column_namesField; }
			set { this.column_namesField = value; }
		}
		private string [] encrypted_columnsField;
		public string [] encrypted_columns
		{
			get { return this.encrypted_columnsField; }
			set { this.encrypted_columnsField = value; }
		}
		private string [] [] valuesField;
		public string [] [] values
		{
			get { return this.valuesField; }
			set { this.valuesField = value; }
		}
	};

}
