// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA"]/*' />
/// <unmanaged>D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA</unmanaged>
public partial struct KeyExchangeHWProtectionInputData
{
	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA::PrivateDataSize"]/*' />
	public uint PrivateDataSize;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA::HWProtectionDataSize"]/*' />
	public uint HWProtectionDataSize;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA::pbInput"]/*' />
	public unsafe fixed byte pbInput[4];
}
