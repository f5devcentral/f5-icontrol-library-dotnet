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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.ProfileDNSSecurityBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SecurityProfileDNSSecurityDNSSecurityStatistics))]
	public partial class SecurityProfileDNSSecurity : iControlInterface {
		public SecurityProfileDNSSecurity() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_header_opcode_exclusion
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	public void add_header_opcode_exclusion(
		string [] profile_names,
		SecurityHeaderOpcode [] [] exclusions
	) {
		this.Invoke("add_header_opcode_exclusion", new object [] {
				profile_names,
				exclusions});

	}
	public System.IAsyncResult Beginadd_header_opcode_exclusion(string [] profile_names,SecurityHeaderOpcode [] [] exclusions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_header_opcode_exclusion", new object[] {
			profile_names,
			exclusions}, callback, asyncState);
	}
	public void Endadd_header_opcode_exclusion(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_query_type_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	public void add_query_type_filter(
		string [] profile_names,
		SecurityQueryType [] [] filters
	) {
		this.Invoke("add_query_type_filter", new object [] {
				profile_names,
				filters});

	}
	public System.IAsyncResult Beginadd_query_type_filter(string [] profile_names,SecurityQueryType [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_query_type_filter", new object[] {
			profile_names,
			filters}, callback, asyncState);
	}
	public void Endadd_query_type_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
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
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDNSSecurityDNSSecurityStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((SecurityProfileDNSSecurityDNSSecurityStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public SecurityProfileDNSSecurityDNSSecurityStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDNSSecurityDNSSecurityStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
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
	// get_header_opcode_exclusion
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityHeaderOpcode [] [] get_header_opcode_exclusion(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_header_opcode_exclusion", new object [] {
				profile_names});
		return ((SecurityHeaderOpcode [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_header_opcode_exclusion(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_header_opcode_exclusion", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityHeaderOpcode [] [] Endget_header_opcode_exclusion(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityHeaderOpcode [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
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
	// get_query_type_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityQueryType [] [] get_query_type_filter(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_query_type_filter", new object [] {
				profile_names});
		return ((SecurityQueryType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_query_type_filter(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_query_type_filter", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityQueryType [] [] Endget_query_type_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityQueryType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_query_type_inclusion_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_query_type_inclusion_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_query_type_inclusion_state", new object [] {
				profile_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_query_type_inclusion_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_query_type_inclusion_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_query_type_inclusion_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDNSSecurityDNSSecurityStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((SecurityProfileDNSSecurityDNSSecurityStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileDNSSecurityDNSSecurityStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDNSSecurityDNSSecurityStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
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
	// remove_all_header_opcode_exclusions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	public void remove_all_header_opcode_exclusions(
		string [] profile_names
	) {
		this.Invoke("remove_all_header_opcode_exclusions", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_header_opcode_exclusions(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_header_opcode_exclusions", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_header_opcode_exclusions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_query_type_filters
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	public void remove_all_query_type_filters(
		string [] profile_names
	) {
		this.Invoke("remove_all_query_type_filters", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_query_type_filters(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_query_type_filters", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_query_type_filters(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_header_opcode_exclusion
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	public void remove_header_opcode_exclusion(
		string [] profile_names,
		SecurityHeaderOpcode [] [] exclusions
	) {
		this.Invoke("remove_header_opcode_exclusion", new object [] {
				profile_names,
				exclusions});

	}
	public System.IAsyncResult Beginremove_header_opcode_exclusion(string [] profile_names,SecurityHeaderOpcode [] [] exclusions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_header_opcode_exclusion", new object[] {
			profile_names,
			exclusions}, callback, asyncState);
	}
	public void Endremove_header_opcode_exclusion(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_query_type_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	public void remove_query_type_filter(
		string [] profile_names,
		SecurityQueryType [] [] filters
	) {
		this.Invoke("remove_query_type_filter", new object [] {
				profile_names,
				filters});

	}
	public System.IAsyncResult Beginremove_query_type_filter(string [] profile_names,SecurityQueryType [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_query_type_filter", new object[] {
			profile_names,
			filters}, callback, asyncState);
	}
	public void Endremove_query_type_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	public void reset_statistics(
		string [] profile_names
	) {
		this.Invoke("reset_statistics", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginreset_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
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
	// set_query_type_inclusion_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDNSSecurity", 
		RequestNamespace="urn:iControl:Security/ProfileDNSSecurity", ResponseNamespace="urn:iControl:Security/ProfileDNSSecurity")]
	public void set_query_type_inclusion_state(
		string [] profile_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_query_type_inclusion_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_query_type_inclusion_state(string [] profile_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_query_type_inclusion_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_query_type_inclusion_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDNSSecurity.DNSSecurityStatisticEntry", Namespace = "urn:iControl")]
	public partial class SecurityProfileDNSSecurityDNSSecurityStatisticEntry
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDNSSecurity.DNSSecurityStatistics", Namespace = "urn:iControl")]
	public partial class SecurityProfileDNSSecurityDNSSecurityStatistics
	{
		private SecurityProfileDNSSecurityDNSSecurityStatisticEntry [] statisticsField;
		public SecurityProfileDNSSecurityDNSSecurityStatisticEntry [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private CommonTimeStamp time_stampField;
		public CommonTimeStamp time_stamp
		{
			get { return this.time_stampField; }
			set { this.time_stampField = value; }
		}
	};

}
