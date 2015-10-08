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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.IPsecIkeDaemonBinding", Namespace="urn:iControl")]
	public partial class NetworkingIPsecIkeDaemon : iControlInterface {
		public NetworkingIPsecIkeDaemon() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkeDaemon", 
		RequestNamespace="urn:iControl:Networking/IPsecIkeDaemon", ResponseNamespace="urn:iControl:Networking/IPsecIkeDaemon")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_description(

	) {
		object [] results = this.Invoke("get_description", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_description(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[0], callback, asyncState);
	}
	public string Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_iskamp_natt_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkeDaemon", 
		RequestNamespace="urn:iControl:Networking/IPsecIkeDaemon", ResponseNamespace="urn:iControl:Networking/IPsecIkeDaemon")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_iskamp_natt_port(

	) {
		object [] results = this.Invoke("get_iskamp_natt_port", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_iskamp_natt_port(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_iskamp_natt_port", new object[0], callback, asyncState);
	}
	public long Endget_iskamp_natt_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_iskamp_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkeDaemon", 
		RequestNamespace="urn:iControl:Networking/IPsecIkeDaemon", ResponseNamespace="urn:iControl:Networking/IPsecIkeDaemon")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_iskamp_port(

	) {
		object [] results = this.Invoke("get_iskamp_port", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_iskamp_port(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_iskamp_port", new object[0], callback, asyncState);
	}
	public long Endget_iskamp_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_natt_keep_alive
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkeDaemon", 
		RequestNamespace="urn:iControl:Networking/IPsecIkeDaemon", ResponseNamespace="urn:iControl:Networking/IPsecIkeDaemon")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_natt_keep_alive(

	) {
		object [] results = this.Invoke("get_natt_keep_alive", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_natt_keep_alive(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_natt_keep_alive", new object[0], callback, asyncState);
	}
	public long Endget_natt_keep_alive(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkeDaemon", 
		RequestNamespace="urn:iControl:Networking/IPsecIkeDaemon", ResponseNamespace="urn:iControl:Networking/IPsecIkeDaemon")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkeDaemon", 
		RequestNamespace="urn:iControl:Networking/IPsecIkeDaemon", ResponseNamespace="urn:iControl:Networking/IPsecIkeDaemon")]
	public void set_description(
		string description
	) {
		this.Invoke("set_description", new object [] {
				description});

	}
	public System.IAsyncResult Beginset_description(string description, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			description}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_iskamp_natt_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkeDaemon", 
		RequestNamespace="urn:iControl:Networking/IPsecIkeDaemon", ResponseNamespace="urn:iControl:Networking/IPsecIkeDaemon")]
	public void set_iskamp_natt_port(
		long value
	) {
		this.Invoke("set_iskamp_natt_port", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_iskamp_natt_port(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_iskamp_natt_port", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_iskamp_natt_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_iskamp_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkeDaemon", 
		RequestNamespace="urn:iControl:Networking/IPsecIkeDaemon", ResponseNamespace="urn:iControl:Networking/IPsecIkeDaemon")]
	public void set_iskamp_port(
		long value
	) {
		this.Invoke("set_iskamp_port", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_iskamp_port(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_iskamp_port", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_iskamp_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_natt_keep_alive
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkeDaemon", 
		RequestNamespace="urn:iControl:Networking/IPsecIkeDaemon", ResponseNamespace="urn:iControl:Networking/IPsecIkeDaemon")]
	public void set_natt_keep_alive(
		long value
	) {
		this.Invoke("set_natt_keep_alive", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_natt_keep_alive(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_natt_keep_alive", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_natt_keep_alive(System.IAsyncResult asyncResult) {
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
