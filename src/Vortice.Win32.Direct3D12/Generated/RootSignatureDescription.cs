// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC"]/*' />
/// <unmanaged>D3D12_ROOT_SIGNATURE_DESC</unmanaged>
public partial struct RootSignatureDescription
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC::NumParameters"]/*' />
	public uint NumParameters;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC::pParameters"]/*' />
	public unsafe RootParameter* pParameters;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC::NumStaticSamplers"]/*' />
	public uint NumStaticSamplers;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC::pStaticSamplers"]/*' />
	public unsafe StaticSamplerDescription* pStaticSamplers;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC::Flags"]/*' />
	public RootSignatureFlags Flags;
}
