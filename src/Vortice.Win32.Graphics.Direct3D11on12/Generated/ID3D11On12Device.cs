// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11on12;

/// <include file='../../Vortice.Win32.Graphics.Direct3D11/Direct3D11.xml' path='doc/member[@name="ID3D11On12Device"]/*' />
/// <unmanaged>ID3D11On12Device</unmanaged>
[Guid("85611e73-70a9-490e-9614-a9e302777904")]
[NativeTypeName("struct ID3D11On12Device : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11On12Device : ID3D11On12Device.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11On12Device
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x73, 0x1E, 0x61, 0x85,
				0xA9, 0x70,
				0x0E, 0x49,
				0x96,
				0x14,
				0xA9,
				0xE3,
				0x02,
				0x77,
				0x79,
				0x04
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11On12Device));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11On12Device));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11On12Device*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11On12Device*, uint>)(lpVtbl[1]))((ID3D11On12Device*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, uint>)(lpVtbl[1]))((ID3D11On12Device*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11On12Device*, uint>)(lpVtbl[2]))((ID3D11On12Device*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, uint>)(lpVtbl[2]))((ID3D11On12Device*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../../Vortice.Win32.Graphics.Direct3D11/Direct3D11.xml' path='doc/member[@name="ID3D11On12Device::CreateWrappedResource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateWrappedResource(IUnknown* pResource12, ResourceFlags* pFlags11, Graphics.Direct3D12.ResourceStates InState, Graphics.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11On12Device*, IUnknown*, ResourceFlags*, Graphics.Direct3D12.ResourceStates, Graphics.Direct3D12.ResourceStates, Guid*, void**, int>)(lpVtbl[3]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, IUnknown*, ResourceFlags*, Graphics.Direct3D12.ResourceStates, Graphics.Direct3D12.ResourceStates, Guid*, void**, int>)(lpVtbl[3]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
#endif
	}

	/// <include file='../../Vortice.Win32.Graphics.Direct3D11/Direct3D11.xml' path='doc/member[@name="ID3D11On12Device::ReleaseWrappedResources"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void ReleaseWrappedResources(Graphics.Direct3D11.ID3D11Resource** ppResources, uint NumResources)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11On12Device*, Graphics.Direct3D11.ID3D11Resource**, uint, void>)(lpVtbl[4]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), ppResources, NumResources);
#else
		((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Graphics.Direct3D11.ID3D11Resource**, uint, void>)(lpVtbl[4]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), ppResources, NumResources);
#endif
	}

	/// <include file='../../Vortice.Win32.Graphics.Direct3D11/Direct3D11.xml' path='doc/member[@name="ID3D11On12Device::AcquireWrappedResources"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void AcquireWrappedResources(Graphics.Direct3D11.ID3D11Resource** ppResources, uint NumResources)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11On12Device*, Graphics.Direct3D11.ID3D11Resource**, uint, void>)(lpVtbl[5]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), ppResources, NumResources);
#else
		((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Graphics.Direct3D11.ID3D11Resource**, uint, void>)(lpVtbl[5]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), ppResources, NumResources);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult CreateWrappedResource(IUnknown* pResource12, ResourceFlags* pFlags11, Graphics.Direct3D12.ResourceStates InState, Graphics.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11);

		[VtblIndex(4)]
		void ReleaseWrappedResources(Graphics.Direct3D11.ID3D11Resource** ppResources, uint NumResources);

		[VtblIndex(5)]
		void AcquireWrappedResources(Graphics.Direct3D11.ID3D11Resource** ppResources, uint NumResources);
	}
}

