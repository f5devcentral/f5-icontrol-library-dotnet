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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.PartitionBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementPartitionAuthZPartition))]
	public partial class ManagementPartition : iControlInterface {
		public ManagementPartition() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create_partition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
	public void create_partition(
		ManagementPartitionAuthZPartition [] partitions
	) {
		this.Invoke("create_partition", new object [] {
				partitions});

	}
	public System.IAsyncResult Begincreate_partition(ManagementPartitionAuthZPartition [] partitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_partition", new object[] {
			partitions}, callback, asyncState);
	}
	public void Endcreate_partition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_partitions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
	public void delete_all_partitions(

	) {
		this.Invoke("delete_all_partitions", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_partitions(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_partitions", new object[0], callback, asyncState);
	}
	public void Enddelete_all_partitions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_partition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
	public void delete_partition(
		string [] partition_names
	) {
		this.Invoke("delete_partition", new object [] {
				partition_names});

	}
	public System.IAsyncResult Begindelete_partition(string [] partition_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_partition", new object[] {
			partition_names}, callback, asyncState);
	}
	public void Enddelete_partition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_active_partition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_active_partition(

	) {
		object [] results = this.Invoke("get_active_partition", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_active_partition(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active_partition", new object[0], callback, asyncState);
	}
	public string Endget_active_partition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_default_route_domain(
		string [] partitions
	) {
		object [] results = this.Invoke("get_default_route_domain", new object [] {
				partitions});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_route_domain(string [] partitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_route_domain", new object[] {
			partitions}, callback, asyncState);
	}
	public long [] Endget_default_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] partitions
	) {
		object [] results = this.Invoke("get_description", new object [] {
				partitions});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] partitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			partitions}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_partition_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementPartitionAuthZPartition [] get_partition_list(

	) {
		object [] results = this.Invoke("get_partition_list", new object [0]);
		return ((ManagementPartitionAuthZPartition [])(results[0]));
	}
	public System.IAsyncResult Beginget_partition_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_partition_list", new object[0], callback, asyncState);
	}
	public ManagementPartitionAuthZPartition [] Endget_partition_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementPartitionAuthZPartition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
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
	// set_active_partition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
	public void set_active_partition(
		string active_partition
	) {
		this.Invoke("set_active_partition", new object [] {
				active_partition});

	}
	public System.IAsyncResult Beginset_active_partition(string active_partition, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_active_partition", new object[] {
			active_partition}, callback, asyncState);
	}
	public void Endset_active_partition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
	public void set_default_route_domain(
		string [] partitions,
		long [] route_domains
	) {
		this.Invoke("set_default_route_domain", new object [] {
				partitions,
				route_domains});

	}
	public System.IAsyncResult Beginset_default_route_domain(string [] partitions,long [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_route_domain", new object[] {
			partitions,
			route_domains}, callback, asyncState);
	}
	public void Endset_default_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Partition", 
		RequestNamespace="urn:iControl:Management/Partition", ResponseNamespace="urn:iControl:Management/Partition")]
	public void set_description(
		string [] partitions,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				partitions,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] partitions,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			partitions,
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.Partition.AuthZPartition", Namespace = "urn:iControl")]
	public partial class ManagementPartitionAuthZPartition
	{
		private string partition_nameField;
		public string partition_name
		{
			get { return this.partition_nameField; }
			set { this.partition_nameField = value; }
		}
		private string descriptionField;
		public string description
		{
			get { return this.descriptionField; }
			set { this.descriptionField = value; }
		}
	};

}
