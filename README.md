# Master branch status
Tool  | Status
-------- | :------------:
AppVeyor | [![Build status](https://ci.appveyor.com/api/projects/status/kt463jsy4il7rtyq/branch/master?svg=true)](https://ci.appveyor.com/project/Rychu-Pawel/nipvalidator/branch/master)
Nuget | [![Nuget](https://img.shields.io/nuget/v/rychusoft.validators.nipvalidator.svg?style=flat)](https://www.nuget.org/packages/Rychusoft.Validators.NipValidator/)

# NipValidator
Polish NIP number validator 

# Easy to use library for validating Polish NIP numbers:
```csharp
string nip = "8674068337";  
bool isValid = Rychusoft.Validators.NipValidator.IsValid(nip);
```
