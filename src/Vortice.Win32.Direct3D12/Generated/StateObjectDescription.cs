// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC"]/*' />
/// <unmanaged>D3D12_STATE_OBJECT_DESC</unmanaged>
public partial struct StateObjectDescription
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC::Type"]/*' />
	public StateObjectType Type;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC::NumSubobjects"]/*' />
	public uint NumSubobjects;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC::pSubobjects"]/*' />
	public unsafe StateSubObject* pSubobjects;
}
