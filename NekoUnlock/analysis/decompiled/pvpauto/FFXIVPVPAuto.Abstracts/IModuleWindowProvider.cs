using System.Collections.Generic;
using Dalamud.Interface.Windowing;

namespace FFXIVPVPAuto.Abstracts;

public interface IModuleWindowProvider
{
	IReadOnlyList<Window> GetWindows();
}
