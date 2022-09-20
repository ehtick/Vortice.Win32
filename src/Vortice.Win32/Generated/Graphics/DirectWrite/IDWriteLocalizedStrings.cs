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

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteLocalizedStrings"]/*' />
/// <unmanaged>IDWriteLocalizedStrings</unmanaged>
[Guid("08256209-099a-4b34-b86d-c22b110e7771")]
[NativeTypeName("struct IDWriteLocalizedStrings : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteLocalizedStrings
{
	public static ref readonly Guid IID_IDWriteLocalizedStrings
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x09, 0x62, 0x25, 0x08,
				0x9A, 0x09,
				0x34, 0x4B,
				0xB8,
				0x6D,
				0xC2,
				0x2B,
				0x11,
				0x0E,
				0x77,
				0x71
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteLocalizedStrings));

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

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteLocalizedStrings::GetCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint>)(lpVtbl[3]))((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteLocalizedStrings::FindLocaleName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult FindLocaleName(ushort* localeName, uint* index, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, ushort*, uint*, Bool32*, int>)(lpVtbl[4]))((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), localeName, index, exists);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteLocalizedStrings::GetLocaleNameLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetLocaleNameLength(uint index, uint* length)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, uint*, int>)(lpVtbl[5]))((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), index, length);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteLocalizedStrings::GetLocaleName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetLocaleName(uint index, ushort* localeName, uint size)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, ushort*, uint, int>)(lpVtbl[6]))((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), index, localeName, size);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteLocalizedStrings::GetStringLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetStringLength(uint index, uint* length)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, uint*, int>)(lpVtbl[7]))((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), index, length);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteLocalizedStrings::GetString"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetString(uint index, ushort* stringBuffer, uint size)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, ushort*, uint, int>)(lpVtbl[8]))((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), index, stringBuffer, size);
	}
}

