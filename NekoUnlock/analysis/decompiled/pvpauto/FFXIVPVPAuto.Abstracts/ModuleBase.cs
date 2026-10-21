using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace FFXIVPVPAuto.Abstracts;

public abstract class ModuleBase
{
	protected delegate void DrawConfigDelegate(ref bool hasChanged);

	private static readonly JsonSerializerOptions JsonOptions;

	public bool Initialized
	{
		[CompilerGenerated]
		get
		{
			/*Error: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
		[CompilerGenerated]
		internal set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x58
		}
	}

	public virtual ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xE2*/;
		}
	}

	public virtual ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid local signature token: 0x3BAB329F
		}
	}

	public virtual IReadOnlyList<ModuleCommand> Commands
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0002: Stack underflow*/- unchecked((ushort)/*Error near IL_0001: Stack underflow*/);
				/*Error near IL_0002: Unknown opcode: 0xAC*/;
			}
		}
	}

	internal string ModuleName
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x88
		}
	}

	protected virtual DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x27 0xCC
		}
	}

	internal bool HasConfig
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_ = ((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
			checked
			{
				_ = /*Error near IL_0003: Stack underflow*/+ /*Error near IL_0003: Stack underflow*/;
				/*Error near IL_0003: Invalid field token*/;
			}
		}
	}

	protected ModuleBase()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD3 0xF0
	}

	internal void InternalInit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x53 0xD5
	}

	internal void InternalUninit()
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0x2B66089A
	}

	internal bool DrawConfigTreeIfAvailable()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x84
	}

	protected unsafe T LoadConfig<T>() where T : new()
	{
		//IL_0002: Expected I4, but got I8
		*(int*)(nint)/*Error near IL_0002: Stack underflow*/ = (int)checked((long)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFC*/;
	}

	protected void SaveConfig<T>(T config)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x68
	}

	protected virtual void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x1C
	}

	protected unsafe virtual void Uninit()
	{
		if (*(byte*)(nint)/*Error near IL_0001: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(int*)(nint)/*Error near IL_0007: Stack underflow*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	protected virtual void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE1
	}

	internal virtual void ExecuteCommand(string actionId, string arguments)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x61
	}

	internal bool TryExecuteCommand(string actionId, string arguments)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xAD*/;
	}

	internal virtual bool? GetCommandToggleState(string toggleId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAB 0xF7
	}

	internal virtual bool SetCommandToggleState(string toggleId, bool enabled)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x23 0xF9
	}

	internal bool TrySetCommandToggleState(string toggleId, bool enabled)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x91
	}

	private void BaseUninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x07 0xA7
	}

	private string GetConfigPath()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x93 0x88
	}

	static ModuleBase()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x99
	}
}
