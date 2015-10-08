set SOURCE_DIR=.\bindings
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ASMPolicy.cs ASM.Policy.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ASMSystemConfiguration.cs ASM.SystemConfiguration.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ASMWebApplication.cs ASM.WebApplication.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/GlobalLBApplication.cs globallb.application.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBMonitor.cs locallb.monitor.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBNodeAddress.cs locallb.nodeaddress.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/LocalLBProfileXML.cs locallb.profilexml.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/ManagementUserManagement.cs management.usermanagement.wsdl
wsdl.exe /language:cs /par:par.txt /namespace:iControl /out:%SOURCE_DIR%/interfaces/NetworkingRouteDomain.cs networking.routedomain.wsdl
