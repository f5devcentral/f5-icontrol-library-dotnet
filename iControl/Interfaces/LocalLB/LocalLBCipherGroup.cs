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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.CipherGroupBinding", Namespace="urn:iControl")]
	public partial class LocalLBCipherGroup : iControlInterface {
		public LocalLBCipherGroup() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_allow
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void add_allow(
		string [] groups,
		string [] [] rules
	) {
		this.Invoke("add_allow", new object [] {
				groups,
				rules});

	}
	public System.IAsyncResult Beginadd_allow(string [] groups,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_allow", new object[] {
			groups,
			rules}, callback, asyncState);
	}
	public void Endadd_allow(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void add_exclude(
		string [] groups,
		string [] [] rules
	) {
		this.Invoke("add_exclude", new object [] {
				groups,
				rules});

	}
	public System.IAsyncResult Beginadd_exclude(string [] groups,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_exclude", new object[] {
			groups,
			rules}, callback, asyncState);
	}
	public void Endadd_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_require
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void add_require(
		string [] groups,
		string [] [] rules
	) {
		this.Invoke("add_require", new object [] {
				groups,
				rules});

	}
	public System.IAsyncResult Beginadd_require(string [] groups,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_require", new object[] {
			groups,
			rules}, callback, asyncState);
	}
	public void Endadd_require(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void create(
		string [] groups,
		string [] [] allows,
		string [] [] excludes,
		string [] [] requires,
		LocalLBCipherGroupCipherGroupOrder [] orders
	) {
		this.Invoke("create", new object [] {
				groups,
				allows,
				excludes,
				requires,
				orders});

	}
	public System.IAsyncResult Begincreate(string [] groups,string [] [] allows,string [] [] excludes,string [] [] requires,LocalLBCipherGroupCipherGroupOrder [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			groups,
			allows,
			excludes,
			requires,
			orders}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_cipher_groups
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void delete_all_cipher_groups(

	) {
		this.Invoke("delete_all_cipher_groups", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_cipher_groups(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_cipher_groups", new object[0], callback, asyncState);
	}
	public void Enddelete_all_cipher_groups(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_cipher_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void delete_cipher_group(
		string [] groups
	) {
		this.Invoke("delete_cipher_group", new object [] {
				groups});

	}
	public System.IAsyncResult Begindelete_cipher_group(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_cipher_group", new object[] {
			groups}, callback, asyncState);
	}
	public void Enddelete_cipher_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_allow
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_allow(
		string [] groups
	) {
		object [] results = this.Invoke("get_allow", new object [] {
				groups});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow", new object[] {
			groups}, callback, asyncState);
	}
	public string [] [] Endget_allow(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] groups
	) {
		object [] results = this.Invoke("get_description", new object [] {
				groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			groups}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_exclude(
		string [] groups
	) {
		object [] results = this.Invoke("get_exclude", new object [] {
				groups});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_exclude(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_exclude", new object[] {
			groups}, callback, asyncState);
	}
	public string [] [] Endget_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
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
	// get_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBCipherGroupCipherGroupOrder [] get_order(
		string [] groups
	) {
		object [] results = this.Invoke("get_order", new object [] {
				groups});
		return ((LocalLBCipherGroupCipherGroupOrder [])(results[0]));
	}
	public System.IAsyncResult Beginget_order(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_order", new object[] {
			groups}, callback, asyncState);
	}
	public LocalLBCipherGroupCipherGroupOrder [] Endget_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBCipherGroupCipherGroupOrder [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_require
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_require(
		string [] groups
	) {
		object [] results = this.Invoke("get_require", new object [] {
				groups});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_require(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_require", new object[] {
			groups}, callback, asyncState);
	}
	public string [] [] Endget_require(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_result_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_result_list(
		string [] groups
	) {
		object [] results = this.Invoke("get_result_list", new object [] {
				groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_result_list(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_result_list", new object[] {
			groups}, callback, asyncState);
	}
	public string [] Endget_result_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
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
	// remove_all_excludes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void remove_all_excludes(
		string [] groups
	) {
		this.Invoke("remove_all_excludes", new object [] {
				groups});

	}
	public System.IAsyncResult Beginremove_all_excludes(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_excludes", new object[] {
			groups}, callback, asyncState);
	}
	public void Endremove_all_excludes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_requires
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void remove_all_requires(
		string [] groups
	) {
		this.Invoke("remove_all_requires", new object [] {
				groups});

	}
	public System.IAsyncResult Beginremove_all_requires(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_requires", new object[] {
			groups}, callback, asyncState);
	}
	public void Endremove_all_requires(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_allow
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void remove_allow(
		string [] groups,
		string [] [] rules
	) {
		this.Invoke("remove_allow", new object [] {
				groups,
				rules});

	}
	public System.IAsyncResult Beginremove_allow(string [] groups,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_allow", new object[] {
			groups,
			rules}, callback, asyncState);
	}
	public void Endremove_allow(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void remove_exclude(
		string [] groups,
		string [] [] rules
	) {
		this.Invoke("remove_exclude", new object [] {
				groups,
				rules});

	}
	public System.IAsyncResult Beginremove_exclude(string [] groups,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_exclude", new object[] {
			groups,
			rules}, callback, asyncState);
	}
	public void Endremove_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_require
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void remove_require(
		string [] groups,
		string [] [] rules
	) {
		this.Invoke("remove_require", new object [] {
				groups,
				rules});

	}
	public System.IAsyncResult Beginremove_require(string [] groups,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_require", new object[] {
			groups,
			rules}, callback, asyncState);
	}
	public void Endremove_require(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void set_description(
		string [] groups,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				groups,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] groups,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			groups,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherGroup", 
		RequestNamespace="urn:iControl:LocalLB/CipherGroup", ResponseNamespace="urn:iControl:LocalLB/CipherGroup")]
	public void set_order(
		string [] groups,
		LocalLBCipherGroupCipherGroupOrder [] orders
	) {
		this.Invoke("set_order", new object [] {
				groups,
				orders});

	}
	public System.IAsyncResult Beginset_order(string [] groups,LocalLBCipherGroupCipherGroupOrder [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_order", new object[] {
			groups,
			orders}, callback, asyncState);
	}
	public void Endset_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.CipherGroup.CipherGroupOrder", Namespace = "urn:iControl")]
	public enum LocalLBCipherGroupCipherGroupOrder
	{
		CIPHER_GROUP_ORDER_UNKNOWN,
		CIPHER_GROUP_ORDER_DEFAULT,
		CIPHER_GROUP_ORDER_SPEED,
		CIPHER_GROUP_ORDER_STRENGTH,
		CIPHER_GROUP_ORDER_FIPS,
		CIPHER_GROUP_ORDER_HARDWARE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
