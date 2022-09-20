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

namespace Win32.Graphics.DirectWrite;

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRenderingParams"]/*' />
/// <unmanaged>IDWriteRenderingParams</unmanaged>
[Guid("2f0da53a-2add-47cd-82ee-d9ec34688e75")]
[NativeTypeName("struct IDWriteRenderingParams : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteRenderingParams
{
	public static ref readonly Guid IID_IDWriteRenderingParams
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x3A, 0xA5, 0x0D, 0x2F,
				0xDD, 0x2A,
				0xCD, 0x47,
				0x82,
				0xEE,
				0xD9,
				0xEC,
				0x34,
				0x68,
				0x8E,
				0x75
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRenderingParams));

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

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRenderingParams::GetGamma"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public float GetGamma()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, float>)(lpVtbl[3]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRenderingParams::GetEnhancedContrast"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public float GetEnhancedContrast()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, float>)(lpVtbl[4]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRenderingParams::GetClearTypeLevel"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public float GetClearTypeLevel()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, float>)(lpVtbl[5]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRenderingParams::GetPixelGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public PixelGeometry GetPixelGeometry()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, PixelGeometry>)(lpVtbl[6]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteRenderingParams::GetRenderingMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public RenderingMode GetRenderingMode()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, RenderingMode>)(lpVtbl[7]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
	}
}

