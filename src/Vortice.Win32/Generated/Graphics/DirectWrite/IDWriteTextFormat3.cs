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

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat3"]/*' />
/// <unmanaged>IDWriteTextFormat3</unmanaged>
[Guid("6d3b5641-e550-430d-a85b-b7bf48a93427")]
[NativeTypeName("struct IDWriteTextFormat3 : IDWriteTextFormat2")]
[NativeInheritance("IDWriteTextFormat2")]
public unsafe partial struct IDWriteTextFormat3
{
	public static ref readonly Guid IID_IDWriteTextFormat3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x41, 0x56, 0x3B, 0x6D,
				0x50, 0xE5,
				0x0D, 0x43,
				0xA8,
				0x5B,
				0xB7,
				0xBF,
				0x48,
				0xA9,
				0x34,
				0x27
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextFormat3));

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

	/// <inheritdoc cref="IDWriteTextFormat.SetTextAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetTextAlignment(TextAlignment textAlignment)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, TextAlignment, int>)(lpVtbl[3]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), textAlignment);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetParagraphAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetParagraphAlignment(ParagraphAlignment paragraphAlignment)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, ParagraphAlignment, int>)(lpVtbl[4]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), paragraphAlignment);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetWordWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetWordWrapping(WordWrapping wordWrapping)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, WordWrapping, int>)(lpVtbl[5]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), wordWrapping);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetReadingDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetReadingDirection(ReadingDirection readingDirection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, ReadingDirection, int>)(lpVtbl[6]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), readingDirection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetFlowDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetFlowDirection(FlowDirection flowDirection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FlowDirection, int>)(lpVtbl[7]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), flowDirection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetIncrementalTabStop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetIncrementalTabStop(float incrementalTabStop)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, float, int>)(lpVtbl[8]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), incrementalTabStop);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetTrimming" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetTrimming(Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, Trimming*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetLineSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetLineSpacing(LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, LineSpacingMethod, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetTextAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public TextAlignment GetTextAlignment()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, TextAlignment>)(lpVtbl[11]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetParagraphAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public ParagraphAlignment GetParagraphAlignment()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, ParagraphAlignment>)(lpVtbl[12]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetWordWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public WordWrapping GetWordWrapping()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, WordWrapping>)(lpVtbl[13]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetReadingDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public ReadingDirection GetReadingDirection()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, ReadingDirection>)(lpVtbl[14]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFlowDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public FlowDirection GetFlowDirection()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FlowDirection>)(lpVtbl[15]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetIncrementalTabStop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public float GetIncrementalTabStop()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, float>)(lpVtbl[16]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetTrimming" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetTrimming(Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, Trimming*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLineSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, LineSpacingMethod*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFontCollection(IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontCollection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontFamilyNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public uint GetFontFamilyNameLength()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, uint>)(lpVtbl[20]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontFamilyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetFontFamilyName(ushort* fontFamilyName, uint nameSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontWeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public FontWeight GetFontWeight()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FontWeight>)(lpVtbl[22]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public FontStyle GetFontStyle()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FontStyle>)(lpVtbl[23]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontStretch" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public FontStretch GetFontStretch()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FontStretch>)(lpVtbl[24]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public float GetFontSize()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, float>)(lpVtbl[25]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLocaleNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public uint GetLocaleNameLength()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, uint>)(lpVtbl[26]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLocaleName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult GetLocaleName(ushort* localeName, uint nameSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), localeName, nameSize);
	}

	/// <inheritdoc cref="IDWriteTextFormat1.SetVerticalGlyphOrientation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult SetVerticalGlyphOrientation(VerticalGlyphOrientation glyphOrientation)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, VerticalGlyphOrientation, int>)(lpVtbl[28]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), glyphOrientation);
	}

	/// <inheritdoc cref="IDWriteTextFormat1.GetVerticalGlyphOrientation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public VerticalGlyphOrientation GetVerticalGlyphOrientation()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, VerticalGlyphOrientation>)(lpVtbl[29]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat1.SetLastLineWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult SetLastLineWrapping(Bool32 isLastLineWrappingEnabled)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, Bool32, int>)(lpVtbl[30]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
	}

	/// <inheritdoc cref="IDWriteTextFormat1.GetLastLineWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public Bool32 GetLastLineWrapping()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, Bool32>)(lpVtbl[31]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat1.SetOpticalAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult SetOpticalAlignment(OpticalAlignment opticalAlignment)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, OpticalAlignment, int>)(lpVtbl[32]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), opticalAlignment);
	}

	/// <inheritdoc cref="IDWriteTextFormat1.GetOpticalAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public OpticalAlignment GetOpticalAlignment()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, OpticalAlignment>)(lpVtbl[33]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat1.SetFontFallback" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult SetFontFallback(IDWriteFontFallback* fontFallback)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, IDWriteFontFallback*, int>)(lpVtbl[34]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFallback);
	}

	/// <inheritdoc cref="IDWriteTextFormat1.GetFontFallback" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult GetFontFallback(IDWriteFontFallback** fontFallback)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, IDWriteFontFallback**, int>)(lpVtbl[35]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFallback);
	}

	/// <inheritdoc cref="IDWriteTextFormat2.SetLineSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public HResult SetLineSpacing(LineSpacing* lineSpacingOptions)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, LineSpacing*, int>)(lpVtbl[36]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
	}

	/// <inheritdoc cref="IDWriteTextFormat2.GetLineSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public HResult GetLineSpacing(LineSpacing* lineSpacingOptions)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, LineSpacing*, int>)(lpVtbl[37]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat3::SetFontAxisValues"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public HResult SetFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FontAxisValue*, uint, int>)(lpVtbl[38]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat3::GetFontAxisValueCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public uint GetFontAxisValueCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, uint>)(lpVtbl[39]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat3::GetFontAxisValues"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public HResult GetFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FontAxisValue*, uint, int>)(lpVtbl[40]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat3::GetAutomaticFontAxes"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public AutomaticFontAxes GetAutomaticFontAxes()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, AutomaticFontAxes>)(lpVtbl[41]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat3::SetAutomaticFontAxes"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public HResult SetAutomaticFontAxes(AutomaticFontAxes automaticFontAxes)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, AutomaticFontAxes, int>)(lpVtbl[42]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), automaticFontAxes);
	}
}

