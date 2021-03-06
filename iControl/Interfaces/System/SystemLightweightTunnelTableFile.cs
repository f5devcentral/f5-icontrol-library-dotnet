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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.LightweightTunnelTableFileBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonULong64))]
	public partial class SystemLightweightTunnelTableFile : iControlInterface {
		public SystemLightweightTunnelTableFile() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
	public void create(
		string [] files,
		string [] paths
	) {
		this.Invoke("create", new object [] {
				files,
				paths});

	}
	public System.IAsyncResult Begincreate(string [] files,string [] paths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			files,
			paths}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_lightweight_tunnel_table_files
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
	public void delete_all_lightweight_tunnel_table_files(

	) {
		this.Invoke("delete_all_lightweight_tunnel_table_files", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_lightweight_tunnel_table_files(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_lightweight_tunnel_table_files", new object[0], callback, asyncState);
	}
	public void Enddelete_all_lightweight_tunnel_table_files(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_lightweight_tunnel_table_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
	public void delete_lightweight_tunnel_table_file(
		string [] files
	) {
		this.Invoke("delete_lightweight_tunnel_table_file", new object [] {
				files});

	}
	public System.IAsyncResult Begindelete_lightweight_tunnel_table_file(string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_lightweight_tunnel_table_file", new object[] {
			files}, callback, asyncState);
	}
	public void Enddelete_lightweight_tunnel_table_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_checksum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/LightweightTunnelTableFile", 
		RequestNamespace="urn:iControl:System/LightweightTunnelTableFile", ResponseNamespace="urn:iControl:System/LightweightTunnelTableFile")]
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
