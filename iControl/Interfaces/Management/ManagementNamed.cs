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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.NamedBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementStatementDefinition))]
	public partial class ManagementNamed : iControlInterface {
		public ManagementNamed() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// delete_acl_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void delete_acl_statement(
		string [] statement_names
	) {
		this.Invoke("delete_acl_statement", new object [] {
				statement_names});

	}
	public System.IAsyncResult Begindelete_acl_statement(string [] statement_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_acl_statement", new object[] {
			statement_names}, callback, asyncState);
	}
	public void Enddelete_acl_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_controls_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void delete_controls_statement(

	) {
		this.Invoke("delete_controls_statement", new object [0]);

	}
	public System.IAsyncResult Begindelete_controls_statement(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_controls_statement", new object[0], callback, asyncState);
	}
	public void Enddelete_controls_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_include_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void delete_include_statement(
		string [] path_names
	) {
		this.Invoke("delete_include_statement", new object [] {
				path_names});

	}
	public System.IAsyncResult Begindelete_include_statement(string [] path_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_include_statement", new object[] {
			path_names}, callback, asyncState);
	}
	public void Enddelete_include_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_key_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void delete_key_statement(
		string [] statement_names
	) {
		this.Invoke("delete_key_statement", new object [] {
				statement_names});

	}
	public System.IAsyncResult Begindelete_key_statement(string [] statement_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_key_statement", new object[] {
			statement_names}, callback, asyncState);
	}
	public void Enddelete_key_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_logging_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void delete_logging_statement(

	) {
		this.Invoke("delete_logging_statement", new object [0]);

	}
	public System.IAsyncResult Begindelete_logging_statement(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_logging_statement", new object[0], callback, asyncState);
	}
	public void Enddelete_logging_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_options_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void delete_options_statement(

	) {
		this.Invoke("delete_options_statement", new object [0]);

	}
	public System.IAsyncResult Begindelete_options_statement(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_options_statement", new object[0], callback, asyncState);
	}
	public void Enddelete_options_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_server_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void delete_server_statement(
		string [] statement_names
	) {
		this.Invoke("delete_server_statement", new object [] {
				statement_names});

	}
	public System.IAsyncResult Begindelete_server_statement(string [] statement_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_server_statement", new object[] {
			statement_names}, callback, asyncState);
	}
	public void Enddelete_server_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_trusted_keys_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void delete_trusted_keys_statement(

	) {
		this.Invoke("delete_trusted_keys_statement", new object [0]);

	}
	public System.IAsyncResult Begindelete_trusted_keys_statement(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_trusted_keys_statement", new object[0], callback, asyncState);
	}
	public void Enddelete_trusted_keys_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_bind_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_bind_version(

	) {
		object [] results = this.Invoke("get_bind_version", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_bind_version(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bind_version", new object[0], callback, asyncState);
	}
	public string Endget_bind_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_named_configuration_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_named_configuration_file(

	) {
		object [] results = this.Invoke("get_named_configuration_file", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_named_configuration_file(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_named_configuration_file", new object[0], callback, asyncState);
	}
	public string [] Endget_named_configuration_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
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
	// set_acl_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void set_acl_statement(
		ManagementStatementDefinition [] statements
	) {
		this.Invoke("set_acl_statement", new object [] {
				statements});

	}
	public System.IAsyncResult Beginset_acl_statement(ManagementStatementDefinition [] statements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_acl_statement", new object[] {
			statements}, callback, asyncState);
	}
	public void Endset_acl_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_controls_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void set_controls_statement(
		ManagementStatementDefinition statement
	) {
		this.Invoke("set_controls_statement", new object [] {
				statement});

	}
	public System.IAsyncResult Beginset_controls_statement(ManagementStatementDefinition statement, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_controls_statement", new object[] {
			statement}, callback, asyncState);
	}
	public void Endset_controls_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_include_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void set_include_statement(
		ManagementStatementDefinition [] statements
	) {
		this.Invoke("set_include_statement", new object [] {
				statements});

	}
	public System.IAsyncResult Beginset_include_statement(ManagementStatementDefinition [] statements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_include_statement", new object[] {
			statements}, callback, asyncState);
	}
	public void Endset_include_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_key_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void set_key_statement(
		ManagementStatementDefinition [] statements
	) {
		this.Invoke("set_key_statement", new object [] {
				statements});

	}
	public System.IAsyncResult Beginset_key_statement(ManagementStatementDefinition [] statements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_key_statement", new object[] {
			statements}, callback, asyncState);
	}
	public void Endset_key_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_logging_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void set_logging_statement(
		ManagementStatementDefinition statement
	) {
		this.Invoke("set_logging_statement", new object [] {
				statement});

	}
	public System.IAsyncResult Beginset_logging_statement(ManagementStatementDefinition statement, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_logging_statement", new object[] {
			statement}, callback, asyncState);
	}
	public void Endset_logging_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_options_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void set_options_statement(
		ManagementStatementDefinition statement
	) {
		this.Invoke("set_options_statement", new object [] {
				statement});

	}
	public System.IAsyncResult Beginset_options_statement(ManagementStatementDefinition statement, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_options_statement", new object[] {
			statement}, callback, asyncState);
	}
	public void Endset_options_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void set_server_statement(
		ManagementStatementDefinition [] statements
	) {
		this.Invoke("set_server_statement", new object [] {
				statements});

	}
	public System.IAsyncResult Beginset_server_statement(ManagementStatementDefinition [] statements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_statement", new object[] {
			statements}, callback, asyncState);
	}
	public void Endset_server_statement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trusted_keys_statement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Named", 
		RequestNamespace="urn:iControl:Management/Named", ResponseNamespace="urn:iControl:Management/Named")]
	public void set_trusted_keys_statement(
		ManagementStatementDefinition statement
	) {
		this.Invoke("set_trusted_keys_statement", new object [] {
				statement});

	}
	public System.IAsyncResult Beginset_trusted_keys_statement(ManagementStatementDefinition statement, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trusted_keys_statement", new object[] {
			statement}, callback, asyncState);
	}
	public void Endset_trusted_keys_statement(System.IAsyncResult asyncResult) {
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
