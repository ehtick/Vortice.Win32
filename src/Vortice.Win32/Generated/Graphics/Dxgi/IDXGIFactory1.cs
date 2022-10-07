// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory1"]/*' />
/// <unmanaged>IDXGIFactory1</unmanaged>
[Guid("770aae78-f26f-4dba-a829-253c83d1b387")]
[NativeTypeName("struct IDXGIFactory1 : IDXGIFactory")]
[NativeInheritance("IDXGIFactory")]
public unsafe partial struct IDXGIFactory1 : INativeGuid
{
	public static ref readonly Guid IID_IDXGIFactory1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x78, 0xAE, 0x0A, 0x77,
				0x6F, 0xF2,
				0xBA, 0x4D,
				0xA8,
				0x29,
				0x25,
				0x3C,
				0x83,
				0xD1,
				0xB3,
				0x87
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactory1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactory1));
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

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIFactory.EnumAdapters" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult EnumAdapters(uint Adapter, IDXGIAdapter** ppAdapter)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, uint, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
	}

	/// <inheritdoc cref="IDXGIFactory.MakeWindowAssociation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult MakeWindowAssociation(IntPtr WindowHandle, uint Flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, IntPtr, uint, int>)(lpVtbl[8]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
	}

	/// <inheritdoc cref="IDXGIFactory.GetWindowAssociation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetWindowAssociation(IntPtr* pWindowHandle)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, IntPtr*, int>)(lpVtbl[9]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), pWindowHandle);
	}

	/// <inheritdoc cref="IDXGIFactory.CreateSwapChain" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateSwapChain(IUnknown* pDevice, SwapChainDescription* pDesc, IDXGISwapChain** ppSwapChain)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, IUnknown*, SwapChainDescription*, IDXGISwapChain**, int>)(lpVtbl[10]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
	}

	/// <inheritdoc cref="IDXGIFactory.CreateSoftwareAdapter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateSoftwareAdapter(IntPtr Module, IDXGIAdapter** ppAdapter)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, IntPtr, IDXGIAdapter**, int>)(lpVtbl[11]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Module, ppAdapter);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory1::EnumAdapters1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, uint, IDXGIAdapter1**, int>)(lpVtbl[12]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory1::IsCurrent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public Bool32 IsCurrent()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Bool32>)(lpVtbl[13]))((IDXGIFactory1*)Unsafe.AsPointer(ref this));
	}
}

