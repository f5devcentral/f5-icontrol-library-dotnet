set SOURCE_DIR=.\bindings
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ASMPolicy.cs ASM.Policy.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ASMSystemConfiguration.cs ASM.SystemConfiguration.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ASMWebApplication.cs ASM.WebApplication.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ASMWebApplicationGroup.cs ASM.WebApplicationGroup.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBApplication.cs globallb.application.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBDataCenter.cs globallb.datacenter.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBDNSSECKey.cs globallb.dnsseckey.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBDNSSECZone.cs globallb.dnsseczone.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBGlobals.cs globallb.globals.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBLink.cs globallb.link.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBMonitor.cs globallb.monitor.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBPool.cs globallb.pool.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBPoolMember.cs globallb.poolmember.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBRegion.cs globallb.region.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBRule.cs globallb.rule.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBServer.cs globallb.server.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBTopology.cs globallb.topology.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBVirtualServer.cs globallb.virtualserver.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBWideip.cs globallb.wideip.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBClass.cs locallb.class.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBMonitor.cs locallb.monitor.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBNAT.cs locallb.nat.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBNodeAddress.cs locallb.nodeaddress.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBPool.cs locallb.pool.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBPoolMember.cs locallb.poolmember.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileAuth.cs locallb.profileauth.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileClientSSL.cs locallb.profileclientssl.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileDiameter.cs locallb.profilediameter.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileDNS.cs locallb.profiledns.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileFastHTTP.cs locallb.profilefasthttp.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileFastL4.cs locallb.profilefastl4.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileFTP.cs locallb.profileftp.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileHTTP.cs locallb.profilehttp.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileHTTPClass.cs locallb.profilehttpclass.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileIIOP.cs locallb.profileiiop.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileOneConnect.cs locallb.profileoneconnect.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfilePersistence.cs locallb.profilepersistence.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileRADIUS.cs locallb.profileradius.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileRTSP.cs locallb.profilertsp.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileSCTP.cs locallb.profilesctp.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileServerSSL.cs locallb.profileserverssl.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileSIP.cs locallb.profilesip.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileStream.cs locallb.profilestream.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileTCP.cs locallb.profiletcp.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileUDP.cs locallb.profileudp.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBPRofileUserStatistic.cs locallb.profileuserstatistic.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileXML.cs locallb.profilexml.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBRAMCacheInformation.cs locallb.ramcacheinformation.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBRateClass.cs locallb.rateclass.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBRule.cs locallb.rule.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBSNAT.cs locallb.snat.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBSNATPool.cs locallb.snatpool.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBSNATPoolMember.cs locallb.snatpoolmember.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBSNATTranslationAddress.cs locallb.snattranslationaddress.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBVirtualAddress.cs locallb.virtualaddress.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBVirtualServer.cs locallb.virtualserver.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LTConfigClass.cs LTConfig.Class.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LTConfigField.cs LTConfig.Field.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementCCLDAPConfiguration.cs management.ccldapconfiguration.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementCRLDPConfiguration.cs management.crldpconfiguration.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementCRLDPServer.cs management.crldpserver.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementDBVariable.cs management.dbvariable.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementEventNotification.cs management.eventnotification.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementEventSubscription.cs management.eventsubscription.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementKeyCertificate.cs management.keycertificate.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementLDAPConfiguration.cs management.ldapconfiguration.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementLicenseAdministration.cs management.licenseadministration.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementNamed.cs management.named.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementOCSPConfiguration.cs management.ocspconfiguration.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementOCSPResponder.cs management.ocspresponder.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementPartition.cs management.partition.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementProvision.cs management.provision.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementRadiusConfiguration.cs management.radiusconfiguration.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementRadiusServer.cs management.radiusserver.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementResourceRecord.cs management.resourcerecord.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementSNMPConfiguration.cs management.snmpconfiguration.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementTACACSConfiguration.cs management.tacacsconfiguration.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementTMOSModule.cs management.tmosmodule.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementUserManagement.cs management.usermanagement.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementView.cs management.view.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementZone.cs management.zone.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementZoneRunner.cs management.zonerunner.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingAdminIP.cs networking.adminip.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingArp.cs networking.arp.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingInterfaces.cs networking.interfaces.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingiSessionAdvertisedRoute.cs networking.iSessionAdvertisedRoute.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingiSessionLocalInterface.cs networking.iSessionLocalInterface.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingiSessionPeerDiscovery.cs networking.iSessionPeerDiscovery.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingiSessionRemoteInterface.cs networking.iSessionRemoteInterface.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingPacketFilter.cs networking.packetfilter.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingPacketFilterGlobals.cs networking.packetfilterglobals.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingPortMirror.cs networking.portmirror.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingProfileGRE.cs networking.profilegre.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingProfileIPIP.cs networking.profileipip.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingProfileWCCPGRE.cs networking.profilewccpgre.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingRouteDomain.cs networking.routedomain.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingRouteTable.cs networking.routetable.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingSelfIP.cs networking.selfip.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingSelfIPPortLockdown.cs networking.selfipportlockdown.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingSTPGlobals.cs networking.stpglobals.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingSTPInstance.cs networking.stpinstance.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingTrunk.cs networking.trunk.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingTunnel.cs networking.tunnel.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingVLAN.cs networking.vlan.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingVLANGroup.cs networking.vlangroup.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/SystemCluster.cs system.cluster.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/SystemConfigSync.cs system.configsync.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/SystemDisk.cs system.disk.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/SystemGeoIP.cs system.geoip.wsdl

wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/SystemFailover.cs system.failover.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/SystemInet.cs system.inet.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/SystemServices.cs system.services.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/SystemSoftwareManagement.cs system.softwaremanagement.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/SystemStatistics.cs system.statistics.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/SystemSystemInfo.cs system.systeminfo.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/WebAcceleratorApplications.cs WebAccelerator.Applications.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/WebAcceleratorPolicies.cs WebAccelerator.Policies.wsdl
