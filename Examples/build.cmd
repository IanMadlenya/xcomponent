@echo off

set /p xcversion=<xcversion.txt

pushd %~dp0

if exist packages (
	rmdir /s /q packages
)

Tools\NuGet.exe install FAKE -ConfigFile Tools\Nuget.Config -ExcludeVersion -OutputDirectory packages -Version 4.10.3
Tools\NuGet.exe install XComponent.Community -ConfigFile Tools\Nuget.Config -ExcludeVersion -OutputDirectory packages -Version %xcversion%

set encoding=utf-8
packages\FAKE\tools\FAKE.exe build.fsx All

popd