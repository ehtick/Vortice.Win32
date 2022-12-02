// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICColorTransform"]/*' />
/// <unmanaged>IWICColorTransform</unmanaged>
[Guid("b66f034f-d0e2-40ab-b436-6de39e321a94")]
[NativeTypeName("struct IWICColorTransform : IWICBitmapSource")]
[NativeInheritance("IWICBitmapSource")]
public unsafe partial struct IWICColorTransform : IWICColorTransform.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICColorTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4F, 0x03, 0x6F, 0xB6,
				0xE2, 0xD0,
				0xAB, 0x40,
				0xB4,
				0x36,
				0x6D,
				0xE3,
				0x9E,
				0x32,
				0x1A,
				0x94
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICColorTransform));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICColorTransform));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, void**, int>)(lpVtbl[0]))((IWICColorTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint>)(lpVtbl[1]))((IWICColorTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint>)(lpVtbl[2]))((IWICColorTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IWICBitmapSource.GetSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetSize(uint* puiWidth, uint* puiHeight)
	{
		return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint*, uint*, int>)(lpVtbl[3]))((IWICColorTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
	}

	/// <inheritdoc cref="IWICBitmapSource.GetPixelFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPixelFormat(Guid* pPixelFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, int>)(lpVtbl[4]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pPixelFormat);
	}

	/// <inheritdoc cref="IWICBitmapSource.GetResolution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetResolution(double* pDpiX, double* pDpiY)
	{
		return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, double*, double*, int>)(lpVtbl[5]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
	}

	/// <inheritdoc cref="IWICBitmapSource.CopyPalette" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CopyPalette(IWICPalette* pIPalette)
	{
		return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICPalette*, int>)(lpVtbl[6]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pIPalette);
	}

	/// <inheritdoc cref="IWICBitmapSource.CopyPixels" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CopyPixels(System.Drawing.Rectangle* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
	{
		return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, System.Drawing.Rectangle*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICColorTransform*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICColorTransform::Initialize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Initialize(IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
	{
		return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)(lpVtbl[8]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pIBitmapSource, pIContextSource, pIContextDest, pixelFmtDest);
	}

	public interface Interface : IWICBitmapSource.Interface
	{
		[VtblIndex(8)]
		HResult Initialize(IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest);
	}
}

