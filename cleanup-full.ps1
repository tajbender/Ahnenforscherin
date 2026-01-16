Write-Host "Starte komplettes Cleanup für Ahnenforscherin..." -ForegroundColor Cyan

# 1. Alle bin/ und obj/ Ordner löschen
Write-Host "Lösche alle bin/ und obj/ Ordner..."
Get-ChildItem -Path . -Include bin,obj -Recurse -Directory -Force |
    ForEach-Object {
        Write-Host "  Entferne: $($_.FullName)"
        Remove-Item $_.FullName -Recurse -Force -ErrorAction SilentlyContinue
    }

# 2. PublishProfiles löschen (Hauptursache für win10-RIDs)
Write-Host "Lösche PublishProfiles..."
$pubProfiles = Get-ChildItem -Path . -Recurse -Include *.pubxml -ErrorAction SilentlyContinue
foreach ($pubFile in $pubProfiles) {
    Write-Host "  Entferne: $($profile.FullName)"
    Remove-Item $profile.FullName -Force
}

# 3. project.assets.json löschen (NuGet Cache pro Projekt)
Write-Host "Lösche project.assets.json Dateien..."
Get-ChildItem -Path . -Recurse -Include project.assets.json -ErrorAction SilentlyContinue |
    ForEach-Object {
        Write-Host "  Entferne: $($_.FullName)"
        Remove-Item $_.FullName -Force
    }

# 4. Lokalen NuGet Cache für die Solution löschen
Write-Host "Lösche lokalen NuGet Cache..."
dotnet nuget locals all --clear

# 5. Neues Restore
Write-Host "Führe dotnet restore aus..."
dotnet restore

Write-Host "`nCleanup abgeschlossen!" -ForegroundColor Green