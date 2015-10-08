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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.AdminIPBinding", Namespace="urn:iControl")]
	public partial class NetworkingAdminIP : iControlInterface {
		public NetworkingAdminIP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void create(
		string [] admin_ips,
		string [] netmasks
	) {
		this.Invoke("create", new object [] {
				admin_ips,
				netmasks});

	}
	public System.IAsyncResult Begincreate(string [] admin_ips,string [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			admin_ips,
			netmasks}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_cluster
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void create_cluster(
		string [] cluster_names,
		string [] [] cluster_ips,
		string [] [] netmasks
	) {
		this.Invoke("create_cluster", new object [] {
				cluster_names,
				cluster_ips,
				netmasks});

	}
	public System.IAsyncResult Begincreate_cluster(string [] cluster_names,string [] [] cluster_ips,string [] [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_cluster", new object[] {
			cluster_names,
			cluster_ips,
			netmasks}, callback, asyncState);
	}
	public void Endcreate_cluster(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_slot_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void create_slot_ip(
		string cluster_name,
		long [] slot_ids,
		string [] [] slot_ips
	) {
		this.Invoke("create_slot_ip", new object [] {
				cluster_name,
				slot_ids,
				slot_ips});

	}
	public System.IAsyncResult Begincreate_slot_ip(string cluster_name,long [] slot_ids,string [] [] slot_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_slot_ip", new object[] {
			cluster_name,
			slot_ids,
			slot_ips}, callback, asyncState);
	}
	public void Endcreate_slot_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_administrative_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void delete_administrative_ip(
		string [] admin_ips
	) {
		this.Invoke("delete_administrative_ip", new object [] {
				admin_ips});

	}
	public System.IAsyncResult Begindelete_administrative_ip(string [] admin_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_administrative_ip", new object[] {
			admin_ips}, callback, asyncState);
	}
	public void Enddelete_administrative_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_administrative_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void delete_all_administrative_ips(

	) {
		this.Invoke("delete_all_administrative_ips", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_administrative_ips(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_administrative_ips", new object[0], callback, asyncState);
	}
	public void Enddelete_all_administrative_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_cluster_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void delete_all_cluster_ips(
		string [] cluster_names
	) {
		this.Invoke("delete_all_cluster_ips", new object [] {
				cluster_names});

	}
	public System.IAsyncResult Begindelete_all_cluster_ips(string [] cluster_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_cluster_ips", new object[] {
			cluster_names}, callback, asyncState);
	}
	public void Enddelete_all_cluster_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_slot_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void delete_all_slot_ips(
		string [] cluster_names,
		long [] [] slot_ids
	) {
		this.Invoke("delete_all_slot_ips", new object [] {
				cluster_names,
				slot_ids});

	}
	public System.IAsyncResult Begindelete_all_slot_ips(string [] cluster_names,long [] [] slot_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_slot_ips", new object[] {
			cluster_names,
			slot_ids}, callback, asyncState);
	}
	public void Enddelete_all_slot_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_cluster_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void delete_cluster_ip(
		string [] cluster_names,
		string [] [] cluster_ips
	) {
		this.Invoke("delete_cluster_ip", new object [] {
				cluster_names,
				cluster_ips});

	}
	public System.IAsyncResult Begindelete_cluster_ip(string [] cluster_names,string [] [] cluster_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_cluster_ip", new object[] {
			cluster_names,
			cluster_ips}, callback, asyncState);
	}
	public void Enddelete_cluster_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_slot_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void delete_slot_ip(
		string cluster_name,
		long [] slot_ids,
		string [] [] slot_ips
	) {
		this.Invoke("delete_slot_ip", new object [] {
				cluster_name,
				slot_ids,
				slot_ips});

	}
	public System.IAsyncResult Begindelete_slot_ip(string cluster_name,long [] slot_ids,string [] [] slot_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_slot_ip", new object[] {
			cluster_name,
			slot_ids,
			slot_ips}, callback, asyncState);
	}
	public void Enddelete_slot_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_cluster_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_cluster_list(
		string [] cluster_names
	) {
		object [] results = this.Invoke("get_cluster_list", new object [] {
				cluster_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_list(string [] cluster_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_list", new object[] {
			cluster_names}, callback, asyncState);
	}
	public string [] [] Endget_cluster_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_cluster_netmask(
		string [] cluster_names,
		string [] [] cluster_ips
	) {
		object [] results = this.Invoke("get_cluster_netmask", new object [] {
				cluster_names,
				cluster_ips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_netmask(string [] cluster_names,string [] [] cluster_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_netmask", new object[] {
			cluster_names,
			cluster_ips}, callback, asyncState);
	}
	public string [] [] Endget_cluster_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] admin_ips
	) {
		object [] results = this.Invoke("get_description", new object [] {
				admin_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] admin_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			admin_ips}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
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
	// get_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_netmask(
		string [] admin_ips
	) {
		object [] results = this.Invoke("get_netmask", new object [] {
				admin_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_netmask(string [] admin_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_netmask", new object[] {
			admin_ips}, callback, asyncState);
	}
	public string [] Endget_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slot_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_slot_ip(
		string cluster_name,
		long [] slot_ids
	) {
		object [] results = this.Invoke("get_slot_ip", new object [] {
				cluster_name,
				slot_ids});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_slot_ip(string cluster_name,long [] slot_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slot_ip", new object[] {
			cluster_name,
			slot_ids}, callback, asyncState);
	}
	public string [] [] Endget_slot_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
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
	// replace_administrative_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void replace_administrative_ip(
		string [] old_ips,
		string [] new_ips,
		string [] netmasks
	) {
		this.Invoke("replace_administrative_ip", new object [] {
				old_ips,
				new_ips,
				netmasks});

	}
	public System.IAsyncResult Beginreplace_administrative_ip(string [] old_ips,string [] new_ips,string [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_administrative_ip", new object[] {
			old_ips,
			new_ips,
			netmasks}, callback, asyncState);
	}
	public void Endreplace_administrative_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_cluster_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void replace_cluster_ip(
		string [] cluster_names,
		string [] [] old_ips,
		string [] [] new_ips,
		string [] [] netmasks
	) {
		this.Invoke("replace_cluster_ip", new object [] {
				cluster_names,
				old_ips,
				new_ips,
				netmasks});

	}
	public System.IAsyncResult Beginreplace_cluster_ip(string [] cluster_names,string [] [] old_ips,string [] [] new_ips,string [] [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_cluster_ip", new object[] {
			cluster_names,
			old_ips,
			new_ips,
			netmasks}, callback, asyncState);
	}
	public void Endreplace_cluster_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_slot_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void replace_slot_ip(
		string cluster_name,
		long [] slot_ids,
		string [] [] old_ips,
		string [] [] new_ips
	) {
		this.Invoke("replace_slot_ip", new object [] {
				cluster_name,
				slot_ids,
				old_ips,
				new_ips});

	}
	public System.IAsyncResult Beginreplace_slot_ip(string cluster_name,long [] slot_ids,string [] [] old_ips,string [] [] new_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_slot_ip", new object[] {
			cluster_name,
			slot_ids,
			old_ips,
			new_ips}, callback, asyncState);
	}
	public void Endreplace_slot_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cluster_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void set_cluster_netmask(
		string [] cluster_names,
		string [] [] cluster_ips,
		string [] [] netmasks
	) {
		this.Invoke("set_cluster_netmask", new object [] {
				cluster_names,
				cluster_ips,
				netmasks});

	}
	public System.IAsyncResult Beginset_cluster_netmask(string [] cluster_names,string [] [] cluster_ips,string [] [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cluster_netmask", new object[] {
			cluster_names,
			cluster_ips,
			netmasks}, callback, asyncState);
	}
	public void Endset_cluster_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void set_description(
		string [] admin_ips,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				admin_ips,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] admin_ips,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			admin_ips,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/AdminIP", 
		RequestNamespace="urn:iControl:Networking/AdminIP", ResponseNamespace="urn:iControl:Networking/AdminIP")]
	public void set_netmask(
		string [] admin_ips,
		string [] netmasks
	) {
		this.Invoke("set_netmask", new object [] {
				admin_ips,
				netmasks});

	}
	public System.IAsyncResult Beginset_netmask(string [] admin_ips,string [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_netmask", new object[] {
			admin_ips,
			netmasks}, callback, asyncState);
	}
	public void Endset_netmask(System.IAsyncResult asyncResult) {
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
