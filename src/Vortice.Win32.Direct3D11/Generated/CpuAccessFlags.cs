// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_CPU_ACCESS_FLAG"]/*' />
/// <unmanaged>D3D11_CPU_ACCESS_FLAG</unmanaged>
[Flags]
public enum CpuAccessFlags : uint
{
	None = 0,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_CPU_ACCESS_FLAG::D3D11_CPU_ACCESS_WRITE"]/*' />
	/// <unmanaged>D3D11_CPU_ACCESS_WRITE</unmanaged>
	Write = 65536,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_CPU_ACCESS_FLAG::D3D11_CPU_ACCESS_READ"]/*' />
	/// <unmanaged>D3D11_CPU_ACCESS_READ</unmanaged>
	Read = 131072,
}
