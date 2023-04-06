// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Media.Audio.XAudio2;

/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2"]/*' />
/// <unmanaged>IXAudio2</unmanaged>
[Guid("2b02e3cf-2e0b-4ec3-be45-1b2a3fe7210d")]
[NativeTypeName("struct IXAudio2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXAudio2 : IXAudio2.Interface, INativeGuid
{
	public static ref readonly Guid IID_IXAudio2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xCF, 0xE3, 0x02, 0x2B,
				0x0B, 0x2E,
				0xC3, 0x4E,
				0xBE,
				0x45,
				0x1B,
				0x2A,
				0x3F,
				0xE7,
				0x21,
				0x0D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXAudio2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXAudio2));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAudio2*, Guid*, void**, int>)(lpVtbl[0]))((IXAudio2*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)(lpVtbl[0]))((IXAudio2*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAudio2*, uint>)(lpVtbl[1]))((IXAudio2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)(lpVtbl[1]))((IXAudio2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAudio2*, uint>)(lpVtbl[2]))((IXAudio2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)(lpVtbl[2]))((IXAudio2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2::RegisterForCallbacks"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult RegisterForCallbacks(IXAudio2EngineCallback* pCallback)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAudio2*, IXAudio2EngineCallback*, int>)(lpVtbl[3]))((IXAudio2*)Unsafe.AsPointer(ref this), pCallback);
#else
		return ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, int>)(lpVtbl[3]))((IXAudio2*)Unsafe.AsPointer(ref this), pCallback);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2::UnregisterForCallbacks"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void UnregisterForCallbacks(IXAudio2EngineCallback* pCallback)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IXAudio2*, IXAudio2EngineCallback*, void>)(lpVtbl[4]))((IXAudio2*)Unsafe.AsPointer(ref this), pCallback);
#else
		((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)(lpVtbl[4]))((IXAudio2*)Unsafe.AsPointer(ref this), pCallback);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2::CreateSourceVoice"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, Media.Audio.WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, Media.Audio.WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)(lpVtbl[5]))((IXAudio2*)Unsafe.AsPointer(ref this), ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
#else
		return ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, Media.Audio.WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)(lpVtbl[5]))((IXAudio2*)Unsafe.AsPointer(ref this), ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2::CreateSubmixVoice"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, EffectChain* pEffectChain)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)(lpVtbl[6]))((IXAudio2*)Unsafe.AsPointer(ref this), ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
#else
		return ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)(lpVtbl[6]))((IXAudio2*)Unsafe.AsPointer(ref this), ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2::CreateMasteringVoice"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ushort* szDeviceId, EffectChain* pEffectChain, Media.Audio.AudioStreamCategory StreamCategory)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, ushort*, EffectChain*, Media.Audio.AudioStreamCategory, int>)(lpVtbl[7]))((IXAudio2*)Unsafe.AsPointer(ref this), ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
#else
		return ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, ushort*, EffectChain*, Media.Audio.AudioStreamCategory, int>)(lpVtbl[7]))((IXAudio2*)Unsafe.AsPointer(ref this), ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2::StartEngine"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult StartEngine()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAudio2*, int>)(lpVtbl[8]))((IXAudio2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IXAudio2*, int>)(lpVtbl[8]))((IXAudio2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2::StopEngine"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void StopEngine()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IXAudio2*, void>)(lpVtbl[9]))((IXAudio2*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<IXAudio2*, void>)(lpVtbl[9]))((IXAudio2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2::CommitChanges"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CommitChanges(uint OperationSet)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAudio2*, uint, int>)(lpVtbl[10]))((IXAudio2*)Unsafe.AsPointer(ref this), OperationSet);
#else
		return ((delegate* unmanaged[Stdcall]<IXAudio2*, uint, int>)(lpVtbl[10]))((IXAudio2*)Unsafe.AsPointer(ref this), OperationSet);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2::GetPerformanceData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void GetPerformanceData(PerformanceData* pPerfData)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IXAudio2*, PerformanceData*, void>)(lpVtbl[11]))((IXAudio2*)Unsafe.AsPointer(ref this), pPerfData);
#else
		((delegate* unmanaged[Stdcall]<IXAudio2*, PerformanceData*, void>)(lpVtbl[11]))((IXAudio2*)Unsafe.AsPointer(ref this), pPerfData);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2::SetDebugConfiguration"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public void SetDebugConfiguration(DebugConfiguration* pDebugConfiguration, void* pReserved = null)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IXAudio2*, DebugConfiguration*, void*, void>)(lpVtbl[12]))((IXAudio2*)Unsafe.AsPointer(ref this), pDebugConfiguration, pReserved);
#else
		((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)(lpVtbl[12]))((IXAudio2*)Unsafe.AsPointer(ref this), pDebugConfiguration, pReserved);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult RegisterForCallbacks(IXAudio2EngineCallback* pCallback);

		[VtblIndex(4)]
		void UnregisterForCallbacks(IXAudio2EngineCallback* pCallback);

		[VtblIndex(5)]
		HResult CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, Media.Audio.WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain);

		[VtblIndex(6)]
		HResult CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, EffectChain* pEffectChain);

		[VtblIndex(7)]
		HResult CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ushort* szDeviceId, EffectChain* pEffectChain, Media.Audio.AudioStreamCategory StreamCategory);

		[VtblIndex(8)]
		HResult StartEngine();

		[VtblIndex(9)]
		void StopEngine();

		[VtblIndex(10)]
		HResult CommitChanges(uint OperationSet);

		[VtblIndex(11)]
		void GetPerformanceData(PerformanceData* pPerfData);

		[VtblIndex(12)]
		void SetDebugConfiguration(DebugConfiguration* pDebugConfiguration, void* pReserved = null);
	}
}

