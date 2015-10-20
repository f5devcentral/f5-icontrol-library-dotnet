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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ALGLogProfileBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileLogElementSequence))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileLogAction))]
	public partial class LocalLBALGLogProfile : iControlInterface {
		public LocalLBALGLogProfile() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_end_control_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void add_end_control_channel_element(
		string [] profiles,
		LocalLBProfileLogElementSequence [] elements
	) {
		this.Invoke("add_end_control_channel_element", new object [] {
				profiles,
				elements});

	}
	public System.IAsyncResult Beginadd_end_control_channel_element(string [] profiles,LocalLBProfileLogElementSequence [] elements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_end_control_channel_element", new object[] {
			profiles,
			elements}, callback, asyncState);
	}
	public void Endadd_end_control_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_end_data_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void add_end_data_channel_element(
		string [] profiles,
		LocalLBProfileLogElementSequence [] elements
	) {
		this.Invoke("add_end_data_channel_element", new object [] {
				profiles,
				elements});

	}
	public System.IAsyncResult Beginadd_end_data_channel_element(string [] profiles,LocalLBProfileLogElementSequence [] elements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_end_data_channel_element", new object[] {
			profiles,
			elements}, callback, asyncState);
	}
	public void Endadd_end_data_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_start_control_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void add_start_control_channel_element(
		string [] profiles,
		LocalLBProfileLogElementSequence [] elements
	) {
		this.Invoke("add_start_control_channel_element", new object [] {
				profiles,
				elements});

	}
	public System.IAsyncResult Beginadd_start_control_channel_element(string [] profiles,LocalLBProfileLogElementSequence [] elements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_start_control_channel_element", new object[] {
			profiles,
			elements}, callback, asyncState);
	}
	public void Endadd_start_control_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_start_data_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void add_start_data_channel_element(
		string [] profiles,
		LocalLBProfileLogElementSequence [] elements
	) {
		this.Invoke("add_start_data_channel_element", new object [] {
				profiles,
				elements});

	}
	public System.IAsyncResult Beginadd_start_data_channel_element(string [] profiles,LocalLBProfileLogElementSequence [] elements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_start_data_channel_element", new object[] {
			profiles,
			elements}, callback, asyncState);
	}
	public void Endadd_start_data_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void create(
		string [] profiles
	) {
		this.Invoke("create", new object [] {
				profiles});

	}
	public System.IAsyncResult Begincreate(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profiles}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_alg_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void delete_alg_log_profile(
		string [] profiles
	) {
		this.Invoke("delete_alg_log_profile", new object [] {
				profiles});

	}
	public System.IAsyncResult Begindelete_alg_log_profile(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_alg_log_profile", new object[] {
			profiles}, callback, asyncState);
	}
	public void Enddelete_alg_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_alg_log_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void delete_all_alg_log_profiles(

	) {
		this.Invoke("delete_all_alg_log_profiles", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_alg_log_profiles(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_alg_log_profiles", new object[0], callback, asyncState);
	}
	public void Enddelete_all_alg_log_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_default_profile(
		string [] profiles
	) {
		object [] results = this.Invoke("get_default_profile", new object [] {
				profiles});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_profile(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_profile", new object[] {
			profiles}, callback, asyncState);
	}
	public string [] Endget_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] profiles
	) {
		object [] results = this.Invoke("get_description", new object [] {
				profiles});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			profiles}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_end_control_channel_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileLogAction [] get_end_control_channel_action(
		string [] profiles
	) {
		object [] results = this.Invoke("get_end_control_channel_action", new object [] {
				profiles});
		return ((LocalLBProfileLogAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_end_control_channel_action(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_end_control_channel_action", new object[] {
			profiles}, callback, asyncState);
	}
	public LocalLBProfileLogAction [] Endget_end_control_channel_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileLogAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_end_control_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileLogElementSequence [] get_end_control_channel_element(
		string [] profiles
	) {
		object [] results = this.Invoke("get_end_control_channel_element", new object [] {
				profiles});
		return ((LocalLBProfileLogElementSequence [])(results[0]));
	}
	public System.IAsyncResult Beginget_end_control_channel_element(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_end_control_channel_element", new object[] {
			profiles}, callback, asyncState);
	}
	public LocalLBProfileLogElementSequence [] Endget_end_control_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileLogElementSequence [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_end_data_channel_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileLogAction [] get_end_data_channel_action(
		string [] profiles
	) {
		object [] results = this.Invoke("get_end_data_channel_action", new object [] {
				profiles});
		return ((LocalLBProfileLogAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_end_data_channel_action(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_end_data_channel_action", new object[] {
			profiles}, callback, asyncState);
	}
	public LocalLBProfileLogAction [] Endget_end_data_channel_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileLogAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_end_data_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileLogElementSequence [] get_end_data_channel_element(
		string [] profiles
	) {
		object [] results = this.Invoke("get_end_data_channel_element", new object [] {
				profiles});
		return ((LocalLBProfileLogElementSequence [])(results[0]));
	}
	public System.IAsyncResult Beginget_end_data_channel_element(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_end_data_channel_element", new object[] {
			profiles}, callback, asyncState);
	}
	public LocalLBProfileLogElementSequence [] Endget_end_data_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileLogElementSequence [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_inbound_transaction_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileLogAction [] get_inbound_transaction_action(
		string [] profiles
	) {
		object [] results = this.Invoke("get_inbound_transaction_action", new object [] {
				profiles});
		return ((LocalLBProfileLogAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_inbound_transaction_action(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_inbound_transaction_action", new object[] {
			profiles}, callback, asyncState);
	}
	public LocalLBProfileLogAction [] Endget_inbound_transaction_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileLogAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
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
	// get_start_control_channel_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileLogAction [] get_start_control_channel_action(
		string [] profiles
	) {
		object [] results = this.Invoke("get_start_control_channel_action", new object [] {
				profiles});
		return ((LocalLBProfileLogAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_start_control_channel_action(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_start_control_channel_action", new object[] {
			profiles}, callback, asyncState);
	}
	public LocalLBProfileLogAction [] Endget_start_control_channel_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileLogAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_start_control_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileLogElementSequence [] get_start_control_channel_element(
		string [] profiles
	) {
		object [] results = this.Invoke("get_start_control_channel_element", new object [] {
				profiles});
		return ((LocalLBProfileLogElementSequence [])(results[0]));
	}
	public System.IAsyncResult Beginget_start_control_channel_element(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_start_control_channel_element", new object[] {
			profiles}, callback, asyncState);
	}
	public LocalLBProfileLogElementSequence [] Endget_start_control_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileLogElementSequence [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_start_data_channel_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileLogAction [] get_start_data_channel_action(
		string [] profiles
	) {
		object [] results = this.Invoke("get_start_data_channel_action", new object [] {
				profiles});
		return ((LocalLBProfileLogAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_start_data_channel_action(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_start_data_channel_action", new object[] {
			profiles}, callback, asyncState);
	}
	public LocalLBProfileLogAction [] Endget_start_data_channel_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileLogAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_start_data_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileLogElementSequence [] get_start_data_channel_element(
		string [] profiles
	) {
		object [] results = this.Invoke("get_start_data_channel_element", new object [] {
				profiles});
		return ((LocalLBProfileLogElementSequence [])(results[0]));
	}
	public System.IAsyncResult Beginget_start_data_channel_element(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_start_data_channel_element", new object[] {
			profiles}, callback, asyncState);
	}
	public LocalLBProfileLogElementSequence [] Endget_start_data_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileLogElementSequence [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
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
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_base_profile(
		string [] profiles
	) {
		object [] results = this.Invoke("is_base_profile", new object [] {
				profiles});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_base_profile(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_base_profile", new object[] {
			profiles}, callback, asyncState);
	}
	public bool [] Endis_base_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_system_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_system_profile(
		string [] profiles
	) {
		object [] results = this.Invoke("is_system_profile", new object [] {
				profiles});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_system_profile(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_system_profile", new object[] {
			profiles}, callback, asyncState);
	}
	public bool [] Endis_system_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_end_control_channel_elements
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void remove_all_end_control_channel_elements(
		string [] profiles
	) {
		this.Invoke("remove_all_end_control_channel_elements", new object [] {
				profiles});

	}
	public System.IAsyncResult Beginremove_all_end_control_channel_elements(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_end_control_channel_elements", new object[] {
			profiles}, callback, asyncState);
	}
	public void Endremove_all_end_control_channel_elements(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_end_data_channel_elements
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void remove_all_end_data_channel_elements(
		string [] profiles
	) {
		this.Invoke("remove_all_end_data_channel_elements", new object [] {
				profiles});

	}
	public System.IAsyncResult Beginremove_all_end_data_channel_elements(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_end_data_channel_elements", new object[] {
			profiles}, callback, asyncState);
	}
	public void Endremove_all_end_data_channel_elements(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_start_control_channel_elements
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void remove_all_start_control_channel_elements(
		string [] profiles
	) {
		this.Invoke("remove_all_start_control_channel_elements", new object [] {
				profiles});

	}
	public System.IAsyncResult Beginremove_all_start_control_channel_elements(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_start_control_channel_elements", new object[] {
			profiles}, callback, asyncState);
	}
	public void Endremove_all_start_control_channel_elements(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_start_data_channel_elements
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void remove_all_start_data_channel_elements(
		string [] profiles
	) {
		this.Invoke("remove_all_start_data_channel_elements", new object [] {
				profiles});

	}
	public System.IAsyncResult Beginremove_all_start_data_channel_elements(string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_start_data_channel_elements", new object[] {
			profiles}, callback, asyncState);
	}
	public void Endremove_all_start_data_channel_elements(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_end_control_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void remove_end_control_channel_element(
		string [] profiles,
		LocalLBProfileLogElementSequence [] elements
	) {
		this.Invoke("remove_end_control_channel_element", new object [] {
				profiles,
				elements});

	}
	public System.IAsyncResult Beginremove_end_control_channel_element(string [] profiles,LocalLBProfileLogElementSequence [] elements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_end_control_channel_element", new object[] {
			profiles,
			elements}, callback, asyncState);
	}
	public void Endremove_end_control_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_end_data_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void remove_end_data_channel_element(
		string [] profiles,
		LocalLBProfileLogElementSequence [] elements
	) {
		this.Invoke("remove_end_data_channel_element", new object [] {
				profiles,
				elements});

	}
	public System.IAsyncResult Beginremove_end_data_channel_element(string [] profiles,LocalLBProfileLogElementSequence [] elements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_end_data_channel_element", new object[] {
			profiles,
			elements}, callback, asyncState);
	}
	public void Endremove_end_data_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_start_control_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void remove_start_control_channel_element(
		string [] profiles,
		LocalLBProfileLogElementSequence [] elements
	) {
		this.Invoke("remove_start_control_channel_element", new object [] {
				profiles,
				elements});

	}
	public System.IAsyncResult Beginremove_start_control_channel_element(string [] profiles,LocalLBProfileLogElementSequence [] elements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_start_control_channel_element", new object[] {
			profiles,
			elements}, callback, asyncState);
	}
	public void Endremove_start_control_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_start_data_channel_element
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void remove_start_data_channel_element(
		string [] profiles,
		LocalLBProfileLogElementSequence [] elements
	) {
		this.Invoke("remove_start_data_channel_element", new object [] {
				profiles,
				elements});

	}
	public System.IAsyncResult Beginremove_start_data_channel_element(string [] profiles,LocalLBProfileLogElementSequence [] elements, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_start_data_channel_element", new object[] {
			profiles,
			elements}, callback, asyncState);
	}
	public void Endremove_start_data_channel_element(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void set_default_profile(
		string [] profiles,
		string [] defaults
	) {
		this.Invoke("set_default_profile", new object [] {
				profiles,
				defaults});

	}
	public System.IAsyncResult Beginset_default_profile(string [] profiles,string [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_profile", new object[] {
			profiles,
			defaults}, callback, asyncState);
	}
	public void Endset_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void set_description(
		string [] profiles,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				profiles,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] profiles,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			profiles,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_end_control_channel_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void set_end_control_channel_action(
		string [] profiles,
		LocalLBProfileLogAction [] actions
	) {
		this.Invoke("set_end_control_channel_action", new object [] {
				profiles,
				actions});

	}
	public System.IAsyncResult Beginset_end_control_channel_action(string [] profiles,LocalLBProfileLogAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_end_control_channel_action", new object[] {
			profiles,
			actions}, callback, asyncState);
	}
	public void Endset_end_control_channel_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_end_data_channel_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void set_end_data_channel_action(
		string [] profiles,
		LocalLBProfileLogAction [] actions
	) {
		this.Invoke("set_end_data_channel_action", new object [] {
				profiles,
				actions});

	}
	public System.IAsyncResult Beginset_end_data_channel_action(string [] profiles,LocalLBProfileLogAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_end_data_channel_action", new object[] {
			profiles,
			actions}, callback, asyncState);
	}
	public void Endset_end_data_channel_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_inbound_transaction_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void set_inbound_transaction_action(
		string [] profiles,
		LocalLBProfileLogAction [] actions
	) {
		this.Invoke("set_inbound_transaction_action", new object [] {
				profiles,
				actions});

	}
	public System.IAsyncResult Beginset_inbound_transaction_action(string [] profiles,LocalLBProfileLogAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_inbound_transaction_action", new object[] {
			profiles,
			actions}, callback, asyncState);
	}
	public void Endset_inbound_transaction_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_start_control_channel_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void set_start_control_channel_action(
		string [] profiles,
		LocalLBProfileLogAction [] actions
	) {
		this.Invoke("set_start_control_channel_action", new object [] {
				profiles,
				actions});

	}
	public System.IAsyncResult Beginset_start_control_channel_action(string [] profiles,LocalLBProfileLogAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_start_control_channel_action", new object[] {
			profiles,
			actions}, callback, asyncState);
	}
	public void Endset_start_control_channel_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_start_data_channel_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ALGLogProfile", 
		RequestNamespace="urn:iControl:LocalLB/ALGLogProfile", ResponseNamespace="urn:iControl:LocalLB/ALGLogProfile")]
	public void set_start_data_channel_action(
		string [] profiles,
		LocalLBProfileLogAction [] actions
	) {
		this.Invoke("set_start_data_channel_action", new object [] {
				profiles,
				actions});

	}
	public System.IAsyncResult Beginset_start_data_channel_action(string [] profiles,LocalLBProfileLogAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_start_data_channel_action", new object[] {
			profiles,
			actions}, callback, asyncState);
	}
	public void Endset_start_data_channel_action(System.IAsyncResult asyncResult) {
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
