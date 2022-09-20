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

namespace Win32.Graphics.Direct3D11;

/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice"]/*' />
/// <unmanaged>ID3D11VideoDevice</unmanaged>
[Guid("10ec4d5b-975a-4689-b9e4-d0aac30fe333")]
[NativeTypeName("struct ID3D11VideoDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11VideoDevice
{
	public static ref readonly Guid IID_ID3D11VideoDevice
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x5B, 0x4D, 0xEC, 0x10,
				0x5A, 0x97,
				0x89, 0x46,
				0xB9,
				0xE4,
				0xD0,
				0xAA,
				0xC3,
				0x0F,
				0xE3,
				0x33
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoDevice));

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

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::CreateVideoDecoder"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateVideoDecoder(VideoDecoderDescription* pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDescription*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)(lpVtbl[3]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pVideoDesc, pConfig, ppDecoder);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::CreateVideoProcessor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)(lpVtbl[4]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pEnum, RateConversionIndex, ppVideoProcessor);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::CreateAuthenticatedChannel"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateAuthenticatedChannel(AuthenticatedChannelType ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)(lpVtbl[5]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), ChannelType, ppAuthenticatedChannel);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::CreateCryptoSession"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)(lpVtbl[6]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::CreateVideoDecoderOutputView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateVideoDecoderOutputView(ID3D11Resource* pResource, VideoDecoderOutputViewDescription* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDescription*, ID3D11VideoDecoderOutputView**, int>)(lpVtbl[7]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pResource, pDesc, ppVDOVView);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::CreateVideoProcessorInputView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDescription* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDescription*, ID3D11VideoProcessorInputView**, int>)(lpVtbl[8]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPIView);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::CreateVideoProcessorOutputView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDescription* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDescription*, ID3D11VideoProcessorOutputView**, int>)(lpVtbl[9]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPOView);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::CreateVideoProcessorEnumerator"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateVideoProcessorEnumerator(VideoProcessorContentDescription* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoProcessorContentDescription*, ID3D11VideoProcessorEnumerator**, int>)(lpVtbl[10]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pDesc, ppEnum);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::GetVideoDecoderProfileCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public uint GetVideoDecoderProfileCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint>)(lpVtbl[11]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::GetVideoDecoderProfile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetVideoDecoderProfile(uint Index, Guid* pDecoderProfile)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint, Guid*, int>)(lpVtbl[12]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), Index, pDecoderProfile);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::CheckVideoDecoderFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CheckVideoDecoderFormat(Guid* pDecoderProfile, Graphics.Dxgi.Common.Format Format, Bool32* pSupported)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Graphics.Dxgi.Common.Format, Bool32*, int>)(lpVtbl[13]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pDecoderProfile, Format, pSupported);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::GetVideoDecoderConfigCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetVideoDecoderConfigCount(VideoDecoderDescription* pDesc, uint* pCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDescription*, uint*, int>)(lpVtbl[14]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pDesc, pCount);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::GetVideoDecoderConfig"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetVideoDecoderConfig(VideoDecoderDescription* pDesc, uint Index, VideoDecoderConfig* pConfig)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDescription*, uint, VideoDecoderConfig*, int>)(lpVtbl[15]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pDesc, Index, pConfig);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::GetContentProtectionCaps"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetContentProtectionCaps(Guid* pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)(lpVtbl[16]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pCaps);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::CheckCryptoKeyExchange"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CheckCryptoKeyExchange(Guid* pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)(lpVtbl[17]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::SetPrivateData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, uint, void*, int>)(lpVtbl[18]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice::SetPrivateDataInterface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, IUnknown*, int>)(lpVtbl[19]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), guid, pData);
	}
}

