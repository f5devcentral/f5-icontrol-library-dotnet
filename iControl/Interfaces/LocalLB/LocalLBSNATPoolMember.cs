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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.SNATPoolMemberBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBSNATPoolMemberSNATPoolMemberStatistics))]
	public partial class LocalLBSNATPoolMember : iControlInterface {
		public LocalLBSNATPoolMember() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPoolMember", 
		RequestNamespace="urn:iControl:LocalLB/SNATPoolMember", ResponseNamespace="urn:iControl:LocalLB/SNATPoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATPoolMemberSNATPoolMemberStatistics [] get_all_statistics(
		string [] snat_pools
	) {
		object [] results = this.Invoke("get_all_statistics", new object [] {
				snat_pools});
		return ((LocalLBSNATPoolMemberSNATPoolMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(string [] snat_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[] {
			snat_pools}, callback, asyncState);
	}
	public LocalLBSNATPoolMemberSNATPoolMemberStatistics [] Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATPoolMemberSNATPoolMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPoolMember", 
		RequestNamespace="urn:iControl:LocalLB/SNATPoolMember", ResponseNamespace="urn:iControl:LocalLB/SNATPoolMember")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATPoolMemberSNATPoolMemberStatistics [] get_statistics(
		string [] snat_pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				snat_pools,
				members});
		return ((LocalLBSNATPoolMemberSNATPoolMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] snat_pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			snat_pools,
			members}, callback, asyncState);
	}
	public LocalLBSNATPoolMemberSNATPoolMemberStatistics [] Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATPoolMemberSNATPoolMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPoolMember", 
		RequestNamespace="urn:iControl:LocalLB/SNATPoolMember", ResponseNamespace="urn:iControl:LocalLB/SNATPoolMember")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATPoolMember", 
		RequestNamespace="urn:iControl:LocalLB/SNATPoolMember", ResponseNamespace="urn:iControl:LocalLB/SNATPoolMember")]
	public void reset_statistics(
		string [] snat_pools,
		string [] [] members
	) {
		this.Invoke("reset_statistics", new object [] {
				snat_pools,
				members});

	}
	public System.IAsyncResult Beginreset_statistics(string [] snat_pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			snat_pools,
			members}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNATPoolMember.SNATPoolMemberStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBSNATPoolMemberSNATPoolMemberStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNATPoolMember.SNATPoolMemberStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBSNATPoolMemberSNATPoolMemberStatistics
	{
		private LocalLBSNATPoolMemberSNATPoolMemberStatisticEntry [] statisticsField;
		public LocalLBSNATPoolMemberSNATPoolMemberStatisticEntry [] statistics
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
