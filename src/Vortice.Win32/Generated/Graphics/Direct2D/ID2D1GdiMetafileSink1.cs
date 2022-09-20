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

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GdiMetafileSink1"]/*' />
/// <unmanaged>ID2D1GdiMetafileSink1</unmanaged>
[Guid("fd0ecb6b-91e6-411e-8655-395e760f91b4")]
[NativeTypeName("struct ID2D1GdiMetafileSink1 : ID2D1GdiMetafileSink")]
[NativeInheritance("ID2D1GdiMetafileSink")]
public unsafe partial struct ID2D1GdiMetafileSink1
{
	public static ref readonly Guid IID_ID2D1GdiMetafileSink1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x6B, 0xCB, 0x0E, 0xFD,
				0xE6, 0x91,
				0x1E, 0x41,
				0x86,
				0x55,
				0x39,
				0x5E,
				0x76,
				0x0F,
				0x91,
				0xB4
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GdiMetafileSink1));

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

	/// <inheritdoc cref="ID2D1GdiMetafileSink.ProcessRecord" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult ProcessRecord(uint recordType, void* recordData, uint recordDataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, uint, void*, uint, int>)(lpVtbl[3]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), recordType, recordData, recordDataSize);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GdiMetafileSink1::ProcessRecord"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult ProcessRecord(uint recordType, void* recordData, uint recordDataSize, uint flags)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, uint, void*, uint, uint, int>)(lpVtbl[4]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), recordType, recordData, recordDataSize, flags);
	}
}

