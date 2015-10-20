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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.ProfileV6RDBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileIPAddress))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileULong))]
	public partial class NetworkingProfileV6RD : iControlInterface {
		public NetworkingProfileV6RD() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	public void create(
		string [] profile_names,
		CommonProfileIPAddress [] v4_prefixes,
		CommonProfileULong [] v4_prefix_lengths,
		CommonProfileIPAddress [] v6_prefixes,
		CommonProfileULong [] v6_prefix_lengths
	) {
		this.Invoke("create", new object [] {
				profile_names,
				v4_prefixes,
				v4_prefix_lengths,
				v6_prefixes,
				v6_prefix_lengths});

	}
	public System.IAsyncResult Begincreate(string [] profile_names,CommonProfileIPAddress [] v4_prefixes,CommonProfileULong [] v4_prefix_lengths,CommonProfileIPAddress [] v6_prefixes,CommonProfileULong [] v6_prefix_lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names,
			v4_prefixes,
			v4_prefix_lengths,
			v6_prefixes,
			v6_prefix_lengths}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
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
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
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
	// get_v4_prefix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileIPAddress [] get_v4_prefix(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_v4_prefix", new object [] {
				profile_names});
		return ((CommonProfileIPAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_v4_prefix(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_v4_prefix", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileIPAddress [] Endget_v4_prefix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileIPAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_v4_prefix_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_v4_prefix_length(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_v4_prefix_length", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_v4_prefix_length(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_v4_prefix_length", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_v4_prefix_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_v6_prefix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileIPAddress [] get_v6_prefix(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_v6_prefix", new object [] {
				profile_names});
		return ((CommonProfileIPAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_v6_prefix(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_v6_prefix", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileIPAddress [] Endget_v6_prefix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileIPAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_v6_prefix_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_v6_prefix_length(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_v6_prefix_length", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_v6_prefix_length(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_v6_prefix_length", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_v6_prefix_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
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
	// set_v4_prefix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	public void set_v4_prefix(
		string [] profile_names,
		CommonProfileIPAddress [] prefixes
	) {
		this.Invoke("set_v4_prefix", new object [] {
				profile_names,
				prefixes});

	}
	public System.IAsyncResult Beginset_v4_prefix(string [] profile_names,CommonProfileIPAddress [] prefixes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_v4_prefix", new object[] {
			profile_names,
			prefixes}, callback, asyncState);
	}
	public void Endset_v4_prefix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_v4_prefix_and_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	public void set_v4_prefix_and_length(
		string [] profile_names,
		CommonProfileIPAddress [] prefixes,
		CommonProfileULong [] lengths
	) {
		this.Invoke("set_v4_prefix_and_length", new object [] {
				profile_names,
				prefixes,
				lengths});

	}
	public System.IAsyncResult Beginset_v4_prefix_and_length(string [] profile_names,CommonProfileIPAddress [] prefixes,CommonProfileULong [] lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_v4_prefix_and_length", new object[] {
			profile_names,
			prefixes,
			lengths}, callback, asyncState);
	}
	public void Endset_v4_prefix_and_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_v4_prefix_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	public void set_v4_prefix_length(
		string [] profile_names,
		CommonProfileULong [] lengths
	) {
		this.Invoke("set_v4_prefix_length", new object [] {
				profile_names,
				lengths});

	}
	public System.IAsyncResult Beginset_v4_prefix_length(string [] profile_names,CommonProfileULong [] lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_v4_prefix_length", new object[] {
			profile_names,
			lengths}, callback, asyncState);
	}
	public void Endset_v4_prefix_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_v6_prefix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	public void set_v6_prefix(
		string [] profile_names,
		CommonProfileIPAddress [] prefixes
	) {
		this.Invoke("set_v6_prefix", new object [] {
				profile_names,
				prefixes});

	}
	public System.IAsyncResult Beginset_v6_prefix(string [] profile_names,CommonProfileIPAddress [] prefixes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_v6_prefix", new object[] {
			profile_names,
			prefixes}, callback, asyncState);
	}
	public void Endset_v6_prefix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_v6_prefix_and_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	public void set_v6_prefix_and_length(
		string [] profile_names,
		CommonProfileIPAddress [] prefixes,
		CommonProfileULong [] lengths
	) {
		this.Invoke("set_v6_prefix_and_length", new object [] {
				profile_names,
				prefixes,
				lengths});

	}
	public System.IAsyncResult Beginset_v6_prefix_and_length(string [] profile_names,CommonProfileIPAddress [] prefixes,CommonProfileULong [] lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_v6_prefix_and_length", new object[] {
			profile_names,
			prefixes,
			lengths}, callback, asyncState);
	}
	public void Endset_v6_prefix_and_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_v6_prefix_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileV6RD", 
		RequestNamespace="urn:iControl:Networking/ProfileV6RD", ResponseNamespace="urn:iControl:Networking/ProfileV6RD")]
	public void set_v6_prefix_length(
		string [] profile_names,
		CommonProfileULong [] lengths
	) {
		this.Invoke("set_v6_prefix_length", new object [] {
				profile_names,
				lengths});

	}
	public System.IAsyncResult Beginset_v6_prefix_length(string [] profile_names,CommonProfileULong [] lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_v6_prefix_length", new object[] {
			profile_names,
			lengths}, callback, asyncState);
	}
	public void Endset_v6_prefix_length(System.IAsyncResult asyncResult) {
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
