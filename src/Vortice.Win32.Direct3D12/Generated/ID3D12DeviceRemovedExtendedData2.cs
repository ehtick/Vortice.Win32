// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData2"]/*' />
/// <unmanaged>ID3D12DeviceRemovedExtendedData2</unmanaged>
[Guid("67fc5816-e4ca-4915-bf18-42541272da54")]
[NativeTypeName("struct ID3D12DeviceRemovedExtendedData2 : ID3D12DeviceRemovedExtendedData1")]
[NativeInheritance("ID3D12DeviceRemovedExtendedData1")]
public unsafe partial struct ID3D12DeviceRemovedExtendedData2 : INativeGuid
{
	public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedData2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x16, 0x58, 0xFC, 0x67,
				0xCA, 0xE4,
				0x15, 0x49,
				0xBF,
				0x18,
				0x42,
				0x54,
				0x12,
				0x72,
				0xDA,
				0x54
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceRemovedExtendedData2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceRemovedExtendedData2));
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

	/// <inheritdoc cref="ID3D12DeviceRemovedExtendedData.GetAutoBreadcrumbsOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetAutoBreadcrumbsOutput(DredAutoBreadcrumbsOutput* pOutput)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredAutoBreadcrumbsOutput*, int>)(lpVtbl[3]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
	}

	/// <inheritdoc cref="ID3D12DeviceRemovedExtendedData.GetPageFaultAllocationOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPageFaultAllocationOutput(DredPageFaultOutput* pOutput)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput*, int>)(lpVtbl[4]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
	}

	/// <inheritdoc cref="ID3D12DeviceRemovedExtendedData1.GetAutoBreadcrumbsOutput1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetAutoBreadcrumbsOutput1(DredAutoBreadcrumbsOutput1* pOutput)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredAutoBreadcrumbsOutput1*, int>)(lpVtbl[5]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
	}

	/// <inheritdoc cref="ID3D12DeviceRemovedExtendedData1.GetPageFaultAllocationOutput1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetPageFaultAllocationOutput1(DredPageFaultOutput1* pOutput)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput1*, int>)(lpVtbl[6]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData2::GetPageFaultAllocationOutput2"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetPageFaultAllocationOutput2(DredPageFaultOutput2* pOutput)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput2*, int>)(lpVtbl[7]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData2::GetDeviceState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public DredDeviceState GetDeviceState()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredDeviceState>)(lpVtbl[8]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this));
	}
}

