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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.ProfileLightweight4Over6TunnelBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileULong))]
	public partial class NetworkingProfileLightweight4Over6Tunnel : iControlInterface {
		public NetworkingProfileLightweight4Over6Tunnel() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	public void create(
		string [] profile_names,
		CommonProfileString [] files
	) {
		this.Invoke("create", new object [] {
				profile_names,
				files});

	}
	public System.IAsyncResult Begincreate(string [] profile_names,CommonProfileString [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names,
			files}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	public void delete_all_profiles(

	) {
		this.Invoke("delete_all_profiles", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_profiles(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_profiles", new object[0], callback, asyncState);
	}
	public void Enddelete_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	public void delete_profile(
		string [] profile_names
	) {
		this.Invoke("delete_profile", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begindelete_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Enddelete_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_default_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_default_profile", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileString [] get_file(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_file", new object [] {
				profile_names});
		return ((CommonProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_file(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_file", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileString [] Endget_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
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
	// get_port_set_identifier_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_port_set_identifier_length(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_port_set_identifier_length", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_port_set_identifier_length(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_port_set_identifier_length", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_port_set_identifier_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
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
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_base_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_base_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_base_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_base_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_base_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_system_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_system_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_system_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_system_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_system_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_system_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	public void set_default_profile(
		string [] profile_names,
		string [] defaults
	) {
		this.Invoke("set_default_profile", new object [] {
				profile_names,
				defaults});

	}
	public System.IAsyncResult Beginset_default_profile(string [] profile_names,string [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_profile", new object[] {
			profile_names,
			defaults}, callback, asyncState);
	}
	public void Endset_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	public void set_description(
		string [] profile_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				profile_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] profile_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			profile_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	public void set_file(
		string [] profile_names,
		CommonProfileString [] files
	) {
		this.Invoke("set_file", new object [] {
				profile_names,
				files});

	}
	public System.IAsyncResult Beginset_file(string [] profile_names,CommonProfileString [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_file", new object[] {
			profile_names,
			files}, callback, asyncState);
	}
	public void Endset_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_port_set_identifier_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileLightweight4Over6Tunnel", 
		RequestNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel", ResponseNamespace="urn:iControl:Networking/ProfileLightweight4Over6Tunnel")]
	public void set_port_set_identifier_length(
		string [] profile_names,
		CommonProfileULong [] lengths
	) {
		this.Invoke("set_port_set_identifier_length", new object [] {
				profile_names,
				lengths});

	}
	public System.IAsyncResult Beginset_port_set_identifier_length(string [] profile_names,CommonProfileULong [] lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_port_set_identifier_length", new object[] {
			profile_names,
			lengths}, callback, asyncState);
	}
	public void Endset_port_set_identifier_length(System.IAsyncResult asyncResult) {
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
