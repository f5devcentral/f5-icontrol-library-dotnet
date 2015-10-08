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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.OCSPConfigurationBinding", Namespace="urn:iControl")]
	public partial class ManagementOCSPConfiguration : iControlInterface {
		public ManagementOCSPConfiguration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_responder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
	public void add_responder(
		string [] config_names,
		string [] [] responders
	) {
		this.Invoke("add_responder", new object [] {
				config_names,
				responders});

	}
	public System.IAsyncResult Beginadd_responder(string [] config_names,string [] [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_responder", new object[] {
			config_names,
			responders}, callback, asyncState);
	}
	public void Endadd_responder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
	public void create(
		string [] config_names,
		string [] [] responders
	) {
		this.Invoke("create", new object [] {
				config_names,
				responders});

	}
	public System.IAsyncResult Begincreate(string [] config_names,string [] [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			config_names,
			responders}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_configurations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
	public void delete_all_configurations(

	) {
		this.Invoke("delete_all_configurations", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_configurations(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_configurations", new object[0], callback, asyncState);
	}
	public void Enddelete_all_configurations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
	public void delete_configuration(
		string [] config_names
	) {
		this.Invoke("delete_configuration", new object [] {
				config_names});

	}
	public System.IAsyncResult Begindelete_configuration(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_configuration", new object[] {
			config_names}, callback, asyncState);
	}
	public void Enddelete_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] config_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
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
	// get_responder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_responder(
		string [] config_names
	) {
		object [] results = this.Invoke("get_responder", new object [] {
				config_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_responder(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_responder", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] [] Endget_responder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
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
	// remove_all_responders
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
	public void remove_all_responders(
		string [] config_names
	) {
		this.Invoke("remove_all_responders", new object [] {
				config_names});

	}
	public System.IAsyncResult Beginremove_all_responders(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_responders", new object[] {
			config_names}, callback, asyncState);
	}
	public void Endremove_all_responders(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_responder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
	public void remove_responder(
		string [] config_names,
		string [] [] responders
	) {
		this.Invoke("remove_responder", new object [] {
				config_names,
				responders});

	}
	public System.IAsyncResult Beginremove_responder(string [] config_names,string [] [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_responder", new object[] {
			config_names,
			responders}, callback, asyncState);
	}
	public void Endremove_responder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPConfiguration", 
		RequestNamespace="urn:iControl:Management/OCSPConfiguration", ResponseNamespace="urn:iControl:Management/OCSPConfiguration")]
	public void set_description(
		string [] config_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				config_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] config_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			config_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
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
