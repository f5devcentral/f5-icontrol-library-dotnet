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
	[System.Web.Services.WebServiceBindingAttribute(Name="Log.IPFIXInformationElementBinding", Namespace="urn:iControl")]
	public partial class LogIPFIXInformationElement : iControlInterface {
		public LogIPFIXInformationElement() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	public void create(
		string [] elements
	) {
		this.Invoke("create", new object [] {
				elements});

	}
	public System.IAsyncResult Begincreate(string [] elements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			elements}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_ipfix_elements
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	public void delete_all_ipfix_elements(

	) {
		this.Invoke("delete_all_ipfix_elements", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_ipfix_elements(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_ipfix_elements", new object[0], callback, asyncState);
	}
	public void Enddelete_all_ipfix_elements(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_ipfix_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	public void delete_ipfix_element(
		string [] elements
	) {
		this.Invoke("delete_ipfix_element", new object [] {
				elements});

	}
	public System.IAsyncResult Begindelete_ipfix_element(string [] elements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_ipfix_element", new object[] {
			elements}, callback, asyncState);
	}
	public void Enddelete_ipfix_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_data_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LogIPFIXInformationElementDataType [] get_data_type(
		string [] elements,
		LogIPFIXInformationElementDefinitionSource [] definition_sources
	) {
		object [] results = this.Invoke("get_data_type", new object [] {
				elements,
				definition_sources});
		return ((LogIPFIXInformationElementDataType [])(results[0]));
	}
	public System.IAsyncResult Beginget_data_type(string [] elements,LogIPFIXInformationElementDefinitionSource [] definition_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_data_type", new object[] {
			elements,
			definition_sources}, callback, asyncState);
	}
	public LogIPFIXInformationElementDataType [] Endget_data_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LogIPFIXInformationElementDataType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_data_type_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_data_type_size(
		string [] elements,
		LogIPFIXInformationElementDefinitionSource [] definition_sources
	) {
		object [] results = this.Invoke("get_data_type_size", new object [] {
				elements,
				definition_sources});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_data_type_size(string [] elements,LogIPFIXInformationElementDefinitionSource [] definition_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_data_type_size", new object[] {
			elements,
			definition_sources}, callback, asyncState);
	}
	public short [] Endget_data_type_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] elements,
		LogIPFIXInformationElementDefinitionSource [] definition_sources
	) {
		object [] results = this.Invoke("get_description", new object [] {
				elements,
				definition_sources});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] elements,LogIPFIXInformationElementDefinitionSource [] definition_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			elements,
			definition_sources}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_element_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_element_id(
		string [] elements,
		LogIPFIXInformationElementDefinitionSource [] definition_sources
	) {
		object [] results = this.Invoke("get_element_id", new object [] {
				elements,
				definition_sources});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_element_id(string [] elements,LogIPFIXInformationElementDefinitionSource [] definition_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_element_id", new object[] {
			elements,
			definition_sources}, callback, asyncState);
	}
	public short [] Endget_element_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enterprise_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_enterprise_id(
		string [] elements,
		LogIPFIXInformationElementDefinitionSource [] definition_sources
	) {
		object [] results = this.Invoke("get_enterprise_id", new object [] {
				elements,
				definition_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_enterprise_id(string [] elements,LogIPFIXInformationElementDefinitionSource [] definition_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enterprise_id", new object[] {
			elements,
			definition_sources}, callback, asyncState);
	}
	public long [] Endget_enterprise_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
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
	// set_data_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	public void set_data_type(
		string [] elements,
		LogIPFIXInformationElementDataType [] values
	) {
		this.Invoke("set_data_type", new object [] {
				elements,
				values});

	}
	public System.IAsyncResult Beginset_data_type(string [] elements,LogIPFIXInformationElementDataType [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_data_type", new object[] {
			elements,
			values}, callback, asyncState);
	}
	public void Endset_data_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_data_type_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	public void set_data_type_size(
		string [] elements,
		short [] values
	) {
		this.Invoke("set_data_type_size", new object [] {
				elements,
				values});

	}
	public System.IAsyncResult Beginset_data_type_size(string [] elements,short [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_data_type_size", new object[] {
			elements,
			values}, callback, asyncState);
	}
	public void Endset_data_type_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	public void set_description(
		string [] elements,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				elements,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] elements,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			elements,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_element_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	public void set_element_id(
		string [] elements,
		short [] values
	) {
		this.Invoke("set_element_id", new object [] {
				elements,
				values});

	}
	public System.IAsyncResult Beginset_element_id(string [] elements,short [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_element_id", new object[] {
			elements,
			values}, callback, asyncState);
	}
	public void Endset_element_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enterprise_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/IPFIXInformationElement", 
		RequestNamespace="urn:iControl:Log/IPFIXInformationElement", ResponseNamespace="urn:iControl:Log/IPFIXInformationElement")]
	public void set_enterprise_id(
		string [] elements,
		long [] values
	) {
		this.Invoke("set_enterprise_id", new object [] {
				elements,
				values});

	}
	public System.IAsyncResult Beginset_enterprise_id(string [] elements,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enterprise_id", new object[] {
			elements,
			values}, callback, asyncState);
	}
	public void Endset_enterprise_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Log.IPFIXInformationElement.DataType", Namespace = "urn:iControl")]
	public enum LogIPFIXInformationElementDataType
	{
		IPFIX_DATA_TYPE_UNKNOWN,
		IPFIX_DATA_TYPE_OCTETARRAY,
		IPFIX_DATA_TYPE_UNSIGNED8,
		IPFIX_DATA_TYPE_UNSIGNED16,
		IPFIX_DATA_TYPE_UNSIGNED32,
		IPFIX_DATA_TYPE_UNSIGNED64,
		IPFIX_DATA_TYPE_SIGNED8,
		IPFIX_DATA_TYPE_SIGNED16,
		IPFIX_DATA_TYPE_SIGNED32,
		IPFIX_DATA_TYPE_SIGNED64,
		IPFIX_DATA_TYPE_FLOAT32,
		IPFIX_DATA_TYPE_FLOAT64,
		IPFIX_DATA_TYPE_BOOLEAN,
		IPFIX_DATA_TYPE_MACADDRESS,
		IPFIX_DATA_TYPE_STRING,
		IPFIX_DATA_TYPE_DATETIMESECONDS,
		IPFIX_DATA_TYPE_DATETIMEMILLISECONDS,
		IPFIX_DATA_TYPE_DATETIMEMICROSECONDS,
		IPFIX_DATA_TYPE_DATETIMENANOSECONDS,
		IPFIX_DATA_TYPE_IPV4ADDRESS,
		IPFIX_DATA_TYPE_IPV6ADDRESS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Log.IPFIXInformationElement.DefinitionSource", Namespace = "urn:iControl")]
	public enum LogIPFIXInformationElementDefinitionSource
	{
		IPFIX_DEFINITION_SOURCE_UNKNOWN,
		IPFIX_DEFINITION_SOURCE_USER,
		IPFIX_DEFINITION_SOURCE_BASE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
