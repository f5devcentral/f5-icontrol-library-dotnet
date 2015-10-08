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
	[System.Web.Services.WebServiceBindingAttribute(Name="Classification.SignatureUpdateScheduleBinding", Namespace="urn:iControl")]
	public partial class ClassificationSignatureUpdateSchedule : iControlInterface {
		public ClassificationSignatureUpdateSchedule() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_auto_update_interval_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureUpdateSchedule", 
		RequestNamespace="urn:iControl:Classification/SignatureUpdateSchedule", ResponseNamespace="urn:iControl:Classification/SignatureUpdateSchedule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ClassificationSignatureUpdateScheduleSignatureUpdateIntervalType [] get_auto_update_interval_type(
		string [] schedules
	) {
		object [] results = this.Invoke("get_auto_update_interval_type", new object [] {
				schedules});
		return ((ClassificationSignatureUpdateScheduleSignatureUpdateIntervalType [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_update_interval_type(string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_update_interval_type", new object[] {
			schedules}, callback, asyncState);
	}
	public ClassificationSignatureUpdateScheduleSignatureUpdateIntervalType [] Endget_auto_update_interval_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ClassificationSignatureUpdateScheduleSignatureUpdateIntervalType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureUpdateSchedule", 
		RequestNamespace="urn:iControl:Classification/SignatureUpdateSchedule", ResponseNamespace="urn:iControl:Classification/SignatureUpdateSchedule")]
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
	// get_update_mode_automatic_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureUpdateSchedule", 
		RequestNamespace="urn:iControl:Classification/SignatureUpdateSchedule", ResponseNamespace="urn:iControl:Classification/SignatureUpdateSchedule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_update_mode_automatic_state(
		string [] schedules
	) {
		object [] results = this.Invoke("get_update_mode_automatic_state", new object [] {
				schedules});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_update_mode_automatic_state(string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_update_mode_automatic_state", new object[] {
			schedules}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_update_mode_automatic_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureUpdateSchedule", 
		RequestNamespace="urn:iControl:Classification/SignatureUpdateSchedule", ResponseNamespace="urn:iControl:Classification/SignatureUpdateSchedule")]
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
	// import_signatures
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureUpdateSchedule", 
		RequestNamespace="urn:iControl:Classification/SignatureUpdateSchedule", ResponseNamespace="urn:iControl:Classification/SignatureUpdateSchedule")]
	public void import_signatures(
		string filename
	) {
		this.Invoke("import_signatures", new object [] {
				filename});

	}
	public System.IAsyncResult Beginimport_signatures(string filename, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("import_signatures", new object[] {
			filename}, callback, asyncState);
	}
	public void Endimport_signatures(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_update_interval_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureUpdateSchedule", 
		RequestNamespace="urn:iControl:Classification/SignatureUpdateSchedule", ResponseNamespace="urn:iControl:Classification/SignatureUpdateSchedule")]
	public void set_auto_update_interval_type(
		string [] schedules,
		ClassificationSignatureUpdateScheduleSignatureUpdateIntervalType [] types
	) {
		this.Invoke("set_auto_update_interval_type", new object [] {
				schedules,
				types});

	}
	public System.IAsyncResult Beginset_auto_update_interval_type(string [] schedules,ClassificationSignatureUpdateScheduleSignatureUpdateIntervalType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_update_interval_type", new object[] {
			schedules,
			types}, callback, asyncState);
	}
	public void Endset_auto_update_interval_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_update_mode_automatic_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureUpdateSchedule", 
		RequestNamespace="urn:iControl:Classification/SignatureUpdateSchedule", ResponseNamespace="urn:iControl:Classification/SignatureUpdateSchedule")]
	public void set_update_mode_automatic_state(
		string [] schedules,
		CommonEnabledState [] states
	) {
		this.Invoke("set_update_mode_automatic_state", new object [] {
				schedules,
				states});

	}
	public System.IAsyncResult Beginset_update_mode_automatic_state(string [] schedules,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_update_mode_automatic_state", new object[] {
			schedules,
			states}, callback, asyncState);
	}
	public void Endset_update_mode_automatic_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_signatures
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureUpdateSchedule", 
		RequestNamespace="urn:iControl:Classification/SignatureUpdateSchedule", ResponseNamespace="urn:iControl:Classification/SignatureUpdateSchedule")]
	public void update_signatures(

	) {
		this.Invoke("update_signatures", new object [0]);

	}
	public System.IAsyncResult Beginupdate_signatures(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_signatures", new object[0], callback, asyncState);
	}
	public void Endupdate_signatures(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Classification.SignatureUpdateSchedule.SignatureUpdateIntervalType", Namespace = "urn:iControl")]
	public enum ClassificationSignatureUpdateScheduleSignatureUpdateIntervalType
	{
		SIGNATURE_UPDATE_INTERVAL_TYPE_UNKNOWN,
		SIGNATURE_UPDATE_INTERVAL_TYPE_DAILY,
		SIGNATURE_UPDATE_INTERVAL_TYPE_WEEKLY,
		SIGNATURE_UPDATE_INTERVAL_TYPE_MONTHLY,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
