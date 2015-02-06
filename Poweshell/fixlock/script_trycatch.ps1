try {
Write-Host "Starting Step 2"
$xml = New-Object XML
Write-Host "XML Object Created"
$webconfigFile = "Poweshell\fixlock\Web.config"
Write-Host "Testing Path"
Write-Host "Test Path Value Is: (Test-Path $webconfigFile)"
if ($true){
	Write-Host "Path Exists"
	$xml.Load($webconfigFile)
	Write-Host "File Loaded"
	$debugmode = $xml.configuration."system.web".SelectSingleNode("//compilation")
	Write-Host "Node Found"
	$debugmode.debug = "false"
	Write-Host "Node Value Changed"
	$xml.Save($webconfigFile)
	Write-Host "File Saved"
}
Write-Host "Outside of If block"
Remove-Variable xml
} catch {
	Write-Host "Caught Error!!!"
  exit 1
}
