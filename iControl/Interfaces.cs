//===========================================================================
//
// File         : Interfaces
//                   
//---------------------------------------------------------------------------
//
// The contents of this file are subject to the "END USER LICENSE AGREEMENT FOR F5
// Software Development Kit for iControl"; you may not use this file except in
// compliance with the License. The License is included in the iControl
// Software Development Kit.
//
// Software distributed under the License is distributed on an "AS IS"
// basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See
// the License for the specific language governing rights and limitations
// under the License.
//
// The Original Code is iControl Code and related documentation
// distributed by F5.
//
// The Initial Developer of the Original Code is F5 Networks, Inc.
// Seattle, WA, USA.
// Portions created by F5 are Copyright (C) 2006 F5 Networks, Inc.
// All Rights Reserved.
// iControl (TM) is a registered trademark of F5 Networks, Inc.
//
// Alternatively, the contents of this file may be used under the terms
// of the GNU General Public License (the "GPL"), in which case the
// provisions of GPL are applicable instead of those above.  If you wish
// to allow use of your version of this file only under the terms of the
// GPL and not to allow others to use your version of this file under the
// License, indicate your decision by deleting the provisions above and
// replace them with the notice and other provisions required by the GPL.
// If you do not delete the provisions above, a recipient may use your
// version of this file under either the License or the GPL.
//
//===========================================================================

using System;
using System.Collections.Generic;
using System.Text;
using iControl;

namespace iControl
{
    public class Interfaces
    {
        //-------------------------------------------------------------------
        // Member Variables
        //-------------------------------------------------------------------
        private ASMLoggingProfile m_ASMLoggingProfile;
        private ASMObjectParams m_ASMObjectParams;
        private ASMPolicy m_ASMPolicy;
        private ASMPolicyGroup m_ASMPolicyGroup;
        private ASMPSMProfile m_ASMPSMProfile;
        private ASMSystemConfiguration m_ASMSystemConfiguration;
        private ASMWebApplication m_ASMWebApplication;
        private ASMWebApplicationGroup m_ASMWebApplicationGroup;

        private ClassificationApplication m_ClassificationApplication;
        private ClassificationCategory m_ClassificationCategory;
        private ClassificationSignatureDefinition m_ClassificationSignatureDefinition;
        private ClassificationSignatureUpdateSchedule m_ClassificationSignatureUpdateSchedule;
        private ClassificationSignatureVersion m_ClassificationSignatureVersion;

        private GlobalLBApplication m_GlobalLBApplication;
        private GlobalLBDataCenter m_GlobalLBDataCenter;
        private GlobalLBDNSSECKey m_GlobalLBDNSSECKey;
        private GlobalLBDNSSECZone m_GlobalLBDNSSECZone;
        private GlobalLBGlobals m_GlobalLBGlobals;
        private GlobalLBLink m_GlobalLBLink;
        private GlobalLBMonitor m_GlobalLBMonitor;
        private GlobalLBPool m_GlobalLBPool;
        private GlobalLBPoolMember m_GlobalLBPoolMember;
        private GlobalLBPoolV2 m_GlobalLBPoolV2;
        private GlobalLBProberPool m_GlobalLBProberPool;
        private GlobalLBRegion m_GlobalLBRegion;
        private GlobalLBRule m_GlobalLBRule;
        private GlobalLBServer m_GlobalLBServer;
        private GlobalLBTopology m_GlobalLBTopology;
        private GlobalLBVirtualServer m_GlobalLBVirtualServer;
        private GlobalLBVirtualServerV2 m_GlobalLBVirtualServerV2;
        private GlobalLBWideIP m_GlobalLBWideIP;
        private GlobalLBWideIPV2 m_GlobalLBWideIPV2;

        private iCallPeriodicHandler m_iCallPeriodicHandler;
        private iCallPerpetualHandler m_iCallPerpetualHandler;
        private iCallScript m_iCallScript;
        private iCallTriggeredHandler m_iCallTriggeredHandler;

        private LocalLBALGLogProfile m_LocalLBALGLogProfile;
        private LocalLBCipherGroup m_LocalLBCipherGroup;
        private LocalLBCipherRule m_LocalLBCipherRule;
        private LocalLBClass m_LocalLBClass;
        private LocalLBContentPolicy m_LocalLBContentPolicy;
        private LocalLBContentPolicyStrategy m_LocalLBContentPolicyStrategy;
        private LocalLBDataGroupFile m_LocalLBDataGroupFile;
        private LocalLBDNSCache m_LocalLBDNSCache;
        private LocalLBDNSExpress m_LocalLBDNSExpress;
        private LocalLBDNSGlobals m_LocalLBDNSGlobals;
        private LocalLBDNSServer m_LocalLBDNSServer;
        private LocalLBDNSTSIGKey m_LocalLBDNSTSIGKey;
        private LocalLBDNSZone m_LocalLBDNSZone;
        private LocalLBFlowEvictionPolicy m_LocalLBFlowEvictionPolicy;
        private LocalLBiFile m_LocalLBiFile;
        private LocalLBiFileFile m_LocalLBiFileFile;
        private LocalLBLSNLogProfile m_LocalLBLSNLogProfile;
        private LocalLBLSNPool m_LocalLBLSNPool;
        private LocalLBMessageRoutingPeer m_LocalLBMessageRoutingPeer;
        private LocalLBMessageRoutingSIPRoute m_LocalLBMessageRoutingSIPRoute;
        private LocalLBMessageRoutingTransportConfig m_LocalLBMessageRoutingTransportConfig;
        private LocalLBMonitor m_LocalLBMonitor;
        private LocalLBNAT m_LocalLBNAT;
        private LocalLBNATV2 m_LocalLBNATV2;
        private LocalLBNodeAddress m_LocalLBNodeAddress;
        private LocalLBNodeAddressV2 m_LocalLBNodeAddressV2;
        private LocalLBOCSPStaplingParameters m_LocalLBOCSPStaplingParameters;
        private LocalLBPool m_LocalLBPool;
        private LocalLBPoolMember m_LocalLBPoolMember;
        private LocalLBProfileAnalytics m_LocalLBProfileAnalytics;
        private LocalLBProfileAuth m_LocalLBProfileAuth;
        private LocalLBProfileClassification m_LocalLBProfileClassification;
        private LocalLBProfileClientLDAP m_LocalLBProfileClientLDAP;
        private LocalLBProfileClientSSL m_LocalLBProfileClientSSL;
        private LocalLBProfileDiameter m_LocalLBProfileDiameter;
        private LocalLBProfileDiameterEndpoint m_LocalLBProfileDiameterEndpoint;
        private LocalLBProfileDiameterRouter m_LocalLBProfileDiameterRouter;
        private LocalLBProfileDiameterSession m_LocalLBProfileDiameterSession;
        private LocalLBProfileDNS m_LocalLBProfileDNS;
        private LocalLBProfileDNSLogging m_LocalLBProfileDNSLogging;
        private LocalLBProfileFastHttp m_LocalLBProfileFastHttp;
        private LocalLBProfileFastL4 m_LocalLBProfileFastL4;
        private LocalLBProfileFIX m_LocalLBProfileFIX;
        private LocalLBProfileFTP m_LocalLBProfileFTP;
        private LocalLBProfileHttp m_LocalLBProfileHttp;
        private LocalLBProfileHttpClass m_LocalLBProfileHttpClass;
        private LocalLBProfileHttpCompression m_LocalLBProfileHttpCompression;
        private LocalLBProfileICAP m_LocalLBProfileICAP;
        private LocalLBProfileIIOP m_LocalLBProfileIIOP;
        private LocalLBProfileIPsecALG m_LocalLBProfileIPsecALG;
        private LocalLBProfileOneConnect m_LocalLBProfileOneConnect;
        private LocalLBProfilePCP m_LocalLBProfilePCP;
        private LocalLBProfilePersistence m_LocalLBProfilePersistence;
        private LocalLBProfilePPTP m_LocalLBProfilePPTP;
        private LocalLBProfileRADIUS m_LocalLBProfileRADIUS;
        private LocalLBProfileRequestAdapt m_LocalLBProfileRequestAdapt;
        private LocalLBProfileRequestLogging m_LocalLBProfileRequestLogging;
        private LocalLBProfileResponseAdapt m_LocalLBProfileResponseAdapt;
        private LocalLBProfileRTSP m_LocalLBProfileRTSP;
        private LocalLBProfileSCTP m_LocalLBProfileSCTP;
        private LocalLBProfileServerLDAP m_LocalLBProfileServerLDAP;
        private LocalLBProfileServerSSL m_LocalLBProfileServerSSL;
        private LocalLBProfileSIP m_LocalLBProfileSIP;
        private LocalLBProfileSIPRouter m_LocalLBProfileSIPRouter;
        private LocalLBProfileSIPSession m_LocalLBProfileSIPSession;
        private LocalLBProfileSMTPS m_LocalLBProfileSMTPS;
        private LocalLBProfileSPDY m_LocalLBProfileSPDY;
        private LocalLBProfileSPM m_LocalLBProfileSPM;
        private LocalLBProfileStream m_LocalLBProfileStream;
        private LocalLBProfileTCP m_LocalLBProfileTCP;
        private LocalLBProfileTCPAnalytics m_LocalLBProfileTCPAnalytics;
        private LocalLBProfileTFTP m_LocalLBProfileTFTP;
        private LocalLBProfileTrafficAcceleration m_LocalLBProfileTrafficAcceleration;
        private LocalLBProfileUDP m_LocalLBProfileUDP;
        private LocalLBProfileUserStatistic m_LocalLBProfileUserStatistic;
        private LocalLBProfileWebAcceleration m_LocalLBProfileWebAcceleration;
        private LocalLBProfileXML m_LocalLBProfileXML;
        private LocalLBRAMCacheInformation m_LocalLBRAMCacheInformation;
        private LocalLBRateClass m_LocalLBRateClass;
        private LocalLBRule m_LocalLBRule;
        private LocalLBSNAT m_LocalLBSNAT;
        private LocalLBSNATPool m_LocalLBSNATPool;
        private LocalLBSNATPoolMember m_LocalLBSNATPoolMember;
        private LocalLBSNATTranslationAddress m_LocalLBSNATTranslationAddress;
        private LocalLBSNATTranslationAddressV2 m_LocalLBSNATTranslationAddressV2;
        private LocalLBVirtualAddress m_LocalLBVirtualAddress;
        private LocalLBVirtualAddressV2 m_LocalLBVirtualAddressV2;
        private LocalLBVirtualServer m_LocalLBVirtualServer;

        private LogDestinationArcSight m_LogDestinationArcSight;
        private LogDestinationIPFIX m_LogDestinationIPFIX;
        private LogDestinationLocalSyslog m_LogDestinationLocalSyslog;
        private LogDestinationManagementPort m_LogDestinationManagementPort;
        private LogDestinationRemoteHighSpeedLog m_LogDestinationRemoteHighSpeedLog;
        private LogDestinationRemoteSyslog m_LogDestinationRemoteSyslog;
        private LogDestinationSplunk m_LogDestinationSplunk;
        private LogFilter m_LogFilter;
        private LogIPFIXInformationElement m_LogIPFIXInformationElement;
        private LogPublisher m_LogPublisher;

        private LTConfigClass m_LTConfigClass;
        private LTConfigField m_LTConfigField;

        private ManagementApplicationPresentationScript m_ManagementApplicationPresentationScript;
        private ManagementApplicationService m_ManagementApplicationService;
        private ManagementApplicationTemplate m_ManagementApplicationTemplate;
        private ManagementCCLDAPConfiguration m_ManagementCCLDAPConfiguration;
        private ManagementCertLDAPConfiguration m_ManagementCertLDAPConfiguration;
        private ManagementCertificateValidatorOCSP m_ManagementCertificateValidatorOCSP;
        private ManagementChangeControl m_ManagementChangeControl;
        private ManagementCLIScript m_ManagementCLIScript;
        private ManagementCRLDPConfiguration m_ManagementCRLDPConfiguration;
        private ManagementCRLDPServer m_ManagementCRLDPServer;
        private ManagementDBVariable m_ManagementDBVariable;
        private ManagementDevice m_ManagementDevice;
        private ManagementDeviceGroup m_ManagementDeviceGroup;
        private ManagementEM m_ManagementEM;
        private ManagementEventNotification m_ManagementEventNotification;
        private ManagementEventSubscription m_ManagementEventSubscription;
        private ManagementFeatureModule m_ManagementFeatureModule;
        private ManagementFolder m_ManagementFolder;
        private ManagementGlobals m_ManagementGlobals;
        private ManagementKeyCertificate m_ManagementKeyCertificate;
        private ManagementLDAPConfiguration m_ManagementLDAPConfiguration;
        private ManagementLicenseAdministration m_ManagementLicenseAdministration;
        private ManagementNamed m_ManagementNamed;
        private ManagementOCSPConfiguration m_ManagementOCSPConfiguration;
        private ManagementOCSPResponder m_ManagementOCSPResponder;
        private ManagementPartition m_ManagementPartition;
        private ManagementProvision m_ManagementProvision;
        private ManagementRADIUSConfiguration m_ManagementRADIUSConfiguration;
        private ManagementRADIUSServer m_ManagementRADIUSServer;
        private ManagementResourceRecord m_ManagementResourceRecord;
        private ManagementSFlowDataSource m_ManagementSFlowDataSource;
        private ManagementSFlowGlobals m_ManagementSFlowGlobals;
        private ManagementSFlowReceiver m_ManagementSFlowReceiver;
        private ManagementSMTPConfiguration m_ManagementSMTPConfiguration;
        private ManagementSNMPConfiguration m_ManagementSNMPConfiguration;
        private ManagementTACACSConfiguration m_ManagementTACACSConfiguration;
        private ManagementTMOSModule m_ManagementTMOSModule;
        private ManagementTrafficGroup m_ManagementTrafficGroup;
        private ManagementTrust m_ManagementTrust;
        private ManagementUserManagement m_ManagementUserManagement;
        private ManagementView m_ManagementView;
        private ManagementZone m_ManagementZone;
        private ManagementZoneRunner m_ManagementZoneRunner;

        private NetworkingAdminIP m_NetworkingAdminIP;
        private NetworkingARP m_NetworkingARP;
        private NetworkingBWControllerPolicy m_NetworkingBWControllerPolicy;
        private NetworkingBWPriorityGroup m_NetworkingBWPriorityGroup;
        private NetworkingDNSResolver m_NetworkingDNSResolver;
        private NetworkingInterfaces m_NetworkingInterfaces;
        private NetworkingIPsecIkeDaemon m_NetworkingIPsecIkeDaemon;
        private NetworkingIPsecIkePeer m_NetworkingIPsecIkePeer;
        private NetworkingIPsecManualSecurityAssociation m_NetworkingIPsecManualSecurityAssociation;
        private NetworkingIPsecPolicy m_NetworkingIPsecPolicy;
        private NetworkingIPsecTrafficSelector m_NetworkingIPsecTrafficSelector;
        private NetworkingiSessionAdvertisedRoute m_NetworkingiSessionAdvertisedRoute;
        private NetworkingiSessionAdvertisedRouteV2 m_NetworkingiSessionAdvertisedRouteV2;
        private NetworkingiSessionDatastor m_NetworkingiSessionDatastor;
        private NetworkingiSessionDeduplication m_NetworkingiSessionDeduplication;
        private NetworkingiSessionLocalInterface m_NetworkingiSessionLocalInterface;
        private NetworkingiSessionPeerDiscovery m_NetworkingiSessionPeerDiscovery;
        private NetworkingiSessionRemoteInterface m_NetworkingiSessionRemoteInterface;
        private NetworkingiSessionRemoteInterfaceV2 m_NetworkingiSessionRemoteInterfaceV2;
        private NetworkingLLDPGlobals m_NetworkingLLDPGlobals;
        private NetworkingMulticastRoute m_NetworkingMulticastRoute;
        private NetworkingPacketFilter m_NetworkingPacketFilter;
        private NetworkingPacketFilterGlobals m_NetworkingPacketFilterGlobals;
        private NetworkingPortMirror m_NetworkingPortMirror;
        private NetworkingProfileFEC m_NetworkingProfileFEC;
        private NetworkingProfileGeneve m_NetworkingProfileGeneve;
        private NetworkingProfileGRE m_NetworkingProfileGRE;
        private NetworkingProfileIPIP m_NetworkingProfileIPIP;
        private NetworkingProfileIPsec m_NetworkingProfileIPsec;
        private NetworkingProfileLightweight4Over6Tunnel m_NetworkingProfileLightweight4Over6Tunnel;
        private NetworkingProfileMAP m_NetworkingProfileMAP;
        private NetworkingProfileV6RD m_NetworkingProfileV6RD;
        private NetworkingProfileVXLAN m_NetworkingProfileVXLAN;
        private NetworkingProfileWCCPGRE m_NetworkingProfileWCCPGRE;
        private NetworkingRouteDomain m_NetworkingRouteDomain;
        private NetworkingRouteDomainV2 m_NetworkingRouteDomainV2;
        private NetworkingRouterAdvertisement m_NetworkingRouterAdvertisement;
        private NetworkingRouteTable m_NetworkingRouteTable;
        private NetworkingRouteTableV2 m_NetworkingRouteTableV2;
        private NetworkingSelfIP m_NetworkingSelfIP;
        private NetworkingSelfIPPortLockdown m_NetworkingSelfIPPortLockdown;
        private NetworkingSelfIPV2 m_NetworkingSelfIPV2;
        private NetworkingSTPGlobals m_NetworkingSTPGlobals;
        private NetworkingSTPInstance m_NetworkingSTPInstance;
        private NetworkingSTPInstanceV2 m_NetworkingSTPInstanceV2;
        private NetworkingTrunk m_NetworkingTrunk;
        private NetworkingTunnel m_NetworkingTunnel;
        private NetworkingVLAN m_NetworkingVLAN;
        private NetworkingVLANGroup m_NetworkingVLANGroup;

        private PEMFormatScript m_PEMFormatScript;
        private PEMForwardingEndpoint m_PEMForwardingEndpoint;
        private PEMInterceptionEndpoint m_PEMInterceptionEndpoint;
        private PEMListener m_PEMListener;
        private PEMPolicy m_PEMPolicy;
        private PEMServiceChainEndpoint m_PEMServiceChainEndpoint;
        private PEMSubscriber m_PEMSubscriber;

        private SecurityDoSDevice m_SecurityDoSDevice;
        private SecurityDoSWhitelist m_SecurityDoSWhitelist;
        private SecurityFirewallAddressList m_SecurityFirewallAddressList;
        private SecurityFirewallGlobalAdminIPRuleList m_SecurityFirewallGlobalAdminIPRuleList;
        private SecurityFirewallGlobalRuleList m_SecurityFirewallGlobalRuleList;
        private SecurityFirewallPolicy m_SecurityFirewallPolicy;
        private SecurityFirewallPortList m_SecurityFirewallPortList;
        private SecurityFirewallRuleList m_SecurityFirewallRuleList;
        private SecurityFirewallWeeklySchedule m_SecurityFirewallWeeklySchedule;
        private SecurityIPIntelligenceBlacklistCategory m_SecurityIPIntelligenceBlacklistCategory;
        private SecurityIPIntelligenceFeedList m_SecurityIPIntelligenceFeedList;
        private SecurityIPIntelligenceGlobalPolicy m_SecurityIPIntelligenceGlobalPolicy;
        private SecurityIPIntelligencePolicy m_SecurityIPIntelligencePolicy;
        private SecurityLogProfile m_SecurityLogProfile;
        private SecurityProfileDNSSecurity m_SecurityProfileDNSSecurity;
        private SecurityProfileDoS m_SecurityProfileDoS;
        private SecurityProfileIPIntelligence m_SecurityProfileIPIntelligence;
        private SystemCertificateRevocationListFile m_SystemCertificateRevocationListFile;
        private SystemCluster m_SystemCluster;

        private SystemCABundleManager m_SystemCABundleManager;
        private SystemConfigSync m_SystemConfigSync;
        private SystemConnections m_SystemConnections;
        private SystemCryptoClient m_SystemCryptoClient;
        private SystemCryptoServer m_SystemCryptoServer;
        private SystemDisk m_SystemDisk;
        private SystemExternalMonitorFile m_SystemExternalMonitorFile;
        private SystemFailover m_SystemFailover;
        private SystemGeoIP m_SystemGeoIP;
        private SystemHAGroup m_SystemHAGroup;
        private SystemHAStatus m_SystemHAStatus;
        private SystemInet m_SystemInet;
        private SystemInternal m_SystemInternal;
        private SystemLightweightTunnelTableFile m_SystemLightweightTunnelTableFile;
        private SystemPerformanceSFlow m_SystemPerformanceSFlow;
        private SystemServices m_SystemServices;
        private SystemSession m_SystemSession;
        private SystemSoftwareManagement m_SystemSoftwareManagement;
        private SystemStatistics m_SystemStatistics;
        private SystemSystemInfo m_SystemSystemInfo;
        private SystemVCMP m_SystemVCMP;
        private WebAcceleratorApplications m_WebAcceleratorApplications;

        private WebAcceleratorPolicies m_WebAcceleratorPolicies;
        private WebAcceleratorProxyMessage m_WebAcceleratorProxyMessage;

        private bool m_bInitialized = false;
        private ConnectionInfo m_ci = null;
        private System.Net.NetworkCredential m_creds = null;
        //private String m_version = "BIGIP-v9.4.0";
        private string m_emIPAddress = null;
        private string m_authToken = null;
        private System.Net.WebProxy m_proxyServer = null;
        private bool m_bPingDuringInitialize = true;
        private Exception m_lastException = null;

        // v11
        private static long SESSIONID_UNKNOWN = -1;
        private static long SESSIONID_NOTAVAILABLE = -2;
        private long m_sessionIdentifier = SESSIONID_UNKNOWN;

        //-------------------------------------------------------------------
        // public member accessors
        //-------------------------------------------------------------------
        public ASMLoggingProfile ASMLoggingProfile { get { verifyInitialized(); if (null == m_ASMLoggingProfile) { initializeInterface(m_ASMLoggingProfile = new ASMLoggingProfile()); } return m_ASMLoggingProfile; } }
        public ASMObjectParams ASMObjectParams { get { verifyInitialized(); if (null == m_ASMObjectParams) { initializeInterface(m_ASMObjectParams = new ASMObjectParams()); } return m_ASMObjectParams; } }
        public ASMPolicy ASMPolicy { get { verifyInitialized(); if (null == m_ASMPolicy) { initializeInterface(m_ASMPolicy = new ASMPolicy()); } return m_ASMPolicy; } }
        public ASMPolicyGroup ASMPolicyGroup { get { verifyInitialized(); if (null == m_ASMPolicyGroup) { initializeInterface(m_ASMPolicyGroup = new ASMPolicyGroup()); } return m_ASMPolicyGroup; } }
        public ASMPSMProfile ASMPSMProfile { get { verifyInitialized(); if (null == m_ASMPSMProfile) { initializeInterface(m_ASMPSMProfile = new ASMPSMProfile()); } return m_ASMPSMProfile; } }
        public ASMSystemConfiguration ASMSystemConfiguration { get { verifyInitialized(); if (null == m_ASMSystemConfiguration) { initializeInterface(m_ASMSystemConfiguration = new ASMSystemConfiguration()); } return m_ASMSystemConfiguration; } }
        public ASMWebApplication ASMWebApplication { get { verifyInitialized(); if (null == m_ASMWebApplication) { initializeInterface(m_ASMWebApplication = new ASMWebApplication()); } return m_ASMWebApplication; } }
        public ASMWebApplicationGroup ASMWebApplicationGroup { get { verifyInitialized(); if (null == m_ASMWebApplicationGroup) { initializeInterface(m_ASMWebApplicationGroup = new ASMWebApplicationGroup()); } return m_ASMWebApplicationGroup; } }

        public ClassificationApplication ClassificationApplication { get { verifyInitialized(); if (null == m_ClassificationApplication) { initializeInterface(m_ClassificationApplication = new ClassificationApplication()); } return m_ClassificationApplication; } }
        public ClassificationCategory ClassificationCategory { get { verifyInitialized(); if (null == m_ClassificationCategory) { initializeInterface(m_ClassificationCategory = new ClassificationCategory()); } return m_ClassificationCategory; } }
        public ClassificationSignatureDefinition ClassificationSignatureDefinition { get { verifyInitialized(); if (null == m_ClassificationSignatureDefinition) { initializeInterface(m_ClassificationSignatureDefinition = new ClassificationSignatureDefinition()); } return m_ClassificationSignatureDefinition; } }
        public ClassificationSignatureUpdateSchedule ClassificationSignatureUpdateSchedule { get { verifyInitialized(); if (null == m_ClassificationSignatureUpdateSchedule) { initializeInterface(m_ClassificationSignatureUpdateSchedule = new ClassificationSignatureUpdateSchedule()); } return m_ClassificationSignatureUpdateSchedule; } }
        public ClassificationSignatureVersion ClassificationSignatureVersion { get { verifyInitialized(); if (null == m_ClassificationSignatureVersion) { initializeInterface(m_ClassificationSignatureVersion = new ClassificationSignatureVersion()); } return m_ClassificationSignatureVersion; } }

        public GlobalLBApplication GlobalLBApplication { get { verifyInitialized(); if (null == m_GlobalLBApplication) { initializeInterface(m_GlobalLBApplication = new GlobalLBApplication()); } return m_GlobalLBApplication; } }
        public GlobalLBDataCenter GlobalLBDataCenter { get { verifyInitialized(); if (null == m_GlobalLBDataCenter) { initializeInterface(m_GlobalLBDataCenter = new GlobalLBDataCenter()); } return m_GlobalLBDataCenter; } }
        public GlobalLBDNSSECKey GlobalLBDNSSECKey { get { verifyInitialized(); if (null == m_GlobalLBDNSSECKey) { initializeInterface(m_GlobalLBDNSSECKey = new GlobalLBDNSSECKey()); } return m_GlobalLBDNSSECKey; } }
        public GlobalLBDNSSECZone GlobalLBDNSSECZone { get { verifyInitialized(); if (null == m_GlobalLBDNSSECZone) { initializeInterface(m_GlobalLBDNSSECZone = new GlobalLBDNSSECZone()); } return m_GlobalLBDNSSECZone; } }
        public GlobalLBGlobals GlobalLBGlobals { get { verifyInitialized(); if (null == m_GlobalLBGlobals) { initializeInterface(m_GlobalLBGlobals = new GlobalLBGlobals()); } return m_GlobalLBGlobals; } }
        public GlobalLBLink GlobalLBLink { get { verifyInitialized(); if (null == m_GlobalLBLink) { initializeInterface(m_GlobalLBLink = new GlobalLBLink()); } return m_GlobalLBLink; } }
        public GlobalLBMonitor GlobalLBMonitor { get { verifyInitialized(); if (null == m_GlobalLBMonitor) { initializeInterface(m_GlobalLBMonitor = new GlobalLBMonitor()); } return m_GlobalLBMonitor; } }
        public GlobalLBPool GlobalLBPool { get { verifyInitialized(); if (null == m_GlobalLBPool) { initializeInterface(m_GlobalLBPool = new GlobalLBPool()); } return m_GlobalLBPool; } }
        public GlobalLBPoolMember GlobalLBPoolMember { get { verifyInitialized(); if (null == m_GlobalLBPoolMember) { initializeInterface(m_GlobalLBPoolMember = new GlobalLBPoolMember()); } return m_GlobalLBPoolMember; } }
        public GlobalLBPoolV2 GlobalLBPoolV2 { get { verifyInitialized(); if (null == m_GlobalLBPoolV2) { initializeInterface(m_GlobalLBPoolV2 = new GlobalLBPoolV2()); } return m_GlobalLBPoolV2; } }
        public GlobalLBProberPool GlobalLBProberPool { get { verifyInitialized(); if (null == m_GlobalLBProberPool) { initializeInterface(m_GlobalLBProberPool = new GlobalLBProberPool()); } return m_GlobalLBProberPool; } }
        public GlobalLBRegion GlobalLBRegion { get { verifyInitialized(); if (null == m_GlobalLBRegion) { initializeInterface(m_GlobalLBRegion = new GlobalLBRegion()); } return m_GlobalLBRegion; } }
        public GlobalLBRule GlobalLBRule { get { verifyInitialized(); if (null == m_GlobalLBRule) { initializeInterface(m_GlobalLBRule = new GlobalLBRule()); } return m_GlobalLBRule; } }
        public GlobalLBServer GlobalLBServer { get { verifyInitialized(); if (null == m_GlobalLBServer) { initializeInterface(m_GlobalLBServer = new GlobalLBServer()); } return m_GlobalLBServer; } }
        public GlobalLBTopology GlobalLBTopology { get { verifyInitialized(); if (null == m_GlobalLBTopology) { initializeInterface(m_GlobalLBTopology = new GlobalLBTopology()); } return m_GlobalLBTopology; } }
        public GlobalLBVirtualServer GlobalLBVirtualServer { get { verifyInitialized(); if (null == m_GlobalLBVirtualServer) { initializeInterface(m_GlobalLBVirtualServer = new GlobalLBVirtualServer()); } return m_GlobalLBVirtualServer; } }
        public GlobalLBVirtualServerV2 GlobalLBVirtualServerV2 { get { verifyInitialized(); if (null == m_GlobalLBVirtualServerV2) { initializeInterface(m_GlobalLBVirtualServerV2 = new GlobalLBVirtualServerV2()); } return m_GlobalLBVirtualServerV2; } }
        public GlobalLBWideIP GlobalLBWideIP { get { verifyInitialized(); if (null == m_GlobalLBWideIP) { initializeInterface(m_GlobalLBWideIP = new GlobalLBWideIP()); } return m_GlobalLBWideIP; } }
        public GlobalLBWideIPV2 GlobalLBWideIPV2 { get { verifyInitialized(); if (null == m_GlobalLBWideIPV2) { initializeInterface(m_GlobalLBWideIPV2 = new GlobalLBWideIPV2()); } return m_GlobalLBWideIPV2; } }

        public iCallPeriodicHandler iCallPeriodicHandler { get { verifyInitialized(); if (null == m_iCallPeriodicHandler) { initializeInterface(m_iCallPeriodicHandler = new iCallPeriodicHandler()); } return m_iCallPeriodicHandler; } }
        public iCallPerpetualHandler iCallPerpetualHandler { get { verifyInitialized(); if (null == m_iCallPerpetualHandler) { initializeInterface(m_iCallPerpetualHandler = new iCallPerpetualHandler()); } return m_iCallPerpetualHandler; } }
        public iCallScript iCallScript { get { verifyInitialized(); if (null == m_iCallScript) { initializeInterface(m_iCallScript = new iCallScript()); } return m_iCallScript; } }
        public iCallTriggeredHandler iCallTriggeredHandler { get { verifyInitialized(); if (null == m_iCallTriggeredHandler) { initializeInterface(m_iCallTriggeredHandler = new iCallTriggeredHandler()); } return m_iCallTriggeredHandler; } }

        public LocalLBALGLogProfile LocalLBALGLogProfile { get { verifyInitialized(); if (null == m_LocalLBALGLogProfile) { initializeInterface(m_LocalLBALGLogProfile = new LocalLBALGLogProfile()); } return m_LocalLBALGLogProfile; } }
        public LocalLBCipherGroup LocalLBCipherGroup { get { verifyInitialized(); if (null == m_LocalLBCipherGroup) { initializeInterface(m_LocalLBCipherGroup = new LocalLBCipherGroup()); } return m_LocalLBCipherGroup; } }
        public LocalLBCipherRule LocalLBCipherRule { get { verifyInitialized(); if (null == m_LocalLBCipherRule) { initializeInterface(m_LocalLBCipherRule = new LocalLBCipherRule()); } return m_LocalLBCipherRule; } }
        public LocalLBClass LocalLBClass { get { verifyInitialized(); if (null == m_LocalLBClass) { initializeInterface(m_LocalLBClass = new LocalLBClass()); } return m_LocalLBClass; } }
        public LocalLBContentPolicy LocalLBContentPolicy { get { verifyInitialized(); if (null == m_LocalLBContentPolicy) { initializeInterface(m_LocalLBContentPolicy = new LocalLBContentPolicy()); } return m_LocalLBContentPolicy; } }
        public LocalLBContentPolicyStrategy LocalLBContentPolicyStrategy { get { verifyInitialized(); if (null == m_LocalLBContentPolicyStrategy) { initializeInterface(m_LocalLBContentPolicyStrategy = new LocalLBContentPolicyStrategy()); } return m_LocalLBContentPolicyStrategy; } }
        public LocalLBDataGroupFile LocalLBDataGroupFile { get { verifyInitialized(); if (null == m_LocalLBDataGroupFile) { initializeInterface(m_LocalLBDataGroupFile = new LocalLBDataGroupFile()); } return m_LocalLBDataGroupFile; } }
        public LocalLBDNSCache LocalLBDNSCache { get { verifyInitialized(); if (null == m_LocalLBDNSCache) { initializeInterface(m_LocalLBDNSCache = new LocalLBDNSCache()); } return m_LocalLBDNSCache; } }
        public LocalLBDNSExpress LocalLBDNSExpress { get { verifyInitialized(); if (null == m_LocalLBDNSExpress) { initializeInterface(m_LocalLBDNSExpress = new LocalLBDNSExpress()); } return m_LocalLBDNSExpress; } }
        public LocalLBDNSGlobals LocalLBDNSGlobals { get { verifyInitialized(); if (null == m_LocalLBDNSGlobals) { initializeInterface(m_LocalLBDNSGlobals = new LocalLBDNSGlobals()); } return m_LocalLBDNSGlobals; } }
        public LocalLBDNSServer LocalLBDNSServer { get { verifyInitialized(); if (null == m_LocalLBDNSServer) { initializeInterface(m_LocalLBDNSServer = new LocalLBDNSServer()); } return m_LocalLBDNSServer; } }
        public LocalLBDNSTSIGKey LocalLBDNSTSIGKey { get { verifyInitialized(); if (null == m_LocalLBDNSTSIGKey) { initializeInterface(m_LocalLBDNSTSIGKey = new LocalLBDNSTSIGKey()); } return m_LocalLBDNSTSIGKey; } }
        public LocalLBDNSZone LocalLBDNSZone { get { verifyInitialized(); if (null == m_LocalLBDNSZone) { initializeInterface(m_LocalLBDNSZone = new LocalLBDNSZone()); } return m_LocalLBDNSZone; } }
        public LocalLBFlowEvictionPolicy LocalLBFlowEvictionPolicy { get { verifyInitialized(); if (null == m_LocalLBFlowEvictionPolicy) { initializeInterface(m_LocalLBFlowEvictionPolicy = new LocalLBFlowEvictionPolicy()); } return m_LocalLBFlowEvictionPolicy; } }
        public LocalLBiFile LocalLBiFile { get { verifyInitialized(); if (null == m_LocalLBiFile) { initializeInterface(m_LocalLBiFile = new LocalLBiFile()); } return m_LocalLBiFile; } }
        public LocalLBiFileFile LocalLBiFileFile { get { verifyInitialized(); if (null == m_LocalLBiFileFile) { initializeInterface(m_LocalLBiFileFile = new LocalLBiFileFile()); } return m_LocalLBiFileFile; } }
        public LocalLBLSNLogProfile LocalLBLSNLogProfile { get { verifyInitialized(); if (null == m_LocalLBLSNLogProfile) { initializeInterface(m_LocalLBLSNLogProfile = new LocalLBLSNLogProfile()); } return m_LocalLBLSNLogProfile; } }
        public LocalLBLSNPool LocalLBLSNPool { get { verifyInitialized(); if (null == m_LocalLBLSNPool) { initializeInterface(m_LocalLBLSNPool = new LocalLBLSNPool()); } return m_LocalLBLSNPool; } }
        public LocalLBMessageRoutingPeer LocalLBMessageRoutingPeer { get { verifyInitialized(); if (null == m_LocalLBMessageRoutingPeer) { initializeInterface(m_LocalLBMessageRoutingPeer = new LocalLBMessageRoutingPeer()); } return m_LocalLBMessageRoutingPeer; } }
        public LocalLBMessageRoutingSIPRoute LocalLBMessageRoutingSIPRoute { get { verifyInitialized(); if (null == m_LocalLBMessageRoutingSIPRoute) { initializeInterface(m_LocalLBMessageRoutingSIPRoute = new LocalLBMessageRoutingSIPRoute()); } return m_LocalLBMessageRoutingSIPRoute; } }
        public LocalLBMessageRoutingTransportConfig LocalLBMessageRoutingTransportConfig { get { verifyInitialized(); if (null == m_LocalLBMessageRoutingTransportConfig) { initializeInterface(m_LocalLBMessageRoutingTransportConfig = new LocalLBMessageRoutingTransportConfig()); } return m_LocalLBMessageRoutingTransportConfig; } }
        public LocalLBMonitor LocalLBMonitor { get { verifyInitialized(); if (null == m_LocalLBMonitor) { initializeInterface(m_LocalLBMonitor = new LocalLBMonitor()); } return m_LocalLBMonitor; } }
        public LocalLBNAT LocalLBNAT { get { verifyInitialized(); if (null == m_LocalLBNAT) { initializeInterface(m_LocalLBNAT = new LocalLBNAT()); } return m_LocalLBNAT; } }
        public LocalLBNATV2 LocalLBNATV2 { get { verifyInitialized(); if (null == m_LocalLBNATV2) { initializeInterface(m_LocalLBNATV2 = new LocalLBNATV2()); } return m_LocalLBNATV2; } }
        public LocalLBNodeAddress LocalLBNodeAddress { get { verifyInitialized(); if (null == m_LocalLBNodeAddress) { initializeInterface(m_LocalLBNodeAddress = new LocalLBNodeAddress()); } return m_LocalLBNodeAddress; } }
        public LocalLBNodeAddressV2 LocalLBNodeAddressV2 { get { verifyInitialized(); if (null == m_LocalLBNodeAddressV2) { initializeInterface(m_LocalLBNodeAddressV2 = new LocalLBNodeAddressV2()); } return m_LocalLBNodeAddressV2; } }
        public LocalLBOCSPStaplingParameters LocalLBOCSPStaplingParameters { get { verifyInitialized(); if (null == m_LocalLBOCSPStaplingParameters) { initializeInterface(m_LocalLBOCSPStaplingParameters = new LocalLBOCSPStaplingParameters()); } return m_LocalLBOCSPStaplingParameters; } }
        public LocalLBPool LocalLBPool { get { verifyInitialized(); if (null == m_LocalLBPool) { initializeInterface(m_LocalLBPool = new LocalLBPool()); } return m_LocalLBPool; } }
        public LocalLBPoolMember LocalLBPoolMember { get { verifyInitialized(); if (null == m_LocalLBPoolMember) { initializeInterface(m_LocalLBPoolMember = new LocalLBPoolMember()); } return m_LocalLBPoolMember; } }
        public LocalLBProfileAnalytics LocalLBProfileAnalytics { get { verifyInitialized(); if (null == m_LocalLBProfileAnalytics) { initializeInterface(m_LocalLBProfileAnalytics = new LocalLBProfileAnalytics()); } return m_LocalLBProfileAnalytics; } }
        public LocalLBProfileAuth LocalLBProfileAuth { get { verifyInitialized(); if (null == m_LocalLBProfileAuth) { initializeInterface(m_LocalLBProfileAuth = new LocalLBProfileAuth()); } return m_LocalLBProfileAuth; } }
        public LocalLBProfileClassification LocalLBProfileClassification { get { verifyInitialized(); if (null == m_LocalLBProfileClassification) { initializeInterface(m_LocalLBProfileClassification = new LocalLBProfileClassification()); } return m_LocalLBProfileClassification; } }
        public LocalLBProfileClientLDAP LocalLBProfileClientLDAP { get { verifyInitialized(); if (null == m_LocalLBProfileClientLDAP) { initializeInterface(m_LocalLBProfileClientLDAP = new LocalLBProfileClientLDAP()); } return m_LocalLBProfileClientLDAP; } }
        public LocalLBProfileClientSSL LocalLBProfileClientSSL { get { verifyInitialized(); if (null == m_LocalLBProfileClientSSL) { initializeInterface(m_LocalLBProfileClientSSL = new LocalLBProfileClientSSL()); } return m_LocalLBProfileClientSSL; } }
        public LocalLBProfileDiameter LocalLBProfileDiameter { get { verifyInitialized(); if (null == m_LocalLBProfileDiameter) { initializeInterface(m_LocalLBProfileDiameter = new LocalLBProfileDiameter()); } return m_LocalLBProfileDiameter; } }
        public LocalLBProfileDiameterEndpoint LocalLBProfileDiameterEndpoint { get { verifyInitialized(); if (null == m_LocalLBProfileDiameterEndpoint) { initializeInterface(m_LocalLBProfileDiameterEndpoint = new LocalLBProfileDiameterEndpoint()); } return m_LocalLBProfileDiameterEndpoint; } }
        public LocalLBProfileDiameterRouter LocalLBProfileDiameterRouter { get { verifyInitialized(); if (null == m_LocalLBProfileDiameterRouter) { initializeInterface(m_LocalLBProfileDiameterRouter = new LocalLBProfileDiameterRouter()); } return m_LocalLBProfileDiameterRouter; } }
        public LocalLBProfileDiameterSession LocalLBProfileDiameterSession { get { verifyInitialized(); if (null == m_LocalLBProfileDiameterSession) { initializeInterface(m_LocalLBProfileDiameterSession = new LocalLBProfileDiameterSession()); } return m_LocalLBProfileDiameterSession; } }
        public LocalLBProfileDNS LocalLBProfileDNS { get { verifyInitialized(); if (null == m_LocalLBProfileDNS) { initializeInterface(m_LocalLBProfileDNS = new LocalLBProfileDNS()); } return m_LocalLBProfileDNS; } }
        public LocalLBProfileDNSLogging LocalLBProfileDNSLogging { get { verifyInitialized(); if (null == m_LocalLBProfileDNSLogging) { initializeInterface(m_LocalLBProfileDNSLogging = new LocalLBProfileDNSLogging()); } return m_LocalLBProfileDNSLogging; } }
        public LocalLBProfileFastHttp LocalLBProfileFastHttp { get { verifyInitialized(); if (null == m_LocalLBProfileFastHttp) { initializeInterface(m_LocalLBProfileFastHttp = new LocalLBProfileFastHttp()); } return m_LocalLBProfileFastHttp; } }
        public LocalLBProfileFastL4 LocalLBProfileFastL4 { get { verifyInitialized(); if (null == m_LocalLBProfileFastL4) { initializeInterface(m_LocalLBProfileFastL4 = new LocalLBProfileFastL4()); } return m_LocalLBProfileFastL4; } }
        public LocalLBProfileFIX LocalLBProfileFIX { get { verifyInitialized(); if (null == m_LocalLBProfileFIX) { initializeInterface(m_LocalLBProfileFIX = new LocalLBProfileFIX()); } return m_LocalLBProfileFIX; } }
        public LocalLBProfileFTP LocalLBProfileFTP { get { verifyInitialized(); if (null == m_LocalLBProfileFTP) { initializeInterface(m_LocalLBProfileFTP = new LocalLBProfileFTP()); } return m_LocalLBProfileFTP; } }
        public LocalLBProfileHttp LocalLBProfileHttp { get { verifyInitialized(); if (null == m_LocalLBProfileHttp) { initializeInterface(m_LocalLBProfileHttp = new LocalLBProfileHttp()); } return m_LocalLBProfileHttp; } }
        public LocalLBProfileHttpClass LocalLBProfileHttpClass { get { verifyInitialized(); if (null == m_LocalLBProfileHttpClass) { initializeInterface(m_LocalLBProfileHttpClass = new LocalLBProfileHttpClass()); } return m_LocalLBProfileHttpClass; } }
        public LocalLBProfileHttpCompression LocalLBProfileHttpCompression { get { verifyInitialized(); if (null == m_LocalLBProfileHttpCompression) { initializeInterface(m_LocalLBProfileHttpCompression = new LocalLBProfileHttpCompression()); } return m_LocalLBProfileHttpCompression; } }
        public LocalLBProfileICAP LocalLBProfileICAP { get { verifyInitialized(); if (null == m_LocalLBProfileICAP) { initializeInterface(m_LocalLBProfileICAP = new LocalLBProfileICAP()); } return m_LocalLBProfileICAP; } }
        public LocalLBProfileIIOP LocalLBProfileIIOP { get { verifyInitialized(); if (null == m_LocalLBProfileIIOP) { initializeInterface(m_LocalLBProfileIIOP = new LocalLBProfileIIOP()); } return m_LocalLBProfileIIOP; } }
        public LocalLBProfileIPsecALG LocalLBProfileIPsecALG { get { verifyInitialized(); if (null == m_LocalLBProfileIPsecALG) { initializeInterface(m_LocalLBProfileIPsecALG = new LocalLBProfileIPsecALG()); } return m_LocalLBProfileIPsecALG; } }
        public LocalLBProfileOneConnect LocalLBProfileOneConnect { get { verifyInitialized(); if (null == m_LocalLBProfileOneConnect) { initializeInterface(m_LocalLBProfileOneConnect = new LocalLBProfileOneConnect()); } return m_LocalLBProfileOneConnect; } }
        public LocalLBProfilePCP LocalLBProfilePCP { get { verifyInitialized(); if (null == m_LocalLBProfilePCP) { initializeInterface(m_LocalLBProfilePCP = new LocalLBProfilePCP()); } return m_LocalLBProfilePCP; } }
        public LocalLBProfilePersistence LocalLBProfilePersistence { get { verifyInitialized(); if (null == m_LocalLBProfilePersistence) { initializeInterface(m_LocalLBProfilePersistence = new LocalLBProfilePersistence()); } return m_LocalLBProfilePersistence; } }
        public LocalLBProfilePPTP LocalLBProfilePPTP { get { verifyInitialized(); if (null == m_LocalLBProfilePPTP) { initializeInterface(m_LocalLBProfilePPTP = new LocalLBProfilePPTP()); } return m_LocalLBProfilePPTP; } }
        public LocalLBProfileRADIUS LocalLBProfileRADIUS { get { verifyInitialized(); if (null == m_LocalLBProfileRADIUS) { initializeInterface(m_LocalLBProfileRADIUS = new LocalLBProfileRADIUS()); } return m_LocalLBProfileRADIUS; } }
        public LocalLBProfileRequestAdapt LocalLBProfileRequestAdapt { get { verifyInitialized(); if (null == m_LocalLBProfileRequestAdapt) { initializeInterface(m_LocalLBProfileRequestAdapt = new LocalLBProfileRequestAdapt()); } return m_LocalLBProfileRequestAdapt; } }
        public LocalLBProfileRequestLogging LocalLBProfileRequestLogging { get { verifyInitialized(); if (null == m_LocalLBProfileRequestLogging) { initializeInterface(m_LocalLBProfileRequestLogging = new LocalLBProfileRequestLogging()); } return m_LocalLBProfileRequestLogging; } }
        public LocalLBProfileResponseAdapt LocalLBProfileResponseAdapt { get { verifyInitialized(); if (null == m_LocalLBProfileResponseAdapt) { initializeInterface(m_LocalLBProfileResponseAdapt = new LocalLBProfileResponseAdapt()); } return m_LocalLBProfileResponseAdapt; } }
        public LocalLBProfileRTSP LocalLBProfileRTSP { get { verifyInitialized(); if (null == m_LocalLBProfileRTSP) { initializeInterface(m_LocalLBProfileRTSP = new LocalLBProfileRTSP()); } return m_LocalLBProfileRTSP; } }
        public LocalLBProfileSCTP LocalLBProfileSCTP { get { verifyInitialized(); if (null == m_LocalLBProfileSCTP) { initializeInterface(m_LocalLBProfileSCTP = new LocalLBProfileSCTP()); } return m_LocalLBProfileSCTP; } }
        public LocalLBProfileServerLDAP LocalLBProfileServerLDAP { get { verifyInitialized(); if (null == m_LocalLBProfileServerLDAP) { initializeInterface(m_LocalLBProfileServerLDAP = new LocalLBProfileServerLDAP()); } return m_LocalLBProfileServerLDAP; } }
        public LocalLBProfileServerSSL LocalLBProfileServerSSL { get { verifyInitialized(); if (null == m_LocalLBProfileServerSSL) { initializeInterface(m_LocalLBProfileServerSSL = new LocalLBProfileServerSSL()); } return m_LocalLBProfileServerSSL; } }
        public LocalLBProfileSIP LocalLBProfileSIP { get { verifyInitialized(); if (null == m_LocalLBProfileSIP) { initializeInterface(m_LocalLBProfileSIP = new LocalLBProfileSIP()); } return m_LocalLBProfileSIP; } }
        public LocalLBProfileSIPRouter LocalLBProfileSIPRouter { get { verifyInitialized(); if (null == m_LocalLBProfileSIPRouter) { initializeInterface(m_LocalLBProfileSIPRouter = new LocalLBProfileSIPRouter()); } return m_LocalLBProfileSIPRouter; } }
        public LocalLBProfileSIPSession LocalLBProfileSIPSession { get { verifyInitialized(); if (null == m_LocalLBProfileSIPSession) { initializeInterface(m_LocalLBProfileSIPSession = new LocalLBProfileSIPSession()); } return m_LocalLBProfileSIPSession; } }
        public LocalLBProfileSMTPS LocalLBProfileSMTPS { get { verifyInitialized(); if (null == m_LocalLBProfileSMTPS) { initializeInterface(m_LocalLBProfileSMTPS = new LocalLBProfileSMTPS()); } return m_LocalLBProfileSMTPS; } }
        public LocalLBProfileSPDY LocalLBProfileSPDY { get { verifyInitialized(); if (null == m_LocalLBProfileSPDY) { initializeInterface(m_LocalLBProfileSPDY = new LocalLBProfileSPDY()); } return m_LocalLBProfileSPDY; } }
        public LocalLBProfileSPM LocalLBProfileSPM { get { verifyInitialized(); if (null == m_LocalLBProfileSPM) { initializeInterface(m_LocalLBProfileSPM = new LocalLBProfileSPM()); } return m_LocalLBProfileSPM; } }
        public LocalLBProfileStream LocalLBProfileStream { get { verifyInitialized(); if (null == m_LocalLBProfileStream) { initializeInterface(m_LocalLBProfileStream = new LocalLBProfileStream()); } return m_LocalLBProfileStream; } }
        public LocalLBProfileTCP LocalLBProfileTCP { get { verifyInitialized(); if (null == m_LocalLBProfileTCP) { initializeInterface(m_LocalLBProfileTCP = new LocalLBProfileTCP()); } return m_LocalLBProfileTCP; } }
        public LocalLBProfileTCPAnalytics LocalLBProfileTCPAnalytics { get { verifyInitialized(); if (null == m_LocalLBProfileTCPAnalytics) { initializeInterface(m_LocalLBProfileTCPAnalytics = new LocalLBProfileTCPAnalytics()); } return m_LocalLBProfileTCPAnalytics; } }
        public LocalLBProfileTFTP LocalLBProfileTFTP { get { verifyInitialized(); if (null == m_LocalLBProfileTFTP) { initializeInterface(m_LocalLBProfileTFTP = new LocalLBProfileTFTP()); } return m_LocalLBProfileTFTP; } }
        public LocalLBProfileTrafficAcceleration LocalLBProfileTrafficAcceleration { get { verifyInitialized(); if (null == m_LocalLBProfileTrafficAcceleration) { initializeInterface(m_LocalLBProfileTrafficAcceleration = new LocalLBProfileTrafficAcceleration()); } return m_LocalLBProfileTrafficAcceleration; } }

        public LocalLBProfileUDP LocalLBProfileUDP { get { verifyInitialized(); if (null == m_LocalLBProfileUDP) { initializeInterface(m_LocalLBProfileUDP = new LocalLBProfileUDP()); } return m_LocalLBProfileUDP; } }
        public LocalLBProfileUserStatistic LocalLBProfileUserStatistic { get { verifyInitialized(); if (null == m_LocalLBProfileUserStatistic) { initializeInterface(m_LocalLBProfileUserStatistic = new LocalLBProfileUserStatistic()); } return m_LocalLBProfileUserStatistic; } }
        public LocalLBProfileWebAcceleration LocalLBProfileWebAcceleration { get { verifyInitialized(); if (null == m_LocalLBProfileWebAcceleration) { initializeInterface(m_LocalLBProfileWebAcceleration = new LocalLBProfileWebAcceleration()); } return m_LocalLBProfileWebAcceleration; } }
        public LocalLBProfileXML LocalLBProfileXML { get { verifyInitialized(); if (null == m_LocalLBProfileXML) { initializeInterface(m_LocalLBProfileXML = new LocalLBProfileXML()); } return m_LocalLBProfileXML; } }
        public LocalLBRAMCacheInformation LocalLBRAMCacheInformation { get { verifyInitialized(); if (null == m_LocalLBRAMCacheInformation) { initializeInterface(m_LocalLBRAMCacheInformation = new LocalLBRAMCacheInformation()); } return m_LocalLBRAMCacheInformation; } }
        public LocalLBRateClass LocalLBRateClass { get { verifyInitialized(); if (null == m_LocalLBRateClass) { initializeInterface(m_LocalLBRateClass = new LocalLBRateClass()); } return m_LocalLBRateClass; } }
        public LocalLBRule LocalLBRule { get { verifyInitialized(); if (null == m_LocalLBRule) { initializeInterface(m_LocalLBRule = new LocalLBRule()); } return m_LocalLBRule; } }
        public LocalLBSNAT LocalLBSNAT { get { verifyInitialized(); if (null == m_LocalLBSNAT) { initializeInterface(m_LocalLBSNAT = new LocalLBSNAT()); } return m_LocalLBSNAT; } }
        public LocalLBSNATPool LocalLBSNATPool { get { verifyInitialized(); if (null == m_LocalLBSNATPool) { initializeInterface(m_LocalLBSNATPool = new LocalLBSNATPool()); } return m_LocalLBSNATPool; } }
        public LocalLBSNATPoolMember LocalLBSNATPoolMember { get { verifyInitialized(); if (null == m_LocalLBSNATPoolMember) { initializeInterface(m_LocalLBSNATPoolMember = new LocalLBSNATPoolMember()); } return m_LocalLBSNATPoolMember; } }
        public LocalLBSNATTranslationAddress LocalLBSNATTranslationAddress { get { verifyInitialized(); if (null == m_LocalLBSNATTranslationAddress) { initializeInterface(m_LocalLBSNATTranslationAddress = new LocalLBSNATTranslationAddress()); } return m_LocalLBSNATTranslationAddress; } }
        public LocalLBSNATTranslationAddressV2 LocalLBSNATTranslationAddressV2 { get { verifyInitialized(); if (null == m_LocalLBSNATTranslationAddressV2) { initializeInterface(m_LocalLBSNATTranslationAddressV2 = new LocalLBSNATTranslationAddressV2()); } return m_LocalLBSNATTranslationAddressV2; } }
        public LocalLBVirtualAddress LocalLBVirtualAddress { get { verifyInitialized(); if (null == m_LocalLBVirtualAddress) { initializeInterface(m_LocalLBVirtualAddress = new LocalLBVirtualAddress()); } return m_LocalLBVirtualAddress; } }
        public LocalLBVirtualAddressV2 LocalLBVirtualAddressV2 { get { verifyInitialized(); if (null == m_LocalLBVirtualAddressV2) { initializeInterface(m_LocalLBVirtualAddressV2 = new LocalLBVirtualAddressV2()); } return m_LocalLBVirtualAddressV2; } }
        public LocalLBVirtualServer LocalLBVirtualServer { get { verifyInitialized(); if (null == m_LocalLBVirtualServer) { initializeInterface(m_LocalLBVirtualServer = new LocalLBVirtualServer()); } return m_LocalLBVirtualServer; } }

        public LogDestinationArcSight LogDestinationArcSight { get { verifyInitialized(); if (null == m_LogDestinationArcSight) { initializeInterface(m_LogDestinationArcSight = new LogDestinationArcSight()); } return m_LogDestinationArcSight; } }
        public LogDestinationIPFIX LogDestinationIPFIX { get { verifyInitialized(); if (null == m_LogDestinationIPFIX) { initializeInterface(m_LogDestinationIPFIX = new LogDestinationIPFIX()); } return m_LogDestinationIPFIX; } }
        public LogDestinationLocalSyslog LogDestinationLocalSyslog { get { verifyInitialized(); if (null == m_LogDestinationLocalSyslog) { initializeInterface(m_LogDestinationLocalSyslog = new LogDestinationLocalSyslog()); } return m_LogDestinationLocalSyslog; } }
        public LogDestinationManagementPort LogDestinationManagementPort { get { verifyInitialized(); if (null == m_LogDestinationManagementPort) { initializeInterface(m_LogDestinationManagementPort = new LogDestinationManagementPort()); } return m_LogDestinationManagementPort; } }
        public LogDestinationRemoteHighSpeedLog LogDestinationRemoteHighSpeedLog { get { verifyInitialized(); if (null == m_LogDestinationRemoteHighSpeedLog) { initializeInterface(m_LogDestinationRemoteHighSpeedLog = new LogDestinationRemoteHighSpeedLog()); } return m_LogDestinationRemoteHighSpeedLog; } }
        public LogDestinationRemoteSyslog LogDestinationRemoteSyslog { get { verifyInitialized(); if (null == m_LogDestinationRemoteSyslog) { initializeInterface(m_LogDestinationRemoteSyslog = new LogDestinationRemoteSyslog()); } return m_LogDestinationRemoteSyslog; } }
        public LogDestinationSplunk LogDestinationSplunk { get { verifyInitialized(); if (null == m_LogDestinationSplunk) { initializeInterface(m_LogDestinationSplunk = new LogDestinationSplunk()); } return m_LogDestinationSplunk; } }
        public LogFilter LogFilter { get { verifyInitialized(); if (null == m_LogFilter) { initializeInterface(m_LogFilter = new LogFilter()); } return m_LogFilter; } }
        public LogIPFIXInformationElement LogIPFIXInformationElement { get { verifyInitialized(); if (null == m_LogIPFIXInformationElement) { initializeInterface(m_LogIPFIXInformationElement = new LogIPFIXInformationElement()); } return m_LogIPFIXInformationElement; } }
        public LogPublisher LogPublisher { get { verifyInitialized(); if (null == m_LogPublisher) { initializeInterface(m_LogPublisher = new LogPublisher()); } return m_LogPublisher; } }

        public LTConfigClass LTConfigClass { get { verifyInitialized(); if (null == m_LTConfigClass) { initializeInterface(m_LTConfigClass = new LTConfigClass()); } return m_LTConfigClass; } }
        public LTConfigField LTConfigField { get { verifyInitialized(); if (null == m_LTConfigField) { initializeInterface(m_LTConfigField = new LTConfigField()); } return m_LTConfigField; } }

        public ManagementApplicationPresentationScript ManagementApplicationPresentationScript { get { verifyInitialized(); if (null == m_ManagementApplicationPresentationScript) { initializeInterface(m_ManagementApplicationPresentationScript = new ManagementApplicationPresentationScript()); } return m_ManagementApplicationPresentationScript; } }
        public ManagementApplicationService ManagementApplicationService { get { verifyInitialized(); if (null == m_ManagementApplicationService) { initializeInterface(m_ManagementApplicationService = new ManagementApplicationService()); } return m_ManagementApplicationService; } }
        public ManagementApplicationTemplate ManagementApplicationTemplate { get { verifyInitialized(); if (null == m_ManagementApplicationTemplate) { initializeInterface(m_ManagementApplicationTemplate = new ManagementApplicationTemplate()); } return m_ManagementApplicationTemplate; } }
        public ManagementCCLDAPConfiguration ManagementCCLDAPConfiguration { get { verifyInitialized(); if (null == m_ManagementCCLDAPConfiguration) { initializeInterface(m_ManagementCCLDAPConfiguration = new ManagementCCLDAPConfiguration()); } return m_ManagementCCLDAPConfiguration; } }
        public ManagementCertLDAPConfiguration ManagementCertLDAPConfiguration { get { verifyInitialized(); if (null == m_ManagementCertLDAPConfiguration) { initializeInterface(m_ManagementCertLDAPConfiguration = new ManagementCertLDAPConfiguration()); } return m_ManagementCertLDAPConfiguration; } }
        public ManagementCertificateValidatorOCSP ManagementCertificateValidatorOCSP { get { verifyInitialized(); if (null == m_ManagementCertificateValidatorOCSP) { initializeInterface(m_ManagementCertificateValidatorOCSP = new ManagementCertificateValidatorOCSP()); } return m_ManagementCertificateValidatorOCSP; } }
        public ManagementChangeControl ManagementChangeControl { get { verifyInitialized(); if (null == m_ManagementChangeControl) { initializeInterface(m_ManagementChangeControl = new ManagementChangeControl()); } return m_ManagementChangeControl; } }
        public ManagementCLIScript ManagementCLIScript { get { verifyInitialized(); if (null == m_ManagementCLIScript) { initializeInterface(m_ManagementCLIScript = new ManagementCLIScript()); } return m_ManagementCLIScript; } }
        public ManagementCRLDPConfiguration ManagementCRLDPConfiguration { get { verifyInitialized(); if (null == m_ManagementCRLDPConfiguration) { initializeInterface(m_ManagementCRLDPConfiguration = new ManagementCRLDPConfiguration()); } return m_ManagementCRLDPConfiguration; } }
        public ManagementCRLDPServer ManagementCRLDPServer { get { verifyInitialized(); if (null == m_ManagementCRLDPServer) { initializeInterface(m_ManagementCRLDPServer = new ManagementCRLDPServer()); } return m_ManagementCRLDPServer; } }
        public ManagementDBVariable ManagementDBVariable { get { verifyInitialized(); if (null == m_ManagementDBVariable) { initializeInterface(m_ManagementDBVariable = new ManagementDBVariable()); } return m_ManagementDBVariable; } }
        public ManagementDevice ManagementDevice { get { verifyInitialized(); if (null == m_ManagementDevice) { initializeInterface(m_ManagementDevice = new ManagementDevice()); } return m_ManagementDevice; } }
        public ManagementDeviceGroup ManagementDeviceGroup { get { verifyInitialized(); if (null == m_ManagementDeviceGroup) { initializeInterface(m_ManagementDeviceGroup = new ManagementDeviceGroup()); } return m_ManagementDeviceGroup; } }
        public ManagementEM ManagementEM { get { verifyInitialized(); if (null == m_ManagementEM) { initializeInterface(m_ManagementEM = new ManagementEM()); } return m_ManagementEM; } }
        public ManagementEventNotification ManagementEventNotification { get { verifyInitialized(); if (null == m_ManagementEventNotification) { initializeInterface(m_ManagementEventNotification = new ManagementEventNotification()); } return m_ManagementEventNotification; } }
        public ManagementEventSubscription ManagementEventSubscription { get { verifyInitialized(); if (null == m_ManagementEventSubscription) { initializeInterface(m_ManagementEventSubscription = new ManagementEventSubscription()); } return m_ManagementEventSubscription; } }
        public ManagementFeatureModule ManagementFeatureModule { get { verifyInitialized(); if (null == m_ManagementFeatureModule) { initializeInterface(m_ManagementFeatureModule = new ManagementFeatureModule()); } return m_ManagementFeatureModule; } }
        public ManagementFolder ManagementFolder { get { verifyInitialized(); if (null == m_ManagementFolder) { initializeInterface(m_ManagementFolder = new ManagementFolder()); } return m_ManagementFolder; } }
        public ManagementGlobals ManagementGlobals { get { verifyInitialized(); if (null == m_ManagementGlobals) { initializeInterface(m_ManagementGlobals = new ManagementGlobals()); } return m_ManagementGlobals; } }
        public ManagementKeyCertificate ManagementKeyCertificate { get { verifyInitialized(); if (null == m_ManagementKeyCertificate) { initializeInterface(m_ManagementKeyCertificate = new ManagementKeyCertificate()); } return m_ManagementKeyCertificate; } }
        public ManagementLDAPConfiguration ManagementLDAPConfiguration { get { verifyInitialized(); if (null == m_ManagementLDAPConfiguration) { initializeInterface(m_ManagementLDAPConfiguration = new ManagementLDAPConfiguration()); } return m_ManagementLDAPConfiguration; } }
        public ManagementLicenseAdministration ManagementLicenseAdministration { get { verifyInitialized(); if (null == m_ManagementLicenseAdministration) { initializeInterface(m_ManagementLicenseAdministration = new ManagementLicenseAdministration()); } return m_ManagementLicenseAdministration; } }
        public ManagementNamed ManagementNamed { get { verifyInitialized(); if (null == m_ManagementNamed) { initializeInterface(m_ManagementNamed = new ManagementNamed()); } return m_ManagementNamed; } }
        public ManagementOCSPConfiguration ManagementOCSPConfiguration { get { verifyInitialized(); if (null == m_ManagementOCSPConfiguration) { initializeInterface(m_ManagementOCSPConfiguration = new ManagementOCSPConfiguration()); } return m_ManagementOCSPConfiguration; } }
        public ManagementOCSPResponder ManagementOCSPResponder { get { verifyInitialized(); if (null == m_ManagementOCSPResponder) { initializeInterface(m_ManagementOCSPResponder = new ManagementOCSPResponder()); } return m_ManagementOCSPResponder; } }
        public ManagementPartition ManagementPartition { get { verifyInitialized(); if (null == m_ManagementPartition) { initializeInterface(m_ManagementPartition = new ManagementPartition()); } return m_ManagementPartition; } }
        public ManagementProvision ManagementProvision { get { verifyInitialized(); if (null == m_ManagementProvision) { initializeInterface(m_ManagementProvision = new ManagementProvision()); } return m_ManagementProvision; } }
        public ManagementRADIUSConfiguration ManagementRADIUSConfiguration { get { verifyInitialized(); if (null == m_ManagementRADIUSConfiguration) { initializeInterface(m_ManagementRADIUSConfiguration = new ManagementRADIUSConfiguration()); } return m_ManagementRADIUSConfiguration; } }
        public ManagementRADIUSServer ManagementRADIUSServer { get { verifyInitialized(); if (null == m_ManagementRADIUSServer) { initializeInterface(m_ManagementRADIUSServer = new ManagementRADIUSServer()); } return m_ManagementRADIUSServer; } }
        public ManagementResourceRecord ManagementResourceRecord { get { verifyInitialized(); if (null == m_ManagementResourceRecord) { initializeInterface(m_ManagementResourceRecord = new ManagementResourceRecord()); } return m_ManagementResourceRecord; } }
        public ManagementSFlowDataSource ManagementSFlowDataSource { get { verifyInitialized(); if (null == m_ManagementSFlowDataSource) { initializeInterface(m_ManagementSFlowDataSource = new ManagementSFlowDataSource()); } return m_ManagementSFlowDataSource; } }
        public ManagementSFlowGlobals ManagementSFlowGlobals { get { verifyInitialized(); if (null == m_ManagementSFlowGlobals) { initializeInterface(m_ManagementSFlowGlobals = new ManagementSFlowGlobals()); } return m_ManagementSFlowGlobals; } }
        public ManagementSFlowReceiver ManagementSFlowReceiver { get { verifyInitialized(); if (null == m_ManagementSFlowReceiver) { initializeInterface(m_ManagementSFlowReceiver = new ManagementSFlowReceiver()); } return m_ManagementSFlowReceiver; } }
        public ManagementSMTPConfiguration ManagementSMTPConfiguration { get { verifyInitialized(); if (null == m_ManagementSMTPConfiguration) { initializeInterface(m_ManagementSMTPConfiguration = new ManagementSMTPConfiguration()); } return m_ManagementSMTPConfiguration; } }
        public ManagementSNMPConfiguration ManagementSNMPConfiguration { get { verifyInitialized(); if (null == m_ManagementSNMPConfiguration) { initializeInterface(m_ManagementSNMPConfiguration = new ManagementSNMPConfiguration()); } return m_ManagementSNMPConfiguration; } }
        public ManagementTACACSConfiguration ManagementTACACSConfiguration { get { verifyInitialized(); if (null == m_ManagementTACACSConfiguration) { initializeInterface(m_ManagementTACACSConfiguration = new ManagementTACACSConfiguration()); } return m_ManagementTACACSConfiguration; } }
        public ManagementTMOSModule ManagementTMOSModule { get { verifyInitialized(); if (null == m_ManagementTMOSModule) { initializeInterface(m_ManagementTMOSModule = new ManagementTMOSModule()); } return m_ManagementTMOSModule; } }
        public ManagementTrafficGroup ManagementTrafficGroup { get { verifyInitialized(); if (null == m_ManagementTrafficGroup) { initializeInterface(m_ManagementTrafficGroup = new ManagementTrafficGroup()); } return m_ManagementTrafficGroup; } }
        public ManagementTrust ManagementTrust { get { verifyInitialized(); if (null == m_ManagementTrust) { initializeInterface(m_ManagementTrust = new ManagementTrust()); } return m_ManagementTrust; } }
        public ManagementUserManagement ManagementUserManagement { get { verifyInitialized(); if (null == m_ManagementUserManagement) { initializeInterface(m_ManagementUserManagement = new ManagementUserManagement()); } return m_ManagementUserManagement; } }
        public ManagementView ManagementView { get { verifyInitialized(); if (null == m_ManagementView) { initializeInterface(m_ManagementView = new ManagementView()); } return m_ManagementView; } }
        public ManagementZone ManagementZone { get { verifyInitialized(); if (null == m_ManagementZone) { initializeInterface(m_ManagementZone = new ManagementZone()); } return m_ManagementZone; } }
        public ManagementZoneRunner ManagementZoneRunner { get { verifyInitialized(); if (null == m_ManagementZoneRunner) { initializeInterface(m_ManagementZoneRunner = new ManagementZoneRunner()); } return m_ManagementZoneRunner; } }

        public NetworkingAdminIP NetworkingAdminIP { get { verifyInitialized(); if (null == m_NetworkingAdminIP) { initializeInterface(m_NetworkingAdminIP = new NetworkingAdminIP()); } return m_NetworkingAdminIP; } }
        public NetworkingARP NetworkingARP { get { verifyInitialized(); if (null == m_NetworkingARP) { initializeInterface(m_NetworkingARP = new NetworkingARP()); } return m_NetworkingARP; } }
        public NetworkingBWControllerPolicy NetworkingBWControllerPolicy { get { verifyInitialized(); if (null == m_NetworkingBWControllerPolicy) { initializeInterface(m_NetworkingBWControllerPolicy = new NetworkingBWControllerPolicy()); } return m_NetworkingBWControllerPolicy; } }
        public NetworkingBWPriorityGroup NetworkingBWPriorityGroup { get { verifyInitialized(); if (null == m_NetworkingBWPriorityGroup) { initializeInterface(m_NetworkingBWPriorityGroup = new NetworkingBWPriorityGroup()); } return m_NetworkingBWPriorityGroup; } }
        public NetworkingDNSResolver NetworkingDNSResolver { get { verifyInitialized(); if (null == m_NetworkingDNSResolver) { initializeInterface(m_NetworkingDNSResolver = new NetworkingDNSResolver()); } return m_NetworkingDNSResolver; } }
        public NetworkingInterfaces NetworkingInterfaces { get { verifyInitialized(); if (null == m_NetworkingInterfaces) { initializeInterface(m_NetworkingInterfaces = new NetworkingInterfaces()); } return m_NetworkingInterfaces; } }
        public NetworkingIPsecIkeDaemon NetworkingIPsecIkeDaemon { get { verifyInitialized(); if (null == m_NetworkingIPsecIkeDaemon) { initializeInterface(m_NetworkingIPsecIkeDaemon = new NetworkingIPsecIkeDaemon()); } return m_NetworkingIPsecIkeDaemon; } }
        public NetworkingIPsecIkePeer NetworkingIPsecIkePeer { get { verifyInitialized(); if (null == m_NetworkingIPsecIkePeer) { initializeInterface(m_NetworkingIPsecIkePeer = new NetworkingIPsecIkePeer()); } return m_NetworkingIPsecIkePeer; } }
        public NetworkingIPsecManualSecurityAssociation NetworkingIPsecManualSecurityAssociation { get { verifyInitialized(); if (null == m_NetworkingIPsecManualSecurityAssociation) { initializeInterface(m_NetworkingIPsecManualSecurityAssociation = new NetworkingIPsecManualSecurityAssociation()); } return m_NetworkingIPsecManualSecurityAssociation; } }
        public NetworkingIPsecPolicy NetworkingIPsecPolicy { get { verifyInitialized(); if (null == m_NetworkingIPsecPolicy) { initializeInterface(m_NetworkingIPsecPolicy = new NetworkingIPsecPolicy()); } return m_NetworkingIPsecPolicy; } }
        public NetworkingIPsecTrafficSelector NetworkingIPsecTrafficSelector { get { verifyInitialized(); if (null == m_NetworkingIPsecTrafficSelector) { initializeInterface(m_NetworkingIPsecTrafficSelector = new NetworkingIPsecTrafficSelector()); } return m_NetworkingIPsecTrafficSelector; } }
        public NetworkingiSessionAdvertisedRoute NetworkingiSessionAdvertisedRoute { get { verifyInitialized(); if (null == m_NetworkingiSessionAdvertisedRoute) { initializeInterface(m_NetworkingiSessionAdvertisedRoute = new NetworkingiSessionAdvertisedRoute()); } return m_NetworkingiSessionAdvertisedRoute; } }
        public NetworkingiSessionAdvertisedRouteV2 NetworkingiSessionAdvertisedRouteV2 { get { verifyInitialized(); if (null == m_NetworkingiSessionAdvertisedRouteV2) { initializeInterface(m_NetworkingiSessionAdvertisedRouteV2 = new NetworkingiSessionAdvertisedRouteV2()); } return m_NetworkingiSessionAdvertisedRouteV2; } }
        public NetworkingiSessionDatastor NetworkingiSessionDatastor { get { verifyInitialized(); if (null == m_NetworkingiSessionDatastor) { initializeInterface(m_NetworkingiSessionDatastor = new NetworkingiSessionDatastor()); } return m_NetworkingiSessionDatastor; } }
        public NetworkingiSessionDeduplication NetworkingiSessionDeduplication { get { verifyInitialized(); if (null == m_NetworkingiSessionDeduplication) { initializeInterface(m_NetworkingiSessionDeduplication = new NetworkingiSessionDeduplication()); } return m_NetworkingiSessionDeduplication; } }
        public NetworkingiSessionLocalInterface NetworkingiSessionLocalInterface { get { verifyInitialized(); if (null == m_NetworkingiSessionLocalInterface) { initializeInterface(m_NetworkingiSessionLocalInterface = new NetworkingiSessionLocalInterface()); } return m_NetworkingiSessionLocalInterface; } }
        public NetworkingiSessionPeerDiscovery NetworkingiSessionPeerDiscovery { get { verifyInitialized(); if (null == m_NetworkingiSessionPeerDiscovery) { initializeInterface(m_NetworkingiSessionPeerDiscovery = new NetworkingiSessionPeerDiscovery()); } return m_NetworkingiSessionPeerDiscovery; } }
        public NetworkingiSessionRemoteInterface NetworkingiSessionRemoteInterface { get { verifyInitialized(); if (null == m_NetworkingiSessionRemoteInterface) { initializeInterface(m_NetworkingiSessionRemoteInterface = new NetworkingiSessionRemoteInterface()); } return m_NetworkingiSessionRemoteInterface; } }
        public NetworkingiSessionRemoteInterfaceV2 NetworkingiSessionRemoteInterfaceV2 { get { verifyInitialized(); if (null == m_NetworkingiSessionRemoteInterfaceV2) { initializeInterface(m_NetworkingiSessionRemoteInterfaceV2 = new NetworkingiSessionRemoteInterfaceV2()); } return m_NetworkingiSessionRemoteInterfaceV2; } }
        public NetworkingLLDPGlobals NetworkingLLDPGlobals { get { verifyInitialized(); if (null == m_NetworkingLLDPGlobals) { initializeInterface(m_NetworkingLLDPGlobals = new NetworkingLLDPGlobals()); } return m_NetworkingLLDPGlobals; } }
        public NetworkingMulticastRoute NetworkingMulticastRoute { get { verifyInitialized(); if (null == m_NetworkingMulticastRoute) { initializeInterface(m_NetworkingMulticastRoute = new NetworkingMulticastRoute()); } return m_NetworkingMulticastRoute; } }
        public NetworkingPacketFilter NetworkingPacketFilter { get { verifyInitialized(); if (null == m_NetworkingPacketFilter) { initializeInterface(m_NetworkingPacketFilter = new NetworkingPacketFilter()); } return m_NetworkingPacketFilter; } }
        public NetworkingPacketFilterGlobals NetworkingPacketFilterGlobals { get { verifyInitialized(); if (null == m_NetworkingPacketFilterGlobals) { initializeInterface(m_NetworkingPacketFilterGlobals = new NetworkingPacketFilterGlobals()); } return m_NetworkingPacketFilterGlobals; } }
        public NetworkingPortMirror NetworkingPortMirror { get { verifyInitialized(); if (null == m_NetworkingPortMirror) { initializeInterface(m_NetworkingPortMirror = new NetworkingPortMirror()); } return m_NetworkingPortMirror; } }
        public NetworkingProfileFEC NetworkingProfileFEC { get { verifyInitialized(); if (null == m_NetworkingProfileFEC) { initializeInterface(m_NetworkingProfileFEC = new NetworkingProfileFEC()); } return m_NetworkingProfileFEC; } }
        public NetworkingProfileGeneve NetworkingProfileGeneve { get { verifyInitialized(); if (null == m_NetworkingProfileGeneve) { initializeInterface(m_NetworkingProfileGeneve = new NetworkingProfileGeneve()); } return m_NetworkingProfileGeneve; } }
        public NetworkingProfileGRE NetworkingProfileGRE { get { verifyInitialized(); if (null == m_NetworkingProfileGRE) { initializeInterface(m_NetworkingProfileGRE = new NetworkingProfileGRE()); } return m_NetworkingProfileGRE; } }
        public NetworkingProfileIPIP NetworkingProfileIPIP { get { verifyInitialized(); if (null == m_NetworkingProfileIPIP) { initializeInterface(m_NetworkingProfileIPIP = new NetworkingProfileIPIP()); } return m_NetworkingProfileIPIP; } }
        public NetworkingProfileIPsec NetworkingProfileIPsec { get { verifyInitialized(); if (null == m_NetworkingProfileIPsec) { initializeInterface(m_NetworkingProfileIPsec = new NetworkingProfileIPsec()); } return m_NetworkingProfileIPsec; } }
        public NetworkingProfileLightweight4Over6Tunnel NetworkingProfileLightweight4Over6Tunnel { get { verifyInitialized(); if (null == m_NetworkingProfileLightweight4Over6Tunnel) { initializeInterface(m_NetworkingProfileLightweight4Over6Tunnel = new NetworkingProfileLightweight4Over6Tunnel()); } return m_NetworkingProfileLightweight4Over6Tunnel; } }
        public NetworkingProfileMAP NetworkingProfileMAP { get { verifyInitialized(); if (null == m_NetworkingProfileMAP) { initializeInterface(m_NetworkingProfileMAP = new NetworkingProfileMAP()); } return m_NetworkingProfileMAP; } }
        public NetworkingProfileV6RD NetworkingProfileV6RD { get { verifyInitialized(); if (null == m_NetworkingProfileV6RD) { initializeInterface(m_NetworkingProfileV6RD = new NetworkingProfileV6RD()); } return m_NetworkingProfileV6RD; } }
        public NetworkingProfileVXLAN NetworkingProfileVXLAN { get { verifyInitialized(); if (null == m_NetworkingProfileVXLAN) { initializeInterface(m_NetworkingProfileVXLAN = new NetworkingProfileVXLAN()); } return m_NetworkingProfileVXLAN; } }
        public NetworkingProfileWCCPGRE NetworkingProfileWCCPGRE { get { verifyInitialized(); if (null == m_NetworkingProfileWCCPGRE) { initializeInterface(m_NetworkingProfileWCCPGRE = new NetworkingProfileWCCPGRE()); } return m_NetworkingProfileWCCPGRE; } }
        public NetworkingRouteDomain NetworkingRouteDomain { get { verifyInitialized(); if (null == m_NetworkingRouteDomain) { initializeInterface(m_NetworkingRouteDomain = new NetworkingRouteDomain()); } return m_NetworkingRouteDomain; } }
        public NetworkingRouteDomainV2 NetworkingRouteDomainV2 { get { verifyInitialized(); if (null == m_NetworkingRouteDomainV2) { initializeInterface(m_NetworkingRouteDomainV2 = new NetworkingRouteDomainV2()); } return m_NetworkingRouteDomainV2; } }
        public NetworkingRouterAdvertisement NetworkingRouterAdvertisement { get { verifyInitialized(); if (null == m_NetworkingRouterAdvertisement) { initializeInterface(m_NetworkingRouterAdvertisement = new NetworkingRouterAdvertisement()); } return m_NetworkingRouterAdvertisement; } }
        public NetworkingRouteTable NetworkingRouteTable { get { verifyInitialized(); if (null == m_NetworkingRouteTable) { initializeInterface(m_NetworkingRouteTable = new NetworkingRouteTable()); } return m_NetworkingRouteTable; } }
        public NetworkingRouteTableV2 NetworkingRouteTableV2 { get { verifyInitialized(); if (null == m_NetworkingRouteTableV2) { initializeInterface(m_NetworkingRouteTableV2 = new NetworkingRouteTableV2()); } return m_NetworkingRouteTableV2; } }
        public NetworkingSelfIP NetworkingSelfIP { get { verifyInitialized(); if (null == m_NetworkingSelfIP) { initializeInterface(m_NetworkingSelfIP = new NetworkingSelfIP()); } return m_NetworkingSelfIP; } }
        public NetworkingSelfIPPortLockdown NetworkingSelfIPPortLockdown { get { verifyInitialized(); if (null == m_NetworkingSelfIPPortLockdown) { initializeInterface(m_NetworkingSelfIPPortLockdown = new NetworkingSelfIPPortLockdown()); } return m_NetworkingSelfIPPortLockdown; } }
        public NetworkingSelfIPV2 NetworkingSelfIPV2 { get { verifyInitialized(); if (null == m_NetworkingSelfIPV2) { initializeInterface(m_NetworkingSelfIPV2 = new NetworkingSelfIPV2()); } return m_NetworkingSelfIPV2; } }
        public NetworkingSTPGlobals NetworkingSTPGlobals { get { verifyInitialized(); if (null == m_NetworkingSTPGlobals) { initializeInterface(m_NetworkingSTPGlobals = new NetworkingSTPGlobals()); } return m_NetworkingSTPGlobals; } }
        public NetworkingSTPInstance NetworkingSTPInstance { get { verifyInitialized(); if (null == m_NetworkingSTPInstance) { initializeInterface(m_NetworkingSTPInstance = new NetworkingSTPInstance()); } return m_NetworkingSTPInstance; } }
        public NetworkingSTPInstanceV2 NetworkingSTPInstanceV2 { get { verifyInitialized(); if (null == m_NetworkingSTPInstanceV2) { initializeInterface(m_NetworkingSTPInstanceV2 = new NetworkingSTPInstanceV2()); } return m_NetworkingSTPInstanceV2; } }
        public NetworkingTrunk NetworkingTrunk { get { verifyInitialized(); if (null == m_NetworkingTrunk) { initializeInterface(m_NetworkingTrunk = new NetworkingTrunk()); } return m_NetworkingTrunk; } }
        public NetworkingTunnel NetworkingTunnel { get { verifyInitialized(); if (null == m_NetworkingTunnel) { initializeInterface(m_NetworkingTunnel = new NetworkingTunnel()); } return m_NetworkingTunnel; } }
        public NetworkingVLAN NetworkingVLAN { get { verifyInitialized(); if (null == m_NetworkingVLAN) { initializeInterface(m_NetworkingVLAN = new NetworkingVLAN()); } return m_NetworkingVLAN; } }
        public NetworkingVLANGroup NetworkingVLANGroup { get { verifyInitialized(); if (null == m_NetworkingVLANGroup) { initializeInterface(m_NetworkingVLANGroup = new NetworkingVLANGroup()); } return m_NetworkingVLANGroup; } }

        public PEMFormatScript PEMFormatScript { get { verifyInitialized(); if (null == m_PEMFormatScript) { initializeInterface(m_PEMFormatScript = new PEMFormatScript()); } return m_PEMFormatScript; } }
        public PEMForwardingEndpoint PEMForwardingEndpoint { get { verifyInitialized(); if (null == m_PEMForwardingEndpoint) { initializeInterface(m_PEMForwardingEndpoint = new PEMForwardingEndpoint()); } return m_PEMForwardingEndpoint; } }
        public PEMInterceptionEndpoint PEMInterceptionEndpoint { get { verifyInitialized(); if (null == m_PEMInterceptionEndpoint) { initializeInterface(m_PEMInterceptionEndpoint = new PEMInterceptionEndpoint()); } return m_PEMInterceptionEndpoint; } }
        public PEMListener PEMListener { get { verifyInitialized(); if (null == m_PEMListener) { initializeInterface(m_PEMListener = new PEMListener()); } return m_PEMListener; } }
        public PEMPolicy PEMPolicy { get { verifyInitialized(); if (null == m_PEMPolicy) { initializeInterface(m_PEMPolicy = new PEMPolicy()); } return m_PEMPolicy; } }
        public PEMServiceChainEndpoint PEMServiceChainEndpoint { get { verifyInitialized(); if (null == m_PEMServiceChainEndpoint) { initializeInterface(m_PEMServiceChainEndpoint = new PEMServiceChainEndpoint()); } return m_PEMServiceChainEndpoint; } }
        public PEMSubscriber PEMSubscriber { get { verifyInitialized(); if (null == m_PEMSubscriber) { initializeInterface(m_PEMSubscriber = new PEMSubscriber()); } return m_PEMSubscriber; } }

        public SecurityDoSDevice SecurityDoSDevice { get { verifyInitialized(); if (null == m_SecurityDoSDevice) { initializeInterface(m_SecurityDoSDevice = new SecurityDoSDevice()); } return m_SecurityDoSDevice; } }
        public SecurityDoSWhitelist SecurityDoSWhitelist { get { verifyInitialized(); if (null == m_SecurityDoSWhitelist) { initializeInterface(m_SecurityDoSWhitelist = new SecurityDoSWhitelist()); } return m_SecurityDoSWhitelist; } }
        public SecurityFirewallAddressList SecurityFirewallAddressList { get { verifyInitialized(); if (null == m_SecurityFirewallAddressList) { initializeInterface(m_SecurityFirewallAddressList = new SecurityFirewallAddressList()); } return m_SecurityFirewallAddressList; } }
        public SecurityFirewallGlobalAdminIPRuleList SecurityFirewallGlobalAdminIPRuleList { get { verifyInitialized(); if (null == m_SecurityFirewallGlobalAdminIPRuleList) { initializeInterface(m_SecurityFirewallGlobalAdminIPRuleList = new SecurityFirewallGlobalAdminIPRuleList()); } return m_SecurityFirewallGlobalAdminIPRuleList; } }
        public SecurityFirewallGlobalRuleList SecurityFirewallGlobalRuleList { get { verifyInitialized(); if (null == m_SecurityFirewallGlobalRuleList) { initializeInterface(m_SecurityFirewallGlobalRuleList = new SecurityFirewallGlobalRuleList()); } return m_SecurityFirewallGlobalRuleList; } }
        public SecurityFirewallPolicy SecurityFirewallPolicy { get { verifyInitialized(); if (null == m_SecurityFirewallPolicy) { initializeInterface(m_SecurityFirewallPolicy = new SecurityFirewallPolicy()); } return m_SecurityFirewallPolicy; } }
        public SecurityFirewallPortList SecurityFirewallPortList { get { verifyInitialized(); if (null == m_SecurityFirewallPortList) { initializeInterface(m_SecurityFirewallPortList = new SecurityFirewallPortList()); } return m_SecurityFirewallPortList; } }
        public SecurityFirewallRuleList SecurityFirewallRuleList { get { verifyInitialized(); if (null == m_SecurityFirewallRuleList) { initializeInterface(m_SecurityFirewallRuleList = new SecurityFirewallRuleList()); } return m_SecurityFirewallRuleList; } }
        public SecurityFirewallWeeklySchedule SecurityFirewallWeeklySchedule { get { verifyInitialized(); if (null == m_SecurityFirewallWeeklySchedule) { initializeInterface(m_SecurityFirewallWeeklySchedule = new SecurityFirewallWeeklySchedule()); } return m_SecurityFirewallWeeklySchedule; } }
        public SecurityIPIntelligenceBlacklistCategory SecurityIPIntelligenceBlacklistCategory { get { verifyInitialized(); if (null == m_SecurityIPIntelligenceBlacklistCategory) { initializeInterface(m_SecurityIPIntelligenceBlacklistCategory = new SecurityIPIntelligenceBlacklistCategory()); } return m_SecurityIPIntelligenceBlacklistCategory; } }
        public SecurityIPIntelligenceFeedList SecurityIPIntelligenceFeedList { get { verifyInitialized(); if (null == m_SecurityIPIntelligenceFeedList) { initializeInterface(m_SecurityIPIntelligenceFeedList = new SecurityIPIntelligenceFeedList()); } return m_SecurityIPIntelligenceFeedList; } }
        public SecurityIPIntelligenceGlobalPolicy SecurityIPIntelligenceGlobalPolicy { get { verifyInitialized(); if (null == m_SecurityIPIntelligenceGlobalPolicy) { initializeInterface(m_SecurityIPIntelligenceGlobalPolicy = new SecurityIPIntelligenceGlobalPolicy()); } return m_SecurityIPIntelligenceGlobalPolicy; } }
        public SecurityIPIntelligencePolicy SecurityIPIntelligencePolicy { get { verifyInitialized(); if (null == m_SecurityIPIntelligencePolicy) { initializeInterface(m_SecurityIPIntelligencePolicy = new SecurityIPIntelligencePolicy()); } return m_SecurityIPIntelligencePolicy; } }
        public SecurityLogProfile SecurityLogProfile { get { verifyInitialized(); if (null == m_SecurityLogProfile) { initializeInterface(m_SecurityLogProfile = new SecurityLogProfile()); } return m_SecurityLogProfile; } }
        public SecurityProfileDNSSecurity SecurityProfileDNSSecurity { get { verifyInitialized(); if (null == m_SecurityProfileDNSSecurity) { initializeInterface(m_SecurityProfileDNSSecurity = new SecurityProfileDNSSecurity()); } return m_SecurityProfileDNSSecurity; } }
        public SecurityProfileDoS SecurityProfileDoS { get { verifyInitialized(); if (null == m_SecurityProfileDoS) { initializeInterface(m_SecurityProfileDoS = new SecurityProfileDoS()); } return m_SecurityProfileDoS; } }
        public SecurityProfileIPIntelligence SecurityProfileIPIntelligence { get { verifyInitialized(); if (null == m_SecurityProfileIPIntelligence) { initializeInterface(m_SecurityProfileIPIntelligence = new SecurityProfileIPIntelligence()); } return m_SecurityProfileIPIntelligence; } }

        public SystemCABundleManager SystemCABundleManager { get { verifyInitialized(); if (null == m_SystemCABundleManager) { initializeInterface(m_SystemCABundleManager = new SystemCABundleManager()); } return m_SystemCABundleManager; } }
        public SystemCertificateRevocationListFile SystemCertificateRevocationListFile { get { verifyInitialized(); if (null == m_SystemCertificateRevocationListFile) { initializeInterface(m_SystemCertificateRevocationListFile = new SystemCertificateRevocationListFile()); } return m_SystemCertificateRevocationListFile; } }
        public SystemCluster SystemCluster { get { verifyInitialized(); if (null == m_SystemCluster) { initializeInterface(m_SystemCluster = new SystemCluster()); } return m_SystemCluster; } }
        public SystemConfigSync SystemConfigSync { get { verifyInitialized(); if (null == m_SystemConfigSync) { initializeInterface(m_SystemConfigSync = new SystemConfigSync()); } return m_SystemConfigSync; } }
        public SystemConnections SystemConnections { get { verifyInitialized(); if (null == m_SystemConnections) { initializeInterface(m_SystemConnections = new SystemConnections()); } return m_SystemConnections; } }
        public SystemCryptoClient SystemCryptoClient { get { verifyInitialized(); if (null == m_SystemCryptoClient) { initializeInterface(m_SystemCryptoClient = new SystemCryptoClient()); } return m_SystemCryptoClient; } }
        public SystemCryptoServer SystemCryptoServer { get { verifyInitialized(); if (null == m_SystemCryptoServer) { initializeInterface(m_SystemCryptoServer = new SystemCryptoServer()); } return m_SystemCryptoServer; } }
        public SystemDisk SystemDisk { get { verifyInitialized(); if (null == m_SystemDisk) { initializeInterface(m_SystemDisk = new SystemDisk()); } return m_SystemDisk; } }
        public SystemExternalMonitorFile SystemExternalMonitorFile { get { verifyInitialized(); if (null == m_SystemExternalMonitorFile) { initializeInterface(m_SystemExternalMonitorFile = new SystemExternalMonitorFile()); } return m_SystemExternalMonitorFile; } }
        public SystemFailover SystemFailover { get { verifyInitialized(); if (null == m_SystemFailover) { initializeInterface(m_SystemFailover = new SystemFailover()); } return m_SystemFailover; } }
        public SystemGeoIP SystemGeoIP { get { verifyInitialized(); if (null == m_SystemGeoIP) { initializeInterface(m_SystemGeoIP = new SystemGeoIP()); } return m_SystemGeoIP; } }
        public SystemHAGroup SystemHAGroup { get { verifyInitialized(); if (null == m_SystemHAGroup) { initializeInterface(m_SystemHAGroup = new SystemHAGroup()); } return m_SystemHAGroup; } }
        public SystemHAStatus SystemHAStatus { get { verifyInitialized(); if (null == m_SystemHAStatus) { initializeInterface(m_SystemHAStatus = new SystemHAStatus()); } return m_SystemHAStatus; } }
        public SystemInet SystemInet { get { verifyInitialized(); if (null == m_SystemInet) { initializeInterface(m_SystemInet = new SystemInet()); } return m_SystemInet; } }
        public SystemInternal SystemInternal { get { verifyInitialized(); if (null == m_SystemInternal) { initializeInterface(m_SystemInternal = new SystemInternal()); } return m_SystemInternal; } }
        public SystemLightweightTunnelTableFile SystemLightweightTunnelTableFile { get { verifyInitialized(); if (null == m_SystemLightweightTunnelTableFile) { initializeInterface(m_SystemLightweightTunnelTableFile = new SystemLightweightTunnelTableFile()); } return m_SystemLightweightTunnelTableFile; } }
        public SystemPerformanceSFlow SystemPerformanceSFlow { get { verifyInitialized(); if (null == m_SystemPerformanceSFlow) { initializeInterface(m_SystemPerformanceSFlow = new SystemPerformanceSFlow()); } return m_SystemPerformanceSFlow; } }
        public SystemServices SystemServices { get { verifyInitialized(); if (null == m_SystemServices) { initializeInterface(m_SystemServices = new SystemServices()); } return m_SystemServices; } }
        public SystemSession SystemSession { get { verifyInitialized(); if (null == m_SystemSession) { initializeInterface(m_SystemSession = new SystemSession()); } return m_SystemSession; } }
        public SystemSoftwareManagement SystemSoftwareManagement { get { verifyInitialized(); if (null == m_SystemSoftwareManagement) { initializeInterface(m_SystemSoftwareManagement = new SystemSoftwareManagement()); } return m_SystemSoftwareManagement; } }
        public SystemStatistics SystemStatistics { get { verifyInitialized(); if (null == m_SystemStatistics) { initializeInterface(m_SystemStatistics = new SystemStatistics()); } return m_SystemStatistics; } }
        public SystemSystemInfo SystemSystemInfo { get { verifyInitialized(); if (null == m_SystemSystemInfo) { initializeInterface(m_SystemSystemInfo = new SystemSystemInfo()); } return m_SystemSystemInfo; } }
        public SystemVCMP SystemVCMP { get { verifyInitialized(); if (null == m_SystemVCMP) { initializeInterface(m_SystemVCMP = new SystemVCMP()); } return m_SystemVCMP; } }

        public WebAcceleratorApplications WebAcceleratorApplications { get { verifyInitialized(); if (null == m_WebAcceleratorApplications) { initializeInterface(m_WebAcceleratorApplications = new WebAcceleratorApplications()); } return m_WebAcceleratorApplications; } }
        public WebAcceleratorPolicies WebAcceleratorPolicies { get { verifyInitialized(); if (null == m_WebAcceleratorPolicies) { initializeInterface(m_WebAcceleratorPolicies = new WebAcceleratorPolicies()); } return m_WebAcceleratorPolicies; } }
        public WebAcceleratorProxyMessage WebAcceleratorProxyMessage { get { verifyInitialized(); if (null == m_WebAcceleratorProxyMessage) { initializeInterface(m_WebAcceleratorProxyMessage = new WebAcceleratorProxyMessage()); } return m_WebAcceleratorProxyMessage; } }

        
        public bool initialized { get { return m_bInitialized; } }
        public iControl.ConnectionInfo ConnectionInfo { get { return m_ci; } }
        public System.Net.NetworkCredential Credentials { get { return m_creds; } }
        public String version { get { return SystemSystemInfo.get_product_information().product_version; } }
        public bool PingDuringInitialize { get { return m_bPingDuringInitialize; } set { m_bPingDuringInitialize = value; } }
        public Exception LastException { get { return m_lastException; } }

        public long SessionIdentifier { get { return m_sessionIdentifier; } }

        //-------------------------------------------------------------------
        // Constructor
        //-------------------------------------------------------------------
        public Interfaces()
        {
            m_ci = new iControl.ConnectionInfo();
            m_creds = new System.Net.NetworkCredential();
        }
        public Interfaces(String hostname, String username, String password) : this()
        {
            initialize(hostname, username, password);
        }
        public Interfaces(String hostname, long port, String username, String password) : this()
        {
            initialize(hostname, port, username, password);
        }

        //-------------------------------------------------------------------
        // private methods
        //-------------------------------------------------------------------

        private void initializeInterface(iControlInterface oInterface)
        {
            String url = (null == m_authToken) ? m_ci.buildURL() : m_ci.buildURLwToken(m_emIPAddress, m_authToken);
            oInterface.Url = url;
            oInterface.Credentials = m_ci.creds;
            oInterface.PreAuthenticate = true;

            if (null != m_proxyServer)
            {
                oInterface.Proxy = m_proxyServer;
            }

            oInterface.interfaces = this;
        }

        private void initializeInterface(System.Web.Services.Protocols.SoapHttpClientProtocol oInterface)
        {
            String url = (null == m_authToken) ? m_ci.buildURL() : m_ci.buildURLwToken(m_emIPAddress, m_authToken);
            oInterface.Url = url;
            oInterface.Credentials = m_ci.creds;
            oInterface.PreAuthenticate = true;

            if (null != m_proxyServer)
            {
              oInterface.Proxy = m_proxyServer;
            }
        }

		    private void verifyInitialized()
		    {
			    if (!m_bInitialized)
			    {
				    throw new System.Exception("Not Initialized"); 
			    }
		    }

        //-------------------------------------------------------------------
        // public methods
        //-------------------------------------------------------------------

        public bool initializeWithToken(String hostname, String emip, String authToken)
        {
	        return initializeWithToken(hostname, 443, emip, authToken);
        }
        public bool initializeWithToken(String hostname, long port, String emip, String authToken)
        {
	        m_authToken = authToken;
	        m_emIPAddress = emip;
	        return initialize(hostname, port, null, null);
        }

        public bool initialize(String hostname, String username, String password)
        {
            return initialize(hostname, 443, username, password);
        }

		public bool initialize(String hostname, long port, String username, String password)
		{
			return initialize(hostname, port, username, password, null, 0, null, null, 443 == port);
		}

        public bool initialize(String hostname, long port, String username, String password, Boolean use_https)
        {
            return initialize(hostname, port, username, password, null, 0, null, null, use_https);
        }

        public bool initialize(String hostname, long port, String username, String password, String proxyServer, long proxyPort, String proxyUser, String proxyPass, Boolean use_https)
        {
            m_bInitialized = false;
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = RemoteCertificateValidationCallback;

                m_ci.setEndpoint(hostname, port, "/iControl/iControlPortal.cgi");
                if ((null != username) && (null != password))
                {
                    m_ci.setCredentials(username, password);
                }
                else
                {
                    m_ci.setCredentials("", "");
                }

                if ((null != proxyServer) && (0 != proxyPort))
                {
                    m_proxyServer = new System.Net.WebProxy(proxyServer, Convert.ToInt32(proxyPort));
                    if ((0 == proxyUser.Length) && (0 == proxyPass.Length))
                    {
                        m_proxyServer.UseDefaultCredentials = true;
                    }
                    else
                    {
                        System.Net.NetworkCredential proxyCreds = new System.Net.NetworkCredential();
                        proxyCreds.UserName = proxyUser;
                        proxyCreds.Password = proxyPass;
                        m_proxyServer.Credentials = proxyCreds;
                    }
                }
                else
                {
                    m_proxyServer = null;
                }

                m_ci.useHttps = use_https;

                m_ASMLoggingProfile = null;
                m_ASMObjectParams = null;
                m_ASMPolicy = null;
                m_ASMPolicyGroup = null;
                m_ASMPSMProfile = null;
                m_ASMSystemConfiguration = null;
                m_ASMWebApplication = null;
                m_ASMWebApplicationGroup = null;

                m_ClassificationApplication = null;
                m_ClassificationCategory = null;
                m_ClassificationSignatureDefinition = null;
                m_ClassificationSignatureUpdateSchedule = null;
                m_ClassificationSignatureVersion = null;

                m_GlobalLBApplication = null;
                m_GlobalLBDataCenter = null;
                m_GlobalLBDNSSECKey = null;
                m_GlobalLBDNSSECZone = null;
                m_GlobalLBGlobals = null;
                m_GlobalLBLink = null;
                m_GlobalLBMonitor = null;
                m_GlobalLBPool = null;
                m_GlobalLBPoolMember = null;
                m_GlobalLBProberPool = null;
                m_GlobalLBRegion = null;
                m_GlobalLBRule = null;
                m_GlobalLBServer = null;
                m_GlobalLBTopology = null;
                m_GlobalLBVirtualServer = null;
                m_GlobalLBVirtualServerV2 = null;
                m_GlobalLBWideIP = null;

                m_iCallPeriodicHandler = null;
                m_iCallPerpetualHandler = null;
                m_iCallScript = null;
                m_iCallTriggeredHandler = null;

                m_LocalLBALGLogProfile = null;
                m_LocalLBCipherGroup = null;
                m_LocalLBCipherRule = null;
                m_LocalLBClass = null;
                m_LocalLBDataGroupFile = null;
                m_LocalLBDNSCache = null;
                m_LocalLBDNSExpress = null;
                m_LocalLBDNSGlobals = null;
                m_LocalLBDNSServer = null;
                m_LocalLBDNSTSIGKey = null;
                m_LocalLBDNSZone = null; 
                m_LocalLBiFile = null;
                m_LocalLBiFileFile = null;
                m_LocalLBLSNPool = null;
                m_LocalLBMonitor = null;
                m_LocalLBNAT = null;
                m_LocalLBNATV2 = null;
                m_LocalLBNodeAddress = null;
                m_LocalLBNodeAddressV2 = null;
                m_LocalLBPool = null;
                m_LocalLBPoolMember = null;
                m_LocalLBProfileAnalytics = null;
                m_LocalLBProfileAuth = null;
                m_LocalLBProfileClassification = null;
                m_LocalLBProfileClientSSL = null;
                m_LocalLBProfileDiameter = null;
                m_LocalLBProfileDiameterEndpoint = null;
                m_LocalLBProfileDiameterRouter = null;
                m_LocalLBProfileDiameterSession = null;
                m_LocalLBProfileDNS = null;
                m_LocalLBProfileDNSLogging = null;
                m_LocalLBProfileFastHttp = null;
                m_LocalLBProfileFastL4 = null;
                m_LocalLBProfileFIX = null;
                m_LocalLBProfileFTP = null;
                m_LocalLBProfileHttp = null;
                m_LocalLBProfileHttpClass = null;
                m_LocalLBProfileHttpCompression = null;
                m_LocalLBProfileICAP = null;
                m_LocalLBProfileIIOP = null;
                m_LocalLBProfileIPsecALG = null;
                m_LocalLBProfileOneConnect = null;
                m_LocalLBProfilePCP = null;
                m_LocalLBProfilePersistence = null;
                m_LocalLBProfilePPTP = null;
                m_LocalLBProfileRADIUS = null;
                m_LocalLBProfileRequestAdapt = null;
                m_LocalLBProfileRequestLogging = null;
                m_LocalLBProfileResponseAdapt = null;
                m_LocalLBProfileRTSP = null;
                m_LocalLBProfileSCTP = null;
                m_LocalLBProfileServerSSL = null;
                m_LocalLBProfileSIP = null;
                m_LocalLBProfileSMTPS = null;
                m_LocalLBProfileSPDY = null;
                m_LocalLBProfileSPM = null;
                m_LocalLBProfileStream = null;
                m_LocalLBProfileTCP = null;
                m_LocalLBProfileTCPAnalytics = null;
                m_LocalLBProfileTFTP = null;
                m_LocalLBProfileTrafficAcceleration = null;
                m_LocalLBProfileUDP = null;
                m_LocalLBProfileUserStatistic = null;
                m_LocalLBProfileWebAcceleration = null;
                m_LocalLBProfileXML = null;
                m_LocalLBRAMCacheInformation = null;
                m_LocalLBRateClass = null;
                m_LocalLBRule = null;
                m_LocalLBSNAT = null;
                m_LocalLBSNATPool = null;
                m_LocalLBSNATPoolMember = null;
                m_LocalLBSNATTranslationAddress = null;
                m_LocalLBSNATTranslationAddressV2 = null;
                m_LocalLBVirtualAddress = null;
                m_LocalLBVirtualAddressV2 = null;
                m_LocalLBVirtualServer = null;

                m_LogDestinationArcSight = null;
                m_LogDestinationIPFIX = null;
                m_LogDestinationLocalSyslog = null;
                m_LogDestinationRemoteHighSpeedLog = null;
                m_LogDestinationRemoteSyslog = null;
                m_LogDestinationSplunk = null;
                m_LogFilter = null;
                m_LogPublisher = null;

                m_LTConfigClass = null;
                m_LTConfigField = null;

                m_ManagementApplicationPresentationScript = null;
                m_ManagementApplicationService = null;
                m_ManagementApplicationTemplate = null;
                m_ManagementCCLDAPConfiguration = null;
                m_ManagementCertLDAPConfiguration = null;
                m_ManagementCertificateValidatorOCSP = null;
                m_ManagementChangeControl = null;
                m_ManagementCLIScript = null;
                m_ManagementCRLDPConfiguration = null;
                m_ManagementCRLDPServer = null;
                m_ManagementDBVariable = null;
                m_ManagementDevice = null;
                m_ManagementDeviceGroup = null;
                m_ManagementEM = null;
                m_ManagementEventNotification = null;
                m_ManagementEventSubscription = null;
                m_ManagementFeatureModule = null;
                m_ManagementFolder = null;
                m_ManagementGlobals = null;
                m_ManagementKeyCertificate = null;
                m_ManagementLDAPConfiguration = null;
                m_ManagementLicenseAdministration = null;
                m_ManagementNamed = null;
                m_ManagementOCSPConfiguration = null;
                m_ManagementOCSPResponder = null;
                m_ManagementPartition = null;
                m_ManagementProvision = null;
                m_ManagementRADIUSConfiguration = null;
                m_ManagementRADIUSServer = null;
                m_ManagementResourceRecord = null;
                m_ManagementSFlowDataSource = null;
                m_ManagementSFlowGlobals = null;
                m_ManagementSFlowReceiver = null;
                m_ManagementSMTPConfiguration = null;
                m_ManagementSNMPConfiguration = null;
                m_ManagementTACACSConfiguration = null;
                m_ManagementTMOSModule = null;
                m_ManagementTrafficGroup = null;
                m_ManagementTrust = null;
                m_ManagementUserManagement = null;
                m_ManagementView = null;
                m_ManagementZone = null;
                m_ManagementZoneRunner = null;

                m_NetworkingAdminIP = null;
                m_NetworkingARP = null;
                m_NetworkingBWControllerPolicy = null;
                m_NetworkingInterfaces = null;
                m_NetworkingIPsecIkeDaemon = null;
                m_NetworkingIPsecIkePeer = null;
                m_NetworkingIPsecManualSecurityAssociation = null;
                m_NetworkingIPsecPolicy = null;
                m_NetworkingIPsecTrafficSelector = null;
                m_NetworkingiSessionAdvertisedRoute = null;
                m_NetworkingiSessionAdvertisedRouteV2 = null;
                m_NetworkingiSessionDatastor = null;
                m_NetworkingiSessionDeduplication = null;
                m_NetworkingiSessionLocalInterface = null;
                m_NetworkingiSessionPeerDiscovery = null;
                m_NetworkingiSessionRemoteInterface = null;
                m_NetworkingiSessionRemoteInterfaceV2 = null;
                m_NetworkingLLDPGlobals = null;
                m_NetworkingMulticastRoute = null;
                m_NetworkingPacketFilter = null;
                m_NetworkingPacketFilterGlobals = null;
                m_NetworkingPortMirror = null;
                m_NetworkingProfileFEC = null;
                m_NetworkingProfileGRE = null;
                m_NetworkingProfileIPIP = null;
                m_NetworkingProfileIPsec = null;
                m_NetworkingProfileLightweight4Over6Tunnel = null;
                m_NetworkingProfileV6RD = null;
                m_NetworkingProfileVXLAN = null;
                m_NetworkingProfileWCCPGRE = null;
                m_NetworkingRouteDomain = null;
                m_NetworkingRouteDomainV2 = null;
                m_NetworkingRouterAdvertisement = null;
                m_NetworkingRouteTable = null;
                m_NetworkingRouteTableV2 = null;
                m_NetworkingSelfIP = null;
                m_NetworkingSelfIPPortLockdown = null;
                m_NetworkingSelfIPV2 = null;
                m_NetworkingSTPGlobals = null;
                m_NetworkingSTPInstance = null;
                m_NetworkingSTPInstanceV2 = null;
                m_NetworkingTrunk = null;
                m_NetworkingTunnel = null;
                m_NetworkingVLAN = null;
                m_NetworkingVLANGroup = null;

                m_PEMFormatScript = null;
                m_PEMForwardingEndpoint = null;
                m_PEMInterceptionEndpoint = null;
                m_PEMListener = null;
                m_PEMPolicy = null;
                m_PEMServiceChainEndpoint = null;
                m_PEMSubscriber = null;

                m_SecurityDoSDevice = null;
                m_SecurityDoSWhitelist = null;
                m_SecurityFirewallAddressList = null;
                m_SecurityFirewallGlobalAdminIPRuleList = null;
                m_SecurityFirewallGlobalRuleList = null;
                m_SecurityFirewallPolicy = null;
                m_SecurityFirewallPortList = null;
                m_SecurityFirewallRuleList = null;
                m_SecurityFirewallWeeklySchedule = null;
                m_SecurityIPIntelligenceBlacklistCategory = null;
                m_SecurityIPIntelligenceFeedList = null;
                m_SecurityIPIntelligenceGlobalPolicy = null;
                m_SecurityIPIntelligencePolicy = null;
                m_SecurityLogProfile = null;
                m_SecurityProfileDNSSecurity = null;
                m_SecurityProfileDoS = null;
                m_SecurityProfileIPIntelligence = null;

                m_SystemCABundleManager = null;
                m_SystemCertificateRevocationListFile = null;
                m_SystemCluster = null;
                m_SystemConfigSync = null;
                m_SystemConnections = null;
                m_SystemDisk = null;
                m_SystemExternalMonitorFile = null;
                m_SystemFailover = null;
                m_SystemGeoIP = null;
                m_SystemHAGroup = null;
                m_SystemHAStatus = null;
                m_SystemInet = null;
                m_SystemInternal = null;
                m_SystemLightweightTunnelTableFile = null;
                m_SystemPerformanceSFlow = null;
                m_SystemServices = null;
                m_SystemSession = null;
                m_SystemSoftwareManagement = null;
                m_SystemStatistics = null;
                m_SystemSystemInfo = null;
                m_SystemVCMP = null;

                m_WebAcceleratorApplications = null;
                m_WebAcceleratorPolicies = null;
                m_WebAcceleratorProxyMessage = null;


				// Attempt connection and only return initialized if connection succeeds.

                m_sessionIdentifier = SESSIONID_UNKNOWN;

				m_bInitialized = true;

				if (m_bPingDuringInitialize)
				{
					String sVersion = SystemSystemInfo.get_version();
				}

            }
            catch (Exception ex)
            {
				m_lastException = ex;
				m_bInitialized = false;
			}
            return m_bInitialized;
        }

        public bool IsValidSessionIdentifier(long id)
        {
            return (id > 0);
        }

        // v11+ session/transaction support
        public long GetSessionIdentifier(bool refresh = false)
        {
            long id = -1;
            if ( initialized )
            {
                try
                {
                    if (IsValidSessionIdentifier(m_sessionIdentifier))
                    {
                        id = m_sessionIdentifier;
                    }

                    if ((!IsValidSessionIdentifier(m_sessionIdentifier)) || refresh)
                    {
                        // Only query once.
                        if (SESSIONID_NOTAVAILABLE != m_sessionIdentifier)
                        {
                            id = SystemSession.get_session_identifier();
                        }
                    }

                    // TODO : Session Identifier
                    if (IsValidSessionIdentifier(id))
                    {
                        m_sessionIdentifier = id;
                    }
                }
                catch(Exception ex)
                {
                    m_lastException = ex;
                    m_sessionIdentifier = SESSIONID_NOTAVAILABLE;
                }
            }
            return id;
        }

        public void UseSessionIdentifier(long id)
        {
            m_sessionIdentifier = id;
        }

        public void ClearSessionIdentifier()
        {
            m_sessionIdentifier = -1;
        }

        public void SetTransactionTimeout(long timeout)
        {
            try
            {
                SystemSession.set_transaction_timeout(timeout);
            }
            catch (Exception ex)
            {
                m_lastException = ex;
            }
        }

        public long StartTransaction()
        {
            long id = -1;
            if (initialized)
            {
                try
                {
                    id = SystemSession.start_transaction();
                }
                catch (Exception ex)
                {
                    m_lastException = ex;
                }
            }
            return id;
        }

        public void SubmitTransaction()
        {
            try
            {
                SystemSession.submit_transaction();
            }
            catch (Exception ex)
            {
                m_lastException = ex;
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                SystemSession.rollback_transaction();
            }
            catch (Exception ex)
            {
                m_lastException = ex;
            }
        }

        public bool RemoteCertificateValidationCallback(Object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
