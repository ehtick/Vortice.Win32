// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA"]/*' />
/// <unmanaged>D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA</unmanaged>
public partial struct KeyExchangeHWProtectionOutputData
{
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA::PrivateDataSize"]/*' />
	public uint PrivateDataSize;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA::MaxHWProtectionDataSize"]/*' />
	public uint MaxHWProtectionDataSize;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA::HWProtectionDataSize"]/*' />
	public uint HWProtectionDataSize;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA::TransportTime"]/*' />
	public ulong TransportTime;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA::ExecutionTime"]/*' />
	public ulong ExecutionTime;

	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA::pbOutput"]/*' />
	public unsafe fixed byte pbOutput[4];
}
