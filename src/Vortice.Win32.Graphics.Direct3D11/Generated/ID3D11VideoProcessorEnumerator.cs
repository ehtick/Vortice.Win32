// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator"]/*' />
/// <unmanaged>ID3D11VideoProcessorEnumerator</unmanaged>
[Guid("31627037-53ab-4200-9061-05faa9ab45f9")]
[NativeTypeName("struct ID3D11VideoProcessorEnumerator : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11VideoProcessorEnumerator : ID3D11VideoProcessorEnumerator.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11VideoProcessorEnumerator
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x37, 0x70, 0x62, 0x31,
				0xAB, 0x53,
				0x00, 0x42,
				0x90,
				0x61,
				0x05,
				0xFA,
				0xA9,
				0xAB,
				0x45,
				0xF9
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoProcessorEnumerator));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoProcessorEnumerator));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint>)(lpVtbl[1]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, uint>)(lpVtbl[1]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint>)(lpVtbl[2]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, uint>)(lpVtbl[2]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), ppDevice);
#else
		((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), ppDevice);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator::GetVideoProcessorContentDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetVideoProcessorContentDesc(VideoProcessorContentDescription* pContentDesc)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, VideoProcessorContentDescription*, int>)(lpVtbl[7]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), pContentDesc);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, VideoProcessorContentDescription*, int>)(lpVtbl[7]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), pContentDesc);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator::CheckVideoProcessorFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CheckVideoProcessorFormat(Graphics.Dxgi.Common.Format Format, uint* pFlags)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Graphics.Dxgi.Common.Format, uint*, int>)(lpVtbl[8]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), Format, pFlags);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Graphics.Dxgi.Common.Format, uint*, int>)(lpVtbl[8]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), Format, pFlags);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator::GetVideoProcessorCaps"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetVideoProcessorCaps(VideoProcessorCaps* pCaps)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, VideoProcessorCaps*, int>)(lpVtbl[9]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), pCaps);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, VideoProcessorCaps*, int>)(lpVtbl[9]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), pCaps);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator::GetVideoProcessorRateConversionCaps"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetVideoProcessorRateConversionCaps(uint TypeIndex, VideoProcessorRateConversionCaps* pCaps)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint, VideoProcessorRateConversionCaps*, int>)(lpVtbl[10]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), TypeIndex, pCaps);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, uint, VideoProcessorRateConversionCaps*, int>)(lpVtbl[10]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), TypeIndex, pCaps);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator::GetVideoProcessorCustomRate"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetVideoProcessorCustomRate(uint TypeIndex, uint CustomRateIndex, VideoProcessorCustomRate* pRate)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint, uint, VideoProcessorCustomRate*, int>)(lpVtbl[11]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), TypeIndex, CustomRateIndex, pRate);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, uint, uint, VideoProcessorCustomRate*, int>)(lpVtbl[11]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), TypeIndex, CustomRateIndex, pRate);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator::GetVideoProcessorFilterRange"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetVideoProcessorFilterRange(VideoProcessorFilter Filter, VideoProcessorFilterRange* pRange)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, VideoProcessorFilter, VideoProcessorFilterRange*, int>)(lpVtbl[12]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), Filter, pRange);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, VideoProcessorFilter, VideoProcessorFilterRange*, int>)(lpVtbl[12]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), Filter, pRange);
#endif
	}

	public interface Interface : ID3D11DeviceChild.Interface
	{
		[VtblIndex(7)]
		HResult GetVideoProcessorContentDesc(VideoProcessorContentDescription* pContentDesc);

		[VtblIndex(8)]
		HResult CheckVideoProcessorFormat(Graphics.Dxgi.Common.Format Format, uint* pFlags);

		[VtblIndex(9)]
		HResult GetVideoProcessorCaps(VideoProcessorCaps* pCaps);

		[VtblIndex(10)]
		HResult GetVideoProcessorRateConversionCaps(uint TypeIndex, VideoProcessorRateConversionCaps* pCaps);

		[VtblIndex(11)]
		HResult GetVideoProcessorCustomRate(uint TypeIndex, uint CustomRateIndex, VideoProcessorCustomRate* pRate);

		[VtblIndex(12)]
		HResult GetVideoProcessorFilterRange(VideoProcessorFilter Filter, VideoProcessorFilterRange* pRange);
	}
}

