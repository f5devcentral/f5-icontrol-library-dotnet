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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.ARPBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingARPStaticEntry))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingARPARPStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingARPNDPStatistics))]
	public partial class NetworkingARP : iControlInterface {
		public NetworkingARP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_static_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	public void add_static_entry(
		NetworkingARPStaticEntry [] entries
	) {
		this.Invoke("add_static_entry", new object [] {
				entries});

	}
	public System.IAsyncResult Beginadd_static_entry(NetworkingARPStaticEntry [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_static_entry", new object[] {
			entries}, callback, asyncState);
	}
	public void Endadd_static_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_static_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	public void create_static_entry(
		string [] entries,
		string [] addresses,
		string [] macs
	) {
		this.Invoke("create_static_entry", new object [] {
				entries,
				addresses,
				macs});

	}
	public System.IAsyncResult Begincreate_static_entry(string [] entries,string [] addresses,string [] macs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_static_entry", new object[] {
			entries,
			addresses,
			macs}, callback, asyncState);
	}
	public void Endcreate_static_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_dynamic_arps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	public void delete_all_dynamic_arps(

	) {
		this.Invoke("delete_all_dynamic_arps", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_dynamic_arps(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_dynamic_arps", new object[0], callback, asyncState);
	}
	public void Enddelete_all_dynamic_arps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_dynamic_ndps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	public void delete_all_dynamic_ndps(

	) {
		this.Invoke("delete_all_dynamic_ndps", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_dynamic_ndps(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_dynamic_ndps", new object[0], callback, asyncState);
	}
	public void Enddelete_all_dynamic_ndps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_static_entries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	public void delete_all_static_entries(

	) {
		this.Invoke("delete_all_static_entries", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_static_entries(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_static_entries", new object[0], callback, asyncState);
	}
	public void Enddelete_all_static_entries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_static_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	public void delete_static_entry(
		NetworkingARPStaticEntry [] entries
	) {
		this.Invoke("delete_static_entry", new object [] {
				entries});

	}
	public System.IAsyncResult Begindelete_static_entry(NetworkingARPStaticEntry [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_static_entry", new object[] {
			entries}, callback, asyncState);
	}
	public void Enddelete_static_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_static_entry_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	public void delete_static_entry_v2(
		string [] entries
	) {
		this.Invoke("delete_static_entry_v2", new object [] {
				entries});

	}
	public System.IAsyncResult Begindelete_static_entry_v2(string [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_static_entry_v2", new object[] {
			entries}, callback, asyncState);
	}
	public void Enddelete_static_entry_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_dynamic_arp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingARPARPStatistics get_dynamic_arp(
		string [] arp_addresses
	) {
		object [] results = this.Invoke("get_dynamic_arp", new object [] {
				arp_addresses});
		return ((NetworkingARPARPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_arp(string [] arp_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_arp", new object[] {
			arp_addresses}, callback, asyncState);
	}
	public NetworkingARPARPStatistics Endget_dynamic_arp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingARPARPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_ndp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingARPNDPStatistics get_dynamic_ndp(
		string [] ndp_addresses
	) {
		object [] results = this.Invoke("get_dynamic_ndp", new object [] {
				ndp_addresses});
		return ((NetworkingARPNDPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_ndp(string [] ndp_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_ndp", new object[] {
			ndp_addresses}, callback, asyncState);
	}
	public NetworkingARPNDPStatistics Endget_dynamic_ndp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingARPNDPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingARPStaticEntry [] get_static_entry(

	) {
		object [] results = this.Invoke("get_static_entry", new object [0]);
		return ((NetworkingARPStaticEntry [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_entry(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_entry", new object[0], callback, asyncState);
	}
	public NetworkingARPStaticEntry [] Endget_static_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingARPStaticEntry [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_entry_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_entry_address(
		string [] entries
	) {
		object [] results = this.Invoke("get_static_entry_address", new object [] {
				entries});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_entry_address(string [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_entry_address", new object[] {
			entries}, callback, asyncState);
	}
	public string [] Endget_static_entry_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_entry_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_entry_description(
		string [] entries
	) {
		object [] results = this.Invoke("get_static_entry_description", new object [] {
				entries});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_entry_description(string [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_entry_description", new object[] {
			entries}, callback, asyncState);
	}
	public string [] Endget_static_entry_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_entry_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_entry_list(

	) {
		object [] results = this.Invoke("get_static_entry_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_entry_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_entry_list", new object[0], callback, asyncState);
	}
	public string [] Endget_static_entry_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_entry_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_entry_mac_address(
		string [] entries
	) {
		object [] results = this.Invoke("get_static_entry_mac_address", new object [] {
				entries});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_entry_mac_address(string [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_entry_mac_address", new object[] {
			entries}, callback, asyncState);
	}
	public string [] Endget_static_entry_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
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
	// set_static_entry_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	public void set_static_entry_description(
		string [] entries,
		string [] descriptions
	) {
		this.Invoke("set_static_entry_description", new object [] {
				entries,
				descriptions});

	}
	public System.IAsyncResult Beginset_static_entry_description(string [] entries,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_entry_description", new object[] {
			entries,
			descriptions}, callback, asyncState);
	}
	public void Endset_static_entry_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_entry_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ARP", 
		RequestNamespace="urn:iControl:Networking/ARP", ResponseNamespace="urn:iControl:Networking/ARP")]
	public void set_static_entry_mac_address(
		string [] entries,
		string [] macs
	) {
		this.Invoke("set_static_entry_mac_address", new object [] {
				entries,
				macs});

	}
	public System.IAsyncResult Beginset_static_entry_mac_address(string [] entries,string [] macs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_entry_mac_address", new object[] {
			entries,
			macs}, callback, asyncState);
	}
	public void Endset_static_entry_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ARP.NDPState", Namespace = "urn:iControl")]
	public enum NetworkingARPNDPState
	{
		NDP_STATE_INCOMPLETE,
		NDP_STATE_REACHABLE,
		NDP_STATE_STALE,
		NDP_STATE_DELAY,
		NDP_STATE_PROBE,
		NDP_STATE_PERMANENT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ARP.ARPEntry", Namespace = "urn:iControl")]
	public partial class NetworkingARPARPEntry
	{
		private string arp_addressField;
		public string arp_address
		{
			get { return this.arp_addressField; }
			set { this.arp_addressField = value; }
		}
		private string mac_addressField;
		public string mac_address
		{
			get { return this.mac_addressField; }
			set { this.mac_addressField = value; }
		}
		private string vlanField;
		public string vlan
		{
			get { return this.vlanField; }
			set { this.vlanField = value; }
		}
		private long expirationField;
		public long expiration
		{
			get { return this.expirationField; }
			set { this.expirationField = value; }
		}
		private bool is_downField;
		public bool is_down
		{
			get { return this.is_downField; }
			set { this.is_downField = value; }
		}
		private bool is_dynamicField;
		public bool is_dynamic
		{
			get { return this.is_dynamicField; }
			set { this.is_dynamicField = value; }
		}
		private bool is_resolvedField;
		public bool is_resolved
		{
			get { return this.is_resolvedField; }
			set { this.is_resolvedField = value; }
		}
		private bool is_keepaliveField;
		public bool is_keepalive
		{
			get { return this.is_keepaliveField; }
			set { this.is_keepaliveField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ARP.ARPStatistics", Namespace = "urn:iControl")]
	public partial class NetworkingARPARPStatistics
	{
		private NetworkingARPARPEntry [] statisticsField;
		public NetworkingARPARPEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ARP.NDPEntry", Namespace = "urn:iControl")]
	public partial class NetworkingARPNDPEntry
	{
		private string ndp_addressField;
		public string ndp_address
		{
			get { return this.ndp_addressField; }
			set { this.ndp_addressField = value; }
		}
		private string mac_addressField;
		public string mac_address
		{
			get { return this.mac_addressField; }
			set { this.mac_addressField = value; }
		}
		private string vlanField;
		public string vlan
		{
			get { return this.vlanField; }
			set { this.vlanField = value; }
		}
		private long expirationField;
		public long expiration
		{
			get { return this.expirationField; }
			set { this.expirationField = value; }
		}
		private bool is_routerField;
		public bool is_router
		{
			get { return this.is_routerField; }
			set { this.is_routerField = value; }
		}
		private NetworkingARPNDPState stateField;
		public NetworkingARPNDPState state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ARP.NDPStatistics", Namespace = "urn:iControl")]
	public partial class NetworkingARPNDPStatistics
	{
		private NetworkingARPNDPEntry [] statisticsField;
		public NetworkingARPNDPEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ARP.StaticEntry", Namespace = "urn:iControl")]
	public partial class NetworkingARPStaticEntry
	{
		private string addressField;
		public string address
		{
			get { return this.addressField; }
			set { this.addressField = value; }
		}
		private string mac_addressField;
		public string mac_address
		{
			get { return this.mac_addressField; }
			set { this.mac_addressField = value; }
		}
	};

}
