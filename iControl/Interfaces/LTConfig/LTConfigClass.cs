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
	[System.Web.Services.WebServiceBindingAttribute(Name="LTConfig.ClassBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LTConfigClassInstanceKey))]
	public partial class LTConfigClass : iControlInterface {
		public LTConfigClass() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	public void create_instance(
		LTConfigClassInstanceKey [] class_instance_keys
	) {
		this.Invoke("create_instance", new object [] {
				class_instance_keys});

	}
	public System.IAsyncResult Begincreate_instance(LTConfigClassInstanceKey [] class_instance_keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_instance", new object[] {
			class_instance_keys}, callback, asyncState);
	}
	public void Endcreate_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	public void delete_instance(
		LTConfigClassInstanceKey [] class_instance_keys
	) {
		this.Invoke("delete_instance", new object [] {
				class_instance_keys});

	}
	public System.IAsyncResult Begindelete_instance(LTConfigClassInstanceKey [] class_instance_keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_instance", new object[] {
			class_instance_keys}, callback, asyncState);
	}
	public void Enddelete_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_category(
		string [] class_names
	) {
		object [] results = this.Invoke("get_category", new object [] {
				class_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_category(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_category", new object[] {
			class_names}, callback, asyncState);
	}
	public string [] Endget_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_clustered_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_clustered_state(
		string [] class_names
	) {
		object [] results = this.Invoke("get_clustered_state", new object [] {
				class_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_clustered_state(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_clustered_state", new object[] {
			class_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_clustered_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_configsyncd_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_configsyncd_state(
		string [] class_names
	) {
		object [] results = this.Invoke("get_configsyncd_state", new object [] {
				class_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_configsyncd_state(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_configsyncd_state", new object[] {
			class_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_configsyncd_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_constraints
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_constraints(
		string [] class_names
	) {
		object [] results = this.Invoke("get_constraints", new object [] {
				class_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_constraints(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_constraints", new object[] {
			class_names}, callback, asyncState);
	}
	public string [] [] Endget_constraints(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_field_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_field_count(
		string [] class_names
	) {
		object [] results = this.Invoke("get_field_count", new object [] {
				class_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_field_count(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_field_count", new object[] {
			class_names}, callback, asyncState);
	}
	public long [] Endget_field_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
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
	// get_list_of_instances
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LTConfigClassInstanceKey [] [] get_list_of_instances(
		string [] class_names
	) {
		object [] results = this.Invoke("get_list_of_instances", new object [] {
				class_names});
		return ((LTConfigClassInstanceKey [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_list_of_instances(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list_of_instances", new object[] {
			class_names}, callback, asyncState);
	}
	public LTConfigClassInstanceKey [] [] Endget_list_of_instances(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LTConfigClassInstanceKey [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nested_classes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_nested_classes(
		string [] class_names
	) {
		object [] results = this.Invoke("get_nested_classes", new object [] {
				class_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_nested_classes(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nested_classes", new object[] {
			class_names}, callback, asyncState);
	}
	public string [] [] Endget_nested_classes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_partitioned_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_partitioned_state(
		string [] class_names
	) {
		object [] results = this.Invoke("get_partitioned_state", new object [] {
				class_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_partitioned_state(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_partitioned_state", new object[] {
			class_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_partitioned_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_singleton_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_singleton_state(
		string [] class_names
	) {
		object [] results = this.Invoke("get_singleton_state", new object [] {
				class_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_singleton_state(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_singleton_state", new object[] {
			class_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_singleton_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_statistics(
		string [] class_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				class_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			class_names}, callback, asyncState);
	}
	public string [] [] Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_toplevelcmd_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_toplevelcmd_state(
		string [] class_names
	) {
		object [] results = this.Invoke("get_toplevelcmd_state", new object [] {
				class_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_toplevelcmd_state(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_toplevelcmd_state", new object[] {
			class_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_toplevelcmd_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Class", 
		RequestNamespace="urn:iControl:LTConfig/Class", ResponseNamespace="urn:iControl:LTConfig/Class")]
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

}
