cd ..
cd src\Fasetto.Word

dotnet sonarscanner begin /key:"Fasetto.Word.Server" /name:"Fasetto.Word.Server" /version:"1.0"
dotnet build Fasetto.Word.Web.Server.sln
dotnet sonarscanner end
pause