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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.DNSGlobalsBinding", Namespace="urn:iControl")]
	public partial class LocalLBDNSGlobals : iControlInterface {
		public LocalLBDNSGlobals() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_cache_edns_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_cache_edns_buffer_size(

	) {
		object [] results = this.Invoke("get_cache_edns_buffer_size", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_cache_edns_buffer_size(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_edns_buffer_size", new object[0], callback, asyncState);
	}
	public long Endget_cache_edns_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_maximum_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_cache_maximum_ttl(

	) {
		object [] results = this.Invoke("get_cache_maximum_ttl", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_cache_maximum_ttl(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_maximum_ttl", new object[0], callback, asyncState);
	}
	public long Endget_cache_maximum_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_minimum_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_cache_minimum_ttl(

	) {
		object [] results = this.Invoke("get_cache_minimum_ttl", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_cache_minimum_ttl(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_minimum_ttl", new object[0], callback, asyncState);
	}
	public long Endget_cache_minimum_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_client_ips_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_collect_client_ips_state(

	) {
		object [] results = this.Invoke("get_collect_client_ips_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_collect_client_ips_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_client_ips_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_collect_client_ips_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_query_names_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_collect_query_names_state(

	) {
		object [] results = this.Invoke("get_collect_query_names_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_collect_query_names_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_query_names_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_collect_query_names_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
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
	// set_cache_edns_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
	public void set_cache_edns_buffer_size(
		long value
	) {
		this.Invoke("set_cache_edns_buffer_size", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_cache_edns_buffer_size(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_edns_buffer_size", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_cache_edns_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_maximum_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
	public void set_cache_maximum_ttl(
		long value
	) {
		this.Invoke("set_cache_maximum_ttl", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_cache_maximum_ttl(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_maximum_ttl", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_cache_maximum_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_minimum_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
	public void set_cache_minimum_ttl(
		long value
	) {
		this.Invoke("set_cache_minimum_ttl", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_cache_minimum_ttl(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_minimum_ttl", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_cache_minimum_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_client_ips_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
	public void set_collect_client_ips_state(
		CommonEnabledState state
	) {
		this.Invoke("set_collect_client_ips_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_collect_client_ips_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_client_ips_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_collect_client_ips_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_query_names_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSGlobals", 
		RequestNamespace="urn:iControl:LocalLB/DNSGlobals", ResponseNamespace="urn:iControl:LocalLB/DNSGlobals")]
	public void set_collect_query_names_state(
		CommonEnabledState state
	) {
		this.Invoke("set_collect_query_names_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_collect_query_names_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_query_names_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_collect_query_names_state(System.IAsyncResult asyncResult) {
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
