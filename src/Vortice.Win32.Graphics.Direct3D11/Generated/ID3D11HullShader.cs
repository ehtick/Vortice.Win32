// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11HullShader"]/*' />
/// <unmanaged>ID3D11HullShader</unmanaged>
[Guid("8e5c6061-628a-4c8e-8264-bbe45cb3d5dd")]
[NativeTypeName("struct ID3D11HullShader : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11HullShader : ID3D11HullShader.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11HullShader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x61, 0x60, 0x5C, 0x8E,
				0x8A, 0x62,
				0x8E, 0x4C,
				0x82,
				0x64,
				0xBB,
				0xE4,
				0x5C,
				0xB3,
				0xD5,
				0xDD
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11HullShader));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11HullShader));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11HullShader*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11HullShader*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11HullShader*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11HullShader*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11HullShader*, uint>)(lpVtbl[1]))((ID3D11HullShader*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11HullShader*, uint>)(lpVtbl[1]))((ID3D11HullShader*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11HullShader*, uint>)(lpVtbl[2]))((ID3D11HullShader*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11HullShader*, uint>)(lpVtbl[2]))((ID3D11HullShader*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11HullShader*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11HullShader*)Unsafe.AsPointer(ref this), ppDevice);
#else
		((delegate* unmanaged[Stdcall]<ID3D11HullShader*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11HullShader*)Unsafe.AsPointer(ref this), ppDevice);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11HullShader*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11HullShader*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11HullShader*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11HullShader*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11HullShader*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11HullShader*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11HullShader*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11HullShader*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11HullShader*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11HullShader*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11HullShader*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11HullShader*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	public interface Interface : ID3D11DeviceChild.Interface
	{
	}
}

