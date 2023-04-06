// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11BlendState"]/*' />
/// <unmanaged>ID3D11BlendState</unmanaged>
[Guid("75b68faa-347d-4159-8f45-a0640f01cd9a")]
[NativeTypeName("struct ID3D11BlendState : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11BlendState : ID3D11BlendState.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11BlendState
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xAA, 0x8F, 0xB6, 0x75,
				0x7D, 0x34,
				0x59, 0x41,
				0x8F,
				0x45,
				0xA0,
				0x64,
				0x0F,
				0x01,
				0xCD,
				0x9A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11BlendState));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11BlendState));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11BlendState*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11BlendState*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11BlendState*, uint>)(lpVtbl[1]))((ID3D11BlendState*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11BlendState*, uint>)(lpVtbl[1]))((ID3D11BlendState*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11BlendState*, uint>)(lpVtbl[2]))((ID3D11BlendState*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11BlendState*, uint>)(lpVtbl[2]))((ID3D11BlendState*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11BlendState*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), ppDevice);
#else
		((delegate* unmanaged[Stdcall]<ID3D11BlendState*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), ppDevice);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11BlendState*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11BlendState*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11BlendState*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11BlendState*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11BlendState*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11BlendState*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11BlendState::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetDesc(BlendDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11BlendState*, BlendDescription*, void>)(lpVtbl[7]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), pDesc);
#else
		((delegate* unmanaged[Stdcall]<ID3D11BlendState*, BlendDescription*, void>)(lpVtbl[7]))((ID3D11BlendState*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	public interface Interface : ID3D11DeviceChild.Interface
	{
		[VtblIndex(7)]
		void GetDesc(BlendDescription* pDesc);
	}
}

