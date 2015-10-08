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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.RouteDomainBinding", Namespace="urn:iControl")]
	public partial class NetworkingRouteDomain : iControlInterface {
		public NetworkingRouteDomain() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	public void add_vlan(
		long [] route_domains,
		string [] [] vlans
	) {
		this.Invoke("add_vlan", new object [] {
				route_domains,
				vlans});

	}
	public System.IAsyncResult Beginadd_vlan(long [] route_domains,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_vlan", new object[] {
			route_domains,
			vlans}, callback, asyncState);
	}
	public void Endadd_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	public void create(
		long [] route_domains,
		string [] [] vlans
	) {
		this.Invoke("create", new object [] {
				route_domains,
				vlans});

	}
	public System.IAsyncResult Begincreate(long [] route_domains,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			route_domains,
			vlans}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_route_domains
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	public void delete_all_route_domains(

	) {
		this.Invoke("delete_all_route_domains", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_route_domains(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_route_domains", new object[0], callback, asyncState);
	}
	public void Enddelete_all_route_domains(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	public void delete_route_domain(
		long [] route_domains
	) {
		this.Invoke("delete_route_domain", new object [] {
				route_domains});

	}
	public System.IAsyncResult Begindelete_route_domain(long [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_route_domain", new object[] {
			route_domains}, callback, asyncState);
	}
	public void Enddelete_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		long [] route_domains
	) {
		object [] results = this.Invoke("get_description", new object [] {
				route_domains});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(long [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			route_domains}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public long [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_parent_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_parent_id(
		long [] route_domains
	) {
		object [] results = this.Invoke("get_parent_id", new object [] {
				route_domains});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_parent_id(long [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_parent_id", new object[] {
			route_domains}, callback, asyncState);
	}
	public long [] Endget_parent_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_strict_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_strict_state(
		long [] route_domains
	) {
		object [] results = this.Invoke("get_strict_state", new object [] {
				route_domains});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_strict_state(long [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_strict_state", new object[] {
			route_domains}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_strict_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
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
	// get_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_vlan(
		long [] route_domains
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				route_domains});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(long [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			route_domains}, callback, asyncState);
	}
	public string [] [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_vlans
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	public void remove_all_vlans(
		long [] route_domains
	) {
		this.Invoke("remove_all_vlans", new object [] {
				route_domains});

	}
	public System.IAsyncResult Beginremove_all_vlans(long [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_vlans", new object[] {
			route_domains}, callback, asyncState);
	}
	public void Endremove_all_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	public void remove_vlan(
		long [] route_domains,
		string [] [] vlans
	) {
		this.Invoke("remove_vlan", new object [] {
				route_domains,
				vlans});

	}
	public System.IAsyncResult Beginremove_vlan(long [] route_domains,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_vlan", new object[] {
			route_domains,
			vlans}, callback, asyncState);
	}
	public void Endremove_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	public void set_description(
		long [] route_domains,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				route_domains,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(long [] route_domains,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			route_domains,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_parent_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	public void set_parent_id(
		long [] route_domains,
		long [] parent_ids
	) {
		this.Invoke("set_parent_id", new object [] {
				route_domains,
				parent_ids});

	}
	public System.IAsyncResult Beginset_parent_id(long [] route_domains,long [] parent_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_parent_id", new object[] {
			route_domains,
			parent_ids}, callback, asyncState);
	}
	public void Endset_parent_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_strict_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomain", 
		RequestNamespace="urn:iControl:Networking/RouteDomain", ResponseNamespace="urn:iControl:Networking/RouteDomain")]
	public void set_strict_state(
		long [] route_domains,
		CommonEnabledState [] states
	) {
		this.Invoke("set_strict_state", new object [] {
				route_domains,
				states});

	}
	public System.IAsyncResult Beginset_strict_state(long [] route_domains,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_strict_state", new object[] {
			route_domains,
			states}, callback, asyncState);
	}
	public void Endset_strict_state(System.IAsyncResult asyncResult) {
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
