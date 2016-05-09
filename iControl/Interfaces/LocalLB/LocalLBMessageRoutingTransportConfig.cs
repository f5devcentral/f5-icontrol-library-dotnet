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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.MessageRoutingTransportConfigBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMessageRoutingTransportConfigTransportConfigProfile))]
	public partial class LocalLBMessageRoutingTransportConfig : iControlInterface {
		public LocalLBMessageRoutingTransportConfig() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void add_profile(
		string [] transport_configs,
		string [] [] profiles
	) {
		this.Invoke("add_profile", new object [] {
				transport_configs,
				profiles});

	}
	public System.IAsyncResult Beginadd_profile(string [] transport_configs,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_profile", new object[] {
			transport_configs,
			profiles}, callback, asyncState);
	}
	public void Endadd_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void create(
		string [] transport_configs,
		LocalLBMessageRoutingProtocol [] protocols,
		string [] [] profiles
	) {
		this.Invoke("create", new object [] {
				transport_configs,
				protocols,
				profiles});

	}
	public System.IAsyncResult Begincreate(string [] transport_configs,LocalLBMessageRoutingProtocol [] protocols,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			transport_configs,
			protocols,
			profiles}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_transport_configs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void delete_all_transport_configs(

	) {
		this.Invoke("delete_all_transport_configs", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_transport_configs(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_transport_configs", new object[0], callback, asyncState);
	}
	public void Enddelete_all_transport_configs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_transport_config
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void delete_transport_config(
		string [] transport_configs
	) {
		this.Invoke("delete_transport_config", new object [] {
				transport_configs});

	}
	public System.IAsyncResult Begindelete_transport_config(string [] transport_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_transport_config", new object[] {
			transport_configs}, callback, asyncState);
	}
	public void Enddelete_transport_config(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] transport_configs
	) {
		object [] results = this.Invoke("get_description", new object [] {
				transport_configs});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] transport_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			transport_configs}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
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
	// get_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMessageRoutingTransportConfigTransportConfigProfile [] [] get_profile(
		string [] transport_configs
	) {
		object [] results = this.Invoke("get_profile", new object [] {
				transport_configs});
		return ((LocalLBMessageRoutingTransportConfigTransportConfigProfile [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_profile(string [] transport_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_profile", new object[] {
			transport_configs}, callback, asyncState);
	}
	public LocalLBMessageRoutingTransportConfigTransportConfigProfile [] [] Endget_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMessageRoutingTransportConfigTransportConfigProfile [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMessageRoutingProtocol [] get_protocol(
		string [] transport_configs
	) {
		object [] results = this.Invoke("get_protocol", new object [] {
				transport_configs});
		return ((LocalLBMessageRoutingProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol(string [] transport_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol", new object[] {
			transport_configs}, callback, asyncState);
	}
	public LocalLBMessageRoutingProtocol [] Endget_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMessageRoutingProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule(
		string [] transport_configs
	) {
		object [] results = this.Invoke("get_rule", new object [] {
				transport_configs});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule(string [] transport_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule", new object[] {
			transport_configs}, callback, asyncState);
	}
	public string [] [] Endget_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_address_translation_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_source_address_translation_pool(
		string [] transport_configs
	) {
		object [] results = this.Invoke("get_source_address_translation_pool", new object [] {
				transport_configs});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_address_translation_pool(string [] transport_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_address_translation_pool", new object[] {
			transport_configs}, callback, asyncState);
	}
	public string [] Endget_source_address_translation_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_address_translation_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMessageRoutingTransportConfigSourceAddressTranslationType [] get_source_address_translation_type(
		string [] transport_configs
	) {
		object [] results = this.Invoke("get_source_address_translation_type", new object [] {
				transport_configs});
		return ((LocalLBMessageRoutingTransportConfigSourceAddressTranslationType [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_address_translation_type(string [] transport_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_address_translation_type", new object[] {
			transport_configs}, callback, asyncState);
	}
	public LocalLBMessageRoutingTransportConfigSourceAddressTranslationType [] Endget_source_address_translation_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMessageRoutingTransportConfigSourceAddressTranslationType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_source_port(
		string [] transport_configs
	) {
		object [] results = this.Invoke("get_source_port", new object [] {
				transport_configs});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_port(string [] transport_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_port", new object[] {
			transport_configs}, callback, asyncState);
	}
	public long [] Endget_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
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
	// remove_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void remove_all_profiles(
		string [] transport_configs
	) {
		this.Invoke("remove_all_profiles", new object [] {
				transport_configs});

	}
	public System.IAsyncResult Beginremove_all_profiles(string [] transport_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_profiles", new object[] {
			transport_configs}, callback, asyncState);
	}
	public void Endremove_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void remove_profile(
		string [] transport_configs,
		string [] [] profiles
	) {
		this.Invoke("remove_profile", new object [] {
				transport_configs,
				profiles});

	}
	public System.IAsyncResult Beginremove_profile(string [] transport_configs,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_profile", new object[] {
			transport_configs,
			profiles}, callback, asyncState);
	}
	public void Endremove_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void replace_rule(
		string [] transport_configs,
		string [] [] rules,
		long [] [] priorities
	) {
		this.Invoke("replace_rule", new object [] {
				transport_configs,
				rules,
				priorities});

	}
	public System.IAsyncResult Beginreplace_rule(string [] transport_configs,string [] [] rules,long [] [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_rule", new object[] {
			transport_configs,
			rules,
			priorities}, callback, asyncState);
	}
	public void Endreplace_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void set_description(
		string [] transport_configs,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				transport_configs,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] transport_configs,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			transport_configs,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_address_translation_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void set_source_address_translation_pool(
		string [] transport_configs,
		string [] pools
	) {
		this.Invoke("set_source_address_translation_pool", new object [] {
				transport_configs,
				pools});

	}
	public System.IAsyncResult Beginset_source_address_translation_pool(string [] transport_configs,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_address_translation_pool", new object[] {
			transport_configs,
			pools}, callback, asyncState);
	}
	public void Endset_source_address_translation_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_address_translation_pool_with_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void set_source_address_translation_pool_with_type(
		string [] transport_configs,
		string [] pools,
		LocalLBMessageRoutingTransportConfigSourceAddressTranslationType [] types
	) {
		this.Invoke("set_source_address_translation_pool_with_type", new object [] {
				transport_configs,
				pools,
				types});

	}
	public System.IAsyncResult Beginset_source_address_translation_pool_with_type(string [] transport_configs,string [] pools,LocalLBMessageRoutingTransportConfigSourceAddressTranslationType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_address_translation_pool_with_type", new object[] {
			transport_configs,
			pools,
			types}, callback, asyncState);
	}
	public void Endset_source_address_translation_pool_with_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_address_translation_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void set_source_address_translation_type(
		string [] transport_configs,
		LocalLBMessageRoutingTransportConfigSourceAddressTranslationType [] types
	) {
		this.Invoke("set_source_address_translation_type", new object [] {
				transport_configs,
				types});

	}
	public System.IAsyncResult Beginset_source_address_translation_type(string [] transport_configs,LocalLBMessageRoutingTransportConfigSourceAddressTranslationType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_address_translation_type", new object[] {
			transport_configs,
			types}, callback, asyncState);
	}
	public void Endset_source_address_translation_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingTransportConfig", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingTransportConfig")]
	public void set_source_port(
		string [] transport_configs,
		long [] ports
	) {
		this.Invoke("set_source_port", new object [] {
				transport_configs,
				ports});

	}
	public System.IAsyncResult Beginset_source_port(string [] transport_configs,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_port", new object[] {
			transport_configs,
			ports}, callback, asyncState);
	}
	public void Endset_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MessageRoutingTransportConfig.SourceAddressTranslationType", Namespace = "urn:iControl")]
	public enum LocalLBMessageRoutingTransportConfigSourceAddressTranslationType
	{
		SOURCE_ADDRESS_TRANSLATION_TYPE_UNKNOWN,
		SOURCE_ADDRESS_TRANSLATION_TYPE_NONE,
		SOURCE_ADDRESS_TRANSLATION_TYPE_SNATPOOL,
		SOURCE_ADDRESS_TRANSLATION_TYPE_AUTOMAP,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MessageRoutingTransportConfig.TransportConfigProfile", Namespace = "urn:iControl")]
	public partial class LocalLBMessageRoutingTransportConfigTransportConfigProfile
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private LocalLBProfileType profile_typeField;
		public LocalLBProfileType profile_type
		{
			get { return this.profile_typeField; }
			set { this.profile_typeField = value; }
		}
	};

}
