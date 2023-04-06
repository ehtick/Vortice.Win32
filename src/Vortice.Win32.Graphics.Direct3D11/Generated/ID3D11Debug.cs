// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Debug"]/*' />
/// <unmanaged>ID3D11Debug</unmanaged>
[Guid("79cf2233-7536-4948-9d36-1e4692dc5760")]
[NativeTypeName("struct ID3D11Debug : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11Debug : ID3D11Debug.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11Debug
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x33, 0x22, 0xCF, 0x79,
				0x36, 0x75,
				0x48, 0x49,
				0x9D,
				0x36,
				0x1E,
				0x46,
				0x92,
				0xDC,
				0x57,
				0x60
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Debug));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Debug));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Debug*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Debug*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, uint>)(lpVtbl[1]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)(lpVtbl[1]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, uint>)(lpVtbl[2]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)(lpVtbl[2]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Debug::SetFeatureMask"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetFeatureMask(uint Mask)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, uint, int>)(lpVtbl[3]))((ID3D11Debug*)Unsafe.AsPointer(ref this), Mask);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, int>)(lpVtbl[3]))((ID3D11Debug*)Unsafe.AsPointer(ref this), Mask);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Debug::GetFeatureMask"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public uint GetFeatureMask()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, uint>)(lpVtbl[4]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)(lpVtbl[4]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Debug::SetPresentPerRenderOpDelay"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPresentPerRenderOpDelay(uint Milliseconds)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, uint, int>)(lpVtbl[5]))((ID3D11Debug*)Unsafe.AsPointer(ref this), Milliseconds);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, int>)(lpVtbl[5]))((ID3D11Debug*)Unsafe.AsPointer(ref this), Milliseconds);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Debug::GetPresentPerRenderOpDelay"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public uint GetPresentPerRenderOpDelay()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, uint>)(lpVtbl[6]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)(lpVtbl[6]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Debug::SetSwapChain"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetSwapChain(Graphics.Dxgi.IDXGISwapChain* pSwapChain)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, Graphics.Dxgi.IDXGISwapChain*, int>)(lpVtbl[7]))((ID3D11Debug*)Unsafe.AsPointer(ref this), pSwapChain);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Graphics.Dxgi.IDXGISwapChain*, int>)(lpVtbl[7]))((ID3D11Debug*)Unsafe.AsPointer(ref this), pSwapChain);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Debug::GetSwapChain"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetSwapChain(Graphics.Dxgi.IDXGISwapChain** ppSwapChain)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, Graphics.Dxgi.IDXGISwapChain**, int>)(lpVtbl[8]))((ID3D11Debug*)Unsafe.AsPointer(ref this), ppSwapChain);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Graphics.Dxgi.IDXGISwapChain**, int>)(lpVtbl[8]))((ID3D11Debug*)Unsafe.AsPointer(ref this), ppSwapChain);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Debug::ValidateContext"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult ValidateContext(ID3D11DeviceContext* pContext)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, ID3D11DeviceContext*, int>)(lpVtbl[9]))((ID3D11Debug*)Unsafe.AsPointer(ref this), pContext);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)(lpVtbl[9]))((ID3D11Debug*)Unsafe.AsPointer(ref this), pContext);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Debug::ReportLiveDeviceObjects"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult ReportLiveDeviceObjects(ReportLiveDeviceObjectFlags Flags)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, ReportLiveDeviceObjectFlags, int>)(lpVtbl[10]))((ID3D11Debug*)Unsafe.AsPointer(ref this), Flags);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ReportLiveDeviceObjectFlags, int>)(lpVtbl[10]))((ID3D11Debug*)Unsafe.AsPointer(ref this), Flags);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Debug::ValidateContextForDispatch"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult ValidateContextForDispatch(ID3D11DeviceContext* pContext)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Debug*, ID3D11DeviceContext*, int>)(lpVtbl[11]))((ID3D11Debug*)Unsafe.AsPointer(ref this), pContext);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)(lpVtbl[11]))((ID3D11Debug*)Unsafe.AsPointer(ref this), pContext);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult SetFeatureMask(uint Mask);

		[VtblIndex(4)]
		uint GetFeatureMask();

		[VtblIndex(5)]
		HResult SetPresentPerRenderOpDelay(uint Milliseconds);

		[VtblIndex(6)]
		uint GetPresentPerRenderOpDelay();

		[VtblIndex(7)]
		HResult SetSwapChain(Graphics.Dxgi.IDXGISwapChain* pSwapChain);

		[VtblIndex(8)]
		HResult GetSwapChain(Graphics.Dxgi.IDXGISwapChain** ppSwapChain);

		[VtblIndex(9)]
		HResult ValidateContext(ID3D11DeviceContext* pContext);

		[VtblIndex(10)]
		HResult ReportLiveDeviceObjects(ReportLiveDeviceObjectFlags Flags);

		[VtblIndex(11)]
		HResult ValidateContextForDispatch(ID3D11DeviceContext* pContext);
	}
}

