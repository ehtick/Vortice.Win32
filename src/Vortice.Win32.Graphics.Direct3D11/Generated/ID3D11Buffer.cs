// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Buffer"]/*' />
/// <unmanaged>ID3D11Buffer</unmanaged>
[Guid("48570b85-d1ee-4fcd-a250-eb350722b037")]
[NativeTypeName("struct ID3D11Buffer : ID3D11Resource")]
[NativeInheritance("ID3D11Resource")]
public unsafe partial struct ID3D11Buffer : ID3D11Buffer.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11Buffer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x85, 0x0B, 0x57, 0x48,
				0xEE, 0xD1,
				0xCD, 0x4F,
				0xA2,
				0x50,
				0xEB,
				0x35,
				0x07,
				0x22,
				0xB0,
				0x37
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Buffer));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Buffer));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Buffer*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Buffer*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Buffer*, uint>)(lpVtbl[1]))((ID3D11Buffer*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Buffer*, uint>)(lpVtbl[1]))((ID3D11Buffer*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Buffer*, uint>)(lpVtbl[2]))((ID3D11Buffer*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Buffer*, uint>)(lpVtbl[2]))((ID3D11Buffer*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Buffer*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), ppDevice);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Buffer*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), ppDevice);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Buffer*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Buffer*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Buffer*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Buffer*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Buffer*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Buffer*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11Resource.GetType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetType(ResourceDimension* pResourceDimension)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Buffer*, ResourceDimension*, void>)(lpVtbl[7]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), pResourceDimension);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Buffer*, ResourceDimension*, void>)(lpVtbl[7]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), pResourceDimension);
#endif
	}

	/// <inheritdoc cref="ID3D11Resource.SetEvictionPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void SetEvictionPriority(uint EvictionPriority)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Buffer*, uint, void>)(lpVtbl[8]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), EvictionPriority);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Buffer*, uint, void>)(lpVtbl[8]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), EvictionPriority);
#endif
	}

	/// <inheritdoc cref="ID3D11Resource.GetEvictionPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public uint GetEvictionPriority()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Buffer*, uint>)(lpVtbl[9]))((ID3D11Buffer*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Buffer*, uint>)(lpVtbl[9]))((ID3D11Buffer*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Buffer::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public void GetDesc(BufferDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Buffer*, BufferDescription*, void>)(lpVtbl[10]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), pDesc);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Buffer*, BufferDescription*, void>)(lpVtbl[10]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	public interface Interface : ID3D11Resource.Interface
	{
		[VtblIndex(10)]
		void GetDesc(BufferDescription* pDesc);
	}
}

