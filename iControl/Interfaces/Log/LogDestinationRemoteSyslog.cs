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
	[System.Web.Services.WebServiceBindingAttribute(Name="Log.DestinationRemoteSyslogBinding", Namespace="urn:iControl")]
	public partial class LogDestinationRemoteSyslog : iControlInterface {
		public LogDestinationRemoteSyslog() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
	public void create(
		string [] destinations,
		LogSyslogFacility [] facilities,
		LogSyslogLevel [] levels,
		string [] hsl_destinations
	) {
		this.Invoke("create", new object [] {
				destinations,
				facilities,
				levels,
				hsl_destinations});

	}
	public System.IAsyncResult Begincreate(string [] destinations,LogSyslogFacility [] facilities,LogSyslogLevel [] levels,string [] hsl_destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			destinations,
			facilities,
			levels,
			hsl_destinations}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_remote_syslog_destinations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
	public void delete_all_remote_syslog_destinations(

	) {
		this.Invoke("delete_all_remote_syslog_destinations", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_remote_syslog_destinations(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_remote_syslog_destinations", new object[0], callback, asyncState);
	}
	public void Enddelete_all_remote_syslog_destinations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_remote_syslog_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
	public void delete_remote_syslog_destination(
		string [] destinations
	) {
		this.Invoke("delete_remote_syslog_destination", new object [] {
				destinations});

	}
	public System.IAsyncResult Begindelete_remote_syslog_destination(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_remote_syslog_destination", new object[] {
			destinations}, callback, asyncState);
	}
	public void Enddelete_remote_syslog_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_default_facility
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
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
	// get_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LogSyslogFormat [] get_format(
		string [] destinations
	) {
		object [] results = this.Invoke("get_format", new object [] {
				destinations});
		return ((LogSyslogFormat [])(results[0]));
	}
	public System.IAsyncResult Beginget_format(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_format", new object[] {
			destinations}, callback, asyncState);
	}
	public LogSyslogFormat [] Endget_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LogSyslogFormat [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
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
	// get_remote_high_speed_log_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_remote_high_speed_log_destination(
		string [] destinations
	) {
		object [] results = this.Invoke("get_remote_high_speed_log_destination", new object [] {
				destinations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_remote_high_speed_log_destination(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_remote_high_speed_log_destination", new object[] {
			destinations}, callback, asyncState);
	}
	public string [] Endget_remote_high_speed_log_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
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
	// set_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
	public void set_format(
		string [] destinations,
		LogSyslogFormat [] formats
	) {
		this.Invoke("set_format", new object [] {
				destinations,
				formats});

	}
	public System.IAsyncResult Beginset_format(string [] destinations,LogSyslogFormat [] formats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_format", new object[] {
			destinations,
			formats}, callback, asyncState);
	}
	public void Endset_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_high_speed_log_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationRemoteSyslog", 
		RequestNamespace="urn:iControl:Log/DestinationRemoteSyslog", ResponseNamespace="urn:iControl:Log/DestinationRemoteSyslog")]
	public void set_remote_high_speed_log_destination(
		string [] destinations,
		string [] hsl_destinations
	) {
		this.Invoke("set_remote_high_speed_log_destination", new object [] {
				destinations,
				hsl_destinations});

	}
	public System.IAsyncResult Beginset_remote_high_speed_log_destination(string [] destinations,string [] hsl_destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_high_speed_log_destination", new object[] {
			destinations,
			hsl_destinations}, callback, asyncState);
	}
	public void Endset_remote_high_speed_log_destination(System.IAsyncResult asyncResult) {
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
