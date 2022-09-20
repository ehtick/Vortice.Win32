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

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw"]/*' />
/// <unmanaged>IWICDevelopRaw</unmanaged>
[Guid("fbec5e44-f7be-4b65-b7f8-c0c81fef026d")]
[NativeTypeName("struct IWICDevelopRaw : IWICBitmapFrameDecode")]
[NativeInheritance("IWICBitmapFrameDecode")]
public unsafe partial struct IWICDevelopRaw
{
	public static ref readonly Guid IID_IWICDevelopRaw
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x44, 0x5E, 0xEC, 0xFB,
				0xBE, 0xF7,
				0x65, 0x4B,
				0xB7,
				0xF8,
				0xC0,
				0xC8,
				0x1F,
				0xEF,
				0x02,
				0x6D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDevelopRaw));

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

	/// <inheritdoc cref="IWICBitmapSource.GetSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetSize(uint* puiWidth, uint* puiHeight)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, int>)(lpVtbl[3]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
	}

	/// <inheritdoc cref="IWICBitmapSource.GetPixelFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPixelFormat(Guid* pPixelFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, int>)(lpVtbl[4]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pPixelFormat);
	}

	/// <inheritdoc cref="IWICBitmapSource.GetResolution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetResolution(double* pDpiX, double* pDpiY)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, double*, int>)(lpVtbl[5]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
	}

	/// <inheritdoc cref="IWICBitmapSource.CopyPalette" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CopyPalette(IWICPalette* pIPalette)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICPalette*, int>)(lpVtbl[6]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pIPalette);
	}

	/// <inheritdoc cref="IWICBitmapSource.CopyPixels" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CopyPixels(System.Drawing.Rectangle* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, System.Drawing.Rectangle*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
	}

	/// <inheritdoc cref="IWICBitmapFrameDecode.GetMetadataQueryReader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICMetadataQueryReader**, int>)(lpVtbl[8]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
	}

	/// <inheritdoc cref="IWICBitmapFrameDecode.GetColorContexts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)(lpVtbl[9]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
	}

	/// <inheritdoc cref="IWICBitmapFrameDecode.GetThumbnail" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetThumbnail(IWICBitmapSource** ppIThumbnail)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICBitmapSource**, int>)(lpVtbl[10]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIThumbnail);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::QueryRawCapabilitiesInfo"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult QueryRawCapabilitiesInfo(WICRawCapabilitiesInfo* pInfo)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, WICRawCapabilitiesInfo*, int>)(lpVtbl[11]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pInfo);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::LoadParameterSet"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult LoadParameterSet(WICRawParameterSet ParameterSet)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, WICRawParameterSet, int>)(lpVtbl[12]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ParameterSet);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetCurrentParameterSet"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetCurrentParameterSet(Com.IPropertyBag2** ppCurrentParameterSet)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Com.IPropertyBag2**, int>)(lpVtbl[13]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppCurrentParameterSet);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetExposureCompensation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetExposureCompensation(double ev)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)(lpVtbl[14]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ev);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetExposureCompensation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetExposureCompensation(double* pEV)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)(lpVtbl[15]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pEV);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetWhitePointRGB"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult SetWhitePointRGB(uint Red, uint Green, uint Blue)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, uint, uint, int>)(lpVtbl[16]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Red, Green, Blue);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetWhitePointRGB"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetWhitePointRGB(uint* pRed, uint* pGreen, uint* pBlue)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)(lpVtbl[17]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRed, pGreen, pBlue);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetNamedWhitePoint"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult SetNamedWhitePoint(WICNamedWhitePoint WhitePoint)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, WICNamedWhitePoint, int>)(lpVtbl[18]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePoint);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetNamedWhitePoint"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetNamedWhitePoint(WICNamedWhitePoint* pWhitePoint)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, WICNamedWhitePoint*, int>)(lpVtbl[19]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePoint);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetWhitePointKelvin"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult SetWhitePointKelvin(uint WhitePointKelvin)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, int>)(lpVtbl[20]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePointKelvin);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetWhitePointKelvin"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetWhitePointKelvin(uint* pWhitePointKelvin)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, int>)(lpVtbl[21]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePointKelvin);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetKelvinRangeInfo"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult GetKelvinRangeInfo(uint* pMinKelvinTemp, uint* pMaxKelvinTemp, uint* pKelvinTempStepValue)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)(lpVtbl[22]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValue);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetContrast"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult SetContrast(double Contrast)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)(lpVtbl[23]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Contrast);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetContrast"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetContrast(double* pContrast)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)(lpVtbl[24]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pContrast);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetGamma"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult SetGamma(double Gamma)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)(lpVtbl[25]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Gamma);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetGamma"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetGamma(double* pGamma)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)(lpVtbl[26]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pGamma);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetSharpness"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult SetSharpness(double Sharpness)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)(lpVtbl[27]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Sharpness);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetSharpness"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult GetSharpness(double* pSharpness)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)(lpVtbl[28]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSharpness);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetSaturation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult SetSaturation(double Saturation)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)(lpVtbl[29]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Saturation);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetSaturation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult GetSaturation(double* pSaturation)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)(lpVtbl[30]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSaturation);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetTint"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult SetTint(double Tint)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)(lpVtbl[31]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Tint);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetTint"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult GetTint(double* pTint)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)(lpVtbl[32]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pTint);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetNoiseReduction"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult SetNoiseReduction(double NoiseReduction)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)(lpVtbl[33]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), NoiseReduction);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetNoiseReduction"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult GetNoiseReduction(double* pNoiseReduction)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)(lpVtbl[34]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pNoiseReduction);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetDestinationColorContext"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult SetDestinationColorContext(IWICColorContext* pColorContext)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICColorContext*, int>)(lpVtbl[35]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pColorContext);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetToneCurve"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public HResult SetToneCurve(uint cbToneCurveSize, WICRawToneCurve* pToneCurve)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, WICRawToneCurve*, int>)(lpVtbl[36]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveSize, pToneCurve);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetToneCurve"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public HResult GetToneCurve(uint cbToneCurveBufferSize, WICRawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, WICRawToneCurve*, uint*, int>)(lpVtbl[37]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetRotation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public HResult SetRotation(double Rotation)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)(lpVtbl[38]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Rotation);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetRotation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult GetRotation(double* pRotation)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)(lpVtbl[39]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRotation);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetRenderMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public HResult SetRenderMode(WICRawRenderMode RenderMode)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, WICRawRenderMode, int>)(lpVtbl[40]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), RenderMode);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::GetRenderMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public HResult GetRenderMode(WICRawRenderMode* pRenderMode)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, WICRawRenderMode*, int>)(lpVtbl[41]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRenderMode);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICDevelopRaw::SetNotificationCallback"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public HResult SetNotificationCallback(IWICDevelopRawNotificationCallback* pCallback)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICDevelopRawNotificationCallback*, int>)(lpVtbl[42]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pCallback);
	}
}

