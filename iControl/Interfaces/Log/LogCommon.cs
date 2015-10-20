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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Log.LogProtocol", Namespace = "urn:iControl")]
	public enum LogLogProtocol
	{
		LOG_PROTOCOL_UNKNOWN,
		LOG_PROTOCOL_TCP,
		LOG_PROTOCOL_UDP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Log.SyslogFacility", Namespace = "urn:iControl")]
	public enum LogSyslogFacility
	{
		LOG_FACILITY_UNKNOWN,
		LOG_FACILITY_LOCAL0,
		LOG_FACILITY_LOCAL1,
		LOG_FACILITY_LOCAL2,
		LOG_FACILITY_LOCAL3,
		LOG_FACILITY_LOCAL4,
		LOG_FACILITY_LOCAL5,
		LOG_FACILITY_LOCAL6,
		LOG_FACILITY_LOCAL7,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Log.SyslogFormat", Namespace = "urn:iControl")]
	public enum LogSyslogFormat
	{
		LOG_FORMAT_UNKNOWN,
		LOG_FORMAT_SYSLOG,
		LOG_FORMAT_BSD_SYSLOG,
		LOG_FORMAT_LEGACY_BIGIP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Log.SyslogLevel", Namespace = "urn:iControl")]
	public enum LogSyslogLevel
	{
		LOG_LEVEL_UNKNOWN,
		LOG_LEVEL_EMERG,
		LOG_LEVEL_ALERT,
		LOG_LEVEL_CRIT,
		LOG_LEVEL_ERR,
		LOG_LEVEL_WARNING,
		LOG_LEVEL_NOTICE,
		LOG_LEVEL_INFO,
		LOG_LEVEL_DEBUG,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
