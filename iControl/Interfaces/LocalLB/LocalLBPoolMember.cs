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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.PoolMemberBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberConnectionLimit))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberDynamicRatio))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberMonitorAssociation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberMonitorInstanceState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberMonitorStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberPriority))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberRatio))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberSessionState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberSessionStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonIPPortDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberMonitorAssociationRemoval))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberMemberMonitorState))]
	public partial class LocalLBPoolMember : iControlInterface {
		public LocalLBPoolMember() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberStatistics [] get_all_statistics(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_all_statistics", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberStatistics [] Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberConnectionLimit [] [] get_connection_limit(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_connection_limit", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberConnectionLimit [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_limit(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_limit", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberConnectionLimit [] [] Endget_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberConnectionLimit [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberDynamicRatio [] [] get_dynamic_ratio(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_dynamic_ratio", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberDynamicRatio [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_ratio(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_ratio", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberDynamicRatio [] [] Endget_dynamic_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberDynamicRatio [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberMonitorAssociation [] [] get_monitor_association(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_monitor_association", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberMonitorAssociation [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_association(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_association", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberMonitorAssociation [] [] Endget_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberMonitorAssociation [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberMonitorInstanceState [] [] get_monitor_instance(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_monitor_instance", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberMonitorInstanceState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_instance(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_instance", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberMonitorInstanceState [] [] Endget_monitor_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberMonitorInstanceState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberMonitorStatus [] [] get_monitor_status(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_monitor_status", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberMonitorStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_status(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_status", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberMonitorStatus [] [] Endget_monitor_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberMonitorStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberObjectStatus [] [] get_object_status(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberObjectStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberObjectStatus [] [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberObjectStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberPriority [] [] get_priority(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_priority", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberPriority [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_priority(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_priority", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberPriority [] [] Endget_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberPriority [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberRatio [] [] get_ratio(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_ratio", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberRatio [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ratio(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ratio", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberRatio [] [] Endget_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberRatio [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberSessionState [] [] get_session_enabled_state(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_session_enabled_state", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberSessionState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_session_enabled_state(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_enabled_state", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberSessionState [] [] Endget_session_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberSessionState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberSessionStatus [] [] get_session_status(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_session_status", new object [] {
				pool_names});
		return ((LocalLBPoolMemberMemberSessionStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_session_status(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_status", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberSessionStatus [] [] Endget_session_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberSessionStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberMemberStatistics [] get_statistics(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				pool_names,
				members});
		return ((LocalLBPoolMemberMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public LocalLBPoolMemberMemberStatistics [] Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
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
	// remove_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	public void remove_monitor_association(
		string [] pool_names,
		LocalLBPoolMemberMemberMonitorAssociationRemoval [] [] monitor_associations
	) {
		this.Invoke("remove_monitor_association", new object [] {
				pool_names,
				monitor_associations});

	}
	public System.IAsyncResult Beginremove_monitor_association(string [] pool_names,LocalLBPoolMemberMemberMonitorAssociationRemoval [] [] monitor_associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_monitor_association", new object[] {
			pool_names,
			monitor_associations}, callback, asyncState);
	}
	public void Endremove_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	public void reset_statistics(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		this.Invoke("reset_statistics", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginreset_statistics(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	public void set_connection_limit(
		string [] pool_names,
		LocalLBPoolMemberMemberConnectionLimit [] [] limits
	) {
		this.Invoke("set_connection_limit", new object [] {
				pool_names,
				limits});

	}
	public System.IAsyncResult Beginset_connection_limit(string [] pool_names,LocalLBPoolMemberMemberConnectionLimit [] [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_limit", new object[] {
			pool_names,
			limits}, callback, asyncState);
	}
	public void Endset_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dynamic_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	public void set_dynamic_ratio(
		string [] pool_names,
		LocalLBPoolMemberMemberDynamicRatio [] [] dynamic_ratios
	) {
		this.Invoke("set_dynamic_ratio", new object [] {
				pool_names,
				dynamic_ratios});

	}
	public System.IAsyncResult Beginset_dynamic_ratio(string [] pool_names,LocalLBPoolMemberMemberDynamicRatio [] [] dynamic_ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dynamic_ratio", new object[] {
			pool_names,
			dynamic_ratios}, callback, asyncState);
	}
	public void Endset_dynamic_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	public void set_monitor_association(
		string [] pool_names,
		LocalLBPoolMemberMemberMonitorAssociation [] [] monitor_associations
	) {
		this.Invoke("set_monitor_association", new object [] {
				pool_names,
				monitor_associations});

	}
	public System.IAsyncResult Beginset_monitor_association(string [] pool_names,LocalLBPoolMemberMemberMonitorAssociation [] [] monitor_associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_association", new object[] {
			pool_names,
			monitor_associations}, callback, asyncState);
	}
	public void Endset_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	public void set_monitor_state(
		string [] pool_names,
		LocalLBPoolMemberMemberMonitorState [] [] monitor_states
	) {
		this.Invoke("set_monitor_state", new object [] {
				pool_names,
				monitor_states});

	}
	public System.IAsyncResult Beginset_monitor_state(string [] pool_names,LocalLBPoolMemberMemberMonitorState [] [] monitor_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_state", new object[] {
			pool_names,
			monitor_states}, callback, asyncState);
	}
	public void Endset_monitor_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	public void set_priority(
		string [] pool_names,
		LocalLBPoolMemberMemberPriority [] [] priorities
	) {
		this.Invoke("set_priority", new object [] {
				pool_names,
				priorities});

	}
	public System.IAsyncResult Beginset_priority(string [] pool_names,LocalLBPoolMemberMemberPriority [] [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_priority", new object[] {
			pool_names,
			priorities}, callback, asyncState);
	}
	public void Endset_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	public void set_ratio(
		string [] pool_names,
		LocalLBPoolMemberMemberRatio [] [] ratios
	) {
		this.Invoke("set_ratio", new object [] {
				pool_names,
				ratios});

	}
	public System.IAsyncResult Beginset_ratio(string [] pool_names,LocalLBPoolMemberMemberRatio [] [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ratio", new object[] {
			pool_names,
			ratios}, callback, asyncState);
	}
	public void Endset_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_session_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/PoolMember", 
		RequestNamespace="urn:iControl:LocalLB/PoolMember", ResponseNamespace="urn:iControl:LocalLB/PoolMember")]
	public void set_session_enabled_state(
		string [] pool_names,
		LocalLBPoolMemberMemberSessionState [] [] session_states
	) {
		this.Invoke("set_session_enabled_state", new object [] {
				pool_names,
				session_states});

	}
	public System.IAsyncResult Beginset_session_enabled_state(string [] pool_names,LocalLBPoolMemberMemberSessionState [] [] session_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_session_enabled_state", new object[] {
			pool_names,
			session_states}, callback, asyncState);
	}
	public void Endset_session_enabled_state(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberConnectionLimit", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberConnectionLimit
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private long connection_limitField;
		public long connection_limit
		{
			get { return this.connection_limitField; }
			set { this.connection_limitField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberDynamicRatio", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberDynamicRatio
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private long dynamic_ratioField;
		public long dynamic_ratio
		{
			get { return this.dynamic_ratioField; }
			set { this.dynamic_ratioField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberMonitorAssociation", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberMonitorAssociation
	{
		private LocalLBMonitorIPPort memberField;
		public LocalLBMonitorIPPort member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private LocalLBMonitorRule monitor_ruleField;
		public LocalLBMonitorRule monitor_rule
		{
			get { return this.monitor_ruleField; }
			set { this.monitor_ruleField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberMonitorAssociationRemoval", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberMonitorAssociationRemoval
	{
		private LocalLBMonitorIPPort memberField;
		public LocalLBMonitorIPPort member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private LocalLBMonitorAssociationRemovalRule removal_ruleField;
		public LocalLBMonitorAssociationRemovalRule removal_rule
		{
			get { return this.removal_ruleField; }
			set { this.removal_ruleField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberMonitorInstanceState", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberMonitorInstanceState
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private LocalLBMonitorInstanceState [] monitor_instancesField;
		public LocalLBMonitorInstanceState [] monitor_instances
		{
			get { return this.monitor_instancesField; }
			set { this.monitor_instancesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberMonitorState", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberMonitorState
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private CommonEnabledState monitor_stateField;
		public CommonEnabledState monitor_state
		{
			get { return this.monitor_stateField; }
			set { this.monitor_stateField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberMonitorStatus", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberMonitorStatus
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private LocalLBMonitorStatus monitor_statusField;
		public LocalLBMonitorStatus monitor_status
		{
			get { return this.monitor_statusField; }
			set { this.monitor_statusField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberObjectStatus", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberObjectStatus
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private LocalLBObjectStatus object_statusField;
		public LocalLBObjectStatus object_status
		{
			get { return this.object_statusField; }
			set { this.object_statusField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberPriority", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberPriority
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private long priorityField;
		public long priority
		{
			get { return this.priorityField; }
			set { this.priorityField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberRatio", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberRatio
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private long ratioField;
		public long ratio
		{
			get { return this.ratioField; }
			set { this.ratioField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberSessionState", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberSessionState
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private CommonEnabledState session_stateField;
		public CommonEnabledState session_state
		{
			get { return this.session_stateField; }
			set { this.session_stateField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberSessionStatus", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberSessionStatus
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private LocalLBSessionStatus session_statusField;
		public LocalLBSessionStatus session_status
		{
			get { return this.session_statusField; }
			set { this.session_statusField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberStatisticEntry
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PoolMember.MemberStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberMemberStatistics
	{
		private LocalLBPoolMemberMemberStatisticEntry [] statisticsField;
		public LocalLBPoolMemberMemberStatisticEntry [] statistics
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
