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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "iCall.GeneralHandlerState", Namespace = "urn:iControl")]
	public enum iCallGeneralHandlerState
	{
		GENERAL_HANDLER_STATE_UNKNOWN,
		GENERAL_HANDLER_STATE_ACTIVE,
		GENERAL_HANDLER_STATE_INACTIVE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "iCall.MatchAlgorithm", Namespace = "urn:iControl")]
	public enum iCallMatchAlgorithm
	{
		MATCH_ALGORITHM_UNKNOWN,
		MATCH_ALGORITHM_EXACT,
		MATCH_ALGORITHM_GLOB,
		MATCH_ALGORITHM_REGEX,
		MATCH_ALGORITHM_SUBNET,
		MATCH_ALGORITHM_ACCEPT_ALL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "iCall.PerpetualHandlerState", Namespace = "urn:iControl")]
	public enum iCallPerpetualHandlerState
	{
		PERPETUAL_HANDLER_STATE_UNKNOWN,
		PERPETUAL_HANDLER_STATE_ACTIVE,
		PERPETUAL_HANDLER_STATE_INACTIVE,
		PERPETUAL_HANDLER_STATE_SUSPEND,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "iCall.PeriodicHandlerExpiry", Namespace = "urn:iControl")]
	public partial class iCallPeriodicHandlerExpiry
	{
		private bool expiresField;
		public bool expires
		{
			get { return this.expiresField; }
			set { this.expiresField = value; }
		}
		private CommonTimeStamp expiry_timeField;
		public CommonTimeStamp expiry_time
		{
			get { return this.expiry_timeField; }
			set { this.expiry_timeField = value; }
		}
	};

}
