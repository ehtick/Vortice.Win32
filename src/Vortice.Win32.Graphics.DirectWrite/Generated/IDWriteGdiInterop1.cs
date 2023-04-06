// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteGdiInterop1"]/*' />
/// <unmanaged>IDWriteGdiInterop1</unmanaged>
[Guid("4556be70-3abd-4f70-90be-421780a6f515")]
[NativeTypeName("struct IDWriteGdiInterop1 : IDWriteGdiInterop")]
[NativeInheritance("IDWriteGdiInterop")]
public unsafe partial struct IDWriteGdiInterop1 : IDWriteGdiInterop1.Interface, INativeGuid
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
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, uint>)(lpVtbl[1]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, uint>)(lpVtbl[1]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, uint>)(lpVtbl[2]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, uint>)(lpVtbl[2]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteGdiInterop.CreateFontFromLOGFONT" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateFontFromLOGFONT(Win32.Graphics.Gdi.LogFontW* logFont, IDWriteFont** font)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, Win32.Graphics.Gdi.LogFontW*, IDWriteFont**, int>)(lpVtbl[3]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, font);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Win32.Graphics.Gdi.LogFontW*, IDWriteFont**, int>)(lpVtbl[3]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, font);
#endif
	}

	/// <inheritdoc cref="IDWriteGdiInterop.ConvertFontToLOGFONT" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult ConvertFontToLOGFONT(IDWriteFont* font, Win32.Graphics.Gdi.LogFontW** logFont, Bool32* isSystemFont)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFont*, Win32.Graphics.Gdi.LogFontW**, Bool32*, int>)(lpVtbl[4]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont, isSystemFont);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, Win32.Graphics.Gdi.LogFontW**, Bool32*, int>)(lpVtbl[4]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont, isSystemFont);
#endif
	}

	/// <inheritdoc cref="IDWriteGdiInterop.ConvertFontFaceToLOGFONT" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult ConvertFontFaceToLOGFONT(IDWriteFontFace* font, Win32.Graphics.Gdi.LogFontW** logFont)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFontFace*, Win32.Graphics.Gdi.LogFontW**, int>)(lpVtbl[5]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFontFace*, Win32.Graphics.Gdi.LogFontW**, int>)(lpVtbl[5]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont);
#endif
	}

	/// <inheritdoc cref="IDWriteGdiInterop.CreateFontFaceFromHdc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateFontFaceFromHdc(IntPtr hdc, IDWriteFontFace** fontFace)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, IntPtr, IDWriteFontFace**, int>)(lpVtbl[6]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, fontFace);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IntPtr, IDWriteFontFace**, int>)(lpVtbl[6]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, fontFace);
#endif
	}

	/// <inheritdoc cref="IDWriteGdiInterop.CreateBitmapRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateBitmapRenderTarget(IntPtr hdc, uint width, uint height, IDWriteBitmapRenderTarget** renderTarget)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, IntPtr, uint, uint, IDWriteBitmapRenderTarget**, int>)(lpVtbl[7]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, width, height, renderTarget);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IntPtr, uint, uint, IDWriteBitmapRenderTarget**, int>)(lpVtbl[7]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, width, height, renderTarget);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteGdiInterop1::CreateFontFromLOGFONT"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateFontFromLOGFONT(Win32.Graphics.Gdi.LogFontW* logFont, IDWriteFontCollection* fontCollection, IDWriteFont** font)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, Win32.Graphics.Gdi.LogFontW*, IDWriteFontCollection*, IDWriteFont**, int>)(lpVtbl[8]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontCollection, font);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Win32.Graphics.Gdi.LogFontW*, IDWriteFontCollection*, IDWriteFont**, int>)(lpVtbl[8]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontCollection, font);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteGdiInterop1::GetFontSignature"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetFontSignature(IDWriteFontFace* fontFace, Win32.Graphics.Gdi.FontSignature** fontSignature)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFontFace*, Win32.Graphics.Gdi.FontSignature**, int>)(lpVtbl[9]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), fontFace, fontSignature);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFontFace*, Win32.Graphics.Gdi.FontSignature**, int>)(lpVtbl[9]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), fontFace, fontSignature);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteGdiInterop1::GetFontSignature"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFontSignature(IDWriteFont* font, Win32.Graphics.Gdi.FontSignature** fontSignature)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFont*, Win32.Graphics.Gdi.FontSignature**, int>)(lpVtbl[10]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, fontSignature);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, Win32.Graphics.Gdi.FontSignature**, int>)(lpVtbl[10]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, fontSignature);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteGdiInterop1::GetMatchingFontsByLOGFONT"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetMatchingFontsByLOGFONT(Win32.Graphics.Gdi.LogFontA* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteGdiInterop1*, Win32.Graphics.Gdi.LogFontA*, IDWriteFontSet*, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontSet, filteredSet);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Win32.Graphics.Gdi.LogFontA*, IDWriteFontSet*, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontSet, filteredSet);
#endif
	}

	public interface Interface : IDWriteGdiInterop.Interface
	{
		[VtblIndex(8)]
		HResult CreateFontFromLOGFONT(Win32.Graphics.Gdi.LogFontW* logFont, IDWriteFontCollection* fontCollection, IDWriteFont** font);

		[VtblIndex(9)]
		HResult GetFontSignature(IDWriteFontFace* fontFace, Win32.Graphics.Gdi.FontSignature** fontSignature);

		[VtblIndex(10)]
		HResult GetFontSignature(IDWriteFont* font, Win32.Graphics.Gdi.FontSignature** fontSignature);

		[VtblIndex(11)]
		HResult GetMatchingFontsByLOGFONT(Win32.Graphics.Gdi.LogFontA* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet);
	}
}

