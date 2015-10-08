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
	[System.Web.Services.WebServiceBindingAttribute(Name="WebAccelerator.PoliciesBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	public partial class WebAcceleratorPolicies : iControlInterface {
		public WebAcceleratorPolicies() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// delete_all_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
	public void delete_all_policies(

	) {
		this.Invoke("delete_all_policies", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_policies(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_policies", new object[0], callback, asyncState);
	}
	public void Enddelete_all_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
	public void delete_policy(
		string name
	) {
		this.Invoke("delete_policy", new object [] {
				name});

	}
	public System.IAsyncResult Begindelete_policy(string name, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_policy", new object[] {
			name}, callback, asyncState);
	}
	public void Enddelete_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_policy_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
	public void delete_policy_v2(
		string [] policies
	) {
		this.Invoke("delete_policy_v2", new object [] {
				policies});

	}
	public System.IAsyncResult Begindelete_policy_v2(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_policy_v2", new object[] {
			policies}, callback, asyncState);
	}
	public void Enddelete_policy_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// export_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
	public void export_policy(
		string [] filenames,
		string [] policy_names,
		bool [] overwrites
	) {
		this.Invoke("export_policy", new object [] {
				filenames,
				policy_names,
				overwrites});

	}
	public System.IAsyncResult Beginexport_policy(string [] filenames,string [] policy_names,bool [] overwrites, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("export_policy", new object[] {
			filenames,
			policy_names,
			overwrites}, callback, asyncState);
	}
	public void Endexport_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
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
	// get_publish_comment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_publish_comment(
		string [] policies
	) {
		object [] results = this.Invoke("get_publish_comment", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_publish_comment(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_publish_comment", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_publish_comment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_publish_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] get_publish_time(
		string [] policies
	) {
		object [] results = this.Invoke("get_publish_time", new object [] {
				policies});
		return ((CommonTimeStamp [])(results[0]));
	}
	public System.IAsyncResult Beginget_publish_time(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_publish_time", new object[] {
			policies}, callback, asyncState);
	}
	public CommonTimeStamp [] Endget_publish_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
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
	// import_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
	public void import_policy(
		string filename,
		bool overwrite
	) {
		this.Invoke("import_policy", new object [] {
				filename,
				overwrite});

	}
	public System.IAsyncResult Beginimport_policy(string filename,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("import_policy", new object[] {
			filename,
			overwrite}, callback, asyncState);
	}
	public void Endimport_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// import_policy_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
	public void import_policy_v2(
		string [] filenames,
		string [] policy_names,
		bool [] overwrites
	) {
		this.Invoke("import_policy_v2", new object [] {
				filenames,
				policy_names,
				overwrites});

	}
	public System.IAsyncResult Beginimport_policy_v2(string [] filenames,string [] policy_names,bool [] overwrites, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("import_policy_v2", new object[] {
			filenames,
			policy_names,
			overwrites}, callback, asyncState);
	}
	public void Endimport_policy_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// is_predefined
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_predefined(
		string [] policies
	) {
		object [] results = this.Invoke("is_predefined", new object [] {
				policies});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_predefined(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_predefined", new object[] {
			policies}, callback, asyncState);
	}
	public bool [] Endis_predefined(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// publish_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/Policies", 
		RequestNamespace="urn:iControl:WebAccelerator/Policies", ResponseNamespace="urn:iControl:WebAccelerator/Policies")]
	public void publish_policy(
		string [] policies,
		string [] comments
	) {
		this.Invoke("publish_policy", new object [] {
				policies,
				comments});

	}
	public System.IAsyncResult Beginpublish_policy(string [] policies,string [] comments, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("publish_policy", new object[] {
			policies,
			comments}, callback, asyncState);
	}
	public void Endpublish_policy(System.IAsyncResult asyncResult) {
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
