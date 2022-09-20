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

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteInMemoryFontFileLoader"]/*' />
/// <unmanaged>IDWriteInMemoryFontFileLoader</unmanaged>
[Guid("dc102f47-a12d-4b1c-822d-9e117e33043f")]
[NativeTypeName("struct IDWriteInMemoryFontFileLoader : IDWriteFontFileLoader")]
[NativeInheritance("IDWriteFontFileLoader")]
public unsafe partial struct IDWriteInMemoryFontFileLoader
{
	public static ref readonly Guid IID_IDWriteInMemoryFontFileLoader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x47, 0x2F, 0x10, 0xDC,
				0x2D, 0xA1,
				0x1C, 0x4B,
				0x82,
				0x2D,
				0x9E,
				0x11,
				0x7E,
				0x33,
				0x04,
				0x3F
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteInMemoryFontFileLoader));

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

	/// <inheritdoc cref="IDWriteFontFileLoader.CreateStreamFromKey" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateStreamFromKey(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[3]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteInMemoryFontFileLoader::CreateInMemoryFontFileReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateInMemoryFontFileReference(IDWriteFactory* factory, void* fontData, uint fontDataSize, IUnknown* ownerObject, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, IUnknown*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), factory, fontData, fontDataSize, ownerObject, fontFile);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteInMemoryFontFileLoader::GetFileCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public uint GetFileCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)(lpVtbl[5]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this));
	}
}

