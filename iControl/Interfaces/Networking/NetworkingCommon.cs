using System;
using System.Collections.Generic;
using System.Text;
namespace iControl
{
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.FilterAction", Namespace = "urn:iControl")]
	public enum NetworkingFilterAction
	{
		FILTER_ACTION_NONE,
		FILTER_ACTION_ACCEPT,
		FILTER_ACTION_DISCARD,
		FILTER_ACTION_REJECT,
		FILTER_ACTION_CONTINUE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.FlowControlType", Namespace = "urn:iControl")]
	public enum NetworkingFlowControlType
	{
		FLOW_CONTROL_PAUSE_NONE,
		FLOW_CONTROL_PAUSE_TX,
		FLOW_CONTROL_PAUSE_RX,
		FLOW_CONTROL_PAUSE_TX_RX,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPCompAlgorithm", Namespace = "urn:iControl")]
	public enum NetworkingIPCompAlgorithm
	{
		IPCOMP_ALGORITHM_UNKNOWN,
		IPCOMP_ALGORITHM_NONE,
		IPCOMP_ALGORITHM_DEFLATE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecDiffieHellmanGroup", Namespace = "urn:iControl")]
	public enum NetworkingIPsecDiffieHellmanGroup
	{
		IPSEC_DIFFIE_HELLMAN_GROUP_UNKNOWN,
		IPSEC_DIFFIE_HELLMAN_GROUP_MODP768,
		IPSEC_DIFFIE_HELLMAN_GROUP_MODP1024,
		IPSEC_DIFFIE_HELLMAN_GROUP_MODP1536,
		IPSEC_DIFFIE_HELLMAN_GROUP_MODP2048,
		IPSEC_DIFFIE_HELLMAN_GROUP_MODP3072,
		IPSEC_DIFFIE_HELLMAN_GROUP_MODP4096,
		IPSEC_DIFFIE_HELLMAN_GROUP_MODP6144,
		IPSEC_DIFFIE_HELLMAN_GROUP_MODP8192,
		IPSEC_ECDH_GROUP_ECP256,
		IPSEC_ECDH_GROUP_ECP384,
		IPSEC_ECDH_GROUP_ECP521,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecDirection", Namespace = "urn:iControl")]
	public enum NetworkingIPsecDirection
	{
		IPSEC_DIR_UNKNOWN,
		IPSEC_DIR_IN,
		IPSEC_DIR_OUT,
		IPSEC_DIR_BOTH,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecDynSaEncryptAlgorithm", Namespace = "urn:iControl")]
	public enum NetworkingIPsecDynSaEncryptAlgorithm
	{
		IPSEC_DYNAMIC_ENCR_UNKNOWN,
		IPSEC_DYNAMIC_ENCR_NULL,
		IPSEC_DYNAMIC_ENCR_3DES,
		IPSEC_DYNAMIC_ENCR_AES128,
		IPSEC_DYNAMIC_ENCR_AES192,
		IPSEC_DYNAMIC_ENCR_AES256,
		IPSEC_DYNAMIC_ENCR_AES_GCM128,
		IPSEC_DYNAMIC_ENCR_AES_GCM192,
		IPSEC_DYNAMIC_ENCR_AES_GCM256,
		IPSEC_DYNAMIC_ENCR_AES_GMAC128,
		IPSEC_DYNAMIC_ENCR_AES_GMAC192,
		IPSEC_DYNAMIC_ENCR_AES_GMAC256,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecIkeEncrAlgorithm", Namespace = "urn:iControl")]
	public enum NetworkingIPsecIkeEncrAlgorithm
	{
		IPSEC_IKE_ENCR_ALG_UNKNOWN,
		IPSEC_IKE_ENCR_ALG_DES,
		IPSEC_IKE_ENCR_ALG_3DES,
		IPSEC_IKE_ENCR_ALG_BLOWFISH,
		IPSEC_IKE_ENCR_ALG_CAST128,
		IPSEC_IKE_ENCR_ALG_AES128,
		IPSEC_IKE_ENCR_ALG_AES192,
		IPSEC_IKE_ENCR_ALG_AES256,
		IPSEC_IKE_ENCR_ALG_CAMELLIA,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecIkeHashAlgorithm", Namespace = "urn:iControl")]
	public enum NetworkingIPsecIkeHashAlgorithm
	{
		IPSEC_IKE_HASH_ALG_UNKNOWN,
		IPSEC_IKE_HASH_ALG_MD5,
		IPSEC_IKE_HASH_ALG_SHA1,
		IPSEC_IKE_HASH_ALG_SHA256,
		IPSEC_IKE_HASH_ALG_SHA384,
		IPSEC_IKE_HASH_ALG_SHA512,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecIkeLogLevel", Namespace = "urn:iControl")]
	public enum NetworkingIPsecIkeLogLevel
	{
		IPSEC_IKE_LOG_LEVEL_UNKNOWN,
		IPSEC_IKE_LOG_LEVEL_ERROR,
		IPSEC_IKE_LOG_LEVEL_WARNING,
		IPSEC_IKE_LOG_LEVEL_NOTIFY,
		IPSEC_IKE_LOG_LEVEL_INFO,
		IPSEC_IKE_LOG_LEVEL_DEBUG,
		IPSEC_IKE_LOG_LEVEL_DEBUG2,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecIkePeerCertType", Namespace = "urn:iControl")]
	public enum NetworkingIPsecIkePeerCertType
	{
		IPSEC_IKE_PEER_CERT_TYPE_UNKNOWN,
		IPSEC_IKE_PEER_CERT_TYPE_NONE,
		IPSEC_IKE_PEER_CERT_TYPE_CERTFILE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecIkePeerGeneratePolicy", Namespace = "urn:iControl")]
	public enum NetworkingIPsecIkePeerGeneratePolicy
	{
		IPSEC_IKE_PEER_GENERATE_POLICY_UNKNOWN,
		IPSEC_IKE_PEER_GENERATE_POLICY_OFF,
		IPSEC_IKE_PEER_GENERATE_POLICY_ON,
		IPSEC_IKE_PEER_GENERATE_POLICY_UNIQUE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecIkePeerIDType", Namespace = "urn:iControl")]
	public enum NetworkingIPsecIkePeerIDType
	{
		IPSEC_IKE_PEER_TYPE_UNKNOWN,
		IPSEC_IKE_PEER_TYPE_ADDRESS,
		IPSEC_IKE_PEER_TYPE_FQDN,
		IPSEC_IKE_PEER_TYPE_USER_FQDN,
		IPSEC_IKE_PEER_TYPE_KEYID_TAG,
		IPSEC_IKE_PEER_TYPE_ASN1DN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecIkePeerMode", Namespace = "urn:iControl")]
	public enum NetworkingIPsecIkePeerMode
	{
		IPSEC_IKE_EXCHANGE_MODE_UNKNOWN,
		IPSEC_IKE_EXCHANGE_MODE_AGGRESSIVE,
		IPSEC_IKE_EXCHANGE_MODE_MAIN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecIkePeerNatTraversal", Namespace = "urn:iControl")]
	public enum NetworkingIPsecIkePeerNatTraversal
	{
		IPSEC_IKE_PEER_NAT_TRAVERSAL_UNKNOWN,
		IPSEC_IKE_PEER_NAT_TRAVERSAL_OFF,
		IPSEC_IKE_PEER_NAT_TRAVERSAL_ON,
		IPSEC_IKE_PEER_NAT_TRAVERSAL_FORCE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecIkeVersion", Namespace = "urn:iControl")]
	public enum NetworkingIPsecIkeVersion
	{
		IPSEC_IKE_VERSION_UNKNOWN,
		IPSEC_IKE_VERSION_1,
		IPSEC_IKE_VERSION_2,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecManSaEncrAlgorithm", Namespace = "urn:iControl")]
	public enum NetworkingIPsecManSaEncrAlgorithm
	{
		IPSEC_MANUAL_SA_ENCR_UNKNOWN,
		IPSEC_MANUAL_SA_ENCR_NULL,
		IPSEC_MANUAL_SA_ENCR_3DES,
		IPSEC_MANUAL_SA_ENCR_AES128,
		IPSEC_MANUAL_SA_ENCR_AES192,
		IPSEC_MANUAL_SA_ENCR_AES256,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecMode", Namespace = "urn:iControl")]
	public enum NetworkingIPsecMode
	{
		IPSEC_MODE_UNKNOWN,
		IPSEC_MODE_TRANSPORT,
		IPSEC_MODE_TUNNEL,
		IPSEC_MODE_ISESSION,
		IPSEC_MODE_INTERFACE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecProtocol", Namespace = "urn:iControl")]
	public enum NetworkingIPsecProtocol
	{
		IPSEC_PROTOCOL_UNKNOWN,
		IPSEC_PROTOCOL_ESP,
		IPSEC_PROTOCOL_AH,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecSaAuthAlgorithm", Namespace = "urn:iControl")]
	public enum NetworkingIPsecSaAuthAlgorithm
	{
		IPSEC_DYNAMIC_SA_AUTH_UNKNOWN,
		IPSEC_DYNAMIC_SA_AUTH_SHA1,
		IPSEC_DYNAMIC_SA_AUTH_AES_GCM128,
		IPSEC_DYNAMIC_SA_AUTH_AES_GCM192,
		IPSEC_DYNAMIC_SA_AUTH_AES_GCM256,
		IPSEC_DYNAMIC_SA_AUTH_AES_GMAC128,
		IPSEC_DYNAMIC_SA_AUTH_AES_GMAC192,
		IPSEC_DYNAMIC_SA_AUTH_AES_GMAC256,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecSaManAlgorithm", Namespace = "urn:iControl")]
	public enum NetworkingIPsecSaManAlgorithm
	{
		IPSEC_MANUAL_SA_AUTH_UNKNOWN,
		IPSEC_MANUAL_SA_AUTH_SHA1,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecSaMethod", Namespace = "urn:iControl")]
	public enum NetworkingIPsecSaMethod
	{
		IPSEC_AUTH_METHOD_UNKNOWN,
		IPSEC_AUTH_METHOD_PRE_SHARED_KEY,
		IPSEC_AUTH_METHOD_RSA_SIGNATURE,
		IPSEC_AUTH_METHOD_DSS,
		IPSEC_AUTH_METHOD_ECDSA_256,
		IPSEC_AUTH_METHOD_ECDSA_384,
		IPSEC_AUTH_METHOD_ECDSA_521,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.IPsecTrafficSelectorAction", Namespace = "urn:iControl")]
	public enum NetworkingIPsecTrafficSelectorAction
	{
		IPSEC_TRAFFIC_SELECTOR_ACTION_UNKNOWN,
		IPSEC_TRAFFIC_SELECTOR_ACTION_DISCARD,
		IPSEC_TRAFFIC_SELECTOR_ACTION_PROTECT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.LearningMode", Namespace = "urn:iControl")]
	public enum NetworkingLearningMode
	{
		LEARNING_MODE_ENABLE_FORWARD,
		LEARNING_MODE_DISABLE_FORWARD,
		LEARNING_MODE_DISABLE_DROP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.MediaStatus", Namespace = "urn:iControl")]
	public enum NetworkingMediaStatus
	{
		MEDIA_STATUS_UP,
		MEDIA_STATUS_DOWN,
		MEDIA_STATUS_DISABLED,
		MEDIA_STATUS_UNINITIALIZED,
		MEDIA_STATUS_LOOPBACK,
		MEDIA_STATUS_UNPOPULATED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.MemberTagMode", Namespace = "urn:iControl")]
	public enum NetworkingMemberTagMode
	{
		MEMBER_TAG_MODE_UNKNOWN,
		MEMBER_TAG_MODE_NONE,
		MEMBER_TAG_MODE_SERVICE,
		MEMBER_TAG_MODE_CUSTOMER,
		MEMBER_TAG_MODE_DOUBLE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.MemberTagType", Namespace = "urn:iControl")]
	public enum NetworkingMemberTagType
	{
		MEMBER_TAGGED,
		MEMBER_UNTAGGED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.MemberType", Namespace = "urn:iControl")]
	public enum NetworkingMemberType
	{
		MEMBER_INTERFACE,
		MEMBER_TRUNK,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.PhyMasterSlaveMode", Namespace = "urn:iControl")]
	public enum NetworkingPhyMasterSlaveMode
	{
		PHY_MODE_NONE,
		PHY_MODE_SLAVE,
		PHY_MODE_MASTER,
		PHY_MODE_AUTO,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteEntryType", Namespace = "urn:iControl")]
	public enum NetworkingRouteEntryType
	{
		ROUTE_TYPE_GATEWAY,
		ROUTE_TYPE_POOL,
		ROUTE_TYPE_INTERFACE,
		ROUTE_TYPE_REJECT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPLinkType", Namespace = "urn:iControl")]
	public enum NetworkingSTPLinkType
	{
		STP_LINK_TYPE_P2P,
		STP_LINK_TYPE_SHARED,
		STP_LINK_TYPE_AUTO,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPModeType", Namespace = "urn:iControl")]
	public enum NetworkingSTPModeType
	{
		STP_MODE_TYPE_DISABLED,
		STP_MODE_TYPE_PASSTHROUGH,
		STP_MODE_TYPE_STP,
		STP_MODE_TYPE_RSTP,
		STP_MODE_TYPE_MSTP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPRoleType", Namespace = "urn:iControl")]
	public enum NetworkingSTPRoleType
	{
		STP_ROLE_TYPE_DISABLE,
		STP_ROLE_TYPE_ROOT,
		STP_ROLE_TYPE_DESIGNATE,
		STP_ROLE_TYPE_ALTERNATE,
		STP_ROLE_TYPE_BACKUP,
		STP_ROLE_TYPE_MASTER,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPStateType", Namespace = "urn:iControl")]
	public enum NetworkingSTPStateType
	{
		STP_STATE_TYPE_DETACH,
		STP_STATE_TYPE_BLOCK,
		STP_STATE_TYPE_LISTEN,
		STP_STATE_TYPE_LEARN,
		STP_STATE_TYPE_FORWARD,
		STP_STATE_TYPE_DISABLE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.TunnelProfileType", Namespace = "urn:iControl")]
	public enum NetworkingTunnelProfileType
	{
		TUNNEL_PROFILE_UNKNOWN,
		TUNNEL_PROFILE_ETHERIP,
		TUNNEL_PROFILE_FEC,
		TUNNEL_PROFILE_GRE,
		TUNNEL_PROFILE_IPIP,
		TUNNEL_PROFILE_PPP,
		TUNNEL_PROFILE_TCPFORWARD,
		TUNNEL_PROFILE_VXLAN,
		TUNNEL_PROFILE_WCCPGRE,
		TUNNEL_PROFILE_V6RD,
		TUNNEL_PROFILE_IPSEC,
		TUNNEL_PROFILE_GENEVE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.TunnelProtocol", Namespace = "urn:iControl")]
	public enum NetworkingTunnelProtocol
	{
		TUNNEL_PROTOCOL_UNKNOWN,
		TUNNEL_PROTOCOL_IPV4,
		TUNNEL_PROTOCOL_IPV6,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileTunnelProtocol", Namespace = "urn:iControl")]
	public partial class NetworkingProfileTunnelProtocol
	{
		private NetworkingTunnelProtocol valueField;
		public NetworkingTunnelProtocol value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Uuid_128", Namespace = "urn:iControl")]
	public partial class NetworkingUuid_128
	{
		private CommonULong64 low_partField;
		public CommonULong64 low_part
		{
			get { return this.low_partField; }
			set { this.low_partField = value; }
		}
		private CommonULong64 high_partField;
		public CommonULong64 high_part
		{
			get { return this.high_partField; }
			set { this.high_partField = value; }
		}
	};

}
