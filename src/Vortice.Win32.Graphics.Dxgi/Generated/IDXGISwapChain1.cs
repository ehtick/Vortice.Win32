// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1"]/*' />
/// <unmanaged>IDXGISwapChain1</unmanaged>
[Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa")]
[NativeTypeName("struct IDXGISwapChain1 : IDXGISwapChain")]
[NativeInheritance("IDXGISwapChain")]
public unsafe partial struct IDXGISwapChain1 : IDXGISwapChain1.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGISwapChain1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF7, 0x45, 0x0A, 0x79,
				0x42, 0x0D,
				0x76, 0x48,
				0x98,
				0x3A,
				0x0A,
				0x55,
				0xCF,
				0xE6,
				0xF4,
				0xAA
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChain1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChain1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, uint>)(lpVtbl[1]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint>)(lpVtbl[1]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, uint>)(lpVtbl[2]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint>)(lpVtbl[2]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pUnknown);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pUnknown);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppParent);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppParent);
#endif
	}

	/// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppDevice)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppDevice);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppDevice);
#endif
	}

	/// <inheritdoc cref="IDXGISwapChain.Present" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Present(uint SyncInterval, PresentFlags Flags)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, uint, PresentFlags, int>)(lpVtbl[8]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, PresentFlags, int>)(lpVtbl[8]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
#endif
	}

	/// <inheritdoc cref="IDXGISwapChain.GetBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, uint, Guid*, void**, int>)(lpVtbl[9]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, Guid*, void**, int>)(lpVtbl[9]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
#endif
	}

	/// <inheritdoc cref="IDXGISwapChain.SetFullscreenState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetFullscreenState(Bool32 Fullscreen, IDXGIOutput* pTarget)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Bool32, IDXGIOutput*, int>)(lpVtbl[10]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Bool32, IDXGIOutput*, int>)(lpVtbl[10]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
#endif
	}

	/// <inheritdoc cref="IDXGISwapChain.GetFullscreenState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFullscreenState(Bool32* pFullscreen, IDXGIOutput** ppTarget)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Bool32*, IDXGIOutput**, int>)(lpVtbl[11]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Bool32*, IDXGIOutput**, int>)(lpVtbl[11]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
#endif
	}

	/// <inheritdoc cref="IDXGISwapChain.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetDesc(SwapChainDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, SwapChainDescription*, int>)(lpVtbl[12]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainDescription*, int>)(lpVtbl[12]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <inheritdoc cref="IDXGISwapChain.ResizeBuffers" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult ResizeBuffers(uint BufferCount, uint Width, uint Height, Common.Format NewFormat, SwapChainFlags SwapChainFlags)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, uint, uint, uint, Common.Format, SwapChainFlags, int>)(lpVtbl[13]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, uint, Common.Format, SwapChainFlags, int>)(lpVtbl[13]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
#endif
	}

	/// <inheritdoc cref="IDXGISwapChain.ResizeTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult ResizeTarget(Common.ModeDescription* pNewTargetParameters)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Common.ModeDescription*, int>)(lpVtbl[14]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pNewTargetParameters);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Common.ModeDescription*, int>)(lpVtbl[14]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pNewTargetParameters);
#endif
	}

	/// <inheritdoc cref="IDXGISwapChain.GetContainingOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetContainingOutput(IDXGIOutput** ppOutput)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, IDXGIOutput**, int>)(lpVtbl[15]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), ppOutput);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, IDXGIOutput**, int>)(lpVtbl[15]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), ppOutput);
#endif
	}

	/// <inheritdoc cref="IDXGISwapChain.GetFrameStatistics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetFrameStatistics(FrameStatistics* pStats)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, FrameStatistics*, int>)(lpVtbl[16]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pStats);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, FrameStatistics*, int>)(lpVtbl[16]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pStats);
#endif
	}

	/// <inheritdoc cref="IDXGISwapChain.GetLastPresentCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetLastPresentCount(uint* pLastPresentCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, uint*, int>)(lpVtbl[17]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pLastPresentCount);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint*, int>)(lpVtbl[17]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pLastPresentCount);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetDesc1(SwapChainDescription1* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, SwapChainDescription1*, int>)(lpVtbl[18]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainDescription1*, int>)(lpVtbl[18]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetFullscreenDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFullscreenDesc(SwapChainFullscreenDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, SwapChainFullscreenDescription*, int>)(lpVtbl[19]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainFullscreenDescription*, int>)(lpVtbl[19]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetHwnd"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult GetHwnd(nint* pHwnd)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, nint*, int>)(lpVtbl[20]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pHwnd);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, nint*, int>)(lpVtbl[20]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pHwnd);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetCoreWindow"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetCoreWindow(Guid* refiid, void** ppUnk)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[21]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), refiid, ppUnk);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[21]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), refiid, ppUnk);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::Present1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult Present1(uint SyncInterval, uint PresentFlags, PresentParameters* pPresentParameters)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, uint, uint, PresentParameters*, int>)(lpVtbl[22]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, PresentFlags, pPresentParameters);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, PresentParameters*, int>)(lpVtbl[22]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, PresentFlags, pPresentParameters);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::IsTemporaryMonoSupported"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public Bool32 IsTemporaryMonoSupported()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Bool32>)(lpVtbl[23]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Bool32>)(lpVtbl[23]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetRestrictToOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, IDXGIOutput**, int>)(lpVtbl[24]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), ppRestrictToOutput);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, IDXGIOutput**, int>)(lpVtbl[24]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), ppRestrictToOutput);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::SetBackgroundColor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult SetBackgroundColor(Color4* pColor)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Color4*, int>)(lpVtbl[25]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pColor);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Color4*, int>)(lpVtbl[25]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pColor);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetBackgroundColor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetBackgroundColor(Color4** pColor)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Color4**, int>)(lpVtbl[26]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pColor);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Color4**, int>)(lpVtbl[26]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pColor);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::SetRotation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult SetRotation(Common.ModeRotation Rotation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Common.ModeRotation, int>)(lpVtbl[27]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Rotation);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Common.ModeRotation, int>)(lpVtbl[27]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Rotation);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetRotation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult GetRotation(Common.ModeRotation* pRotation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGISwapChain1*, Common.ModeRotation*, int>)(lpVtbl[28]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pRotation);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Common.ModeRotation*, int>)(lpVtbl[28]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pRotation);
#endif
	}

	public interface Interface : IDXGISwapChain.Interface
	{
		[VtblIndex(18)]
		HResult GetDesc1(SwapChainDescription1* pDesc);

		[VtblIndex(19)]
		HResult GetFullscreenDesc(SwapChainFullscreenDescription* pDesc);

		[VtblIndex(20)]
		HResult GetHwnd(nint* pHwnd);

		[VtblIndex(21)]
		HResult GetCoreWindow(Guid* refiid, void** ppUnk);

		[VtblIndex(22)]
		HResult Present1(uint SyncInterval, uint PresentFlags, PresentParameters* pPresentParameters);

		[VtblIndex(23)]
		Bool32 IsTemporaryMonoSupported();

		[VtblIndex(24)]
		HResult GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput);

		[VtblIndex(25)]
		HResult SetBackgroundColor(Color4* pColor);

		[VtblIndex(26)]
		HResult GetBackgroundColor(Color4** pColor);

		[VtblIndex(27)]
		HResult SetRotation(Common.ModeRotation Rotation);

		[VtblIndex(28)]
		HResult GetRotation(Common.ModeRotation* pRotation);
	}
}

