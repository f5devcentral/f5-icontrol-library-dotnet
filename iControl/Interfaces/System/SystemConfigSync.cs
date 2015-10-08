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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.ConfigSyncBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemConfigSyncFileTransferContext))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemConfigSyncConfigFileEntry))]
	public partial class SystemConfigSync : iControlInterface {
		public SystemConfigSync() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// delete_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void delete_configuration(
		string filename
	) {
		this.Invoke("delete_configuration", new object [] {
				filename});

	}
	public System.IAsyncResult Begindelete_configuration(string filename, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_configuration", new object[] {
			filename}, callback, asyncState);
	}
	public void Enddelete_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void delete_file(
		string filename
	) {
		this.Invoke("delete_file", new object [] {
				filename});

	}
	public System.IAsyncResult Begindelete_file(string filename, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_file", new object[] {
			filename}, callback, asyncState);
	}
	public void Enddelete_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// download_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemConfigSyncFileTransferContext download_configuration(
		string config_name,
		long chunk_size,
		ref long file_offset
	) {
		object [] results = this.Invoke("download_configuration", new object [] {
				config_name,
				chunk_size,
				file_offset});
		file_offset = ((long)(results[1]));
		return ((SystemConfigSyncFileTransferContext)(results[0]));
	}
	public System.IAsyncResult Begindownload_configuration(string config_name,long chunk_size,long file_offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("download_configuration", new object[] {
			config_name,
			chunk_size,
			file_offset}, callback, asyncState);
	}
	public SystemConfigSyncFileTransferContext Enddownload_configuration(System.IAsyncResult asyncResult,
 out long file_offset) {
		object [] results = this.EndInvoke(asyncResult);
		file_offset = ((long)(results[1]));
		return ((SystemConfigSyncFileTransferContext)(results[0]));
	}

	//-----------------------------------------------------------------------
	// download_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemConfigSyncFileTransferContext download_file(
		string file_name,
		long chunk_size,
		ref long file_offset
	) {
		object [] results = this.Invoke("download_file", new object [] {
				file_name,
				chunk_size,
				file_offset});
		file_offset = ((long)(results[1]));
		return ((SystemConfigSyncFileTransferContext)(results[0]));
	}
	public System.IAsyncResult Begindownload_file(string file_name,long chunk_size,long file_offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("download_file", new object[] {
			file_name,
			chunk_size,
			file_offset}, callback, asyncState);
	}
	public SystemConfigSyncFileTransferContext Enddownload_file(System.IAsyncResult asyncResult,
 out long file_offset) {
		object [] results = this.EndInvoke(asyncResult);
		file_offset = ((long)(results[1]));
		return ((SystemConfigSyncFileTransferContext)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_configuration_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemConfigSyncConfigFileEntry [] get_configuration_list(

	) {
		object [] results = this.Invoke("get_configuration_list", new object [0]);
		return ((SystemConfigSyncConfigFileEntry [])(results[0]));
	}
	public System.IAsyncResult Beginget_configuration_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_configuration_list", new object[0], callback, asyncState);
	}
	public SystemConfigSyncConfigFileEntry [] Endget_configuration_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemConfigSyncConfigFileEntry [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
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
	// install_all_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void install_all_configuration(
		string filename
	) {
		this.Invoke("install_all_configuration", new object [] {
				filename});

	}
	public System.IAsyncResult Begininstall_all_configuration(string filename, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_all_configuration", new object[] {
			filename}, callback, asyncState);
	}
	public void Endinstall_all_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// install_all_encrypted_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void install_all_encrypted_configuration(
		string filename,
		string passphrase
	) {
		this.Invoke("install_all_encrypted_configuration", new object [] {
				filename,
				passphrase});

	}
	public System.IAsyncResult Begininstall_all_encrypted_configuration(string filename,string passphrase, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_all_encrypted_configuration", new object[] {
			filename,
			passphrase}, callback, asyncState);
	}
	public void Endinstall_all_encrypted_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// install_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void install_configuration(
		string filename
	) {
		this.Invoke("install_configuration", new object [] {
				filename});

	}
	public System.IAsyncResult Begininstall_configuration(string filename, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_configuration", new object[] {
			filename}, callback, asyncState);
	}
	public void Endinstall_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// install_configuration_quietly
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void install_configuration_quietly(
		string filename
	) {
		this.Invoke("install_configuration_quietly", new object [] {
				filename});

	}
	public System.IAsyncResult Begininstall_configuration_quietly(string filename, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_configuration_quietly", new object[] {
			filename}, callback, asyncState);
	}
	public void Endinstall_configuration_quietly(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// install_encrypted_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void install_encrypted_configuration(
		string filename,
		string passphrase
	) {
		this.Invoke("install_encrypted_configuration", new object [] {
				filename,
				passphrase});

	}
	public System.IAsyncResult Begininstall_encrypted_configuration(string filename,string passphrase, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_encrypted_configuration", new object[] {
			filename,
			passphrase}, callback, asyncState);
	}
	public void Endinstall_encrypted_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// install_encrypted_configuration_quietly
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void install_encrypted_configuration_quietly(
		string filename,
		string passphrase
	) {
		this.Invoke("install_encrypted_configuration_quietly", new object [] {
				filename,
				passphrase});

	}
	public System.IAsyncResult Begininstall_encrypted_configuration_quietly(string filename,string passphrase, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_encrypted_configuration_quietly", new object[] {
			filename,
			passphrase}, callback, asyncState);
	}
	public void Endinstall_encrypted_configuration_quietly(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// load_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void load_configuration(
		string filename,
		SystemConfigSyncLoadMode load_flag
	) {
		this.Invoke("load_configuration", new object [] {
				filename,
				load_flag});

	}
	public System.IAsyncResult Beginload_configuration(string filename,SystemConfigSyncLoadMode load_flag, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("load_configuration", new object[] {
			filename,
			load_flag}, callback, asyncState);
	}
	public void Endload_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// move_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void move_file(
		string from_path,
		string to_path
	) {
		this.Invoke("move_file", new object [] {
				from_path,
				to_path});

	}
	public System.IAsyncResult Beginmove_file(string from_path,string to_path, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("move_file", new object[] {
			from_path,
			to_path}, callback, asyncState);
	}
	public void Endmove_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// rollback_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void rollback_configuration(

	) {
		this.Invoke("rollback_configuration", new object [0]);

	}
	public System.IAsyncResult Beginrollback_configuration(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("rollback_configuration", new object[0], callback, asyncState);
	}
	public void Endrollback_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// save_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void save_configuration(
		string filename,
		SystemConfigSyncSaveMode save_flag
	) {
		this.Invoke("save_configuration", new object [] {
				filename,
				save_flag});

	}
	public System.IAsyncResult Beginsave_configuration(string filename,SystemConfigSyncSaveMode save_flag, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("save_configuration", new object[] {
			filename,
			save_flag}, callback, asyncState);
	}
	public void Endsave_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// save_encrypted_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void save_encrypted_configuration(
		string filename,
		string passphrase
	) {
		this.Invoke("save_encrypted_configuration", new object [] {
				filename,
				passphrase});

	}
	public System.IAsyncResult Beginsave_encrypted_configuration(string filename,string passphrase, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("save_encrypted_configuration", new object[] {
			filename,
			passphrase}, callback, asyncState);
	}
	public void Endsave_encrypted_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// save_partial_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void save_partial_configuration(
		string filename,
		SystemConfigSyncSaveMode save_flag,
		SystemConfigSyncConfigExcludeComponent [] features_to_exclude,
		SystemConfigSyncConfigIncludeComponent [] features_to_include
	) {
		this.Invoke("save_partial_configuration", new object [] {
				filename,
				save_flag,
				features_to_exclude,
				features_to_include});

	}
	public System.IAsyncResult Beginsave_partial_configuration(string filename,SystemConfigSyncSaveMode save_flag,SystemConfigSyncConfigExcludeComponent [] features_to_exclude,SystemConfigSyncConfigIncludeComponent [] features_to_include, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("save_partial_configuration", new object[] {
			filename,
			save_flag,
			features_to_exclude,
			features_to_include}, callback, asyncState);
	}
	public void Endsave_partial_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// save_partial_encrypted_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void save_partial_encrypted_configuration(
		string filename,
		string passphrase,
		SystemConfigSyncConfigExcludeComponent [] features_to_exclude,
		SystemConfigSyncConfigIncludeComponent [] features_to_include
	) {
		this.Invoke("save_partial_encrypted_configuration", new object [] {
				filename,
				passphrase,
				features_to_exclude,
				features_to_include});

	}
	public System.IAsyncResult Beginsave_partial_encrypted_configuration(string filename,string passphrase,SystemConfigSyncConfigExcludeComponent [] features_to_exclude,SystemConfigSyncConfigIncludeComponent [] features_to_include, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("save_partial_encrypted_configuration", new object[] {
			filename,
			passphrase,
			features_to_exclude,
			features_to_include}, callback, asyncState);
	}
	public void Endsave_partial_encrypted_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// save_partition_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void save_partition_configuration(
		string [] partitions,
		SystemConfigSyncSaveMode save_flag
	) {
		this.Invoke("save_partition_configuration", new object [] {
				partitions,
				save_flag});

	}
	public System.IAsyncResult Beginsave_partition_configuration(string [] partitions,SystemConfigSyncSaveMode save_flag, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("save_partition_configuration", new object[] {
			partitions,
			save_flag}, callback, asyncState);
	}
	public void Endsave_partition_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// synchronize_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void synchronize_configuration(
		SystemConfigSyncSyncMode sync_flag
	) {
		this.Invoke("synchronize_configuration", new object [] {
				sync_flag});

	}
	public System.IAsyncResult Beginsynchronize_configuration(SystemConfigSyncSyncMode sync_flag, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("synchronize_configuration", new object[] {
			sync_flag}, callback, asyncState);
	}
	public void Endsynchronize_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// synchronize_from_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void synchronize_from_group(
		string group
	) {
		this.Invoke("synchronize_from_group", new object [] {
				group});

	}
	public System.IAsyncResult Beginsynchronize_from_group(string group, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("synchronize_from_group", new object[] {
			group}, callback, asyncState);
	}
	public void Endsynchronize_from_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// synchronize_to_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void synchronize_to_group(
		string group
	) {
		this.Invoke("synchronize_to_group", new object [] {
				group});

	}
	public System.IAsyncResult Beginsynchronize_to_group(string group, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("synchronize_to_group", new object[] {
			group}, callback, asyncState);
	}
	public void Endsynchronize_to_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// synchronize_to_group_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void synchronize_to_group_v2(
		string group,
		string device,
		bool force
	) {
		this.Invoke("synchronize_to_group_v2", new object [] {
				group,
				device,
				force});

	}
	public System.IAsyncResult Beginsynchronize_to_group_v2(string group,string device,bool force, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("synchronize_to_group_v2", new object[] {
			group,
			device,
			force}, callback, asyncState);
	}
	public void Endsynchronize_to_group_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// upload_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void upload_configuration(
		string config_name,
		SystemConfigSyncFileTransferContext file_context
	) {
		this.Invoke("upload_configuration", new object [] {
				config_name,
				file_context});

	}
	public System.IAsyncResult Beginupload_configuration(string config_name,SystemConfigSyncFileTransferContext file_context, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("upload_configuration", new object[] {
			config_name,
			file_context}, callback, asyncState);
	}
	public void Endupload_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// upload_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/ConfigSync", 
		RequestNamespace="urn:iControl:System/ConfigSync", ResponseNamespace="urn:iControl:System/ConfigSync")]
	public void upload_file(
		string file_name,
		SystemConfigSyncFileTransferContext file_context
	) {
		this.Invoke("upload_file", new object [] {
				file_name,
				file_context});

	}
	public System.IAsyncResult Beginupload_file(string file_name,SystemConfigSyncFileTransferContext file_context, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("upload_file", new object[] {
			file_name,
			file_context}, callback, asyncState);
	}
	public void Endupload_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ConfigSync.ConfigExcludeComponent", Namespace = "urn:iControl")]
	public enum SystemConfigSyncConfigExcludeComponent
	{
		CONFIG_EXCLUDE_PRIVATE_KEYS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ConfigSync.ConfigIncludeComponent", Namespace = "urn:iControl")]
	public enum SystemConfigSyncConfigIncludeComponent
	{
		CONFIG_INCLUDE_EM_IMAGES,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ConfigSync.LoadMode", Namespace = "urn:iControl")]
	public enum SystemConfigSyncLoadMode
	{
		LOAD_HIGH_LEVEL_CONFIG,
		LOAD_BASE_LEVEL_CONFIG,
		LOAD_GTM_CONFIG_ONLY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ConfigSync.SaveMode", Namespace = "urn:iControl")]
	public enum SystemConfigSyncSaveMode
	{
		SAVE_FULL,
		SAVE_HIGH_LEVEL_CONFIG,
		SAVE_BASE_LEVEL_CONFIG,
		SAVE_GTM_CONFIG_ONLY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ConfigSync.SyncMode", Namespace = "urn:iControl")]
	public enum SystemConfigSyncSyncMode
	{
		CONFIGSYNC_BASIC,
		CONFIGSYNC_ALL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ConfigSync.ConfigFileEntry", Namespace = "urn:iControl")]
	public partial class SystemConfigSyncConfigFileEntry
	{
		private string file_nameField;
		public string file_name
		{
			get { return this.file_nameField; }
			set { this.file_nameField = value; }
		}
		private string file_datetimeField;
		public string file_datetime
		{
			get { return this.file_datetimeField; }
			set { this.file_datetimeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ConfigSync.FileTransferContext", Namespace = "urn:iControl")]
	public partial class SystemConfigSyncFileTransferContext
	{
		private byte [] file_dataField;
		[System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")]
		public byte [] file_data
		{
			get { return this.file_dataField; }
			set { this.file_dataField = value; }
		}
		private CommonFileChainType chain_typeField;
		public CommonFileChainType chain_type
		{
			get { return this.chain_typeField; }
			set { this.chain_typeField = value; }
		}
	};

}
