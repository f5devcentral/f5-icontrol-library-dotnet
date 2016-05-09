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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.RateClassBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBRateClassRateUnit))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBRateClassRateUnitV2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBRateClassRateClassStatistics))]
	public partial class LocalLBRateClass : iControlInterface {
		public LocalLBRateClass() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void create(
		string [] rate_classes,
		LocalLBRateClassRateUnit [] base_rates
	) {
		this.Invoke("create", new object [] {
				rate_classes,
				base_rates});

	}
	public System.IAsyncResult Begincreate(string [] rate_classes,LocalLBRateClassRateUnit [] base_rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			rate_classes,
			base_rates}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_drop_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void create_drop_policy(
		string [] drop_policies,
		LocalLBRateClassDropPolicyType [] types
	) {
		this.Invoke("create_drop_policy", new object [] {
				drop_policies,
				types});

	}
	public System.IAsyncResult Begincreate_drop_policy(string [] drop_policies,LocalLBRateClassDropPolicyType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_drop_policy", new object[] {
			drop_policies,
			types}, callback, asyncState);
	}
	public void Endcreate_drop_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_queueing_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void create_queueing_method(
		string [] queues,
		LocalLBRateClassQueueType [] types
	) {
		this.Invoke("create_queueing_method", new object [] {
				queues,
				types});

	}
	public System.IAsyncResult Begincreate_queueing_method(string [] queues,LocalLBRateClassQueueType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_queueing_method", new object[] {
			queues,
			types}, callback, asyncState);
	}
	public void Endcreate_queueing_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_shaping_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void create_shaping_policy(
		string [] policies
	) {
		this.Invoke("create_shaping_policy", new object [] {
				policies});

	}
	public System.IAsyncResult Begincreate_shaping_policy(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_shaping_policy", new object[] {
			policies}, callback, asyncState);
	}
	public void Endcreate_shaping_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void create_v2(
		string [] rate_classes,
		LocalLBRateClassRateUnitV2 [] base_rates
	) {
		this.Invoke("create_v2", new object [] {
				rate_classes,
				base_rates});

	}
	public System.IAsyncResult Begincreate_v2(string [] rate_classes,LocalLBRateClassRateUnitV2 [] base_rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_v2", new object[] {
			rate_classes,
			base_rates}, callback, asyncState);
	}
	public void Endcreate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_drop_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void delete_all_drop_policies(

	) {
		this.Invoke("delete_all_drop_policies", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_drop_policies(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_drop_policies", new object[0], callback, asyncState);
	}
	public void Enddelete_all_drop_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_queueing_methods
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void delete_all_queueing_methods(

	) {
		this.Invoke("delete_all_queueing_methods", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_queueing_methods(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_queueing_methods", new object[0], callback, asyncState);
	}
	public void Enddelete_all_queueing_methods(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_rate_classes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void delete_all_rate_classes(

	) {
		this.Invoke("delete_all_rate_classes", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_rate_classes(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_rate_classes", new object[0], callback, asyncState);
	}
	public void Enddelete_all_rate_classes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_shaping_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void delete_all_shaping_policies(

	) {
		this.Invoke("delete_all_shaping_policies", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_shaping_policies(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_shaping_policies", new object[0], callback, asyncState);
	}
	public void Enddelete_all_shaping_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_drop_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void delete_drop_policy(
		string [] drop_policies
	) {
		this.Invoke("delete_drop_policy", new object [] {
				drop_policies});

	}
	public System.IAsyncResult Begindelete_drop_policy(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_drop_policy", new object[] {
			drop_policies}, callback, asyncState);
	}
	public void Enddelete_drop_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_queueing_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void delete_queueing_method(
		string [] queues
	) {
		this.Invoke("delete_queueing_method", new object [] {
				queues});

	}
	public System.IAsyncResult Begindelete_queueing_method(string [] queues, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_queueing_method", new object[] {
			queues}, callback, asyncState);
	}
	public void Enddelete_queueing_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_rate_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void delete_rate_class(
		string [] rate_classes
	) {
		this.Invoke("delete_rate_class", new object [] {
				rate_classes});

	}
	public System.IAsyncResult Begindelete_rate_class(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_rate_class", new object[] {
			rate_classes}, callback, asyncState);
	}
	public void Enddelete_rate_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_shaping_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void delete_shaping_policy(
		string [] policies
	) {
		this.Invoke("delete_shaping_policy", new object [] {
				policies});

	}
	public System.IAsyncResult Begindelete_shaping_policy(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_shaping_policy", new object[] {
			policies}, callback, asyncState);
	}
	public void Enddelete_shaping_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateClassRateClassStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBRateClassRateClassStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBRateClassRateClassStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateClassRateClassStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_base_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateClassRateUnit [] get_base_rate(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_base_rate", new object [] {
				rate_classes});
		return ((LocalLBRateClassRateUnit [])(results[0]));
	}
	public System.IAsyncResult Beginget_base_rate(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_base_rate", new object[] {
			rate_classes}, callback, asyncState);
	}
	public LocalLBRateClassRateUnit [] Endget_base_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateClassRateUnit [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_base_rate_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateClassRateUnitV2 [] get_base_rate_v2(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_base_rate_v2", new object [] {
				rate_classes});
		return ((LocalLBRateClassRateUnitV2 [])(results[0]));
	}
	public System.IAsyncResult Beginget_base_rate_v2(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_base_rate_v2", new object[] {
			rate_classes}, callback, asyncState);
	}
	public LocalLBRateClassRateUnitV2 [] Endget_base_rate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateClassRateUnitV2 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_burst_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_burst_size(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_burst_size", new object [] {
				rate_classes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_burst_size(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_burst_size", new object[] {
			rate_classes}, callback, asyncState);
	}
	public long [] Endget_burst_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ceiling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateClassRateUnit [] get_ceiling_rate(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_ceiling_rate", new object [] {
				rate_classes});
		return ((LocalLBRateClassRateUnit [])(results[0]));
	}
	public System.IAsyncResult Beginget_ceiling_rate(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ceiling_rate", new object[] {
			rate_classes}, callback, asyncState);
	}
	public LocalLBRateClassRateUnit [] Endget_ceiling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateClassRateUnit [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ceiling_rate_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateClassRateUnitV2 [] get_ceiling_rate_v2(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_ceiling_rate_v2", new object [] {
				rate_classes});
		return ((LocalLBRateClassRateUnitV2 [])(results[0]));
	}
	public System.IAsyncResult Beginget_ceiling_rate_v2(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ceiling_rate_v2", new object[] {
			rate_classes}, callback, asyncState);
	}
	public LocalLBRateClassRateUnitV2 [] Endget_ceiling_rate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateClassRateUnitV2 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_description", new object [] {
				rate_classes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			rate_classes}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_direction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateClassDirectionType [] get_direction(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_direction", new object [] {
				rate_classes});
		return ((LocalLBRateClassDirectionType [])(results[0]));
	}
	public System.IAsyncResult Beginget_direction(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_direction", new object[] {
			rate_classes}, callback, asyncState);
	}
	public LocalLBRateClassDirectionType [] Endget_direction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateClassDirectionType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_direction_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_direction_vlan(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_direction_vlan", new object [] {
				rate_classes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_direction_vlan(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_direction_vlan", new object[] {
			rate_classes}, callback, asyncState);
	}
	public string [] Endget_direction_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_drop_policy(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_drop_policy", new object [] {
				rate_classes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy", new object[] {
			rate_classes}, callback, asyncState);
	}
	public string [] Endget_drop_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_average_packet_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_drop_policy_average_packet_size(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_average_packet_size", new object [] {
				drop_policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_average_packet_size(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_average_packet_size", new object[] {
			drop_policies}, callback, asyncState);
	}
	public long [] Endget_drop_policy_average_packet_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_drop_policy_description(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_description", new object [] {
				drop_policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_description(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_description", new object[] {
			drop_policies}, callback, asyncState);
	}
	public string [] Endget_drop_policy_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_drop_limit_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_drop_policy_drop_limit_factor(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_drop_limit_factor", new object [] {
				drop_policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_drop_limit_factor(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_drop_limit_factor", new object[] {
			drop_policies}, callback, asyncState);
	}
	public long [] Endget_drop_policy_drop_limit_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_drop_policy_list(

	) {
		object [] results = this.Invoke("get_drop_policy_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_list", new object[0], callback, asyncState);
	}
	public string [] Endget_drop_policy_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_maximum_active_connections
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_drop_policy_maximum_active_connections(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_maximum_active_connections", new object [] {
				drop_policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_maximum_active_connections(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_maximum_active_connections", new object[] {
			drop_policies}, callback, asyncState);
	}
	public long [] Endget_drop_policy_maximum_active_connections(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_maximum_probability
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_drop_policy_maximum_probability(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_maximum_probability", new object [] {
				drop_policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_maximum_probability(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_maximum_probability", new object[] {
			drop_policies}, callback, asyncState);
	}
	public long [] Endget_drop_policy_maximum_probability(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_maximum_queue_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_drop_policy_maximum_queue_size(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_maximum_queue_size", new object [] {
				drop_policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_maximum_queue_size(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_maximum_queue_size", new object[] {
			drop_policies}, callback, asyncState);
	}
	public long [] Endget_drop_policy_maximum_queue_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_maximum_queue_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_drop_policy_maximum_queue_threshold(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_maximum_queue_threshold", new object [] {
				drop_policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_maximum_queue_threshold(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_maximum_queue_threshold", new object[] {
			drop_policies}, callback, asyncState);
	}
	public long [] Endget_drop_policy_maximum_queue_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_minimum_queue_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_drop_policy_minimum_queue_threshold(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_minimum_queue_threshold", new object [] {
				drop_policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_minimum_queue_threshold(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_minimum_queue_threshold", new object[] {
			drop_policies}, callback, asyncState);
	}
	public long [] Endget_drop_policy_minimum_queue_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_no_drop_limit_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_drop_policy_no_drop_limit_factor(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_no_drop_limit_factor", new object [] {
				drop_policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_no_drop_limit_factor(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_no_drop_limit_factor", new object[] {
			drop_policies}, callback, asyncState);
	}
	public long [] Endget_drop_policy_no_drop_limit_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateClassDropPolicyType [] get_drop_policy_type(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_type", new object [] {
				drop_policies});
		return ((LocalLBRateClassDropPolicyType [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_type(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_type", new object[] {
			drop_policies}, callback, asyncState);
	}
	public LocalLBRateClassDropPolicyType [] Endget_drop_policy_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateClassDropPolicyType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drop_policy_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_drop_policy_weight(
		string [] drop_policies
	) {
		object [] results = this.Invoke("get_drop_policy_weight", new object [] {
				drop_policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_drop_policy_weight(string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drop_policy_weight", new object[] {
			drop_policies}, callback, asyncState);
	}
	public long [] Endget_drop_policy_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
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
	// get_parent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_parent(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_parent", new object [] {
				rate_classes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_parent(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_parent", new object[] {
			rate_classes}, callback, asyncState);
	}
	public string [] Endget_parent(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_percent_of_parent_base_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_percent_of_parent_base_rate(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_percent_of_parent_base_rate", new object [] {
				rate_classes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_percent_of_parent_base_rate(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_percent_of_parent_base_rate", new object[] {
			rate_classes}, callback, asyncState);
	}
	public long [] Endget_percent_of_parent_base_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_percent_of_parent_ceiling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_percent_of_parent_ceiling_rate(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_percent_of_parent_ceiling_rate", new object [] {
				rate_classes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_percent_of_parent_ceiling_rate(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_percent_of_parent_ceiling_rate", new object[] {
			rate_classes}, callback, asyncState);
	}
	public long [] Endget_percent_of_parent_ceiling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queue_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateClassQueueType [] get_queue_type(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_queue_type", new object [] {
				rate_classes});
		return ((LocalLBRateClassQueueType [])(results[0]));
	}
	public System.IAsyncResult Beginget_queue_type(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queue_type", new object[] {
			rate_classes}, callback, asyncState);
	}
	public LocalLBRateClassQueueType [] Endget_queue_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateClassQueueType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queueing_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_queueing_method(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_queueing_method", new object [] {
				rate_classes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_queueing_method(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queueing_method", new object[] {
			rate_classes}, callback, asyncState);
	}
	public string [] Endget_queueing_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queueing_method_bucket_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_queueing_method_bucket_count(
		string [] queues
	) {
		object [] results = this.Invoke("get_queueing_method_bucket_count", new object [] {
				queues});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_queueing_method_bucket_count(string [] queues, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queueing_method_bucket_count", new object[] {
			queues}, callback, asyncState);
	}
	public long [] Endget_queueing_method_bucket_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queueing_method_bucket_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_queueing_method_bucket_size(
		string [] queues
	) {
		object [] results = this.Invoke("get_queueing_method_bucket_size", new object [] {
				queues});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_queueing_method_bucket_size(string [] queues, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queueing_method_bucket_size", new object[] {
			queues}, callback, asyncState);
	}
	public long [] Endget_queueing_method_bucket_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queueing_method_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_queueing_method_description(
		string [] queues
	) {
		object [] results = this.Invoke("get_queueing_method_description", new object [] {
				queues});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_queueing_method_description(string [] queues, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queueing_method_description", new object[] {
			queues}, callback, asyncState);
	}
	public string [] Endget_queueing_method_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queueing_method_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_queueing_method_list(

	) {
		object [] results = this.Invoke("get_queueing_method_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_queueing_method_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queueing_method_list", new object[0], callback, asyncState);
	}
	public string [] Endget_queueing_method_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queueing_method_maximum_queue_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_queueing_method_maximum_queue_size(
		string [] queues
	) {
		object [] results = this.Invoke("get_queueing_method_maximum_queue_size", new object [] {
				queues});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_queueing_method_maximum_queue_size(string [] queues, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queueing_method_maximum_queue_size", new object[] {
			queues}, callback, asyncState);
	}
	public long [] Endget_queueing_method_maximum_queue_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queueing_method_minimum_queue_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_queueing_method_minimum_queue_size(
		string [] queues
	) {
		object [] results = this.Invoke("get_queueing_method_minimum_queue_size", new object [] {
				queues});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_queueing_method_minimum_queue_size(string [] queues, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queueing_method_minimum_queue_size", new object[] {
			queues}, callback, asyncState);
	}
	public long [] Endget_queueing_method_minimum_queue_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queueing_method_perturbation_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_queueing_method_perturbation_interval(
		string [] queues
	) {
		object [] results = this.Invoke("get_queueing_method_perturbation_interval", new object [] {
				queues});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_queueing_method_perturbation_interval(string [] queues, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queueing_method_perturbation_interval", new object[] {
			queues}, callback, asyncState);
	}
	public long [] Endget_queueing_method_perturbation_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queueing_method_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateClassQueueType [] get_queueing_method_type(
		string [] queues
	) {
		object [] results = this.Invoke("get_queueing_method_type", new object [] {
				queues});
		return ((LocalLBRateClassQueueType [])(results[0]));
	}
	public System.IAsyncResult Beginget_queueing_method_type(string [] queues, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queueing_method_type", new object[] {
			queues}, callback, asyncState);
	}
	public LocalLBRateClassQueueType [] Endget_queueing_method_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateClassQueueType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_shaping_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_shaping_policy(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_shaping_policy", new object [] {
				rate_classes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_shaping_policy(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_shaping_policy", new object[] {
			rate_classes}, callback, asyncState);
	}
	public string [] Endget_shaping_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_shaping_policy_burst_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_shaping_policy_burst_size(
		string [] policies
	) {
		object [] results = this.Invoke("get_shaping_policy_burst_size", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_shaping_policy_burst_size(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_shaping_policy_burst_size", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_shaping_policy_burst_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_shaping_policy_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_shaping_policy_description(
		string [] policies
	) {
		object [] results = this.Invoke("get_shaping_policy_description", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_shaping_policy_description(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_shaping_policy_description", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_shaping_policy_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_shaping_policy_drop_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_shaping_policy_drop_policy(
		string [] policies
	) {
		object [] results = this.Invoke("get_shaping_policy_drop_policy", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_shaping_policy_drop_policy(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_shaping_policy_drop_policy", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_shaping_policy_drop_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_shaping_policy_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_shaping_policy_list(

	) {
		object [] results = this.Invoke("get_shaping_policy_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_shaping_policy_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_shaping_policy_list", new object[0], callback, asyncState);
	}
	public string [] Endget_shaping_policy_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_shaping_policy_percent_of_parent_base_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_shaping_policy_percent_of_parent_base_rate(
		string [] policies
	) {
		object [] results = this.Invoke("get_shaping_policy_percent_of_parent_base_rate", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_shaping_policy_percent_of_parent_base_rate(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_shaping_policy_percent_of_parent_base_rate", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_shaping_policy_percent_of_parent_base_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_shaping_policy_percent_of_parent_ceiling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_shaping_policy_percent_of_parent_ceiling_rate(
		string [] policies
	) {
		object [] results = this.Invoke("get_shaping_policy_percent_of_parent_ceiling_rate", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_shaping_policy_percent_of_parent_ceiling_rate(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_shaping_policy_percent_of_parent_ceiling_rate", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_shaping_policy_percent_of_parent_ceiling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_shaping_policy_queueing_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_shaping_policy_queueing_method(
		string [] policies
	) {
		object [] results = this.Invoke("get_shaping_policy_queueing_method", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_shaping_policy_queueing_method(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_shaping_policy_queueing_method", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_shaping_policy_queueing_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateClassRateClassStatistics get_statistics(
		string [] rate_classes
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				rate_classes});
		return ((LocalLBRateClassRateClassStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			rate_classes}, callback, asyncState);
	}
	public LocalLBRateClassRateClassStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateClassRateClassStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void reset_statistics(
		string [] rate_classes
	) {
		this.Invoke("reset_statistics", new object [] {
				rate_classes});

	}
	public System.IAsyncResult Beginreset_statistics(string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			rate_classes}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_base_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_base_rate(
		string [] rate_classes,
		LocalLBRateClassRateUnit [] rates
	) {
		this.Invoke("set_base_rate", new object [] {
				rate_classes,
				rates});

	}
	public System.IAsyncResult Beginset_base_rate(string [] rate_classes,LocalLBRateClassRateUnit [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_base_rate", new object[] {
			rate_classes,
			rates}, callback, asyncState);
	}
	public void Endset_base_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_base_rate_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_base_rate_v2(
		string [] rate_classes,
		LocalLBRateClassRateUnitV2 [] rates
	) {
		this.Invoke("set_base_rate_v2", new object [] {
				rate_classes,
				rates});

	}
	public System.IAsyncResult Beginset_base_rate_v2(string [] rate_classes,LocalLBRateClassRateUnitV2 [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_base_rate_v2", new object[] {
			rate_classes,
			rates}, callback, asyncState);
	}
	public void Endset_base_rate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_burst_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_burst_size(
		string [] rate_classes,
		long [] burst_sizes
	) {
		this.Invoke("set_burst_size", new object [] {
				rate_classes,
				burst_sizes});

	}
	public System.IAsyncResult Beginset_burst_size(string [] rate_classes,long [] burst_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_burst_size", new object[] {
			rate_classes,
			burst_sizes}, callback, asyncState);
	}
	public void Endset_burst_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ceiling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_ceiling_rate(
		string [] rate_classes,
		LocalLBRateClassRateUnit [] rates
	) {
		this.Invoke("set_ceiling_rate", new object [] {
				rate_classes,
				rates});

	}
	public System.IAsyncResult Beginset_ceiling_rate(string [] rate_classes,LocalLBRateClassRateUnit [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ceiling_rate", new object[] {
			rate_classes,
			rates}, callback, asyncState);
	}
	public void Endset_ceiling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ceiling_rate_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_ceiling_rate_v2(
		string [] rate_classes,
		LocalLBRateClassRateUnitV2 [] rates
	) {
		this.Invoke("set_ceiling_rate_v2", new object [] {
				rate_classes,
				rates});

	}
	public System.IAsyncResult Beginset_ceiling_rate_v2(string [] rate_classes,LocalLBRateClassRateUnitV2 [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ceiling_rate_v2", new object[] {
			rate_classes,
			rates}, callback, asyncState);
	}
	public void Endset_ceiling_rate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_description(
		string [] rate_classes,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				rate_classes,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] rate_classes,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			rate_classes,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_direction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_direction(
		string [] rate_classes,
		LocalLBRateClassDirectionType [] direction_types
	) {
		this.Invoke("set_direction", new object [] {
				rate_classes,
				direction_types});

	}
	public System.IAsyncResult Beginset_direction(string [] rate_classes,LocalLBRateClassDirectionType [] direction_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_direction", new object[] {
			rate_classes,
			direction_types}, callback, asyncState);
	}
	public void Endset_direction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_direction_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_direction_vlan(
		string [] rate_classes,
		string [] vlans
	) {
		this.Invoke("set_direction_vlan", new object [] {
				rate_classes,
				vlans});

	}
	public System.IAsyncResult Beginset_direction_vlan(string [] rate_classes,string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_direction_vlan", new object[] {
			rate_classes,
			vlans}, callback, asyncState);
	}
	public void Endset_direction_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy(
		string [] rate_classes,
		string [] policies
	) {
		this.Invoke("set_drop_policy", new object [] {
				rate_classes,
				policies});

	}
	public System.IAsyncResult Beginset_drop_policy(string [] rate_classes,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy", new object[] {
			rate_classes,
			policies}, callback, asyncState);
	}
	public void Endset_drop_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_average_packet_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_average_packet_size(
		string [] drop_policies,
		long [] mtus
	) {
		this.Invoke("set_drop_policy_average_packet_size", new object [] {
				drop_policies,
				mtus});

	}
	public System.IAsyncResult Beginset_drop_policy_average_packet_size(string [] drop_policies,long [] mtus, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_average_packet_size", new object[] {
			drop_policies,
			mtus}, callback, asyncState);
	}
	public void Endset_drop_policy_average_packet_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_description(
		string [] drop_policies,
		string [] descriptions
	) {
		this.Invoke("set_drop_policy_description", new object [] {
				drop_policies,
				descriptions});

	}
	public System.IAsyncResult Beginset_drop_policy_description(string [] drop_policies,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_description", new object[] {
			drop_policies,
			descriptions}, callback, asyncState);
	}
	public void Endset_drop_policy_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_drop_limit_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_drop_limit_factor(
		string [] drop_policies,
		long [] factors
	) {
		this.Invoke("set_drop_policy_drop_limit_factor", new object [] {
				drop_policies,
				factors});

	}
	public System.IAsyncResult Beginset_drop_policy_drop_limit_factor(string [] drop_policies,long [] factors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_drop_limit_factor", new object[] {
			drop_policies,
			factors}, callback, asyncState);
	}
	public void Endset_drop_policy_drop_limit_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_maximum_active_connections
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_maximum_active_connections(
		string [] drop_policies,
		long [] max_conns
	) {
		this.Invoke("set_drop_policy_maximum_active_connections", new object [] {
				drop_policies,
				max_conns});

	}
	public System.IAsyncResult Beginset_drop_policy_maximum_active_connections(string [] drop_policies,long [] max_conns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_maximum_active_connections", new object[] {
			drop_policies,
			max_conns}, callback, asyncState);
	}
	public void Endset_drop_policy_maximum_active_connections(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_maximum_probability
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_maximum_probability(
		string [] drop_policies,
		long [] probabilities
	) {
		this.Invoke("set_drop_policy_maximum_probability", new object [] {
				drop_policies,
				probabilities});

	}
	public System.IAsyncResult Beginset_drop_policy_maximum_probability(string [] drop_policies,long [] probabilities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_maximum_probability", new object[] {
			drop_policies,
			probabilities}, callback, asyncState);
	}
	public void Endset_drop_policy_maximum_probability(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_maximum_queue_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_maximum_queue_size(
		string [] drop_policies,
		long [] max_sizes
	) {
		this.Invoke("set_drop_policy_maximum_queue_size", new object [] {
				drop_policies,
				max_sizes});

	}
	public System.IAsyncResult Beginset_drop_policy_maximum_queue_size(string [] drop_policies,long [] max_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_maximum_queue_size", new object[] {
			drop_policies,
			max_sizes}, callback, asyncState);
	}
	public void Endset_drop_policy_maximum_queue_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_maximum_queue_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_maximum_queue_threshold(
		string [] drop_policies,
		long [] thresholds
	) {
		this.Invoke("set_drop_policy_maximum_queue_threshold", new object [] {
				drop_policies,
				thresholds});

	}
	public System.IAsyncResult Beginset_drop_policy_maximum_queue_threshold(string [] drop_policies,long [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_maximum_queue_threshold", new object[] {
			drop_policies,
			thresholds}, callback, asyncState);
	}
	public void Endset_drop_policy_maximum_queue_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_minimum_queue_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_minimum_queue_threshold(
		string [] drop_policies,
		long [] thresholds
	) {
		this.Invoke("set_drop_policy_minimum_queue_threshold", new object [] {
				drop_policies,
				thresholds});

	}
	public System.IAsyncResult Beginset_drop_policy_minimum_queue_threshold(string [] drop_policies,long [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_minimum_queue_threshold", new object[] {
			drop_policies,
			thresholds}, callback, asyncState);
	}
	public void Endset_drop_policy_minimum_queue_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_no_drop_limit_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_no_drop_limit_factor(
		string [] drop_policies,
		long [] factors
	) {
		this.Invoke("set_drop_policy_no_drop_limit_factor", new object [] {
				drop_policies,
				factors});

	}
	public System.IAsyncResult Beginset_drop_policy_no_drop_limit_factor(string [] drop_policies,long [] factors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_no_drop_limit_factor", new object[] {
			drop_policies,
			factors}, callback, asyncState);
	}
	public void Endset_drop_policy_no_drop_limit_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_type(
		string [] drop_policies,
		LocalLBRateClassDropPolicyType [] types
	) {
		this.Invoke("set_drop_policy_type", new object [] {
				drop_policies,
				types});

	}
	public System.IAsyncResult Beginset_drop_policy_type(string [] drop_policies,LocalLBRateClassDropPolicyType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_type", new object[] {
			drop_policies,
			types}, callback, asyncState);
	}
	public void Endset_drop_policy_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drop_policy_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_drop_policy_weight(
		string [] drop_policies,
		long [] weights
	) {
		this.Invoke("set_drop_policy_weight", new object [] {
				drop_policies,
				weights});

	}
	public System.IAsyncResult Beginset_drop_policy_weight(string [] drop_policies,long [] weights, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drop_policy_weight", new object[] {
			drop_policies,
			weights}, callback, asyncState);
	}
	public void Endset_drop_policy_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_parent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_parent(
		string [] rate_classes,
		string [] parents
	) {
		this.Invoke("set_parent", new object [] {
				rate_classes,
				parents});

	}
	public System.IAsyncResult Beginset_parent(string [] rate_classes,string [] parents, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_parent", new object[] {
			rate_classes,
			parents}, callback, asyncState);
	}
	public void Endset_parent(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_percent_of_parent_base_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_percent_of_parent_base_rate(
		string [] rate_classes,
		long [] percents
	) {
		this.Invoke("set_percent_of_parent_base_rate", new object [] {
				rate_classes,
				percents});

	}
	public System.IAsyncResult Beginset_percent_of_parent_base_rate(string [] rate_classes,long [] percents, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_percent_of_parent_base_rate", new object[] {
			rate_classes,
			percents}, callback, asyncState);
	}
	public void Endset_percent_of_parent_base_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_percent_of_parent_ceiling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_percent_of_parent_ceiling_rate(
		string [] rate_classes,
		long [] percents
	) {
		this.Invoke("set_percent_of_parent_ceiling_rate", new object [] {
				rate_classes,
				percents});

	}
	public System.IAsyncResult Beginset_percent_of_parent_ceiling_rate(string [] rate_classes,long [] percents, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_percent_of_parent_ceiling_rate", new object[] {
			rate_classes,
			percents}, callback, asyncState);
	}
	public void Endset_percent_of_parent_ceiling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queue_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_queue_type(
		string [] rate_classes,
		LocalLBRateClassQueueType [] queue_types
	) {
		this.Invoke("set_queue_type", new object [] {
				rate_classes,
				queue_types});

	}
	public System.IAsyncResult Beginset_queue_type(string [] rate_classes,LocalLBRateClassQueueType [] queue_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queue_type", new object[] {
			rate_classes,
			queue_types}, callback, asyncState);
	}
	public void Endset_queue_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queueing_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_queueing_method(
		string [] rate_classes,
		string [] methods
	) {
		this.Invoke("set_queueing_method", new object [] {
				rate_classes,
				methods});

	}
	public System.IAsyncResult Beginset_queueing_method(string [] rate_classes,string [] methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queueing_method", new object[] {
			rate_classes,
			methods}, callback, asyncState);
	}
	public void Endset_queueing_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queueing_method_bucket_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_queueing_method_bucket_count(
		string [] queues,
		long [] bucket_counts
	) {
		this.Invoke("set_queueing_method_bucket_count", new object [] {
				queues,
				bucket_counts});

	}
	public System.IAsyncResult Beginset_queueing_method_bucket_count(string [] queues,long [] bucket_counts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queueing_method_bucket_count", new object[] {
			queues,
			bucket_counts}, callback, asyncState);
	}
	public void Endset_queueing_method_bucket_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queueing_method_bucket_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_queueing_method_bucket_size(
		string [] queues,
		long [] bucket_sizes
	) {
		this.Invoke("set_queueing_method_bucket_size", new object [] {
				queues,
				bucket_sizes});

	}
	public System.IAsyncResult Beginset_queueing_method_bucket_size(string [] queues,long [] bucket_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queueing_method_bucket_size", new object[] {
			queues,
			bucket_sizes}, callback, asyncState);
	}
	public void Endset_queueing_method_bucket_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queueing_method_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_queueing_method_description(
		string [] queues,
		string [] descriptions
	) {
		this.Invoke("set_queueing_method_description", new object [] {
				queues,
				descriptions});

	}
	public System.IAsyncResult Beginset_queueing_method_description(string [] queues,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queueing_method_description", new object[] {
			queues,
			descriptions}, callback, asyncState);
	}
	public void Endset_queueing_method_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queueing_method_maximum_queue_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_queueing_method_maximum_queue_size(
		string [] queues,
		long [] max_sizes
	) {
		this.Invoke("set_queueing_method_maximum_queue_size", new object [] {
				queues,
				max_sizes});

	}
	public System.IAsyncResult Beginset_queueing_method_maximum_queue_size(string [] queues,long [] max_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queueing_method_maximum_queue_size", new object[] {
			queues,
			max_sizes}, callback, asyncState);
	}
	public void Endset_queueing_method_maximum_queue_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queueing_method_minimum_queue_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_queueing_method_minimum_queue_size(
		string [] queues,
		long [] min_sizes
	) {
		this.Invoke("set_queueing_method_minimum_queue_size", new object [] {
				queues,
				min_sizes});

	}
	public System.IAsyncResult Beginset_queueing_method_minimum_queue_size(string [] queues,long [] min_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queueing_method_minimum_queue_size", new object[] {
			queues,
			min_sizes}, callback, asyncState);
	}
	public void Endset_queueing_method_minimum_queue_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queueing_method_perturbation_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_queueing_method_perturbation_interval(
		string [] queues,
		long [] intervals
	) {
		this.Invoke("set_queueing_method_perturbation_interval", new object [] {
				queues,
				intervals});

	}
	public System.IAsyncResult Beginset_queueing_method_perturbation_interval(string [] queues,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queueing_method_perturbation_interval", new object[] {
			queues,
			intervals}, callback, asyncState);
	}
	public void Endset_queueing_method_perturbation_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queueing_method_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_queueing_method_type(
		string [] queues,
		LocalLBRateClassQueueType [] types
	) {
		this.Invoke("set_queueing_method_type", new object [] {
				queues,
				types});

	}
	public System.IAsyncResult Beginset_queueing_method_type(string [] queues,LocalLBRateClassQueueType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queueing_method_type", new object[] {
			queues,
			types}, callback, asyncState);
	}
	public void Endset_queueing_method_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_shaping_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_shaping_policy(
		string [] rate_classes,
		string [] policies
	) {
		this.Invoke("set_shaping_policy", new object [] {
				rate_classes,
				policies});

	}
	public System.IAsyncResult Beginset_shaping_policy(string [] rate_classes,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_shaping_policy", new object[] {
			rate_classes,
			policies}, callback, asyncState);
	}
	public void Endset_shaping_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_shaping_policy_burst_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_shaping_policy_burst_size(
		string [] policies,
		long [] burst_sizes
	) {
		this.Invoke("set_shaping_policy_burst_size", new object [] {
				policies,
				burst_sizes});

	}
	public System.IAsyncResult Beginset_shaping_policy_burst_size(string [] policies,long [] burst_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_shaping_policy_burst_size", new object[] {
			policies,
			burst_sizes}, callback, asyncState);
	}
	public void Endset_shaping_policy_burst_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_shaping_policy_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_shaping_policy_description(
		string [] policies,
		string [] descriptions
	) {
		this.Invoke("set_shaping_policy_description", new object [] {
				policies,
				descriptions});

	}
	public System.IAsyncResult Beginset_shaping_policy_description(string [] policies,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_shaping_policy_description", new object[] {
			policies,
			descriptions}, callback, asyncState);
	}
	public void Endset_shaping_policy_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_shaping_policy_drop_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_shaping_policy_drop_policy(
		string [] policies,
		string [] drop_policies
	) {
		this.Invoke("set_shaping_policy_drop_policy", new object [] {
				policies,
				drop_policies});

	}
	public System.IAsyncResult Beginset_shaping_policy_drop_policy(string [] policies,string [] drop_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_shaping_policy_drop_policy", new object[] {
			policies,
			drop_policies}, callback, asyncState);
	}
	public void Endset_shaping_policy_drop_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_shaping_policy_percent_of_parent_base_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_shaping_policy_percent_of_parent_base_rate(
		string [] policies,
		long [] percents
	) {
		this.Invoke("set_shaping_policy_percent_of_parent_base_rate", new object [] {
				policies,
				percents});

	}
	public System.IAsyncResult Beginset_shaping_policy_percent_of_parent_base_rate(string [] policies,long [] percents, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_shaping_policy_percent_of_parent_base_rate", new object[] {
			policies,
			percents}, callback, asyncState);
	}
	public void Endset_shaping_policy_percent_of_parent_base_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_shaping_policy_percent_of_parent_ceiling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_shaping_policy_percent_of_parent_ceiling_rate(
		string [] policies,
		long [] percents
	) {
		this.Invoke("set_shaping_policy_percent_of_parent_ceiling_rate", new object [] {
				policies,
				percents});

	}
	public System.IAsyncResult Beginset_shaping_policy_percent_of_parent_ceiling_rate(string [] policies,long [] percents, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_shaping_policy_percent_of_parent_ceiling_rate", new object[] {
			policies,
			percents}, callback, asyncState);
	}
	public void Endset_shaping_policy_percent_of_parent_ceiling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_shaping_policy_queueing_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RateClass", 
		RequestNamespace="urn:iControl:LocalLB/RateClass", ResponseNamespace="urn:iControl:LocalLB/RateClass")]
	public void set_shaping_policy_queueing_method(
		string [] policies,
		string [] methods
	) {
		this.Invoke("set_shaping_policy_queueing_method", new object [] {
				policies,
				methods});

	}
	public System.IAsyncResult Beginset_shaping_policy_queueing_method(string [] policies,string [] methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_shaping_policy_queueing_method", new object[] {
			policies,
			methods}, callback, asyncState);
	}
	public void Endset_shaping_policy_queueing_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RateClass.DirectionType", Namespace = "urn:iControl")]
	public enum LocalLBRateClassDirectionType
	{
		DIRECTION_ANY,
		DIRECTION_CLIENT,
		DIRECTION_SERVER,
		DIRECTION_VLAN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RateClass.DropPolicyType", Namespace = "urn:iControl")]
	public enum LocalLBRateClassDropPolicyType
	{
		DROP_INVALID,
		DROP_TAIL,
		DROP_RED,
		DROP_FRED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RateClass.QueueType", Namespace = "urn:iControl")]
	public enum LocalLBRateClassQueueType
	{
		QUEUE_NONE,
		QUEUE_STOCHASTIC_FAIR,
		QUEUE_PRIORITY_FIFO,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RateClass.UnitType", Namespace = "urn:iControl")]
	public enum LocalLBRateClassUnitType
	{
		UNIT_BPS,
		UNIT_KBPS,
		UNIT_MBPS,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RateClass.RateClassStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBRateClassRateClassStatisticEntry
	{
		private string rate_classField;
		public string rate_class
		{
			get { return this.rate_classField; }
			set { this.rate_classField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RateClass.RateClassStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBRateClassRateClassStatistics
	{
		private LocalLBRateClassRateClassStatisticEntry [] statisticsField;
		public LocalLBRateClassRateClassStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RateClass.RateUnit", Namespace = "urn:iControl")]
	public partial class LocalLBRateClassRateUnit
	{
		private long rateField;
		public long rate
		{
			get { return this.rateField; }
			set { this.rateField = value; }
		}
		private LocalLBRateClassUnitType unitField;
		public LocalLBRateClassUnitType unit
		{
			get { return this.unitField; }
			set { this.unitField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RateClass.RateUnitV2", Namespace = "urn:iControl")]
	public partial class LocalLBRateClassRateUnitV2
	{
		private CommonULong64 rateField;
		public CommonULong64 rate
		{
			get { return this.rateField; }
			set { this.rateField = value; }
		}
		private LocalLBRateClassUnitType unitField;
		public LocalLBRateClassUnitType unit
		{
			get { return this.unitField; }
			set { this.unitField = value; }
		}
	};

}
