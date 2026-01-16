# ---------------------------------------------------------
# Ahnenforscherin – Solution automatisch erzeugen
# Erstellt Ahnenforscherin.sln und fügt alle Projekte hinzu
# ---------------------------------------------------------

# Prüfen, ob dotnet CLI verfügbar ist
if (-not (Get-Command dotnet -ErrorAction SilentlyContinue)) {
    Write-Host "Die .NET SDK CLI (dotnet) wurde nicht gefunden."
    exit 1
}

# Solution erstellen
Write-Host "Erstelle Solution Ahnenforscherin.sln..."
dotnet new sln -n Ahnenforscherin

# Projekte definieren
$projects = @(
    "src/Ahnenforscherin.App/Ahnenforscherin.App.csproj",
    "src/Ahnenforscherin.Core/Ahnenforscherin.Core.csproj",
    "src/Ahnenforscherin.Data/Ahnenforscherin.Data.csproj",
    "src/Ahnenforscherin.Import/Ahnenforscherin.Import.csproj",
    "src/Ahnenforscherin.Export/Ahnenforscherin.Export.csproj",
    "tests/Ahnenforscherin.Tests/Ahnenforscherin.Tests.csproj"
)

# Projekte hinzufügen
foreach ($proj in $projects) {
    Write-Host "Füge Projekt hinzu: $proj"
    dotnet sln Ahnenforscherin.sln add $proj
}

# Solution-Folder erstellen
Write-Host "Erstelle Solution-Ordnerstruktur..."

dotnet sln Ahnenforscherin.sln add src/Ahnenforscherin.App/Ahnenforscherin.App.csproj --solution-folder src
dotnet sln Ahnenforscherin.sln add src/Ahnenforscherin.Core/Ahnenforscherin.Core.csproj --solution-folder src
dotnet sln Ahnenforscherin.sln add src/Ahnenforscherin.Data/Ahnenforscherin.Data.csproj --solution-folder src
dotnet sln Ahnenforscherin.sln add src/Ahnenforscherin.Import/Ahnenforscherin.Import.csproj --solution-folder src
dotnet sln Ahnenforscherin.sln add src/Ahnenforscherin.Export/Ahnenforscherin.Export.csproj --solution-folder src

dotnet sln Ahnenforscherin.sln add tests/Ahnenforscherin.Tests/Ahnenforscherin.Tests.csproj --solution-folder tests

Write-Host "`nSolution erfolgreich erstellt und strukturiert!"
