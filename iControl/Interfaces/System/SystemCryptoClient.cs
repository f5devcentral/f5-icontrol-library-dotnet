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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.CryptoClientBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemCryptoClientCryptoClientStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSystemProfileAttribute))]
	public partial class SystemCryptoClient : iControlInterface {
		public SystemCryptoClient() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void add_profile(
		string [] clients,
		string [] [] profiles
	) {
		this.Invoke("add_profile", new object [] {
				clients,
				profiles});

	}
	public System.IAsyncResult Beginadd_profile(string [] clients,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_profile", new object[] {
			clients,
			profiles}, callback, asyncState);
	}
	public void Endadd_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void create(
		string [] clients,
		string [] addresses,
		long [] ports
	) {
		this.Invoke("create", new object [] {
				clients,
				addresses,
				ports});

	}
	public System.IAsyncResult Begincreate(string [] clients,string [] addresses,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			clients,
			addresses,
			ports}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_clients
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void delete_all_clients(

	) {
		this.Invoke("delete_all_clients", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_clients(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_clients", new object[0], callback, asyncState);
	}
	public void Enddelete_all_clients(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void delete_client(
		string [] clients
	) {
		this.Invoke("delete_client", new object [] {
				clients});

	}
	public System.IAsyncResult Begindelete_client(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_client", new object[] {
			clients}, callback, asyncState);
	}
	public void Enddelete_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemCryptoClientCryptoClientStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((SystemCryptoClientCryptoClientStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public SystemCryptoClientCryptoClientStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemCryptoClientCryptoClientStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_heartbeat_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_heartbeat_interval(
		string [] clients
	) {
		object [] results = this.Invoke("get_heartbeat_interval", new object [] {
				clients});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_heartbeat_interval(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_heartbeat_interval", new object[] {
			clients}, callback, asyncState);
	}
	public long [] Endget_heartbeat_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
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
	// get_maximum_retries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_maximum_retries(
		string [] clients
	) {
		object [] results = this.Invoke("get_maximum_retries", new object [] {
				clients});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_retries(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_retries", new object[] {
			clients}, callback, asyncState);
	}
	public long [] Endget_maximum_retries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSystemProfileAttribute [] [] get_profile(
		string [] clients
	) {
		object [] results = this.Invoke("get_profile", new object [] {
				clients});
		return ((SystemSystemProfileAttribute [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_profile(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_profile", new object[] {
			clients}, callback, asyncState);
	}
	public SystemSystemProfileAttribute [] [] Endget_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSystemProfileAttribute [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_request_timeout(
		string [] clients
	) {
		object [] results = this.Invoke("get_request_timeout", new object [] {
				clients});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_timeout(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_timeout", new object[] {
			clients}, callback, asyncState);
	}
	public long [] Endget_request_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_retry_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_retry_interval(
		string [] clients
	) {
		object [] results = this.Invoke("get_retry_interval", new object [] {
				clients});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_retry_interval(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_retry_interval", new object[] {
			clients}, callback, asyncState);
	}
	public long [] Endget_retry_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_server_address(
		string [] clients
	) {
		object [] results = this.Invoke("get_server_address", new object [] {
				clients});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_address(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_address", new object[] {
			clients}, callback, asyncState);
	}
	public string [] Endget_server_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_server_port(
		string [] clients
	) {
		object [] results = this.Invoke("get_server_port", new object [] {
				clients});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_port(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_port", new object[] {
			clients}, callback, asyncState);
	}
	public long [] Endget_server_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemCryptoClientCryptoClientStatistics get_statistics(
		string [] clients
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				clients});
		return ((SystemCryptoClientCryptoClientStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			clients}, callback, asyncState);
	}
	public SystemCryptoClientCryptoClientStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemCryptoClientCryptoClientStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
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
	// remove_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void remove_all_profiles(
		string [] clients
	) {
		this.Invoke("remove_all_profiles", new object [] {
				clients});

	}
	public System.IAsyncResult Beginremove_all_profiles(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_profiles", new object[] {
			clients}, callback, asyncState);
	}
	public void Endremove_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void remove_profile(
		string [] clients,
		string [] [] profiles
	) {
		this.Invoke("remove_profile", new object [] {
				clients,
				profiles});

	}
	public System.IAsyncResult Beginremove_profile(string [] clients,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_profile", new object[] {
			clients,
			profiles}, callback, asyncState);
	}
	public void Endremove_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_connection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void reset_connection(
		string [] clients
	) {
		this.Invoke("reset_connection", new object [] {
				clients});

	}
	public System.IAsyncResult Beginreset_connection(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_connection", new object[] {
			clients}, callback, asyncState);
	}
	public void Endreset_connection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void reset_statistics(
		string [] clients
	) {
		this.Invoke("reset_statistics", new object [] {
				clients});

	}
	public System.IAsyncResult Beginreset_statistics(string [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			clients}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_heartbeat_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void set_heartbeat_interval(
		string [] clients,
		long [] intervals
	) {
		this.Invoke("set_heartbeat_interval", new object [] {
				clients,
				intervals});

	}
	public System.IAsyncResult Beginset_heartbeat_interval(string [] clients,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_heartbeat_interval", new object[] {
			clients,
			intervals}, callback, asyncState);
	}
	public void Endset_heartbeat_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_retries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void set_maximum_retries(
		string [] clients,
		long [] retries
	) {
		this.Invoke("set_maximum_retries", new object [] {
				clients,
				retries});

	}
	public System.IAsyncResult Beginset_maximum_retries(string [] clients,long [] retries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_retries", new object[] {
			clients,
			retries}, callback, asyncState);
	}
	public void Endset_maximum_retries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void set_request_timeout(
		string [] clients,
		long [] timeouts
	) {
		this.Invoke("set_request_timeout", new object [] {
				clients,
				timeouts});

	}
	public System.IAsyncResult Beginset_request_timeout(string [] clients,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_timeout", new object[] {
			clients,
			timeouts}, callback, asyncState);
	}
	public void Endset_request_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_retry_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void set_retry_interval(
		string [] clients,
		long [] intervals
	) {
		this.Invoke("set_retry_interval", new object [] {
				clients,
				intervals});

	}
	public System.IAsyncResult Beginset_retry_interval(string [] clients,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_retry_interval", new object[] {
			clients,
			intervals}, callback, asyncState);
	}
	public void Endset_retry_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void set_server_address(
		string [] clients,
		string [] addresses
	) {
		this.Invoke("set_server_address", new object [] {
				clients,
				addresses});

	}
	public System.IAsyncResult Beginset_server_address(string [] clients,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_address", new object[] {
			clients,
			addresses}, callback, asyncState);
	}
	public void Endset_server_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoClient", 
		RequestNamespace="urn:iControl:System/CryptoClient", ResponseNamespace="urn:iControl:System/CryptoClient")]
	public void set_server_port(
		string [] clients,
		long [] ports
	) {
		this.Invoke("set_server_port", new object [] {
				clients,
				ports});

	}
	public System.IAsyncResult Beginset_server_port(string [] clients,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_port", new object[] {
			clients,
			ports}, callback, asyncState);
	}
	public void Endset_server_port(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CryptoClient.CryptoClientStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemCryptoClientCryptoClientStatisticEntry
	{
		private string clientField;
		public string client
		{
			get { return this.clientField; }
			set { this.clientField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CryptoClient.CryptoClientStatistics", Namespace = "urn:iControl")]
	public partial class SystemCryptoClientCryptoClientStatistics
	{
		private SystemCryptoClientCryptoClientStatisticEntry [] statisticsField;
		public SystemCryptoClientCryptoClientStatisticEntry [] statistics
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
