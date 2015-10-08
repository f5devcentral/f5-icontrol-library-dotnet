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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.TopologyBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBTopologyTopologyRecord))]
	public partial class GlobalLBTopology : iControlInterface {
		public GlobalLBTopology() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
	public void create(
		GlobalLBTopologyTopologyRecord [] records,
		long [] weights,
		long [] orders
	) {
		this.Invoke("create", new object [] {
				records,
				weights,
				orders});

	}
	public System.IAsyncResult Begincreate(GlobalLBTopologyTopologyRecord [] records,long [] weights,long [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			records,
			weights,
			orders}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_topology_records
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
	public void delete_all_topology_records(

	) {
		this.Invoke("delete_all_topology_records", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_topology_records(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_topology_records", new object[0], callback, asyncState);
	}
	public void Enddelete_all_topology_records(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_topology_record
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
	public void delete_topology_record(
		GlobalLBTopologyTopologyRecord [] records
	) {
		this.Invoke("delete_topology_record", new object [] {
				records});

	}
	public System.IAsyncResult Begindelete_topology_record(GlobalLBTopologyTopologyRecord [] records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_topology_record", new object[] {
			records}, callback, asyncState);
	}
	public void Enddelete_topology_record(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		GlobalLBTopologyTopologyRecord [] records
	) {
		object [] results = this.Invoke("get_description", new object [] {
				records});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(GlobalLBTopologyTopologyRecord [] records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			records}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBTopologyTopologyRecord [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((GlobalLBTopologyTopologyRecord [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public GlobalLBTopologyTopologyRecord [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBTopologyTopologyRecord [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_order(
		GlobalLBTopologyTopologyRecord [] records
	) {
		object [] results = this.Invoke("get_order", new object [] {
				records});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_order(GlobalLBTopologyTopologyRecord [] records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_order", new object[] {
			records}, callback, asyncState);
	}
	public long [] Endget_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
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
	// get_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_weight(
		GlobalLBTopologyTopologyRecord [] records
	) {
		object [] results = this.Invoke("get_weight", new object [] {
				records});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_weight(GlobalLBTopologyTopologyRecord [] records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_weight", new object[] {
			records}, callback, asyncState);
	}
	public long [] Endget_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
	public void set_description(
		GlobalLBTopologyTopologyRecord [] records,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				records,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(GlobalLBTopologyTopologyRecord [] records,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			records,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
	public void set_order(
		GlobalLBTopologyTopologyRecord [] records,
		long [] orders
	) {
		this.Invoke("set_order", new object [] {
				records,
				orders});

	}
	public System.IAsyncResult Beginset_order(GlobalLBTopologyTopologyRecord [] records,long [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_order", new object[] {
			records,
			orders}, callback, asyncState);
	}
	public void Endset_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Topology", 
		RequestNamespace="urn:iControl:GlobalLB/Topology", ResponseNamespace="urn:iControl:GlobalLB/Topology")]
	public void set_weight(
		GlobalLBTopologyTopologyRecord [] records,
		long [] weights
	) {
		this.Invoke("set_weight", new object [] {
				records,
				weights});

	}
	public System.IAsyncResult Beginset_weight(GlobalLBTopologyTopologyRecord [] records,long [] weights, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_weight", new object[] {
			records,
			weights}, callback, asyncState);
	}
	public void Endset_weight(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Topology.TopologyEndpoint", Namespace = "urn:iControl")]
	public partial class GlobalLBTopologyTopologyEndpoint
	{
		private GlobalLBRegionType typeField;
		public GlobalLBRegionType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private string contentField;
		public string content
		{
			get { return this.contentField; }
			set { this.contentField = value; }
		}
		private bool negateField;
		public bool negate
		{
			get { return this.negateField; }
			set { this.negateField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Topology.TopologyRecord", Namespace = "urn:iControl")]
	public partial class GlobalLBTopologyTopologyRecord
	{
		private GlobalLBTopologyTopologyEndpoint serverField;
		public GlobalLBTopologyTopologyEndpoint server
		{
			get { return this.serverField; }
			set { this.serverField = value; }
		}
		private GlobalLBTopologyTopologyEndpoint ldnsField;
		public GlobalLBTopologyTopologyEndpoint ldns
		{
			get { return this.ldnsField; }
			set { this.ldnsField = value; }
		}
	};

}
