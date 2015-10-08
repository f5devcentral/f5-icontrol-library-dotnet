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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DebugLevel", Namespace = "urn:iControl")]
	public enum ManagementDebugLevel
	{
		ZRD_EMERG,
		ZRD_ALERT,
		ZRD_CRIT,
		ZRD_ERROR,
		ZRD_WARN,
		ZRD_NOTICE,
		ZRD_INFO,
		ZRD_DEBUG,
		ZRD_UNSET,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.LDAPPasswordEncodingOption", Namespace = "urn:iControl")]
	public enum ManagementLDAPPasswordEncodingOption
	{
		LDAP_PASSWORD_ENCODING_ACTIVE_DIRECTORY,
		LDAP_PASSWORD_ENCODING_CLEAR,
		LDAP_PASSWORD_ENCODING_CRYPT,
		LDAP_PASSWORD_ENCODING_EXTENDED_OPERATION,
		LDAP_PASSWORD_ENCODING_MD5,
		LDAP_PASSWORD_ENCODING_NDS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.LDAPSSLOption", Namespace = "urn:iControl")]
	public enum ManagementLDAPSSLOption
	{
		LDAP_SSL_OPTION_NONE,
		LDAP_SSL_OPTION_ON,
		LDAP_SSL_OPTION_UNKNOWN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.LDAPSSOOption", Namespace = "urn:iControl")]
	public enum ManagementLDAPSSOOption
	{
		LDAP_SSO_OPTION_UNKNOWN,
		LDAP_SSO_OPTION_OFF,
		LDAP_SSO_OPTION_ON,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.LDAPSearchMethod", Namespace = "urn:iControl")]
	public enum ManagementLDAPSearchMethod
	{
		LDAP_SEARCH_METHOD_USER,
		LDAP_SEARCH_METHOD_CERTIFICATE,
		LDAP_SEARCH_METHOD_CERTIFICATE_MAP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.LDAPSearchScope", Namespace = "urn:iControl")]
	public enum ManagementLDAPSearchScope
	{
		LDAP_SEARCH_SCOPE_BASE,
		LDAP_SEARCH_SCOPE_ONE_LEVEL,
		LDAP_SEARCH_SCOPE_SUBTREE,
		LDAP_SEARCH_SCOPE_UNKNOWN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.OCSPDigestMethod", Namespace = "urn:iControl")]
	public enum ManagementOCSPDigestMethod
	{
		OCSP_DIGEST_METHOD_SHA1,
		OCSP_DIGEST_METHOD_MD5,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.RadiusServiceType", Namespace = "urn:iControl")]
	public enum ManagementRadiusServiceType
	{
		AUTH_RADIUS_SERVICE_TYPE_UNKNOWN,
		AUTH_RADIUS_SERVICE_TYPE_DEFAULT,
		AUTH_RADIUS_SERVICE_TYPE_LOGIN,
		AUTH_RADIUS_SERVICE_TYPE_FRAMED,
		AUTH_RADIUS_SERVICE_TYPE_CALLBACK_LOGIN,
		AUTH_RADIUS_SERVICE_TYPE_CALLBACK_FRAMED,
		AUTH_RADIUS_SERVICE_TYPE_OUTBOUND,
		AUTH_RADIUS_SERVICE_TYPE_ADMINISTRATIVE,
		AUTH_RADIUS_SERVICE_TYPE_NAS_PROMPT,
		AUTH_RADIUS_SERVICE_TYPE_AUTHENTICATE_ONLY,
		AUTH_RADIUS_SERVICE_TYPE_CALLBACK_NAS_PROMPT,
		AUTH_RADIUS_SERVICE_TYPE_CALL_CHECK,
		AUTH_RADIUS_SERVICE_TYPE_CALLBACK_ADMINISTRATIVE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ZoneType", Namespace = "urn:iControl")]
	public enum ManagementZoneType
	{
		UNSET,
		MASTER,
		SLAVE,
		STUB,
		FORWARD,
		HINT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.A6Record", Namespace = "urn:iControl")]
	public partial class ManagementA6Record
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private short prefix_bitsField;
		public short prefix_bits
		{
			get { return this.prefix_bitsField; }
			set { this.prefix_bitsField = value; }
		}
		private string ip_addressField;
		public string ip_address
		{
			get { return this.ip_addressField; }
			set { this.ip_addressField = value; }
		}
		private string prefix_nameField;
		public string prefix_name
		{
			get { return this.prefix_nameField; }
			set { this.prefix_nameField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.AAAARecord", Namespace = "urn:iControl")]
	public partial class ManagementAAAARecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private string ip_addressField;
		public string ip_address
		{
			get { return this.ip_addressField; }
			set { this.ip_addressField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ARecord", Namespace = "urn:iControl")]
	public partial class ManagementARecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private string ip_addressField;
		public string ip_address
		{
			get { return this.ip_addressField; }
			set { this.ip_addressField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.CNAMERecord", Namespace = "urn:iControl")]
	public partial class ManagementCNAMERecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private string cnameField;
		public string cname
		{
			get { return this.cnameField; }
			set { this.cnameField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DNAMERecord", Namespace = "urn:iControl")]
	public partial class ManagementDNAMERecord
	{
		private string labelField;
		public string label
		{
			get { return this.labelField; }
			set { this.labelField = value; }
		}
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DSRecord", Namespace = "urn:iControl")]
	public partial class ManagementDSRecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private short key_tagField;
		public short key_tag
		{
			get { return this.key_tagField; }
			set { this.key_tagField = value; }
		}
		private short algorithmField;
		public short algorithm
		{
			get { return this.algorithmField; }
			set { this.algorithmField = value; }
		}
		private short digest_typeField;
		public short digest_type
		{
			get { return this.digest_typeField; }
			set { this.digest_typeField = value; }
		}
		private string digestField;
		public string digest
		{
			get { return this.digestField; }
			set { this.digestField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.HINFORecord", Namespace = "urn:iControl")]
	public partial class ManagementHINFORecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private string hardwareField;
		public string hardware
		{
			get { return this.hardwareField; }
			set { this.hardwareField = value; }
		}
		private string osField;
		public string os
		{
			get { return this.osField; }
			set { this.osField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KEYRecord", Namespace = "urn:iControl")]
	public partial class ManagementKEYRecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private short flagsField;
		public short flags
		{
			get { return this.flagsField; }
			set { this.flagsField = value; }
		}
		private short protocolField;
		public short protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}
		private short algorithmField;
		public short algorithm
		{
			get { return this.algorithmField; }
			set { this.algorithmField = value; }
		}
		private string public_keyField;
		public string public_key
		{
			get { return this.public_keyField; }
			set { this.public_keyField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.MXRecord", Namespace = "urn:iControl")]
	public partial class ManagementMXRecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private long preferenceField;
		public long preference
		{
			get { return this.preferenceField; }
			set { this.preferenceField = value; }
		}
		private string mailField;
		public string mail
		{
			get { return this.mailField; }
			set { this.mailField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.NAPTRRecord", Namespace = "urn:iControl")]
	public partial class ManagementNAPTRRecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private short orderField;
		public short order
		{
			get { return this.orderField; }
			set { this.orderField = value; }
		}
		private short preferenceField;
		public short preference
		{
			get { return this.preferenceField; }
			set { this.preferenceField = value; }
		}
		private string flagsField;
		public string flags
		{
			get { return this.flagsField; }
			set { this.flagsField = value; }
		}
		private string serviceField;
		public string service
		{
			get { return this.serviceField; }
			set { this.serviceField = value; }
		}
		private string regexpField;
		public string regexp
		{
			get { return this.regexpField; }
			set { this.regexpField = value; }
		}
		private string replacementField;
		public string replacement
		{
			get { return this.replacementField; }
			set { this.replacementField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.NSRecord", Namespace = "urn:iControl")]
	public partial class ManagementNSRecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private string host_nameField;
		public string host_name
		{
			get { return this.host_nameField; }
			set { this.host_nameField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.NXTRecord", Namespace = "urn:iControl")]
	public partial class ManagementNXTRecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private string nxt_domainField;
		public string nxt_domain
		{
			get { return this.nxt_domainField; }
			set { this.nxt_domainField = value; }
		}
		private string typesField;
		public string types
		{
			get { return this.typesField; }
			set { this.typesField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.PTRRecord", Namespace = "urn:iControl")]
	public partial class ManagementPTRRecord
	{
		private string ip_addressField;
		public string ip_address
		{
			get { return this.ip_addressField; }
			set { this.ip_addressField = value; }
		}
		private string dnameField;
		public string dname
		{
			get { return this.dnameField; }
			set { this.dnameField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.RRList", Namespace = "urn:iControl")]
	public partial class ManagementRRList
	{
		private ManagementARecord [] a_listField;
		public ManagementARecord [] a_list
		{
			get { return this.a_listField; }
			set { this.a_listField = value; }
		}
		private ManagementNSRecord [] ns_listField;
		public ManagementNSRecord [] ns_list
		{
			get { return this.ns_listField; }
			set { this.ns_listField = value; }
		}
		private ManagementCNAMERecord [] cname_listField;
		public ManagementCNAMERecord [] cname_list
		{
			get { return this.cname_listField; }
			set { this.cname_listField = value; }
		}
		private ManagementSOARecord [] soa_listField;
		public ManagementSOARecord [] soa_list
		{
			get { return this.soa_listField; }
			set { this.soa_listField = value; }
		}
		private ManagementPTRRecord [] ptr_listField;
		public ManagementPTRRecord [] ptr_list
		{
			get { return this.ptr_listField; }
			set { this.ptr_listField = value; }
		}
		private ManagementHINFORecord [] hinfo_listField;
		public ManagementHINFORecord [] hinfo_list
		{
			get { return this.hinfo_listField; }
			set { this.hinfo_listField = value; }
		}
		private ManagementMXRecord [] mx_listField;
		public ManagementMXRecord [] mx_list
		{
			get { return this.mx_listField; }
			set { this.mx_listField = value; }
		}
		private ManagementTXTRecord [] txt_listField;
		public ManagementTXTRecord [] txt_list
		{
			get { return this.txt_listField; }
			set { this.txt_listField = value; }
		}
		private ManagementSRVRecord [] srv_listField;
		public ManagementSRVRecord [] srv_list
		{
			get { return this.srv_listField; }
			set { this.srv_listField = value; }
		}
		private ManagementKEYRecord [] key_listField;
		public ManagementKEYRecord [] key_list
		{
			get { return this.key_listField; }
			set { this.key_listField = value; }
		}
		private ManagementSIGRecord [] sig_listField;
		public ManagementSIGRecord [] sig_list
		{
			get { return this.sig_listField; }
			set { this.sig_listField = value; }
		}
		private ManagementNXTRecord [] nxt_listField;
		public ManagementNXTRecord [] nxt_list
		{
			get { return this.nxt_listField; }
			set { this.nxt_listField = value; }
		}
		private ManagementAAAARecord [] aaaa_listField;
		public ManagementAAAARecord [] aaaa_list
		{
			get { return this.aaaa_listField; }
			set { this.aaaa_listField = value; }
		}
		private ManagementA6Record [] a6_listField;
		public ManagementA6Record [] a6_list
		{
			get { return this.a6_listField; }
			set { this.a6_listField = value; }
		}
		private ManagementDNAMERecord [] dname_listField;
		public ManagementDNAMERecord [] dname_list
		{
			get { return this.dname_listField; }
			set { this.dname_listField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SIGRecord", Namespace = "urn:iControl")]
	public partial class ManagementSIGRecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private short type_coveredField;
		public short type_covered
		{
			get { return this.type_coveredField; }
			set { this.type_coveredField = value; }
		}
		private short algorithmField;
		public short algorithm
		{
			get { return this.algorithmField; }
			set { this.algorithmField = value; }
		}
		private short labelsField;
		public short labels
		{
			get { return this.labelsField; }
			set { this.labelsField = value; }
		}
		private long orig_ttlField;
		public long orig_ttl
		{
			get { return this.orig_ttlField; }
			set { this.orig_ttlField = value; }
		}
		private string sig_expirationField;
		public string sig_expiration
		{
			get { return this.sig_expirationField; }
			set { this.sig_expirationField = value; }
		}
		private string sig_inceptionField;
		public string sig_inception
		{
			get { return this.sig_inceptionField; }
			set { this.sig_inceptionField = value; }
		}
		private short key_tagField;
		public short key_tag
		{
			get { return this.key_tagField; }
			set { this.key_tagField = value; }
		}
		private string signer_nameField;
		public string signer_name
		{
			get { return this.signer_nameField; }
			set { this.signer_nameField = value; }
		}
		private string signatureField;
		public string signature
		{
			get { return this.signatureField; }
			set { this.signatureField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SOARecord", Namespace = "urn:iControl")]
	public partial class ManagementSOARecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private string primaryField;
		public string primary
		{
			get { return this.primaryField; }
			set { this.primaryField = value; }
		}
		private string emailField;
		public string email
		{
			get { return this.emailField; }
			set { this.emailField = value; }
		}
		private long serialField;
		public long serial
		{
			get { return this.serialField; }
			set { this.serialField = value; }
		}
		private long refreshField;
		public long refresh
		{
			get { return this.refreshField; }
			set { this.refreshField = value; }
		}
		private long retryField;
		public long retry
		{
			get { return this.retryField; }
			set { this.retryField = value; }
		}
		private long expireField;
		public long expire
		{
			get { return this.expireField; }
			set { this.expireField = value; }
		}
		private long neg_ttlField;
		public long neg_ttl
		{
			get { return this.neg_ttlField; }
			set { this.neg_ttlField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SRVRecord", Namespace = "urn:iControl")]
	public partial class ManagementSRVRecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private long priorityField;
		public long priority
		{
			get { return this.priorityField; }
			set { this.priorityField = value; }
		}
		private long weightField;
		public long weight
		{
			get { return this.weightField; }
			set { this.weightField = value; }
		}
		private long portField;
		public long port
		{
			get { return this.portField; }
			set { this.portField = value; }
		}
		private string targetField;
		public string target
		{
			get { return this.targetField; }
			set { this.targetField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.StatementDefinition", Namespace = "urn:iControl")]
	public partial class ManagementStatementDefinition
	{
		private string statement_idField;
		public string statement_id
		{
			get { return this.statement_idField; }
			set { this.statement_idField = value; }
		}
		private string [] sub_stringsField;
		public string [] sub_strings
		{
			get { return this.sub_stringsField; }
			set { this.sub_stringsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.TXTRecord", Namespace = "urn:iControl")]
	public partial class ManagementTXTRecord
	{
		private string domain_nameField;
		public string domain_name
		{
			get { return this.domain_nameField; }
			set { this.domain_nameField = value; }
		}
		private string textField;
		public string text
		{
			get { return this.textField; }
			set { this.textField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ViewInfo", Namespace = "urn:iControl")]
	public partial class ManagementViewInfo
	{
		private string view_nameField;
		public string view_name
		{
			get { return this.view_nameField; }
			set { this.view_nameField = value; }
		}
		private long view_orderField;
		public long view_order
		{
			get { return this.view_orderField; }
			set { this.view_orderField = value; }
		}
		private string [] option_seqField;
		public string [] option_seq
		{
			get { return this.option_seqField; }
			set { this.option_seqField = value; }
		}
		private string [] zone_namesField;
		public string [] zone_names
		{
			get { return this.zone_namesField; }
			set { this.zone_namesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ViewZone", Namespace = "urn:iControl")]
	public partial class ManagementViewZone
	{
		private string view_nameField;
		public string view_name
		{
			get { return this.view_nameField; }
			set { this.view_nameField = value; }
		}
		private string zone_nameField;
		public string zone_name
		{
			get { return this.zone_nameField; }
			set { this.zone_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.ZoneInfo", Namespace = "urn:iControl")]
	public partial class ManagementZoneInfo
	{
		private string view_nameField;
		public string view_name
		{
			get { return this.view_nameField; }
			set { this.view_nameField = value; }
		}
		private string zone_nameField;
		public string zone_name
		{
			get { return this.zone_nameField; }
			set { this.zone_nameField = value; }
		}
		private ManagementZoneType zone_typeField;
		public ManagementZoneType zone_type
		{
			get { return this.zone_typeField; }
			set { this.zone_typeField = value; }
		}
		private string zone_fileField;
		public string zone_file
		{
			get { return this.zone_fileField; }
			set { this.zone_fileField = value; }
		}
		private string [] option_seqField;
		public string [] option_seq
		{
			get { return this.option_seqField; }
			set { this.option_seqField = value; }
		}
	};

}
