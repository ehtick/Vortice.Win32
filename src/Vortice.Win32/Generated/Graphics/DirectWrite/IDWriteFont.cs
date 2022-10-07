// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont"]/*' />
/// <unmanaged>IDWriteFont</unmanaged>
[Guid("acd16696-8c14-4f5d-877e-fe3fc1d32737")]
[NativeTypeName("struct IDWriteFont : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFont : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFont
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x96, 0x66, 0xD1, 0xAC,
				0x14, 0x8C,
				0x5D, 0x4F,
				0x87,
				0x7E,
				0xFE,
				0x3F,
				0xC1,
				0xD3,
				0x27,
				0x37
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFont));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFont));
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

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::GetFontFamily"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetFontFamily(IDWriteFontFamily** fontFamily)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont*, IDWriteFontFamily**, int>)(lpVtbl[3]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontFamily);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::GetWeight"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public FontWeight GetWeight()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont*, FontWeight>)(lpVtbl[4]))((IDWriteFont*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::GetStretch"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public FontStretch GetStretch()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont*, FontStretch>)(lpVtbl[5]))((IDWriteFont*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::GetStyle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public FontStyle GetStyle()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont*, FontStyle>)(lpVtbl[6]))((IDWriteFont*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::IsSymbolFont"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public Bool32 IsSymbolFont()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont*, Bool32>)(lpVtbl[7]))((IDWriteFont*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::GetFaceNames"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetFaceNames(IDWriteLocalizedStrings** names)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont*, IDWriteLocalizedStrings**, int>)(lpVtbl[8]))((IDWriteFont*)Unsafe.AsPointer(ref this), names);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::GetInformationalStrings"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetInformationalStrings(InformationalStringId informationalStringID, IDWriteLocalizedStrings** informationalStrings, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont*, InformationalStringId, IDWriteLocalizedStrings**, Bool32*, int>)(lpVtbl[9]))((IDWriteFont*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::GetSimulations"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public FontSimulations GetSimulations()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont*, FontSimulations>)(lpVtbl[10]))((IDWriteFont*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::GetMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void GetMetrics(FontMetrics* fontMetrics)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFont*, FontMetrics*, void>)(lpVtbl[11]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontMetrics);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::HasCharacter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult HasCharacter(uint unicodeValue, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont*, uint, Bool32*, int>)(lpVtbl[12]))((IDWriteFont*)Unsafe.AsPointer(ref this), unicodeValue, exists);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFont::CreateFontFace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateFontFace(IDWriteFontFace** fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont*, IDWriteFontFace**, int>)(lpVtbl[13]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontFace);
	}
}

