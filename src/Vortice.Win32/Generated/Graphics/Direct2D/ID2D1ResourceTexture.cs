// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='Direct2D.xml' path='doc/member[@name="ID2D1ResourceTexture"]/*' />
/// <unmanaged>ID2D1ResourceTexture</unmanaged>
[Guid("688d15c3-02b0-438d-b13a-d1b44c32c39a")]
[NativeTypeName("struct ID2D1ResourceTexture : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1ResourceTexture : INativeGuid
{
	public static ref readonly Guid IID_ID2D1ResourceTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC3, 0x15, 0x8D, 0x68,
				0xB0, 0x02,
				0x8D, 0x43,
				0xB1,
				0x3A,
				0xD1,
				0xB4,
				0x4C,
				0x32,
				0xC3,
				0x9A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ResourceTexture));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ResourceTexture));
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

	/// <include file='Direct2D.xml' path='doc/member[@name="ID2D1ResourceTexture::Update"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult Update(uint* minimumExtents, uint* maximimumExtents, uint* strides, uint dimensions, byte* data, uint dataCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)(lpVtbl[3]))((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this), minimumExtents, maximimumExtents, strides, dimensions, data, dataCount);
	}
}

