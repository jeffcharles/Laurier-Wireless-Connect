Thank you very much for taking the time to download the source code for this project. This file will quickly review some steps you should take to set up your computer to compile this application, go over some distribution advice involving .NET bootstrappers, as well as provide some contact information.

To set up your development machine to compile this application:
---------------------------------------------------------------

1. Download and install WiX 3.0, available at http://sourceforge.net/projects/wix/files/

2. Download and install the .NET 3.0 SP2 and .NET 2.0 SP2 bootstrapper packages, available at http://msdn.microsoft.com/en-ca/vstudio/bb898654.aspx

3. Download the Windows Installer 3.1 Redistributable exe, available at http://www.microsoft.com/downloads/details.aspx?familyid=889482fc-5f56-4a38-b838-de776fd4138c&displaylang=en#filelist and place it in the Windows Installer 3.1 bootstrapper folder, normally located at C:\Program Files\Microsoft SDKs\Windows\v7.0A\Bootstrapper\Packages\WindowsInstaller3_1

Distribution advice:
--------------------

When distributing this application, we suggest distributing the MSI file to users running Windows Vista and 7 and to distribute the bootstrapped setup exe file to Windows XP users. The bootstrapped setup exe file will not function properly on Windows Vista or 7 because the .NET 3.0 SP2 package in the bootstrapper is not compatible with Windows Vista or 7, thus we suggest distributing the MSI for these platforms. Since .NET 3.0 is included in both Windows Vista and 7, a .NET 3.0 bootstrapper is not neccessary for these platforms. Windows XP however requires a .NET 3.0 bootstrapper because .NET 3.0 may not be installed, distributing the MSI file to XP users may result in the application refusing to run. We also examined using .NET 2.0, .NET 3.5, .NET 3.5 Client Profile, and .NET 4.0 bootstrappers. The .NET 2.0 bootstrapper is also not compatible with Windows Vista or 7. The .NET 3.5 bootstrapper would force an unacceptably long installation on Windows XP and Vista computers. The .NET 3.5 Client Profile bootstrapper will force a full .NET 3.5 installation (which is unacceptably long) if the user has any other older version of .NET installed. The .NET 4.0 bootstrapper would force a long .NET 4.0 installation for a large majority of clients. It's my opinion that providing the bootstrapped setup exe for Windows XP and the MSI file for Windows Vista and 7 is the least undesirable option as the trade-off between slightly increasing confusion among non-technical users who don't know what operating system they are running is worth it to minimize setup times for Windows Vista and 7 users.

Contact Information:
--------------------

Maintainer: Jeffrey Charles <jeffrey.charles@wluopensource.org>
Open Source at Laurier: <info@wluopensource.org>