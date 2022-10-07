// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='DXGI.xml' path='doc/member[@name="IDXGISwapChain3"]/*' />
/// <unmanaged>IDXGISwapChain3</unmanaged>
[Guid("94d99bdb-f1f8-4ab0-b236-7da0170edab1")]
[NativeTypeName("struct IDXGISwapChain3 : IDXGISwapChain2")]
[NativeInheritance("IDXGISwapChain2")]
public unsafe partial struct IDXGISwapChain3 : INativeGuid
{
	public static ref readonly Guid IID_IDXGISwapChain3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xDB, 0x9B, 0xD9, 0x94,
				0xF8, 0xF1,
				0xB0, 0x4A,
				0xB2,
				0x36,
				0x7D,
				0xA0,
				0x17,
				0x0E,
				0xDA,
				0xB1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChain3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChain3));
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

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppDevice)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), riid, ppDevice);
	}

	/// <inheritdoc cref="IDXGISwapChain.Present" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Present(uint SyncInterval, PresentFlags Flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, PresentFlags, int>)(lpVtbl[8]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, Guid*, void**, int>)(lpVtbl[9]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
	}

	/// <inheritdoc cref="IDXGISwapChain.SetFullscreenState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetFullscreenState(Bool32 Fullscreen, IDXGIOutput* pTarget)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Bool32, IDXGIOutput*, int>)(lpVtbl[10]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetFullscreenState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFullscreenState(Bool32* pFullscreen, IDXGIOutput** ppTarget)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Bool32*, IDXGIOutput**, int>)(lpVtbl[11]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetDesc(SwapChainDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, SwapChainDescription*, int>)(lpVtbl[12]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="IDXGISwapChain.ResizeBuffers" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult ResizeBuffers(uint BufferCount, uint Width, uint Height, Common.Format NewFormat, SwapChainFlags SwapChainFlags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, uint, Common.Format, SwapChainFlags, int>)(lpVtbl[13]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
	}

	/// <inheritdoc cref="IDXGISwapChain.ResizeTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult ResizeTarget(Common.ModeDescription* pNewTargetParameters)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Common.ModeDescription*, int>)(lpVtbl[14]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pNewTargetParameters);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetContainingOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetContainingOutput(IDXGIOutput** ppOutput)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, IDXGIOutput**, int>)(lpVtbl[15]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), ppOutput);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetFrameStatistics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetFrameStatistics(FrameStatistics* pStats)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, FrameStatistics*, int>)(lpVtbl[16]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pStats);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetLastPresentCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetLastPresentCount(uint* pLastPresentCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, int>)(lpVtbl[17]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pLastPresentCount);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetDesc1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetDesc1(SwapChainDescription1* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, SwapChainDescription1*, int>)(lpVtbl[18]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetFullscreenDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFullscreenDesc(SwapChainFullscreenDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, SwapChainFullscreenDescription*, int>)(lpVtbl[19]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetHwnd" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult GetHwnd(IntPtr* pHwnd)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, IntPtr*, int>)(lpVtbl[20]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pHwnd);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetCoreWindow" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetCoreWindow(Guid* refiid, void** ppUnk)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)(lpVtbl[21]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), refiid, ppUnk);
	}

	/// <inheritdoc cref="IDXGISwapChain1.Present1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult Present1(uint SyncInterval, uint PresentFlags, PresentParameters* pPresentParameters)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, PresentParameters*, int>)(lpVtbl[22]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), SyncInterval, PresentFlags, pPresentParameters);
	}

	/// <inheritdoc cref="IDXGISwapChain1.IsTemporaryMonoSupported" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public Bool32 IsTemporaryMonoSupported()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Bool32>)(lpVtbl[23]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetRestrictToOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, IDXGIOutput**, int>)(lpVtbl[24]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), ppRestrictToOutput);
	}

	/// <inheritdoc cref="IDXGISwapChain1.SetBackgroundColor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult SetBackgroundColor(Color4* pColor)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Color4*, int>)(lpVtbl[25]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pColor);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetBackgroundColor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetBackgroundColor(Color4** pColor)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Color4**, int>)(lpVtbl[26]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pColor);
	}

	/// <inheritdoc cref="IDXGISwapChain1.SetRotation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult SetRotation(Common.ModeRotation Rotation)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Common.ModeRotation, int>)(lpVtbl[27]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Rotation);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetRotation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult GetRotation(Common.ModeRotation* pRotation)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Common.ModeRotation*, int>)(lpVtbl[28]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pRotation);
	}

	/// <inheritdoc cref="IDXGISwapChain2.SetSourceSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult SetSourceSize(uint Width, uint Height)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, int>)(lpVtbl[29]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Width, Height);
	}

	/// <inheritdoc cref="IDXGISwapChain2.GetSourceSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult GetSourceSize(uint* pWidth, uint* pHeight)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, uint*, int>)(lpVtbl[30]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pWidth, pHeight);
	}

	/// <inheritdoc cref="IDXGISwapChain2.SetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult SetMaximumFrameLatency(uint MaxLatency)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, int>)(lpVtbl[31]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), MaxLatency);
	}

	/// <inheritdoc cref="IDXGISwapChain2.GetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult GetMaximumFrameLatency(uint* pMaxLatency)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, int>)(lpVtbl[32]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pMaxLatency);
	}

	/// <inheritdoc cref="IDXGISwapChain2.GetFrameLatencyWaitableObject" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public Handle GetFrameLatencyWaitableObject()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Handle>)(lpVtbl[33]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGISwapChain2.SetMatrixTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult SetMatrixTransform(Matrix3x2* pMatrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Matrix3x2*, int>)(lpVtbl[34]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pMatrix);
	}

	/// <inheritdoc cref="IDXGISwapChain2.GetMatrixTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult GetMatrixTransform(Matrix3x2* pMatrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Matrix3x2*, int>)(lpVtbl[35]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pMatrix);
	}

	/// <include file='DXGI.xml' path='doc/member[@name="IDXGISwapChain3::GetCurrentBackBufferIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public uint GetCurrentBackBufferIndex()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint>)(lpVtbl[36]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this));
	}

	/// <include file='DXGI.xml' path='doc/member[@name="IDXGISwapChain3::CheckColorSpaceSupport"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public HResult CheckColorSpaceSupport(Common.ColorSpaceType ColorSpace, uint* pColorSpaceSupport)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Common.ColorSpaceType, uint*, int>)(lpVtbl[37]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), ColorSpace, pColorSpaceSupport);
	}

	/// <include file='DXGI.xml' path='doc/member[@name="IDXGISwapChain3::SetColorSpace1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public HResult SetColorSpace1(Common.ColorSpaceType ColorSpace)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Common.ColorSpaceType, int>)(lpVtbl[38]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), ColorSpace);
	}

	/// <include file='DXGI.xml' path='doc/member[@name="IDXGISwapChain3::ResizeBuffers1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult ResizeBuffers1(uint BufferCount, uint Width, uint Height, Common.Format Format, uint SwapChainFlags, uint* pCreationNodeMask, IUnknown** ppPresentQueue)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, uint, Common.Format, uint, uint*, IUnknown**, int>)(lpVtbl[39]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMask, ppPresentQueue);
	}
}

