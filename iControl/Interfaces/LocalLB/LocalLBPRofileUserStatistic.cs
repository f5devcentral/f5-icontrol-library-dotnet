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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileUserStatisticBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileUserStatisticProfileUserStatisticStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileUserStatisticUserStatisticName))]
	public partial class LocalLBProfileUserStatistic : iControlInterface {
		public LocalLBProfileUserStatistic() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileUserStatisticProfileUserStatisticStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileUserStatisticProfileUserStatisticStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileUserStatisticProfileUserStatisticStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileUserStatisticProfileUserStatisticStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	// get_statistic_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileUserStatisticUserStatisticName [] [] get_statistic_name(
		string [] profile_names,
		LocalLBProfileUserStatisticUserStatisticKey [] [] statistic_keys
	) {
		object [] results = this.Invoke("get_statistic_name", new object [] {
				profile_names,
				statistic_keys});
		return ((LocalLBProfileUserStatisticUserStatisticName [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_statistic_name(string [] profile_names,LocalLBProfileUserStatisticUserStatisticKey [] [] statistic_keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistic_name", new object[] {
			profile_names,
			statistic_keys}, callback, asyncState);
	}
	public LocalLBProfileUserStatisticUserStatisticName [] [] Endget_statistic_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileUserStatisticUserStatisticName [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileUserStatisticProfileUserStatisticStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileUserStatisticProfileUserStatisticStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileUserStatisticProfileUserStatisticStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileUserStatisticProfileUserStatisticStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
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
	// set_statistic_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileUserStatistic", 
		RequestNamespace="urn:iControl:LocalLB/ProfileUserStatistic", ResponseNamespace="urn:iControl:LocalLB/ProfileUserStatistic")]
	public void set_statistic_name(
		string [] profile_names,
		LocalLBProfileUserStatisticUserStatisticName [] [] statistic_names
	) {
		this.Invoke("set_statistic_name", new object [] {
				profile_names,
				statistic_names});

	}
	public System.IAsyncResult Beginset_statistic_name(string [] profile_names,LocalLBProfileUserStatisticUserStatisticName [] [] statistic_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_statistic_name", new object[] {
			profile_names,
			statistic_names}, callback, asyncState);
	}
	public void Endset_statistic_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileUserStatistic.UserStatisticKey", Namespace = "urn:iControl")]
	public enum LocalLBProfileUserStatisticUserStatisticKey
	{
		USER_STATISTIC_UNDEFINED,
		USER_STATISTIC_1,
		USER_STATISTIC_2,
		USER_STATISTIC_3,
		USER_STATISTIC_4,
		USER_STATISTIC_5,
		USER_STATISTIC_6,
		USER_STATISTIC_7,
		USER_STATISTIC_8,
		USER_STATISTIC_9,
		USER_STATISTIC_10,
		USER_STATISTIC_11,
		USER_STATISTIC_12,
		USER_STATISTIC_13,
		USER_STATISTIC_14,
		USER_STATISTIC_15,
		USER_STATISTIC_16,
		USER_STATISTIC_17,
		USER_STATISTIC_18,
		USER_STATISTIC_19,
		USER_STATISTIC_20,
		USER_STATISTIC_21,
		USER_STATISTIC_22,
		USER_STATISTIC_23,
		USER_STATISTIC_24,
		USER_STATISTIC_25,
		USER_STATISTIC_26,
		USER_STATISTIC_27,
		USER_STATISTIC_28,
		USER_STATISTIC_29,
		USER_STATISTIC_30,
		USER_STATISTIC_31,
		USER_STATISTIC_32,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileUserStatistic.ProfileUserStatisticStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileUserStatisticProfileUserStatisticStatisticEntry
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private LocalLBProfileUserStatisticUserStatistic [] statisticsField;
		public LocalLBProfileUserStatisticUserStatistic [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileUserStatistic.ProfileUserStatisticStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileUserStatisticProfileUserStatisticStatistics
	{
		private LocalLBProfileUserStatisticProfileUserStatisticStatisticEntry [] statisticsField;
		public LocalLBProfileUserStatisticProfileUserStatisticStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileUserStatistic.UserStatistic", Namespace = "urn:iControl")]
	public partial class LocalLBProfileUserStatisticUserStatistic
	{
		private LocalLBProfileUserStatisticUserStatisticKey statistic_keyField;
		public LocalLBProfileUserStatisticUserStatisticKey statistic_key
		{
			get { return this.statistic_keyField; }
			set { this.statistic_keyField = value; }
		}
		private CommonULong64 valueField;
		public CommonULong64 value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private long time_stampField;
		public long time_stamp
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileUserStatistic.UserStatisticName", Namespace = "urn:iControl")]
	public partial class LocalLBProfileUserStatisticUserStatisticName
	{
		private LocalLBProfileUserStatisticUserStatisticKey statistic_keyField;
		public LocalLBProfileUserStatisticUserStatisticKey statistic_key
		{
			get { return this.statistic_keyField; }
			set { this.statistic_keyField = value; }
		}
		private LocalLBProfileString statistic_nameField;
		public LocalLBProfileString statistic_name
		{
			get { return this.statistic_nameField; }
			set { this.statistic_nameField = value; }
		}
	};

}
