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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.ConnectionsBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemConnectionsConnectionID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemConnectionsActiveConnection))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemConnectionsActiveConnectionV2))]
	public partial class SystemConnections : iControlInterface {
		public SystemConnections() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// delete_active_connection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Connections", 
		RequestNamespace="urn:iControl:System/Connections", ResponseNamespace="urn:iControl:System/Connections")]
	public void delete_active_connection(
		SystemConnectionsConnectionID [] connections
	) {
		this.Invoke("delete_active_connection", new object [] {
				connections});

	}
	public System.IAsyncResult Begindelete_active_connection(SystemConnectionsConnectionID [] connections, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_active_connection", new object[] {
			connections}, callback, asyncState);
	}
	public void Enddelete_active_connection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_active_connections
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Connections", 
		RequestNamespace="urn:iControl:System/Connections", ResponseNamespace="urn:iControl:System/Connections")]
	public void delete_all_active_connections(

	) {
		this.Invoke("delete_all_active_connections", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_active_connections(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_active_connections", new object[0], callback, asyncState);
	}
	public void Enddelete_all_active_connections(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_active_connection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Connections", 
		RequestNamespace="urn:iControl:System/Connections", ResponseNamespace="urn:iControl:System/Connections")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemConnectionsActiveConnection [] get_active_connection(
		SystemConnectionsConnectionID [] connections
	) {
		object [] results = this.Invoke("get_active_connection", new object [] {
				connections});
		return ((SystemConnectionsActiveConnection [])(results[0]));
	}
	public System.IAsyncResult Beginget_active_connection(SystemConnectionsConnectionID [] connections, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active_connection", new object[] {
			connections}, callback, asyncState);
	}
	public SystemConnectionsActiveConnection [] Endget_active_connection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemConnectionsActiveConnection [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_active_connection_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Connections", 
		RequestNamespace="urn:iControl:System/Connections", ResponseNamespace="urn:iControl:System/Connections")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemConnectionsActiveConnectionV2 [] get_active_connection_v2(
		SystemConnectionsConnectionID [] connections
	) {
		object [] results = this.Invoke("get_active_connection_v2", new object [] {
				connections});
		return ((SystemConnectionsActiveConnectionV2 [])(results[0]));
	}
	public System.IAsyncResult Beginget_active_connection_v2(SystemConnectionsConnectionID [] connections, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active_connection_v2", new object[] {
			connections}, callback, asyncState);
	}
	public SystemConnectionsActiveConnectionV2 [] Endget_active_connection_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemConnectionsActiveConnectionV2 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_active_connections
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Connections", 
		RequestNamespace="urn:iControl:System/Connections", ResponseNamespace="urn:iControl:System/Connections")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemConnectionsActiveConnection [] get_all_active_connections(

	) {
		object [] results = this.Invoke("get_all_active_connections", new object [0]);
		return ((SystemConnectionsActiveConnection [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_active_connections(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_active_connections", new object[0], callback, asyncState);
	}
	public SystemConnectionsActiveConnection [] Endget_all_active_connections(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemConnectionsActiveConnection [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_active_connections_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Connections", 
		RequestNamespace="urn:iControl:System/Connections", ResponseNamespace="urn:iControl:System/Connections")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemConnectionsActiveConnectionV2 [] get_all_active_connections_v2(

	) {
		object [] results = this.Invoke("get_all_active_connections_v2", new object [0]);
		return ((SystemConnectionsActiveConnectionV2 [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_active_connections_v2(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_active_connections_v2", new object[0], callback, asyncState);
	}
	public SystemConnectionsActiveConnectionV2 [] Endget_all_active_connections_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemConnectionsActiveConnectionV2 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Connections", 
		RequestNamespace="urn:iControl:System/Connections", ResponseNamespace="urn:iControl:System/Connections")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemConnectionsConnectionID [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((SystemConnectionsConnectionID [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public SystemConnectionsConnectionID [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemConnectionsConnectionID [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Connections", 
		RequestNamespace="urn:iControl:System/Connections", ResponseNamespace="urn:iControl:System/Connections")]
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Connections.ActiveConnection", Namespace = "urn:iControl")]
	public partial class SystemConnectionsActiveConnection
	{
		private SystemConnectionsConnectionID connection_idField;
		public SystemConnectionsConnectionID connection_id
		{
			get { return this.connection_idField; }
			set { this.connection_idField = value; }
		}
		private CommonIPPortDefinition serverside_clientField;
		public CommonIPPortDefinition serverside_client
		{
			get { return this.serverside_clientField; }
			set { this.serverside_clientField = value; }
		}
		private CommonIPPortDefinition virtual_pathField;
		public CommonIPPortDefinition virtual_path
		{
			get { return this.virtual_pathField; }
			set { this.virtual_pathField = value; }
		}
		private long unit_idField;
		public long unit_id
		{
			get { return this.unit_idField; }
			set { this.unit_idField = value; }
		}
		private CommonULong64 clientside_bytes_inField;
		public CommonULong64 clientside_bytes_in
		{
			get { return this.clientside_bytes_inField; }
			set { this.clientside_bytes_inField = value; }
		}
		private CommonULong64 clientside_bytes_outField;
		public CommonULong64 clientside_bytes_out
		{
			get { return this.clientside_bytes_outField; }
			set { this.clientside_bytes_outField = value; }
		}
		private CommonULong64 clientside_packets_inField;
		public CommonULong64 clientside_packets_in
		{
			get { return this.clientside_packets_inField; }
			set { this.clientside_packets_inField = value; }
		}
		private CommonULong64 clientside_packets_outField;
		public CommonULong64 clientside_packets_out
		{
			get { return this.clientside_packets_outField; }
			set { this.clientside_packets_outField = value; }
		}
		private CommonULong64 serverside_bytes_inField;
		public CommonULong64 serverside_bytes_in
		{
			get { return this.serverside_bytes_inField; }
			set { this.serverside_bytes_inField = value; }
		}
		private CommonULong64 serverside_bytes_outField;
		public CommonULong64 serverside_bytes_out
		{
			get { return this.serverside_bytes_outField; }
			set { this.serverside_bytes_outField = value; }
		}
		private CommonULong64 serverside_packets_inField;
		public CommonULong64 serverside_packets_in
		{
			get { return this.serverside_packets_inField; }
			set { this.serverside_packets_inField = value; }
		}
		private CommonULong64 serverside_packets_outField;
		public CommonULong64 serverside_packets_out
		{
			get { return this.serverside_packets_outField; }
			set { this.serverside_packets_outField = value; }
		}
		private long idle_timeField;
		public long idle_time
		{
			get { return this.idle_timeField; }
			set { this.idle_timeField = value; }
		}
		private long idle_timeoutField;
		public long idle_timeout
		{
			get { return this.idle_timeoutField; }
			set { this.idle_timeoutField = value; }
		}
		private string lasthop_infoField;
		public string lasthop_info
		{
			get { return this.lasthop_infoField; }
			set { this.lasthop_infoField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Connections.ActiveConnectionV2", Namespace = "urn:iControl")]
	public partial class SystemConnectionsActiveConnectionV2
	{
		private SystemConnectionsConnectionID connection_idField;
		public SystemConnectionsConnectionID connection_id
		{
			get { return this.connection_idField; }
			set { this.connection_idField = value; }
		}
		private CommonIPPortDefinition serverside_clientField;
		public CommonIPPortDefinition serverside_client
		{
			get { return this.serverside_clientField; }
			set { this.serverside_clientField = value; }
		}
		private CommonIPPortDefinition virtual_pathField;
		public CommonIPPortDefinition virtual_path
		{
			get { return this.virtual_pathField; }
			set { this.virtual_pathField = value; }
		}
		private string traffic_groupField;
		public string traffic_group
		{
			get { return this.traffic_groupField; }
			set { this.traffic_groupField = value; }
		}
		private CommonULong64 clientside_bytes_inField;
		public CommonULong64 clientside_bytes_in
		{
			get { return this.clientside_bytes_inField; }
			set { this.clientside_bytes_inField = value; }
		}
		private CommonULong64 clientside_bytes_outField;
		public CommonULong64 clientside_bytes_out
		{
			get { return this.clientside_bytes_outField; }
			set { this.clientside_bytes_outField = value; }
		}
		private CommonULong64 clientside_packets_inField;
		public CommonULong64 clientside_packets_in
		{
			get { return this.clientside_packets_inField; }
			set { this.clientside_packets_inField = value; }
		}
		private CommonULong64 clientside_packets_outField;
		public CommonULong64 clientside_packets_out
		{
			get { return this.clientside_packets_outField; }
			set { this.clientside_packets_outField = value; }
		}
		private CommonULong64 serverside_bytes_inField;
		public CommonULong64 serverside_bytes_in
		{
			get { return this.serverside_bytes_inField; }
			set { this.serverside_bytes_inField = value; }
		}
		private CommonULong64 serverside_bytes_outField;
		public CommonULong64 serverside_bytes_out
		{
			get { return this.serverside_bytes_outField; }
			set { this.serverside_bytes_outField = value; }
		}
		private CommonULong64 serverside_packets_inField;
		public CommonULong64 serverside_packets_in
		{
			get { return this.serverside_packets_inField; }
			set { this.serverside_packets_inField = value; }
		}
		private CommonULong64 serverside_packets_outField;
		public CommonULong64 serverside_packets_out
		{
			get { return this.serverside_packets_outField; }
			set { this.serverside_packets_outField = value; }
		}
		private long idle_timeField;
		public long idle_time
		{
			get { return this.idle_timeField; }
			set { this.idle_timeField = value; }
		}
		private long idle_timeoutField;
		public long idle_timeout
		{
			get { return this.idle_timeoutField; }
			set { this.idle_timeoutField = value; }
		}
		private string lasthop_infoField;
		public string lasthop_info
		{
			get { return this.lasthop_infoField; }
			set { this.lasthop_infoField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Connections.ConnectionID", Namespace = "urn:iControl")]
	public partial class SystemConnectionsConnectionID
	{
		private CommonIPPortDefinition clientside_clientField;
		public CommonIPPortDefinition clientside_client
		{
			get { return this.clientside_clientField; }
			set { this.clientside_clientField = value; }
		}
		private CommonIPPortDefinition clientside_serverField;
		public CommonIPPortDefinition clientside_server
		{
			get { return this.clientside_serverField; }
			set { this.clientside_serverField = value; }
		}
		private CommonIPPortDefinition serverside_serverField;
		public CommonIPPortDefinition serverside_server
		{
			get { return this.serverside_serverField; }
			set { this.serverside_serverField = value; }
		}
		private CommonProtocolType protocolField;
		public CommonProtocolType protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}
	};

}
