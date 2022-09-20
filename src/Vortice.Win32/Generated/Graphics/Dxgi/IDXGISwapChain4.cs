// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Numerics;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.Dxgi;

/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain4"]/*' />
/// <unmanaged>IDXGISwapChain4</unmanaged>
[Guid("3d585d5a-bd4a-489e-b1f4-3dbcb6452ffb")]
[NativeTypeName("struct IDXGISwapChain4 : IDXGISwapChain3")]
[NativeInheritance("IDXGISwapChain3")]
public unsafe partial struct IDXGISwapChain4
{
	public static ref readonly Guid IID_IDXGISwapChain4
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x5A, 0x5D, 0x58, 0x3D,
				0x4A, 0xBD,
				0x9E, 0x48,
				0xB1,
				0xF4,
				0x3D,
				0xBC,
				0xB6,
				0x45,
				0x2F,
				0xFB
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChain4));

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
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppDevice)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), riid, ppDevice);
	}

	/// <inheritdoc cref="IDXGISwapChain.Present" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Present(uint SyncInterval, uint Flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint, uint, int>)(lpVtbl[8]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint, Guid*, void**, int>)(lpVtbl[9]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
	}

	/// <inheritdoc cref="IDXGISwapChain.SetFullscreenState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetFullscreenState(Bool32 Fullscreen, IDXGIOutput* pTarget)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Bool32, IDXGIOutput*, int>)(lpVtbl[10]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetFullscreenState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFullscreenState(Bool32* pFullscreen, IDXGIOutput** ppTarget)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Bool32*, IDXGIOutput**, int>)(lpVtbl[11]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetDesc(SwapChainDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, SwapChainDescription*, int>)(lpVtbl[12]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="IDXGISwapChain.ResizeBuffers" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult ResizeBuffers(uint BufferCount, uint Width, uint Height, Common.Format NewFormat, uint SwapChainFlags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint, uint, uint, Common.Format, uint, int>)(lpVtbl[13]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
	}

	/// <inheritdoc cref="IDXGISwapChain.ResizeTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult ResizeTarget(Common.ModeDescription* pNewTargetParameters)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Common.ModeDescription*, int>)(lpVtbl[14]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pNewTargetParameters);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetContainingOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetContainingOutput(IDXGIOutput** ppOutput)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, IDXGIOutput**, int>)(lpVtbl[15]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), ppOutput);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetFrameStatistics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetFrameStatistics(FrameStatistics* pStats)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, FrameStatistics*, int>)(lpVtbl[16]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pStats);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetLastPresentCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetLastPresentCount(uint* pLastPresentCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint*, int>)(lpVtbl[17]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pLastPresentCount);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetDesc1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetDesc1(SwapChainDescription1* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, SwapChainDescription1*, int>)(lpVtbl[18]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetFullscreenDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFullscreenDesc(SwapChainFullscreenDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, SwapChainFullscreenDescription*, int>)(lpVtbl[19]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetHwnd" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult GetHwnd(IntPtr* pHwnd)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, IntPtr*, int>)(lpVtbl[20]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pHwnd);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetCoreWindow" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetCoreWindow(Guid* refiid, void** ppUnk)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Guid*, void**, int>)(lpVtbl[21]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), refiid, ppUnk);
	}

	/// <inheritdoc cref="IDXGISwapChain1.Present1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult Present1(uint SyncInterval, uint PresentFlags, PresentParameters* pPresentParameters)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint, uint, PresentParameters*, int>)(lpVtbl[22]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), SyncInterval, PresentFlags, pPresentParameters);
	}

	/// <inheritdoc cref="IDXGISwapChain1.IsTemporaryMonoSupported" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public Bool32 IsTemporaryMonoSupported()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Bool32>)(lpVtbl[23]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetRestrictToOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, IDXGIOutput**, int>)(lpVtbl[24]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), ppRestrictToOutput);
	}

	/// <inheritdoc cref="IDXGISwapChain1.SetBackgroundColor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult SetBackgroundColor(Rgba* pColor)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Rgba*, int>)(lpVtbl[25]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pColor);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetBackgroundColor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetBackgroundColor(Rgba* pColor)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Rgba*, int>)(lpVtbl[26]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pColor);
	}

	/// <inheritdoc cref="IDXGISwapChain1.SetRotation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult SetRotation(Common.ModeRotation Rotation)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Common.ModeRotation, int>)(lpVtbl[27]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Rotation);
	}

	/// <inheritdoc cref="IDXGISwapChain1.GetRotation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult GetRotation(Common.ModeRotation* pRotation)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Common.ModeRotation*, int>)(lpVtbl[28]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pRotation);
	}

	/// <inheritdoc cref="IDXGISwapChain2.SetSourceSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult SetSourceSize(uint Width, uint Height)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint, uint, int>)(lpVtbl[29]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Width, Height);
	}

	/// <inheritdoc cref="IDXGISwapChain2.GetSourceSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult GetSourceSize(uint* pWidth, uint* pHeight)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint*, uint*, int>)(lpVtbl[30]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pWidth, pHeight);
	}

	/// <inheritdoc cref="IDXGISwapChain2.SetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult SetMaximumFrameLatency(uint MaxLatency)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint, int>)(lpVtbl[31]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), MaxLatency);
	}

	/// <inheritdoc cref="IDXGISwapChain2.GetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult GetMaximumFrameLatency(uint* pMaxLatency)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint*, int>)(lpVtbl[32]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pMaxLatency);
	}

	/// <inheritdoc cref="IDXGISwapChain2.GetFrameLatencyWaitableObject" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public IntPtr GetFrameLatencyWaitableObject()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, IntPtr>)(lpVtbl[33]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGISwapChain2.SetMatrixTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult SetMatrixTransform(Matrix3x2F* pMatrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Matrix3x2F*, int>)(lpVtbl[34]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pMatrix);
	}

	/// <inheritdoc cref="IDXGISwapChain2.GetMatrixTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult GetMatrixTransform(Matrix3x2F* pMatrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Matrix3x2F*, int>)(lpVtbl[35]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pMatrix);
	}

	/// <inheritdoc cref="IDXGISwapChain3.GetCurrentBackBufferIndex" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public uint GetCurrentBackBufferIndex()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint>)(lpVtbl[36]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGISwapChain3.CheckColorSpaceSupport" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public HResult CheckColorSpaceSupport(Common.ColorSpaceType ColorSpace, uint* pColorSpaceSupport)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Common.ColorSpaceType, uint*, int>)(lpVtbl[37]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), ColorSpace, pColorSpaceSupport);
	}

	/// <inheritdoc cref="IDXGISwapChain3.SetColorSpace1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public HResult SetColorSpace1(Common.ColorSpaceType ColorSpace)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, Common.ColorSpaceType, int>)(lpVtbl[38]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), ColorSpace);
	}

	/// <inheritdoc cref="IDXGISwapChain3.ResizeBuffers1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult ResizeBuffers1(uint BufferCount, uint Width, uint Height, Common.Format Format, uint SwapChainFlags, uint* pCreationNodeMask, IUnknown** ppPresentQueue)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, uint, uint, uint, Common.Format, uint, uint*, IUnknown**, int>)(lpVtbl[39]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMask, ppPresentQueue);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGISwapChain4::SetHDRMetaData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public HResult SetHDRMetaData(HdrMetadataType Type, uint Size, void* pMetaData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChain4*, HdrMetadataType, uint, void*, int>)(lpVtbl[40]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Type, Size, pMetaData);
	}
}

