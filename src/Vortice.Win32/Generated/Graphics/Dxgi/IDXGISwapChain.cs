// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.Dxgi;

/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain"]/*' />
/// <unmanaged>IDXGISwapChain</unmanaged>
[Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
[NativeTypeName("struct IDXGISwapChain : IDXGIDeviceSubObject")]
[NativeInheritance("IDXGIDeviceSubObject")]
public unsafe partial struct IDXGISwapChain
{
	public static ref readonly Guid IID_IDXGISwapChain
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA0, 0x36, 0x0D, 0x31,
				0xE7, 0xD2,
				0x0A, 0x4C,
				0xAA,
				0x04,
				0x6A,
				0x9D,
				0x23,
				0xB8,
				0x88,
				0x6A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChain));

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

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppDevice)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), riid, ppDevice);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain::Present"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Present(uint SyncInterval, PresentFlags Flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, uint, PresentFlags, int>)(lpVtbl[8]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain::GetBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, uint, Guid*, void**, int>)(lpVtbl[9]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain::SetFullscreenState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetFullscreenState(Bool32 Fullscreen, IDXGIOutput* pTarget)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, Bool32, IDXGIOutput*, int>)(lpVtbl[10]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain::GetFullscreenState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFullscreenState(Bool32* pFullscreen, IDXGIOutput** ppTarget)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, Bool32*, IDXGIOutput**, int>)(lpVtbl[11]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetDesc(SwapChainDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, SwapChainDescription*, int>)(lpVtbl[12]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain::ResizeBuffers"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult ResizeBuffers(uint BufferCount, uint Width, uint Height, Common.Format NewFormat, uint SwapChainFlags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, uint, uint, uint, Common.Format, uint, int>)(lpVtbl[13]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain::ResizeTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult ResizeTarget(Common.ModeDescription* pNewTargetParameters)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, Common.ModeDescription*, int>)(lpVtbl[14]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), pNewTargetParameters);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain::GetContainingOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetContainingOutput(IDXGIOutput** ppOutput)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, IDXGIOutput**, int>)(lpVtbl[15]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), ppOutput);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain::GetFrameStatistics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetFrameStatistics(FrameStatistics* pStats)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, FrameStatistics*, int>)(lpVtbl[16]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), pStats);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain::GetLastPresentCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetLastPresentCount(uint* pLastPresentCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain*, uint*, int>)(lpVtbl[17]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), pLastPresentCount);
	}
}

