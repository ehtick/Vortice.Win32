// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='DXGI.xml' path='doc/member[@name="IDXGISurface2"]/*' />
/// <unmanaged>IDXGISurface2</unmanaged>
[Guid("aba496dd-b617-4cb8-a866-bc44d7eb1fa2")]
[NativeTypeName("struct IDXGISurface2 : IDXGISurface1")]
[NativeInheritance("IDXGISurface1")]
public unsafe partial struct IDXGISurface2 : INativeGuid
{
	public static ref readonly Guid IID_IDXGISurface2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xDD, 0x96, 0xA4, 0xAB,
				0x17, 0xB6,
				0xB8, 0x4C,
				0xA8,
				0x66,
				0xBC,
				0x44,
				0xD7,
				0xEB,
				0x1F,
				0xA2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISurface2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISurface2));
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
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISurface2*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISurface2*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISurface2*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISurface2*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppDevice)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISurface2*)Unsafe.AsPointer(ref this), riid, ppDevice);
	}

	/// <inheritdoc cref="IDXGISurface.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetDesc(SurfaceDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, SurfaceDescription*, int>)(lpVtbl[8]))((IDXGISurface2*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="IDXGISurface.Map" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult Map(MappedRect* pLockedRect, uint MapFlags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, MappedRect*, uint, int>)(lpVtbl[9]))((IDXGISurface2*)Unsafe.AsPointer(ref this), pLockedRect, MapFlags);
	}

	/// <inheritdoc cref="IDXGISurface.Unmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult Unmap()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, int>)(lpVtbl[10]))((IDXGISurface2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGISurface1.GetDC" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetDC(Bool32 Discard, IntPtr* phdc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Bool32, IntPtr*, int>)(lpVtbl[11]))((IDXGISurface2*)Unsafe.AsPointer(ref this), Discard, phdc);
	}

	/// <inheritdoc cref="IDXGISurface1.ReleaseDC" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult ReleaseDC(RawRect* pDirtyRect)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, RawRect*, int>)(lpVtbl[12]))((IDXGISurface2*)Unsafe.AsPointer(ref this), pDirtyRect);
	}

	/// <include file='DXGI.xml' path='doc/member[@name="IDXGISurface2::GetResource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetResource(Guid* riid, void** ppParentResource, uint* pSubresourceIndex)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, uint*, int>)(lpVtbl[13]))((IDXGISurface2*)Unsafe.AsPointer(ref this), riid, ppParentResource, pSubresourceIndex);
	}
}

