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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.AddressType", Namespace = "urn:iControl")]
	public enum GlobalLBAddressType
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.AutoConfigurationState", Namespace = "urn:iControl")]
	public enum GlobalLBAutoConfigurationState
	{
		AUTOCONFIG_DISABLED,
		AUTOCONFIG_ENABLED,
		AUTOCONFIG_ENABLED_AUTODELETE_DISABLED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.AvailabilityDependency", Namespace = "urn:iControl")]
	public enum GlobalLBAvailabilityDependency
	{
		AVAILABILITY_DEPENDENCY_NONE,
		AVAILABILITY_DEPENDENCY_SERVER,
		AVAILABILITY_DEPENDENCY_LINK,
		AVAILABILITY_DEPENDENCY_DATA_CENTER,
		AVAILABILITY_DEPENDENCY_WIDE_IP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DNSReturnCode", Namespace = "urn:iControl")]
	public enum GlobalLBDNSReturnCode
	{
		RETURN_CODE_UNKNOWN,
		RETURN_CODE_NO_ERROR,
		RETURN_CODE_FORMAT_ERROR,
		RETURN_CODE_SERVER_FAILURE,
		RETURN_CODE_NON_EXISTENT_DOMAIN,
		RETURN_CODE_NOT_IMPLEMENTED,
		RETURN_CODE_REFUSED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DomainNameCheckMode", Namespace = "urn:iControl")]
	public enum GlobalLBDomainNameCheckMode
	{
		DOMAIN_NAME_CHECK_MODE_UNKNOWN,
		DOMAIN_NAME_CHECK_MODE_NONE,
		DOMAIN_NAME_CHECK_MODE_STRICT,
		DOMAIN_NAME_CHECK_MODE_ALLOW_UNDERSCORES,
		DOMAIN_NAME_CHECK_MODE_IDN_COMPATIBLE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.GTMQueryType", Namespace = "urn:iControl")]
	public enum GlobalLBGTMQueryType
	{
		GTM_QUERY_TYPE_UNKNOWN,
		GTM_QUERY_TYPE_A,
		GTM_QUERY_TYPE_CNAME,
		GTM_QUERY_TYPE_MX,
		GTM_QUERY_TYPE_AAAA,
		GTM_QUERY_TYPE_SRV,
		GTM_QUERY_TYPE_NAPTR,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.HardwareSecurityModuleType", Namespace = "urn:iControl")]
	public enum GlobalLBHardwareSecurityModuleType
	{
		HARDWARE_SECURITY_MODULE_TYPE_UNKNOWN,
		HARDWARE_SECURITY_MODULE_TYPE_NONE,
		HARDWARE_SECURITY_MODULE_TYPE_INTERNAL,
		HARDWARE_SECURITY_MODULE_TYPE_EXTERNAL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.LBDecisionLogVerbosity", Namespace = "urn:iControl")]
	public enum GlobalLBLBDecisionLogVerbosity
	{
		LB_DECISION_LOG_UNKNOWN,
		LB_DECISION_LOG_NONE,
		LB_DECISION_POOL_SELECTION,
		LB_DECISION_POOL_TRAVERSAL,
		LB_DECISION_PM_SELECTION,
		LB_DECISION_PM_TRAVERSAL,
		LB_DECISION_LOG_ALL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.LBMethod", Namespace = "urn:iControl")]
	public enum GlobalLBLBMethod
	{
		LB_METHOD_RETURN_TO_DNS,
		LB_METHOD_NULL,
		LB_METHOD_ROUND_ROBIN,
		LB_METHOD_RATIO,
		LB_METHOD_TOPOLOGY,
		LB_METHOD_STATIC_PERSIST,
		LB_METHOD_GLOBAL_AVAILABILITY,
		LB_METHOD_VS_CAPACITY,
		LB_METHOD_LEAST_CONN,
		LB_METHOD_LOWEST_RTT,
		LB_METHOD_LOWEST_HOPS,
		LB_METHOD_PACKET_RATE,
		LB_METHOD_CPU,
		LB_METHOD_HIT_RATIO,
		LB_METHOD_QOS,
		LB_METHOD_BPS,
		LB_METHOD_DROP_PACKET,
		LB_METHOD_EXPLICIT_IP,
		LB_METHOD_CONNECTION_RATE,
		LB_METHOD_VS_SCORE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.LDNSProbeProtocol", Namespace = "urn:iControl")]
	public enum GlobalLBLDNSProbeProtocol
	{
		LDNS_PROBE_PROTOCOL_ICMP,
		LDNS_PROBE_PROTOCOL_TCP,
		LDNS_PROBE_PROTOCOL_UDP,
		LDNS_PROBE_PROTOCOL_DNS_DOT,
		LDNS_PROBE_PROTOCOL_DNS_REV,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.LinkWeightType", Namespace = "urn:iControl")]
	public enum GlobalLBLinkWeightType
	{
		LINK_WEIGHT_TYPE_RATIO,
		LINK_WEIGHT_TYPE_COST,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.MetricLimitType", Namespace = "urn:iControl")]
	public enum GlobalLBMetricLimitType
	{
		METRIC_LIMIT_CPU_USAGE,
		METRIC_LIMIT_MEMORY_AVAILABLE,
		METRIC_LIMIT_BITS_PER_SECOND,
		METRIC_LIMIT_PACKETS_PER_SECOND,
		METRIC_LIMIT_CONNECTIONS,
		METRIC_LIMIT_CONNECTIONS_PER_SECOND,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.MonitorAssociationRemovalRule", Namespace = "urn:iControl")]
	public enum GlobalLBMonitorAssociationRemovalRule
	{
		REMOVE_EXPLICIT_MONITOR_ASSOCIATION,
		REMOVE_ALL_MONITOR_ASSOCIATION,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.MonitorInstanceStateType", Namespace = "urn:iControl")]
	public enum GlobalLBMonitorInstanceStateType
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.MonitorRuleType", Namespace = "urn:iControl")]
	public enum GlobalLBMonitorRuleType
	{
		MONITOR_RULE_TYPE_UNDEFINED,
		MONITOR_RULE_TYPE_NONE,
		MONITOR_RULE_TYPE_SINGLE,
		MONITOR_RULE_TYPE_AND_LIST,
		MONITOR_RULE_TYPE_M_OF_N,
		MONITOR_RULE_TYPE_M_FROM_N,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.ProberSelectionType", Namespace = "urn:iControl")]
	public enum GlobalLBProberSelectionType
	{
		PROBER_SELECTION_UNKNOWN,
		PROBER_SELECTION_INSIDE_DATACENTER,
		PROBER_SELECTION_OUTSIDE_DATACENTER,
		PROBER_SELECTION_POOL,
		PROBER_SELECTION_ANY_AVAILABLE,
		PROBER_SELECTION_INHERIT,
		PROBER_SELECTION_NONE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.RegionDBType", Namespace = "urn:iControl")]
	public enum GlobalLBRegionDBType
	{
		REGION_DB_TYPE_USER_DEFINED,
		REGION_DB_TYPE_ACL,
		REGION_DB_TYPE_ISP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.RegionType", Namespace = "urn:iControl")]
	public enum GlobalLBRegionType
	{
		REGION_TYPE_CIDR,
		REGION_TYPE_REGION,
		REGION_TYPE_CONTINENT,
		REGION_TYPE_COUNTRY,
		REGION_TYPE_STATE,
		REGION_TYPE_POOL,
		REGION_TYPE_DATA_CENTER,
		REGION_TYPE_ISP_REGION,
		REGION_TYPE_GEOIP_ISP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.ServerType", Namespace = "urn:iControl")]
	public enum GlobalLBServerType
	{
		SERVER_TYPE_BIGIP_STANDALONE,
		SERVER_TYPE_BIGIP_REDUNDANT,
		SERVER_TYPE_GENERIC_LOAD_BALANCER,
		SERVER_TYPE_ALTEON_ACE_DIRECTOR,
		SERVER_TYPE_CISCO_CSS,
		SERVER_TYPE_CISCO_LOCAL_DIRECTOR_V2,
		SERVER_TYPE_CISCO_LOCAL_DIRECTOR_V3,
		SERVER_TYPE_CISCO_SERVER_LOAD_BALANCER,
		SERVER_TYPE_EXTREME,
		SERVER_TYPE_FOUNDRY_SERVER_IRON,
		SERVER_TYPE_GENERIC_HOST,
		SERVER_TYPE_CACHEFLOW,
		SERVER_TYPE_NETAPP,
		SERVER_TYPE_WINDOWS_2000,
		SERVER_TYPE_NT4,
		SERVER_TYPE_SOLARIS,
		SERVER_TYPE_RADWARE,
		SERVER_TYPE_BIGIP,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.MetricLimit", Namespace = "urn:iControl")]
	public partial class GlobalLBMetricLimit
	{
		private GlobalLBMetricLimitType typeField;
		public GlobalLBMetricLimitType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private long valueField;
		public long value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.MonitorIPPort", Namespace = "urn:iControl")]
	public partial class GlobalLBMonitorIPPort
	{
		private GlobalLBAddressType address_typeField;
		public GlobalLBAddressType address_type
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.MonitorInstance", Namespace = "urn:iControl")]
	public partial class GlobalLBMonitorInstance
	{
		private string template_nameField;
		public string template_name
		{
			get { return this.template_nameField; }
			set { this.template_nameField = value; }
		}
		private GlobalLBMonitorIPPort instance_definitionField;
		public GlobalLBMonitorIPPort instance_definition
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.MonitorInstanceState", Namespace = "urn:iControl")]
	public partial class GlobalLBMonitorInstanceState
	{
		private GlobalLBMonitorInstance instanceField;
		public GlobalLBMonitorInstance instance
		{
			get { return this.instanceField; }
			set { this.instanceField = value; }
		}
		private GlobalLBMonitorInstanceStateType instance_stateField;
		public GlobalLBMonitorInstanceStateType instance_state
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.MonitorRule", Namespace = "urn:iControl")]
	public partial class GlobalLBMonitorRule
	{
		private GlobalLBMonitorRuleType typeField;
		public GlobalLBMonitorRuleType type
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.MonitorRuleV2", Namespace = "urn:iControl")]
	public partial class GlobalLBMonitorRuleV2
	{
		private GlobalLBMonitorRuleType typeField;
		public GlobalLBMonitorRuleType type
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
		private long prober_countField;
		public long prober_count
		{
			get { return this.prober_countField; }
			set { this.prober_countField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolID", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolID
	{
		private string pool_nameField;
		public string pool_name
		{
			get { return this.pool_nameField; }
			set { this.pool_nameField = value; }
		}
		private GlobalLBGTMQueryType pool_typeField;
		public GlobalLBGTMQueryType pool_type
		{
			get { return this.pool_typeField; }
			set { this.pool_typeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.ProberSelection", Namespace = "urn:iControl")]
	public partial class GlobalLBProberSelection
	{
		private GlobalLBProberSelectionType prober_preferenceField;
		public GlobalLBProberSelectionType prober_preference
		{
			get { return this.prober_preferenceField; }
			set { this.prober_preferenceField = value; }
		}
		private GlobalLBProberSelectionType prober_fallbackField;
		public GlobalLBProberSelectionType prober_fallback
		{
			get { return this.prober_fallbackField; }
			set { this.prober_fallbackField = value; }
		}
		private string prober_poolField;
		public string prober_pool
		{
			get { return this.prober_poolField; }
			set { this.prober_poolField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.VirtualServerDefinition", Namespace = "urn:iControl")]
	public partial class GlobalLBVirtualServerDefinition
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string addressField;
		public string address
		{
			get { return this.addressField; }
			set { this.addressField = value; }
		}
		private long portField;
		public long port
		{
			get { return this.portField; }
			set { this.portField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.VirtualServerID", Namespace = "urn:iControl")]
	public partial class GlobalLBVirtualServerID
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string serverField;
		public string server
		{
			get { return this.serverField; }
			set { this.serverField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.WideIPID", Namespace = "urn:iControl")]
	public partial class GlobalLBWideIPID
	{
		private string wideip_nameField;
		public string wideip_name
		{
			get { return this.wideip_nameField; }
			set { this.wideip_nameField = value; }
		}
		private GlobalLBGTMQueryType wideip_typeField;
		public GlobalLBGTMQueryType wideip_type
		{
			get { return this.wideip_typeField; }
			set { this.wideip_typeField = value; }
		}
	};

}
