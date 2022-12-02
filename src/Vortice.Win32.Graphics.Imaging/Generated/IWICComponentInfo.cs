// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentInfo"]/*' />
/// <unmanaged>IWICComponentInfo</unmanaged>
[Guid("23bc3f0a-698b-4357-886b-f24d50671334")]
[NativeTypeName("struct IWICComponentInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICComponentInfo : IWICComponentInfo.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICComponentInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x0A, 0x3F, 0xBC, 0x23,
				0x8B, 0x69,
				0x57, 0x43,
				0x88,
				0x6B,
				0xF2,
				0x4D,
				0x50,
				0x67,
				0x13,
				0x34
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICComponentInfo));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICComponentInfo));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICComponentInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, uint>)(lpVtbl[1]))((IWICComponentInfo*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, uint>)(lpVtbl[2]))((IWICComponentInfo*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentInfo::GetComponentType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetComponentType(WICComponentType* pType)
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICComponentInfo*)Unsafe.AsPointer(ref this), pType);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentInfo::GetCLSID"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCLSID(Guid* pclsid)
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, Guid*, int>)(lpVtbl[4]))((IWICComponentInfo*)Unsafe.AsPointer(ref this), pclsid);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentInfo::GetSigningStatus"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetSigningStatus(uint* pStatus)
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, uint*, int>)(lpVtbl[5]))((IWICComponentInfo*)Unsafe.AsPointer(ref this), pStatus);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentInfo::GetAuthor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetAuthor(uint cchAuthor, ushort* wzAuthor, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICComponentInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentInfo::GetVendorGUID"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetVendorGUID(Guid* pguidVendor)
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, Guid*, int>)(lpVtbl[7]))((IWICComponentInfo*)Unsafe.AsPointer(ref this), pguidVendor);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentInfo::GetVersion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetVersion(uint cchVersion, ushort* wzVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICComponentInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentInfo::GetSpecVersion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSpecVersion(uint cchSpecVersion, ushort* wzSpecVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICComponentInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentInfo::GetFriendlyName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFriendlyName(uint cchFriendlyName, ushort* wzFriendlyName, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICComponentInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICComponentInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetComponentType(WICComponentType* pType);

		[VtblIndex(4)]
		HResult GetCLSID(Guid* pclsid);

		[VtblIndex(5)]
		HResult GetSigningStatus(uint* pStatus);

		[VtblIndex(6)]
		HResult GetAuthor(uint cchAuthor, ushort* wzAuthor, uint* pcchActual);

		[VtblIndex(7)]
		HResult GetVendorGUID(Guid* pguidVendor);

		[VtblIndex(8)]
		HResult GetVersion(uint cchVersion, ushort* wzVersion, uint* pcchActual);

		[VtblIndex(9)]
		HResult GetSpecVersion(uint cchSpecVersion, ushort* wzSpecVersion, uint* pcchActual);

		[VtblIndex(10)]
		HResult GetFriendlyName(uint cchFriendlyName, ushort* wzFriendlyName, uint* pcchActual);
	}
}

