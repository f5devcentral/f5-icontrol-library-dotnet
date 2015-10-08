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
	[System.Web.Services.WebServiceBindingAttribute(Name="ASM.PolicyGroupBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMWebApplicationGroupDefinition))]
	public partial class ASMPolicyGroup : iControlInterface {
		public ASMPolicyGroup() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PolicyGroup", 
		RequestNamespace="urn:iControl:ASM/PolicyGroup", ResponseNamespace="urn:iControl:ASM/PolicyGroup")]
	public void add_policy(
		string [] group_names,
		string [] [] policy_names
	) {
		this.Invoke("add_policy", new object [] {
				group_names,
				policy_names});

	}
	public System.IAsyncResult Beginadd_policy(string [] group_names,string [] [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_policy", new object[] {
			group_names,
			policy_names}, callback, asyncState);
	}
	public void Endadd_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PolicyGroup", 
		RequestNamespace="urn:iControl:ASM/PolicyGroup", ResponseNamespace="urn:iControl:ASM/PolicyGroup")]
	public void create(
		string [] group_names
	) {
		this.Invoke("create", new object [] {
				group_names});

	}
	public System.IAsyncResult Begincreate(string [] group_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			group_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_groups
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PolicyGroup", 
		RequestNamespace="urn:iControl:ASM/PolicyGroup", ResponseNamespace="urn:iControl:ASM/PolicyGroup")]
	public void delete_all_groups(

	) {
		this.Invoke("delete_all_groups", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_groups(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_groups", new object[0], callback, asyncState);
	}
	public void Enddelete_all_groups(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PolicyGroup", 
		RequestNamespace="urn:iControl:ASM/PolicyGroup", ResponseNamespace="urn:iControl:ASM/PolicyGroup")]
	public void delete_group(
		string [] group_names
	) {
		this.Invoke("delete_group", new object [] {
				group_names});

	}
	public System.IAsyncResult Begindelete_group(string [] group_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_group", new object[] {
			group_names}, callback, asyncState);
	}
	public void Enddelete_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PolicyGroup", 
		RequestNamespace="urn:iControl:ASM/PolicyGroup", ResponseNamespace="urn:iControl:ASM/PolicyGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMWebApplicationGroupDefinition [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((ASMWebApplicationGroupDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public ASMWebApplicationGroupDefinition [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMWebApplicationGroupDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_policy_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PolicyGroup", 
		RequestNamespace="urn:iControl:ASM/PolicyGroup", ResponseNamespace="urn:iControl:ASM/PolicyGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_policy_list(
		ASMWebApplicationGroupDefinition [] group_names
	) {
		object [] results = this.Invoke("get_policy_list", new object [] {
				group_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_policy_list(ASMWebApplicationGroupDefinition [] group_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_policy_list", new object[] {
			group_names}, callback, asyncState);
	}
	public string [] [] Endget_policy_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PolicyGroup", 
		RequestNamespace="urn:iControl:ASM/PolicyGroup", ResponseNamespace="urn:iControl:ASM/PolicyGroup")]
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
	// remove_all_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PolicyGroup", 
		RequestNamespace="urn:iControl:ASM/PolicyGroup", ResponseNamespace="urn:iControl:ASM/PolicyGroup")]
	public void remove_all_policies(
		string [] group_names
	) {
		this.Invoke("remove_all_policies", new object [] {
				group_names});

	}
	public System.IAsyncResult Beginremove_all_policies(string [] group_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_policies", new object[] {
			group_names}, callback, asyncState);
	}
	public void Endremove_all_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/PolicyGroup", 
		RequestNamespace="urn:iControl:ASM/PolicyGroup", ResponseNamespace="urn:iControl:ASM/PolicyGroup")]
	public void remove_policy(
		string [] group_names,
		string [] [] policy_names
	) {
		this.Invoke("remove_policy", new object [] {
				group_names,
				policy_names});

	}
	public System.IAsyncResult Beginremove_policy(string [] group_names,string [] [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_policy", new object[] {
			group_names,
			policy_names}, callback, asyncState);
	}
	public void Endremove_policy(System.IAsyncResult asyncResult) {
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
