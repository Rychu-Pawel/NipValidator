# Master branch status
Tool  | Status
-------- | :------------:
AppVeyor | [![Build status](https://ci.appveyor.com/api/projects/status/kt463jsy4il7rtyq/branch/master?svg=true)](https://ci.appveyor.com/project/Rychu-Pawel/nipvalidator/branch/master)
SonarCloud | [![reliability](https://sonarcloud.io/api/project_badges/measure?project=NipValidator&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=NipValidator) [![security](https://sonarcloud.io/api/project_badges/measure?project=NipValidator&metric=security_rating)](https://sonarcloud.io/dashboard?id=NipValidator) [![vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=NipValidator&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=NipValidator)
Nuget | [![Nuget](https://img.shields.io/nuget/v/rychusoft.validators.nipvalidator.svg?style=flat)](https://www.nuget.org/packages/Rychusoft.Validators.NipValidator/)

# NipValidator
Polish NIP number validator 

# Easy to use library for validating Polish NIP numbers:
string nip = "8674068337";  
bool isValid = Rychusoft.Validators.NipValidator.IsValid(nip);
