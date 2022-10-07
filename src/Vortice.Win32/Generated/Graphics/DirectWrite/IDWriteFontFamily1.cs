// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFontFamily1"]/*' />
/// <unmanaged>IDWriteFontFamily1</unmanaged>
[Guid("da20d8ef-812a-4c43-9802-62ec4abd7adf")]
[NativeTypeName("struct IDWriteFontFamily1 : IDWriteFontFamily")]
[NativeInheritance("IDWriteFontFamily")]
public unsafe partial struct IDWriteFontFamily1 : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontFamily1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xEF, 0xD8, 0x20, 0xDA,
				0x2A, 0x81,
				0x43, 0x4C,
				0x98,
				0x02,
				0x62,
				0xEC,
				0x4A,
				0xBD,
				0x7A,
				0xDF
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFamily1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFamily1));
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

	/// <inheritdoc cref="IDWriteFontList.GetFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetFontCollection(IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, IDWriteFontCollection**, int>)(lpVtbl[3]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), fontCollection);
	}

	/// <inheritdoc cref="IDWriteFontList.GetFontCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public uint GetFontCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint>)(lpVtbl[4]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontList.GetFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetFont(uint index, IDWriteFont** font)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint, IDWriteFont**, int>)(lpVtbl[5]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), index, font);
	}

	/// <inheritdoc cref="IDWriteFontFamily.GetFamilyNames" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetFamilyNames(IDWriteLocalizedStrings** names)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, IDWriteLocalizedStrings**, int>)(lpVtbl[6]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), names);
	}

	/// <inheritdoc cref="IDWriteFontFamily.GetFirstMatchingFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetFirstMatchingFont(FontWeight weight, FontStretch stretch, FontStyle style, IDWriteFont** matchingFont)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, FontWeight, FontStretch, FontStyle, IDWriteFont**, int>)(lpVtbl[7]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), weight, stretch, style, matchingFont);
	}

	/// <inheritdoc cref="IDWriteFontFamily.GetMatchingFonts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetMatchingFonts(FontWeight weight, FontStretch stretch, FontStyle style, IDWriteFontList** matchingFonts)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, FontWeight, FontStretch, FontStyle, IDWriteFontList**, int>)(lpVtbl[8]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), weight, stretch, style, matchingFonts);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFontFamily1::GetFontLocality"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public Locality GetFontLocality(uint listIndex)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint, Locality>)(lpVtbl[9]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), listIndex);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFontFamily1::GetFont"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFont(uint listIndex, IDWriteFont3** font)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint, IDWriteFont3**, int>)(lpVtbl[10]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), listIndex, font);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFontFamily1::GetFontFaceReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFontFaceReference(uint listIndex, IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[11]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
	}
}

