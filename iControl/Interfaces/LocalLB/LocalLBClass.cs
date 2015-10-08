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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ClassBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBClassAddressClass))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBClassStringClass))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBClassValueClass))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBClassMetaInformation))]
	public partial class LocalLBClass : iControlInterface {
		public LocalLBClass() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_address_class_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void add_address_class_member(
		LocalLBClassAddressClass [] class_members
	) {
		this.Invoke("add_address_class_member", new object [] {
				class_members});

	}
	public System.IAsyncResult Beginadd_address_class_member(LocalLBClassAddressClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_address_class_member", new object[] {
			class_members}, callback, asyncState);
	}
	public void Endadd_address_class_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_string_class_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void add_string_class_member(
		LocalLBClassStringClass [] class_members
	) {
		this.Invoke("add_string_class_member", new object [] {
				class_members});

	}
	public System.IAsyncResult Beginadd_string_class_member(LocalLBClassStringClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_string_class_member", new object[] {
			class_members}, callback, asyncState);
	}
	public void Endadd_string_class_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_value_class_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void add_value_class_member(
		LocalLBClassValueClass [] class_members
	) {
		this.Invoke("add_value_class_member", new object [] {
				class_members});

	}
	public System.IAsyncResult Beginadd_value_class_member(LocalLBClassValueClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_value_class_member", new object[] {
			class_members}, callback, asyncState);
	}
	public void Endadd_value_class_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_address_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void create_address_class(
		LocalLBClassAddressClass [] classes
	) {
		this.Invoke("create_address_class", new object [] {
				classes});

	}
	public System.IAsyncResult Begincreate_address_class(LocalLBClassAddressClass [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_address_class", new object[] {
			classes}, callback, asyncState);
	}
	public void Endcreate_address_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_external_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void create_external_class(
		LocalLBClassMetaInformation [] external_classes
	) {
		this.Invoke("create_external_class", new object [] {
				external_classes});

	}
	public System.IAsyncResult Begincreate_external_class(LocalLBClassMetaInformation [] external_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_external_class", new object[] {
			external_classes}, callback, asyncState);
	}
	public void Endcreate_external_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_external_class_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void create_external_class_v2(
		string [] class_names,
		string [] file_names
	) {
		this.Invoke("create_external_class_v2", new object [] {
				class_names,
				file_names});

	}
	public System.IAsyncResult Begincreate_external_class_v2(string [] class_names,string [] file_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_external_class_v2", new object[] {
			class_names,
			file_names}, callback, asyncState);
	}
	public void Endcreate_external_class_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_string_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void create_string_class(
		LocalLBClassStringClass [] classes
	) {
		this.Invoke("create_string_class", new object [] {
				classes});

	}
	public System.IAsyncResult Begincreate_string_class(LocalLBClassStringClass [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_string_class", new object[] {
			classes}, callback, asyncState);
	}
	public void Endcreate_string_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_value_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void create_value_class(
		LocalLBClassValueClass [] classes
	) {
		this.Invoke("create_value_class", new object [] {
				classes});

	}
	public System.IAsyncResult Begincreate_value_class(LocalLBClassValueClass [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_value_class", new object[] {
			classes}, callback, asyncState);
	}
	public void Endcreate_value_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_address_class_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void delete_address_class_member(
		LocalLBClassAddressClass [] class_members
	) {
		this.Invoke("delete_address_class_member", new object [] {
				class_members});

	}
	public System.IAsyncResult Begindelete_address_class_member(LocalLBClassAddressClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_address_class_member", new object[] {
			class_members}, callback, asyncState);
	}
	public void Enddelete_address_class_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_address_classes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void delete_all_address_classes(

	) {
		this.Invoke("delete_all_address_classes", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_address_classes(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_address_classes", new object[0], callback, asyncState);
	}
	public void Enddelete_all_address_classes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_string_classes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void delete_all_string_classes(

	) {
		this.Invoke("delete_all_string_classes", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_string_classes(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_string_classes", new object[0], callback, asyncState);
	}
	public void Enddelete_all_string_classes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_value_classes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void delete_all_value_classes(

	) {
		this.Invoke("delete_all_value_classes", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_value_classes(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_value_classes", new object[0], callback, asyncState);
	}
	public void Enddelete_all_value_classes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void delete_class(
		string [] classes
	) {
		this.Invoke("delete_class", new object [] {
				classes});

	}
	public System.IAsyncResult Begindelete_class(string [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_class", new object[] {
			classes}, callback, asyncState);
	}
	public void Enddelete_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_string_class_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void delete_string_class_member(
		LocalLBClassStringClass [] class_members
	) {
		this.Invoke("delete_string_class_member", new object [] {
				class_members});

	}
	public System.IAsyncResult Begindelete_string_class_member(LocalLBClassStringClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_string_class_member", new object[] {
			class_members}, callback, asyncState);
	}
	public void Enddelete_string_class_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_value_class_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void delete_value_class_member(
		LocalLBClassValueClass [] class_members
	) {
		this.Invoke("delete_value_class_member", new object [] {
				class_members});

	}
	public System.IAsyncResult Begindelete_value_class_member(LocalLBClassValueClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_value_class_member", new object[] {
			class_members}, callback, asyncState);
	}
	public void Enddelete_value_class_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// find_address_class_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] [] find_address_class_member(
		LocalLBClassAddressClass [] class_members
	) {
		object [] results = this.Invoke("find_address_class_member", new object [] {
				class_members});
		return ((bool [] [])(results[0]));
	}
	public System.IAsyncResult Beginfind_address_class_member(LocalLBClassAddressClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("find_address_class_member", new object[] {
			class_members}, callback, asyncState);
	}
	public bool [] [] Endfind_address_class_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// find_string_class_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] [] find_string_class_member(
		LocalLBClassStringClass [] class_members
	) {
		object [] results = this.Invoke("find_string_class_member", new object [] {
				class_members});
		return ((bool [] [])(results[0]));
	}
	public System.IAsyncResult Beginfind_string_class_member(LocalLBClassStringClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("find_string_class_member", new object[] {
			class_members}, callback, asyncState);
	}
	public bool [] [] Endfind_string_class_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// find_value_class_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] [] find_value_class_member(
		LocalLBClassValueClass [] class_members
	) {
		object [] results = this.Invoke("find_value_class_member", new object [] {
				class_members});
		return ((bool [] [])(results[0]));
	}
	public System.IAsyncResult Beginfind_value_class_member(LocalLBClassValueClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("find_value_class_member", new object[] {
			class_members}, callback, asyncState);
	}
	public bool [] [] Endfind_value_class_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_address_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBClassAddressClass [] get_address_class(
		string [] class_names
	) {
		object [] results = this.Invoke("get_address_class", new object [] {
				class_names});
		return ((LocalLBClassAddressClass [])(results[0]));
	}
	public System.IAsyncResult Beginget_address_class(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address_class", new object[] {
			class_names}, callback, asyncState);
	}
	public LocalLBClassAddressClass [] Endget_address_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBClassAddressClass [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_address_class_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_address_class_list(

	) {
		object [] results = this.Invoke("get_address_class_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_address_class_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address_class_list", new object[0], callback, asyncState);
	}
	public string [] Endget_address_class_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_address_class_member_data_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_address_class_member_data_value(
		LocalLBClassAddressClass [] class_members
	) {
		object [] results = this.Invoke("get_address_class_member_data_value", new object [] {
				class_members});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_address_class_member_data_value(LocalLBClassAddressClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address_class_member_data_value", new object[] {
			class_members}, callback, asyncState);
	}
	public string [] [] Endget_address_class_member_data_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_class_meta_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBClassMetaInformation [] get_class_meta_information(
		string [] class_names
	) {
		object [] results = this.Invoke("get_class_meta_information", new object [] {
				class_names});
		return ((LocalLBClassMetaInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_class_meta_information(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_class_meta_information", new object[] {
			class_names}, callback, asyncState);
	}
	public LocalLBClassMetaInformation [] Endget_class_meta_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBClassMetaInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_class_meta_information_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBClassMetaInformation [] get_class_meta_information_v2(
		string [] class_names
	) {
		object [] results = this.Invoke("get_class_meta_information_v2", new object [] {
				class_names});
		return ((LocalLBClassMetaInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_class_meta_information_v2(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_class_meta_information_v2", new object[] {
			class_names}, callback, asyncState);
	}
	public LocalLBClassMetaInformation [] Endget_class_meta_information_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBClassMetaInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_class_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBClassClassType [] get_class_type(
		string [] class_names
	) {
		object [] results = this.Invoke("get_class_type", new object [] {
				class_names});
		return ((LocalLBClassClassType [])(results[0]));
	}
	public System.IAsyncResult Beginget_class_type(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_class_type", new object[] {
			class_names}, callback, asyncState);
	}
	public LocalLBClassClassType [] Endget_class_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBClassClassType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_data_separator
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_data_separator(
		string [] class_names
	) {
		object [] results = this.Invoke("get_data_separator", new object [] {
				class_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_data_separator(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_data_separator", new object[] {
			class_names}, callback, asyncState);
	}
	public string [] Endget_data_separator(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] class_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				class_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			class_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_external_class_file_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBClassFileFormatType [] get_external_class_file_format(
		string [] class_names
	) {
		object [] results = this.Invoke("get_external_class_file_format", new object [] {
				class_names});
		return ((LocalLBClassFileFormatType [])(results[0]));
	}
	public System.IAsyncResult Beginget_external_class_file_format(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_external_class_file_format", new object[] {
			class_names}, callback, asyncState);
	}
	public LocalLBClassFileFormatType [] Endget_external_class_file_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBClassFileFormatType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_external_class_file_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBClassFileModeType [] get_external_class_file_mode(
		string [] class_names
	) {
		object [] results = this.Invoke("get_external_class_file_mode", new object [] {
				class_names});
		return ((LocalLBClassFileModeType [])(results[0]));
	}
	public System.IAsyncResult Beginget_external_class_file_mode(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_external_class_file_mode", new object[] {
			class_names}, callback, asyncState);
	}
	public LocalLBClassFileModeType [] Endget_external_class_file_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBClassFileModeType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_external_class_file_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_external_class_file_name(
		string [] class_names
	) {
		object [] results = this.Invoke("get_external_class_file_name", new object [] {
				class_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_external_class_file_name(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_external_class_file_name", new object[] {
			class_names}, callback, asyncState);
	}
	public string [] Endget_external_class_file_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_external_class_file_name_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_external_class_file_name_v2(
		string [] class_names
	) {
		object [] results = this.Invoke("get_external_class_file_name_v2", new object [] {
				class_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_external_class_file_name_v2(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_external_class_file_name_v2", new object[] {
			class_names}, callback, asyncState);
	}
	public string [] Endget_external_class_file_name_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_external_class_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBClassMetaInformation [] get_external_class_list(

	) {
		object [] results = this.Invoke("get_external_class_list", new object [0]);
		return ((LocalLBClassMetaInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_external_class_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_external_class_list", new object[0], callback, asyncState);
	}
	public LocalLBClassMetaInformation [] Endget_external_class_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBClassMetaInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_external_class_list_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_external_class_list_v2(

	) {
		object [] results = this.Invoke("get_external_class_list_v2", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_external_class_list_v2(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_external_class_list_v2", new object[0], callback, asyncState);
	}
	public string [] Endget_external_class_list_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_string_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBClassStringClass [] get_string_class(
		string [] class_names
	) {
		object [] results = this.Invoke("get_string_class", new object [] {
				class_names});
		return ((LocalLBClassStringClass [])(results[0]));
	}
	public System.IAsyncResult Beginget_string_class(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_string_class", new object[] {
			class_names}, callback, asyncState);
	}
	public LocalLBClassStringClass [] Endget_string_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBClassStringClass [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_string_class_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_string_class_list(

	) {
		object [] results = this.Invoke("get_string_class_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_string_class_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_string_class_list", new object[0], callback, asyncState);
	}
	public string [] Endget_string_class_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_string_class_member_data_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_string_class_member_data_value(
		LocalLBClassStringClass [] class_members
	) {
		object [] results = this.Invoke("get_string_class_member_data_value", new object [] {
				class_members});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_string_class_member_data_value(LocalLBClassStringClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_string_class_member_data_value", new object[] {
			class_members}, callback, asyncState);
	}
	public string [] [] Endget_string_class_member_data_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_value_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBClassValueClass [] get_value_class(
		string [] class_names
	) {
		object [] results = this.Invoke("get_value_class", new object [] {
				class_names});
		return ((LocalLBClassValueClass [])(results[0]));
	}
	public System.IAsyncResult Beginget_value_class(string [] class_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_value_class", new object[] {
			class_names}, callback, asyncState);
	}
	public LocalLBClassValueClass [] Endget_value_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBClassValueClass [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_value_class_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_value_class_list(

	) {
		object [] results = this.Invoke("get_value_class_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_value_class_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_value_class_list", new object[0], callback, asyncState);
	}
	public string [] Endget_value_class_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_value_class_member_data_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_value_class_member_data_value(
		LocalLBClassValueClass [] class_members
	) {
		object [] results = this.Invoke("get_value_class_member_data_value", new object [] {
				class_members});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_value_class_member_data_value(LocalLBClassValueClass [] class_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_value_class_member_data_value", new object[] {
			class_members}, callback, asyncState);
	}
	public string [] [] Endget_value_class_member_data_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
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
	// modify_address_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void modify_address_class(
		LocalLBClassAddressClass [] classes
	) {
		this.Invoke("modify_address_class", new object [] {
				classes});

	}
	public System.IAsyncResult Beginmodify_address_class(LocalLBClassAddressClass [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("modify_address_class", new object[] {
			classes}, callback, asyncState);
	}
	public void Endmodify_address_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// modify_string_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void modify_string_class(
		LocalLBClassStringClass [] classes
	) {
		this.Invoke("modify_string_class", new object [] {
				classes});

	}
	public System.IAsyncResult Beginmodify_string_class(LocalLBClassStringClass [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("modify_string_class", new object[] {
			classes}, callback, asyncState);
	}
	public void Endmodify_string_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// modify_value_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void modify_value_class(
		LocalLBClassValueClass [] classes
	) {
		this.Invoke("modify_value_class", new object [] {
				classes});

	}
	public System.IAsyncResult Beginmodify_value_class(LocalLBClassValueClass [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("modify_value_class", new object[] {
			classes}, callback, asyncState);
	}
	public void Endmodify_value_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_address_class_member_data_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void set_address_class_member_data_value(
		LocalLBClassAddressClass [] class_members,
		string [] [] values
	) {
		this.Invoke("set_address_class_member_data_value", new object [] {
				class_members,
				values});

	}
	public System.IAsyncResult Beginset_address_class_member_data_value(LocalLBClassAddressClass [] class_members,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_address_class_member_data_value", new object[] {
			class_members,
			values}, callback, asyncState);
	}
	public void Endset_address_class_member_data_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_data_separator
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void set_data_separator(
		string [] class_names,
		string [] separators
	) {
		this.Invoke("set_data_separator", new object [] {
				class_names,
				separators});

	}
	public System.IAsyncResult Beginset_data_separator(string [] class_names,string [] separators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_data_separator", new object[] {
			class_names,
			separators}, callback, asyncState);
	}
	public void Endset_data_separator(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void set_description(
		string [] class_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				class_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] class_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			class_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_external_class_file_format
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void set_external_class_file_format(
		string [] class_names,
		LocalLBClassFileFormatType [] file_formats
	) {
		this.Invoke("set_external_class_file_format", new object [] {
				class_names,
				file_formats});

	}
	public System.IAsyncResult Beginset_external_class_file_format(string [] class_names,LocalLBClassFileFormatType [] file_formats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_external_class_file_format", new object[] {
			class_names,
			file_formats}, callback, asyncState);
	}
	public void Endset_external_class_file_format(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_external_class_file_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void set_external_class_file_mode(
		string [] class_names,
		LocalLBClassFileModeType [] file_modes
	) {
		this.Invoke("set_external_class_file_mode", new object [] {
				class_names,
				file_modes});

	}
	public System.IAsyncResult Beginset_external_class_file_mode(string [] class_names,LocalLBClassFileModeType [] file_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_external_class_file_mode", new object[] {
			class_names,
			file_modes}, callback, asyncState);
	}
	public void Endset_external_class_file_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_external_class_file_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void set_external_class_file_name(
		string [] class_names,
		string [] file_names
	) {
		this.Invoke("set_external_class_file_name", new object [] {
				class_names,
				file_names});

	}
	public System.IAsyncResult Beginset_external_class_file_name(string [] class_names,string [] file_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_external_class_file_name", new object[] {
			class_names,
			file_names}, callback, asyncState);
	}
	public void Endset_external_class_file_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_external_class_file_name_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void set_external_class_file_name_v2(
		string [] class_names,
		string [] file_names
	) {
		this.Invoke("set_external_class_file_name_v2", new object [] {
				class_names,
				file_names});

	}
	public System.IAsyncResult Beginset_external_class_file_name_v2(string [] class_names,string [] file_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_external_class_file_name_v2", new object[] {
			class_names,
			file_names}, callback, asyncState);
	}
	public void Endset_external_class_file_name_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_string_class_member_data_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void set_string_class_member_data_value(
		LocalLBClassStringClass [] class_members,
		string [] [] values
	) {
		this.Invoke("set_string_class_member_data_value", new object [] {
				class_members,
				values});

	}
	public System.IAsyncResult Beginset_string_class_member_data_value(LocalLBClassStringClass [] class_members,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_string_class_member_data_value", new object[] {
			class_members,
			values}, callback, asyncState);
	}
	public void Endset_string_class_member_data_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_value_class_member_data_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Class", 
		RequestNamespace="urn:iControl:LocalLB/Class", ResponseNamespace="urn:iControl:LocalLB/Class")]
	public void set_value_class_member_data_value(
		LocalLBClassValueClass [] class_members,
		string [] [] values
	) {
		this.Invoke("set_value_class_member_data_value", new object [] {
				class_members,
				values});

	}
	public System.IAsyncResult Beginset_value_class_member_data_value(LocalLBClassValueClass [] class_members,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_value_class_member_data_value", new object[] {
			class_members,
			values}, callback, asyncState);
	}
	public void Endset_value_class_member_data_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Class.ClassType", Namespace = "urn:iControl")]
	public enum LocalLBClassClassType
	{
		CLASS_TYPE_UNDEFINED,
		CLASS_TYPE_ADDRESS,
		CLASS_TYPE_STRING,
		CLASS_TYPE_VALUE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Class.FileFormatType", Namespace = "urn:iControl")]
	public enum LocalLBClassFileFormatType
	{
		FILE_FORMAT_UNKNOWN,
		FILE_FORMAT_CSV,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Class.FileModeType", Namespace = "urn:iControl")]
	public enum LocalLBClassFileModeType
	{
		FILE_MODE_UNKNOWN,
		FILE_MODE_TYPE_READ,
		FILE_MODE_TYPE_READ_WRITE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Class.AddressClass", Namespace = "urn:iControl")]
	public partial class LocalLBClassAddressClass
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private LocalLBClassAddressEntry [] membersField;
		public LocalLBClassAddressEntry [] members
		{
			get { return this.membersField; }
			set { this.membersField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Class.AddressEntry", Namespace = "urn:iControl")]
	public partial class LocalLBClassAddressEntry
	{
		private string addressField;
		public string address
		{
			get { return this.addressField; }
			set { this.addressField = value; }
		}
		private string netmaskField;
		public string netmask
		{
			get { return this.netmaskField; }
			set { this.netmaskField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Class.MetaInformation", Namespace = "urn:iControl")]
	public partial class LocalLBClassMetaInformation
	{
		private string class_nameField;
		public string class_name
		{
			get { return this.class_nameField; }
			set { this.class_nameField = value; }
		}
		private LocalLBClassClassType class_typeField;
		public LocalLBClassClassType class_type
		{
			get { return this.class_typeField; }
			set { this.class_typeField = value; }
		}
		private string file_nameField;
		public string file_name
		{
			get { return this.file_nameField; }
			set { this.file_nameField = value; }
		}
		private LocalLBClassFileModeType file_modeField;
		public LocalLBClassFileModeType file_mode
		{
			get { return this.file_modeField; }
			set { this.file_modeField = value; }
		}
		private LocalLBClassFileFormatType file_formatField;
		public LocalLBClassFileFormatType file_format
		{
			get { return this.file_formatField; }
			set { this.file_formatField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Class.StringClass", Namespace = "urn:iControl")]
	public partial class LocalLBClassStringClass
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string [] membersField;
		public string [] members
		{
			get { return this.membersField; }
			set { this.membersField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Class.ValueClass", Namespace = "urn:iControl")]
	public partial class LocalLBClassValueClass
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private long [] membersField;
		public long [] members
		{
			get { return this.membersField; }
			set { this.membersField = value; }
		}
	};

}
