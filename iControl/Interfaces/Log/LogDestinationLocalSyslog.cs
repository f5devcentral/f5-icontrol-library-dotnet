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
	[System.Web.Services.WebServiceBindingAttribute(Name="Log.DestinationLocalSyslogBinding", Namespace="urn:iControl")]
	public partial class LogDestinationLocalSyslog : iControlInterface {
		public LogDestinationLocalSyslog() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_default_facility
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationLocalSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationLocalSyslog", ResponseNamespace="urn:iControl:Log/DestinationLocalSyslog")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LogSyslogFacility [] get_default_facility(
		string [] destinations
	) {
		object [] results = this.Invoke("get_default_facility", new object [] {
				destinations});
		return ((LogSyslogFacility [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_facility(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_facility", new object[] {
			destinations}, callback, asyncState);
	}
	public LogSyslogFacility [] Endget_default_facility(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LogSyslogFacility [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_severity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationLocalSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationLocalSyslog", ResponseNamespace="urn:iControl:Log/DestinationLocalSyslog")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LogSyslogLevel [] get_default_severity(
		string [] destinations
	) {
		object [] results = this.Invoke("get_default_severity", new object [] {
				destinations});
		return ((LogSyslogLevel [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_severity(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_severity", new object[] {
			destinations}, callback, asyncState);
	}
	public LogSyslogLevel [] Endget_default_severity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LogSyslogLevel [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationLocalSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationLocalSyslog", ResponseNamespace="urn:iControl:Log/DestinationLocalSyslog")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationLocalSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationLocalSyslog", ResponseNamespace="urn:iControl:Log/DestinationLocalSyslog")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationLocalSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationLocalSyslog", ResponseNamespace="urn:iControl:Log/DestinationLocalSyslog")]
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
	// set_default_facility
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationLocalSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationLocalSyslog", ResponseNamespace="urn:iControl:Log/DestinationLocalSyslog")]
	public void set_default_facility(
		string [] destinations,
		LogSyslogFacility [] facilities
	) {
		this.Invoke("set_default_facility", new object [] {
				destinations,
				facilities});

	}
	public System.IAsyncResult Beginset_default_facility(string [] destinations,LogSyslogFacility [] facilities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_facility", new object[] {
			destinations,
			facilities}, callback, asyncState);
	}
	public void Endset_default_facility(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_severity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationLocalSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationLocalSyslog", ResponseNamespace="urn:iControl:Log/DestinationLocalSyslog")]
	public void set_default_severity(
		string [] destinations,
		LogSyslogLevel [] levels
	) {
		this.Invoke("set_default_severity", new object [] {
				destinations,
				levels});

	}
	public System.IAsyncResult Beginset_default_severity(string [] destinations,LogSyslogLevel [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_severity", new object[] {
			destinations,
			levels}, callback, asyncState);
	}
	public void Endset_default_severity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationLocalSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationLocalSyslog", ResponseNamespace="urn:iControl:Log/DestinationLocalSyslog")]
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

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
