// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFallbackBuilder"]/*' />
/// <unmanaged>IDWriteFontFallbackBuilder</unmanaged>
[Guid("fd882d06-8aba-4fb8-b849-8be8b73e14de")]
[NativeTypeName("struct IDWriteFontFallbackBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontFallbackBuilder : IDWriteFontFallbackBuilder.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontFallbackBuilder
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x06, 0x2D, 0x88, 0xFD,
				0xBA, 0x8A,
				0xB8, 0x4F,
				0xB8,
				0x49,
				0x8B,
				0xE8,
				0xB7,
				0x3E,
				0x14,
				0xDE
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFallbackBuilder));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFallbackBuilder));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, uint>)(lpVtbl[1]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)(lpVtbl[1]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, uint>)(lpVtbl[2]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)(lpVtbl[2]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFallbackBuilder::AddMapping"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult AddMapping(UnicodeRange* ranges, uint rangesCount, ushort** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, ushort* localeName, ushort* baseFamilyName, float scale)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, ushort**, uint, IDWriteFontCollection*, ushort*, ushort*, float, int>)(lpVtbl[3]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, ushort**, uint, IDWriteFontCollection*, ushort*, ushort*, float, int>)(lpVtbl[3]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFallbackBuilder::AddMappings"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult AddMappings(IDWriteFontFallback* fontFallback)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int>)(lpVtbl[4]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), fontFallback);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int>)(lpVtbl[4]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), fontFallback);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFallbackBuilder::CreateFontFallback"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateFontFallback(IDWriteFontFallback** fontFallback)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int>)(lpVtbl[5]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), fontFallback);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int>)(lpVtbl[5]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), fontFallback);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult AddMapping(UnicodeRange* ranges, uint rangesCount, ushort** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, ushort* localeName, ushort* baseFamilyName, float scale);

		[VtblIndex(4)]
		HResult AddMappings(IDWriteFontFallback* fontFallback);

		[VtblIndex(5)]
		HResult CreateFontFallback(IDWriteFontFallback** fontFallback);
	}
}

