using System;
using System.Collections.Generic;
using System.Text;
using iControl;

namespace testclient
{
    class Program
    {
        Interfaces m_interfaces = new Interfaces();

        public void Usage()
        {
            Console.WriteLine("Usage: testclient.exe bigip username password [options]");
            Console.WriteLine("   [options]");
            Console.WriteLine("       none - list pools");
            Console.WriteLine("       poolname - list pool members for specified pool name");
            Console.WriteLine("       poolname member:port - display enabled state for given pool member");
            Console.WriteLine("       poolname member:port [enable|disable] - set the state of the given pool member");
        }

        public void processArgs(string[] args)
        {
            if (args.Length >= 3)
            {
                try
                {
                    // Initialize the connection information
                    bool bInitialized = m_interfaces.initialize(args[0], 443, args[1], args[2]);
					          if (!bInitialized)
					          {
						          Exception ex = m_interfaces.LastException;
					          }
					          //m_interfaces.initialize(args[0], 443, args[1], args[2], "71.170.131.38", 808, "joe", "f5rox");
					          //iControl.Dialogs.ConnectionDialog cd = new iControl.Dialogs.ConnectionDialog();

                    switch (args.Length)
                    {
                        case 3:
                            //m_interfaces.SystemSystemInfo.AddHeader("X-iControl", "BLAHBLAHBLAH");

                            m_interfaces.GetSessionIdentifier();
                            string version = m_interfaces.SystemSystemInfo.get_version();
                            Console.WriteLine(version);

                            m_interfaces.ClearSessionIdentifier();
                            version = m_interfaces.SystemSystemInfo.get_version();
                            Console.WriteLine(version);

                            //iControl.CommonTMOSModule [] module_list = m_interfaces.ManagementTMOSModule.get_known_module_list();
                            //for (int i = 0; i < module_list.Length; i++)
                            //{
                            //    Console.WriteLine(module_list[i].ToString());
                            //}
                            //listPools();
                            break;
                        case 4:
                            listPoolMembers(args[3]);
                            break;
                        case 5:
                            showPoolMemberState(args[3], args[4]);
                            break;
                        case 6:
                            setPoolMemberState(args[3], args[4], args[5]);
                            break;
                        default:
                            Usage();
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }
            else
            {
                Usage();
            }
        }

        public void listPools()
        {
            String[] pool_list = m_interfaces.LocalLBPool.get_list();
            Console.WriteLine("POOLS");
            for (int i = 0; i < pool_list.Length; i++)
            {
                Console.WriteLine("  [" + i + "] : " + pool_list[i]);
            }
        }

        public void listPoolMembers(String pool_name)
        {
            CommonIPPortDefinition [][] members = m_interfaces.LocalLBPool.get_member(new string[] { pool_name });
            Console.WriteLine("POOL '" + pool_name + "' MEMBERS");
            for (int i = 0; i < members[0].Length; i++)
            {
                Console.WriteLine("  [" + i + "] : " + members[0][i].address + ":" + members[0][i].port.ToString());
            }
        }
        public void showPoolMemberState(String pool_name, String member)
        {
            CommonIPPortDefinition ipPort = parseMember(member);
            LocalLBPoolMemberMemberSessionState [][] session_states =
            m_interfaces.LocalLBPoolMember.get_session_enabled_state(new string[] { pool_name });
            Console.WriteLine("POOL '" + pool_name + "' MEMBER STATUS");
            for(int i=0; i<session_states[0].Length; i++)
            {
                if (session_states[0][i].member.address.Equals(ipPort.address) &&
                    session_states[0][i].member.port == ipPort.port)
                {
                    Console.WriteLine("  " + member + " : " + session_states[0][i].session_state);
                }
            }
        }

        public void setPoolMemberState(String pool_name, String member, String state)
        {
            CommonIPPortDefinition ipPort = parseMember(member);
            if ( null != ipPort )
            {
                LocalLBPoolMemberMemberSessionState [][] session_states = new LocalLBPoolMemberMemberSessionState[1][];
                session_states[0] = new LocalLBPoolMemberMemberSessionState[1];
                session_states[0][0] = new LocalLBPoolMemberMemberSessionState();
                session_states[0][0].member = new CommonIPPortDefinition();
                session_states[0][0].member = ipPort;
                session_states[0][0].session_state = parseState(state);
                m_interfaces.LocalLBPoolMember.set_session_enabled_state(new string[] { pool_name }, session_states);
                Console.WriteLine("Setting state to " + session_states[0][0].session_state); 
            }
        }

        public CommonEnabledState parseState(String str)
        {
            CommonEnabledState state = CommonEnabledState.STATE_ENABLED;
            if (str.ToLower().Equals("enable"))
            {
                state = CommonEnabledState.STATE_ENABLED;
            }
            else if (str.ToLower().Equals("disable"))
            {
                state = CommonEnabledState.STATE_DISABLED;
            }
            return state;
        }

        public CommonIPPortDefinition parseMember(String member)
        {
            CommonIPPortDefinition ipPort = null;
            String[] sSplit = member.Split(new char[] { ':' });
            if (2 == sSplit.Length)
            {
                ipPort = new CommonIPPortDefinition();
                ipPort.address = sSplit[0];
                ipPort.port = Convert.ToInt32(sSplit[1]);
            }
            return ipPort;
        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.processArgs(args);
        }

    }
}
