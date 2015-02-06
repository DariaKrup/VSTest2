# TW-21554
Write-Host It's a trap!
trap { $host.SetShouldExit(1) }
EpicFail.exe 1