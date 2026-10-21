
// ILSpy could not decompile this. Please report the exception below,
// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
// Error decompiling @0200000E FFXIVPVPAuto.Verification.AuthState
// in assembly "C:/Users/admin/AppData/Local/Temp/dalamud-plugins-inspect/pvpauto/pvpauto.dll"
//  ---> System.BadImageFormatException: Invalid method header: 0x54
//    at System.Reflection.Metadata.MethodBodyBlock.Create(BlobReader reader) in offset 88
//    at System.Reflection.Metadata.PEReaderExtensions.GetMethodBody(PEReader peReader, Int32 relativeVirtualAddress) in offset 52
//    at ICSharpCode.Decompiler.Metadata.PEFile.GetMethodBody(Int32 rva) in PEFile.cs:line 72
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBodyForAnalysis(IMethod method, IDecompilerTypeSystem typeSystem, CancellationToken cancellationToken) in CSharpDecompiler.cs:line 204
//    at ICSharpCode.Decompiler.CSharp.AutoEventDecompiler.IsAutomaticAccessor(IDecompilerTypeSystem typeSystem, IMethod accessor, IField field, Boolean isAddAccessor, CancellationToken cancellationToken) in AutoEventDecompiler.cs:line 123
//    at ICSharpCode.Decompiler.CSharp.AutoEventDecompiler.IsAutomaticEvent(IDecompilerTypeSystem typeSystem, IEvent ev, CancellationToken cancellationToken, IField& backingField) in AutoEventDecompiler.cs:line 70
//    at ICSharpCode.Decompiler.CSharp.AutoEventDecompiler.IsAutomaticEvent(IDecompilerTypeSystem typeSystem, IEvent ev, DecompileRun decompileRun, CancellationToken cancellationToken, IField& backingField) in AutoEventDecompiler.cs:line 51
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.<DoDecompile>g__IsBackingFieldOfNonAutomaticEvent|96_0(IEntity entity, <>c__DisplayClass96_0&) in CSharpDecompiler.cs:line 1999
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DoDecompile(ITypeDefinition typeDef, DecompileRun decompileRun, ITypeResolveContext decompilationContext, Boolean asExtension) in CSharpDecompiler.cs:line 1882
// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DoDecompile(ITypeDefinition typeDef, DecompileRun decompileRun, ITypeResolveContext decompilationContext, Boolean asExtension) in CSharpDecompiler.cs:line 1981
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DoDecompileTypes(IEnumerable`1 types, DecompileRun decompileRun, ITypeResolveContext decompilationContext, SyntaxTree syntaxTree) in CSharpDecompiler.cs:line 1009
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileTypes(IEnumerable`1 types) in CSharpDecompiler.cs:line 1364
//    at ICSharpCode.Decompiler.CSharp.ProjectDecompiler.WholeProjectDecompiler.<>c__DisplayClass58_0.<WriteCodeFilesInProject>b__6(IGrouping`2 file) in WholeProjectDecompiler.cs:line 439
