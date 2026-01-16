# ---------------------------------------------------------
# Ahnenforscherin – .csproj Dateien automatisch erzeugen
# Erstellt alle Projektdateien mit vollständigem Inhalt
# ---------------------------------------------------------

$projects = @(
    @{
        Path = "src/Ahnenforscherin.App/Ahnenforscherin.App.csproj"
        Content = @"
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net8.0-windows10.0.19041.0</TargetFramework>
    <UseWinUI>true</UseWinUI>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RootNamespace>Ahnenforscherin.App</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.WindowsAppSDK" Version="1.5.240802000" />
    <PackageReference Include="CommunityToolkit.Mvvm" Version="8.2.2" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Ahnenforscherin.Core\Ahnenforscherin.Core.csproj" />
    <ProjectReference Include="..\Ahnenforscherin.Data\Ahnenforscherin.Data.csproj" />
    <ProjectReference Include="..\Ahnenforscherin.Import\Ahnenforscherin.Import.csproj" />
    <ProjectReference Include="..\Ahnenforscherin.Export\Ahnenforscherin.Export.csproj" />
  </ItemGroup>

</Project>
"@
    },
    @{
        Path = "src/Ahnenforscherin.Core/Ahnenforscherin.Core.csproj"
        Content = @"
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RootNamespace>Ahnenforscherin.Core</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="CommunityToolkit.Mvvm" Version="8.2.2" />
  </ItemGroup>

</Project>
"@
    },
    @{
        Path = "src/Ahnenforscherin.Data/Ahnenforscherin.Data.csproj"
        Content = @"
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RootNamespace>Ahnenforscherin.Data</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.Data.Sqlite" Version="8.0.0" />
    <PackageReference Include="Dapper" Version="2.1.35" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Ahnenforscherin.Core\Ahnenforscherin.Core.csproj" />
  </ItemGroup>

</Project>
"@
    },
    @{
        Path = "src/Ahnenforscherin.Import/Ahnenforscherin.Import.csproj"
        Content = @"
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RootNamespace>Ahnenforscherin.Import</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\Ahnenforscherin.Core\Ahnenforscherin.Core.csproj" />
  </ItemGroup>

</Project>
"@
    },
    @{
        Path = "src/Ahnenforscherin.Export/Ahnenforscherin.Export.csproj"
        Content = @"
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RootNamespace>Ahnenforscherin.Export</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\Ahnenforscherin.Core\Ahnenforscherin.Core.csproj" />
  </ItemGroup>

</Project>
"@
    },
    @{
        Path = "tests/Ahnenforscherin.Tests/Ahnenforscherin.Tests.csproj"
        Content = @"
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <IsPackable>false</IsPackable>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RootNamespace>Ahnenforscherin.Tests</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="xunit" Version="2.5.3" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.5.3" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.8.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\..\src\Ahnenforscherin.Core\Ahnenforscherin.Core.csproj" />
    <ProjectReference Include="..\..\src\Ahnenforscherin.Data\Ahnenforscherin.Data.csproj" />
    <ProjectReference Include="..\..\src\Ahnenforscherin.Import\Ahnenforscherin.Import.csproj" />
    <ProjectReference Include="..\..\src\Ahnenforscherin.Export\Ahnenforscherin.Export.csproj" />
  </ItemGroup>

</Project>
"@
    }
)

foreach ($proj in $projects) {
    $path = $proj.Path
    $content = $proj.Content

    $folder = Split-Path $path
    if (-not (Test-Path $folder)) {
        New-Item -ItemType Directory -Path $folder | Out-Null
    }

    Set-Content -Path $path -Value $content -Encoding UTF8
    Write-Host "Created project file: $path"
}

Write-Host "`nAlle .csproj Dateien erfolgreich erstellt!"
