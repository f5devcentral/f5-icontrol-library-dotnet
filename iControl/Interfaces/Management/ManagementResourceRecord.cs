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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.ResourceRecordBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementViewZone))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementARecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementAAAARecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementCNAMERecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementDNAMERecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementDSRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementHINFORecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementMXRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementNAPTRRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementNSRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementPTRRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementRRList))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSOARecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSRVRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementTXTRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementA6Record))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKEYRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementNXTRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSIGRecord))]
	public partial class ManagementResourceRecord : iControlInterface {
		public ManagementResourceRecord() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_a
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_a(
		ManagementViewZone [] view_zones,
		ManagementARecord [] [] a_records,
		bool [] sync_ptrs
	) {
		this.Invoke("add_a", new object [] {
				view_zones,
				a_records,
				sync_ptrs});

	}
	public System.IAsyncResult Beginadd_a(ManagementViewZone [] view_zones,ManagementARecord [] [] a_records,bool [] sync_ptrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_a", new object[] {
			view_zones,
			a_records,
			sync_ptrs}, callback, asyncState);
	}
	public void Endadd_a(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_aaaa
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_aaaa(
		ManagementViewZone [] view_zones,
		ManagementAAAARecord [] [] aaaa_records,
		bool [] sync_ptrs
	) {
		this.Invoke("add_aaaa", new object [] {
				view_zones,
				aaaa_records,
				sync_ptrs});

	}
	public System.IAsyncResult Beginadd_aaaa(ManagementViewZone [] view_zones,ManagementAAAARecord [] [] aaaa_records,bool [] sync_ptrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_aaaa", new object[] {
			view_zones,
			aaaa_records,
			sync_ptrs}, callback, asyncState);
	}
	public void Endadd_aaaa(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_cname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_cname(
		ManagementViewZone [] view_zones,
		ManagementCNAMERecord [] [] cname_records
	) {
		this.Invoke("add_cname", new object [] {
				view_zones,
				cname_records});

	}
	public System.IAsyncResult Beginadd_cname(ManagementViewZone [] view_zones,ManagementCNAMERecord [] [] cname_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_cname", new object[] {
			view_zones,
			cname_records}, callback, asyncState);
	}
	public void Endadd_cname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_dname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_dname(
		ManagementViewZone [] view_zones,
		ManagementDNAMERecord [] [] dname_records
	) {
		this.Invoke("add_dname", new object [] {
				view_zones,
				dname_records});

	}
	public System.IAsyncResult Beginadd_dname(ManagementViewZone [] view_zones,ManagementDNAMERecord [] [] dname_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_dname", new object[] {
			view_zones,
			dname_records}, callback, asyncState);
	}
	public void Endadd_dname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_ds
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_ds(
		ManagementViewZone [] view_zones,
		ManagementDSRecord [] [] ds_records
	) {
		this.Invoke("add_ds", new object [] {
				view_zones,
				ds_records});

	}
	public System.IAsyncResult Beginadd_ds(ManagementViewZone [] view_zones,ManagementDSRecord [] [] ds_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ds", new object[] {
			view_zones,
			ds_records}, callback, asyncState);
	}
	public void Endadd_ds(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_hinfo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_hinfo(
		ManagementViewZone [] view_zones,
		ManagementHINFORecord [] [] hinfo_records
	) {
		this.Invoke("add_hinfo", new object [] {
				view_zones,
				hinfo_records});

	}
	public System.IAsyncResult Beginadd_hinfo(ManagementViewZone [] view_zones,ManagementHINFORecord [] [] hinfo_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_hinfo", new object[] {
			view_zones,
			hinfo_records}, callback, asyncState);
	}
	public void Endadd_hinfo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_mx
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_mx(
		ManagementViewZone [] view_zones,
		ManagementMXRecord [] [] mx_records
	) {
		this.Invoke("add_mx", new object [] {
				view_zones,
				mx_records});

	}
	public System.IAsyncResult Beginadd_mx(ManagementViewZone [] view_zones,ManagementMXRecord [] [] mx_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_mx", new object[] {
			view_zones,
			mx_records}, callback, asyncState);
	}
	public void Endadd_mx(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_naptr
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_naptr(
		ManagementViewZone [] view_zones,
		ManagementNAPTRRecord [] [] naptr_records
	) {
		this.Invoke("add_naptr", new object [] {
				view_zones,
				naptr_records});

	}
	public System.IAsyncResult Beginadd_naptr(ManagementViewZone [] view_zones,ManagementNAPTRRecord [] [] naptr_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_naptr", new object[] {
			view_zones,
			naptr_records}, callback, asyncState);
	}
	public void Endadd_naptr(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_ns
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_ns(
		ManagementViewZone [] view_zones,
		ManagementNSRecord [] [] ns_records
	) {
		this.Invoke("add_ns", new object [] {
				view_zones,
				ns_records});

	}
	public System.IAsyncResult Beginadd_ns(ManagementViewZone [] view_zones,ManagementNSRecord [] [] ns_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ns", new object[] {
			view_zones,
			ns_records}, callback, asyncState);
	}
	public void Endadd_ns(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_ptr
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_ptr(
		ManagementViewZone [] view_zones,
		ManagementPTRRecord [] [] ptr_records
	) {
		this.Invoke("add_ptr", new object [] {
				view_zones,
				ptr_records});

	}
	public System.IAsyncResult Beginadd_ptr(ManagementViewZone [] view_zones,ManagementPTRRecord [] [] ptr_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ptr", new object[] {
			view_zones,
			ptr_records}, callback, asyncState);
	}
	public void Endadd_ptr(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_rrs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_rrs(
		ManagementViewZone [] view_zones,
		ManagementRRList [] rr_lists,
		bool [] sync_ptrs
	) {
		this.Invoke("add_rrs", new object [] {
				view_zones,
				rr_lists,
				sync_ptrs});

	}
	public System.IAsyncResult Beginadd_rrs(ManagementViewZone [] view_zones,ManagementRRList [] rr_lists,bool [] sync_ptrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_rrs", new object[] {
			view_zones,
			rr_lists,
			sync_ptrs}, callback, asyncState);
	}
	public void Endadd_rrs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_soa
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_soa(
		ManagementViewZone [] view_zones,
		ManagementSOARecord [] [] soa_records
	) {
		this.Invoke("add_soa", new object [] {
				view_zones,
				soa_records});

	}
	public System.IAsyncResult Beginadd_soa(ManagementViewZone [] view_zones,ManagementSOARecord [] [] soa_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_soa", new object[] {
			view_zones,
			soa_records}, callback, asyncState);
	}
	public void Endadd_soa(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_srv
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_srv(
		ManagementViewZone [] view_zones,
		ManagementSRVRecord [] [] srv_records
	) {
		this.Invoke("add_srv", new object [] {
				view_zones,
				srv_records});

	}
	public System.IAsyncResult Beginadd_srv(ManagementViewZone [] view_zones,ManagementSRVRecord [] [] srv_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_srv", new object[] {
			view_zones,
			srv_records}, callback, asyncState);
	}
	public void Endadd_srv(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_txt
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void add_txt(
		ManagementViewZone [] view_zones,
		ManagementTXTRecord [] [] txt_records
	) {
		this.Invoke("add_txt", new object [] {
				view_zones,
				txt_records});

	}
	public System.IAsyncResult Beginadd_txt(ManagementViewZone [] view_zones,ManagementTXTRecord [] [] txt_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_txt", new object[] {
			view_zones,
			txt_records}, callback, asyncState);
	}
	public void Endadd_txt(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_a
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_a(
		ManagementViewZone [] view_zones,
		ManagementARecord [] [] a_records,
		bool [] sync_ptrs
	) {
		this.Invoke("delete_a", new object [] {
				view_zones,
				a_records,
				sync_ptrs});

	}
	public System.IAsyncResult Begindelete_a(ManagementViewZone [] view_zones,ManagementARecord [] [] a_records,bool [] sync_ptrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_a", new object[] {
			view_zones,
			a_records,
			sync_ptrs}, callback, asyncState);
	}
	public void Enddelete_a(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_a6
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_a6(
		ManagementViewZone [] view_zones,
		ManagementA6Record [] [] a6_records,
		bool [] sync_ptrs
	) {
		this.Invoke("delete_a6", new object [] {
				view_zones,
				a6_records,
				sync_ptrs});

	}
	public System.IAsyncResult Begindelete_a6(ManagementViewZone [] view_zones,ManagementA6Record [] [] a6_records,bool [] sync_ptrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_a6", new object[] {
			view_zones,
			a6_records,
			sync_ptrs}, callback, asyncState);
	}
	public void Enddelete_a6(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_aaaa
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_aaaa(
		ManagementViewZone [] view_zones,
		ManagementAAAARecord [] [] aaaa_records,
		bool [] sync_ptrs
	) {
		this.Invoke("delete_aaaa", new object [] {
				view_zones,
				aaaa_records,
				sync_ptrs});

	}
	public System.IAsyncResult Begindelete_aaaa(ManagementViewZone [] view_zones,ManagementAAAARecord [] [] aaaa_records,bool [] sync_ptrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_aaaa", new object[] {
			view_zones,
			aaaa_records,
			sync_ptrs}, callback, asyncState);
	}
	public void Enddelete_aaaa(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_cname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_cname(
		ManagementViewZone [] view_zones,
		ManagementCNAMERecord [] [] cname_records
	) {
		this.Invoke("delete_cname", new object [] {
				view_zones,
				cname_records});

	}
	public System.IAsyncResult Begindelete_cname(ManagementViewZone [] view_zones,ManagementCNAMERecord [] [] cname_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_cname", new object[] {
			view_zones,
			cname_records}, callback, asyncState);
	}
	public void Enddelete_cname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_dname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_dname(
		ManagementViewZone [] view_zones,
		ManagementDNAMERecord [] [] dname_records
	) {
		this.Invoke("delete_dname", new object [] {
				view_zones,
				dname_records});

	}
	public System.IAsyncResult Begindelete_dname(ManagementViewZone [] view_zones,ManagementDNAMERecord [] [] dname_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_dname", new object[] {
			view_zones,
			dname_records}, callback, asyncState);
	}
	public void Enddelete_dname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_ds
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_ds(
		ManagementViewZone [] view_zones,
		ManagementDSRecord [] [] ds_records
	) {
		this.Invoke("delete_ds", new object [] {
				view_zones,
				ds_records});

	}
	public System.IAsyncResult Begindelete_ds(ManagementViewZone [] view_zones,ManagementDSRecord [] [] ds_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_ds", new object[] {
			view_zones,
			ds_records}, callback, asyncState);
	}
	public void Enddelete_ds(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_hinfo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_hinfo(
		ManagementViewZone [] view_zones,
		ManagementHINFORecord [] [] hinfo_records
	) {
		this.Invoke("delete_hinfo", new object [] {
				view_zones,
				hinfo_records});

	}
	public System.IAsyncResult Begindelete_hinfo(ManagementViewZone [] view_zones,ManagementHINFORecord [] [] hinfo_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_hinfo", new object[] {
			view_zones,
			hinfo_records}, callback, asyncState);
	}
	public void Enddelete_hinfo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_key(
		ManagementViewZone [] view_zones,
		ManagementKEYRecord [] [] key_records
	) {
		this.Invoke("delete_key", new object [] {
				view_zones,
				key_records});

	}
	public System.IAsyncResult Begindelete_key(ManagementViewZone [] view_zones,ManagementKEYRecord [] [] key_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_key", new object[] {
			view_zones,
			key_records}, callback, asyncState);
	}
	public void Enddelete_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_mx
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_mx(
		ManagementViewZone [] view_zones,
		ManagementMXRecord [] [] mx_records
	) {
		this.Invoke("delete_mx", new object [] {
				view_zones,
				mx_records});

	}
	public System.IAsyncResult Begindelete_mx(ManagementViewZone [] view_zones,ManagementMXRecord [] [] mx_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_mx", new object[] {
			view_zones,
			mx_records}, callback, asyncState);
	}
	public void Enddelete_mx(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_naptr
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_naptr(
		ManagementViewZone [] view_zones,
		ManagementNAPTRRecord [] [] naptr_records
	) {
		this.Invoke("delete_naptr", new object [] {
				view_zones,
				naptr_records});

	}
	public System.IAsyncResult Begindelete_naptr(ManagementViewZone [] view_zones,ManagementNAPTRRecord [] [] naptr_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_naptr", new object[] {
			view_zones,
			naptr_records}, callback, asyncState);
	}
	public void Enddelete_naptr(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_ns
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_ns(
		ManagementViewZone [] view_zones,
		ManagementNSRecord [] [] ns_records
	) {
		this.Invoke("delete_ns", new object [] {
				view_zones,
				ns_records});

	}
	public System.IAsyncResult Begindelete_ns(ManagementViewZone [] view_zones,ManagementNSRecord [] [] ns_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_ns", new object[] {
			view_zones,
			ns_records}, callback, asyncState);
	}
	public void Enddelete_ns(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_nxt
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_nxt(
		ManagementViewZone [] view_zones,
		ManagementNXTRecord [] [] nxt_records
	) {
		this.Invoke("delete_nxt", new object [] {
				view_zones,
				nxt_records});

	}
	public System.IAsyncResult Begindelete_nxt(ManagementViewZone [] view_zones,ManagementNXTRecord [] [] nxt_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_nxt", new object[] {
			view_zones,
			nxt_records}, callback, asyncState);
	}
	public void Enddelete_nxt(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_ptr
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_ptr(
		ManagementViewZone [] view_zones,
		ManagementPTRRecord [] [] ptr_records
	) {
		this.Invoke("delete_ptr", new object [] {
				view_zones,
				ptr_records});

	}
	public System.IAsyncResult Begindelete_ptr(ManagementViewZone [] view_zones,ManagementPTRRecord [] [] ptr_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_ptr", new object[] {
			view_zones,
			ptr_records}, callback, asyncState);
	}
	public void Enddelete_ptr(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_sig
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_sig(
		ManagementViewZone [] view_zones,
		ManagementSIGRecord [] [] sig_records
	) {
		this.Invoke("delete_sig", new object [] {
				view_zones,
				sig_records});

	}
	public System.IAsyncResult Begindelete_sig(ManagementViewZone [] view_zones,ManagementSIGRecord [] [] sig_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_sig", new object[] {
			view_zones,
			sig_records}, callback, asyncState);
	}
	public void Enddelete_sig(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_soa
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_soa(
		ManagementViewZone [] view_zones,
		ManagementSOARecord [] [] soa_records
	) {
		this.Invoke("delete_soa", new object [] {
				view_zones,
				soa_records});

	}
	public System.IAsyncResult Begindelete_soa(ManagementViewZone [] view_zones,ManagementSOARecord [] [] soa_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_soa", new object[] {
			view_zones,
			soa_records}, callback, asyncState);
	}
	public void Enddelete_soa(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_srv
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_srv(
		ManagementViewZone [] view_zones,
		ManagementSRVRecord [] [] srv_records
	) {
		this.Invoke("delete_srv", new object [] {
				view_zones,
				srv_records});

	}
	public System.IAsyncResult Begindelete_srv(ManagementViewZone [] view_zones,ManagementSRVRecord [] [] srv_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_srv", new object[] {
			view_zones,
			srv_records}, callback, asyncState);
	}
	public void Enddelete_srv(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_txt
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void delete_txt(
		ManagementViewZone [] view_zones,
		ManagementTXTRecord [] [] txt_records
	) {
		this.Invoke("delete_txt", new object [] {
				view_zones,
				txt_records});

	}
	public System.IAsyncResult Begindelete_txt(ManagementViewZone [] view_zones,ManagementTXTRecord [] [] txt_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_txt", new object[] {
			view_zones,
			txt_records}, callback, asyncState);
	}
	public void Enddelete_txt(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_rrs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rrs(
		ManagementViewZone [] view_zones
	) {
		object [] results = this.Invoke("get_rrs", new object [] {
				view_zones});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rrs(ManagementViewZone [] view_zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rrs", new object[] {
			view_zones}, callback, asyncState);
	}
	public string [] [] Endget_rrs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rrs_detailed
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementRRList [] get_rrs_detailed(
		ManagementViewZone [] view_zones
	) {
		object [] results = this.Invoke("get_rrs_detailed", new object [] {
				view_zones});
		return ((ManagementRRList [])(results[0]));
	}
	public System.IAsyncResult Beginget_rrs_detailed(ManagementViewZone [] view_zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rrs_detailed", new object[] {
			view_zones}, callback, asyncState);
	}
	public ManagementRRList [] Endget_rrs_detailed(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementRRList [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
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
	// update_a
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_a(
		ManagementViewZone [] view_zones,
		ManagementARecord [] [] old_records,
		ManagementARecord [] [] new_records,
		bool [] sync_ptrs
	) {
		this.Invoke("update_a", new object [] {
				view_zones,
				old_records,
				new_records,
				sync_ptrs});

	}
	public System.IAsyncResult Beginupdate_a(ManagementViewZone [] view_zones,ManagementARecord [] [] old_records,ManagementARecord [] [] new_records,bool [] sync_ptrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_a", new object[] {
			view_zones,
			old_records,
			new_records,
			sync_ptrs}, callback, asyncState);
	}
	public void Endupdate_a(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_aaaa
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_aaaa(
		ManagementViewZone [] view_zones,
		ManagementAAAARecord [] [] old_records,
		ManagementAAAARecord [] [] new_records,
		bool [] sync_ptrs
	) {
		this.Invoke("update_aaaa", new object [] {
				view_zones,
				old_records,
				new_records,
				sync_ptrs});

	}
	public System.IAsyncResult Beginupdate_aaaa(ManagementViewZone [] view_zones,ManagementAAAARecord [] [] old_records,ManagementAAAARecord [] [] new_records,bool [] sync_ptrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_aaaa", new object[] {
			view_zones,
			old_records,
			new_records,
			sync_ptrs}, callback, asyncState);
	}
	public void Endupdate_aaaa(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_cname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_cname(
		ManagementViewZone [] view_zones,
		ManagementCNAMERecord [] [] old_records,
		ManagementCNAMERecord [] [] new_records
	) {
		this.Invoke("update_cname", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_cname(ManagementViewZone [] view_zones,ManagementCNAMERecord [] [] old_records,ManagementCNAMERecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_cname", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_cname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_dname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_dname(
		ManagementViewZone [] view_zones,
		ManagementDNAMERecord [] [] old_records,
		ManagementDNAMERecord [] [] new_records
	) {
		this.Invoke("update_dname", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_dname(ManagementViewZone [] view_zones,ManagementDNAMERecord [] [] old_records,ManagementDNAMERecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_dname", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_dname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_ds
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_ds(
		ManagementViewZone [] view_zones,
		ManagementDSRecord [] [] old_records,
		ManagementDSRecord [] [] new_records
	) {
		this.Invoke("update_ds", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_ds(ManagementViewZone [] view_zones,ManagementDSRecord [] [] old_records,ManagementDSRecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_ds", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_ds(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_hinfo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_hinfo(
		ManagementViewZone [] view_zones,
		ManagementHINFORecord [] [] old_records,
		ManagementHINFORecord [] [] new_records
	) {
		this.Invoke("update_hinfo", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_hinfo(ManagementViewZone [] view_zones,ManagementHINFORecord [] [] old_records,ManagementHINFORecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_hinfo", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_hinfo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_mx
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_mx(
		ManagementViewZone [] view_zones,
		ManagementMXRecord [] [] old_records,
		ManagementMXRecord [] [] new_records
	) {
		this.Invoke("update_mx", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_mx(ManagementViewZone [] view_zones,ManagementMXRecord [] [] old_records,ManagementMXRecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_mx", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_mx(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_naptr
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_naptr(
		ManagementViewZone [] view_zones,
		ManagementNAPTRRecord [] [] old_records,
		ManagementNAPTRRecord [] [] new_records
	) {
		this.Invoke("update_naptr", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_naptr(ManagementViewZone [] view_zones,ManagementNAPTRRecord [] [] old_records,ManagementNAPTRRecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_naptr", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_naptr(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_ns
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_ns(
		ManagementViewZone [] view_zones,
		ManagementNSRecord [] [] old_records,
		ManagementNSRecord [] [] new_records
	) {
		this.Invoke("update_ns", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_ns(ManagementViewZone [] view_zones,ManagementNSRecord [] [] old_records,ManagementNSRecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_ns", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_ns(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_ptr
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_ptr(
		ManagementViewZone [] view_zones,
		ManagementPTRRecord [] [] old_records,
		ManagementPTRRecord [] [] new_records
	) {
		this.Invoke("update_ptr", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_ptr(ManagementViewZone [] view_zones,ManagementPTRRecord [] [] old_records,ManagementPTRRecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_ptr", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_ptr(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_soa
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_soa(
		ManagementViewZone [] view_zones,
		ManagementSOARecord [] [] old_records,
		ManagementSOARecord [] [] new_records
	) {
		this.Invoke("update_soa", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_soa(ManagementViewZone [] view_zones,ManagementSOARecord [] [] old_records,ManagementSOARecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_soa", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_soa(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_srv
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_srv(
		ManagementViewZone [] view_zones,
		ManagementSRVRecord [] [] old_records,
		ManagementSRVRecord [] [] new_records
	) {
		this.Invoke("update_srv", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_srv(ManagementViewZone [] view_zones,ManagementSRVRecord [] [] old_records,ManagementSRVRecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_srv", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_srv(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// update_txt
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ResourceRecord", 
		RequestNamespace="urn:iControl:Management/ResourceRecord", ResponseNamespace="urn:iControl:Management/ResourceRecord")]
	public void update_txt(
		ManagementViewZone [] view_zones,
		ManagementTXTRecord [] [] old_records,
		ManagementTXTRecord [] [] new_records
	) {
		this.Invoke("update_txt", new object [] {
				view_zones,
				old_records,
				new_records});

	}
	public System.IAsyncResult Beginupdate_txt(ManagementViewZone [] view_zones,ManagementTXTRecord [] [] old_records,ManagementTXTRecord [] [] new_records, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("update_txt", new object[] {
			view_zones,
			old_records,
			new_records}, callback, asyncState);
	}
	public void Endupdate_txt(System.IAsyncResult asyncResult) {
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
