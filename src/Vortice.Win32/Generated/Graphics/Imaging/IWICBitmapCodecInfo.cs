// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Numerics;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.Imaging;

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo"]/*' />
/// <unmanaged>IWICBitmapCodecInfo</unmanaged>
[Guid("e87a44c4-b76e-4c47-8b09-298eb12a2714")]
[NativeTypeName("struct IWICBitmapCodecInfo : IWICComponentInfo")]
[NativeInheritance("IWICComponentInfo")]
public unsafe partial struct IWICBitmapCodecInfo
{
	public static ref readonly Guid IID_IWICBitmapCodecInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC4, 0x44, 0x7A, 0xE8,
				0x6E, 0xB7,
				0x47, 0x4C,
				0x8B,
				0x09,
				0x29,
				0x8E,
				0xB1,
				0x2A,
				0x27,
				0x14
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapCodecInfo));

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

	/// <inheritdoc cref="IWICComponentInfo.GetComponentType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetComponentType(WICComponentType* pType)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pType);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetCLSID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCLSID(Guid* pclsid)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)(lpVtbl[4]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pclsid);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSigningStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetSigningStatus(uint* pStatus)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint*, int>)(lpVtbl[5]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pStatus);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetAuthor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetAuthor(uint cchAuthor, ushort* wzAuthor, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVendorGUID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetVendorGUID(Guid* pguidVendor)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)(lpVtbl[7]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pguidVendor);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetVersion(uint cchVersion, ushort* wzVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSpecVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSpecVersion(uint cchSpecVersion, ushort* wzSpecVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetFriendlyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFriendlyName(uint cchFriendlyName, ushort* wzFriendlyName, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::GetContainerFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetContainerFormat(Guid* pguidContainerFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)(lpVtbl[11]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::GetPixelFormats"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::GetColorManagementVersion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetColorManagementVersion(uint cchColorManagementVersion, ushort* wzColorManagementVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::GetDeviceManufacturer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetDeviceManufacturer(uint cchDeviceManufacturer, ushort* wzDeviceManufacturer, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::GetDeviceModels"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetDeviceModels(uint cchDeviceModels, ushort* wzDeviceModels, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[15]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::GetMimeTypes"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetMimeTypes(uint cchMimeTypes, ushort* wzMimeTypes, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[16]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::GetFileExtensions"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetFileExtensions(uint cchFileExtensions, ushort* wzFileExtensions, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[17]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::DoesSupportAnimation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult DoesSupportAnimation(Bool32* pfSupportAnimation)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Bool32*, int>)(lpVtbl[18]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::DoesSupportChromakey"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult DoesSupportChromakey(Bool32* pfSupportChromakey)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Bool32*, int>)(lpVtbl[19]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::DoesSupportLossless"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult DoesSupportLossless(Bool32* pfSupportLossless)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Bool32*, int>)(lpVtbl[20]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::DoesSupportMultiframe"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult DoesSupportMultiframe(Bool32* pfSupportMultiframe)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Bool32*, int>)(lpVtbl[21]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapCodecInfo::MatchesMimeType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult MatchesMimeType(ushort* wzMimeType, Bool32* pfMatches)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, ushort*, Bool32*, int>)(lpVtbl[22]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
	}
}

