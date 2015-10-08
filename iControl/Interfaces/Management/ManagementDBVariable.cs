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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.DBVariableBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementDBVariableVariableNameValue))]
	public partial class ManagementDBVariable : iControlInterface {
		public ManagementDBVariable() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DBVariable", 
		RequestNamespace="urn:iControl:Management/DBVariable", ResponseNamespace="urn:iControl:Management/DBVariable")]
	public void create(
		ManagementDBVariableVariableNameValue [] variables
	) {
		this.Invoke("create", new object [] {
				variables});

	}
	public System.IAsyncResult Begincreate(ManagementDBVariableVariableNameValue [] variables, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			variables}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_variable
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DBVariable", 
		RequestNamespace="urn:iControl:Management/DBVariable", ResponseNamespace="urn:iControl:Management/DBVariable")]
	public void delete_variable(
		string [] variables
	) {
		this.Invoke("delete_variable", new object [] {
				variables});

	}
	public System.IAsyncResult Begindelete_variable(string [] variables, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_variable", new object[] {
			variables}, callback, asyncState);
	}
	public void Enddelete_variable(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DBVariable", 
		RequestNamespace="urn:iControl:Management/DBVariable", ResponseNamespace="urn:iControl:Management/DBVariable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementDBVariableVariableNameValue [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((ManagementDBVariableVariableNameValue [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public ManagementDBVariableVariableNameValue [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementDBVariableVariableNameValue [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DBVariable", 
		RequestNamespace="urn:iControl:Management/DBVariable", ResponseNamespace="urn:iControl:Management/DBVariable")]
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
	// is_variable_available
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DBVariable", 
		RequestNamespace="urn:iControl:Management/DBVariable", ResponseNamespace="urn:iControl:Management/DBVariable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_variable_available(
		string [] variables
	) {
		object [] results = this.Invoke("is_variable_available", new object [] {
				variables});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_variable_available(string [] variables, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_variable_available", new object[] {
			variables}, callback, asyncState);
	}
	public bool [] Endis_variable_available(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// modify
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DBVariable", 
		RequestNamespace="urn:iControl:Management/DBVariable", ResponseNamespace="urn:iControl:Management/DBVariable")]
	public void modify(
		ManagementDBVariableVariableNameValue [] variables
	) {
		this.Invoke("modify", new object [] {
				variables});

	}
	public System.IAsyncResult Beginmodify(ManagementDBVariableVariableNameValue [] variables, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("modify", new object[] {
			variables}, callback, asyncState);
	}
	public void Endmodify(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// query
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DBVariable", 
		RequestNamespace="urn:iControl:Management/DBVariable", ResponseNamespace="urn:iControl:Management/DBVariable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementDBVariableVariableNameValue [] query(
		string [] variables
	) {
		object [] results = this.Invoke("query", new object [] {
				variables});
		return ((ManagementDBVariableVariableNameValue [])(results[0]));
	}
	public System.IAsyncResult Beginquery(string [] variables, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("query", new object[] {
			variables}, callback, asyncState);
	}
	public ManagementDBVariableVariableNameValue [] Endquery(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementDBVariableVariableNameValue [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// reset
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DBVariable", 
		RequestNamespace="urn:iControl:Management/DBVariable", ResponseNamespace="urn:iControl:Management/DBVariable")]
	public void reset(
		string [] variables
	) {
		this.Invoke("reset", new object [] {
				variables});

	}
	public System.IAsyncResult Beginreset(string [] variables, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset", new object[] {
			variables}, callback, asyncState);
	}
	public void Endreset(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DBVariable.VariableNameValue", Namespace = "urn:iControl")]
	public partial class ManagementDBVariableVariableNameValue
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
