// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='Direct3D11.xml' path='doc/member[@name="ID3D11VideoDecoder"]/*' />
/// <unmanaged>ID3D11VideoDecoder</unmanaged>
[Guid("3c9c5b51-995d-48d1-9b8d-fa5caeded65c")]
[NativeTypeName("struct ID3D11VideoDecoder : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11VideoDecoder : INativeGuid
{
	public static ref readonly Guid IID_ID3D11VideoDecoder
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x51, 0x5B, 0x9C, 0x3C,
				0x5D, 0x99,
				0xD1, 0x48,
				0x9B,
				0x8D,
				0xFA,
				0x5C,
				0xAE,
				0xDE,
				0xD6,
				0x5C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoDecoder));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoDecoder));
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

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoDecoder*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDecoder*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDecoder*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDecoder*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <include file='Direct3D11.xml' path='doc/member[@name="ID3D11VideoDecoder::GetCreationParameters"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetCreationParameters(VideoDecoderDescription* pVideoDesc, VideoDecoderConfig* pConfig)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDecoder*, VideoDecoderDescription*, VideoDecoderConfig*, int>)(lpVtbl[7]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), pVideoDesc, pConfig);
	}

	/// <include file='Direct3D11.xml' path='doc/member[@name="ID3D11VideoDecoder::GetDriverHandle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetDriverHandle(Handle* pDriverHandle)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDecoder*, Handle*, int>)(lpVtbl[8]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), pDriverHandle);
	}
}

