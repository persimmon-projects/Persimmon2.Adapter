namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Persimmon2.Adapter")>]
[<assembly: AssemblyProductAttribute("Persimmon2.Adapter")>]
[<assembly: AssemblyDescriptionAttribute("This is a library for the Persimmon client.")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
