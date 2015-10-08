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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.PortMirrorBinding", Namespace="urn:iControl")]
	public partial class NetworkingPortMirror : iControlInterface {
		public NetworkingPortMirror() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PortMirror", 
		RequestNamespace="urn:iControl:Networking/PortMirror", ResponseNamespace="urn:iControl:Networking/PortMirror")]
	public void add_interface(
		string [] pmirrors,
		string [] [] interfaces
	) {
		this.Invoke("add_interface", new object [] {
				pmirrors,
				interfaces});

	}
	public System.IAsyncResult Beginadd_interface(string [] pmirrors,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_interface", new object[] {
			pmirrors,
			interfaces}, callback, asyncState);
	}
	public void Endadd_interface(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PortMirror", 
		RequestNamespace="urn:iControl:Networking/PortMirror", ResponseNamespace="urn:iControl:Networking/PortMirror")]
	public void create(
		string [] pmirrors,
		string [] [] interfaces
	) {
		this.Invoke("create", new object [] {
				pmirrors,
				interfaces});

	}
	public System.IAsyncResult Begincreate(string [] pmirrors,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			pmirrors,
			interfaces}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_port_mirrors
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PortMirror", 
		RequestNamespace="urn:iControl:Networking/PortMirror", ResponseNamespace="urn:iControl:Networking/PortMirror")]
	public void delete_all_port_mirrors(

	) {
		this.Invoke("delete_all_port_mirrors", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_port_mirrors(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_port_mirrors", new object[0], callback, asyncState);
	}
	public void Enddelete_all_port_mirrors(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_port_mirror
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PortMirror", 
		RequestNamespace="urn:iControl:Networking/PortMirror", ResponseNamespace="urn:iControl:Networking/PortMirror")]
	public void delete_port_mirror(
		string [] pmirrors
	) {
		this.Invoke("delete_port_mirror", new object [] {
				pmirrors});

	}
	public System.IAsyncResult Begindelete_port_mirror(string [] pmirrors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_port_mirror", new object[] {
			pmirrors}, callback, asyncState);
	}
	public void Enddelete_port_mirror(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PortMirror", 
		RequestNamespace="urn:iControl:Networking/PortMirror", ResponseNamespace="urn:iControl:Networking/PortMirror")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_interface(
		string [] pmirrors
	) {
		object [] results = this.Invoke("get_interface", new object [] {
				pmirrors});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface(string [] pmirrors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface", new object[] {
			pmirrors}, callback, asyncState);
	}
	public string [] [] Endget_interface(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PortMirror", 
		RequestNamespace="urn:iControl:Networking/PortMirror", ResponseNamespace="urn:iControl:Networking/PortMirror")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PortMirror", 
		RequestNamespace="urn:iControl:Networking/PortMirror", ResponseNamespace="urn:iControl:Networking/PortMirror")]
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
	// remove_all_interfaces
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PortMirror", 
		RequestNamespace="urn:iControl:Networking/PortMirror", ResponseNamespace="urn:iControl:Networking/PortMirror")]
	public void remove_all_interfaces(
		string [] pmirrors
	) {
		this.Invoke("remove_all_interfaces", new object [] {
				pmirrors});

	}
	public System.IAsyncResult Beginremove_all_interfaces(string [] pmirrors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_interfaces", new object[] {
			pmirrors}, callback, asyncState);
	}
	public void Endremove_all_interfaces(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PortMirror", 
		RequestNamespace="urn:iControl:Networking/PortMirror", ResponseNamespace="urn:iControl:Networking/PortMirror")]
	public void remove_interface(
		string [] pmirrors,
		string [] [] interfaces
	) {
		this.Invoke("remove_interface", new object [] {
				pmirrors,
				interfaces});

	}
	public System.IAsyncResult Beginremove_interface(string [] pmirrors,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_interface", new object[] {
			pmirrors,
			interfaces}, callback, asyncState);
	}
	public void Endremove_interface(System.IAsyncResult asyncResult) {
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
