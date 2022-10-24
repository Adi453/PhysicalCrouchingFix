using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(PhysicalCrouchingFix.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(PhysicalCrouchingFix.BuildInfo.Company)]
[assembly: AssemblyProduct(PhysicalCrouchingFix.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + PhysicalCrouchingFix.BuildInfo.Author)]
[assembly: AssemblyTrademark(PhysicalCrouchingFix.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(PhysicalCrouchingFix.BuildInfo.Version)]
[assembly: AssemblyFileVersion(PhysicalCrouchingFix.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(PhysicalCrouchingFix.PhysicalCrouchingFix), PhysicalCrouchingFix.BuildInfo.Name, PhysicalCrouchingFix.BuildInfo.Version, PhysicalCrouchingFix.BuildInfo.Author, PhysicalCrouchingFix.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]