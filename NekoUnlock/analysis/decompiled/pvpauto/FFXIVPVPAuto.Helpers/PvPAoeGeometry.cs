
// ILSpy could not decompile this. Please report the exception below,
// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
// Error decompiling @0200007C FFXIVPVPAuto.Helpers.PvPAoeGeometry
// in assembly "C:/Users/admin/AppData/Local/Temp/dalamud-plugins-inspect/pvpauto/pvpauto.dll"
//  ---> System.BadImageFormatException: Invalid method header: 0x3B 0x74
//    at System.Reflection.Metadata.MethodBodyBlock.Create(BlobReader reader) in offset 130
//    at System.Reflection.Metadata.PEReaderExtensions.GetMethodBody(PEReader peReader, Int32 relativeVirtualAddress) in offset 52
//    at ICSharpCode.Decompiler.Metadata.PEFile.GetMethodBody(Int32 rva) in PEFile.cs:line 72
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBodyForAnalysis(IMethod method, IDecompilerTypeSystem typeSystem, CancellationToken cancellationToken) in CSharpDecompiler.cs:line 204
//    at ICSharpCode.Decompiler.CSharp.RecordDecompiler.DecompileBody(IMethod method) in RecordDecompiler.cs:line 1455
//    at ICSharpCode.Decompiler.CSharp.RecordDecompiler.<DetectAutomaticProperties>g__IsAutoGetter|15_1(IMethod method, IField& field) in RecordDecompiler.cs:line 118
//    at ICSharpCode.Decompiler.CSharp.RecordDecompiler.<DetectAutomaticProperties>g__IsAutoProperty|15_0(IProperty p, IField& field) in RecordDecompiler.cs:line 91
//    at ICSharpCode.Decompiler.CSharp.RecordDecompiler.DetectAutomaticProperties() in RecordDecompiler.cs:line 75
//    at ICSharpCode.Decompiler.CSharp.RecordDecompiler..ctor(IDecompilerTypeSystem dts, ITypeDefinition recordTypeDef, DecompilerSettings settings, CancellationToken cancellationToken) in RecordDecompiler.cs:line 63
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DoDecompile(ITypeDefinition typeDef, DecompileRun decompileRun, ITypeResolveContext decompilationContext, Boolean asExtension) in CSharpDecompiler.cs:line 1844
// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DoDecompile(ITypeDefinition typeDef, DecompileRun decompileRun, ITypeResolveContext decompilationContext, Boolean asExtension) in CSharpDecompiler.cs:line 1981
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DoDecompileTypes(IEnumerable`1 types, DecompileRun decompileRun, ITypeResolveContext decompilationContext, SyntaxTree syntaxTree) in CSharpDecompiler.cs:line 1009
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileTypes(IEnumerable`1 types) in CSharpDecompiler.cs:line 1364
//    at ICSharpCode.Decompiler.CSharp.ProjectDecompiler.WholeProjectDecompiler.<>c__DisplayClass58_0.<WriteCodeFilesInProject>b__6(IGrouping`2 file) in WholeProjectDecompiler.cs:line 439
