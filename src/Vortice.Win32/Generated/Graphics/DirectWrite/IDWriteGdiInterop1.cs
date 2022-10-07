// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteGdiInterop1"]/*' />
/// <unmanaged>IDWriteGdiInterop1</unmanaged>
[Guid("4556be70-3abd-4f70-90be-421780a6f515")]
[NativeTypeName("struct IDWriteGdiInterop1 : IDWriteGdiInterop")]
[NativeInheritance("IDWriteGdiInterop")]
public unsafe partial struct IDWriteGdiInterop1 : INativeGuid
{
	public static ref readonly Guid IID_IDWriteGdiInterop1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x70, 0xBE, 0x56, 0x45,
				0xBD, 0x3A,
				0x70, 0x4F,
				0x90,
				0xBE,
				0x42,
				0x17,
				0x80,
				0xA6,
				0xF5,
				0x15
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteGdiInterop1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteGdiInterop1));
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

	/// <inheritdoc cref="IDWriteGdiInterop.CreateFontFromLOGFONT" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateFontFromLOGFONT(Win32.Graphics.Gdi.LogFontW* logFont, IDWriteFont** font)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Win32.Graphics.Gdi.LogFontW*, IDWriteFont**, int>)(lpVtbl[3]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, font);
	}

	/// <inheritdoc cref="IDWriteGdiInterop.ConvertFontToLOGFONT" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult ConvertFontToLOGFONT(IDWriteFont* font, Win32.Graphics.Gdi.LogFontW** logFont, Bool32* isSystemFont)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, Win32.Graphics.Gdi.LogFontW**, Bool32*, int>)(lpVtbl[4]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont, isSystemFont);
	}

	/// <inheritdoc cref="IDWriteGdiInterop.ConvertFontFaceToLOGFONT" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult ConvertFontFaceToLOGFONT(IDWriteFontFace* font, Win32.Graphics.Gdi.LogFontW** logFont)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFontFace*, Win32.Graphics.Gdi.LogFontW**, int>)(lpVtbl[5]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont);
	}

	/// <inheritdoc cref="IDWriteGdiInterop.CreateFontFaceFromHdc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateFontFaceFromHdc(IntPtr hdc, IDWriteFontFace** fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IntPtr, IDWriteFontFace**, int>)(lpVtbl[6]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, fontFace);
	}

	/// <inheritdoc cref="IDWriteGdiInterop.CreateBitmapRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateBitmapRenderTarget(IntPtr hdc, uint width, uint height, IDWriteBitmapRenderTarget** renderTarget)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IntPtr, uint, uint, IDWriteBitmapRenderTarget**, int>)(lpVtbl[7]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, width, height, renderTarget);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteGdiInterop1::CreateFontFromLOGFONT"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateFontFromLOGFONT(Win32.Graphics.Gdi.LogFontW* logFont, IDWriteFontCollection* fontCollection, IDWriteFont** font)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Win32.Graphics.Gdi.LogFontW*, IDWriteFontCollection*, IDWriteFont**, int>)(lpVtbl[8]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontCollection, font);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteGdiInterop1::GetFontSignature"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetFontSignature(IDWriteFontFace* fontFace, Win32.Graphics.Gdi.FontSignature** fontSignature)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFontFace*, Win32.Graphics.Gdi.FontSignature**, int>)(lpVtbl[9]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), fontFace, fontSignature);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteGdiInterop1::GetFontSignature"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFontSignature(IDWriteFont* font, Win32.Graphics.Gdi.FontSignature** fontSignature)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, Win32.Graphics.Gdi.FontSignature**, int>)(lpVtbl[10]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, fontSignature);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteGdiInterop1::GetMatchingFontsByLOGFONT"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetMatchingFontsByLOGFONT(Win32.Graphics.Gdi.LogFontA* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Win32.Graphics.Gdi.LogFontA*, IDWriteFontSet*, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontSet, filteredSet);
	}
}

