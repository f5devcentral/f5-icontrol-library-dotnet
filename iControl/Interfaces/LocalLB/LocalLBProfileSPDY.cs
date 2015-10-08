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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileSPDYBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSPDYProfileActivationMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSPDYProfileSPDYStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSPDYProfilePriorityMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSPDYProfileSupportedProtocolVersionSequence))]
	public partial class LocalLBProfileSPDY : iControlInterface {
		public LocalLBProfileSPDY() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void create(
		string [] profile_names
	) {
		this.Invoke("create", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begincreate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void delete_all_profiles(

	) {
		this.Invoke("delete_all_profiles", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_profiles(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_profiles", new object[0], callback, asyncState);
	}
	public void Enddelete_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void delete_profile(
		string [] profile_names
	) {
		this.Invoke("delete_profile", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begindelete_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Enddelete_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_activation_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSPDYProfileActivationMode [] get_activation_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_activation_mode", new object [] {
				profile_names});
		return ((LocalLBProfileSPDYProfileActivationMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_activation_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_activation_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSPDYProfileActivationMode [] Endget_activation_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSPDYProfileActivationMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSPDYProfileSPDYStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileSPDYProfileSPDYStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileSPDYProfileSPDYStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSPDYProfileSPDYStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_compression_level(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_level", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_level(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_level", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_compression_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_compression_window_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_window_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_window_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_window_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_compression_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_connection_idle_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_connection_idle_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_idle_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_idle_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_connection_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_default_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_default_profile", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_frame_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_frame_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_frame_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_frame_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_frame_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_frame_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_insert_header
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_insert_header(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_insert_header", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_insert_header(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_insert_header", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_insert_header(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_insert_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_insert_header_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_insert_header_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_insert_header_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_insert_header_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_insert_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
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
	// get_maximum_concurrent_streams_per_connection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_concurrent_streams_per_connection(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_concurrent_streams_per_connection", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_concurrent_streams_per_connection(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_concurrent_streams_per_connection", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_concurrent_streams_per_connection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_priority_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSPDYProfilePriorityMode [] get_priority_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_priority_mode", new object [] {
				profile_names});
		return ((LocalLBProfileSPDYProfilePriorityMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_priority_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_priority_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSPDYProfilePriorityMode [] Endget_priority_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSPDYProfilePriorityMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_receive_window
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_receive_window(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_receive_window", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_receive_window(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_receive_window", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_receive_window(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSPDYProfileSPDYStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileSPDYProfileSPDYStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSPDYProfileSPDYStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSPDYProfileSPDYStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStatisticsByVirtual get_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		object [] results = this.Invoke("get_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public LocalLBProfileStatisticsByVirtual Endget_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_supported_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSPDYProfileSupportedProtocolVersionSequence [] get_supported_version(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_supported_version", new object [] {
				profile_names});
		return ((LocalLBProfileSPDYProfileSupportedProtocolVersionSequence [])(results[0]));
	}
	public System.IAsyncResult Beginget_supported_version(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_supported_version", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSPDYProfileSupportedProtocolVersionSequence [] Endget_supported_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSPDYProfileSupportedProtocolVersionSequence [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
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
	// get_write_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_write_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_write_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_write_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_write_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_write_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_base_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_base_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_base_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_base_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_base_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_system_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_system_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_system_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_system_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_system_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_system_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// replace_supported_versions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void replace_supported_versions(
		string [] profile_names,
		LocalLBProfileSPDYProfileSupportedProtocolVersionSequence [] versions
	) {
		this.Invoke("replace_supported_versions", new object [] {
				profile_names,
				versions});

	}
	public System.IAsyncResult Beginreplace_supported_versions(string [] profile_names,LocalLBProfileSPDYProfileSupportedProtocolVersionSequence [] versions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_supported_versions", new object[] {
			profile_names,
			versions}, callback, asyncState);
	}
	public void Endreplace_supported_versions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void reset_statistics(
		string [] profile_names
	) {
		this.Invoke("reset_statistics", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginreset_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void reset_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		this.Invoke("reset_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});

	}
	public System.IAsyncResult Beginreset_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public void Endreset_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_activation_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_activation_mode(
		string [] profile_names,
		LocalLBProfileSPDYProfileActivationMode [] modes
	) {
		this.Invoke("set_activation_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_activation_mode(string [] profile_names,LocalLBProfileSPDYProfileActivationMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_activation_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_activation_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_compression_level(
		string [] profile_names,
		LocalLBProfileULong [] levels
	) {
		this.Invoke("set_compression_level", new object [] {
				profile_names,
				levels});

	}
	public System.IAsyncResult Beginset_compression_level(string [] profile_names,LocalLBProfileULong [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_level", new object[] {
			profile_names,
			levels}, callback, asyncState);
	}
	public void Endset_compression_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_compression_window_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_compression_window_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_compression_window_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_window_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_compression_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_connection_idle_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_connection_idle_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_connection_idle_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_idle_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_connection_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_default_profile(
		string [] profile_names,
		string [] defaults
	) {
		this.Invoke("set_default_profile", new object [] {
				profile_names,
				defaults});

	}
	public System.IAsyncResult Beginset_default_profile(string [] profile_names,string [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_profile", new object[] {
			profile_names,
			defaults}, callback, asyncState);
	}
	public void Endset_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_description(
		string [] profile_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				profile_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] profile_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			profile_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_frame_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_frame_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_frame_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_frame_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_frame_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_frame_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_insert_header
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_insert_header(
		string [] profile_names,
		LocalLBProfileString [] headers
	) {
		this.Invoke("set_insert_header", new object [] {
				profile_names,
				headers});

	}
	public System.IAsyncResult Beginset_insert_header(string [] profile_names,LocalLBProfileString [] headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_insert_header", new object[] {
			profile_names,
			headers}, callback, asyncState);
	}
	public void Endset_insert_header(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_insert_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_insert_header_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_insert_header_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_insert_header_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_insert_header_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_insert_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_concurrent_streams_per_connection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_maximum_concurrent_streams_per_connection(
		string [] profile_names,
		LocalLBProfileULong [] streams
	) {
		this.Invoke("set_maximum_concurrent_streams_per_connection", new object [] {
				profile_names,
				streams});

	}
	public System.IAsyncResult Beginset_maximum_concurrent_streams_per_connection(string [] profile_names,LocalLBProfileULong [] streams, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_concurrent_streams_per_connection", new object[] {
			profile_names,
			streams}, callback, asyncState);
	}
	public void Endset_maximum_concurrent_streams_per_connection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_priority_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_priority_mode(
		string [] profile_names,
		LocalLBProfileSPDYProfilePriorityMode [] modes
	) {
		this.Invoke("set_priority_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_priority_mode(string [] profile_names,LocalLBProfileSPDYProfilePriorityMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_priority_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_priority_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_receive_window
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_receive_window(
		string [] profile_names,
		LocalLBProfileULong [] windows
	) {
		this.Invoke("set_receive_window", new object [] {
				profile_names,
				windows});

	}
	public System.IAsyncResult Beginset_receive_window(string [] profile_names,LocalLBProfileULong [] windows, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_receive_window", new object[] {
			profile_names,
			windows}, callback, asyncState);
	}
	public void Endset_receive_window(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_write_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSPDY", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSPDY", ResponseNamespace="urn:iControl:LocalLB/ProfileSPDY")]
	public void set_write_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_write_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_write_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_write_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_write_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSPDY.ActivationMode", Namespace = "urn:iControl")]
	public enum LocalLBProfileSPDYActivationMode
	{
		SPDY_ACTIVATION_UNKNOWN,
		SPDY_ACTIVATION_NPN,
		SPDY_ACTIVATION_ALWAYS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSPDY.PriorityMode", Namespace = "urn:iControl")]
	public enum LocalLBProfileSPDYPriorityMode
	{
		SPDY_PRIORITY_UNKNOWN,
		SPDY_PRIORITY_STRICT,
		SPDY_PRIORITY_FAIR,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSPDY.SupportedProtocolVersion", Namespace = "urn:iControl")]
	public enum LocalLBProfileSPDYSupportedProtocolVersion
	{
		SPDY_VERSION_UNKNOWN,
		SPDY_VERSION_2,
		SPDY_VERSION_3,
		SPDY_VERSION_HTTP,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSPDY.ProfileActivationMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSPDYProfileActivationMode
	{
		private LocalLBProfileSPDYActivationMode valueField;
		public LocalLBProfileSPDYActivationMode value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSPDY.ProfilePriorityMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSPDYProfilePriorityMode
	{
		private LocalLBProfileSPDYPriorityMode valueField;
		public LocalLBProfileSPDYPriorityMode value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSPDY.ProfileSPDYStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSPDYProfileSPDYStatisticEntry
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSPDY.ProfileSPDYStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSPDYProfileSPDYStatistics
	{
		private LocalLBProfileSPDYProfileSPDYStatisticEntry [] statisticsField;
		public LocalLBProfileSPDYProfileSPDYStatisticEntry [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private CommonTimeStamp time_stampField;
		public CommonTimeStamp time_stamp
		{
			get { return this.time_stampField; }
			set { this.time_stampField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSPDY.ProfileSupportedProtocolVersionSequence", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSPDYProfileSupportedProtocolVersionSequence
	{
		private LocalLBProfileSPDYSupportedProtocolVersion [] valueField;
		public LocalLBProfileSPDYSupportedProtocolVersion [] value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

}
