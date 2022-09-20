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

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataQueryWriter"]/*' />
/// <unmanaged>IWICMetadataQueryWriter</unmanaged>
[Guid("a721791a-0def-4d06-bd91-2118bf1db10b")]
[NativeTypeName("struct IWICMetadataQueryWriter : IWICMetadataQueryReader")]
[NativeInheritance("IWICMetadataQueryReader")]
public unsafe partial struct IWICMetadataQueryWriter
{
	public static ref readonly Guid IID_IWICMetadataQueryWriter
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x1A, 0x79, 0x21, 0xA7,
				0xEF, 0x0D,
				0x06, 0x4D,
				0xBD,
				0x91,
				0x21,
				0x18,
				0xBF,
				0x1D,
				0xB1,
				0x0B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataQueryWriter));

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

	/// <inheritdoc cref="IWICMetadataQueryReader.GetContainerFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetContainerFormat(Guid* pguidContainerFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
	}

	/// <inheritdoc cref="IWICMetadataQueryReader.GetLocation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetLocation(uint cchMaxLength, ushort* wzNamespace, uint* pcchActualLength)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, uint, ushort*, uint*, int>)(lpVtbl[4]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), cchMaxLength, wzNamespace, pcchActualLength);
	}

	/// <inheritdoc cref="IWICMetadataQueryReader.GetMetadataByName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetMetadataByName(ushort* wzName, Com.Variant** pvarValue)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, ushort*, Com.Variant**, int>)(lpVtbl[5]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName, pvarValue);
	}

	/// <inheritdoc cref="IWICMetadataQueryReader.GetEnumerator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetEnumerator(Com.IEnumString** ppIEnumString)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, Com.IEnumString**, int>)(lpVtbl[6]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), ppIEnumString);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataQueryWriter::SetMetadataByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetMetadataByName(ushort* wzName, Com.Variant* pvarValue)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, ushort*, Com.Variant*, int>)(lpVtbl[7]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName, pvarValue);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataQueryWriter::RemoveMetadataByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult RemoveMetadataByName(ushort* wzName)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, ushort*, int>)(lpVtbl[8]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName);
	}
}

