using System;
using System.Runtime.CompilerServices;

namespace FFXIVPVPAuto.Abstracts;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
internal sealed class ManagerInitOrderAttribute : Attribute
{
	public int Order
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x39
		}
	}

	public ManagerInitOrderAttribute(int order)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x87 0x55
	}
}
