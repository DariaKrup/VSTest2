Write-Host "Running powershell user script wrapper"
echo $PSVersionTable.PSVersion
$version = 1
if ($PSVersionTable -ne $null) {
  Write-Host "Running version greater than 1.0"
  Write-Host "Setting try/catch blocks..."
  try {
    $path = Resolve-Path "runEpicFail.ps1"
    Write-Host $path.Path
    . $path.Path
  } catch {
    Write-Host "##teamcity[message text='$_' status='ERROR']"
    $host.SetShouldExit(1)
  }
} else {
  trap { $host.SetShouldExit(1) }
  # move call of external script to cmdlet 
  $path = Resolve-Path "runEpicFail.ps1"
  Write-Host $path.Path
}

