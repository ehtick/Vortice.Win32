// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D;

/// <include file='../Direct3D.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS"]/*' />
/// <unmanaged>D3D_SHADER_VARIABLE_FLAGS</unmanaged>
[Flags]
public enum ShaderVariableFlags : int
{
	None = 0,
	/// <include file='../Direct3D.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS::D3D_SVF_USERPACKED"]/*' />
	/// <unmanaged>D3D_SVF_USERPACKED</unmanaged>
	UserPacked = 1,
	/// <include file='../Direct3D.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS::D3D_SVF_USED"]/*' />
	/// <unmanaged>D3D_SVF_USED</unmanaged>
	Used = 2,
	/// <include file='../Direct3D.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS::D3D_SVF_INTERFACE_POINTER"]/*' />
	/// <unmanaged>D3D_SVF_INTERFACE_POINTER</unmanaged>
	InterfacePointer = 4,
	/// <include file='../Direct3D.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS::D3D_SVF_INTERFACE_PARAMETER"]/*' />
	/// <unmanaged>D3D_SVF_INTERFACE_PARAMETER</unmanaged>
	InterfaceParameter = 8,
}
