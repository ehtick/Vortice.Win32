// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings1"]/*' />
/// <unmanaged>ID3D12DeviceRemovedExtendedDataSettings1</unmanaged>
[Guid("dbd5ae51-3317-4f0a-adf9-1d7cedcaae0b")]
[NativeTypeName("struct ID3D12DeviceRemovedExtendedDataSettings1 : ID3D12DeviceRemovedExtendedDataSettings")]
[NativeInheritance("ID3D12DeviceRemovedExtendedDataSettings")]
public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings1 : INativeGuid
{
	public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedDataSettings1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x51, 0xAE, 0xD5, 0xDB,
				0x17, 0x33,
				0x0A, 0x4F,
				0xAD,
				0xF9,
				0x1D,
				0x7C,
				0xED,
				0xCA,
				0xAE,
				0x0B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceRemovedExtendedDataSettings1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceRemovedExtendedDataSettings1));
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

	/// <inheritdoc cref="ID3D12DeviceRemovedExtendedDataSettings.SetAutoBreadcrumbsEnablement" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void SetAutoBreadcrumbsEnablement(DredEnablement Enablement)
	{
		((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)(lpVtbl[3]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
	}

	/// <inheritdoc cref="ID3D12DeviceRemovedExtendedDataSettings.SetPageFaultEnablement" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetPageFaultEnablement(DredEnablement Enablement)
	{
		((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)(lpVtbl[4]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
	}

	/// <inheritdoc cref="ID3D12DeviceRemovedExtendedDataSettings.SetWatsonDumpEnablement" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetWatsonDumpEnablement(DredEnablement Enablement)
	{
		((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)(lpVtbl[5]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings1::SetBreadcrumbContextEnablement"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void SetBreadcrumbContextEnablement(DredEnablement Enablement)
	{
		((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)(lpVtbl[6]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
	}
}

