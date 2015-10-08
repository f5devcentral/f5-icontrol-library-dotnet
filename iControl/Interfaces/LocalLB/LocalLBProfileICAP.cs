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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileICAPBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileICAPICAPProfileStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileICAP : iControlInterface {
		public LocalLBProfileICAP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileICAPICAPProfileStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileICAPICAPProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileICAPICAPProfileStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileICAPICAPProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	// get_header_from
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_header_from(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_header_from", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_header_from(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_header_from", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_header_from(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_host(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_host", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_host(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_host", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	// get_preview_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_preview_length(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_preview_length", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_preview_length(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_preview_length", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_preview_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_referer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_referer(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_referer", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_referer(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_referer", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_referer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileICAPICAPProfileStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileICAPICAPProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileICAPICAPProfileStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileICAPICAPProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	// get_uri
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_uri(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_uri", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_uri(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_uri", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_uri(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_user_agent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_user_agent(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_user_agent", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_user_agent(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_user_agent", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_user_agent(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
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
	// set_header_from
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	public void set_header_from(
		string [] profile_names,
		LocalLBProfileString [] headers
	) {
		this.Invoke("set_header_from", new object [] {
				profile_names,
				headers});

	}
	public System.IAsyncResult Beginset_header_from(string [] profile_names,LocalLBProfileString [] headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_header_from", new object[] {
			profile_names,
			headers}, callback, asyncState);
	}
	public void Endset_header_from(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_host
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	public void set_host(
		string [] profile_names,
		LocalLBProfileString [] hosts
	) {
		this.Invoke("set_host", new object [] {
				profile_names,
				hosts});

	}
	public System.IAsyncResult Beginset_host(string [] profile_names,LocalLBProfileString [] hosts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_host", new object[] {
			profile_names,
			hosts}, callback, asyncState);
	}
	public void Endset_host(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_preview_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	public void set_preview_length(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_preview_length", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_preview_length(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_preview_length", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_preview_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_referer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	public void set_referer(
		string [] profile_names,
		LocalLBProfileString [] referers
	) {
		this.Invoke("set_referer", new object [] {
				profile_names,
				referers});

	}
	public System.IAsyncResult Beginset_referer(string [] profile_names,LocalLBProfileString [] referers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_referer", new object[] {
			profile_names,
			referers}, callback, asyncState);
	}
	public void Endset_referer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_uri
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	public void set_uri(
		string [] profile_names,
		LocalLBProfileString [] uris
	) {
		this.Invoke("set_uri", new object [] {
				profile_names,
				uris});

	}
	public System.IAsyncResult Beginset_uri(string [] profile_names,LocalLBProfileString [] uris, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_uri", new object[] {
			profile_names,
			uris}, callback, asyncState);
	}
	public void Endset_uri(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_user_agent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileICAP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileICAP", ResponseNamespace="urn:iControl:LocalLB/ProfileICAP")]
	public void set_user_agent(
		string [] profile_names,
		LocalLBProfileString [] agents
	) {
		this.Invoke("set_user_agent", new object [] {
				profile_names,
				agents});

	}
	public System.IAsyncResult Beginset_user_agent(string [] profile_names,LocalLBProfileString [] agents, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_user_agent", new object[] {
			profile_names,
			agents}, callback, asyncState);
	}
	public void Endset_user_agent(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileICAP.ICAPProfileStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileICAPICAPProfileStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileICAP.ICAPProfileStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileICAPICAPProfileStatistics
	{
		private LocalLBProfileICAPICAPProfileStatisticEntry [] statisticsField;
		public LocalLBProfileICAPICAPProfileStatisticEntry [] statistics
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

}
