// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontDownloadListener"]/*' />
/// <unmanaged>IDWriteFontDownloadListener</unmanaged>
[Guid("b06fe5b9-43ec-4393-881b-dbe4dc72fda7")]
[NativeTypeName("struct IDWriteFontDownloadListener : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontDownloadListener : IDWriteFontDownloadListener.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontDownloadListener
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xB9, 0xE5, 0x6F, 0xB0,
				0xEC, 0x43,
				0x93, 0x43,
				0x88,
				0x1B,
				0xDB,
				0xE4,
				0xDC,
				0x72,
				0xFD,
				0xA7
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontDownloadListener));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontDownloadListener));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, uint>)(lpVtbl[1]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, uint>)(lpVtbl[2]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontDownloadListener::DownloadCompleted"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void DownloadCompleted(IDWriteFontDownloadQueue* downloadQueue, IUnknown* context, HResult downloadResult)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, IDWriteFontDownloadQueue*, IUnknown*, HResult, void>)(lpVtbl[3]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this), downloadQueue, context, downloadResult);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		void DownloadCompleted(IDWriteFontDownloadQueue* downloadQueue, IUnknown* context, HResult downloadResult);
	}
}

