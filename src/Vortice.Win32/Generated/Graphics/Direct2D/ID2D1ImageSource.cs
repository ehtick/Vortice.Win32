// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='Direct2D.xml' path='doc/member[@name="ID2D1ImageSource"]/*' />
/// <unmanaged>ID2D1ImageSource</unmanaged>
[Guid("c9b664e5-74a1-4378-9ac2-eefc37a3f4d8")]
[NativeTypeName("struct ID2D1ImageSource : ID2D1Image")]
[NativeInheritance("ID2D1Image")]
public unsafe partial struct ID2D1ImageSource : INativeGuid
{
	public static ref readonly Guid IID_ID2D1ImageSource
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xE5, 0x64, 0xB6, 0xC9,
				0xA1, 0x74,
				0x78, 0x43,
				0x9A,
				0xC2,
				0xEE,
				0xFC,
				0x37,
				0xA3,
				0xF4,
				0xD8
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ImageSource));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ImageSource));
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

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageSource*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this), factory);
	}

	/// <include file='Direct2D.xml' path='doc/member[@name="ID2D1ImageSource::OfferResources"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult OfferResources()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageSource*, int>)(lpVtbl[4]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this));
	}

	/// <include file='Direct2D.xml' path='doc/member[@name="ID2D1ImageSource::TryReclaimResources"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult TryReclaimResources(Bool32* resourcesDiscarded)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageSource*, Bool32*, int>)(lpVtbl[5]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this), resourcesDiscarded);
	}
}

