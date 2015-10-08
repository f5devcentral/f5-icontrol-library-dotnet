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
	[System.Web.Services.WebServiceBindingAttribute(Name="LTConfig.FieldBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LTConfigClassInstanceKey))]
	public partial class LTConfigField : iControlInterface {
		public LTConfigField() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_application_data
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_application_data(
		string [] class_names,
		string [] [] field_names
	) {
		object [] results = this.Invoke("get_application_data", new object [] {
				class_names,
				field_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_data(string [] class_names,string [] [] field_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_data", new object[] {
			class_names,
			field_names}, callback, asyncState);
	}
	public string [] [] Endget_application_data(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_clustered_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_clustered_state(
		string [] class_names,
		string [] [] field_names
	) {
		object [] results = this.Invoke("get_clustered_state", new object [] {
				class_names,
				field_names});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_clustered_state(string [] class_names,string [] [] field_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_clustered_state", new object[] {
			class_names,
			field_names}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_clustered_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_configsyncd_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_configsyncd_state(
		string [] class_names,
		string [] [] field_names
	) {
		object [] results = this.Invoke("get_configsyncd_state", new object [] {
				class_names,
				field_names});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_configsyncd_state(string [] class_names,string [] [] field_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_configsyncd_state", new object[] {
			class_names,
			field_names}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_configsyncd_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_db_variable_mirror_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_db_variable_mirror_information(
		string [] class_names,
		string [] [] field_names
	) {
		object [] results = this.Invoke("get_db_variable_mirror_information", new object [] {
				class_names,
				field_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_db_variable_mirror_information(string [] class_names,string [] [] field_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_db_variable_mirror_information", new object[] {
			class_names,
			field_names}, callback, asyncState);
	}
	public string [] [] Endget_db_variable_mirror_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_default(
		string [] class_names,
		string [] [] field_names
	) {
		object [] results = this.Invoke("get_default", new object [] {
				class_names,
				field_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_default(string [] class_names,string [] [] field_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default", new object[] {
			class_names,
			field_names}, callback, asyncState);
	}
	public string [] [] Endget_default(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_display_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_display_name(
		string [] class_names,
		string [] [] field_names
	) {
		object [] results = this.Invoke("get_display_name", new object [] {
				class_names,
				field_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_display_name(string [] class_names,string [] [] field_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_display_name", new object[] {
			class_names,
			field_names}, callback, asyncState);
	}
	public string [] [] Endget_display_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_list(
		string [] class_names
	) {
		object [] results = this.Invoke("get_list", new object [] {
				class_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[] {
			class_names}, callback, asyncState);
	}
	public string [] [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_required_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_required_state(
		string [] class_names,
		string [] [] field_names
	) {
		object [] results = this.Invoke("get_required_state", new object [] {
				class_names,
				field_names});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_required_state(string [] class_names,string [] [] field_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_required_state", new object[] {
			class_names,
			field_names}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_required_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_type_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_type_information(
		string [] class_names,
		string [] [] field_names
	) {
		object [] results = this.Invoke("get_type_information", new object [] {
				class_names,
				field_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_type_information(string [] class_names,string [] [] field_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_type_information", new object[] {
			class_names,
			field_names}, callback, asyncState);
	}
	public string [] [] Endget_type_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_value(
		LTConfigClassInstanceKey class_instance_key,
		string field_instance_name
	) {
		object [] results = this.Invoke("get_value", new object [] {
				class_instance_key,
				field_instance_name});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_value(LTConfigClassInstanceKey class_instance_key,string field_instance_name, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_value", new object[] {
			class_instance_key,
			field_instance_name}, callback, asyncState);
	}
	public string Endget_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_values
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_values(
		LTConfigClassInstanceKey [] class_instance_keys,
		string [] [] field_instance_names
	) {
		object [] results = this.Invoke("get_values", new object [] {
				class_instance_keys,
				field_instance_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_values(LTConfigClassInstanceKey [] class_instance_keys,string [] [] field_instance_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_values", new object[] {
			class_instance_keys,
			field_instance_names}, callback, asyncState);
	}
	public string [] [] Endget_values(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
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
	// set_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	public void set_value(
		bool create_instances_if_needed,
		LTConfigClassInstanceKey class_instance_key,
		string field_instance_name,
		string value
	) {
		this.Invoke("set_value", new object [] {
				create_instances_if_needed,
				class_instance_key,
				field_instance_name,
				value});

	}
	public System.IAsyncResult Beginset_value(bool create_instances_if_needed,LTConfigClassInstanceKey class_instance_key,string field_instance_name,string value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_value", new object[] {
			create_instances_if_needed,
			class_instance_key,
			field_instance_name,
			value}, callback, asyncState);
	}
	public void Endset_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_values
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LTConfig/Field", 
		RequestNamespace="urn:iControl:LTConfig/Field", ResponseNamespace="urn:iControl:LTConfig/Field")]
	public void set_values(
		bool create_instances_if_needed,
		LTConfigClassInstanceKey [] class_instance_keys,
		string [] [] field_instance_names,
		string [] [] values
	) {
		this.Invoke("set_values", new object [] {
				create_instances_if_needed,
				class_instance_keys,
				field_instance_names,
				values});

	}
	public System.IAsyncResult Beginset_values(bool create_instances_if_needed,LTConfigClassInstanceKey [] class_instance_keys,string [] [] field_instance_names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_values", new object[] {
			create_instances_if_needed,
			class_instance_keys,
			field_instance_names,
			values}, callback, asyncState);
	}
	public void Endset_values(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
