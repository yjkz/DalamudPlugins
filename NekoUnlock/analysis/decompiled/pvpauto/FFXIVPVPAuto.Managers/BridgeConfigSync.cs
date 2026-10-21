namespace FFXIVPVPAuto.Managers;

internal static class BridgeConfigSync
{
	private const string TargetName = "FFXIVPVPAuto";

	private const string MarkerName = "BridgeSync.last";

	internal static void TrySync()
	{
		/*Error: Read out of bounds.*/;
	}

	private static void SyncCore()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken()
		//    at System.Reflection.Metadata.Ecma335.MetadataTokens.EntityHandle(Int32 token)
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeMetadataToken() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 227
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 1198
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2391
	}
}
