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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.ProfileFECBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfilePortNumber))]
	public partial class NetworkingProfileFEC : iControlInterface {
		public NetworkingProfileFEC() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	// get_decode_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_decode_idle_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_decode_idle_timeout", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_decode_idle_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_decode_idle_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_decode_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_decode_maximum_packet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_decode_maximum_packet(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_decode_maximum_packet", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_decode_maximum_packet(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_decode_maximum_packet", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_decode_maximum_packet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_decode_queue
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_decode_queue(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_decode_queue", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_decode_queue(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_decode_queue", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_decode_queue(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	// get_encode_maximum_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_encode_maximum_delay(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_encode_maximum_delay", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_encode_maximum_delay(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_encode_maximum_delay", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_encode_maximum_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_keepalive_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_keepalive_interval(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_keepalive_interval", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_keepalive_interval(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_keepalive_interval", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_keepalive_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	// get_lzo_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileEnabledState [] get_lzo_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_lzo_state", new object [] {
				profile_names});
		return ((CommonProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_lzo_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lzo_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileEnabledState [] Endget_lzo_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_repair_adaptive_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileEnabledState [] get_repair_adaptive_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_repair_adaptive_state", new object [] {
				profile_names});
		return ((CommonProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_repair_adaptive_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_repair_adaptive_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileEnabledState [] Endget_repair_adaptive_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_repair_packet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_repair_packet(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_repair_packet", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_repair_packet(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_repair_packet", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_repair_packet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_adaptive_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileEnabledState [] get_source_adaptive_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_source_adaptive_state", new object [] {
				profile_names});
		return ((CommonProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_adaptive_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_adaptive_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileEnabledState [] Endget_source_adaptive_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_packet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileULong [] get_source_packet(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_source_packet", new object [] {
				profile_names});
		return ((CommonProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_packet(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_packet", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileULong [] Endget_source_packet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_udp_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfilePortNumber [] get_udp_port(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_udp_port", new object [] {
				profile_names});
		return ((CommonProfilePortNumber [])(results[0]));
	}
	public System.IAsyncResult Beginget_udp_port(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_udp_port", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfilePortNumber [] Endget_udp_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfilePortNumber [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	// set_decode_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_decode_idle_timeout(
		string [] profile_names,
		CommonProfileULong [] timeouts
	) {
		this.Invoke("set_decode_idle_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_decode_idle_timeout(string [] profile_names,CommonProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_decode_idle_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_decode_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_decode_maximum_packet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_decode_maximum_packet(
		string [] profile_names,
		CommonProfileULong [] values
	) {
		this.Invoke("set_decode_maximum_packet", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_decode_maximum_packet(string [] profile_names,CommonProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_decode_maximum_packet", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_decode_maximum_packet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_decode_queue
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_decode_queue(
		string [] profile_names,
		CommonProfileULong [] values
	) {
		this.Invoke("set_decode_queue", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_decode_queue(string [] profile_names,CommonProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_decode_queue", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_decode_queue(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
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
	// set_encode_maximum_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_encode_maximum_delay(
		string [] profile_names,
		CommonProfileULong [] delays
	) {
		this.Invoke("set_encode_maximum_delay", new object [] {
				profile_names,
				delays});

	}
	public System.IAsyncResult Beginset_encode_maximum_delay(string [] profile_names,CommonProfileULong [] delays, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_encode_maximum_delay", new object[] {
			profile_names,
			delays}, callback, asyncState);
	}
	public void Endset_encode_maximum_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_keepalive_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_keepalive_interval(
		string [] profile_names,
		CommonProfileULong [] intervals
	) {
		this.Invoke("set_keepalive_interval", new object [] {
				profile_names,
				intervals});

	}
	public System.IAsyncResult Beginset_keepalive_interval(string [] profile_names,CommonProfileULong [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_keepalive_interval", new object[] {
			profile_names,
			intervals}, callback, asyncState);
	}
	public void Endset_keepalive_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lzo_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_lzo_state(
		string [] profile_names,
		CommonProfileEnabledState [] states
	) {
		this.Invoke("set_lzo_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_lzo_state(string [] profile_names,CommonProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lzo_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_lzo_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_repair_adaptive_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_repair_adaptive_state(
		string [] profile_names,
		CommonProfileEnabledState [] states
	) {
		this.Invoke("set_repair_adaptive_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_repair_adaptive_state(string [] profile_names,CommonProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_repair_adaptive_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_repair_adaptive_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_repair_packet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_repair_packet(
		string [] profile_names,
		CommonProfileULong [] values
	) {
		this.Invoke("set_repair_packet", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_repair_packet(string [] profile_names,CommonProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_repair_packet", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_repair_packet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_adaptive_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_source_adaptive_state(
		string [] profile_names,
		CommonProfileEnabledState [] states
	) {
		this.Invoke("set_source_adaptive_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_source_adaptive_state(string [] profile_names,CommonProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_adaptive_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_source_adaptive_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_packet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_source_packet(
		string [] profile_names,
		CommonProfileULong [] values
	) {
		this.Invoke("set_source_packet", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_source_packet(string [] profile_names,CommonProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_packet", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_source_packet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_udp_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileFEC", 
		RequestNamespace="urn:iControl:Networking/ProfileFEC", ResponseNamespace="urn:iControl:Networking/ProfileFEC")]
	public void set_udp_port(
		string [] profile_names,
		CommonProfilePortNumber [] ports
	) {
		this.Invoke("set_udp_port", new object [] {
				profile_names,
				ports});

	}
	public System.IAsyncResult Beginset_udp_port(string [] profile_names,CommonProfilePortNumber [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_udp_port", new object[] {
			profile_names,
			ports}, callback, asyncState);
	}
	public void Endset_udp_port(System.IAsyncResult asyncResult) {
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
