// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC"]/*' />
/// <unmanaged>D3D11_COMPUTE_SHADER_TRACE_DESC</unmanaged>
public partial struct ComputeShaderTraceDescription
{
	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC::Invocation"]/*' />
	public ulong Invocation;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC::ThreadIDInGroup"]/*' />
	public unsafe fixed uint ThreadIDInGroup[3];

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC::ThreadGroupID"]/*' />
	public unsafe fixed uint ThreadGroupID[3];
}
