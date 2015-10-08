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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.ProfileGREBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingProfileGREProfileGREEncapsulationType))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingProfileGREProfileGREFloodingType))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileEnabledState))]
	public partial class NetworkingProfileGRE : iControlInterface {
		public NetworkingProfileGRE() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	// get_encapsulation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingProfileGREProfileGREEncapsulationType [] get_encapsulation(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_encapsulation", new object [] {
				profile_names});
		return ((NetworkingProfileGREProfileGREEncapsulationType [])(results[0]));
	}
	public System.IAsyncResult Beginget_encapsulation(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_encapsulation", new object[] {
			profile_names}, callback, asyncState);
	}
	public NetworkingProfileGREProfileGREEncapsulationType [] Endget_encapsulation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingProfileGREProfileGREEncapsulationType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flooding_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingProfileGREProfileGREFloodingType [] get_flooding_type(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_flooding_type", new object [] {
				profile_names});
		return ((NetworkingProfileGREProfileGREFloodingType [])(results[0]));
	}
	public System.IAsyncResult Beginget_flooding_type(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flooding_type", new object[] {
			profile_names}, callback, asyncState);
	}
	public NetworkingProfileGREProfileGREFloodingType [] Endget_flooding_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingProfileGREProfileGREFloodingType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_include_checksum_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	// set_encapsulation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
	public void set_encapsulation(
		string [] profile_names,
		NetworkingProfileGREProfileGREEncapsulationType [] encapsulations
	) {
		this.Invoke("set_encapsulation", new object [] {
				profile_names,
				encapsulations});

	}
	public System.IAsyncResult Beginset_encapsulation(string [] profile_names,NetworkingProfileGREProfileGREEncapsulationType [] encapsulations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_encapsulation", new object[] {
			profile_names,
			encapsulations}, callback, asyncState);
	}
	public void Endset_encapsulation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flooding_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
	public void set_flooding_type(
		string [] profile_names,
		NetworkingProfileGREProfileGREFloodingType [] flooding_types
	) {
		this.Invoke("set_flooding_type", new object [] {
				profile_names,
				flooding_types});

	}
	public System.IAsyncResult Beginset_flooding_type(string [] profile_names,NetworkingProfileGREProfileGREFloodingType [] flooding_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flooding_type", new object[] {
			profile_names,
			flooding_types}, callback, asyncState);
	}
	public void Endset_flooding_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_include_checksum_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileGRE", 
		RequestNamespace="urn:iControl:Networking/ProfileGRE", ResponseNamespace="urn:iControl:Networking/ProfileGRE")]
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

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileGRE.GREEncapsulationType", Namespace = "urn:iControl")]
	public enum NetworkingProfileGREGREEncapsulationType
	{
		PROFILE_GRE_ENCAPSULATION_TYPE_UNKNOWN,
		PROFILE_GRE_ENCAPSULATION_TYPE_STANDARD,
		PROFILE_GRE_ENCAPSULATION_TYPE_NVGRE,
		PROFILE_GRE_ENCAPSULATION_TYPE_TRANSPARENT_ETHERNET_BRIDGING,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileGRE.GREFloodingType", Namespace = "urn:iControl")]
	public enum NetworkingProfileGREGREFloodingType
	{
		PROFILE_GRE_FLOODING_TYPE_UNKNOWN,
		PROFILE_GRE_FLOODING_TYPE_NONE,
		PROFILE_GRE_FLOODING_TYPE_MULTIPOINT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileGRE.ProfileGREEncapsulationType", Namespace = "urn:iControl")]
	public partial class NetworkingProfileGREProfileGREEncapsulationType
	{
		private NetworkingProfileGREGREEncapsulationType valueField;
		public NetworkingProfileGREGREEncapsulationType value
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileGRE.ProfileGREFloodingType", Namespace = "urn:iControl")]
	public partial class NetworkingProfileGREProfileGREFloodingType
	{
		private NetworkingProfileGREGREFloodingType valueField;
		public NetworkingProfileGREGREFloodingType value
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
