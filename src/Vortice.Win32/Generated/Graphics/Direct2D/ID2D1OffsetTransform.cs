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

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1OffsetTransform"]/*' />
/// <unmanaged>ID2D1OffsetTransform</unmanaged>
[Guid("3fe6adea-7643-4f53-bd14-a0ce63f24042")]
[NativeTypeName("struct ID2D1OffsetTransform : ID2D1TransformNode")]
[NativeInheritance("ID2D1TransformNode")]
public unsafe partial struct ID2D1OffsetTransform
{
	public static ref readonly Guid IID_ID2D1OffsetTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xEA, 0xAD, 0xE6, 0x3F,
				0x43, 0x76,
				0x53, 0x4F,
				0xBD,
				0x14,
				0xA0,
				0xCE,
				0x63,
				0xF2,
				0x40,
				0x42
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1OffsetTransform));

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

	/// <inheritdoc cref="ID2D1TransformNode.GetInputCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetInputCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1OffsetTransform*, uint>)(lpVtbl[3]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1OffsetTransform::SetOffset"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetOffset(System.Drawing.Point offset)
	{
		((delegate* unmanaged[Stdcall]<ID2D1OffsetTransform*, System.Drawing.Point, void>)(lpVtbl[4]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this), offset);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1OffsetTransform::GetOffset"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public System.Drawing.Point GetOffset()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1OffsetTransform*, System.Drawing.Point>)(lpVtbl[5]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
	}
}

