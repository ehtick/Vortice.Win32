// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BorderTransform"]/*' />
/// <unmanaged>ID2D1BorderTransform</unmanaged>
[Guid("4998735c-3a19-473c-9781-656847e3a347")]
[NativeTypeName("struct ID2D1BorderTransform : ID2D1ConcreteTransform")]
[NativeInheritance("ID2D1ConcreteTransform")]
public unsafe partial struct ID2D1BorderTransform : ID2D1BorderTransform.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1BorderTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x5C, 0x73, 0x98, 0x49,
				0x19, 0x3A,
				0x3C, 0x47,
				0x97,
				0x81,
				0x65,
				0x68,
				0x47,
				0xE3,
				0xA3,
				0x47
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BorderTransform));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BorderTransform));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, uint>)(lpVtbl[1]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, uint>)(lpVtbl[2]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1TransformNode.GetInputCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetInputCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, uint>)(lpVtbl[3]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1ConcreteTransform.SetOutputBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOutputBuffer(BufferPrecision bufferPrecision, ChannelDepth channelDepth)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, BufferPrecision, ChannelDepth, int>)(lpVtbl[4]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
	}

	/// <inheritdoc cref="ID2D1ConcreteTransform.SetCached" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetCached(Bool32 isCached)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, Bool32, void>)(lpVtbl[5]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), isCached);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BorderTransform::SetExtendModeX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void SetExtendModeX(ExtendMode extendMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, ExtendMode, void>)(lpVtbl[6]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), extendMode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BorderTransform::SetExtendModeY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void SetExtendModeY(ExtendMode extendMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, ExtendMode, void>)(lpVtbl[7]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), extendMode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BorderTransform::GetExtendModeX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public ExtendMode GetExtendModeX()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, ExtendMode>)(lpVtbl[8]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BorderTransform::GetExtendModeY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ExtendMode GetExtendModeY()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, ExtendMode>)(lpVtbl[9]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
	}

	public interface Interface : ID2D1ConcreteTransform.Interface
	{
		[VtblIndex(6)]
		void SetExtendModeX(ExtendMode extendMode);

		[VtblIndex(7)]
		void SetExtendModeY(ExtendMode extendMode);

		[VtblIndex(8)]
		ExtendMode GetExtendModeX();

		[VtblIndex(9)]
		ExtendMode GetExtendModeY();
	}
}

