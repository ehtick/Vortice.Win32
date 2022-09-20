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

namespace Win32.Graphics.Direct3D12;

/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12Debug5"]/*' />
/// <unmanaged>ID3D12Debug5</unmanaged>
[Guid("548d6b12-09fa-40e0-9069-5dcd589a52c9")]
[NativeTypeName("struct ID3D12Debug5 : ID3D12Debug4")]
[NativeInheritance("ID3D12Debug4")]
public unsafe partial struct ID3D12Debug5
{
	public static ref readonly Guid IID_ID3D12Debug5
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x12, 0x6B, 0x8D, 0x54,
				0xFA, 0x09,
				0xE0, 0x40,
				0x90,
				0x69,
				0x5D,
				0xCD,
				0x58,
				0x9A,
				0x52,
				0xC9
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug5));

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

	/// <inheritdoc cref="ID3D12Debug.EnableDebugLayer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void EnableDebugLayer()
	{
		((delegate* unmanaged[Stdcall]<ID3D12Debug5*, void>)(lpVtbl[3]))((ID3D12Debug5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12Debug3.SetEnableGPUBasedValidation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetEnableGPUBasedValidation(Bool32 Enable)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Debug5*, Bool32, void>)(lpVtbl[4]))((ID3D12Debug5*)Unsafe.AsPointer(ref this), Enable);
	}

	/// <inheritdoc cref="ID3D12Debug3.SetEnableSynchronizedCommandQueueValidation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetEnableSynchronizedCommandQueueValidation(Bool32 Enable)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Debug5*, Bool32, void>)(lpVtbl[5]))((ID3D12Debug5*)Unsafe.AsPointer(ref this), Enable);
	}

	/// <inheritdoc cref="ID3D12Debug3.SetGPUBasedValidationFlags" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void SetGPUBasedValidationFlags(GpuBasedValidationFlags Flags)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Debug5*, GpuBasedValidationFlags, void>)(lpVtbl[6]))((ID3D12Debug5*)Unsafe.AsPointer(ref this), Flags);
	}

	/// <inheritdoc cref="ID3D12Debug4.DisableDebugLayer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void DisableDebugLayer()
	{
		((delegate* unmanaged[Stdcall]<ID3D12Debug5*, void>)(lpVtbl[7]))((ID3D12Debug5*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12Debug5::SetEnableAutoName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void SetEnableAutoName(Bool32 Enable)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Debug5*, Bool32, void>)(lpVtbl[8]))((ID3D12Debug5*)Unsafe.AsPointer(ref this), Enable);
	}
}

