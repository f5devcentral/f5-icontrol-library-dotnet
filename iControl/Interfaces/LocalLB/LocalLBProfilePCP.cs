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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfilePCPBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfilePortNumber))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	public partial class LocalLBProfilePCP : iControlInterface {
		public LocalLBProfilePCP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_third_party_allowed_subnet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void add_third_party_allowed_subnet(
		string [] profile_names,
		string [] [] subnets
	) {
		this.Invoke("add_third_party_allowed_subnet", new object [] {
				profile_names,
				subnets});

	}
	public System.IAsyncResult Beginadd_third_party_allowed_subnet(string [] profile_names,string [] [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_third_party_allowed_subnet", new object[] {
			profile_names,
			subnets}, callback, asyncState);
	}
	public void Endadd_third_party_allowed_subnet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	// get_announce_after_failover_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_announce_after_failover_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_announce_after_failover_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_announce_after_failover_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_announce_after_failover_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_announce_after_failover_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_announce_multicast_repeats
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_announce_multicast_repeats(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_announce_multicast_repeats", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_announce_multicast_repeats(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_announce_multicast_repeats", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_announce_multicast_repeats(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	// get_listening_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfilePortNumber [] get_listening_port(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_listening_port", new object [] {
				profile_names});
		return ((LocalLBProfilePortNumber [])(results[0]));
	}
	public System.IAsyncResult Beginget_listening_port(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_listening_port", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfilePortNumber [] Endget_listening_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfilePortNumber [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mapping_filter_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_mapping_filter_limit(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_mapping_filter_limit", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_mapping_filter_limit(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mapping_filter_limit", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_mapping_filter_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mapping_limit_per_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_mapping_limit_per_client(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_mapping_limit_per_client", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_mapping_limit_per_client(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mapping_limit_per_client", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_mapping_limit_per_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mapping_recycle_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_mapping_recycle_delay(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_mapping_recycle_delay", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_mapping_recycle_delay(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mapping_recycle_delay", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_mapping_recycle_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_mapping_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_mapping_lifetime(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_mapping_lifetime", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_mapping_lifetime(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_mapping_lifetime", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_mapping_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_minimum_mapping_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_minimum_mapping_lifetime(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_minimum_mapping_lifetime", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_minimum_mapping_lifetime(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_minimum_mapping_lifetime", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_minimum_mapping_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_multicast_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfilePortNumber [] get_multicast_port(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_multicast_port", new object [] {
				profile_names});
		return ((LocalLBProfilePortNumber [])(results[0]));
	}
	public System.IAsyncResult Beginget_multicast_port(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_multicast_port", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfilePortNumber [] Endget_multicast_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfilePortNumber [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_rule(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rule", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_third_party_allowed_subnet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_third_party_allowed_subnet(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_third_party_allowed_subnet", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_third_party_allowed_subnet(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_third_party_allowed_subnet", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_third_party_allowed_subnet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_third_party_option_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_third_party_option_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_third_party_option_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_third_party_option_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_third_party_option_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_third_party_option_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	// remove_all_third_party_allowed_subnets
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void remove_all_third_party_allowed_subnets(
		string [] profile_names
	) {
		this.Invoke("remove_all_third_party_allowed_subnets", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_third_party_allowed_subnets(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_third_party_allowed_subnets", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_third_party_allowed_subnets(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_third_party_allowed_subnet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void remove_third_party_allowed_subnet(
		string [] profile_names,
		string [] [] subnets
	) {
		this.Invoke("remove_third_party_allowed_subnet", new object [] {
				profile_names,
				subnets});

	}
	public System.IAsyncResult Beginremove_third_party_allowed_subnet(string [] profile_names,string [] [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_third_party_allowed_subnet", new object[] {
			profile_names,
			subnets}, callback, asyncState);
	}
	public void Endremove_third_party_allowed_subnet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_announce_after_failover_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void set_announce_after_failover_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_announce_after_failover_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_announce_after_failover_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_announce_after_failover_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_announce_after_failover_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_announce_multicast_repeats
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void set_announce_multicast_repeats(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_announce_multicast_repeats", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_announce_multicast_repeats(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_announce_multicast_repeats", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_announce_multicast_repeats(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
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
	// set_mapping_filter_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void set_mapping_filter_limit(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_mapping_filter_limit", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_mapping_filter_limit(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mapping_filter_limit", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_mapping_filter_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mapping_limit_per_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void set_mapping_limit_per_client(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_mapping_limit_per_client", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_mapping_limit_per_client(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mapping_limit_per_client", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_mapping_limit_per_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mapping_recycle_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void set_mapping_recycle_delay(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_mapping_recycle_delay", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_mapping_recycle_delay(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mapping_recycle_delay", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_mapping_recycle_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_mapping_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void set_maximum_mapping_lifetime(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_mapping_lifetime", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_mapping_lifetime(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_mapping_lifetime", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_mapping_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_minimum_mapping_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void set_minimum_mapping_lifetime(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_minimum_mapping_lifetime", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_minimum_mapping_lifetime(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_minimum_mapping_lifetime", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_minimum_mapping_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void set_rule(
		string [] profile_names,
		LocalLBProfileString [] rules
	) {
		this.Invoke("set_rule", new object [] {
				profile_names,
				rules});

	}
	public System.IAsyncResult Beginset_rule(string [] profile_names,LocalLBProfileString [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule", new object[] {
			profile_names,
			rules}, callback, asyncState);
	}
	public void Endset_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_third_party_option_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePCP", ResponseNamespace="urn:iControl:LocalLB/ProfilePCP")]
	public void set_third_party_option_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_third_party_option_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_third_party_option_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_third_party_option_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_third_party_option_state(System.IAsyncResult asyncResult) {
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
