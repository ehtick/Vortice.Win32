// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Layer"]/*' />
/// <unmanaged>ID2D1Layer</unmanaged>
[Guid("2cd9069b-12e2-11dc-9fed-001143a055f9")]
[NativeTypeName("struct ID2D1Layer : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1Layer : ID2D1Layer.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1Layer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x9B, 0x06, 0xD9, 0x2C,
				0xE2, 0x12,
				0xDC, 0x11,
				0x9F,
				0xED,
				0x00,
				0x11,
				0x43,
				0xA0,
				0x55,
				0xF9
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Layer));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Layer));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Layer*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Layer*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Layer*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Layer*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Layer*, uint>)(lpVtbl[1]))((ID2D1Layer*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Layer*, uint>)(lpVtbl[1]))((ID2D1Layer*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Layer*, uint>)(lpVtbl[2]))((ID2D1Layer*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Layer*, uint>)(lpVtbl[2]))((ID2D1Layer*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1Layer*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Layer*)Unsafe.AsPointer(ref this), factory);
#else
		((delegate* unmanaged[Stdcall]<ID2D1Layer*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Layer*)Unsafe.AsPointer(ref this), factory);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Layer::GetSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public System.Drawing.SizeF GetSize()
	{
		System.Drawing.SizeF result;
#if NET6_0_OR_GREATER
		return *((delegate* unmanaged<ID2D1Layer*, System.Drawing.SizeF*, System.Drawing.SizeF*>)(lpVtbl[4]))((ID2D1Layer*)Unsafe.AsPointer(ref this), &result);
#else
		return *((delegate* unmanaged[Stdcall]<ID2D1Layer*, System.Drawing.SizeF*, System.Drawing.SizeF*>)(lpVtbl[4]))((ID2D1Layer*)Unsafe.AsPointer(ref this), &result);
#endif
	}

	public interface Interface : ID2D1Resource.Interface
	{
		[VtblIndex(4)]
		System.Drawing.SizeF GetSize();
	}
}

