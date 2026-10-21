
// ILSpy could not decompile this. Please report the exception below,
// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
// System.BadImageFormatException: Read out of bounds.
//    at System.Reflection.Throw.OutOfBounds()
//    at System.Reflection.Metadata.Ecma335.StandAloneSigTableReader.GetSignature(Int32 rowId)
//    at System.Reflection.Metadata.StandaloneSignature.GetKind()
//    at ICSharpCode.Decompiler.CSharp.RequiredNamespaceCollector.CollectNamespacesFromMethodBody(MethodBodyBlock method, MetadataModule module) in /_/ICSharpCode.Decompiler/CSharp/RequiredNamespaceCollector.cs:line 387
//    at ICSharpCode.Decompiler.CSharp.RequiredNamespaceCollector.CollectNamespaces(IEntity entity, MetadataModule module, CodeMappingInfo mappingInfo) in /_/ICSharpCode.Decompiler/CSharp/RequiredNamespaceCollector.cs:line 162
//    at ICSharpCode.Decompiler.CSharp.RequiredNamespaceCollector.CollectNamespaces(IEntity entity, MetadataModule module, CodeMappingInfo mappingInfo) in /_/ICSharpCode.Decompiler/CSharp/RequiredNamespaceCollector.cs:line 128
//    at ICSharpCode.Decompiler.CSharp.RequiredNamespaceCollector.CollectNamespaces(IEntity entity, MetadataModule module, HashSet`1 namespaces) in /_/ICSharpCode.Decompiler/CSharp/RequiredNamespaceCollector.cs:line 76
//    at ICSharpCode.Decompiler.CSharp.RequiredNamespaceCollector.CollectNamespaces(EntityHandle entity, MetadataModule module, HashSet`1 namespaces) in /_/ICSharpCode.Decompiler/CSharp/RequiredNamespaceCollector.cs:line 234
//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileTypes(IEnumerable`1 types) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 1360
//    at ICSharpCode.Decompiler.CSharp.ProjectDecompiler.WholeProjectDecompiler.<>c__DisplayClass58_0.<WriteCodeFilesInProject>b__6(IGrouping`2 file) in /_/ICSharpCode.Decompiler/CSharp/ProjectDecompiler/WholeProjectDecompiler.cs:line 439
