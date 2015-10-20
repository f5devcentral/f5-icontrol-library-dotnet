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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CPUMetricType", Namespace = "urn:iControl")]
	public enum SystemCPUMetricType
	{
		CPU_INDEX,
		CPU_TEMPERATURE,
		CPU_FAN_SPEED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ChassisSlotState", Namespace = "urn:iControl")]
	public enum SystemChassisSlotState
	{
		CHASSIS_SLOT_STATE_UNKNOWN,
		CHASSIS_SLOT_STATE_FAILED,
		CHASSIS_SLOT_STATE_EMPTY,
		CHASSIS_SLOT_STATE_PRIMING,
		CHASSIS_SLOT_STATE_OK,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ConnectionType", Namespace = "urn:iControl")]
	public enum SystemConnectionType
	{
		CONNECTION_TYPE_UNKNOWN,
		CONNECTION_TYPE_CLUSTER,
		CONNECTION_TYPE_BLADE,
		CONNECTION_TYPE_ADMIN,
		CONNECTION_TYPE_SELF,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.FanMetricType", Namespace = "urn:iControl")]
	public enum SystemFanMetricType
	{
		FAN_INDEX,
		FAN_STATE,
		FAN_SPEED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.HardwareType", Namespace = "urn:iControl")]
	public enum SystemHardwareType
	{
		HARDWARE_SWITCH,
		HARDWARE_COMPRESSION,
		HARDWARE_ENCRYPTION,
		HARDWARE_NETWORK,
		HARDWARE_PIC,
		HARDWARE_CHASSIS,
		HARDWARE_MEZZANINE,
		HARDWARE_BASE_BOARD,
		HARDWARE_PSU,
		HARDWARE_COPROCESSOR,
		HARDWARE_PHDISK,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.PSMetricType", Namespace = "urn:iControl")]
	public enum SystemPSMetricType
	{
		PS_INDEX,
		PS_STATE,
		PS_INPUT_STATE,
		PS_OUTPUT_STATE,
		PS_FAN_STATE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SystemProfileType", Namespace = "urn:iControl")]
	public enum SystemSystemProfileType
	{
		PROFILE_TYPE_UNKNOWN,
		PROFILE_TYPE_TCP,
		PROFILE_TYPE_SERVER_SSL,
		PROFILE_TYPE_CLIENT_SSL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.TemperatureMetricType", Namespace = "urn:iControl")]
	public enum SystemTemperatureMetricType
	{
		TEMPERATURE_INDEX,
		TEMPERATURE_VALUE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.BladeTemperature", Namespace = "urn:iControl")]
	public partial class SystemBladeTemperature
	{
		private long slotField;
		public long slot
		{
			get { return this.slotField; }
			set { this.slotField = value; }
		}
		private long sensorField;
		public long sensor
		{
			get { return this.sensorField; }
			set { this.sensorField = value; }
		}
		private string locationField;
		public string location
		{
			get { return this.locationField; }
			set { this.locationField = value; }
		}
		private long temperatureField;
		public long temperature
		{
			get { return this.temperatureField; }
			set { this.temperatureField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CPUMetric", Namespace = "urn:iControl")]
	public partial class SystemCPUMetric
	{
		private SystemCPUMetricType metric_typeField;
		public SystemCPUMetricType metric_type
		{
			get { return this.metric_typeField; }
			set { this.metric_typeField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CPUUsage", Namespace = "urn:iControl")]
	public partial class SystemCPUUsage
	{
		private long cpu_idField;
		public long cpu_id
		{
			get { return this.cpu_idField; }
			set { this.cpu_idField = value; }
		}
		private CommonULong64 userField;
		public CommonULong64 user
		{
			get { return this.userField; }
			set { this.userField = value; }
		}
		private CommonULong64 nicedField;
		public CommonULong64 niced
		{
			get { return this.nicedField; }
			set { this.nicedField = value; }
		}
		private CommonULong64 systemField;
		public CommonULong64 system
		{
			get { return this.systemField; }
			set { this.systemField = value; }
		}
		private CommonULong64 idleField;
		public CommonULong64 idle
		{
			get { return this.idleField; }
			set { this.idleField = value; }
		}
		private CommonULong64 irqField;
		public CommonULong64 irq
		{
			get { return this.irqField; }
			set { this.irqField = value; }
		}
		private CommonULong64 softirqField;
		public CommonULong64 softirq
		{
			get { return this.softirqField; }
			set { this.softirqField = value; }
		}
		private CommonULong64 iowaitField;
		public CommonULong64 iowait
		{
			get { return this.iowaitField; }
			set { this.iowaitField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CPUUsageExtended", Namespace = "urn:iControl")]
	public partial class SystemCPUUsageExtended
	{
		private string host_idField;
		public string host_id
		{
			get { return this.host_idField; }
			set { this.host_idField = value; }
		}
		private CommonStatistic [] [] statisticsField;
		public CommonStatistic [] [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CPUUsageExtendedInformation", Namespace = "urn:iControl")]
	public partial class SystemCPUUsageExtendedInformation
	{
		private SystemCPUUsageExtended [] hostsField;
		public SystemCPUUsageExtended [] hosts
		{
			get { return this.hostsField; }
			set { this.hostsField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CPUUsageInformation", Namespace = "urn:iControl")]
	public partial class SystemCPUUsageInformation
	{
		private SystemCPUUsage [] usagesField;
		public SystemCPUUsage [] usages
		{
			get { return this.usagesField; }
			set { this.usagesField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ChassisSlot", Namespace = "urn:iControl")]
	public partial class SystemChassisSlot
	{
		private long slot_idField;
		public long slot_id
		{
			get { return this.slot_idField; }
			set { this.slot_idField = value; }
		}
		private string serial_numberField;
		public string serial_number
		{
			get { return this.serial_numberField; }
			set { this.serial_numberField = value; }
		}
		private bool is_downField;
		public bool is_down
		{
			get { return this.is_downField; }
			set { this.is_downField = value; }
		}
		private SystemChassisSlotState stateField;
		public SystemChassisSlotState state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ConnectionInformation", Namespace = "urn:iControl")]
	public partial class SystemConnectionInformation
	{
		private CommonIPPortDefinition localField;
		public CommonIPPortDefinition local
		{
			get { return this.localField; }
			set { this.localField = value; }
		}
		private CommonIPPortDefinition remoteField;
		public CommonIPPortDefinition remote
		{
			get { return this.remoteField; }
			set { this.remoteField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.DiskUsage", Namespace = "urn:iControl")]
	public partial class SystemDiskUsage
	{
		private string partition_nameField;
		public string partition_name
		{
			get { return this.partition_nameField; }
			set { this.partition_nameField = value; }
		}
		private CommonULong64 block_sizeField;
		public CommonULong64 block_size
		{
			get { return this.block_sizeField; }
			set { this.block_sizeField = value; }
		}
		private CommonULong64 total_blocksField;
		public CommonULong64 total_blocks
		{
			get { return this.total_blocksField; }
			set { this.total_blocksField = value; }
		}
		private CommonULong64 free_blocksField;
		public CommonULong64 free_blocks
		{
			get { return this.free_blocksField; }
			set { this.free_blocksField = value; }
		}
		private CommonULong64 total_nodesField;
		public CommonULong64 total_nodes
		{
			get { return this.total_nodesField; }
			set { this.total_nodesField = value; }
		}
		private CommonULong64 free_nodesField;
		public CommonULong64 free_nodes
		{
			get { return this.free_nodesField; }
			set { this.free_nodesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.DiskUsageInformation", Namespace = "urn:iControl")]
	public partial class SystemDiskUsageInformation
	{
		private SystemDiskUsage [] usagesField;
		public SystemDiskUsage [] usages
		{
			get { return this.usagesField; }
			set { this.usagesField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.FanMetric", Namespace = "urn:iControl")]
	public partial class SystemFanMetric
	{
		private SystemFanMetricType metric_typeField;
		public SystemFanMetricType metric_type
		{
			get { return this.metric_typeField; }
			set { this.metric_typeField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.GlobalCPUUsageExtendedInformation", Namespace = "urn:iControl")]
	public partial class SystemGlobalCPUUsageExtendedInformation
	{
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.HardwareInformation", Namespace = "urn:iControl")]
	public partial class SystemHardwareInformation
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private SystemHardwareType typeField;
		public SystemHardwareType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private long slotField;
		public long slot
		{
			get { return this.slotField; }
			set { this.slotField = value; }
		}
		private string modelField;
		public string model
		{
			get { return this.modelField; }
			set { this.modelField = value; }
		}
		private SystemVersionInformation [] versionsField;
		public SystemVersionInformation [] versions
		{
			get { return this.versionsField; }
			set { this.versionsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.LockStatus", Namespace = "urn:iControl")]
	public partial class SystemLockStatus
	{
		private string lock_nameField;
		public string lock_name
		{
			get { return this.lock_nameField; }
			set { this.lock_nameField = value; }
		}
		private long time_leftField;
		public long time_left
		{
			get { return this.time_leftField; }
			set { this.time_leftField = value; }
		}
		private string commentField;
		public string comment
		{
			get { return this.commentField; }
			set { this.commentField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.MemoryUsageInformation", Namespace = "urn:iControl")]
	public partial class SystemMemoryUsageInformation
	{
		private CommonULong64 total_memoryField;
		public CommonULong64 total_memory
		{
			get { return this.total_memoryField; }
			set { this.total_memoryField = value; }
		}
		private CommonULong64 used_memoryField;
		public CommonULong64 used_memory
		{
			get { return this.used_memoryField; }
			set { this.used_memoryField = value; }
		}
		private SystemSubsystemMemoryUsage [] usagesField;
		public SystemSubsystemMemoryUsage [] usages
		{
			get { return this.usagesField; }
			set { this.usagesField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.PSMetric", Namespace = "urn:iControl")]
	public partial class SystemPSMetric
	{
		private SystemPSMetricType metric_typeField;
		public SystemPSMetricType metric_type
		{
			get { return this.metric_typeField; }
			set { this.metric_typeField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.PlatformCPUs", Namespace = "urn:iControl")]
	public partial class SystemPlatformCPUs
	{
		private SystemCPUMetric [] [] cpusField;
		public SystemCPUMetric [] [] cpus
		{
			get { return this.cpusField; }
			set { this.cpusField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.PlatformFans", Namespace = "urn:iControl")]
	public partial class SystemPlatformFans
	{
		private SystemFanMetric [] [] fansField;
		public SystemFanMetric [] [] fans
		{
			get { return this.fansField; }
			set { this.fansField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.PlatformPowerSupplies", Namespace = "urn:iControl")]
	public partial class SystemPlatformPowerSupplies
	{
		private SystemPSMetric [] [] power_suppliesField;
		public SystemPSMetric [] [] power_supplies
		{
			get { return this.power_suppliesField; }
			set { this.power_suppliesField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.PlatformTemperatures", Namespace = "urn:iControl")]
	public partial class SystemPlatformTemperatures
	{
		private SystemTemperatureMetric [] [] temperaturesField;
		public SystemTemperatureMetric [] [] temperatures
		{
			get { return this.temperaturesField; }
			set { this.temperaturesField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.ProductInformation", Namespace = "urn:iControl")]
	public partial class SystemProductInformation
	{
		private string product_codeField;
		public string product_code
		{
			get { return this.product_codeField; }
			set { this.product_codeField = value; }
		}
		private string product_versionField;
		public string product_version
		{
			get { return this.product_versionField; }
			set { this.product_versionField = value; }
		}
		private string package_versionField;
		public string package_version
		{
			get { return this.package_versionField; }
			set { this.package_versionField = value; }
		}
		private string package_editionField;
		public string package_edition
		{
			get { return this.package_editionField; }
			set { this.package_editionField = value; }
		}
		private string [] product_featuresField;
		public string [] product_features
		{
			get { return this.product_featuresField; }
			set { this.product_featuresField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SubsystemMemoryUsage", Namespace = "urn:iControl")]
	public partial class SystemSubsystemMemoryUsage
	{
		private string subsystem_nameField;
		public string subsystem_name
		{
			get { return this.subsystem_nameField; }
			set { this.subsystem_nameField = value; }
		}
		private CommonULong64 current_allocatedField;
		public CommonULong64 current_allocated
		{
			get { return this.current_allocatedField; }
			set { this.current_allocatedField = value; }
		}
		private CommonULong64 maximum_allocatedField;
		public CommonULong64 maximum_allocated
		{
			get { return this.maximum_allocatedField; }
			set { this.maximum_allocatedField = value; }
		}
		private CommonULong64 sizeField;
		public CommonULong64 size
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SystemInformation", Namespace = "urn:iControl")]
	public partial class SystemSystemInformation
	{
		private string system_nameField;
		public string system_name
		{
			get { return this.system_nameField; }
			set { this.system_nameField = value; }
		}
		private string host_nameField;
		public string host_name
		{
			get { return this.host_nameField; }
			set { this.host_nameField = value; }
		}
		private string os_releaseField;
		public string os_release
		{
			get { return this.os_releaseField; }
			set { this.os_releaseField = value; }
		}
		private string os_machineField;
		public string os_machine
		{
			get { return this.os_machineField; }
			set { this.os_machineField = value; }
		}
		private string os_versionField;
		public string os_version
		{
			get { return this.os_versionField; }
			set { this.os_versionField = value; }
		}
		private string platformField;
		public string platform
		{
			get { return this.platformField; }
			set { this.platformField = value; }
		}
		private string product_categoryField;
		public string product_category
		{
			get { return this.product_categoryField; }
			set { this.product_categoryField = value; }
		}
		private string chassis_serialField;
		public string chassis_serial
		{
			get { return this.chassis_serialField; }
			set { this.chassis_serialField = value; }
		}
		private string switch_board_serialField;
		public string switch_board_serial
		{
			get { return this.switch_board_serialField; }
			set { this.switch_board_serialField = value; }
		}
		private string switch_board_part_revisionField;
		public string switch_board_part_revision
		{
			get { return this.switch_board_part_revisionField; }
			set { this.switch_board_part_revisionField = value; }
		}
		private string host_board_serialField;
		public string host_board_serial
		{
			get { return this.host_board_serialField; }
			set { this.host_board_serialField = value; }
		}
		private string host_board_part_revisionField;
		public string host_board_part_revision
		{
			get { return this.host_board_part_revisionField; }
			set { this.host_board_part_revisionField = value; }
		}
		private string annunciator_board_serialField;
		public string annunciator_board_serial
		{
			get { return this.annunciator_board_serialField; }
			set { this.annunciator_board_serialField = value; }
		}
		private string annunciator_board_part_revisionField;
		public string annunciator_board_part_revision
		{
			get { return this.annunciator_board_part_revisionField; }
			set { this.annunciator_board_part_revisionField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.SystemProfileAttribute", Namespace = "urn:iControl")]
	public partial class SystemSystemProfileAttribute
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private SystemSystemProfileType profile_typeField;
		public SystemSystemProfileType profile_type
		{
			get { return this.profile_typeField; }
			set { this.profile_typeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.TemperatureMetric", Namespace = "urn:iControl")]
	public partial class SystemTemperatureMetric
	{
		private SystemTemperatureMetricType metric_typeField;
		public SystemTemperatureMetricType metric_type
		{
			get { return this.metric_typeField; }
			set { this.metric_typeField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.VersionInformation", Namespace = "urn:iControl")]
	public partial class SystemVersionInformation
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string valueField;
		public string value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	};

}
