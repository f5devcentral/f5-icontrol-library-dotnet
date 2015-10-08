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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.SFlowDataSourceBinding", Namespace="urn:iControl")]
	public partial class ManagementSFlowDataSource : iControlInterface {
		public ManagementSFlowDataSource() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_http_is_active
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_http_is_active(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_http_is_active", new object [] {
				data_sources});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_http_is_active(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_is_active", new object[] {
			data_sources}, callback, asyncState);
	}
	public bool [] Endget_http_is_active(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_http_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_http_list(

	) {
		object [] results = this.Invoke("get_http_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_http_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_list", new object[0], callback, asyncState);
	}
	public string [] Endget_http_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_http_poll_interval_effective
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_http_poll_interval_effective(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_http_poll_interval_effective", new object [] {
				data_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_http_poll_interval_effective(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_poll_interval_effective", new object[] {
			data_sources}, callback, asyncState);
	}
	public long [] Endget_http_poll_interval_effective(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_http_sampling_rate_effective
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_http_sampling_rate_effective(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_http_sampling_rate_effective", new object [] {
				data_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_http_sampling_rate_effective(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_sampling_rate_effective", new object[] {
			data_sources}, callback, asyncState);
	}
	public long [] Endget_http_sampling_rate_effective(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_http_subagent_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_http_subagent_id(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_http_subagent_id", new object [] {
				data_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_http_subagent_id(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_subagent_id", new object[] {
			data_sources}, callback, asyncState);
	}
	public long [] Endget_http_subagent_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_is_active
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_interface_is_active(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_interface_is_active", new object [] {
				data_sources});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_is_active(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_is_active", new object[] {
			data_sources}, callback, asyncState);
	}
	public bool [] Endget_interface_is_active(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_interface_list(

	) {
		object [] results = this.Invoke("get_interface_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_list", new object[0], callback, asyncState);
	}
	public string [] Endget_interface_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_poll_interval_effective
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_interface_poll_interval_effective(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_interface_poll_interval_effective", new object [] {
				data_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_poll_interval_effective(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_poll_interval_effective", new object[] {
			data_sources}, callback, asyncState);
	}
	public long [] Endget_interface_poll_interval_effective(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_subagent_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_interface_subagent_id(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_interface_subagent_id", new object [] {
				data_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_subagent_id(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_subagent_id", new object[] {
			data_sources}, callback, asyncState);
	}
	public long [] Endget_interface_subagent_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_is_active
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_system_is_active(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_system_is_active", new object [] {
				data_sources});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_system_is_active(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_is_active", new object[] {
			data_sources}, callback, asyncState);
	}
	public bool [] Endget_system_is_active(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_system_list(

	) {
		object [] results = this.Invoke("get_system_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_system_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_list", new object[0], callback, asyncState);
	}
	public string [] Endget_system_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_poll_interval_effective
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_system_poll_interval_effective(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_system_poll_interval_effective", new object [] {
				data_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_system_poll_interval_effective(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_poll_interval_effective", new object[] {
			data_sources}, callback, asyncState);
	}
	public long [] Endget_system_poll_interval_effective(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_subagent_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_system_subagent_id(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_system_subagent_id", new object [] {
				data_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_system_subagent_id(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_subagent_id", new object[] {
			data_sources}, callback, asyncState);
	}
	public long [] Endget_system_subagent_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
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
	// get_vlan_is_active
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_vlan_is_active(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_vlan_is_active", new object [] {
				data_sources});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan_is_active(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan_is_active", new object[] {
			data_sources}, callback, asyncState);
	}
	public bool [] Endget_vlan_is_active(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vlan_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_vlan_list(

	) {
		object [] results = this.Invoke("get_vlan_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan_list", new object[0], callback, asyncState);
	}
	public string [] Endget_vlan_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vlan_poll_interval_effective
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_vlan_poll_interval_effective(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_vlan_poll_interval_effective", new object [] {
				data_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan_poll_interval_effective(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan_poll_interval_effective", new object[] {
			data_sources}, callback, asyncState);
	}
	public long [] Endget_vlan_poll_interval_effective(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vlan_sampling_rate_effective
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_vlan_sampling_rate_effective(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_vlan_sampling_rate_effective", new object [] {
				data_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan_sampling_rate_effective(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan_sampling_rate_effective", new object[] {
			data_sources}, callback, asyncState);
	}
	public long [] Endget_vlan_sampling_rate_effective(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vlan_subagent_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SFlowDataSource", 
		RequestNamespace="urn:iControl:Management/SFlowDataSource", ResponseNamespace="urn:iControl:Management/SFlowDataSource")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_vlan_subagent_id(
		string [] data_sources
	) {
		object [] results = this.Invoke("get_vlan_subagent_id", new object [] {
				data_sources});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan_subagent_id(string [] data_sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan_subagent_id", new object[] {
			data_sources}, callback, asyncState);
	}
	public long [] Endget_vlan_subagent_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
