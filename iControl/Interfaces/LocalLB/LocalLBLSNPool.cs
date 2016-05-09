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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.LSNPoolBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBLSNPoolLSNPoolStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBLSNPoolLSNPoolStatistics_v2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonVLANFilterList))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonPortRange))]
	public partial class LocalLBLSNPool : iControlInterface {
		public LocalLBLSNPool() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_backup_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void add_backup_member(
		string [] pools,
		string [] [] members
	) {
		this.Invoke("add_backup_member", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Beginadd_backup_member(string [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_backup_member", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endadd_backup_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void add_member(
		string [] pools,
		string [] [] members
	) {
		this.Invoke("add_member", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Beginadd_member(string [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endadd_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void create(
		string [] pools,
		string [] [] members
	) {
		this.Invoke("create", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Begincreate(string [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_lsn_pools
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void delete_all_lsn_pools(

	) {
		this.Invoke("delete_all_lsn_pools", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_lsn_pools(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_lsn_pools", new object[0], callback, asyncState);
	}
	public void Enddelete_all_lsn_pools(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_lsn_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void delete_lsn_pool(
		string [] pools
	) {
		this.Invoke("delete_lsn_pool", new object [] {
				pools});

	}
	public System.IAsyncResult Begindelete_lsn_pool(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_lsn_pool", new object[] {
			pools}, callback, asyncState);
	}
	public void Enddelete_lsn_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBLSNPoolLSNPoolStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBLSNPoolLSNPoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBLSNPoolLSNPoolStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBLSNPoolLSNPoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBLSNPoolLSNPoolStatistics_v2 get_all_statistics_v2(

	) {
		object [] results = this.Invoke("get_all_statistics_v2", new object [0]);
		return ((LocalLBLSNPoolLSNPoolStatistics_v2)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics_v2(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics_v2", new object[0], callback, asyncState);
	}
	public LocalLBLSNPoolLSNPoolStatistics_v2 Endget_all_statistics_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBLSNPoolLSNPoolStatistics_v2)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_backup_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_backup_member(
		string [] pools
	) {
		object [] results = this.Invoke("get_backup_member", new object [] {
				pools});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_backup_member(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_backup_member", new object[] {
			pools}, callback, asyncState);
	}
	public string [] [] Endget_backup_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_block_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_block_idle_timeout(
		string [] pools
	) {
		object [] results = this.Invoke("get_block_idle_timeout", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_block_idle_timeout(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_block_idle_timeout", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_block_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_block_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_block_lifetime(
		string [] pools
	) {
		object [] results = this.Invoke("get_block_lifetime", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_block_lifetime(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_block_lifetime", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_block_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_block_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_block_size(
		string [] pools
	) {
		object [] results = this.Invoke("get_block_size", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_block_size(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_block_size", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_block_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_client_block_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_client_block_limit(
		string [] pools
	) {
		object [] results = this.Invoke("get_client_block_limit", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_client_block_limit(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_client_block_limit", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_client_block_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_connection_limit(
		string [] pools
	) {
		object [] results = this.Invoke("get_connection_limit", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_limit(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_limit", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
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
	// get_egress_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonVLANFilterList [] get_egress_interface(
		string [] pools
	) {
		object [] results = this.Invoke("get_egress_interface", new object [] {
				pools});
		return ((CommonVLANFilterList [])(results[0]));
	}
	public System.IAsyncResult Beginget_egress_interface(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_egress_interface", new object[] {
			pools}, callback, asyncState);
	}
	public CommonVLANFilterList [] Endget_egress_interface(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonVLANFilterList [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_egress_interface_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_egress_interface_state(
		string [] pools
	) {
		object [] results = this.Invoke("get_egress_interface_state", new object [] {
				pools});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_egress_interface_state(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_egress_interface_state", new object[] {
			pools}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_egress_interface_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hairpin_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBLSNPoolHairpinMode [] get_hairpin_mode(
		string [] pools
	) {
		object [] results = this.Invoke("get_hairpin_mode", new object [] {
				pools});
		return ((LocalLBLSNPoolHairpinMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_hairpin_mode(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hairpin_mode", new object[] {
			pools}, callback, asyncState);
	}
	public LocalLBLSNPoolHairpinMode [] Endget_hairpin_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBLSNPoolHairpinMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_icmp_echo_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_icmp_echo_state(
		string [] pools
	) {
		object [] results = this.Invoke("get_icmp_echo_state", new object [] {
				pools});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_icmp_echo_state(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_icmp_echo_state", new object[] {
			pools}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_icmp_echo_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_inbound_connection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_inbound_connection_state(
		string [] pools
	) {
		object [] results = this.Invoke("get_inbound_connection_state", new object [] {
				pools});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_inbound_connection_state(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_inbound_connection_state", new object[] {
			pools}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_inbound_connection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_inbound_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBLSNPoolInboundMode [] get_inbound_mode(
		string [] pools
	) {
		object [] results = this.Invoke("get_inbound_mode", new object [] {
				pools});
		return ((LocalLBLSNPoolInboundMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_inbound_mode(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_inbound_mode", new object[] {
			pools}, callback, asyncState);
	}
	public LocalLBLSNPoolInboundMode [] Endget_inbound_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBLSNPoolInboundMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
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
	// get_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_log_profile(
		string [] pools
	) {
		object [] results = this.Invoke("get_log_profile", new object [] {
				pools});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_profile(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_profile", new object[] {
			pools}, callback, asyncState);
	}
	public string [] Endget_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_log_publisher(
		string [] pools
	) {
		object [] results = this.Invoke("get_log_publisher", new object [] {
				pools});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_publisher(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_publisher", new object[] {
			pools}, callback, asyncState);
	}
	public string [] Endget_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
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
	// get_nat_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBLSNPoolNATMode [] get_nat_mode(
		string [] pools
	) {
		object [] results = this.Invoke("get_nat_mode", new object [] {
				pools});
		return ((LocalLBLSNPoolNATMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_nat_mode(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nat_mode", new object[] {
			pools}, callback, asyncState);
	}
	public LocalLBLSNPoolNATMode [] Endget_nat_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBLSNPoolNATMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pcp_dslite_tunnel
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_pcp_dslite_tunnel(
		string [] pools
	) {
		object [] results = this.Invoke("get_pcp_dslite_tunnel", new object [] {
				pools});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_pcp_dslite_tunnel(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pcp_dslite_tunnel", new object[] {
			pools}, callback, asyncState);
	}
	public string [] Endget_pcp_dslite_tunnel(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pcp_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_pcp_profile(
		string [] pools
	) {
		object [] results = this.Invoke("get_pcp_profile", new object [] {
				pools});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_pcp_profile(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pcp_profile", new object[] {
			pools}, callback, asyncState);
	}
	public string [] Endget_pcp_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pcp_selfip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_pcp_selfip(
		string [] pools
	) {
		object [] results = this.Invoke("get_pcp_selfip", new object [] {
				pools});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_pcp_selfip(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pcp_selfip", new object[] {
			pools}, callback, asyncState);
	}
	public string [] Endget_pcp_selfip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBLSNPoolPersistMode [] get_persistence_mode(
		string [] pools
	) {
		object [] results = this.Invoke("get_persistence_mode", new object [] {
				pools});
		return ((LocalLBLSNPoolPersistMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_mode(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_mode", new object[] {
			pools}, callback, asyncState);
	}
	public LocalLBLSNPoolPersistMode [] Endget_persistence_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBLSNPoolPersistMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_persistence_timeout(
		string [] pools
	) {
		object [] results = this.Invoke("get_persistence_timeout", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_timeout(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_timeout", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_persistence_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_route_advertisement_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_route_advertisement_state(
		string [] pools
	) {
		object [] results = this.Invoke("get_route_advertisement_state", new object [] {
				pools});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_advertisement_state(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_advertisement_state", new object[] {
			pools}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_route_advertisement_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBLSNPoolLSNPoolStatistics get_statistics(
		string [] pools
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				pools});
		return ((LocalLBLSNPoolLSNPoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			pools}, callback, asyncState);
	}
	public LocalLBLSNPoolLSNPoolStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBLSNPoolLSNPoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBLSNPoolLSNPoolStatistics_v2 get_statistics_v2(
		string [] pools
	) {
		object [] results = this.Invoke("get_statistics_v2", new object [] {
				pools});
		return ((LocalLBLSNPoolLSNPoolStatistics_v2)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics_v2(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics_v2", new object[] {
			pools}, callback, asyncState);
	}
	public LocalLBLSNPoolLSNPoolStatistics_v2 Endget_statistics_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBLSNPoolLSNPoolStatistics_v2)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_translation_port_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] get_translation_port_range(
		string [] pools
	) {
		object [] results = this.Invoke("get_translation_port_range", new object [] {
				pools});
		return ((CommonPortRange [])(results[0]));
	}
	public System.IAsyncResult Beginget_translation_port_range(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_translation_port_range", new object[] {
			pools}, callback, asyncState);
	}
	public CommonPortRange [] Endget_translation_port_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
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
	// get_zombie_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_zombie_timeout(
		string [] pools
	) {
		object [] results = this.Invoke("get_zombie_timeout", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_zombie_timeout(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_zombie_timeout", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_zombie_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_backup_members
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void remove_all_backup_members(
		string [] pools
	) {
		this.Invoke("remove_all_backup_members", new object [] {
				pools});

	}
	public System.IAsyncResult Beginremove_all_backup_members(string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_backup_members", new object[] {
			pools}, callback, asyncState);
	}
	public void Endremove_all_backup_members(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_members
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
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
	// remove_backup_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void remove_backup_member(
		string [] pools,
		string [] [] members
	) {
		this.Invoke("remove_backup_member", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Beginremove_backup_member(string [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_backup_member", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endremove_backup_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
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
	// set_block_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_block_idle_timeout(
		string [] pools,
		long [] timeouts
	) {
		this.Invoke("set_block_idle_timeout", new object [] {
				pools,
				timeouts});

	}
	public System.IAsyncResult Beginset_block_idle_timeout(string [] pools,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_block_idle_timeout", new object[] {
			pools,
			timeouts}, callback, asyncState);
	}
	public void Endset_block_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_block_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_block_lifetime(
		string [] pools,
		long [] values
	) {
		this.Invoke("set_block_lifetime", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_block_lifetime(string [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_block_lifetime", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_block_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_block_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_block_size(
		string [] pools,
		long [] sizes
	) {
		this.Invoke("set_block_size", new object [] {
				pools,
				sizes});

	}
	public System.IAsyncResult Beginset_block_size(string [] pools,long [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_block_size", new object[] {
			pools,
			sizes}, callback, asyncState);
	}
	public void Endset_block_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_client_block_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_client_block_limit(
		string [] pools,
		long [] limits
	) {
		this.Invoke("set_client_block_limit", new object [] {
				pools,
				limits});

	}
	public System.IAsyncResult Beginset_client_block_limit(string [] pools,long [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_client_block_limit", new object[] {
			pools,
			limits}, callback, asyncState);
	}
	public void Endset_client_block_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_connection_limit(
		string [] pools,
		long [] limits
	) {
		this.Invoke("set_connection_limit", new object [] {
				pools,
				limits});

	}
	public System.IAsyncResult Beginset_connection_limit(string [] pools,long [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_limit", new object[] {
			pools,
			limits}, callback, asyncState);
	}
	public void Endset_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
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
	// set_egress_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_egress_interface(
		string [] pools,
		CommonVLANFilterList [] interfaces
	) {
		this.Invoke("set_egress_interface", new object [] {
				pools,
				interfaces});

	}
	public System.IAsyncResult Beginset_egress_interface(string [] pools,CommonVLANFilterList [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_egress_interface", new object[] {
			pools,
			interfaces}, callback, asyncState);
	}
	public void Endset_egress_interface(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_egress_interface_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_egress_interface_state(
		string [] pools,
		CommonEnabledState [] states
	) {
		this.Invoke("set_egress_interface_state", new object [] {
				pools,
				states});

	}
	public System.IAsyncResult Beginset_egress_interface_state(string [] pools,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_egress_interface_state", new object[] {
			pools,
			states}, callback, asyncState);
	}
	public void Endset_egress_interface_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_hairpin_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_hairpin_mode(
		string [] pools,
		LocalLBLSNPoolHairpinMode [] modes
	) {
		this.Invoke("set_hairpin_mode", new object [] {
				pools,
				modes});

	}
	public System.IAsyncResult Beginset_hairpin_mode(string [] pools,LocalLBLSNPoolHairpinMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hairpin_mode", new object[] {
			pools,
			modes}, callback, asyncState);
	}
	public void Endset_hairpin_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_icmp_echo_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_icmp_echo_state(
		string [] pools,
		CommonEnabledState [] states
	) {
		this.Invoke("set_icmp_echo_state", new object [] {
				pools,
				states});

	}
	public System.IAsyncResult Beginset_icmp_echo_state(string [] pools,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_icmp_echo_state", new object[] {
			pools,
			states}, callback, asyncState);
	}
	public void Endset_icmp_echo_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_inbound_connection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_inbound_connection_state(
		string [] pools,
		CommonEnabledState [] states
	) {
		this.Invoke("set_inbound_connection_state", new object [] {
				pools,
				states});

	}
	public System.IAsyncResult Beginset_inbound_connection_state(string [] pools,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_inbound_connection_state", new object[] {
			pools,
			states}, callback, asyncState);
	}
	public void Endset_inbound_connection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_inbound_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_inbound_mode(
		string [] pools,
		LocalLBLSNPoolInboundMode [] modes
	) {
		this.Invoke("set_inbound_mode", new object [] {
				pools,
				modes});

	}
	public System.IAsyncResult Beginset_inbound_mode(string [] pools,LocalLBLSNPoolInboundMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_inbound_mode", new object[] {
			pools,
			modes}, callback, asyncState);
	}
	public void Endset_inbound_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_log_profile(
		string [] pools,
		string [] profiles
	) {
		this.Invoke("set_log_profile", new object [] {
				pools,
				profiles});

	}
	public System.IAsyncResult Beginset_log_profile(string [] pools,string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_profile", new object[] {
			pools,
			profiles}, callback, asyncState);
	}
	public void Endset_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_log_publisher(
		string [] pools,
		string [] publishers
	) {
		this.Invoke("set_log_publisher", new object [] {
				pools,
				publishers});

	}
	public System.IAsyncResult Beginset_log_publisher(string [] pools,string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_publisher", new object[] {
			pools,
			publishers}, callback, asyncState);
	}
	public void Endset_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nat_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_nat_mode(
		string [] pools,
		LocalLBLSNPoolNATMode [] modes
	) {
		this.Invoke("set_nat_mode", new object [] {
				pools,
				modes});

	}
	public System.IAsyncResult Beginset_nat_mode(string [] pools,LocalLBLSNPoolNATMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nat_mode", new object[] {
			pools,
			modes}, callback, asyncState);
	}
	public void Endset_nat_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pcp_dslite_tunnel
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_pcp_dslite_tunnel(
		string [] pools,
		string [] tunnels
	) {
		this.Invoke("set_pcp_dslite_tunnel", new object [] {
				pools,
				tunnels});

	}
	public System.IAsyncResult Beginset_pcp_dslite_tunnel(string [] pools,string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pcp_dslite_tunnel", new object[] {
			pools,
			tunnels}, callback, asyncState);
	}
	public void Endset_pcp_dslite_tunnel(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pcp_full_config
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_pcp_full_config(
		string [] pools,
		string [] profiles,
		string [] self_ips,
		string [] tunnels
	) {
		this.Invoke("set_pcp_full_config", new object [] {
				pools,
				profiles,
				self_ips,
				tunnels});

	}
	public System.IAsyncResult Beginset_pcp_full_config(string [] pools,string [] profiles,string [] self_ips,string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pcp_full_config", new object[] {
			pools,
			profiles,
			self_ips,
			tunnels}, callback, asyncState);
	}
	public void Endset_pcp_full_config(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pcp_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_pcp_profile(
		string [] pools,
		string [] profiles
	) {
		this.Invoke("set_pcp_profile", new object [] {
				pools,
				profiles});

	}
	public System.IAsyncResult Beginset_pcp_profile(string [] pools,string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pcp_profile", new object[] {
			pools,
			profiles}, callback, asyncState);
	}
	public void Endset_pcp_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pcp_selfip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_pcp_selfip(
		string [] pools,
		string [] self_ips
	) {
		this.Invoke("set_pcp_selfip", new object [] {
				pools,
				self_ips});

	}
	public System.IAsyncResult Beginset_pcp_selfip(string [] pools,string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pcp_selfip", new object[] {
			pools,
			self_ips}, callback, asyncState);
	}
	public void Endset_pcp_selfip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_persistence_mode(
		string [] pools,
		LocalLBLSNPoolPersistMode [] modes
	) {
		this.Invoke("set_persistence_mode", new object [] {
				pools,
				modes});

	}
	public System.IAsyncResult Beginset_persistence_mode(string [] pools,LocalLBLSNPoolPersistMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_mode", new object[] {
			pools,
			modes}, callback, asyncState);
	}
	public void Endset_persistence_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_persistence_timeout(
		string [] pools,
		long [] timeouts
	) {
		this.Invoke("set_persistence_timeout", new object [] {
				pools,
				timeouts});

	}
	public System.IAsyncResult Beginset_persistence_timeout(string [] pools,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_timeout", new object[] {
			pools,
			timeouts}, callback, asyncState);
	}
	public void Endset_persistence_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_route_advertisement_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_route_advertisement_state(
		string [] pools,
		CommonEnabledState [] states
	) {
		this.Invoke("set_route_advertisement_state", new object [] {
				pools,
				states});

	}
	public System.IAsyncResult Beginset_route_advertisement_state(string [] pools,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_route_advertisement_state", new object[] {
			pools,
			states}, callback, asyncState);
	}
	public void Endset_route_advertisement_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_translation_port_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_translation_port_range(
		string [] pools,
		CommonPortRange [] ranges
	) {
		this.Invoke("set_translation_port_range", new object [] {
				pools,
				ranges});

	}
	public System.IAsyncResult Beginset_translation_port_range(string [] pools,CommonPortRange [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_translation_port_range", new object[] {
			pools,
			ranges}, callback, asyncState);
	}
	public void Endset_translation_port_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_zombie_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/LSNPool", 
		RequestNamespace="urn:iControl:LocalLB/LSNPool", ResponseNamespace="urn:iControl:LocalLB/LSNPool")]
	public void set_zombie_timeout(
		string [] pools,
		long [] timeouts
	) {
		this.Invoke("set_zombie_timeout", new object [] {
				pools,
				timeouts});

	}
	public System.IAsyncResult Beginset_zombie_timeout(string [] pools,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_zombie_timeout", new object[] {
			pools,
			timeouts}, callback, asyncState);
	}
	public void Endset_zombie_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LSNPool.HairpinMode", Namespace = "urn:iControl")]
	public enum LocalLBLSNPoolHairpinMode
	{
		LSN_HAIRPIN_MODE_UNKNOWN,
		LSN_HAIRPIN_MODE_DISABLED,
		LSN_HAIRPIN_MODE_ENABLED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LSNPool.InboundMode", Namespace = "urn:iControl")]
	public enum LocalLBLSNPoolInboundMode
	{
		LSN_INBOUND_MODE_UNKNOWN,
		LSN_INBOUND_MODE_DISABLED,
		LSN_INBOUND_MODE_EXPLICIT,
		LSN_INBOUND_MODE_AUTOMATIC,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LSNPool.NATMode", Namespace = "urn:iControl")]
	public enum LocalLBLSNPoolNATMode
	{
		LSN_MODE_UNKNOWN,
		LSN_MODE_NAPT,
		LSN_MODE_DETERMINISTIC,
		LSN_MODE_PBA,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LSNPool.PersistMode", Namespace = "urn:iControl")]
	public enum LocalLBLSNPoolPersistMode
	{
		LSN_PERSIST_MODE_UNKNOWN,
		LSN_PERSIST_MODE_NONE,
		LSN_PERSIST_MODE_ADDRESS,
		LSN_PERSIST_MODE_ADDRESS_PORT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LSNPool.LSNPoolFailureStatistic", Namespace = "urn:iControl")]
	public partial class LocalLBLSNPoolLSNPoolFailureStatistic
	{
		private string failure_causeField;
		public string failure_cause
		{
			get { return this.failure_causeField; }
			set { this.failure_causeField = value; }
		}
		private CommonULong64 failure_countField;
		public CommonULong64 failure_count
		{
			get { return this.failure_countField; }
			set { this.failure_countField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LSNPool.LSNPoolStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBLSNPoolLSNPoolStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LSNPool.LSNPoolStatisticEntry_v2", Namespace = "urn:iControl")]
	public partial class LocalLBLSNPoolLSNPoolStatisticEntry_v2
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
		private LocalLBLSNPoolLSNPoolFailureStatistic [] failuresField;
		public LocalLBLSNPoolLSNPoolFailureStatistic [] failures
		{
			get { return this.failuresField; }
			set { this.failuresField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LSNPool.LSNPoolStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBLSNPoolLSNPoolStatistics
	{
		private LocalLBLSNPoolLSNPoolStatisticEntry [] statisticsField;
		public LocalLBLSNPoolLSNPoolStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LSNPool.LSNPoolStatistics_v2", Namespace = "urn:iControl")]
	public partial class LocalLBLSNPoolLSNPoolStatistics_v2
	{
		private LocalLBLSNPoolLSNPoolStatisticEntry_v2 [] statisticsField;
		public LocalLBLSNPoolLSNPoolStatisticEntry_v2 [] statistics
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
