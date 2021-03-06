﻿namespace System
open System.Reflection
open System.Runtime.CompilerServices

[<assembly: AssemblyTitleAttribute("FSharpx.Collections.Experimental")>]
[<assembly: AssemblyProductAttribute("FSharpx.Collections")>]
[<assembly: AssemblyDescriptionAttribute("FSharpx.Collections is a collection of datastructures for use with F# and C#.")>]
[<assembly: InternalsVisibleToAttribute("FSharpx.Collections.Tests")>]
[<assembly: InternalsVisibleToAttribute("FSharpx.Collections.Experimental.Tests")>]
[<assembly: AssemblyVersionAttribute("1.15.2")>]
[<assembly: AssemblyFileVersionAttribute("1.15.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.15.2"
    let [<Literal>] InformationalVersion = "1.15.2"
