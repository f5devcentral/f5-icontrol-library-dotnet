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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.HAStatusBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemHAStatusEntryID))]
	public partial class SystemHAStatus : iControlInterface {
		public SystemHAStatus() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAStatus", 
		RequestNamespace="urn:iControl:System/HAStatus", ResponseNamespace="urn:iControl:System/HAStatus")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemHAStatusEntryID [] [] get_entry(
		bool [] peers
	) {
		object [] results = this.Invoke("get_entry", new object [] {
				peers});
		return ((SystemHAStatusEntryID [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry(bool [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry", new object[] {
			peers}, callback, asyncState);
	}
	public SystemHAStatusEntryID [] [] Endget_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemHAStatusEntryID [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAStatus", 
		RequestNamespace="urn:iControl:System/HAStatus", ResponseNamespace="urn:iControl:System/HAStatus")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonHAAction [] [] get_entry_action(
		bool [] peers,
		SystemHAStatusEntryID [] [] ids
	) {
		object [] results = this.Invoke("get_entry_action", new object [] {
				peers,
				ids});
		return ((CommonHAAction [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_action(bool [] peers,SystemHAStatusEntryID [] [] ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_action", new object[] {
			peers,
			ids}, callback, asyncState);
	}
	public CommonHAAction [] [] Endget_entry_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonHAAction [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_action_required_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAStatus", 
		RequestNamespace="urn:iControl:System/HAStatus", ResponseNamespace="urn:iControl:System/HAStatus")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_entry_action_required_state(
		bool [] peers,
		SystemHAStatusEntryID [] [] ids
	) {
		object [] results = this.Invoke("get_entry_action_required_state", new object [] {
				peers,
				ids});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_action_required_state(bool [] peers,SystemHAStatusEntryID [] [] ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_action_required_state", new object[] {
			peers,
			ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_entry_action_required_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_data
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAStatus", 
		RequestNamespace="urn:iControl:System/HAStatus", ResponseNamespace="urn:iControl:System/HAStatus")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_entry_data(
		bool [] peers,
		SystemHAStatusEntryID [] [] ids
	) {
		object [] results = this.Invoke("get_entry_data", new object [] {
				peers,
				ids});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_data(bool [] peers,SystemHAStatusEntryID [] [] ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_data", new object[] {
			peers,
			ids}, callback, asyncState);
	}
	public long [] [] Endget_entry_data(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAStatus", 
		RequestNamespace="urn:iControl:System/HAStatus", ResponseNamespace="urn:iControl:System/HAStatus")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_entry_enabled_state(
		bool [] peers,
		SystemHAStatusEntryID [] [] ids
	) {
		object [] results = this.Invoke("get_entry_enabled_state", new object [] {
				peers,
				ids});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_enabled_state(bool [] peers,SystemHAStatusEntryID [] [] ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_enabled_state", new object[] {
			peers,
			ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_entry_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_failure_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAStatus", 
		RequestNamespace="urn:iControl:System/HAStatus", ResponseNamespace="urn:iControl:System/HAStatus")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_entry_failure_state(
		bool [] peers,
		SystemHAStatusEntryID [] [] ids
	) {
		object [] results = this.Invoke("get_entry_failure_state", new object [] {
				peers,
				ids});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_failure_state(bool [] peers,SystemHAStatusEntryID [] [] ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_failure_state", new object[] {
			peers,
			ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_entry_failure_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAStatus", 
		RequestNamespace="urn:iControl:System/HAStatus", ResponseNamespace="urn:iControl:System/HAStatus")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_entry_timeout(
		bool [] peers,
		SystemHAStatusEntryID [] [] ids
	) {
		object [] results = this.Invoke("get_entry_timeout", new object [] {
				peers,
				ids});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_timeout(bool [] peers,SystemHAStatusEntryID [] [] ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_timeout", new object[] {
			peers,
			ids}, callback, asyncState);
	}
	public long [] [] Endget_entry_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAStatus", 
		RequestNamespace="urn:iControl:System/HAStatus", ResponseNamespace="urn:iControl:System/HAStatus")]
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.HAStatus.Feature", Namespace = "urn:iControl")]
	public enum SystemHAStatusFeature
	{
		FEATURE_ASM_CONFIGURATION,
		FEATURE_CLUSTER_MEMBER,
		FEATURE_CLUSTER_MIN_UP_MEMBERS,
		FEATURE_CLUSTER_TIME_SYNC,
		FEATURE_DAEMON,
		FEATURE_DAEMON_HEARTBEAT,
		FEATURE_FIPS,
		FEATURE_FORCED_OFFLINE,
		FEATURE_GROUP_SCORE,
		FEATURE_HARDWARE_FAILOVER,
		FEATURE_HSB,
		FEATURE_LICENSE,
		FEATURE_MPI,
		FEATURE_MYSQL,
		FEATURE_NETWORK_FAILOVER,
		FEATURE_OVERDOG,
		FEATURE_PEER_GROUP_SCORE,
		FEATURE_POOL_MIN_UP_MEMBERS,
		FEATURE_REBOOT,
		FEATURE_SECONDARY_SOD,
		FEATURE_SOD_CONFIGURATION,
		FEATURE_SOFTWARE_UPDATE,
		FEATURE_SWITCHBOARD,
		FEATURE_TMM_DETECTED,
		FEATURE_TMM_READY,
		FEATURE_UNKNOWN,
		FEATURE_VLAN,
		FEATURE_HYPERVISOR_OFFLINE,
		FEATURE_COMPRESSION_FAILSAFE,
		FEATURE_CRYPTO_FAILSAFE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.HAStatus.EntryID", Namespace = "urn:iControl")]
	public partial class SystemHAStatusEntryID
	{
		private SystemHAStatusFeature ha_featureField;
		public SystemHAStatusFeature ha_feature
		{
			get { return this.ha_featureField; }
			set { this.ha_featureField = value; }
		}
		private string ha_keyField;
		public string ha_key
		{
			get { return this.ha_keyField; }
			set { this.ha_keyField = value; }
		}
		private long slotField;
		public long slot
		{
			get { return this.slotField; }
			set { this.slotField = value; }
		}
	};

}
