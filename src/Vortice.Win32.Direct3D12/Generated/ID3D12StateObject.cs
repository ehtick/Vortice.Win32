// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12StateObject"]/*' />
/// <unmanaged>ID3D12StateObject</unmanaged>
[Guid("47016943-fca8-4594-93ea-af258b55346d")]
[NativeTypeName("struct ID3D12StateObject : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
public unsafe partial struct ID3D12StateObject : INativeGuid
{
	public static ref readonly Guid IID_ID3D12StateObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x43, 0x69, 0x01, 0x47,
				0xA8, 0xFC,
				0x94, 0x45,
				0x93,
				0xEA,
				0xAF,
				0x25,
				0x8B,
				0x55,
				0x34,
				0x6D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12StateObject));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12StateObject));
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
		return ((delegate* unmanaged[Stdcall]<ID3D12StateObject*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12StateObject*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12StateObject*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12StateObject*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12StateObject*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12StateObject*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12StateObject*, ushort*, int>)(lpVtbl[6]))((ID3D12StateObject*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12StateObject*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12StateObject*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}
}

