// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC"]/*' />
/// <unmanaged>DXGI_ADAPTER_DESC</unmanaged>
public partial struct AdapterDescription
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::Description"]/*' />
	public unsafe fixed ushort Description[128];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::VendorId"]/*' />
	public uint VendorId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::DeviceId"]/*' />
	public uint DeviceId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::SubSysId"]/*' />
	public uint SubSysId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::Revision"]/*' />
	public uint Revision;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::DedicatedVideoMemory"]/*' />
	public nuint DedicatedVideoMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::DedicatedSystemMemory"]/*' />
	public nuint DedicatedSystemMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::SharedSystemMemory"]/*' />
	public nuint SharedSystemMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::AdapterLuid"]/*' />
	public Luid AdapterLuid;
}
