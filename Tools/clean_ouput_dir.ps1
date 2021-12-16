[CmdletBinding()]

param (
    [string]
    [Parameter(Mandatory=$true)]
    $TargetDir
)

Write-Output "===== Beginning $($PSCmdlet.MyInvocation.MyCommand) ====="

# Cleanup
Get-ChildItem -Path "$($TargetDir)\lang" | Remove-Item -Force
Get-ChildItem -Path "$($TargetDir)\dll" | Remove-Item -Force
Remove-Item "$($TargetDir)\lang" -Force 
Remove-Item "$($TargetDir)\dll" -Force 

# Create directories
New-Item -Path "$($TargetDir)" -Name "lang" -ItemType "directory"
New-Item -Path "$($TargetDir)" -Name "dll" -ItemType "directory"

# Remove unnecessary files from build
#Get-ChildItem -Path "$($TargetDir)\*.json" | Remove-Item

# Move DLLs
Get-ChildItem -Path "$($TargetDir)\*.dll" | Move-Item -Destination "$($TargetDir)\dll"

# Move language resource DLLs
$languages = @('de','it','cs-CZ','el','es','es-AR','fi-FI','fr','hu','ja-JP','ko-KR','lt','nb-NO','nl','pl','pt','pt-BR','ru','tr-TR','uk','zh-CN','zh-TW')
foreach ($language in $languages){
    $src = "$($TargetDir)\$language"
    $dst = "$($TargetDir)\lang\$language"
    Move-Item -Path $src -Destination $dst -Force
}

Write-Output ""