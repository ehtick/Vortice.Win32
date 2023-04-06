// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderResourceView1"]/*' />
/// <unmanaged>ID3D11ShaderResourceView1</unmanaged>
[Guid("91308b87-9040-411d-8c67-c39253ce3802")]
[NativeTypeName("struct ID3D11ShaderResourceView1 : ID3D11ShaderResourceView")]
[NativeInheritance("ID3D11ShaderResourceView")]
public unsafe partial struct ID3D11ShaderResourceView1 : ID3D11ShaderResourceView1.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11ShaderResourceView1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x87, 0x8B, 0x30, 0x91,
				0x40, 0x90,
				0x1D, 0x41,
				0x8C,
				0x67,
				0xC3,
				0x92,
				0x53,
				0xCE,
				0x38,
				0x02
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderResourceView1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderResourceView1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ShaderResourceView1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderResourceView1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ShaderResourceView1*, uint>)(lpVtbl[1]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderResourceView1*, uint>)(lpVtbl[1]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ShaderResourceView1*, uint>)(lpVtbl[2]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderResourceView1*, uint>)(lpVtbl[2]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11ShaderResourceView1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), ppDevice);
#else
		((delegate* unmanaged[Stdcall]<ID3D11ShaderResourceView1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), ppDevice);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ShaderResourceView1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderResourceView1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ShaderResourceView1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderResourceView1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ShaderResourceView1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderResourceView1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11View.GetResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetResource(ID3D11Resource** ppResource)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11ShaderResourceView1*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), ppResource);
#else
		((delegate* unmanaged[Stdcall]<ID3D11ShaderResourceView1*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), ppResource);
#endif
	}

	/// <inheritdoc cref="ID3D11ShaderResourceView.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc(ShaderResourceViewDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11ShaderResourceView1*, ShaderResourceViewDescription*, void>)(lpVtbl[8]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), pDesc);
#else
		((delegate* unmanaged[Stdcall]<ID3D11ShaderResourceView1*, ShaderResourceViewDescription*, void>)(lpVtbl[8]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderResourceView1::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void GetDesc1(ShaderResourceViewDescription1* pDesc1)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11ShaderResourceView1*, ShaderResourceViewDescription1*, void>)(lpVtbl[9]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), pDesc1);
#else
		((delegate* unmanaged[Stdcall]<ID3D11ShaderResourceView1*, ShaderResourceViewDescription1*, void>)(lpVtbl[9]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), pDesc1);
#endif
	}

	public interface Interface : ID3D11ShaderResourceView.Interface
	{
		[VtblIndex(9)]
		void GetDesc1(ShaderResourceViewDescription1* pDesc1);
	}
}

