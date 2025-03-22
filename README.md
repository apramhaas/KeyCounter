# KeyCounter

KeyCounter is a tool for the tray-bar that helps you to get statistics about the usage of your computer's keyboard, mouse, and uptime. **KeyCounter is NOT (!) intended to work as a keylogger**, nor is it possible to use it as one without major modifications to the source code. Be sure to protect the privacy of all users and get their consent.

This program is distributed in the hope that it will be useful, but **WITHOUT ANY WARRANTY**; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

## System Requirements

- Windows 2000 SP4 / Windows XP / Windows Server 2003 / Windows Vista / Windows 8 / Windows 10 / Windows 11
- Microsoft .NET Framework 2.0 for versions up to 0.10.0.0
- Microsoft .NET Framework 4.7.2 for versions from 0.10.1.0

The binary distributions up to 0.10.0.0 were compiled using Microsoft Visual C# 2005 Express Edition. Later binary distributions were compiled using Microsoft Visual Studio Community 2022.

## Contact

If you have any questions, recommendations, or comments about KeyCounter, feel free to create an issue.

## Changelog

### 0.10.1.0 2025-03-22
- Target framework changed to .net 4.7.2
- Project reorganization and update to VS Community Edition 2022
- Move project from Sourceforge to Github

### 0.10.0.1 2008-03-24
- Target framework changed to .NET 3.5, Visual C# 2008
- Fixed copyright notice in about box: no copyright for editors in GPL licensed software!

### 0.10 2007-03-25
- Options dialog
- Balloon tips
- New icons
- Improved stability
- Many bugfixes

### 0.9.1 2007-01-15
- New column for hits per minute in FormDisplay->Per Key
- Visual Studio AboutBox replaces FormAbout, thanks to UNCLE JAMAL for the nice pic!
- Some new icons for the tray-bar context-menu (looks cool with the new AboutBox)
- Fixed bug B1 "uptime standby" with a regular uptime-update (timer in FormMain)
- Note: The slow timer period causes the uptime to increase in steps of 10s; anyhow, the internal counter precision is not reduced.
- Basic support for GPLv2

### 0.9.0 2007-01-08
- Setting "debugModeEnabled" switched to false -> no debug-windows for users
- Fixed summary-tab of FormDisplay ("Average key hits per minute since last reset")
- FormAbout shows compilation date and time (helper program CompileInfo.exe)
