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

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPointCollection"]/*' />
/// <unmanaged>ID2D1SvgPointCollection</unmanaged>
[Guid("9dbe4c0d-3572-4dd9-9825-5530813bb712")]
[NativeTypeName("struct ID2D1SvgPointCollection : ID2D1SvgAttribute")]
[NativeInheritance("ID2D1SvgAttribute")]
public unsafe partial struct ID2D1SvgPointCollection
{
	public static ref readonly Guid IID_ID2D1SvgPointCollection
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x0D, 0x4C, 0xBE, 0x9D,
				0x72, 0x35,
				0xD9, 0x4D,
				0x98,
				0x25,
				0x55,
				0x30,
				0x81,
				0x3B,
				0xB7,
				0x12
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgPointCollection));

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
		((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1SvgAttribute.GetElement" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void GetElement(ID2D1SvgElement** element)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), element);
	}

	/// <inheritdoc cref="ID2D1SvgAttribute.Clone" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult Clone(ID2D1SvgAttribute** attribute)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), attribute);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPointCollection::RemovePointsAtEnd"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult RemovePointsAtEnd(uint pointsCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, uint, int>)(lpVtbl[6]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), pointsCount);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPointCollection::UpdatePoints"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult UpdatePoints(System.Drawing.PointF** points, uint pointsCount, uint startIndex)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, System.Drawing.PointF**, uint, uint, int>)(lpVtbl[7]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), points, pointsCount, startIndex);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPointCollection::GetPoints"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetPoints(System.Drawing.PointF** points, uint pointsCount, uint startIndex)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, System.Drawing.PointF**, uint, uint, int>)(lpVtbl[8]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), points, pointsCount, startIndex);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPointCollection::GetPointsCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public uint GetPointsCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, uint>)(lpVtbl[9]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this));
	}
}

