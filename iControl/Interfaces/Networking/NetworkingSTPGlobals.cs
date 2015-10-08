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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.STPGlobalsBinding", Namespace="urn:iControl")]
	public partial class NetworkingSTPGlobals : iControlInterface {
		public NetworkingSTPGlobals() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_configuration_identifier
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_configuration_identifier(

	) {
		object [] results = this.Invoke("get_configuration_identifier", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_configuration_identifier(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_configuration_identifier", new object[0], callback, asyncState);
	}
	public string Endget_configuration_identifier(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_configuration_revision
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_configuration_revision(

	) {
		object [] results = this.Invoke("get_configuration_revision", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_configuration_revision(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_configuration_revision", new object[0], callback, asyncState);
	}
	public long Endget_configuration_revision(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
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
	// get_forward_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_forward_delay(

	) {
		object [] results = this.Invoke("get_forward_delay", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_forward_delay(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_forward_delay", new object[0], callback, asyncState);
	}
	public long Endget_forward_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hello_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_hello_time(

	) {
		object [] results = this.Invoke("get_hello_time", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_hello_time(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hello_time", new object[0], callback, asyncState);
	}
	public long Endget_hello_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_maximum_age(

	) {
		object [] results = this.Invoke("get_maximum_age", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_age(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_age", new object[0], callback, asyncState);
	}
	public long Endget_maximum_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_hop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_maximum_hop(

	) {
		object [] results = this.Invoke("get_maximum_hop", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_hop(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_hop", new object[0], callback, asyncState);
	}
	public long Endget_maximum_hop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPModeType get_mode(

	) {
		object [] results = this.Invoke("get_mode", new object [0]);
		return ((NetworkingSTPModeType)(results[0]));
	}
	public System.IAsyncResult Beginget_mode(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mode", new object[0], callback, asyncState);
	}
	public NetworkingSTPModeType Endget_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPModeType)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transmit_hold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_transmit_hold(

	) {
		object [] results = this.Invoke("get_transmit_hold", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_transmit_hold(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transmit_hold", new object[0], callback, asyncState);
	}
	public long Endget_transmit_hold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
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
	// set_configuration_identifier
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	public void set_configuration_identifier(
		string value
	) {
		this.Invoke("set_configuration_identifier", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_configuration_identifier(string value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_configuration_identifier", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_configuration_identifier(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_configuration_revision
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	public void set_configuration_revision(
		long value
	) {
		this.Invoke("set_configuration_revision", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_configuration_revision(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_configuration_revision", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_configuration_revision(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
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
	// set_forward_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	public void set_forward_delay(
		long value
	) {
		this.Invoke("set_forward_delay", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_forward_delay(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_forward_delay", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_forward_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_hello_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	public void set_hello_time(
		long value
	) {
		this.Invoke("set_hello_time", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_hello_time(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hello_time", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_hello_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	public void set_maximum_age(
		long value
	) {
		this.Invoke("set_maximum_age", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_maximum_age(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_age", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_maximum_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_hop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	public void set_maximum_hop(
		long value
	) {
		this.Invoke("set_maximum_hop", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_maximum_hop(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_hop", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_maximum_hop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	public void set_mode(
		NetworkingSTPModeType value
	) {
		this.Invoke("set_mode", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_mode(NetworkingSTPModeType value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mode", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_transmit_hold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPGlobals", 
		RequestNamespace="urn:iControl:Networking/STPGlobals", ResponseNamespace="urn:iControl:Networking/STPGlobals")]
	public void set_transmit_hold(
		long value
	) {
		this.Invoke("set_transmit_hold", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_transmit_hold(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_transmit_hold", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_transmit_hold(System.IAsyncResult asyncResult) {
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
