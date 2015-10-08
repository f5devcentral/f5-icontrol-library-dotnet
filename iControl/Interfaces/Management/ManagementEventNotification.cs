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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.EventNotificationBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementEventNotificationEventSource))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementEventNotificationEventData))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	public partial class ManagementEventNotification : iControlInterface {
		public ManagementEventNotification() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// events_occurred
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventNotification", 
		RequestNamespace="urn:iControl:Management/EventNotification", ResponseNamespace="urn:iControl:Management/EventNotification")]
	public void events_occurred(
		ManagementEventNotificationEventSource event_source,
		string subscription_id,
		ManagementEventNotificationEventData [] event_data_list,
		CommonTimeStamp time_stamp
	) {
		this.Invoke("events_occurred", new object [] {
				event_source,
				subscription_id,
				event_data_list,
				time_stamp});

	}
	public System.IAsyncResult Beginevents_occurred(ManagementEventNotificationEventSource event_source,string subscription_id,ManagementEventNotificationEventData [] event_data_list,CommonTimeStamp time_stamp, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("events_occurred", new object[] {
			event_source,
			subscription_id,
			event_data_list,
			time_stamp}, callback, asyncState);
	}
	public void Endevents_occurred(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventNotification.EventDataType", Namespace = "urn:iControl")]
	public enum ManagementEventNotificationEventDataType
	{
		DATATYPE_BITS,
		DATATYPE_BLOB,
		DATATYPE_BOOL,
		DATATYPE_BYTE,
		DATATYPE_DATE,
		DATATYPE_IP_ADDRESS,
		DATATYPE_LONG,
		DATATYPE_MAC,
		DATATYPE_PTR,
		DATATYPE_SERVICE,
		DATATYPE_STRING,
		DATATYPE_TAG,
		DATATYPE_TIME,
		DATATYPE_ULONG,
		DATATYPE_UWORD,
		DATATYPE_UQUAD,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventNotification.EventData", Namespace = "urn:iControl")]
	public partial class ManagementEventNotificationEventData
	{
		private string usernameField;
		public string username
		{
			get { return this.usernameField; }
			set { this.usernameField = value; }
		}
		private long sequence_numberField;
		public long sequence_number
		{
			get { return this.sequence_numberField; }
			set { this.sequence_numberField = value; }
		}
		private ManagementEventSubscriptionEventType event_typeField;
		public ManagementEventSubscriptionEventType event_type
		{
			get { return this.event_typeField; }
			set { this.event_typeField = value; }
		}
		private ManagementEventSubscriptionObjectType object_typeField;
		public ManagementEventSubscriptionObjectType object_type
		{
			get { return this.object_typeField; }
			set { this.object_typeField = value; }
		}
		private ManagementEventNotificationEventDataItem [] event_data_item_listField;
		public ManagementEventNotificationEventDataItem [] event_data_item_list
		{
			get { return this.event_data_item_listField; }
			set { this.event_data_item_listField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventNotification.EventDataItem", Namespace = "urn:iControl")]
	public partial class ManagementEventNotificationEventDataItem
	{
		private string event_data_nameField;
		public string event_data_name
		{
			get { return this.event_data_nameField; }
			set { this.event_data_nameField = value; }
		}
		private ManagementEventNotificationEventDataType event_data_typeField;
		public ManagementEventNotificationEventDataType event_data_type
		{
			get { return this.event_data_typeField; }
			set { this.event_data_typeField = value; }
		}
		private string event_data_valueField;
		public string event_data_value
		{
			get { return this.event_data_valueField; }
			set { this.event_data_valueField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventNotification.EventSource", Namespace = "urn:iControl")]
	public partial class ManagementEventNotificationEventSource
	{
		private string system_idField;
		public string system_id
		{
			get { return this.system_idField; }
			set { this.system_idField = value; }
		}
		private string urlField;
		public string url
		{
			get { return this.urlField; }
			set { this.urlField = value; }
		}
	};

}
