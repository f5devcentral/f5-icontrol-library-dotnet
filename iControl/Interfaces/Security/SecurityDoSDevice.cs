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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.DoSDeviceBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SecurityDoSDeviceVectorStatistics))]
	public partial class SecurityDoSDevice : iControlInterface {
		public SecurityDoSDevice() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_vector_packet_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	public void add_vector_packet_type(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors,
		SecurityDoSDeviceDoSNetworkVectorPacketType [] [] [] packet_types
	) {
		this.Invoke("add_vector_packet_type", new object [] {
				devices,
				vectors,
				packet_types});

	}
	public System.IAsyncResult Beginadd_vector_packet_type(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors,SecurityDoSDeviceDoSNetworkVectorPacketType [] [] [] packet_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_vector_packet_type", new object[] {
			devices,
			vectors,
			packet_types}, callback, asyncState);
	}
	public void Endadd_vector_packet_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityDoSDeviceVectorStatistics [] get_all_vector_statistics(
		string [] devices
	) {
		object [] results = this.Invoke("get_all_vector_statistics", new object [] {
				devices});
		return ((SecurityDoSDeviceVectorStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_vector_statistics(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_vector_statistics", new object[] {
			devices}, callback, asyncState);
	}
	public SecurityDoSDeviceVectorStatistics [] Endget_all_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityDoSDeviceVectorStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] devices
	) {
		object [] results = this.Invoke("get_description", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
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
	// get_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_publisher(
		string [] devices
	) {
		object [] results = this.Invoke("get_publisher", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_publisher(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_publisher", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityDoSDeviceDoSDeviceVector [] [] get_vector(
		string [] devices
	) {
		object [] results = this.Invoke("get_vector", new object [] {
				devices});
		return ((SecurityDoSDeviceDoSDeviceVector [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_vector(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vector", new object[] {
			devices}, callback, asyncState);
	}
	public SecurityDoSDeviceDoSDeviceVector [] [] Endget_vector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityDoSDeviceDoSDeviceVector [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vector_default_internal_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_vector_default_internal_rate_limit(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors
	) {
		object [] results = this.Invoke("get_vector_default_internal_rate_limit", new object [] {
				devices,
				vectors});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_vector_default_internal_rate_limit(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vector_default_internal_rate_limit", new object[] {
			devices,
			vectors}, callback, asyncState);
	}
	public long [] [] Endget_vector_default_internal_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vector_detection_threshold_percent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_vector_detection_threshold_percent(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors
	) {
		object [] results = this.Invoke("get_vector_detection_threshold_percent", new object [] {
				devices,
				vectors});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_vector_detection_threshold_percent(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vector_detection_threshold_percent", new object[] {
			devices,
			vectors}, callback, asyncState);
	}
	public long [] [] Endget_vector_detection_threshold_percent(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vector_detection_threshold_pps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_vector_detection_threshold_pps(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors
	) {
		object [] results = this.Invoke("get_vector_detection_threshold_pps", new object [] {
				devices,
				vectors});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_vector_detection_threshold_pps(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vector_detection_threshold_pps", new object[] {
			devices,
			vectors}, callback, asyncState);
	}
	public long [] [] Endget_vector_detection_threshold_pps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vector_packet_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityDoSDeviceDoSNetworkVectorPacketType [] [] [] get_vector_packet_type(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors
	) {
		object [] results = this.Invoke("get_vector_packet_type", new object [] {
				devices,
				vectors});
		return ((SecurityDoSDeviceDoSNetworkVectorPacketType [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_vector_packet_type(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vector_packet_type", new object[] {
			devices,
			vectors}, callback, asyncState);
	}
	public SecurityDoSDeviceDoSNetworkVectorPacketType [] [] [] Endget_vector_packet_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityDoSDeviceDoSNetworkVectorPacketType [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityDoSDeviceVectorStatistics [] get_vector_statistics(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors
	) {
		object [] results = this.Invoke("get_vector_statistics", new object [] {
				devices,
				vectors});
		return ((SecurityDoSDeviceVectorStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_vector_statistics(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vector_statistics", new object[] {
			devices,
			vectors}, callback, asyncState);
	}
	public SecurityDoSDeviceVectorStatistics [] Endget_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityDoSDeviceVectorStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
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
	// remove_all_vector_packet_types
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	public void remove_all_vector_packet_types(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors
	) {
		this.Invoke("remove_all_vector_packet_types", new object [] {
				devices,
				vectors});

	}
	public System.IAsyncResult Beginremove_all_vector_packet_types(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_vector_packet_types", new object[] {
			devices,
			vectors}, callback, asyncState);
	}
	public void Endremove_all_vector_packet_types(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_vector_packet_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	public void remove_vector_packet_type(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors,
		SecurityDoSDeviceDoSNetworkVectorPacketType [] [] [] packet_types
	) {
		this.Invoke("remove_vector_packet_type", new object [] {
				devices,
				vectors,
				packet_types});

	}
	public System.IAsyncResult Beginremove_vector_packet_type(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors,SecurityDoSDeviceDoSNetworkVectorPacketType [] [] [] packet_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_vector_packet_type", new object[] {
			devices,
			vectors,
			packet_types}, callback, asyncState);
	}
	public void Endremove_vector_packet_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_vector_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	public void reset_vector_statistics(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors
	) {
		this.Invoke("reset_vector_statistics", new object [] {
				devices,
				vectors});

	}
	public System.IAsyncResult Beginreset_vector_statistics(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_vector_statistics", new object[] {
			devices,
			vectors}, callback, asyncState);
	}
	public void Endreset_vector_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	public void set_description(
		string [] devices,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				devices,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] devices,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			devices,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	public void set_publisher(
		string [] devices,
		string [] publishers
	) {
		this.Invoke("set_publisher", new object [] {
				devices,
				publishers});

	}
	public System.IAsyncResult Beginset_publisher(string [] devices,string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_publisher", new object[] {
			devices,
			publishers}, callback, asyncState);
	}
	public void Endset_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vector_default_internal_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	public void set_vector_default_internal_rate_limit(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors,
		long [] [] values
	) {
		this.Invoke("set_vector_default_internal_rate_limit", new object [] {
				devices,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_vector_default_internal_rate_limit(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vector_default_internal_rate_limit", new object[] {
			devices,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_vector_default_internal_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vector_detection_threshold_percent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	public void set_vector_detection_threshold_percent(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors,
		long [] [] values
	) {
		this.Invoke("set_vector_detection_threshold_percent", new object [] {
				devices,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_vector_detection_threshold_percent(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vector_detection_threshold_percent", new object[] {
			devices,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_vector_detection_threshold_percent(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vector_detection_threshold_pps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/DoSDevice", 
		RequestNamespace="urn:iControl:Security/DoSDevice", ResponseNamespace="urn:iControl:Security/DoSDevice")]
	public void set_vector_detection_threshold_pps(
		string [] devices,
		SecurityDoSDeviceDoSDeviceVector [] [] vectors,
		long [] [] values
	) {
		this.Invoke("set_vector_detection_threshold_pps", new object [] {
				devices,
				vectors,
				values});

	}
	public System.IAsyncResult Beginset_vector_detection_threshold_pps(string [] devices,SecurityDoSDeviceDoSDeviceVector [] [] vectors,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vector_detection_threshold_pps", new object[] {
			devices,
			vectors,
			values}, callback, asyncState);
	}
	public void Endset_vector_detection_threshold_pps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.DoSDevice.DoSDeviceVector", Namespace = "urn:iControl")]
	public enum SecurityDoSDeviceDoSDeviceVector
	{
		DOS_DEVICE_VECTOR_UNKNOWN,
		DOS_DEVICE_VECTOR_ARP_FLOOD,
		DOS_DEVICE_VECTOR_BAD_ICMP_FRAME,
		DOS_DEVICE_VECTOR_BAD_IP_OPT,
		DOS_DEVICE_VECTOR_BAD_IPV6_HOP_COUNT,
		DOS_DEVICE_VECTOR_BAD_IPV6_VER,
		DOS_DEVICE_VECTOR_BAD_TCP_CHECKSUM,
		DOS_DEVICE_VECTOR_BAD_TCP_FLAGS_ALL_CLR,
		DOS_DEVICE_VECTOR_BAD_TCP_FLAGS_ALL_SET,
		DOS_DEVICE_VECTOR_BAD_TTL_VALUE,
		DOS_DEVICE_VECTOR_BAD_UDP_CHECKSUM,
		DOS_DEVICE_VECTOR_BAD_UDP_HEADER,
		DOS_DEVICE_VECTOR_BAD_VERSION,
		DOS_DEVICE_VECTOR_DNS_RESPONSE_FLOOD,
		DOS_DEVICE_VECTOR_ETHER_BRDCST_PKT,
		DOS_DEVICE_VECTOR_ETHER_MAC_SA_EQ_DA,
		DOS_DEVICE_VECTOR_ETHER_MULTICST_PKT,
		DOS_DEVICE_VECTOR_FIN_ONLY_SET,
		DOS_DEVICE_VECTOR_HEADER_LENGTH_GT_L2_LENGTH,
		DOS_DEVICE_VECTOR_HEADER_LENGTH_TOO_SHORT,
		DOS_DEVICE_VECTOR_HOST_UNREACHABLE,
		DOS_DEVICE_VECTOR_ICMP_FLOOD,
		DOS_DEVICE_VECTOR_ICMP_FRAG,
		DOS_DEVICE_VECTOR_ICMP_FRAME_TOO_LARGE,
		DOS_DEVICE_VECTOR_IP_ERR_CHECKSUM,
		DOS_DEVICE_VECTOR_IP_FRAG,
		DOS_DEVICE_VECTOR_IP_FRAG_FLOOD,
		DOS_DEVICE_VECTOR_IP_LENGTH_GT_L2_LENGTH,
		DOS_DEVICE_VECTOR_IP_OPT_FRAMES,
		DOS_DEVICE_VECTOR_IP_OVERLAP_FRAG,
		DOS_DEVICE_VECTOR_IP_SA_EQ_DA,
		DOS_DEVICE_VECTOR_IP_SHORT_FRAG,
		DOS_DEVICE_VECTOR_IPV6_EXT_HEADER_FRAMES,
		DOS_DEVICE_VECTOR_IPV6_FRAG,
		DOS_DEVICE_VECTOR_IPV6_FRAG_FLOOD,
		DOS_DEVICE_VECTOR_IPV6_LENGTH_GT_L2_LENGTH,
		DOS_DEVICE_VECTOR_IPV6_OVERLAP_FRAG,
		DOS_DEVICE_VECTOR_IPV6_SA_EQ_DA,
		DOS_DEVICE_VECTOR_IPV6_SHORT_FRAG,
		DOS_DEVICE_VECTOR_L2_LENGTH_GGT_IP_LENGTH,
		DOS_DEVICE_VECTOR_L4_EXT_HEADERS_GO_END,
		DOS_DEVICE_VECTOR_NO_L4,
		DOS_DEVICE_VECTOR_OPT_PRESENT_WITH_ILLEGAL_LENGTH,
		DOS_DEVICE_VECTOR_PAYLOAD_LENGTH_LS_L2_LENGTH,
		DOS_DEVICE_VECTOR_ROUTING_HEADER_TYPE_0,
		DOS_DEVICE_VECTOR_SSL_RENEGOTIATION,
		DOS_DEVICE_VECTOR_SYN_AND_FIN_SET,
		DOS_DEVICE_VECTOR_TCP_ACK_FLOOD,
		DOS_DEVICE_VECTOR_TCP_HEADER_LENGTH_GT_L2_LENGTH,
		DOS_DEVICE_VECTOR_TCP_HEADER_LENGTH_TOO_SHORT,
		DOS_DEVICE_VECTOR_TCP_LAND,
		DOS_DEVICE_VECTOR_TCP_OPT_OVERRUNS_TCP_HEADER,
		DOS_DEVICE_VECTOR_TCP_RST_FLOOD,
		DOS_DEVICE_VECTOR_TCP_SYNACK_FLOOD,
		DOS_DEVICE_VECTOR_TCP_SYN_FLOOD,
		DOS_DEVICE_VECTOR_TIDCMP,
		DOS_DEVICE_VECTOR_TOO_MANY_EXT_HEADERS,
		DOS_DEVICE_VECTOR_TTL_LEQ_ONE,
		DOS_DEVICE_VECTOR_UDP_LAND,
		DOS_DEVICE_VECTOR_UNK_TCP_OPT_TYPE,
		DOS_DEVICE_VECTOR_FLOOD,
		DOS_DEVICE_VECTOR_SWEEP,
		DOS_DEVICE_VECTOR_ICMPV6_FLOOD,
		DOS_DEVICE_VECTOR_IPV6_DUPLICATE_EXTENSION_HEADERS,
		DOS_DEVICE_VECTOR_IPV6_EXTENSION_HEADERS_WRONG_ORDER,
		DOS_DEVICE_VECTOR_IPV6_EXTENSION_HEADERS_TOO_LARGE,
		DOS_DEVICE_VECTOR_IPV6_HOP_COUNT_LEQ_ONE,
		DOS_DEVICE_VECTOR_UDP_FLOOD,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.DoSDevice.DoSNetworkVectorPacketType", Namespace = "urn:iControl")]
	public enum SecurityDoSDeviceDoSNetworkVectorPacketType
	{
		NETWORK_ATTACK_PACKET_UNKNOWN,
		NETWORK_ATTACK_PACKET_IPV4_UDP,
		NETWORK_ATTACK_PACKET_IPV4_TCP_SYN_ONLY,
		NETWORK_ATTACK_PACKET_IPV4_ICMP,
		NETWORK_ATTACK_PACKET_IPV4_ANY,
		NETWORK_ATTACK_PACKET_IPV6_UDP,
		NETWORK_ATTACK_PACKET_IPV6_TCP_SYN_ONLY,
		NETWORK_ATTACK_PACKET_IPV6_ICMP,
		NETWORK_ATTACK_PACKET_IPV6_ANY,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.DoSDevice.VectorStatisticEntry", Namespace = "urn:iControl")]
	public partial class SecurityDoSDeviceVectorStatisticEntry
	{
		private SecurityDoSDeviceDoSDeviceVector attack_vectorField;
		public SecurityDoSDeviceDoSDeviceVector attack_vector
		{
			get { return this.attack_vectorField; }
			set { this.attack_vectorField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.DoSDevice.VectorStatistics", Namespace = "urn:iControl")]
	public partial class SecurityDoSDeviceVectorStatistics
	{
		private SecurityDoSDeviceVectorStatisticEntry [] statisticsField;
		public SecurityDoSDeviceVectorStatisticEntry [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private CommonTimeStamp time_stampField;
		public CommonTimeStamp time_stamp
		{
			get { return this.time_stampField; }
			set { this.time_stampField = value; }
		}
	};

}
