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
	[System.Web.Services.WebServiceBindingAttribute(Name="ASM.LoggingProfileBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonIPPortDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMLoggingProfileDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMLoggingRemoteStorageBase))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMLoggingRequestSearch))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMLoggingStorageFormat))]
	public partial class ASMLoggingProfile : iControlInterface {
		public ASMLoggingProfile() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_remote_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void add_remote_server(
		string [] logprof_names,
		CommonIPPortDefinition [] [] ip_ports
	) {
		this.Invoke("add_remote_server", new object [] {
				logprof_names,
				ip_ports});

	}
	public System.IAsyncResult Beginadd_remote_server(string [] logprof_names,CommonIPPortDefinition [] [] ip_ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_remote_server", new object[] {
			logprof_names,
			ip_ports}, callback, asyncState);
	}
	public void Endadd_remote_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// apply_logprof
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void apply_logprof(
		string [] logprof_names
	) {
		this.Invoke("apply_logprof", new object [] {
				logprof_names});

	}
	public System.IAsyncResult Beginapply_logprof(string [] logprof_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("apply_logprof", new object[] {
			logprof_names}, callback, asyncState);
	}
	public void Endapply_logprof(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void create(
		string [] logprof_names
	) {
		this.Invoke("create", new object [] {
				logprof_names});

	}
	public System.IAsyncResult Begincreate(string [] logprof_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			logprof_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_logprof
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void delete_logprof(
		string [] logprof_names
	) {
		this.Invoke("delete_logprof", new object [] {
				logprof_names});

	}
	public System.IAsyncResult Begindelete_logprof(string [] logprof_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_logprof", new object[] {
			logprof_names}, callback, asyncState);
	}
	public void Enddelete_logprof(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
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
	// get_logprof
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMLoggingProfileDefinition [] get_logprof(
		string [] logprof_names
	) {
		object [] results = this.Invoke("get_logprof", new object [] {
				logprof_names});
		return ((ASMLoggingProfileDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_logprof(string [] logprof_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logprof", new object[] {
			logprof_names}, callback, asyncState);
	}
	public ASMLoggingProfileDefinition [] Endget_logprof(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMLoggingProfileDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
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
	// remove_remote_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void remove_remote_server(
		string [] logprof_names,
		CommonIPPortDefinition [] [] ip_ports
	) {
		this.Invoke("remove_remote_server", new object [] {
				logprof_names,
				ip_ports});

	}
	public System.IAsyncResult Beginremove_remote_server(string [] logprof_names,CommonIPPortDefinition [] [] ip_ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_remote_server", new object[] {
			logprof_names,
			ip_ports}, callback, asyncState);
	}
	public void Endremove_remote_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// rename
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void rename(
		string [] logprof_names,
		string [] new_logprof_names
	) {
		this.Invoke("rename", new object [] {
				logprof_names,
				new_logprof_names});

	}
	public System.IAsyncResult Beginrename(string [] logprof_names,string [] new_logprof_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("rename", new object[] {
			logprof_names,
			new_logprof_names}, callback, asyncState);
	}
	public void Endrename(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_http_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void replace_http_method(
		string [] logprof_names,
		string [] [] http_methods
	) {
		this.Invoke("replace_http_method", new object [] {
				logprof_names,
				http_methods});

	}
	public System.IAsyncResult Beginreplace_http_method(string [] logprof_names,string [] [] http_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_http_method", new object[] {
			logprof_names,
			http_methods}, callback, asyncState);
	}
	public void Endreplace_http_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_response_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void replace_response_code(
		string [] logprof_names,
		long [] [] response_codes
	) {
		this.Invoke("replace_response_code", new object [] {
				logprof_names,
				response_codes});

	}
	public System.IAsyncResult Beginreplace_response_code(string [] logprof_names,long [] [] response_codes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_response_code", new object[] {
			logprof_names,
			response_codes}, callback, asyncState);
	}
	public void Endreplace_response_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_description(
		string [] logprof_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				logprof_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] logprof_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			logprof_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_filter_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_filter_protocol(
		string [] logprof_names,
		ASMProtocolType [] filter_protocols
	) {
		this.Invoke("set_filter_protocol", new object [] {
				logprof_names,
				filter_protocols});

	}
	public System.IAsyncResult Beginset_filter_protocol(string [] logprof_names,ASMProtocolType [] filter_protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_filter_protocol", new object[] {
			logprof_names,
			filter_protocols}, callback, asyncState);
	}
	public void Endset_filter_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_guarantee_logging_flag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_guarantee_logging_flag(
		string [] logprof_names,
		bool [] guarantee_logging_flags
	) {
		this.Invoke("set_guarantee_logging_flag", new object [] {
				logprof_names,
				guarantee_logging_flags});

	}
	public System.IAsyncResult Beginset_guarantee_logging_flag(string [] logprof_names,bool [] guarantee_logging_flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_guarantee_logging_flag", new object[] {
			logprof_names,
			guarantee_logging_flags}, callback, asyncState);
	}
	public void Endset_guarantee_logging_flag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_local_storage_flag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_local_storage_flag(
		string [] logprof_names,
		bool [] local_storage_flags
	) {
		this.Invoke("set_local_storage_flag", new object [] {
				logprof_names,
				local_storage_flags});

	}
	public System.IAsyncResult Beginset_local_storage_flag(string [] logprof_names,bool [] local_storage_flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_local_storage_flag", new object[] {
			logprof_names,
			local_storage_flags}, callback, asyncState);
	}
	public void Endset_local_storage_flag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_logic_operation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_logic_operation(
		string [] logprof_names,
		ASMLoggingLogicOperation [] logic_operations
	) {
		this.Invoke("set_logic_operation", new object [] {
				logprof_names,
				logic_operations});

	}
	public System.IAsyncResult Beginset_logic_operation(string [] logprof_names,ASMLoggingLogicOperation [] logic_operations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_logic_operation", new object[] {
			logprof_names,
			logic_operations}, callback, asyncState);
	}
	public void Endset_logic_operation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_entry_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_maximum_entry_length(
		string [] logprof_names,
		long [] maximum_entry_lengths
	) {
		this.Invoke("set_maximum_entry_length", new object [] {
				logprof_names,
				maximum_entry_lengths});

	}
	public System.IAsyncResult Beginset_maximum_entry_length(string [] logprof_names,long [] maximum_entry_lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_entry_length", new object[] {
			logprof_names,
			maximum_entry_lengths}, callback, asyncState);
	}
	public void Endset_maximum_entry_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_maximum_header_size(
		string [] logprof_names,
		long [] maximum_header_sizes
	) {
		this.Invoke("set_maximum_header_size", new object [] {
				logprof_names,
				maximum_header_sizes});

	}
	public System.IAsyncResult Beginset_maximum_header_size(string [] logprof_names,long [] maximum_header_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_header_size", new object[] {
			logprof_names,
			maximum_header_sizes}, callback, asyncState);
	}
	public void Endset_maximum_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_query_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_maximum_query_size(
		string [] logprof_names,
		long [] maximum_query_sizes
	) {
		this.Invoke("set_maximum_query_size", new object [] {
				logprof_names,
				maximum_query_sizes});

	}
	public System.IAsyncResult Beginset_maximum_query_size(string [] logprof_names,long [] maximum_query_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_query_size", new object[] {
			logprof_names,
			maximum_query_sizes}, callback, asyncState);
	}
	public void Endset_maximum_query_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_request_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_maximum_request_size(
		string [] logprof_names,
		long [] maximum_request_sizes
	) {
		this.Invoke("set_maximum_request_size", new object [] {
				logprof_names,
				maximum_request_sizes});

	}
	public System.IAsyncResult Beginset_maximum_request_size(string [] logprof_names,long [] maximum_request_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_request_size", new object[] {
			logprof_names,
			maximum_request_sizes}, callback, asyncState);
	}
	public void Endset_maximum_request_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_log_facility
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_remote_log_facility(
		string [] logprof_names,
		ASMLoggingRemoteFacility [] remote_log_facilities
	) {
		this.Invoke("set_remote_log_facility", new object [] {
				logprof_names,
				remote_log_facilities});

	}
	public System.IAsyncResult Beginset_remote_log_facility(string [] logprof_names,ASMLoggingRemoteFacility [] remote_log_facilities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_log_facility", new object[] {
			logprof_names,
			remote_log_facilities}, callback, asyncState);
	}
	public void Endset_remote_log_facility(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_remote_protocol(
		string [] logprof_names,
		ASMLoggingRemoteProtocol [] remote_protocols
	) {
		this.Invoke("set_remote_protocol", new object [] {
				logprof_names,
				remote_protocols});

	}
	public System.IAsyncResult Beginset_remote_protocol(string [] logprof_names,ASMLoggingRemoteProtocol [] remote_protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_protocol", new object[] {
			logprof_names,
			remote_protocols}, callback, asyncState);
	}
	public void Endset_remote_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_remote_server(
		string [] logprof_names,
		CommonIPPortDefinition [] ip_ports
	) {
		this.Invoke("set_remote_server", new object [] {
				logprof_names,
				ip_ports});

	}
	public System.IAsyncResult Beginset_remote_server(string [] logprof_names,CommonIPPortDefinition [] ip_ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_server", new object[] {
			logprof_names,
			ip_ports}, callback, asyncState);
	}
	public void Endset_remote_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_storage_base
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_remote_storage_base(
		string [] logprof_names,
		ASMLoggingRemoteStorageBase [] remote_storage_bases
	) {
		this.Invoke("set_remote_storage_base", new object [] {
				logprof_names,
				remote_storage_bases});

	}
	public System.IAsyncResult Beginset_remote_storage_base(string [] logprof_names,ASMLoggingRemoteStorageBase [] remote_storage_bases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_storage_base", new object[] {
			logprof_names,
			remote_storage_bases}, callback, asyncState);
	}
	public void Endset_remote_storage_base(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_report_anomalies_flag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_report_anomalies_flag(
		string [] logprof_names,
		bool [] report_anomalies_flags
	) {
		this.Invoke("set_report_anomalies_flag", new object [] {
				logprof_names,
				report_anomalies_flags});

	}
	public System.IAsyncResult Beginset_report_anomalies_flag(string [] logprof_names,bool [] report_anomalies_flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_report_anomalies_flag", new object[] {
			logprof_names,
			report_anomalies_flags}, callback, asyncState);
	}
	public void Endset_report_anomalies_flag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_search
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_request_search(
		string [] logprof_names,
		ASMLoggingRequestSearch [] request_searches
	) {
		this.Invoke("set_request_search", new object [] {
				logprof_names,
				request_searches});

	}
	public System.IAsyncResult Beginset_request_search(string [] logprof_names,ASMLoggingRequestSearch [] request_searches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_search", new object[] {
			logprof_names,
			request_searches}, callback, asyncState);
	}
	public void Endset_request_search(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_request_type(
		string [] logprof_names,
		ASMLoggingRequestType [] request_types
	) {
		this.Invoke("set_request_type", new object [] {
				logprof_names,
				request_types});

	}
	public System.IAsyncResult Beginset_request_type(string [] logprof_names,ASMLoggingRequestType [] request_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_type", new object[] {
			logprof_names,
			request_types}, callback, asyncState);
	}
	public void Endset_request_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_search_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_search_pattern(
		string [] logprof_names,
		string [] search_patterns
	) {
		this.Invoke("set_search_pattern", new object [] {
				logprof_names,
				search_patterns});

	}
	public System.IAsyncResult Beginset_search_pattern(string [] logprof_names,string [] search_patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_search_pattern", new object[] {
			logprof_names,
			search_patterns}, callback, asyncState);
	}
	public void Endset_search_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_storage_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/LoggingProfile", 
		RequestNamespace="urn:iControl:ASM/LoggingProfile", ResponseNamespace="urn:iControl:ASM/LoggingProfile")]
	public void set_storage_format(
		string [] logprof_names,
		ASMLoggingStorageFormat [] storage_formats
	) {
		this.Invoke("set_storage_format", new object [] {
				logprof_names,
				storage_formats});

	}
	public System.IAsyncResult Beginset_storage_format(string [] logprof_names,ASMLoggingStorageFormat [] storage_formats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_storage_format", new object[] {
			logprof_names,
			storage_formats}, callback, asyncState);
	}
	public void Endset_storage_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
