SET FILE_NAME=TennisPlayerApi
SET SOURCE_DLL=bin\Debug\netcoreapp2.2\TennisPlayer.API.dll
SET TARGET_DIR=E:\Tennis\TennisPlayer\TennisPlayer.API\ApiDoc\
SET TITLE=swaggerTest
SET DESCRIPTION=SwaggerTest
SET VERSION=1.0.0
SET HOST=localhost:5000
dotnet E:\Tennis\NSwag\NetCore22\dotnet-nswag.dll webapi2swagger /assembly:"%SOURCE_DLL%" /AspNetCore:true /output:%TARGET_DIR%%FILE_NAME%.json /InfoTitle:"%TITLE%" /InfoDescription:"%DESCRIPTION%" /InfoVersion:%VERSION% /ServiceHost:%HOST%
