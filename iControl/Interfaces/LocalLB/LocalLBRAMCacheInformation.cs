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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.RAMCacheInformationBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBRAMCacheInformationRAMCacheKey))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBRAMCacheInformationRAMCacheEntry))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBRAMCacheInformationRAMCacheEntryExactMatch))]
	public partial class LocalLBRAMCacheInformation : iControlInterface {
		public LocalLBRAMCacheInformation() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// evict_all_ramcache_entries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RAMCacheInformation", 
		RequestNamespace="urn:iControl:LocalLB/RAMCacheInformation", ResponseNamespace="urn:iControl:LocalLB/RAMCacheInformation")]
	public void evict_all_ramcache_entries(

	) {
		this.Invoke("evict_all_ramcache_entries", new object [0]);

	}
	public System.IAsyncResult Beginevict_all_ramcache_entries(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("evict_all_ramcache_entries", new object[0], callback, asyncState);
	}
	public void Endevict_all_ramcache_entries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// evict_ramcache_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RAMCacheInformation", 
		RequestNamespace="urn:iControl:LocalLB/RAMCacheInformation", ResponseNamespace="urn:iControl:LocalLB/RAMCacheInformation")]
	public void evict_ramcache_entry(
		LocalLBRAMCacheInformationRAMCacheKey [] keys
	) {
		this.Invoke("evict_ramcache_entry", new object [] {
				keys});

	}
	public System.IAsyncResult Beginevict_ramcache_entry(LocalLBRAMCacheInformationRAMCacheKey [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("evict_ramcache_entry", new object[] {
			keys}, callback, asyncState);
	}
	public void Endevict_ramcache_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// evict_ramcache_entry_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RAMCacheInformation", 
		RequestNamespace="urn:iControl:LocalLB/RAMCacheInformation", ResponseNamespace="urn:iControl:LocalLB/RAMCacheInformation")]
	public void evict_ramcache_entry_v2(
		LocalLBRAMCacheInformationRAMCacheKey [] keys,
		bool exact_match
	) {
		this.Invoke("evict_ramcache_entry_v2", new object [] {
				keys,
				exact_match});

	}
	public System.IAsyncResult Beginevict_ramcache_entry_v2(LocalLBRAMCacheInformationRAMCacheKey [] keys,bool exact_match, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("evict_ramcache_entry_v2", new object[] {
			keys,
			exact_match}, callback, asyncState);
	}
	public void Endevict_ramcache_entry_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_ramcache_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RAMCacheInformation", 
		RequestNamespace="urn:iControl:LocalLB/RAMCacheInformation", ResponseNamespace="urn:iControl:LocalLB/RAMCacheInformation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRAMCacheInformationRAMCacheEntry [] [] get_ramcache_entry(
		LocalLBRAMCacheInformationRAMCacheKey [] keys
	) {
		object [] results = this.Invoke("get_ramcache_entry", new object [] {
				keys});
		return ((LocalLBRAMCacheInformationRAMCacheEntry [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_entry(LocalLBRAMCacheInformationRAMCacheKey [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_entry", new object[] {
			keys}, callback, asyncState);
	}
	public LocalLBRAMCacheInformationRAMCacheEntry [] [] Endget_ramcache_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRAMCacheInformationRAMCacheEntry [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_entry_exact_match
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RAMCacheInformation", 
		RequestNamespace="urn:iControl:LocalLB/RAMCacheInformation", ResponseNamespace="urn:iControl:LocalLB/RAMCacheInformation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRAMCacheInformationRAMCacheEntryExactMatch [] [] get_ramcache_entry_exact_match(
		LocalLBRAMCacheInformationRAMCacheKey [] keys
	) {
		object [] results = this.Invoke("get_ramcache_entry_exact_match", new object [] {
				keys});
		return ((LocalLBRAMCacheInformationRAMCacheEntryExactMatch [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_entry_exact_match(LocalLBRAMCacheInformationRAMCacheKey [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_entry_exact_match", new object[] {
			keys}, callback, asyncState);
	}
	public LocalLBRAMCacheInformationRAMCacheEntryExactMatch [] [] Endget_ramcache_entry_exact_match(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRAMCacheInformationRAMCacheEntryExactMatch [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/RAMCacheInformation", 
		RequestNamespace="urn:iControl:LocalLB/RAMCacheInformation", ResponseNamespace="urn:iControl:LocalLB/RAMCacheInformation")]
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

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RAMCacheInformation.RAMCacheVaryType", Namespace = "urn:iControl")]
	public enum LocalLBRAMCacheInformationRAMCacheVaryType
	{
		RAM_CACHE_VARY_NONE,
		RAM_CACHE_VARY_USERAGENT,
		RAM_CACHE_VARY_ACCEPT_ENCODING,
		RAM_CACHE_VARY_BOTH,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RAMCacheInformation.RAMCacheEntry", Namespace = "urn:iControl")]
	public partial class LocalLBRAMCacheInformationRAMCacheEntry
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private string host_nameField;
		public string host_name
		{
			get { return this.host_nameField; }
			set { this.host_nameField = value; }
		}
		private string uriField;
		public string uri
		{
			get { return this.uriField; }
			set { this.uriField = value; }
		}
		private LocalLBRAMCacheInformationRAMCacheVaryType vary_typeField;
		public LocalLBRAMCacheInformationRAMCacheVaryType vary_type
		{
			get { return this.vary_typeField; }
			set { this.vary_typeField = value; }
		}
		private long vary_countField;
		public long vary_count
		{
			get { return this.vary_countField; }
			set { this.vary_countField = value; }
		}
		private long hitsField;
		public long hits
		{
			get { return this.hitsField; }
			set { this.hitsField = value; }
		}
		private long receivedField;
		public long received
		{
			get { return this.receivedField; }
			set { this.receivedField = value; }
		}
		private long last_sentField;
		public long last_sent
		{
			get { return this.last_sentField; }
			set { this.last_sentField = value; }
		}
		private long expirationField;
		public long expiration
		{
			get { return this.expirationField; }
			set { this.expirationField = value; }
		}
		private long sizeField;
		public long size
		{
			get { return this.sizeField; }
			set { this.sizeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RAMCacheInformation.RAMCacheEntryExactMatch", Namespace = "urn:iControl")]
	public partial class LocalLBRAMCacheInformationRAMCacheEntryExactMatch
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private string host_nameField;
		public string host_name
		{
			get { return this.host_nameField; }
			set { this.host_nameField = value; }
		}
		private string uriField;
		public string uri
		{
			get { return this.uriField; }
			set { this.uriField = value; }
		}
		private string vary_useragentField;
		public string vary_useragent
		{
			get { return this.vary_useragentField; }
			set { this.vary_useragentField = value; }
		}
		private string vary_encodingField;
		public string vary_encoding
		{
			get { return this.vary_encodingField; }
			set { this.vary_encodingField = value; }
		}
		private long hitsField;
		public long hits
		{
			get { return this.hitsField; }
			set { this.hitsField = value; }
		}
		private long receivedField;
		public long received
		{
			get { return this.receivedField; }
			set { this.receivedField = value; }
		}
		private long last_sentField;
		public long last_sent
		{
			get { return this.last_sentField; }
			set { this.last_sentField = value; }
		}
		private long expirationField;
		public long expiration
		{
			get { return this.expirationField; }
			set { this.expirationField = value; }
		}
		private long sizeField;
		public long size
		{
			get { return this.sizeField; }
			set { this.sizeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RAMCacheInformation.RAMCacheKey", Namespace = "urn:iControl")]
	public partial class LocalLBRAMCacheInformationRAMCacheKey
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private string host_nameField;
		public string host_name
		{
			get { return this.host_nameField; }
			set { this.host_nameField = value; }
		}
		private string uriField;
		public string uri
		{
			get { return this.uriField; }
			set { this.uriField = value; }
		}
		private long maximum_responsesField;
		public long maximum_responses
		{
			get { return this.maximum_responsesField; }
			set { this.maximum_responsesField = value; }
		}
	};

}
