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
	[System.Web.Services.WebServiceBindingAttribute(Name="WebAccelerator.ApplicationsBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(WebAcceleratorApplicationsApplicationStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(WebAcceleratorApplicationsApplicationStatisticsByVirtual))]
	public partial class WebAcceleratorApplications : iControlInterface {
		public WebAcceleratorApplications() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void add_host(
		string [] applications,
		string [] [] hosts
	) {
		this.Invoke("add_host", new object [] {
				applications,
				hosts});

	}
	public System.IAsyncResult Beginadd_host(string [] applications,string [] [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_host", new object[] {
			applications,
			hosts}, callback, asyncState);
	}
	public void Endadd_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long create(
		string name,
		string description,
		string local_policy,
		string remote_policy,
		string [] requested_hosts
	) {
		object [] results = this.Invoke("create", new object [] {
				name,
				description,
				local_policy,
				remote_policy,
				requested_hosts});
		return ((long)(results[0]));
	}
	public System.IAsyncResult Begincreate(string name,string description,string local_policy,string remote_policy,string [] requested_hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			name,
			description,
			local_policy,
			remote_policy,
			requested_hosts}, callback, asyncState);
	}
	public long Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// create_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void create_v2(
		string [] names,
		string [] local_policies,
		string [] remote_policies,
		string [] [] requested_hosts
	) {
		this.Invoke("create_v2", new object [] {
				names,
				local_policies,
				remote_policies,
				requested_hosts});

	}
	public System.IAsyncResult Begincreate_v2(string [] names,string [] local_policies,string [] remote_policies,string [] [] requested_hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_v2", new object[] {
			names,
			local_policies,
			remote_policies,
			requested_hosts}, callback, asyncState);
	}
	public void Endcreate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_applications
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void delete_all_applications(

	) {
		this.Invoke("delete_all_applications", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_applications(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_applications", new object[0], callback, asyncState);
	}
	public void Enddelete_all_applications(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void delete_application(
		string [] applications
	) {
		this.Invoke("delete_application", new object [] {
				applications});

	}
	public System.IAsyncResult Begindelete_application(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_application", new object[] {
			applications}, callback, asyncState);
	}
	public void Enddelete_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public WebAcceleratorApplicationsApplicationStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((WebAcceleratorApplicationsApplicationStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public WebAcceleratorApplicationsApplicationStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((WebAcceleratorApplicationsApplicationStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_code(
		string [] applications
	) {
		object [] results = this.Invoke("get_code", new object [] {
				applications});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_code(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_code", new object[] {
			applications}, callback, asyncState);
	}
	public long [] Endget_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_content_expiration_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] get_content_expiration_time(
		string [] applications
	) {
		object [] results = this.Invoke("get_content_expiration_time", new object [] {
				applications});
		return ((CommonTimeStamp [])(results[0]));
	}
	public System.IAsyncResult Beginget_content_expiration_time(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_content_expiration_time", new object[] {
			applications}, callback, asyncState);
	}
	public CommonTimeStamp [] Endget_content_expiration_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] applications
	) {
		object [] results = this.Invoke("get_description", new object [] {
				applications});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			applications}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_etag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public WebAcceleratorApplicationsETag [] get_etag(
		string [] applications
	) {
		object [] results = this.Invoke("get_etag", new object [] {
				applications});
		return ((WebAcceleratorApplicationsETag [])(results[0]));
	}
	public System.IAsyncResult Beginget_etag(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_etag", new object[] {
			applications}, callback, asyncState);
	}
	public WebAcceleratorApplicationsETag [] Endget_etag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((WebAcceleratorApplicationsETag [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_host(
		string [] applications
	) {
		object [] results = this.Invoke("get_host", new object [] {
				applications});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_host(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_host", new object[] {
			applications}, callback, asyncState);
	}
	public string [] [] Endget_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_host_http_subdomain_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_host_http_subdomain_count(
		string [] applications,
		string [] [] hosts
	) {
		object [] results = this.Invoke("get_host_http_subdomain_count", new object [] {
				applications,
				hosts});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_host_http_subdomain_count(string [] applications,string [] [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_host_http_subdomain_count", new object[] {
			applications,
			hosts}, callback, asyncState);
	}
	public long [] [] Endget_host_http_subdomain_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_host_https_subdomain_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_host_https_subdomain_count(
		string [] applications,
		string [] [] hosts
	) {
		object [] results = this.Invoke("get_host_https_subdomain_count", new object [] {
				applications,
				hosts});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_host_https_subdomain_count(string [] applications,string [] [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_host_https_subdomain_count", new object[] {
			applications,
			hosts}, callback, asyncState);
	}
	public long [] [] Endget_host_https_subdomain_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_host_subdomain_prefixes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_host_subdomain_prefixes(
		string [] applications,
		string [] [] hosts
	) {
		object [] results = this.Invoke("get_host_subdomain_prefixes", new object [] {
				applications,
				hosts});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_host_subdomain_prefixes(string [] applications,string [] [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_host_subdomain_prefixes", new object[] {
			applications,
			hosts}, callback, asyncState);
	}
	public string [] [] Endget_host_subdomain_prefixes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ibr_default_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ibr_default_lifetime(
		string [] applications
	) {
		object [] results = this.Invoke("get_ibr_default_lifetime", new object [] {
				applications});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ibr_default_lifetime(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ibr_default_lifetime", new object[] {
			applications}, callback, asyncState);
	}
	public long [] Endget_ibr_default_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ibr_prefix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ibr_prefix(
		string [] applications
	) {
		object [] results = this.Invoke("get_ibr_prefix", new object [] {
				applications});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ibr_prefix(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ibr_prefix", new object[] {
			applications}, callback, asyncState);
	}
	public string [] Endget_ibr_prefix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_info_header
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public WebAcceleratorApplicationsInfoHeader [] get_info_header(
		string [] applications
	) {
		object [] results = this.Invoke("get_info_header", new object [] {
				applications});
		return ((WebAcceleratorApplicationsInfoHeader [])(results[0]));
	}
	public System.IAsyncResult Beginget_info_header(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_info_header", new object[] {
			applications}, callback, asyncState);
	}
	public WebAcceleratorApplicationsInfoHeader [] Endget_info_header(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((WebAcceleratorApplicationsInfoHeader [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
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
	// get_local_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_local_policy(
		string [] applications
	) {
		object [] results = this.Invoke("get_local_policy", new object [] {
				applications});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_local_policy(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_local_policy", new object[] {
			applications}, callback, asyncState);
	}
	public string [] Endget_local_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_etag_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_maximum_etag_cache_size(
		string [] applications
	) {
		object [] results = this.Invoke("get_maximum_etag_cache_size", new object [] {
				applications});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_etag_cache_size(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_etag_cache_size", new object[] {
			applications}, callback, asyncState);
	}
	public long [] Endget_maximum_etag_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_performance_monitor_data_retention_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_performance_monitor_data_retention_period(
		string [] applications
	) {
		object [] results = this.Invoke("get_performance_monitor_data_retention_period", new object [] {
				applications});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_performance_monitor_data_retention_period(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_performance_monitor_data_retention_period", new object[] {
			applications}, callback, asyncState);
	}
	public long [] Endget_performance_monitor_data_retention_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_performance_monitor_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_performance_monitor_state(
		string [] applications
	) {
		object [] results = this.Invoke("get_performance_monitor_state", new object [] {
				applications});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_performance_monitor_state(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_performance_monitor_state", new object[] {
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_performance_monitor_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_remote_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_remote_policy(
		string [] applications
	) {
		object [] results = this.Invoke("get_remote_policy", new object [] {
				applications});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_remote_policy(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_remote_policy", new object[] {
			applications}, callback, asyncState);
	}
	public string [] Endget_remote_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public WebAcceleratorApplicationsApplicationStatistics get_statistics(
		string [] applications
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				applications});
		return ((WebAcceleratorApplicationsApplicationStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			applications}, callback, asyncState);
	}
	public WebAcceleratorApplicationsApplicationStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((WebAcceleratorApplicationsApplicationStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public WebAcceleratorApplicationsApplicationStatisticsByVirtual get_statistics_by_virtual(
		string [] applications,
		string [] [] virtuals
	) {
		object [] results = this.Invoke("get_statistics_by_virtual", new object [] {
				applications,
				virtuals});
		return ((WebAcceleratorApplicationsApplicationStatisticsByVirtual)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics_by_virtual(string [] applications,string [] [] virtuals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics_by_virtual", new object[] {
			applications,
			virtuals}, callback, asyncState);
	}
	public WebAcceleratorApplicationsApplicationStatisticsByVirtual Endget_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((WebAcceleratorApplicationsApplicationStatisticsByVirtual)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unmapped_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_unmapped_state(
		string [] applications
	) {
		object [] results = this.Invoke("get_unmapped_state", new object [] {
				applications});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_unmapped_state(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unmapped_state", new object[] {
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_unmapped_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
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
	// invalidate_content
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void invalidate_content(
		string [] applications
	) {
		this.Invoke("invalidate_content", new object [] {
				applications});

	}
	public System.IAsyncResult Begininvalidate_content(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("invalidate_content", new object[] {
			applications}, callback, asyncState);
	}
	public void Endinvalidate_content(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// is_predefined
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_predefined(
		string [] applications
	) {
		object [] results = this.Invoke("is_predefined", new object [] {
				applications});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_predefined(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_predefined", new object[] {
			applications}, callback, asyncState);
	}
	public bool [] Endis_predefined(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_hosts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void remove_all_hosts(
		string [] applications
	) {
		this.Invoke("remove_all_hosts", new object [] {
				applications});

	}
	public System.IAsyncResult Beginremove_all_hosts(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_hosts", new object[] {
			applications}, callback, asyncState);
	}
	public void Endremove_all_hosts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void remove_host(
		string [] applications,
		string [] [] hosts
	) {
		this.Invoke("remove_host", new object [] {
				applications,
				hosts});

	}
	public System.IAsyncResult Beginremove_host(string [] applications,string [] [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_host", new object[] {
			applications,
			hosts}, callback, asyncState);
	}
	public void Endremove_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void reset_statistics(
		string [] applications
	) {
		this.Invoke("reset_statistics", new object [] {
				applications});

	}
	public System.IAsyncResult Beginreset_statistics(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			applications}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void reset_statistics_by_virtual(
		string [] applications,
		string [] [] virtuals
	) {
		this.Invoke("reset_statistics_by_virtual", new object [] {
				applications,
				virtuals});

	}
	public System.IAsyncResult Beginreset_statistics_by_virtual(string [] applications,string [] [] virtuals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics_by_virtual", new object[] {
			applications,
			virtuals}, callback, asyncState);
	}
	public void Endreset_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_code(
		string [] applications,
		long [] codes
	) {
		this.Invoke("set_code", new object [] {
				applications,
				codes});

	}
	public System.IAsyncResult Beginset_code(string [] applications,long [] codes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_code", new object[] {
			applications,
			codes}, callback, asyncState);
	}
	public void Endset_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_description(
		string [] applications,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				applications,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] applications,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			applications,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_etag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_etag(
		string [] applications,
		WebAcceleratorApplicationsETag [] types
	) {
		this.Invoke("set_etag", new object [] {
				applications,
				types});

	}
	public System.IAsyncResult Beginset_etag(string [] applications,WebAcceleratorApplicationsETag [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_etag", new object[] {
			applications,
			types}, callback, asyncState);
	}
	public void Endset_etag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_host_http_subdomain_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_host_http_subdomain_count(
		string [] applications,
		string [] [] hosts,
		long [] [] subdomains
	) {
		this.Invoke("set_host_http_subdomain_count", new object [] {
				applications,
				hosts,
				subdomains});

	}
	public System.IAsyncResult Beginset_host_http_subdomain_count(string [] applications,string [] [] hosts,long [] [] subdomains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_host_http_subdomain_count", new object[] {
			applications,
			hosts,
			subdomains}, callback, asyncState);
	}
	public void Endset_host_http_subdomain_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_host_https_subdomain_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_host_https_subdomain_count(
		string [] applications,
		string [] [] hosts,
		long [] [] subdomains
	) {
		this.Invoke("set_host_https_subdomain_count", new object [] {
				applications,
				hosts,
				subdomains});

	}
	public System.IAsyncResult Beginset_host_https_subdomain_count(string [] applications,string [] [] hosts,long [] [] subdomains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_host_https_subdomain_count", new object[] {
			applications,
			hosts,
			subdomains}, callback, asyncState);
	}
	public void Endset_host_https_subdomain_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_host_subdomain_prefixes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_host_subdomain_prefixes(
		string [] applications,
		string [] [] hosts,
		string [] [] prefixes
	) {
		this.Invoke("set_host_subdomain_prefixes", new object [] {
				applications,
				hosts,
				prefixes});

	}
	public System.IAsyncResult Beginset_host_subdomain_prefixes(string [] applications,string [] [] hosts,string [] [] prefixes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_host_subdomain_prefixes", new object[] {
			applications,
			hosts,
			prefixes}, callback, asyncState);
	}
	public void Endset_host_subdomain_prefixes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ibr_default_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_ibr_default_lifetime(
		string [] applications,
		long [] lifetimes
	) {
		this.Invoke("set_ibr_default_lifetime", new object [] {
				applications,
				lifetimes});

	}
	public System.IAsyncResult Beginset_ibr_default_lifetime(string [] applications,long [] lifetimes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ibr_default_lifetime", new object[] {
			applications,
			lifetimes}, callback, asyncState);
	}
	public void Endset_ibr_default_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ibr_prefix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_ibr_prefix(
		string [] applications,
		string [] prefixes
	) {
		this.Invoke("set_ibr_prefix", new object [] {
				applications,
				prefixes});

	}
	public System.IAsyncResult Beginset_ibr_prefix(string [] applications,string [] prefixes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ibr_prefix", new object[] {
			applications,
			prefixes}, callback, asyncState);
	}
	public void Endset_ibr_prefix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_info_header
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_info_header(
		string [] applications,
		WebAcceleratorApplicationsInfoHeader [] types
	) {
		this.Invoke("set_info_header", new object [] {
				applications,
				types});

	}
	public System.IAsyncResult Beginset_info_header(string [] applications,WebAcceleratorApplicationsInfoHeader [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_info_header", new object[] {
			applications,
			types}, callback, asyncState);
	}
	public void Endset_info_header(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_local_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_local_policy(
		string [] applications,
		string [] policies
	) {
		this.Invoke("set_local_policy", new object [] {
				applications,
				policies});

	}
	public System.IAsyncResult Beginset_local_policy(string [] applications,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_local_policy", new object[] {
			applications,
			policies}, callback, asyncState);
	}
	public void Endset_local_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_etag_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_maximum_etag_cache_size(
		string [] applications,
		long [] cache_sizes
	) {
		this.Invoke("set_maximum_etag_cache_size", new object [] {
				applications,
				cache_sizes});

	}
	public System.IAsyncResult Beginset_maximum_etag_cache_size(string [] applications,long [] cache_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_etag_cache_size", new object[] {
			applications,
			cache_sizes}, callback, asyncState);
	}
	public void Endset_maximum_etag_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_performance_monitor_data_retention_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_performance_monitor_data_retention_period(
		string [] applications,
		long [] periods
	) {
		this.Invoke("set_performance_monitor_data_retention_period", new object [] {
				applications,
				periods});

	}
	public System.IAsyncResult Beginset_performance_monitor_data_retention_period(string [] applications,long [] periods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_performance_monitor_data_retention_period", new object[] {
			applications,
			periods}, callback, asyncState);
	}
	public void Endset_performance_monitor_data_retention_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_performance_monitor_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_performance_monitor_state(
		string [] applications,
		CommonEnabledState [] states
	) {
		this.Invoke("set_performance_monitor_state", new object [] {
				applications,
				states});

	}
	public System.IAsyncResult Beginset_performance_monitor_state(string [] applications,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_performance_monitor_state", new object[] {
			applications,
			states}, callback, asyncState);
	}
	public void Endset_performance_monitor_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_remote_policy(
		string [] applications,
		string [] policies
	) {
		this.Invoke("set_remote_policy", new object [] {
				applications,
				policies});

	}
	public System.IAsyncResult Beginset_remote_policy(string [] applications,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_policy", new object[] {
			applications,
			policies}, callback, asyncState);
	}
	public void Endset_remote_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unmapped_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Applications", 
		RequestNamespace="urn:iControl:WebAccelerator/Applications", ResponseNamespace="urn:iControl:WebAccelerator/Applications")]
	public void set_unmapped_state(
		string [] applications,
		CommonEnabledState [] states
	) {
		this.Invoke("set_unmapped_state", new object [] {
				applications,
				states});

	}
	public System.IAsyncResult Beginset_unmapped_state(string [] applications,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unmapped_state", new object[] {
			applications,
			states}, callback, asyncState);
	}
	public void Endset_unmapped_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "WebAccelerator.Applications.ETag", Namespace = "urn:iControl")]
	public enum WebAcceleratorApplicationsETag
	{
		ETAG_UNKNOWN,
		ETAG_ALWAYS,
		ETAG_NEVER,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "WebAccelerator.Applications.InfoHeader", Namespace = "urn:iControl")]
	public enum WebAcceleratorApplicationsInfoHeader
	{
		INFO_HEADER_UNKNOWN,
		INFO_HEADER_NONE,
		INFO_HEADER_STANDARD,
		INFO_HEADER_DEBUG,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "WebAccelerator.Applications.ApplicationStatisticEntry", Namespace = "urn:iControl")]
	public partial class WebAcceleratorApplicationsApplicationStatisticEntry
	{
		private string applicationField;
		public string application
		{
			get { return this.applicationField; }
			set { this.applicationField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "WebAccelerator.Applications.ApplicationStatistics", Namespace = "urn:iControl")]
	public partial class WebAcceleratorApplicationsApplicationStatistics
	{
		private WebAcceleratorApplicationsApplicationStatisticEntry [] statisticsField;
		public WebAcceleratorApplicationsApplicationStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "WebAccelerator.Applications.ApplicationStatisticsByVirtual", Namespace = "urn:iControl")]
	public partial class WebAcceleratorApplicationsApplicationStatisticsByVirtual
	{
		private CommonStatistic [] [] [] statisticsField;
		public CommonStatistic [] [] [] statistics
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
