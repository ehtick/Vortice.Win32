// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDecodeSwapChain"]/*' />
/// <unmanaged>IDXGIDecodeSwapChain</unmanaged>
[Guid("2633066b-4514-4c7a-8fd8-12ea98059d18")]
[NativeTypeName("struct IDXGIDecodeSwapChain : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGIDecodeSwapChain : INativeGuid
{
	public static ref readonly Guid IID_IDXGIDecodeSwapChain
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x6B, 0x06, 0x33, 0x26,
				0x14, 0x45,
				0x7A, 0x4C,
				0x8F,
				0xD8,
				0x12,
				0xEA,
				0x98,
				0x05,
				0x9D,
				0x18
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDecodeSwapChain));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDecodeSwapChain));
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

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDecodeSwapChain::PresentBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult PresentBuffer(uint BufferToPresent, uint SyncInterval, uint Flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint, uint, uint, int>)(lpVtbl[3]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), BufferToPresent, SyncInterval, Flags);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDecodeSwapChain::SetSourceRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetSourceRect(RawRect* pRect)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, RawRect*, int>)(lpVtbl[4]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDecodeSwapChain::SetTargetRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetTargetRect(RawRect* pRect)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, RawRect*, int>)(lpVtbl[5]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDecodeSwapChain::SetDestSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetDestSize(uint Width, uint Height)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint, uint, int>)(lpVtbl[6]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), Width, Height);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDecodeSwapChain::GetSourceRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetSourceRect(RawRect* pRect)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, RawRect*, int>)(lpVtbl[7]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDecodeSwapChain::GetTargetRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetTargetRect(RawRect* pRect)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, RawRect*, int>)(lpVtbl[8]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDecodeSwapChain::GetDestSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetDestSize(uint* pWidth, uint* pHeight)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint*, uint*, int>)(lpVtbl[9]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pWidth, pHeight);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDecodeSwapChain::SetColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetColorSpace(MultiplaneOverlayYcbcrFlags ColorSpace)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, MultiplaneOverlayYcbcrFlags, int>)(lpVtbl[10]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), ColorSpace);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDecodeSwapChain::GetColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public MultiplaneOverlayYcbcrFlags GetColorSpace()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, MultiplaneOverlayYcbcrFlags>)(lpVtbl[11]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
	}
}

