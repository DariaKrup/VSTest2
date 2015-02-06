if (Test-Path env:TEAMCITY_VERSION) {
  Write-Host "Running under TeamCity " env:TEAMCITY_VERSION
}

$rawUI = (Get-Host).UI.RawUI
Write-Host "raw ui BufferSize Height:" $rawUI.BufferSize.Height
Write-Host "raw ui BufferSize Width:" $rawUI.BufferSize.Width
$maxwinwidth = $rawUI.MaxPhysicalWindowSize.Width
$rawUI.BufferSize = New-Object Management.Automation.Host.Size ([Math]::max($maxwinwidth, 500), $rawUI.BufferSize.Height)
$rawUI.WindowSize = New-Object Management.Automation.Host.Size ($maxwinwidth, $rawUI.WindowSize.Height)
Write-Output "maxwinwidth=$maxwinwidth"
