// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DISCARD_REGION"]/*' />
/// <unmanaged>D3D12_DISCARD_REGION</unmanaged>
public partial struct DiscardRegion
{
	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DISCARD_REGION::NumRects"]/*' />
	public uint NumRects;

	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DISCARD_REGION::pRects"]/*' />
	public unsafe RawRect* pRects;

	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DISCARD_REGION::FirstSubresource"]/*' />
	public uint FirstSubresource;

	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DISCARD_REGION::NumSubresources"]/*' />
	public uint NumSubresources;
}
