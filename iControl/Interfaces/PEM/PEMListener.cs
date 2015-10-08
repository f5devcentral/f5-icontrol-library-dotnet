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
	[System.Web.Services.WebServiceBindingAttribute(Name="PEM.ListenerBinding", Namespace="urn:iControl")]
	public partial class PEMListener : iControlInterface {
		public PEMListener() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
	public void add_virtual_server(
		string [] listeners,
		string [] [] servers
	) {
		this.Invoke("add_virtual_server", new object [] {
				listeners,
				servers});

	}
	public System.IAsyncResult Beginadd_virtual_server(string [] listeners,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_virtual_server", new object[] {
			listeners,
			servers}, callback, asyncState);
	}
	public void Endadd_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
	public void create(
		string [] listeners,
		string [] profiles,
		string [] [] servers
	) {
		this.Invoke("create", new object [] {
				listeners,
				profiles,
				servers});

	}
	public System.IAsyncResult Begincreate(string [] listeners,string [] profiles,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			listeners,
			profiles,
			servers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_listeners
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
	public void delete_all_listeners(

	) {
		this.Invoke("delete_all_listeners", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_listeners(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_listeners", new object[0], callback, asyncState);
	}
	public void Enddelete_all_listeners(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_listener
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
	public void delete_listener(
		string [] listeners
	) {
		this.Invoke("delete_listener", new object [] {
				listeners});

	}
	public System.IAsyncResult Begindelete_listener(string [] listeners, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_listener", new object[] {
			listeners}, callback, asyncState);
	}
	public void Enddelete_listener(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] listeners
	) {
		object [] results = this.Invoke("get_description", new object [] {
				listeners});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] listeners, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			listeners}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
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
	// get_spm_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_spm_profile(
		string [] listeners
	) {
		object [] results = this.Invoke("get_spm_profile", new object [] {
				listeners});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_spm_profile(string [] listeners, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_spm_profile", new object[] {
			listeners}, callback, asyncState);
	}
	public string [] Endget_spm_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
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
	// get_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_virtual_server(
		string [] listeners
	) {
		object [] results = this.Invoke("get_virtual_server", new object [] {
				listeners});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_virtual_server(string [] listeners, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_virtual_server", new object[] {
			listeners}, callback, asyncState);
	}
	public string [] [] Endget_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
	public void remove_virtual_server(
		string [] listeners,
		string [] [] servers
	) {
		this.Invoke("remove_virtual_server", new object [] {
				listeners,
				servers});

	}
	public System.IAsyncResult Beginremove_virtual_server(string [] listeners,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_virtual_server", new object[] {
			listeners,
			servers}, callback, asyncState);
	}
	public void Endremove_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
	public void set_description(
		string [] listeners,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				listeners,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] listeners,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			listeners,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_spm_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Listener", 
		RequestNamespace="urn:iControl:PEM/Listener", ResponseNamespace="urn:iControl:PEM/Listener")]
	public void set_spm_profile(
		string [] listeners,
		string [] profiles
	) {
		this.Invoke("set_spm_profile", new object [] {
				listeners,
				profiles});

	}
	public System.IAsyncResult Beginset_spm_profile(string [] listeners,string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_spm_profile", new object[] {
			listeners,
			profiles}, callback, asyncState);
	}
	public void Endset_spm_profile(System.IAsyncResult asyncResult) {
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
