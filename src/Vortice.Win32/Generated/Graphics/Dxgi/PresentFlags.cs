// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <unmanaged>DXGI_PRESENT</unmanaged>
[Flags]
public enum PresentFlags : uint
{
	None = 0,
	/// <unmanaged>DXGI_PRESENT_TEST</unmanaged>
	Test = 1,
	/// <unmanaged>DXGI_PRESENT_DO_NOT_SEQUENCE</unmanaged>
	DoNotSequence = 2,
	/// <unmanaged>DXGI_PRESENT_RESTART</unmanaged>
	Restart = 4,
	/// <unmanaged>DXGI_PRESENT_DO_NOT_WAIT</unmanaged>
	DoNotWait = 8,
	/// <unmanaged>DXGI_PRESENT_STEREO_PREFER_RIGHT</unmanaged>
	StereoPreferRight = 16,
	/// <unmanaged>DXGI_PRESENT_STEREO_TEMPORARY_MONO</unmanaged>
	StereoTemporaryMono = 32,
	/// <unmanaged>DXGI_PRESENT_RESTRICT_TO_OUTPUT</unmanaged>
	RestrictToOutput = 64,
	/// <unmanaged>DXGI_PRESENT_USE_DURATION</unmanaged>
	UseDuration = 256,
	/// <unmanaged>DXGI_PRESENT_ALLOW_TEARING</unmanaged>
	AllowTearing = 512,
}
