// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_FLAGS"]/*' />
/// <unmanaged>D3D12_RENDER_PASS_FLAGS</unmanaged>
[Flags]
public enum RenderPassFlags : uint
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_FLAGS::D3D12_RENDER_PASS_FLAG_NONE"]/*' />
	/// <unmanaged>D3D12_RENDER_PASS_FLAG_NONE</unmanaged>
	None = 0,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_FLAGS::D3D12_RENDER_PASS_FLAG_ALLOW_UAV_WRITES"]/*' />
	/// <unmanaged>D3D12_RENDER_PASS_FLAG_ALLOW_UAV_WRITES</unmanaged>
	AllowUavWrites = 1,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_FLAGS::D3D12_RENDER_PASS_FLAG_SUSPENDING_PASS"]/*' />
	/// <unmanaged>D3D12_RENDER_PASS_FLAG_SUSPENDING_PASS</unmanaged>
	SuspendingPass = 2,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_FLAGS::D3D12_RENDER_PASS_FLAG_RESUMING_PASS"]/*' />
	/// <unmanaged>D3D12_RENDER_PASS_FLAG_RESUMING_PASS</unmanaged>
	ResumingPass = 4,
}
