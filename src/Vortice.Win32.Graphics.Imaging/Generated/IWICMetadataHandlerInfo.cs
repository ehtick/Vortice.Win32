// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataHandlerInfo"]/*' />
/// <unmanaged>IWICMetadataHandlerInfo</unmanaged>
[Guid("aba958bf-c672-44d1-8d61-ce6df2e682c2")]
[NativeTypeName("struct IWICMetadataHandlerInfo : IWICComponentInfo")]
[NativeInheritance("IWICComponentInfo")]
public unsafe partial struct IWICMetadataHandlerInfo : IWICMetadataHandlerInfo.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICMetadataHandlerInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xBF, 0x58, 0xA9, 0xAB,
				0x72, 0xC6,
				0xD1, 0x44,
				0x8D,
				0x61,
				0xCE,
				0x6D,
				0xF2,
				0xE6,
				0x82,
				0xC2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataHandlerInfo));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataHandlerInfo));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, uint>)(lpVtbl[1]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, uint>)(lpVtbl[2]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IWICComponentInfo.GetComponentType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetComponentType(WICComponentType* pType)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pType);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetCLSID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCLSID(Guid* pclsid)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, Guid*, int>)(lpVtbl[4]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pclsid);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSigningStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetSigningStatus(uint* pStatus)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, uint*, int>)(lpVtbl[5]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pStatus);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetAuthor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetAuthor(uint cchAuthor, ushort* wzAuthor, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVendorGUID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetVendorGUID(Guid* pguidVendor)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, Guid*, int>)(lpVtbl[7]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pguidVendor);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetVersion(uint cchVersion, ushort* wzVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSpecVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSpecVersion(uint cchSpecVersion, ushort* wzSpecVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetFriendlyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFriendlyName(uint cchFriendlyName, ushort* wzFriendlyName, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataHandlerInfo::GetMetadataFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetMetadataFormat(Guid* pguidMetadataFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, Guid*, int>)(lpVtbl[11]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataHandlerInfo::GetContainerFormats"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataHandlerInfo::GetDeviceManufacturer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetDeviceManufacturer(uint cchDeviceManufacturer, ushort* wzDeviceManufacturer, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataHandlerInfo::GetDeviceModels"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetDeviceModels(uint cchDeviceModels, ushort* wzDeviceModels, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataHandlerInfo::DoesRequireFullStream"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult DoesRequireFullStream(Bool32* pfRequiresFullStream)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, Bool32*, int>)(lpVtbl[15]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataHandlerInfo::DoesSupportPadding"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult DoesSupportPadding(Bool32* pfSupportsPadding)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, Bool32*, int>)(lpVtbl[16]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataHandlerInfo::DoesRequireFixedSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult DoesRequireFixedSize(Bool32* pfFixedSize)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataHandlerInfo*, Bool32*, int>)(lpVtbl[17]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
	}

	public interface Interface : IWICComponentInfo.Interface
	{
		[VtblIndex(11)]
		HResult GetMetadataFormat(Guid* pguidMetadataFormat);

		[VtblIndex(12)]
		HResult GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual);

		[VtblIndex(13)]
		HResult GetDeviceManufacturer(uint cchDeviceManufacturer, ushort* wzDeviceManufacturer, uint* pcchActual);

		[VtblIndex(14)]
		HResult GetDeviceModels(uint cchDeviceModels, ushort* wzDeviceModels, uint* pcchActual);

		[VtblIndex(15)]
		HResult DoesRequireFullStream(Bool32* pfRequiresFullStream);

		[VtblIndex(16)]
		HResult DoesSupportPadding(Bool32* pfSupportsPadding);

		[VtblIndex(17)]
		HResult DoesRequireFixedSize(Bool32* pfFixedSize);
	}
}

