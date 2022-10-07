// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS"]/*' />
/// <unmanaged>D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS</unmanaged>
public partial struct RenderPassEndingAccessResolveParameters
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS::pSrcResource"]/*' />
	public unsafe ID3D12Resource* pSrcResource;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS::pDstResource"]/*' />
	public unsafe ID3D12Resource* pDstResource;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS::SubresourceCount"]/*' />
	public uint SubresourceCount;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS::pSubresourceParameters"]/*' />
	public unsafe RenderPassEndingAccessResolveSubresourceParameters* pSubresourceParameters;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS::Format"]/*' />
	public Graphics.Dxgi.Common.Format Format;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS::ResolveMode"]/*' />
	public ResolveMode ResolveMode;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS::PreserveResolveSource"]/*' />
	public Bool32 PreserveResolveSource;
}
