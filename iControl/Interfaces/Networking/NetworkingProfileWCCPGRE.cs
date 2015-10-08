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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.ProfileWCCPGREBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingProfileWCCPGREProfileWCCPGREForwarding))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileULong))]
	public partial class NetworkingProfileWCCPGRE : iControlInterface {
		public NetworkingProfileWCCPGRE() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	// get_egress_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingProfileWCCPGREProfileWCCPGREForwarding [] get_egress_forwarding(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_egress_forwarding", new object [] {
				profile_names});
		return ((NetworkingProfileWCCPGREProfileWCCPGREForwarding [])(results[0]));
	}
	public System.IAsyncResult Beginget_egress_forwarding(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_egress_forwarding", new object[] {
			profile_names}, callback, asyncState);
	}
	public NetworkingProfileWCCPGREProfileWCCPGREForwarding [] Endget_egress_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingProfileWCCPGREProfileWCCPGREForwarding [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_include_checksum_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileEnabledState [] get_include_checksum_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_include_checksum_state", new object [] {
				profile_names});
		return ((CommonProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_include_checksum_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_include_checksum_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileEnabledState [] Endget_include_checksum_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	// get_validate_checksum_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileEnabledState [] get_validate_checksum_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_validate_checksum_state", new object [] {
				profile_names});
		return ((CommonProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_validate_checksum_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_validate_checksum_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileEnabledState [] Endget_validate_checksum_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	// get_wccp_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_wccp_version(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_wccp_version", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_wccp_version(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wccp_version", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_wccp_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
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
	// set_egress_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
	public void set_egress_forwarding(
		string [] profile_names,
		NetworkingProfileWCCPGREProfileWCCPGREForwarding [] modes
	) {
		this.Invoke("set_egress_forwarding", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_egress_forwarding(string [] profile_names,NetworkingProfileWCCPGREProfileWCCPGREForwarding [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_egress_forwarding", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_egress_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_include_checksum_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
	public void set_include_checksum_state(
		string [] profile_names,
		CommonProfileEnabledState [] states
	) {
		this.Invoke("set_include_checksum_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_include_checksum_state(string [] profile_names,CommonProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_include_checksum_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_include_checksum_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_validate_checksum_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
	public void set_validate_checksum_state(
		string [] profile_names,
		CommonProfileEnabledState [] states
	) {
		this.Invoke("set_validate_checksum_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_validate_checksum_state(string [] profile_names,CommonProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_validate_checksum_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_validate_checksum_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_wccp_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileWCCPGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileWCCPGRE", ResponseNamespace="urn:iControl:Networking/ProfileWCCPGRE")]
	public void set_wccp_version(
		string [] profile_names,
		CommonProfileULong [] versions
	) {
		this.Invoke("set_wccp_version", new object [] {
				profile_names,
				versions});

	}
	public System.IAsyncResult Beginset_wccp_version(string [] profile_names,CommonProfileULong [] versions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_wccp_version", new object[] {
			profile_names,
			versions}, callback, asyncState);
	}
	public void Endset_wccp_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileWCCPGRE.WCCPGREForwarding", Namespace = "urn:iControl")]
	public enum NetworkingProfileWCCPGREWCCPGREForwarding
	{
		WCCP_GRE_FORWARD_UNKNOWN,
		WCCP_GRE_FORWARD_NORMAL,
		WCCP_GRE_FORWARD_LASTHOP,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileWCCPGRE.ProfileWCCPGREForwarding", Namespace = "urn:iControl")]
	public partial class NetworkingProfileWCCPGREProfileWCCPGREForwarding
	{
		private NetworkingProfileWCCPGREWCCPGREForwarding valueField;
		public NetworkingProfileWCCPGREWCCPGREForwarding value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

}
