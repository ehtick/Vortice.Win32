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

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextAnalysisSink1"]/*' />
/// <unmanaged>IDWriteTextAnalysisSink1</unmanaged>
[Guid("b0d941a0-85e7-4d8b-9fd3-5ced9934482a")]
[NativeTypeName("struct IDWriteTextAnalysisSink1 : IDWriteTextAnalysisSink")]
[NativeInheritance("IDWriteTextAnalysisSink")]
public unsafe partial struct IDWriteTextAnalysisSink1
{
	public static ref readonly Guid IID_IDWriteTextAnalysisSink1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA0, 0x41, 0xD9, 0xB0,
				0xE7, 0x85,
				0x8B, 0x4D,
				0x9F,
				0xD3,
				0x5C,
				0xED,
				0x99,
				0x34,
				0x48,
				0x2A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextAnalysisSink1));

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

	/// <inheritdoc cref="IDWriteTextAnalysisSink.SetScriptAnalysis" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetScriptAnalysis(uint textPosition, uint textLength, ScriptAnalysis* scriptAnalysis)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, ScriptAnalysis*, int>)(lpVtbl[3]))((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), textPosition, textLength, scriptAnalysis);
	}

	/// <inheritdoc cref="IDWriteTextAnalysisSink.SetLineBreakpoints" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetLineBreakpoints(uint textPosition, uint textLength, LineBreakpoint* lineBreakpoints)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, LineBreakpoint*, int>)(lpVtbl[4]))((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), textPosition, textLength, lineBreakpoints);
	}

	/// <inheritdoc cref="IDWriteTextAnalysisSink.SetBidiLevel" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetBidiLevel(uint textPosition, uint textLength, byte explicitLevel, byte resolvedLevel)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, byte, byte, int>)(lpVtbl[5]))((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), textPosition, textLength, explicitLevel, resolvedLevel);
	}

	/// <inheritdoc cref="IDWriteTextAnalysisSink.SetNumberSubstitution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetNumberSubstitution(uint textPosition, uint textLength, IDWriteNumberSubstitution* numberSubstitution)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, IDWriteNumberSubstitution*, int>)(lpVtbl[6]))((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), textPosition, textLength, numberSubstitution);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextAnalysisSink1::SetGlyphOrientation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetGlyphOrientation(uint textPosition, uint textLength, GlyphOrientationAngle glyphOrientationAngle, byte adjustedBidiLevel, Bool32 isSideways, Bool32 isRightToLeft)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, GlyphOrientationAngle, byte, Bool32, Bool32, int>)(lpVtbl[7]))((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), textPosition, textLength, glyphOrientationAngle, adjustedBidiLevel, isSideways, isRightToLeft);
	}
}

