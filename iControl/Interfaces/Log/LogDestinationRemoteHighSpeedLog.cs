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
	[System.Web.Services.WebServiceBindingAttribute(Name="Log.DestinationRemoteHighSpeedLogBinding", Namespace="urn:iControl")]
	public partial class LogDestinationRemoteHighSpeedLog : iControlInterface {
		public LogDestinationRemoteHighSpeedLog() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
	public void create(
		string [] destinations,
		string [] pools,
		LogDestinationRemoteHighSpeedLogHighSpeedLogProtocol [] protocols
	) {
		this.Invoke("create", new object [] {
				destinations,
				pools,
				protocols});

	}
	public System.IAsyncResult Begincreate(string [] destinations,string [] pools,LogDestinationRemoteHighSpeedLogHighSpeedLogProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			destinations,
			pools,
			protocols}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_remote_high_speed_log_destinations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
	public void delete_all_remote_high_speed_log_destinations(

	) {
		this.Invoke("delete_all_remote_high_speed_log_destinations", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_remote_high_speed_log_destinations(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_remote_high_speed_log_destinations", new object[0], callback, asyncState);
	}
	public void Enddelete_all_remote_high_speed_log_destinations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_remote_high_speed_log_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
	public void delete_remote_high_speed_log_destination(
		string [] destinations
	) {
		this.Invoke("delete_remote_high_speed_log_destination", new object [] {
				destinations});

	}
	public System.IAsyncResult Begindelete_remote_high_speed_log_destination(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_remote_high_speed_log_destination", new object[] {
			destinations}, callback, asyncState);
	}
	public void Enddelete_remote_high_speed_log_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
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
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LogDestinationRemoteHighSpeedLogHighSpeedLogProtocol [] get_log_protocol(
		string [] destinations
	) {
		object [] results = this.Invoke("get_log_protocol", new object [] {
				destinations});
		return ((LogDestinationRemoteHighSpeedLogHighSpeedLogProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_protocol(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_protocol", new object[] {
			destinations}, callback, asyncState);
	}
	public LogDestinationRemoteHighSpeedLogHighSpeedLogProtocol [] Endget_log_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LogDestinationRemoteHighSpeedLogHighSpeedLogProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_pool(
		string [] destinations
	) {
		object [] results = this.Invoke("get_pool", new object [] {
				destinations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool", new object[] {
			destinations}, callback, asyncState);
	}
	public string [] Endget_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
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
	// set_log_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
	public void set_log_protocol(
		string [] destinations,
		LogDestinationRemoteHighSpeedLogHighSpeedLogProtocol [] protocols
	) {
		this.Invoke("set_log_protocol", new object [] {
				destinations,
				protocols});

	}
	public System.IAsyncResult Beginset_log_protocol(string [] destinations,LogDestinationRemoteHighSpeedLogHighSpeedLogProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_protocol", new object[] {
			destinations,
			protocols}, callback, asyncState);
	}
	public void Endset_log_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteHighSpeedLog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog", ResponseNamespace="urn:iControl:Log/DestinationRemoteHighSpeedLog")]
	public void set_pool(
		string [] destinations,
		string [] pools
	) {
		this.Invoke("set_pool", new object [] {
				destinations,
				pools});

	}
	public System.IAsyncResult Beginset_pool(string [] destinations,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pool", new object[] {
			destinations,
			pools}, callback, asyncState);
	}
	public void Endset_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Log.DestinationRemoteHighSpeedLog.HighSpeedLogProtocol", Namespace = "urn:iControl")]
	public enum LogDestinationRemoteHighSpeedLogHighSpeedLogProtocol
	{
		HIGH_SPEED_LOG_PROTOCOL_UNKNOWN,
		HIGH_SPEED_LOG_PROTOCOL_TCP,
		HIGH_SPEED_LOG_PROTOCOL_UDP,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
