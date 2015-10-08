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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.RegionBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBRegionRegionDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBRegionRegionItem))]
	public partial class GlobalLBRegion : iControlInterface {
		public GlobalLBRegion() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_region_item
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
	public void add_region_item(
		GlobalLBRegionRegionDefinition [] regions,
		GlobalLBRegionRegionItem [] [] items
	) {
		this.Invoke("add_region_item", new object [] {
				regions,
				items});

	}
	public System.IAsyncResult Beginadd_region_item(GlobalLBRegionRegionDefinition [] regions,GlobalLBRegionRegionItem [] [] items, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_region_item", new object[] {
			regions,
			items}, callback, asyncState);
	}
	public void Endadd_region_item(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
	public void create(
		GlobalLBRegionRegionDefinition [] regions,
		GlobalLBRegionRegionItem [] [] items
	) {
		this.Invoke("create", new object [] {
				regions,
				items});

	}
	public System.IAsyncResult Begincreate(GlobalLBRegionRegionDefinition [] regions,GlobalLBRegionRegionItem [] [] items, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			regions,
			items}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_region_definitions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
	public void delete_all_region_definitions(

	) {
		this.Invoke("delete_all_region_definitions", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_region_definitions(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_region_definitions", new object[0], callback, asyncState);
	}
	public void Enddelete_all_region_definitions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_region_definition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
	public void delete_region_definition(
		GlobalLBRegionRegionDefinition [] regions
	) {
		this.Invoke("delete_region_definition", new object [] {
				regions});

	}
	public System.IAsyncResult Begindelete_region_definition(GlobalLBRegionRegionDefinition [] regions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_region_definition", new object[] {
			regions}, callback, asyncState);
	}
	public void Enddelete_region_definition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		GlobalLBRegionRegionDefinition [] regions
	) {
		object [] results = this.Invoke("get_description", new object [] {
				regions});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(GlobalLBRegionRegionDefinition [] regions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			regions}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBRegionRegionDefinition [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((GlobalLBRegionRegionDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public GlobalLBRegionRegionDefinition [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBRegionRegionDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_region_item
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBRegionRegionItem [] [] get_region_item(
		GlobalLBRegionRegionDefinition [] regions
	) {
		object [] results = this.Invoke("get_region_item", new object [] {
				regions});
		return ((GlobalLBRegionRegionItem [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_region_item(GlobalLBRegionRegionDefinition [] regions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_region_item", new object[] {
			regions}, callback, asyncState);
	}
	public GlobalLBRegionRegionItem [] [] Endget_region_item(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBRegionRegionItem [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
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
	// remove_all_region_items
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
	public void remove_all_region_items(
		GlobalLBRegionRegionDefinition [] regions
	) {
		this.Invoke("remove_all_region_items", new object [] {
				regions});

	}
	public System.IAsyncResult Beginremove_all_region_items(GlobalLBRegionRegionDefinition [] regions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_region_items", new object[] {
			regions}, callback, asyncState);
	}
	public void Endremove_all_region_items(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_region_item
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
	public void remove_region_item(
		GlobalLBRegionRegionDefinition [] regions,
		GlobalLBRegionRegionItem [] [] items
	) {
		this.Invoke("remove_region_item", new object [] {
				regions,
				items});

	}
	public System.IAsyncResult Beginremove_region_item(GlobalLBRegionRegionDefinition [] regions,GlobalLBRegionRegionItem [] [] items, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_region_item", new object[] {
			regions,
			items}, callback, asyncState);
	}
	public void Endremove_region_item(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Region", 
		RequestNamespace="urn:iControl:GlobalLB/Region", ResponseNamespace="urn:iControl:GlobalLB/Region")]
	public void set_description(
		GlobalLBRegionRegionDefinition [] regions,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				regions,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(GlobalLBRegionRegionDefinition [] regions,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			regions,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Region.RegionDefinition", Namespace = "urn:iControl")]
	public partial class GlobalLBRegionRegionDefinition
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private GlobalLBRegionDBType db_typeField;
		public GlobalLBRegionDBType db_type
		{
			get { return this.db_typeField; }
			set { this.db_typeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Region.RegionItem", Namespace = "urn:iControl")]
	public partial class GlobalLBRegionRegionItem
	{
		private string contentField;
		public string content
		{
			get { return this.contentField; }
			set { this.contentField = value; }
		}
		private GlobalLBRegionType typeField;
		public GlobalLBRegionType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private bool negateField;
		public bool negate
		{
			get { return this.negateField; }
			set { this.negateField = value; }
		}
	};

}
