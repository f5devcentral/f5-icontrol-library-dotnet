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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileDiameterBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileDiameterProfileDiameterStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileDiameter : iControlInterface {
		public LocalLBProfileDiameter() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDiameterProfileDiameterStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileDiameterProfileDiameterStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileDiameterProfileDiameterStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDiameterProfileDiameterStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_prime_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_connection_prime_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_connection_prime_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_prime_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_prime_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_connection_prime_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	// get_destination_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_destination_realm(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_destination_realm", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_realm(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_realm", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_destination_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_handshake_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	// get_host_ip_rewrite_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_host_ip_rewrite_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_host_ip_rewrite_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_host_ip_rewrite_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_host_ip_rewrite_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_host_ip_rewrite_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	// get_max_watchdog_failure
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_max_watchdog_failure(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_max_watchdog_failure", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_max_watchdog_failure(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_max_watchdog_failure", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_max_watchdog_failure(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_retransmit_attempts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_retransmit_attempts(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_retransmit_attempts", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_retransmit_attempts(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_retransmit_attempts", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_retransmit_attempts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	// get_origin_host_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_origin_host_to_client(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_origin_host_to_client", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_host_to_client(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_host_to_client", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_origin_host_to_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin_host_to_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_origin_host_to_server(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_origin_host_to_server", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_host_to_server(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_host_to_server", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_origin_host_to_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	// get_origin_realm_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_origin_realm_to_client(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_origin_realm_to_client", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_realm_to_client(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_realm_to_client", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_origin_realm_to_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin_realm_to_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_origin_realm_to_server(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_origin_realm_to_server", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_realm_to_server(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_realm_to_server", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_origin_realm_to_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_overwrite_destination_host_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_overwrite_destination_host_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_overwrite_destination_host_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_overwrite_destination_host_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_overwrite_destination_host_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_overwrite_destination_host_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_parent_avp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_parent_avp(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_parent_avp", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_parent_avp(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_parent_avp", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_parent_avp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persist_avp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	// get_reset_on_timeout_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	// get_retransmit_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_retransmit_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_retransmit_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_retransmit_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_retransmit_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_retransmit_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDiameterProfileDiameterStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileDiameterProfileDiameterStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileDiameterProfileDiameterStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDiameterProfileDiameterStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	// set_connection_prime_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_connection_prime_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_connection_prime_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_connection_prime_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_prime_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_connection_prime_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	// set_destination_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_destination_realm(
		string [] profile_names,
		LocalLBProfileString [] realms
	) {
		this.Invoke("set_destination_realm", new object [] {
				profile_names,
				realms});

	}
	public System.IAsyncResult Beginset_destination_realm(string [] profile_names,LocalLBProfileString [] realms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_realm", new object[] {
			profile_names,
			realms}, callback, asyncState);
	}
	public void Endset_destination_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_handshake_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_handshake_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_handshake_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_handshake_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_handshake_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_handshake_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_host_ip_rewrite_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_host_ip_rewrite_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_host_ip_rewrite_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_host_ip_rewrite_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_host_ip_rewrite_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_host_ip_rewrite_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_max_watchdog_failure
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_max_watchdog_failure(
		string [] profile_names,
		LocalLBProfileULong [] failures
	) {
		this.Invoke("set_max_watchdog_failure", new object [] {
				profile_names,
				failures});

	}
	public System.IAsyncResult Beginset_max_watchdog_failure(string [] profile_names,LocalLBProfileULong [] failures, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_max_watchdog_failure", new object[] {
			profile_names,
			failures}, callback, asyncState);
	}
	public void Endset_max_watchdog_failure(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_retransmit_attempts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_maximum_retransmit_attempts(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_retransmit_attempts", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_retransmit_attempts(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_retransmit_attempts", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_retransmit_attempts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_origin_host(
		string [] profile_names,
		LocalLBProfileString [] hosts
	) {
		this.Invoke("set_origin_host", new object [] {
				profile_names,
				hosts});

	}
	public System.IAsyncResult Beginset_origin_host(string [] profile_names,LocalLBProfileString [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_host", new object[] {
			profile_names,
			hosts}, callback, asyncState);
	}
	public void Endset_origin_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_host_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_origin_host_to_client(
		string [] profile_names,
		LocalLBProfileString [] hosts
	) {
		this.Invoke("set_origin_host_to_client", new object [] {
				profile_names,
				hosts});

	}
	public System.IAsyncResult Beginset_origin_host_to_client(string [] profile_names,LocalLBProfileString [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_host_to_client", new object[] {
			profile_names,
			hosts}, callback, asyncState);
	}
	public void Endset_origin_host_to_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_host_to_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_origin_host_to_server(
		string [] profile_names,
		LocalLBProfileString [] hosts
	) {
		this.Invoke("set_origin_host_to_server", new object [] {
				profile_names,
				hosts});

	}
	public System.IAsyncResult Beginset_origin_host_to_server(string [] profile_names,LocalLBProfileString [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_host_to_server", new object[] {
			profile_names,
			hosts}, callback, asyncState);
	}
	public void Endset_origin_host_to_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_origin_realm(
		string [] profile_names,
		LocalLBProfileString [] realms
	) {
		this.Invoke("set_origin_realm", new object [] {
				profile_names,
				realms});

	}
	public System.IAsyncResult Beginset_origin_realm(string [] profile_names,LocalLBProfileString [] realms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_realm", new object[] {
			profile_names,
			realms}, callback, asyncState);
	}
	public void Endset_origin_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_realm_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_origin_realm_to_client(
		string [] profile_names,
		LocalLBProfileString [] realms
	) {
		this.Invoke("set_origin_realm_to_client", new object [] {
				profile_names,
				realms});

	}
	public System.IAsyncResult Beginset_origin_realm_to_client(string [] profile_names,LocalLBProfileString [] realms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_realm_to_client", new object[] {
			profile_names,
			realms}, callback, asyncState);
	}
	public void Endset_origin_realm_to_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_realm_to_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_origin_realm_to_server(
		string [] profile_names,
		LocalLBProfileString [] realms
	) {
		this.Invoke("set_origin_realm_to_server", new object [] {
				profile_names,
				realms});

	}
	public System.IAsyncResult Beginset_origin_realm_to_server(string [] profile_names,LocalLBProfileString [] realms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_realm_to_server", new object[] {
			profile_names,
			realms}, callback, asyncState);
	}
	public void Endset_origin_realm_to_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_overwrite_destination_host_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_overwrite_destination_host_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_overwrite_destination_host_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_overwrite_destination_host_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_overwrite_destination_host_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_overwrite_destination_host_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_parent_avp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_parent_avp(
		string [] profile_names,
		LocalLBProfileString [] avps
	) {
		this.Invoke("set_parent_avp", new object [] {
				profile_names,
				avps});

	}
	public System.IAsyncResult Beginset_parent_avp(string [] profile_names,LocalLBProfileString [] avps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_parent_avp", new object[] {
			profile_names,
			avps}, callback, asyncState);
	}
	public void Endset_parent_avp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persist_avp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_persist_avp(
		string [] profile_names,
		LocalLBProfileString [] avps
	) {
		this.Invoke("set_persist_avp", new object [] {
				profile_names,
				avps});

	}
	public System.IAsyncResult Beginset_persist_avp(string [] profile_names,LocalLBProfileString [] avps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persist_avp", new object[] {
			profile_names,
			avps}, callback, asyncState);
	}
	public void Endset_persist_avp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_reset_on_timeout_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
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
	// set_retransmit_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_retransmit_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_retransmit_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_retransmit_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_retransmit_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_retransmit_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_watchdog_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameter", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameter")]
	public void set_watchdog_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_watchdog_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_watchdog_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_watchdog_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_watchdog_timeout(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameter.ProfileDiameterStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDiameterProfileDiameterStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameter.ProfileDiameterStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDiameterProfileDiameterStatistics
	{
		private LocalLBProfileDiameterProfileDiameterStatisticEntry [] statisticsField;
		public LocalLBProfileDiameterProfileDiameterStatisticEntry [] statistics
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
