# Quokka.TCL

Vivado 2020.2 TCL builder in C# based on ug835-vivado-tcl-commands.pdf

Some commands have inconsisted usage type
https://github.com/EvgenyMuryshkin/Quokka.TCL/blob/main/Quokka.TCL/Vivado/generated/log.md

## Getting Started
* Clone repository
* Open solution in Visual Studio/VSCode
* Run SmokeTest_Pass to run sample testbench in Vivado using generated TCL
* Create your own scenarios and submit PR for any issues\suggestions

## Package

[![NuGet](https://img.shields.io/nuget/v/Quokka.TCL.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Quokka.TCL/)

# Usage
## Complete setup from new project to bitstream creation
```
var tcl = new VivadoTCL();
tcl
    .TCLContent(Path.Combine(Env.ScriptsLocation, "errors.tcl"))
    .set_msg_config(id: "filemgmt 20-742", new_severity: "ERROR")
    .create_project("test", part: "xc7z020clg400-1", verbose: true)
    .SetProperty("target_language", "Verilog", tcl.CurrentProject)
    .SetProperty("board_part", "digilentinc.com:arty-z7-20:part0:1.0", tcl.CurrentProject)
    .SetProperty("platform.board_id", "arty-z7-20", tcl.CurrentProject)
    .AddSources(hdlPath, "*.v")
    .AddSources(manualAssetsPath)
    .update_compile_order(fileset: "sources_1")
    .SetProperty("top", "top", tcl.CurrentFileSet)
    .SetProperty("SOURCE_SET", "sources_1", tcl.Sim1)
    .launch_runs("impl_1", to_step: "write_bitstream", jobs: 4)
    .wait_on_run("impl_1")
    .Text("exitIfFailed")
    ;
SaveTCL(tcl);
```

## Flat builder usage
```
[TestMethod]
public void FlatTCL_CreateProject()
{
    var tcl = new VivadoTCL();
    tcl.create_project("test", verbose: true);
    SaveTCL(tcl);
    Assert.AreEqual("create_project -verbose test", LoadTCLLines()[0]);
}
```

## Categorized builder usage:
```
[TestMethod]
public void CategorizedTCL_CreateProject()
{
    var tcl = new VivadoCategorizedTCL();
    tcl.Project.create_project("test", quiet: true);
    SaveTCL(tcl);
    Assert.AreEqual("create_project -quiet test", LoadTCLLines()[0]);
}
```

## Custom command override
```
class CustomVivadoTCLBuilder : VivadoTCLBuilder
{
    public override SimpleTCLCommand create_project(string name, string part = null, bool? force = null, bool? in_memory = null, bool? ip = null, bool? rtl_kernel = null, bool? quiet = null, bool? verbose = null, string dir = null)
    {
        // always verbose
        return base.create_project(name, part, force, in_memory, ip, rtl_kernel, quiet, true, dir);
    }
}

[TestMethod]
public void FlatTCL_Custom_CreateProject()
{
    var tcl = new VivadoTCL(new CustomVivadoTCLBuilder());
    tcl.create_project("test");
    SaveTCL(tcl);
    Assert.AreEqual("create_project -verbose test", LoadTCLLines()[0]);
}
```

## Contributing
Please report parameter type inconsistency, missing commands\parameters or submit PR with fixes.
All suggestions regarding interface, features etc are most welcomed.

Thanks you

Evgeny
