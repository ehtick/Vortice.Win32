// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Resource2"]/*' />
/// <unmanaged>ID3D12Resource2</unmanaged>
[Guid("be36ec3b-ea85-4aeb-a45a-e9d76404a495")]
[NativeTypeName("struct ID3D12Resource2 : ID3D12Resource1")]
[NativeInheritance("ID3D12Resource1")]
public unsafe partial struct ID3D12Resource2 : ID3D12Resource2.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12Resource2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x3B, 0xEC, 0x36, 0xBE,
				0x85, 0xEA,
				0xEB, 0x4A,
				0xA4,
				0x5A,
				0xE9,
				0xD7,
				0x64,
				0x04,
				0xA4,
				0x95
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Resource2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Resource2));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, uint>)(lpVtbl[1]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, uint>)(lpVtbl[1]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, uint>)(lpVtbl[2]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, uint>)(lpVtbl[2]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, ushort*, int>)(lpVtbl[6]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Name);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, ushort*, int>)(lpVtbl[6]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Name);
#endif
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppvDevice);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppvDevice);
#endif
	}

	/// <inheritdoc cref="ID3D12Resource.Map" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Map(uint Subresource, Range* pReadRange, void** ppData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, uint, Range*, void**, int>)(lpVtbl[8]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Subresource, pReadRange, ppData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, uint, Range*, void**, int>)(lpVtbl[8]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Subresource, pReadRange, ppData);
#endif
	}

	/// <inheritdoc cref="ID3D12Resource.Unmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void Unmap(uint Subresource, Range* pWrittenRange)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12Resource2*, uint, Range*, void>)(lpVtbl[9]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
#else
		((delegate* unmanaged[Stdcall]<ID3D12Resource2*, uint, Range*, void>)(lpVtbl[9]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
#endif
	}

	/// <inheritdoc cref="ID3D12Resource.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ResourceDescription GetDesc()
	{
		ResourceDescription result;
#if NET6_0_OR_GREATER
		return *((delegate* unmanaged<ID3D12Resource2*, ResourceDescription*, ResourceDescription*>)(lpVtbl[10]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), &result);
#else
		return *((delegate* unmanaged[Stdcall]<ID3D12Resource2*, ResourceDescription*, ResourceDescription*>)(lpVtbl[10]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), &result);
#endif
	}

	/// <inheritdoc cref="ID3D12Resource.GetGPUVirtualAddress" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public ulong GetGPUVirtualAddress()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, ulong>)(lpVtbl[11]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, ulong>)(lpVtbl[11]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D12Resource.WriteToSubresource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult WriteToSubresource(uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, uint, Box*, void*, uint, uint, int>)(lpVtbl[12]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, uint, Box*, void*, uint, uint, int>)(lpVtbl[12]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
#endif
	}

	/// <inheritdoc cref="ID3D12Resource.ReadFromSubresource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, Box* pSrcBox)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, void*, uint, uint, uint, Box*, int>)(lpVtbl[13]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, void*, uint, uint, uint, Box*, int>)(lpVtbl[13]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
#endif
	}

	/// <inheritdoc cref="ID3D12Resource.GetHeapProperties" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetHeapProperties(HeapProperties* pHeapProperties, HeapFlags* pHeapFlags)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, HeapProperties*, HeapFlags*, int>)(lpVtbl[14]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), pHeapProperties, pHeapFlags);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, HeapProperties*, HeapFlags*, int>)(lpVtbl[14]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), pHeapProperties, pHeapFlags);
#endif
	}

	/// <inheritdoc cref="ID3D12Resource1.GetProtectedResourceSession" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetProtectedResourceSession(Guid* riid, void** ppProtectedSession)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[15]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[15]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Resource2::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public ResourceDescription1 GetDesc1()
	{
		ResourceDescription1 result;
#if NET6_0_OR_GREATER
		return *((delegate* unmanaged<ID3D12Resource2*, ResourceDescription1*, ResourceDescription1*>)(lpVtbl[16]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), &result);
#else
		return *((delegate* unmanaged[Stdcall]<ID3D12Resource2*, ResourceDescription1*, ResourceDescription1*>)(lpVtbl[16]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), &result);
#endif
	}

	public interface Interface : ID3D12Resource1.Interface
	{
		[VtblIndex(16)]
		ResourceDescription1 GetDesc1();
	}
}

