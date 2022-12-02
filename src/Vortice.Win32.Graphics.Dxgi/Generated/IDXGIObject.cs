// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIObject"]/*' />
/// <unmanaged>IDXGIObject</unmanaged>
[Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e")]
[NativeTypeName("struct IDXGIObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGIObject : IDXGIObject.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xB8, 0x2F, 0xC2, 0xAE,
				0xF3, 0x76,
				0x39, 0x46,
				0x9B,
				0xE0,
				0x28,
				0xEB,
				0x43,
				0xA6,
				0x7A,
				0x2E
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIObject));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIObject));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIObject*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIObject*, uint>)(lpVtbl[1]))((IDXGIObject*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIObject*, uint>)(lpVtbl[2]))((IDXGIObject*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIObject::SetPrivateData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIObject*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIObject*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIObject::SetPrivateDataInterface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIObject*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIObject*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIObject::GetPrivateData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIObject*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIObject*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIObject::GetParent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIObject*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIObject*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult SetPrivateData(Guid* Name, uint DataSize, void* pData);

		[VtblIndex(4)]
		HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown);

		[VtblIndex(5)]
		HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData);

		[VtblIndex(6)]
		HResult GetParent(Guid* riid, void** ppParent);
	}
}

