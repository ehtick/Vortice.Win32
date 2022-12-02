// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICJpegFrameEncode"]/*' />
/// <unmanaged>IWICJpegFrameEncode</unmanaged>
[Guid("2f0c601f-d2c6-468c-abfa-49495d983ed1")]
[NativeTypeName("struct IWICJpegFrameEncode : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICJpegFrameEncode : IWICJpegFrameEncode.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICJpegFrameEncode
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x1F, 0x60, 0x0C, 0x2F,
				0xC6, 0xD2,
				0x8C, 0x46,
				0xAB,
				0xFA,
				0x49,
				0x49,
				0x5D,
				0x98,
				0x3E,
				0xD1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICJpegFrameEncode));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICJpegFrameEncode));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, Guid*, void**, int>)(lpVtbl[0]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint>)(lpVtbl[1]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint>)(lpVtbl[2]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICJpegFrameEncode::GetAcHuffmanTable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetAcHuffmanTable(uint scanIndex, uint tableIndex, Graphics.Dxgi.Common.JpegAcHuffmanTable* pAcHuffmanTable)
	{
		return ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Graphics.Dxgi.Common.JpegAcHuffmanTable*, int>)(lpVtbl[3]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICJpegFrameEncode::GetDcHuffmanTable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetDcHuffmanTable(uint scanIndex, uint tableIndex, Graphics.Dxgi.Common.JpegDCHuffmanTable* pDcHuffmanTable)
	{
		return ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Graphics.Dxgi.Common.JpegDCHuffmanTable*, int>)(lpVtbl[4]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICJpegFrameEncode::GetQuantizationTable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetQuantizationTable(uint scanIndex, uint tableIndex, Graphics.Dxgi.Common.JpegQuantizationTable* pQuantizationTable)
	{
		return ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Graphics.Dxgi.Common.JpegQuantizationTable*, int>)(lpVtbl[5]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICJpegFrameEncode::WriteScan"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult WriteScan(uint cbScanData, byte* pbScanData)
	{
		return ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, byte*, int>)(lpVtbl[6]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), cbScanData, pbScanData);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetAcHuffmanTable(uint scanIndex, uint tableIndex, Graphics.Dxgi.Common.JpegAcHuffmanTable* pAcHuffmanTable);

		[VtblIndex(4)]
		HResult GetDcHuffmanTable(uint scanIndex, uint tableIndex, Graphics.Dxgi.Common.JpegDCHuffmanTable* pDcHuffmanTable);

		[VtblIndex(5)]
		HResult GetQuantizationTable(uint scanIndex, uint tableIndex, Graphics.Dxgi.Common.JpegQuantizationTable* pQuantizationTable);

		[VtblIndex(6)]
		HResult WriteScan(uint cbScanData, byte* pbScanData);
	}
}

