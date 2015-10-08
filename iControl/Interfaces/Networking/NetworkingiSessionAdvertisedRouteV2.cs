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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.iSessionAdvertisedRouteV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingiSessionAdvertisedRouteV2RouteDestination))]
	public partial class NetworkingiSessionAdvertisedRouteV2 : iControlInterface {
		public NetworkingiSessionAdvertisedRouteV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	public void create(
		string [] subnets,
		NetworkingiSessionAdvertisedRouteV2RouteDestination [] destinations,
		CommonEnabledState [] states,
		long [] metrics,
		string [] labels
	) {
		this.Invoke("create", new object [] {
				subnets,
				destinations,
				states,
				metrics,
				labels});

	}
	public System.IAsyncResult Begincreate(string [] subnets,NetworkingiSessionAdvertisedRouteV2RouteDestination [] destinations,CommonEnabledState [] states,long [] metrics,string [] labels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			subnets,
			destinations,
			states,
			metrics,
			labels}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_subnets
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	public void delete_all_subnets(

	) {
		this.Invoke("delete_all_subnets", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_subnets(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_subnets", new object[0], callback, asyncState);
	}
	public void Enddelete_all_subnets(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_subnet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	public void delete_subnet(
		string [] subnets
	) {
		this.Invoke("delete_subnet", new object [] {
				subnets});

	}
	public System.IAsyncResult Begindelete_subnet(string [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_subnet", new object[] {
			subnets}, callback, asyncState);
	}
	public void Enddelete_subnet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] subnets
	) {
		object [] results = this.Invoke("get_description", new object [] {
				subnets});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			subnets}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingiSessionAdvertisedRouteV2RouteDestination [] get_destination(
		string [] subnets
	) {
		object [] results = this.Invoke("get_destination", new object [] {
				subnets});
		return ((NetworkingiSessionAdvertisedRouteV2RouteDestination [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination(string [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination", new object[] {
			subnets}, callback, asyncState);
	}
	public NetworkingiSessionAdvertisedRouteV2RouteDestination [] Endget_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingiSessionAdvertisedRouteV2RouteDestination [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] subnets
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				subnets});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			subnets}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_label
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_label(
		string [] subnets
	) {
		object [] results = this.Invoke("get_label", new object [] {
				subnets});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_label(string [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_label", new object[] {
			subnets}, callback, asyncState);
	}
	public string [] Endget_label(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
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
	// get_metric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_metric(
		string [] subnets
	) {
		object [] results = this.Invoke("get_metric", new object [] {
				subnets});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_metric(string [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metric", new object[] {
			subnets}, callback, asyncState);
	}
	public long [] Endget_metric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	public void set_description(
		string [] subnets,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				subnets,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] subnets,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			subnets,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	public void set_enabled_state(
		string [] subnets,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				subnets,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] subnets,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			subnets,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_label
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	public void set_label(
		string [] subnets,
		string [] labels
	) {
		this.Invoke("set_label", new object [] {
				subnets,
				labels});

	}
	public System.IAsyncResult Beginset_label(string [] subnets,string [] labels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_label", new object[] {
			subnets,
			labels}, callback, asyncState);
	}
	public void Endset_label(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRouteV2", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRouteV2")]
	public void set_metric(
		string [] subnets,
		long [] metrics
	) {
		this.Invoke("set_metric", new object [] {
				subnets,
				metrics});

	}
	public System.IAsyncResult Beginset_metric(string [] subnets,long [] metrics, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metric", new object[] {
			subnets,
			metrics}, callback, asyncState);
	}
	public void Endset_metric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.iSessionAdvertisedRouteV2.RouteDestination", Namespace = "urn:iControl")]
	public partial class NetworkingiSessionAdvertisedRouteV2RouteDestination
	{
		private string ipField;
		public string ip
		{
			get { return this.ipField; }
			set { this.ipField = value; }
		}
		private string maskField;
		public string mask
		{
			get { return this.maskField; }
			set { this.maskField = value; }
		}
	};

}
