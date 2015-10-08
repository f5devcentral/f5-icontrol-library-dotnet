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
	[System.Web.Services.WebServiceBindingAttribute(Name="ASM.SystemConfigurationBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMViolationSeverity))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMSignatureFileUpdateReturnValue))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMFileTransferContext))]
	public partial class ASMSystemConfiguration : iControlInterface {
		public ASMSystemConfiguration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_signature_file_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/SystemConfiguration", 
		RequestNamespace="urn:iControl:ASM/SystemConfiguration", ResponseNamespace="urn:iControl:ASM/SystemConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_signature_file_version(

	) {
		object [] results = this.Invoke("get_signature_file_version", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_signature_file_version(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_signature_file_version", new object[0], callback, asyncState);
	}
	public string Endget_signature_file_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/SystemConfiguration", 
		RequestNamespace="urn:iControl:ASM/SystemConfiguration", ResponseNamespace="urn:iControl:ASM/SystemConfiguration")]
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
	// get_violation_severities
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/SystemConfiguration", 
		RequestNamespace="urn:iControl:ASM/SystemConfiguration", ResponseNamespace="urn:iControl:ASM/SystemConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMViolationSeverity [] get_violation_severities(

	) {
		object [] results = this.Invoke("get_violation_severities", new object [0]);
		return ((ASMViolationSeverity [])(results[0]));
	}
	public System.IAsyncResult Beginget_violation_severities(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_violation_severities", new object[0], callback, asyncState);
	}
	public ASMViolationSeverity [] Endget_violation_severities(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMViolationSeverity [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_asm_ready
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/SystemConfiguration", 
		RequestNamespace="urn:iControl:ASM/SystemConfiguration", ResponseNamespace="urn:iControl:ASM/SystemConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool is_asm_ready(

	) {
		object [] results = this.Invoke("is_asm_ready", new object [0]);
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginis_asm_ready(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_asm_ready", new object[0], callback, asyncState);
	}
	public bool Endis_asm_ready(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_violation_severities
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/SystemConfiguration", 
		RequestNamespace="urn:iControl:ASM/SystemConfiguration", ResponseNamespace="urn:iControl:ASM/SystemConfiguration")]
	public void set_violation_severities(
		ASMViolationSeverity [] violation_severities
	) {
		this.Invoke("set_violation_severities", new object [] {
				violation_severities});

	}
	public System.IAsyncResult Beginset_violation_severities(ASMViolationSeverity [] violation_severities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_violation_severities", new object[] {
			violation_severities}, callback, asyncState);
	}
	public void Endset_violation_severities(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_signature_file_automatic
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/SystemConfiguration", 
		RequestNamespace="urn:iControl:ASM/SystemConfiguration", ResponseNamespace="urn:iControl:ASM/SystemConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMSignatureFileUpdateReturnValue update_signature_file_automatic(
		bool flg_is_user_defined,
		bool do_set_active,
		bool force,
		string user_name,
		bool check_interval
	) {
		object [] results = this.Invoke("update_signature_file_automatic", new object [] {
				flg_is_user_defined,
				do_set_active,
				force,
				user_name,
				check_interval});
		return ((ASMSignatureFileUpdateReturnValue)(results[0]));
	}
	public System.IAsyncResult Beginupdate_signature_file_automatic(bool flg_is_user_defined,bool do_set_active,bool force,string user_name,bool check_interval, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_signature_file_automatic", new object[] {
			flg_is_user_defined,
			do_set_active,
			force,
			user_name,
			check_interval}, callback, asyncState);
	}
	public ASMSignatureFileUpdateReturnValue Endupdate_signature_file_automatic(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMSignatureFileUpdateReturnValue)(results[0]));
	}

	//-----------------------------------------------------------------------
	// update_signature_file_manual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/SystemConfiguration", 
		RequestNamespace="urn:iControl:ASM/SystemConfiguration", ResponseNamespace="urn:iControl:ASM/SystemConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMSignatureFileUpdateReturnValue update_signature_file_manual(
		ASMFileTransferContext file_context,
		bool flg_is_user_defined,
		bool do_set_active,
		bool force,
		string user_name,
		bool check_interval
	) {
		object [] results = this.Invoke("update_signature_file_manual", new object [] {
				file_context,
				flg_is_user_defined,
				do_set_active,
				force,
				user_name,
				check_interval});
		return ((ASMSignatureFileUpdateReturnValue)(results[0]));
	}
	public System.IAsyncResult Beginupdate_signature_file_manual(ASMFileTransferContext file_context,bool flg_is_user_defined,bool do_set_active,bool force,string user_name,bool check_interval, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_signature_file_manual", new object[] {
			file_context,
			flg_is_user_defined,
			do_set_active,
			force,
			user_name,
			check_interval}, callback, asyncState);
	}
	public ASMSignatureFileUpdateReturnValue Endupdate_signature_file_manual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMSignatureFileUpdateReturnValue)(results[0]));
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
