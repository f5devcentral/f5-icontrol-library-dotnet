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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.BWPriorityGroupBinding", Namespace="urn:iControl")]
	public partial class NetworkingBWPriorityGroup : iControlInterface {
		public NetworkingBWPriorityGroup() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_priority_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	public void add_priority_class(
		string [] groups,
		string [] [] classes,
		long [] [] percentages
	) {
		this.Invoke("add_priority_class", new object [] {
				groups,
				classes,
				percentages});

	}
	public System.IAsyncResult Beginadd_priority_class(string [] groups,string [] [] classes,long [] [] percentages, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_priority_class", new object[] {
			groups,
			classes,
			percentages}, callback, asyncState);
	}
	public void Endadd_priority_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	public void create(
		string [] groups,
		CommonEnabledState [] states
	) {
		this.Invoke("create", new object [] {
				groups,
				states});

	}
	public System.IAsyncResult Begincreate(string [] groups,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			groups,
			states}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_priority_groups
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	public void delete_all_priority_groups(

	) {
		this.Invoke("delete_all_priority_groups", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_priority_groups(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_priority_groups", new object[0], callback, asyncState);
	}
	public void Enddelete_all_priority_groups(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_priority_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	public void delete_priority_group(
		string [] groups
	) {
		this.Invoke("delete_priority_group", new object [] {
				groups});

	}
	public System.IAsyncResult Begindelete_priority_group(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_priority_group", new object[] {
			groups}, callback, asyncState);
	}
	public void Enddelete_priority_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
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
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
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
	// get_priority_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_priority_class(
		string [] groups
	) {
		object [] results = this.Invoke("get_priority_class", new object [] {
				groups});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_priority_class(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_priority_class", new object[] {
			groups}, callback, asyncState);
	}
	public string [] [] Endget_priority_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_priority_class_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_priority_class_description(
		string [] groups,
		string [] [] classes
	) {
		object [] results = this.Invoke("get_priority_class_description", new object [] {
				groups,
				classes});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_priority_class_description(string [] groups,string [] [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_priority_class_description", new object[] {
			groups,
			classes}, callback, asyncState);
	}
	public string [] [] Endget_priority_class_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_priority_class_weight_percentage
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_priority_class_weight_percentage(
		string [] groups,
		string [] [] classes
	) {
		object [] results = this.Invoke("get_priority_class_weight_percentage", new object [] {
				groups,
				classes});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_priority_class_weight_percentage(string [] groups,string [] [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_priority_class_weight_percentage", new object[] {
			groups,
			classes}, callback, asyncState);
	}
	public long [] [] Endget_priority_class_weight_percentage(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
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
	// remove_all_priority_classes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	public void remove_all_priority_classes(
		string [] groups
	) {
		this.Invoke("remove_all_priority_classes", new object [] {
				groups});

	}
	public System.IAsyncResult Beginremove_all_priority_classes(string [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_priority_classes", new object[] {
			groups}, callback, asyncState);
	}
	public void Endremove_all_priority_classes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_priority_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	public void remove_priority_class(
		string [] groups,
		string [] [] classes
	) {
		this.Invoke("remove_priority_class", new object [] {
				groups,
				classes});

	}
	public System.IAsyncResult Beginremove_priority_class(string [] groups,string [] [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_priority_class", new object[] {
			groups,
			classes}, callback, asyncState);
	}
	public void Endremove_priority_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
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
	// set_priority_class_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	public void set_priority_class_description(
		string [] groups,
		string [] [] classes,
		string [] [] descriptions
	) {
		this.Invoke("set_priority_class_description", new object [] {
				groups,
				classes,
				descriptions});

	}
	public System.IAsyncResult Beginset_priority_class_description(string [] groups,string [] [] classes,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_priority_class_description", new object[] {
			groups,
			classes,
			descriptions}, callback, asyncState);
	}
	public void Endset_priority_class_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_priority_class_weight_percentage
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWPriorityGroup", 
		RequestNamespace="urn:iControl:Networking/BWPriorityGroup", ResponseNamespace="urn:iControl:Networking/BWPriorityGroup")]
	public void set_priority_class_weight_percentage(
		string [] groups,
		string [] [] classes,
		long [] [] percentages
	) {
		this.Invoke("set_priority_class_weight_percentage", new object [] {
				groups,
				classes,
				percentages});

	}
	public System.IAsyncResult Beginset_priority_class_weight_percentage(string [] groups,string [] [] classes,long [] [] percentages, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_priority_class_weight_percentage", new object[] {
			groups,
			classes,
			percentages}, callback, asyncState);
	}
	public void Endset_priority_class_weight_percentage(System.IAsyncResult asyncResult) {
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
