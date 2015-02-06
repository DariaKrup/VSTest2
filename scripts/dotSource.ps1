Write-Host "Running powershell user script wrapper"
$host = Get-Host
Write-Host "Powershell version: "
# resolve path to user script

$file = args[0]
$hello = Resolve-Path userScript1.ps1
echo $hello.Path
. $hello.Path
Get-Host
