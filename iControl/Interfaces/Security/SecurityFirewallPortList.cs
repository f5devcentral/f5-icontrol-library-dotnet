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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.FirewallPortListBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonPortRange))]
	public partial class SecurityFirewallPortList : iControlInterface {
		public SecurityFirewallPortList() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_nested_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void add_nested_port_list(
		string [] lists,
		string [] [] nested_lists
	) {
		this.Invoke("add_nested_port_list", new object [] {
				lists,
				nested_lists});

	}
	public System.IAsyncResult Beginadd_nested_port_list(string [] lists,string [] [] nested_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_nested_port_list", new object[] {
			lists,
			nested_lists}, callback, asyncState);
	}
	public void Endadd_nested_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void add_port(
		string [] lists,
		CommonPortRange [] [] ports
	) {
		this.Invoke("add_port", new object [] {
				lists,
				ports});

	}
	public System.IAsyncResult Beginadd_port(string [] lists,CommonPortRange [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_port", new object[] {
			lists,
			ports}, callback, asyncState);
	}
	public void Endadd_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void create(
		string [] lists,
		CommonPortRange [] [] ports
	) {
		this.Invoke("create", new object [] {
				lists,
				ports});

	}
	public System.IAsyncResult Begincreate(string [] lists,CommonPortRange [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			lists,
			ports}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_with_nested_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void create_with_nested_port_list(
		string [] lists,
		string [] [] nested_lists
	) {
		this.Invoke("create_with_nested_port_list", new object [] {
				lists,
				nested_lists});

	}
	public System.IAsyncResult Begincreate_with_nested_port_list(string [] lists,string [] [] nested_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_with_nested_port_list", new object[] {
			lists,
			nested_lists}, callback, asyncState);
	}
	public void Endcreate_with_nested_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void delete_all_port_lists(

	) {
		this.Invoke("delete_all_port_lists", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_port_lists(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_port_lists", new object[0], callback, asyncState);
	}
	public void Enddelete_all_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void delete_port_list(
		string [] lists
	) {
		this.Invoke("delete_port_list", new object [] {
				lists});

	}
	public System.IAsyncResult Begindelete_port_list(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_port_list", new object[] {
			lists}, callback, asyncState);
	}
	public void Enddelete_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] lists
	) {
		object [] results = this.Invoke("get_description", new object [] {
				lists});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			lists}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
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
	// get_nested_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_nested_port_list(
		string [] lists
	) {
		object [] results = this.Invoke("get_nested_port_list", new object [] {
				lists});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_nested_port_list(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nested_port_list", new object[] {
			lists}, callback, asyncState);
	}
	public string [] [] Endget_nested_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nested_port_list_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_nested_port_list_description(
		string [] lists,
		string [] [] nested_lists
	) {
		object [] results = this.Invoke("get_nested_port_list_description", new object [] {
				lists,
				nested_lists});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_nested_port_list_description(string [] lists,string [] [] nested_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nested_port_list_description", new object[] {
			lists,
			nested_lists}, callback, asyncState);
	}
	public string [] [] Endget_nested_port_list_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] get_port(
		string [] lists
	) {
		object [] results = this.Invoke("get_port", new object [] {
				lists});
		return ((CommonPortRange [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_port(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_port", new object[] {
			lists}, callback, asyncState);
	}
	public CommonPortRange [] [] Endget_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_port_description(
		string [] lists,
		CommonPortRange [] [] ports
	) {
		object [] results = this.Invoke("get_port_description", new object [] {
				lists,
				ports});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_port_description(string [] lists,CommonPortRange [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_port_description", new object[] {
			lists,
			ports}, callback, asyncState);
	}
	public string [] [] Endget_port_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
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
	// remove_all_nested_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void remove_all_nested_port_lists(
		string [] lists
	) {
		this.Invoke("remove_all_nested_port_lists", new object [] {
				lists});

	}
	public System.IAsyncResult Beginremove_all_nested_port_lists(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_nested_port_lists", new object[] {
			lists}, callback, asyncState);
	}
	public void Endremove_all_nested_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void remove_all_ports(
		string [] lists
	) {
		this.Invoke("remove_all_ports", new object [] {
				lists});

	}
	public System.IAsyncResult Beginremove_all_ports(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_ports", new object[] {
			lists}, callback, asyncState);
	}
	public void Endremove_all_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_nested_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void remove_nested_port_list(
		string [] lists,
		string [] [] nested_lists
	) {
		this.Invoke("remove_nested_port_list", new object [] {
				lists,
				nested_lists});

	}
	public System.IAsyncResult Beginremove_nested_port_list(string [] lists,string [] [] nested_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_nested_port_list", new object[] {
			lists,
			nested_lists}, callback, asyncState);
	}
	public void Endremove_nested_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void remove_port(
		string [] lists,
		CommonPortRange [] [] ports
	) {
		this.Invoke("remove_port", new object [] {
				lists,
				ports});

	}
	public System.IAsyncResult Beginremove_port(string [] lists,CommonPortRange [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_port", new object[] {
			lists,
			ports}, callback, asyncState);
	}
	public void Endremove_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void set_description(
		string [] lists,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				lists,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] lists,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			lists,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nested_port_list_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void set_nested_port_list_description(
		string [] lists,
		string [] [] nested_lists,
		string [] [] descriptions
	) {
		this.Invoke("set_nested_port_list_description", new object [] {
				lists,
				nested_lists,
				descriptions});

	}
	public System.IAsyncResult Beginset_nested_port_list_description(string [] lists,string [] [] nested_lists,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nested_port_list_description", new object[] {
			lists,
			nested_lists,
			descriptions}, callback, asyncState);
	}
	public void Endset_nested_port_list_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPortList", 
		RequestNamespace="urn:iControl:Security/FirewallPortList", ResponseNamespace="urn:iControl:Security/FirewallPortList")]
	public void set_port_description(
		string [] lists,
		CommonPortRange [] [] ports,
		string [] [] descriptions
	) {
		this.Invoke("set_port_description", new object [] {
				lists,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_port_description(string [] lists,CommonPortRange [] [] ports,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_port_description", new object[] {
			lists,
			ports,
			descriptions}, callback, asyncState);
	}
	public void Endset_port_description(System.IAsyncResult asyncResult) {
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
