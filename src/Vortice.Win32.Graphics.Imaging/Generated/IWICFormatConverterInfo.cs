// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICFormatConverterInfo"]/*' />
/// <unmanaged>IWICFormatConverterInfo</unmanaged>
[Guid("9f34fb65-13f4-4f15-bc57-3726b5e53d9f")]
[NativeTypeName("struct IWICFormatConverterInfo : IWICComponentInfo")]
[NativeInheritance("IWICComponentInfo")]
public unsafe partial struct IWICFormatConverterInfo : IWICFormatConverterInfo.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICFormatConverterInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x65, 0xFB, 0x34, 0x9F,
				0xF4, 0x13,
				0x15, 0x4F,
				0xBC,
				0x57,
				0x37,
				0x26,
				0xB5,
				0xE5,
				0x3D,
				0x9F
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICFormatConverterInfo));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICFormatConverterInfo));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, uint>)(lpVtbl[1]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, uint>)(lpVtbl[1]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, uint>)(lpVtbl[2]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, uint>)(lpVtbl[2]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetComponentType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetComponentType(WICComponentType* pType)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pType);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pType);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetCLSID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCLSID(Guid* pclsid)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, Guid*, int>)(lpVtbl[4]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pclsid);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, Guid*, int>)(lpVtbl[4]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pclsid);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSigningStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetSigningStatus(uint* pStatus)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, uint*, int>)(lpVtbl[5]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pStatus);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, uint*, int>)(lpVtbl[5]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pStatus);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetAuthor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetAuthor(uint cchAuthor, ushort* wzAuthor, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVendorGUID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetVendorGUID(Guid* pguidVendor)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, Guid*, int>)(lpVtbl[7]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, Guid*, int>)(lpVtbl[7]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetVersion(uint cchVersion, ushort* wzVersion, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSpecVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSpecVersion(uint cchSpecVersion, ushort* wzSpecVersion, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetFriendlyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFriendlyName(uint cchFriendlyName, ushort* wzFriendlyName, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICFormatConverterInfo::GetPixelFormats"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetPixelFormats(uint cFormats, Guid* pPixelFormatGUIDs, uint* pcActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, uint, Guid*, uint*, int>)(lpVtbl[11]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cFormats, pPixelFormatGUIDs, pcActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, uint, Guid*, uint*, int>)(lpVtbl[11]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cFormats, pPixelFormatGUIDs, pcActual);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICFormatConverterInfo::CreateInstance"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateInstance(IWICFormatConverter** ppIConverter)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICFormatConverterInfo*, IWICFormatConverter**, int>)(lpVtbl[12]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), ppIConverter);
#else
		return ((delegate* unmanaged[Stdcall]<IWICFormatConverterInfo*, IWICFormatConverter**, int>)(lpVtbl[12]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), ppIConverter);
#endif
	}

	public interface Interface : IWICComponentInfo.Interface
	{
		[VtblIndex(11)]
		HResult GetPixelFormats(uint cFormats, Guid* pPixelFormatGUIDs, uint* pcActual);

		[VtblIndex(12)]
		HResult CreateInstance(IWICFormatConverter** ppIConverter);
	}
}

