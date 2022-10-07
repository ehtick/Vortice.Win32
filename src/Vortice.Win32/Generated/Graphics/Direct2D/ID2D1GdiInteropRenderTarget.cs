// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GdiInteropRenderTarget"]/*' />
/// <unmanaged>ID2D1GdiInteropRenderTarget</unmanaged>
[Guid("e0db51c3-6f77-4bae-b3d5-e47509b35838")]
[NativeTypeName("struct ID2D1GdiInteropRenderTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1GdiInteropRenderTarget : INativeGuid
{
	public static ref readonly Guid IID_ID2D1GdiInteropRenderTarget
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC3, 0x51, 0xDB, 0xE0,
				0x77, 0x6F,
				0xAE, 0x4B,
				0xB3,
				0xD5,
				0xE4,
				0x75,
				0x09,
				0xB3,
				0x58,
				0x38
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GdiInteropRenderTarget));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GdiInteropRenderTarget));
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

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GdiInteropRenderTarget::GetDC"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetDC(DCInitializeMode mode, IntPtr* hdc)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, DCInitializeMode, IntPtr*, int>)(lpVtbl[3]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), mode, hdc);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GdiInteropRenderTarget::ReleaseDC"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult ReleaseDC(RawRect* update)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, RawRect*, int>)(lpVtbl[4]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), update);
	}
}

