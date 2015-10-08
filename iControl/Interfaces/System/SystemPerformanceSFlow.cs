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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.PerformanceSFlowBinding", Namespace="urn:iControl")]
	public partial class SystemPerformanceSFlow : iControlInterface {
		public SystemPerformanceSFlow() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	public void create(
		string [] receivers,
		string [] addresses
	) {
		this.Invoke("create", new object [] {
				receivers,
				addresses});

	}
	public System.IAsyncResult Begincreate(string [] receivers,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			receivers,
			addresses}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_sflow_receivers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	public void delete_all_sflow_receivers(

	) {
		this.Invoke("delete_all_sflow_receivers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_sflow_receivers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_sflow_receivers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_sflow_receivers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_sflow_receiver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	public void delete_sflow_receiver(
		string [] receivers
	) {
		this.Invoke("delete_sflow_receiver", new object [] {
				receivers});

	}
	public System.IAsyncResult Begindelete_sflow_receiver(string [] receivers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_sflow_receiver", new object[] {
			receivers}, callback, asyncState);
	}
	public void Enddelete_sflow_receiver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_address(
		string [] receivers
	) {
		object [] results = this.Invoke("get_address", new object [] {
				receivers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_address(string [] receivers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address", new object[] {
			receivers}, callback, asyncState);
	}
	public string [] Endget_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_datagram_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_datagram_version(
		string [] receivers
	) {
		object [] results = this.Invoke("get_datagram_version", new object [] {
				receivers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_datagram_version(string [] receivers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_datagram_version", new object[] {
			receivers}, callback, asyncState);
	}
	public long [] Endget_datagram_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
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
	// get_maximum_datagram_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_maximum_datagram_size(
		string [] receivers
	) {
		object [] results = this.Invoke("get_maximum_datagram_size", new object [] {
				receivers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_datagram_size(string [] receivers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_datagram_size", new object[] {
			receivers}, callback, asyncState);
	}
	public long [] Endget_maximum_datagram_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_poll_interval(
		string [] receivers
	) {
		object [] results = this.Invoke("get_poll_interval", new object [] {
				receivers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_poll_interval(string [] receivers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_poll_interval", new object[] {
			receivers}, callback, asyncState);
	}
	public long [] Endget_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_port(
		string [] receivers
	) {
		object [] results = this.Invoke("get_port", new object [] {
				receivers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_port(string [] receivers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_port", new object[] {
			receivers}, callback, asyncState);
	}
	public long [] Endget_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
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
	// set_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	public void set_address(
		string [] receivers,
		string [] addresses
	) {
		this.Invoke("set_address", new object [] {
				receivers,
				addresses});

	}
	public System.IAsyncResult Beginset_address(string [] receivers,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_address", new object[] {
			receivers,
			addresses}, callback, asyncState);
	}
	public void Endset_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_datagram_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	public void set_maximum_datagram_size(
		string [] receivers,
		long [] sizes
	) {
		this.Invoke("set_maximum_datagram_size", new object [] {
				receivers,
				sizes});

	}
	public System.IAsyncResult Beginset_maximum_datagram_size(string [] receivers,long [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_datagram_size", new object[] {
			receivers,
			sizes}, callback, asyncState);
	}
	public void Endset_maximum_datagram_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	public void set_poll_interval(
		string [] receivers,
		long [] intervals
	) {
		this.Invoke("set_poll_interval", new object [] {
				receivers,
				intervals});

	}
	public System.IAsyncResult Beginset_poll_interval(string [] receivers,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_poll_interval", new object[] {
			receivers,
			intervals}, callback, asyncState);
	}
	public void Endset_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/PerformanceSFlow", 
		RequestNamespace="urn:iControl:System/PerformanceSFlow", ResponseNamespace="urn:iControl:System/PerformanceSFlow")]
	public void set_port(
		string [] receivers,
		long [] ports
	) {
		this.Invoke("set_port", new object [] {
				receivers,
				ports});

	}
	public System.IAsyncResult Beginset_port(string [] receivers,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_port", new object[] {
			receivers,
			ports}, callback, asyncState);
	}
	public void Endset_port(System.IAsyncResult asyncResult) {
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
