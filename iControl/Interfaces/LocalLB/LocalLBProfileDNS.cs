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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileDNSBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileDNSProfileDNSStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileDNSProfileDNS64AdditionalSectionRewrite))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileDNSProfileDNS64Mode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileIPAddress))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileDNSProfileDNSLastAction))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileDNS : iControlInterface {
		public LocalLBProfileDNS() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDNSProfileDNSStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileDNSProfileDNSStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileDNSProfileDNSStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDNSProfileDNSStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_avr_dnsstat_sample_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_avr_dnsstat_sample_rate(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_avr_dnsstat_sample_rate", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_avr_dnsstat_sample_rate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_avr_dnsstat_sample_rate", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_avr_dnsstat_sample_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	// get_dns64_additional_section_rewrite
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDNSProfileDNS64AdditionalSectionRewrite [] get_dns64_additional_section_rewrite(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns64_additional_section_rewrite", new object [] {
				profile_names});
		return ((LocalLBProfileDNSProfileDNS64AdditionalSectionRewrite [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns64_additional_section_rewrite(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns64_additional_section_rewrite", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileDNSProfileDNS64AdditionalSectionRewrite [] Endget_dns64_additional_section_rewrite(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDNSProfileDNS64AdditionalSectionRewrite [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns64_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDNSProfileDNS64Mode [] get_dns64_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns64_mode", new object [] {
				profile_names});
		return ((LocalLBProfileDNSProfileDNS64Mode [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns64_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns64_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileDNSProfileDNS64Mode [] Endget_dns64_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDNSProfileDNS64Mode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns64_prefix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileIPAddress [] get_dns64_prefix(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns64_prefix", new object [] {
				profile_names});
		return ((LocalLBProfileIPAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns64_prefix(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns64_prefix", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileIPAddress [] Endget_dns64_prefix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileIPAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_cache
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_dns_cache(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns_cache", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_cache(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_cache", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_dns_cache(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_cache_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_dns_cache_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns_cache_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_cache_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_cache_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_dns_cache_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_express_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_dns_express_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns_express_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_express_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_express_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_dns_express_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_firewall_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_dns_firewall_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns_firewall_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_firewall_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_firewall_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_dns_firewall_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_last_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDNSProfileDNSLastAction [] get_dns_last_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns_last_action", new object [] {
				profile_names});
		return ((LocalLBProfileDNSProfileDNSLastAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_last_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_last_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileDNSProfileDNSLastAction [] Endget_dns_last_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDNSProfileDNSLastAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_logging_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_dns_logging_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns_logging_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_logging_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_logging_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_dns_logging_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_logging_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_dns_logging_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns_logging_profile", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_logging_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_logging_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_dns_logging_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_security_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_dns_security_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns_security_profile", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_security_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_security_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_dns_security_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dnssec_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_dnssec_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dnssec_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dnssec_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dnssec_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_dnssec_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_gtm_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_gtm_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_gtm_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_gtm_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_gtm_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_gtm_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileDNSProfileDNSStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileDNSProfileDNSStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileDNSProfileDNSStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileDNSProfileDNSStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	// get_use_local_bind_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_use_local_bind_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_use_local_bind_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_local_bind_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_local_bind_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_use_local_bind_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	// get_zone_transfer_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_zone_transfer_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_zone_transfer_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_zone_transfer_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_zone_transfer_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_zone_transfer_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	// set_avr_dnsstat_sample_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_avr_dnsstat_sample_rate(
		string [] profile_names,
		LocalLBProfileULong [] rates
	) {
		this.Invoke("set_avr_dnsstat_sample_rate", new object [] {
				profile_names,
				rates});

	}
	public System.IAsyncResult Beginset_avr_dnsstat_sample_rate(string [] profile_names,LocalLBProfileULong [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_avr_dnsstat_sample_rate", new object[] {
			profile_names,
			rates}, callback, asyncState);
	}
	public void Endset_avr_dnsstat_sample_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
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
	// set_dns64_additional_section_rewrite
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns64_additional_section_rewrite(
		string [] profile_names,
		LocalLBProfileDNSProfileDNS64AdditionalSectionRewrite [] values
	) {
		this.Invoke("set_dns64_additional_section_rewrite", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_dns64_additional_section_rewrite(string [] profile_names,LocalLBProfileDNSProfileDNS64AdditionalSectionRewrite [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns64_additional_section_rewrite", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_dns64_additional_section_rewrite(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns64_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns64_mode(
		string [] profile_names,
		LocalLBProfileDNSProfileDNS64Mode [] modes
	) {
		this.Invoke("set_dns64_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_dns64_mode(string [] profile_names,LocalLBProfileDNSProfileDNS64Mode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns64_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_dns64_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns64_prefix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns64_prefix(
		string [] profile_names,
		LocalLBProfileIPAddress [] values
	) {
		this.Invoke("set_dns64_prefix", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_dns64_prefix(string [] profile_names,LocalLBProfileIPAddress [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns64_prefix", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_dns64_prefix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_cache
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns_cache(
		string [] profile_names,
		LocalLBProfileString [] caches
	) {
		this.Invoke("set_dns_cache", new object [] {
				profile_names,
				caches});

	}
	public System.IAsyncResult Beginset_dns_cache(string [] profile_names,LocalLBProfileString [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_cache", new object[] {
			profile_names,
			caches}, callback, asyncState);
	}
	public void Endset_dns_cache(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_cache_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns_cache_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_dns_cache_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_dns_cache_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_cache_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_dns_cache_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_express_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns_express_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_dns_express_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_dns_express_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_express_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_dns_express_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_firewall_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns_firewall_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_dns_firewall_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_dns_firewall_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_firewall_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_dns_firewall_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_last_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns_last_action(
		string [] profile_names,
		LocalLBProfileDNSProfileDNSLastAction [] actions
	) {
		this.Invoke("set_dns_last_action", new object [] {
				profile_names,
				actions});

	}
	public System.IAsyncResult Beginset_dns_last_action(string [] profile_names,LocalLBProfileDNSProfileDNSLastAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_last_action", new object[] {
			profile_names,
			actions}, callback, asyncState);
	}
	public void Endset_dns_last_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_logging_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns_logging_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_dns_logging_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_dns_logging_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_logging_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_dns_logging_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_logging_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns_logging_profile(
		string [] profile_names,
		LocalLBProfileString [] logging_profile_names
	) {
		this.Invoke("set_dns_logging_profile", new object [] {
				profile_names,
				logging_profile_names});

	}
	public System.IAsyncResult Beginset_dns_logging_profile(string [] profile_names,LocalLBProfileString [] logging_profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_logging_profile", new object[] {
			profile_names,
			logging_profile_names}, callback, asyncState);
	}
	public void Endset_dns_logging_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_security_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dns_security_profile(
		string [] profile_names,
		LocalLBProfileString [] security_profile_names
	) {
		this.Invoke("set_dns_security_profile", new object [] {
				profile_names,
				security_profile_names});

	}
	public System.IAsyncResult Beginset_dns_security_profile(string [] profile_names,LocalLBProfileString [] security_profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_security_profile", new object[] {
			profile_names,
			security_profile_names}, callback, asyncState);
	}
	public void Endset_dns_security_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dnssec_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_dnssec_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_dnssec_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_dnssec_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dnssec_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_dnssec_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_gtm_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_gtm_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_gtm_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_gtm_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_gtm_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_gtm_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_local_bind_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_use_local_bind_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_use_local_bind_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_use_local_bind_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_local_bind_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_use_local_bind_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_zone_transfer_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNS", ResponseNamespace="urn:iControl:LocalLB/ProfileDNS")]
	public void set_zone_transfer_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_zone_transfer_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_zone_transfer_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_zone_transfer_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_zone_transfer_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDNS.DNS64AdditionalSectionRewrite", Namespace = "urn:iControl")]
	public enum LocalLBProfileDNSDNS64AdditionalSectionRewrite
	{
		DNS64_ADDITIONAL_SECTION_REWRITE_UNKNOWN,
		DNS64_ADDITIONAL_SECTION_REWRITE_DISABLE,
		DNS64_ADDITIONAL_SECTION_REWRITE_V6ONLY,
		DNS64_ADDITIONAL_SECTION_REWRITE_V4ONLY,
		DNS64_ADDITIONAL_SECTION_REWRITE_ANY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDNS.DNS64Mode", Namespace = "urn:iControl")]
	public enum LocalLBProfileDNSDNS64Mode
	{
		DNS64_MODE_UNKNOWN,
		DNS64_MODE_DISABLE,
		DNS64_MODE_SECONDARY,
		DNS64_MODE_IMMEDIATE,
		DNS64_MODE_V4ONLY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDNS.DNSLastAction", Namespace = "urn:iControl")]
	public enum LocalLBProfileDNSDNSLastAction
	{
		DNS_LAST_ACTION_UNKNOWN,
		DNS_LAST_ACTION_ALLOW,
		DNS_LAST_ACTION_DROP,
		DNS_LAST_ACTION_REJECT,
		DNS_LAST_ACTION_HINT,
		DNS_LAST_ACTION_NOERROR,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDNS.ProfileDNS64AdditionalSectionRewrite", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDNSProfileDNS64AdditionalSectionRewrite
	{
		private LocalLBProfileDNSDNS64AdditionalSectionRewrite valueField;
		public LocalLBProfileDNSDNS64AdditionalSectionRewrite value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDNS.ProfileDNS64Mode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDNSProfileDNS64Mode
	{
		private LocalLBProfileDNSDNS64Mode valueField;
		public LocalLBProfileDNSDNS64Mode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDNS.ProfileDNSLastAction", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDNSProfileDNSLastAction
	{
		private LocalLBProfileDNSDNSLastAction valueField;
		public LocalLBProfileDNSDNSLastAction value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDNS.ProfileDNSStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDNSProfileDNSStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileDNS.ProfileDNSStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileDNSProfileDNSStatistics
	{
		private LocalLBProfileDNSProfileDNSStatisticEntry [] statisticsField;
		public LocalLBProfileDNSProfileDNSStatisticEntry [] statistics
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
