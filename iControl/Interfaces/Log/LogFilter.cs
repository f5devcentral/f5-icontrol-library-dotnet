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
	[System.Web.Services.WebServiceBindingAttribute(Name="Log.FilterBinding", Namespace="urn:iControl")]
	public partial class LogFilter : iControlInterface {
		public LogFilter() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	public void create(
		string [] filters,
		LogFilterSource [] sources,
		string [] publishers
	) {
		this.Invoke("create", new object [] {
				filters,
				sources,
				publishers});

	}
	public System.IAsyncResult Begincreate(string [] filters,LogFilterSource [] sources,string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			filters,
			sources,
			publishers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_filters
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	public void delete_all_filters(

	) {
		this.Invoke("delete_all_filters", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_filters(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_filters", new object[0], callback, asyncState);
	}
	public void Enddelete_all_filters(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	public void delete_filter(
		string [] filters
	) {
		this.Invoke("delete_filter", new object [] {
				filters});

	}
	public System.IAsyncResult Begindelete_filter(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_filter", new object[] {
			filters}, callback, asyncState);
	}
	public void Enddelete_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] filters
	) {
		object [] results = this.Invoke("get_description", new object [] {
				filters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			filters}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LogSyslogLevel [] get_level(
		string [] filters
	) {
		object [] results = this.Invoke("get_level", new object [] {
				filters});
		return ((LogSyslogLevel [])(results[0]));
	}
	public System.IAsyncResult Beginget_level(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_level", new object[] {
			filters}, callback, asyncState);
	}
	public LogSyslogLevel [] Endget_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LogSyslogLevel [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
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
	// get_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_publisher(
		string [] filters
	) {
		object [] results = this.Invoke("get_publisher", new object [] {
				filters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_publisher(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_publisher", new object[] {
			filters}, callback, asyncState);
	}
	public string [] Endget_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LogFilterSource [] get_source(
		string [] filters
	) {
		object [] results = this.Invoke("get_source", new object [] {
				filters});
		return ((LogFilterSource [])(results[0]));
	}
	public System.IAsyncResult Beginget_source(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source", new object[] {
			filters}, callback, asyncState);
	}
	public LogFilterSource [] Endget_source(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LogFilterSource [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
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
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	public void set_description(
		string [] filters,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				filters,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] filters,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			filters,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	public void set_level(
		string [] filters,
		LogSyslogLevel [] levels
	) {
		this.Invoke("set_level", new object [] {
				filters,
				levels});

	}
	public System.IAsyncResult Beginset_level(string [] filters,LogSyslogLevel [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_level", new object[] {
			filters,
			levels}, callback, asyncState);
	}
	public void Endset_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	public void set_publisher(
		string [] filters,
		string [] publishers
	) {
		this.Invoke("set_publisher", new object [] {
				filters,
				publishers});

	}
	public System.IAsyncResult Beginset_publisher(string [] filters,string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_publisher", new object[] {
			filters,
			publishers}, callback, asyncState);
	}
	public void Endset_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Filter", 
		RequestNamespace="urn:iControl:Log/Filter", ResponseNamespace="urn:iControl:Log/Filter")]
	public void set_source(
		string [] filters,
		LogFilterSource [] sources
	) {
		this.Invoke("set_source", new object [] {
				filters,
				sources});

	}
	public System.IAsyncResult Beginset_source(string [] filters,LogFilterSource [] sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source", new object[] {
			filters,
			sources}, callback, asyncState);
	}
	public void Endset_source(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Log.Filter.Source", Namespace = "urn:iControl")]
	public enum LogFilterSource
	{
		LOG_SOURCE_UNKNOWN,
		LOG_SOURCE_ALL,
		LOG_SOURCE_ACCESSCONTROL,
		LOG_SOURCE_ADAPT,
		LOG_SOURCE_ALERTD,
		LOG_SOURCE_APMACL,
		LOG_SOURCE_ARP,
		LOG_SOURCE_AVR,
		LOG_SOURCE_BASED,
		LOG_SOURCE_BCM56XXD,
		LOG_SOURCE_BIG3D,
		LOG_SOURCE_BIG3DSHIM,
		LOG_SOURCE_BIGD,
		LOG_SOURCE_BIGDB,
		LOG_SOURCE_BIGDBD,
		LOG_SOURCE_BIGPIPE,
		LOG_SOURCE_BIGSTART,
		LOG_SOURCE_BP,
		LOG_SOURCE_CHECKCERT,
		LOG_SOURCE_CHMAND,
		LOG_SOURCE_CIFS,
		LOG_SOURCE_CLUSTERD,
		LOG_SOURCE_COAPI,
		LOG_SOURCE_BIGIP_COMMON,
		LOG_SOURCE_CONFIG_DB,
		LOG_SOURCE_CONNAPI,
		LOG_SOURCE_CS,
		LOG_SOURCE_CSSD,
		LOG_SOURCE_CSYNCD,
		LOG_SOURCE_DAEMON,
		LOG_SOURCE_DEFLATE,
		LOG_SOURCE_DEVMGMTD,
		LOG_SOURCE_DIAMETER,
		LOG_SOURCE_DMON,
		LOG_SOURCE_DOSPROTECT,
		LOG_SOURCE_DUMMY,
		LOG_SOURCE_ECA,
		LOG_SOURCE_EVENTD,
		LOG_SOURCE_EVROUTED,
		LOG_SOURCE_FFLAG,
		LOG_SOURCE_GET_DOSSIER,
		LOG_SOURCE_GTMD,
		LOG_SOURCE_HA,
		LOG_SOURCE_HALMSG,
		LOG_SOURCE_HA_TABLE,
		LOG_SOURCE_HTTP,
		LOG_SOURCE_HWCTL,
		LOG_SOURCE_IP,
		LOG_SOURCE_IPREPD,
		LOG_SOURCE_ISESSION,
		LOG_SOURCE_ISTATSD,
		LOG_SOURCE_LACPD,
		LOG_SOURCE_LAYER4,
		LOG_SOURCE_LIBHAL,
		LOG_SOURCE_LIND,
		LOG_SOURCE_LLDPD,
		LOG_SOURCE_MAPI,
		LOG_SOURCE_MCP,
		LOG_SOURCE_MCPD,
		LOG_SOURCE_MGMT_ACLD,
		LOG_SOURCE_MYSQLHAD,
		LOG_SOURCE_NET,
		LOG_SOURCE_NETWORK,
		LOG_SOURCE_PACKET_FILTER,
		LOG_SOURCE_PCCD,
		LOG_SOURCE_PFMAND,
		LOG_SOURCE_PKTCLASS,
		LOG_SOURCE_PLUGIN,
		LOG_SOURCE_PROBE_PLUSPLUS,
		LOG_SOURCE_PROMPTSTATUSD,
		LOG_SOURCE_PVA,
		LOG_SOURCE_PVAD,
		LOG_SOURCE_RADIUS,
		LOG_SOURCE_RAMCACHE,
		LOG_SOURCE_RBA,
		LOG_SOURCE_RTSP,
		LOG_SOURCE_RULES,
		LOG_SOURCE_SASPD,
		LOG_SOURCE_SCRIPTD,
		LOG_SOURCE_SHELL,
		LOG_SOURCE_SNMP,
		LOG_SOURCE_SOD,
		LOG_SOURCE_SSL,
		LOG_SOURCE_SSO,
		LOG_SOURCE_STATSD,
		LOG_SOURCE_STPD,
		LOG_SOURCE_SUBAGENTS,
		LOG_SOURCE_SYSCALL,
		LOG_SOURCE_SYSTEM_CHECK,
		LOG_SOURCE_TAMD,
		LOG_SOURCE_TCL_CHECKER,
		LOG_SOURCE_TCPDUMP,
		LOG_SOURCE_TMM,
		LOG_SOURCE_TMSH,
		LOG_SOURCE_TS,
		LOG_SOURCE_VCMPD,
		LOG_SOURCE_PORTAL_ACCESS,
		LOG_SOURCE_WEBSSO,
		LOG_SOURCE_WOC_PLUGIN,
		LOG_SOURCE_XCONFIG,
		LOG_SOURCE_XDB,
		LOG_SOURCE_ZFD,
		LOG_SOURCE_ZXFRD,
		LOG_SOURCE_COMMON_F5LOGGING,
		LOG_SOURCE_COMMON_FPDD,
		LOG_SOURCE_EM_ADMIN,
		LOG_SOURCE_EM_ALERT,
		LOG_SOURCE_EM_CLIENTLIB,
		LOG_SOURCE_EM_COMMON,
		LOG_SOURCE_EM_DEVICE,
		LOG_SOURCE_EM_DISCOVERY,
		LOG_SOURCE_EM_FILE,
		LOG_SOURCE_EM_LIB,
		LOG_SOURCE_EM_REPORT,
		LOG_SOURCE_EM_STATS,
		LOG_SOURCE_EM_SWIM,
		LOG_SOURCE_NONE,
		LOG_SOURCE_ACCESSPERREQUEST,
		LOG_SOURCE_BDOSD,
		LOG_SOURCE_COMMON_COMMON,
		LOG_SOURCE_DWBLD,
		LOG_SOURCE_FIX,
		LOG_SOURCE_GTP,
		LOG_SOURCE_GUESTAGENTD,
		LOG_SOURCE_HOSTAGENTD,
		LOG_SOURCE_ICRD,
		LOG_SOURCE_IPFIX,
		LOG_SOURCE_IPFIXIRULES,
		LOG_SOURCE_IPSEC,
		LOG_SOURCE_IVS,
		LOG_SOURCE_LOPD,
		LOG_SOURCE_LSN,
		LOG_SOURCE_LSNAPI,
		LOG_SOURCE_MAMIDBRIDGED,
		LOG_SOURCE_MAP,
		LOG_SOURCE_MR,
		LOG_SOURCE_MRSIP,
		LOG_SOURCE_MSGBUSD,
		LOG_SOURCE_PCP,
		LOG_SOURCE_PEM,
		LOG_SOURCE_PKCS11D,
		LOG_SOURCE_POLICY,
		LOG_SOURCE_PPTP,
		LOG_SOURCE_REWRITE,
		LOG_SOURCE_SFLOW,
		LOG_SOURCE_SWG,
		LOG_SOURCE_TMM_TCP,
		LOG_SOURCE_TUNNEL,
		LOG_SOURCE_URLC,
		LOG_SOURCE_URLDB,
		LOG_SOURCE_URLDBMGRD,
		LOG_SOURCE_VXLAND,
		LOG_SOURCE_WEBAPPLICATIONS,
		LOG_SOURCE_WR_URLDBD,
		LOG_SOURCE_ERRDEFSD,
		LOG_SOURCE_FIPS,
		LOG_SOURCE_FW_FQDN,
		LOG_SOURCE_HWPD,
		LOG_SOURCE_IPFIXPROXY,
		LOG_SOURCE_PGADMIND,
		LOG_SOURCE_SCIM,
		LOG_SOURCE_SCTP,
		LOG_SOURCE_SDMD,
		LOG_SOURCE_SHMMAPD,
		LOG_SOURCE_SPOLICY,
		LOG_SOURCE_STATED,
		LOG_SOURCE_STATUSD,
		LOG_SOURCE_TFTP,
		LOG_SOURCE_TMROUTED,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
