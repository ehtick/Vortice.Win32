// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE"]/*' />
/// <unmanaged>D3D12_DRED_ALLOCATION_NODE</unmanaged>
public partial struct DredAllocationNode
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE::ObjectNameA"]/*' />
	public unsafe byte* ObjectNameA;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE::ObjectNameW"]/*' />
	public unsafe ushort* ObjectNameW;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE::AllocationType"]/*' />
	public DredAllocationType AllocationType;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE::pNext"]/*' />
	public unsafe DredAllocationNode* pNext;
}
