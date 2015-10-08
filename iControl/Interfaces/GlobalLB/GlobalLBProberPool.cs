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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.ProberPoolBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBProberPoolProberPoolMemberStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBProberPoolProberPoolStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	public partial class GlobalLBProberPool : iControlInterface {
		public GlobalLBProberPool() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void add_member(
		string [] pools,
		string [] [] members,
		long [] [] orders
	) {
		this.Invoke("add_member", new object [] {
				pools,
				members,
				orders});

	}
	public System.IAsyncResult Beginadd_member(string [] pools,string [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member", new object[] {
			pools,
			members,
			orders}, callback, asyncState);
	}
	public void Endadd_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void create(
		string [] pools,
		GlobalLBLBMethod [] lb_methods,
		string [] [] members,
		long [] [] orders
	) {
		this.Invoke("create", new object [] {
				pools,
				lb_methods,
				members,
				orders});

	}
	public System.IAsyncResult Begincreate(string [] pools,GlobalLBLBMethod [] lb_methods,string [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			pools,
			lb_methods,
			members,
			orders}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_prober_pools
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void delete_all_prober_pools(

	) {
		this.Invoke("delete_all_prober_pools", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_prober_pools(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_prober_pools", new object[0], callback, asyncState);
	}
	public void Enddelete_all_prober_pools(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_prober_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void delete_prober_pool(
		string [] pools
	) {
		this.Invoke("delete_prober_pool", new object [] {
				pools});

	}
	public System.IAsyncResult Begindelete_prober_pool(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_prober_pool", new object[] {
			pools}, callback, asyncState);
	}
	public void Enddelete_prober_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBProberPoolProberPoolMemberStatistics [] get_all_member_statistics(
		string [] pools
	) {
		object [] results = this.Invoke("get_all_member_statistics", new object [] {
				pools});
		return ((GlobalLBProberPoolProberPoolMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_member_statistics(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_member_statistics", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBProberPoolProberPoolMemberStatistics [] Endget_all_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBProberPoolProberPoolMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBProberPoolProberPoolStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBProberPoolProberPoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBProberPoolProberPoolStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBProberPoolProberPoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] pools
	) {
		object [] results = this.Invoke("get_description", new object [] {
				pools});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			pools}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] pools
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				pools});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			pools}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod [] get_lb_method(
		string [] pools
	) {
		object [] results = this.Invoke("get_lb_method", new object [] {
				pools});
		return ((GlobalLBLBMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_lb_method(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lb_method", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBLBMethod [] Endget_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_member(
		string [] pools
	) {
		object [] results = this.Invoke("get_member", new object [] {
				pools});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member", new object[] {
			pools}, callback, asyncState);
	}
	public string [] [] Endget_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_member_enabled_state(
		string [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_member_enabled_state", new object [] {
				pools,
				members});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_enabled_state(string [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_enabled_state", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] [] get_member_object_status(
		string [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_member_object_status", new object [] {
				pools,
				members});
		return ((CommonObjectStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_object_status(string [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_object_status", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public CommonObjectStatus [] [] Endget_member_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_member_order(
		string [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_member_order", new object [] {
				pools,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_order(string [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_order", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public long [] [] Endget_member_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBProberPoolProberPoolMemberStatistics [] get_member_statistics(
		string [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_member_statistics", new object [] {
				pools,
				members});
		return ((GlobalLBProberPoolProberPoolMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_statistics(string [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_statistics", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public GlobalLBProberPoolProberPoolMemberStatistics [] Endget_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBProberPoolProberPoolMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		string [] pools
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				pools});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			pools}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBProberPoolProberPoolStatistics get_statistics(
		string [] pools
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				pools});
		return ((GlobalLBProberPoolProberPoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBProberPoolProberPoolStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBProberPoolProberPoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void remove_all_members(
		string [] pools
	) {
		this.Invoke("remove_all_members", new object [] {
				pools});

	}
	public System.IAsyncResult Beginremove_all_members(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_members", new object[] {
			pools}, callback, asyncState);
	}
	public void Endremove_all_members(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void remove_member(
		string [] pools,
		string [] [] members
	) {
		this.Invoke("remove_member", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Beginremove_member(string [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endremove_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void reset_member_statistics(
		string [] pools,
		string [] [] members
	) {
		this.Invoke("reset_member_statistics", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Beginreset_member_statistics(string [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_member_statistics", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endreset_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void reset_statistics(
		string [] pools
	) {
		this.Invoke("reset_statistics", new object [] {
				pools});

	}
	public System.IAsyncResult Beginreset_statistics(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			pools}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void set_description(
		string [] pools,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				pools,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] pools,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			pools,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void set_enabled_state(
		string [] pools,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				pools,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] pools,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			pools,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void set_lb_method(
		string [] pools,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("set_lb_method", new object [] {
				pools,
				lb_methods});

	}
	public System.IAsyncResult Beginset_lb_method(string [] pools,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lb_method", new object[] {
			pools,
			lb_methods}, callback, asyncState);
	}
	public void Endset_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void set_member_enabled_state(
		string [] pools,
		string [] [] members,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_member_enabled_state", new object [] {
				pools,
				members,
				states});

	}
	public System.IAsyncResult Beginset_member_enabled_state(string [] pools,string [] [] members,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_enabled_state", new object[] {
			pools,
			members,
			states}, callback, asyncState);
	}
	public void Endset_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/ProberPool", 
		RequestNamespace="urn:iControl:GlobalLB/ProberPool", ResponseNamespace="urn:iControl:GlobalLB/ProberPool")]
	public void set_member_order(
		string [] pools,
		string [] [] members,
		long [] [] orders
	) {
		this.Invoke("set_member_order", new object [] {
				pools,
				members,
				orders});

	}
	public System.IAsyncResult Beginset_member_order(string [] pools,string [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_order", new object[] {
			pools,
			members,
			orders}, callback, asyncState);
	}
	public void Endset_member_order(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.ProberPool.ProberPoolMemberStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBProberPoolProberPoolMemberStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.ProberPool.ProberPoolMemberStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBProberPoolProberPoolMemberStatistics
	{
		private GlobalLBProberPoolProberPoolMemberStatisticEntry [] statisticsField;
		public GlobalLBProberPoolProberPoolMemberStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.ProberPool.ProberPoolStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBProberPoolProberPoolStatisticEntry
	{
		private string poolField;
		public string pool
		{
			get { return this.poolField; }
			set { this.poolField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.ProberPool.ProberPoolStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBProberPoolProberPoolStatistics
	{
		private GlobalLBProberPoolProberPoolStatisticEntry [] statisticsField;
		public GlobalLBProberPoolProberPoolStatisticEntry [] statistics
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
