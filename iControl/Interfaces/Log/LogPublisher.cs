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
	[System.Web.Services.WebServiceBindingAttribute(Name="Log.PublisherBinding", Namespace="urn:iControl")]
	public partial class LogPublisher : iControlInterface {
		public LogPublisher() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
	public void add_destination(
		string [] publishers,
		string [] [] destinations
	) {
		this.Invoke("add_destination", new object [] {
				publishers,
				destinations});

	}
	public System.IAsyncResult Beginadd_destination(string [] publishers,string [] [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_destination", new object[] {
			publishers,
			destinations}, callback, asyncState);
	}
	public void Endadd_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
	public void create(
		string [] publishers,
		string [] [] destinations
	) {
		this.Invoke("create", new object [] {
				publishers,
				destinations});

	}
	public System.IAsyncResult Begincreate(string [] publishers,string [] [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			publishers,
			destinations}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_publishers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
	public void delete_all_publishers(

	) {
		this.Invoke("delete_all_publishers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_publishers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_publishers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_publishers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
	public void delete_publisher(
		string [] publishers
	) {
		this.Invoke("delete_publisher", new object [] {
				publishers});

	}
	public System.IAsyncResult Begindelete_publisher(string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_publisher", new object[] {
			publishers}, callback, asyncState);
	}
	public void Enddelete_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] publishers
	) {
		object [] results = this.Invoke("get_description", new object [] {
				publishers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			publishers}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_destination(
		string [] publishers
	) {
		object [] results = this.Invoke("get_destination", new object [] {
				publishers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination(string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination", new object[] {
			publishers}, callback, asyncState);
	}
	public string [] [] Endget_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
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
	// remove_all_destinations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
	public void remove_all_destinations(
		string [] publishers
	) {
		this.Invoke("remove_all_destinations", new object [] {
				publishers});

	}
	public System.IAsyncResult Beginremove_all_destinations(string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_destinations", new object[] {
			publishers}, callback, asyncState);
	}
	public void Endremove_all_destinations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
	public void remove_destination(
		string [] publishers,
		string [] [] destinations
	) {
		this.Invoke("remove_destination", new object [] {
				publishers,
				destinations});

	}
	public System.IAsyncResult Beginremove_destination(string [] publishers,string [] [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_destination", new object[] {
			publishers,
			destinations}, callback, asyncState);
	}
	public void Endremove_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/Publisher", 
		RequestNamespace="urn:iControl:Log/Publisher", ResponseNamespace="urn:iControl:Log/Publisher")]
	public void set_description(
		string [] publishers,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				publishers,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] publishers,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			publishers,
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

}
