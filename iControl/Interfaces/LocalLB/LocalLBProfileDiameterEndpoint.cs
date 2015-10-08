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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileDiameterEndpointBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileDiameterEndpointDiameterEndpointProfileStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileDiameterEndpointProfileDiameterApplicationTypeSequence))]
	public partial class LocalLBProfileDiameterEndpoint : iControlInterface {
		public LocalLBProfileDiameterEndpoint() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDiameterEndpointDiameterEndpointProfileStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileDiameterEndpointDiameterEndpointProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileDiameterEndpointDiameterEndpointProfileStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDiameterEndpointDiameterEndpointProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
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
	// get_destination_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_destination_host(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_destination_host", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_host(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_host", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_destination_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_destination_realm(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_destination_realm", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_realm(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_realm", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_destination_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fatal_grace_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_fatal_grace_time(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_fatal_grace_time", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_fatal_grace_time(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fatal_grace_time", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_fatal_grace_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fatal_grace_time_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_fatal_grace_time_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_fatal_grace_time_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_fatal_grace_time_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fatal_grace_time_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_fatal_grace_time_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
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
	// get_maximum_retransmit_attempts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_retransmit_attempts(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_retransmit_attempts", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_retransmit_attempts(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_retransmit_attempts", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_retransmit_attempts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_origin_host(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_origin_host", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_host(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_host", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_origin_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_origin_realm(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_origin_realm", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_realm(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_realm", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_origin_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_product_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_product_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_product_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_product_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_product_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_product_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_retransmit_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_retransmit_delay(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_retransmit_delay", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_retransmit_delay(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_retransmit_delay", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_retransmit_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDiameterEndpointDiameterEndpointProfileStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileDiameterEndpointDiameterEndpointProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileDiameterEndpointDiameterEndpointProfileStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDiameterEndpointDiameterEndpointProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStatisticsByVirtual get_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		object [] results = this.Invoke("get_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public LocalLBProfileStatisticsByVirtual Endget_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_supported_application_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDiameterEndpointProfileDiameterApplicationTypeSequence [] get_supported_application_type(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_supported_application_type", new object [] {
				profile_names});
		return ((LocalLBProfileDiameterEndpointProfileDiameterApplicationTypeSequence [])(results[0]));
	}
	public System.IAsyncResult Beginget_supported_application_type(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_supported_application_type", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileDiameterEndpointProfileDiameterApplicationTypeSequence [] Endget_supported_application_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDiameterEndpointProfileDiameterApplicationTypeSequence [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
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
	// replace_supported_application_types
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void replace_supported_application_types(
		string [] profile_names,
		LocalLBProfileDiameterEndpointProfileDiameterApplicationTypeSequence [] types
	) {
		this.Invoke("replace_supported_application_types", new object [] {
				profile_names,
				types});

	}
	public System.IAsyncResult Beginreplace_supported_application_types(string [] profile_names,LocalLBProfileDiameterEndpointProfileDiameterApplicationTypeSequence [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_supported_application_types", new object[] {
			profile_names,
			types}, callback, asyncState);
	}
	public void Endreplace_supported_application_types(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
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
	// reset_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void reset_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		this.Invoke("reset_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});

	}
	public System.IAsyncResult Beginreset_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public void Endreset_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
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
	// set_destination_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void set_destination_host(
		string [] profile_names,
		LocalLBProfileString [] hosts
	) {
		this.Invoke("set_destination_host", new object [] {
				profile_names,
				hosts});

	}
	public System.IAsyncResult Beginset_destination_host(string [] profile_names,LocalLBProfileString [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_host", new object[] {
			profile_names,
			hosts}, callback, asyncState);
	}
	public void Endset_destination_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_destination_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void set_destination_realm(
		string [] profile_names,
		LocalLBProfileString [] realms
	) {
		this.Invoke("set_destination_realm", new object [] {
				profile_names,
				realms});

	}
	public System.IAsyncResult Beginset_destination_realm(string [] profile_names,LocalLBProfileString [] realms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_realm", new object[] {
			profile_names,
			realms}, callback, asyncState);
	}
	public void Endset_destination_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fatal_grace_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void set_fatal_grace_time(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_fatal_grace_time", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_fatal_grace_time(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fatal_grace_time", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_fatal_grace_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fatal_grace_time_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void set_fatal_grace_time_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_fatal_grace_time_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_fatal_grace_time_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fatal_grace_time_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_fatal_grace_time_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_retransmit_attempts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void set_maximum_retransmit_attempts(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_retransmit_attempts", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_retransmit_attempts(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_retransmit_attempts", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_retransmit_attempts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void set_origin_host(
		string [] profile_names,
		LocalLBProfileString [] hosts
	) {
		this.Invoke("set_origin_host", new object [] {
				profile_names,
				hosts});

	}
	public System.IAsyncResult Beginset_origin_host(string [] profile_names,LocalLBProfileString [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_host", new object[] {
			profile_names,
			hosts}, callback, asyncState);
	}
	public void Endset_origin_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void set_origin_realm(
		string [] profile_names,
		LocalLBProfileString [] realms
	) {
		this.Invoke("set_origin_realm", new object [] {
				profile_names,
				realms});

	}
	public System.IAsyncResult Beginset_origin_realm(string [] profile_names,LocalLBProfileString [] realms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_realm", new object[] {
			profile_names,
			realms}, callback, asyncState);
	}
	public void Endset_origin_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_product_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void set_product_name(
		string [] profile_names,
		LocalLBProfileString [] products
	) {
		this.Invoke("set_product_name", new object [] {
				profile_names,
				products});

	}
	public System.IAsyncResult Beginset_product_name(string [] profile_names,LocalLBProfileString [] products, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_product_name", new object[] {
			profile_names,
			products}, callback, asyncState);
	}
	public void Endset_product_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_retransmit_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDiameterEndpoint", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint", ResponseNamespace="urn:iControl:LocalLB/ProfileDiameterEndpoint")]
	public void set_retransmit_delay(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_retransmit_delay", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_retransmit_delay(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_retransmit_delay", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_retransmit_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterEndpoint.DiameterApplicationType", Namespace = "urn:iControl")]
	public enum LocalLBProfileDiameterEndpointDiameterApplicationType
	{
		DIAMETER_APPLICATION_TYPE_UNKNOWN,
		DIAMETER_APPLICATION_TYPE_GX,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterEndpoint.DiameterEndpointProfileStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDiameterEndpointDiameterEndpointProfileStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterEndpoint.DiameterEndpointProfileStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDiameterEndpointDiameterEndpointProfileStatistics
	{
		private LocalLBProfileDiameterEndpointDiameterEndpointProfileStatisticEntry [] statisticsField;
		public LocalLBProfileDiameterEndpointDiameterEndpointProfileStatisticEntry [] statistics
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDiameterEndpoint.ProfileDiameterApplicationTypeSequence", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDiameterEndpointProfileDiameterApplicationTypeSequence
	{
		private LocalLBProfileDiameterEndpointDiameterApplicationType [] valueField;
		public LocalLBProfileDiameterEndpointDiameterApplicationType [] value
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
