if((Test-Path "GeneratedPackages") -eq $false){
    New-Item "GeneratedPackages" -type directory
}
gci  *.nuspec | 
    ForEach-Object {
        $expression = "Nuget.exe pack {0} -Build -OutputDirectory GeneratedPackages" -f $_.Name
        Invoke-Expression $expression
    }