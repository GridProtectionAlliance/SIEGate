using System.Reflection;
using System.Runtime.InteropServices;

// Informational attributes.
[assembly: AssemblyCompany("Grid Protection Alliance")]
[assembly: AssemblyCopyright("Copyright © 2012.  All Rights Reserved.")]
[assembly: AssemblyProduct("SIEGate")]

// Assembly manifest attributes.
#if DEBUG
[assembly: AssemblyConfiguration("Debug Build")]
#else
[assembly: AssemblyConfiguration("Release Build")]
#endif
[assembly: AssemblyDescription("Windows service that hosts input, action and output adapters.")]
[assembly: AssemblyTitle("SIEGate Iaon Host")]

// Other configuration attributes.
[assembly: ComVisible(false)]
[assembly: Guid("B49F061B-549F-4C3A-A2D6-47C2356D2BC1")]

// Assembly identity attributes.
[assembly: AssemblyVersion("1.8.196.0")]
[assembly: AssemblyFileVersion("1.8.196.0")]