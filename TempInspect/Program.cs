using System;
using System.Reflection;

var asm = Assembly.LoadFrom(@"C:\Users\Ali Can\.nuget\packages\ts.entityframeworkcore.genericrepository\8.0.0\lib\net8.0\GenericRepository.dll");
var types = asm.GetTypes();
foreach (var t in types)
{
    Console.WriteLine($"TYPE: {t.FullName}");
    foreach (var m in t.GetMethods())
    {
        var retNull = m.ReturnParameter.GetCustomAttributes();
        Console.WriteLine($"  METHOD: {m.Name} | ReturnType: {m.ReturnType.Name}");
    }
}
