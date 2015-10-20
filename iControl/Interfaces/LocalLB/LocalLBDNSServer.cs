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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.DNSServerBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBDNSServerDNSServerStatistics))]
	public partial class LocalLBDNSServer : iControlInterface {
		public LocalLBDNSServer() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	public void create(
		string [] servers,
		string [] addresses
	) {
		this.Invoke("create", new object [] {
				servers,
				addresses});

	}
	public System.IAsyncResult Begincreate(string [] servers,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			servers,
			addresses}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	public void delete_all_servers(

	) {
		this.Invoke("delete_all_servers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_servers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_servers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	public void delete_server(
		string [] servers
	) {
		this.Invoke("delete_server", new object [] {
				servers});

	}
	public System.IAsyncResult Begindelete_server(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_server", new object[] {
			servers}, callback, asyncState);
	}
	public void Enddelete_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_address(
		string [] servers
	) {
		object [] results = this.Invoke("get_address", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_address(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSServerDNSServerStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBDNSServerDNSServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBDNSServerDNSServerStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSServerDNSServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
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
	// get_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_port(
		string [] servers
	) {
		object [] results = this.Invoke("get_port", new object [] {
				servers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_port(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_port", new object[] {
			servers}, callback, asyncState);
	}
	public long [] Endget_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_route_domain(
		string [] servers
	) {
		object [] results = this.Invoke("get_route_domain", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_domain(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_domain", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSServerDNSServerStatistics get_statistics(
		string [] servers
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				servers});
		return ((LocalLBDNSServerDNSServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			servers}, callback, asyncState);
	}
	public LocalLBDNSServerDNSServerStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSServerDNSServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tsig_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_tsig_key(
		string [] servers
	) {
		object [] results = this.Invoke("get_tsig_key", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_tsig_key(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tsig_key", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_tsig_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	public void reset_statistics(
		string [] servers
	) {
		this.Invoke("reset_statistics", new object [] {
				servers});

	}
	public System.IAsyncResult Beginreset_statistics(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			servers}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	public void set_address(
		string [] servers,
		string [] addresses
	) {
		this.Invoke("set_address", new object [] {
				servers,
				addresses});

	}
	public System.IAsyncResult Beginset_address(string [] servers,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_address", new object[] {
			servers,
			addresses}, callback, asyncState);
	}
	public void Endset_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	public void set_port(
		string [] servers,
		long [] ports
	) {
		this.Invoke("set_port", new object [] {
				servers,
				ports});

	}
	public System.IAsyncResult Beginset_port(string [] servers,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_port", new object[] {
			servers,
			ports}, callback, asyncState);
	}
	public void Endset_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	public void set_route_domain(
		string [] servers,
		string [] domains
	) {
		this.Invoke("set_route_domain", new object [] {
				servers,
				domains});

	}
	public System.IAsyncResult Beginset_route_domain(string [] servers,string [] domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_route_domain", new object[] {
			servers,
			domains}, callback, asyncState);
	}
	public void Endset_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tsig_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSServer", 
		RequestNamespace="urn:iControl:LocalLB/DNSServer", ResponseNamespace="urn:iControl:LocalLB/DNSServer")]
	public void set_tsig_key(
		string [] servers,
		string [] keys
	) {
		this.Invoke("set_tsig_key", new object [] {
				servers,
				keys});

	}
	public System.IAsyncResult Beginset_tsig_key(string [] servers,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tsig_key", new object[] {
			servers,
			keys}, callback, asyncState);
	}
	public void Endset_tsig_key(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSServer.DNSServerStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBDNSServerDNSServerStatisticEntry
	{
		private string serverField;
		public string server
		{
			get { return this.serverField; }
			set { this.serverField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSServer.DNSServerStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBDNSServerDNSServerStatistics
	{
		private LocalLBDNSServerDNSServerStatisticEntry [] statisticsField;
		public LocalLBDNSServerDNSServerStatisticEntry [] statistics
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
