// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Predicate"]/*' />
/// <unmanaged>ID3D11Predicate</unmanaged>
[Guid("9eb576dd-9f77-4d86-81aa-8bab5fe490e2")]
[NativeTypeName("struct ID3D11Predicate : ID3D11Query")]
[NativeInheritance("ID3D11Query")]
public unsafe partial struct ID3D11Predicate : ID3D11Predicate.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11Predicate
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xDD, 0x76, 0xB5, 0x9E,
				0x77, 0x9F,
				0x86, 0x4D,
				0x81,
				0xAA,
				0x8B,
				0xAB,
				0x5F,
				0xE4,
				0x90,
				0xE2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Predicate));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Predicate));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Predicate*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Predicate*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Predicate*, uint>)(lpVtbl[1]))((ID3D11Predicate*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Predicate*, uint>)(lpVtbl[1]))((ID3D11Predicate*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Predicate*, uint>)(lpVtbl[2]))((ID3D11Predicate*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Predicate*, uint>)(lpVtbl[2]))((ID3D11Predicate*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Predicate*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), ppDevice);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Predicate*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), ppDevice);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Predicate*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Predicate*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Predicate*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Predicate*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Predicate*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Predicate*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11Asynchronous.GetDataSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public uint GetDataSize()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Predicate*, uint>)(lpVtbl[7]))((ID3D11Predicate*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Predicate*, uint>)(lpVtbl[7]))((ID3D11Predicate*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11Query.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc(QueryDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Predicate*, QueryDescription*, void>)(lpVtbl[8]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), pDesc);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Predicate*, QueryDescription*, void>)(lpVtbl[8]))((ID3D11Predicate*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	public interface Interface : ID3D11Query.Interface
	{
	}
}

