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

/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIDevice4"]/*' />
/// <unmanaged>IDXGIDevice4</unmanaged>
[Guid("95b4f95f-d8da-4ca4-9ee6-3b76d5968a10")]
[NativeTypeName("struct IDXGIDevice4 : IDXGIDevice3")]
[NativeInheritance("IDXGIDevice3")]
public unsafe partial struct IDXGIDevice4
{
	public static ref readonly Guid IID_IDXGIDevice4
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x5F, 0xF9, 0xB4, 0x95,
				0xDA, 0xD8,
				0xA4, 0x4C,
				0x9E,
				0xE6,
				0x3B,
				0x76,
				0xD5,
				0x96,
				0x8A,
				0x10
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice4));

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
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIDevice.GetAdapter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetAdapter(IDXGIAdapter** pAdapter)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pAdapter);
	}

	/// <inheritdoc cref="IDXGIDevice.CreateSurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSurface(SurfaceDescription* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, SurfaceDescription*, uint, uint, SharedResource*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
	}

	/// <inheritdoc cref="IDXGIDevice.QueryResourceResidency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult QueryResourceResidency(IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, IUnknown**, Residency*, uint, int>)(lpVtbl[9]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
	}

	/// <inheritdoc cref="IDXGIDevice.SetGPUThreadPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetGPUThreadPriority(int Priority)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, int, int>)(lpVtbl[10]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Priority);
	}

	/// <inheritdoc cref="IDXGIDevice.GetGPUThreadPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetGPUThreadPriority(int* pPriority)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, int*, int>)(lpVtbl[11]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pPriority);
	}

	/// <inheritdoc cref="IDXGIDevice1.SetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetMaximumFrameLatency(uint MaxLatency)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, int>)(lpVtbl[12]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), MaxLatency);
	}

	/// <inheritdoc cref="IDXGIDevice1.GetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetMaximumFrameLatency(uint* pMaxLatency)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint*, int>)(lpVtbl[13]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pMaxLatency);
	}

	/// <inheritdoc cref="IDXGIDevice2.OfferResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult OfferResources(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, int>)(lpVtbl[14]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority);
	}

	/// <inheritdoc cref="IDXGIDevice2.ReclaimResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult ReclaimResources(uint NumResources, IDXGIResource** ppResources, Bool32* pDiscarded)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, Bool32*, int>)(lpVtbl[15]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, pDiscarded);
	}

	/// <inheritdoc cref="IDXGIDevice2.EnqueueSetEvent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult EnqueueSetEvent(IntPtr hEvent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, IntPtr, int>)(lpVtbl[16]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), hEvent);
	}

	/// <inheritdoc cref="IDXGIDevice3.Trim" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void Trim()
	{
		((delegate* unmanaged[Stdcall]<IDXGIDevice4*, void>)(lpVtbl[17]))((IDXGIDevice4*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIDevice4::OfferResources1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult OfferResources1(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority, uint Flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, uint, int>)(lpVtbl[18]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority, Flags);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIDevice4::ReclaimResources1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult ReclaimResources1(uint NumResources, IDXGIResource** ppResources, ReclaimResourceResults* pResults)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, ReclaimResourceResults*, int>)(lpVtbl[19]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, pResults);
	}
}

