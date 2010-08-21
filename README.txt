Thank you very much for taking the time to download the source code for this project. This file will quickly review some steps you should take to set up your computer to compile this application, go over some distribution advice involving .NET bootstrappers, as well as provide some contact information.

To set up your development machine to compile this application:
---------------------------------------------------------------

1. Download and install a version of Microsoft Visual C# 2010 (Visual C# express is freely available at http://www.microsoft.com/express/downloads/#2010-Visual-CS)

2. Download and install Python, Mercurial, and TortoiseHg, available at http://www.python.org/download/ and http://mercurial.selenic.com/downloads/ respectively

3. Download and install WiX 3.0, available at http://sourceforge.net/projects/wix/files/

The Installer build will fail for `Debug|Any CPU` unless you have built a `Release|Any CPU` build prior to building a debug version. If you get an error about missing executable files while building a debug version, then attempt to build a release version before attempting to build the debug version.

Installer Oddities:
-------------------

I used dotNetInstaller <http://dotnetinstaller.codeplex.com/> to generate a bootstrapped installer called Setup.exe in the `Installer\bin\Release` folder. The post-build event for Installer should generate the setup file. The setup file generated will download .NET 2.0 SP1 and install it if the user does not already have it installed.

More Documentation:
-------------------

Please see the docs folder for more documentation.

Contact Information:
--------------------

Maintainer: Jeffrey Charles <jeffrey.charles@wluopensource.org>
Open Source at Laurier: <info@wluopensource.org>

Thank you's:
------------

I'd like to thank the following projects for making this application possible:

* Managed Wifi API <http://managedwifi.codeplex.com/>
* Windows Installer XML (WiX) toolset <http://wix.sourceforge.net/>
* dotNetInstaller <http://dotnetinstaller.codeplex.com/>