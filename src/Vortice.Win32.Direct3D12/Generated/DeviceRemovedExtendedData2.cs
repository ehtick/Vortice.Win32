// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA2"]/*' />
/// <unmanaged>D3D12_DEVICE_REMOVED_EXTENDED_DATA2</unmanaged>
public partial struct DeviceRemovedExtendedData2
{
	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA2::DeviceRemovedReason"]/*' />
	public HResult DeviceRemovedReason;

	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA2::AutoBreadcrumbsOutput"]/*' />
	public DredAutoBreadcrumbsOutput1 AutoBreadcrumbsOutput;

	/// <include file='Direct3D12.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA2::PageFaultOutput"]/*' />
	public DredPageFaultOutput1 PageFaultOutput;
}
