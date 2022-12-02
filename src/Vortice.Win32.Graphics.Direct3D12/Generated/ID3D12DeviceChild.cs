// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DeviceChild"]/*' />
/// <unmanaged>ID3D12DeviceChild</unmanaged>
[Guid("905db94b-a00c-4140-9df5-2b64ca9ea357")]
[NativeTypeName("struct ID3D12DeviceChild : ID3D12Object")]
[NativeInheritance("ID3D12Object")]
public unsafe partial struct ID3D12DeviceChild : ID3D12DeviceChild.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12DeviceChild
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4B, 0xB9, 0x5D, 0x90,
				0x0C, 0xA0,
				0x40, 0x41,
				0x9D,
				0xF5,
				0x2B,
				0x64,
				0xCA,
				0x9E,
				0xA3,
				0x57
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceChild));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceChild));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceChild*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DeviceChild*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceChild*, uint>)(lpVtbl[1]))((ID3D12DeviceChild*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceChild*, uint>)(lpVtbl[2]))((ID3D12DeviceChild*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceChild*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12DeviceChild*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceChild*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12DeviceChild*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceChild*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12DeviceChild*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceChild*, ushort*, int>)(lpVtbl[6]))((ID3D12DeviceChild*)Unsafe.AsPointer(ref this), Name);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DeviceChild::GetDevice"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceChild*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12DeviceChild*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	public interface Interface : ID3D12Object.Interface
	{
		[VtblIndex(7)]
		HResult GetDevice(Guid* riid, void** ppvDevice);
	}
}

