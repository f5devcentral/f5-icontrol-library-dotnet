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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.DNSSECZoneBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBDNSSECZoneDNSSECStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBDNSSECZoneSecureEntryPoint))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonULong64))]
	public partial class GlobalLBDNSSECZone : iControlInterface {
		public GlobalLBDNSSECZone() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void add_key(
		string [] zones,
		string [] [] keys
	) {
		this.Invoke("add_key", new object [] {
				zones,
				keys});

	}
	public System.IAsyncResult Beginadd_key(string [] zones,string [] [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_key", new object[] {
			zones,
			keys}, callback, asyncState);
	}
	public void Endadd_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void create(
		string [] zones,
		string [] [] keys
	) {
		this.Invoke("create", new object [] {
				zones,
				keys});

	}
	public System.IAsyncResult Begincreate(string [] zones,string [] [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			zones,
			keys}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_zones
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void delete_all_zones(

	) {
		this.Invoke("delete_all_zones", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_zones(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_zones", new object[0], callback, asyncState);
	}
	public void Enddelete_all_zones(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void delete_zone(
		string [] zones
	) {
		this.Invoke("delete_zone", new object [] {
				zones});

	}
	public System.IAsyncResult Begindelete_zone(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_zone", new object[] {
			zones}, callback, asyncState);
	}
	public void Enddelete_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDNSSECZoneDNSSECStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBDNSSECZoneDNSSECStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBDNSSECZoneDNSSECStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDNSSECZoneDNSSECStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] zones
	) {
		object [] results = this.Invoke("get_description", new object [] {
				zones});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			zones}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ds_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDNSSECZoneHashAlgorithm [] get_ds_algorithm(
		string [] zones
	) {
		object [] results = this.Invoke("get_ds_algorithm", new object [] {
				zones});
		return ((GlobalLBDNSSECZoneHashAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_ds_algorithm(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ds_algorithm", new object[] {
			zones}, callback, asyncState);
	}
	public GlobalLBDNSSECZoneHashAlgorithm [] Endget_ds_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDNSSECZoneHashAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] zones
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				zones});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			zones}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_key(
		string [] zones
	) {
		object [] results = this.Invoke("get_key", new object [] {
				zones});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_key(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_key", new object[] {
			zones}, callback, asyncState);
	}
	public string [] [] Endget_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
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
	// get_nsec3_iteration_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_nsec3_iteration_count(
		string [] zones
	) {
		object [] results = this.Invoke("get_nsec3_iteration_count", new object [] {
				zones});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_nsec3_iteration_count(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nsec3_iteration_count", new object[] {
			zones}, callback, asyncState);
	}
	public long [] Endget_nsec3_iteration_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		string [] zones
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				zones});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			zones}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_secure_entry_point
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDNSSECZoneSecureEntryPoint [] [] get_secure_entry_point(
		string [] zones
	) {
		object [] results = this.Invoke("get_secure_entry_point", new object [] {
				zones});
		return ((GlobalLBDNSSECZoneSecureEntryPoint [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_secure_entry_point(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_secure_entry_point", new object[] {
			zones}, callback, asyncState);
	}
	public GlobalLBDNSSECZoneSecureEntryPoint [] [] Endget_secure_entry_point(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDNSSECZoneSecureEntryPoint [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDNSSECZoneDNSSECStatistics get_statistics(
		string [] zones
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				zones});
		return ((GlobalLBDNSSECZoneDNSSECStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			zones}, callback, asyncState);
	}
	public GlobalLBDNSSECZoneDNSSECStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDNSSECZoneDNSSECStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transfer_external_serial
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] get_transfer_external_serial(
		string [] zones
	) {
		object [] results = this.Invoke("get_transfer_external_serial", new object [] {
				zones});
		return ((CommonULong64 [])(results[0]));
	}
	public System.IAsyncResult Beginget_transfer_external_serial(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transfer_external_serial", new object[] {
			zones}, callback, asyncState);
	}
	public CommonULong64 [] Endget_transfer_external_serial(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transfer_master_serial
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] get_transfer_master_serial(
		string [] zones
	) {
		object [] results = this.Invoke("get_transfer_master_serial", new object [] {
				zones});
		return ((CommonULong64 [])(results[0]));
	}
	public System.IAsyncResult Beginget_transfer_master_serial(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transfer_master_serial", new object[] {
			zones}, callback, asyncState);
	}
	public CommonULong64 [] Endget_transfer_master_serial(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
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
	// remove_all_keys
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void remove_all_keys(
		string [] zones
	) {
		this.Invoke("remove_all_keys", new object [] {
				zones});

	}
	public System.IAsyncResult Beginremove_all_keys(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_keys", new object[] {
			zones}, callback, asyncState);
	}
	public void Endremove_all_keys(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void remove_key(
		string [] zones,
		string [] [] keys
	) {
		this.Invoke("remove_key", new object [] {
				zones,
				keys});

	}
	public System.IAsyncResult Beginremove_key(string [] zones,string [] [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_key", new object[] {
			zones,
			keys}, callback, asyncState);
	}
	public void Endremove_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void reset_statistics(
		string [] zones
	) {
		this.Invoke("reset_statistics", new object [] {
				zones});

	}
	public System.IAsyncResult Beginreset_statistics(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			zones}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void set_description(
		string [] zones,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				zones,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] zones,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			zones,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ds_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void set_ds_algorithm(
		string [] zones,
		GlobalLBDNSSECZoneHashAlgorithm [] algorithms
	) {
		this.Invoke("set_ds_algorithm", new object [] {
				zones,
				algorithms});

	}
	public System.IAsyncResult Beginset_ds_algorithm(string [] zones,GlobalLBDNSSECZoneHashAlgorithm [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ds_algorithm", new object[] {
			zones,
			algorithms}, callback, asyncState);
	}
	public void Endset_ds_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void set_enabled_state(
		string [] zones,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				zones,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] zones,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			zones,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nsec3_iteration_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECZone", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECZone", ResponseNamespace="urn:iControl:GlobalLB/DNSSECZone")]
	public void set_nsec3_iteration_count(
		string [] zones,
		long [] counts
	) {
		this.Invoke("set_nsec3_iteration_count", new object [] {
				zones,
				counts});

	}
	public System.IAsyncResult Beginset_nsec3_iteration_count(string [] zones,long [] counts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nsec3_iteration_count", new object[] {
			zones,
			counts}, callback, asyncState);
	}
	public void Endset_nsec3_iteration_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DNSSECZone.HashAlgorithm", Namespace = "urn:iControl")]
	public enum GlobalLBDNSSECZoneHashAlgorithm
	{
		DNSSECZONE_HASH_ALGORITHM_UNKNOWN,
		DNSSECZONE_HASH_ALGORITHM_SHA1,
		DNSSECZONE_HASH_ALGORITHM_SHA256,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DNSSECZone.TSIGAlgorithm", Namespace = "urn:iControl")]
	public enum GlobalLBDNSSECZoneTSIGAlgorithm
	{
		TSIG_ALGORITHM_UNKNOWN,
		TSIG_ALGORITHM_MD5,
		TSIG_ALGORITHM_SHA1,
		TSIG_ALGORITHM_SHA256,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DNSSECZone.DNSSECStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBDNSSECZoneDNSSECStatisticEntry
	{
		private string zoneField;
		public string zone
		{
			get { return this.zoneField; }
			set { this.zoneField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DNSSECZone.DNSSECStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBDNSSECZoneDNSSECStatistics
	{
		private GlobalLBDNSSECZoneDNSSECStatisticEntry [] statisticsField;
		public GlobalLBDNSSECZoneDNSSECStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DNSSECZone.SecureEntryPoint", Namespace = "urn:iControl")]
	public partial class GlobalLBDNSSECZoneSecureEntryPoint
	{
		private string dnskey_recordField;
		public string dnskey_record
		{
			get { return this.dnskey_recordField; }
			set { this.dnskey_recordField = value; }
		}
		private string ds_recordField;
		public string ds_record
		{
			get { return this.ds_recordField; }
			set { this.ds_recordField = value; }
		}
		private CommonULong64 generation_idField;
		public CommonULong64 generation_id
		{
			get { return this.generation_idField; }
			set { this.generation_idField = value; }
		}
		private string key_nameField;
		public string key_name
		{
			get { return this.key_nameField; }
			set { this.key_nameField = value; }
		}
	};

}
