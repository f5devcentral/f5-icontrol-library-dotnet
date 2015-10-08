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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.InternalBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemInternalURI))]
	public partial class SystemInternal : iControlInterface {
		public SystemInternal() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_methods
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Internal", 
		RequestNamespace="urn:iControl:System/Internal", ResponseNamespace="urn:iControl:System/Internal")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_methods(

	) {
		object [] results = this.Invoke("get_methods", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_methods(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_methods", new object[0], callback, asyncState);
	}
	public string [] Endget_methods(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Internal", 
		RequestNamespace="urn:iControl:System/Internal", ResponseNamespace="urn:iControl:System/Internal")]
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
	// map_uri
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Internal", 
		RequestNamespace="urn:iControl:System/Internal", ResponseNamespace="urn:iControl:System/Internal")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemInternalURI [] map_uri(
		string [] target_tags
	) {
		object [] results = this.Invoke("map_uri", new object [] {
				target_tags});
		return ((SystemInternalURI [])(results[0]));
	}
	public System.IAsyncResult Beginmap_uri(string [] target_tags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("map_uri", new object[] {
			target_tags}, callback, asyncState);
	}
	public SystemInternalURI [] Endmap_uri(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemInternalURI [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// test_connection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Internal", 
		RequestNamespace="urn:iControl:System/Internal", ResponseNamespace="urn:iControl:System/Internal")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool test_connection(
		string [] addresses,
		long [] ports
	) {
		object [] results = this.Invoke("test_connection", new object [] {
				addresses,
				ports});
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Begintest_connection(string [] addresses,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("test_connection", new object[] {
			addresses,
			ports}, callback, asyncState);
	}
	public bool Endtest_connection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// test_connection_with_proxy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Internal", 
		RequestNamespace="urn:iControl:System/Internal", ResponseNamespace="urn:iControl:System/Internal")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool test_connection_with_proxy(
		string [] addresses,
		long [] ports,
		string [] proxy_addresses,
		long [] proxy_ports
	) {
		object [] results = this.Invoke("test_connection_with_proxy", new object [] {
				addresses,
				ports,
				proxy_addresses,
				proxy_ports});
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Begintest_connection_with_proxy(string [] addresses,long [] ports,string [] proxy_addresses,long [] proxy_ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("test_connection_with_proxy", new object[] {
			addresses,
			ports,
			proxy_addresses,
			proxy_ports}, callback, asyncState);
	}
	public bool Endtest_connection_with_proxy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Internal.URI", Namespace = "urn:iControl")]
	public partial class SystemInternalURI
	{
		private string pathField;
		public string path
		{
			get { return this.pathField; }
			set { this.pathField = value; }
		}
		private CommonKeyValue [] argmapField;
		public CommonKeyValue [] argmap
		{
			get { return this.argmapField; }
			set { this.argmapField = value; }
		}
	};

}
