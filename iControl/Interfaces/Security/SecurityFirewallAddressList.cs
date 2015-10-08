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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.FirewallAddressListBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonAddressRange))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonGeoLocation))]
	public partial class SecurityFirewallAddressList : iControlInterface {
		public SecurityFirewallAddressList() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void add_address(
		string [] lists,
		string [] [] addresses
	) {
		this.Invoke("add_address", new object [] {
				lists,
				addresses});

	}
	public System.IAsyncResult Beginadd_address(string [] lists,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_address", new object[] {
			lists,
			addresses}, callback, asyncState);
	}
	public void Endadd_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void add_address_range(
		string [] lists,
		CommonAddressRange [] [] ranges
	) {
		this.Invoke("add_address_range", new object [] {
				lists,
				ranges});

	}
	public System.IAsyncResult Beginadd_address_range(string [] lists,CommonAddressRange [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_address_range", new object[] {
			lists,
			ranges}, callback, asyncState);
	}
	public void Endadd_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void add_geo(
		string [] lists,
		CommonGeoLocation [] [] geos
	) {
		this.Invoke("add_geo", new object [] {
				lists,
				geos});

	}
	public System.IAsyncResult Beginadd_geo(string [] lists,CommonGeoLocation [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_geo", new object[] {
			lists,
			geos}, callback, asyncState);
	}
	public void Endadd_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_nested_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void add_nested_address_list(
		string [] lists,
		string [] [] nested_lists
	) {
		this.Invoke("add_nested_address_list", new object [] {
				lists,
				nested_lists});

	}
	public System.IAsyncResult Beginadd_nested_address_list(string [] lists,string [] [] nested_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_nested_address_list", new object[] {
			lists,
			nested_lists}, callback, asyncState);
	}
	public void Endadd_nested_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void create(
		string [] lists,
		string [] [] addresses
	) {
		this.Invoke("create", new object [] {
				lists,
				addresses});

	}
	public System.IAsyncResult Begincreate(string [] lists,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			lists,
			addresses}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_with_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void create_with_address_range(
		string [] lists,
		CommonAddressRange [] [] ranges
	) {
		this.Invoke("create_with_address_range", new object [] {
				lists,
				ranges});

	}
	public System.IAsyncResult Begincreate_with_address_range(string [] lists,CommonAddressRange [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_with_address_range", new object[] {
			lists,
			ranges}, callback, asyncState);
	}
	public void Endcreate_with_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_with_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void create_with_geo(
		string [] lists,
		CommonGeoLocation [] [] geos
	) {
		this.Invoke("create_with_geo", new object [] {
				lists,
				geos});

	}
	public System.IAsyncResult Begincreate_with_geo(string [] lists,CommonGeoLocation [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_with_geo", new object[] {
			lists,
			geos}, callback, asyncState);
	}
	public void Endcreate_with_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_with_nested_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void create_with_nested_address_list(
		string [] lists,
		string [] [] nested_lists
	) {
		this.Invoke("create_with_nested_address_list", new object [] {
				lists,
				nested_lists});

	}
	public System.IAsyncResult Begincreate_with_nested_address_list(string [] lists,string [] [] nested_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_with_nested_address_list", new object[] {
			lists,
			nested_lists}, callback, asyncState);
	}
	public void Endcreate_with_nested_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void delete_address_list(
		string [] lists
	) {
		this.Invoke("delete_address_list", new object [] {
				lists});

	}
	public System.IAsyncResult Begindelete_address_list(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_address_list", new object[] {
			lists}, callback, asyncState);
	}
	public void Enddelete_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void delete_all_address_lists(

	) {
		this.Invoke("delete_all_address_lists", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_address_lists(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_address_lists", new object[0], callback, asyncState);
	}
	public void Enddelete_all_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_address(
		string [] lists
	) {
		object [] results = this.Invoke("get_address", new object [] {
				lists});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_address(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address", new object[] {
			lists}, callback, asyncState);
	}
	public string [] [] Endget_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_address_description(
		string [] lists,
		string [] [] addresses
	) {
		object [] results = this.Invoke("get_address_description", new object [] {
				lists,
				addresses});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_address_description(string [] lists,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address_description", new object[] {
			lists,
			addresses}, callback, asyncState);
	}
	public string [] [] Endget_address_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] get_address_range(
		string [] lists
	) {
		object [] results = this.Invoke("get_address_range", new object [] {
				lists});
		return ((CommonAddressRange [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_address_range(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address_range", new object[] {
			lists}, callback, asyncState);
	}
	public CommonAddressRange [] [] Endget_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_address_range_description(
		string [] lists,
		CommonAddressRange [] [] ranges
	) {
		object [] results = this.Invoke("get_address_range_description", new object [] {
				lists,
				ranges});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_address_range_description(string [] lists,CommonAddressRange [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address_range_description", new object[] {
			lists,
			ranges}, callback, asyncState);
	}
	public string [] [] Endget_address_range_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] lists
	) {
		object [] results = this.Invoke("get_description", new object [] {
				lists});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			lists}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] get_geo(
		string [] lists
	) {
		object [] results = this.Invoke("get_geo", new object [] {
				lists});
		return ((CommonGeoLocation [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_geo(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_geo", new object[] {
			lists}, callback, asyncState);
	}
	public CommonGeoLocation [] [] Endget_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_geo_description(
		string [] lists,
		CommonGeoLocation [] [] geos
	) {
		object [] results = this.Invoke("get_geo_description", new object [] {
				lists,
				geos});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_geo_description(string [] lists,CommonGeoLocation [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_geo_description", new object[] {
			lists,
			geos}, callback, asyncState);
	}
	public string [] [] Endget_geo_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
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
	// get_nested_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_nested_address_list(
		string [] lists
	) {
		object [] results = this.Invoke("get_nested_address_list", new object [] {
				lists});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_nested_address_list(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nested_address_list", new object[] {
			lists}, callback, asyncState);
	}
	public string [] [] Endget_nested_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nested_address_list_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_nested_address_list_description(
		string [] lists,
		string [] [] nested_lists
	) {
		object [] results = this.Invoke("get_nested_address_list_description", new object [] {
				lists,
				nested_lists});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_nested_address_list_description(string [] lists,string [] [] nested_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nested_address_list_description", new object[] {
			lists,
			nested_lists}, callback, asyncState);
	}
	public string [] [] Endget_nested_address_list_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
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
	// remove_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void remove_address(
		string [] lists,
		string [] [] addresses
	) {
		this.Invoke("remove_address", new object [] {
				lists,
				addresses});

	}
	public System.IAsyncResult Beginremove_address(string [] lists,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_address", new object[] {
			lists,
			addresses}, callback, asyncState);
	}
	public void Endremove_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void remove_address_range(
		string [] lists,
		CommonAddressRange [] [] ranges
	) {
		this.Invoke("remove_address_range", new object [] {
				lists,
				ranges});

	}
	public System.IAsyncResult Beginremove_address_range(string [] lists,CommonAddressRange [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_address_range", new object[] {
			lists,
			ranges}, callback, asyncState);
	}
	public void Endremove_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void remove_all_address_ranges(
		string [] lists
	) {
		this.Invoke("remove_all_address_ranges", new object [] {
				lists});

	}
	public System.IAsyncResult Beginremove_all_address_ranges(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_address_ranges", new object[] {
			lists}, callback, asyncState);
	}
	public void Endremove_all_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void remove_all_addresses(
		string [] lists
	) {
		this.Invoke("remove_all_addresses", new object [] {
				lists});

	}
	public System.IAsyncResult Beginremove_all_addresses(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_addresses", new object[] {
			lists}, callback, asyncState);
	}
	public void Endremove_all_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void remove_all_geos(
		string [] lists
	) {
		this.Invoke("remove_all_geos", new object [] {
				lists});

	}
	public System.IAsyncResult Beginremove_all_geos(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_geos", new object[] {
			lists}, callback, asyncState);
	}
	public void Endremove_all_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_nested_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void remove_all_nested_address_lists(
		string [] lists
	) {
		this.Invoke("remove_all_nested_address_lists", new object [] {
				lists});

	}
	public System.IAsyncResult Beginremove_all_nested_address_lists(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_nested_address_lists", new object[] {
			lists}, callback, asyncState);
	}
	public void Endremove_all_nested_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void remove_geo(
		string [] lists,
		CommonGeoLocation [] [] geos
	) {
		this.Invoke("remove_geo", new object [] {
				lists,
				geos});

	}
	public System.IAsyncResult Beginremove_geo(string [] lists,CommonGeoLocation [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_geo", new object[] {
			lists,
			geos}, callback, asyncState);
	}
	public void Endremove_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_nested_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void remove_nested_address_list(
		string [] lists,
		string [] [] nested_lists
	) {
		this.Invoke("remove_nested_address_list", new object [] {
				lists,
				nested_lists});

	}
	public System.IAsyncResult Beginremove_nested_address_list(string [] lists,string [] [] nested_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_nested_address_list", new object[] {
			lists,
			nested_lists}, callback, asyncState);
	}
	public void Endremove_nested_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void set_address_description(
		string [] lists,
		string [] [] addresses,
		string [] [] descriptions
	) {
		this.Invoke("set_address_description", new object [] {
				lists,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_address_description(string [] lists,string [] [] addresses,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_address_description", new object[] {
			lists,
			addresses,
			descriptions}, callback, asyncState);
	}
	public void Endset_address_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void set_address_range_description(
		string [] lists,
		CommonAddressRange [] [] ranges,
		string [] [] descriptions
	) {
		this.Invoke("set_address_range_description", new object [] {
				lists,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_address_range_description(string [] lists,CommonAddressRange [] [] ranges,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_address_range_description", new object[] {
			lists,
			ranges,
			descriptions}, callback, asyncState);
	}
	public void Endset_address_range_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void set_description(
		string [] lists,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				lists,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] lists,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			lists,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void set_geo_description(
		string [] lists,
		CommonGeoLocation [] [] geos,
		string [] [] descriptions
	) {
		this.Invoke("set_geo_description", new object [] {
				lists,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_geo_description(string [] lists,CommonGeoLocation [] [] geos,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_geo_description", new object[] {
			lists,
			geos,
			descriptions}, callback, asyncState);
	}
	public void Endset_geo_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nested_address_list_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallAddressList", 
		RequestNamespace="urn:iControl:Security/FirewallAddressList", ResponseNamespace="urn:iControl:Security/FirewallAddressList")]
	public void set_nested_address_list_description(
		string [] lists,
		string [] [] nested_lists,
		string [] [] descriptions
	) {
		this.Invoke("set_nested_address_list_description", new object [] {
				lists,
				nested_lists,
				descriptions});

	}
	public System.IAsyncResult Beginset_nested_address_list_description(string [] lists,string [] [] nested_lists,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nested_address_list_description", new object[] {
			lists,
			nested_lists,
			descriptions}, callback, asyncState);
	}
	public void Endset_nested_address_list_description(System.IAsyncResult asyncResult) {
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
