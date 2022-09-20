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

namespace Win32.Graphics.Direct2D;

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1ColorContext1"]/*' />
/// <unmanaged>ID2D1ColorContext1</unmanaged>
[Guid("1ab42875-c57f-4be9-bd85-9cd78d6f55ee")]
[NativeTypeName("struct ID2D1ColorContext1 : ID2D1ColorContext")]
[NativeInheritance("ID2D1ColorContext")]
public unsafe partial struct ID2D1ColorContext1
{
	public static ref readonly Guid IID_ID2D1ColorContext1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x75, 0x28, 0xB4, 0x1A,
				0x7F, 0xC5,
				0xE9, 0x4B,
				0xBD,
				0x85,
				0x9C,
				0xD7,
				0x8D,
				0x6F,
				0x55,
				0xEE
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ColorContext1));

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

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1ColorContext.GetColorSpace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public ColorSpace GetColorSpace()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ColorSpace>)(lpVtbl[4]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1ColorContext.GetProfileSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public uint GetProfileSize()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, uint>)(lpVtbl[5]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1ColorContext.GetProfile" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetProfile(byte* profile, uint profileSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, byte*, uint, int>)(lpVtbl[6]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), profile, profileSize);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1ColorContext1::GetColorContextType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public ColorContextType GetColorContextType()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ColorContextType>)(lpVtbl[7]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1ColorContext1::GetDXGIColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public Graphics.Dxgi.Common.ColorSpaceType GetDXGIColorSpace()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Graphics.Dxgi.Common.ColorSpaceType>)(lpVtbl[8]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1ColorContext1::GetSimpleColorProfile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSimpleColorProfile(SimpleColorProfile* simpleProfile)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, SimpleColorProfile*, int>)(lpVtbl[9]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), simpleProfile);
	}
}

