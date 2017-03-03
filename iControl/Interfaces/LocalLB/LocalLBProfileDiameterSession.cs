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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileDiameterSessionBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStringArray))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileDiameterSessionDiameterSessionProfileStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileIPAddress))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileDiameterSessionProfilePersistType))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileDiameterSession : iControlInterface {
		public LocalLBProfileDiameterSession() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_array_acct_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void add_array_acct_application_id(
		string [] profile_names,
		LocalLBProfileStringArray [] values
	) {
		this.Invoke("add_array_acct_application_id", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginadd_array_acct_application_id(string [] profile_names,LocalLBProfileStringArray [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_array_acct_application_id", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endadd_array_acct_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_array_auth_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void add_array_auth_application_id(
		string [] profile_names,
		LocalLBProfileStringArray [] values
	) {
		this.Invoke("add_array_auth_application_id", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginadd_array_auth_application_id(string [] profile_names,LocalLBProfileStringArray [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_array_auth_application_id", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endadd_array_auth_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	// get_acct_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_acct_application_id(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_acct_application_id", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_acct_application_id(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_acct_application_id", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_acct_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDiameterSessionDiameterSessionProfileStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileDiameterSessionDiameterSessionProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileDiameterSessionDiameterSessionProfileStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDiameterSessionDiameterSessionProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_array_acct_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_array_acct_application_id(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_array_acct_application_id", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_array_acct_application_id(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_array_acct_application_id", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_array_acct_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_array_auth_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_array_auth_application_id(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_array_auth_application_id", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_array_auth_application_id(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_array_auth_application_id", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_array_auth_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auth_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_auth_application_id(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_auth_application_id", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_auth_application_id(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auth_application_id", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_auth_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	// get_destination_host_rewrite
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_destination_host_rewrite(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_destination_host_rewrite", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_host_rewrite(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_host_rewrite", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_destination_host_rewrite(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination_realm_rewrite
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_destination_realm_rewrite(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_destination_realm_rewrite", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_realm_rewrite(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_realm_rewrite", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_destination_realm_rewrite(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_discard_unroutable_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_discard_unroutable_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_discard_unroutable_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_discard_unroutable_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_discard_unroutable_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_discard_unroutable_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_handshake_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_handshake_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_handshake_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_handshake_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_handshake_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_handshake_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_host_ip_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileIPAddress [] get_host_ip_address(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_host_ip_address", new object [] {
				profile_names});
		return ((LocalLBProfileIPAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_host_ip_address(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_host_ip_address", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileIPAddress [] Endget_host_ip_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileIPAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	// get_maximum_message_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	// get_maximum_watchdog_failures
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_watchdog_failures(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_watchdog_failures", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_watchdog_failures(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_watchdog_failures", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_watchdog_failures(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_origin_host(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_origin_host", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_host(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_host", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_origin_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin_host_rewrite
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_origin_host_rewrite(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_origin_host_rewrite", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_host_rewrite(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_host_rewrite", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_origin_host_rewrite(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_origin_realm(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_origin_realm", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_realm(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_realm", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_origin_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin_realm_rewrite
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_origin_realm_rewrite(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_origin_realm_rewrite", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_realm_rewrite(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_realm_rewrite", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_origin_realm_rewrite(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persist_avp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_persist_avp(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_persist_avp", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_persist_avp(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persist_avp", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_persist_avp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persist_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDiameterSessionProfilePersistType [] get_persist_type(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_persist_type", new object [] {
				profile_names});
		return ((LocalLBProfileDiameterSessionProfilePersistType [])(results[0]));
	}
	public System.IAsyncResult Beginget_persist_type(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persist_type", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileDiameterSessionProfilePersistType [] Endget_persist_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDiameterSessionProfilePersistType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_product_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_product_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_product_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_product_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_product_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_product_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_reset_on_timeout_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_reset_on_timeout_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_reset_on_timeout_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_reset_on_timeout_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_reset_on_timeout_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_reset_on_timeout_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_route_unconfigured_peers_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_route_unconfigured_peers_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_route_unconfigured_peers_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_unconfigured_peers_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_unconfigured_peers_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_route_unconfigured_peers_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDiameterSessionDiameterSessionProfileStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileDiameterSessionDiameterSessionProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileDiameterSessionDiameterSessionProfileStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDiameterSessionDiameterSessionProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	// get_vendor_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_vendor_id(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_vendor_id", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_vendor_id(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vendor_id", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_vendor_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vendor_specific_acct_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_vendor_specific_acct_application_id(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_vendor_specific_acct_application_id", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_vendor_specific_acct_application_id(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vendor_specific_acct_application_id", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_vendor_specific_acct_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vendor_specific_auth_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_vendor_specific_auth_application_id(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_vendor_specific_auth_application_id", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_vendor_specific_auth_application_id(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vendor_specific_auth_application_id", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_vendor_specific_auth_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vendor_specific_vendor_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_vendor_specific_vendor_id(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_vendor_specific_vendor_id", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_vendor_specific_vendor_id(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vendor_specific_vendor_id", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_vendor_specific_vendor_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	// get_watchdog_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_watchdog_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_watchdog_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_watchdog_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_watchdog_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_watchdog_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	// remove_all_array_acct_application_ids
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void remove_all_array_acct_application_ids(
		string [] profile_names
	) {
		this.Invoke("remove_all_array_acct_application_ids", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_array_acct_application_ids(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_array_acct_application_ids", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_array_acct_application_ids(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_array_auth_application_ids
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void remove_all_array_auth_application_ids(
		string [] profile_names
	) {
		this.Invoke("remove_all_array_auth_application_ids", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_array_auth_application_ids(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_array_auth_application_ids", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_array_auth_application_ids(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_array_acct_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void remove_array_acct_application_id(
		string [] profile_names,
		LocalLBProfileStringArray [] values
	) {
		this.Invoke("remove_array_acct_application_id", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginremove_array_acct_application_id(string [] profile_names,LocalLBProfileStringArray [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_array_acct_application_id", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endremove_array_acct_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_array_auth_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void remove_array_auth_application_id(
		string [] profile_names,
		LocalLBProfileStringArray [] values
	) {
		this.Invoke("remove_array_auth_application_id", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginremove_array_auth_application_id(string [] profile_names,LocalLBProfileStringArray [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_array_auth_application_id", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endremove_array_auth_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	// set_acct_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_acct_application_id(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_acct_application_id", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_acct_application_id(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_acct_application_id", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_acct_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auth_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_auth_application_id(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_auth_application_id", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_auth_application_id(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auth_application_id", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_auth_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	// set_destination_host_rewrite
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_destination_host_rewrite(
		string [] profile_names,
		LocalLBProfileString [] values
	) {
		this.Invoke("set_destination_host_rewrite", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_destination_host_rewrite(string [] profile_names,LocalLBProfileString [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_host_rewrite", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_destination_host_rewrite(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_destination_realm_rewrite
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_destination_realm_rewrite(
		string [] profile_names,
		LocalLBProfileString [] values
	) {
		this.Invoke("set_destination_realm_rewrite", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_destination_realm_rewrite(string [] profile_names,LocalLBProfileString [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_realm_rewrite", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_destination_realm_rewrite(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_discard_unroutable_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_discard_unroutable_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_discard_unroutable_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_discard_unroutable_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_discard_unroutable_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_discard_unroutable_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_handshake_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_handshake_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_handshake_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_handshake_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_handshake_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_handshake_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_host_ip_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_host_ip_address(
		string [] profile_names,
		LocalLBProfileIPAddress [] values
	) {
		this.Invoke("set_host_ip_address", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_host_ip_address(string [] profile_names,LocalLBProfileIPAddress [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_host_ip_address", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_host_ip_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_message_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_maximum_message_size(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_message_size", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_message_size(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_message_size", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_message_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_watchdog_failures
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_maximum_watchdog_failures(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_watchdog_failures", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_watchdog_failures(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_watchdog_failures", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_watchdog_failures(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_origin_host(
		string [] profile_names,
		LocalLBProfileString [] values
	) {
		this.Invoke("set_origin_host", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_origin_host(string [] profile_names,LocalLBProfileString [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_host", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_origin_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_host_rewrite
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_origin_host_rewrite(
		string [] profile_names,
		LocalLBProfileString [] values
	) {
		this.Invoke("set_origin_host_rewrite", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_origin_host_rewrite(string [] profile_names,LocalLBProfileString [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_host_rewrite", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_origin_host_rewrite(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_origin_realm(
		string [] profile_names,
		LocalLBProfileString [] values
	) {
		this.Invoke("set_origin_realm", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_origin_realm(string [] profile_names,LocalLBProfileString [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_realm", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_origin_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_realm_rewrite
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_origin_realm_rewrite(
		string [] profile_names,
		LocalLBProfileString [] values
	) {
		this.Invoke("set_origin_realm_rewrite", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_origin_realm_rewrite(string [] profile_names,LocalLBProfileString [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_realm_rewrite", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_origin_realm_rewrite(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persist_avp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_persist_avp(
		string [] profile_names,
		LocalLBProfileString [] values
	) {
		this.Invoke("set_persist_avp", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_persist_avp(string [] profile_names,LocalLBProfileString [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persist_avp", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_persist_avp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persist_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_persist_type(
		string [] profile_names,
		LocalLBProfileDiameterSessionProfilePersistType [] values
	) {
		this.Invoke("set_persist_type", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_persist_type(string [] profile_names,LocalLBProfileDiameterSessionProfilePersistType [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persist_type", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_persist_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_product_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_product_name(
		string [] profile_names,
		LocalLBProfileString [] values
	) {
		this.Invoke("set_product_name", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_product_name(string [] profile_names,LocalLBProfileString [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_product_name", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_product_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_reset_on_timeout_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_reset_on_timeout_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_reset_on_timeout_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_reset_on_timeout_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_reset_on_timeout_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_reset_on_timeout_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_route_unconfigured_peers_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_route_unconfigured_peers_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_route_unconfigured_peers_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_route_unconfigured_peers_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_route_unconfigured_peers_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_route_unconfigured_peers_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vendor_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_vendor_id(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_vendor_id", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_vendor_id(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vendor_id", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_vendor_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vendor_specific_acct_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_vendor_specific_acct_application_id(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_vendor_specific_acct_application_id", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_vendor_specific_acct_application_id(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vendor_specific_acct_application_id", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_vendor_specific_acct_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vendor_specific_auth_application_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_vendor_specific_auth_application_id(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_vendor_specific_auth_application_id", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_vendor_specific_auth_application_id(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vendor_specific_auth_application_id", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_vendor_specific_auth_application_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vendor_specific_vendor_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_vendor_specific_vendor_id(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_vendor_specific_vendor_id", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_vendor_specific_vendor_id(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vendor_specific_vendor_id", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_vendor_specific_vendor_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_watchdog_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterSession", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterSession", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterSession")]
	public void set_watchdog_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_watchdog_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_watchdog_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_watchdog_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_watchdog_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterSession.PersistKey", Namespace = "urn:iControl")]
	public enum LocalLBProfileDiameterSessionPersistKey
	{
		DIAMETERSESSION_PERSIST_KEY_UNKNOWN,
		DIAMETERSESSION_PERSIST_KEY_CALL_ID,
		DIAMETERSESSION_PERSIST_KEY_SOURCE_ADDRESS,
		DIAMETERSESSION_PERSIST_KEY_CUSTOM,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterSession.PersistType", Namespace = "urn:iControl")]
	public enum LocalLBProfileDiameterSessionPersistType
	{
		DIAMETERSESSION_PERSIST_TYPE_UNKNOWN,
		DIAMETERSESSION_PERSIST_TYPE_NONE,
		DIAMETERSESSION_PERSIST_TYPE_SESSION,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterSession.DiameterSessionProfileStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDiameterSessionDiameterSessionProfileStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterSession.DiameterSessionProfileStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDiameterSessionDiameterSessionProfileStatistics
	{
		private LocalLBProfileDiameterSessionDiameterSessionProfileStatisticEntry [] statisticsField;
		public LocalLBProfileDiameterSessionDiameterSessionProfileStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterSession.ProfilePersistType", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDiameterSessionProfilePersistType
	{
		private LocalLBProfileDiameterSessionPersistType valueField;
		public LocalLBProfileDiameterSessionPersistType value
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

}
