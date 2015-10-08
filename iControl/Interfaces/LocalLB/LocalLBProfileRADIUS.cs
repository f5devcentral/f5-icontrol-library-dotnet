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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileRADIUSBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileRADIUSProfileRADIUSStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStringArray))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileRADIUS : iControlInterface {
		public LocalLBProfileRADIUS() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
	public void add_client(
		string [] profile_names,
		string [] [] clients
	) {
		this.Invoke("add_client", new object [] {
				profile_names,
				clients});

	}
	public System.IAsyncResult Beginadd_client(string [] profile_names,string [] [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_client", new object[] {
			profile_names,
			clients}, callback, asyncState);
	}
	public void Endadd_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileRADIUSProfileRADIUSStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileRADIUSProfileRADIUSStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileRADIUSProfileRADIUSStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileRADIUSProfileRADIUSStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_client(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_client", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_client(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_client", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	// get_persist_avp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_persist_avp(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_persist_avp", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_persist_avp(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persist_avp", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_persist_avp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileRADIUSProfileRADIUSStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileRADIUSProfileRADIUSStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileRADIUSProfileRADIUSStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileRADIUSProfileRADIUSStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	// remove_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
	public void remove_client(
		string [] profile_names,
		string [] [] clients
	) {
		this.Invoke("remove_client", new object [] {
				profile_names,
				clients});

	}
	public System.IAsyncResult Beginremove_client(string [] profile_names,string [] [] clients, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_client", new object[] {
			profile_names,
			clients}, callback, asyncState);
	}
	public void Endremove_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	// set_default_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
	public void set_default_client(
		string [] profile_names
	) {
		this.Invoke("set_default_client", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_client(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_client", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
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
	// set_persist_avp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRADIUS", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRADIUS", ResponseNamespace="urn:iControl:LocalLB/ProfileRADIUS")]
	public void set_persist_avp(
		string [] profile_names,
		LocalLBProfileString [] avps
	) {
		this.Invoke("set_persist_avp", new object [] {
				profile_names,
				avps});

	}
	public System.IAsyncResult Beginset_persist_avp(string [] profile_names,LocalLBProfileString [] avps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persist_avp", new object[] {
			profile_names,
			avps}, callback, asyncState);
	}
	public void Endset_persist_avp(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileRADIUS.ProfileRADIUSStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileRADIUSProfileRADIUSStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileRADIUS.ProfileRADIUSStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileRADIUSProfileRADIUSStatistics
	{
		private LocalLBProfileRADIUSProfileRADIUSStatisticEntry [] statisticsField;
		public LocalLBProfileRADIUSProfileRADIUSStatisticEntry [] statistics
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
