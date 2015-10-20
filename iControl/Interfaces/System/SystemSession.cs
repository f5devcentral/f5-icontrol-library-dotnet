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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.SessionBinding", Namespace="urn:iControl")]
	public partial class SystemSession : iControlInterface {
		public SystemSession() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_active_folder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_active_folder(

	) {
		object [] results = this.Invoke("get_active_folder", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_active_folder(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active_folder", new object[0], callback, asyncState);
	}
	public string Endget_active_folder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dtd_processing_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_dtd_processing_state(

	) {
		object [] results = this.Invoke("get_dtd_processing_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_dtd_processing_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dtd_processing_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_dtd_processing_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_force_sessions_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_force_sessions_state(

	) {
		object [] results = this.Invoke("get_force_sessions_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_force_sessions_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_force_sessions_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_force_sessions_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_sessions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_maximum_sessions(

	) {
		object [] results = this.Invoke("get_maximum_sessions", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_sessions(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_sessions", new object[0], callback, asyncState);
	}
	public long Endget_maximum_sessions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_recursive_query_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_recursive_query_state(

	) {
		object [] results = this.Invoke("get_recursive_query_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_recursive_query_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_recursive_query_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_recursive_query_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_returned_path
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSessionReturnedPath get_returned_path(

	) {
		object [] results = this.Invoke("get_returned_path", new object [0]);
		return ((SystemSessionReturnedPath)(results[0]));
	}
	public System.IAsyncResult Beginget_returned_path(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_returned_path", new object[0], callback, asyncState);
	}
	public SystemSessionReturnedPath Endget_returned_path(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSessionReturnedPath)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_identifier
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_session_identifier(

	) {
		object [] results = this.Invoke("get_session_identifier", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_session_identifier(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_identifier", new object[0], callback, asyncState);
	}
	public long Endget_session_identifier(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_session_timeout(

	) {
		object [] results = this.Invoke("get_session_timeout", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_session_timeout(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_timeout", new object[0], callback, asyncState);
	}
	public long Endget_session_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transaction_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_transaction_timeout(

	) {
		object [] results = this.Invoke("get_transaction_timeout", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_transaction_timeout(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transaction_timeout", new object[0], callback, asyncState);
	}
	public long Endget_transaction_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
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
	// rollback_transaction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	public void rollback_transaction(

	) {
		this.Invoke("rollback_transaction", new object [0]);

	}
	public System.IAsyncResult Beginrollback_transaction(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("rollback_transaction", new object[0], callback, asyncState);
	}
	public void Endrollback_transaction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_active_folder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	public void set_active_folder(
		string folder
	) {
		this.Invoke("set_active_folder", new object [] {
				folder});

	}
	public System.IAsyncResult Beginset_active_folder(string folder, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_active_folder", new object[] {
			folder}, callback, asyncState);
	}
	public void Endset_active_folder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dtd_processing_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	public void set_dtd_processing_state(
		CommonEnabledState state
	) {
		this.Invoke("set_dtd_processing_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_dtd_processing_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dtd_processing_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_dtd_processing_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_force_sessions_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	public void set_force_sessions_state(
		CommonEnabledState state
	) {
		this.Invoke("set_force_sessions_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_force_sessions_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_force_sessions_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_force_sessions_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_sessions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	public void set_maximum_sessions(
		long sessions
	) {
		this.Invoke("set_maximum_sessions", new object [] {
				sessions});

	}
	public System.IAsyncResult Beginset_maximum_sessions(long sessions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_sessions", new object[] {
			sessions}, callback, asyncState);
	}
	public void Endset_maximum_sessions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_recursive_query_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	public void set_recursive_query_state(
		CommonEnabledState state
	) {
		this.Invoke("set_recursive_query_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_recursive_query_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_recursive_query_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_recursive_query_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_returned_path
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	public void set_returned_path(
		SystemSessionReturnedPath path
	) {
		this.Invoke("set_returned_path", new object [] {
				path});

	}
	public System.IAsyncResult Beginset_returned_path(SystemSessionReturnedPath path, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_returned_path", new object[] {
			path}, callback, asyncState);
	}
	public void Endset_returned_path(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_session_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	public void set_session_timeout(
		long timeout
	) {
		this.Invoke("set_session_timeout", new object [] {
				timeout});

	}
	public System.IAsyncResult Beginset_session_timeout(long timeout, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_session_timeout", new object[] {
			timeout}, callback, asyncState);
	}
	public void Endset_session_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_transaction_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	public void set_transaction_timeout(
		long timeout
	) {
		this.Invoke("set_transaction_timeout", new object [] {
				timeout});

	}
	public System.IAsyncResult Beginset_transaction_timeout(long timeout, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_transaction_timeout", new object[] {
			timeout}, callback, asyncState);
	}
	public void Endset_transaction_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// start_transaction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long start_transaction(

	) {
		object [] results = this.Invoke("start_transaction", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginstart_transaction(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("start_transaction", new object[0], callback, asyncState);
	}
	public long Endstart_transaction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// submit_transaction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Session", 
		RequestNamespace="urn:iControl:System/Session", ResponseNamespace="urn:iControl:System/Session")]
	public void submit_transaction(

	) {
		this.Invoke("submit_transaction", new object [0]);

	}
	public System.IAsyncResult Beginsubmit_transaction(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("submit_transaction", new object[0], callback, asyncState);
	}
	public void Endsubmit_transaction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Session.ReturnedPath", Namespace = "urn:iControl")]
	public enum SystemSessionReturnedPath
	{
		PATH_UNKNOWN,
		PATH_FULL,
		PATH_RELATIVE,
		PATH_BARE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
