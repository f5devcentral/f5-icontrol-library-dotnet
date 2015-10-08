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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.SNATPoolBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBSNATPoolSNATPoolMemberStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBSNATPoolSNATPoolStatistics))]
	public partial class LocalLBSNATPool : iControlInterface {
		public LocalLBSNATPool() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void add_member(
		string [] snat_pools,
		string [] [] members
	) {
		this.Invoke("add_member", new object [] {
				snat_pools,
				members});

	}
	public System.IAsyncResult Beginadd_member(string [] snat_pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member", new object[] {
			snat_pools,
			members}, callback, asyncState);
	}
	public void Endadd_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_member_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void add_member_v2(
		string [] snat_pools,
		string [] [] members
	) {
		this.Invoke("add_member_v2", new object [] {
				snat_pools,
				members});

	}
	public System.IAsyncResult Beginadd_member_v2(string [] snat_pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member_v2", new object[] {
			snat_pools,
			members}, callback, asyncState);
	}
	public void Endadd_member_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void create(
		string [] snat_pools,
		string [] [] translation_addresses
	) {
		this.Invoke("create", new object [] {
				snat_pools,
				translation_addresses});

	}
	public System.IAsyncResult Begincreate(string [] snat_pools,string [] [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			snat_pools,
			translation_addresses}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void create_v2(
		string [] snat_pools,
		string [] [] translation_addresses
	) {
		this.Invoke("create_v2", new object [] {
				snat_pools,
				translation_addresses});

	}
	public System.IAsyncResult Begincreate_v2(string [] snat_pools,string [] [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_v2", new object[] {
			snat_pools,
			translation_addresses}, callback, asyncState);
	}
	public void Endcreate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_snat_pools
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void delete_all_snat_pools(

	) {
		this.Invoke("delete_all_snat_pools", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_snat_pools(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_snat_pools", new object[0], callback, asyncState);
	}
	public void Enddelete_all_snat_pools(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_snat_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void delete_snat_pool(
		string [] snat_pools
	) {
		this.Invoke("delete_snat_pool", new object [] {
				snat_pools});

	}
	public System.IAsyncResult Begindelete_snat_pool(string [] snat_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_snat_pool", new object[] {
			snat_pools}, callback, asyncState);
	}
	public void Enddelete_snat_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATPoolSNATPoolMemberStatistics [] get_all_member_statistics(
		string [] snat_pools
	) {
		object [] results = this.Invoke("get_all_member_statistics", new object [] {
				snat_pools});
		return ((LocalLBSNATPoolSNATPoolMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_member_statistics(string [] snat_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_member_statistics", new object[] {
			snat_pools}, callback, asyncState);
	}
	public LocalLBSNATPoolSNATPoolMemberStatistics [] Endget_all_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATPoolSNATPoolMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATPoolSNATPoolStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBSNATPoolSNATPoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBSNATPoolSNATPoolStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATPoolSNATPoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] snat_pools
	) {
		object [] results = this.Invoke("get_description", new object [] {
				snat_pools});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] snat_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			snat_pools}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
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
	// get_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_member(
		string [] snat_pools
	) {
		object [] results = this.Invoke("get_member", new object [] {
				snat_pools});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member(string [] snat_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member", new object[] {
			snat_pools}, callback, asyncState);
	}
	public string [] [] Endget_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATPoolSNATPoolMemberStatistics [] get_member_statistics(
		string [] snat_pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_member_statistics", new object [] {
				snat_pools,
				members});
		return ((LocalLBSNATPoolSNATPoolMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_statistics(string [] snat_pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_statistics", new object[] {
			snat_pools,
			members}, callback, asyncState);
	}
	public LocalLBSNATPoolSNATPoolMemberStatistics [] Endget_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATPoolSNATPoolMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_member_v2(
		string [] snat_pools
	) {
		object [] results = this.Invoke("get_member_v2", new object [] {
				snat_pools});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_v2(string [] snat_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_v2", new object[] {
			snat_pools}, callback, asyncState);
	}
	public string [] [] Endget_member_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATPoolSNATPoolStatistics get_statistics(
		string [] snat_pools
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				snat_pools});
		return ((LocalLBSNATPoolSNATPoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] snat_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			snat_pools}, callback, asyncState);
	}
	public LocalLBSNATPoolSNATPoolStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATPoolSNATPoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
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
	// remove_all_members
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void remove_all_members(
		string [] snat_pools
	) {
		this.Invoke("remove_all_members", new object [] {
				snat_pools});

	}
	public System.IAsyncResult Beginremove_all_members(string [] snat_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_members", new object[] {
			snat_pools}, callback, asyncState);
	}
	public void Endremove_all_members(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void remove_member(
		string [] snat_pools,
		string [] [] members
	) {
		this.Invoke("remove_member", new object [] {
				snat_pools,
				members});

	}
	public System.IAsyncResult Beginremove_member(string [] snat_pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member", new object[] {
			snat_pools,
			members}, callback, asyncState);
	}
	public void Endremove_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void remove_member_v2(
		string [] snat_pools,
		string [] [] members
	) {
		this.Invoke("remove_member_v2", new object [] {
				snat_pools,
				members});

	}
	public System.IAsyncResult Beginremove_member_v2(string [] snat_pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member_v2", new object[] {
			snat_pools,
			members}, callback, asyncState);
	}
	public void Endremove_member_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void reset_member_statistics(
		string [] snat_pools,
		string [] [] members
	) {
		this.Invoke("reset_member_statistics", new object [] {
				snat_pools,
				members});

	}
	public System.IAsyncResult Beginreset_member_statistics(string [] snat_pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_member_statistics", new object[] {
			snat_pools,
			members}, callback, asyncState);
	}
	public void Endreset_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void reset_statistics(
		string [] snat_pools
	) {
		this.Invoke("reset_statistics", new object [] {
				snat_pools});

	}
	public System.IAsyncResult Beginreset_statistics(string [] snat_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			snat_pools}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPool", 
		RequestNamespace="urn:iControl:LocalLB/SNATPool", ResponseNamespace="urn:iControl:LocalLB/SNATPool")]
	public void set_description(
		string [] snat_pools,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				snat_pools,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] snat_pools,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			snat_pools,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNATPool.SNATPoolMemberStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBSNATPoolSNATPoolMemberStatisticEntry
	{
		private string memberField;
		public string member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNATPool.SNATPoolMemberStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBSNATPoolSNATPoolMemberStatistics
	{
		private LocalLBSNATPoolSNATPoolMemberStatisticEntry [] statisticsField;
		public LocalLBSNATPoolSNATPoolMemberStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNATPool.SNATPoolStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBSNATPoolSNATPoolStatisticEntry
	{
		private string snat_poolField;
		public string snat_pool
		{
			get { return this.snat_poolField; }
			set { this.snat_poolField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNATPool.SNATPoolStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBSNATPoolSNATPoolStatistics
	{
		private LocalLBSNATPoolSNATPoolStatisticEntry [] statisticsField;
		public LocalLBSNATPoolSNATPoolStatisticEntry [] statistics
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
