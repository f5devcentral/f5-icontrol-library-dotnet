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
	[System.Web.Services.WebServiceBindingAttribute(Name="ASM.PolicyBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonIPNetmask))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMFileTransferContext))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMDos))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMDynamicSessionsInUrl))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMViolation))]
	public partial class ASMPolicy : iControlInterface {
		public ASMPolicy() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_dos_white_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void add_dos_white_ip(
		string [] policy_names,
		CommonIPNetmask [] [] ip_netmasks
	) {
		this.Invoke("add_dos_white_ip", new object [] {
				policy_names,
				ip_netmasks});

	}
	public System.IAsyncResult Beginadd_dos_white_ip(string [] policy_names,CommonIPNetmask [] [] ip_netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_dos_white_ip", new object[] {
			policy_names,
			ip_netmasks}, callback, asyncState);
	}
	public void Endadd_dos_white_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_predictable_resource_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool add_predictable_resource_location(
		string policy_name,
		string [] uris
	) {
		object [] results = this.Invoke("add_predictable_resource_location", new object [] {
				policy_name,
				uris});
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginadd_predictable_resource_location(string policy_name,string [] uris, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_predictable_resource_location", new object[] {
			policy_name,
			uris}, callback, asyncState);
	}
	public bool Endadd_predictable_resource_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// apply_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void apply_policy(
		string [] policy_names
	) {
		this.Invoke("apply_policy", new object [] {
				policy_names});

	}
	public System.IAsyncResult Beginapply_policy(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("apply_policy", new object[] {
			policy_names}, callback, asyncState);
	}
	public void Endapply_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// associate_wa_webapp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void associate_wa_webapp(
		string [] policy_names,
		string [] wa_webapp_names
	) {
		this.Invoke("associate_wa_webapp", new object [] {
				policy_names,
				wa_webapp_names});

	}
	public System.IAsyncResult Beginassociate_wa_webapp(string [] policy_names,string [] wa_webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("associate_wa_webapp", new object[] {
			policy_names,
			wa_webapp_names}, callback, asyncState);
	}
	public void Endassociate_wa_webapp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// attach_to_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void attach_to_virtual_server(
		string [] policy_names,
		string [] virtual_servers
	) {
		this.Invoke("attach_to_virtual_server", new object [] {
				policy_names,
				virtual_servers});

	}
	public System.IAsyncResult Beginattach_to_virtual_server(string [] policy_names,string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("attach_to_virtual_server", new object[] {
			policy_names,
			virtual_servers}, callback, asyncState);
	}
	public void Endattach_to_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void create(
		string [] webapp_names,
		string [] [] policy_names
	) {
		this.Invoke("create", new object [] {
				webapp_names,
				policy_names});

	}
	public System.IAsyncResult Begincreate(string [] webapp_names,string [] [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			webapp_names,
			policy_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_case_insensitive
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void create_case_insensitive(
		string [] webapp_names,
		string [] [] policy_names,
		bool [] [] case_insensitive_flags
	) {
		this.Invoke("create_case_insensitive", new object [] {
				webapp_names,
				policy_names,
				case_insensitive_flags});

	}
	public System.IAsyncResult Begincreate_case_insensitive(string [] webapp_names,string [] [] policy_names,bool [] [] case_insensitive_flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_case_insensitive", new object[] {
			webapp_names,
			policy_names,
			case_insensitive_flags}, callback, asyncState);
	}
	public void Endcreate_case_insensitive(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_from_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void create_from_template(
		string [] webapp_names,
		string [] [] policy_names,
		ASMPolicyTemplate [] [] policy_templates
	) {
		this.Invoke("create_from_template", new object [] {
				webapp_names,
				policy_names,
				policy_templates});

	}
	public System.IAsyncResult Begincreate_from_template(string [] webapp_names,string [] [] policy_names,ASMPolicyTemplate [] [] policy_templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_from_template", new object[] {
			webapp_names,
			policy_names,
			policy_templates}, callback, asyncState);
	}
	public void Endcreate_from_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_from_template_names
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void create_from_template_names(
		string [] webapp_names,
		string [] [] policy_names,
		string [] [] policy_template_names
	) {
		this.Invoke("create_from_template_names", new object [] {
				webapp_names,
				policy_names,
				policy_template_names});

	}
	public System.IAsyncResult Begincreate_from_template_names(string [] webapp_names,string [] [] policy_names,string [] [] policy_template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_from_template_names", new object[] {
			webapp_names,
			policy_names,
			policy_template_names}, callback, asyncState);
	}
	public void Endcreate_from_template_names(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_from_template_names_with_language
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void create_from_template_names_with_language(
		string [] policy_names,
		ASMWebApplicationLanguage [] languages,
		string [] policy_template_names
	) {
		this.Invoke("create_from_template_names_with_language", new object [] {
				policy_names,
				languages,
				policy_template_names});

	}
	public System.IAsyncResult Begincreate_from_template_names_with_language(string [] policy_names,ASMWebApplicationLanguage [] languages,string [] policy_template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_from_template_names_with_language", new object[] {
			policy_names,
			languages,
			policy_template_names}, callback, asyncState);
	}
	public void Endcreate_from_template_names_with_language(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_from_template_with_language
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void create_from_template_with_language(
		string [] policy_names,
		ASMWebApplicationLanguage [] languages,
		ASMPolicyTemplate [] policy_templates
	) {
		this.Invoke("create_from_template_with_language", new object [] {
				policy_names,
				languages,
				policy_templates});

	}
	public System.IAsyncResult Begincreate_from_template_with_language(string [] policy_names,ASMWebApplicationLanguage [] languages,ASMPolicyTemplate [] policy_templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_from_template_with_language", new object[] {
			policy_names,
			languages,
			policy_templates}, callback, asyncState);
	}
	public void Endcreate_from_template_with_language(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void delete_policy(
		string [] policy_names
	) {
		this.Invoke("delete_policy", new object [] {
				policy_names});

	}
	public System.IAsyncResult Begindelete_policy(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_policy", new object[] {
			policy_names}, callback, asyncState);
	}
	public void Enddelete_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// detach_from_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void detach_from_virtual_server(
		string [] policy_names,
		string [] virtual_servers
	) {
		this.Invoke("detach_from_virtual_server", new object [] {
				policy_names,
				virtual_servers});

	}
	public System.IAsyncResult Begindetach_from_virtual_server(string [] policy_names,string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("detach_from_virtual_server", new object[] {
			policy_names,
			virtual_servers}, callback, asyncState);
	}
	public void Enddetach_from_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// detach_wa_webapp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void detach_wa_webapp(
		string [] policy_names,
		string [] wa_webapp_names
	) {
		this.Invoke("detach_wa_webapp", new object [] {
				policy_names,
				wa_webapp_names});

	}
	public System.IAsyncResult Begindetach_wa_webapp(string [] policy_names,string [] wa_webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("detach_wa_webapp", new object[] {
			policy_names,
			wa_webapp_names}, callback, asyncState);
	}
	public void Enddetach_wa_webapp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// download_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMFileTransferContext download_policy(
		string policy_name,
		long chunk_size,
		ref long file_offset
	) {
		object [] results = this.Invoke("download_policy", new object [] {
				policy_name,
				chunk_size,
				file_offset});
		file_offset = ((long)(results[1]));
		return ((ASMFileTransferContext)(results[0]));
	}
	public System.IAsyncResult Begindownload_policy(string policy_name,long chunk_size,long file_offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("download_policy", new object[] {
			policy_name,
			chunk_size,
			file_offset}, callback, asyncState);
	}
	public ASMFileTransferContext Enddownload_policy(System.IAsyncResult asyncResult,
 out long file_offset) {
		object [] results = this.EndInvoke(asyncResult);
		file_offset = ((long)(results[1]));
		return ((ASMFileTransferContext)(results[0]));
	}

	//-----------------------------------------------------------------------
	// export_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void export_policy(
		string policy_name,
		string filename
	) {
		this.Invoke("export_policy", new object [] {
				policy_name,
				filename});

	}
	public System.IAsyncResult Beginexport_policy(string policy_name,string filename, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("export_policy", new object[] {
			policy_name,
			filename}, callback, asyncState);
	}
	public void Endexport_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// export_policy_xml
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void export_policy_xml(
		string policy_name,
		string filename
	) {
		this.Invoke("export_policy_xml", new object [] {
				policy_name,
				filename});

	}
	public System.IAsyncResult Beginexport_policy_xml(string policy_name,string filename, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("export_policy_xml", new object[] {
			policy_name,
			filename}, callback, asyncState);
	}
	public void Endexport_policy_xml(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_active
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_active(
		string [] policy_names
	) {
		object [] results = this.Invoke("get_active", new object [] {
				policy_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_active(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active", new object[] {
			policy_names}, callback, asyncState);
	}
	public bool [] Endget_active(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_cookie_length(
		string [] policy_names
	) {
		object [] results = this.Invoke("get_cookie_length", new object [] {
				policy_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_length(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_length", new object[] {
			policy_names}, callback, asyncState);
	}
	public long [] Endget_cookie_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] policy_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				policy_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			policy_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_disable_blocking_flag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_disable_blocking_flag(
		string [] policy_names
	) {
		object [] results = this.Invoke("get_disable_blocking_flag", new object [] {
				policy_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_disable_blocking_flag(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_disable_blocking_flag", new object[] {
			policy_names}, callback, asyncState);
	}
	public bool [] Endget_disable_blocking_flag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMDos [] get_dos(
		string [] policy_names
	) {
		object [] results = this.Invoke("get_dos", new object [] {
				policy_names});
		return ((ASMDos [])(results[0]));
	}
	public System.IAsyncResult Beginget_dos(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dos", new object[] {
			policy_names}, callback, asyncState);
	}
	public ASMDos [] Endget_dos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMDos [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_sessions_in_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMDynamicSessionsInUrl [] get_dynamic_sessions_in_url(
		string [] policy_names
	) {
		object [] results = this.Invoke("get_dynamic_sessions_in_url", new object [] {
				policy_names});
		return ((ASMDynamicSessionsInUrl [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_sessions_in_url(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_sessions_in_url", new object[] {
			policy_names}, callback, asyncState);
	}
	public ASMDynamicSessionsInUrl [] Endget_dynamic_sessions_in_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMDynamicSessionsInUrl [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_http_header_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_http_header_length(
		string [] policy_names
	) {
		object [] results = this.Invoke("get_http_header_length", new object [] {
				policy_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_http_header_length(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_header_length", new object[] {
			policy_names}, callback, asyncState);
	}
	public long [] Endget_http_header_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_language
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMWebApplicationLanguage [] get_language(
		string [] policy_names
	) {
		object [] results = this.Invoke("get_language", new object [] {
				policy_names});
		return ((ASMWebApplicationLanguage [])(results[0]));
	}
	public System.IAsyncResult Beginget_language(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_language", new object[] {
			policy_names}, callback, asyncState);
	}
	public ASMWebApplicationLanguage [] Endget_language(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMWebApplicationLanguage [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
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
	// get_logging_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_logging_profile(
		string [] policy_names
	) {
		object [] results = this.Invoke("get_logging_profile", new object [] {
				policy_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_logging_profile(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logging_profile", new object[] {
			policy_names}, callback, asyncState);
	}
	public string [] Endget_logging_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
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
	// get_violation_flags
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMViolation [] [] get_violation_flags(
		string [] policy_names
	) {
		object [] results = this.Invoke("get_violation_flags", new object [] {
				policy_names});
		return ((ASMViolation [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_violation_flags(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_violation_flags", new object[] {
			policy_names}, callback, asyncState);
	}
	public ASMViolation [] [] Endget_violation_flags(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMViolation [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// import_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string import_policy(
		string webapp_name,
		string filename
	) {
		object [] results = this.Invoke("import_policy", new object [] {
				webapp_name,
				filename});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginimport_policy(string webapp_name,string filename, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("import_policy", new object[] {
			webapp_name,
			filename}, callback, asyncState);
	}
	public string Endimport_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// reconfigure
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void reconfigure(
		string [] policy_names
	) {
		this.Invoke("reconfigure", new object [] {
				policy_names});

	}
	public System.IAsyncResult Beginreconfigure(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reconfigure", new object[] {
			policy_names}, callback, asyncState);
	}
	public void Endreconfigure(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_dos_white_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void remove_dos_white_ip(
		string [] policy_names,
		CommonIPNetmask [] [] ip_netmasks
	) {
		this.Invoke("remove_dos_white_ip", new object [] {
				policy_names,
				ip_netmasks});

	}
	public System.IAsyncResult Beginremove_dos_white_ip(string [] policy_names,CommonIPNetmask [] [] ip_netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_dos_white_ip", new object[] {
			policy_names,
			ip_netmasks}, callback, asyncState);
	}
	public void Endremove_dos_white_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// rename
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void rename(
		string [] policy_names,
		string [] new_policy_names
	) {
		this.Invoke("rename", new object [] {
				policy_names,
				new_policy_names});

	}
	public System.IAsyncResult Beginrename(string [] policy_names,string [] new_policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("rename", new object[] {
			policy_names,
			new_policy_names}, callback, asyncState);
	}
	public void Endrename(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// restore_dos_defaults
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void restore_dos_defaults(
		string [] policy_names
	) {
		this.Invoke("restore_dos_defaults", new object [] {
				policy_names});

	}
	public System.IAsyncResult Beginrestore_dos_defaults(string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("restore_dos_defaults", new object[] {
			policy_names}, callback, asyncState);
	}
	public void Endrestore_dos_defaults(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_active
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_active(
		string [] policy_names,
		bool [] active_flags
	) {
		this.Invoke("set_active", new object [] {
				policy_names,
				active_flags});

	}
	public System.IAsyncResult Beginset_active(string [] policy_names,bool [] active_flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_active", new object[] {
			policy_names,
			active_flags}, callback, asyncState);
	}
	public void Endset_active(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cookie_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_cookie_length(
		string [] policy_names,
		long [] cookie_lengths
	) {
		this.Invoke("set_cookie_length", new object [] {
				policy_names,
				cookie_lengths});

	}
	public System.IAsyncResult Beginset_cookie_length(string [] policy_names,long [] cookie_lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cookie_length", new object[] {
			policy_names,
			cookie_lengths}, callback, asyncState);
	}
	public void Endset_cookie_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_description(
		string [] policy_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				policy_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] policy_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			policy_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_disable_blocking_flag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_disable_blocking_flag(
		string [] policy_names,
		bool [] blocking_flags
	) {
		this.Invoke("set_disable_blocking_flag", new object [] {
				policy_names,
				blocking_flags});

	}
	public System.IAsyncResult Beginset_disable_blocking_flag(string [] policy_names,bool [] blocking_flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_disable_blocking_flag", new object[] {
			policy_names,
			blocking_flags}, callback, asyncState);
	}
	public void Endset_disable_blocking_flag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_detection_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_detection_mode(
		string [] policy_names,
		ASMDosDetectionMode [] detection_modes
	) {
		this.Invoke("set_dos_detection_mode", new object [] {
				policy_names,
				detection_modes});

	}
	public System.IAsyncResult Beginset_dos_detection_mode(string [] policy_names,ASMDosDetectionMode [] detection_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_detection_mode", new object[] {
			policy_names,
			detection_modes}, callback, asyncState);
	}
	public void Endset_dos_detection_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_ip_maximum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_ip_maximum_tps(
		string [] policy_names,
		long [] ip_maximum_tpses
	) {
		this.Invoke("set_dos_ip_maximum_tps", new object [] {
				policy_names,
				ip_maximum_tpses});

	}
	public System.IAsyncResult Beginset_dos_ip_maximum_tps(string [] policy_names,long [] ip_maximum_tpses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_ip_maximum_tps", new object[] {
			policy_names,
			ip_maximum_tpses}, callback, asyncState);
	}
	public void Endset_dos_ip_maximum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_ip_minimum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_ip_minimum_tps(
		string [] policy_names,
		long [] ip_minimum_tpses
	) {
		this.Invoke("set_dos_ip_minimum_tps", new object [] {
				policy_names,
				ip_minimum_tpses});

	}
	public System.IAsyncResult Beginset_dos_ip_minimum_tps(string [] policy_names,long [] ip_minimum_tpses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_ip_minimum_tps", new object[] {
			policy_names,
			ip_minimum_tpses}, callback, asyncState);
	}
	public void Endset_dos_ip_minimum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_ip_tps_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_ip_tps_increase_rate(
		string [] policy_names,
		long [] ip_tps_increase_rates
	) {
		this.Invoke("set_dos_ip_tps_increase_rate", new object [] {
				policy_names,
				ip_tps_increase_rates});

	}
	public System.IAsyncResult Beginset_dos_ip_tps_increase_rate(string [] policy_names,long [] ip_tps_increase_rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_ip_tps_increase_rate", new object[] {
			policy_names,
			ip_tps_increase_rates}, callback, asyncState);
	}
	public void Endset_dos_ip_tps_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_latency_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_latency_increase_rate(
		string [] policy_names,
		long [] latency_increase_rates
	) {
		this.Invoke("set_dos_latency_increase_rate", new object [] {
				policy_names,
				latency_increase_rates});

	}
	public System.IAsyncResult Beginset_dos_latency_increase_rate(string [] policy_names,long [] latency_increase_rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_latency_increase_rate", new object[] {
			policy_names,
			latency_increase_rates}, callback, asyncState);
	}
	public void Endset_dos_latency_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_maximum_latency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_maximum_latency(
		string [] policy_names,
		long [] maximum_latencies
	) {
		this.Invoke("set_dos_maximum_latency", new object [] {
				policy_names,
				maximum_latencies});

	}
	public System.IAsyncResult Beginset_dos_maximum_latency(string [] policy_names,long [] maximum_latencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_maximum_latency", new object[] {
			policy_names,
			maximum_latencies}, callback, asyncState);
	}
	public void Endset_dos_maximum_latency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_maximum_prevention_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_maximum_prevention_duration(
		string [] policy_names,
		long [] maximum_prevention_durations
	) {
		this.Invoke("set_dos_maximum_prevention_duration", new object [] {
				policy_names,
				maximum_prevention_durations});

	}
	public System.IAsyncResult Beginset_dos_maximum_prevention_duration(string [] policy_names,long [] maximum_prevention_durations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_maximum_prevention_duration", new object[] {
			policy_names,
			maximum_prevention_durations}, callback, asyncState);
	}
	public void Endset_dos_maximum_prevention_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_minimum_latency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_minimum_latency(
		string [] policy_names,
		long [] minimum_latencies
	) {
		this.Invoke("set_dos_minimum_latency", new object [] {
				policy_names,
				minimum_latencies});

	}
	public System.IAsyncResult Beginset_dos_minimum_latency(string [] policy_names,long [] minimum_latencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_minimum_latency", new object[] {
			policy_names,
			minimum_latencies}, callback, asyncState);
	}
	public void Endset_dos_minimum_latency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_operation_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_operation_mode(
		string [] policy_names,
		ASMDosOperationMode [] operation_modes
	) {
		this.Invoke("set_dos_operation_mode", new object [] {
				policy_names,
				operation_modes});

	}
	public System.IAsyncResult Beginset_dos_operation_mode(string [] policy_names,ASMDosOperationMode [] operation_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_operation_mode", new object[] {
			policy_names,
			operation_modes}, callback, asyncState);
	}
	public void Endset_dos_operation_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_source_ip_based_client_side_integrity_defense_flag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_source_ip_based_client_side_integrity_defense_flag(
		string [] policy_names,
		bool [] source_ip_based_client_side_integrity_defense_flags
	) {
		this.Invoke("set_dos_source_ip_based_client_side_integrity_defense_flag", new object [] {
				policy_names,
				source_ip_based_client_side_integrity_defense_flags});

	}
	public System.IAsyncResult Beginset_dos_source_ip_based_client_side_integrity_defense_flag(string [] policy_names,bool [] source_ip_based_client_side_integrity_defense_flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_source_ip_based_client_side_integrity_defense_flag", new object[] {
			policy_names,
			source_ip_based_client_side_integrity_defense_flags}, callback, asyncState);
	}
	public void Endset_dos_source_ip_based_client_side_integrity_defense_flag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_source_ip_based_rate_limiting_flag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_source_ip_based_rate_limiting_flag(
		string [] policy_names,
		bool [] source_ip_based_rate_limiting_flags
	) {
		this.Invoke("set_dos_source_ip_based_rate_limiting_flag", new object [] {
				policy_names,
				source_ip_based_rate_limiting_flags});

	}
	public System.IAsyncResult Beginset_dos_source_ip_based_rate_limiting_flag(string [] policy_names,bool [] source_ip_based_rate_limiting_flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_source_ip_based_rate_limiting_flag", new object[] {
			policy_names,
			source_ip_based_rate_limiting_flags}, callback, asyncState);
	}
	public void Endset_dos_source_ip_based_rate_limiting_flag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_url_based_client_side_integrity_defense_flag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_url_based_client_side_integrity_defense_flag(
		string [] policy_names,
		bool [] url_based_client_side_integrity_defense_flags
	) {
		this.Invoke("set_dos_url_based_client_side_integrity_defense_flag", new object [] {
				policy_names,
				url_based_client_side_integrity_defense_flags});

	}
	public System.IAsyncResult Beginset_dos_url_based_client_side_integrity_defense_flag(string [] policy_names,bool [] url_based_client_side_integrity_defense_flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_url_based_client_side_integrity_defense_flag", new object[] {
			policy_names,
			url_based_client_side_integrity_defense_flags}, callback, asyncState);
	}
	public void Endset_dos_url_based_client_side_integrity_defense_flag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_url_based_rate_limiting_flag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_url_based_rate_limiting_flag(
		string [] policy_names,
		bool [] url_based_rate_limiting_flags
	) {
		this.Invoke("set_dos_url_based_rate_limiting_flag", new object [] {
				policy_names,
				url_based_rate_limiting_flags});

	}
	public System.IAsyncResult Beginset_dos_url_based_rate_limiting_flag(string [] policy_names,bool [] url_based_rate_limiting_flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_url_based_rate_limiting_flag", new object[] {
			policy_names,
			url_based_rate_limiting_flags}, callback, asyncState);
	}
	public void Endset_dos_url_based_rate_limiting_flag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_url_maximum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_url_maximum_tps(
		string [] policy_names,
		long [] url_maximum_tpses
	) {
		this.Invoke("set_dos_url_maximum_tps", new object [] {
				policy_names,
				url_maximum_tpses});

	}
	public System.IAsyncResult Beginset_dos_url_maximum_tps(string [] policy_names,long [] url_maximum_tpses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_url_maximum_tps", new object[] {
			policy_names,
			url_maximum_tpses}, callback, asyncState);
	}
	public void Endset_dos_url_maximum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_url_minimum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_url_minimum_tps(
		string [] policy_names,
		long [] url_minimum_tpses
	) {
		this.Invoke("set_dos_url_minimum_tps", new object [] {
				policy_names,
				url_minimum_tpses});

	}
	public System.IAsyncResult Beginset_dos_url_minimum_tps(string [] policy_names,long [] url_minimum_tpses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_url_minimum_tps", new object[] {
			policy_names,
			url_minimum_tpses}, callback, asyncState);
	}
	public void Endset_dos_url_minimum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dos_url_tps_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dos_url_tps_increase_rate(
		string [] policy_names,
		long [] url_tps_increase_rates
	) {
		this.Invoke("set_dos_url_tps_increase_rate", new object [] {
				policy_names,
				url_tps_increase_rates});

	}
	public System.IAsyncResult Beginset_dos_url_tps_increase_rate(string [] policy_names,long [] url_tps_increase_rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dos_url_tps_increase_rate", new object[] {
			policy_names,
			url_tps_increase_rates}, callback, asyncState);
	}
	public void Endset_dos_url_tps_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dynamic_sessions_in_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_dynamic_sessions_in_url(
		string [] policy_names,
		ASMDynamicSessionsInUrl [] settings
	) {
		this.Invoke("set_dynamic_sessions_in_url", new object [] {
				policy_names,
				settings});

	}
	public System.IAsyncResult Beginset_dynamic_sessions_in_url(string [] policy_names,ASMDynamicSessionsInUrl [] settings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dynamic_sessions_in_url", new object[] {
			policy_names,
			settings}, callback, asyncState);
	}
	public void Endset_dynamic_sessions_in_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_http_header_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_http_header_length(
		string [] policy_names,
		long [] http_header_lengths
	) {
		this.Invoke("set_http_header_length", new object [] {
				policy_names,
				http_header_lengths});

	}
	public System.IAsyncResult Beginset_http_header_length(string [] policy_names,long [] http_header_lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_http_header_length", new object[] {
			policy_names,
			http_header_lengths}, callback, asyncState);
	}
	public void Endset_http_header_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_http_response_splitting
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool set_http_response_splitting(
		string policy_name
	) {
		object [] results = this.Invoke("set_http_response_splitting", new object [] {
				policy_name});
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginset_http_response_splitting(string policy_name, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_http_response_splitting", new object[] {
			policy_name}, callback, asyncState);
	}
	public bool Endset_http_response_splitting(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_language
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_language(
		string [] policy_names,
		ASMWebApplicationLanguage [] languages
	) {
		this.Invoke("set_language", new object [] {
				policy_names,
				languages});

	}
	public System.IAsyncResult Beginset_language(string [] policy_names,ASMWebApplicationLanguage [] languages, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_language", new object[] {
			policy_names,
			languages}, callback, asyncState);
	}
	public void Endset_language(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_language_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_language_template(
		string [] policy_names,
		ASMWebApplicationLanguage [] languages,
		ASMPolicyTemplate [] policy_templates
	) {
		this.Invoke("set_language_template", new object [] {
				policy_names,
				languages,
				policy_templates});

	}
	public System.IAsyncResult Beginset_language_template(string [] policy_names,ASMWebApplicationLanguage [] languages,ASMPolicyTemplate [] policy_templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_language_template", new object[] {
			policy_names,
			languages,
			policy_templates}, callback, asyncState);
	}
	public void Endset_language_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_language_template_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_language_template_name(
		string [] policy_names,
		ASMWebApplicationLanguage [] languages,
		string [] policy_template_names
	) {
		this.Invoke("set_language_template_name", new object [] {
				policy_names,
				languages,
				policy_template_names});

	}
	public System.IAsyncResult Beginset_language_template_name(string [] policy_names,ASMWebApplicationLanguage [] languages,string [] policy_template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_language_template_name", new object[] {
			policy_names,
			languages,
			policy_template_names}, callback, asyncState);
	}
	public void Endset_language_template_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_logging_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_logging_profile(
		string [] policy_names,
		string [] logprof_names
	) {
		this.Invoke("set_logging_profile", new object [] {
				policy_names,
				logprof_names});

	}
	public System.IAsyncResult Beginset_logging_profile(string [] policy_names,string [] logprof_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_logging_profile", new object[] {
			policy_names,
			logprof_names}, callback, asyncState);
	}
	public void Endset_logging_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_path_traversal
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool set_path_traversal(
		string policy_name
	) {
		object [] results = this.Invoke("set_path_traversal", new object [] {
				policy_name});
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginset_path_traversal(string policy_name, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_path_traversal", new object[] {
			policy_name}, callback, asyncState);
	}
	public bool Endset_path_traversal(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_prerequisite_expiration_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_prerequisite_expiration_period(
		string [] policy_names,
		long [] expiration_periods
	) {
		this.Invoke("set_prerequisite_expiration_period", new object [] {
				policy_names,
				expiration_periods});

	}
	public System.IAsyncResult Beginset_prerequisite_expiration_period(string [] policy_names,long [] expiration_periods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prerequisite_expiration_period", new object[] {
			policy_names,
			expiration_periods}, callback, asyncState);
	}
	public void Endset_prerequisite_expiration_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_violation_flags
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void set_violation_flags(
		string [] policy_names,
		ASMViolation [] [] violations
	) {
		this.Invoke("set_violation_flags", new object [] {
				policy_names,
				violations});

	}
	public System.IAsyncResult Beginset_violation_flags(string [] policy_names,ASMViolation [] [] violations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_violation_flags", new object[] {
			policy_names,
			violations}, callback, asyncState);
	}
	public void Endset_violation_flags(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// upload_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void upload_policy(
		string policy_name,
		ASMFileTransferContext file_context
	) {
		this.Invoke("upload_policy", new object [] {
				policy_name,
				file_context});

	}
	public System.IAsyncResult Beginupload_policy(string policy_name,ASMFileTransferContext file_context, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("upload_policy", new object[] {
			policy_name,
			file_context}, callback, asyncState);
	}
	public void Endupload_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// upload_xml_profile_wsdl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/Policy", 
		RequestNamespace="urn:iControl:ASM/Policy", ResponseNamespace="urn:iControl:ASM/Policy")]
	public void upload_xml_profile_wsdl(
		string policy_name,
		string profile_name,
		string wsdl_filename,
		string wsdl_text
	) {
		this.Invoke("upload_xml_profile_wsdl", new object [] {
				policy_name,
				profile_name,
				wsdl_filename,
				wsdl_text});

	}
	public System.IAsyncResult Beginupload_xml_profile_wsdl(string policy_name,string profile_name,string wsdl_filename,string wsdl_text, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("upload_xml_profile_wsdl", new object[] {
			policy_name,
			profile_name,
			wsdl_filename,
			wsdl_text}, callback, asyncState);
	}
	public void Endupload_xml_profile_wsdl(System.IAsyncResult asyncResult) {
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
