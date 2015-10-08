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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.FirewallWeeklyScheduleBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SecurityFirewallWeeklyScheduleDailyTime))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStampExpiry))]
	public partial class SecurityFirewallWeeklySchedule : iControlInterface {
		public SecurityFirewallWeeklySchedule() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	public void create(
		string [] schedules
	) {
		this.Invoke("create", new object [] {
				schedules});

	}
	public System.IAsyncResult Begincreate(string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			schedules}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_weekly_schedules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	public void delete_all_weekly_schedules(

	) {
		this.Invoke("delete_all_weekly_schedules", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_weekly_schedules(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_weekly_schedules", new object[0], callback, asyncState);
	}
	public void Enddelete_all_weekly_schedules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	public void delete_weekly_schedule(
		string [] schedules
	) {
		this.Invoke("delete_weekly_schedule", new object [] {
				schedules});

	}
	public System.IAsyncResult Begindelete_weekly_schedule(string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_weekly_schedule", new object[] {
			schedules}, callback, asyncState);
	}
	public void Enddelete_weekly_schedule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_daily_hour_end
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityFirewallWeeklyScheduleDailyTime [] get_daily_hour_end(
		string [] schedules
	) {
		object [] results = this.Invoke("get_daily_hour_end", new object [] {
				schedules});
		return ((SecurityFirewallWeeklyScheduleDailyTime [])(results[0]));
	}
	public System.IAsyncResult Beginget_daily_hour_end(string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_daily_hour_end", new object[] {
			schedules}, callback, asyncState);
	}
	public SecurityFirewallWeeklyScheduleDailyTime [] Endget_daily_hour_end(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityFirewallWeeklyScheduleDailyTime [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_daily_hour_start
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityFirewallWeeklyScheduleDailyTime [] get_daily_hour_start(
		string [] schedules
	) {
		object [] results = this.Invoke("get_daily_hour_start", new object [] {
				schedules});
		return ((SecurityFirewallWeeklyScheduleDailyTime [])(results[0]));
	}
	public System.IAsyncResult Beginget_daily_hour_start(string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_daily_hour_start", new object[] {
			schedules}, callback, asyncState);
	}
	public SecurityFirewallWeeklyScheduleDailyTime [] Endget_daily_hour_start(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityFirewallWeeklyScheduleDailyTime [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_date_valid_end
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStampExpiry [] get_date_valid_end(
		string [] schedules
	) {
		object [] results = this.Invoke("get_date_valid_end", new object [] {
				schedules});
		return ((CommonTimeStampExpiry [])(results[0]));
	}
	public System.IAsyncResult Beginget_date_valid_end(string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_date_valid_end", new object[] {
			schedules}, callback, asyncState);
	}
	public CommonTimeStampExpiry [] Endget_date_valid_end(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStampExpiry [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_date_valid_start
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] get_date_valid_start(
		string [] schedules
	) {
		object [] results = this.Invoke("get_date_valid_start", new object [] {
				schedules});
		return ((CommonTimeStamp [])(results[0]));
	}
	public System.IAsyncResult Beginget_date_valid_start(string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_date_valid_start", new object[] {
			schedules}, callback, asyncState);
	}
	public CommonTimeStamp [] Endget_date_valid_start(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_days_of_week
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityFirewallWeeklyScheduleFWWeekDay [] [] get_days_of_week(
		string [] schedules
	) {
		object [] results = this.Invoke("get_days_of_week", new object [] {
				schedules});
		return ((SecurityFirewallWeeklyScheduleFWWeekDay [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_days_of_week(string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_days_of_week", new object[] {
			schedules}, callback, asyncState);
	}
	public SecurityFirewallWeeklyScheduleFWWeekDay [] [] Endget_days_of_week(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityFirewallWeeklyScheduleFWWeekDay [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] schedules
	) {
		object [] results = this.Invoke("get_description", new object [] {
				schedules});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			schedules}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
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
	// set_daily_hour_end
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	public void set_daily_hour_end(
		string [] schedules,
		SecurityFirewallWeeklyScheduleDailyTime [] times
	) {
		this.Invoke("set_daily_hour_end", new object [] {
				schedules,
				times});

	}
	public System.IAsyncResult Beginset_daily_hour_end(string [] schedules,SecurityFirewallWeeklyScheduleDailyTime [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_daily_hour_end", new object[] {
			schedules,
			times}, callback, asyncState);
	}
	public void Endset_daily_hour_end(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_daily_hour_start
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	public void set_daily_hour_start(
		string [] schedules,
		SecurityFirewallWeeklyScheduleDailyTime [] times
	) {
		this.Invoke("set_daily_hour_start", new object [] {
				schedules,
				times});

	}
	public System.IAsyncResult Beginset_daily_hour_start(string [] schedules,SecurityFirewallWeeklyScheduleDailyTime [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_daily_hour_start", new object[] {
			schedules,
			times}, callback, asyncState);
	}
	public void Endset_daily_hour_start(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_date_valid_end
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	public void set_date_valid_end(
		string [] schedules,
		CommonTimeStampExpiry [] dates
	) {
		this.Invoke("set_date_valid_end", new object [] {
				schedules,
				dates});

	}
	public System.IAsyncResult Beginset_date_valid_end(string [] schedules,CommonTimeStampExpiry [] dates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_date_valid_end", new object[] {
			schedules,
			dates}, callback, asyncState);
	}
	public void Endset_date_valid_end(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_date_valid_start
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	public void set_date_valid_start(
		string [] schedules,
		CommonTimeStamp [] dates
	) {
		this.Invoke("set_date_valid_start", new object [] {
				schedules,
				dates});

	}
	public System.IAsyncResult Beginset_date_valid_start(string [] schedules,CommonTimeStamp [] dates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_date_valid_start", new object[] {
			schedules,
			dates}, callback, asyncState);
	}
	public void Endset_date_valid_start(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_days_of_week
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	public void set_days_of_week(
		string [] schedules,
		SecurityFirewallWeeklyScheduleFWWeekDay [] [] days
	) {
		this.Invoke("set_days_of_week", new object [] {
				schedules,
				days});

	}
	public System.IAsyncResult Beginset_days_of_week(string [] schedules,SecurityFirewallWeeklyScheduleFWWeekDay [] [] days, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_days_of_week", new object[] {
			schedules,
			days}, callback, asyncState);
	}
	public void Endset_days_of_week(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallWeeklySchedule", 
		RequestNamespace="urn:iControl:Security/FirewallWeeklySchedule", ResponseNamespace="urn:iControl:Security/FirewallWeeklySchedule")]
	public void set_description(
		string [] schedules,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				schedules,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] schedules,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			schedules,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.FirewallWeeklySchedule.FWWeekDay", Namespace = "urn:iControl")]
	public enum SecurityFirewallWeeklyScheduleFWWeekDay
	{
		FW_UNKNOWN,
		FW_SUNDAY,
		FW_MONDAY,
		FW_TUESDAY,
		FW_WEDNESDAY,
		FW_THURSDAY,
		FW_FRIDAY,
		FW_SATURDAY,
		FW_ALL_DAYS,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.FirewallWeeklySchedule.DailyTime", Namespace = "urn:iControl")]
	public partial class SecurityFirewallWeeklyScheduleDailyTime
	{
		private long hourField;
		public long hour
		{
			get { return this.hourField; }
			set { this.hourField = value; }
		}
		private long minuteField;
		public long minute
		{
			get { return this.minuteField; }
			set { this.minuteField = value; }
		}
	};

}
