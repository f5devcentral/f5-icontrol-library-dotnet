using System;
using System.Collections.Generic;
using System.Text;
namespace iControl
{
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LTConfig.ClassInstanceKey", Namespace = "urn:iControl")]
	public partial class LTConfigClassInstanceKey
	{
		private string containerField;
		public string container
		{
			get { return this.containerField; }
			set { this.containerField = value; }
		}
		private string container_classField;
		public string container_class
		{
			get { return this.container_classField; }
			set { this.container_classField = value; }
		}
		private string class_nameField;
		public string class_name
		{
			get { return this.class_nameField; }
			set { this.class_nameField = value; }
		}
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
	};

}
