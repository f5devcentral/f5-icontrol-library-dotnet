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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.HAGroupBinding", Namespace="urn:iControl")]
	public partial class SystemHAGroup : iControlInterface {
		public SystemHAGroup() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_cluster
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void add_cluster(
		string [] ha_groups,
		string [] [] clusters,
		long [] [] weights
	) {
		this.Invoke("add_cluster", new object [] {
				ha_groups,
				clusters,
				weights});

	}
	public System.IAsyncResult Beginadd_cluster(string [] ha_groups,string [] [] clusters,long [] [] weights, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_cluster", new object[] {
			ha_groups,
			clusters,
			weights}, callback, asyncState);
	}
	public void Endadd_cluster(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void add_pool(
		string [] ha_groups,
		string [] [] pools,
		long [] [] weights
	) {
		this.Invoke("add_pool", new object [] {
				ha_groups,
				pools,
				weights});

	}
	public System.IAsyncResult Beginadd_pool(string [] ha_groups,string [] [] pools,long [] [] weights, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_pool", new object[] {
			ha_groups,
			pools,
			weights}, callback, asyncState);
	}
	public void Endadd_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_trunk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void add_trunk(
		string [] ha_groups,
		string [] [] trunks,
		long [] [] weights
	) {
		this.Invoke("add_trunk", new object [] {
				ha_groups,
				trunks,
				weights});

	}
	public System.IAsyncResult Beginadd_trunk(string [] ha_groups,string [] [] trunks,long [] [] weights, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_trunk", new object[] {
			ha_groups,
			trunks,
			weights}, callback, asyncState);
	}
	public void Endadd_trunk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void create(
		string [] ha_groups
	) {
		this.Invoke("create", new object [] {
				ha_groups});

	}
	public System.IAsyncResult Begincreate(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			ha_groups}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_high_availability_groups
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void delete_all_high_availability_groups(

	) {
		this.Invoke("delete_all_high_availability_groups", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_high_availability_groups(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_high_availability_groups", new object[0], callback, asyncState);
	}
	public void Enddelete_all_high_availability_groups(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_high_availability_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void delete_high_availability_group(
		string [] ha_groups
	) {
		this.Invoke("delete_high_availability_group", new object [] {
				ha_groups});

	}
	public System.IAsyncResult Begindelete_high_availability_group(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_high_availability_group", new object[] {
			ha_groups}, callback, asyncState);
	}
	public void Enddelete_high_availability_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_active_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_active_score(
		string [] ha_groups
	) {
		object [] results = this.Invoke("get_active_score", new object [] {
				ha_groups});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_active_score(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active_score", new object[] {
			ha_groups}, callback, asyncState);
	}
	public long [] Endget_active_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_cluster(
		string [] ha_groups
	) {
		object [] results = this.Invoke("get_cluster", new object [] {
				ha_groups});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster", new object[] {
			ha_groups}, callback, asyncState);
	}
	public string [] [] Endget_cluster(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster_attribute
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemHAGroupHAGroupClusterAttribute [] [] get_cluster_attribute(
		string [] ha_groups,
		string [] [] clusters
	) {
		object [] results = this.Invoke("get_cluster_attribute", new object [] {
				ha_groups,
				clusters});
		return ((SystemHAGroupHAGroupClusterAttribute [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_attribute(string [] ha_groups,string [] [] clusters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_attribute", new object[] {
			ha_groups,
			clusters}, callback, asyncState);
	}
	public SystemHAGroupHAGroupClusterAttribute [] [] Endget_cluster_attribute(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemHAGroupHAGroupClusterAttribute [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster_attribute_minimum_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_cluster_attribute_minimum_threshold(
		string [] ha_groups,
		string [] [] clusters
	) {
		object [] results = this.Invoke("get_cluster_attribute_minimum_threshold", new object [] {
				ha_groups,
				clusters});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_attribute_minimum_threshold(string [] ha_groups,string [] [] clusters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_attribute_minimum_threshold", new object[] {
			ha_groups,
			clusters}, callback, asyncState);
	}
	public long [] [] Endget_cluster_attribute_minimum_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster_attribute_sufficient_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_cluster_attribute_sufficient_threshold(
		string [] ha_groups,
		string [] [] clusters
	) {
		object [] results = this.Invoke("get_cluster_attribute_sufficient_threshold", new object [] {
				ha_groups,
				clusters});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_attribute_sufficient_threshold(string [] ha_groups,string [] [] clusters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_attribute_sufficient_threshold", new object[] {
			ha_groups,
			clusters}, callback, asyncState);
	}
	public long [] [] Endget_cluster_attribute_sufficient_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster_attribute_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_cluster_attribute_threshold(
		string [] ha_groups,
		string [] [] clusters
	) {
		object [] results = this.Invoke("get_cluster_attribute_threshold", new object [] {
				ha_groups,
				clusters});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_attribute_threshold(string [] ha_groups,string [] [] clusters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_attribute_threshold", new object[] {
			ha_groups,
			clusters}, callback, asyncState);
	}
	public long [] [] Endget_cluster_attribute_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster_attribute_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_cluster_attribute_value(
		string [] ha_groups,
		string [] [] clusters
	) {
		object [] results = this.Invoke("get_cluster_attribute_value", new object [] {
				ha_groups,
				clusters});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_attribute_value(string [] ha_groups,string [] [] clusters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_attribute_value", new object[] {
			ha_groups,
			clusters}, callback, asyncState);
	}
	public long [] [] Endget_cluster_attribute_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_cluster_score(
		string [] ha_groups,
		string [] [] clusters
	) {
		object [] results = this.Invoke("get_cluster_score", new object [] {
				ha_groups,
				clusters});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_score(string [] ha_groups,string [] [] clusters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_score", new object[] {
			ha_groups,
			clusters}, callback, asyncState);
	}
	public long [] [] Endget_cluster_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_cluster_weight(
		string [] ha_groups,
		string [] [] clusters
	) {
		object [] results = this.Invoke("get_cluster_weight", new object [] {
				ha_groups,
				clusters});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_weight(string [] ha_groups,string [] [] clusters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_weight", new object[] {
			ha_groups,
			clusters}, callback, asyncState);
	}
	public long [] [] Endget_cluster_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] ha_groups
	) {
		object [] results = this.Invoke("get_description", new object [] {
				ha_groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			ha_groups}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] ha_groups
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				ha_groups});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			ha_groups}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
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
	// get_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_pool(
		string [] ha_groups
	) {
		object [] results = this.Invoke("get_pool", new object [] {
				ha_groups});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool", new object[] {
			ha_groups}, callback, asyncState);
	}
	public string [] [] Endget_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool_attribute
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemHAGroupHAGroupPoolAttribute [] [] get_pool_attribute(
		string [] ha_groups,
		string [] [] pools
	) {
		object [] results = this.Invoke("get_pool_attribute", new object [] {
				ha_groups,
				pools});
		return ((SystemHAGroupHAGroupPoolAttribute [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool_attribute(string [] ha_groups,string [] [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool_attribute", new object[] {
			ha_groups,
			pools}, callback, asyncState);
	}
	public SystemHAGroupHAGroupPoolAttribute [] [] Endget_pool_attribute(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemHAGroupHAGroupPoolAttribute [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool_attribute_minimum_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_pool_attribute_minimum_threshold(
		string [] ha_groups,
		string [] [] pools
	) {
		object [] results = this.Invoke("get_pool_attribute_minimum_threshold", new object [] {
				ha_groups,
				pools});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool_attribute_minimum_threshold(string [] ha_groups,string [] [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool_attribute_minimum_threshold", new object[] {
			ha_groups,
			pools}, callback, asyncState);
	}
	public long [] [] Endget_pool_attribute_minimum_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool_attribute_sufficient_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_pool_attribute_sufficient_threshold(
		string [] ha_groups,
		string [] [] pools
	) {
		object [] results = this.Invoke("get_pool_attribute_sufficient_threshold", new object [] {
				ha_groups,
				pools});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool_attribute_sufficient_threshold(string [] ha_groups,string [] [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool_attribute_sufficient_threshold", new object[] {
			ha_groups,
			pools}, callback, asyncState);
	}
	public long [] [] Endget_pool_attribute_sufficient_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool_attribute_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_pool_attribute_threshold(
		string [] ha_groups,
		string [] [] pools
	) {
		object [] results = this.Invoke("get_pool_attribute_threshold", new object [] {
				ha_groups,
				pools});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool_attribute_threshold(string [] ha_groups,string [] [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool_attribute_threshold", new object[] {
			ha_groups,
			pools}, callback, asyncState);
	}
	public long [] [] Endget_pool_attribute_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool_attribute_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_pool_attribute_value(
		string [] ha_groups,
		string [] [] pools
	) {
		object [] results = this.Invoke("get_pool_attribute_value", new object [] {
				ha_groups,
				pools});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool_attribute_value(string [] ha_groups,string [] [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool_attribute_value", new object[] {
			ha_groups,
			pools}, callback, asyncState);
	}
	public long [] [] Endget_pool_attribute_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_pool_score(
		string [] ha_groups,
		string [] [] pools
	) {
		object [] results = this.Invoke("get_pool_score", new object [] {
				ha_groups,
				pools});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool_score(string [] ha_groups,string [] [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool_score", new object[] {
			ha_groups,
			pools}, callback, asyncState);
	}
	public long [] [] Endget_pool_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_pool_weight(
		string [] ha_groups,
		string [] [] pools
	) {
		object [] results = this.Invoke("get_pool_weight", new object [] {
				ha_groups,
				pools});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool_weight(string [] ha_groups,string [] [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool_weight", new object[] {
			ha_groups,
			pools}, callback, asyncState);
	}
	public long [] [] Endget_pool_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_total_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_total_score(
		string [] ha_groups
	) {
		object [] results = this.Invoke("get_total_score", new object [] {
				ha_groups});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_total_score(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_total_score", new object[] {
			ha_groups}, callback, asyncState);
	}
	public long [] Endget_total_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trunk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_trunk(
		string [] ha_groups
	) {
		object [] results = this.Invoke("get_trunk", new object [] {
				ha_groups});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_trunk(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trunk", new object[] {
			ha_groups}, callback, asyncState);
	}
	public string [] [] Endget_trunk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trunk_attribute
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemHAGroupHAGroupTrunkAttribute [] [] get_trunk_attribute(
		string [] ha_groups,
		string [] [] trunks
	) {
		object [] results = this.Invoke("get_trunk_attribute", new object [] {
				ha_groups,
				trunks});
		return ((SystemHAGroupHAGroupTrunkAttribute [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_trunk_attribute(string [] ha_groups,string [] [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trunk_attribute", new object[] {
			ha_groups,
			trunks}, callback, asyncState);
	}
	public SystemHAGroupHAGroupTrunkAttribute [] [] Endget_trunk_attribute(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemHAGroupHAGroupTrunkAttribute [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trunk_attribute_minimum_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_trunk_attribute_minimum_threshold(
		string [] ha_groups,
		string [] [] trunks
	) {
		object [] results = this.Invoke("get_trunk_attribute_minimum_threshold", new object [] {
				ha_groups,
				trunks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_trunk_attribute_minimum_threshold(string [] ha_groups,string [] [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trunk_attribute_minimum_threshold", new object[] {
			ha_groups,
			trunks}, callback, asyncState);
	}
	public long [] [] Endget_trunk_attribute_minimum_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trunk_attribute_sufficient_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_trunk_attribute_sufficient_threshold(
		string [] ha_groups,
		string [] [] trunks
	) {
		object [] results = this.Invoke("get_trunk_attribute_sufficient_threshold", new object [] {
				ha_groups,
				trunks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_trunk_attribute_sufficient_threshold(string [] ha_groups,string [] [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trunk_attribute_sufficient_threshold", new object[] {
			ha_groups,
			trunks}, callback, asyncState);
	}
	public long [] [] Endget_trunk_attribute_sufficient_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trunk_attribute_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_trunk_attribute_threshold(
		string [] ha_groups,
		string [] [] trunks
	) {
		object [] results = this.Invoke("get_trunk_attribute_threshold", new object [] {
				ha_groups,
				trunks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_trunk_attribute_threshold(string [] ha_groups,string [] [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trunk_attribute_threshold", new object[] {
			ha_groups,
			trunks}, callback, asyncState);
	}
	public long [] [] Endget_trunk_attribute_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trunk_attribute_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_trunk_attribute_value(
		string [] ha_groups,
		string [] [] trunks
	) {
		object [] results = this.Invoke("get_trunk_attribute_value", new object [] {
				ha_groups,
				trunks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_trunk_attribute_value(string [] ha_groups,string [] [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trunk_attribute_value", new object[] {
			ha_groups,
			trunks}, callback, asyncState);
	}
	public long [] [] Endget_trunk_attribute_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trunk_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_trunk_score(
		string [] ha_groups,
		string [] [] trunks
	) {
		object [] results = this.Invoke("get_trunk_score", new object [] {
				ha_groups,
				trunks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_trunk_score(string [] ha_groups,string [] [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trunk_score", new object[] {
			ha_groups,
			trunks}, callback, asyncState);
	}
	public long [] [] Endget_trunk_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trunk_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_trunk_weight(
		string [] ha_groups,
		string [] [] trunks
	) {
		object [] results = this.Invoke("get_trunk_weight", new object [] {
				ha_groups,
				trunks});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_trunk_weight(string [] ha_groups,string [] [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trunk_weight", new object[] {
			ha_groups,
			trunks}, callback, asyncState);
	}
	public long [] [] Endget_trunk_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
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
	// remove_all_clusters
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void remove_all_clusters(
		string [] ha_groups
	) {
		this.Invoke("remove_all_clusters", new object [] {
				ha_groups});

	}
	public System.IAsyncResult Beginremove_all_clusters(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_clusters", new object[] {
			ha_groups}, callback, asyncState);
	}
	public void Endremove_all_clusters(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_pools
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void remove_all_pools(
		string [] ha_groups
	) {
		this.Invoke("remove_all_pools", new object [] {
				ha_groups});

	}
	public System.IAsyncResult Beginremove_all_pools(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_pools", new object[] {
			ha_groups}, callback, asyncState);
	}
	public void Endremove_all_pools(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_trunks
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void remove_all_trunks(
		string [] ha_groups
	) {
		this.Invoke("remove_all_trunks", new object [] {
				ha_groups});

	}
	public System.IAsyncResult Beginremove_all_trunks(string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_trunks", new object[] {
			ha_groups}, callback, asyncState);
	}
	public void Endremove_all_trunks(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_cluster
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void remove_cluster(
		string [] ha_groups,
		string [] [] clusters
	) {
		this.Invoke("remove_cluster", new object [] {
				ha_groups,
				clusters});

	}
	public System.IAsyncResult Beginremove_cluster(string [] ha_groups,string [] [] clusters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_cluster", new object[] {
			ha_groups,
			clusters}, callback, asyncState);
	}
	public void Endremove_cluster(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void remove_pool(
		string [] ha_groups,
		string [] [] pools
	) {
		this.Invoke("remove_pool", new object [] {
				ha_groups,
				pools});

	}
	public System.IAsyncResult Beginremove_pool(string [] ha_groups,string [] [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_pool", new object[] {
			ha_groups,
			pools}, callback, asyncState);
	}
	public void Endremove_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_trunk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void remove_trunk(
		string [] ha_groups,
		string [] [] trunks
	) {
		this.Invoke("remove_trunk", new object [] {
				ha_groups,
				trunks});

	}
	public System.IAsyncResult Beginremove_trunk(string [] ha_groups,string [] [] trunks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_trunk", new object[] {
			ha_groups,
			trunks}, callback, asyncState);
	}
	public void Endremove_trunk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_active_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_active_score(
		string [] ha_groups,
		long [] scores
	) {
		this.Invoke("set_active_score", new object [] {
				ha_groups,
				scores});

	}
	public System.IAsyncResult Beginset_active_score(string [] ha_groups,long [] scores, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_active_score", new object[] {
			ha_groups,
			scores}, callback, asyncState);
	}
	public void Endset_active_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cluster_attribute
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_cluster_attribute(
		string [] ha_groups,
		string [] [] clusters,
		SystemHAGroupHAGroupClusterAttribute [] [] attributes
	) {
		this.Invoke("set_cluster_attribute", new object [] {
				ha_groups,
				clusters,
				attributes});

	}
	public System.IAsyncResult Beginset_cluster_attribute(string [] ha_groups,string [] [] clusters,SystemHAGroupHAGroupClusterAttribute [] [] attributes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cluster_attribute", new object[] {
			ha_groups,
			clusters,
			attributes}, callback, asyncState);
	}
	public void Endset_cluster_attribute(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cluster_attribute_minimum_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_cluster_attribute_minimum_threshold(
		string [] ha_groups,
		string [] [] clusters,
		long [] [] thresholds
	) {
		this.Invoke("set_cluster_attribute_minimum_threshold", new object [] {
				ha_groups,
				clusters,
				thresholds});

	}
	public System.IAsyncResult Beginset_cluster_attribute_minimum_threshold(string [] ha_groups,string [] [] clusters,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cluster_attribute_minimum_threshold", new object[] {
			ha_groups,
			clusters,
			thresholds}, callback, asyncState);
	}
	public void Endset_cluster_attribute_minimum_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cluster_attribute_sufficient_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_cluster_attribute_sufficient_threshold(
		string [] ha_groups,
		string [] [] clusters,
		long [] [] thresholds
	) {
		this.Invoke("set_cluster_attribute_sufficient_threshold", new object [] {
				ha_groups,
				clusters,
				thresholds});

	}
	public System.IAsyncResult Beginset_cluster_attribute_sufficient_threshold(string [] ha_groups,string [] [] clusters,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cluster_attribute_sufficient_threshold", new object[] {
			ha_groups,
			clusters,
			thresholds}, callback, asyncState);
	}
	public void Endset_cluster_attribute_sufficient_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cluster_attribute_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_cluster_attribute_threshold(
		string [] ha_groups,
		string [] [] clusters,
		long [] [] thresholds
	) {
		this.Invoke("set_cluster_attribute_threshold", new object [] {
				ha_groups,
				clusters,
				thresholds});

	}
	public System.IAsyncResult Beginset_cluster_attribute_threshold(string [] ha_groups,string [] [] clusters,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cluster_attribute_threshold", new object[] {
			ha_groups,
			clusters,
			thresholds}, callback, asyncState);
	}
	public void Endset_cluster_attribute_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cluster_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_cluster_weight(
		string [] ha_groups,
		string [] [] clusters,
		long [] [] weights
	) {
		this.Invoke("set_cluster_weight", new object [] {
				ha_groups,
				clusters,
				weights});

	}
	public System.IAsyncResult Beginset_cluster_weight(string [] ha_groups,string [] [] clusters,long [] [] weights, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cluster_weight", new object[] {
			ha_groups,
			clusters,
			weights}, callback, asyncState);
	}
	public void Endset_cluster_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_description(
		string [] ha_groups,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				ha_groups,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] ha_groups,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			ha_groups,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_enabled_state(
		string [] ha_groups,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				ha_groups,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] ha_groups,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			ha_groups,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pool_attribute
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_pool_attribute(
		string [] ha_groups,
		string [] [] pools,
		SystemHAGroupHAGroupPoolAttribute [] [] attributes
	) {
		this.Invoke("set_pool_attribute", new object [] {
				ha_groups,
				pools,
				attributes});

	}
	public System.IAsyncResult Beginset_pool_attribute(string [] ha_groups,string [] [] pools,SystemHAGroupHAGroupPoolAttribute [] [] attributes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pool_attribute", new object[] {
			ha_groups,
			pools,
			attributes}, callback, asyncState);
	}
	public void Endset_pool_attribute(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pool_attribute_minimum_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_pool_attribute_minimum_threshold(
		string [] ha_groups,
		string [] [] pools,
		long [] [] thresholds
	) {
		this.Invoke("set_pool_attribute_minimum_threshold", new object [] {
				ha_groups,
				pools,
				thresholds});

	}
	public System.IAsyncResult Beginset_pool_attribute_minimum_threshold(string [] ha_groups,string [] [] pools,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pool_attribute_minimum_threshold", new object[] {
			ha_groups,
			pools,
			thresholds}, callback, asyncState);
	}
	public void Endset_pool_attribute_minimum_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pool_attribute_sufficient_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_pool_attribute_sufficient_threshold(
		string [] ha_groups,
		string [] [] pools,
		long [] [] thresholds
	) {
		this.Invoke("set_pool_attribute_sufficient_threshold", new object [] {
				ha_groups,
				pools,
				thresholds});

	}
	public System.IAsyncResult Beginset_pool_attribute_sufficient_threshold(string [] ha_groups,string [] [] pools,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pool_attribute_sufficient_threshold", new object[] {
			ha_groups,
			pools,
			thresholds}, callback, asyncState);
	}
	public void Endset_pool_attribute_sufficient_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pool_attribute_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_pool_attribute_threshold(
		string [] ha_groups,
		string [] [] pools,
		long [] [] thresholds
	) {
		this.Invoke("set_pool_attribute_threshold", new object [] {
				ha_groups,
				pools,
				thresholds});

	}
	public System.IAsyncResult Beginset_pool_attribute_threshold(string [] ha_groups,string [] [] pools,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pool_attribute_threshold", new object[] {
			ha_groups,
			pools,
			thresholds}, callback, asyncState);
	}
	public void Endset_pool_attribute_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pool_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_pool_weight(
		string [] ha_groups,
		string [] [] pools,
		long [] [] weights
	) {
		this.Invoke("set_pool_weight", new object [] {
				ha_groups,
				pools,
				weights});

	}
	public System.IAsyncResult Beginset_pool_weight(string [] ha_groups,string [] [] pools,long [] [] weights, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pool_weight", new object[] {
			ha_groups,
			pools,
			weights}, callback, asyncState);
	}
	public void Endset_pool_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trunk_attribute
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_trunk_attribute(
		string [] ha_groups,
		string [] [] trunks,
		SystemHAGroupHAGroupTrunkAttribute [] [] attributes
	) {
		this.Invoke("set_trunk_attribute", new object [] {
				ha_groups,
				trunks,
				attributes});

	}
	public System.IAsyncResult Beginset_trunk_attribute(string [] ha_groups,string [] [] trunks,SystemHAGroupHAGroupTrunkAttribute [] [] attributes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trunk_attribute", new object[] {
			ha_groups,
			trunks,
			attributes}, callback, asyncState);
	}
	public void Endset_trunk_attribute(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trunk_attribute_minimum_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_trunk_attribute_minimum_threshold(
		string [] ha_groups,
		string [] [] trunks,
		long [] [] thresholds
	) {
		this.Invoke("set_trunk_attribute_minimum_threshold", new object [] {
				ha_groups,
				trunks,
				thresholds});

	}
	public System.IAsyncResult Beginset_trunk_attribute_minimum_threshold(string [] ha_groups,string [] [] trunks,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trunk_attribute_minimum_threshold", new object[] {
			ha_groups,
			trunks,
			thresholds}, callback, asyncState);
	}
	public void Endset_trunk_attribute_minimum_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trunk_attribute_sufficient_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_trunk_attribute_sufficient_threshold(
		string [] ha_groups,
		string [] [] trunks,
		long [] [] thresholds
	) {
		this.Invoke("set_trunk_attribute_sufficient_threshold", new object [] {
				ha_groups,
				trunks,
				thresholds});

	}
	public System.IAsyncResult Beginset_trunk_attribute_sufficient_threshold(string [] ha_groups,string [] [] trunks,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trunk_attribute_sufficient_threshold", new object[] {
			ha_groups,
			trunks,
			thresholds}, callback, asyncState);
	}
	public void Endset_trunk_attribute_sufficient_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trunk_attribute_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_trunk_attribute_threshold(
		string [] ha_groups,
		string [] [] trunks,
		long [] [] thresholds
	) {
		this.Invoke("set_trunk_attribute_threshold", new object [] {
				ha_groups,
				trunks,
				thresholds});

	}
	public System.IAsyncResult Beginset_trunk_attribute_threshold(string [] ha_groups,string [] [] trunks,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trunk_attribute_threshold", new object[] {
			ha_groups,
			trunks,
			thresholds}, callback, asyncState);
	}
	public void Endset_trunk_attribute_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trunk_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/HAGroup", 
		RequestNamespace="urn:iControl:System/HAGroup", ResponseNamespace="urn:iControl:System/HAGroup")]
	public void set_trunk_weight(
		string [] ha_groups,
		string [] [] trunks,
		long [] [] weights
	) {
		this.Invoke("set_trunk_weight", new object [] {
				ha_groups,
				trunks,
				weights});

	}
	public System.IAsyncResult Beginset_trunk_weight(string [] ha_groups,string [] [] trunks,long [] [] weights, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trunk_weight", new object[] {
			ha_groups,
			trunks,
			weights}, callback, asyncState);
	}
	public void Endset_trunk_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.HAGroup.HAGroupClusterAttribute", Namespace = "urn:iControl")]
	public enum SystemHAGroupHAGroupClusterAttribute
	{
		HA_GROUP_CLUSTER_UNKNOWN,
		HA_GROUP_CLUSTER_PERCENT_MEMBERS_UP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.HAGroup.HAGroupPoolAttribute", Namespace = "urn:iControl")]
	public enum SystemHAGroupHAGroupPoolAttribute
	{
		HA_GROUP_POOL_UNKNOWN,
		HA_GROUP_POOL_PERCENT_MEMBERS_UP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.HAGroup.HAGroupTrunkAttribute", Namespace = "urn:iControl")]
	public enum SystemHAGroupHAGroupTrunkAttribute
	{
		HA_GROUP_TRUNK_UNKNOWN,
		HA_GROUP_TRUNK_PERCENT_MEMBERS_UP,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
