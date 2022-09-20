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

/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIResource"]/*' />
/// <unmanaged>IDXGIResource</unmanaged>
[Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b")]
[NativeTypeName("struct IDXGIResource : IDXGIDeviceSubObject")]
[NativeInheritance("IDXGIDeviceSubObject")]
public unsafe partial struct IDXGIResource
{
	public static ref readonly Guid IID_IDXGIResource
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xB4, 0x3A, 0x5F, 0x03,
				0x2E, 0x48,
				0x50, 0x4E,
				0xB4,
				0x1F,
				0x8A,
				0x7F,
				0x8B,
				0xD8,
				0x96,
				0x0B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIResource));

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
		return ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIResource*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIResource*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIResource*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIResource*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppDevice)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)(lpVtbl[7]))((IDXGIResource*)Unsafe.AsPointer(ref this), riid, ppDevice);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIResource::GetSharedHandle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetSharedHandle(IntPtr* pSharedHandle)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIResource*, IntPtr*, int>)(lpVtbl[8]))((IDXGIResource*)Unsafe.AsPointer(ref this), pSharedHandle);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIResource::GetUsage"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetUsage(uint* pUsage)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIResource*, uint*, int>)(lpVtbl[9]))((IDXGIResource*)Unsafe.AsPointer(ref this), pUsage);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIResource::SetEvictionPriority"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetEvictionPriority(ResourcePriority EvictionPriority)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIResource*, ResourcePriority, int>)(lpVtbl[10]))((IDXGIResource*)Unsafe.AsPointer(ref this), EvictionPriority);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIResource::GetEvictionPriority"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetEvictionPriority(uint* pEvictionPriority)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIResource*, uint*, int>)(lpVtbl[11]))((IDXGIResource*)Unsafe.AsPointer(ref this), pEvictionPriority);
	}
}

