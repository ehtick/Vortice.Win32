// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_ALIASING_BARRIER"]/*' />
/// <unmanaged>D3D12_RESOURCE_ALIASING_BARRIER</unmanaged>
public partial struct ResourceAliasingBarrier
{
	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_ALIASING_BARRIER::pResourceBefore"]/*' />
	public unsafe ID3D12Resource* pResourceBefore;

	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_ALIASING_BARRIER::pResourceAfter"]/*' />
	public unsafe ID3D12Resource* pResourceAfter;
}
