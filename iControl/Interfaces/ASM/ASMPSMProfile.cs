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
	[System.Web.Services.WebServiceBindingAttribute(Name="ASM.PSMProfileBinding", Namespace="urn:iControl")]
	public partial class ASMPSMProfile : iControlInterface {
		public ASMPSMProfile() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_assignment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PSMProfile", 
		RequestNamespace="urn:iControl:ASM/PSMProfile", ResponseNamespace="urn:iControl:ASM/PSMProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_assignment(
		string [] ltm_profiles
	) {
		object [] results = this.Invoke("get_assignment", new object [] {
				ltm_profiles});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_assignment(string [] ltm_profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_assignment", new object[] {
			ltm_profiles}, callback, asyncState);
	}
	public string [] Endget_assignment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PSMProfile", 
		RequestNamespace="urn:iControl:ASM/PSMProfile", ResponseNamespace="urn:iControl:ASM/PSMProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_list(
		ASMPSMProfilePSMProfileType type
	) {
		object [] results = this.Invoke("get_list", new object [] {
				type});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(ASMPSMProfilePSMProfileType type, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[] {
			type}, callback, asyncState);
	}
	public string [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PSMProfile", 
		RequestNamespace="urn:iControl:ASM/PSMProfile", ResponseNamespace="urn:iControl:ASM/PSMProfile")]
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
	// set_assignment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PSMProfile", 
		RequestNamespace="urn:iControl:ASM/PSMProfile", ResponseNamespace="urn:iControl:ASM/PSMProfile")]
	public void set_assignment(
		string [] ltm_profiles,
		string [] psm_profiles,
		long timeout
	) {
		this.Invoke("set_assignment", new object [] {
				ltm_profiles,
				psm_profiles,
				timeout});

	}
	public System.IAsyncResult Beginset_assignment(string [] ltm_profiles,string [] psm_profiles,long timeout, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_assignment", new object[] {
			ltm_profiles,
			psm_profiles,
			timeout}, callback, asyncState);
	}
	public void Endset_assignment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.PSMProfile.PSMProfileType", Namespace = "urn:iControl")]
	public enum ASMPSMProfilePSMProfileType
	{
		PSM_PROFILE_FTP,
		PSM_PROFILE_SMTP,
		PSM_PROFILE_HTTP,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
