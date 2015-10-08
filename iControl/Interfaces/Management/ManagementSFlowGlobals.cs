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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.SFlowGlobalsBinding", Namespace="urn:iControl")]
	public partial class ManagementSFlowGlobals : iControlInterface {
		public ManagementSFlowGlobals() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_http_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_http_description(

	) {
		object [] results = this.Invoke("get_http_description", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_http_description(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_description", new object[0], callback, asyncState);
	}
	public string Endget_http_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_http_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_http_poll_interval(

	) {
		object [] results = this.Invoke("get_http_poll_interval", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_http_poll_interval(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_poll_interval", new object[0], callback, asyncState);
	}
	public long Endget_http_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_http_sampling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_http_sampling_rate(

	) {
		object [] results = this.Invoke("get_http_sampling_rate", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_http_sampling_rate(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_sampling_rate", new object[0], callback, asyncState);
	}
	public long Endget_http_sampling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_interface_description(

	) {
		object [] results = this.Invoke("get_interface_description", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_interface_description(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_description", new object[0], callback, asyncState);
	}
	public string Endget_interface_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_interface_poll_interval(

	) {
		object [] results = this.Invoke("get_interface_poll_interval", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_interface_poll_interval(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_poll_interval", new object[0], callback, asyncState);
	}
	public long Endget_interface_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_system_description(

	) {
		object [] results = this.Invoke("get_system_description", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_system_description(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_description", new object[0], callback, asyncState);
	}
	public string Endget_system_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_system_poll_interval(

	) {
		object [] results = this.Invoke("get_system_poll_interval", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_system_poll_interval(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_poll_interval", new object[0], callback, asyncState);
	}
	public long Endget_system_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
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
	// get_vlan_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_vlan_description(

	) {
		object [] results = this.Invoke("get_vlan_description", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_vlan_description(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan_description", new object[0], callback, asyncState);
	}
	public string Endget_vlan_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vlan_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_vlan_poll_interval(

	) {
		object [] results = this.Invoke("get_vlan_poll_interval", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_vlan_poll_interval(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan_poll_interval", new object[0], callback, asyncState);
	}
	public long Endget_vlan_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vlan_sampling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_vlan_sampling_rate(

	) {
		object [] results = this.Invoke("get_vlan_sampling_rate", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_vlan_sampling_rate(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan_sampling_rate", new object[0], callback, asyncState);
	}
	public long Endget_vlan_sampling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_http_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	public void set_http_description(
		string description
	) {
		this.Invoke("set_http_description", new object [] {
				description});

	}
	public System.IAsyncResult Beginset_http_description(string description, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_http_description", new object[] {
			description}, callback, asyncState);
	}
	public void Endset_http_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_http_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	public void set_http_poll_interval(
		long interval
	) {
		this.Invoke("set_http_poll_interval", new object [] {
				interval});

	}
	public System.IAsyncResult Beginset_http_poll_interval(long interval, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_http_poll_interval", new object[] {
			interval}, callback, asyncState);
	}
	public void Endset_http_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_http_sampling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	public void set_http_sampling_rate(
		long rate
	) {
		this.Invoke("set_http_sampling_rate", new object [] {
				rate});

	}
	public System.IAsyncResult Beginset_http_sampling_rate(long rate, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_http_sampling_rate", new object[] {
			rate}, callback, asyncState);
	}
	public void Endset_http_sampling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_interface_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	public void set_interface_description(
		string description
	) {
		this.Invoke("set_interface_description", new object [] {
				description});

	}
	public System.IAsyncResult Beginset_interface_description(string description, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_interface_description", new object[] {
			description}, callback, asyncState);
	}
	public void Endset_interface_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_interface_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	public void set_interface_poll_interval(
		long interval
	) {
		this.Invoke("set_interface_poll_interval", new object [] {
				interval});

	}
	public System.IAsyncResult Beginset_interface_poll_interval(long interval, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_interface_poll_interval", new object[] {
			interval}, callback, asyncState);
	}
	public void Endset_interface_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_system_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	public void set_system_description(
		string description
	) {
		this.Invoke("set_system_description", new object [] {
				description});

	}
	public System.IAsyncResult Beginset_system_description(string description, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_system_description", new object[] {
			description}, callback, asyncState);
	}
	public void Endset_system_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_system_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	public void set_system_poll_interval(
		long interval
	) {
		this.Invoke("set_system_poll_interval", new object [] {
				interval});

	}
	public System.IAsyncResult Beginset_system_poll_interval(long interval, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_system_poll_interval", new object[] {
			interval}, callback, asyncState);
	}
	public void Endset_system_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	public void set_vlan_description(
		string description
	) {
		this.Invoke("set_vlan_description", new object [] {
				description});

	}
	public System.IAsyncResult Beginset_vlan_description(string description, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan_description", new object[] {
			description}, callback, asyncState);
	}
	public void Endset_vlan_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	public void set_vlan_poll_interval(
		long interval
	) {
		this.Invoke("set_vlan_poll_interval", new object [] {
				interval});

	}
	public System.IAsyncResult Beginset_vlan_poll_interval(long interval, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan_poll_interval", new object[] {
			interval}, callback, asyncState);
	}
	public void Endset_vlan_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan_sampling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowGlobals", 
		RequestNamespace="urn:iControl:Management/SFlowGlobals", ResponseNamespace="urn:iControl:Management/SFlowGlobals")]
	public void set_vlan_sampling_rate(
		long rate
	) {
		this.Invoke("set_vlan_sampling_rate", new object [] {
				rate});

	}
	public System.IAsyncResult Beginset_vlan_sampling_rate(long rate, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan_sampling_rate", new object[] {
			rate}, callback, asyncState);
	}
	public void Endset_vlan_sampling_rate(System.IAsyncResult asyncResult) {
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
