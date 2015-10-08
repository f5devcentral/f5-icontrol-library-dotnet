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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.iSessionDatastorBinding", Namespace="urn:iControl")]
	public partial class NetworkingiSessionDatastor : iControlInterface {
		public NetworkingiSessionDatastor() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
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
	// get_disk_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_disk_cache_size(

	) {
		object [] results = this.Invoke("get_disk_cache_size", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_disk_cache_size(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_disk_cache_size", new object[0], callback, asyncState);
	}
	public long Endget_disk_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_disk_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_disk_state(

	) {
		object [] results = this.Invoke("get_disk_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_disk_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_disk_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_disk_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_memory_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_memory_cache_size(

	) {
		object [] results = this.Invoke("get_memory_cache_size", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_memory_cache_size(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_memory_cache_size", new object[0], callback, asyncState);
	}
	public long Endget_memory_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pruning_high_water_mark
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_pruning_high_water_mark(

	) {
		object [] results = this.Invoke("get_pruning_high_water_mark", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_pruning_high_water_mark(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pruning_high_water_mark", new object[0], callback, asyncState);
	}
	public long Endget_pruning_high_water_mark(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pruning_low_water_mark
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_pruning_low_water_mark(

	) {
		object [] results = this.Invoke("get_pruning_low_water_mark", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_pruning_low_water_mark(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pruning_low_water_mark", new object[0], callback, asyncState);
	}
	public long Endget_pruning_low_water_mark(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
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
	// set_disk_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
	public void set_disk_state(
		CommonEnabledState state
	) {
		this.Invoke("set_disk_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_disk_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_disk_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_disk_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pruning_high_water_mark
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
	public void set_pruning_high_water_mark(
		long value
	) {
		this.Invoke("set_pruning_high_water_mark", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_pruning_high_water_mark(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pruning_high_water_mark", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_pruning_high_water_mark(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pruning_low_water_mark
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionDatastor", 
		RequestNamespace="urn:iControl:Networking/iSessionDatastor", ResponseNamespace="urn:iControl:Networking/iSessionDatastor")]
	public void set_pruning_low_water_mark(
		long value
	) {
		this.Invoke("set_pruning_low_water_mark", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_pruning_low_water_mark(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pruning_low_water_mark", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_pruning_low_water_mark(System.IAsyncResult asyncResult) {
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
