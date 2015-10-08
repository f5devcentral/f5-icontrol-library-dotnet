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
	[System.Web.Services.WebServiceBindingAttribute(Name="PEM.SubscriberBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(PEMSubscriberSessionDBKey))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(PEMSubscriberSessionDBEntry))]
	public partial class PEMSubscriber : iControlInterface {
		public PEMSubscriber() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	public void add_policy(
		string [] subscribers,
		string [] [] policies
	) {
		this.Invoke("add_policy", new object [] {
				subscribers,
				policies});

	}
	public System.IAsyncResult Beginadd_policy(string [] subscribers,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_policy", new object[] {
			subscribers,
			policies}, callback, asyncState);
	}
	public void Endadd_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	public void create(
		string [] subscribers,
		PEMSubscriberSubscriberIdType [] types,
		string [] [] policies
	) {
		this.Invoke("create", new object [] {
				subscribers,
				types,
				policies});

	}
	public System.IAsyncResult Begincreate(string [] subscribers,PEMSubscriberSubscriberIdType [] types,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			subscribers,
			types,
			policies}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_subscribers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	public void delete_all_subscribers(

	) {
		this.Invoke("delete_all_subscribers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_subscribers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_subscribers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_subscribers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_sessiondb_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	public void delete_sessiondb_entry(
		PEMSubscriberSessionDBKey [] keys
	) {
		this.Invoke("delete_sessiondb_entry", new object [] {
				keys});

	}
	public System.IAsyncResult Begindelete_sessiondb_entry(PEMSubscriberSessionDBKey [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_sessiondb_entry", new object[] {
			keys}, callback, asyncState);
	}
	public void Enddelete_sessiondb_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_subscriber
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	public void delete_subscriber(
		string [] subscribers
	) {
		this.Invoke("delete_subscriber", new object [] {
				subscribers});

	}
	public System.IAsyncResult Begindelete_subscriber(string [] subscribers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_subscriber", new object[] {
			subscribers}, callback, asyncState);
	}
	public void Enddelete_subscriber(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_ip_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ip_address(
		string [] subscribers
	) {
		object [] results = this.Invoke("get_ip_address", new object [] {
				subscribers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_address(string [] subscribers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_address", new object[] {
			subscribers}, callback, asyncState);
	}
	public string [] Endget_ip_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
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
	// get_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_policy(
		string [] subscribers
	) {
		object [] results = this.Invoke("get_policy", new object [] {
				subscribers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_policy(string [] subscribers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_policy", new object[] {
			subscribers}, callback, asyncState);
	}
	public string [] [] Endget_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sessiondb_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMSubscriberSessionDBEntry [] [] get_sessiondb_entry(
		PEMSubscriberSessionDBKey [] keys
	) {
		object [] results = this.Invoke("get_sessiondb_entry", new object [] {
				keys});
		return ((PEMSubscriberSessionDBEntry [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_sessiondb_entry(PEMSubscriberSessionDBKey [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sessiondb_entry", new object[] {
			keys}, callback, asyncState);
	}
	public PEMSubscriberSessionDBEntry [] [] Endget_sessiondb_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMSubscriberSessionDBEntry [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_subscriber_id_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMSubscriberSubscriberIdType [] get_subscriber_id_type(
		string [] subscribers
	) {
		object [] results = this.Invoke("get_subscriber_id_type", new object [] {
				subscribers});
		return ((PEMSubscriberSubscriberIdType [])(results[0]));
	}
	public System.IAsyncResult Beginget_subscriber_id_type(string [] subscribers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_subscriber_id_type", new object[] {
			subscribers}, callback, asyncState);
	}
	public PEMSubscriberSubscriberIdType [] Endget_subscriber_id_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMSubscriberSubscriberIdType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
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
	// load_subscribers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	public void load_subscribers(
		string [] filenames
	) {
		this.Invoke("load_subscribers", new object [] {
				filenames});

	}
	public System.IAsyncResult Beginload_subscribers(string [] filenames, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("load_subscribers", new object[] {
			filenames}, callback, asyncState);
	}
	public void Endload_subscribers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	public void remove_policy(
		string [] subscribers,
		string [] [] policies
	) {
		this.Invoke("remove_policy", new object [] {
				subscribers,
				policies});

	}
	public System.IAsyncResult Beginremove_policy(string [] subscribers,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_policy", new object[] {
			subscribers,
			policies}, callback, asyncState);
	}
	public void Endremove_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	public void set_ip_address(
		string [] subscribers,
		string [] ips
	) {
		this.Invoke("set_ip_address", new object [] {
				subscribers,
				ips});

	}
	public System.IAsyncResult Beginset_ip_address(string [] subscribers,string [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_address", new object[] {
			subscribers,
			ips}, callback, asyncState);
	}
	public void Endset_ip_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_subscriber_id_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Subscriber", 
		RequestNamespace="urn:iControl:PEM/Subscriber", ResponseNamespace="urn:iControl:PEM/Subscriber")]
	public void set_subscriber_id_type(
		string [] subscribers,
		PEMSubscriberSubscriberIdType [] types
	) {
		this.Invoke("set_subscriber_id_type", new object [] {
				subscribers,
				types});

	}
	public System.IAsyncResult Beginset_subscriber_id_type(string [] subscribers,PEMSubscriberSubscriberIdType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_subscriber_id_type", new object[] {
			subscribers,
			types}, callback, asyncState);
	}
	public void Endset_subscriber_id_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Subscriber.SessionDBPolicyType", Namespace = "urn:iControl")]
	public enum PEMSubscriberSessionDBPolicyType
	{
		SESSIONDB_POLICY_TYPE_UNKNOWN,
		SESSIONDB_POLICY_TYPE_PREDEFINED,
		SESSIONDB_POLICY_TYPE_DYNAMIC,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Subscriber.SessionDBSubscriberType", Namespace = "urn:iControl")]
	public enum PEMSubscriberSessionDBSubscriberType
	{
		SESSIONDB_SUBSCRIBER_TYPE_UNKNOWN,
		SESSIONDB_SUBSCRIBER_TYPE_STATIC,
		SESSIONDB_SUBSCRIBER_TYPE_DYNAMIC,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Subscriber.SubscriberIdType", Namespace = "urn:iControl")]
	public enum PEMSubscriberSubscriberIdType
	{
		SUBSCRIBER_ID_TYPE_UNKNOWN,
		SUBSCRIBER_ID_TYPE_E164,
		SUBSCRIBER_ID_TYPE_IMSI,
		SUBSCRIBER_ID_TYPE_NAI,
		SUBSCRIBER_ID_TYPE_PRIVATE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Subscriber.PolicyInformation", Namespace = "urn:iControl")]
	public partial class PEMSubscriberPolicyInformation
	{
		private string policy_nameField;
		public string policy_name
		{
			get { return this.policy_nameField; }
			set { this.policy_nameField = value; }
		}
		private PEMSubscriberSessionDBPolicyType policy_typeField;
		public PEMSubscriberSessionDBPolicyType policy_type
		{
			get { return this.policy_typeField; }
			set { this.policy_typeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Subscriber.SessionDBEntry", Namespace = "urn:iControl")]
	public partial class PEMSubscriberSessionDBEntry
	{
		private string subscriber_idField;
		public string subscriber_id
		{
			get { return this.subscriber_idField; }
			set { this.subscriber_idField = value; }
		}
		private string session_ipField;
		public string session_ip
		{
			get { return this.session_ipField; }
			set { this.session_ipField = value; }
		}
		private long route_domainField;
		public long route_domain
		{
			get { return this.route_domainField; }
			set { this.route_domainField = value; }
		}
		private PEMSubscriberSessionDBSubscriberType subscriber_typeField;
		public PEMSubscriberSessionDBSubscriberType subscriber_type
		{
			get { return this.subscriber_typeField; }
			set { this.subscriber_typeField = value; }
		}
		private bool provisionedField;
		public bool provisioned
		{
			get { return this.provisionedField; }
			set { this.provisionedField = value; }
		}
		private string subscriber_id_typeField;
		public string subscriber_id_type
		{
			get { return this.subscriber_id_typeField; }
			set { this.subscriber_id_typeField = value; }
		}
		private string calling_station_idField;
		public string calling_station_id
		{
			get { return this.calling_station_idField; }
			set { this.calling_station_idField = value; }
		}
		private string called_station_idField;
		public string called_station_id
		{
			get { return this.called_station_idField; }
			set { this.called_station_idField = value; }
		}
		private string usernameField;
		public string username
		{
			get { return this.usernameField; }
			set { this.usernameField = value; }
		}
		private string tower_idField;
		public string tower_id
		{
			get { return this.tower_idField; }
			set { this.tower_idField = value; }
		}
		private string imsiField;
		public string imsi
		{
			get { return this.imsiField; }
			set { this.imsiField = value; }
		}
		private string imeisvField;
		public string imeisv
		{
			get { return this.imeisvField; }
			set { this.imeisvField = value; }
		}
		private PEMSubscriberPolicyInformation [] policy_informationField;
		public PEMSubscriberPolicyInformation [] policy_information
		{
			get { return this.policy_informationField; }
			set { this.policy_informationField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Subscriber.SessionDBKey", Namespace = "urn:iControl")]
	public partial class PEMSubscriberSessionDBKey
	{
		private string subscriber_idField;
		public string subscriber_id
		{
			get { return this.subscriber_idField; }
			set { this.subscriber_idField = value; }
		}
		private string session_ipField;
		public string session_ip
		{
			get { return this.session_ipField; }
			set { this.session_ipField = value; }
		}
	};

}
