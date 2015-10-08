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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.CRLDPServerBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementCRLDPServerCRLDPServerDefinition))]
	public partial class ManagementCRLDPServer : iControlInterface {
		public ManagementCRLDPServer() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
	public void create(
		ManagementCRLDPServerCRLDPServerDefinition [] servers
	) {
		this.Invoke("create", new object [] {
				servers});

	}
	public System.IAsyncResult Begincreate(ManagementCRLDPServerCRLDPServerDefinition [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			servers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
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
	// get_base_dn
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_base_dn(
		string [] servers
	) {
		object [] results = this.Invoke("get_base_dn", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_base_dn(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_base_dn", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_base_dn(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
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
	// get_hostname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_hostname(
		string [] servers
	) {
		object [] results = this.Invoke("get_hostname", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_hostname(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hostname", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_hostname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
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
	// get_reverse_dn_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_reverse_dn_state(
		string [] servers
	) {
		object [] results = this.Invoke("get_reverse_dn_state", new object [] {
				servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_reverse_dn_state(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_reverse_dn_state", new object[] {
			servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_reverse_dn_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
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
	// set_base_dn
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
	public void set_base_dn(
		string [] servers,
		string [] base_dns
	) {
		this.Invoke("set_base_dn", new object [] {
				servers,
				base_dns});

	}
	public System.IAsyncResult Beginset_base_dn(string [] servers,string [] base_dns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_base_dn", new object[] {
			servers,
			base_dns}, callback, asyncState);
	}
	public void Endset_base_dn(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
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
	// set_hostname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
	public void set_hostname(
		string [] servers,
		string [] hostnames
	) {
		this.Invoke("set_hostname", new object [] {
				servers,
				hostnames});

	}
	public System.IAsyncResult Beginset_hostname(string [] servers,string [] hostnames, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hostname", new object[] {
			servers,
			hostnames}, callback, asyncState);
	}
	public void Endset_hostname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
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
	// set_reverse_dn_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPServer", 
		RequestNamespace="urn:iControl:Management/CRLDPServer", ResponseNamespace="urn:iControl:Management/CRLDPServer")]
	public void set_reverse_dn_state(
		string [] servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_reverse_dn_state", new object [] {
				servers,
				states});

	}
	public System.IAsyncResult Beginset_reverse_dn_state(string [] servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_reverse_dn_state", new object[] {
			servers,
			states}, callback, asyncState);
	}
	public void Endset_reverse_dn_state(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.CRLDPServer.CRLDPServerDefinition", Namespace = "urn:iControl")]
	public partial class ManagementCRLDPServerCRLDPServerDefinition
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string hostnameField;
		public string hostname
		{
			get { return this.hostnameField; }
			set { this.hostnameField = value; }
		}
		private long portField;
		public long port
		{
			get { return this.portField; }
			set { this.portField = value; }
		}
	};

}
