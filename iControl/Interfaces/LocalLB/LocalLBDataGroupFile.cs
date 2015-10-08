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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.DataGroupFileBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonULong64))]
	public partial class LocalLBDataGroupFile : iControlInterface {
		public LocalLBDataGroupFile() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	public void create(
		string [] files,
		string [] paths,
		LocalLBDataGroupType [] types
	) {
		this.Invoke("create", new object [] {
				files,
				paths,
				types});

	}
	public System.IAsyncResult Begincreate(string [] files,string [] paths,LocalLBDataGroupType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			files,
			paths,
			types}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_data_group_files
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	public void delete_all_data_group_files(

	) {
		this.Invoke("delete_all_data_group_files", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_data_group_files(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_data_group_files", new object[0], callback, asyncState);
	}
	public void Enddelete_all_data_group_files(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_data_group_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	public void delete_data_group_file(
		string [] files
	) {
		this.Invoke("delete_data_group_file", new object [] {
				files});

	}
	public System.IAsyncResult Begindelete_data_group_file(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_data_group_file", new object[] {
			files}, callback, asyncState);
	}
	public void Enddelete_data_group_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_cache_path
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_cache_path(
		string [] files
	) {
		object [] results = this.Invoke("get_cache_path", new object [] {
				files});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_path(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_path", new object[] {
			files}, callback, asyncState);
	}
	public string [] Endget_cache_path(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_checksum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_checksum(
		string [] files
	) {
		object [] results = this.Invoke("get_checksum", new object [] {
				files});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_checksum(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_checksum", new object[] {
			files}, callback, asyncState);
	}
	public string [] Endget_checksum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_creation_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] get_creation_time(
		string [] files
	) {
		object [] results = this.Invoke("get_creation_time", new object [] {
				files});
		return ((CommonTimeStamp [])(results[0]));
	}
	public System.IAsyncResult Beginget_creation_time(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_creation_time", new object[] {
			files}, callback, asyncState);
	}
	public CommonTimeStamp [] Endget_creation_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_creator
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_creator(
		string [] files
	) {
		object [] results = this.Invoke("get_creator", new object [] {
				files});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_creator(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_creator", new object[] {
			files}, callback, asyncState);
	}
	public string [] Endget_creator(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_data_separator
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_data_separator(
		string [] class_names
	) {
		object [] results = this.Invoke("get_data_separator", new object [] {
				class_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_data_separator(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_data_separator", new object[] {
			class_names}, callback, asyncState);
	}
	public string [] Endget_data_separator(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_dynamic_state(
		string [] files
	) {
		object [] results = this.Invoke("get_dynamic_state", new object [] {
				files});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_state(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_state", new object[] {
			files}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_dynamic_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
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
	// get_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_mode(
		string [] files
	) {
		object [] results = this.Invoke("get_mode", new object [] {
				files});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_mode(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mode", new object[] {
			files}, callback, asyncState);
	}
	public long [] Endget_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_modification_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] get_modification_time(
		string [] files
	) {
		object [] results = this.Invoke("get_modification_time", new object [] {
				files});
		return ((CommonTimeStamp [])(results[0]));
	}
	public System.IAsyncResult Beginget_modification_time(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_modification_time", new object[] {
			files}, callback, asyncState);
	}
	public CommonTimeStamp [] Endget_modification_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_modifier
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_modifier(
		string [] files
	) {
		object [] results = this.Invoke("get_modifier", new object [] {
				files});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_modifier(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_modifier", new object[] {
			files}, callback, asyncState);
	}
	public string [] Endget_modifier(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_revision
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_revision(
		string [] files
	) {
		object [] results = this.Invoke("get_revision", new object [] {
				files});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_revision(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_revision", new object[] {
			files}, callback, asyncState);
	}
	public long [] Endget_revision(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] get_size(
		string [] files
	) {
		object [] results = this.Invoke("get_size", new object [] {
				files});
		return ((CommonULong64 [])(results[0]));
	}
	public System.IAsyncResult Beginget_size(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_size", new object[] {
			files}, callback, asyncState);
	}
	public CommonULong64 [] Endget_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_path
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_source_path(
		string [] files
	) {
		object [] results = this.Invoke("get_source_path", new object [] {
				files});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_path(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_path", new object[] {
			files}, callback, asyncState);
	}
	public string [] Endget_source_path(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_path
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_system_path(
		string [] files
	) {
		object [] results = this.Invoke("get_system_path", new object [] {
				files});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_system_path(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_path", new object[] {
			files}, callback, asyncState);
	}
	public string [] Endget_system_path(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_system_state(
		string [] files
	) {
		object [] results = this.Invoke("get_system_state", new object [] {
				files});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_system_state(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_state", new object[] {
			files}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_system_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_value_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDataGroupType [] get_value_type(
		string [] files
	) {
		object [] results = this.Invoke("get_value_type", new object [] {
				files});
		return ((LocalLBDataGroupType [])(results[0]));
	}
	public System.IAsyncResult Beginget_value_type(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_value_type", new object[] {
			files}, callback, asyncState);
	}
	public LocalLBDataGroupType [] Endget_value_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDataGroupType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
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
	// set_data_separator
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	public void set_data_separator(
		string [] files,
		string [] separators
	) {
		this.Invoke("set_data_separator", new object [] {
				files,
				separators});

	}
	public System.IAsyncResult Beginset_data_separator(string [] files,string [] separators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_data_separator", new object[] {
			files,
			separators}, callback, asyncState);
	}
	public void Endset_data_separator(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_local_path
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DataGroupFile", 
		RequestNamespace="urn:iControl:LocalLB/DataGroupFile", ResponseNamespace="urn:iControl:LocalLB/DataGroupFile")]
	public void set_local_path(
		string [] files,
		string [] paths
	) {
		this.Invoke("set_local_path", new object [] {
				files,
				paths});

	}
	public System.IAsyncResult Beginset_local_path(string [] files,string [] paths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_local_path", new object[] {
			files,
			paths}, callback, asyncState);
	}
	public void Endset_local_path(System.IAsyncResult asyncResult) {
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
