// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GdiMetafile"]/*' />
/// <unmanaged>ID2D1GdiMetafile</unmanaged>
[Guid("2f543dc3-cfc1-4211-864f-cfd91c6f3395")]
[NativeTypeName("struct ID2D1GdiMetafile : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1GdiMetafile : ID2D1GdiMetafile.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1GdiMetafile
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC3, 0x3D, 0x54, 0x2F,
				0xC1, 0xCF,
				0x11, 0x42,
				0x86,
				0x4F,
				0xCF,
				0xD9,
				0x1C,
				0x6F,
				0x33,
				0x95
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GdiMetafile));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GdiMetafile));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1GdiMetafile*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1GdiMetafile*, uint>)(lpVtbl[1]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile*, uint>)(lpVtbl[1]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1GdiMetafile*, uint>)(lpVtbl[2]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile*, uint>)(lpVtbl[2]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1GdiMetafile*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), factory);
#else
		((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), factory);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GdiMetafile::Stream"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult Stream(ID2D1GdiMetafileSink* sink)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1GdiMetafile*, ID2D1GdiMetafileSink*, int>)(lpVtbl[4]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), sink);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile*, ID2D1GdiMetafileSink*, int>)(lpVtbl[4]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), sink);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GdiMetafile::GetBounds"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetBounds(Win32.Numerics.RectF** bounds)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1GdiMetafile*, Win32.Numerics.RectF**, int>)(lpVtbl[5]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), bounds);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile*, Win32.Numerics.RectF**, int>)(lpVtbl[5]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), bounds);
#endif
	}

	public interface Interface : ID2D1Resource.Interface
	{
		[VtblIndex(4)]
		HResult Stream(ID2D1GdiMetafileSink* sink);

		[VtblIndex(5)]
		HResult GetBounds(Win32.Numerics.RectF** bounds);
	}
}

