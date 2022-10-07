// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFontFallback1"]/*' />
/// <unmanaged>IDWriteFontFallback1</unmanaged>
[Guid("2397599d-dd0d-4681-bd6a-f4f31eaade77")]
[NativeTypeName("struct IDWriteFontFallback1 : IDWriteFontFallback")]
[NativeInheritance("IDWriteFontFallback")]
public unsafe partial struct IDWriteFontFallback1 : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontFallback1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x9D, 0x59, 0x97, 0x23,
				0x0D, 0xDD,
				0x81, 0x46,
				0xBD,
				0x6A,
				0xF4,
				0xF3,
				0x1E,
				0xAA,
				0xDE,
				0x77
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFallback1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFallback1));
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

	/// <inheritdoc cref="IDWriteFontFallback.MapCharacters" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, ushort* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, ushort*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)(lpVtbl[3]))((IDWriteFontFallback1*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFontFallback1::MapCharacters"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, ushort* baseFamilyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, uint* mappedLength, float* scale, IDWriteFontFace5** mappedFontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, ushort*, FontAxisValue*, uint, uint*, float*, IDWriteFontFace5**, int>)(lpVtbl[4]))((IDWriteFontFallback1*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, fontAxisValues, fontAxisValueCount, mappedLength, scale, mappedFontFace);
	}
}

