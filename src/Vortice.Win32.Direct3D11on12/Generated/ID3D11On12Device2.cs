// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11on12;

/// <include file='Direct3D11on12.xml' path='doc/member[@name="ID3D11On12Device2"]/*' />
/// <unmanaged>ID3D11On12Device2</unmanaged>
[Guid("dc90f331-4740-43fa-866e-67f12cb58223")]
[NativeTypeName("struct ID3D11On12Device2 : ID3D11On12Device1")]
[NativeInheritance("ID3D11On12Device1")]
public unsafe partial struct ID3D11On12Device2 : INativeGuid
{
	public static ref readonly Guid IID_ID3D11On12Device2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x31, 0xF3, 0x90, 0xDC,
				0x40, 0x47,
				0xFA, 0x43,
				0x86,
				0x6E,
				0x67,
				0xF1,
				0x2C,
				0xB5,
				0x82,
				0x23
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11On12Device2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11On12Device2));
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

	/// <inheritdoc cref="ID3D11On12Device.CreateWrappedResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateWrappedResource(IUnknown* pResource12, ResourceFlags* pFlags11, Graphics.Direct3D12.ResourceStates InState, Graphics.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, IUnknown*, ResourceFlags*, Graphics.Direct3D12.ResourceStates, Graphics.Direct3D12.ResourceStates, Guid*, void**, int>)(lpVtbl[3]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
	}

	/// <inheritdoc cref="ID3D11On12Device.ReleaseWrappedResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void ReleaseWrappedResources(Graphics.Direct3D11.ID3D11Resource** ppResources, uint NumResources)
	{
		((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Graphics.Direct3D11.ID3D11Resource**, uint, void>)(lpVtbl[4]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), ppResources, NumResources);
	}

	/// <inheritdoc cref="ID3D11On12Device.AcquireWrappedResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void AcquireWrappedResources(Graphics.Direct3D11.ID3D11Resource** ppResources, uint NumResources)
	{
		((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Graphics.Direct3D11.ID3D11Resource**, uint, void>)(lpVtbl[5]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), ppResources, NumResources);
	}

	/// <inheritdoc cref="ID3D11On12Device1.GetD3D12Device" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetD3D12Device(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Guid*, void**, int>)(lpVtbl[6]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	/// <include file='Direct3D11on12.xml' path='doc/member[@name="ID3D11On12Device2::UnwrapUnderlyingResource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult UnwrapUnderlyingResource(Graphics.Direct3D11.ID3D11Resource* pResource11, Graphics.Direct3D12.ID3D12CommandQueue* pCommandQueue, Guid* riid, void** ppvResource12)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Graphics.Direct3D11.ID3D11Resource*, Graphics.Direct3D12.ID3D12CommandQueue*, Guid*, void**, int>)(lpVtbl[7]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), pResource11, pCommandQueue, riid, ppvResource12);
	}

	/// <include file='Direct3D11on12.xml' path='doc/member[@name="ID3D11On12Device2::ReturnUnderlyingResource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult ReturnUnderlyingResource(Graphics.Direct3D11.ID3D11Resource* pResource11, uint NumSync, ulong* pSignalValues, Graphics.Direct3D12.ID3D12Fence** ppFences)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Graphics.Direct3D11.ID3D11Resource*, uint, ulong*, Graphics.Direct3D12.ID3D12Fence**, int>)(lpVtbl[8]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), pResource11, NumSync, pSignalValues, ppFences);
	}
}

