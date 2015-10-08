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
	[System.Web.Services.WebServiceBindingAttribute(Name="Log.DestinationArcSightBinding", Namespace="urn:iControl")]
	public partial class LogDestinationArcSight : iControlInterface {
		public LogDestinationArcSight() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationArcSight", 
		RequestNamespace="urn:iControl:Log/DestinationArcSight", ResponseNamespace="urn:iControl:Log/DestinationArcSight")]
	public void create(
		string [] destinations,
		string [] forwarding_destinations
	) {
		this.Invoke("create", new object [] {
				destinations,
				forwarding_destinations});

	}
	public System.IAsyncResult Begincreate(string [] destinations,string [] forwarding_destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			destinations,
			forwarding_destinations}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_arcsight_destinations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationArcSight", 
		RequestNamespace="urn:iControl:Log/DestinationArcSight", ResponseNamespace="urn:iControl:Log/DestinationArcSight")]
	public void delete_all_arcsight_destinations(

	) {
		this.Invoke("delete_all_arcsight_destinations", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_arcsight_destinations(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_arcsight_destinations", new object[0], callback, asyncState);
	}
	public void Enddelete_all_arcsight_destinations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_arcsight_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationArcSight", 
		RequestNamespace="urn:iControl:Log/DestinationArcSight", ResponseNamespace="urn:iControl:Log/DestinationArcSight")]
	public void delete_arcsight_destination(
		string [] destinations
	) {
		this.Invoke("delete_arcsight_destination", new object [] {
				destinations});

	}
	public System.IAsyncResult Begindelete_arcsight_destination(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_arcsight_destination", new object[] {
			destinations}, callback, asyncState);
	}
	public void Enddelete_arcsight_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationArcSight", 
		RequestNamespace="urn:iControl:Log/DestinationArcSight", ResponseNamespace="urn:iControl:Log/DestinationArcSight")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] destinations
	) {
		object [] results = this.Invoke("get_description", new object [] {
				destinations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			destinations}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_forwarding_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationArcSight", 
		RequestNamespace="urn:iControl:Log/DestinationArcSight", ResponseNamespace="urn:iControl:Log/DestinationArcSight")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_forwarding_destination(
		string [] destinations
	) {
		object [] results = this.Invoke("get_forwarding_destination", new object [] {
				destinations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_forwarding_destination(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_forwarding_destination", new object[] {
			destinations}, callback, asyncState);
	}
	public string [] Endget_forwarding_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationArcSight", 
		RequestNamespace="urn:iControl:Log/DestinationArcSight", ResponseNamespace="urn:iControl:Log/DestinationArcSight")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationArcSight", 
		RequestNamespace="urn:iControl:Log/DestinationArcSight", ResponseNamespace="urn:iControl:Log/DestinationArcSight")]
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
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationArcSight", 
		RequestNamespace="urn:iControl:Log/DestinationArcSight", ResponseNamespace="urn:iControl:Log/DestinationArcSight")]
	public void set_description(
		string [] destinations,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				destinations,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] destinations,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			destinations,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_forwarding_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationArcSight", 
		RequestNamespace="urn:iControl:Log/DestinationArcSight", ResponseNamespace="urn:iControl:Log/DestinationArcSight")]
	public void set_forwarding_destination(
		string [] destinations,
		string [] forwarding_destinations
	) {
		this.Invoke("set_forwarding_destination", new object [] {
				destinations,
				forwarding_destinations});

	}
	public System.IAsyncResult Beginset_forwarding_destination(string [] destinations,string [] forwarding_destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_forwarding_destination", new object[] {
			destinations,
			forwarding_destinations}, callback, asyncState);
	}
	public void Endset_forwarding_destination(System.IAsyncResult asyncResult) {
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
