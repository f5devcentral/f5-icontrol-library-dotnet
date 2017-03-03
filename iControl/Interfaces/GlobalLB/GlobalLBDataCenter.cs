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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.DataCenterBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBDataCenterDataCenterAttribute))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBDataCenterDataCenterStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBDataCenterDataCenterLinkDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBProberSelection))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBDataCenterDataCenterServerDefinition))]
	public partial class GlobalLBDataCenter : iControlInterface {
		public GlobalLBDataCenter() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void add_metadata(
		string [] data_centers,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				data_centers,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(string [] data_centers,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			data_centers,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void create(
		GlobalLBDataCenterDataCenterAttribute [] data_centers
	) {
		this.Invoke("create", new object [] {
				data_centers});

	}
	public System.IAsyncResult Begincreate(GlobalLBDataCenterDataCenterAttribute [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			data_centers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_data_centers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void delete_all_data_centers(

	) {
		this.Invoke("delete_all_data_centers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_data_centers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_data_centers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_data_centers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_data_center
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void delete_data_center(
		string [] data_centers
	) {
		this.Invoke("delete_data_center", new object [] {
				data_centers});

	}
	public System.IAsyncResult Begindelete_data_center(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_data_center", new object[] {
			data_centers}, callback, asyncState);
	}
	public void Enddelete_data_center(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDataCenterDataCenterStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBDataCenterDataCenterStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBDataCenterDataCenterStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDataCenterDataCenterStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_contact_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_contact_information(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_contact_information", new object [] {
				data_centers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_contact_information(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_contact_information", new object[] {
			data_centers}, callback, asyncState);
	}
	public string [] Endget_contact_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_description", new object [] {
				data_centers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			data_centers}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				data_centers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			data_centers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDataCenterDataCenterLinkDefinition [] get_link(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_link", new object [] {
				data_centers});
		return ((GlobalLBDataCenterDataCenterLinkDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_link(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link", new object[] {
			data_centers}, callback, asyncState);
	}
	public GlobalLBDataCenterDataCenterLinkDefinition [] Endget_link(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDataCenterDataCenterLinkDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
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
	// get_location_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_location_information(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_location_information", new object [] {
				data_centers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_location_information(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_location_information", new object[] {
			data_centers}, callback, asyncState);
	}
	public string [] Endget_location_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				data_centers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			data_centers}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		string [] data_centers,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				data_centers,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(string [] data_centers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			data_centers,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		string [] data_centers,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				data_centers,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(string [] data_centers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			data_centers,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		string [] data_centers,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				data_centers,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(string [] data_centers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			data_centers,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				data_centers});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			data_centers}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prober_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_prober_pool(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_prober_pool", new object [] {
				data_centers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_prober_pool(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prober_pool", new object[] {
			data_centers}, callback, asyncState);
	}
	public string [] Endget_prober_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prober_selection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBProberSelection [] get_prober_selection(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_prober_selection", new object [] {
				data_centers});
		return ((GlobalLBProberSelection [])(results[0]));
	}
	public System.IAsyncResult Beginget_prober_selection(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prober_selection", new object[] {
			data_centers}, callback, asyncState);
	}
	public GlobalLBProberSelection [] Endget_prober_selection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBProberSelection [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDataCenterDataCenterServerDefinition [] get_server(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_server", new object [] {
				data_centers});
		return ((GlobalLBDataCenterDataCenterServerDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_server(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server", new object[] {
			data_centers}, callback, asyncState);
	}
	public GlobalLBDataCenterDataCenterServerDefinition [] Endget_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDataCenterDataCenterServerDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDataCenterDataCenterStatistics get_statistics(
		string [] data_centers
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				data_centers});
		return ((GlobalLBDataCenterDataCenterStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			data_centers}, callback, asyncState);
	}
	public GlobalLBDataCenterDataCenterStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDataCenterDataCenterStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
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
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void remove_all_metadata(
		string [] data_centers
	) {
		this.Invoke("remove_all_metadata", new object [] {
				data_centers});

	}
	public System.IAsyncResult Beginremove_all_metadata(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			data_centers}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void remove_metadata(
		string [] data_centers,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				data_centers,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(string [] data_centers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			data_centers,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void reset_statistics(
		string [] data_centers
	) {
		this.Invoke("reset_statistics", new object [] {
				data_centers});

	}
	public System.IAsyncResult Beginreset_statistics(string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			data_centers}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_contact_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void set_contact_information(
		string [] data_centers,
		string [] contacts
	) {
		this.Invoke("set_contact_information", new object [] {
				data_centers,
				contacts});

	}
	public System.IAsyncResult Beginset_contact_information(string [] data_centers,string [] contacts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_contact_information", new object[] {
			data_centers,
			contacts}, callback, asyncState);
	}
	public void Endset_contact_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void set_description(
		string [] data_centers,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				data_centers,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] data_centers,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			data_centers,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void set_enabled_state(
		string [] data_centers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				data_centers,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] data_centers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			data_centers,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_location_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void set_location_information(
		string [] data_centers,
		string [] locations
	) {
		this.Invoke("set_location_information", new object [] {
				data_centers,
				locations});

	}
	public System.IAsyncResult Beginset_location_information(string [] data_centers,string [] locations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_location_information", new object[] {
			data_centers,
			locations}, callback, asyncState);
	}
	public void Endset_location_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void set_metadata_description(
		string [] data_centers,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				data_centers,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(string [] data_centers,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			data_centers,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void set_metadata_persistence(
		string [] data_centers,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				data_centers,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(string [] data_centers,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			data_centers,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void set_metadata_value(
		string [] data_centers,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				data_centers,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(string [] data_centers,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			data_centers,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prober_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void set_prober_pool(
		string [] data_centers,
		string [] pools
	) {
		this.Invoke("set_prober_pool", new object [] {
				data_centers,
				pools});

	}
	public System.IAsyncResult Beginset_prober_pool(string [] data_centers,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prober_pool", new object[] {
			data_centers,
			pools}, callback, asyncState);
	}
	public void Endset_prober_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prober_selection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DataCenter", 
		RequestNamespace="urn:iControl:GlobalLB/DataCenter", ResponseNamespace="urn:iControl:GlobalLB/DataCenter")]
	public void set_prober_selection(
		string [] data_centers,
		GlobalLBProberSelection [] prober_selections
	) {
		this.Invoke("set_prober_selection", new object [] {
				data_centers,
				prober_selections});

	}
	public System.IAsyncResult Beginset_prober_selection(string [] data_centers,GlobalLBProberSelection [] prober_selections, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prober_selection", new object[] {
			data_centers,
			prober_selections}, callback, asyncState);
	}
	public void Endset_prober_selection(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DataCenter.DataCenterAttribute", Namespace = "urn:iControl")]
	public partial class GlobalLBDataCenterDataCenterAttribute
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string locationField;
		public string location
		{
			get { return this.locationField; }
			set { this.locationField = value; }
		}
		private string contactField;
		public string contact
		{
			get { return this.contactField; }
			set { this.contactField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DataCenter.DataCenterLinkDefinition", Namespace = "urn:iControl")]
	public partial class GlobalLBDataCenterDataCenterLinkDefinition
	{
		private string data_centerField;
		public string data_center
		{
			get { return this.data_centerField; }
			set { this.data_centerField = value; }
		}
		private string [] linksField;
		public string [] links
		{
			get { return this.linksField; }
			set { this.linksField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DataCenter.DataCenterServerDefinition", Namespace = "urn:iControl")]
	public partial class GlobalLBDataCenterDataCenterServerDefinition
	{
		private string data_centerField;
		public string data_center
		{
			get { return this.data_centerField; }
			set { this.data_centerField = value; }
		}
		private string [] serversField;
		public string [] servers
		{
			get { return this.serversField; }
			set { this.serversField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DataCenter.DataCenterStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBDataCenterDataCenterStatisticEntry
	{
		private string data_centerField;
		public string data_center
		{
			get { return this.data_centerField; }
			set { this.data_centerField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DataCenter.DataCenterStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBDataCenterDataCenterStatistics
	{
		private GlobalLBDataCenterDataCenterStatisticEntry [] statisticsField;
		public GlobalLBDataCenterDataCenterStatisticEntry [] statistics
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
