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

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmap"]/*' />
/// <unmanaged>IWICBitmap</unmanaged>
[Guid("00000121-a8f2-4877-ba0a-fd2b6645fb94")]
[NativeTypeName("struct IWICBitmap : IWICBitmapSource")]
[NativeInheritance("IWICBitmapSource")]
public unsafe partial struct IWICBitmap
{
	public static ref readonly Guid IID_IWICBitmap
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x21, 0x01, 0x00, 0x00,
				0xF2, 0xA8,
				0x77, 0x48,
				0xBA,
				0x0A,
				0xFD,
				0x2B,
				0x66,
				0x45,
				0xFB,
				0x94
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmap));

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
		return ((delegate* unmanaged[Stdcall]<IWICBitmap*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmap*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
	}

	/// <inheritdoc cref="IWICBitmapSource.GetPixelFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPixelFormat(Guid* pPixelFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmap*, Guid*, int>)(lpVtbl[4]))((IWICBitmap*)Unsafe.AsPointer(ref this), pPixelFormat);
	}

	/// <inheritdoc cref="IWICBitmapSource.GetResolution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetResolution(double* pDpiX, double* pDpiY)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmap*, double*, double*, int>)(lpVtbl[5]))((IWICBitmap*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
	}

	/// <inheritdoc cref="IWICBitmapSource.CopyPalette" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CopyPalette(IWICPalette* pIPalette)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmap*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmap*)Unsafe.AsPointer(ref this), pIPalette);
	}

	/// <inheritdoc cref="IWICBitmapSource.CopyPixels" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CopyPixels(System.Drawing.Rectangle* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmap*, System.Drawing.Rectangle*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmap*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmap::Lock"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Lock(System.Drawing.Rectangle* prcLock, WICBitmapLockFlags flags, IWICBitmapLock** ppILock)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmap*, System.Drawing.Rectangle*, WICBitmapLockFlags, IWICBitmapLock**, int>)(lpVtbl[8]))((IWICBitmap*)Unsafe.AsPointer(ref this), prcLock, flags, ppILock);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmap::SetPalette"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetPalette(IWICPalette* pIPalette)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmap*, IWICPalette*, int>)(lpVtbl[9]))((IWICBitmap*)Unsafe.AsPointer(ref this), pIPalette);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmap::SetResolution"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetResolution(double dpiX, double dpiY)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmap*, double, double, int>)(lpVtbl[10]))((IWICBitmap*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}
}

