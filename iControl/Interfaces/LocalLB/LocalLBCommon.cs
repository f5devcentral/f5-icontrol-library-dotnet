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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ActivationMode", Namespace = "urn:iControl")]
	public enum LocalLBActivationMode
	{
		STARTTLS_ACTIVATION_UNKNOWN,
		STARTTLS_ACTIVATION_NONE,
		STARTTLS_ACTIVATION_ALLOW,
		STARTTLS_ACTIVATION_REQUIRE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.AdaptServiceDownAction", Namespace = "urn:iControl")]
	public enum LocalLBAdaptServiceDownAction
	{
		ADAPT_ACTION_UNKNOWN,
		ADAPT_ACTION_IGNORE,
		ADAPT_ACTION_RESET,
		ADAPT_ACTION_DROP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.AddressType", Namespace = "urn:iControl")]
	public enum LocalLBAddressType
	{
		ATYPE_UNSET,
		ATYPE_STAR_ADDRESS_STAR_PORT,
		ATYPE_STAR_ADDRESS_EXPLICIT_PORT,
		ATYPE_EXPLICIT_ADDRESS_EXPLICIT_PORT,
		ATYPE_STAR_ADDRESS,
		ATYPE_EXPLICIT_ADDRESS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.AuthenticationMethod", Namespace = "urn:iControl")]
	public enum LocalLBAuthenticationMethod
	{
		AUTHENTICATION_METHOD_LDAP,
		AUTHENTICATION_METHOD_RADIUS,
		AUTHENTICATION_METHOD_SSL_CC_LDAP,
		AUTHENTICATION_METHOD_SSL_OCSP,
		AUTHENTICATION_METHOD_TACACS,
		AUTHENTICATION_METHOD_GENERIC,
		AUTHENTICATION_METHOD_SSL_CRLDP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.AvailabilityStatus", Namespace = "urn:iControl")]
	public enum LocalLBAvailabilityStatus
	{
		AVAILABILITY_STATUS_NONE,
		AVAILABILITY_STATUS_GREEN,
		AVAILABILITY_STATUS_YELLOW,
		AVAILABILITY_STATUS_RED,
		AVAILABILITY_STATUS_BLUE,
		AVAILABILITY_STATUS_GRAY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ClientSSLCertificateMode", Namespace = "urn:iControl")]
	public enum LocalLBClientSSLCertificateMode
	{
		CLIENTSSL_CERTIFICATE_MODE_REQUEST,
		CLIENTSSL_CERTIFICATE_MODE_REQUIRE,
		CLIENTSSL_CERTIFICATE_MODE_IGNORE,
		CLIENTSSL_CERTIFICATE_MODE_AUTO,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ClonePoolType", Namespace = "urn:iControl")]
	public enum LocalLBClonePoolType
	{
		CLONE_POOL_TYPE_UNDEFINED,
		CLONE_POOL_TYPE_CLIENTSIDE,
		CLONE_POOL_TYPE_SERVERSIDE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.CompressionMethod", Namespace = "urn:iControl")]
	public enum LocalLBCompressionMethod
	{
		COMPRESSION_METHOD_DEFLATE,
		COMPRESSION_METHOD_GZIP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.CookiePersistenceMethod", Namespace = "urn:iControl")]
	public enum LocalLBCookiePersistenceMethod
	{
		COOKIE_PERSISTENCE_METHOD_NONE,
		COOKIE_PERSISTENCE_METHOD_INSERT,
		COOKIE_PERSISTENCE_METHOD_REWRITE,
		COOKIE_PERSISTENCE_METHOD_PASSIVE,
		COOKIE_PERSISTENCE_METHOD_HASH,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.CredentialSource", Namespace = "urn:iControl")]
	public enum LocalLBCredentialSource
	{
		CREDENTIAL_SOURCE_HTTP_BASIC_AUTH,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSCacheLocalZoneType", Namespace = "urn:iControl")]
	public enum LocalLBDNSCacheLocalZoneType
	{
		DNS_CACHE_LOCAL_ZONE_TYPE_UNKNOWN,
		DNS_CACHE_LOCAL_ZONE_TYPE_DENY,
		DNS_CACHE_LOCAL_ZONE_TYPE_REDIRECT,
		DNS_CACHE_LOCAL_ZONE_TYPE_REFUSE,
		DNS_CACHE_LOCAL_ZONE_TYPE_STATIC,
		DNS_CACHE_LOCAL_ZONE_TYPE_TRANSPARENT,
		DNS_CACHE_LOCAL_ZONE_TYPE_TYPETRANSPARENT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSCacheType", Namespace = "urn:iControl")]
	public enum LocalLBDNSCacheType
	{
		DNS_CACHE_TYPE_UNKNOWN,
		DNS_CACHE_TYPE_CACHE_RESOLVER,
		DNS_CACHE_TYPE_VALIDATING_CACHE_RESOLVER,
		DNS_CACHE_TYPE_CACHE_ONLY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSRRSetRotateType", Namespace = "urn:iControl")]
	public enum LocalLBDNSRRSetRotateType
	{
		DNS_RRSET_ROTATE_TYPE_UNKNOWN,
		DNS_RRSET_ROTATE_TYPE_NONE,
		DNS_RRSET_ROTATE_TYPE_QID,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DataGroupType", Namespace = "urn:iControl")]
	public enum LocalLBDataGroupType
	{
		DATA_GROUP_UNDEFINED,
		DATA_GROUP_ADDRESS,
		DATA_GROUP_STRING,
		DATA_GROUP_VALUE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.EnabledStatus", Namespace = "urn:iControl")]
	public enum LocalLBEnabledStatus
	{
		ENABLED_STATUS_NONE,
		ENABLED_STATUS_ENABLED,
		ENABLED_STATUS_DISABLED,
		ENABLED_STATUS_DISABLED_BY_PARENT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ForwardProxyBypassDefaultAction", Namespace = "urn:iControl")]
	public enum LocalLBForwardProxyBypassDefaultAction
	{
		FORWARD_PROXY_BYPASS_DEFAULT_ACTION_UNKNOWN,
		FORWARD_PROXY_BYPASS_DEFAULT_ACTION_INTERCEPT,
		FORWARD_PROXY_BYPASS_DEFAULT_ACTION_BYPASS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.HardwareAccelerationMode", Namespace = "urn:iControl")]
	public enum LocalLBHardwareAccelerationMode
	{
		HW_ACCELERATION_MODE_NONE,
		HW_ACCELERATION_MODE_ASSIST,
		HW_ACCELERATION_MODE_FULL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.HttpChunkMode", Namespace = "urn:iControl")]
	public enum LocalLBHttpChunkMode
	{
		HTTP_CHUNK_MODE_PRESERVE,
		HTTP_CHUNK_MODE_SELECTIVE,
		HTTP_CHUNK_MODE_UNCHUNK,
		HTTP_CHUNK_MODE_RECHUNK,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.HttpCompressionMode", Namespace = "urn:iControl")]
	public enum LocalLBHttpCompressionMode
	{
		HTTP_COMPRESSION_MODE_DISABLE,
		HTTP_COMPRESSION_MODE_ENABLE,
		HTTP_COMPRESSION_MODE_SELECTIVE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.HttpRedirectRewriteMode", Namespace = "urn:iControl")]
	public enum LocalLBHttpRedirectRewriteMode
	{
		HTTP_REDIRECT_REWRITE_MODE_NONE,
		HTTP_REDIRECT_REWRITE_MODE_ALL,
		HTTP_REDIRECT_REWRITE_MODE_NODES,
		HTTP_REDIRECT_REWRITE_MODE_MATCHING,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LBMethod", Namespace = "urn:iControl")]
	public enum LocalLBLBMethod
	{
		LB_METHOD_ROUND_ROBIN,
		LB_METHOD_RATIO_MEMBER,
		LB_METHOD_LEAST_CONNECTION_MEMBER,
		LB_METHOD_OBSERVED_MEMBER,
		LB_METHOD_PREDICTIVE_MEMBER,
		LB_METHOD_RATIO_NODE_ADDRESS,
		LB_METHOD_LEAST_CONNECTION_NODE_ADDRESS,
		LB_METHOD_FASTEST_NODE_ADDRESS,
		LB_METHOD_OBSERVED_NODE_ADDRESS,
		LB_METHOD_PREDICTIVE_NODE_ADDRESS,
		LB_METHOD_DYNAMIC_RATIO,
		LB_METHOD_FASTEST_APP_RESPONSE,
		LB_METHOD_LEAST_SESSIONS,
		LB_METHOD_DYNAMIC_RATIO_MEMBER,
		LB_METHOD_L3_ADDR,
		LB_METHOD_UNKNOWN,
		LB_METHOD_WEIGHTED_LEAST_CONNECTION_MEMBER,
		LB_METHOD_WEIGHTED_LEAST_CONNECTION_NODE_ADDRESS,
		LB_METHOD_RATIO_SESSION,
		LB_METHOD_RATIO_LEAST_CONNECTION_MEMBER,
		LB_METHOD_RATIO_LEAST_CONNECTION_NODE_ADDRESS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LogAction", Namespace = "urn:iControl")]
	public enum LocalLBLogAction
	{
		LOG_ACTION_UNKNOWN,
		LOG_ACTION_DISABLED,
		LOG_ACTION_ENABLED,
		LOG_ACTION_BACKUP_ALLOCATION_ONLY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.LogElement", Namespace = "urn:iControl")]
	public enum LocalLBLogElement
	{
		LOG_ELEMENT_UNKNOWN,
		LOG_ELEMENT_DESTINATION,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MessageRoutingProtocol", Namespace = "urn:iControl")]
	public enum LocalLBMessageRoutingProtocol
	{
		MESSAGE_ROUTING_PROTOCOL_UNKNOWN,
		MESSAGE_ROUTING_PROTOCOL_NONE,
		MESSAGE_ROUTING_PROTOCOL_GENERIC_MESSAGE,
		MESSAGE_ROUTING_PROTOCOL_SIP,
		MESSAGE_ROUTING_PROTOCOL_DIAMETER,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MonitorAssociationRemovalRule", Namespace = "urn:iControl")]
	public enum LocalLBMonitorAssociationRemovalRule
	{
		REMOVE_EXPLICIT_MONITOR_ASSOCIATION,
		REMOVE_ALL_MONITOR_ASSOCIATION,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MonitorInstanceStateType", Namespace = "urn:iControl")]
	public enum LocalLBMonitorInstanceStateType
	{
		INSTANCE_STATE_UNCHECKED,
		INSTANCE_STATE_CHECKING,
		INSTANCE_STATE_UP,
		INSTANCE_STATE_DOWN,
		INSTANCE_STATE_FORCED_DOWN,
		INSTANCE_STATE_DISABLED,
		INSTANCE_STATE_DOWN_BY_IRULE,
		INSTANCE_STATE_DOWN_WAIT_FOR_MANUAL_RESUME,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MonitorRuleType", Namespace = "urn:iControl")]
	public enum LocalLBMonitorRuleType
	{
		MONITOR_RULE_TYPE_UNDEFINED,
		MONITOR_RULE_TYPE_NONE,
		MONITOR_RULE_TYPE_SINGLE,
		MONITOR_RULE_TYPE_AND_LIST,
		MONITOR_RULE_TYPE_M_OF_N,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MonitorStatus", Namespace = "urn:iControl")]
	public enum LocalLBMonitorStatus
	{
		MONITOR_STATUS_UNCHECKED,
		MONITOR_STATUS_CHECKING,
		MONITOR_STATUS_UP,
		MONITOR_STATUS_DOWN,
		MONITOR_STATUS_FORCED_DOWN,
		MONITOR_STATUS_MAINT,
		MONITOR_STATUS_ADDRESS_DOWN,
		MONITOR_STATUS_DOWN_BY_IRULE,
		MONITOR_STATUS_DOWN_WAIT_FOR_MANUAL_RESUME,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PersistenceMode", Namespace = "urn:iControl")]
	public enum LocalLBPersistenceMode
	{
		PERSISTENCE_MODE_NONE,
		PERSISTENCE_MODE_SOURCE_ADDRESS_AFFINITY,
		PERSISTENCE_MODE_DESTINATION_ADDRESS_AFFINITY,
		PERSISTENCE_MODE_COOKIE,
		PERSISTENCE_MODE_MSRDP,
		PERSISTENCE_MODE_SSL_SID,
		PERSISTENCE_MODE_SIP,
		PERSISTENCE_MODE_UIE,
		PERSISTENCE_MODE_HASH,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PolicyEvent", Namespace = "urn:iControl")]
	public enum LocalLBPolicyEvent
	{
		POLICY_EVENT_UNKNOWN,
		POLICY_EVENT_CLIENT_ACCEPTED,
		POLICY_EVENT_CLIENTSSL_CLIENTHELLO,
		POLICY_EVENT_SERVER_CONNECTED,
		POLICY_EVENT_SERVERSSL_SERVERHELLO,
		POLICY_EVENT_SERVERSSL_HANDSHAKE,
		POLICY_EVENT_HTTP_REQUEST,
		POLICY_EVENT_HTTP_RESPONSE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PolicyOperand", Namespace = "urn:iControl")]
	public enum LocalLBPolicyOperand
	{
		POLICY_OPERAND_UNKNOWN,
		POLICY_OPERAND_TCP,
		POLICY_OPERAND_CLIENT_SSL,
		POLICY_OPERAND_HTTP_METHOD,
		POLICY_OPERAND_HTTP_URI,
		POLICY_OPERAND_HTTP_VERSION,
		POLICY_OPERAND_HTTP_STATUS,
		POLICY_OPERAND_HTTP_HOST,
		POLICY_OPERAND_HTTP_HEADER,
		POLICY_OPERAND_HTTP_REFERER,
		POLICY_OPERAND_HTTP_COOKIE,
		POLICY_OPERAND_HTTP_SET_COOKIE,
		POLICY_OPERAND_HTTP_BASIC_AUTH,
		POLICY_OPERAND_HTTP_USER_AGENT,
		POLICY_OPERAND_SSL_EXTENSION,
		POLICY_OPERAND_SSL_CERT,
		POLICY_OPERAND_GEOIP,
		POLICY_OPERAND_CPU_USAGE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PolicySelector", Namespace = "urn:iControl")]
	public enum LocalLBPolicySelector
	{
		POLICY_SELECTOR_UNKNOWN,
		POLICY_SELECTOR_ALL,
		POLICY_SELECTOR_NAME,
		POLICY_SELECTOR_VALUE,
		POLICY_SELECTOR_ADDRESS,
		POLICY_SELECTOR_HEADER,
		POLICY_SELECTOR_SCHEME,
		POLICY_SELECTOR_HOST,
		POLICY_SELECTOR_PORT,
		POLICY_SELECTOR_PATH,
		POLICY_SELECTOR_QUERY_STRING,
		POLICY_SELECTOR_EXTENSION,
		POLICY_SELECTOR_PATH_SEGMENT,
		POLICY_SELECTOR_QUERY_PARAM,
		POLICY_SELECTOR_UNNAMED_QUERY_PARAM,
		POLICY_SELECTOR_MAJOR,
		POLICY_SELECTOR_MINOR,
		POLICY_SELECTOR_CODE,
		POLICY_SELECTOR_TEXT,
		POLICY_SELECTOR_DOMAIN,
		POLICY_SELECTOR_EXPIRY,
		POLICY_SELECTOR_VERSION,
		POLICY_SELECTOR_USERNAME,
		POLICY_SELECTOR_PASSWORD,
		POLICY_SELECTOR_PROTOCOL,
		POLICY_SELECTOR_CIPHER,
		POLICY_SELECTOR_CIPHER_BITS,
		POLICY_SELECTOR_RTT,
		POLICY_SELECTOR_MSS,
		POLICY_SELECTOR_VLAN,
		POLICY_SELECTOR_VLAN_ID,
		POLICY_SELECTOR_ROUTE_DOMAIN,
		POLICY_SELECTOR_SERVER_NAME,
		POLICY_SELECTOR_COMMON_NAME,
		POLICY_SELECTOR_NPN,
		POLICY_SELECTOR_ALPN,
		POLICY_SELECTOR_CONTINENT,
		POLICY_SELECTOR_COUNTRY_CODE,
		POLICY_SELECTOR_COUNTRY_NAME,
		POLICY_SELECTOR_REGION_NAME,
		POLICY_SELECTOR_REGION_CODE,
		POLICY_SELECTOR_ORG,
		POLICY_SELECTOR_ISP,
		POLICY_SELECTOR_LAST_15SECS,
		POLICY_SELECTOR_LAST_1MIN,
		POLICY_SELECTOR_LAST_5MINS,
		POLICY_SELECTOR_DEVICE_MAKE,
		POLICY_SELECTOR_DEVICE_MODEL,
		POLICY_SELECTOR_BROWSER_TYPE,
		POLICY_SELECTOR_BROWSER_VERSION,
		POLICY_SELECTOR_UA_TOKEN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileContextType", Namespace = "urn:iControl")]
	public enum LocalLBProfileContextType
	{
		PROFILE_CONTEXT_TYPE_ALL,
		PROFILE_CONTEXT_TYPE_CLIENT,
		PROFILE_CONTEXT_TYPE_SERVER,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileMode", Namespace = "urn:iControl")]
	public enum LocalLBProfileMode
	{
		PROFILE_MODE_DISABLED,
		PROFILE_MODE_ENABLED,
		PROFILE_MODE_UNKNOWN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileType", Namespace = "urn:iControl")]
	public enum LocalLBProfileType
	{
		PROFILE_TYPE_TCP,
		PROFILE_TYPE_UDP,
		PROFILE_TYPE_FTP,
		PROFILE_TYPE_FAST_L4,
		PROFILE_TYPE_HTTP,
		PROFILE_TYPE_SERVER_SSL,
		PROFILE_TYPE_CLIENT_SSL,
		PROFILE_TYPE_AUTH,
		PROFILE_TYPE_PERSISTENCE,
		PROFILE_TYPE_CONNECTION_POOL,
		PROFILE_TYPE_STREAM,
		PROFILE_TYPE_XML,
		PROFILE_TYPE_FAST_HTTP,
		PROFILE_TYPE_IIOP,
		PROFILE_TYPE_RTSP,
		PROFILE_TYPE_STATISTICS,
		PROFILE_TYPE_HTTPCLASS,
		PROFILE_TYPE_DNS,
		PROFILE_TYPE_SCTP,
		PROFILE_TYPE_INSTANCE,
		PROFILE_TYPE_SIPP,
		PROFILE_TYPE_HTTPCOMPRESSION,
		PROFILE_TYPE_WEBACCELERATION,
		PROFILE_TYPE_UNKNOWN,
		PROFILE_TYPE_RADIUS,
		PROFILE_TYPE_DIAMETER,
		PROFILE_TYPE_ANALYTICS,
		PROFILE_TYPE_REQUEST_LOGGING,
		PROFILE_TYPE_DOS,
		PROFILE_TYPE_ICAP,
		PROFILE_TYPE_REQUESTADAPT,
		PROFILE_TYPE_RESPONSEADAPT,
		PROFILE_TYPE_IPINTELLIGENCE,
		PROFILE_TYPE_SPDY,
		PROFILE_TYPE_DIAMETER_ENDPOINT,
		PROFILE_TYPE_DIAMETER_ROUTER,
		PROFILE_TYPE_WEBSECURITY,
		PROFILE_TYPE_HTTPSECURITY,
		PROFILE_TYPE_PPTP,
		PROFILE_TYPE_FIX,
		PROFILE_TYPE_SIP_ROUTER,
		PROFILE_TYPE_SIP_SESSION,
		PROFILE_TYPE_CLIENT_LDAP,
		PROFILE_TYPE_SERVER_LDAP,
		PROFILE_TYPE_TFTP,
		PROFILE_TYPE_DIAMETER_SESSION,
		PROFILE_TYPE_IPSECALG,
		PROFILE_TYPE_TRAFFIC_ACCELERATION,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RPZActionType", Namespace = "urn:iControl")]
	public enum LocalLBRPZActionType
	{
		RPZ_ACTION_TYPE_UNKNOWN,
		RPZ_ACTION_TYPE_NXDOMAIN,
		RPZ_ACTION_TYPE_WALLEDGARDEN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RamCacheCacheControlMode", Namespace = "urn:iControl")]
	public enum LocalLBRamCacheCacheControlMode
	{
		RAMCACHE_CACHE_CONTROL_MODE_NONE,
		RAMCACHE_CACHE_CONTROL_MODE_MAX_AGE,
		RAMCACHE_CACHE_CONTROL_MODE_ALL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RateLimitMode", Namespace = "urn:iControl")]
	public enum LocalLBRateLimitMode
	{
		RATE_LIMIT_MODE_UNKNOWN,
		RATE_LIMIT_MODE_OBJECT,
		RATE_LIMIT_MODE_OBJECT_SRC,
		RATE_LIMIT_MODE_OBJECT_DST,
		RATE_LIMIT_MODE_OBJECT_SRC_DST,
		RATE_LIMIT_MODE_SRC,
		RATE_LIMIT_MODE_DST,
		RATE_LIMIT_MODE_SRC_DST,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ResponseControlMode", Namespace = "urn:iControl")]
	public enum LocalLBResponseControlMode
	{
		RESPONSE_CONTROL_MODE_UNKNOWN,
		RESPONSE_CONTROL_MODE_IGNORE,
		RESPONSE_CONTROL_MODE_DROP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.RtspProxyType", Namespace = "urn:iControl")]
	public enum LocalLBRtspProxyType
	{
		RTSP_PROXY_TYPE_NONE,
		RTSP_PROXY_TYPE_EXTERNAL,
		RTSP_PROXY_TYPE_INTERNAL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SSLCertificateExtension", Namespace = "urn:iControl")]
	public enum LocalLBSSLCertificateExtension
	{
		SSL_FWDP_CERT_EXT_UNKNOWN,
		SSL_FWDP_CERT_EXT_AUTHORITY_KEY_IDENTIFIER,
		SSL_FWDP_CERT_EXT_BASIC_CONSTRAINTS,
		SSL_FWDP_CERT_EXT_CERTIFICATE_POLICIES,
		SSL_FWDP_CERT_EXT_CRL_DISTRIBUTION_POINTS,
		SSL_FWDP_CERT_EXT_EXTENDED_KEY_USAGE,
		SSL_FWDP_CERT_EXT_FRESH_CRL,
		SSL_FWDP_CERT_EXT_ISSUER_ALTERNATIVE_NAME,
		SSL_FWDP_CERT_EXT_KEY_USAGE,
		SSL_FWDP_CERT_EXT_SUBJECT_ALTERNATIVE_NAME,
		SSL_FWDP_CERT_EXT_SUBJECT_DIRECTORY_ATTRIBUTES,
		SSL_FWDP_CERT_EXT_SUBJECT_KEY_IDENTIFIER,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SSLOption", Namespace = "urn:iControl")]
	public enum LocalLBSSLOption
	{
		SSL_OPTION_MICROSOFT_SESSION_ID_BUG,
		SSL_OPTION_NETSCAPE_CHALLENGE_BUG,
		SSL_OPTION_NETSCAPE_REUSE_CIPHER_CHANGE_BUG,
		SSL_OPTION_SSLREF2_REUSE_CERT_TYPE_BUG,
		SSL_OPTION_MICROSOFT_BIG_SSLV3_BUFFER,
		SSL_OPTION_MSIE_SSL_V2_RSA_PADDING,
		SSL_OPTION_SSLEAY_080_CLIENT_DH_BUG,
		SSL_OPTION_TLS_D5_BUG,
		SSL_OPTION_TLS_BLOCK_PADDING_BUG,
		SSL_OPTION_DONT_INSERT_EMPTY_FRAGMENTS,
		SSL_OPTION_ALL_BUGFIXES,
		SSL_OPTION_PASSIVE_CLOSE,
		SSL_OPTION_NO_SESSION_RESUMPTION_ON_RENEGOTIATION,
		SSL_OPTION_SINGLE_DH_USE,
		SSL_OPTION_EPHEMERAL_RSA,
		SSL_OPTION_CIPHER_SERVER_PREFERENCE,
		SSL_OPTION_TLS_ROLLBACK_BUG,
		SSL_OPTION_NO_SSL_V2,
		SSL_OPTION_NO_SSL_V3,
		SSL_OPTION_NO_TLS_V1,
		SSL_OPTION_PKCS1_CHECK_1,
		SSL_OPTION_PKCS1_CHECK_2,
		SSL_OPTION_NETSCAPE_CA_DN_BUG,
		SSL_OPTION_NETSCAPE_DEMO_CIPHER_CHANGE_BUG,
		SSL_OPTION_NO_SSL,
		SSL_OPTION_NO_DTLS,
		SSL_OPTION_NO_TLSv1_1,
		SSL_OPTION_NO_TLSv1_2,
		SSL_OPTION_NO_TLS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SSLSignHash", Namespace = "urn:iControl")]
	public enum LocalLBSSLSignHash
	{
		SSL_SIGN_HASH_UNKNOWN,
		SSL_SIGN_HASH_ANY,
		SSL_SIGN_HASH_SHA1,
		SSL_SIGN_HASH_SHA256,
		SSL_SIGN_HASH_SHA384,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SecureRenegotiationMode", Namespace = "urn:iControl")]
	public enum LocalLBSecureRenegotiationMode
	{
		SECURE_RENEGOTIATION_MODE_UNKNOWN,
		SECURE_RENEGOTIATION_MODE_REQUEST,
		SECURE_RENEGOTIATION_MODE_REQUIRE,
		SECURE_RENEGOTIATION_MODE_REQUIRE_STRICT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ServerSSLCertificateMode", Namespace = "urn:iControl")]
	public enum LocalLBServerSSLCertificateMode
	{
		SERVERSSL_CERTIFICATE_MODE_REQUIRE,
		SERVERSSL_CERTIFICATE_MODE_IGNORE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ServiceDownAction", Namespace = "urn:iControl")]
	public enum LocalLBServiceDownAction
	{
		SERVICE_DOWN_ACTION_NONE,
		SERVICE_DOWN_ACTION_RESET,
		SERVICE_DOWN_ACTION_DROP,
		SERVICE_DOWN_ACTION_RESELECT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SessionStatus", Namespace = "urn:iControl")]
	public enum LocalLBSessionStatus
	{
		SESSION_STATUS_ENABLED,
		SESSION_STATUS_DISABLED,
		SESSION_STATUS_FORCED_DISABLED,
		SESSION_STATUS_ADDRESS_DISABLED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SnatType", Namespace = "urn:iControl")]
	public enum LocalLBSnatType
	{
		SNAT_TYPE_NONE,
		SNAT_TYPE_TRANSLATION_ADDRESS,
		SNAT_TYPE_SNATPOOL,
		SNAT_TYPE_AUTOMAP,
		SNAT_TYPE_UNKNOWN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.TCPCongestionControlMode", Namespace = "urn:iControl")]
	public enum LocalLBTCPCongestionControlMode
	{
		TCP_CONGESTION_CONTROL_NONE,
		TCP_CONGESTION_CONTROL_RENO,
		TCP_CONGESTION_CONTROL_NEWRENO,
		TCP_CONGESTION_CONTROL_SCALABLE,
		TCP_CONGESTION_CONTROL_HIGHSPEED,
		TCP_CONGESTION_CONTROL_VEGAS,
		TCP_CONGESTION_CONTROL_ILLINOIS,
		TCP_CONGESTION_CONTROL_WOODSIDE,
		TCP_CONGESTION_CONTROL_CHD,
		TCP_CONGESTION_CONTROL_CDG,
		TCP_CONGESTION_CONTROL_CUBIC,
		TCP_CONGESTION_CONTROL_WESTWOOD,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.TCPOptionMode", Namespace = "urn:iControl")]
	public enum LocalLBTCPOptionMode
	{
		TCP_OPTION_MODE_PRESERVE,
		TCP_OPTION_MODE_STRIP,
		TCP_OPTION_MODE_REWRITE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.TCPPacketDFMode", Namespace = "urn:iControl")]
	public enum LocalLBTCPPacketDFMode
	{
		TCP_PACKET_IP_DF_UNKNOWN,
		TCP_PACKET_IP_DF_PMTU,
		TCP_PACKET_IP_DF_PRESERVE,
		TCP_PACKET_IP_DF_SET,
		TCP_PACKET_IP_DF_CLEAR,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.TCPPacketTTLMode", Namespace = "urn:iControl")]
	public enum LocalLBTCPPacketTTLMode
	{
		TCP_PACKET_IP_TTL_UNKNOWN,
		TCP_PACKET_IP_TTL_PROXY,
		TCP_PACKET_IP_TTL_PRESERVE,
		TCP_PACKET_IP_TTL_DECREMENT,
		TCP_PACKET_IP_TTL_SET,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.UncleanShutdownMode", Namespace = "urn:iControl")]
	public enum LocalLBUncleanShutdownMode
	{
		UNCLEAN_SHUTDOWN_MODE_DISABLED,
		UNCLEAN_SHUTDOWN_MODE_ENABLED,
		UNCLEAN_SHUTDOWN_MODE_FAST,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualAddressStatusDependency", Namespace = "urn:iControl")]
	public enum LocalLBVirtualAddressStatusDependency
	{
		VIRTUAL_ADDRESS_STATUS_DEPENDENCY_NONE,
		VIRTUAL_ADDRESS_STATUS_DEPENDENCY_ANY,
		VIRTUAL_ADDRESS_STATUS_DEPENDENCY_ALL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.WACacheControlMode", Namespace = "urn:iControl")]
	public enum LocalLBWACacheControlMode
	{
		WA_CACHE_CONTROL_MODE_NONE,
		WA_CACHE_CONTROL_MODE_MAX_AGE,
		WA_CACHE_CONTROL_MODE_ALL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MatchPatternString", Namespace = "urn:iControl")]
	public partial class LocalLBMatchPatternString
	{
		private string patternField;
		public string pattern
		{
			get { return this.patternField; }
			set { this.patternField = value; }
		}
		private bool is_globField;
		public bool is_glob
		{
			get { return this.is_globField; }
			set { this.is_globField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MonitorIP", Namespace = "urn:iControl")]
	public partial class LocalLBMonitorIP
	{
		private LocalLBAddressType address_typeField;
		public LocalLBAddressType address_type
		{
			get { return this.address_typeField; }
			set { this.address_typeField = value; }
		}
		private string ipaddressField;
		public string ipaddress
		{
			get { return this.ipaddressField; }
			set { this.ipaddressField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MonitorIPPort", Namespace = "urn:iControl")]
	public partial class LocalLBMonitorIPPort
	{
		private LocalLBAddressType address_typeField;
		public LocalLBAddressType address_type
		{
			get { return this.address_typeField; }
			set { this.address_typeField = value; }
		}
		private CommonIPPortDefinition ipportField;
		public CommonIPPortDefinition ipport
		{
			get { return this.ipportField; }
			set { this.ipportField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MonitorInstance", Namespace = "urn:iControl")]
	public partial class LocalLBMonitorInstance
	{
		private string template_nameField;
		public string template_name
		{
			get { return this.template_nameField; }
			set { this.template_nameField = value; }
		}
		private LocalLBMonitorIPPort instance_definitionField;
		public LocalLBMonitorIPPort instance_definition
		{
			get { return this.instance_definitionField; }
			set { this.instance_definitionField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MonitorInstanceState", Namespace = "urn:iControl")]
	public partial class LocalLBMonitorInstanceState
	{
		private LocalLBMonitorInstance instanceField;
		public LocalLBMonitorInstance instance
		{
			get { return this.instanceField; }
			set { this.instanceField = value; }
		}
		private LocalLBMonitorInstanceStateType instance_stateField;
		public LocalLBMonitorInstanceStateType instance_state
		{
			get { return this.instance_stateField; }
			set { this.instance_stateField = value; }
		}
		private bool enabled_stateField;
		public bool enabled_state
		{
			get { return this.enabled_stateField; }
			set { this.enabled_stateField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MonitorRule", Namespace = "urn:iControl")]
	public partial class LocalLBMonitorRule
	{
		private LocalLBMonitorRuleType typeField;
		public LocalLBMonitorRuleType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private long quorumField;
		public long quorum
		{
			get { return this.quorumField; }
			set { this.quorumField = value; }
		}
		private string [] monitor_templatesField;
		public string [] monitor_templates
		{
			get { return this.monitor_templatesField; }
			set { this.monitor_templatesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ObjectStatus", Namespace = "urn:iControl")]
	public partial class LocalLBObjectStatus
	{
		private LocalLBAvailabilityStatus availability_statusField;
		public LocalLBAvailabilityStatus availability_status
		{
			get { return this.availability_statusField; }
			set { this.availability_statusField = value; }
		}
		private LocalLBEnabledStatus enabled_statusField;
		public LocalLBEnabledStatus enabled_status
		{
			get { return this.enabled_statusField; }
			set { this.enabled_statusField = value; }
		}
		private string status_descriptionField;
		public string status_description
		{
			get { return this.status_descriptionField; }
			set { this.status_descriptionField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.PersistenceRecord", Namespace = "urn:iControl")]
	public partial class LocalLBPersistenceRecord
	{
		private string pool_nameField;
		public string pool_name
		{
			get { return this.pool_nameField; }
			set { this.pool_nameField = value; }
		}
		private CommonIPPortDefinition node_serverField;
		public CommonIPPortDefinition node_server
		{
			get { return this.node_serverField; }
			set { this.node_serverField = value; }
		}
		private LocalLBPersistenceMode modeField;
		public LocalLBPersistenceMode mode
		{
			get { return this.modeField; }
			set { this.modeField = value; }
		}
		private string persistence_valueField;
		public string persistence_value
		{
			get { return this.persistence_valueField; }
			set { this.persistence_valueField = value; }
		}
		private CommonVirtualServerDefinition virtual_serverField;
		public CommonVirtualServerDefinition virtual_server
		{
			get { return this.virtual_serverField; }
			set { this.virtual_serverField = value; }
		}
		private long create_timeField;
		public long create_time
		{
			get { return this.create_timeField; }
			set { this.create_timeField = value; }
		}
		private long ageField;
		public long age
		{
			get { return this.ageField; }
			set { this.ageField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileActivationMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileActivationMode
	{
		private LocalLBActivationMode valueField;
		public LocalLBActivationMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAdaptServiceDownAction", Namespace = "urn:iControl")]
	public partial class LocalLBProfileAdaptServiceDownAction
	{
		private LocalLBAdaptServiceDownAction valueField;
		public LocalLBAdaptServiceDownAction value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAuthenticationMethod", Namespace = "urn:iControl")]
	public partial class LocalLBProfileAuthenticationMethod
	{
		private LocalLBAuthenticationMethod valueField;
		public LocalLBAuthenticationMethod value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileClientSSLCertificateMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileClientSSLCertificateMode
	{
		private LocalLBClientSSLCertificateMode valueField;
		public LocalLBClientSSLCertificateMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileCompressionMethod", Namespace = "urn:iControl")]
	public partial class LocalLBProfileCompressionMethod
	{
		private LocalLBCompressionMethod valueField;
		public LocalLBCompressionMethod value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileCookiePersistenceMethod", Namespace = "urn:iControl")]
	public partial class LocalLBProfileCookiePersistenceMethod
	{
		private LocalLBCookiePersistenceMethod valueField;
		public LocalLBCookiePersistenceMethod value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileCredentialSource", Namespace = "urn:iControl")]
	public partial class LocalLBProfileCredentialSource
	{
		private LocalLBCredentialSource valueField;
		public LocalLBCredentialSource value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileEnabledState", Namespace = "urn:iControl")]
	public partial class LocalLBProfileEnabledState
	{
		private CommonEnabledState valueField;
		public CommonEnabledState value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileForwardProxyBypassDefaultAction", Namespace = "urn:iControl")]
	public partial class LocalLBProfileForwardProxyBypassDefaultAction
	{
		private LocalLBForwardProxyBypassDefaultAction valueField;
		public LocalLBForwardProxyBypassDefaultAction value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHardwareAccelerationMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHardwareAccelerationMode
	{
		private LocalLBHardwareAccelerationMode valueField;
		public LocalLBHardwareAccelerationMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttpChunkMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpChunkMode
	{
		private LocalLBHttpChunkMode valueField;
		public LocalLBHttpChunkMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttpCompressionMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpCompressionMode
	{
		private LocalLBHttpCompressionMode valueField;
		public LocalLBHttpCompressionMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttpRedirectRewriteMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpRedirectRewriteMode
	{
		private LocalLBHttpRedirectRewriteMode valueField;
		public LocalLBHttpRedirectRewriteMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileIPAddress", Namespace = "urn:iControl")]
	public partial class LocalLBProfileIPAddress
	{
		private string valueField;
		public string value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileLogAction", Namespace = "urn:iControl")]
	public partial class LocalLBProfileLogAction
	{
		private LocalLBLogAction valueField;
		public LocalLBLogAction value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileLogElementSequence", Namespace = "urn:iControl")]
	public partial class LocalLBProfileLogElementSequence
	{
		private LocalLBLogElement [] valueField;
		public LocalLBLogElement [] value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileMatchPatternStringArray", Namespace = "urn:iControl")]
	public partial class LocalLBProfileMatchPatternStringArray
	{
		private LocalLBMatchPatternString [] valuesField;
		public LocalLBMatchPatternString [] values
		{
			get { return this.valuesField; }
			set { this.valuesField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfilePersistenceMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfilePersistenceMode
	{
		private LocalLBPersistenceMode valueField;
		public LocalLBPersistenceMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfilePortNumber", Namespace = "urn:iControl")]
	public partial class LocalLBProfilePortNumber
	{
		private long valueField;
		public long value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileProfileMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileProfileMode
	{
		private LocalLBProfileMode valueField;
		public LocalLBProfileMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileRamCacheCacheControlMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileRamCacheCacheControlMode
	{
		private LocalLBRamCacheCacheControlMode valueField;
		public LocalLBRamCacheCacheControlMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileResponseControlMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileResponseControlMode
	{
		private LocalLBResponseControlMode valueField;
		public LocalLBResponseControlMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileRtspProxyType", Namespace = "urn:iControl")]
	public partial class LocalLBProfileRtspProxyType
	{
		private LocalLBRtspProxyType valueField;
		public LocalLBRtspProxyType value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSSLCertificateExtension", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSSLCertificateExtension
	{
		private LocalLBSSLCertificateExtension [] valueField;
		public LocalLBSSLCertificateExtension [] value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSSLOption", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSSLOption
	{
		private LocalLBSSLOption [] valuesField;
		public LocalLBSSLOption [] values
		{
			get { return this.valuesField; }
			set { this.valuesField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSSLSignHash", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSSLSignHash
	{
		private LocalLBSSLSignHash valueField;
		public LocalLBSSLSignHash value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSecureRenegotiationMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSecureRenegotiationMode
	{
		private LocalLBSecureRenegotiationMode valueField;
		public LocalLBSecureRenegotiationMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileServerSSLCertificateMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileServerSSLCertificateMode
	{
		private LocalLBServerSSLCertificateMode valueField;
		public LocalLBServerSSLCertificateMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileStatisticsByVirtual", Namespace = "urn:iControl")]
	public partial class LocalLBProfileStatisticsByVirtual
	{
		private CommonStatistic [] [] [] statisticsField;
		public CommonStatistic [] [] [] statistics
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileString", Namespace = "urn:iControl")]
	public partial class LocalLBProfileString
	{
		private string valueField;
		public string value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileStringArray", Namespace = "urn:iControl")]
	public partial class LocalLBProfileStringArray
	{
		private string [] valuesField;
		public string [] values
		{
			get { return this.valuesField; }
			set { this.valuesField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileTCPCongestionControlMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileTCPCongestionControlMode
	{
		private LocalLBTCPCongestionControlMode valueField;
		public LocalLBTCPCongestionControlMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileTCPOptionMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileTCPOptionMode
	{
		private LocalLBTCPOptionMode valueField;
		public LocalLBTCPOptionMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileTCPPacketDFMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileTCPPacketDFMode
	{
		private LocalLBTCPPacketDFMode valueField;
		public LocalLBTCPPacketDFMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileTCPPacketTTLMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileTCPPacketTTLMode
	{
		private LocalLBTCPPacketTTLMode valueField;
		public LocalLBTCPPacketTTLMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileULong", Namespace = "urn:iControl")]
	public partial class LocalLBProfileULong
	{
		private long valueField;
		public long value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileUShort", Namespace = "urn:iControl")]
	public partial class LocalLBProfileUShort
	{
		private short valueField;
		public short value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileUncleanShutdownMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileUncleanShutdownMode
	{
		private LocalLBUncleanShutdownMode valueField;
		public LocalLBUncleanShutdownMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileWACacheControlMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileWACacheControlMode
	{
		private LocalLBWACacheControlMode valueField;
		public LocalLBWACacheControlMode value
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

}
