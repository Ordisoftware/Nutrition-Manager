#define MyAppVersion "1.0"
#define MyAppName "Nutrition Manager"
#define MyAppNameNoSpace "NutritionManager"
#define MyAppExeName "Ordisoftware.Nutrition.Manager.exe"
#define MyAppPublisher "Ordisoftware"
#define MyAppURL "https://www.ordisoftware.com/projects/nutrition-manager"

[Setup]
MinVersion=0,6.1sp1
LicenseFile=..\Project\Licenses\MPL 2.0.rtf
AppCopyright=Copyright 2025 Olivier Rogier
AppId={{1F42B494-D1AB-4A0B-A438-974914D1ECC4}
;AppMutex=BBED54DA-8843-43C8-BC66-1FD655B5FADC
#include "Scripts\Setup.iss"

[Languages]
#include "Scripts\Languages.iss"

[Dirs]

[InstallDelete]
#include "Scripts\InstallDelete.iss"

[Files]
#include "Scripts\Files.iss"

[Run]
#include "Scripts\Run.iss"

[Registry]

[Tasks]
#include "Scripts\Tasks.iss"

[Icons]
#include "Scripts\Icons.iss"

[CustomMessages]
#include "Scripts\Messages.iss"

[Code]
#include "Scripts\CheckDotNetFramework.iss"
