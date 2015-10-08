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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.FailoverBinding", Namespace="urn:iControl")]
	public partial class SystemFailover : iControlInterface {
		public SystemFailover() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_failover_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemFailoverFailoverMode get_failover_mode(

	) {
		object [] results = this.Invoke("get_failover_mode", new object [0]);
		return ((SystemFailoverFailoverMode)(results[0]));
	}
	public System.IAsyncResult Beginget_failover_mode(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_failover_mode", new object[0], callback, asyncState);
	}
	public SystemFailoverFailoverMode Endget_failover_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemFailoverFailoverMode)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_failover_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemFailoverFailoverState get_failover_state(

	) {
		object [] results = this.Invoke("get_failover_state", new object [0]);
		return ((SystemFailoverFailoverState)(results[0]));
	}
	public System.IAsyncResult Beginget_failover_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_failover_state", new object[0], callback, asyncState);
	}
	public SystemFailoverFailoverState Endget_failover_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemFailoverFailoverState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_peer_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_peer_address(

	) {
		object [] results = this.Invoke("get_peer_address", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_peer_address(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer_address", new object[0], callback, asyncState);
	}
	public string [] Endget_peer_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
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
	// is_redundant
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool is_redundant(

	) {
		object [] results = this.Invoke("is_redundant", new object [0]);
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginis_redundant(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_redundant", new object[0], callback, asyncState);
	}
	public bool Endis_redundant(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_failback
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	public void set_failback(

	) {
		this.Invoke("set_failback", new object [0]);

	}
	public System.IAsyncResult Beginset_failback(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_failback", new object[0], callback, asyncState);
	}
	public void Endset_failback(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_offline
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	public void set_offline(

	) {
		this.Invoke("set_offline", new object [0]);

	}
	public System.IAsyncResult Beginset_offline(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_offline", new object[0], callback, asyncState);
	}
	public void Endset_offline(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_offline_release
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	public void set_offline_release(

	) {
		this.Invoke("set_offline_release", new object [0]);

	}
	public System.IAsyncResult Beginset_offline_release(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_offline_release", new object[0], callback, asyncState);
	}
	public void Endset_offline_release(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_standby
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	public void set_standby(

	) {
		this.Invoke("set_standby", new object [0]);

	}
	public System.IAsyncResult Beginset_standby(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_standby", new object[0], callback, asyncState);
	}
	public void Endset_standby(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_standby_to_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	public void set_standby_to_device(
		string device
	) {
		this.Invoke("set_standby_to_device", new object [] {
				device});

	}
	public System.IAsyncResult Beginset_standby_to_device(string device, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_standby_to_device", new object[] {
			device}, callback, asyncState);
	}
	public void Endset_standby_to_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_standby_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	public void set_standby_traffic_group(
		string [] traffic_groups
	) {
		this.Invoke("set_standby_traffic_group", new object [] {
				traffic_groups});

	}
	public System.IAsyncResult Beginset_standby_traffic_group(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_standby_traffic_group", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public void Endset_standby_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_standby_traffic_group_to_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Failover", 
		RequestNamespace="urn:iControl:System/Failover", ResponseNamespace="urn:iControl:System/Failover")]
	public void set_standby_traffic_group_to_device(
		string [] traffic_groups,
		string device
	) {
		this.Invoke("set_standby_traffic_group_to_device", new object [] {
				traffic_groups,
				device});

	}
	public System.IAsyncResult Beginset_standby_traffic_group_to_device(string [] traffic_groups,string device, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_standby_traffic_group_to_device", new object[] {
			traffic_groups,
			device}, callback, asyncState);
	}
	public void Endset_standby_traffic_group_to_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Failover.FailoverMode", Namespace = "urn:iControl")]
	public enum SystemFailoverFailoverMode
	{
		FAILOVER_MODE_ACTIVE_ACTIVE,
		FAILOVER_MODE_ACTIVE_STANDBY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Failover.FailoverState", Namespace = "urn:iControl")]
	public enum SystemFailoverFailoverState
	{
		FAILOVER_STATE_STANDBY,
		FAILOVER_STATE_ACTIVE,
		FAILOVER_STATE_FORCED_OFFLINE,
		FAILOVER_STATE_OFFLINE,
		FAILOVER_STATE_UNKNOWN,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
