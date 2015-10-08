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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.StatisticsBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsGtmIQueryStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsGtmIQueryStatistics_v2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsHostStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsPVAStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsTMMStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsVirtualCompressionStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsSystemStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsGlobalHostStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsGlobalPVAStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsGlobalTMMStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsGtmLdnsStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsGtmPathStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsGtmPathStatisticObjectID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsPerformanceGraphDataCSV))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsPerformanceStatisticQuery))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsPerformanceTable))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemStatisticsPerformanceTableData))]
	public partial class SystemStatistics : iControlInterface {
		public SystemStatistics() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_all_gtm_iquery_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsGtmIQueryStatistics get_all_gtm_iquery_statistics(

	) {
		object [] results = this.Invoke("get_all_gtm_iquery_statistics", new object [0]);
		return ((SystemStatisticsGtmIQueryStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_gtm_iquery_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_gtm_iquery_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsGtmIQueryStatistics Endget_all_gtm_iquery_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsGtmIQueryStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_gtm_iquery_statistics_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsGtmIQueryStatistics_v2 get_all_gtm_iquery_statistics_v2(

	) {
		object [] results = this.Invoke("get_all_gtm_iquery_statistics_v2", new object [0]);
		return ((SystemStatisticsGtmIQueryStatistics_v2)(results[0]));
	}
	public System.IAsyncResult Beginget_all_gtm_iquery_statistics_v2(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_gtm_iquery_statistics_v2", new object[0], callback, asyncState);
	}
	public SystemStatisticsGtmIQueryStatistics_v2 Endget_all_gtm_iquery_statistics_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsGtmIQueryStatistics_v2)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_host_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsHostStatistics get_all_host_statistics(

	) {
		object [] results = this.Invoke("get_all_host_statistics", new object [0]);
		return ((SystemStatisticsHostStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_host_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_host_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsHostStatistics Endget_all_host_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsHostStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_pva_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsPVAStatistics get_all_pva_statistics(

	) {
		object [] results = this.Invoke("get_all_pva_statistics", new object [0]);
		return ((SystemStatisticsPVAStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_pva_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_pva_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsPVAStatistics Endget_all_pva_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsPVAStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_tmm_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsTMMStatistics get_all_tmm_statistics(

	) {
		object [] results = this.Invoke("get_all_tmm_statistics", new object [0]);
		return ((SystemStatisticsTMMStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_tmm_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_tmm_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsTMMStatistics Endget_all_tmm_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsTMMStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_virtual_compression_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsVirtualCompressionStatistics get_all_virtual_compression_statistics(

	) {
		object [] results = this.Invoke("get_all_virtual_compression_statistics", new object [0]);
		return ((SystemStatisticsVirtualCompressionStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_virtual_compression_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_virtual_compression_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsVirtualCompressionStatistics Endget_all_virtual_compression_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsVirtualCompressionStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_authentication_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_authentication_statistics(

	) {
		object [] results = this.Invoke("get_authentication_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_authentication_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_authentication_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_authentication_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_client_ssl_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_client_ssl_statistics(

	) {
		object [] results = this.Invoke("get_client_ssl_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_client_ssl_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_client_ssl_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_client_ssl_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_diameter_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_diameter_statistics(

	) {
		object [] results = this.Invoke("get_diameter_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_diameter_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_diameter_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_diameter_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_server_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_dns_server_statistics(

	) {
		object [] results = this.Invoke("get_dns_server_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_dns_server_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_server_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_dns_server_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_dns_statistics(

	) {
		object [] results = this.Invoke("get_dns_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_dns_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_dns_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dnssec_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_dnssec_statistics(

	) {
		object [] results = this.Invoke("get_dnssec_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_dnssec_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dnssec_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_dnssec_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fasthttp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_fasthttp_statistics(

	) {
		object [] results = this.Invoke("get_fasthttp_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_fasthttp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fasthttp_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_fasthttp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fastl4_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_fastl4_statistics(

	) {
		object [] results = this.Invoke("get_fastl4_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_fastl4_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fastl4_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_fastl4_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fix_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_fix_statistics(

	) {
		object [] results = this.Invoke("get_fix_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_fix_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fix_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_fix_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ftp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_ftp_statistics(

	) {
		object [] results = this.Invoke("get_ftp_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_ftp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ftp_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_ftp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_global_host_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsGlobalHostStatistics get_global_host_statistics(

	) {
		object [] results = this.Invoke("get_global_host_statistics", new object [0]);
		return ((SystemStatisticsGlobalHostStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_global_host_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_global_host_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsGlobalHostStatistics Endget_global_host_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsGlobalHostStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_global_pva_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsGlobalPVAStatistics get_global_pva_statistics(

	) {
		object [] results = this.Invoke("get_global_pva_statistics", new object [0]);
		return ((SystemStatisticsGlobalPVAStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_global_pva_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_global_pva_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsGlobalPVAStatistics Endget_global_pva_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsGlobalPVAStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_global_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_global_statistics(

	) {
		object [] results = this.Invoke("get_global_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_global_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_global_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_global_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_global_tmm_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsGlobalTMMStatistics get_global_tmm_statistics(

	) {
		object [] results = this.Invoke("get_global_tmm_statistics", new object [0]);
		return ((SystemStatisticsGlobalTMMStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_global_tmm_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_global_tmm_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsGlobalTMMStatistics Endget_global_tmm_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsGlobalTMMStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_gtm_global_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_gtm_global_statistics(

	) {
		object [] results = this.Invoke("get_gtm_global_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_gtm_global_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_gtm_global_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_gtm_global_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_gtm_iquery_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsGtmIQueryStatistics get_gtm_iquery_statistics(
		string [] addresses
	) {
		object [] results = this.Invoke("get_gtm_iquery_statistics", new object [] {
				addresses});
		return ((SystemStatisticsGtmIQueryStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_gtm_iquery_statistics(string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_gtm_iquery_statistics", new object[] {
			addresses}, callback, asyncState);
	}
	public SystemStatisticsGtmIQueryStatistics Endget_gtm_iquery_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsGtmIQueryStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_gtm_iquery_statistics_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsGtmIQueryStatistics_v2 get_gtm_iquery_statistics_v2(
		string [] addresses
	) {
		object [] results = this.Invoke("get_gtm_iquery_statistics_v2", new object [] {
				addresses});
		return ((SystemStatisticsGtmIQueryStatistics_v2)(results[0]));
	}
	public System.IAsyncResult Beginget_gtm_iquery_statistics_v2(string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_gtm_iquery_statistics_v2", new object[] {
			addresses}, callback, asyncState);
	}
	public SystemStatisticsGtmIQueryStatistics_v2 Endget_gtm_iquery_statistics_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsGtmIQueryStatistics_v2)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_gtm_ldns_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsGtmLdnsStatistics get_gtm_ldns_statistics(
		string [] ldns_ips
	) {
		object [] results = this.Invoke("get_gtm_ldns_statistics", new object [] {
				ldns_ips});
		return ((SystemStatisticsGtmLdnsStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_gtm_ldns_statistics(string [] ldns_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_gtm_ldns_statistics", new object[] {
			ldns_ips}, callback, asyncState);
	}
	public SystemStatisticsGtmLdnsStatistics Endget_gtm_ldns_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsGtmLdnsStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_gtm_memory_usage_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_gtm_memory_usage_statistics(

	) {
		object [] results = this.Invoke("get_gtm_memory_usage_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_gtm_memory_usage_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_gtm_memory_usage_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_gtm_memory_usage_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_gtm_path_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsGtmPathStatistics get_gtm_path_statistics(
		string [] ldns_ips,
		SystemStatisticsGtmPathStatisticObjectID [] object_names
	) {
		object [] results = this.Invoke("get_gtm_path_statistics", new object [] {
				ldns_ips,
				object_names});
		return ((SystemStatisticsGtmPathStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_gtm_path_statistics(string [] ldns_ips,SystemStatisticsGtmPathStatisticObjectID [] object_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_gtm_path_statistics", new object[] {
			ldns_ips,
			object_names}, callback, asyncState);
	}
	public SystemStatisticsGtmPathStatistics Endget_gtm_path_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsGtmPathStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_host_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsHostStatistics get_host_statistics(
		string [] host_ids
	) {
		object [] results = this.Invoke("get_host_statistics", new object [] {
				host_ids});
		return ((SystemStatisticsHostStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_host_statistics(string [] host_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_host_statistics", new object[] {
			host_ids}, callback, asyncState);
	}
	public SystemStatisticsHostStatistics Endget_host_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsHostStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_http_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_http_statistics(

	) {
		object [] results = this.Invoke("get_http_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_http_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_http_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_httpcompression_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_httpcompression_statistics(

	) {
		object [] results = this.Invoke("get_httpcompression_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_httpcompression_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_httpcompression_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_httpcompression_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_icmp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_icmp_statistics(

	) {
		object [] results = this.Invoke("get_icmp_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_icmp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_icmp_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_icmp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_icmpv6_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_icmpv6_statistics(

	) {
		object [] results = this.Invoke("get_icmpv6_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_icmpv6_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_icmpv6_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_icmpv6_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_iiop_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_iiop_statistics(

	) {
		object [] results = this.Invoke("get_iiop_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_iiop_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_iiop_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_iiop_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_intelligence_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_ip_intelligence_statistics(

	) {
		object [] results = this.Invoke("get_ip_intelligence_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_ip_intelligence_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_intelligence_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_ip_intelligence_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_ip_statistics(

	) {
		object [] results = this.Invoke("get_ip_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_ip_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_ip_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ipv6_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_ipv6_statistics(

	) {
		object [] results = this.Invoke("get_ipv6_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_ipv6_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ipv6_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_ipv6_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list_of_hosts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_list_of_hosts(

	) {
		object [] results = this.Invoke("get_list_of_hosts", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_list_of_hosts(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list_of_hosts", new object[0], callback, asyncState);
	}
	public string [] Endget_list_of_hosts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list_of_pvas
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_list_of_pvas(

	) {
		object [] results = this.Invoke("get_list_of_pvas", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_list_of_pvas(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list_of_pvas", new object[0], callback, asyncState);
	}
	public string [] Endget_list_of_pvas(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list_of_tmms
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_list_of_tmms(

	) {
		object [] results = this.Invoke("get_list_of_tmms", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_list_of_tmms(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list_of_tmms", new object[0], callback, asyncState);
	}
	public string [] Endget_list_of_tmms(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lsn_pool_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_lsn_pool_statistics(

	) {
		object [] results = this.Invoke("get_lsn_pool_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_lsn_pool_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lsn_pool_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_lsn_pool_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_oneconnect_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_oneconnect_statistics(

	) {
		object [] results = this.Invoke("get_oneconnect_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_oneconnect_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_oneconnect_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_oneconnect_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pem_action_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_pem_action_statistics(

	) {
		object [] results = this.Invoke("get_pem_action_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_pem_action_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pem_action_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_pem_action_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pem_gx_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_pem_gx_statistics(

	) {
		object [] results = this.Invoke("get_pem_gx_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_pem_gx_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pem_gx_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_pem_gx_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pem_gy_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_pem_gy_statistics(

	) {
		object [] results = this.Invoke("get_pem_gy_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_pem_gy_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pem_gy_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_pem_gy_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pem_hsl_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_pem_hsl_statistics(

	) {
		object [] results = this.Invoke("get_pem_hsl_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_pem_hsl_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pem_hsl_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_pem_hsl_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pem_radius_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_pem_radius_statistics(

	) {
		object [] results = this.Invoke("get_pem_radius_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_pem_radius_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pem_radius_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_pem_radius_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pem_session_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_pem_session_statistics(

	) {
		object [] results = this.Invoke("get_pem_session_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_pem_session_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pem_session_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_pem_session_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pem_subscriber_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_pem_subscriber_statistics(

	) {
		object [] results = this.Invoke("get_pem_subscriber_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_pem_subscriber_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pem_subscriber_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_pem_subscriber_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_performance_graph_csv_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsPerformanceGraphDataCSV [] get_performance_graph_csv_statistics(
		SystemStatisticsPerformanceStatisticQuery [] objects
	) {
		object [] results = this.Invoke("get_performance_graph_csv_statistics", new object [] {
				objects});
		return ((SystemStatisticsPerformanceGraphDataCSV [])(results[0]));
	}
	public System.IAsyncResult Beginget_performance_graph_csv_statistics(SystemStatisticsPerformanceStatisticQuery [] objects, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_performance_graph_csv_statistics", new object[] {
			objects}, callback, asyncState);
	}
	public SystemStatisticsPerformanceGraphDataCSV [] Endget_performance_graph_csv_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsPerformanceGraphDataCSV [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_performance_graph_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsPerformanceGraph [] get_performance_graph_list(

	) {
		object [] results = this.Invoke("get_performance_graph_list", new object [0]);
		return ((SystemStatisticsPerformanceGraph [])(results[0]));
	}
	public System.IAsyncResult Beginget_performance_graph_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_performance_graph_list", new object[0], callback, asyncState);
	}
	public SystemStatisticsPerformanceGraph [] Endget_performance_graph_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsPerformanceGraph [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_performance_table_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsPerformanceTable [] get_performance_table_list(

	) {
		object [] results = this.Invoke("get_performance_table_list", new object [0]);
		return ((SystemStatisticsPerformanceTable [])(results[0]));
	}
	public System.IAsyncResult Beginget_performance_table_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_performance_table_list", new object[0], callback, asyncState);
	}
	public SystemStatisticsPerformanceTable [] Endget_performance_table_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsPerformanceTable [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_performance_table_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsPerformanceTableData [] get_performance_table_statistics(
		SystemStatisticsPerformanceStatisticQuery [] tables
	) {
		object [] results = this.Invoke("get_performance_table_statistics", new object [] {
				tables});
		return ((SystemStatisticsPerformanceTableData [])(results[0]));
	}
	public System.IAsyncResult Beginget_performance_table_statistics(SystemStatisticsPerformanceStatisticQuery [] tables, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_performance_table_statistics", new object[] {
			tables}, callback, asyncState);
	}
	public SystemStatisticsPerformanceTableData [] Endget_performance_table_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsPerformanceTableData [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pptp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_pptp_statistics(

	) {
		object [] results = this.Invoke("get_pptp_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_pptp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pptp_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_pptp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pva_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsPVAStatistics get_pva_statistics(
		string [] pva_ids
	) {
		object [] results = this.Invoke("get_pva_statistics", new object [] {
				pva_ids});
		return ((SystemStatisticsPVAStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_pva_statistics(string [] pva_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pva_statistics", new object[] {
			pva_ids}, callback, asyncState);
	}
	public SystemStatisticsPVAStatistics Endget_pva_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsPVAStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_radius_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_radius_statistics(

	) {
		object [] results = this.Invoke("get_radius_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_radius_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_radius_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_radius_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rtsp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_rtsp_statistics(

	) {
		object [] results = this.Invoke("get_rtsp_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_rtsp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rtsp_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_rtsp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sctp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_sctp_statistics(

	) {
		object [] results = this.Invoke("get_sctp_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_sctp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sctp_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_sctp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_ssl_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_server_ssl_statistics(

	) {
		object [] results = this.Invoke("get_server_ssl_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_server_ssl_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_ssl_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_server_ssl_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sip_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_sip_statistics(

	) {
		object [] results = this.Invoke("get_sip_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_sip_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sip_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_sip_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_spdy_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_spdy_statistics(

	) {
		object [] results = this.Invoke("get_spdy_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_spdy_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_spdy_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_spdy_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_stream_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_stream_statistics(

	) {
		object [] results = this.Invoke("get_stream_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_stream_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_stream_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_stream_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_tcp_statistics(

	) {
		object [] results = this.Invoke("get_tcp_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_tcp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tmm_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsTMMStatistics get_tmm_statistics(
		string [] tmm_ids
	) {
		object [] results = this.Invoke("get_tmm_statistics", new object [] {
				tmm_ids});
		return ((SystemStatisticsTMMStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_tmm_statistics(string [] tmm_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tmm_statistics", new object[] {
			tmm_ids}, callback, asyncState);
	}
	public SystemStatisticsTMMStatistics Endget_tmm_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsTMMStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_udp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_udp_statistics(

	) {
		object [] results = this.Invoke("get_udp_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_udp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_udp_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_udp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
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
	// get_virtual_compression_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsVirtualCompressionStatistics get_virtual_compression_statistics(
		string [] device_names
	) {
		object [] results = this.Invoke("get_virtual_compression_statistics", new object [] {
				device_names});
		return ((SystemStatisticsVirtualCompressionStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_virtual_compression_statistics(string [] device_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_virtual_compression_statistics", new object[] {
			device_names}, callback, asyncState);
	}
	public SystemStatisticsVirtualCompressionStatistics Endget_virtual_compression_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsVirtualCompressionStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_webacceleration_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_webacceleration_statistics(

	) {
		object [] results = this.Invoke("get_webacceleration_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_webacceleration_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_webacceleration_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_webacceleration_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_xml_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemStatisticsSystemStatistics get_xml_statistics(

	) {
		object [] results = this.Invoke("get_xml_statistics", new object [0]);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_xml_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_xml_statistics", new object[0], callback, asyncState);
	}
	public SystemStatisticsSystemStatistics Endget_xml_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemStatisticsSystemStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// reset_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_all_statistics(

	) {
		this.Invoke("reset_all_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_all_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_authentication_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_authentication_statistics(

	) {
		this.Invoke("reset_authentication_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_authentication_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_authentication_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_authentication_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_client_ssl_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_client_ssl_statistics(

	) {
		this.Invoke("reset_client_ssl_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_client_ssl_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_client_ssl_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_client_ssl_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_diameter_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_diameter_statistics(

	) {
		this.Invoke("reset_diameter_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_diameter_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_diameter_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_diameter_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_dns_server_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_dns_server_statistics(

	) {
		this.Invoke("reset_dns_server_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_dns_server_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_dns_server_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_dns_server_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_dns_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_dns_statistics(

	) {
		this.Invoke("reset_dns_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_dns_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_dns_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_dns_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_dnssec_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_dnssec_statistics(

	) {
		this.Invoke("reset_dnssec_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_dnssec_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_dnssec_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_dnssec_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_fasthttp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_fasthttp_statistics(

	) {
		this.Invoke("reset_fasthttp_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_fasthttp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_fasthttp_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_fasthttp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_fastl4_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_fastl4_statistics(

	) {
		this.Invoke("reset_fastl4_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_fastl4_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_fastl4_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_fastl4_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_fix_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_fix_statistics(

	) {
		this.Invoke("reset_fix_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_fix_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_fix_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_fix_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_ftp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_ftp_statistics(

	) {
		this.Invoke("reset_ftp_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_ftp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_ftp_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_ftp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_global_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_global_statistics(

	) {
		this.Invoke("reset_global_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_global_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_global_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_global_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_gtm_global_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_gtm_global_statistics(

	) {
		this.Invoke("reset_gtm_global_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_gtm_global_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_gtm_global_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_gtm_global_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_gtm_iquery_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_gtm_iquery_statistics(
		string [] addresses
	) {
		this.Invoke("reset_gtm_iquery_statistics", new object [] {
				addresses});

	}
	public System.IAsyncResult Beginreset_gtm_iquery_statistics(string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_gtm_iquery_statistics", new object[] {
			addresses}, callback, asyncState);
	}
	public void Endreset_gtm_iquery_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_gtm_ldns_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_gtm_ldns_statistics(
		string [] ldns_ips
	) {
		this.Invoke("reset_gtm_ldns_statistics", new object [] {
				ldns_ips});

	}
	public System.IAsyncResult Beginreset_gtm_ldns_statistics(string [] ldns_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_gtm_ldns_statistics", new object[] {
			ldns_ips}, callback, asyncState);
	}
	public void Endreset_gtm_ldns_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_gtm_path_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_gtm_path_statistics(
		string [] ldns_ips,
		SystemStatisticsGtmPathStatisticObjectID [] object_names
	) {
		this.Invoke("reset_gtm_path_statistics", new object [] {
				ldns_ips,
				object_names});

	}
	public System.IAsyncResult Beginreset_gtm_path_statistics(string [] ldns_ips,SystemStatisticsGtmPathStatisticObjectID [] object_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_gtm_path_statistics", new object[] {
			ldns_ips,
			object_names}, callback, asyncState);
	}
	public void Endreset_gtm_path_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_http_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_http_statistics(

	) {
		this.Invoke("reset_http_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_http_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_http_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_http_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_httpcompression_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_httpcompression_statistics(

	) {
		this.Invoke("reset_httpcompression_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_httpcompression_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_httpcompression_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_httpcompression_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_icmp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_icmp_statistics(

	) {
		this.Invoke("reset_icmp_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_icmp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_icmp_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_icmp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_icmpv6_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_icmpv6_statistics(

	) {
		this.Invoke("reset_icmpv6_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_icmpv6_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_icmpv6_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_icmpv6_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_iiop_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_iiop_statistics(

	) {
		this.Invoke("reset_iiop_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_iiop_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_iiop_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_iiop_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_ip_intelligence_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_ip_intelligence_statistics(

	) {
		this.Invoke("reset_ip_intelligence_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_ip_intelligence_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_ip_intelligence_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_ip_intelligence_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_ip_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_ip_statistics(

	) {
		this.Invoke("reset_ip_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_ip_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_ip_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_ip_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_ipv6_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_ipv6_statistics(

	) {
		this.Invoke("reset_ipv6_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_ipv6_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_ipv6_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_ipv6_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_lsn_pool_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_lsn_pool_statistics(

	) {
		this.Invoke("reset_lsn_pool_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_lsn_pool_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_lsn_pool_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_lsn_pool_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_oneconnect_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_oneconnect_statistics(

	) {
		this.Invoke("reset_oneconnect_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_oneconnect_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_oneconnect_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_oneconnect_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_pem_action_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_pem_action_statistics(

	) {
		this.Invoke("reset_pem_action_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_pem_action_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_pem_action_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_pem_action_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_pem_gx_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_pem_gx_statistics(

	) {
		this.Invoke("reset_pem_gx_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_pem_gx_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_pem_gx_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_pem_gx_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_pem_gy_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_pem_gy_statistics(

	) {
		this.Invoke("reset_pem_gy_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_pem_gy_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_pem_gy_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_pem_gy_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_pem_hsl_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_pem_hsl_statistics(

	) {
		this.Invoke("reset_pem_hsl_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_pem_hsl_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_pem_hsl_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_pem_hsl_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_pem_radius_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_pem_radius_statistics(

	) {
		this.Invoke("reset_pem_radius_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_pem_radius_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_pem_radius_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_pem_radius_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_pem_session_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_pem_session_statistics(

	) {
		this.Invoke("reset_pem_session_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_pem_session_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_pem_session_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_pem_session_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_pem_subscriber_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_pem_subscriber_statistics(

	) {
		this.Invoke("reset_pem_subscriber_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_pem_subscriber_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_pem_subscriber_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_pem_subscriber_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_pptp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_pptp_statistics(

	) {
		this.Invoke("reset_pptp_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_pptp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_pptp_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_pptp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_radius_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_radius_statistics(

	) {
		this.Invoke("reset_radius_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_radius_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_radius_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_radius_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_rtsp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_rtsp_statistics(

	) {
		this.Invoke("reset_rtsp_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_rtsp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_rtsp_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_rtsp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_sctp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_sctp_statistics(

	) {
		this.Invoke("reset_sctp_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_sctp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_sctp_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_sctp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_server_ssl_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_server_ssl_statistics(

	) {
		this.Invoke("reset_server_ssl_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_server_ssl_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_server_ssl_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_server_ssl_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_sip_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_sip_statistics(

	) {
		this.Invoke("reset_sip_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_sip_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_sip_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_sip_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_spdy_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_spdy_statistics(

	) {
		this.Invoke("reset_spdy_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_spdy_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_spdy_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_spdy_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_stream_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_stream_statistics(

	) {
		this.Invoke("reset_stream_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_stream_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_stream_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_stream_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_tcp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_tcp_statistics(

	) {
		this.Invoke("reset_tcp_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_tcp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_tcp_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_tcp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_udp_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_udp_statistics(

	) {
		this.Invoke("reset_udp_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_udp_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_udp_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_udp_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_virtual_compression_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_virtual_compression_statistics(
		string [] device_names
	) {
		this.Invoke("reset_virtual_compression_statistics", new object [] {
				device_names});

	}
	public System.IAsyncResult Beginreset_virtual_compression_statistics(string [] device_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_virtual_compression_statistics", new object[] {
			device_names}, callback, asyncState);
	}
	public void Endreset_virtual_compression_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_webacceleration_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_webacceleration_statistics(

	) {
		this.Invoke("reset_webacceleration_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_webacceleration_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_webacceleration_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_webacceleration_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_xml_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Statistics", 
		RequestNamespace="urn:iControl:System/Statistics", ResponseNamespace="urn:iControl:System/Statistics")]
	public void reset_xml_statistics(

	) {
		this.Invoke("reset_xml_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_xml_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_xml_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_xml_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmIQueryState", Namespace = "urn:iControl")]
	public enum SystemStatisticsGtmIQueryState
	{
		IQUERY_STATE_UNCONNECTED,
		IQUERY_STATE_CONNECTING,
		IQUERY_STATE_CONNECTED,
		IQUERY_STATE_BACKLOGGED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmPathStatisticObjectType", Namespace = "urn:iControl")]
	public enum SystemStatisticsGtmPathStatisticObjectType
	{
		GTM_PATH_STATISTIC_DATA_CENTER,
		GTM_PATH_STATISTIC_LINK,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GlobalHostStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGlobalHostStatistics
	{
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GlobalPVAStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGlobalPVAStatistics
	{
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GlobalTMMStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGlobalTMMStatistics
	{
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmIQueryStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGtmIQueryStatisticEntry
	{
		private string ip_addressField;
		public string ip_address
		{
			get { return this.ip_addressField; }
			set { this.ip_addressField = value; }
		}
		private SystemStatisticsGtmIQueryState connection_stateField;
		public SystemStatisticsGtmIQueryState connection_state
		{
			get { return this.connection_stateField; }
			set { this.connection_stateField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmIQueryStatisticEntry_v2", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGtmIQueryStatisticEntry_v2
	{
		private string ip_addressField;
		public string ip_address
		{
			get { return this.ip_addressField; }
			set { this.ip_addressField = value; }
		}
		private SystemStatisticsGtmIQueryState connection_stateField;
		public SystemStatisticsGtmIQueryState connection_state
		{
			get { return this.connection_stateField; }
			set { this.connection_stateField = value; }
		}
		private string serverField;
		public string server
		{
			get { return this.serverField; }
			set { this.serverField = value; }
		}
		private string data_centerField;
		public string data_center
		{
			get { return this.data_centerField; }
			set { this.data_centerField = value; }
		}
		private long configuration_timeField;
		public long configuration_time
		{
			get { return this.configuration_timeField; }
			set { this.configuration_timeField = value; }
		}
		private long cert_expire_timeField;
		public long cert_expire_time
		{
			get { return this.cert_expire_timeField; }
			set { this.cert_expire_timeField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmIQueryStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGtmIQueryStatistics
	{
		private SystemStatisticsGtmIQueryStatisticEntry [] statisticsField;
		public SystemStatisticsGtmIQueryStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmIQueryStatistics_v2", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGtmIQueryStatistics_v2
	{
		private SystemStatisticsGtmIQueryStatisticEntry_v2 [] statisticsField;
		public SystemStatisticsGtmIQueryStatisticEntry_v2 [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmLdnsStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGtmLdnsStatisticEntry
	{
		private string ldns_ipField;
		public string ldns_ip
		{
			get { return this.ldns_ipField; }
			set { this.ldns_ipField = value; }
		}
		private long last_accessedField;
		public long last_accessed
		{
			get { return this.last_accessedField; }
			set { this.last_accessedField = value; }
		}
		private string continentField;
		public string continent
		{
			get { return this.continentField; }
			set { this.continentField = value; }
		}
		private string countryField;
		public string country
		{
			get { return this.countryField; }
			set { this.countryField = value; }
		}
		private string stateField;
		public string state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
		private string cityField;
		public string city
		{
			get { return this.cityField; }
			set { this.cityField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmLdnsStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGtmLdnsStatistics
	{
		private SystemStatisticsGtmLdnsStatisticEntry [] statisticsField;
		public SystemStatisticsGtmLdnsStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmPathStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGtmPathStatisticEntry
	{
		private string ldns_ipField;
		public string ldns_ip
		{
			get { return this.ldns_ipField; }
			set { this.ldns_ipField = value; }
		}
		private SystemStatisticsGtmPathStatisticObjectID object_nameField;
		public SystemStatisticsGtmPathStatisticObjectID object_name
		{
			get { return this.object_nameField; }
			set { this.object_nameField = value; }
		}
		private long last_probe_timeField;
		public long last_probe_time
		{
			get { return this.last_probe_timeField; }
			set { this.last_probe_timeField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmPathStatisticObjectID", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGtmPathStatisticObjectID
	{
		private SystemStatisticsGtmPathStatisticObjectType typeField;
		public SystemStatisticsGtmPathStatisticObjectType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.GtmPathStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsGtmPathStatistics
	{
		private SystemStatisticsGtmPathStatisticEntry [] statisticsField;
		public SystemStatisticsGtmPathStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.HostStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemStatisticsHostStatisticEntry
	{
		private string host_idField;
		public string host_id
		{
			get { return this.host_idField; }
			set { this.host_idField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.HostStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsHostStatistics
	{
		private SystemStatisticsHostStatisticEntry [] statisticsField;
		public SystemStatisticsHostStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.PVAStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemStatisticsPVAStatisticEntry
	{
		private string pva_idField;
		public string pva_id
		{
			get { return this.pva_idField; }
			set { this.pva_idField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.PVAStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsPVAStatistics
	{
		private SystemStatisticsPVAStatisticEntry [] statisticsField;
		public SystemStatisticsPVAStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.PerformanceGraph", Namespace = "urn:iControl")]
	public partial class SystemStatisticsPerformanceGraph
	{
		private string graph_nameField;
		public string graph_name
		{
			get { return this.graph_nameField; }
			set { this.graph_nameField = value; }
		}
		private string graph_titleField;
		public string graph_title
		{
			get { return this.graph_titleField; }
			set { this.graph_titleField = value; }
		}
		private string graph_descriptionField;
		public string graph_description
		{
			get { return this.graph_descriptionField; }
			set { this.graph_descriptionField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.PerformanceGraphDataCSV", Namespace = "urn:iControl")]
	public partial class SystemStatisticsPerformanceGraphDataCSV
	{
		private string object_nameField;
		public string object_name
		{
			get { return this.object_nameField; }
			set { this.object_nameField = value; }
		}
		private long start_timeField;
		public long start_time
		{
			get { return this.start_timeField; }
			set { this.start_timeField = value; }
		}
		private long end_timeField;
		public long end_time
		{
			get { return this.end_timeField; }
			set { this.end_timeField = value; }
		}
		private long intervalField;
		public long interval
		{
			get { return this.intervalField; }
			set { this.intervalField = value; }
		}
		private byte [] statistic_dataField;
		[System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")]
		public byte [] statistic_data
		{
			get { return this.statistic_dataField; }
			set { this.statistic_dataField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.PerformanceStatisticQuery", Namespace = "urn:iControl")]
	public partial class SystemStatisticsPerformanceStatisticQuery
	{
		private string object_nameField;
		public string object_name
		{
			get { return this.object_nameField; }
			set { this.object_nameField = value; }
		}
		private long start_timeField;
		public long start_time
		{
			get { return this.start_timeField; }
			set { this.start_timeField = value; }
		}
		private long end_timeField;
		public long end_time
		{
			get { return this.end_timeField; }
			set { this.end_timeField = value; }
		}
		private long intervalField;
		public long interval
		{
			get { return this.intervalField; }
			set { this.intervalField = value; }
		}
		private long maximum_rowsField;
		public long maximum_rows
		{
			get { return this.maximum_rowsField; }
			set { this.maximum_rowsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.PerformanceTable", Namespace = "urn:iControl")]
	public partial class SystemStatisticsPerformanceTable
	{
		private string table_nameField;
		public string table_name
		{
			get { return this.table_nameField; }
			set { this.table_nameField = value; }
		}
		private string table_descriptionField;
		public string table_description
		{
			get { return this.table_descriptionField; }
			set { this.table_descriptionField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.PerformanceTableData", Namespace = "urn:iControl")]
	public partial class SystemStatisticsPerformanceTableData
	{
		private string table_nameField;
		public string table_name
		{
			get { return this.table_nameField; }
			set { this.table_nameField = value; }
		}
		private long start_timeField;
		public long start_time
		{
			get { return this.start_timeField; }
			set { this.start_timeField = value; }
		}
		private long end_timeField;
		public long end_time
		{
			get { return this.end_timeField; }
			set { this.end_timeField = value; }
		}
		private long intervalField;
		public long interval
		{
			get { return this.intervalField; }
			set { this.intervalField = value; }
		}
		private double [] statistic_dataField;
		public double [] statistic_data
		{
			get { return this.statistic_dataField; }
			set { this.statistic_dataField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.SystemStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsSystemStatistics
	{
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.TMMStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemStatisticsTMMStatisticEntry
	{
		private string tmm_idField;
		public string tmm_id
		{
			get { return this.tmm_idField; }
			set { this.tmm_idField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.TMMStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsTMMStatistics
	{
		private SystemStatisticsTMMStatisticEntry [] statisticsField;
		public SystemStatisticsTMMStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.VirtualCompressionStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemStatisticsVirtualCompressionStatisticEntry
	{
		private string device_nameField;
		public string device_name
		{
			get { return this.device_nameField; }
			set { this.device_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Statistics.VirtualCompressionStatistics", Namespace = "urn:iControl")]
	public partial class SystemStatisticsVirtualCompressionStatistics
	{
		private SystemStatisticsVirtualCompressionStatisticEntry [] statisticsField;
		public SystemStatisticsVirtualCompressionStatisticEntry [] statistics
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
