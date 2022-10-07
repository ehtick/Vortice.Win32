// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap1"]/*' />
/// <unmanaged>ID2D1Bitmap1</unmanaged>
[Guid("a898a84c-3873-4588-b08b-ebbf978df041")]
[NativeTypeName("struct ID2D1Bitmap1 : ID2D1Bitmap")]
[NativeInheritance("ID2D1Bitmap")]
public unsafe partial struct ID2D1Bitmap1 : INativeGuid
{
	public static ref readonly Guid IID_ID2D1Bitmap1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4C, 0xA8, 0x98, 0xA8,
				0x73, 0x38,
				0x88, 0x45,
				0xB0,
				0x8B,
				0xEB,
				0xBF,
				0x97,
				0x8D,
				0xF0,
				0x41
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Bitmap1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Bitmap1));
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

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1Bitmap.GetSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public System.Drawing.SizeF GetSize()
	{
		System.Drawing.SizeF result;
		return *((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, System.Drawing.SizeF*, System.Drawing.SizeF*>)(lpVtbl[4]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
	}

	/// <inheritdoc cref="ID2D1Bitmap.GetPixelSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public System.Drawing.Size GetPixelSize()
	{
		System.Drawing.Size result;
		return *((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, System.Drawing.Size*, System.Drawing.Size*>)(lpVtbl[5]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
	}

	/// <inheritdoc cref="ID2D1Bitmap.GetPixelFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public Common.PixelFormat GetPixelFormat()
	{
		Common.PixelFormat result;
		return *((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Common.PixelFormat*, Common.PixelFormat*>)(lpVtbl[6]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
	}

	/// <inheritdoc cref="ID2D1Bitmap.GetDpi" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetDpi(float* dpiX, float* dpiY)
	{
		((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, float*, float*, void>)(lpVtbl[7]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}

	/// <inheritdoc cref="ID2D1Bitmap.CopyFromBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CopyFromBitmap(System.Drawing.Point* destPoint, ID2D1Bitmap* bitmap, Common.RectU* srcRect)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, System.Drawing.Point*, ID2D1Bitmap*, Common.RectU*, int>)(lpVtbl[8]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), destPoint, bitmap, srcRect);
	}

	/// <inheritdoc cref="ID2D1Bitmap.CopyFromRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CopyFromRenderTarget(System.Drawing.Point* destPoint, ID2D1RenderTarget* renderTarget, Common.RectU* srcRect)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, System.Drawing.Point*, ID2D1RenderTarget*, Common.RectU*, int>)(lpVtbl[9]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), destPoint, renderTarget, srcRect);
	}

	/// <inheritdoc cref="ID2D1Bitmap.CopyFromMemory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CopyFromMemory(Common.RectU* dstRect, void* srcData, uint pitch)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Common.RectU*, void*, uint, int>)(lpVtbl[10]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dstRect, srcData, pitch);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap1::GetColorContext"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void GetColorContext(ID2D1ColorContext** colorContext)
	{
		((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1ColorContext**, void>)(lpVtbl[11]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), colorContext);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap1::GetOptions"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public BitmapOptions GetOptions()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, BitmapOptions>)(lpVtbl[12]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap1::GetSurface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetSurface(Graphics.Dxgi.IDXGISurface** dxgiSurface)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Graphics.Dxgi.IDXGISurface**, int>)(lpVtbl[13]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dxgiSurface);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap1::Map"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult Map(MapOptions options, MappedRect* mappedRect)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, MapOptions, MappedRect*, int>)(lpVtbl[14]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), options, mappedRect);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap1::Unmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult Unmap()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, int>)(lpVtbl[15]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
	}
}

