using BMVE.Core.Enums;
using BMVE.Core.Utils.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace BMVE.Core.Commands
{
    internal static class SystemProxy
    {
        internal static string System_Version() => Assembly.GetAssembly(typeof(SystemProxy)).GetName().Version.ToString();

        internal static string[] System_GetEnvironmentArguments() => Environment.GetCommandLineArgs();
        internal static string System_GetMachineName() => Environment.MachineName;
        internal static string System_GetOSVersion() => Environment.OSVersion.VersionString;
        internal static int System_GetProcessorCount() => Environment.ProcessorCount;
        internal static int System_GetSystemPageSize() => Environment.SystemPageSize;
        internal static string System_GetSystemDirectory() => Environment.SystemDirectory;
        internal static string System_GetUserDomainName() => Environment.UserDomainName;
        internal static string System_GetUserName() => Environment.UserName;
        internal static string System_GetWorkingMemorySet() => Environment.WorkingSet.ToString();

        internal static void System_Sleep(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
    }
}
