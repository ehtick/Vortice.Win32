// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat"]/*' />
/// <unmanaged>IDWriteTextFormat</unmanaged>
[Guid("9c906818-31d7-4fd3-a151-7c5e225db55a")]
[NativeTypeName("struct IDWriteTextFormat : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteTextFormat : IDWriteTextFormat.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteTextFormat
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x18, 0x68, 0x90, 0x9C,
				0xD7, 0x31,
				0xD3, 0x4F,
				0xA1,
				0x51,
				0x7C,
				0x5E,
				0x22,
				0x5D,
				0xB5,
				0x5A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextFormat));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextFormat));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, uint>)(lpVtbl[1]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, uint>)(lpVtbl[1]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, uint>)(lpVtbl[2]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, uint>)(lpVtbl[2]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::SetTextAlignment"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetTextAlignment(TextAlignment textAlignment)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, TextAlignment, int>)(lpVtbl[3]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), textAlignment);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, TextAlignment, int>)(lpVtbl[3]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), textAlignment);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::SetParagraphAlignment"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetParagraphAlignment(ParagraphAlignment paragraphAlignment)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, ParagraphAlignment, int>)(lpVtbl[4]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), paragraphAlignment);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, ParagraphAlignment, int>)(lpVtbl[4]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), paragraphAlignment);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::SetWordWrapping"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetWordWrapping(WordWrapping wordWrapping)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, WordWrapping, int>)(lpVtbl[5]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), wordWrapping);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, WordWrapping, int>)(lpVtbl[5]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), wordWrapping);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::SetReadingDirection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetReadingDirection(ReadingDirection readingDirection)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, ReadingDirection, int>)(lpVtbl[6]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), readingDirection);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, ReadingDirection, int>)(lpVtbl[6]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), readingDirection);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::SetFlowDirection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetFlowDirection(FlowDirection flowDirection)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, FlowDirection, int>)(lpVtbl[7]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), flowDirection);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, FlowDirection, int>)(lpVtbl[7]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), flowDirection);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::SetIncrementalTabStop"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetIncrementalTabStop(float incrementalTabStop)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, float, int>)(lpVtbl[8]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), incrementalTabStop);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, float, int>)(lpVtbl[8]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), incrementalTabStop);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::SetTrimming"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetTrimming(Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, Trimming*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Trimming*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::SetLineSpacing"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetLineSpacing(LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, LineSpacingMethod, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetTextAlignment"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public TextAlignment GetTextAlignment()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, TextAlignment>)(lpVtbl[11]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, TextAlignment>)(lpVtbl[11]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetParagraphAlignment"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public ParagraphAlignment GetParagraphAlignment()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, ParagraphAlignment>)(lpVtbl[12]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, ParagraphAlignment>)(lpVtbl[12]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetWordWrapping"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public WordWrapping GetWordWrapping()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, WordWrapping>)(lpVtbl[13]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, WordWrapping>)(lpVtbl[13]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetReadingDirection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public ReadingDirection GetReadingDirection()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, ReadingDirection>)(lpVtbl[14]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, ReadingDirection>)(lpVtbl[14]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetFlowDirection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public FlowDirection GetFlowDirection()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, FlowDirection>)(lpVtbl[15]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, FlowDirection>)(lpVtbl[15]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetIncrementalTabStop"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public float GetIncrementalTabStop()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, float>)(lpVtbl[16]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, float>)(lpVtbl[16]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetTrimming"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetTrimming(Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, Trimming*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Trimming*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetLineSpacing"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, LineSpacingMethod*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetFontCollection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFontCollection(IDWriteFontCollection** fontCollection)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), fontCollection);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), fontCollection);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetFontFamilyNameLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public uint GetFontFamilyNameLength()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, uint>)(lpVtbl[20]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, uint>)(lpVtbl[20]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetFontFamilyName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetFontFamilyName(ushort* fontFamilyName, uint nameSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetFontWeight"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public FontWeight GetFontWeight()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, FontWeight>)(lpVtbl[22]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, FontWeight>)(lpVtbl[22]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetFontStyle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public FontStyle GetFontStyle()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, FontStyle>)(lpVtbl[23]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, FontStyle>)(lpVtbl[23]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetFontStretch"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public FontStretch GetFontStretch()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, FontStretch>)(lpVtbl[24]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, FontStretch>)(lpVtbl[24]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetFontSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public float GetFontSize()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, float>)(lpVtbl[25]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, float>)(lpVtbl[25]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetLocaleNameLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public uint GetLocaleNameLength()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, uint>)(lpVtbl[26]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, uint>)(lpVtbl[26]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextFormat::GetLocaleName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult GetLocaleName(ushort* localeName, uint nameSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteTextFormat*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), localeName, nameSize);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), localeName, nameSize);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult SetTextAlignment(TextAlignment textAlignment);

		[VtblIndex(4)]
		HResult SetParagraphAlignment(ParagraphAlignment paragraphAlignment);

		[VtblIndex(5)]
		HResult SetWordWrapping(WordWrapping wordWrapping);

		[VtblIndex(6)]
		HResult SetReadingDirection(ReadingDirection readingDirection);

		[VtblIndex(7)]
		HResult SetFlowDirection(FlowDirection flowDirection);

		[VtblIndex(8)]
		HResult SetIncrementalTabStop(float incrementalTabStop);

		[VtblIndex(9)]
		HResult SetTrimming(Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign);

		[VtblIndex(10)]
		HResult SetLineSpacing(LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline);

		[VtblIndex(11)]
		TextAlignment GetTextAlignment();

		[VtblIndex(12)]
		ParagraphAlignment GetParagraphAlignment();

		[VtblIndex(13)]
		WordWrapping GetWordWrapping();

		[VtblIndex(14)]
		ReadingDirection GetReadingDirection();

		[VtblIndex(15)]
		FlowDirection GetFlowDirection();

		[VtblIndex(16)]
		float GetIncrementalTabStop();

		[VtblIndex(17)]
		HResult GetTrimming(Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign);

		[VtblIndex(18)]
		HResult GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline);

		[VtblIndex(19)]
		HResult GetFontCollection(IDWriteFontCollection** fontCollection);

		[VtblIndex(20)]
		uint GetFontFamilyNameLength();

		[VtblIndex(21)]
		HResult GetFontFamilyName(ushort* fontFamilyName, uint nameSize);

		[VtblIndex(22)]
		FontWeight GetFontWeight();

		[VtblIndex(23)]
		FontStyle GetFontStyle();

		[VtblIndex(24)]
		FontStretch GetFontStretch();

		[VtblIndex(25)]
		float GetFontSize();

		[VtblIndex(26)]
		uint GetLocaleNameLength();

		[VtblIndex(27)]
		HResult GetLocaleName(ushort* localeName, uint nameSize);
	}
}

