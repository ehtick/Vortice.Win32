// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutput6"]/*' />
/// <unmanaged>IDXGIOutput6</unmanaged>
[Guid("068346e8-aaec-4b84-add7-137f513f77a1")]
[NativeTypeName("struct IDXGIOutput6 : IDXGIOutput5")]
[NativeInheritance("IDXGIOutput5")]
public unsafe partial struct IDXGIOutput6 : IDXGIOutput6.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIOutput6
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xE8, 0x46, 0x83, 0x06,
				0xEC, 0xAA,
				0x84, 0x4B,
				0xAD,
				0xD7,
				0x13,
				0x7F,
				0x51,
				0x3F,
				0x77,
				0xA1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutput6));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutput6));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, uint>)(lpVtbl[1]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint>)(lpVtbl[1]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, uint>)(lpVtbl[2]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint>)(lpVtbl[2]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Name, pUnknown);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Name, pUnknown);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), riid, ppParent);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), riid, ppParent);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDesc(OutputDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, OutputDescription*, int>)(lpVtbl[7]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDescription*, int>)(lpVtbl[7]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.GetDisplayModeList" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetDisplayModeList(Common.Format EnumFormat, EnumModesFlags Flags, uint* pNumModes, Common.ModeDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Common.Format, EnumModesFlags, uint*, Common.ModeDescription*, int>)(lpVtbl[8]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Common.Format, EnumModesFlags, uint*, Common.ModeDescription*, int>)(lpVtbl[8]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.FindClosestMatchingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult FindClosestMatchingMode(Common.ModeDescription* pModeToMatch, Common.ModeDescription* pClosestMatch, IUnknown* pConcernedDevice)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Common.ModeDescription*, Common.ModeDescription*, IUnknown*, int>)(lpVtbl[9]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Common.ModeDescription*, Common.ModeDescription*, IUnknown*, int>)(lpVtbl[9]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.WaitForVBlank" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult WaitForVBlank()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, int>)(lpVtbl[10]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, int>)(lpVtbl[10]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.TakeOwnership" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult TakeOwnership(IUnknown* pDevice, Bool32 Exclusive)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, IUnknown*, Bool32, int>)(lpVtbl[11]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IUnknown*, Bool32, int>)(lpVtbl[11]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.ReleaseOwnership" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public void ReleaseOwnership()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDXGIOutput6*, void>)(lpVtbl[12]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<IDXGIOutput6*, void>)(lpVtbl[12]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.GetGammaControlCapabilities" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetGammaControlCapabilities(Common.GammaControlCapabilities* pGammaCaps)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Common.GammaControlCapabilities*, int>)(lpVtbl[13]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pGammaCaps);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Common.GammaControlCapabilities*, int>)(lpVtbl[13]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pGammaCaps);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.SetGammaControl" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetGammaControl(Common.GammaControl* pArray)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Common.GammaControl*, int>)(lpVtbl[14]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pArray);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Common.GammaControl*, int>)(lpVtbl[14]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pArray);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.GetGammaControl" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetGammaControl(Common.GammaControl* pArray)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Common.GammaControl*, int>)(lpVtbl[15]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pArray);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Common.GammaControl*, int>)(lpVtbl[15]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pArray);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.SetDisplaySurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult SetDisplaySurface(IDXGISurface* pScanoutSurface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, IDXGISurface*, int>)(lpVtbl[16]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pScanoutSurface);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGISurface*, int>)(lpVtbl[16]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pScanoutSurface);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.GetDisplaySurfaceData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetDisplaySurfaceData(IDXGISurface* pDestination)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, IDXGISurface*, int>)(lpVtbl[17]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDestination);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGISurface*, int>)(lpVtbl[17]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDestination);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput.GetFrameStatistics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetFrameStatistics(FrameStatistics* pStats)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, FrameStatistics*, int>)(lpVtbl[18]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pStats);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, FrameStatistics*, int>)(lpVtbl[18]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pStats);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput1.GetDisplayModeList1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetDisplayModeList1(Common.Format EnumFormat, uint Flags, uint* pNumModes, ModeDescription1* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Common.Format, uint, uint*, ModeDescription1*, int>)(lpVtbl[19]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Common.Format, uint, uint*, ModeDescription1*, int>)(lpVtbl[19]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput1.FindClosestMatchingMode1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult FindClosestMatchingMode1(ModeDescription1* pModeToMatch, ModeDescription1* pClosestMatch, IUnknown* pConcernedDevice)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, ModeDescription1*, ModeDescription1*, IUnknown*, int>)(lpVtbl[20]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDescription1*, ModeDescription1*, IUnknown*, int>)(lpVtbl[20]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput1.GetDisplaySurfaceData1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetDisplaySurfaceData1(IDXGIResource* pDestination)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, IDXGIResource*, int>)(lpVtbl[21]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDestination);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGIResource*, int>)(lpVtbl[21]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDestination);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput1.DuplicateOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult DuplicateOutput(IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, IUnknown*, IDXGIOutputDuplication**, int>)(lpVtbl[22]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IUnknown*, IDXGIOutputDuplication**, int>)(lpVtbl[22]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput2.SupportsOverlays" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public Bool32 SupportsOverlays()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Bool32>)(lpVtbl[23]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Bool32>)(lpVtbl[23]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDXGIOutput3.CheckOverlaySupport" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CheckOverlaySupport(Common.Format EnumFormat, IUnknown* pConcernedDevice, uint* pFlags)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Common.Format, IUnknown*, uint*, int>)(lpVtbl[24]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), EnumFormat, pConcernedDevice, pFlags);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Common.Format, IUnknown*, uint*, int>)(lpVtbl[24]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), EnumFormat, pConcernedDevice, pFlags);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput4.CheckOverlayColorSpaceSupport" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CheckOverlayColorSpaceSupport(Common.Format Format, Common.ColorSpaceType ColorSpace, IUnknown* pConcernedDevice, uint* pFlags)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, Common.Format, Common.ColorSpaceType, IUnknown*, uint*, int>)(lpVtbl[25]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Format, ColorSpace, pConcernedDevice, pFlags);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Common.Format, Common.ColorSpaceType, IUnknown*, uint*, int>)(lpVtbl[25]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Format, ColorSpace, pConcernedDevice, pFlags);
#endif
	}

	/// <inheritdoc cref="IDXGIOutput5.DuplicateOutput1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult DuplicateOutput1(IUnknown* pDevice, uint Flags, uint SupportedFormatsCount, Common.Format* pSupportedFormats, IDXGIOutputDuplication** ppOutputDuplication)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, IUnknown*, uint, uint, Common.Format*, IDXGIOutputDuplication**, int>)(lpVtbl[26]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDevice, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplication);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IUnknown*, uint, uint, Common.Format*, IDXGIOutputDuplication**, int>)(lpVtbl[26]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDevice, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplication);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutput6::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult GetDesc1(OutputDescription1* pDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, OutputDescription1*, int>)(lpVtbl[27]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDesc);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDescription1*, int>)(lpVtbl[27]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutput6::CheckHardwareCompositionSupport"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult CheckHardwareCompositionSupport(uint* pFlags)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutput6*, uint*, int>)(lpVtbl[28]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pFlags);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint*, int>)(lpVtbl[28]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pFlags);
#endif
	}

	public interface Interface : IDXGIOutput5.Interface
	{
		[VtblIndex(27)]
		HResult GetDesc1(OutputDescription1* pDesc);

		[VtblIndex(28)]
		HResult CheckHardwareCompositionSupport(uint* pFlags);
	}
}

