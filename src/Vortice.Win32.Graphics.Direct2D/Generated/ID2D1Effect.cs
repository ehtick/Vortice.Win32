// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Effect"]/*' />
/// <unmanaged>ID2D1Effect</unmanaged>
[Guid("28211a43-7d89-476f-8181-2d6159b220ad")]
[NativeTypeName("struct ID2D1Effect : ID2D1Properties")]
[NativeInheritance("ID2D1Properties")]
public unsafe partial struct ID2D1Effect : ID2D1Effect.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1Effect
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x43, 0x1A, 0x21, 0x28,
				0x89, 0x7D,
				0x6F, 0x47,
				0x81,
				0x81,
				0x2D,
				0x61,
				0x59,
				0xB2,
				0x20,
				0xAD
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Effect));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Effect));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Effect*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Effect*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint>)(lpVtbl[1]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)(lpVtbl[1]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint>)(lpVtbl[2]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)(lpVtbl[2]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.GetPropertyCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetPropertyCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint>)(lpVtbl[3]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)(lpVtbl[3]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.GetPropertyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPropertyName(uint index, ushort* name, uint nameCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint, ushort*, uint, int>)(lpVtbl[4]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, name, nameCount);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ushort*, uint, int>)(lpVtbl[4]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, name, nameCount);
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.GetPropertyNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public uint GetPropertyNameLength(uint index)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint, uint>)(lpVtbl[5]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, uint>)(lpVtbl[5]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.GetType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public PropertyType GetType(uint index)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint, PropertyType>)(lpVtbl[6]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType>)(lpVtbl[6]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.GetPropertyIndex" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public uint GetPropertyIndex(ushort* name)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, ushort*, uint>)(lpVtbl[7]))((ID2D1Effect*)Unsafe.AsPointer(ref this), name);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, ushort*, uint>)(lpVtbl[7]))((ID2D1Effect*)Unsafe.AsPointer(ref this), name);
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.SetValueByName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetValueByName(ushort* name, PropertyType type, byte* data, uint dataSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, ushort*, PropertyType, byte*, uint, int>)(lpVtbl[8]))((ID2D1Effect*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, ushort*, PropertyType, byte*, uint, int>)(lpVtbl[8]))((ID2D1Effect*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.SetValue" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetValue(uint index, PropertyType type, byte* data, uint dataSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)(lpVtbl[9]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)(lpVtbl[9]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.GetValueByName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetValueByName(ushort* name, PropertyType type, byte* data, uint dataSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, ushort*, PropertyType, byte*, uint, int>)(lpVtbl[10]))((ID2D1Effect*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, ushort*, PropertyType, byte*, uint, int>)(lpVtbl[10]))((ID2D1Effect*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.GetValue" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetValue(uint index, PropertyType type, byte* data, uint dataSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)(lpVtbl[11]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)(lpVtbl[11]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.GetValueSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public uint GetValueSize(uint index)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint, uint>)(lpVtbl[12]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, uint>)(lpVtbl[12]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
#endif
	}

	/// <inheritdoc cref="ID2D1Properties.GetSubProperties" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetSubProperties(uint index, ID2D1Properties** subProperties)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint, ID2D1Properties**, int>)(lpVtbl[13]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, subProperties);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Properties**, int>)(lpVtbl[13]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, subProperties);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Effect::SetInput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public void SetInput(uint index, ID2D1Image* input, Bool32 invalidate)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1Effect*, uint, ID2D1Image*, Bool32, void>)(lpVtbl[14]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, input, invalidate);
#else
		((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image*, Bool32, void>)(lpVtbl[14]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, input, invalidate);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Effect::SetInputCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult SetInputCount(uint inputCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint, int>)(lpVtbl[15]))((ID2D1Effect*)Unsafe.AsPointer(ref this), inputCount);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, int>)(lpVtbl[15]))((ID2D1Effect*)Unsafe.AsPointer(ref this), inputCount);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Effect::GetInput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public void GetInput(uint index, ID2D1Image** input)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1Effect*, uint, ID2D1Image**, void>)(lpVtbl[16]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, input);
#else
		((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image**, void>)(lpVtbl[16]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, input);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Effect::GetInputCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public uint GetInputCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Effect*, uint>)(lpVtbl[17]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)(lpVtbl[17]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Effect::GetOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void GetOutput(ID2D1Image** outputImage)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1Effect*, ID2D1Image**, void>)(lpVtbl[18]))((ID2D1Effect*)Unsafe.AsPointer(ref this), outputImage);
#else
		((delegate* unmanaged[Stdcall]<ID2D1Effect*, ID2D1Image**, void>)(lpVtbl[18]))((ID2D1Effect*)Unsafe.AsPointer(ref this), outputImage);
#endif
	}

	public interface Interface : ID2D1Properties.Interface
	{
		[VtblIndex(14)]
		void SetInput(uint index, ID2D1Image* input, Bool32 invalidate);

		[VtblIndex(15)]
		HResult SetInputCount(uint inputCount);

		[VtblIndex(16)]
		void GetInput(uint index, ID2D1Image** input);

		[VtblIndex(17)]
		uint GetInputCount();

		[VtblIndex(18)]
		void GetOutput(ID2D1Image** outputImage);
	}
}

