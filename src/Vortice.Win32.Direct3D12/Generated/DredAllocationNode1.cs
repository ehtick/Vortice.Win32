// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1"]/*' />
/// <unmanaged>D3D12_DRED_ALLOCATION_NODE1</unmanaged>
public partial struct DredAllocationNode1
{
	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1::ObjectNameA"]/*' />
	public unsafe byte* ObjectNameA;

	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1::ObjectNameW"]/*' />
	public unsafe ushort* ObjectNameW;

	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1::AllocationType"]/*' />
	public DredAllocationType AllocationType;

	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1::pNext"]/*' />
	public unsafe DredAllocationNode1* pNext;

	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1::pObject"]/*' />
	public unsafe IUnknown* pObject;
}
