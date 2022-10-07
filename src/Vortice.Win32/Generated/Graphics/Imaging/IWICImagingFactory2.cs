// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging.D2D;

/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory2"]/*' />
/// <unmanaged>IWICImagingFactory2</unmanaged>
[Guid("7b816b45-1996-4476-b132-de9e247c8af0")]
[NativeTypeName("struct IWICImagingFactory2 : IWICImagingFactory")]
[NativeInheritance("IWICImagingFactory")]
public unsafe partial struct IWICImagingFactory2 : INativeGuid
{
	public static ref readonly Guid IID_IWICImagingFactory2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x45, 0x6B, 0x81, 0x7B,
				0x96, 0x19,
				0x76, 0x44,
				0xB1,
				0x32,
				0xDE,
				0x9E,
				0x24,
				0x7C,
				0x8A,
				0xF0
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImagingFactory2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImagingFactory2));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromFilename" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult CreateDecoderFromFilename(ushort* wzFilename, Guid* pguidVendor, uint dwDesiredAccess, Graphics.Imaging.WICDecodeOptions metadataOptions, Graphics.Imaging.IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, ushort*, Guid*, uint, Graphics.Imaging.WICDecodeOptions, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[0]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromStream" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	public HResult CreateDecoderFromStream(Com.IStream* pIStream, Guid* pguidVendor, Graphics.Imaging.WICDecodeOptions metadataOptions, Graphics.Imaging.IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Com.IStream*, Guid*, Graphics.Imaging.WICDecodeOptions, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[1]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromFileHandle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	public HResult CreateDecoderFromFileHandle(nuint hFile, Guid* pguidVendor, Graphics.Imaging.WICDecodeOptions metadataOptions, Graphics.Imaging.IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, nuint, Guid*, Graphics.Imaging.WICDecodeOptions, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[2]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateComponentInfo" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateComponentInfo(Guid* clsidComponent, Graphics.Imaging.IWICComponentInfo** ppIInfo)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Guid*, Graphics.Imaging.IWICComponentInfo**, int>)(lpVtbl[3]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateDecoder(Guid* guidContainerFormat, Guid* pguidVendor, Graphics.Imaging.IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Guid*, Guid*, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[4]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateEncoder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateEncoder(Guid* guidContainerFormat, Guid* pguidVendor, Graphics.Imaging.IWICBitmapEncoder** ppIEncoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Guid*, Guid*, Graphics.Imaging.IWICBitmapEncoder**, int>)(lpVtbl[5]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreatePalette" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreatePalette(Graphics.Imaging.IWICPalette** ppIPalette)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICPalette**, int>)(lpVtbl[6]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIPalette);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateFormatConverter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateFormatConverter(Graphics.Imaging.IWICFormatConverter** ppIFormatConverter)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICFormatConverter**, int>)(lpVtbl[7]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIFormatConverter);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapScaler" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateBitmapScaler(Graphics.Imaging.IWICBitmapScaler** ppIBitmapScaler)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapScaler**, int>)(lpVtbl[8]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapClipper" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateBitmapClipper(Graphics.Imaging.IWICBitmapClipper** ppIBitmapClipper)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapClipper**, int>)(lpVtbl[9]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFlipRotator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateBitmapFlipRotator(Graphics.Imaging.IWICBitmapFlipRotator** ppIBitmapFlipRotator)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapFlipRotator**, int>)(lpVtbl[10]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateStream" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateStream(Graphics.Imaging.IWICStream** ppIWICStream)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICStream**, int>)(lpVtbl[11]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICStream);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateColorContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateColorContext(Graphics.Imaging.IWICColorContext** ppIWICColorContext)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICColorContext**, int>)(lpVtbl[12]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICColorContext);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateColorTransformer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateColorTransformer(Graphics.Imaging.IWICColorTransform** ppIWICColorTransform)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICColorTransform**, int>)(lpVtbl[13]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateBitmap(uint uiWidth, uint uiHeight, Guid* pixelFormat, Graphics.Imaging.WICBitmapCreateCacheOption option, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, uint, uint, Guid*, Graphics.Imaging.WICBitmapCreateCacheOption, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[14]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromSource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateBitmapFromSource(Graphics.Imaging.IWICBitmapSource* pIBitmapSource, Graphics.Imaging.WICBitmapCreateCacheOption option, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapSource*, Graphics.Imaging.WICBitmapCreateCacheOption, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[15]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromSourceRect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateBitmapFromSourceRect(Graphics.Imaging.IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapSource*, uint, uint, uint, uint, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[16]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromMemory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, uint, uint, Guid*, uint, uint, byte*, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[17]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromHBITMAP" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateBitmapFromHBITMAP(IntPtr hBitmap, IntPtr hPalette, Graphics.Imaging.WICBitmapAlphaChannelOption options, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, IntPtr, IntPtr, Graphics.Imaging.WICBitmapAlphaChannelOption, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[18]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromHICON" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateBitmapFromHICON(IntPtr hIcon, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, IntPtr, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[19]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateComponentEnumerator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateComponentEnumerator(uint componentTypes, uint options, Com.IEnumUnknown** ppIEnumUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, uint, uint, Com.IEnumUnknown**, int>)(lpVtbl[20]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateFastMetadataEncoderFromDecoder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateFastMetadataEncoderFromDecoder(Graphics.Imaging.IWICBitmapDecoder* pIDecoder, Graphics.Imaging.IWICFastMetadataEncoder** ppIFastEncoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapDecoder*, Graphics.Imaging.IWICFastMetadataEncoder**, int>)(lpVtbl[21]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateFastMetadataEncoderFromFrameDecode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateFastMetadataEncoderFromFrameDecode(Graphics.Imaging.IWICBitmapFrameDecode* pIFrameDecoder, Graphics.Imaging.IWICFastMetadataEncoder** ppIFastEncoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapFrameDecode*, Graphics.Imaging.IWICFastMetadataEncoder**, int>)(lpVtbl[22]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateQueryWriter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateQueryWriter(Guid* guidMetadataFormat, Guid* pguidVendor, Graphics.Imaging.IWICMetadataQueryWriter** ppIQueryWriter)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Guid*, Guid*, Graphics.Imaging.IWICMetadataQueryWriter**, int>)(lpVtbl[23]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateQueryWriterFromReader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateQueryWriterFromReader(Graphics.Imaging.IWICMetadataQueryReader* pIQueryReader, Guid* pguidVendor, Graphics.Imaging.IWICMetadataQueryWriter** ppIQueryWriter)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICMetadataQueryReader*, Guid*, Graphics.Imaging.IWICMetadataQueryWriter**, int>)(lpVtbl[24]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory2::CreateImageEncoder"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateImageEncoder(Graphics.Direct2D.ID2D1Device* pD2DDevice, IWICImageEncoder** ppWICImageEncoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Direct2D.ID2D1Device*, IWICImageEncoder**, int>)(lpVtbl[25]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pD2DDevice, ppWICImageEncoder);
	}
}

