$webconfigFile = Resolve-Path ".\Poweshell\fixlock\Web.config"
Write-Host $webconfigfile
Write-Host "Testing Path"
Write-Host Test Path Value Is: (Test-Path $webconfigFile)