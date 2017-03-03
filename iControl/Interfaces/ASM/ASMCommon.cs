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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.ApplyLearningType", Namespace = "urn:iControl")]
	public enum ASMApplyLearningType
	{
		APPLY_LEARNING_ALL_POLICIES,
		APPLY_LEARNING_ACTIVE_POLICY,
		APPLY_LEARNING_SPECIFIC_POLICY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.DosDetectionMode", Namespace = "urn:iControl")]
	public enum ASMDosDetectionMode
	{
		DOS_DETECTION_TPS_BASED,
		DOS_DETECTION_LATENCY_BASED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.DosOperationMode", Namespace = "urn:iControl")]
	public enum ASMDosOperationMode
	{
		DOS_OPERATION_OFF,
		DOS_OPERATION_TRANSPARENT,
		DOS_OPERATION_BLOCKING,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.DynamicSessionsInUrlType", Namespace = "urn:iControl")]
	public enum ASMDynamicSessionsInUrlType
	{
		DYNAMIC_SESSIONS_DISABLED,
		DYNAMIC_SESSIONS_DEFAULT_PATTERN,
		DYNAMIC_SESSIONS_CUSTOM_PATTERN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.FlagState", Namespace = "urn:iControl")]
	public enum ASMFlagState
	{
		FLAG_ON,
		FLAG_OFF,
		FLAG_UNCHANGED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingLogicOperation", Namespace = "urn:iControl")]
	public enum ASMLoggingLogicOperation
	{
		LOGGING_LOGIC_OPERATION_OR,
		LOGGING_LOGIC_OPERATION_AND,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingRemoteFacility", Namespace = "urn:iControl")]
	public enum ASMLoggingRemoteFacility
	{
		LOGGING_REMOTE_FACILITY_LOCAL0,
		LOGGING_REMOTE_FACILITY_LOCAL1,
		LOGGING_REMOTE_FACILITY_LOCAL2,
		LOGGING_REMOTE_FACILITY_LOCAL3,
		LOGGING_REMOTE_FACILITY_LOCAL4,
		LOGGING_REMOTE_FACILITY_LOCAL5,
		LOGGING_REMOTE_FACILITY_LOCAL6,
		LOGGING_REMOTE_FACILITY_LOCAL7,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingRemoteProtocol", Namespace = "urn:iControl")]
	public enum ASMLoggingRemoteProtocol
	{
		LOGGING_REMOTE_PROTOCOL_UDP,
		LOGGING_REMOTE_PROTOCOL_TCP,
		LOGGING_REMOTE_PROTOCOL_TCP_RFC3195,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingRemoteStorageType", Namespace = "urn:iControl")]
	public enum ASMLoggingRemoteStorageType
	{
		LOGGING_REMOTE_STORAGE_NONE,
		LOGGING_REMOTE_STORAGE_REMOTE,
		LOGGING_REMOTE_STORAGE_REPORTING_SERVER,
		LOGGING_REMOTE_STORAGE_ARCSIGHT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingRequestSearchTarget", Namespace = "urn:iControl")]
	public enum ASMLoggingRequestSearchTarget
	{
		LOGGING_REQUEST_SEARCH_TARGET_REQUEST,
		LOGGING_REQUEST_SEARCH_TARGET_ALL,
		LOGGING_REQUEST_SEARCH_TARGET_URI,
		LOGGING_REQUEST_SEARCH_TARGET_QUERY_STRING,
		LOGGING_REQUEST_SEARCH_TARGET_POST_DATA,
		LOGGING_REQUEST_SEARCH_TARGET_HEADERS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingRequestType", Namespace = "urn:iControl")]
	public enum ASMLoggingRequestType
	{
		LOGGING_ILLEGAL_REQUESTS_ONLY,
		LOGGING_ALL_REQUESTS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingStorageFormatType", Namespace = "urn:iControl")]
	public enum ASMLoggingStorageFormatType
	{
		LOGGING_STORAGE_FORMAT_PREDEFINED,
		LOGGING_STORAGE_FORMAT_USER_DEFINED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.PolicyTemplate", Namespace = "urn:iControl")]
	public enum ASMPolicyTemplate
	{
		POLICY_TEMPLATE_EMPTY,
		POLICY_TEMPLATE_SHAREPOINT_2007_HTTP,
		POLICY_TEMPLATE_SHAREPOINT_2007_HTTPS,
		POLICY_TEMPLATE_OWA_EXCHANGE_2003_HTTP,
		POLICY_TEMPLATE_OWA_EXCHANGE_2003_HTTPS,
		POLICY_TEMPLATE_ORACLE_APPLICATIONS_11I_HTTP,
		POLICY_TEMPLATE_ORACLE_APPLICATIONS_11I_HTTPS,
		POLICY_TEMPLATE_LOTUSDOMINO_6_5_HTTP,
		POLICY_TEMPLATE_LOTUSDOMINO_6_5_HTTPS,
		POLICY_TEMPLATE_OWA_EXCHANGE_2007_HTTP,
		POLICY_TEMPLATE_OWA_EXCHANGE_2007_HTTPS,
		POLICY_TEMPLATE_SAP_NETWEAVER_7_HTTP,
		POLICY_TEMPLATE_SAP_NETWEAVER_7_HTTPS,
		POLICY_TEMPLATE_RAPID_DEPLOYMENT_HTTP,
		POLICY_TEMPLATE_RAPID_DEPLOYMENT_HTTPS,
		POLICY_TEMPLATE_PEOPLESOFT_PORTAL_9_HTTP,
		POLICY_TEMPLATE_PEOPLESOFT_PORTAL_9_HTTPS,
		POLICY_TEMPLATE_ORACLE_10G_PORTAL_HTTP,
		POLICY_TEMPLATE_ORACLE_10G_PORTAL_HTTPS,
		POLICY_TEMPLATE_SHAREPOINT_2003_HTTP,
		POLICY_TEMPLATE_SHAREPOINT_2003_HTTPS,
		POLICY_TEMPLATE_ACTIVESYNC_V1_0_V2_0_HTTP,
		POLICY_TEMPLATE_ACTIVESYNC_V1_0_V2_0_HTTPS,
		POLICY_TEMPLATE_OWA_EXCHANGE_2007_WITH_ACTIVESYNC_HTTP,
		POLICY_TEMPLATE_OWA_EXCHANGE_2007_WITH_ACTIVESYNC_HTTPS,
		POLICY_TEMPLATE_OWA_EXCHANGE_2003_WITH_ACTIVESYNC_HTTP,
		POLICY_TEMPLATE_OWA_EXCHANGE_2003_WITH_ACTIVESYNC_HTTPS,
		POLICY_TEMPLATE_VULNERABILITY_ASSESSMENT,
		POLICY_TEMPLATE_OWA_EXCHANGE_2010_HTTP,
		POLICY_TEMPLATE_OWA_EXCHANGE_2010_HTTPS,
		POLICY_TEMPLATE_SHAREPOINT_2010_HTTP,
		POLICY_TEMPLATE_SHAREPOINT_2010_HTTPS,
		POLICY_TEMPLATE_RAPID_DEPLOYMENT,
		POLICY_TEMPLATE_RAPID_DEPLOYMENT_PB,
		POLICY_TEMPLATE_FUNDAMENTAL,
		POLICY_TEMPLATE_COMPREHENSIVE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.ProtocolType", Namespace = "urn:iControl")]
	public enum ASMProtocolType
	{
		HTTP,
		HTTPS,
		ALL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.SeverityName", Namespace = "urn:iControl")]
	public enum ASMSeverityName
	{
		SEVERITY_LOG_EMERG,
		SEVERITY_LOG_ALERT,
		SEVERITY_LOG_CRIT,
		SEVERITY_LOG_ERR,
		SEVERITY_LOG_WARNING,
		SEVERITY_LOG_NOTICE,
		SEVERITY_LOG_INFO,
		SEVERITY_LOG_DEBUG,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.ViolationName", Namespace = "urn:iControl")]
	public enum ASMViolationName
	{
		VIOLATION_EVASION_DETECTED,
		VIOLATION_VIRUS_DETECTED,
		VIOLATION_REQUEST_TOO_LONG,
		VIOLATION_ILLEGAL_INGRESS_OBJECT,
		VIOLATION_PARSER_EXPIRED_INGRESS_OBJECT,
		VIOLATION_RESPONSE_SCRUBBING,
		VIOLATION_ILLEGAL_SOAP_ATTACHMENT,
		VIOLATION_MISSING_MANDATORY_HEADER,
		VIOLATION_ILLEGAL_GEOLOCATION,
		VIOLATION_HTTP_SANITY_CHECK_FAILED,
		VIOLATION_CHAR_CONV,
		VIOLATION_CSRF,
		VIOLATION_MALFORMED_XML,
		VIOLATION_XML_WSDL,
		VIOLATION_XML_FORMAT_SETTING,
		VIOLATION_PARSER_FAILED_SOAP_SECURITY,
		VIOLATION_SOAP_METHOD_NOT_ALLOWED,
		VIOLATION_BRUTE_FORCE_ATTACK_DETECTED,
		VIOLATION_WEB_SCRAPING_DETECTED,
		VIOLATION_CSRF_EXPIRED,
		VIOLATION_OBJ_LEN,
		VIOLATION_COOKIE_LEN,
		VIOLATION_REQ_LEN,
		VIOLATION_QS_LEN,
		VIOLATION_POST_DATA_LEN,
		VIOLATION_MULTI_PART_PARAM_VAL,
		VIOLATION_HEADER_LEN,
		VIOLATION_JSON_FORMAT_SETTING,
		VIOLATION_REPEATED_PARAMETER_NAME,
		VIOLATION_METACHAR_IN_OBJ,
		VIOLATION_METACHAR_IN_PARAM_NAME,
		VIOLATION_METACHAR_IN_DEF_PARAM,
		VIOLATION_OBJ_TYPE,
		VIOLATION_OBJ_DOESNT_EXIST,
		VIOLATION_FLOW_TO_OBJ,
		VIOLATION_ILLEGAL_METHOD,
		VIOLATION_SESSSION_ID_IN_URL,
		VIOLATION_QS_OR_POST_DATA,
		VIOLATION_PARAM,
		VIOLATION_EMPTY_PARAM_VALUE,
		VIOLATION_STATIC_PARAM_VALUE,
		VIOLATION_DYN_PARAM_VALUE,
		VIOLATION_PARAM_VALUE_LEN,
		VIOLATION_PARAM_DATA_TYPE,
		VIOLATION_PARAM_NUMERIC_VALUE,
		VIOLATION_NUM_OF_MANDATORY_PARAMS,
		VIOLATION_PARAM_VALUE_NOT_MATCHING_REGEX,
		VIOLATION_MOD_ASM_COOKIE,
		VIOLATION_MOD_DOMAIN_COOKIE,
		VIOLATION_NOT_RFC_COOKIE,
		VIOLATION_MALFORMED_JSON,
		VIOLATION_ENTRY_POINT,
		VIOLATION_SESSION_AWARENESS,
		VIOLATION_MSG_KEY,
		VIOLATION_EXPIRED_TIMESTAMP,
		VIOLATION_DISALLOWED_FILE_UPLOAD_CONTENT,
		VIOLATION_METACHAR_IN_HEADER,
		VIOLATION_ILLEGAL_REQUEST_CONTENT_TYPE,
		VIOLATION_HTTP_STATUS_IN_RESPONSE,
		VIOLATION_PARSER_ACCESS_FROM_MALICIOUS_IP_ADDRESS,
		VIOLATION_GWT_FORMAT_SETTING,
		VIOLATION_MALFORMED_GWT,
		VIOLATION_BASE64_PARAM_VALUE,
		VIOLATION_REDIRECT,
		VIOLATION_WEBSOCKET_BAD_REQUEST,
		VIOLATION_WEBSOCKET_FRAMING_PROTOCOL,
		VIOLATION_WEBSOCKET_FRAME_MASKING,
		VIOLATION_WEBSOCKET_FRAME_LENGTH,
		VIOLATION_WEBSOCKET_TEXT_NULL_VALUE,
		VIOLATION_CROSS_ORIGIN_REQUEST,
		VIOLATION_WEBSOCKET_TEXT_MESSAGE_NOT_ALLOWED,
		VIOLATION_WEBSOCKET_BINARY_MESSAGE_NOT_ALLOWED,
		VIOLATION_WEBSOCKET_EXTENSION,
		VIOLATION_WEBSOCKET_FRAMES_PER_MESSAGE_COUNT,
		VIOLATION_WEBSOCKET_BINARY_MESSAGE_LENGTH,
		VIOLATION_PLAINTEXT_FORMAT_SETTING,
		VIOLATION_BLACKLISTED_IP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.WebApplicationLanguage", Namespace = "urn:iControl")]
	public enum ASMWebApplicationLanguage
	{
		LANGUAGE_UNDEFINED,
		UNICODE_UTF_8,
		WESTERN_EUROPEAN_ISO_8859_1,
		WESTERN_EUROPEAN_WINDOWS_1252,
		WESTERN_EUROPEAN_ISO_8859_15,
		CENTRAL_EUROPEAN_ISO_8859_2,
		CENTRAL_EUROPEAN_WINDOWS_1250,
		SOUTH_EUROPEAN_ISO_8859_3,
		GREEK_ISO_8859_7,
		GREEK_WINDOWS_1253,
		NORDIC_ISO_8859_10,
		CYRILLIC_WINDOWS_1251,
		CYRILLIC_KOI8_R,
		CYRILLIC_ISO_8859_5,
		ROMANIAN_ISO_8859_16,
		BALTIC_ISO_8859_4,
		BALTIC_ISO_8859_13,
		BALTIC_WINDOWS_1257,
		HEBREW_WINDOWS_1255,
		HEBREW_ISO_8859_8,
		JAPANESE_SHIFT_JIS,
		JAPANESE_EUC_JP,
		KOREAN_EUC_KR,
		CHINESE_BIG5,
		CHINESE_GB2312,
		THAI_CP874,
		ARABIC_ISO_8859_6,
		CHINESE_GBK,
		CHINESE_GB18030,
		TURKISH_ISO_8859_9,
		ARABIC_WINDOWS_1256,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.ApplyLearning", Namespace = "urn:iControl")]
	public partial class ASMApplyLearning
	{
		private ASMApplyLearningType typeField;
		public ASMApplyLearningType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private string policy_nameField;
		public string policy_name
		{
			get { return this.policy_nameField; }
			set { this.policy_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.Dos", Namespace = "urn:iControl")]
	public partial class ASMDos
	{
		private ASMDosOperationMode operation_modeField;
		public ASMDosOperationMode operation_mode
		{
			get { return this.operation_modeField; }
			set { this.operation_modeField = value; }
		}
		private ASMDosDetectionMode detection_modeField;
		public ASMDosDetectionMode detection_mode
		{
			get { return this.detection_modeField; }
			set { this.detection_modeField = value; }
		}
		private long latency_increase_rateField;
		public long latency_increase_rate
		{
			get { return this.latency_increase_rateField; }
			set { this.latency_increase_rateField = value; }
		}
		private long maximum_latencyField;
		public long maximum_latency
		{
			get { return this.maximum_latencyField; }
			set { this.maximum_latencyField = value; }
		}
		private long minimum_latencyField;
		public long minimum_latency
		{
			get { return this.minimum_latencyField; }
			set { this.minimum_latencyField = value; }
		}
		private bool source_ip_based_client_side_integrity_defense_flagField;
		public bool source_ip_based_client_side_integrity_defense_flag
		{
			get { return this.source_ip_based_client_side_integrity_defense_flagField; }
			set { this.source_ip_based_client_side_integrity_defense_flagField = value; }
		}
		private bool source_ip_based_rate_limiting_flagField;
		public bool source_ip_based_rate_limiting_flag
		{
			get { return this.source_ip_based_rate_limiting_flagField; }
			set { this.source_ip_based_rate_limiting_flagField = value; }
		}
		private bool url_based_client_side_integrity_defense_flagField;
		public bool url_based_client_side_integrity_defense_flag
		{
			get { return this.url_based_client_side_integrity_defense_flagField; }
			set { this.url_based_client_side_integrity_defense_flagField = value; }
		}
		private bool url_based_rate_limiting_flagField;
		public bool url_based_rate_limiting_flag
		{
			get { return this.url_based_rate_limiting_flagField; }
			set { this.url_based_rate_limiting_flagField = value; }
		}
		private long ip_tps_increase_rateField;
		public long ip_tps_increase_rate
		{
			get { return this.ip_tps_increase_rateField; }
			set { this.ip_tps_increase_rateField = value; }
		}
		private long ip_maximum_tpsField;
		public long ip_maximum_tps
		{
			get { return this.ip_maximum_tpsField; }
			set { this.ip_maximum_tpsField = value; }
		}
		private long ip_minimum_tpsField;
		public long ip_minimum_tps
		{
			get { return this.ip_minimum_tpsField; }
			set { this.ip_minimum_tpsField = value; }
		}
		private long url_tps_increase_rateField;
		public long url_tps_increase_rate
		{
			get { return this.url_tps_increase_rateField; }
			set { this.url_tps_increase_rateField = value; }
		}
		private long url_maximum_tpsField;
		public long url_maximum_tps
		{
			get { return this.url_maximum_tpsField; }
			set { this.url_maximum_tpsField = value; }
		}
		private long url_minimum_tpsField;
		public long url_minimum_tps
		{
			get { return this.url_minimum_tpsField; }
			set { this.url_minimum_tpsField = value; }
		}
		private long maximum_prevention_durationField;
		public long maximum_prevention_duration
		{
			get { return this.maximum_prevention_durationField; }
			set { this.maximum_prevention_durationField = value; }
		}
		private CommonIPNetmask [] ip_white_listField;
		public CommonIPNetmask [] ip_white_list
		{
			get { return this.ip_white_listField; }
			set { this.ip_white_listField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.DynamicSessionsInUrl", Namespace = "urn:iControl")]
	public partial class ASMDynamicSessionsInUrl
	{
		private ASMDynamicSessionsInUrlType typeField;
		public ASMDynamicSessionsInUrlType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private string valueField;
		public string value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private string descriptionField;
		public string description
		{
			get { return this.descriptionField; }
			set { this.descriptionField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.FileTransferContext", Namespace = "urn:iControl")]
	public partial class ASMFileTransferContext
	{
		private byte [] file_dataField;
		[System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")]
		public byte [] file_data
		{
			get { return this.file_dataField; }
			set { this.file_dataField = value; }
		}
		private CommonFileChainType chain_typeField;
		public CommonFileChainType chain_type
		{
			get { return this.chain_typeField; }
			set { this.chain_typeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingProfileDefinition", Namespace = "urn:iControl")]
	public partial class ASMLoggingProfileDefinition
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string descriptionField;
		public string description
		{
			get { return this.descriptionField; }
			set { this.descriptionField = value; }
		}
		private bool local_storage_flagField;
		public bool local_storage_flag
		{
			get { return this.local_storage_flagField; }
			set { this.local_storage_flagField = value; }
		}
		private bool guarantee_logging_flagField;
		public bool guarantee_logging_flag
		{
			get { return this.guarantee_logging_flagField; }
			set { this.guarantee_logging_flagField = value; }
		}
		private ASMLoggingRemoteStorage remote_storageField;
		public ASMLoggingRemoteStorage remote_storage
		{
			get { return this.remote_storageField; }
			set { this.remote_storageField = value; }
		}
		private ASMLoggingStorageFilter storage_filterField;
		public ASMLoggingStorageFilter storage_filter
		{
			get { return this.storage_filterField; }
			set { this.storage_filterField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingRemoteStorage", Namespace = "urn:iControl")]
	public partial class ASMLoggingRemoteStorage
	{
		private ASMLoggingRemoteStorageBase baseField;
		public ASMLoggingRemoteStorageBase _base
		{
			get { return this.baseField; }
			set { this.baseField = value; }
		}
		private ASMLoggingRemoteProtocol protocolField;
		public ASMLoggingRemoteProtocol protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}
		private ASMLoggingRemoteFacility facilityField;
		public ASMLoggingRemoteFacility facility
		{
			get { return this.facilityField; }
			set { this.facilityField = value; }
		}
		private long maximum_request_sizeField;
		public long maximum_request_size
		{
			get { return this.maximum_request_sizeField; }
			set { this.maximum_request_sizeField = value; }
		}
		private long maximum_header_sizeField;
		public long maximum_header_size
		{
			get { return this.maximum_header_sizeField; }
			set { this.maximum_header_sizeField = value; }
		}
		private long maximum_query_sizeField;
		public long maximum_query_size
		{
			get { return this.maximum_query_sizeField; }
			set { this.maximum_query_sizeField = value; }
		}
		private long maximum_entry_lengthField;
		public long maximum_entry_length
		{
			get { return this.maximum_entry_lengthField; }
			set { this.maximum_entry_lengthField = value; }
		}
		private bool report_anomalies_flagField;
		public bool report_anomalies_flag
		{
			get { return this.report_anomalies_flagField; }
			set { this.report_anomalies_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingRemoteStorageBase", Namespace = "urn:iControl")]
	public partial class ASMLoggingRemoteStorageBase
	{
		private ASMLoggingRemoteStorageType typeField;
		public ASMLoggingRemoteStorageType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private CommonIPPortDefinition [] serversField;
		public CommonIPPortDefinition [] servers
		{
			get { return this.serversField; }
			set { this.serversField = value; }
		}
		private ASMLoggingStorageFormat formatField;
		public ASMLoggingStorageFormat format
		{
			get { return this.formatField; }
			set { this.formatField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingRequestSearch", Namespace = "urn:iControl")]
	public partial class ASMLoggingRequestSearch
	{
		private ASMLoggingRequestSearchTarget targetField;
		public ASMLoggingRequestSearchTarget target
		{
			get { return this.targetField; }
			set { this.targetField = value; }
		}
		private string patternField;
		public string pattern
		{
			get { return this.patternField; }
			set { this.patternField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingStorageFilter", Namespace = "urn:iControl")]
	public partial class ASMLoggingStorageFilter
	{
		private ASMLoggingLogicOperation logic_operationField;
		public ASMLoggingLogicOperation logic_operation
		{
			get { return this.logic_operationField; }
			set { this.logic_operationField = value; }
		}
		private ASMLoggingRequestType request_typeField;
		public ASMLoggingRequestType request_type
		{
			get { return this.request_typeField; }
			set { this.request_typeField = value; }
		}
		private ASMProtocolType protocolField;
		public ASMProtocolType protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}
		private long [] response_codesField;
		public long [] response_codes
		{
			get { return this.response_codesField; }
			set { this.response_codesField = value; }
		}
		private string [] http_methodsField;
		public string [] http_methods
		{
			get { return this.http_methodsField; }
			set { this.http_methodsField = value; }
		}
		private ASMLoggingRequestSearch request_searchField;
		public ASMLoggingRequestSearch request_search
		{
			get { return this.request_searchField; }
			set { this.request_searchField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.LoggingStorageFormat", Namespace = "urn:iControl")]
	public partial class ASMLoggingStorageFormat
	{
		private ASMLoggingStorageFormatType typeField;
		public ASMLoggingStorageFormatType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private string csv_delimiterField;
		public string csv_delimiter
		{
			get { return this.csv_delimiterField; }
			set { this.csv_delimiterField = value; }
		}
		private string [] csv_fieldsField;
		public string [] csv_fields
		{
			get { return this.csv_fieldsField; }
			set { this.csv_fieldsField = value; }
		}
		private string user_stringField;
		public string user_string
		{
			get { return this.user_stringField; }
			set { this.user_stringField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.ObjectTypeType", Namespace = "urn:iControl")]
	public partial class ASMObjectTypeType
	{
		private bool no_ext_flagField;
		public bool no_ext_flag
		{
			get { return this.no_ext_flagField; }
			set { this.no_ext_flagField = value; }
		}
		private string object_type_nameField;
		public string object_type_name
		{
			get { return this.object_type_nameField; }
			set { this.object_type_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.SignatureFileUpdateReturnValue", Namespace = "urn:iControl")]
	public partial class ASMSignatureFileUpdateReturnValue
	{
		private long completed_successfullyField;
		public long completed_successfully
		{
			get { return this.completed_successfullyField; }
			set { this.completed_successfullyField = value; }
		}
		private long sig_countField;
		public long sig_count
		{
			get { return this.sig_countField; }
			set { this.sig_countField = value; }
		}
		private long sigs_updated_countField;
		public long sigs_updated_count
		{
			get { return this.sigs_updated_countField; }
			set { this.sigs_updated_countField = value; }
		}
		private string error_msgField;
		public string error_msg
		{
			get { return this.error_msgField; }
			set { this.error_msgField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.Violation", Namespace = "urn:iControl")]
	public partial class ASMViolation
	{
		private ASMViolationName violation_nameField;
		public ASMViolationName violation_name
		{
			get { return this.violation_nameField; }
			set { this.violation_nameField = value; }
		}
		private ASMFlagState learn_flagField;
		public ASMFlagState learn_flag
		{
			get { return this.learn_flagField; }
			set { this.learn_flagField = value; }
		}
		private ASMFlagState alarm_flagField;
		public ASMFlagState alarm_flag
		{
			get { return this.alarm_flagField; }
			set { this.alarm_flagField = value; }
		}
		private ASMFlagState block_flagField;
		public ASMFlagState block_flag
		{
			get { return this.block_flagField; }
			set { this.block_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.ViolationSeverity", Namespace = "urn:iControl")]
	public partial class ASMViolationSeverity
	{
		private ASMViolationName violation_nameField;
		public ASMViolationName violation_name
		{
			get { return this.violation_nameField; }
			set { this.violation_nameField = value; }
		}
		private ASMSeverityName severity_nameField;
		public ASMSeverityName severity_name
		{
			get { return this.severity_nameField; }
			set { this.severity_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.WebApplicationGroupDefinition", Namespace = "urn:iControl")]
	public partial class ASMWebApplicationGroupDefinition
	{
		private string valueField;
		public string value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool ungrouped_flagField;
		public bool ungrouped_flag
		{
			get { return this.ungrouped_flagField; }
			set { this.ungrouped_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "ASM.WebObjectType", Namespace = "urn:iControl")]
	public partial class ASMWebObjectType
	{
		private string web_object_nameField;
		public string web_object_name
		{
			get { return this.web_object_nameField; }
			set { this.web_object_nameField = value; }
		}
		private ASMProtocolType protocolField;
		public ASMProtocolType protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}
	};

}
