// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat1"]/*' />
/// <unmanaged>IDWriteTextFormat1</unmanaged>
[Guid("5f174b49-0d8b-4cfb-8bca-f1cce9d06c67")]
[NativeTypeName("struct IDWriteTextFormat1 : IDWriteTextFormat")]
[NativeInheritance("IDWriteTextFormat")]
public unsafe partial struct IDWriteTextFormat1 : IDWriteTextFormat1.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteTextFormat1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x49, 0x4B, 0x17, 0x5F,
				0x8B, 0x0D,
				0xFB, 0x4C,
				0x8B,
				0xCA,
				0xF1,
				0xCC,
				0xE9,
				0xD0,
				0x6C,
				0x67
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextFormat1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextFormat1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, uint>)(lpVtbl[1]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, uint>)(lpVtbl[2]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetTextAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetTextAlignment(TextAlignment textAlignment)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, TextAlignment, int>)(lpVtbl[3]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), textAlignment);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetParagraphAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetParagraphAlignment(ParagraphAlignment paragraphAlignment)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, ParagraphAlignment, int>)(lpVtbl[4]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), paragraphAlignment);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetWordWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetWordWrapping(WordWrapping wordWrapping)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, WordWrapping, int>)(lpVtbl[5]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), wordWrapping);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetReadingDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetReadingDirection(ReadingDirection readingDirection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, ReadingDirection, int>)(lpVtbl[6]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), readingDirection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetFlowDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetFlowDirection(FlowDirection flowDirection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, FlowDirection, int>)(lpVtbl[7]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), flowDirection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetIncrementalTabStop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetIncrementalTabStop(float incrementalTabStop)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, float, int>)(lpVtbl[8]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), incrementalTabStop);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetTrimming" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetTrimming(Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, Trimming*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetLineSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetLineSpacing(LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, LineSpacingMethod, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetTextAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public TextAlignment GetTextAlignment()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, TextAlignment>)(lpVtbl[11]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetParagraphAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public ParagraphAlignment GetParagraphAlignment()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, ParagraphAlignment>)(lpVtbl[12]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetWordWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public WordWrapping GetWordWrapping()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, WordWrapping>)(lpVtbl[13]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetReadingDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public ReadingDirection GetReadingDirection()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, ReadingDirection>)(lpVtbl[14]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFlowDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public FlowDirection GetFlowDirection()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, FlowDirection>)(lpVtbl[15]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetIncrementalTabStop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public float GetIncrementalTabStop()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, float>)(lpVtbl[16]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetTrimming" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetTrimming(Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, Trimming*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLineSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, LineSpacingMethod*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFontCollection(IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontCollection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontFamilyNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public uint GetFontFamilyNameLength()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, uint>)(lpVtbl[20]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontFamilyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetFontFamilyName(ushort* fontFamilyName, uint nameSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontWeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public FontWeight GetFontWeight()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, FontWeight>)(lpVtbl[22]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public FontStyle GetFontStyle()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, FontStyle>)(lpVtbl[23]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontStretch" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public FontStretch GetFontStretch()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, FontStretch>)(lpVtbl[24]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public float GetFontSize()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, float>)(lpVtbl[25]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLocaleNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public uint GetLocaleNameLength()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, uint>)(lpVtbl[26]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLocaleName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult GetLocaleName(ushort* localeName, uint nameSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), localeName, nameSize);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat1::SetVerticalGlyphOrientation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult SetVerticalGlyphOrientation(VerticalGlyphOrientation glyphOrientation)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, VerticalGlyphOrientation, int>)(lpVtbl[28]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), glyphOrientation);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat1::GetVerticalGlyphOrientation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public VerticalGlyphOrientation GetVerticalGlyphOrientation()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, VerticalGlyphOrientation>)(lpVtbl[29]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat1::SetLastLineWrapping"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult SetLastLineWrapping(Bool32 isLastLineWrappingEnabled)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, Bool32, int>)(lpVtbl[30]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat1::GetLastLineWrapping"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public Bool32 GetLastLineWrapping()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, Bool32>)(lpVtbl[31]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat1::SetOpticalAlignment"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult SetOpticalAlignment(OpticalAlignment opticalAlignment)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, OpticalAlignment, int>)(lpVtbl[32]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), opticalAlignment);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat1::GetOpticalAlignment"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public OpticalAlignment GetOpticalAlignment()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, OpticalAlignment>)(lpVtbl[33]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat1::SetFontFallback"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult SetFontFallback(IDWriteFontFallback* fontFallback)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, IDWriteFontFallback*, int>)(lpVtbl[34]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFallback);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat1::GetFontFallback"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult GetFontFallback(IDWriteFontFallback** fontFallback)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, IDWriteFontFallback**, int>)(lpVtbl[35]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFallback);
	}

	public interface Interface : IDWriteTextFormat.Interface
	{
		[VtblIndex(28)]
		HResult SetVerticalGlyphOrientation(VerticalGlyphOrientation glyphOrientation);

		[VtblIndex(29)]
		VerticalGlyphOrientation GetVerticalGlyphOrientation();

		[VtblIndex(30)]
		HResult SetLastLineWrapping(Bool32 isLastLineWrappingEnabled);

		[VtblIndex(31)]
		Bool32 GetLastLineWrapping();

		[VtblIndex(32)]
		HResult SetOpticalAlignment(OpticalAlignment opticalAlignment);

		[VtblIndex(33)]
		OpticalAlignment GetOpticalAlignment();

		[VtblIndex(34)]
		HResult SetFontFallback(IDWriteFontFallback* fontFallback);

		[VtblIndex(35)]
		HResult GetFontFallback(IDWriteFontFallback** fontFallback);
	}
}

