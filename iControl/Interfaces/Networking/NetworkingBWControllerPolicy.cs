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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.BWControllerPolicyBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonRateUnit))]
	public partial class NetworkingBWControllerPolicy : iControlInterface {
		public NetworkingBWControllerPolicy() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_category_maximum_percentage
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void add_category_maximum_percentage(
		string [] policies,
		string [] [] categories,
		long [] [] percentages
	) {
		this.Invoke("add_category_maximum_percentage", new object [] {
				policies,
				categories,
				percentages});

	}
	public System.IAsyncResult Beginadd_category_maximum_percentage(string [] policies,string [] [] categories,long [] [] percentages, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_category_maximum_percentage", new object[] {
			policies,
			categories,
			percentages}, callback, asyncState);
	}
	public void Endadd_category_maximum_percentage(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_category_maximum_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void add_category_maximum_rate(
		string [] policies,
		string [] [] categories,
		CommonRateUnit [] [] rates
	) {
		this.Invoke("add_category_maximum_rate", new object [] {
				policies,
				categories,
				rates});

	}
	public System.IAsyncResult Beginadd_category_maximum_rate(string [] policies,string [] [] categories,CommonRateUnit [] [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_category_maximum_rate", new object[] {
			policies,
			categories,
			rates}, callback, asyncState);
	}
	public void Endadd_category_maximum_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void create(
		string [] policies,
		CommonRateUnit [] rates,
		CommonEnabledState [] states,
		CommonRateUnit [] user_rates
	) {
		this.Invoke("create", new object [] {
				policies,
				rates,
				states,
				user_rates});

	}
	public System.IAsyncResult Begincreate(string [] policies,CommonRateUnit [] rates,CommonEnabledState [] states,CommonRateUnit [] user_rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			policies,
			rates,
			states,
			user_rates}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void delete_policy(
		string [] policies
	) {
		this.Invoke("delete_policy", new object [] {
				policies});

	}
	public System.IAsyncResult Begindelete_policy(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_policy", new object[] {
			policies}, callback, asyncState);
	}
	public void Enddelete_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_category(
		string [] policies
	) {
		object [] results = this.Invoke("get_category", new object [] {
				policies});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_category(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_category", new object[] {
			policies}, callback, asyncState);
	}
	public string [] [] Endget_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_category_maximum_percentage
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_category_maximum_percentage(
		string [] policies,
		string [] [] categories
	) {
		object [] results = this.Invoke("get_category_maximum_percentage", new object [] {
				policies,
				categories});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_category_maximum_percentage(string [] policies,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_category_maximum_percentage", new object[] {
			policies,
			categories}, callback, asyncState);
	}
	public long [] [] Endget_category_maximum_percentage(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_category_maximum_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonRateUnit [] [] get_category_maximum_rate(
		string [] policies,
		string [] [] categories
	) {
		object [] results = this.Invoke("get_category_maximum_rate", new object [] {
				policies,
				categories});
		return ((CommonRateUnit [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_category_maximum_rate(string [] policies,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_category_maximum_rate", new object[] {
			policies,
			categories}, callback, asyncState);
	}
	public CommonRateUnit [] [] Endget_category_maximum_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonRateUnit [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] policies
	) {
		object [] results = this.Invoke("get_description", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_dynamic_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_dynamic_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_dynamic_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_tos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ip_tos(
		string [] policies
	) {
		object [] results = this.Invoke("get_ip_tos", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_tos(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_tos", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_ip_tos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_qos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_link_qos(
		string [] policies
	) {
		object [] results = this.Invoke("get_link_qos", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_link_qos(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_qos", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_link_qos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
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
	// get_maximum_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonRateUnit [] get_maximum_rate(
		string [] policies
	) {
		object [] results = this.Invoke("get_maximum_rate", new object [] {
				policies});
		return ((CommonRateUnit [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_rate(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_rate", new object[] {
			policies}, callback, asyncState);
	}
	public CommonRateUnit [] Endget_maximum_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonRateUnit [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_user_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonRateUnit [] get_maximum_user_rate(
		string [] policies
	) {
		object [] results = this.Invoke("get_maximum_user_rate", new object [] {
				policies});
		return ((CommonRateUnit [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_user_rate(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_user_rate", new object[] {
			policies}, callback, asyncState);
	}
	public CommonRateUnit [] Endget_maximum_user_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonRateUnit [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
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
	// remove_all_categories
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void remove_all_categories(
		string [] policies
	) {
		this.Invoke("remove_all_categories", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_categories(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_categories", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_categories(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void remove_category(
		string [] policies,
		string [] [] categories
	) {
		this.Invoke("remove_category", new object [] {
				policies,
				categories});

	}
	public System.IAsyncResult Beginremove_category(string [] policies,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_category", new object[] {
			policies,
			categories}, callback, asyncState);
	}
	public void Endremove_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_category_maximum_percentage
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void set_category_maximum_percentage(
		string [] policies,
		string [] [] categories,
		long [] [] percentages
	) {
		this.Invoke("set_category_maximum_percentage", new object [] {
				policies,
				categories,
				percentages});

	}
	public System.IAsyncResult Beginset_category_maximum_percentage(string [] policies,string [] [] categories,long [] [] percentages, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_category_maximum_percentage", new object[] {
			policies,
			categories,
			percentages}, callback, asyncState);
	}
	public void Endset_category_maximum_percentage(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_category_maximum_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void set_category_maximum_rate(
		string [] policies,
		string [] [] categories,
		CommonRateUnit [] [] rates
	) {
		this.Invoke("set_category_maximum_rate", new object [] {
				policies,
				categories,
				rates});

	}
	public System.IAsyncResult Beginset_category_maximum_rate(string [] policies,string [] [] categories,CommonRateUnit [] [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_category_maximum_rate", new object[] {
			policies,
			categories,
			rates}, callback, asyncState);
	}
	public void Endset_category_maximum_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void set_description(
		string [] policies,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				policies,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] policies,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			policies,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_tos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void set_ip_tos(
		string [] policies,
		long [] values
	) {
		this.Invoke("set_ip_tos", new object [] {
				policies,
				values});

	}
	public System.IAsyncResult Beginset_ip_tos(string [] policies,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_tos", new object[] {
			policies,
			values}, callback, asyncState);
	}
	public void Endset_ip_tos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_qos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void set_link_qos(
		string [] policies,
		long [] values
	) {
		this.Invoke("set_link_qos", new object [] {
				policies,
				values});

	}
	public System.IAsyncResult Beginset_link_qos(string [] policies,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_qos", new object[] {
			policies,
			values}, callback, asyncState);
	}
	public void Endset_link_qos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void set_maximum_rate(
		string [] policies,
		CommonRateUnit [] rates
	) {
		this.Invoke("set_maximum_rate", new object [] {
				policies,
				rates});

	}
	public System.IAsyncResult Beginset_maximum_rate(string [] policies,CommonRateUnit [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_rate", new object[] {
			policies,
			rates}, callback, asyncState);
	}
	public void Endset_maximum_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_user_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/BWControllerPolicy", 
		RequestNamespace="urn:iControl:Networking/BWControllerPolicy", ResponseNamespace="urn:iControl:Networking/BWControllerPolicy")]
	public void set_maximum_user_rate(
		string [] policies,
		CommonRateUnit [] rates
	) {
		this.Invoke("set_maximum_user_rate", new object [] {
				policies,
				rates});

	}
	public System.IAsyncResult Beginset_maximum_user_rate(string [] policies,CommonRateUnit [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_user_rate", new object[] {
			policies,
			rates}, callback, asyncState);
	}
	public void Endset_maximum_user_rate(System.IAsyncResult asyncResult) {
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
