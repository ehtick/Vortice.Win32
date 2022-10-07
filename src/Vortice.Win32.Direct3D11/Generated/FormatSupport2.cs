// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2"]/*' />
/// <unmanaged>D3D11_FORMAT_SUPPORT2</unmanaged>
[Flags]
public enum FormatSupport2 : int
{
	None = 0,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_ADD"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_ADD</unmanaged>
	UavAtomicAdd = 1,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS</unmanaged>
	UavAtomicBitwiseOps = 2,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE</unmanaged>
	UavAtomicCompareStoreOrCompareExchange = 4,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE</unmanaged>
	UavAtomicExchange = 8,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX</unmanaged>
	UavAtomicSignedMinOrMax = 16,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX</unmanaged>
	UavAtomicUnsignedMinOrMax = 32,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_UAV_TYPED_LOAD"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_UAV_TYPED_LOAD</unmanaged>
	UavTypedLoad = 64,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_UAV_TYPED_STORE"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_UAV_TYPED_STORE</unmanaged>
	UavTypedStore = 128,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP</unmanaged>
	OutputMergerLogicOp = 256,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_TILED"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_TILED</unmanaged>
	Tiled = 512,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_SHAREABLE"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_SHAREABLE</unmanaged>
	Shareable = 1024,
	/// <include file='Direct3D11.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2::D3D11_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY"]/*' />
	/// <unmanaged>D3D11_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY</unmanaged>
	MultiplaneOverlay = 16384,
}
