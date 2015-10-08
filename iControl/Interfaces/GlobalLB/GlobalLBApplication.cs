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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.ApplicationBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBApplicationApplicationContextObject))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	public partial class GlobalLBApplication : iControlInterface {
		public GlobalLBApplication() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	public void create(
		string [] applications
	) {
		this.Invoke("create", new object [] {
				applications});

	}
	public System.IAsyncResult Begincreate(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			applications}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_applications
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	public void delete_all_applications(

	) {
		this.Invoke("delete_all_applications", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_applications(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_applications", new object[0], callback, asyncState);
	}
	public void Enddelete_all_applications(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	public void delete_application(
		string [] applications
	) {
		this.Invoke("delete_application", new object [] {
				applications});

	}
	public System.IAsyncResult Begindelete_application(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_application", new object[] {
			applications}, callback, asyncState);
	}
	public void Enddelete_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// disable_application_context_object
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	public void disable_application_context_object(
		GlobalLBApplicationApplicationContextObject [] application_objects
	) {
		this.Invoke("disable_application_context_object", new object [] {
				application_objects});

	}
	public System.IAsyncResult Begindisable_application_context_object(GlobalLBApplicationApplicationContextObject [] application_objects, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("disable_application_context_object", new object[] {
			application_objects}, callback, asyncState);
	}
	public void Enddisable_application_context_object(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// enable_application_context_object
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	public void enable_application_context_object(
		GlobalLBApplicationApplicationContextObject [] application_objects
	) {
		this.Invoke("enable_application_context_object", new object [] {
				application_objects});

	}
	public System.IAsyncResult Beginenable_application_context_object(GlobalLBApplicationApplicationContextObject [] application_objects, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("enable_application_context_object", new object[] {
			application_objects}, callback, asyncState);
	}
	public void Endenable_application_context_object(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_application_context_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_application_context_status(
		GlobalLBApplicationApplicationContextObject [] application_objects
	) {
		object [] results = this.Invoke("get_application_context_status", new object [] {
				application_objects});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_context_status(GlobalLBApplicationApplicationContextObject [] application_objects, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_context_status", new object[] {
			application_objects}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_application_context_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_availability_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBAvailabilityDependency [] get_availability_dependency(
		string [] applications
	) {
		object [] results = this.Invoke("get_availability_dependency", new object [] {
				applications});
		return ((GlobalLBAvailabilityDependency [])(results[0]));
	}
	public System.IAsyncResult Beginget_availability_dependency(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_availability_dependency", new object[] {
			applications}, callback, asyncState);
	}
	public GlobalLBAvailabilityDependency [] Endget_availability_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBAvailabilityDependency [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_data_centers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_data_centers(
		string [] applications
	) {
		object [] results = this.Invoke("get_data_centers", new object [] {
				applications});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_data_centers(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_data_centers", new object[] {
			applications}, callback, asyncState);
	}
	public string [] [] Endget_data_centers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] applications
	) {
		object [] results = this.Invoke("get_description", new object [] {
				applications});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			applications}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
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
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		string [] applications
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				applications});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			applications}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_persistence_state(
		string [] applications
	) {
		object [] results = this.Invoke("get_persistence_state", new object [] {
				applications});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_state(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_state", new object[] {
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_persistence_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_persistence_ttl(
		string [] applications
	) {
		object [] results = this.Invoke("get_persistence_ttl", new object [] {
				applications});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_ttl(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_ttl", new object[] {
			applications}, callback, asyncState);
	}
	public long [] Endget_persistence_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_servers(
		string [] applications
	) {
		object [] results = this.Invoke("get_servers", new object [] {
				applications});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_servers(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_servers", new object[] {
			applications}, callback, asyncState);
	}
	public string [] [] Endget_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
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
	// get_wide_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_wide_ips(
		string [] applications
	) {
		object [] results = this.Invoke("get_wide_ips", new object [] {
				applications});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_wide_ips(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wide_ips", new object[] {
			applications}, callback, asyncState);
	}
	public string [] [] Endget_wide_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_availability_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	public void set_availability_dependency(
		string [] applications,
		GlobalLBAvailabilityDependency [] values
	) {
		this.Invoke("set_availability_dependency", new object [] {
				applications,
				values});

	}
	public System.IAsyncResult Beginset_availability_dependency(string [] applications,GlobalLBAvailabilityDependency [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_availability_dependency", new object[] {
			applications,
			values}, callback, asyncState);
	}
	public void Endset_availability_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	public void set_description(
		string [] applications,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				applications,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] applications,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			applications,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	public void set_persistence_state(
		string [] applications,
		CommonEnabledState [] states
	) {
		this.Invoke("set_persistence_state", new object [] {
				applications,
				states});

	}
	public System.IAsyncResult Beginset_persistence_state(string [] applications,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_state", new object[] {
			applications,
			states}, callback, asyncState);
	}
	public void Endset_persistence_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Application", 
		RequestNamespace="urn:iControl:GlobalLB/Application", ResponseNamespace="urn:iControl:GlobalLB/Application")]
	public void set_persistence_ttl(
		string [] applications,
		long [] values
	) {
		this.Invoke("set_persistence_ttl", new object [] {
				applications,
				values});

	}
	public System.IAsyncResult Beginset_persistence_ttl(string [] applications,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_ttl", new object[] {
			applications,
			values}, callback, asyncState);
	}
	public void Endset_persistence_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Application.ApplicationObjectType", Namespace = "urn:iControl")]
	public enum GlobalLBApplicationApplicationObjectType
	{
		APPLICATION_OBJECT_TYPE_DATACENTER,
		APPLICATION_OBJECT_TYPE_SERVER,
		APPLICATION_OBJECT_TYPE_LINK,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Application.ApplicationContextObject", Namespace = "urn:iControl")]
	public partial class GlobalLBApplicationApplicationContextObject
	{
		private string application_nameField;
		public string application_name
		{
			get { return this.application_nameField; }
			set { this.application_nameField = value; }
		}
		private string object_nameField;
		public string object_name
		{
			get { return this.object_nameField; }
			set { this.object_nameField = value; }
		}
		private GlobalLBApplicationApplicationObjectType object_typeField;
		public GlobalLBApplicationApplicationObjectType object_type
		{
			get { return this.object_typeField; }
			set { this.object_typeField = value; }
		}
	};

}
