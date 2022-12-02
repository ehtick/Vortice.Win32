// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext"]/*' />
/// <unmanaged>ID2D1EffectContext</unmanaged>
[Guid("3d9f916b-27dc-4ad7-b4f1-64945340f563")]
[NativeTypeName("struct ID2D1EffectContext : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1EffectContext : ID2D1EffectContext.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1EffectContext
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x6B, 0x91, 0x9F, 0x3D,
				0xDC, 0x27,
				0xD7, 0x4A,
				0xB4,
				0xF1,
				0x64,
				0x94,
				0x53,
				0x40,
				0xF5,
				0x63
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1EffectContext));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1EffectContext));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint>)(lpVtbl[1]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint>)(lpVtbl[2]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::GetDpi"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDpi(float* dpiX, float* dpiY)
	{
		((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, float*, float*, void>)(lpVtbl[3]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateEffect(Guid* effectId, ID2D1Effect** effect)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)(lpVtbl[4]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), effectId, effect);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::GetMaximumSupportedFeatureLevel"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetMaximumSupportedFeatureLevel(Graphics.Direct3D.FeatureLevel* featureLevels, uint featureLevelsCount, Graphics.Direct3D.FeatureLevel* maximumSupportedFeatureLevel)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Graphics.Direct3D.FeatureLevel*, uint, Graphics.Direct3D.FeatureLevel*, int>)(lpVtbl[5]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateTransformNodeFromEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateTransformNodeFromEffect(ID2D1Effect* effect, ID2D1TransformNode** transformNode)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)(lpVtbl[6]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), effect, transformNode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateBlendTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateBlendTransform(uint numInputs, BlendDescription* blendDescription, ID2D1BlendTransform** transform)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint, BlendDescription*, ID2D1BlendTransform**, int>)(lpVtbl[7]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), numInputs, blendDescription, transform);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateBorderTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateBorderTransform(ExtendMode extendModeX, ExtendMode extendModeY, ID2D1BorderTransform** transform)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ExtendMode, ExtendMode, ID2D1BorderTransform**, int>)(lpVtbl[8]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), extendModeX, extendModeY, transform);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateOffsetTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateOffsetTransform(System.Drawing.Point offset, ID2D1OffsetTransform** transform)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, System.Drawing.Point, ID2D1OffsetTransform**, int>)(lpVtbl[9]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), offset, transform);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateBoundsAdjustmentTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateBoundsAdjustmentTransform(RawRect* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, RawRect*, ID2D1BoundsAdjustmentTransform**, int>)(lpVtbl[10]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), outputRectangle, transform);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::LoadPixelShader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult LoadPixelShader(Guid* shaderId, byte* shaderBuffer, uint shaderBufferCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)(lpVtbl[11]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), shaderId, shaderBuffer, shaderBufferCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::LoadVertexShader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult LoadVertexShader(Guid* resourceId, byte* shaderBuffer, uint shaderBufferCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)(lpVtbl[12]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, shaderBuffer, shaderBufferCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::LoadComputeShader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult LoadComputeShader(Guid* resourceId, byte* shaderBuffer, uint shaderBufferCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)(lpVtbl[13]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, shaderBuffer, shaderBufferCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::IsShaderLoaded"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public Bool32 IsShaderLoaded(Guid* shaderId)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, Bool32>)(lpVtbl[14]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), shaderId);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateResourceTexture"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)(lpVtbl[15]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::FindResourceTexture"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult FindResourceTexture(Guid* resourceId, ID2D1ResourceTexture** resourceTexture)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)(lpVtbl[16]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, resourceTexture);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateVertexBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)(lpVtbl[17]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::FindVertexBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult FindVertexBuffer(Guid* resourceId, ID2D1VertexBuffer** buffer)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)(lpVtbl[18]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, buffer);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateColorContext"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateColorContext(ColorSpace space, byte* profile, uint profileSize, ID2D1ColorContext** colorContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)(lpVtbl[19]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), space, profile, profileSize, colorContext);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateColorContextFromFilename"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateColorContextFromFilename(ushort* filename, ID2D1ColorContext** colorContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ushort*, ID2D1ColorContext**, int>)(lpVtbl[20]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), filename, colorContext);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CreateColorContextFromWicColorContext"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateColorContextFromWicColorContext(Graphics.Imaging.IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Graphics.Imaging.IWICColorContext*, ID2D1ColorContext**, int>)(lpVtbl[21]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), wicColorContext, colorContext);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::CheckFeatureSupport"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CheckFeatureSupport(Feature feature, void* featureSupportData, uint featureSupportDataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Feature, void*, uint, int>)(lpVtbl[22]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), feature, featureSupportData, featureSupportDataSize);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1EffectContext::IsBufferPrecisionSupported"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public Bool32 IsBufferPrecisionSupported(BufferPrecision bufferPrecision)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, BufferPrecision, Bool32>)(lpVtbl[23]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), bufferPrecision);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		void GetDpi(float* dpiX, float* dpiY);

		[VtblIndex(4)]
		HResult CreateEffect(Guid* effectId, ID2D1Effect** effect);

		[VtblIndex(5)]
		HResult GetMaximumSupportedFeatureLevel(Graphics.Direct3D.FeatureLevel* featureLevels, uint featureLevelsCount, Graphics.Direct3D.FeatureLevel* maximumSupportedFeatureLevel);

		[VtblIndex(6)]
		HResult CreateTransformNodeFromEffect(ID2D1Effect* effect, ID2D1TransformNode** transformNode);

		[VtblIndex(7)]
		HResult CreateBlendTransform(uint numInputs, BlendDescription* blendDescription, ID2D1BlendTransform** transform);

		[VtblIndex(8)]
		HResult CreateBorderTransform(ExtendMode extendModeX, ExtendMode extendModeY, ID2D1BorderTransform** transform);

		[VtblIndex(9)]
		HResult CreateOffsetTransform(System.Drawing.Point offset, ID2D1OffsetTransform** transform);

		[VtblIndex(10)]
		HResult CreateBoundsAdjustmentTransform(RawRect* outputRectangle, ID2D1BoundsAdjustmentTransform** transform);

		[VtblIndex(11)]
		HResult LoadPixelShader(Guid* shaderId, byte* shaderBuffer, uint shaderBufferCount);

		[VtblIndex(12)]
		HResult LoadVertexShader(Guid* resourceId, byte* shaderBuffer, uint shaderBufferCount);

		[VtblIndex(13)]
		HResult LoadComputeShader(Guid* resourceId, byte* shaderBuffer, uint shaderBufferCount);

		[VtblIndex(14)]
		Bool32 IsShaderLoaded(Guid* shaderId);

		[VtblIndex(15)]
		HResult CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture);

		[VtblIndex(16)]
		HResult FindResourceTexture(Guid* resourceId, ID2D1ResourceTexture** resourceTexture);

		[VtblIndex(17)]
		HResult CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer);

		[VtblIndex(18)]
		HResult FindVertexBuffer(Guid* resourceId, ID2D1VertexBuffer** buffer);

		[VtblIndex(19)]
		HResult CreateColorContext(ColorSpace space, byte* profile, uint profileSize, ID2D1ColorContext** colorContext);

		[VtblIndex(20)]
		HResult CreateColorContextFromFilename(ushort* filename, ID2D1ColorContext** colorContext);

		[VtblIndex(21)]
		HResult CreateColorContextFromWicColorContext(Graphics.Imaging.IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext);

		[VtblIndex(22)]
		HResult CheckFeatureSupport(Feature feature, void* featureSupportData, uint featureSupportDataSize);

		[VtblIndex(23)]
		Bool32 IsBufferPrecisionSupported(BufferPrecision bufferPrecision);
	}
}

