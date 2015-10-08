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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.iSessionDeduplicationBinding", Namespace="urn:iControl")]
	public partial class NetworkingiSessionDeduplication : iControlInterface {
		public NetworkingiSessionDeduplication() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDeduplication", 
		RequestNamespace="urn:iControl:Networking/iSessionDeduplication", ResponseNamespace="urn:iControl:Networking/iSessionDeduplication")]
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
	// get_dictionary
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDeduplication", 
		RequestNamespace="urn:iControl:Networking/iSessionDeduplication", ResponseNamespace="urn:iControl:Networking/iSessionDeduplication")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_dictionary(

	) {
		object [] results = this.Invoke("get_dictionary", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_dictionary(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dictionary", new object[0], callback, asyncState);
	}
	public string Endget_dictionary(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dictionary_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDeduplication", 
		RequestNamespace="urn:iControl:Networking/iSessionDeduplication", ResponseNamespace="urn:iControl:Networking/iSessionDeduplication")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_dictionary_size(

	) {
		object [] results = this.Invoke("get_dictionary_size", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_dictionary_size(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dictionary_size", new object[0], callback, asyncState);
	}
	public long Endget_dictionary_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDeduplication", 
		RequestNamespace="urn:iControl:Networking/iSessionDeduplication", ResponseNamespace="urn:iControl:Networking/iSessionDeduplication")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_enabled_state(

	) {
		object [] results = this.Invoke("get_enabled_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_endpoints
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDeduplication", 
		RequestNamespace="urn:iControl:Networking/iSessionDeduplication", ResponseNamespace="urn:iControl:Networking/iSessionDeduplication")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_maximum_endpoints(

	) {
		object [] results = this.Invoke("get_maximum_endpoints", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_endpoints(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_endpoints", new object[0], callback, asyncState);
	}
	public long Endget_maximum_endpoints(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDeduplication", 
		RequestNamespace="urn:iControl:Networking/iSessionDeduplication", ResponseNamespace="urn:iControl:Networking/iSessionDeduplication")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDeduplication", 
		RequestNamespace="urn:iControl:Networking/iSessionDeduplication", ResponseNamespace="urn:iControl:Networking/iSessionDeduplication")]
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
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDeduplication", 
		RequestNamespace="urn:iControl:Networking/iSessionDeduplication", ResponseNamespace="urn:iControl:Networking/iSessionDeduplication")]
	public void set_enabled_state(
		CommonEnabledState state
	) {
		this.Invoke("set_enabled_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_enabled_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_endpoints
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDeduplication", 
		RequestNamespace="urn:iControl:Networking/iSessionDeduplication", ResponseNamespace="urn:iControl:Networking/iSessionDeduplication")]
	public void set_maximum_endpoints(
		long value
	) {
		this.Invoke("set_maximum_endpoints", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_maximum_endpoints(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_endpoints", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_maximum_endpoints(System.IAsyncResult asyncResult) {
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
