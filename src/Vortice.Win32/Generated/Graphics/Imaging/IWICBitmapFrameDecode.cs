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

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapFrameDecode"]/*' />
/// <unmanaged>IWICBitmapFrameDecode</unmanaged>
[Guid("3b16811b-6a43-4ec9-a813-3d930c13b940")]
[NativeTypeName("struct IWICBitmapFrameDecode : IWICBitmapSource")]
[NativeInheritance("IWICBitmapSource")]
public unsafe partial struct IWICBitmapFrameDecode
{
	public static ref readonly Guid IID_IWICBitmapFrameDecode
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x1B, 0x81, 0x16, 0x3B,
				0x43, 0x6A,
				0xC9, 0x4E,
				0xA8,
				0x13,
				0x3D,
				0x93,
				0x0C,
				0x13,
				0xB9,
				0x40
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapFrameDecode));

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
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
	}

	/// <inheritdoc cref="IWICBitmapSource.GetPixelFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPixelFormat(Guid* pPixelFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, int>)(lpVtbl[4]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pPixelFormat);
	}

	/// <inheritdoc cref="IWICBitmapSource.GetResolution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetResolution(double* pDpiX, double* pDpiY)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, double*, double*, int>)(lpVtbl[5]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
	}

	/// <inheritdoc cref="IWICBitmapSource.CopyPalette" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CopyPalette(IWICPalette* pIPalette)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pIPalette);
	}

	/// <inheritdoc cref="IWICBitmapSource.CopyPixels" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CopyPixels(System.Drawing.Rectangle* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, System.Drawing.Rectangle*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapFrameDecode::GetMetadataQueryReader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICMetadataQueryReader**, int>)(lpVtbl[8]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapFrameDecode::GetColorContexts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)(lpVtbl[9]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapFrameDecode::GetThumbnail"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetThumbnail(IWICBitmapSource** ppIThumbnail)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICBitmapSource**, int>)(lpVtbl[10]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIThumbnail);
	}
}

