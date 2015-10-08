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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.TrunkBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingTrunkTrunkStatistics))]
	public partial class NetworkingTrunk : iControlInterface {
		public NetworkingTrunk() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void add_interface(
		string [] trunks,
		string [] [] interfaces
	) {
		this.Invoke("add_interface", new object [] {
				trunks,
				interfaces});

	}
	public System.IAsyncResult Beginadd_interface(string [] trunks,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_interface", new object[] {
			trunks,
			interfaces}, callback, asyncState);
	}
	public void Endadd_interface(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void create(
		string [] trunks,
		bool [] lacp_states,
		string [] [] interfaces
	) {
		this.Invoke("create", new object [] {
				trunks,
				lacp_states,
				interfaces});

	}
	public System.IAsyncResult Begincreate(string [] trunks,bool [] lacp_states,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			trunks,
			lacp_states,
			interfaces}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_trunks
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void delete_all_trunks(

	) {
		this.Invoke("delete_all_trunks", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_trunks(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_trunks", new object[0], callback, asyncState);
	}
	public void Enddelete_all_trunks(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_trunk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void delete_trunk(
		string [] trunks
	) {
		this.Invoke("delete_trunk", new object [] {
				trunks});

	}
	public System.IAsyncResult Begindelete_trunk(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_trunk", new object[] {
			trunks}, callback, asyncState);
	}
	public void Enddelete_trunk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_active_lacp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_active_lacp_state(
		string [] trunks
	) {
		object [] results = this.Invoke("get_active_lacp_state", new object [] {
				trunks});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_active_lacp_state(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active_lacp_state", new object[] {
			trunks}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_active_lacp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingTrunkTrunkStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((NetworkingTrunkTrunkStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public NetworkingTrunkTrunkStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingTrunkTrunkStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_configured_member_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_configured_member_count(
		string [] trunks
	) {
		object [] results = this.Invoke("get_configured_member_count", new object [] {
				trunks});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_configured_member_count(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_configured_member_count", new object[] {
			trunks}, callback, asyncState);
	}
	public long [] Endget_configured_member_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] trunks
	) {
		object [] results = this.Invoke("get_description", new object [] {
				trunks});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			trunks}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_distribution_hash_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingTrunkDistributionHashOption [] get_distribution_hash_option(
		string [] trunks
	) {
		object [] results = this.Invoke("get_distribution_hash_option", new object [] {
				trunks});
		return ((NetworkingTrunkDistributionHashOption [])(results[0]));
	}
	public System.IAsyncResult Beginget_distribution_hash_option(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_distribution_hash_option", new object[] {
			trunks}, callback, asyncState);
	}
	public NetworkingTrunkDistributionHashOption [] Endget_distribution_hash_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingTrunkDistributionHashOption [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_interface(
		string [] trunks
	) {
		object [] results = this.Invoke("get_interface", new object [] {
				trunks});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface", new object[] {
			trunks}, callback, asyncState);
	}
	public string [] [] Endget_interface(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lacp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_lacp_enabled_state(
		string [] trunks
	) {
		object [] results = this.Invoke("get_lacp_enabled_state", new object [] {
				trunks});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_lacp_enabled_state(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lacp_enabled_state", new object[] {
			trunks}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_lacp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lacp_timeout_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingTrunkLACPTimeoutOption [] get_lacp_timeout_option(
		string [] trunks
	) {
		object [] results = this.Invoke("get_lacp_timeout_option", new object [] {
				trunks});
		return ((NetworkingTrunkLACPTimeoutOption [])(results[0]));
	}
	public System.IAsyncResult Beginget_lacp_timeout_option(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lacp_timeout_option", new object[] {
			trunks}, callback, asyncState);
	}
	public NetworkingTrunkLACPTimeoutOption [] Endget_lacp_timeout_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingTrunkLACPTimeoutOption [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_selection_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingTrunkLinkSelectionPolicy [] get_link_selection_policy(
		string [] trunks
	) {
		object [] results = this.Invoke("get_link_selection_policy", new object [] {
				trunks});
		return ((NetworkingTrunkLinkSelectionPolicy [])(results[0]));
	}
	public System.IAsyncResult Beginget_link_selection_policy(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_selection_policy", new object[] {
			trunks}, callback, asyncState);
	}
	public NetworkingTrunkLinkSelectionPolicy [] Endget_link_selection_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingTrunkLinkSelectionPolicy [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
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
	// get_media_speed
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_media_speed(
		string [] trunks
	) {
		object [] results = this.Invoke("get_media_speed", new object [] {
				trunks});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_media_speed(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_media_speed", new object[] {
			trunks}, callback, asyncState);
	}
	public long [] Endget_media_speed(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_media_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingMediaStatus [] get_media_status(
		string [] trunks
	) {
		object [] results = this.Invoke("get_media_status", new object [] {
				trunks});
		return ((NetworkingMediaStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_media_status(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_media_status", new object[] {
			trunks}, callback, asyncState);
	}
	public NetworkingMediaStatus [] Endget_media_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingMediaStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_operational_member_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_operational_member_count(
		string [] trunks
	) {
		object [] results = this.Invoke("get_operational_member_count", new object [] {
				trunks});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_operational_member_count(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_operational_member_count", new object[] {
			trunks}, callback, asyncState);
	}
	public long [] Endget_operational_member_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingTrunkTrunkStatistics get_statistics(
		string [] trunks
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				trunks});
		return ((NetworkingTrunkTrunkStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			trunks}, callback, asyncState);
	}
	public NetworkingTrunkTrunkStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingTrunkTrunkStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_stp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_stp_enabled_state(
		string [] trunks
	) {
		object [] results = this.Invoke("get_stp_enabled_state", new object [] {
				trunks});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_stp_enabled_state(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_stp_enabled_state", new object[] {
			trunks}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_stp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_stp_protocol_detection_reset_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_stp_protocol_detection_reset_state(
		string [] trunks
	) {
		object [] results = this.Invoke("get_stp_protocol_detection_reset_state", new object [] {
				trunks});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_stp_protocol_detection_reset_state(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_stp_protocol_detection_reset_state", new object[] {
			trunks}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_stp_protocol_detection_reset_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
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
	// remove_all_interfaces
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void remove_all_interfaces(
		string [] trunks
	) {
		this.Invoke("remove_all_interfaces", new object [] {
				trunks});

	}
	public System.IAsyncResult Beginremove_all_interfaces(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_interfaces", new object[] {
			trunks}, callback, asyncState);
	}
	public void Endremove_all_interfaces(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void remove_interface(
		string [] trunks,
		string [] [] interfaces
	) {
		this.Invoke("remove_interface", new object [] {
				trunks,
				interfaces});

	}
	public System.IAsyncResult Beginremove_interface(string [] trunks,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_interface", new object[] {
			trunks,
			interfaces}, callback, asyncState);
	}
	public void Endremove_interface(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void reset_statistics(
		string [] trunks
	) {
		this.Invoke("reset_statistics", new object [] {
				trunks});

	}
	public System.IAsyncResult Beginreset_statistics(string [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			trunks}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_active_lacp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void set_active_lacp_state(
		string [] trunks,
		CommonEnabledState [] states
	) {
		this.Invoke("set_active_lacp_state", new object [] {
				trunks,
				states});

	}
	public System.IAsyncResult Beginset_active_lacp_state(string [] trunks,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_active_lacp_state", new object[] {
			trunks,
			states}, callback, asyncState);
	}
	public void Endset_active_lacp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void set_description(
		string [] trunks,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				trunks,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] trunks,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			trunks,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_distribution_hash_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void set_distribution_hash_option(
		string [] trunks,
		NetworkingTrunkDistributionHashOption [] hashing_options
	) {
		this.Invoke("set_distribution_hash_option", new object [] {
				trunks,
				hashing_options});

	}
	public System.IAsyncResult Beginset_distribution_hash_option(string [] trunks,NetworkingTrunkDistributionHashOption [] hashing_options, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_distribution_hash_option", new object[] {
			trunks,
			hashing_options}, callback, asyncState);
	}
	public void Endset_distribution_hash_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lacp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void set_lacp_enabled_state(
		string [] trunks,
		CommonEnabledState [] states
	) {
		this.Invoke("set_lacp_enabled_state", new object [] {
				trunks,
				states});

	}
	public System.IAsyncResult Beginset_lacp_enabled_state(string [] trunks,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lacp_enabled_state", new object[] {
			trunks,
			states}, callback, asyncState);
	}
	public void Endset_lacp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lacp_timeout_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void set_lacp_timeout_option(
		string [] trunks,
		NetworkingTrunkLACPTimeoutOption [] timeout_options
	) {
		this.Invoke("set_lacp_timeout_option", new object [] {
				trunks,
				timeout_options});

	}
	public System.IAsyncResult Beginset_lacp_timeout_option(string [] trunks,NetworkingTrunkLACPTimeoutOption [] timeout_options, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lacp_timeout_option", new object[] {
			trunks,
			timeout_options}, callback, asyncState);
	}
	public void Endset_lacp_timeout_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_selection_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void set_link_selection_policy(
		string [] trunks,
		NetworkingTrunkLinkSelectionPolicy [] policies
	) {
		this.Invoke("set_link_selection_policy", new object [] {
				trunks,
				policies});

	}
	public System.IAsyncResult Beginset_link_selection_policy(string [] trunks,NetworkingTrunkLinkSelectionPolicy [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_selection_policy", new object[] {
			trunks,
			policies}, callback, asyncState);
	}
	public void Endset_link_selection_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_stp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void set_stp_enabled_state(
		string [] trunks,
		CommonEnabledState [] states
	) {
		this.Invoke("set_stp_enabled_state", new object [] {
				trunks,
				states});

	}
	public System.IAsyncResult Beginset_stp_enabled_state(string [] trunks,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_stp_enabled_state", new object[] {
			trunks,
			states}, callback, asyncState);
	}
	public void Endset_stp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_stp_protocol_detection_reset_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Trunk", 
		RequestNamespace="urn:iControl:Networking/Trunk", ResponseNamespace="urn:iControl:Networking/Trunk")]
	public void set_stp_protocol_detection_reset_state(
		string [] trunks,
		CommonEnabledState [] states
	) {
		this.Invoke("set_stp_protocol_detection_reset_state", new object [] {
				trunks,
				states});

	}
	public System.IAsyncResult Beginset_stp_protocol_detection_reset_state(string [] trunks,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_stp_protocol_detection_reset_state", new object[] {
			trunks,
			states}, callback, asyncState);
	}
	public void Endset_stp_protocol_detection_reset_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Trunk.DistributionHashOption", Namespace = "urn:iControl")]
	public enum NetworkingTrunkDistributionHashOption
	{
		DISTRIBUTION_HASH_OPTION_DST_MAC,
		DISTRIBUTION_HASH_OPTION_SRC_DST_MAC,
		DISTRIBUTION_HASH_OPTION_SRC_DST_MAC_IP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Trunk.LACPTimeoutOption", Namespace = "urn:iControl")]
	public enum NetworkingTrunkLACPTimeoutOption
	{
		LACP_TIMEOUT_LONG,
		LACP_TIMEOUT_SHORT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Trunk.LinkSelectionPolicy", Namespace = "urn:iControl")]
	public enum NetworkingTrunkLinkSelectionPolicy
	{
		LINK_SELECTION_AUTO,
		LINK_SELECTION_MAXIMUM_BANDWIDTH,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Trunk.TrunkStatisticEntry", Namespace = "urn:iControl")]
	public partial class NetworkingTrunkTrunkStatisticEntry
	{
		private string trunk_nameField;
		public string trunk_name
		{
			get { return this.trunk_nameField; }
			set { this.trunk_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Trunk.TrunkStatistics", Namespace = "urn:iControl")]
	public partial class NetworkingTrunkTrunkStatistics
	{
		private NetworkingTrunkTrunkStatisticEntry [] statisticsField;
		public NetworkingTrunkTrunkStatisticEntry [] statistics
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
