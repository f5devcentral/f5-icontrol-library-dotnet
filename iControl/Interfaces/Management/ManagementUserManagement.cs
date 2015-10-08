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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.UserManagementBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementUserManagementPasswordInfo))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementUserManagementUserInfo))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementUserManagementUserInfo2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementUserManagementUserInfo3))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementUserManagementUserID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementUserManagementUserPermission))]
	public partial class ManagementUserManagement : iControlInterface {
		public ManagementUserManagement() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// change_my_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void change_my_password(
		ManagementUserManagementPasswordInfo password
	) {
		this.Invoke("change_my_password", new object [] {
				password});

	}
	public System.IAsyncResult Beginchange_my_password(ManagementUserManagementPasswordInfo password, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("change_my_password", new object[] {
			password}, callback, asyncState);
	}
	public void Endchange_my_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// change_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void change_password(
		string [] user_names,
		string [] passwords
	) {
		this.Invoke("change_password", new object [] {
				user_names,
				passwords});

	}
	public System.IAsyncResult Beginchange_password(string [] user_names,string [] passwords, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("change_password", new object[] {
			user_names,
			passwords}, callback, asyncState);
	}
	public void Endchange_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// change_password_2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void change_password_2(
		string [] user_names,
		ManagementUserManagementPasswordInfo [] passwords
	) {
		this.Invoke("change_password_2", new object [] {
				user_names,
				passwords});

	}
	public System.IAsyncResult Beginchange_password_2(string [] user_names,ManagementUserManagementPasswordInfo [] passwords, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("change_password_2", new object[] {
			user_names,
			passwords}, callback, asyncState);
	}
	public void Endchange_password_2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void create_user(
		ManagementUserManagementUserInfo [] users
	) {
		this.Invoke("create_user", new object [] {
				users});

	}
	public System.IAsyncResult Begincreate_user(ManagementUserManagementUserInfo [] users, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_user", new object[] {
			users}, callback, asyncState);
	}
	public void Endcreate_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_user_2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void create_user_2(
		ManagementUserManagementUserInfo2 [] users
	) {
		this.Invoke("create_user_2", new object [] {
				users});

	}
	public System.IAsyncResult Begincreate_user_2(ManagementUserManagementUserInfo2 [] users, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_user_2", new object[] {
			users}, callback, asyncState);
	}
	public void Endcreate_user_2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_user_3
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void create_user_3(
		ManagementUserManagementUserInfo3 [] users
	) {
		this.Invoke("create_user_3", new object [] {
				users});

	}
	public System.IAsyncResult Begincreate_user_3(ManagementUserManagementUserInfo3 [] users, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_user_3", new object[] {
			users}, callback, asyncState);
	}
	public void Endcreate_user_3(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void delete_user(
		string [] user_names
	) {
		this.Invoke("delete_user", new object [] {
				user_names});

	}
	public System.IAsyncResult Begindelete_user(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_user", new object[] {
			user_names}, callback, asyncState);
	}
	public void Enddelete_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_authentication_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAuthenticationMethod get_authentication_method(

	) {
		object [] results = this.Invoke("get_authentication_method", new object [0]);
		return ((CommonAuthenticationMethod)(results[0]));
	}
	public System.IAsyncResult Beginget_authentication_method(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_authentication_method", new object[0], callback, asyncState);
	}
	public CommonAuthenticationMethod Endget_authentication_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAuthenticationMethod)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_partition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_default_partition(

	) {
		object [] results = this.Invoke("get_default_partition", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_default_partition(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_partition", new object[0], callback, asyncState);
	}
	public string Endget_default_partition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_role
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementUserManagementUserRole get_default_role(

	) {
		object [] results = this.Invoke("get_default_role", new object [0]);
		return ((ManagementUserManagementUserRole)(results[0]));
	}
	public System.IAsyncResult Beginget_default_role(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_role", new object[0], callback, asyncState);
	}
	public ManagementUserManagementUserRole Endget_default_role(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementUserManagementUserRole)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] user_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				user_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			user_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_encrypted_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_encrypted_password(
		string [] user_names
	) {
		object [] results = this.Invoke("get_encrypted_password", new object [] {
				user_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_encrypted_password(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_encrypted_password", new object[] {
			user_names}, callback, asyncState);
	}
	public string [] Endget_encrypted_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fullname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_fullname(
		string [] user_names
	) {
		object [] results = this.Invoke("get_fullname", new object [] {
				user_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_fullname(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fullname", new object[] {
			user_names}, callback, asyncState);
	}
	public string [] Endget_fullname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_group_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_group_id(
		string [] user_names
	) {
		object [] results = this.Invoke("get_group_id", new object [] {
				user_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_group_id(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_group_id", new object[] {
			user_names}, callback, asyncState);
	}
	public long [] Endget_group_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_home_directory
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_home_directory(
		string [] user_names
	) {
		object [] results = this.Invoke("get_home_directory", new object [] {
				user_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_home_directory(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_home_directory", new object[] {
			user_names}, callback, asyncState);
	}
	public string [] Endget_home_directory(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_home_partition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_home_partition(
		string [] user_names
	) {
		object [] results = this.Invoke("get_home_partition", new object [] {
				user_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_home_partition(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_home_partition", new object[] {
			user_names}, callback, asyncState);
	}
	public string [] Endget_home_partition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementUserManagementUserID [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((ManagementUserManagementUserID [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public ManagementUserManagementUserID [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementUserManagementUserID [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_login_shell
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_login_shell(
		string [] user_names
	) {
		object [] results = this.Invoke("get_login_shell", new object [] {
				user_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_login_shell(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_login_shell", new object[] {
			user_names}, callback, asyncState);
	}
	public string [] Endget_login_shell(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_my_permission
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementUserManagementUserPermission [] get_my_permission(

	) {
		object [] results = this.Invoke("get_my_permission", new object [0]);
		return ((ManagementUserManagementUserPermission [])(results[0]));
	}
	public System.IAsyncResult Beginget_my_permission(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_my_permission", new object[0], callback, asyncState);
	}
	public ManagementUserManagementUserPermission [] Endget_my_permission(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementUserManagementUserPermission [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_remote_console_access
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool get_remote_console_access(

	) {
		object [] results = this.Invoke("get_remote_console_access", new object [0]);
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginget_remote_console_access(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_remote_console_access", new object[0], callback, asyncState);
	}
	public bool Endget_remote_console_access(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_role
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementUserManagementUserRole [] get_role(
		string [] user_names
	) {
		object [] results = this.Invoke("get_role", new object [] {
				user_names});
		return ((ManagementUserManagementUserRole [])(results[0]));
	}
	public System.IAsyncResult Beginget_role(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_role", new object[] {
			user_names}, callback, asyncState);
	}
	public ManagementUserManagementUserRole [] Endget_role(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementUserManagementUserRole [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_user_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_user_id(
		string [] user_names
	) {
		object [] results = this.Invoke("get_user_id", new object [] {
				user_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_user_id(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_user_id", new object[] {
			user_names}, callback, asyncState);
	}
	public long [] Endget_user_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_user_permission
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementUserManagementUserPermission [] [] get_user_permission(
		string [] user_names
	) {
		object [] results = this.Invoke("get_user_permission", new object [] {
				user_names});
		return ((ManagementUserManagementUserPermission [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_user_permission(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_user_permission", new object[] {
			user_names}, callback, asyncState);
	}
	public ManagementUserManagementUserPermission [] [] Endget_user_permission(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementUserManagementUserPermission [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
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
	// is_locked_out
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_locked_out(
		string [] user_names
	) {
		object [] results = this.Invoke("is_locked_out", new object [] {
				user_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_locked_out(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_locked_out", new object[] {
			user_names}, callback, asyncState);
	}
	public bool [] Endis_locked_out(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// reset_locked_out
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void reset_locked_out(
		string [] user_names
	) {
		this.Invoke("reset_locked_out", new object [] {
				user_names});

	}
	public System.IAsyncResult Beginreset_locked_out(string [] user_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_locked_out", new object[] {
			user_names}, callback, asyncState);
	}
	public void Endreset_locked_out(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_authentication_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_authentication_method(
		CommonAuthenticationMethod auth_method
	) {
		this.Invoke("set_authentication_method", new object [] {
				auth_method});

	}
	public System.IAsyncResult Beginset_authentication_method(CommonAuthenticationMethod auth_method, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_authentication_method", new object[] {
			auth_method}, callback, asyncState);
	}
	public void Endset_authentication_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_partition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_default_partition(
		string partition
	) {
		this.Invoke("set_default_partition", new object [] {
				partition});

	}
	public System.IAsyncResult Beginset_default_partition(string partition, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_partition", new object[] {
			partition}, callback, asyncState);
	}
	public void Endset_default_partition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_role
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_default_role(
		ManagementUserManagementUserRole role
	) {
		this.Invoke("set_default_role", new object [] {
				role});

	}
	public System.IAsyncResult Beginset_default_role(ManagementUserManagementUserRole role, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_role", new object[] {
			role}, callback, asyncState);
	}
	public void Endset_default_role(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_description(
		string [] user_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				user_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] user_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			user_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fullname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_fullname(
		string [] user_names,
		string [] fullnames
	) {
		this.Invoke("set_fullname", new object [] {
				user_names,
				fullnames});

	}
	public System.IAsyncResult Beginset_fullname(string [] user_names,string [] fullnames, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fullname", new object[] {
			user_names,
			fullnames}, callback, asyncState);
	}
	public void Endset_fullname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_group_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_group_id(
		string [] user_names,
		long [] gids
	) {
		this.Invoke("set_group_id", new object [] {
				user_names,
				gids});

	}
	public System.IAsyncResult Beginset_group_id(string [] user_names,long [] gids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_group_id", new object[] {
			user_names,
			gids}, callback, asyncState);
	}
	public void Endset_group_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_home_directory
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_home_directory(
		string [] user_names,
		string [] directories
	) {
		this.Invoke("set_home_directory", new object [] {
				user_names,
				directories});

	}
	public System.IAsyncResult Beginset_home_directory(string [] user_names,string [] directories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_home_directory", new object[] {
			user_names,
			directories}, callback, asyncState);
	}
	public void Endset_home_directory(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_login_shell
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_login_shell(
		string [] user_names,
		string [] shells
	) {
		this.Invoke("set_login_shell", new object [] {
				user_names,
				shells});

	}
	public System.IAsyncResult Beginset_login_shell(string [] user_names,string [] shells, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_login_shell", new object[] {
			user_names,
			shells}, callback, asyncState);
	}
	public void Endset_login_shell(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_console_access
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_remote_console_access(
		bool enabled
	) {
		this.Invoke("set_remote_console_access", new object [] {
				enabled});

	}
	public System.IAsyncResult Beginset_remote_console_access(bool enabled, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_console_access", new object[] {
			enabled}, callback, asyncState);
	}
	public void Endset_remote_console_access(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_role
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_role(
		string [] user_names,
		ManagementUserManagementUserRole [] roles
	) {
		this.Invoke("set_role", new object [] {
				user_names,
				roles});

	}
	public System.IAsyncResult Beginset_role(string [] user_names,ManagementUserManagementUserRole [] roles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_role", new object[] {
			user_names,
			roles}, callback, asyncState);
	}
	public void Endset_role(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_user_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_user_id(
		string [] user_names,
		long [] uids
	) {
		this.Invoke("set_user_id", new object [] {
				user_names,
				uids});

	}
	public System.IAsyncResult Beginset_user_id(string [] user_names,long [] uids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_user_id", new object[] {
			user_names,
			uids}, callback, asyncState);
	}
	public void Endset_user_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_user_permission
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/UserManagement", 
		RequestNamespace="urn:iControl:Management/UserManagement", ResponseNamespace="urn:iControl:Management/UserManagement")]
	public void set_user_permission(
		string [] user_names,
		ManagementUserManagementUserPermission [] [] permissions
	) {
		this.Invoke("set_user_permission", new object [] {
				user_names,
				permissions});

	}
	public System.IAsyncResult Beginset_user_permission(string [] user_names,ManagementUserManagementUserPermission [] [] permissions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_user_permission", new object[] {
			user_names,
			permissions}, callback, asyncState);
	}
	public void Endset_user_permission(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.UserManagement.UserRole", Namespace = "urn:iControl")]
	public enum ManagementUserManagementUserRole
	{
		USER_ROLE_ADMINISTRATOR,
		USER_ROLE_TRAFFIC_MANAGER,
		USER_ROLE_GUEST,
		USER_ROLE_ASM_POLICY_EDITOR,
		USER_ROLE_INVALID,
		USER_ROLE_MANAGER,
		USER_ROLE_EDITOR,
		USER_ROLE_APPLICATION_EDITOR,
		USER_ROLE_CERTIFICATE_MANAGER,
		USER_ROLE_USER_MANAGER,
		USER_ROLE_RESOURCE_ADMINISTRATOR,
		USER_ROLE_ASM_EDITOR,
		USER_ROLE_ADVANCED_OPERATOR,
		USER_ROLE_AUDITOR,
		USER_ROLE_ACCELERATION_POLICY_EDITOR,
		USER_ROLE_IRULE_MANAGER,
		USER_ROLE_FIREWALL_MANAGER,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.UserManagement.PasswordInfo", Namespace = "urn:iControl")]
	public partial class ManagementUserManagementPasswordInfo
	{
		private bool is_encryptedField;
		public bool is_encrypted
		{
			get { return this.is_encryptedField; }
			set { this.is_encryptedField = value; }
		}
		private string passwordField;
		public string password
		{
			get { return this.passwordField; }
			set { this.passwordField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.UserManagement.UserID", Namespace = "urn:iControl")]
	public partial class ManagementUserManagementUserID
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string full_nameField;
		public string full_name
		{
			get { return this.full_nameField; }
			set { this.full_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.UserManagement.UserInfo", Namespace = "urn:iControl")]
	public partial class ManagementUserManagementUserInfo
	{
		private ManagementUserManagementUserID userField;
		public ManagementUserManagementUserID user
		{
			get { return this.userField; }
			set { this.userField = value; }
		}
		private ManagementUserManagementUserRole roleField;
		public ManagementUserManagementUserRole role
		{
			get { return this.roleField; }
			set { this.roleField = value; }
		}
		private string passwordField;
		public string password
		{
			get { return this.passwordField; }
			set { this.passwordField = value; }
		}
		private string home_directoryField;
		public string home_directory
		{
			get { return this.home_directoryField; }
			set { this.home_directoryField = value; }
		}
		private string login_shellField;
		public string login_shell
		{
			get { return this.login_shellField; }
			set { this.login_shellField = value; }
		}
		private long user_idField;
		public long user_id
		{
			get { return this.user_idField; }
			set { this.user_idField = value; }
		}
		private long group_idField;
		public long group_id
		{
			get { return this.group_idField; }
			set { this.group_idField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.UserManagement.UserInfo2", Namespace = "urn:iControl")]
	public partial class ManagementUserManagementUserInfo2
	{
		private ManagementUserManagementUserID userField;
		public ManagementUserManagementUserID user
		{
			get { return this.userField; }
			set { this.userField = value; }
		}
		private ManagementUserManagementUserRole roleField;
		public ManagementUserManagementUserRole role
		{
			get { return this.roleField; }
			set { this.roleField = value; }
		}
		private ManagementUserManagementPasswordInfo passwordField;
		public ManagementUserManagementPasswordInfo password
		{
			get { return this.passwordField; }
			set { this.passwordField = value; }
		}
		private string home_directoryField;
		public string home_directory
		{
			get { return this.home_directoryField; }
			set { this.home_directoryField = value; }
		}
		private string login_shellField;
		public string login_shell
		{
			get { return this.login_shellField; }
			set { this.login_shellField = value; }
		}
		private long user_idField;
		public long user_id
		{
			get { return this.user_idField; }
			set { this.user_idField = value; }
		}
		private long group_idField;
		public long group_id
		{
			get { return this.group_idField; }
			set { this.group_idField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.UserManagement.UserInfo3", Namespace = "urn:iControl")]
	public partial class ManagementUserManagementUserInfo3
	{
		private ManagementUserManagementUserID userField;
		public ManagementUserManagementUserID user
		{
			get { return this.userField; }
			set { this.userField = value; }
		}
		private ManagementUserManagementPasswordInfo passwordField;
		public ManagementUserManagementPasswordInfo password
		{
			get { return this.passwordField; }
			set { this.passwordField = value; }
		}
		private ManagementUserManagementUserPermission [] permissionsField;
		public ManagementUserManagementUserPermission [] permissions
		{
			get { return this.permissionsField; }
			set { this.permissionsField = value; }
		}
		private string login_shellField;
		public string login_shell
		{
			get { return this.login_shellField; }
			set { this.login_shellField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.UserManagement.UserPermission", Namespace = "urn:iControl")]
	public partial class ManagementUserManagementUserPermission
	{
		private ManagementUserManagementUserRole roleField;
		public ManagementUserManagementUserRole role
		{
			get { return this.roleField; }
			set { this.roleField = value; }
		}
		private string partitionField;
		public string partition
		{
			get { return this.partitionField; }
			set { this.partitionField = value; }
		}
	};

}
