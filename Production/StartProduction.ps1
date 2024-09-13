# Define the base path relative to the script's location
$basePath = Split-Path -Parent $MyInvocation.MyCommand.Path

# Define paths relative to the script location
$angularAppPath = Join-Path -Path $basePath -ChildPath "UserInterface\browser"
$aspNetCoreAppPath = Join-Path -Path $basePath -ChildPath "Server\HotelManagement.Server.API.exe"

# Define the port for the Angular application
$angularPort = 2872

# Start Angular application using http-server with output suppression
Start-Process -FilePath "npx" -ArgumentList "http-server", "-p", $angularPort -WorkingDirectory $angularAppPath -NoNewWindow -RedirectStandardOutput "NUL"

# Start ASP.NET Core application with output suppression
Start-Process -FilePath $aspNetCoreAppPath -WorkingDirectory (Split-Path -Parent $aspNetCoreAppPath) -NoNewWindow -RedirectStandardOutput "NUL"

# Inform the user
Write-Output "Angular application is running at http://localhost:$angularPort"
Write-Output "ASP.NET Core application is running."
