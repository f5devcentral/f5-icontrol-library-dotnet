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
	[System.Web.Services.WebServiceBindingAttribute(Name="Log.DestinationManagementPortBinding", Namespace="urn:iControl")]
	public partial class LogDestinationManagementPort : iControlInterface {
		public LogDestinationManagementPort() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	public void create(
		string [] destinations,
		string [] addresses,
		long [] ports,
		LogLogProtocol [] protocols
	) {
		this.Invoke("create", new object [] {
				destinations,
				addresses,
				ports,
				protocols});

	}
	public System.IAsyncResult Begincreate(string [] destinations,string [] addresses,long [] ports,LogLogProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			destinations,
			addresses,
			ports,
			protocols}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_management_port_destinations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	public void delete_all_management_port_destinations(

	) {
		this.Invoke("delete_all_management_port_destinations", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_management_port_destinations(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_management_port_destinations", new object[0], callback, asyncState);
	}
	public void Enddelete_all_management_port_destinations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_management_port_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	public void delete_management_port_destination(
		string [] destinations
	) {
		this.Invoke("delete_management_port_destination", new object [] {
				destinations});

	}
	public System.IAsyncResult Begindelete_management_port_destination(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_management_port_destination", new object[] {
			destinations}, callback, asyncState);
	}
	public void Enddelete_management_port_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] destinations
	) {
		object [] results = this.Invoke("get_description", new object [] {
				destinations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			destinations}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_destination_address(
		string [] destinations
	) {
		object [] results = this.Invoke("get_destination_address", new object [] {
				destinations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_address(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_address", new object[] {
			destinations}, callback, asyncState);
	}
	public string [] Endget_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_destination_port(
		string [] destinations
	) {
		object [] results = this.Invoke("get_destination_port", new object [] {
				destinations});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_port(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_port", new object[] {
			destinations}, callback, asyncState);
	}
	public long [] Endget_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
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
	// get_log_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LogLogProtocol [] get_log_protocol(
		string [] destinations
	) {
		object [] results = this.Invoke("get_log_protocol", new object [] {
				destinations});
		return ((LogLogProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_protocol(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_protocol", new object[] {
			destinations}, callback, asyncState);
	}
	public LogLogProtocol [] Endget_log_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LogLogProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	public void set_description(
		string [] destinations,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				destinations,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] destinations,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			destinations,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	public void set_destination_address(
		string [] destinations,
		string [] addresses
	) {
		this.Invoke("set_destination_address", new object [] {
				destinations,
				addresses});

	}
	public System.IAsyncResult Beginset_destination_address(string [] destinations,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_address", new object[] {
			destinations,
			addresses}, callback, asyncState);
	}
	public void Endset_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	public void set_destination_port(
		string [] destinations,
		long [] ports
	) {
		this.Invoke("set_destination_port", new object [] {
				destinations,
				ports});

	}
	public System.IAsyncResult Beginset_destination_port(string [] destinations,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_port", new object[] {
			destinations,
			ports}, callback, asyncState);
	}
	public void Endset_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationManagementPort", 
		RequestNamespace="urn:iControl:Log/DestinationManagementPort", ResponseNamespace="urn:iControl:Log/DestinationManagementPort")]
	public void set_log_protocol(
		string [] destinations,
		LogLogProtocol [] protocols
	) {
		this.Invoke("set_log_protocol", new object [] {
				destinations,
				protocols});

	}
	public System.IAsyncResult Beginset_log_protocol(string [] destinations,LogLogProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_protocol", new object[] {
			destinations,
			protocols}, callback, asyncState);
	}
	public void Endset_log_protocol(System.IAsyncResult asyncResult) {
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
