// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteLocalFontFileLoader"]/*' />
/// <unmanaged>IDWriteLocalFontFileLoader</unmanaged>
[Guid("b2d9f3ec-c9fe-4a11-a2ec-d86208f7c0a2")]
[NativeTypeName("struct IDWriteLocalFontFileLoader : IDWriteFontFileLoader")]
[NativeInheritance("IDWriteFontFileLoader")]
public unsafe partial struct IDWriteLocalFontFileLoader : INativeGuid
{
	public static ref readonly Guid IID_IDWriteLocalFontFileLoader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xEC, 0xF3, 0xD9, 0xB2,
				0xFE, 0xC9,
				0x11, 0x4A,
				0xA2,
				0xEC,
				0xD8,
				0x62,
				0x08,
				0xF7,
				0xC0,
				0xA2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteLocalFontFileLoader));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteLocalFontFileLoader));
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

	/// <inheritdoc cref="IDWriteFontFileLoader.CreateStreamFromKey" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateStreamFromKey(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[3]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteLocalFontFileLoader::GetFilePathLengthFromKey"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFilePathLengthFromKey(void* fontFileReferenceKey, uint fontFileReferenceKeySize, uint* filePathLength)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, uint*, int>)(lpVtbl[4]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, filePathLength);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteLocalFontFileLoader::GetFilePathFromKey"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetFilePathFromKey(void* fontFileReferenceKey, uint fontFileReferenceKeySize, ushort* filePath, uint filePathSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, ushort*, uint, int>)(lpVtbl[5]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, filePath, filePathSize);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteLocalFontFileLoader::GetLastWriteTimeFromKey"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetLastWriteTimeFromKey(void* fontFileReferenceKey, uint fontFileReferenceKeySize, ulong* lastWriteTime)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, ulong*, int>)(lpVtbl[6]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, lastWriteTime);
	}
}

