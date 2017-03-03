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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileDiameterRouterBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStringArray))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileDiameterRouterDiameterRouterProfileStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	public partial class LocalLBProfileDiameterRouter : iControlInterface {
		public LocalLBProfileDiameterRouter() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_supported_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	public void add_supported_application(
		string [] profile_names,
		LocalLBProfileStringArray [] values
	) {
		this.Invoke("add_supported_application", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginadd_supported_application(string [] profile_names,LocalLBProfileStringArray [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_supported_application", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endadd_supported_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDiameterRouterDiameterRouterProfileStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileDiameterRouterDiameterRouterProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileDiameterRouterDiameterRouterProfileStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDiameterRouterDiameterRouterProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	// get_ignore_peer_port_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_ignore_peer_port_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ignore_peer_port_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ignore_peer_port_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ignore_peer_port_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_ignore_peer_port_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	// get_maximum_pending_bytes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_pending_bytes(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_pending_bytes", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_pending_bytes(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_pending_bytes", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_pending_bytes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_pending_messages
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_pending_messages(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_pending_messages", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_pending_messages(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_pending_messages", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_pending_messages(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDiameterRouterDiameterRouterProfileStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileDiameterRouterDiameterRouterProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileDiameterRouterDiameterRouterProfileStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDiameterRouterDiameterRouterProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_supported_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_supported_application(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_supported_application", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_supported_application(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_supported_application", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_supported_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transaction_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_transaction_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_transaction_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_transaction_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transaction_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_transaction_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_local_connection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_use_local_connection_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_use_local_connection_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_local_connection_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_local_connection_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_use_local_connection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	// remove_all_supported_applications
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	public void remove_all_supported_applications(
		string [] profile_names
	) {
		this.Invoke("remove_all_supported_applications", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_supported_applications(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_supported_applications", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_supported_applications(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_supported_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	public void remove_supported_application(
		string [] profile_names,
		LocalLBProfileStringArray [] values
	) {
		this.Invoke("remove_supported_application", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginremove_supported_application(string [] profile_names,LocalLBProfileStringArray [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_supported_application", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endremove_supported_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
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
	// set_ignore_peer_port_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	public void set_ignore_peer_port_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_ignore_peer_port_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_ignore_peer_port_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ignore_peer_port_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_ignore_peer_port_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_pending_bytes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	public void set_maximum_pending_bytes(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_pending_bytes", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_pending_bytes(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_pending_bytes", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_pending_bytes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_pending_messages
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	public void set_maximum_pending_messages(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_pending_messages", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_pending_messages(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_pending_messages", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_pending_messages(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_transaction_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	public void set_transaction_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_transaction_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_transaction_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_transaction_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_transaction_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_local_connection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterRouter")]
	public void set_use_local_connection_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_use_local_connection_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_use_local_connection_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_local_connection_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_use_local_connection_state(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterRouter.DiameterRouterProfileStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDiameterRouterDiameterRouterProfileStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterRouter.DiameterRouterProfileStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDiameterRouterDiameterRouterProfileStatistics
	{
		private LocalLBProfileDiameterRouterDiameterRouterProfileStatisticEntry [] statisticsField;
		public LocalLBProfileDiameterRouterDiameterRouterProfileStatisticEntry [] statistics
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
