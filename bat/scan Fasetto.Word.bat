cd ..
cd src\Fasetto.Word

SonarScanner.MSBuild begin /key:"Fasetto.Word" /name:"Fasetto.Word" /version:"1.0"
MSBuild Fasetto.Word.sln
SonarScanner.MSBuild end
pause