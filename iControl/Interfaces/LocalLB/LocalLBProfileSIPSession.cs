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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileSIPSessionBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSIPSessionSIPSessionProfileStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSIPSessionProfilePersistKey))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSIPSessionProfilePersistType))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileSIPSession : iControlInterface {
		public LocalLBProfileSIPSession() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void create(
		string [] profile_names
	) {
		this.Invoke("create", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begincreate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void delete_all_profiles(

	) {
		this.Invoke("delete_all_profiles", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_profiles(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_profiles", new object[0], callback, asyncState);
	}
	public void Enddelete_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void delete_profile(
		string [] profile_names
	) {
		this.Invoke("delete_profile", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begindelete_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Enddelete_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSIPSessionSIPSessionProfileStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileSIPSessionSIPSessionProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileSIPSessionSIPSessionProfileStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSIPSessionSIPSessionProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_custom_via
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_custom_via(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_custom_via", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_custom_via(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_custom_via", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_custom_via(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_default_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_default_profile", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_do_not_connect_back_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_do_not_connect_back_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_do_not_connect_back_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_do_not_connect_back_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_do_not_connect_back_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_do_not_connect_back_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_firewall_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_firewall_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_firewall_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_firewall_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_firewall_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_firewall_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generate_response_on_failure_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_generate_response_on_failure_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_generate_response_on_failure_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_generate_response_on_failure_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generate_response_on_failure_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_generate_response_on_failure_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_honor_via_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_honor_via_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_honor_via_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_honor_via_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_honor_via_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_honor_via_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_insert_record_route_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_insert_record_route_header_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_insert_record_route_header_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_insert_record_route_header_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_insert_record_route_header_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_insert_record_route_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_insert_via_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_insert_via_header_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_insert_via_header_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_insert_via_header_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_insert_via_header_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_insert_via_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
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
	// get_loop_detection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_loop_detection_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_loop_detection_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_loop_detection_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_loop_detection_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_loop_detection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_max_forwards_check_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_max_forwards_check_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_max_forwards_check_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_max_forwards_check_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_max_forwards_check_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_max_forwards_check_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_message_header_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_message_header_count(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_message_header_count", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_message_header_count(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_message_header_count", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_message_header_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_message_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_message_header_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_message_header_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_message_header_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_message_header_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_message_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_message_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_message_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_message_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_message_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_message_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_message_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persist_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSIPSessionProfilePersistKey [] get_persist_key(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_persist_key", new object [] {
				profile_names});
		return ((LocalLBProfileSIPSessionProfilePersistKey [])(results[0]));
	}
	public System.IAsyncResult Beginget_persist_key(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persist_key", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSIPSessionProfilePersistKey [] Endget_persist_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSIPSessionProfilePersistKey [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persist_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_persist_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_persist_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_persist_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persist_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_persist_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persist_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSIPSessionProfilePersistType [] get_persist_type(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_persist_type", new object [] {
				profile_names});
		return ((LocalLBProfileSIPSessionProfilePersistType [])(results[0]));
	}
	public System.IAsyncResult Beginget_persist_type(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persist_type", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSIPSessionProfilePersistType [] Endget_persist_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSIPSessionProfilePersistType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSIPSessionSIPSessionProfileStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileSIPSessionSIPSessionProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSIPSessionSIPSessionProfileStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSIPSessionSIPSessionProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStatisticsByVirtual get_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		object [] results = this.Invoke("get_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public LocalLBProfileStatisticsByVirtual Endget_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
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
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_base_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_base_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_base_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_base_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_base_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_system_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_system_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_system_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_system_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_system_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_system_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void reset_statistics(
		string [] profile_names
	) {
		this.Invoke("reset_statistics", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginreset_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void reset_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		this.Invoke("reset_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});

	}
	public System.IAsyncResult Beginreset_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public void Endreset_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_custom_via
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_custom_via(
		string [] profile_names,
		LocalLBProfileString [] vias
	) {
		this.Invoke("set_custom_via", new object [] {
				profile_names,
				vias});

	}
	public System.IAsyncResult Beginset_custom_via(string [] profile_names,LocalLBProfileString [] vias, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_custom_via", new object[] {
			profile_names,
			vias}, callback, asyncState);
	}
	public void Endset_custom_via(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_default_profile(
		string [] profile_names,
		string [] defaults
	) {
		this.Invoke("set_default_profile", new object [] {
				profile_names,
				defaults});

	}
	public System.IAsyncResult Beginset_default_profile(string [] profile_names,string [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_profile", new object[] {
			profile_names,
			defaults}, callback, asyncState);
	}
	public void Endset_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_description(
		string [] profile_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				profile_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] profile_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			profile_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_do_not_connect_back_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_do_not_connect_back_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_do_not_connect_back_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_do_not_connect_back_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_do_not_connect_back_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_do_not_connect_back_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_firewall_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_firewall_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_firewall_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_firewall_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_firewall_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_firewall_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_generate_response_on_failure_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_generate_response_on_failure_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_generate_response_on_failure_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_generate_response_on_failure_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_generate_response_on_failure_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_generate_response_on_failure_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_honor_via_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_honor_via_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_honor_via_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_honor_via_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_honor_via_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_honor_via_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_insert_record_route_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_insert_record_route_header_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_insert_record_route_header_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_insert_record_route_header_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_insert_record_route_header_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_insert_record_route_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_insert_via_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_insert_via_header_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_insert_via_header_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_insert_via_header_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_insert_via_header_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_insert_via_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_loop_detection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_loop_detection_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_loop_detection_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_loop_detection_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_loop_detection_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_loop_detection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_max_forwards_check_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_max_forwards_check_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_max_forwards_check_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_max_forwards_check_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_max_forwards_check_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_max_forwards_check_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_message_header_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_maximum_message_header_count(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_message_header_count", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_message_header_count(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_message_header_count", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_message_header_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_message_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_maximum_message_header_size(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_message_header_size", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_message_header_size(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_message_header_size", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_message_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_message_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_maximum_message_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_maximum_message_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_maximum_message_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_message_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_maximum_message_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persist_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_persist_key(
		string [] profile_names,
		LocalLBProfileSIPSessionProfilePersistKey [] values
	) {
		this.Invoke("set_persist_key", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_persist_key(string [] profile_names,LocalLBProfileSIPSessionProfilePersistKey [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persist_key", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_persist_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persist_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_persist_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_persist_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_persist_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persist_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_persist_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persist_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPSession", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPSession")]
	public void set_persist_type(
		string [] profile_names,
		LocalLBProfileSIPSessionProfilePersistType [] values
	) {
		this.Invoke("set_persist_type", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_persist_type(string [] profile_names,LocalLBProfileSIPSessionProfilePersistType [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persist_type", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_persist_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIPSession.PersistKey", Namespace = "urn:iControl")]
	public enum LocalLBProfileSIPSessionPersistKey
	{
		SIPSESSION_PERSIST_KEY_UNKNOWN,
		SIPSESSION_PERSIST_KEY_CALL_ID,
		SIPSESSION_PERSIST_KEY_SRC_ADDR,
		SIPSESSION_PERSIST_KEY_CUSTOM,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIPSession.PersistType", Namespace = "urn:iControl")]
	public enum LocalLBProfileSIPSessionPersistType
	{
		SIPSESSION_PERSIST_TYPE_UNKNOWN,
		SIPSESSION_PERSIST_TYPE_NONE,
		SIPSESSION_PERSIST_TYPE_SESSION,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIPSession.ProfilePersistKey", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSIPSessionProfilePersistKey
	{
		private LocalLBProfileSIPSessionPersistKey valueField;
		public LocalLBProfileSIPSessionPersistKey value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIPSession.ProfilePersistType", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSIPSessionProfilePersistType
	{
		private LocalLBProfileSIPSessionPersistType valueField;
		public LocalLBProfileSIPSessionPersistType value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIPSession.SIPSessionProfileStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSIPSessionSIPSessionProfileStatisticEntry
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIPSession.SIPSessionProfileStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSIPSessionSIPSessionProfileStatistics
	{
		private LocalLBProfileSIPSessionSIPSessionProfileStatisticEntry [] statisticsField;
		public LocalLBProfileSIPSessionSIPSessionProfileStatisticEntry [] statistics
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
