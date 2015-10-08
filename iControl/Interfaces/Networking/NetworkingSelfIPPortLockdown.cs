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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.SelfIPPortLockdownBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingSelfIPPortLockdownSelfIPAccess))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingSelfIPPortLockdownProtocolPort))]
	public partial class NetworkingSelfIPPortLockdown : iControlInterface {
		public NetworkingSelfIPPortLockdown() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_allow_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPPortLockdown", 
		RequestNamespace="urn:iControl:Networking/SelfIPPortLockdown", ResponseNamespace="urn:iControl:Networking/SelfIPPortLockdown")]
	public void add_allow_access_list(
		NetworkingSelfIPPortLockdownSelfIPAccess [] access_lists
	) {
		this.Invoke("add_allow_access_list", new object [] {
				access_lists});

	}
	public System.IAsyncResult Beginadd_allow_access_list(NetworkingSelfIPPortLockdownSelfIPAccess [] access_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_allow_access_list", new object[] {
			access_lists}, callback, asyncState);
	}
	public void Endadd_allow_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_default_protocol_port_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPPortLockdown", 
		RequestNamespace="urn:iControl:Networking/SelfIPPortLockdown", ResponseNamespace="urn:iControl:Networking/SelfIPPortLockdown")]
	public void add_default_protocol_port_access_list(
		NetworkingSelfIPPortLockdownProtocolPort [] defaults
	) {
		this.Invoke("add_default_protocol_port_access_list", new object [] {
				defaults});

	}
	public System.IAsyncResult Beginadd_default_protocol_port_access_list(NetworkingSelfIPPortLockdownProtocolPort [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_default_protocol_port_access_list", new object[] {
			defaults}, callback, asyncState);
	}
	public void Endadd_default_protocol_port_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_allow_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPPortLockdown", 
		RequestNamespace="urn:iControl:Networking/SelfIPPortLockdown", ResponseNamespace="urn:iControl:Networking/SelfIPPortLockdown")]
	public void delete_allow_access_list(
		NetworkingSelfIPPortLockdownSelfIPAccess [] access_lists
	) {
		this.Invoke("delete_allow_access_list", new object [] {
				access_lists});

	}
	public System.IAsyncResult Begindelete_allow_access_list(NetworkingSelfIPPortLockdownSelfIPAccess [] access_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_allow_access_list", new object[] {
			access_lists}, callback, asyncState);
	}
	public void Enddelete_allow_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_allow_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPPortLockdown", 
		RequestNamespace="urn:iControl:Networking/SelfIPPortLockdown", ResponseNamespace="urn:iControl:Networking/SelfIPPortLockdown")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSelfIPPortLockdownSelfIPAccess [] get_allow_access_list(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_allow_access_list", new object [] {
				self_ips});
		return ((NetworkingSelfIPPortLockdownSelfIPAccess [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_access_list(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_access_list", new object[] {
			self_ips}, callback, asyncState);
	}
	public NetworkingSelfIPPortLockdownSelfIPAccess [] Endget_allow_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSelfIPPortLockdownSelfIPAccess [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_protocol_port_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPPortLockdown", 
		RequestNamespace="urn:iControl:Networking/SelfIPPortLockdown", ResponseNamespace="urn:iControl:Networking/SelfIPPortLockdown")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSelfIPPortLockdownProtocolPort [] get_default_protocol_port_access_list(

	) {
		object [] results = this.Invoke("get_default_protocol_port_access_list", new object [0]);
		return ((NetworkingSelfIPPortLockdownProtocolPort [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_protocol_port_access_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_protocol_port_access_list", new object[0], callback, asyncState);
	}
	public NetworkingSelfIPPortLockdownProtocolPort [] Endget_default_protocol_port_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSelfIPPortLockdownProtocolPort [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPPortLockdown", 
		RequestNamespace="urn:iControl:Networking/SelfIPPortLockdown", ResponseNamespace="urn:iControl:Networking/SelfIPPortLockdown")]
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
	// remove_default_protocol_port_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPPortLockdown", 
		RequestNamespace="urn:iControl:Networking/SelfIPPortLockdown", ResponseNamespace="urn:iControl:Networking/SelfIPPortLockdown")]
	public void remove_default_protocol_port_access_list(
		NetworkingSelfIPPortLockdownProtocolPort [] defaults
	) {
		this.Invoke("remove_default_protocol_port_access_list", new object [] {
				defaults});

	}
	public System.IAsyncResult Beginremove_default_protocol_port_access_list(NetworkingSelfIPPortLockdownProtocolPort [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_default_protocol_port_access_list", new object[] {
			defaults}, callback, asyncState);
	}
	public void Endremove_default_protocol_port_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.SelfIPPortLockdown.AllowMode", Namespace = "urn:iControl")]
	public enum NetworkingSelfIPPortLockdownAllowMode
	{
		ALLOW_MODE_PROTOCOL_PORT,
		ALLOW_MODE_NONE,
		ALLOW_MODE_DEFAULTS,
		ALLOW_MODE_ALL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.SelfIPPortLockdown.ProtocolPort", Namespace = "urn:iControl")]
	public partial class NetworkingSelfIPPortLockdownProtocolPort
	{
		private CommonProtocolType protocolField;
		public CommonProtocolType protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}
		private long portField;
		public long port
		{
			get { return this.portField; }
			set { this.portField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.SelfIPPortLockdown.SelfIPAccess", Namespace = "urn:iControl")]
	public partial class NetworkingSelfIPPortLockdownSelfIPAccess
	{
		private string self_ipField;
		public string self_ip
		{
			get { return this.self_ipField; }
			set { this.self_ipField = value; }
		}
		private NetworkingSelfIPPortLockdownAllowMode modeField;
		public NetworkingSelfIPPortLockdownAllowMode mode
		{
			get { return this.modeField; }
			set { this.modeField = value; }
		}
		private NetworkingSelfIPPortLockdownProtocolPort [] protocol_portsField;
		public NetworkingSelfIPPortLockdownProtocolPort [] protocol_ports
		{
			get { return this.protocol_portsField; }
			set { this.protocol_portsField = value; }
		}
	};

}
