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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.RADIUSServerBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementRADIUSServerRADIUSServerDefinition))]
	public partial class ManagementRADIUSServer : iControlInterface {
		public ManagementRADIUSServer() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	public void create(
		ManagementRADIUSServerRADIUSServerDefinition [] servers
	) {
		this.Invoke("create", new object [] {
				servers});

	}
	public System.IAsyncResult Begincreate(ManagementRADIUSServerRADIUSServerDefinition [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			servers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	public void delete_all_servers(

	) {
		this.Invoke("delete_all_servers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_servers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_servers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	public void delete_server(
		string [] servers
	) {
		this.Invoke("delete_server", new object [] {
				servers});

	}
	public System.IAsyncResult Begindelete_server(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_server", new object[] {
			servers}, callback, asyncState);
	}
	public void Enddelete_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] servers
	) {
		object [] results = this.Invoke("get_description", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_or_hostname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ip_or_hostname(
		string [] servers
	) {
		object [] results = this.Invoke("get_ip_or_hostname", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_or_hostname(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_or_hostname", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_ip_or_hostname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
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
	// get_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_port(
		string [] servers
	) {
		object [] results = this.Invoke("get_port", new object [] {
				servers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_port(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_port", new object[] {
			servers}, callback, asyncState);
	}
	public long [] Endget_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_secret
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_secret(
		string [] servers
	) {
		object [] results = this.Invoke("get_secret", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_secret(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_secret", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_secret(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_timeout(
		string [] servers
	) {
		object [] results = this.Invoke("get_timeout", new object [] {
				servers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_timeout(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timeout", new object[] {
			servers}, callback, asyncState);
	}
	public long [] Endget_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
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
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	public void set_description(
		string [] servers,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				servers,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] servers,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			servers,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_or_hostname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	public void set_ip_or_hostname(
		string [] servers,
		string [] ip_or_hostnames
	) {
		this.Invoke("set_ip_or_hostname", new object [] {
				servers,
				ip_or_hostnames});

	}
	public System.IAsyncResult Beginset_ip_or_hostname(string [] servers,string [] ip_or_hostnames, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_or_hostname", new object[] {
			servers,
			ip_or_hostnames}, callback, asyncState);
	}
	public void Endset_ip_or_hostname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	public void set_port(
		string [] servers,
		long [] ports
	) {
		this.Invoke("set_port", new object [] {
				servers,
				ports});

	}
	public System.IAsyncResult Beginset_port(string [] servers,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_port", new object[] {
			servers,
			ports}, callback, asyncState);
	}
	public void Endset_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_secret
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	public void set_secret(
		string [] servers,
		string [] secrets
	) {
		this.Invoke("set_secret", new object [] {
				servers,
				secrets});

	}
	public System.IAsyncResult Beginset_secret(string [] servers,string [] secrets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_secret", new object[] {
			servers,
			secrets}, callback, asyncState);
	}
	public void Endset_secret(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSServer", 
		RequestNamespace="urn:iControl:Management/RADIUSServer", ResponseNamespace="urn:iControl:Management/RADIUSServer")]
	public void set_timeout(
		string [] servers,
		long [] timeouts
	) {
		this.Invoke("set_timeout", new object [] {
				servers,
				timeouts});

	}
	public System.IAsyncResult Beginset_timeout(string [] servers,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timeout", new object[] {
			servers,
			timeouts}, callback, asyncState);
	}
	public void Endset_timeout(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.RADIUSServer.RADIUSServerDefinition", Namespace = "urn:iControl")]
	public partial class ManagementRADIUSServerRADIUSServerDefinition
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string ip_or_hostnameField;
		public string ip_or_hostname
		{
			get { return this.ip_or_hostnameField; }
			set { this.ip_or_hostnameField = value; }
		}
		private long serviceField;
		public long service
		{
			get { return this.serviceField; }
			set { this.serviceField = value; }
		}
		private string secretField;
		public string secret
		{
			get { return this.secretField; }
			set { this.secretField = value; }
		}
	};

}
