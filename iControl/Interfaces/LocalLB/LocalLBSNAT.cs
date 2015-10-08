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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.SNATBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBSNATSNATOriginalAddress))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBSNATSNATDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonVLANFilterList))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBSNATSNATStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBSNATTranslation))]
	public partial class LocalLBSNAT : iControlInterface {
		public LocalLBSNAT() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void add_metadata(
		string [] snats,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				snats,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(string [] snats,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			snats,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_original_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void add_original_address(
		string [] snats,
		LocalLBSNATSNATOriginalAddress [] [] addresses
	) {
		this.Invoke("add_original_address", new object [] {
				snats,
				addresses});

	}
	public System.IAsyncResult Beginadd_original_address(string [] snats,LocalLBSNATSNATOriginalAddress [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_original_address", new object[] {
			snats,
			addresses}, callback, asyncState);
	}
	public void Endadd_original_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void create(
		LocalLBSNATSNATDefinition [] snats,
		LocalLBSNATSNATOriginalAddress [] [] original_addresses,
		CommonVLANFilterList [] vlans
	) {
		this.Invoke("create", new object [] {
				snats,
				original_addresses,
				vlans});

	}
	public System.IAsyncResult Begincreate(LocalLBSNATSNATDefinition [] snats,LocalLBSNATSNATOriginalAddress [] [] original_addresses,CommonVLANFilterList [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			snats,
			original_addresses,
			vlans}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_snats
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void delete_all_snats(

	) {
		this.Invoke("delete_all_snats", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_snats(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_snats", new object[0], callback, asyncState);
	}
	public void Enddelete_all_snats(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_snat
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void delete_snat(
		string [] snats
	) {
		this.Invoke("delete_snat", new object [] {
				snats});

	}
	public System.IAsyncResult Begindelete_snat(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_snat", new object[] {
			snats}, callback, asyncState);
	}
	public void Enddelete_snat(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATSNATStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBSNATSNATStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBSNATSNATStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATSNATStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAutoLasthop [] get_auto_lasthop(
		string [] snats
	) {
		object [] results = this.Invoke("get_auto_lasthop", new object [] {
				snats});
		return ((CommonAutoLasthop [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_lasthop(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_lasthop", new object[] {
			snats}, callback, asyncState);
	}
	public CommonAutoLasthop [] Endget_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAutoLasthop [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_mirror_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_connection_mirror_state(
		string [] snats
	) {
		object [] results = this.Invoke("get_connection_mirror_state", new object [] {
				snats});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_mirror_state(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_mirror_state", new object[] {
			snats}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_connection_mirror_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] snats
	) {
		object [] results = this.Invoke("get_description", new object [] {
				snats});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			snats}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
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
	// get_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		string [] snats
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				snats});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			snats}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		string [] snats,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				snats,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(string [] snats,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			snats,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		string [] snats,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				snats,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(string [] snats,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			snats,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		string [] snats,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				snats,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(string [] snats,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			snats,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_original_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATSNATOriginalAddress [] [] get_original_address(
		string [] snats
	) {
		object [] results = this.Invoke("get_original_address", new object [] {
				snats});
		return ((LocalLBSNATSNATOriginalAddress [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_original_address(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_original_address", new object[] {
			snats}, callback, asyncState);
	}
	public LocalLBSNATSNATOriginalAddress [] [] Endget_original_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATSNATOriginalAddress [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_port_behavior
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonSourcePortBehavior [] get_source_port_behavior(
		string [] snats
	) {
		object [] results = this.Invoke("get_source_port_behavior", new object [] {
				snats});
		return ((CommonSourcePortBehavior [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_port_behavior(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_port_behavior", new object[] {
			snats}, callback, asyncState);
	}
	public CommonSourcePortBehavior [] Endget_source_port_behavior(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonSourcePortBehavior [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATSNATStatistics get_statistics(
		string [] snats
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				snats});
		return ((LocalLBSNATSNATStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			snats}, callback, asyncState);
	}
	public LocalLBSNATSNATStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATSNATStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_translation_target
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATTranslation [] get_translation_target(
		string [] snats
	) {
		object [] results = this.Invoke("get_translation_target", new object [] {
				snats});
		return ((LocalLBSNATTranslation [])(results[0]));
	}
	public System.IAsyncResult Beginget_translation_target(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_translation_target", new object[] {
			snats}, callback, asyncState);
	}
	public LocalLBSNATTranslation [] Endget_translation_target(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATTranslation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
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
	// get_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonVLANFilterList [] get_vlan(
		string [] snats
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				snats});
		return ((CommonVLANFilterList [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			snats}, callback, asyncState);
	}
	public CommonVLANFilterList [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonVLANFilterList [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void remove_all_metadata(
		string [] snats
	) {
		this.Invoke("remove_all_metadata", new object [] {
				snats});

	}
	public System.IAsyncResult Beginremove_all_metadata(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			snats}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_original_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void remove_all_original_addresses(
		string [] snats
	) {
		this.Invoke("remove_all_original_addresses", new object [] {
				snats});

	}
	public System.IAsyncResult Beginremove_all_original_addresses(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_original_addresses", new object[] {
			snats}, callback, asyncState);
	}
	public void Endremove_all_original_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void remove_metadata(
		string [] snats,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				snats,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(string [] snats,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			snats,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_original_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void remove_original_address(
		string [] snats,
		LocalLBSNATSNATOriginalAddress [] [] addresses
	) {
		this.Invoke("remove_original_address", new object [] {
				snats,
				addresses});

	}
	public System.IAsyncResult Beginremove_original_address(string [] snats,LocalLBSNATSNATOriginalAddress [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_original_address", new object[] {
			snats,
			addresses}, callback, asyncState);
	}
	public void Endremove_original_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void reset_statistics(
		string [] snats
	) {
		this.Invoke("reset_statistics", new object [] {
				snats});

	}
	public System.IAsyncResult Beginreset_statistics(string [] snats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			snats}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void set_auto_lasthop(
		string [] snats,
		CommonAutoLasthop [] values
	) {
		this.Invoke("set_auto_lasthop", new object [] {
				snats,
				values});

	}
	public System.IAsyncResult Beginset_auto_lasthop(string [] snats,CommonAutoLasthop [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_lasthop", new object[] {
			snats,
			values}, callback, asyncState);
	}
	public void Endset_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_mirror_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void set_connection_mirror_state(
		string [] snats,
		CommonEnabledState [] states
	) {
		this.Invoke("set_connection_mirror_state", new object [] {
				snats,
				states});

	}
	public System.IAsyncResult Beginset_connection_mirror_state(string [] snats,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_mirror_state", new object[] {
			snats,
			states}, callback, asyncState);
	}
	public void Endset_connection_mirror_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void set_description(
		string [] snats,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				snats,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] snats,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			snats,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void set_metadata_description(
		string [] snats,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				snats,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(string [] snats,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			snats,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void set_metadata_persistence(
		string [] snats,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				snats,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(string [] snats,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			snats,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void set_metadata_value(
		string [] snats,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				snats,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(string [] snats,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			snats,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_port_behavior
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void set_source_port_behavior(
		string [] snats,
		CommonSourcePortBehavior [] source_port_behaviors
	) {
		this.Invoke("set_source_port_behavior", new object [] {
				snats,
				source_port_behaviors});

	}
	public System.IAsyncResult Beginset_source_port_behavior(string [] snats,CommonSourcePortBehavior [] source_port_behaviors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_port_behavior", new object[] {
			snats,
			source_port_behaviors}, callback, asyncState);
	}
	public void Endset_source_port_behavior(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_translation_target
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void set_translation_target(
		string [] snats,
		LocalLBSNATTranslation [] targets
	) {
		this.Invoke("set_translation_target", new object [] {
				snats,
				targets});

	}
	public System.IAsyncResult Beginset_translation_target(string [] snats,LocalLBSNATTranslation [] targets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_translation_target", new object[] {
			snats,
			targets}, callback, asyncState);
	}
	public void Endset_translation_target(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNAT", 
		RequestNamespace="urn:iControl:LocalLB/SNAT", ResponseNamespace="urn:iControl:LocalLB/SNAT")]
	public void set_vlan(
		string [] snats,
		CommonVLANFilterList [] vlans
	) {
		this.Invoke("set_vlan", new object [] {
				snats,
				vlans});

	}
	public System.IAsyncResult Beginset_vlan(string [] snats,CommonVLANFilterList [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan", new object[] {
			snats,
			vlans}, callback, asyncState);
	}
	public void Endset_vlan(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNAT.SNATDefinition", Namespace = "urn:iControl")]
	public partial class LocalLBSNATSNATDefinition
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private LocalLBSNATTranslation targetField;
		public LocalLBSNATTranslation target
		{
			get { return this.targetField; }
			set { this.targetField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNAT.SNATOriginalAddress", Namespace = "urn:iControl")]
	public partial class LocalLBSNATSNATOriginalAddress
	{
		private string original_addressField;
		public string original_address
		{
			get { return this.original_addressField; }
			set { this.original_addressField = value; }
		}
		private string wildmaskField;
		public string wildmask
		{
			get { return this.wildmaskField; }
			set { this.wildmaskField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNAT.SNATStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBSNATSNATStatisticEntry
	{
		private LocalLBSNATSNATDefinition snatField;
		public LocalLBSNATSNATDefinition snat
		{
			get { return this.snatField; }
			set { this.snatField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNAT.SNATStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBSNATSNATStatistics
	{
		private LocalLBSNATSNATStatisticEntry [] statisticsField;
		public LocalLBSNATSNATStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNAT.Translation", Namespace = "urn:iControl")]
	public partial class LocalLBSNATTranslation
	{
		private LocalLBSnatType typeField;
		public LocalLBSnatType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private string translation_objectField;
		public string translation_object
		{
			get { return this.translation_objectField; }
			set { this.translation_objectField = value; }
		}
	};

}
