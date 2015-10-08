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
	[System.Web.Services.WebServiceBindingAttribute(Name="ASM.ObjectParamsBinding", Namespace="urn:iControl")]
	public partial class ASMObjectParams : iControlInterface {
		public ASMObjectParams() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_or_update_object_param_with_characteristics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/ObjectParams", 
		RequestNamespace="urn:iControl:ASM/ObjectParams", ResponseNamespace="urn:iControl:ASM/ObjectParams")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool add_or_update_object_param_with_characteristics(
		string policy_name,
		string uri,
		string param_name,
		ASMObjectParamsObjectParamCategory [] setting_categories
	) {
		object [] results = this.Invoke("add_or_update_object_param_with_characteristics", new object [] {
				policy_name,
				uri,
				param_name,
				setting_categories});
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginadd_or_update_object_param_with_characteristics(string policy_name,string uri,string param_name,ASMObjectParamsObjectParamCategory [] setting_categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_or_update_object_param_with_characteristics", new object[] {
			policy_name,
			uri,
			param_name,
			setting_categories}, callback, asyncState);
	}
	public bool Endadd_or_update_object_param_with_characteristics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/ObjectParams", 
		RequestNamespace="urn:iControl:ASM/ObjectParams", ResponseNamespace="urn:iControl:ASM/ObjectParams")]
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
	// set_parameter_staging_flag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/ObjectParams", 
		RequestNamespace="urn:iControl:ASM/ObjectParams", ResponseNamespace="urn:iControl:ASM/ObjectParams")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool set_parameter_staging_flag(
		string policy_name,
		string uri,
		string param_name,
		bool flg_is_staging
	) {
		object [] results = this.Invoke("set_parameter_staging_flag", new object [] {
				policy_name,
				uri,
				param_name,
				flg_is_staging});
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginset_parameter_staging_flag(string policy_name,string uri,string param_name,bool flg_is_staging, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_parameter_staging_flag", new object[] {
			policy_name,
			uri,
			param_name,
			flg_is_staging}, callback, asyncState);
	}
	public bool Endset_parameter_staging_flag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.ObjectParams.ObjectParamCategory", Namespace = "urn:iControl")]
	public enum ASMObjectParamsObjectParamCategory
	{
		WH_OBJECT_PARAM_SQL_INJECTION,
		WH_OBJECT_PARAM_XSS,
		WH_OBJECT_PARAM_COMMAND_INJECTION,
		WH_OBJECT_PARAM_XPATH_INJECTION,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.ObjectParams.AttackSignatureDefinition", Namespace = "urn:iControl")]
	public partial class ASMObjectParamsAttackSignatureDefinition
	{
		private long attack_signature_idField;
		public long attack_signature_id
		{
			get { return this.attack_signature_idField; }
			set { this.attack_signature_idField = value; }
		}
		private bool enable_flagField;
		public bool enable_flag
		{
			get { return this.enable_flagField; }
			set { this.enable_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.ObjectParams.MetacharDefinition", Namespace = "urn:iControl")]
	public partial class ASMObjectParamsMetacharDefinition
	{
		private long metachar_idField;
		public long metachar_id
		{
			get { return this.metachar_idField; }
			set { this.metachar_idField = value; }
		}
		private bool allow_flagField;
		public bool allow_flag
		{
			get { return this.allow_flagField; }
			set { this.allow_flagField = value; }
		}
	};

}
