for($i = 1; $i -lt 101; $i++ ) {
	for($j=0;$j -lt 30000;$j++) {} 
	write-progress "Search in Progress" "% Complete:" -perc $i;
}