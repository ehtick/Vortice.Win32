// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollection3"]/*' />
/// <unmanaged>IDWriteFontCollection3</unmanaged>
[Guid("a4d055a6-f9e3-4e25-93b7-9e309f3af8e9")]
[NativeTypeName("struct IDWriteFontCollection3 : IDWriteFontCollection2")]
[NativeInheritance("IDWriteFontCollection2")]
public unsafe partial struct IDWriteFontCollection3 : IDWriteFontCollection3.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontCollection3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA6, 0x55, 0xD0, 0xA4,
				0xE3, 0xF9,
				0x25, 0x4E,
				0x93,
				0xB7,
				0x9E,
				0x30,
				0x9F,
				0x3A,
				0xF8,
				0xE9
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollection3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollection3));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, uint>)(lpVtbl[1]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint>)(lpVtbl[1]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, uint>)(lpVtbl[2]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint>)(lpVtbl[2]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontCollection.GetFontFamilyCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetFontFamilyCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, uint>)(lpVtbl[3]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint>)(lpVtbl[3]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontCollection.GetFontFamily" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFontFamily(uint index, IDWriteFontFamily** fontFamily)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, uint, IDWriteFontFamily**, int>)(lpVtbl[4]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint, IDWriteFontFamily**, int>)(lpVtbl[4]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
#endif
	}

	/// <inheritdoc cref="IDWriteFontCollection.FindFamilyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult FindFamilyName(ushort* familyName, uint* index, Bool32* exists)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, ushort*, uint*, Bool32*, int>)(lpVtbl[5]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), familyName, index, exists);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, ushort*, uint*, Bool32*, int>)(lpVtbl[5]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), familyName, index, exists);
#endif
	}

	/// <inheritdoc cref="IDWriteFontCollection.GetFontFromFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, IDWriteFontFace*, IDWriteFont**, int>)(lpVtbl[6]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontFace, font);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, IDWriteFontFace*, IDWriteFont**, int>)(lpVtbl[6]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontFace, font);
#endif
	}

	/// <inheritdoc cref="IDWriteFontCollection1.GetFontSet" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetFontSet(IDWriteFontSet** fontSet)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, IDWriteFontSet**, int>)(lpVtbl[7]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontSet);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, IDWriteFontSet**, int>)(lpVtbl[7]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontSet);
#endif
	}

	/// <inheritdoc cref="IDWriteFontCollection1.GetFontFamily" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetFontFamily(uint index, IDWriteFontFamily1** fontFamily)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, uint, IDWriteFontFamily1**, int>)(lpVtbl[8]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint, IDWriteFontFamily1**, int>)(lpVtbl[8]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
#endif
	}

	/// <inheritdoc cref="IDWriteFontCollection2.GetFontFamily" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetFontFamily(uint index, IDWriteFontFamily2** fontFamily)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, uint, IDWriteFontFamily2**, int>)(lpVtbl[9]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint, IDWriteFontFamily2**, int>)(lpVtbl[9]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
#endif
	}

	/// <inheritdoc cref="IDWriteFontCollection2.GetMatchingFonts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetMatchingFonts(ushort* familyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, ushort*, FontAxisValue*, uint, IDWriteFontList2**, int>)(lpVtbl[10]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, fontList);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, ushort*, FontAxisValue*, uint, IDWriteFontList2**, int>)(lpVtbl[10]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, fontList);
#endif
	}

	/// <inheritdoc cref="IDWriteFontCollection2.GetFontFamilyModel" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public FontFamilyModel GetFontFamilyModel()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, FontFamilyModel>)(lpVtbl[11]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, FontFamilyModel>)(lpVtbl[11]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontCollection2.GetFontSet" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetFontSet(IDWriteFontSet1** fontSet)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, IDWriteFontSet1**, int>)(lpVtbl[12]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontSet);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, IDWriteFontSet1**, int>)(lpVtbl[12]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontSet);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollection3::GetExpirationEvent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public Handle GetExpirationEvent()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontCollection3*, Handle>)(lpVtbl[13]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, Handle>)(lpVtbl[13]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
#endif
	}

	public interface Interface : IDWriteFontCollection2.Interface
	{
		[VtblIndex(13)]
		Handle GetExpirationEvent();
	}
}

