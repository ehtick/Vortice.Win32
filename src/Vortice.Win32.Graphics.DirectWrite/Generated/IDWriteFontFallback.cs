// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFallback"]/*' />
/// <unmanaged>IDWriteFontFallback</unmanaged>
[Guid("efa008f9-f7a1-48bf-b05c-f224713cc0ff")]
[NativeTypeName("struct IDWriteFontFallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontFallback : IDWriteFontFallback.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontFallback
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF9, 0x08, 0xA0, 0xEF,
				0xA1, 0xF7,
				0xBF, 0x48,
				0xB0,
				0x5C,
				0xF2,
				0x24,
				0x71,
				0x3C,
				0xC0,
				0xFF
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFallback));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFallback));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFallback*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallback*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFallback*, uint>)(lpVtbl[1]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallback*, uint>)(lpVtbl[1]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFallback*, uint>)(lpVtbl[2]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallback*, uint>)(lpVtbl[2]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFallback::MapCharacters"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, ushort* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFallback*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, ushort*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)(lpVtbl[3]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallback*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, ushort*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)(lpVtbl[3]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, ushort* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale);
	}
}

