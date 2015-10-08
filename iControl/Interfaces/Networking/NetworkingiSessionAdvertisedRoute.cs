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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.iSessionAdvertisedRouteBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingiSessionAdvertisedRouteiSessionAdvertisedRouteStruct))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingiSessionAdvertisedRouteSubnetOptKey))]
	public partial class NetworkingiSessionAdvertisedRoute : iControlInterface {
		public NetworkingiSessionAdvertisedRoute() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
	public void create(
		NetworkingiSessionAdvertisedRouteiSessionAdvertisedRouteStruct subnet
	) {
		this.Invoke("create", new object [] {
				subnet});

	}
	public System.IAsyncResult Begincreate(NetworkingiSessionAdvertisedRouteiSessionAdvertisedRouteStruct subnet, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			subnet}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_subnets
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
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
	// delete_subnets
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
	public void delete_subnets(
		NetworkingiSessionAdvertisedRouteSubnetOptKey [] subnets
	) {
		this.Invoke("delete_subnets", new object [] {
				subnets});

	}
	public System.IAsyncResult Begindelete_subnets(NetworkingiSessionAdvertisedRouteSubnetOptKey [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_subnets", new object[] {
			subnets}, callback, asyncState);
	}
	public void Enddelete_subnets(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		NetworkingiSessionAdvertisedRouteSubnetOptKey [] subnets
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				subnets});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(NetworkingiSessionAdvertisedRouteSubnetOptKey [] subnets, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_label(
		NetworkingiSessionAdvertisedRouteSubnetOptKey [] subnets
	) {
		object [] results = this.Invoke("get_label", new object [] {
				subnets});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_label(NetworkingiSessionAdvertisedRouteSubnetOptKey [] subnets, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingiSessionAdvertisedRouteSubnetOptKey [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((NetworkingiSessionAdvertisedRouteSubnetOptKey [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public NetworkingiSessionAdvertisedRouteSubnetOptKey [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingiSessionAdvertisedRouteSubnetOptKey [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_metric(
		NetworkingiSessionAdvertisedRouteSubnetOptKey [] subnets
	) {
		object [] results = this.Invoke("get_metric", new object [] {
				subnets});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_metric(NetworkingiSessionAdvertisedRouteSubnetOptKey [] subnets, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
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
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
	public void set_enabled_state(
		NetworkingiSessionAdvertisedRouteSubnetOptKey [] ip,
		CommonEnabledState [] included
	) {
		this.Invoke("set_enabled_state", new object [] {
				ip,
				included});

	}
	public System.IAsyncResult Beginset_enabled_state(NetworkingiSessionAdvertisedRouteSubnetOptKey [] ip,CommonEnabledState [] included, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			ip,
			included}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_label
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
	public void set_label(
		NetworkingiSessionAdvertisedRouteSubnetOptKey [] ip,
		string [] labels
	) {
		this.Invoke("set_label", new object [] {
				ip,
				labels});

	}
	public System.IAsyncResult Beginset_label(NetworkingiSessionAdvertisedRouteSubnetOptKey [] ip,string [] labels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_label", new object[] {
			ip,
			labels}, callback, asyncState);
	}
	public void Endset_label(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionAdvertisedRoute", 
		RequestNamespace="urn:iControl:Networking/iSessionAdvertisedRoute", ResponseNamespace="urn:iControl:Networking/iSessionAdvertisedRoute")]
	public void set_metric(
		NetworkingiSessionAdvertisedRouteSubnetOptKey [] subnet,
		long [] metric
	) {
		this.Invoke("set_metric", new object [] {
				subnet,
				metric});

	}
	public System.IAsyncResult Beginset_metric(NetworkingiSessionAdvertisedRouteSubnetOptKey [] subnet,long [] metric, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metric", new object[] {
			subnet,
			metric}, callback, asyncState);
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.iSessionAdvertisedRoute.SubnetOptKey", Namespace = "urn:iControl")]
	public partial class NetworkingiSessionAdvertisedRouteSubnetOptKey
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.iSessionAdvertisedRoute.iSessionAdvertisedRouteStruct", Namespace = "urn:iControl")]
	public partial class NetworkingiSessionAdvertisedRouteiSessionAdvertisedRouteStruct
	{
		private NetworkingiSessionAdvertisedRouteSubnetOptKey keyField;
		public NetworkingiSessionAdvertisedRouteSubnetOptKey key
		{
			get { return this.keyField; }
			set { this.keyField = value; }
		}
		private CommonEnabledState includedField;
		public CommonEnabledState included
		{
			get { return this.includedField; }
			set { this.includedField = value; }
		}
		private long metricField;
		public long metric
		{
			get { return this.metricField; }
			set { this.metricField = value; }
		}
		private string labelField;
		public string label
		{
			get { return this.labelField; }
			set { this.labelField = value; }
		}
	};

}
