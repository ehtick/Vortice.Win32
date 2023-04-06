// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Fence"]/*' />
/// <unmanaged>ID3D12Fence</unmanaged>
[Guid("0a753dcf-c4d8-4b91-adf6-be5a60d95a76")]
[NativeTypeName("struct ID3D12Fence : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
public unsafe partial struct ID3D12Fence : ID3D12Fence.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12Fence
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xCF, 0x3D, 0x75, 0x0A,
				0xD8, 0xC4,
				0x91, 0x4B,
				0xAD,
				0xF6,
				0xBE,
				0x5A,
				0x60,
				0xD9,
				0x5A,
				0x76
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Fence));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Fence));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Fence*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Fence*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, uint>)(lpVtbl[1]))((ID3D12Fence*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, uint>)(lpVtbl[1]))((ID3D12Fence*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, uint>)(lpVtbl[2]))((ID3D12Fence*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, uint>)(lpVtbl[2]))((ID3D12Fence*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Fence*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Fence*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Fence*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Fence*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Fence*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Fence*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, ushort*, int>)(lpVtbl[6]))((ID3D12Fence*)Unsafe.AsPointer(ref this), Name);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, ushort*, int>)(lpVtbl[6]))((ID3D12Fence*)Unsafe.AsPointer(ref this), Name);
#endif
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Fence*)Unsafe.AsPointer(ref this), riid, ppvDevice);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Fence*)Unsafe.AsPointer(ref this), riid, ppvDevice);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Fence::GetCompletedValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public ulong GetCompletedValue()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, ulong>)(lpVtbl[8]))((ID3D12Fence*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, ulong>)(lpVtbl[8]))((ID3D12Fence*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Fence::SetEventOnCompletion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetEventOnCompletion(ulong Value, Handle hEvent)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, ulong, Handle, int>)(lpVtbl[9]))((ID3D12Fence*)Unsafe.AsPointer(ref this), Value, hEvent);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, ulong, Handle, int>)(lpVtbl[9]))((ID3D12Fence*)Unsafe.AsPointer(ref this), Value, hEvent);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Fence::Signal"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult Signal(ulong Value)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Fence*, ulong, int>)(lpVtbl[10]))((ID3D12Fence*)Unsafe.AsPointer(ref this), Value);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Fence*, ulong, int>)(lpVtbl[10]))((ID3D12Fence*)Unsafe.AsPointer(ref this), Value);
#endif
	}

	public interface Interface : ID3D12Pageable.Interface
	{
		[VtblIndex(8)]
		ulong GetCompletedValue();

		[VtblIndex(9)]
		HResult SetEventOnCompletion(ulong Value, Handle hEvent);

		[VtblIndex(10)]
		HResult Signal(ulong Value);
	}
}

