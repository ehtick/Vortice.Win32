// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ProtectedResourceSession"]/*' />
/// <unmanaged>ID3D12ProtectedResourceSession</unmanaged>
[Guid("6cd696f4-f289-40cc-8091-5a6c0a099c3d")]
[NativeTypeName("struct ID3D12ProtectedResourceSession : ID3D12ProtectedSession")]
[NativeInheritance("ID3D12ProtectedSession")]
public unsafe partial struct ID3D12ProtectedResourceSession : INativeGuid
{
	public static ref readonly Guid IID_ID3D12ProtectedResourceSession
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF4, 0x96, 0xD6, 0x6C,
				0x89, 0xF2,
				0xCC, 0x40,
				0x80,
				0x91,
				0x5A,
				0x6C,
				0x0A,
				0x09,
				0x9C,
				0x3D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ProtectedResourceSession));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ProtectedResourceSession));
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

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession*, ushort*, int>)(lpVtbl[6]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	/// <inheritdoc cref="ID3D12ProtectedSession.GetStatusFence" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetStatusFence(Guid* riid, void** ppFence)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), riid, ppFence);
	}

	/// <inheritdoc cref="ID3D12ProtectedSession.GetSessionStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ProtectedSessionStatus GetSessionStatus()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession*, ProtectedSessionStatus>)(lpVtbl[9]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ProtectedResourceSession::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ProtectedResourceSessionDescription GetDesc()
	{
		ProtectedResourceSessionDescription result;
		return *((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession*, ProtectedResourceSessionDescription*, ProtectedResourceSessionDescription*>)(lpVtbl[10]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), &result);
	}
}

