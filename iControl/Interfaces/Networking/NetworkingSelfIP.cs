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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.SelfIPBinding", Namespace="urn:iControl")]
	public partial class NetworkingSelfIP : iControlInterface {
		public NetworkingSelfIP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	public void create(
		string [] self_ips,
		string [] vlan_names,
		string [] netmasks,
		long [] unit_ids,
		CommonEnabledState [] floating_states
	) {
		this.Invoke("create", new object [] {
				self_ips,
				vlan_names,
				netmasks,
				unit_ids,
				floating_states});

	}
	public System.IAsyncResult Begincreate(string [] self_ips,string [] vlan_names,string [] netmasks,long [] unit_ids,CommonEnabledState [] floating_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			self_ips,
			vlan_names,
			netmasks,
			unit_ids,
			floating_states}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_self_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	public void delete_all_self_ips(

	) {
		this.Invoke("delete_all_self_ips", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_self_ips(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_self_ips", new object[0], callback, asyncState);
	}
	public void Enddelete_all_self_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_self_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	public void delete_self_ip(
		string [] self_ips
	) {
		this.Invoke("delete_self_ip", new object [] {
				self_ips});

	}
	public System.IAsyncResult Begindelete_self_ip(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_self_ip", new object[] {
			self_ips}, callback, asyncState);
	}
	public void Enddelete_self_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_floating_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_floating_state(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_floating_state", new object [] {
				self_ips});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_floating_state(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_floating_state", new object[] {
			self_ips}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_floating_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
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
	// get_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_netmask(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_netmask", new object [] {
				self_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_netmask(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_netmask", new object[] {
			self_ips}, callback, asyncState);
	}
	public string [] Endget_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_unit_id(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_unit_id", new object [] {
				self_ips});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_unit_id(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unit_id", new object[] {
			self_ips}, callback, asyncState);
	}
	public long [] Endget_unit_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_vlan(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				self_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			self_ips}, callback, asyncState);
	}
	public string [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_floating_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	public void set_floating_state(
		string [] self_ips,
		CommonEnabledState [] states
	) {
		this.Invoke("set_floating_state", new object [] {
				self_ips,
				states});

	}
	public System.IAsyncResult Beginset_floating_state(string [] self_ips,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_floating_state", new object[] {
			self_ips,
			states}, callback, asyncState);
	}
	public void Endset_floating_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	public void set_netmask(
		string [] self_ips,
		string [] netmasks
	) {
		this.Invoke("set_netmask", new object [] {
				self_ips,
				netmasks});

	}
	public System.IAsyncResult Beginset_netmask(string [] self_ips,string [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_netmask", new object[] {
			self_ips,
			netmasks}, callback, asyncState);
	}
	public void Endset_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	public void set_unit_id(
		string [] self_ips,
		long [] unit_ids
	) {
		this.Invoke("set_unit_id", new object [] {
				self_ips,
				unit_ids});

	}
	public System.IAsyncResult Beginset_unit_id(string [] self_ips,long [] unit_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unit_id", new object[] {
			self_ips,
			unit_ids}, callback, asyncState);
	}
	public void Endset_unit_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIP", 
		RequestNamespace="urn:iControl:Networking/SelfIP", ResponseNamespace="urn:iControl:Networking/SelfIP")]
	public void set_vlan(
		string [] self_ips,
		string [] vlan_names
	) {
		this.Invoke("set_vlan", new object [] {
				self_ips,
				vlan_names});

	}
	public System.IAsyncResult Beginset_vlan(string [] self_ips,string [] vlan_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan", new object[] {
			self_ips,
			vlan_names}, callback, asyncState);
	}
	public void Endset_vlan(System.IAsyncResult asyncResult) {
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
