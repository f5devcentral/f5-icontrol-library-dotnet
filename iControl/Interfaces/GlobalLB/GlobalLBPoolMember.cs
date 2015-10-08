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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.PoolMemberBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMemberMemberDependency))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMemberMemberStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonIPPortDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMemberMemberEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMemberMemberMetricLimit))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMemberMemberMonitorAssociation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMemberMemberObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMemberMemberOrder))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMemberMemberRatio))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMemberMemberMonitorAssociationRemoval))]
	public partial class GlobalLBPoolMember : iControlInterface {
		public GlobalLBPoolMember() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	public void add_dependency(
		string [] pool_names,
		GlobalLBPoolMemberMemberDependency [] [] dependencies
	) {
		this.Invoke("add_dependency", new object [] {
				pool_names,
				dependencies});

	}
	public System.IAsyncResult Beginadd_dependency(string [] pool_names,GlobalLBPoolMemberMemberDependency [] [] dependencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_dependency", new object[] {
			pool_names,
			dependencies}, callback, asyncState);
	}
	public void Endadd_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMemberMemberStatistics [] get_all_statistics(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_all_statistics", new object [] {
				pool_names});
		return ((GlobalLBPoolMemberMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[] {
			pool_names}, callback, asyncState);
	}
	public GlobalLBPoolMemberMemberStatistics [] Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMemberMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMemberMemberDependency [] [] get_dependency(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		object [] results = this.Invoke("get_dependency", new object [] {
				pool_names,
				members});
		return ((GlobalLBPoolMemberMemberDependency [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dependency(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dependency", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBPoolMemberMemberDependency [] [] Endget_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMemberMemberDependency [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMemberMemberEnabledState [] [] get_enabled_state(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				pool_names,
				members});
		return ((GlobalLBPoolMemberMemberEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBPoolMemberMemberEnabledState [] [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMemberMemberEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMemberMemberMetricLimit [] [] get_limit(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		object [] results = this.Invoke("get_limit", new object [] {
				pool_names,
				members});
		return ((GlobalLBPoolMemberMemberMetricLimit [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_limit(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_limit", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBPoolMemberMemberMetricLimit [] [] Endget_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMemberMemberMetricLimit [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMemberMemberMonitorAssociation [] [] get_monitor_association(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_monitor_association", new object [] {
				pool_names});
		return ((GlobalLBPoolMemberMemberMonitorAssociation [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_association(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_association", new object[] {
			pool_names}, callback, asyncState);
	}
	public GlobalLBPoolMemberMemberMonitorAssociation [] [] Endget_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMemberMemberMonitorAssociation [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMemberMemberObjectStatus [] [] get_object_status(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				pool_names,
				members});
		return ((GlobalLBPoolMemberMemberObjectStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBPoolMemberMemberObjectStatus [] [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMemberMemberObjectStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMemberMemberOrder [] [] get_order(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		object [] results = this.Invoke("get_order", new object [] {
				pool_names,
				members});
		return ((GlobalLBPoolMemberMemberOrder [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_order(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_order", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBPoolMemberMemberOrder [] [] Endget_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMemberMemberOrder [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMemberMemberRatio [] [] get_ratio(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		object [] results = this.Invoke("get_ratio", new object [] {
				pool_names,
				members});
		return ((GlobalLBPoolMemberMemberRatio [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ratio(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ratio", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBPoolMemberMemberRatio [] [] Endget_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMemberMemberRatio [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMemberMemberStatistics [] get_statistics(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				pool_names,
				members});
		return ((GlobalLBPoolMemberMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBPoolMemberMemberStatistics [] Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMemberMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
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
	// remove_all_dependencies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	public void remove_all_dependencies(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		this.Invoke("remove_all_dependencies", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginremove_all_dependencies(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_dependencies", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endremove_all_dependencies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	public void remove_dependency(
		string [] pool_names,
		GlobalLBPoolMemberMemberDependency [] [] dependencies
	) {
		this.Invoke("remove_dependency", new object [] {
				pool_names,
				dependencies});

	}
	public System.IAsyncResult Beginremove_dependency(string [] pool_names,GlobalLBPoolMemberMemberDependency [] [] dependencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_dependency", new object[] {
			pool_names,
			dependencies}, callback, asyncState);
	}
	public void Endremove_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	public void remove_monitor_association(
		string [] pool_names,
		GlobalLBPoolMemberMemberMonitorAssociationRemoval [] [] monitor_associations
	) {
		this.Invoke("remove_monitor_association", new object [] {
				pool_names,
				monitor_associations});

	}
	public System.IAsyncResult Beginremove_monitor_association(string [] pool_names,GlobalLBPoolMemberMemberMonitorAssociationRemoval [] [] monitor_associations, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
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
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	public void set_enabled_state(
		string [] pool_names,
		GlobalLBPoolMemberMemberEnabledState [] [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				pool_names,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] pool_names,GlobalLBPoolMemberMemberEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			pool_names,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	public void set_limit(
		string [] pool_names,
		GlobalLBPoolMemberMemberMetricLimit [] [] limits
	) {
		this.Invoke("set_limit", new object [] {
				pool_names,
				limits});

	}
	public System.IAsyncResult Beginset_limit(string [] pool_names,GlobalLBPoolMemberMemberMetricLimit [] [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_limit", new object[] {
			pool_names,
			limits}, callback, asyncState);
	}
	public void Endset_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	public void set_monitor_association(
		string [] pool_names,
		GlobalLBPoolMemberMemberMonitorAssociation [] [] monitor_associations
	) {
		this.Invoke("set_monitor_association", new object [] {
				pool_names,
				monitor_associations});

	}
	public System.IAsyncResult Beginset_monitor_association(string [] pool_names,GlobalLBPoolMemberMemberMonitorAssociation [] [] monitor_associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_association", new object[] {
			pool_names,
			monitor_associations}, callback, asyncState);
	}
	public void Endset_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	public void set_order(
		string [] pool_names,
		GlobalLBPoolMemberMemberOrder [] [] orders
	) {
		this.Invoke("set_order", new object [] {
				pool_names,
				orders});

	}
	public System.IAsyncResult Beginset_order(string [] pool_names,GlobalLBPoolMemberMemberOrder [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_order", new object[] {
			pool_names,
			orders}, callback, asyncState);
	}
	public void Endset_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolMember", 
		RequestNamespace="urn:iControl:GlobalLB/PoolMember", ResponseNamespace="urn:iControl:GlobalLB/PoolMember")]
	public void set_ratio(
		string [] pool_names,
		GlobalLBPoolMemberMemberRatio [] [] ratios
	) {
		this.Invoke("set_ratio", new object [] {
				pool_names,
				ratios});

	}
	public System.IAsyncResult Beginset_ratio(string [] pool_names,GlobalLBPoolMemberMemberRatio [] [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ratio", new object[] {
			pool_names,
			ratios}, callback, asyncState);
	}
	public void Endset_ratio(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolMember.MemberDependency", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberMemberDependency
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private GlobalLBVirtualServerDefinition [] dependenciesField;
		public GlobalLBVirtualServerDefinition [] dependencies
		{
			get { return this.dependenciesField; }
			set { this.dependenciesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolMember.MemberEnabledState", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberMemberEnabledState
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private CommonEnabledState stateField;
		public CommonEnabledState state
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolMember.MemberMetricLimit", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberMemberMetricLimit
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private GlobalLBMetricLimit [] metric_limitsField;
		public GlobalLBMetricLimit [] metric_limits
		{
			get { return this.metric_limitsField; }
			set { this.metric_limitsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolMember.MemberMonitorAssociation", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberMemberMonitorAssociation
	{
		private GlobalLBMonitorIPPort memberField;
		public GlobalLBMonitorIPPort member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private GlobalLBMonitorRule monitor_ruleField;
		public GlobalLBMonitorRule monitor_rule
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolMember.MemberMonitorAssociationRemoval", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberMemberMonitorAssociationRemoval
	{
		private GlobalLBMonitorIPPort memberField;
		public GlobalLBMonitorIPPort member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private GlobalLBMonitorAssociationRemovalRule removal_ruleField;
		public GlobalLBMonitorAssociationRemovalRule removal_rule
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolMember.MemberObjectStatus", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberMemberObjectStatus
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private CommonObjectStatus statusField;
		public CommonObjectStatus status
		{
			get { return this.statusField; }
			set { this.statusField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolMember.MemberOrder", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberMemberOrder
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private long orderField;
		public long order
		{
			get { return this.orderField; }
			set { this.orderField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolMember.MemberRatio", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberMemberRatio
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolMember.MemberStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberMemberStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolMember.MemberStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberMemberStatistics
	{
		private GlobalLBPoolMemberMemberStatisticEntry [] statisticsField;
		public GlobalLBPoolMemberMemberStatisticEntry [] statistics
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
