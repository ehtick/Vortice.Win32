// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC"]/*' />
/// <unmanaged>D3D12_PARAMETER_DESC</unmanaged>
public partial struct ParameterDescription
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::Name"]/*' />
	public unsafe sbyte* Name;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::SemanticName"]/*' />
	public unsafe sbyte* SemanticName;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::Type"]/*' />
	public Graphics.Direct3D.ShaderVariableType Type;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::Class"]/*' />
	public Graphics.Direct3D.ShaderVariableClass Class;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::Rows"]/*' />
	public uint Rows;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::Columns"]/*' />
	public uint Columns;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::InterpolationMode"]/*' />
	public Graphics.Direct3D.InterpolationMode InterpolationMode;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::Flags"]/*' />
	public Graphics.Direct3D.ParameterFlags Flags;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::FirstInRegister"]/*' />
	public uint FirstInRegister;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::FirstInComponent"]/*' />
	public uint FirstInComponent;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::FirstOutRegister"]/*' />
	public uint FirstOutRegister;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_PARAMETER_DESC::FirstOutComponent"]/*' />
	public uint FirstOutComponent;
}
