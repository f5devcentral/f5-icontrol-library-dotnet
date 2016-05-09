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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.CryptoServerBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemCryptoServerCryptoServerStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSystemProfileAttribute))]
	public partial class SystemCryptoServer : iControlInterface {
		public SystemCryptoServer() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_client_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	public void add_client_address(
		string [] servers,
		string [] [] addresses
	) {
		this.Invoke("add_client_address", new object [] {
				servers,
				addresses});

	}
	public System.IAsyncResult Beginadd_client_address(string [] servers,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_client_address", new object[] {
			servers,
			addresses}, callback, asyncState);
	}
	public void Endadd_client_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	public void add_profile(
		string [] servers,
		string [] [] profiles
	) {
		this.Invoke("add_profile", new object [] {
				servers,
				profiles});

	}
	public System.IAsyncResult Beginadd_profile(string [] servers,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_profile", new object[] {
			servers,
			profiles}, callback, asyncState);
	}
	public void Endadd_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	public void create(
		string [] servers,
		string [] addresses,
		long [] ports
	) {
		this.Invoke("create", new object [] {
				servers,
				addresses,
				ports});

	}
	public System.IAsyncResult Begincreate(string [] servers,string [] addresses,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			servers,
			addresses,
			ports}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemCryptoServerCryptoServerStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((SystemCryptoServerCryptoServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public SystemCryptoServerCryptoServerStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemCryptoServerCryptoServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_client_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_client_address(
		string [] servers
	) {
		object [] results = this.Invoke("get_client_address", new object [] {
				servers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_client_address(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_client_address", new object[] {
			servers}, callback, asyncState);
	}
	public string [] [] Endget_client_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] servers
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
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
	// get_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSystemProfileAttribute [] [] get_profile(
		string [] servers
	) {
		object [] results = this.Invoke("get_profile", new object [] {
				servers});
		return ((SystemSystemProfileAttribute [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_profile(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_profile", new object[] {
			servers}, callback, asyncState);
	}
	public SystemSystemProfileAttribute [] [] Endget_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSystemProfileAttribute [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemCryptoServerCryptoServerStatistics get_statistics(
		string [] servers
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				servers});
		return ((SystemCryptoServerCryptoServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			servers}, callback, asyncState);
	}
	public SystemCryptoServerCryptoServerStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemCryptoServerCryptoServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
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
	// remove_all_client_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	public void remove_all_client_addresses(
		string [] servers
	) {
		this.Invoke("remove_all_client_addresses", new object [] {
				servers});

	}
	public System.IAsyncResult Beginremove_all_client_addresses(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_client_addresses", new object[] {
			servers}, callback, asyncState);
	}
	public void Endremove_all_client_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	public void remove_all_profiles(
		string [] servers
	) {
		this.Invoke("remove_all_profiles", new object [] {
				servers});

	}
	public System.IAsyncResult Beginremove_all_profiles(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_profiles", new object[] {
			servers}, callback, asyncState);
	}
	public void Endremove_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_client_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	public void remove_client_address(
		string [] servers,
		string [] [] addresses
	) {
		this.Invoke("remove_client_address", new object [] {
				servers,
				addresses});

	}
	public System.IAsyncResult Beginremove_client_address(string [] servers,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_client_address", new object[] {
			servers,
			addresses}, callback, asyncState);
	}
	public void Endremove_client_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	public void remove_profile(
		string [] servers,
		string [] [] profiles
	) {
		this.Invoke("remove_profile", new object [] {
				servers,
				profiles});

	}
	public System.IAsyncResult Beginremove_profile(string [] servers,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_profile", new object[] {
			servers,
			profiles}, callback, asyncState);
	}
	public void Endremove_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
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
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
	public void set_enabled_state(
		string [] servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				servers,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			servers,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CryptoServer", 
		RequestNamespace="urn:iControl:System/CryptoServer", ResponseNamespace="urn:iControl:System/CryptoServer")]
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CryptoServer.CryptoServerStatisticEntry", Namespace = "urn:iControl")]
	public partial class SystemCryptoServerCryptoServerStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CryptoServer.CryptoServerStatistics", Namespace = "urn:iControl")]
	public partial class SystemCryptoServerCryptoServerStatistics
	{
		private SystemCryptoServerCryptoServerStatisticEntry [] statisticsField;
		public SystemCryptoServerCryptoServerStatisticEntry [] statistics
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
