; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{48A5A939-444E-47FE-B0FE-9A1EAC356167}
AppName=Robot Dashboard
AppVersion=1.0
;AppVerName=Robot Dashboard 1.5
AppPublisher=FRC Team 525
DefaultDirName=C:\Robot Dashboard 2018
DefaultGroupName=Robot Dashboard 2018
OutputDir=C:\Robotics\2018\FRC\RobotDash\Output
OutputBaseFilename=DashboardSetup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Dirs]
Name: "{app}\Resources"

[Files]
Source: "C:\Robotics\2018\FRC\RobotDash\RobotDash\bin\Debug\RobotDash.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Robotics\2018\FRC\RobotDash\RobotDash\bin\Debug\Resources\*"; DestDir: "{app}\Resources\"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Robot Dashboard 2018"; Filename: "{app}\RobotDash.exe"
Name: "{commondesktop}\Robot Dashboard 2018"; Filename: "{app}\RobotDash.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\RobotDash.exe"; Description: "{cm:LaunchProgram,Robot Dashboard 2018}"; Flags: nowait postinstall skipifsilent
