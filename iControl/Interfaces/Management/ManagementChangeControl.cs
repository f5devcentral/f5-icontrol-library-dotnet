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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.ChangeControlBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementChangeControlClassInfo))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementChangeControlDeprecatedClassInfo))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementChangeControlInstance))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementChangeControlInstanceInfo))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementChangeControlClassTransactionInfo))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementChangeControlInstanceVariable))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementChangeControlModuleInfo))]
	public partial class ManagementChangeControl : iControlInterface {
		public ManagementChangeControl() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// delete_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	public void delete_instance(
		string [] instance_names
	) {
		this.Invoke("delete_instance", new object [] {
				instance_names});

	}
	public System.IAsyncResult Begindelete_instance(string [] instance_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_instance", new object[] {
			instance_names}, callback, asyncState);
	}
	public void Enddelete_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_class_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementChangeControlClassInfo [] get_class_info(
		string filter
	) {
		object [] results = this.Invoke("get_class_info", new object [] {
				filter});
		return ((ManagementChangeControlClassInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_class_info(string filter, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_class_info", new object[] {
			filter}, callback, asyncState);
	}
	public ManagementChangeControlClassInfo [] Endget_class_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementChangeControlClassInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_deprecated_class_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementChangeControlDeprecatedClassInfo [] get_deprecated_class_info(
		string filter
	) {
		object [] results = this.Invoke("get_deprecated_class_info", new object [] {
				filter});
		return ((ManagementChangeControlDeprecatedClassInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_deprecated_class_info(string filter, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_deprecated_class_info", new object[] {
			filter}, callback, asyncState);
	}
	public ManagementChangeControlDeprecatedClassInfo [] Endget_deprecated_class_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementChangeControlDeprecatedClassInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementChangeControlInstance [] get_instance(
		string [] instance_names,
		ManagementChangeControlInstanceFormatType instance_format
	) {
		object [] results = this.Invoke("get_instance", new object [] {
				instance_names,
				instance_format});
		return ((ManagementChangeControlInstance [])(results[0]));
	}
	public System.IAsyncResult Beginget_instance(string [] instance_names,ManagementChangeControlInstanceFormatType instance_format, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_instance", new object[] {
			instance_names,
			instance_format}, callback, asyncState);
	}
	public ManagementChangeControlInstance [] Endget_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementChangeControlInstance [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_instance_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_instance_dependency(
		string [] instance_names,
		long depth
	) {
		object [] results = this.Invoke("get_instance_dependency", new object [] {
				instance_names,
				depth});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_instance_dependency(string [] instance_names,long depth, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_instance_dependency", new object[] {
			instance_names,
			depth}, callback, asyncState);
	}
	public string [] [] Endget_instance_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_instance_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementChangeControlInstanceInfo [] [] get_instance_info(
		ManagementChangeControlClassTransactionInfo [] classes
	) {
		object [] results = this.Invoke("get_instance_info", new object [] {
				classes});
		return ((ManagementChangeControlInstanceInfo [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_instance_info(ManagementChangeControlClassTransactionInfo [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_instance_info", new object[] {
			classes}, callback, asyncState);
	}
	public ManagementChangeControlInstanceInfo [] [] Endget_instance_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementChangeControlInstanceInfo [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_instance_variable
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementChangeControlInstanceVariable [] [] get_instance_variable(
		string [] instance_names,
		ManagementChangeControlInstanceVariableType instance_variable
	) {
		object [] results = this.Invoke("get_instance_variable", new object [] {
				instance_names,
				instance_variable});
		return ((ManagementChangeControlInstanceVariable [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_instance_variable(string [] instance_names,ManagementChangeControlInstanceVariableType instance_variable, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_instance_variable", new object[] {
			instance_names,
			instance_variable}, callback, asyncState);
	}
	public ManagementChangeControlInstanceVariable [] [] Endget_instance_variable(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementChangeControlInstanceVariable [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_last_load_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp get_last_load_time(

	) {
		object [] results = this.Invoke("get_last_load_time", new object [0]);
		return ((CommonTimeStamp)(results[0]));
	}
	public System.IAsyncResult Beginget_last_load_time(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_load_time", new object[0], callback, asyncState);
	}
	public CommonTimeStamp Endget_last_load_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_module_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementChangeControlModuleInfo [] get_module_info(
		string filter
	) {
		object [] results = this.Invoke("get_module_info", new object [] {
				filter});
		return ((ManagementChangeControlModuleInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_module_info(string filter, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_module_info", new object[] {
			filter}, callback, asyncState);
	}
	public ManagementChangeControlModuleInfo [] Endget_module_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementChangeControlModuleInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
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
	// put_config
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	public void put_config(
		ManagementChangeControlInstanceFormatType instance_format,
		string data
	) {
		this.Invoke("put_config", new object [] {
				instance_format,
				data});

	}
	public System.IAsyncResult Beginput_config(ManagementChangeControlInstanceFormatType instance_format,string data, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("put_config", new object[] {
			instance_format,
			data}, callback, asyncState);
	}
	public void Endput_config(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// put_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	public void put_instance(
		ManagementChangeControlInstance [] instances
	) {
		this.Invoke("put_instance", new object [] {
				instances});

	}
	public System.IAsyncResult Beginput_instance(ManagementChangeControlInstance [] instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("put_instance", new object[] {
			instances}, callback, asyncState);
	}
	public void Endput_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// verify_config
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	public void verify_config(
		ManagementChangeControlInstanceFormatType instance_format,
		string data
	) {
		this.Invoke("verify_config", new object [] {
				instance_format,
				data});

	}
	public System.IAsyncResult Beginverify_config(ManagementChangeControlInstanceFormatType instance_format,string data, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("verify_config", new object[] {
			instance_format,
			data}, callback, asyncState);
	}
	public void Endverify_config(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// verify_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ChangeControl", 
		RequestNamespace="urn:iControl:Management/ChangeControl", ResponseNamespace="urn:iControl:Management/ChangeControl")]
	public void verify_instance(
		ManagementChangeControlInstance [] instances
	) {
		this.Invoke("verify_instance", new object [] {
				instances});

	}
	public System.IAsyncResult Beginverify_instance(ManagementChangeControlInstance [] instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("verify_instance", new object[] {
			instances}, callback, asyncState);
	}
	public void Endverify_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ChangeControl.InstanceFormatType", Namespace = "urn:iControl")]
	public enum ManagementChangeControlInstanceFormatType
	{
		FORMAT_SHELL,
		FORMAT_XML,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ChangeControl.InstanceVariableType", Namespace = "urn:iControl")]
	public enum ManagementChangeControlInstanceVariableType
	{
		TYPE_DEVICE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ChangeControl.ClassInfo", Namespace = "urn:iControl")]
	public partial class ManagementChangeControlClassInfo
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private long transaction_idField;
		public long transaction_id
		{
			get { return this.transaction_idField; }
			set { this.transaction_idField = value; }
		}
		private long delete_transaction_idField;
		public long delete_transaction_id
		{
			get { return this.delete_transaction_idField; }
			set { this.delete_transaction_idField = value; }
		}
		private bool supports_deleteField;
		public bool supports_delete
		{
			get { return this.supports_deleteField; }
			set { this.supports_deleteField = value; }
		}
		private bool supports_transaction_idField;
		public bool supports_transaction_id
		{
			get { return this.supports_transaction_idField; }
			set { this.supports_transaction_idField = value; }
		}
		private bool supports_verifyField;
		public bool supports_verify
		{
			get { return this.supports_verifyField; }
			set { this.supports_verifyField = value; }
		}
		private bool is_singletonField;
		public bool is_singleton
		{
			get { return this.is_singletonField; }
			set { this.is_singletonField = value; }
		}
		private bool header_needs_instance_nameField;
		public bool header_needs_instance_name
		{
			get { return this.header_needs_instance_nameField; }
			set { this.header_needs_instance_nameField = value; }
		}
		private bool is_partitionedField;
		public bool is_partitioned
		{
			get { return this.is_partitionedField; }
			set { this.is_partitionedField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ChangeControl.ClassTransactionInfo", Namespace = "urn:iControl")]
	public partial class ManagementChangeControlClassTransactionInfo
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private long transaction_idField;
		public long transaction_id
		{
			get { return this.transaction_idField; }
			set { this.transaction_idField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ChangeControl.DeprecatedClassInfo", Namespace = "urn:iControl")]
	public partial class ManagementChangeControlDeprecatedClassInfo
	{
		private string old_nameField;
		public string old_name
		{
			get { return this.old_nameField; }
			set { this.old_nameField = value; }
		}
		private string new_nameField;
		public string new_name
		{
			get { return this.new_nameField; }
			set { this.new_nameField = value; }
		}
		private string transition_versionField;
		public string transition_version
		{
			get { return this.transition_versionField; }
			set { this.transition_versionField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ChangeControl.Instance", Namespace = "urn:iControl")]
	public partial class ManagementChangeControlInstance
	{
		private ManagementChangeControlInstanceInfo infoField;
		public ManagementChangeControlInstanceInfo info
		{
			get { return this.infoField; }
			set { this.infoField = value; }
		}
		private ManagementChangeControlInstanceFormatType formatField;
		public ManagementChangeControlInstanceFormatType format
		{
			get { return this.formatField; }
			set { this.formatField = value; }
		}
		private string dataField;
		public string data
		{
			get { return this.dataField; }
			set { this.dataField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ChangeControl.InstanceInfo", Namespace = "urn:iControl")]
	public partial class ManagementChangeControlInstanceInfo
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private long transaction_idField;
		public long transaction_id
		{
			get { return this.transaction_idField; }
			set { this.transaction_idField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ChangeControl.InstanceVariable", Namespace = "urn:iControl")]
	public partial class ManagementChangeControlInstanceVariable
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string display_nameField;
		public string display_name
		{
			get { return this.display_nameField; }
			set { this.display_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ChangeControl.ModuleInfo", Namespace = "urn:iControl")]
	public partial class ManagementChangeControlModuleInfo
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private long transaction_idField;
		public long transaction_id
		{
			get { return this.transaction_idField; }
			set { this.transaction_idField = value; }
		}
		private long delete_transaction_idField;
		public long delete_transaction_id
		{
			get { return this.delete_transaction_idField; }
			set { this.delete_transaction_idField = value; }
		}
		private bool supports_transaction_idField;
		public bool supports_transaction_id
		{
			get { return this.supports_transaction_idField; }
			set { this.supports_transaction_idField = value; }
		}
	};

}
