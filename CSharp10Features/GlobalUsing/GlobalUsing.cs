global using System.Collections;



// or you can do it in .csproj file 
<PropertyGroup>
    <ImplicitUsings>enable</ImplicitUsings>
</PropertyGroup>


<ItemGroup Condition= "'$(ImplicitUsings)' == 'true' Or '$(ImplicitUsings)' == 'enable'">
    <using Include="System.Collections"/>
</ItemGroup>
