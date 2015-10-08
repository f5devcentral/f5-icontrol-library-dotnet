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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileSPMBinding", Namespace="urn:iControl")]
	public partial class LocalLBProfileSPM : iControlInterface {
		public LocalLBProfileSPM() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_high_precedence_global_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	public void add_high_precedence_global_policy(
		string [] profile_names,
		string [] [] policies
	) {
		this.Invoke("add_high_precedence_global_policy", new object [] {
				profile_names,
				policies});

	}
	public System.IAsyncResult Beginadd_high_precedence_global_policy(string [] profile_names,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_high_precedence_global_policy", new object[] {
			profile_names,
			policies}, callback, asyncState);
	}
	public void Endadd_high_precedence_global_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_low_precedence_global_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	public void add_low_precedence_global_policy(
		string [] profile_names,
		string [] [] policies
	) {
		this.Invoke("add_low_precedence_global_policy", new object [] {
				profile_names,
				policies});

	}
	public System.IAsyncResult Beginadd_low_precedence_global_policy(string [] profile_names,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_low_precedence_global_policy", new object[] {
			profile_names,
			policies}, callback, asyncState);
	}
	public void Endadd_low_precedence_global_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_unknown_subscriber_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	public void add_unknown_subscriber_policy(
		string [] profile_names,
		string [] [] policies
	) {
		this.Invoke("add_unknown_subscriber_policy", new object [] {
				profile_names,
				policies});

	}
	public System.IAsyncResult Beginadd_unknown_subscriber_policy(string [] profile_names,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_unknown_subscriber_policy", new object[] {
			profile_names,
			policies}, callback, asyncState);
	}
	public void Endadd_unknown_subscriber_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	public void create(
		string [] profile_names
	) {
		this.Invoke("create", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begincreate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
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
	// get_high_precedence_global_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_high_precedence_global_policy(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_high_precedence_global_policy", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_high_precedence_global_policy(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_high_precedence_global_policy", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_high_precedence_global_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
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
	// get_low_precedence_global_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_low_precedence_global_policy(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_low_precedence_global_policy", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_low_precedence_global_policy(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_low_precedence_global_policy", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_low_precedence_global_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unknown_subscriber_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_unknown_subscriber_policy(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_unknown_subscriber_policy", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_unknown_subscriber_policy(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unknown_subscriber_policy", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_unknown_subscriber_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
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
	// remove_all_high_precedence_global_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	public void remove_all_high_precedence_global_policies(
		string [] profile_names
	) {
		this.Invoke("remove_all_high_precedence_global_policies", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_high_precedence_global_policies(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_high_precedence_global_policies", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_high_precedence_global_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_low_precedence_global_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	public void remove_all_low_precedence_global_policies(
		string [] profile_names
	) {
		this.Invoke("remove_all_low_precedence_global_policies", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_low_precedence_global_policies(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_low_precedence_global_policies", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_low_precedence_global_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_unknown_subscriber_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	public void remove_all_unknown_subscriber_policies(
		string [] profile_names
	) {
		this.Invoke("remove_all_unknown_subscriber_policies", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_unknown_subscriber_policies(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_unknown_subscriber_policies", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_unknown_subscriber_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_high_precedence_global_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	public void remove_high_precedence_global_policy(
		string [] profile_names,
		string [] [] policies
	) {
		this.Invoke("remove_high_precedence_global_policy", new object [] {
				profile_names,
				policies});

	}
	public System.IAsyncResult Beginremove_high_precedence_global_policy(string [] profile_names,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_high_precedence_global_policy", new object[] {
			profile_names,
			policies}, callback, asyncState);
	}
	public void Endremove_high_precedence_global_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_low_precedence_global_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	public void remove_low_precedence_global_policy(
		string [] profile_names,
		string [] [] policies
	) {
		this.Invoke("remove_low_precedence_global_policy", new object [] {
				profile_names,
				policies});

	}
	public System.IAsyncResult Beginremove_low_precedence_global_policy(string [] profile_names,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_low_precedence_global_policy", new object[] {
			profile_names,
			policies}, callback, asyncState);
	}
	public void Endremove_low_precedence_global_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_unknown_subscriber_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
	public void remove_unknown_subscriber_policy(
		string [] profile_names,
		string [] [] policies
	) {
		this.Invoke("remove_unknown_subscriber_policy", new object [] {
				profile_names,
				policies});

	}
	public System.IAsyncResult Beginremove_unknown_subscriber_policy(string [] profile_names,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_unknown_subscriber_policy", new object[] {
			profile_names,
			policies}, callback, asyncState);
	}
	public void Endremove_unknown_subscriber_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPM", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPM", ResponseNamespace="urn:iControl:LocalLB/ProfileSPM")]
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

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
