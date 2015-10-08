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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.DNSExpressBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBDNSExpressDNSExpressStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBDNSExpressDNSExpressZoneDBStatistics))]
	public partial class LocalLBDNSExpress : iControlInterface {
		public LocalLBDNSExpress() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	public void create(
		string [] zones,
		string [] targets
	) {
		this.Invoke("create", new object [] {
				zones,
				targets});

	}
	public System.IAsyncResult Begincreate(string [] zones,string [] targets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			zones,
			targets}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_tsig_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	public void create_tsig_key(
		string [] keys,
		LocalLBDNSExpressTSIGKeyAlgorithm [] algorithms,
		string [] secrets
	) {
		this.Invoke("create_tsig_key", new object [] {
				keys,
				algorithms,
				secrets});

	}
	public System.IAsyncResult Begincreate_tsig_key(string [] keys,LocalLBDNSExpressTSIGKeyAlgorithm [] algorithms,string [] secrets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_tsig_key", new object[] {
			keys,
			algorithms,
			secrets}, callback, asyncState);
	}
	public void Endcreate_tsig_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_tsig_keys
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	public void delete_all_tsig_keys(

	) {
		this.Invoke("delete_all_tsig_keys", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_tsig_keys(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_tsig_keys", new object[0], callback, asyncState);
	}
	public void Enddelete_all_tsig_keys(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_zones
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
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
	// delete_tsig_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	public void delete_tsig_key(
		string [] keys
	) {
		this.Invoke("delete_tsig_key", new object [] {
				keys});

	}
	public System.IAsyncResult Begindelete_tsig_key(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_tsig_key", new object[] {
			keys}, callback, asyncState);
	}
	public void Enddelete_tsig_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSExpressDNSExpressStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBDNSExpressDNSExpressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBDNSExpressDNSExpressStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSExpressDNSExpressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
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
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
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
	// get_notify_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSExpressNOTIFYAction [] get_notify_action(
		string [] zones
	) {
		object [] results = this.Invoke("get_notify_action", new object [] {
				zones});
		return ((LocalLBDNSExpressNOTIFYAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_notify_action(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_notify_action", new object[] {
			zones}, callback, asyncState);
	}
	public LocalLBDNSExpressNOTIFYAction [] Endget_notify_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSExpressNOTIFYAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
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
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSExpressDNSExpressStatistics get_statistics(
		string [] zones
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				zones});
		return ((LocalLBDNSExpressDNSExpressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			zones}, callback, asyncState);
	}
	public LocalLBDNSExpressDNSExpressStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSExpressDNSExpressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transfer_target
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_transfer_target(
		string [] zones
	) {
		object [] results = this.Invoke("get_transfer_target", new object [] {
				zones});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_transfer_target(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transfer_target", new object[] {
			zones}, callback, asyncState);
	}
	public string [] Endget_transfer_target(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tsig_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_tsig_key(
		string [] zones
	) {
		object [] results = this.Invoke("get_tsig_key", new object [] {
				zones});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_tsig_key(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tsig_key", new object[] {
			zones}, callback, asyncState);
	}
	public string [] Endget_tsig_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tsig_key_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSExpressTSIGKeyAlgorithm [] get_tsig_key_algorithm(
		string [] keys
	) {
		object [] results = this.Invoke("get_tsig_key_algorithm", new object [] {
				keys});
		return ((LocalLBDNSExpressTSIGKeyAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_tsig_key_algorithm(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tsig_key_algorithm", new object[] {
			keys}, callback, asyncState);
	}
	public LocalLBDNSExpressTSIGKeyAlgorithm [] Endget_tsig_key_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSExpressTSIGKeyAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tsig_key_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_tsig_key_list(

	) {
		object [] results = this.Invoke("get_tsig_key_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_tsig_key_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tsig_key_list", new object[0], callback, asyncState);
	}
	public string [] Endget_tsig_key_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tsig_key_secret
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_tsig_key_secret(
		string [] keys
	) {
		object [] results = this.Invoke("get_tsig_key_secret", new object [] {
				keys});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_tsig_key_secret(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tsig_key_secret", new object[] {
			keys}, callback, asyncState);
	}
	public string [] Endget_tsig_key_secret(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_verify_notify_tsig_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_verify_notify_tsig_state(
		string [] zones
	) {
		object [] results = this.Invoke("get_verify_notify_tsig_state", new object [] {
				zones});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_verify_notify_tsig_state(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_verify_notify_tsig_state", new object[] {
			zones}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_verify_notify_tsig_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
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
	// get_zone_db_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSExpressDNSExpressZoneDBStatistics get_zone_db_statistics(
		string [] zones,
		long [] sizes
	) {
		object [] results = this.Invoke("get_zone_db_statistics", new object [] {
				zones,
				sizes});
		return ((LocalLBDNSExpressDNSExpressZoneDBStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_zone_db_statistics(string [] zones,long [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_zone_db_statistics", new object[] {
			zones,
			sizes}, callback, asyncState);
	}
	public LocalLBDNSExpressDNSExpressZoneDBStatistics Endget_zone_db_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSExpressDNSExpressZoneDBStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
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
	// set_notify_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	public void set_notify_action(
		string [] zones,
		LocalLBDNSExpressNOTIFYAction [] actions
	) {
		this.Invoke("set_notify_action", new object [] {
				zones,
				actions});

	}
	public System.IAsyncResult Beginset_notify_action(string [] zones,LocalLBDNSExpressNOTIFYAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_notify_action", new object[] {
			zones,
			actions}, callback, asyncState);
	}
	public void Endset_notify_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_transfer_target
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	public void set_transfer_target(
		string [] zones,
		string [] targets
	) {
		this.Invoke("set_transfer_target", new object [] {
				zones,
				targets});

	}
	public System.IAsyncResult Beginset_transfer_target(string [] zones,string [] targets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_transfer_target", new object[] {
			zones,
			targets}, callback, asyncState);
	}
	public void Endset_transfer_target(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tsig_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	public void set_tsig_key(
		string [] zones,
		string [] keys
	) {
		this.Invoke("set_tsig_key", new object [] {
				zones,
				keys});

	}
	public System.IAsyncResult Beginset_tsig_key(string [] zones,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tsig_key", new object[] {
			zones,
			keys}, callback, asyncState);
	}
	public void Endset_tsig_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tsig_key_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	public void set_tsig_key_algorithm(
		string [] keys,
		LocalLBDNSExpressTSIGKeyAlgorithm [] algorithms
	) {
		this.Invoke("set_tsig_key_algorithm", new object [] {
				keys,
				algorithms});

	}
	public System.IAsyncResult Beginset_tsig_key_algorithm(string [] keys,LocalLBDNSExpressTSIGKeyAlgorithm [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tsig_key_algorithm", new object[] {
			keys,
			algorithms}, callback, asyncState);
	}
	public void Endset_tsig_key_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tsig_key_secret
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	public void set_tsig_key_secret(
		string [] keys,
		string [] secrets
	) {
		this.Invoke("set_tsig_key_secret", new object [] {
				keys,
				secrets});

	}
	public System.IAsyncResult Beginset_tsig_key_secret(string [] keys,string [] secrets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tsig_key_secret", new object[] {
			keys,
			secrets}, callback, asyncState);
	}
	public void Endset_tsig_key_secret(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_verify_notify_tsig_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSExpress", 
		RequestNamespace="urn:iControl:LocalLB/DNSExpress", ResponseNamespace="urn:iControl:LocalLB/DNSExpress")]
	public void set_verify_notify_tsig_state(
		string [] zones,
		CommonEnabledState [] states
	) {
		this.Invoke("set_verify_notify_tsig_state", new object [] {
				zones,
				states});

	}
	public System.IAsyncResult Beginset_verify_notify_tsig_state(string [] zones,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_verify_notify_tsig_state", new object[] {
			zones,
			states}, callback, asyncState);
	}
	public void Endset_verify_notify_tsig_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSExpress.NOTIFYAction", Namespace = "urn:iControl")]
	public enum LocalLBDNSExpressNOTIFYAction
	{
		DNS_EXPRESS_NOTIFY_ACTION_UNKNOWN,
		DNS_EXPRESS_NOTIFY_ACTION_CONSUME,
		DNS_EXPRESS_NOTIFY_ACTION_BYPASS,
		DNS_EXPRESS_NOTIFY_ACTION_REPEAT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSExpress.TSIGKeyAlgorithm", Namespace = "urn:iControl")]
	public enum LocalLBDNSExpressTSIGKeyAlgorithm
	{
		KEY_ALGORITHM_UNKNOWN,
		KEY_ALGORITHM_HMACMD5,
		KEY_ALGORITHM_HMACSHA1,
		KEY_ALGORITHM_HMACSHA256,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSExpress.DNSExpressStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBDNSExpressDNSExpressStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSExpress.DNSExpressStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBDNSExpressDNSExpressStatistics
	{
		private LocalLBDNSExpressDNSExpressStatisticEntry [] statisticsField;
		public LocalLBDNSExpressDNSExpressStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSExpress.DNSExpressZoneDBEntry", Namespace = "urn:iControl")]
	public partial class LocalLBDNSExpressDNSExpressZoneDBEntry
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private CommonULong64 valueField;
		public CommonULong64 value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSExpress.DNSExpressZoneDBStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBDNSExpressDNSExpressZoneDBStatisticEntry
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
		private LocalLBDNSExpressDNSExpressZoneDBEntry [] entriesField;
		public LocalLBDNSExpressDNSExpressZoneDBEntry [] entries
		{
			get { return this.entriesField; }
			set { this.entriesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSExpress.DNSExpressZoneDBStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBDNSExpressDNSExpressZoneDBStatistics
	{
		private LocalLBDNSExpressDNSExpressZoneDBStatisticEntry [] statisticsField;
		public LocalLBDNSExpressDNSExpressZoneDBStatisticEntry [] statistics
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
