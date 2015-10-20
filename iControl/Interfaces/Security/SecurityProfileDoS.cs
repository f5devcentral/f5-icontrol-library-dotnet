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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.ProfileDoSBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SecurityProfileDoSDNSQueryVectorStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SecurityProfileDoSNetworkAttackVectorStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SecurityProfileDoSSIPAttackVectorStatistics))]
	public partial class SecurityProfileDoS : iControlInterface {
		public SecurityProfileDoS() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void add_application(
		string [] profile_names,
		string [] [] applications
	) {
		this.Invoke("add_application", new object [] {
				profile_names,
				applications});

	}
	public System.IAsyncResult Beginadd_application(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_application", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public void Endadd_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_dns_query_vector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void add_dns_query_vector(
		string [] profile_names,
		string [] [] dnses,
		SecurityProfileDoSDNSQuery [] [] [] vectors
	) {
		this.Invoke("add_dns_query_vector", new object [] {
				profile_names,
				dnses,
				vectors});

	}
	public System.IAsyncResult Beginadd_dns_query_vector(string [] profile_names,string [] [] dnses,SecurityProfileDoSDNSQuery [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_dns_query_vector", new object[] {
			profile_names,
			dnses,
			vectors}, callback, asyncState);
	}
	public void Endadd_dns_query_vector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_dos_network
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void add_dos_network(
		string [] profile_names,
		string [] [] networks
	) {
		this.Invoke("add_dos_network", new object [] {
				profile_names,
				networks});

	}
	public System.IAsyncResult Beginadd_dos_network(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_dos_network", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public void Endadd_dos_network(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_heavy_url_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void add_heavy_url_exclude(
		string [] profile_names,
		string [] [] applications,
		string [] [] [] urls
	) {
		this.Invoke("add_heavy_url_exclude", new object [] {
				profile_names,
				applications,
				urls});

	}
	public System.IAsyncResult Beginadd_heavy_url_exclude(string [] profile_names,string [] [] applications,string [] [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_heavy_url_exclude", new object[] {
			profile_names,
			applications,
			urls}, callback, asyncState);
	}
	public void Endadd_heavy_url_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_heavy_url_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void add_heavy_url_include(
		string [] profile_names,
		string [] [] applications,
		string [] [] [] urls
	) {
		this.Invoke("add_heavy_url_include", new object [] {
				profile_names,
				applications,
				urls});

	}
	public System.IAsyncResult Beginadd_heavy_url_include(string [] profile_names,string [] [] applications,string [] [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_heavy_url_include", new object[] {
			profile_names,
			applications,
			urls}, callback, asyncState);
	}
	public void Endadd_heavy_url_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_network_attack_vector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void add_network_attack_vector(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors
	) {
		this.Invoke("add_network_attack_vector", new object [] {
				profile_names,
				networks,
				vectors});

	}
	public System.IAsyncResult Beginadd_network_attack_vector(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_network_attack_vector", new object[] {
			profile_names,
			networks,
			vectors}, callback, asyncState);
	}
	public void Endadd_network_attack_vector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_protocol_dns
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void add_protocol_dns(
		string [] profile_names,
		string [] [] dnses
	) {
		this.Invoke("add_protocol_dns", new object [] {
				profile_names,
				dnses});

	}
	public System.IAsyncResult Beginadd_protocol_dns(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_protocol_dns", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public void Endadd_protocol_dns(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_protocol_sip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void add_protocol_sip(
		string [] profile_names,
		string [] [] sips
	) {
		this.Invoke("add_protocol_sip", new object [] {
				profile_names,
				sips});

	}
	public System.IAsyncResult Beginadd_protocol_sip(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_protocol_sip", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public void Endadd_protocol_sip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_sip_attack_vector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void add_sip_attack_vector(
		string [] profile_names,
		string [] [] sips,
		SecurityProfileDoSSIPAttackVector [] [] [] vectors
	) {
		this.Invoke("add_sip_attack_vector", new object [] {
				profile_names,
				sips,
				vectors});

	}
	public System.IAsyncResult Beginadd_sip_attack_vector(string [] profile_names,string [] [] sips,SecurityProfileDoSSIPAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_sip_attack_vector", new object[] {
			profile_names,
			sips,
			vectors}, callback, asyncState);
	}
	public void Endadd_sip_attack_vector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_white_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void add_white_ip(
		string [] profile_names,
		string [] [] applications,
		CommonIPNetmask [] [] [] ip_netmasks
	) {
		this.Invoke("add_white_ip", new object [] {
				profile_names,
				applications,
				ip_netmasks});

	}
	public System.IAsyncResult Beginadd_white_ip(string [] profile_names,string [] [] applications,CommonIPNetmask [] [] [] ip_netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_white_ip", new object[] {
			profile_names,
			applications,
			ip_netmasks}, callback, asyncState);
	}
	public void Endadd_white_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
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
	// get_all_dns_query_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDoSDNSQueryVectorStatistics [] [] get_all_dns_query_vector_statistics(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_all_dns_query_vector_statistics", new object [] {
				profile_names,
				dnses});
		return ((SecurityProfileDoSDNSQueryVectorStatistics [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_dns_query_vector_statistics(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_dns_query_vector_statistics", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public SecurityProfileDoSDNSQueryVectorStatistics [] [] Endget_all_dns_query_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDoSDNSQueryVectorStatistics [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_network_attack_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDoSNetworkAttackVectorStatistics [] [] get_all_network_attack_vector_statistics(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_all_network_attack_vector_statistics", new object [] {
				profile_names,
				networks});
		return ((SecurityProfileDoSNetworkAttackVectorStatistics [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_network_attack_vector_statistics(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_network_attack_vector_statistics", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public SecurityProfileDoSNetworkAttackVectorStatistics [] [] Endget_all_network_attack_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDoSNetworkAttackVectorStatistics [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_sip_attack_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDoSSIPAttackVectorStatistics [] [] get_all_sip_attack_vector_statistics(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_all_sip_attack_vector_statistics", new object [] {
				profile_names,
				sips});
		return ((SecurityProfileDoSSIPAttackVectorStatistics [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_sip_attack_vector_statistics(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_sip_attack_vector_statistics", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public SecurityProfileDoSSIPAttackVectorStatistics [] [] Endget_all_sip_attack_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDoSSIPAttackVectorStatistics [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_application(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_application", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_deescalation_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_deescalation_period(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_deescalation_period", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_deescalation_period(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_deescalation_period", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_deescalation_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
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
	// get_dns_query_vector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDoSDNSQuery [] [] [] get_dns_query_vector(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_dns_query_vector", new object [] {
				profile_names,
				dnses});
		return ((SecurityProfileDoSDNSQuery [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_query_vector(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_query_vector", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public SecurityProfileDoSDNSQuery [] [] [] Endget_dns_query_vector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDoSDNSQuery [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_query_vector_rate_increase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_dns_query_vector_rate_increase(
		string [] profile_names,
		string [] [] dnses,
		SecurityProfileDoSDNSQuery [] [] [] vectors
	) {
		object [] results = this.Invoke("get_dns_query_vector_rate_increase", new object [] {
				profile_names,
				dnses,
				vectors});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_query_vector_rate_increase(string [] profile_names,string [] [] dnses,SecurityProfileDoSDNSQuery [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_query_vector_rate_increase", new object[] {
			profile_names,
			dnses,
			vectors}, callback, asyncState);
	}
	public long [] [] [] Endget_dns_query_vector_rate_increase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_query_vector_rate_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_dns_query_vector_rate_threshold(
		string [] profile_names,
		string [] [] dnses,
		SecurityProfileDoSDNSQuery [] [] [] vectors
	) {
		object [] results = this.Invoke("get_dns_query_vector_rate_threshold", new object [] {
				profile_names,
				dnses,
				vectors});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_query_vector_rate_threshold(string [] profile_names,string [] [] dnses,SecurityProfileDoSDNSQuery [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_query_vector_rate_threshold", new object[] {
			profile_names,
			dnses,
			vectors}, callback, asyncState);
	}
	public long [] [] [] Endget_dns_query_vector_rate_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_query_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDoSDNSQueryVectorStatistics [] [] get_dns_query_vector_statistics(
		string [] profile_names,
		string [] [] dnses,
		SecurityProfileDoSDNSQuery [] [] [] vectors
	) {
		object [] results = this.Invoke("get_dns_query_vector_statistics", new object [] {
				profile_names,
				dnses,
				vectors});
		return ((SecurityProfileDoSDNSQueryVectorStatistics [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_query_vector_statistics(string [] profile_names,string [] [] dnses,SecurityProfileDoSDNSQuery [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_query_vector_statistics", new object[] {
			profile_names,
			dnses,
			vectors}, callback, asyncState);
	}
	public SecurityProfileDoSDNSQueryVectorStatistics [] [] Endget_dns_query_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDoSDNSQueryVectorStatistics [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dos_network
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_dos_network(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dos_network", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dos_network(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dos_network", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_dos_network(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_escalation_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_escalation_period(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_escalation_period", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_escalation_period(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_escalation_period", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_escalation_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_heavy_url_automatic_detection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_heavy_url_automatic_detection_state(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_heavy_url_automatic_detection_state", new object [] {
				profile_names,
				applications});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_heavy_url_automatic_detection_state(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_heavy_url_automatic_detection_state", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_heavy_url_automatic_detection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_heavy_url_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_heavy_url_exclude(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_heavy_url_exclude", new object [] {
				profile_names,
				applications});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_heavy_url_exclude(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_heavy_url_exclude", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public string [] [] [] Endget_heavy_url_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_heavy_url_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_heavy_url_include(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_heavy_url_include", new object [] {
				profile_names,
				applications});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_heavy_url_include(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_heavy_url_include", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public string [] [] [] Endget_heavy_url_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_heavy_url_latency_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_heavy_url_latency_threshold(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_heavy_url_latency_threshold", new object [] {
				profile_names,
				applications});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_heavy_url_latency_threshold(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_heavy_url_latency_threshold", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public long [] [] Endget_heavy_url_latency_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_heavy_url_protection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_heavy_url_protection_state(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_heavy_url_protection_state", new object [] {
				profile_names,
				applications});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_heavy_url_protection_state(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_heavy_url_protection_state", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_heavy_url_protection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_maximum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_ip_maximum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_ip_maximum_tps", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_maximum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_maximum_tps", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_ip_maximum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_minimum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_ip_minimum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_ip_minimum_tps", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_minimum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_minimum_tps", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_ip_minimum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_tps_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_ip_tps_increase_rate(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_ip_tps_increase_rate", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_tps_increase_rate(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_tps_increase_rate", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_ip_tps_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_latency_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_latency_increase_rate(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_latency_increase_rate", new object [] {
				profile_names,
				applications});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_latency_increase_rate(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_latency_increase_rate", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public long [] [] Endget_latency_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
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
	// get_maximum_latency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_maximum_latency(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_maximum_latency", new object [] {
				profile_names,
				applications});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_latency(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_latency", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public long [] [] Endget_maximum_latency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_prevention_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_maximum_prevention_duration(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_maximum_prevention_duration", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_prevention_duration(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_prevention_duration", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_maximum_prevention_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_minimum_latency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_minimum_latency(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_minimum_latency", new object [] {
				profile_names,
				applications});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_minimum_latency(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_minimum_latency", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public long [] [] Endget_minimum_latency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_attack_vector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDoSNetworkAttackVector [] [] [] get_network_attack_vector(
		string [] profile_names,
		string [] [] networks
	) {
		object [] results = this.Invoke("get_network_attack_vector", new object [] {
				profile_names,
				networks});
		return ((SecurityProfileDoSNetworkAttackVector [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_attack_vector(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_attack_vector", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public SecurityProfileDoSNetworkAttackVector [] [] [] Endget_network_attack_vector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDoSNetworkAttackVector [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_attack_vector_auto_blacklisting_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] [] get_network_attack_vector_auto_blacklisting_state(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors
	) {
		object [] results = this.Invoke("get_network_attack_vector_auto_blacklisting_state", new object [] {
				profile_names,
				networks,
				vectors});
		return ((CommonEnabledState [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_attack_vector_auto_blacklisting_state(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_attack_vector_auto_blacklisting_state", new object[] {
			profile_names,
			networks,
			vectors}, callback, asyncState);
	}
	public CommonEnabledState [] [] [] Endget_network_attack_vector_auto_blacklisting_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_attack_vector_blacklist_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_network_attack_vector_blacklist_category(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors
	) {
		object [] results = this.Invoke("get_network_attack_vector_blacklist_category", new object [] {
				profile_names,
				networks,
				vectors});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_attack_vector_blacklist_category(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_attack_vector_blacklist_category", new object[] {
			profile_names,
			networks,
			vectors}, callback, asyncState);
	}
	public string [] [] [] Endget_network_attack_vector_blacklist_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_attack_vector_blacklist_detection_seconds
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_network_attack_vector_blacklist_detection_seconds(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors
	) {
		object [] results = this.Invoke("get_network_attack_vector_blacklist_detection_seconds", new object [] {
				profile_names,
				networks,
				vectors});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_attack_vector_blacklist_detection_seconds(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_attack_vector_blacklist_detection_seconds", new object[] {
			profile_names,
			networks,
			vectors}, callback, asyncState);
	}
	public long [] [] [] Endget_network_attack_vector_blacklist_detection_seconds(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_attack_vector_blacklist_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_network_attack_vector_blacklist_duration(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors
	) {
		object [] results = this.Invoke("get_network_attack_vector_blacklist_duration", new object [] {
				profile_names,
				networks,
				vectors});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_attack_vector_blacklist_duration(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_attack_vector_blacklist_duration", new object[] {
			profile_names,
			networks,
			vectors}, callback, asyncState);
	}
	public long [] [] [] Endget_network_attack_vector_blacklist_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_attack_vector_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_network_attack_vector_rate_limit(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors
	) {
		object [] results = this.Invoke("get_network_attack_vector_rate_limit", new object [] {
				profile_names,
				networks,
				vectors});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_attack_vector_rate_limit(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_attack_vector_rate_limit", new object[] {
			profile_names,
			networks,
			vectors}, callback, asyncState);
	}
	public long [] [] [] Endget_network_attack_vector_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_attack_vector_rate_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_network_attack_vector_rate_threshold(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors
	) {
		object [] results = this.Invoke("get_network_attack_vector_rate_threshold", new object [] {
				profile_names,
				networks,
				vectors});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_attack_vector_rate_threshold(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_attack_vector_rate_threshold", new object[] {
			profile_names,
			networks,
			vectors}, callback, asyncState);
	}
	public long [] [] [] Endget_network_attack_vector_rate_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_network_attack_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDoSNetworkAttackVectorStatistics [] [] get_network_attack_vector_statistics(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors
	) {
		object [] results = this.Invoke("get_network_attack_vector_statistics", new object [] {
				profile_names,
				networks,
				vectors});
		return ((SecurityProfileDoSNetworkAttackVectorStatistics [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_attack_vector_statistics(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_attack_vector_statistics", new object[] {
			profile_names,
			networks,
			vectors}, callback, asyncState);
	}
	public SecurityProfileDoSNetworkAttackVectorStatistics [] [] Endget_network_attack_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDoSNetworkAttackVectorStatistics [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_operation_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDoSOperationMode [] [] get_operation_mode(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_operation_mode", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((SecurityProfileDoSOperationMode [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_operation_mode(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_operation_mode", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public SecurityProfileDoSOperationMode [] [] Endget_operation_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDoSOperationMode [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_dns(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_protocol_dns", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_protocol_dns(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_error_attack_detection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_dns_error_attack_detection_state(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_error_attack_detection_state", new object [] {
				profile_names,
				dnses});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_error_attack_detection_state(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_error_attack_detection_state", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_dns_error_attack_detection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_dns_error_attack_rate_increase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_protocol_dns_error_attack_rate_increase(
		string [] profile_names,
		string [] [] dnses
	) {
		object [] results = this.Invoke("get_protocol_dns_error_attack_rate_increase", new object [] {
				profile_names,
				dnses});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_dns_error_attack_rate_increase(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_dns_error_attack_rate_increase", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public long [] [] Endget_protocol_dns_error_attack_rate_increase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_protocol_sip(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_protocol_sip", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_protocol_sip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_error_attack_detection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_protocol_sip_error_attack_detection_state(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_error_attack_detection_state", new object [] {
				profile_names,
				sips});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_error_attack_detection_state(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_error_attack_detection_state", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_protocol_sip_error_attack_detection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_error_attack_rate_increase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_protocol_sip_error_attack_rate_increase(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_error_attack_rate_increase", new object [] {
				profile_names,
				sips});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_error_attack_rate_increase(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_error_attack_rate_increase", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public long [] [] Endget_protocol_sip_error_attack_rate_increase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol_sip_error_attack_rate_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_protocol_sip_error_attack_rate_threshold(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_protocol_sip_error_attack_rate_threshold", new object [] {
				profile_names,
				sips});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_sip_error_attack_rate_threshold(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_sip_error_attack_rate_threshold", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public long [] [] Endget_protocol_sip_error_attack_rate_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sip_attack_vector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDoSSIPAttackVector [] [] [] get_sip_attack_vector(
		string [] profile_names,
		string [] [] sips
	) {
		object [] results = this.Invoke("get_sip_attack_vector", new object [] {
				profile_names,
				sips});
		return ((SecurityProfileDoSSIPAttackVector [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_sip_attack_vector(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sip_attack_vector", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public SecurityProfileDoSSIPAttackVector [] [] [] Endget_sip_attack_vector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDoSSIPAttackVector [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sip_attack_vector_rate_increase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_sip_attack_vector_rate_increase(
		string [] profile_names,
		string [] [] sips,
		SecurityProfileDoSSIPAttackVector [] [] [] vectors
	) {
		object [] results = this.Invoke("get_sip_attack_vector_rate_increase", new object [] {
				profile_names,
				sips,
				vectors});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_sip_attack_vector_rate_increase(string [] profile_names,string [] [] sips,SecurityProfileDoSSIPAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sip_attack_vector_rate_increase", new object[] {
			profile_names,
			sips,
			vectors}, callback, asyncState);
	}
	public long [] [] [] Endget_sip_attack_vector_rate_increase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sip_attack_vector_rate_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_sip_attack_vector_rate_threshold(
		string [] profile_names,
		string [] [] sips,
		SecurityProfileDoSSIPAttackVector [] [] [] vectors
	) {
		object [] results = this.Invoke("get_sip_attack_vector_rate_threshold", new object [] {
				profile_names,
				sips,
				vectors});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_sip_attack_vector_rate_threshold(string [] profile_names,string [] [] sips,SecurityProfileDoSSIPAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sip_attack_vector_rate_threshold", new object[] {
			profile_names,
			sips,
			vectors}, callback, asyncState);
	}
	public long [] [] [] Endget_sip_attack_vector_rate_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sip_attack_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileDoSSIPAttackVectorStatistics [] [] get_sip_attack_vector_statistics(
		string [] profile_names,
		string [] [] sips,
		SecurityProfileDoSSIPAttackVector [] [] [] vectors
	) {
		object [] results = this.Invoke("get_sip_attack_vector_statistics", new object [] {
				profile_names,
				sips,
				vectors});
		return ((SecurityProfileDoSSIPAttackVectorStatistics [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_sip_attack_vector_statistics(string [] profile_names,string [] [] sips,SecurityProfileDoSSIPAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sip_attack_vector_statistics", new object[] {
			profile_names,
			sips,
			vectors}, callback, asyncState);
	}
	public SecurityProfileDoSSIPAttackVectorStatistics [] [] Endget_sip_attack_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileDoSSIPAttackVectorStatistics [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_site_wide_client_side_integrity_defense_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_site_wide_client_side_integrity_defense_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_site_wide_client_side_integrity_defense_state", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_site_wide_client_side_integrity_defense_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_site_wide_client_side_integrity_defense_state", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_site_wide_client_side_integrity_defense_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_site_wide_maximum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_site_wide_maximum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_site_wide_maximum_tps", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_site_wide_maximum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_site_wide_maximum_tps", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_site_wide_maximum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_site_wide_minimum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_site_wide_minimum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_site_wide_minimum_tps", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_site_wide_minimum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_site_wide_minimum_tps", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_site_wide_minimum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_site_wide_rate_limiting_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_site_wide_rate_limiting_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_site_wide_rate_limiting_state", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_site_wide_rate_limiting_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_site_wide_rate_limiting_state", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_site_wide_rate_limiting_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_site_wide_tps_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_site_wide_tps_increase_rate(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_site_wide_tps_increase_rate", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_site_wide_tps_increase_rate(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_site_wide_tps_increase_rate", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_site_wide_tps_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_ip_based_client_side_integrity_defense_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_source_ip_based_client_side_integrity_defense_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_source_ip_based_client_side_integrity_defense_state", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_ip_based_client_side_integrity_defense_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_ip_based_client_side_integrity_defense_state", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_source_ip_based_client_side_integrity_defense_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_ip_based_rate_limiting_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_source_ip_based_rate_limiting_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_source_ip_based_rate_limiting_state", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_ip_based_rate_limiting_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_ip_based_rate_limiting_state", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_source_ip_based_rate_limiting_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_dump_maximum_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_tcp_dump_maximum_duration(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_tcp_dump_maximum_duration", new object [] {
				profile_names,
				applications});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_dump_maximum_duration(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_dump_maximum_duration", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public long [] [] Endget_tcp_dump_maximum_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_dump_maximum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_tcp_dump_maximum_size(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_tcp_dump_maximum_size", new object [] {
				profile_names,
				applications});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_dump_maximum_size(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_dump_maximum_size", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public long [] [] Endget_tcp_dump_maximum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_dump_record_traffic_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_tcp_dump_record_traffic_state(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_tcp_dump_record_traffic_state", new object [] {
				profile_names,
				applications});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_dump_record_traffic_state(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_dump_record_traffic_state", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_tcp_dump_record_traffic_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_dump_repetition_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_tcp_dump_repetition_interval(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_tcp_dump_repetition_interval", new object [] {
				profile_names,
				applications});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_dump_repetition_interval(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_dump_repetition_interval", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public long [] [] Endget_tcp_dump_repetition_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trigger_irule_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_trigger_irule_state(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_trigger_irule_state", new object [] {
				profile_names,
				applications});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_trigger_irule_state(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trigger_irule_state", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_trigger_irule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_url_based_client_side_integrity_defense_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_url_based_client_side_integrity_defense_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_url_based_client_side_integrity_defense_state", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_url_based_client_side_integrity_defense_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_url_based_client_side_integrity_defense_state", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_url_based_client_side_integrity_defense_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_url_based_rate_limiting_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_url_based_rate_limiting_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_url_based_rate_limiting_state", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_url_based_rate_limiting_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_url_based_rate_limiting_state", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_url_based_rate_limiting_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_url_maximum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_url_maximum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_url_maximum_tps", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_url_maximum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_url_maximum_tps", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_url_maximum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_url_minimum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_url_minimum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_url_minimum_tps", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_url_minimum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_url_minimum_tps", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_url_minimum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_url_tps_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_url_tps_increase_rate(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly
	) {
		object [] results = this.Invoke("get_url_tps_increase_rate", new object [] {
				profile_names,
				applications,
				anomaly});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_url_tps_increase_rate(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_url_tps_increase_rate", new object[] {
			profile_names,
			applications,
			anomaly}, callback, asyncState);
	}
	public long [] [] Endget_url_tps_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
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
	// get_white_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPNetmask [] [] [] get_white_ip(
		string [] profile_names,
		string [] [] applications
	) {
		object [] results = this.Invoke("get_white_ip", new object [] {
				profile_names,
				applications});
		return ((CommonIPNetmask [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_white_ip(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_white_ip", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public CommonIPNetmask [] [] [] Endget_white_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPNetmask [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_system_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
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
	// remove_all_applications
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_all_applications(
		string [] profile_names
	) {
		this.Invoke("remove_all_applications", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_applications(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_applications", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_applications(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_dns_query_vectors
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_all_dns_query_vectors(
		string [] profile_names,
		string [] [] dnses
	) {
		this.Invoke("remove_all_dns_query_vectors", new object [] {
				profile_names,
				dnses});

	}
	public System.IAsyncResult Beginremove_all_dns_query_vectors(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_dns_query_vectors", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public void Endremove_all_dns_query_vectors(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_dos_networks
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_all_dos_networks(
		string [] profile_names
	) {
		this.Invoke("remove_all_dos_networks", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_dos_networks(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_dos_networks", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_dos_networks(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_network_attack_vectors
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_all_network_attack_vectors(
		string [] profile_names,
		string [] [] networks
	) {
		this.Invoke("remove_all_network_attack_vectors", new object [] {
				profile_names,
				networks});

	}
	public System.IAsyncResult Beginremove_all_network_attack_vectors(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_network_attack_vectors", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public void Endremove_all_network_attack_vectors(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_protocol_dnses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_all_protocol_dnses(
		string [] profile_names
	) {
		this.Invoke("remove_all_protocol_dnses", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_protocol_dnses(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_protocol_dnses", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_protocol_dnses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_protocol_sips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_all_protocol_sips(
		string [] profile_names
	) {
		this.Invoke("remove_all_protocol_sips", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_protocol_sips(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_protocol_sips", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_protocol_sips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_sip_attack_vectors
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_all_sip_attack_vectors(
		string [] profile_names,
		string [] [] sips
	) {
		this.Invoke("remove_all_sip_attack_vectors", new object [] {
				profile_names,
				sips});

	}
	public System.IAsyncResult Beginremove_all_sip_attack_vectors(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_sip_attack_vectors", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public void Endremove_all_sip_attack_vectors(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_white_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_all_white_ips(
		string [] profile_names,
		string [] [] applications
	) {
		this.Invoke("remove_all_white_ips", new object [] {
				profile_names,
				applications});

	}
	public System.IAsyncResult Beginremove_all_white_ips(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_white_ips", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public void Endremove_all_white_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_application(
		string [] profile_names,
		string [] [] applications
	) {
		this.Invoke("remove_application", new object [] {
				profile_names,
				applications});

	}
	public System.IAsyncResult Beginremove_application(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_application", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public void Endremove_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_dns_query_vector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_dns_query_vector(
		string [] profile_names,
		string [] [] dnses,
		SecurityProfileDoSDNSQuery [] [] [] vectors
	) {
		this.Invoke("remove_dns_query_vector", new object [] {
				profile_names,
				dnses,
				vectors});

	}
	public System.IAsyncResult Beginremove_dns_query_vector(string [] profile_names,string [] [] dnses,SecurityProfileDoSDNSQuery [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_dns_query_vector", new object[] {
			profile_names,
			dnses,
			vectors}, callback, asyncState);
	}
	public void Endremove_dns_query_vector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_dos_network
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_dos_network(
		string [] profile_names,
		string [] [] networks
	) {
		this.Invoke("remove_dos_network", new object [] {
				profile_names,
				networks});

	}
	public System.IAsyncResult Beginremove_dos_network(string [] profile_names,string [] [] networks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_dos_network", new object[] {
			profile_names,
			networks}, callback, asyncState);
	}
	public void Endremove_dos_network(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_heavy_url_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_heavy_url_exclude(
		string [] profile_names,
		string [] [] applications,
		string [] [] [] urls
	) {
		this.Invoke("remove_heavy_url_exclude", new object [] {
				profile_names,
				applications,
				urls});

	}
	public System.IAsyncResult Beginremove_heavy_url_exclude(string [] profile_names,string [] [] applications,string [] [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_heavy_url_exclude", new object[] {
			profile_names,
			applications,
			urls}, callback, asyncState);
	}
	public void Endremove_heavy_url_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_heavy_url_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_heavy_url_include(
		string [] profile_names,
		string [] [] applications,
		string [] [] [] urls
	) {
		this.Invoke("remove_heavy_url_include", new object [] {
				profile_names,
				applications,
				urls});

	}
	public System.IAsyncResult Beginremove_heavy_url_include(string [] profile_names,string [] [] applications,string [] [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_heavy_url_include", new object[] {
			profile_names,
			applications,
			urls}, callback, asyncState);
	}
	public void Endremove_heavy_url_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_network_attack_vector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_network_attack_vector(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors
	) {
		this.Invoke("remove_network_attack_vector", new object [] {
				profile_names,
				networks,
				vectors});

	}
	public System.IAsyncResult Beginremove_network_attack_vector(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_network_attack_vector", new object[] {
			profile_names,
			networks,
			vectors}, callback, asyncState);
	}
	public void Endremove_network_attack_vector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_protocol_dns
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_protocol_dns(
		string [] profile_names,
		string [] [] dnses
	) {
		this.Invoke("remove_protocol_dns", new object [] {
				profile_names,
				dnses});

	}
	public System.IAsyncResult Beginremove_protocol_dns(string [] profile_names,string [] [] dnses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_protocol_dns", new object[] {
			profile_names,
			dnses}, callback, asyncState);
	}
	public void Endremove_protocol_dns(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_protocol_sip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_protocol_sip(
		string [] profile_names,
		string [] [] sips
	) {
		this.Invoke("remove_protocol_sip", new object [] {
				profile_names,
				sips});

	}
	public System.IAsyncResult Beginremove_protocol_sip(string [] profile_names,string [] [] sips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_protocol_sip", new object[] {
			profile_names,
			sips}, callback, asyncState);
	}
	public void Endremove_protocol_sip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_sip_attack_vector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_sip_attack_vector(
		string [] profile_names,
		string [] [] sips,
		SecurityProfileDoSSIPAttackVector [] [] [] vectors
	) {
		this.Invoke("remove_sip_attack_vector", new object [] {
				profile_names,
				sips,
				vectors});

	}
	public System.IAsyncResult Beginremove_sip_attack_vector(string [] profile_names,string [] [] sips,SecurityProfileDoSSIPAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_sip_attack_vector", new object[] {
			profile_names,
			sips,
			vectors}, callback, asyncState);
	}
	public void Endremove_sip_attack_vector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_white_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void remove_white_ip(
		string [] profile_names,
		string [] [] applications,
		CommonIPNetmask [] [] [] ip_netmasks
	) {
		this.Invoke("remove_white_ip", new object [] {
				profile_names,
				applications,
				ip_netmasks});

	}
	public System.IAsyncResult Beginremove_white_ip(string [] profile_names,string [] [] applications,CommonIPNetmask [] [] [] ip_netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_white_ip", new object[] {
			profile_names,
			applications,
			ip_netmasks}, callback, asyncState);
	}
	public void Endremove_white_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_heavy_url_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void replace_heavy_url_exclude(
		string [] profile_names,
		string [] [] applications,
		string [] [] [] urls
	) {
		this.Invoke("replace_heavy_url_exclude", new object [] {
				profile_names,
				applications,
				urls});

	}
	public System.IAsyncResult Beginreplace_heavy_url_exclude(string [] profile_names,string [] [] applications,string [] [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_heavy_url_exclude", new object[] {
			profile_names,
			applications,
			urls}, callback, asyncState);
	}
	public void Endreplace_heavy_url_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_heavy_url_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void replace_heavy_url_include(
		string [] profile_names,
		string [] [] applications,
		string [] [] [] urls
	) {
		this.Invoke("replace_heavy_url_include", new object [] {
				profile_names,
				applications,
				urls});

	}
	public System.IAsyncResult Beginreplace_heavy_url_include(string [] profile_names,string [] [] applications,string [] [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_heavy_url_include", new object[] {
			profile_names,
			applications,
			urls}, callback, asyncState);
	}
	public void Endreplace_heavy_url_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_dns_query_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void reset_dns_query_vector_statistics(
		string [] profile_names,
		string [] [] dnses,
		SecurityProfileDoSDNSQuery [] [] [] vectors
	) {
		this.Invoke("reset_dns_query_vector_statistics", new object [] {
				profile_names,
				dnses,
				vectors});

	}
	public System.IAsyncResult Beginreset_dns_query_vector_statistics(string [] profile_names,string [] [] dnses,SecurityProfileDoSDNSQuery [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_dns_query_vector_statistics", new object[] {
			profile_names,
			dnses,
			vectors}, callback, asyncState);
	}
	public void Endreset_dns_query_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_network_attack_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void reset_network_attack_vector_statistics(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors
	) {
		this.Invoke("reset_network_attack_vector_statistics", new object [] {
				profile_names,
				networks,
				vectors});

	}
	public System.IAsyncResult Beginreset_network_attack_vector_statistics(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_network_attack_vector_statistics", new object[] {
			profile_names,
			networks,
			vectors}, callback, asyncState);
	}
	public void Endreset_network_attack_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_sip_attack_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void reset_sip_attack_vector_statistics(
		string [] profile_names,
		string [] [] sips,
		SecurityProfileDoSSIPAttackVector [] [] [] vectors
	) {
		this.Invoke("reset_sip_attack_vector_statistics", new object [] {
				profile_names,
				sips,
				vectors});

	}
	public System.IAsyncResult Beginreset_sip_attack_vector_statistics(string [] profile_names,string [] [] sips,SecurityProfileDoSSIPAttackVector [] [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_sip_attack_vector_statistics", new object[] {
			profile_names,
			sips,
			vectors}, callback, asyncState);
	}
	public void Endreset_sip_attack_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_deescalation_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_deescalation_period(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_deescalation_period", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_deescalation_period(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_deescalation_period", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_deescalation_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
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
	// set_dns_query_vector_rate_increase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_dns_query_vector_rate_increase(
		string [] profile_names,
		string [] [] dnses,
		SecurityProfileDoSDNSQuery [] [] [] vectors,
		long [] [] [] values
	) {
		this.Invoke("set_dns_query_vector_rate_increase", new object [] {
				profile_names,
				dnses,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_dns_query_vector_rate_increase(string [] profile_names,string [] [] dnses,SecurityProfileDoSDNSQuery [] [] [] vectors,long [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_query_vector_rate_increase", new object[] {
			profile_names,
			dnses,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_dns_query_vector_rate_increase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_query_vector_rate_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_dns_query_vector_rate_threshold(
		string [] profile_names,
		string [] [] dnses,
		SecurityProfileDoSDNSQuery [] [] [] vectors,
		long [] [] [] values
	) {
		this.Invoke("set_dns_query_vector_rate_threshold", new object [] {
				profile_names,
				dnses,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_dns_query_vector_rate_threshold(string [] profile_names,string [] [] dnses,SecurityProfileDoSDNSQuery [] [] [] vectors,long [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_query_vector_rate_threshold", new object[] {
			profile_names,
			dnses,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_dns_query_vector_rate_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_escalation_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_escalation_period(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_escalation_period", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_escalation_period(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_escalation_period", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_escalation_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_heavy_url_automatic_detection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_heavy_url_automatic_detection_state(
		string [] profile_names,
		string [] [] applications,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_heavy_url_automatic_detection_state", new object [] {
				profile_names,
				applications,
				states});

	}
	public System.IAsyncResult Beginset_heavy_url_automatic_detection_state(string [] profile_names,string [] [] applications,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_heavy_url_automatic_detection_state", new object[] {
			profile_names,
			applications,
			states}, callback, asyncState);
	}
	public void Endset_heavy_url_automatic_detection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_heavy_url_latency_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_heavy_url_latency_threshold(
		string [] profile_names,
		string [] [] applications,
		long [] [] values
	) {
		this.Invoke("set_heavy_url_latency_threshold", new object [] {
				profile_names,
				applications,
				values});

	}
	public System.IAsyncResult Beginset_heavy_url_latency_threshold(string [] profile_names,string [] [] applications,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_heavy_url_latency_threshold", new object[] {
			profile_names,
			applications,
			values}, callback, asyncState);
	}
	public void Endset_heavy_url_latency_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_heavy_url_protection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_heavy_url_protection_state(
		string [] profile_names,
		string [] [] applications,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_heavy_url_protection_state", new object [] {
				profile_names,
				applications,
				states});

	}
	public System.IAsyncResult Beginset_heavy_url_protection_state(string [] profile_names,string [] [] applications,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_heavy_url_protection_state", new object[] {
			profile_names,
			applications,
			states}, callback, asyncState);
	}
	public void Endset_heavy_url_protection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_maximum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_ip_maximum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_ip_maximum_tps", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_ip_maximum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_maximum_tps", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_ip_maximum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_minimum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_ip_minimum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_ip_minimum_tps", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_ip_minimum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_minimum_tps", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_ip_minimum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_tps_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_ip_tps_increase_rate(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_ip_tps_increase_rate", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_ip_tps_increase_rate(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_tps_increase_rate", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_ip_tps_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_latency_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_latency_increase_rate(
		string [] profile_names,
		string [] [] applications,
		long [] [] values
	) {
		this.Invoke("set_latency_increase_rate", new object [] {
				profile_names,
				applications,
				values});

	}
	public System.IAsyncResult Beginset_latency_increase_rate(string [] profile_names,string [] [] applications,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_latency_increase_rate", new object[] {
			profile_names,
			applications,
			values}, callback, asyncState);
	}
	public void Endset_latency_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_latency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_maximum_latency(
		string [] profile_names,
		string [] [] applications,
		long [] [] values
	) {
		this.Invoke("set_maximum_latency", new object [] {
				profile_names,
				applications,
				values});

	}
	public System.IAsyncResult Beginset_maximum_latency(string [] profile_names,string [] [] applications,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_latency", new object[] {
			profile_names,
			applications,
			values}, callback, asyncState);
	}
	public void Endset_maximum_latency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_prevention_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_maximum_prevention_duration(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_maximum_prevention_duration", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_maximum_prevention_duration(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_prevention_duration", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_maximum_prevention_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_minimum_latency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_minimum_latency(
		string [] profile_names,
		string [] [] applications,
		long [] [] values
	) {
		this.Invoke("set_minimum_latency", new object [] {
				profile_names,
				applications,
				values});

	}
	public System.IAsyncResult Beginset_minimum_latency(string [] profile_names,string [] [] applications,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_minimum_latency", new object[] {
			profile_names,
			applications,
			values}, callback, asyncState);
	}
	public void Endset_minimum_latency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_attack_vector_auto_blacklisting_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_network_attack_vector_auto_blacklisting_state(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors,
		CommonEnabledState [] [] [] states
	) {
		this.Invoke("set_network_attack_vector_auto_blacklisting_state", new object [] {
				profile_names,
				networks,
				vectors,
				states});

	}
	public System.IAsyncResult Beginset_network_attack_vector_auto_blacklisting_state(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors,CommonEnabledState [] [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_attack_vector_auto_blacklisting_state", new object[] {
			profile_names,
			networks,
			vectors,
			states}, callback, asyncState);
	}
	public void Endset_network_attack_vector_auto_blacklisting_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_attack_vector_blacklist_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_network_attack_vector_blacklist_category(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors,
		string [] [] [] values
	) {
		this.Invoke("set_network_attack_vector_blacklist_category", new object [] {
				profile_names,
				networks,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_network_attack_vector_blacklist_category(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors,string [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_attack_vector_blacklist_category", new object[] {
			profile_names,
			networks,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_network_attack_vector_blacklist_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_attack_vector_blacklist_detection_seconds
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_network_attack_vector_blacklist_detection_seconds(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors,
		long [] [] [] values
	) {
		this.Invoke("set_network_attack_vector_blacklist_detection_seconds", new object [] {
				profile_names,
				networks,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_network_attack_vector_blacklist_detection_seconds(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors,long [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_attack_vector_blacklist_detection_seconds", new object[] {
			profile_names,
			networks,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_network_attack_vector_blacklist_detection_seconds(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_attack_vector_blacklist_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_network_attack_vector_blacklist_duration(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors,
		long [] [] [] values
	) {
		this.Invoke("set_network_attack_vector_blacklist_duration", new object [] {
				profile_names,
				networks,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_network_attack_vector_blacklist_duration(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors,long [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_attack_vector_blacklist_duration", new object[] {
			profile_names,
			networks,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_network_attack_vector_blacklist_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_attack_vector_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_network_attack_vector_rate_limit(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors,
		long [] [] [] values
	) {
		this.Invoke("set_network_attack_vector_rate_limit", new object [] {
				profile_names,
				networks,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_network_attack_vector_rate_limit(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors,long [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_attack_vector_rate_limit", new object[] {
			profile_names,
			networks,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_network_attack_vector_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_attack_vector_rate_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_network_attack_vector_rate_threshold(
		string [] profile_names,
		string [] [] networks,
		SecurityProfileDoSNetworkAttackVector [] [] [] vectors,
		long [] [] [] values
	) {
		this.Invoke("set_network_attack_vector_rate_threshold", new object [] {
				profile_names,
				networks,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_network_attack_vector_rate_threshold(string [] profile_names,string [] [] networks,SecurityProfileDoSNetworkAttackVector [] [] [] vectors,long [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_attack_vector_rate_threshold", new object[] {
			profile_names,
			networks,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_network_attack_vector_rate_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_operation_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_operation_mode(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		SecurityProfileDoSOperationMode [] [] modes
	) {
		this.Invoke("set_operation_mode", new object [] {
				profile_names,
				applications,
				anomaly,
				modes});

	}
	public System.IAsyncResult Beginset_operation_mode(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,SecurityProfileDoSOperationMode [] [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_operation_mode", new object[] {
			profile_names,
			applications,
			anomaly,
			modes}, callback, asyncState);
	}
	public void Endset_operation_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_error_attack_detection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_protocol_dns_error_attack_detection_state(
		string [] profile_names,
		string [] [] dnses,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_dns_error_attack_detection_state", new object [] {
				profile_names,
				dnses,
				states});

	}
	public System.IAsyncResult Beginset_protocol_dns_error_attack_detection_state(string [] profile_names,string [] [] dnses,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_error_attack_detection_state", new object[] {
			profile_names,
			dnses,
			states}, callback, asyncState);
	}
	public void Endset_protocol_dns_error_attack_detection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_dns_error_attack_rate_increase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_protocol_dns_error_attack_rate_increase(
		string [] profile_names,
		string [] [] dnses,
		long [] [] values
	) {
		this.Invoke("set_protocol_dns_error_attack_rate_increase", new object [] {
				profile_names,
				dnses,
				values});

	}
	public System.IAsyncResult Beginset_protocol_dns_error_attack_rate_increase(string [] profile_names,string [] [] dnses,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_dns_error_attack_rate_increase", new object[] {
			profile_names,
			dnses,
			values}, callback, asyncState);
	}
	public void Endset_protocol_dns_error_attack_rate_increase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_error_attack_detection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_protocol_sip_error_attack_detection_state(
		string [] profile_names,
		string [] [] sips,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_protocol_sip_error_attack_detection_state", new object [] {
				profile_names,
				sips,
				states});

	}
	public System.IAsyncResult Beginset_protocol_sip_error_attack_detection_state(string [] profile_names,string [] [] sips,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_error_attack_detection_state", new object[] {
			profile_names,
			sips,
			states}, callback, asyncState);
	}
	public void Endset_protocol_sip_error_attack_detection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_error_attack_rate_increase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_protocol_sip_error_attack_rate_increase(
		string [] profile_names,
		string [] [] sips,
		long [] [] values
	) {
		this.Invoke("set_protocol_sip_error_attack_rate_increase", new object [] {
				profile_names,
				sips,
				values});

	}
	public System.IAsyncResult Beginset_protocol_sip_error_attack_rate_increase(string [] profile_names,string [] [] sips,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_error_attack_rate_increase", new object[] {
			profile_names,
			sips,
			values}, callback, asyncState);
	}
	public void Endset_protocol_sip_error_attack_rate_increase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_sip_error_attack_rate_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_protocol_sip_error_attack_rate_threshold(
		string [] profile_names,
		string [] [] sips,
		long [] [] values
	) {
		this.Invoke("set_protocol_sip_error_attack_rate_threshold", new object [] {
				profile_names,
				sips,
				values});

	}
	public System.IAsyncResult Beginset_protocol_sip_error_attack_rate_threshold(string [] profile_names,string [] [] sips,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_sip_error_attack_rate_threshold", new object[] {
			profile_names,
			sips,
			values}, callback, asyncState);
	}
	public void Endset_protocol_sip_error_attack_rate_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sip_attack_vector_rate_increase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_sip_attack_vector_rate_increase(
		string [] profile_names,
		string [] [] sips,
		SecurityProfileDoSSIPAttackVector [] [] [] vectors,
		long [] [] [] values
	) {
		this.Invoke("set_sip_attack_vector_rate_increase", new object [] {
				profile_names,
				sips,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_sip_attack_vector_rate_increase(string [] profile_names,string [] [] sips,SecurityProfileDoSSIPAttackVector [] [] [] vectors,long [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sip_attack_vector_rate_increase", new object[] {
			profile_names,
			sips,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_sip_attack_vector_rate_increase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sip_attack_vector_rate_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_sip_attack_vector_rate_threshold(
		string [] profile_names,
		string [] [] sips,
		SecurityProfileDoSSIPAttackVector [] [] [] vectors,
		long [] [] [] values
	) {
		this.Invoke("set_sip_attack_vector_rate_threshold", new object [] {
				profile_names,
				sips,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_sip_attack_vector_rate_threshold(string [] profile_names,string [] [] sips,SecurityProfileDoSSIPAttackVector [] [] [] vectors,long [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sip_attack_vector_rate_threshold", new object[] {
			profile_names,
			sips,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_sip_attack_vector_rate_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_site_wide_client_side_integrity_defense_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_site_wide_client_side_integrity_defense_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_site_wide_client_side_integrity_defense_state", new object [] {
				profile_names,
				applications,
				anomaly,
				states});

	}
	public System.IAsyncResult Beginset_site_wide_client_side_integrity_defense_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_site_wide_client_side_integrity_defense_state", new object[] {
			profile_names,
			applications,
			anomaly,
			states}, callback, asyncState);
	}
	public void Endset_site_wide_client_side_integrity_defense_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_site_wide_maximum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_site_wide_maximum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_site_wide_maximum_tps", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_site_wide_maximum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_site_wide_maximum_tps", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_site_wide_maximum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_site_wide_minimum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_site_wide_minimum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_site_wide_minimum_tps", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_site_wide_minimum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_site_wide_minimum_tps", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_site_wide_minimum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_site_wide_rate_limiting_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_site_wide_rate_limiting_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_site_wide_rate_limiting_state", new object [] {
				profile_names,
				applications,
				anomaly,
				states});

	}
	public System.IAsyncResult Beginset_site_wide_rate_limiting_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_site_wide_rate_limiting_state", new object[] {
			profile_names,
			applications,
			anomaly,
			states}, callback, asyncState);
	}
	public void Endset_site_wide_rate_limiting_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_site_wide_tps_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_site_wide_tps_increase_rate(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_site_wide_tps_increase_rate", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_site_wide_tps_increase_rate(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_site_wide_tps_increase_rate", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_site_wide_tps_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_ip_based_client_side_integrity_defense_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_source_ip_based_client_side_integrity_defense_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_source_ip_based_client_side_integrity_defense_state", new object [] {
				profile_names,
				applications,
				anomaly,
				states});

	}
	public System.IAsyncResult Beginset_source_ip_based_client_side_integrity_defense_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_ip_based_client_side_integrity_defense_state", new object[] {
			profile_names,
			applications,
			anomaly,
			states}, callback, asyncState);
	}
	public void Endset_source_ip_based_client_side_integrity_defense_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_ip_based_rate_limiting_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_source_ip_based_rate_limiting_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_source_ip_based_rate_limiting_state", new object [] {
				profile_names,
				applications,
				anomaly,
				states});

	}
	public System.IAsyncResult Beginset_source_ip_based_rate_limiting_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_ip_based_rate_limiting_state", new object[] {
			profile_names,
			applications,
			anomaly,
			states}, callback, asyncState);
	}
	public void Endset_source_ip_based_rate_limiting_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_dump_maximum_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_tcp_dump_maximum_duration(
		string [] profile_names,
		string [] [] applications,
		long [] [] values
	) {
		this.Invoke("set_tcp_dump_maximum_duration", new object [] {
				profile_names,
				applications,
				values});

	}
	public System.IAsyncResult Beginset_tcp_dump_maximum_duration(string [] profile_names,string [] [] applications,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_dump_maximum_duration", new object[] {
			profile_names,
			applications,
			values}, callback, asyncState);
	}
	public void Endset_tcp_dump_maximum_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_dump_maximum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_tcp_dump_maximum_size(
		string [] profile_names,
		string [] [] applications,
		long [] [] values
	) {
		this.Invoke("set_tcp_dump_maximum_size", new object [] {
				profile_names,
				applications,
				values});

	}
	public System.IAsyncResult Beginset_tcp_dump_maximum_size(string [] profile_names,string [] [] applications,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_dump_maximum_size", new object[] {
			profile_names,
			applications,
			values}, callback, asyncState);
	}
	public void Endset_tcp_dump_maximum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_dump_record_traffic_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_tcp_dump_record_traffic_state(
		string [] profile_names,
		string [] [] applications,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_tcp_dump_record_traffic_state", new object [] {
				profile_names,
				applications,
				states});

	}
	public System.IAsyncResult Beginset_tcp_dump_record_traffic_state(string [] profile_names,string [] [] applications,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_dump_record_traffic_state", new object[] {
			profile_names,
			applications,
			states}, callback, asyncState);
	}
	public void Endset_tcp_dump_record_traffic_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_dump_repetition_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_tcp_dump_repetition_interval(
		string [] profile_names,
		string [] [] applications,
		long [] [] values
	) {
		this.Invoke("set_tcp_dump_repetition_interval", new object [] {
				profile_names,
				applications,
				values});

	}
	public System.IAsyncResult Beginset_tcp_dump_repetition_interval(string [] profile_names,string [] [] applications,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_dump_repetition_interval", new object[] {
			profile_names,
			applications,
			values}, callback, asyncState);
	}
	public void Endset_tcp_dump_repetition_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trigger_irule_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_trigger_irule_state(
		string [] profile_names,
		string [] [] applications,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_trigger_irule_state", new object [] {
				profile_names,
				applications,
				states});

	}
	public System.IAsyncResult Beginset_trigger_irule_state(string [] profile_names,string [] [] applications,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trigger_irule_state", new object[] {
			profile_names,
			applications,
			states}, callback, asyncState);
	}
	public void Endset_trigger_irule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_url_based_client_side_integrity_defense_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_url_based_client_side_integrity_defense_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_url_based_client_side_integrity_defense_state", new object [] {
				profile_names,
				applications,
				anomaly,
				states});

	}
	public System.IAsyncResult Beginset_url_based_client_side_integrity_defense_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_url_based_client_side_integrity_defense_state", new object[] {
			profile_names,
			applications,
			anomaly,
			states}, callback, asyncState);
	}
	public void Endset_url_based_client_side_integrity_defense_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_url_based_rate_limiting_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_url_based_rate_limiting_state(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_url_based_rate_limiting_state", new object [] {
				profile_names,
				applications,
				anomaly,
				states});

	}
	public System.IAsyncResult Beginset_url_based_rate_limiting_state(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_url_based_rate_limiting_state", new object[] {
			profile_names,
			applications,
			anomaly,
			states}, callback, asyncState);
	}
	public void Endset_url_based_rate_limiting_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_url_maximum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_url_maximum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_url_maximum_tps", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_url_maximum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_url_maximum_tps", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_url_maximum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_url_minimum_tps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_url_minimum_tps(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_url_minimum_tps", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_url_minimum_tps(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_url_minimum_tps", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_url_minimum_tps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_url_tps_increase_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileDoS", 
		RequestNamespace="urn:iControl:Security/ProfileDoS", ResponseNamespace="urn:iControl:Security/ProfileDoS")]
	public void set_url_tps_increase_rate(
		string [] profile_names,
		string [] [] applications,
		SecurityProfileDoSAnomaly anomaly,
		long [] [] values
	) {
		this.Invoke("set_url_tps_increase_rate", new object [] {
				profile_names,
				applications,
				anomaly,
				values});

	}
	public System.IAsyncResult Beginset_url_tps_increase_rate(string [] profile_names,string [] [] applications,SecurityProfileDoSAnomaly anomaly,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_url_tps_increase_rate", new object[] {
			profile_names,
			applications,
			anomaly,
			values}, callback, asyncState);
	}
	public void Endset_url_tps_increase_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.Anomaly", Namespace = "urn:iControl")]
	public enum SecurityProfileDoSAnomaly
	{
		ANOMALY_TPS_BASED,
		ANOMALY_LATENCY_BASED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.DNSQuery", Namespace = "urn:iControl")]
	public enum SecurityProfileDoSDNSQuery
	{
		DNS_QUERY_UNKNOWN,
		DNS_QUERY_A,
		DNS_QUERY_PTR,
		DNS_QUERY_NS,
		DNS_QUERY_SOA,
		DNS_QUERY_CNAME,
		DNS_QUERY_MX,
		DNS_QUERY_AAAA,
		DNS_QUERY_TXT,
		DNS_QUERY_SRV,
		DNS_QUERY_AXFR,
		DNS_QUERY_IXFR,
		DNS_QUERY_ANY,
		DNS_QUERY_OTHER,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.NetworkAttackVector", Namespace = "urn:iControl")]
	public enum SecurityProfileDoSNetworkAttackVector
	{
		NETWORK_ATTACK_VECTOR_UNKNOWN,
		NETWORK_ATTACK_VECTOR_TCP_SYN_FLOOD,
		NETWORK_ATTACK_VECTOR_TCP_RST_FLOOD,
		NETWORK_ATTACK_VECTOR_UDP_FLOOD,
		NETWORK_ATTACK_VECTOR_IP_OPT_FRAMES,
		NETWORK_ATTACK_VECTOR_IP_FRAG_FLOOD,
		NETWORK_ATTACK_VECTOR_TOO_MANY_EXT_HDRS,
		NETWORK_ATTACK_VECTOR_EXT_HDR_TOO_LARGE,
		NETWORK_ATTACK_VECTOR_IP_LOW_TTL,
		NETWORK_ATTACK_VECTOR_HOP_CNT_LOW,
		NETWORK_ATTACK_VECTOR_IPV6_EXT_HDR_FRAMES,
		NETWORK_ATTACK_VECTOR_IPV6_FRAG_FLOOD,
		NETWORK_ATTACK_VECTOR_UNK_TCP_OPT_TYPE,
		NETWORK_ATTACK_VECTOR_OPT_PRESENT_WITH_ILLEGAL_LEN,
		NETWORK_ATTACK_VECTOR_TCP_OPT_OVERRUNS_TCP_HDR,
		NETWORK_ATTACK_VECTOR_TCP_SYNACK_FLOOD,
		NETWORK_ATTACK_VECTOR_ICMPV4_FLOOD,
		NETWORK_ATTACK_VECTOR_ICMP_FRAG,
		NETWORK_ATTACK_VECTOR_ICMPV6_FLOOD,
		NETWORK_ATTACK_VECTOR_HOST_UNREACHABLE,
		NETWORK_ATTACK_VECTOR_TIDCMP,
		NETWORK_ATTACK_VECTOR_SWEEP,
		NETWORK_ATTACK_VECTOR_TCP_BAD_URGENT,
		NETWORK_ATTACK_VECTOR_TCP_WINDOW_SIZE,
		NETWORK_ATTACK_VECTOR_TCP_SYN_OVERSIZE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.OperationMode", Namespace = "urn:iControl")]
	public enum SecurityProfileDoSOperationMode
	{
		OPERATION_MODE_UNKNOWN,
		OPERATION_MODE_OFF,
		OPERATION_MODE_TRANSPARENT,
		OPERATION_MODE_BLOCKING,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.SIPAttackVector", Namespace = "urn:iControl")]
	public enum SecurityProfileDoSSIPAttackVector
	{
		SIP_ATTACK_VECTOR_UNKNOWN,
		SIP_ATTACK_VECTOR_INVITE,
		SIP_ATTACK_VECTOR_ACK,
		SIP_ATTACK_VECTOR_OPTIONS,
		SIP_ATTACK_VECTOR_BYE,
		SIP_ATTACK_VECTOR_CANCEL,
		SIP_ATTACK_VECTOR_REGISTER,
		SIP_ATTACK_VECTOR_PUBLISH,
		SIP_ATTACK_VECTOR_NOTIFY,
		SIP_ATTACK_VECTOR_SUBSCRIBE,
		SIP_ATTACK_VECTOR_MESSAGE,
		SIP_ATTACK_VECTOR_PRACK,
		SIP_ATTACK_VECTOR_OTHER,
		SIP_ATTACK_VECTOR_MALFORMED,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.DNSQueryVectorStatisticEntry", Namespace = "urn:iControl")]
	public partial class SecurityProfileDoSDNSQueryVectorStatisticEntry
	{
		private SecurityProfileDoSDNSQuery queryField;
		public SecurityProfileDoSDNSQuery query
		{
			get { return this.queryField; }
			set { this.queryField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.DNSQueryVectorStatistics", Namespace = "urn:iControl")]
	public partial class SecurityProfileDoSDNSQueryVectorStatistics
	{
		private SecurityProfileDoSDNSQueryVectorStatisticEntry [] statisticsField;
		public SecurityProfileDoSDNSQueryVectorStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.NetworkAttackVectorStatisticEntry", Namespace = "urn:iControl")]
	public partial class SecurityProfileDoSNetworkAttackVectorStatisticEntry
	{
		private SecurityProfileDoSNetworkAttackVector vector_nameField;
		public SecurityProfileDoSNetworkAttackVector vector_name
		{
			get { return this.vector_nameField; }
			set { this.vector_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.NetworkAttackVectorStatistics", Namespace = "urn:iControl")]
	public partial class SecurityProfileDoSNetworkAttackVectorStatistics
	{
		private SecurityProfileDoSNetworkAttackVectorStatisticEntry [] statisticsField;
		public SecurityProfileDoSNetworkAttackVectorStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.SIPAttackVectorStatisticEntry", Namespace = "urn:iControl")]
	public partial class SecurityProfileDoSSIPAttackVectorStatisticEntry
	{
		private SecurityProfileDoSSIPAttackVector vector_nameField;
		public SecurityProfileDoSSIPAttackVector vector_name
		{
			get { return this.vector_nameField; }
			set { this.vector_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileDoS.SIPAttackVectorStatistics", Namespace = "urn:iControl")]
	public partial class SecurityProfileDoSSIPAttackVectorStatistics
	{
		private SecurityProfileDoSSIPAttackVectorStatisticEntry [] statisticsField;
		public SecurityProfileDoSSIPAttackVectorStatisticEntry [] statistics
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
