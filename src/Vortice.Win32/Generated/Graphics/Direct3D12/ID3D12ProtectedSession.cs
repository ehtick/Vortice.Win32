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

namespace Win32.Graphics.Direct3D12;

/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ProtectedSession"]/*' />
/// <unmanaged>ID3D12ProtectedSession</unmanaged>
[Guid("a1533d18-0ac1-4084-85b9-89a96116806b")]
[NativeTypeName("struct ID3D12ProtectedSession : ID3D12DeviceChild")]
[NativeInheritance("ID3D12DeviceChild")]
public unsafe partial struct ID3D12ProtectedSession
{
	public static ref readonly Guid IID_ID3D12ProtectedSession
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x18, 0x3D, 0x53, 0xA1,
				0xC1, 0x0A,
				0x84, 0x40,
				0x85,
				0xB9,
				0x89,
				0xA9,
				0x61,
				0x16,
				0x80,
				0x6B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ProtectedSession));

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

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedSession*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12ProtectedSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedSession*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12ProtectedSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedSession*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12ProtectedSession*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedSession*, ushort*, int>)(lpVtbl[6]))((ID3D12ProtectedSession*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedSession*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12ProtectedSession*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ProtectedSession::GetStatusFence"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetStatusFence(Guid* riid, void** ppFence)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedSession*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12ProtectedSession*)Unsafe.AsPointer(ref this), riid, ppFence);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12ProtectedSession::GetSessionStatus"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ProtectedSessionStatus GetSessionStatus()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedSession*, ProtectedSessionStatus>)(lpVtbl[9]))((ID3D12ProtectedSession*)Unsafe.AsPointer(ref this));
	}
}

