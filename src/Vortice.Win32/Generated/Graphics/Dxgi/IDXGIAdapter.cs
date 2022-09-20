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

/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIAdapter"]/*' />
/// <unmanaged>IDXGIAdapter</unmanaged>
[Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0")]
[NativeTypeName("struct IDXGIAdapter : IDXGIObject")]
[NativeInheritance("IDXGIObject")]
public unsafe partial struct IDXGIAdapter
{
	public static ref readonly Guid IID_IDXGIAdapter
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xE1, 0xE7, 0x11, 0x24,
				0xAC, 0x12,
				0xCF, 0x4C,
				0xBD,
				0x14,
				0x97,
				0x98,
				0xE8,
				0x53,
				0x4D,
				0xC0
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIAdapter));

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
		return ((delegate* unmanaged[Stdcall]<IDXGIAdapter*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIAdapter*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIAdapter*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIAdapter*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIAdapter::EnumOutputs"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult EnumOutputs(uint Output, IDXGIOutput** ppOutput)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIAdapter*, uint, IDXGIOutput**, int>)(lpVtbl[7]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), Output, ppOutput);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIAdapter::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetDesc(AdapterDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIAdapter*, AdapterDescription*, int>)(lpVtbl[8]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIAdapter::CheckInterfaceSupport"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CheckInterfaceSupport(Guid* InterfaceName, LargeInteger* pUMDVersion)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIAdapter*, Guid*, LargeInteger*, int>)(lpVtbl[9]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), InterfaceName, pUMDVersion);
	}
}

