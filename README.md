# Quokka.TCL

Vivado TCL builder in C# based on ug835-vivado-tcl-commands.pdf

Some commands have inconsisted usage type
https://github.com/EvgenyMuryshkin/Quokka.TCL/blob/main/Quokka.TCL/Vivado/generated/log.md

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
