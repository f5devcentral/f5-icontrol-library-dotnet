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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.LLDPGlobalsBinding", Namespace="urn:iControl")]
	public partial class NetworkingLLDPGlobals : iControlInterface {
		public NetworkingLLDPGlobals() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_description(

	) {
		object [] results = this.Invoke("get_description", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_description(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[0], callback, asyncState);
	}
	public string Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lldp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_lldp_enabled_state(

	) {
		object [] results = this.Invoke("get_lldp_enabled_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_lldp_enabled_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lldp_enabled_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_lldp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_neighbors_per_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_maximum_neighbors_per_port(

	) {
		object [] results = this.Invoke("get_maximum_neighbors_per_port", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_neighbors_per_port(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_neighbors_per_port", new object[0], callback, asyncState);
	}
	public long Endget_maximum_neighbors_per_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_reinit_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_reinit_delay(

	) {
		object [] results = this.Invoke("get_reinit_delay", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_reinit_delay(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_reinit_delay", new object[0], callback, asyncState);
	}
	public long Endget_reinit_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tx_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_tx_delay(

	) {
		object [] results = this.Invoke("get_tx_delay", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_tx_delay(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tx_delay", new object[0], callback, asyncState);
	}
	public long Endget_tx_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tx_hold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_tx_hold(

	) {
		object [] results = this.Invoke("get_tx_hold", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_tx_hold(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tx_hold", new object[0], callback, asyncState);
	}
	public long Endget_tx_hold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tx_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_tx_interval(

	) {
		object [] results = this.Invoke("get_tx_interval", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_tx_interval(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tx_interval", new object[0], callback, asyncState);
	}
	public long Endget_tx_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
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
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	public void set_description(
		string description
	) {
		this.Invoke("set_description", new object [] {
				description});

	}
	public System.IAsyncResult Beginset_description(string description, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			description}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lldp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	public void set_lldp_enabled_state(
		CommonEnabledState value
	) {
		this.Invoke("set_lldp_enabled_state", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_lldp_enabled_state(CommonEnabledState value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lldp_enabled_state", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_lldp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_neighbors_per_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	public void set_maximum_neighbors_per_port(
		long value
	) {
		this.Invoke("set_maximum_neighbors_per_port", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_maximum_neighbors_per_port(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_neighbors_per_port", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_maximum_neighbors_per_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_reinit_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	public void set_reinit_delay(
		long value
	) {
		this.Invoke("set_reinit_delay", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_reinit_delay(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_reinit_delay", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_reinit_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tx_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	public void set_tx_delay(
		long value
	) {
		this.Invoke("set_tx_delay", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_tx_delay(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tx_delay", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_tx_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tx_hold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	public void set_tx_hold(
		long value
	) {
		this.Invoke("set_tx_hold", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_tx_hold(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tx_hold", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_tx_hold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tx_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/LLDPGlobals", 
		RequestNamespace="urn:iControl:Networking/LLDPGlobals", ResponseNamespace="urn:iControl:Networking/LLDPGlobals")]
	public void set_tx_interval(
		long value
	) {
		this.Invoke("set_tx_interval", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_tx_interval(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tx_interval", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_tx_interval(System.IAsyncResult asyncResult) {
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
