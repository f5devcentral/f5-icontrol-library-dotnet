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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.LogProfileBinding", Namespace="urn:iControl")]
	public partial class SecurityLogProfile : iControlInterface {
		public SecurityLogProfile() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void add_application(
		string [] profile_names,
		string [] [] applications
	) {
		this.Invoke("add_application", new object [] {
				profile_names,
				applications});

	}
	public System.IAsyncResult Beginadd_application(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_application", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public void Endadd_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_application_request_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void add_application_request_filter(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileFilterKey [] [] [] keys,
		string [] [] [] [] values
	) {
		this.Invoke("add_application_request_filter", new object [] {
				profile_names,
				applications,
				keys,
				values});

	}
	public System.IAsyncResult Beginadd_application_request_filter(string [] profile_names,string [] [] applications,SecurityLogProfileFilterKey [] [] [] keys,string [] [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_application_request_filter", new object[] {
			profile_names,
			applications,
			keys,
			values}, callback, asyncState);
	}
	public void Endadd_application_request_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_application_request_filter_values
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void add_application_request_filter_values(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileFilterKey [] [] [] keys,
		string [] [] [] [] values
	) {
		this.Invoke("add_application_request_filter_values", new object [] {
				profile_names,
				applications,
				keys,
				values});

	}
	public System.IAsyncResult Beginadd_application_request_filter_values(string [] profile_names,string [] [] applications,SecurityLogProfileFilterKey [] [] [] keys,string [] [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_application_request_filter_values", new object[] {
			profile_names,
			applications,
			keys,
			values}, callback, asyncState);
	}
	public void Endadd_application_request_filter_values(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_application_server_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void add_application_server_address(
		string [] profile_names,
		string [] [] applications,
		CommonIPPortDefinition [] [] [] servers
	) {
		this.Invoke("add_application_server_address", new object [] {
				profile_names,
				applications,
				servers});

	}
	public System.IAsyncResult Beginadd_application_server_address(string [] profile_names,string [] [] applications,CommonIPPortDefinition [] [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_application_server_address", new object[] {
			profile_names,
			applications,
			servers}, callback, asyncState);
	}
	public void Endadd_application_server_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_network
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void add_network(
		string [] profile_names,
		string [] [] networks
	) {
		this.Invoke("add_network", new object [] {
				profile_names,
				networks});

	}
	public System.IAsyncResult Beginadd_network(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_network", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public void Endadd_network(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_protocol_dns
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void add_protocol_dns(
		string [] profile_names,
		string [] [] dnses
	) {
		this.Invoke("add_protocol_dns", new object [] {
				profile_names,
				dnses});

	}
	public System.IAsyncResult Beginadd_protocol_dns(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_protocol_dns", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public void Endadd_protocol_dns(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_protocol_sip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void add_protocol_sip(
		string [] profile_names,
		string [] [] sips
	) {
		this.Invoke("add_protocol_sip", new object [] {
				profile_names,
				sips});

	}
	public System.IAsyncResult Beginadd_protocol_sip(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_protocol_sip", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public void Endadd_protocol_sip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_protocol_transfer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void add_protocol_transfer(
		string [] profile_names,
		string [] [] protocols
	) {
		this.Invoke("add_protocol_transfer", new object [] {
				profile_names,
				protocols});

	}
	public System.IAsyncResult Beginadd_protocol_transfer(string [] profile_names,string [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_protocol_transfer", new object[] {
			profile_names,
			protocols}, callback, asyncState);
	}
	public void Endadd_protocol_transfer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
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
	// delete_all_log_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void delete_all_log_profiles(

	) {
		this.Invoke("delete_all_log_profiles", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_log_profiles(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_log_profiles", new object[0], callback, asyncState);
	}
	public void Enddelete_all_log_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void delete_log_profile(
		string [] profile_names
	) {
		this.Invoke("delete_log_profile", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begindelete_log_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_log_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Enddelete_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_application(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_application", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_facility
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileRemoteFacility [] [] get_application_facility(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_facility", new object [] {
				profile_names,
				applications});
		return ((SecurityLogProfileRemoteFacility [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_facility(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_facility", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public SecurityLogProfileRemoteFacility [] [] Endget_application_facility(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileRemoteFacility [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_field_delimiter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_application_field_delimiter(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_field_delimiter", new object [] {
				profile_names,
				applications});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_field_delimiter(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_field_delimiter", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public string [] [] Endget_application_field_delimiter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_field_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_application_field_format(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_field_format", new object [] {
				profile_names,
				applications});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_field_format(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_field_format", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public string [] [] Endget_application_field_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_fields
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_application_fields(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_fields", new object [] {
				profile_names,
				applications});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_fields(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_fields", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public string [] [] [] Endget_application_fields(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileStorageFormat [] [] get_application_format(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_format", new object [] {
				profile_names,
				applications});
		return ((SecurityLogProfileStorageFormat [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_format(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_format", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public SecurityLogProfileStorageFormat [] [] Endget_application_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileStorageFormat [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_guarantee_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_application_guarantee_logging_state(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_guarantee_logging_state", new object [] {
				profile_names,
				applications});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_guarantee_logging_state(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_guarantee_logging_state", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_application_guarantee_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_guarantee_response_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_application_guarantee_response_logging_state(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_guarantee_response_logging_state", new object [] {
				profile_names,
				applications});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_guarantee_response_logging_state(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_guarantee_response_logging_state", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_application_guarantee_response_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_local_storage_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_application_local_storage_state(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_local_storage_state", new object [] {
				profile_names,
				applications});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_local_storage_state(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_local_storage_state", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_application_local_storage_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_logic_operation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileLogicOperation [] [] get_application_logic_operation(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_logic_operation", new object [] {
				profile_names,
				applications});
		return ((SecurityLogProfileLogicOperation [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_logic_operation(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_logic_operation", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public SecurityLogProfileLogicOperation [] [] Endget_application_logic_operation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileLogicOperation [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_maximum_entry_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileEntryLength [] [] get_application_maximum_entry_length(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_maximum_entry_length", new object [] {
				profile_names,
				applications});
		return ((SecurityLogProfileEntryLength [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_maximum_entry_length(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_maximum_entry_length", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public SecurityLogProfileEntryLength [] [] Endget_application_maximum_entry_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileEntryLength [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_maximum_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_application_maximum_header_size(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_maximum_header_size", new object [] {
				profile_names,
				applications});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_maximum_header_size(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_maximum_header_size", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public long [] [] Endget_application_maximum_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_maximum_query_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_application_maximum_query_size(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_maximum_query_size", new object [] {
				profile_names,
				applications});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_maximum_query_size(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_maximum_query_size", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public long [] [] Endget_application_maximum_query_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_maximum_request_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_application_maximum_request_size(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_maximum_request_size", new object [] {
				profile_names,
				applications});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_maximum_request_size(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_maximum_request_size", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public long [] [] Endget_application_maximum_request_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileRemoteProtocol [] [] get_application_protocol(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_protocol", new object [] {
				profile_names,
				applications});
		return ((SecurityLogProfileRemoteProtocol [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_protocol(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_protocol", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public SecurityLogProfileRemoteProtocol [] [] Endget_application_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileRemoteProtocol [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_remote_storage
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileRemoteStorage [] [] get_application_remote_storage(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_remote_storage", new object [] {
				profile_names,
				applications});
		return ((SecurityLogProfileRemoteStorage [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_remote_storage(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_remote_storage", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public SecurityLogProfileRemoteStorage [] [] Endget_application_remote_storage(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileRemoteStorage [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_report_anomalies_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_application_report_anomalies_state(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_report_anomalies_state", new object [] {
				profile_names,
				applications});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_report_anomalies_state(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_report_anomalies_state", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_application_report_anomalies_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_request_filter_keys
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileFilterKey [] [] [] get_application_request_filter_keys(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_request_filter_keys", new object [] {
				profile_names,
				applications});
		return ((SecurityLogProfileFilterKey [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_request_filter_keys(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_request_filter_keys", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public SecurityLogProfileFilterKey [] [] [] Endget_application_request_filter_keys(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileFilterKey [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_request_filter_values
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] [] get_application_request_filter_values(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileFilterKey [] [] [] keys
	) {
		object [] results = this.Invoke("get_application_request_filter_values", new object [] {
				profile_names,
				applications,
				keys});
		return ((string [] [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_request_filter_values(string [] profile_names,string [] [] applications,SecurityLogProfileFilterKey [] [] [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_request_filter_values", new object[] {
			profile_names,
			applications,
			keys}, callback, asyncState);
	}
	public string [] [] [] [] Endget_application_request_filter_values(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_response_logging
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileResponseLogging [] [] get_application_response_logging(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_response_logging", new object [] {
				profile_names,
				applications});
		return ((SecurityLogProfileResponseLogging [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_response_logging(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_response_logging", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public SecurityLogProfileResponseLogging [] [] Endget_application_response_logging(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileResponseLogging [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_server_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPPortDefinition [] [] [] get_application_server_address(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_server_address", new object [] {
				profile_names,
				applications});
		return ((CommonIPPortDefinition [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_server_address(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_server_address", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public CommonIPPortDefinition [] [] [] Endget_application_server_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPPortDefinition [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_user_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_application_user_string(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_application_user_string", new object [] {
				profile_names,
				applications});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_user_string(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_user_string", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public string [] [] Endget_application_user_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
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
	// get_dns_dos_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_dns_dos_publisher(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns_dos_publisher", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_dos_publisher(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_dos_publisher", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_dns_dos_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dos_network_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_dos_network_publisher(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dos_network_publisher", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_dos_network_publisher(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dos_network_publisher", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_dos_network_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_intelligence_log_aggregate_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ip_intelligence_log_aggregate_rate_limit(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ip_intelligence_log_aggregate_rate_limit", new object [] {
				profile_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_intelligence_log_aggregate_rate_limit(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_intelligence_log_aggregate_rate_limit", new object[] {
			profile_names}, callback, asyncState);
	}
	public long [] Endget_ip_intelligence_log_aggregate_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_intelligence_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ip_intelligence_log_publisher(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ip_intelligence_log_publisher", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_intelligence_log_publisher(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_intelligence_log_publisher", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_ip_intelligence_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_intelligence_log_translation_fields_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_ip_intelligence_log_translation_fields_filter_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ip_intelligence_log_translation_fields_filter_state", new object [] {
				profile_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_intelligence_log_translation_fields_filter_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_intelligence_log_translation_fields_filter_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_ip_intelligence_log_translation_fields_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
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
	// get_network
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_network(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_network", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_network(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_field_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_network_field_format(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_field_format", new object [] {
				profile_names,
				networks});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_field_format(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_field_format", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public string [] [] Endget_network_field_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_field_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_network_field_list(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_field_list", new object [] {
				profile_names,
				networks});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_field_list(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_field_list", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public string [] [] [] Endget_network_field_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_field_list_delimiter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_network_field_list_delimiter(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_field_list_delimiter", new object [] {
				profile_names,
				networks});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_field_list_delimiter(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_field_list_delimiter", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public string [] [] Endget_network_field_list_delimiter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileNetworkStorageFormat [] [] get_network_format(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_format", new object [] {
				profile_names,
				networks});
		return ((SecurityLogProfileNetworkStorageFormat [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_format(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_format", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public SecurityLogProfileNetworkStorageFormat [] [] Endget_network_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileNetworkStorageFormat [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_acl_match_accept_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_network_log_acl_match_accept_filter_state(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_acl_match_accept_filter_state", new object [] {
				profile_names,
				networks});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_acl_match_accept_filter_state(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_acl_match_accept_filter_state", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_network_log_acl_match_accept_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_acl_match_accept_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_network_log_acl_match_accept_rate_limit(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_acl_match_accept_rate_limit", new object [] {
				profile_names,
				networks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_acl_match_accept_rate_limit(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_acl_match_accept_rate_limit", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public long [] [] Endget_network_log_acl_match_accept_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_acl_match_drop_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_network_log_acl_match_drop_filter_state(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_acl_match_drop_filter_state", new object [] {
				profile_names,
				networks});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_acl_match_drop_filter_state(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_acl_match_drop_filter_state", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_network_log_acl_match_drop_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_acl_match_drop_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_network_log_acl_match_drop_rate_limit(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_acl_match_drop_rate_limit", new object [] {
				profile_names,
				networks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_acl_match_drop_rate_limit(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_acl_match_drop_rate_limit", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public long [] [] Endget_network_log_acl_match_drop_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_acl_match_reject_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_network_log_acl_match_reject_filter_state(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_acl_match_reject_filter_state", new object [] {
				profile_names,
				networks});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_acl_match_reject_filter_state(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_acl_match_reject_filter_state", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_network_log_acl_match_reject_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_acl_match_reject_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_network_log_acl_match_reject_rate_limit(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_acl_match_reject_rate_limit", new object [] {
				profile_names,
				networks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_acl_match_reject_rate_limit(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_acl_match_reject_rate_limit", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public long [] [] Endget_network_log_acl_match_reject_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_aggregate_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_network_log_aggregate_rate_limit(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_aggregate_rate_limit", new object [] {
				profile_names,
				networks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_aggregate_rate_limit(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_aggregate_rate_limit", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public long [] [] Endget_network_log_aggregate_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_ip_errors_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_network_log_ip_errors_filter_state(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_ip_errors_filter_state", new object [] {
				profile_names,
				networks});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_ip_errors_filter_state(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_ip_errors_filter_state", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_network_log_ip_errors_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_ip_errors_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_network_log_ip_errors_rate_limit(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_ip_errors_rate_limit", new object [] {
				profile_names,
				networks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_ip_errors_rate_limit(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_ip_errors_rate_limit", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public long [] [] Endget_network_log_ip_errors_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_network_log_publisher(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_publisher", new object [] {
				profile_names,
				networks});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_publisher(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_publisher", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public string [] [] Endget_network_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_tcp_errors_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_network_log_tcp_errors_filter_state(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_tcp_errors_filter_state", new object [] {
				profile_names,
				networks});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_tcp_errors_filter_state(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_tcp_errors_filter_state", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_network_log_tcp_errors_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_tcp_errors_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_network_log_tcp_errors_rate_limit(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_tcp_errors_rate_limit", new object [] {
				profile_names,
				networks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_tcp_errors_rate_limit(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_tcp_errors_rate_limit", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public long [] [] Endget_network_log_tcp_errors_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_tcp_events_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_network_log_tcp_events_filter_state(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_tcp_events_filter_state", new object [] {
				profile_names,
				networks});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_tcp_events_filter_state(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_tcp_events_filter_state", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_network_log_tcp_events_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_tcp_events_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_network_log_tcp_events_rate_limit(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_tcp_events_rate_limit", new object [] {
				profile_names,
				networks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_tcp_events_rate_limit(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_tcp_events_rate_limit", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public long [] [] Endget_network_log_tcp_events_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_log_translation_fields_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_network_log_translation_fields_filter_state(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_log_translation_fields_filter_state", new object [] {
				profile_names,
				networks});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_log_translation_fields_filter_state(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_log_translation_fields_filter_state", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_network_log_translation_fields_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_user_defined_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_network_user_defined_string(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_user_defined_string", new object [] {
				profile_names,
				networks});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_user_defined_string(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_user_defined_string", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public string [] [] Endget_network_user_defined_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_dns(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_protocol_dns", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_protocol_dns(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_field_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_dns_field_format(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_field_format", new object [] {
				profile_names,
				dnses});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_field_format(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_field_format", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public string [] [] Endget_protocol_dns_field_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_field_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_protocol_dns_field_list(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_field_list", new object [] {
				profile_names,
				dnses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_field_list(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_field_list", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public string [] [] [] Endget_protocol_dns_field_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_field_list_delimiter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_dns_field_list_delimiter(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_field_list_delimiter", new object [] {
				profile_names,
				dnses});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_field_list_delimiter(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_field_list_delimiter", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public string [] [] Endget_protocol_dns_field_list_delimiter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileDNSStorageFormat [] [] get_protocol_dns_format(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_format", new object [] {
				profile_names,
				dnses});
		return ((SecurityLogProfileDNSStorageFormat [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_format(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_format", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public SecurityLogProfileDNSStorageFormat [] [] Endget_protocol_dns_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileDNSStorageFormat [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_log_drop_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_dns_log_drop_filter_state(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_log_drop_filter_state", new object [] {
				profile_names,
				dnses});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_log_drop_filter_state(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_log_drop_filter_state", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_dns_log_drop_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_log_filtered_drop_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_dns_log_filtered_drop_filter_state(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_log_filtered_drop_filter_state", new object [] {
				profile_names,
				dnses});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_log_filtered_drop_filter_state(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_log_filtered_drop_filter_state", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_dns_log_filtered_drop_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_log_malformed_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_dns_log_malformed_filter_state(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_log_malformed_filter_state", new object [] {
				profile_names,
				dnses});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_log_malformed_filter_state(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_log_malformed_filter_state", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_dns_log_malformed_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_log_malicious_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_dns_log_malicious_filter_state(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_log_malicious_filter_state", new object [] {
				profile_names,
				dnses});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_log_malicious_filter_state(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_log_malicious_filter_state", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_dns_log_malicious_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_dns_log_publisher(
		string [] profile_names,
		string [] [] protocols
	) {
		object [] results = this.Invoke("get_protocol_dns_log_publisher", new object [] {
				profile_names,
				protocols});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_log_publisher(string [] profile_names,string [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_log_publisher", new object[] {
			profile_names,
			protocols}, callback, asyncState);
	}
	public string [] [] Endget_protocol_dns_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_log_reject_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_dns_log_reject_filter_state(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_log_reject_filter_state", new object [] {
				profile_names,
				dnses});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_log_reject_filter_state(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_log_reject_filter_state", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_dns_log_reject_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_user_defined_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_dns_user_defined_string(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_user_defined_string", new object [] {
				profile_names,
				dnses});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_user_defined_string(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_user_defined_string", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public string [] [] Endget_protocol_dns_user_defined_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_sip(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_protocol_sip", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_protocol_sip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_field_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_sip_field_format(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_field_format", new object [] {
				profile_names,
				sips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_field_format(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_field_format", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public string [] [] Endget_protocol_sip_field_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_field_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_protocol_sip_field_list(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_field_list", new object [] {
				profile_names,
				sips});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_field_list(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_field_list", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public string [] [] [] Endget_protocol_sip_field_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_field_list_delimiter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_sip_field_list_delimiter(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_field_list_delimiter", new object [] {
				profile_names,
				sips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_field_list_delimiter(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_field_list_delimiter", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public string [] [] Endget_protocol_sip_field_list_delimiter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityLogProfileSIPStorageFormat [] [] get_protocol_sip_format(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_format", new object [] {
				profile_names,
				sips});
		return ((SecurityLogProfileSIPStorageFormat [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_format(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_format", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public SecurityLogProfileSIPStorageFormat [] [] Endget_protocol_sip_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityLogProfileSIPStorageFormat [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_log_drop_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_sip_log_drop_filter_state(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_log_drop_filter_state", new object [] {
				profile_names,
				sips});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_log_drop_filter_state(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_log_drop_filter_state", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_sip_log_drop_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_log_global_failures_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_sip_log_global_failures_filter_state(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_log_global_failures_filter_state", new object [] {
				profile_names,
				sips});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_log_global_failures_filter_state(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_log_global_failures_filter_state", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_sip_log_global_failures_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_log_malformed_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_sip_log_malformed_filter_state(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_log_malformed_filter_state", new object [] {
				profile_names,
				sips});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_log_malformed_filter_state(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_log_malformed_filter_state", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_sip_log_malformed_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_sip_log_publisher(
		string [] profile_names,
		string [] [] protocols
	) {
		object [] results = this.Invoke("get_protocol_sip_log_publisher", new object [] {
				profile_names,
				protocols});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_log_publisher(string [] profile_names,string [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_log_publisher", new object[] {
			profile_names,
			protocols}, callback, asyncState);
	}
	public string [] [] Endget_protocol_sip_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_log_redirection_responses_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_sip_log_redirection_responses_filter_state(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_log_redirection_responses_filter_state", new object [] {
				profile_names,
				sips});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_log_redirection_responses_filter_state(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_log_redirection_responses_filter_state", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_sip_log_redirection_responses_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_log_request_failures_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_sip_log_request_failures_filter_state(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_log_request_failures_filter_state", new object [] {
				profile_names,
				sips});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_log_request_failures_filter_state(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_log_request_failures_filter_state", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_sip_log_request_failures_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_log_server_errors_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_sip_log_server_errors_filter_state(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_log_server_errors_filter_state", new object [] {
				profile_names,
				sips});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_log_server_errors_filter_state(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_log_server_errors_filter_state", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_sip_log_server_errors_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_user_defined_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_sip_user_defined_string(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_user_defined_string", new object [] {
				profile_names,
				sips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_user_defined_string(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_user_defined_string", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public string [] [] Endget_protocol_sip_user_defined_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_transfer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_transfer(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_protocol_transfer", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_transfer(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_transfer", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_protocol_transfer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_transfer_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_transfer_publisher(
		string [] profile_names,
		string [] [] protocols
	) {
		object [] results = this.Invoke("get_protocol_transfer_publisher", new object [] {
				profile_names,
				protocols});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_transfer_publisher(string [] profile_names,string [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_transfer_publisher", new object[] {
			profile_names,
			protocols}, callback, asyncState);
	}
	public string [] [] Endget_protocol_transfer_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sip_dos_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_sip_dos_publisher(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sip_dos_publisher", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_sip_dos_publisher(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sip_dos_publisher", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_sip_dos_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
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
	// is_system_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_system_log_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_system_log_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_system_log_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_system_log_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_system_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_application_request_filters
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_all_application_request_filters(
		string [] profile_names,
		string [] [] applications
	) {
		this.Invoke("remove_all_application_request_filters", new object [] {
				profile_names,
				applications});

	}
	public System.IAsyncResult Beginremove_all_application_request_filters(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_application_request_filters", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public void Endremove_all_application_request_filters(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_application_server_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_all_application_server_addresses(
		string [] profile_names,
		string [] [] applications
	) {
		this.Invoke("remove_all_application_server_addresses", new object [] {
				profile_names,
				applications});

	}
	public System.IAsyncResult Beginremove_all_application_server_addresses(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_application_server_addresses", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public void Endremove_all_application_server_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_applications
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_all_applications(
		string [] profile_names
	) {
		this.Invoke("remove_all_applications", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_applications(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_applications", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_applications(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_networks
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_all_networks(
		string [] profile_names
	) {
		this.Invoke("remove_all_networks", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_networks(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_networks", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_networks(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_protocol_dnses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_all_protocol_dnses(
		string [] profile_names
	) {
		this.Invoke("remove_all_protocol_dnses", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_protocol_dnses(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_protocol_dnses", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_protocol_dnses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_protocol_sips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_all_protocol_sips(
		string [] profile_names
	) {
		this.Invoke("remove_all_protocol_sips", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_protocol_sips(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_protocol_sips", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_protocol_sips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_protocol_transfers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_all_protocol_transfers(
		string [] profile_names
	) {
		this.Invoke("remove_all_protocol_transfers", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_protocol_transfers(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_protocol_transfers", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_protocol_transfers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_application(
		string [] profile_names,
		string [] [] applications
	) {
		this.Invoke("remove_application", new object [] {
				profile_names,
				applications});

	}
	public System.IAsyncResult Beginremove_application(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_application", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public void Endremove_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_application_request_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_application_request_filter(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileFilterKey [] [] [] keys
	) {
		this.Invoke("remove_application_request_filter", new object [] {
				profile_names,
				applications,
				keys});

	}
	public System.IAsyncResult Beginremove_application_request_filter(string [] profile_names,string [] [] applications,SecurityLogProfileFilterKey [] [] [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_application_request_filter", new object[] {
			profile_names,
			applications,
			keys}, callback, asyncState);
	}
	public void Endremove_application_request_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_application_request_filter_values
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_application_request_filter_values(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileFilterKey [] [] [] keys,
		string [] [] [] [] values
	) {
		this.Invoke("remove_application_request_filter_values", new object [] {
				profile_names,
				applications,
				keys,
				values});

	}
	public System.IAsyncResult Beginremove_application_request_filter_values(string [] profile_names,string [] [] applications,SecurityLogProfileFilterKey [] [] [] keys,string [] [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_application_request_filter_values", new object[] {
			profile_names,
			applications,
			keys,
			values}, callback, asyncState);
	}
	public void Endremove_application_request_filter_values(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_application_server_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_application_server_address(
		string [] profile_names,
		string [] [] applications,
		CommonIPPortDefinition [] [] [] servers
	) {
		this.Invoke("remove_application_server_address", new object [] {
				profile_names,
				applications,
				servers});

	}
	public System.IAsyncResult Beginremove_application_server_address(string [] profile_names,string [] [] applications,CommonIPPortDefinition [] [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_application_server_address", new object[] {
			profile_names,
			applications,
			servers}, callback, asyncState);
	}
	public void Endremove_application_server_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_network
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_network(
		string [] profile_names,
		string [] [] networks
	) {
		this.Invoke("remove_network", new object [] {
				profile_names,
				networks});

	}
	public System.IAsyncResult Beginremove_network(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_network", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public void Endremove_network(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_protocol_dns
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_protocol_dns(
		string [] profile_names,
		string [] [] dnses
	) {
		this.Invoke("remove_protocol_dns", new object [] {
				profile_names,
				dnses});

	}
	public System.IAsyncResult Beginremove_protocol_dns(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_protocol_dns", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public void Endremove_protocol_dns(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_protocol_sip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_protocol_sip(
		string [] profile_names,
		string [] [] sips
	) {
		this.Invoke("remove_protocol_sip", new object [] {
				profile_names,
				sips});

	}
	public System.IAsyncResult Beginremove_protocol_sip(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_protocol_sip", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public void Endremove_protocol_sip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_protocol_transfer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void remove_protocol_transfer(
		string [] profile_names,
		string [] [] protocols
	) {
		this.Invoke("remove_protocol_transfer", new object [] {
				profile_names,
				protocols});

	}
	public System.IAsyncResult Beginremove_protocol_transfer(string [] profile_names,string [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_protocol_transfer", new object[] {
			profile_names,
			protocols}, callback, asyncState);
	}
	public void Endremove_protocol_transfer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_application_fields
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void replace_application_fields(
		string [] profile_names,
		string [] [] applications,
		string [] [] [] fields
	) {
		this.Invoke("replace_application_fields", new object [] {
				profile_names,
				applications,
				fields});

	}
	public System.IAsyncResult Beginreplace_application_fields(string [] profile_names,string [] [] applications,string [] [] [] fields, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_application_fields", new object[] {
			profile_names,
			applications,
			fields}, callback, asyncState);
	}
	public void Endreplace_application_fields(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_application_request_filter_values
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void replace_application_request_filter_values(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileFilterKey [] [] [] keys,
		string [] [] [] [] values
	) {
		this.Invoke("replace_application_request_filter_values", new object [] {
				profile_names,
				applications,
				keys,
				values});

	}
	public System.IAsyncResult Beginreplace_application_request_filter_values(string [] profile_names,string [] [] applications,SecurityLogProfileFilterKey [] [] [] keys,string [] [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_application_request_filter_values", new object[] {
			profile_names,
			applications,
			keys,
			values}, callback, asyncState);
	}
	public void Endreplace_application_request_filter_values(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_network_field_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void replace_network_field_list(
		string [] profile_names,
		string [] [] networks,
		string [] [] [] fields
	) {
		this.Invoke("replace_network_field_list", new object [] {
				profile_names,
				networks,
				fields});

	}
	public System.IAsyncResult Beginreplace_network_field_list(string [] profile_names,string [] [] networks,string [] [] [] fields, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_network_field_list", new object[] {
			profile_names,
			networks,
			fields}, callback, asyncState);
	}
	public void Endreplace_network_field_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_protocol_dns_field_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void replace_protocol_dns_field_list(
		string [] profile_names,
		string [] [] dnses,
		string [] [] [] fields
	) {
		this.Invoke("replace_protocol_dns_field_list", new object [] {
				profile_names,
				dnses,
				fields});

	}
	public System.IAsyncResult Beginreplace_protocol_dns_field_list(string [] profile_names,string [] [] dnses,string [] [] [] fields, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_protocol_dns_field_list", new object[] {
			profile_names,
			dnses,
			fields}, callback, asyncState);
	}
	public void Endreplace_protocol_dns_field_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_protocol_sip_field_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void replace_protocol_sip_field_list(
		string [] profile_names,
		string [] [] sips,
		string [] [] [] fields
	) {
		this.Invoke("replace_protocol_sip_field_list", new object [] {
				profile_names,
				sips,
				fields});

	}
	public System.IAsyncResult Beginreplace_protocol_sip_field_list(string [] profile_names,string [] [] sips,string [] [] [] fields, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_protocol_sip_field_list", new object[] {
			profile_names,
			sips,
			fields}, callback, asyncState);
	}
	public void Endreplace_protocol_sip_field_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_facility
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_facility(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileRemoteFacility [] [] facilities
	) {
		this.Invoke("set_application_facility", new object [] {
				profile_names,
				applications,
				facilities});

	}
	public System.IAsyncResult Beginset_application_facility(string [] profile_names,string [] [] applications,SecurityLogProfileRemoteFacility [] [] facilities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_facility", new object[] {
			profile_names,
			applications,
			facilities}, callback, asyncState);
	}
	public void Endset_application_facility(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_field_delimiter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_field_delimiter(
		string [] profile_names,
		string [] [] applications,
		string [] [] texts
	) {
		this.Invoke("set_application_field_delimiter", new object [] {
				profile_names,
				applications,
				texts});

	}
	public System.IAsyncResult Beginset_application_field_delimiter(string [] profile_names,string [] [] applications,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_field_delimiter", new object[] {
			profile_names,
			applications,
			texts}, callback, asyncState);
	}
	public void Endset_application_field_delimiter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_field_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_field_format(
		string [] profile_names,
		string [] [] applications,
		string [] [] texts
	) {
		this.Invoke("set_application_field_format", new object [] {
				profile_names,
				applications,
				texts});

	}
	public System.IAsyncResult Beginset_application_field_format(string [] profile_names,string [] [] applications,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_field_format", new object[] {
			profile_names,
			applications,
			texts}, callback, asyncState);
	}
	public void Endset_application_field_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_format_predefined
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_format_predefined(
		string [] profile_names,
		string [] [] applications,
		string [] [] [] fields
	) {
		this.Invoke("set_application_format_predefined", new object [] {
				profile_names,
				applications,
				fields});

	}
	public System.IAsyncResult Beginset_application_format_predefined(string [] profile_names,string [] [] applications,string [] [] [] fields, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_format_predefined", new object[] {
			profile_names,
			applications,
			fields}, callback, asyncState);
	}
	public void Endset_application_format_predefined(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_format_user_defined
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_format_user_defined(
		string [] profile_names,
		string [] [] applications,
		string [] [] texts
	) {
		this.Invoke("set_application_format_user_defined", new object [] {
				profile_names,
				applications,
				texts});

	}
	public System.IAsyncResult Beginset_application_format_user_defined(string [] profile_names,string [] [] applications,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_format_user_defined", new object[] {
			profile_names,
			applications,
			texts}, callback, asyncState);
	}
	public void Endset_application_format_user_defined(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_guarantee_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_guarantee_logging_state(
		string [] profile_names,
		string [] [] applications,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_application_guarantee_logging_state", new object [] {
				profile_names,
				applications,
				states});

	}
	public System.IAsyncResult Beginset_application_guarantee_logging_state(string [] profile_names,string [] [] applications,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_guarantee_logging_state", new object[] {
			profile_names,
			applications,
			states}, callback, asyncState);
	}
	public void Endset_application_guarantee_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_guarantee_response_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_guarantee_response_logging_state(
		string [] profile_names,
		string [] [] applications,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_application_guarantee_response_logging_state", new object [] {
				profile_names,
				applications,
				states});

	}
	public System.IAsyncResult Beginset_application_guarantee_response_logging_state(string [] profile_names,string [] [] applications,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_guarantee_response_logging_state", new object[] {
			profile_names,
			applications,
			states}, callback, asyncState);
	}
	public void Endset_application_guarantee_response_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_local_storage_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_local_storage_state(
		string [] profile_names,
		string [] [] applications,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_application_local_storage_state", new object [] {
				profile_names,
				applications,
				states});

	}
	public System.IAsyncResult Beginset_application_local_storage_state(string [] profile_names,string [] [] applications,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_local_storage_state", new object[] {
			profile_names,
			applications,
			states}, callback, asyncState);
	}
	public void Endset_application_local_storage_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_logic_operation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_logic_operation(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileLogicOperation [] [] operations
	) {
		this.Invoke("set_application_logic_operation", new object [] {
				profile_names,
				applications,
				operations});

	}
	public System.IAsyncResult Beginset_application_logic_operation(string [] profile_names,string [] [] applications,SecurityLogProfileLogicOperation [] [] operations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_logic_operation", new object[] {
			profile_names,
			applications,
			operations}, callback, asyncState);
	}
	public void Endset_application_logic_operation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_maximum_entry_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_maximum_entry_length(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileEntryLength [] [] lengths
	) {
		this.Invoke("set_application_maximum_entry_length", new object [] {
				profile_names,
				applications,
				lengths});

	}
	public System.IAsyncResult Beginset_application_maximum_entry_length(string [] profile_names,string [] [] applications,SecurityLogProfileEntryLength [] [] lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_maximum_entry_length", new object[] {
			profile_names,
			applications,
			lengths}, callback, asyncState);
	}
	public void Endset_application_maximum_entry_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_maximum_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_maximum_header_size(
		string [] profile_names,
		string [] [] applications,
		long [] [] values
	) {
		this.Invoke("set_application_maximum_header_size", new object [] {
				profile_names,
				applications,
				values});

	}
	public System.IAsyncResult Beginset_application_maximum_header_size(string [] profile_names,string [] [] applications,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_maximum_header_size", new object[] {
			profile_names,
			applications,
			values}, callback, asyncState);
	}
	public void Endset_application_maximum_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_maximum_query_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_maximum_query_size(
		string [] profile_names,
		string [] [] applications,
		long [] [] values
	) {
		this.Invoke("set_application_maximum_query_size", new object [] {
				profile_names,
				applications,
				values});

	}
	public System.IAsyncResult Beginset_application_maximum_query_size(string [] profile_names,string [] [] applications,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_maximum_query_size", new object[] {
			profile_names,
			applications,
			values}, callback, asyncState);
	}
	public void Endset_application_maximum_query_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_maximum_request_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_maximum_request_size(
		string [] profile_names,
		string [] [] applications,
		long [] [] values
	) {
		this.Invoke("set_application_maximum_request_size", new object [] {
				profile_names,
				applications,
				values});

	}
	public System.IAsyncResult Beginset_application_maximum_request_size(string [] profile_names,string [] [] applications,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_maximum_request_size", new object[] {
			profile_names,
			applications,
			values}, callback, asyncState);
	}
	public void Endset_application_maximum_request_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_protocol(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileRemoteProtocol [] [] protocols
	) {
		this.Invoke("set_application_protocol", new object [] {
				profile_names,
				applications,
				protocols});

	}
	public System.IAsyncResult Beginset_application_protocol(string [] profile_names,string [] [] applications,SecurityLogProfileRemoteProtocol [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_protocol", new object[] {
			profile_names,
			applications,
			protocols}, callback, asyncState);
	}
	public void Endset_application_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_remote_format_predefined
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_remote_format_predefined(
		string [] profile_names,
		string [] [] applications,
		string [] [] [] fields
	) {
		this.Invoke("set_application_remote_format_predefined", new object [] {
				profile_names,
				applications,
				fields});

	}
	public System.IAsyncResult Beginset_application_remote_format_predefined(string [] profile_names,string [] [] applications,string [] [] [] fields, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_remote_format_predefined", new object[] {
			profile_names,
			applications,
			fields}, callback, asyncState);
	}
	public void Endset_application_remote_format_predefined(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_remote_format_user_defined
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_remote_format_user_defined(
		string [] profile_names,
		string [] [] applications,
		string [] [] texts
	) {
		this.Invoke("set_application_remote_format_user_defined", new object [] {
				profile_names,
				applications,
				texts});

	}
	public System.IAsyncResult Beginset_application_remote_format_user_defined(string [] profile_names,string [] [] applications,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_remote_format_user_defined", new object[] {
			profile_names,
			applications,
			texts}, callback, asyncState);
	}
	public void Endset_application_remote_format_user_defined(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_remote_storage
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_remote_storage(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileRemoteStorage [] [] types
	) {
		this.Invoke("set_application_remote_storage", new object [] {
				profile_names,
				applications,
				types});

	}
	public System.IAsyncResult Beginset_application_remote_storage(string [] profile_names,string [] [] applications,SecurityLogProfileRemoteStorage [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_remote_storage", new object[] {
			profile_names,
			applications,
			types}, callback, asyncState);
	}
	public void Endset_application_remote_storage(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_report_anomalies_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_report_anomalies_state(
		string [] profile_names,
		string [] [] applications,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_application_report_anomalies_state", new object [] {
				profile_names,
				applications,
				states});

	}
	public System.IAsyncResult Beginset_application_report_anomalies_state(string [] profile_names,string [] [] applications,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_report_anomalies_state", new object[] {
			profile_names,
			applications,
			states}, callback, asyncState);
	}
	public void Endset_application_report_anomalies_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_response_logging
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_response_logging(
		string [] profile_names,
		string [] [] applications,
		SecurityLogProfileResponseLogging [] [] types
	) {
		this.Invoke("set_application_response_logging", new object [] {
				profile_names,
				applications,
				types});

	}
	public System.IAsyncResult Beginset_application_response_logging(string [] profile_names,string [] [] applications,SecurityLogProfileResponseLogging [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_response_logging", new object[] {
			profile_names,
			applications,
			types}, callback, asyncState);
	}
	public void Endset_application_response_logging(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application_user_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_application_user_string(
		string [] profile_names,
		string [] [] applications,
		string [] [] texts
	) {
		this.Invoke("set_application_user_string", new object [] {
				profile_names,
				applications,
				texts});

	}
	public System.IAsyncResult Beginset_application_user_string(string [] profile_names,string [] [] applications,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_user_string", new object[] {
			profile_names,
			applications,
			texts}, callback, asyncState);
	}
	public void Endset_application_user_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
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
	// set_dns_dos_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_dns_dos_publisher(
		string [] profile_names,
		string [] publishers
	) {
		this.Invoke("set_dns_dos_publisher", new object [] {
				profile_names,
				publishers});

	}
	public System.IAsyncResult Beginset_dns_dos_publisher(string [] profile_names,string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_dos_publisher", new object[] {
			profile_names,
			publishers}, callback, asyncState);
	}
	public void Endset_dns_dos_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_network_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_dos_network_publisher(
		string [] profile_names,
		string [] publishers
	) {
		this.Invoke("set_dos_network_publisher", new object [] {
				profile_names,
				publishers});

	}
	public System.IAsyncResult Beginset_dos_network_publisher(string [] profile_names,string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_network_publisher", new object[] {
			profile_names,
			publishers}, callback, asyncState);
	}
	public void Endset_dos_network_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_intelligence_log_aggregate_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_ip_intelligence_log_aggregate_rate_limit(
		string [] profile_names,
		long [] values
	) {
		this.Invoke("set_ip_intelligence_log_aggregate_rate_limit", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_ip_intelligence_log_aggregate_rate_limit(string [] profile_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_intelligence_log_aggregate_rate_limit", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_ip_intelligence_log_aggregate_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_intelligence_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_ip_intelligence_log_publisher(
		string [] profile_names,
		string [] publishers
	) {
		this.Invoke("set_ip_intelligence_log_publisher", new object [] {
				profile_names,
				publishers});

	}
	public System.IAsyncResult Beginset_ip_intelligence_log_publisher(string [] profile_names,string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_intelligence_log_publisher", new object[] {
			profile_names,
			publishers}, callback, asyncState);
	}
	public void Endset_ip_intelligence_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_intelligence_log_translation_fields_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_ip_intelligence_log_translation_fields_filter_state(
		string [] profile_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_ip_intelligence_log_translation_fields_filter_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_ip_intelligence_log_translation_fields_filter_state(string [] profile_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_intelligence_log_translation_fields_filter_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_ip_intelligence_log_translation_fields_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_field_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_field_format(
		string [] profile_names,
		string [] [] networks,
		string [] [] texts
	) {
		this.Invoke("set_network_field_format", new object [] {
				profile_names,
				networks,
				texts});

	}
	public System.IAsyncResult Beginset_network_field_format(string [] profile_names,string [] [] networks,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_field_format", new object[] {
			profile_names,
			networks,
			texts}, callback, asyncState);
	}
	public void Endset_network_field_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_field_list_delimiter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_field_list_delimiter(
		string [] profile_names,
		string [] [] networks,
		string [] [] texts
	) {
		this.Invoke("set_network_field_list_delimiter", new object [] {
				profile_names,
				networks,
				texts});

	}
	public System.IAsyncResult Beginset_network_field_list_delimiter(string [] profile_names,string [] [] networks,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_field_list_delimiter", new object[] {
			profile_names,
			networks,
			texts}, callback, asyncState);
	}
	public void Endset_network_field_list_delimiter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_format_field_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_format_field_list(
		string [] profile_names,
		string [] [] networks,
		string [] [] [] fields
	) {
		this.Invoke("set_network_format_field_list", new object [] {
				profile_names,
				networks,
				fields});

	}
	public System.IAsyncResult Beginset_network_format_field_list(string [] profile_names,string [] [] networks,string [] [] [] fields, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_format_field_list", new object[] {
			profile_names,
			networks,
			fields}, callback, asyncState);
	}
	public void Endset_network_format_field_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_format_user_defined
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_format_user_defined(
		string [] profile_names,
		string [] [] networks,
		string [] [] texts
	) {
		this.Invoke("set_network_format_user_defined", new object [] {
				profile_names,
				networks,
				texts});

	}
	public System.IAsyncResult Beginset_network_format_user_defined(string [] profile_names,string [] [] networks,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_format_user_defined", new object[] {
			profile_names,
			networks,
			texts}, callback, asyncState);
	}
	public void Endset_network_format_user_defined(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_acl_match_accept_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_acl_match_accept_filter_state(
		string [] profile_names,
		string [] [] networks,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_network_log_acl_match_accept_filter_state", new object [] {
				profile_names,
				networks,
				states});

	}
	public System.IAsyncResult Beginset_network_log_acl_match_accept_filter_state(string [] profile_names,string [] [] networks,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_acl_match_accept_filter_state", new object[] {
			profile_names,
			networks,
			states}, callback, asyncState);
	}
	public void Endset_network_log_acl_match_accept_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_acl_match_accept_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_acl_match_accept_rate_limit(
		string [] profile_names,
		string [] [] networks,
		long [] [] values
	) {
		this.Invoke("set_network_log_acl_match_accept_rate_limit", new object [] {
				profile_names,
				networks,
				values});

	}
	public System.IAsyncResult Beginset_network_log_acl_match_accept_rate_limit(string [] profile_names,string [] [] networks,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_acl_match_accept_rate_limit", new object[] {
			profile_names,
			networks,
			values}, callback, asyncState);
	}
	public void Endset_network_log_acl_match_accept_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_acl_match_drop_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_acl_match_drop_filter_state(
		string [] profile_names,
		string [] [] networks,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_network_log_acl_match_drop_filter_state", new object [] {
				profile_names,
				networks,
				states});

	}
	public System.IAsyncResult Beginset_network_log_acl_match_drop_filter_state(string [] profile_names,string [] [] networks,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_acl_match_drop_filter_state", new object[] {
			profile_names,
			networks,
			states}, callback, asyncState);
	}
	public void Endset_network_log_acl_match_drop_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_acl_match_drop_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_acl_match_drop_rate_limit(
		string [] profile_names,
		string [] [] networks,
		long [] [] values
	) {
		this.Invoke("set_network_log_acl_match_drop_rate_limit", new object [] {
				profile_names,
				networks,
				values});

	}
	public System.IAsyncResult Beginset_network_log_acl_match_drop_rate_limit(string [] profile_names,string [] [] networks,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_acl_match_drop_rate_limit", new object[] {
			profile_names,
			networks,
			values}, callback, asyncState);
	}
	public void Endset_network_log_acl_match_drop_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_acl_match_reject_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_acl_match_reject_filter_state(
		string [] profile_names,
		string [] [] networks,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_network_log_acl_match_reject_filter_state", new object [] {
				profile_names,
				networks,
				states});

	}
	public System.IAsyncResult Beginset_network_log_acl_match_reject_filter_state(string [] profile_names,string [] [] networks,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_acl_match_reject_filter_state", new object[] {
			profile_names,
			networks,
			states}, callback, asyncState);
	}
	public void Endset_network_log_acl_match_reject_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_acl_match_reject_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_acl_match_reject_rate_limit(
		string [] profile_names,
		string [] [] networks,
		long [] [] values
	) {
		this.Invoke("set_network_log_acl_match_reject_rate_limit", new object [] {
				profile_names,
				networks,
				values});

	}
	public System.IAsyncResult Beginset_network_log_acl_match_reject_rate_limit(string [] profile_names,string [] [] networks,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_acl_match_reject_rate_limit", new object[] {
			profile_names,
			networks,
			values}, callback, asyncState);
	}
	public void Endset_network_log_acl_match_reject_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_aggregate_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_aggregate_rate_limit(
		string [] profile_names,
		string [] [] networks,
		long [] [] values
	) {
		this.Invoke("set_network_log_aggregate_rate_limit", new object [] {
				profile_names,
				networks,
				values});

	}
	public System.IAsyncResult Beginset_network_log_aggregate_rate_limit(string [] profile_names,string [] [] networks,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_aggregate_rate_limit", new object[] {
			profile_names,
			networks,
			values}, callback, asyncState);
	}
	public void Endset_network_log_aggregate_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_ip_errors_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_ip_errors_filter_state(
		string [] profile_names,
		string [] [] networks,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_network_log_ip_errors_filter_state", new object [] {
				profile_names,
				networks,
				states});

	}
	public System.IAsyncResult Beginset_network_log_ip_errors_filter_state(string [] profile_names,string [] [] networks,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_ip_errors_filter_state", new object[] {
			profile_names,
			networks,
			states}, callback, asyncState);
	}
	public void Endset_network_log_ip_errors_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_ip_errors_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_ip_errors_rate_limit(
		string [] profile_names,
		string [] [] networks,
		long [] [] values
	) {
		this.Invoke("set_network_log_ip_errors_rate_limit", new object [] {
				profile_names,
				networks,
				values});

	}
	public System.IAsyncResult Beginset_network_log_ip_errors_rate_limit(string [] profile_names,string [] [] networks,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_ip_errors_rate_limit", new object[] {
			profile_names,
			networks,
			values}, callback, asyncState);
	}
	public void Endset_network_log_ip_errors_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_publisher(
		string [] profile_names,
		string [] [] networks,
		string [] [] publishers
	) {
		this.Invoke("set_network_log_publisher", new object [] {
				profile_names,
				networks,
				publishers});

	}
	public System.IAsyncResult Beginset_network_log_publisher(string [] profile_names,string [] [] networks,string [] [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_publisher", new object[] {
			profile_names,
			networks,
			publishers}, callback, asyncState);
	}
	public void Endset_network_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_tcp_errors_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_tcp_errors_filter_state(
		string [] profile_names,
		string [] [] networks,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_network_log_tcp_errors_filter_state", new object [] {
				profile_names,
				networks,
				states});

	}
	public System.IAsyncResult Beginset_network_log_tcp_errors_filter_state(string [] profile_names,string [] [] networks,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_tcp_errors_filter_state", new object[] {
			profile_names,
			networks,
			states}, callback, asyncState);
	}
	public void Endset_network_log_tcp_errors_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_tcp_errors_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_tcp_errors_rate_limit(
		string [] profile_names,
		string [] [] networks,
		long [] [] values
	) {
		this.Invoke("set_network_log_tcp_errors_rate_limit", new object [] {
				profile_names,
				networks,
				values});

	}
	public System.IAsyncResult Beginset_network_log_tcp_errors_rate_limit(string [] profile_names,string [] [] networks,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_tcp_errors_rate_limit", new object[] {
			profile_names,
			networks,
			values}, callback, asyncState);
	}
	public void Endset_network_log_tcp_errors_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_tcp_events_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_tcp_events_filter_state(
		string [] profile_names,
		string [] [] networks,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_network_log_tcp_events_filter_state", new object [] {
				profile_names,
				networks,
				states});

	}
	public System.IAsyncResult Beginset_network_log_tcp_events_filter_state(string [] profile_names,string [] [] networks,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_tcp_events_filter_state", new object[] {
			profile_names,
			networks,
			states}, callback, asyncState);
	}
	public void Endset_network_log_tcp_events_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_tcp_events_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_tcp_events_rate_limit(
		string [] profile_names,
		string [] [] networks,
		long [] [] values
	) {
		this.Invoke("set_network_log_tcp_events_rate_limit", new object [] {
				profile_names,
				networks,
				values});

	}
	public System.IAsyncResult Beginset_network_log_tcp_events_rate_limit(string [] profile_names,string [] [] networks,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_tcp_events_rate_limit", new object[] {
			profile_names,
			networks,
			values}, callback, asyncState);
	}
	public void Endset_network_log_tcp_events_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_log_translation_fields_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_log_translation_fields_filter_state(
		string [] profile_names,
		string [] [] networks,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_network_log_translation_fields_filter_state", new object [] {
				profile_names,
				networks,
				states});

	}
	public System.IAsyncResult Beginset_network_log_translation_fields_filter_state(string [] profile_names,string [] [] networks,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_log_translation_fields_filter_state", new object[] {
			profile_names,
			networks,
			states}, callback, asyncState);
	}
	public void Endset_network_log_translation_fields_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_user_defined_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_network_user_defined_string(
		string [] profile_names,
		string [] [] networks,
		string [] [] texts
	) {
		this.Invoke("set_network_user_defined_string", new object [] {
				profile_names,
				networks,
				texts});

	}
	public System.IAsyncResult Beginset_network_user_defined_string(string [] profile_names,string [] [] networks,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_user_defined_string", new object[] {
			profile_names,
			networks,
			texts}, callback, asyncState);
	}
	public void Endset_network_user_defined_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_field_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_field_format(
		string [] profile_names,
		string [] [] dnses,
		string [] [] texts
	) {
		this.Invoke("set_protocol_dns_field_format", new object [] {
				profile_names,
				dnses,
				texts});

	}
	public System.IAsyncResult Beginset_protocol_dns_field_format(string [] profile_names,string [] [] dnses,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_field_format", new object[] {
			profile_names,
			dnses,
			texts}, callback, asyncState);
	}
	public void Endset_protocol_dns_field_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_field_list_delimiter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_field_list_delimiter(
		string [] profile_names,
		string [] [] dnses,
		string [] [] texts
	) {
		this.Invoke("set_protocol_dns_field_list_delimiter", new object [] {
				profile_names,
				dnses,
				texts});

	}
	public System.IAsyncResult Beginset_protocol_dns_field_list_delimiter(string [] profile_names,string [] [] dnses,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_field_list_delimiter", new object[] {
			profile_names,
			dnses,
			texts}, callback, asyncState);
	}
	public void Endset_protocol_dns_field_list_delimiter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_format_field_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_format_field_list(
		string [] profile_names,
		string [] [] dnses,
		string [] [] [] fields
	) {
		this.Invoke("set_protocol_dns_format_field_list", new object [] {
				profile_names,
				dnses,
				fields});

	}
	public System.IAsyncResult Beginset_protocol_dns_format_field_list(string [] profile_names,string [] [] dnses,string [] [] [] fields, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_format_field_list", new object[] {
			profile_names,
			dnses,
			fields}, callback, asyncState);
	}
	public void Endset_protocol_dns_format_field_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_format_user_defined
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_format_user_defined(
		string [] profile_names,
		string [] [] dnses,
		string [] [] texts
	) {
		this.Invoke("set_protocol_dns_format_user_defined", new object [] {
				profile_names,
				dnses,
				texts});

	}
	public System.IAsyncResult Beginset_protocol_dns_format_user_defined(string [] profile_names,string [] [] dnses,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_format_user_defined", new object[] {
			profile_names,
			dnses,
			texts}, callback, asyncState);
	}
	public void Endset_protocol_dns_format_user_defined(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_log_drop_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_log_drop_filter_state(
		string [] profile_names,
		string [] [] dnses,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_dns_log_drop_filter_state", new object [] {
				profile_names,
				dnses,
				states});

	}
	public System.IAsyncResult Beginset_protocol_dns_log_drop_filter_state(string [] profile_names,string [] [] dnses,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_log_drop_filter_state", new object[] {
			profile_names,
			dnses,
			states}, callback, asyncState);
	}
	public void Endset_protocol_dns_log_drop_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_log_filtered_drop_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_log_filtered_drop_filter_state(
		string [] profile_names,
		string [] [] dnses,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_dns_log_filtered_drop_filter_state", new object [] {
				profile_names,
				dnses,
				states});

	}
	public System.IAsyncResult Beginset_protocol_dns_log_filtered_drop_filter_state(string [] profile_names,string [] [] dnses,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_log_filtered_drop_filter_state", new object[] {
			profile_names,
			dnses,
			states}, callback, asyncState);
	}
	public void Endset_protocol_dns_log_filtered_drop_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_log_malformed_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_log_malformed_filter_state(
		string [] profile_names,
		string [] [] dnses,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_dns_log_malformed_filter_state", new object [] {
				profile_names,
				dnses,
				states});

	}
	public System.IAsyncResult Beginset_protocol_dns_log_malformed_filter_state(string [] profile_names,string [] [] dnses,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_log_malformed_filter_state", new object[] {
			profile_names,
			dnses,
			states}, callback, asyncState);
	}
	public void Endset_protocol_dns_log_malformed_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_log_malicious_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_log_malicious_filter_state(
		string [] profile_names,
		string [] [] dnses,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_dns_log_malicious_filter_state", new object [] {
				profile_names,
				dnses,
				states});

	}
	public System.IAsyncResult Beginset_protocol_dns_log_malicious_filter_state(string [] profile_names,string [] [] dnses,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_log_malicious_filter_state", new object[] {
			profile_names,
			dnses,
			states}, callback, asyncState);
	}
	public void Endset_protocol_dns_log_malicious_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_log_publisher(
		string [] profile_names,
		string [] [] protocols,
		string [] [] publishers
	) {
		this.Invoke("set_protocol_dns_log_publisher", new object [] {
				profile_names,
				protocols,
				publishers});

	}
	public System.IAsyncResult Beginset_protocol_dns_log_publisher(string [] profile_names,string [] [] protocols,string [] [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_log_publisher", new object[] {
			profile_names,
			protocols,
			publishers}, callback, asyncState);
	}
	public void Endset_protocol_dns_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_log_reject_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_log_reject_filter_state(
		string [] profile_names,
		string [] [] dnses,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_dns_log_reject_filter_state", new object [] {
				profile_names,
				dnses,
				states});

	}
	public System.IAsyncResult Beginset_protocol_dns_log_reject_filter_state(string [] profile_names,string [] [] dnses,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_log_reject_filter_state", new object[] {
			profile_names,
			dnses,
			states}, callback, asyncState);
	}
	public void Endset_protocol_dns_log_reject_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_user_defined_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_dns_user_defined_string(
		string [] profile_names,
		string [] [] dnses,
		string [] [] texts
	) {
		this.Invoke("set_protocol_dns_user_defined_string", new object [] {
				profile_names,
				dnses,
				texts});

	}
	public System.IAsyncResult Beginset_protocol_dns_user_defined_string(string [] profile_names,string [] [] dnses,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_user_defined_string", new object[] {
			profile_names,
			dnses,
			texts}, callback, asyncState);
	}
	public void Endset_protocol_dns_user_defined_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_field_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_field_format(
		string [] profile_names,
		string [] [] sips,
		string [] [] texts
	) {
		this.Invoke("set_protocol_sip_field_format", new object [] {
				profile_names,
				sips,
				texts});

	}
	public System.IAsyncResult Beginset_protocol_sip_field_format(string [] profile_names,string [] [] sips,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_field_format", new object[] {
			profile_names,
			sips,
			texts}, callback, asyncState);
	}
	public void Endset_protocol_sip_field_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_field_list_delimiter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_field_list_delimiter(
		string [] profile_names,
		string [] [] sips,
		string [] [] texts
	) {
		this.Invoke("set_protocol_sip_field_list_delimiter", new object [] {
				profile_names,
				sips,
				texts});

	}
	public System.IAsyncResult Beginset_protocol_sip_field_list_delimiter(string [] profile_names,string [] [] sips,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_field_list_delimiter", new object[] {
			profile_names,
			sips,
			texts}, callback, asyncState);
	}
	public void Endset_protocol_sip_field_list_delimiter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_format_field_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_format_field_list(
		string [] profile_names,
		string [] [] sips,
		string [] [] [] fields
	) {
		this.Invoke("set_protocol_sip_format_field_list", new object [] {
				profile_names,
				sips,
				fields});

	}
	public System.IAsyncResult Beginset_protocol_sip_format_field_list(string [] profile_names,string [] [] sips,string [] [] [] fields, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_format_field_list", new object[] {
			profile_names,
			sips,
			fields}, callback, asyncState);
	}
	public void Endset_protocol_sip_format_field_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_format_user_defined
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_format_user_defined(
		string [] profile_names,
		string [] [] sips,
		string [] [] texts
	) {
		this.Invoke("set_protocol_sip_format_user_defined", new object [] {
				profile_names,
				sips,
				texts});

	}
	public System.IAsyncResult Beginset_protocol_sip_format_user_defined(string [] profile_names,string [] [] sips,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_format_user_defined", new object[] {
			profile_names,
			sips,
			texts}, callback, asyncState);
	}
	public void Endset_protocol_sip_format_user_defined(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_log_drop_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_log_drop_filter_state(
		string [] profile_names,
		string [] [] sips,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_sip_log_drop_filter_state", new object [] {
				profile_names,
				sips,
				states});

	}
	public System.IAsyncResult Beginset_protocol_sip_log_drop_filter_state(string [] profile_names,string [] [] sips,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_log_drop_filter_state", new object[] {
			profile_names,
			sips,
			states}, callback, asyncState);
	}
	public void Endset_protocol_sip_log_drop_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_log_global_failures_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_log_global_failures_filter_state(
		string [] profile_names,
		string [] [] sips,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_sip_log_global_failures_filter_state", new object [] {
				profile_names,
				sips,
				states});

	}
	public System.IAsyncResult Beginset_protocol_sip_log_global_failures_filter_state(string [] profile_names,string [] [] sips,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_log_global_failures_filter_state", new object[] {
			profile_names,
			sips,
			states}, callback, asyncState);
	}
	public void Endset_protocol_sip_log_global_failures_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_log_malformed_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_log_malformed_filter_state(
		string [] profile_names,
		string [] [] sips,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_sip_log_malformed_filter_state", new object [] {
				profile_names,
				sips,
				states});

	}
	public System.IAsyncResult Beginset_protocol_sip_log_malformed_filter_state(string [] profile_names,string [] [] sips,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_log_malformed_filter_state", new object[] {
			profile_names,
			sips,
			states}, callback, asyncState);
	}
	public void Endset_protocol_sip_log_malformed_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_log_publisher(
		string [] profile_names,
		string [] [] protocols,
		string [] [] publishers
	) {
		this.Invoke("set_protocol_sip_log_publisher", new object [] {
				profile_names,
				protocols,
				publishers});

	}
	public System.IAsyncResult Beginset_protocol_sip_log_publisher(string [] profile_names,string [] [] protocols,string [] [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_log_publisher", new object[] {
			profile_names,
			protocols,
			publishers}, callback, asyncState);
	}
	public void Endset_protocol_sip_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_log_redirection_responses_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_log_redirection_responses_filter_state(
		string [] profile_names,
		string [] [] sips,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_sip_log_redirection_responses_filter_state", new object [] {
				profile_names,
				sips,
				states});

	}
	public System.IAsyncResult Beginset_protocol_sip_log_redirection_responses_filter_state(string [] profile_names,string [] [] sips,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_log_redirection_responses_filter_state", new object[] {
			profile_names,
			sips,
			states}, callback, asyncState);
	}
	public void Endset_protocol_sip_log_redirection_responses_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_log_request_failures_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_log_request_failures_filter_state(
		string [] profile_names,
		string [] [] sips,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_sip_log_request_failures_filter_state", new object [] {
				profile_names,
				sips,
				states});

	}
	public System.IAsyncResult Beginset_protocol_sip_log_request_failures_filter_state(string [] profile_names,string [] [] sips,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_log_request_failures_filter_state", new object[] {
			profile_names,
			sips,
			states}, callback, asyncState);
	}
	public void Endset_protocol_sip_log_request_failures_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_log_server_errors_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_log_server_errors_filter_state(
		string [] profile_names,
		string [] [] sips,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_sip_log_server_errors_filter_state", new object [] {
				profile_names,
				sips,
				states});

	}
	public System.IAsyncResult Beginset_protocol_sip_log_server_errors_filter_state(string [] profile_names,string [] [] sips,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_log_server_errors_filter_state", new object[] {
			profile_names,
			sips,
			states}, callback, asyncState);
	}
	public void Endset_protocol_sip_log_server_errors_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_user_defined_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_sip_user_defined_string(
		string [] profile_names,
		string [] [] sips,
		string [] [] texts
	) {
		this.Invoke("set_protocol_sip_user_defined_string", new object [] {
				profile_names,
				sips,
				texts});

	}
	public System.IAsyncResult Beginset_protocol_sip_user_defined_string(string [] profile_names,string [] [] sips,string [] [] texts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_user_defined_string", new object[] {
			profile_names,
			sips,
			texts}, callback, asyncState);
	}
	public void Endset_protocol_sip_user_defined_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_transfer_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_protocol_transfer_publisher(
		string [] profile_names,
		string [] [] protocols,
		string [] [] publishers
	) {
		this.Invoke("set_protocol_transfer_publisher", new object [] {
				profile_names,
				protocols,
				publishers});

	}
	public System.IAsyncResult Beginset_protocol_transfer_publisher(string [] profile_names,string [] [] protocols,string [] [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_transfer_publisher", new object[] {
			profile_names,
			protocols,
			publishers}, callback, asyncState);
	}
	public void Endset_protocol_transfer_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sip_dos_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/LogProfile", 
		RequestNamespace="urn:iControl:Security/LogProfile", ResponseNamespace="urn:iControl:Security/LogProfile")]
	public void set_sip_dos_publisher(
		string [] profile_names,
		string [] publishers
	) {
		this.Invoke("set_sip_dos_publisher", new object [] {
				profile_names,
				publishers});

	}
	public System.IAsyncResult Beginset_sip_dos_publisher(string [] profile_names,string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sip_dos_publisher", new object[] {
			profile_names,
			publishers}, callback, asyncState);
	}
	public void Endset_sip_dos_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.DNSStorageFormat", Namespace = "urn:iControl")]
	public enum SecurityLogProfileDNSStorageFormat
	{
		DNS_STORAGE_FORMAT_UNKNOWN,
		DNS_STORAGE_FORMAT_NONE,
		DNS_STORAGE_FORMAT_FIELD_LIST,
		DNS_STORAGE_FORMAT_USER_DEFINED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.EntryLength", Namespace = "urn:iControl")]
	public enum SecurityLogProfileEntryLength
	{
		ENTRY_LENGTH_UNKNOWN,
		ENTRY_LENGTH_1K,
		ENTRY_LENGTH_2K,
		ENTRY_LENGTH_10K,
		ENTRY_LENGTH_64K,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.FilterKey", Namespace = "urn:iControl")]
	public enum SecurityLogProfileFilterKey
	{
		FILTER_KEY_UNKNOWN,
		FILTER_KEY_REQUEST_TYPE,
		FILTER_KEY_PROTOCOL,
		FILTER_KEY_RESPONSE_CODE,
		FILTER_KEY_HTTP_METHOD,
		FILTER_KEY_SEARCH_ALL,
		FILTER_KEY_SEARCH_IN_HEADERS,
		FILTER_KEY_SEARCH_IN_POST_DATA,
		FILTER_KEY_SEARCH_IN_QUERY_STRING,
		FILTER_KEY_SEARCH_IN_REQUEST,
		FILTER_KEY_SEARCH_IN_URI,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.LogicOperation", Namespace = "urn:iControl")]
	public enum SecurityLogProfileLogicOperation
	{
		LOGIC_OPERATION_UNKNOWN,
		LOGIC_OPERATION_AND,
		LOGIC_OPERATION_OR,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.NetworkStorageFormat", Namespace = "urn:iControl")]
	public enum SecurityLogProfileNetworkStorageFormat
	{
		NETWORK_STORAGE_FORMAT_UNKNOWN,
		NETWORK_STORAGE_FORMAT_NONE,
		NETWORK_STORAGE_FORMAT_FIELD_LIST,
		NETWORK_STORAGE_FORMAT_USER_DEFINED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.RemoteFacility", Namespace = "urn:iControl")]
	public enum SecurityLogProfileRemoteFacility
	{
		REMOTE_FACILITY_UNKNOWN,
		REMOTE_FACILITY_LOCAL0,
		REMOTE_FACILITY_LOCAL1,
		REMOTE_FACILITY_LOCAL2,
		REMOTE_FACILITY_LOCAL3,
		REMOTE_FACILITY_LOCAL4,
		REMOTE_FACILITY_LOCAL5,
		REMOTE_FACILITY_LOCAL6,
		REMOTE_FACILITY_LOCAL7,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.RemoteProtocol", Namespace = "urn:iControl")]
	public enum SecurityLogProfileRemoteProtocol
	{
		REMOTE_PROTOCOL_UNKNOWN,
		REMOTE_PROTOCOL_UDP,
		REMOTE_PROTOCOL_TCP,
		REMOTE_PROTOCOL_TCP_RFC3195,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.RemoteStorage", Namespace = "urn:iControl")]
	public enum SecurityLogProfileRemoteStorage
	{
		REMOTE_STORAGE_UNKNOWN,
		REMOTE_STORAGE_NONE,
		REMOTE_STORAGE_REMOTE,
		REMOTE_STORAGE_SPLUNK,
		REMOTE_STORAGE_ARCSIGHT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.ResponseLogging", Namespace = "urn:iControl")]
	public enum SecurityLogProfileResponseLogging
	{
		RESPONSE_LOGGING_UNKNOWN,
		RESPONSE_LOGGING_NONE,
		RESPONSE_LOGGING_ILLEGAL,
		RESPONSE_LOGGING_ALL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.SIPStorageFormat", Namespace = "urn:iControl")]
	public enum SecurityLogProfileSIPStorageFormat
	{
		SIP_STORAGE_FORMAT_UNKNOWN,
		SIP_STORAGE_FORMAT_NONE,
		SIP_STORAGE_FORMAT_FIELD_LIST,
		SIP_STORAGE_FORMAT_USER_DEFINED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.LogProfile.StorageFormat", Namespace = "urn:iControl")]
	public enum SecurityLogProfileStorageFormat
	{
		STORAGE_FORMAT_UNKNOWN,
		STORAGE_FORMAT_PREDEFINED,
		STORAGE_FORMAT_USER_DEFINED,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
