// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet"]/*' />
/// <unmanaged>IDWriteFontSet</unmanaged>
[Guid("53585141-d9f8-4095-8321-d73cf6bd116b")]
[NativeTypeName("struct IDWriteFontSet : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontSet : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontSet
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x41, 0x51, 0x58, 0x53,
				0xF8, 0xD9,
				0x95, 0x40,
				0x83,
				0x21,
				0xD7,
				0x3C,
				0xF6,
				0xBD,
				0x11,
				0x6B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSet));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSet));
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

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet::GetFontCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetFontCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint>)(lpVtbl[3]))((IDWriteFontSet*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet::GetFontFaceReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFontFaceReference(uint listIndex, IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[4]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet::FindFontFaceReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, uint* listIndex, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFaceReference*, uint*, Bool32*, int>)(lpVtbl[5]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), fontFaceReference, listIndex, exists);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet::FindFontFace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult FindFontFace(IDWriteFontFace* fontFace, uint* listIndex, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFace*, uint*, Bool32*, int>)(lpVtbl[6]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), fontFace, listIndex, exists);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet::GetPropertyValues"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetPropertyValues(FontPropertyId propertyID, IDWriteStringList** values)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontPropertyId, IDWriteStringList**, int>)(lpVtbl[7]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), propertyID, values);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet::GetPropertyValues"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetPropertyValues(FontPropertyId propertyID, ushort* preferredLocaleNames, IDWriteStringList** values)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontPropertyId, ushort*, IDWriteStringList**, int>)(lpVtbl[8]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), propertyID, preferredLocaleNames, values);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet::GetPropertyValues"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetPropertyValues(uint listIndex, FontPropertyId propertyId, Bool32* exists, IDWriteLocalizedStrings** values)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint, FontPropertyId, Bool32*, IDWriteLocalizedStrings**, int>)(lpVtbl[9]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), listIndex, propertyId, exists, values);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet::GetPropertyOccurrenceCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetPropertyOccurrenceCount(FontProperty* property, uint* propertyOccurrenceCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontProperty*, uint*, int>)(lpVtbl[10]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), property, propertyOccurrenceCount);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet::GetMatchingFonts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetMatchingFonts(ushort* familyName, FontWeight fontWeight, FontStretch fontStretch, FontStyle fontStyle, IDWriteFontSet** filteredSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, ushort*, FontWeight, FontStretch, FontStyle, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), familyName, fontWeight, fontStretch, fontStyle, filteredSet);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet::GetMatchingFonts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetMatchingFonts(FontProperty* properties, uint propertyCount, IDWriteFontSet** filteredSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontProperty*, uint, IDWriteFontSet**, int>)(lpVtbl[12]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), properties, propertyCount, filteredSet);
	}
}

