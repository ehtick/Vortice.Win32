// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT2"]/*' />
/// <unmanaged>D3D12_DRED_PAGE_FAULT_OUTPUT2</unmanaged>
public partial struct DredPageFaultOutput2
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT2::PageFaultVA"]/*' />
	public ulong PageFaultVA;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT2::pHeadExistingAllocationNode"]/*' />
	public unsafe DredAllocationNode1* pHeadExistingAllocationNode;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT2::pHeadRecentFreedAllocationNode"]/*' />
	public unsafe DredAllocationNode1* pHeadRecentFreedAllocationNode;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT2::PageFaultFlags"]/*' />
	public DredPageFaultFlags PageFaultFlags;
}
