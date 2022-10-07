// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory"]/*' />
/// <unmanaged>IWICImagingFactory</unmanaged>
[Guid("ec5ec8a9-c395-4314-9c77-54d7a935ff70")]
[NativeTypeName("struct IWICImagingFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICImagingFactory : INativeGuid
{
	public static ref readonly Guid IID_IWICImagingFactory
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA9, 0xC8, 0x5E, 0xEC,
				0x95, 0xC3,
				0x14, 0x43,
				0x9C,
				0x77,
				0x54,
				0xD7,
				0xA9,
				0x35,
				0xFF,
				0x70
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImagingFactory));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImagingFactory));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateDecoderFromFilename"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateDecoderFromFilename(ushort* wzFilename, Guid* pguidVendor, NativeFileAccess dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, ushort*, Guid*, NativeFileAccess, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[3]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateDecoderFromStream"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateDecoderFromStream(Com.IStream* pIStream, Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Com.IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[4]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateDecoderFromFileHandle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateDecoderFromFileHandle(nuint hFile, Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, nuint, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[5]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateComponentInfo"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateComponentInfo(Guid* clsidComponent, IWICComponentInfo** ppIInfo)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, IWICComponentInfo**, int>)(lpVtbl[6]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateDecoder"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateDecoder(Guid* guidContainerFormat, Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)(lpVtbl[7]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateEncoder"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateEncoder(Guid* guidContainerFormat, Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)(lpVtbl[8]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreatePalette"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreatePalette(IWICPalette** ppIPalette)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICPalette**, int>)(lpVtbl[9]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIPalette);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateFormatConverter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateFormatConverter(IWICFormatConverter** ppIFormatConverter)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICFormatConverter**, int>)(lpVtbl[10]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIFormatConverter);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateBitmapScaler"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapScaler**, int>)(lpVtbl[11]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateBitmapClipper"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapClipper**, int>)(lpVtbl[12]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateBitmapFlipRotator"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFlipRotator**, int>)(lpVtbl[13]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateStream"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateStream(IWICStream** ppIWICStream)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICStream**, int>)(lpVtbl[14]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICStream);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateColorContext"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateColorContext(IWICColorContext** ppIWICColorContext)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICColorContext**, int>)(lpVtbl[15]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICColorContext);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateColorTransformer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateColorTransformer(IWICColorTransform** ppIWICColorTransform)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICColorTransform**, int>)(lpVtbl[16]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateBitmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateBitmap(uint uiWidth, uint uiHeight, Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[17]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateBitmapFromSource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[18]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateBitmapFromSourceRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)(lpVtbl[19]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateBitmapFromMemory"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)(lpVtbl[20]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateBitmapFromHBITMAP"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateBitmapFromHBITMAP(IntPtr hBitmap, IntPtr hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr, IntPtr, WICBitmapAlphaChannelOption, IWICBitmap**, int>)(lpVtbl[21]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateBitmapFromHICON"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateBitmapFromHICON(IntPtr hIcon, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr, IWICBitmap**, int>)(lpVtbl[22]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateComponentEnumerator"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateComponentEnumerator(uint componentTypes, uint options, Com.IEnumUnknown** ppIEnumUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Com.IEnumUnknown**, int>)(lpVtbl[23]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateFastMetadataEncoderFromDecoder"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)(lpVtbl[24]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateFastMetadataEncoderFromFrameDecode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)(lpVtbl[25]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateQueryWriter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult CreateQueryWriter(Guid* guidMetadataFormat, Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[26]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
	}

	/// <include file='Imaging.xml' path='doc/member[@name="IWICImagingFactory::CreateQueryWriterFromReader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
	{
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[27]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
	}
}

