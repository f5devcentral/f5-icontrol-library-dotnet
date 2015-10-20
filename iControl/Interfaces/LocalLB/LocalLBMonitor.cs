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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.MonitorBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorMonitorTemplate))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorCommonAttributes))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorInstanceState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorIPPort))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorIntegerValue))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorStringValue))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorUserDefinedStringValue))]
	public partial class LocalLBMonitor : iControlInterface {
		public LocalLBMonitor() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void create_template(
		LocalLBMonitorMonitorTemplate [] templates,
		LocalLBMonitorCommonAttributes [] template_attributes
	) {
		this.Invoke("create_template", new object [] {
				templates,
				template_attributes});

	}
	public System.IAsyncResult Begincreate_template(LocalLBMonitorMonitorTemplate [] templates,LocalLBMonitorCommonAttributes [] template_attributes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_template", new object[] {
			templates,
			template_attributes}, callback, asyncState);
	}
	public void Endcreate_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_templates
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void delete_all_templates(

	) {
		this.Invoke("delete_all_templates", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_templates(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_templates", new object[0], callback, asyncState);
	}
	public void Enddelete_all_templates(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void delete_template(
		string [] template_names
	) {
		this.Invoke("delete_template", new object [] {
				template_names});

	}
	public System.IAsyncResult Begindelete_template(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_template", new object[] {
			template_names}, callback, asyncState);
	}
	public void Enddelete_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_adaptive_divergence_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorAdaptiveType [] get_adaptive_divergence_type(
		string [] template_names
	) {
		object [] results = this.Invoke("get_adaptive_divergence_type", new object [] {
				template_names});
		return ((LocalLBMonitorAdaptiveType [])(results[0]));
	}
	public System.IAsyncResult Beginget_adaptive_divergence_type(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_adaptive_divergence_type", new object[] {
			template_names}, callback, asyncState);
	}
	public LocalLBMonitorAdaptiveType [] Endget_adaptive_divergence_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorAdaptiveType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_adaptive_divergence_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_adaptive_divergence_value(
		string [] template_names
	) {
		object [] results = this.Invoke("get_adaptive_divergence_value", new object [] {
				template_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_adaptive_divergence_value(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_adaptive_divergence_value", new object[] {
			template_names}, callback, asyncState);
	}
	public long [] Endget_adaptive_divergence_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_adaptive_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_adaptive_limit(
		string [] template_names
	) {
		object [] results = this.Invoke("get_adaptive_limit", new object [] {
				template_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_adaptive_limit(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_adaptive_limit", new object[] {
			template_names}, callback, asyncState);
	}
	public long [] Endget_adaptive_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_adaptive_sampling_timespan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_adaptive_sampling_timespan(
		string [] template_names
	) {
		object [] results = this.Invoke("get_adaptive_sampling_timespan", new object [] {
				template_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_adaptive_sampling_timespan(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_adaptive_sampling_timespan", new object[] {
			template_names}, callback, asyncState);
	}
	public long [] Endget_adaptive_sampling_timespan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_adaptive_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_adaptive_state(
		string [] template_names
	) {
		object [] results = this.Invoke("get_adaptive_state", new object [] {
				template_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_adaptive_state(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_adaptive_state", new object[] {
			template_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_adaptive_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] template_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				template_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			template_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_instance_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorInstanceState [] get_instance_state(
		LocalLBMonitorInstance [] instances
	) {
		object [] results = this.Invoke("get_instance_state", new object [] {
				instances});
		return ((LocalLBMonitorInstanceState [])(results[0]));
	}
	public System.IAsyncResult Beginget_instance_state(LocalLBMonitorInstance [] instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_instance_state", new object[] {
			instances}, callback, asyncState);
	}
	public LocalLBMonitorInstanceState [] Endget_instance_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorInstanceState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_manual_resume_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_manual_resume_state(
		string [] template_names
	) {
		object [] results = this.Invoke("get_manual_resume_state", new object [] {
				template_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_manual_resume_state(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_manual_resume_state", new object[] {
			template_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_manual_resume_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_parent_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_parent_template(
		string [] template_names
	) {
		object [] results = this.Invoke("get_parent_template", new object [] {
				template_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_parent_template(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_parent_template", new object[] {
			template_names}, callback, asyncState);
	}
	public string [] Endget_parent_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_address_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBAddressType [] get_template_address_type(
		string [] template_names
	) {
		object [] results = this.Invoke("get_template_address_type", new object [] {
				template_names});
		return ((LocalLBAddressType [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_address_type(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_address_type", new object[] {
			template_names}, callback, asyncState);
	}
	public LocalLBAddressType [] Endget_template_address_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBAddressType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorIPPort [] get_template_destination(
		string [] template_names
	) {
		object [] results = this.Invoke("get_template_destination", new object [] {
				template_names});
		return ((LocalLBMonitorIPPort [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_destination(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_destination", new object[] {
			template_names}, callback, asyncState);
	}
	public LocalLBMonitorIPPort [] Endget_template_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorIPPort [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_integer_property
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorIntegerValue [] get_template_integer_property(
		string [] template_names,
		LocalLBMonitorIntPropertyType [] property_types
	) {
		object [] results = this.Invoke("get_template_integer_property", new object [] {
				template_names,
				property_types});
		return ((LocalLBMonitorIntegerValue [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_integer_property(string [] template_names,LocalLBMonitorIntPropertyType [] property_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_integer_property", new object[] {
			template_names,
			property_types}, callback, asyncState);
	}
	public LocalLBMonitorIntegerValue [] Endget_template_integer_property(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorIntegerValue [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorMonitorTemplate [] get_template_list(

	) {
		object [] results = this.Invoke("get_template_list", new object [0]);
		return ((LocalLBMonitorMonitorTemplate [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_list", new object[0], callback, asyncState);
	}
	public LocalLBMonitorMonitorTemplate [] Endget_template_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorMonitorTemplate [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_reverse_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_template_reverse_mode(
		string [] template_names
	) {
		object [] results = this.Invoke("get_template_reverse_mode", new object [] {
				template_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_reverse_mode(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_reverse_mode", new object[] {
			template_names}, callback, asyncState);
	}
	public bool [] Endget_template_reverse_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_template_state(
		string [] template_names
	) {
		object [] results = this.Invoke("get_template_state", new object [] {
				template_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_state(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_state", new object[] {
			template_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_template_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_string_property
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorStringValue [] get_template_string_property(
		string [] template_names,
		LocalLBMonitorStrPropertyType [] property_types
	) {
		object [] results = this.Invoke("get_template_string_property", new object [] {
				template_names,
				property_types});
		return ((LocalLBMonitorStringValue [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_string_property(string [] template_names,LocalLBMonitorStrPropertyType [] property_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_string_property", new object[] {
			template_names,
			property_types}, callback, asyncState);
	}
	public LocalLBMonitorStringValue [] Endget_template_string_property(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorStringValue [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_transparent_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_template_transparent_mode(
		string [] template_names
	) {
		object [] results = this.Invoke("get_template_transparent_mode", new object [] {
				template_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_transparent_mode(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_transparent_mode", new object[] {
			template_names}, callback, asyncState);
	}
	public bool [] Endget_template_transparent_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorTemplateType [] get_template_type(
		string [] template_names
	) {
		object [] results = this.Invoke("get_template_type", new object [] {
				template_names});
		return ((LocalLBMonitorTemplateType [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_type(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_type", new object[] {
			template_names}, callback, asyncState);
	}
	public LocalLBMonitorTemplateType [] Endget_template_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorTemplateType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_user_defined_string_property
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorUserDefinedStringValue [] get_template_user_defined_string_property(
		string [] template_names,
		string [] property_names
	) {
		object [] results = this.Invoke("get_template_user_defined_string_property", new object [] {
				template_names,
				property_names});
		return ((LocalLBMonitorUserDefinedStringValue [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_user_defined_string_property(string [] template_names,string [] property_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_user_defined_string_property", new object[] {
			template_names,
			property_names}, callback, asyncState);
	}
	public LocalLBMonitorUserDefinedStringValue [] Endget_template_user_defined_string_property(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorUserDefinedStringValue [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
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
	// is_template_directly_usable
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_template_directly_usable(
		string [] template_names
	) {
		object [] results = this.Invoke("is_template_directly_usable", new object [] {
				template_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_template_directly_usable(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_template_directly_usable", new object[] {
			template_names}, callback, asyncState);
	}
	public bool [] Endis_template_directly_usable(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_template_read_only
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_template_read_only(
		string [] template_names
	) {
		object [] results = this.Invoke("is_template_read_only", new object [] {
				template_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_template_read_only(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_template_read_only", new object[] {
			template_names}, callback, asyncState);
	}
	public bool [] Endis_template_read_only(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_template_root
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_template_root(
		string [] template_names
	) {
		object [] results = this.Invoke("is_template_root", new object [] {
				template_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_template_root(string [] template_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_template_root", new object[] {
			template_names}, callback, asyncState);
	}
	public bool [] Endis_template_root(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_adaptive_divergence_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_adaptive_divergence_type(
		string [] template_names,
		LocalLBMonitorAdaptiveType [] types
	) {
		this.Invoke("set_adaptive_divergence_type", new object [] {
				template_names,
				types});

	}
	public System.IAsyncResult Beginset_adaptive_divergence_type(string [] template_names,LocalLBMonitorAdaptiveType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_adaptive_divergence_type", new object[] {
			template_names,
			types}, callback, asyncState);
	}
	public void Endset_adaptive_divergence_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_adaptive_divergence_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_adaptive_divergence_value(
		string [] template_names,
		long [] values
	) {
		this.Invoke("set_adaptive_divergence_value", new object [] {
				template_names,
				values});

	}
	public System.IAsyncResult Beginset_adaptive_divergence_value(string [] template_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_adaptive_divergence_value", new object[] {
			template_names,
			values}, callback, asyncState);
	}
	public void Endset_adaptive_divergence_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_adaptive_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_adaptive_limit(
		string [] template_names,
		long [] limits
	) {
		this.Invoke("set_adaptive_limit", new object [] {
				template_names,
				limits});

	}
	public System.IAsyncResult Beginset_adaptive_limit(string [] template_names,long [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_adaptive_limit", new object[] {
			template_names,
			limits}, callback, asyncState);
	}
	public void Endset_adaptive_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_adaptive_sampling_timespan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_adaptive_sampling_timespan(
		string [] template_names,
		long [] timespans
	) {
		this.Invoke("set_adaptive_sampling_timespan", new object [] {
				template_names,
				timespans});

	}
	public System.IAsyncResult Beginset_adaptive_sampling_timespan(string [] template_names,long [] timespans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_adaptive_sampling_timespan", new object[] {
			template_names,
			timespans}, callback, asyncState);
	}
	public void Endset_adaptive_sampling_timespan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_adaptive_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_adaptive_state(
		string [] template_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_adaptive_state", new object [] {
				template_names,
				states});

	}
	public System.IAsyncResult Beginset_adaptive_state(string [] template_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_adaptive_state", new object[] {
			template_names,
			states}, callback, asyncState);
	}
	public void Endset_adaptive_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_description(
		string [] template_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				template_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] template_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			template_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_instance_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_instance_state(
		LocalLBMonitorInstanceState [] instance_states
	) {
		this.Invoke("set_instance_state", new object [] {
				instance_states});

	}
	public System.IAsyncResult Beginset_instance_state(LocalLBMonitorInstanceState [] instance_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_instance_state", new object[] {
			instance_states}, callback, asyncState);
	}
	public void Endset_instance_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_manual_resume_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_manual_resume_state(
		string [] template_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_manual_resume_state", new object [] {
				template_names,
				states});

	}
	public System.IAsyncResult Beginset_manual_resume_state(string [] template_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_manual_resume_state", new object[] {
			template_names,
			states}, callback, asyncState);
	}
	public void Endset_manual_resume_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_template_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_template_destination(
		string [] template_names,
		LocalLBMonitorIPPort [] destinations
	) {
		this.Invoke("set_template_destination", new object [] {
				template_names,
				destinations});

	}
	public System.IAsyncResult Beginset_template_destination(string [] template_names,LocalLBMonitorIPPort [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_template_destination", new object[] {
			template_names,
			destinations}, callback, asyncState);
	}
	public void Endset_template_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_template_integer_property
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_template_integer_property(
		string [] template_names,
		LocalLBMonitorIntegerValue [] values
	) {
		this.Invoke("set_template_integer_property", new object [] {
				template_names,
				values});

	}
	public System.IAsyncResult Beginset_template_integer_property(string [] template_names,LocalLBMonitorIntegerValue [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_template_integer_property", new object[] {
			template_names,
			values}, callback, asyncState);
	}
	public void Endset_template_integer_property(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_template_reverse_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_template_reverse_mode(
		string [] template_names,
		bool [] reverse_modes
	) {
		this.Invoke("set_template_reverse_mode", new object [] {
				template_names,
				reverse_modes});

	}
	public System.IAsyncResult Beginset_template_reverse_mode(string [] template_names,bool [] reverse_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_template_reverse_mode", new object[] {
			template_names,
			reverse_modes}, callback, asyncState);
	}
	public void Endset_template_reverse_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_template_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_template_state(
		string [] template_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_template_state", new object [] {
				template_names,
				states});

	}
	public System.IAsyncResult Beginset_template_state(string [] template_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_template_state", new object[] {
			template_names,
			states}, callback, asyncState);
	}
	public void Endset_template_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_template_string_property
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_template_string_property(
		string [] template_names,
		LocalLBMonitorStringValue [] values
	) {
		this.Invoke("set_template_string_property", new object [] {
				template_names,
				values});

	}
	public System.IAsyncResult Beginset_template_string_property(string [] template_names,LocalLBMonitorStringValue [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_template_string_property", new object[] {
			template_names,
			values}, callback, asyncState);
	}
	public void Endset_template_string_property(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_template_transparent_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_template_transparent_mode(
		string [] template_names,
		bool [] transparent_modes
	) {
		this.Invoke("set_template_transparent_mode", new object [] {
				template_names,
				transparent_modes});

	}
	public System.IAsyncResult Beginset_template_transparent_mode(string [] template_names,bool [] transparent_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_template_transparent_mode", new object[] {
			template_names,
			transparent_modes}, callback, asyncState);
	}
	public void Endset_template_transparent_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_template_user_defined_string_property
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Monitor", 
		RequestNamespace="urn:iControl:LocalLB/Monitor", ResponseNamespace="urn:iControl:LocalLB/Monitor")]
	public void set_template_user_defined_string_property(
		string [] template_names,
		LocalLBMonitorUserDefinedStringValue [] values
	) {
		this.Invoke("set_template_user_defined_string_property", new object [] {
				template_names,
				values});

	}
	public System.IAsyncResult Beginset_template_user_defined_string_property(string [] template_names,LocalLBMonitorUserDefinedStringValue [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_template_user_defined_string_property", new object[] {
			template_names,
			values}, callback, asyncState);
	}
	public void Endset_template_user_defined_string_property(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Monitor.AdaptiveType", Namespace = "urn:iControl")]
	public enum LocalLBMonitorAdaptiveType
	{
		ATYPE_UNKNOWN,
		ATYPE_RELATIVE,
		ATYPE_ABSOLUTE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Monitor.IntPropertyType", Namespace = "urn:iControl")]
	public enum LocalLBMonitorIntPropertyType
	{
		ITYPE_UNSET,
		ITYPE_INTERVAL,
		ITYPE_TIMEOUT,
		ITYPE_PROBE_INTERVAL,
		ITYPE_PROBE_TIMEOUT,
		ITYPE_PROBE_NUM_PROBES,
		ITYPE_PROBE_NUM_SUCCESSES,
		ITYPE_TIME_UNTIL_UP,
		ITYPE_UP_INTERVAL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Monitor.StrPropertyType", Namespace = "urn:iControl")]
	public enum LocalLBMonitorStrPropertyType
	{
		STYPE_UNSET,
		STYPE_SEND,
		STYPE_GET,
		STYPE_RECEIVE,
		STYPE_USERNAME,
		STYPE_PASSWORD,
		STYPE_RUN,
		STYPE_NEWSGROUP,
		STYPE_DATABASE,
		STYPE_DOMAIN,
		STYPE_ARGUMENTS,
		STYPE_FOLDER,
		STYPE_BASE,
		STYPE_FILTER,
		STYPE_SECRET,
		STYPE_METHOD,
		STYPE_URL,
		STYPE_COMMAND,
		STYPE_METRICS,
		STYPE_POST,
		STYPE_USERAGENT,
		STYPE_AGENT_TYPE,
		STYPE_CPU_COEFFICIENT,
		STYPE_CPU_THRESHOLD,
		STYPE_MEMORY_COEFFICIENT,
		STYPE_MEMORY_THRESHOLD,
		STYPE_DISK_COEFFICIENT,
		STYPE_DISK_THRESHOLD,
		STYPE_SNMP_VERSION,
		STYPE_COMMUNITY,
		STYPE_SEND_PACKETS,
		STYPE_TIMEOUT_PACKETS,
		STYPE_RECEIVE_DRAIN,
		STYPE_RECEIVE_ROW,
		STYPE_RECEIVE_COLUMN,
		STYPE_DEBUG,
		STYPE_SECURITY,
		STYPE_MODE,
		STYPE_CIPHER_LIST,
		STYPE_NAMESPACE,
		STYPE_PARAMETER_NAME,
		STYPE_PARAMETER_VALUE,
		STYPE_PARAMETER_TYPE,
		STYPE_RETURN_TYPE,
		STYPE_RETURN_VALUE,
		STYPE_SOAP_FAULT,
		STYPE_SSL_OPTIONS,
		STYPE_CLIENT_CERTIFICATE,
		STYPE_PROTOCOL,
		STYPE_MANDATORY_ATTRS,
		STYPE_FILENAME,
		STYPE_ACCOUNTING_NODE,
		STYPE_ACCOUNTING_PORT,
		STYPE_SERVER_ID,
		STYPE_CALL_ID,
		STYPE_SESSION_ID,
		STYPE_FRAMED_ADDRESS,
		STYPE_PROGRAM,
		STYPE_VERSION,
		STYPE_SERVER,
		STYPE_SERVICE,
		STYPE_GW_MONITOR_ADDRESS,
		STYPE_GW_MONITOR_SERVICE,
		STYPE_GW_MONITOR_INTERVAL,
		STYPE_GW_MONITOR_PROTOCOL,
		STYPE_DB_COUNT,
		STYPE_REQUEST,
		STYPE_HEADERS,
		STYPE_FILTER_NEG,
		STYPE_SERVER_IP,
		STYPE_SNMP_PORT,
		STYPE_POOL_NAME,
		STYPE_NAS_IP,
		STYPE_CLIENT_KEY,
		STYPE_MAX_LOAD_AVERAGE,
		STYPE_CONCURRENCY_LIMIT,
		STYPE_FAILURES,
		STYPE_FAILURE_INTERVAL,
		STYPE_RESPONSE_TIME,
		STYPE_RETRY_TIME,
		STYPE_DIAMETER_ACCT_APPLICATION_ID,
		STYPE_DIAMETER_AUTH_APPLICATION_ID,
		STYPE_DIAMETER_ORIGIN_HOST,
		STYPE_DIAMETER_ORIGIN_REALM,
		STYPE_DIAMETER_HOST_IP_ADDRESS,
		STYPE_DIAMETER_VENDOR_ID,
		STYPE_DIAMETER_PRODUCT_NAME,
		STYPE_DIAMETER_VENDOR_SPECIFIC_VENDOR_ID,
		STYPE_DIAMETER_VENDOR_SPECIFIC_ACCT_APPLICATION_ID,
		STYPE_DIAMETER_VENDOR_SPECIFIC_AUTH_APPLICATION_ID,
		STYPE_RUN_V2,
		STYPE_CLIENT_CERTIFICATE_V2,
		STYPE_CLIENT_KEY_V2,
		STYPE_CHASE_REFERRALS,
		STYPE_QUERY_NAME,
		STYPE_QUERY_TYPE,
		STYPE_ANSWER_CONTAINS,
		STYPE_ACCEPT_RCODE,
		STYPE_GW_MONITOR_MODE,
		STYPE_GW_MONITOR_SECONDARY_ADDRESS,
		STYPE_DSCP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Monitor.TemplateType", Namespace = "urn:iControl")]
	public enum LocalLBMonitorTemplateType
	{
		TTYPE_UNSET,
		TTYPE_ICMP,
		TTYPE_TCP,
		TTYPE_TCP_ECHO,
		TTYPE_EXTERNAL,
		TTYPE_HTTP,
		TTYPE_HTTPS,
		TTYPE_NNTP,
		TTYPE_FTP,
		TTYPE_POP3,
		TTYPE_SMTP,
		TTYPE_MSSQL,
		TTYPE_GATEWAY,
		TTYPE_IMAP,
		TTYPE_RADIUS,
		TTYPE_LDAP,
		TTYPE_WMI,
		TTYPE_SNMP_DCA,
		TTYPE_SNMP_DCA_BASE,
		TTYPE_REAL_SERVER,
		TTYPE_UDP,
		TTYPE_NONE,
		TTYPE_ORACLE,
		TTYPE_SOAP,
		TTYPE_GATEWAY_ICMP,
		TTYPE_SIP,
		TTYPE_TCP_HALF_OPEN,
		TTYPE_SCRIPTED,
		TTYPE_WAP,
		TTYPE_RPC,
		TTYPE_SMB,
		TTYPE_SASP,
		TTYPE_MODULE_SCORE,
		TTYPE_FIREPASS,
		TTYPE_INBAND,
		TTYPE_RADIUS_ACCOUNTING,
		TTYPE_DIAMETER,
		TTYPE_VIRTUAL_LOCATION,
		TTYPE_MYSQL,
		TTYPE_POSTGRESQL,
		TTYPE_DNS,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Monitor.CommonAttributes", Namespace = "urn:iControl")]
	public partial class LocalLBMonitorCommonAttributes
	{
		private string parent_templateField;
		public string parent_template
		{
			get { return this.parent_templateField; }
			set { this.parent_templateField = value; }
		}
		private long intervalField;
		public long interval
		{
			get { return this.intervalField; }
			set { this.intervalField = value; }
		}
		private long timeoutField;
		public long timeout
		{
			get { return this.timeoutField; }
			set { this.timeoutField = value; }
		}
		private LocalLBMonitorIPPort dest_ipportField;
		public LocalLBMonitorIPPort dest_ipport
		{
			get { return this.dest_ipportField; }
			set { this.dest_ipportField = value; }
		}
		private bool is_read_onlyField;
		public bool is_read_only
		{
			get { return this.is_read_onlyField; }
			set { this.is_read_onlyField = value; }
		}
		private bool is_directly_usableField;
		public bool is_directly_usable
		{
			get { return this.is_directly_usableField; }
			set { this.is_directly_usableField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Monitor.IntegerValue", Namespace = "urn:iControl")]
	public partial class LocalLBMonitorIntegerValue
	{
		private LocalLBMonitorIntPropertyType typeField;
		public LocalLBMonitorIntPropertyType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private long valueField;
		public long value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Monitor.MonitorTemplate", Namespace = "urn:iControl")]
	public partial class LocalLBMonitorMonitorTemplate
	{
		private string template_nameField;
		public string template_name
		{
			get { return this.template_nameField; }
			set { this.template_nameField = value; }
		}
		private LocalLBMonitorTemplateType template_typeField;
		public LocalLBMonitorTemplateType template_type
		{
			get { return this.template_typeField; }
			set { this.template_typeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Monitor.StringValue", Namespace = "urn:iControl")]
	public partial class LocalLBMonitorStringValue
	{
		private LocalLBMonitorStrPropertyType typeField;
		public LocalLBMonitorStrPropertyType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private string valueField;
		public string value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Monitor.UserDefinedStringValue", Namespace = "urn:iControl")]
	public partial class LocalLBMonitorUserDefinedStringValue
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string valueField;
		public string value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	};

}
