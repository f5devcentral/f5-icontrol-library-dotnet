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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.DoSWhitelistBinding", Namespace="urn:iControl")]
	public partial class SecurityDoSWhitelist : iControlInterface {
		public SecurityDoSWhitelist() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	public void add_entry(
		string [] whitelists,
		string [] [] entries
	) {
		this.Invoke("add_entry", new object [] {
				whitelists,
				entries});

	}
	public System.IAsyncResult Beginadd_entry(string [] whitelists,string [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_entry", new object[] {
			whitelists,
			entries}, callback, asyncState);
	}
	public void Endadd_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] whitelists
	) {
		object [] results = this.Invoke("get_description", new object [] {
				whitelists});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] whitelists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			whitelists}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_entry(
		string [] whitelists
	) {
		object [] results = this.Invoke("get_entry", new object [] {
				whitelists});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry(string [] whitelists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry", new object[] {
			whitelists}, callback, asyncState);
	}
	public string [] [] Endget_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_entry_description(
		string [] whitelists,
		string [] [] entries
	) {
		object [] results = this.Invoke("get_entry_description", new object [] {
				whitelists,
				entries});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_description(string [] whitelists,string [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_description", new object[] {
			whitelists,
			entries}, callback, asyncState);
	}
	public string [] [] Endget_entry_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_entry_destination_address(
		string [] whitelists,
		string [] [] entries
	) {
		object [] results = this.Invoke("get_entry_destination_address", new object [] {
				whitelists,
				entries});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_destination_address(string [] whitelists,string [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_destination_address", new object[] {
			whitelists,
			entries}, callback, asyncState);
	}
	public string [] [] Endget_entry_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_entry_destination_port(
		string [] whitelists,
		string [] [] entries
	) {
		object [] results = this.Invoke("get_entry_destination_port", new object [] {
				whitelists,
				entries});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_destination_port(string [] whitelists,string [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_destination_port", new object[] {
			whitelists,
			entries}, callback, asyncState);
	}
	public long [] [] Endget_entry_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_protocol_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityDoSWhitelistProtocolType [] [] get_entry_protocol_type(
		string [] whitelists,
		string [] [] entries
	) {
		object [] results = this.Invoke("get_entry_protocol_type", new object [] {
				whitelists,
				entries});
		return ((SecurityDoSWhitelistProtocolType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_protocol_type(string [] whitelists,string [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_protocol_type", new object[] {
			whitelists,
			entries}, callback, asyncState);
	}
	public SecurityDoSWhitelistProtocolType [] [] Endget_entry_protocol_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityDoSWhitelistProtocolType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_entry_source_address(
		string [] whitelists,
		string [] [] entries
	) {
		object [] results = this.Invoke("get_entry_source_address", new object [] {
				whitelists,
				entries});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_source_address(string [] whitelists,string [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_source_address", new object[] {
			whitelists,
			entries}, callback, asyncState);
	}
	public string [] [] Endget_entry_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_entry_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_entry_source_vlan(
		string [] whitelists,
		string [] [] entries
	) {
		object [] results = this.Invoke("get_entry_source_vlan", new object [] {
				whitelists,
				entries});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_entry_source_vlan(string [] whitelists,string [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_entry_source_vlan", new object[] {
			whitelists,
			entries}, callback, asyncState);
	}
	public string [] [] Endget_entry_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
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
	// remove_all_entries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	public void remove_all_entries(
		string [] whitelists
	) {
		this.Invoke("remove_all_entries", new object [] {
				whitelists});

	}
	public System.IAsyncResult Beginremove_all_entries(string [] whitelists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_entries", new object[] {
			whitelists}, callback, asyncState);
	}
	public void Endremove_all_entries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	public void remove_entry(
		string [] whitelists,
		string [] [] entries
	) {
		this.Invoke("remove_entry", new object [] {
				whitelists,
				entries});

	}
	public System.IAsyncResult Beginremove_entry(string [] whitelists,string [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_entry", new object[] {
			whitelists,
			entries}, callback, asyncState);
	}
	public void Endremove_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	public void set_description(
		string [] whitelists,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				whitelists,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] whitelists,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			whitelists,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_entry_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	public void set_entry_description(
		string [] whitelists,
		string [] [] entries,
		string [] [] descriptions
	) {
		this.Invoke("set_entry_description", new object [] {
				whitelists,
				entries,
				descriptions});

	}
	public System.IAsyncResult Beginset_entry_description(string [] whitelists,string [] [] entries,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_entry_description", new object[] {
			whitelists,
			entries,
			descriptions}, callback, asyncState);
	}
	public void Endset_entry_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_entry_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	public void set_entry_destination_address(
		string [] whitelists,
		string [] [] entries,
		string [] [] addresses
	) {
		this.Invoke("set_entry_destination_address", new object [] {
				whitelists,
				entries,
				addresses});

	}
	public System.IAsyncResult Beginset_entry_destination_address(string [] whitelists,string [] [] entries,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_entry_destination_address", new object[] {
			whitelists,
			entries,
			addresses}, callback, asyncState);
	}
	public void Endset_entry_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_entry_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	public void set_entry_destination_port(
		string [] whitelists,
		string [] [] entries,
		long [] [] ports
	) {
		this.Invoke("set_entry_destination_port", new object [] {
				whitelists,
				entries,
				ports});

	}
	public System.IAsyncResult Beginset_entry_destination_port(string [] whitelists,string [] [] entries,long [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_entry_destination_port", new object[] {
			whitelists,
			entries,
			ports}, callback, asyncState);
	}
	public void Endset_entry_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_entry_protocol_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	public void set_entry_protocol_type(
		string [] whitelists,
		string [] [] entries,
		SecurityDoSWhitelistProtocolType [] [] types
	) {
		this.Invoke("set_entry_protocol_type", new object [] {
				whitelists,
				entries,
				types});

	}
	public System.IAsyncResult Beginset_entry_protocol_type(string [] whitelists,string [] [] entries,SecurityDoSWhitelistProtocolType [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_entry_protocol_type", new object[] {
			whitelists,
			entries,
			types}, callback, asyncState);
	}
	public void Endset_entry_protocol_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_entry_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	public void set_entry_source_address(
		string [] whitelists,
		string [] [] entries,
		string [] [] addresses
	) {
		this.Invoke("set_entry_source_address", new object [] {
				whitelists,
				entries,
				addresses});

	}
	public System.IAsyncResult Beginset_entry_source_address(string [] whitelists,string [] [] entries,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_entry_source_address", new object[] {
			whitelists,
			entries,
			addresses}, callback, asyncState);
	}
	public void Endset_entry_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_entry_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSWhitelist", 
		RequestNamespace="urn:iControl:Security/DoSWhitelist", ResponseNamespace="urn:iControl:Security/DoSWhitelist")]
	public void set_entry_source_vlan(
		string [] whitelists,
		string [] [] entries,
		string [] [] vlans
	) {
		this.Invoke("set_entry_source_vlan", new object [] {
				whitelists,
				entries,
				vlans});

	}
	public System.IAsyncResult Beginset_entry_source_vlan(string [] whitelists,string [] [] entries,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_entry_source_vlan", new object[] {
			whitelists,
			entries,
			vlans}, callback, asyncState);
	}
	public void Endset_entry_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.DoSWhitelist.ProtocolType", Namespace = "urn:iControl")]
	public enum SecurityDoSWhitelistProtocolType
	{
		DOS_WHITELIST_PROTOCOL_UNKNOWN,
		DOS_WHITELIST_PROTOCOL_TCP,
		DOS_WHITELIST_PROTOCOL_UDP,
		DOS_WHITELIST_PROTOCOL_ICMP,
		DOS_WHITELIST_PROTOCOL_ANY,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
