// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Query1"]/*' />
/// <unmanaged>ID3D11Query1</unmanaged>
[Guid("631b4766-36dc-461d-8db6-c47e13e60916")]
[NativeTypeName("struct ID3D11Query1 : ID3D11Query")]
[NativeInheritance("ID3D11Query")]
public unsafe partial struct ID3D11Query1 : ID3D11Query1.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11Query1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x66, 0x47, 0x1B, 0x63,
				0xDC, 0x36,
				0x1D, 0x46,
				0x8D,
				0xB6,
				0xC4,
				0x7E,
				0x13,
				0xE6,
				0x09,
				0x16
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Query1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Query1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Query1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Query1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Query1*, uint>)(lpVtbl[1]))((ID3D11Query1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Query1*, uint>)(lpVtbl[2]))((ID3D11Query1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Query1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Query1*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Query1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Query1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Query1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Query1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Query1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Query1*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11Asynchronous.GetDataSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public uint GetDataSize()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Query1*, uint>)(lpVtbl[7]))((ID3D11Query1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11Query.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc(QueryDescription* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Query1*, QueryDescription*, void>)(lpVtbl[8]))((ID3D11Query1*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Query1::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void GetDesc1(QueryDescription1* pDesc1)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Query1*, QueryDescription1*, void>)(lpVtbl[9]))((ID3D11Query1*)Unsafe.AsPointer(ref this), pDesc1);
	}

	public interface Interface : ID3D11Query.Interface
	{
		[VtblIndex(9)]
		void GetDesc1(QueryDescription1* pDesc1);
	}
}

