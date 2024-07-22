// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12InfoQueue1"]/*' />
/// <unmanaged>ID3D12InfoQueue1</unmanaged>
[Guid("2852dd88-b484-4c0c-b6b1-67168500e600")]
[NativeTypeName("struct ID3D12InfoQueue1 : ID3D12InfoQueue")]
[NativeInheritance("ID3D12InfoQueue")]
public unsafe partial struct ID3D12InfoQueue1 : ID3D12InfoQueue1.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12InfoQueue1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x88, 0xDD, 0x52, 0x28,
				0x84, 0xB4,
				0x0C, 0x4C,
				0xB6,
				0xB1,
				0x67,
				0x16,
				0x85,
				0x00,
				0xE6,
				0x00
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12InfoQueue1));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, uint>)(lpVtbl[1]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, uint>)(lpVtbl[2]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.SetMessageCountLimit" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetMessageCountLimit(ulong MessageCountLimit)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, ulong, int>)(lpVtbl[3]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), MessageCountLimit);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.ClearStoredMessages" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void ClearStoredMessages()
	{
		((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, void>)(lpVtbl[4]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetMessage" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetMessage(ulong MessageIndex, Message* pMessage, nuint* pMessageByteLength)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, ulong, Message*, nuint*, int>)(lpVtbl[5]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), MessageIndex, pMessage, pMessageByteLength);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetNumMessagesAllowedByStorageFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public ulong GetNumMessagesAllowedByStorageFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, ulong>)(lpVtbl[6]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetNumMessagesDeniedByStorageFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public ulong GetNumMessagesDeniedByStorageFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, ulong>)(lpVtbl[7]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetNumStoredMessages" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public ulong GetNumStoredMessages()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, ulong>)(lpVtbl[8]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetNumStoredMessagesAllowedByRetrievalFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, ulong>)(lpVtbl[9]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetNumMessagesDiscardedByMessageCountLimit" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ulong GetNumMessagesDiscardedByMessageCountLimit()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, ulong>)(lpVtbl[10]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetMessageCountLimit" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public ulong GetMessageCountLimit()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, ulong>)(lpVtbl[11]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.AddStorageFilterEntries" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult AddStorageFilterEntries(InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)(lpVtbl[12]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetStorageFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetStorageFilter(InfoQueueFilter* pFilter, nuint* pFilterByteLength)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)(lpVtbl[13]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.ClearStorageFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public void ClearStorageFilter()
	{
		((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, void>)(lpVtbl[14]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.PushEmptyStorageFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult PushEmptyStorageFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, int>)(lpVtbl[15]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.PushCopyOfStorageFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult PushCopyOfStorageFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, int>)(lpVtbl[16]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.PushStorageFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult PushStorageFilter(InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)(lpVtbl[17]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.PopStorageFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void PopStorageFilter()
	{
		((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, void>)(lpVtbl[18]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetStorageFilterStackSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public uint GetStorageFilterStackSize()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, uint>)(lpVtbl[19]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.AddRetrievalFilterEntries" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult AddRetrievalFilterEntries(InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)(lpVtbl[20]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetRetrievalFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetRetrievalFilter(InfoQueueFilter* pFilter, nuint* pFilterByteLength)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)(lpVtbl[21]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.ClearRetrievalFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public void ClearRetrievalFilter()
	{
		((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, void>)(lpVtbl[22]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.PushEmptyRetrievalFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult PushEmptyRetrievalFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, int>)(lpVtbl[23]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.PushCopyOfRetrievalFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult PushCopyOfRetrievalFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, int>)(lpVtbl[24]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.PushRetrievalFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult PushRetrievalFilter(InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)(lpVtbl[25]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.PopRetrievalFilter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public void PopRetrievalFilter()
	{
		((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, void>)(lpVtbl[26]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetRetrievalFilterStackSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public uint GetRetrievalFilterStackSize()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, uint>)(lpVtbl[27]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12InfoQueue.AddMessage" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult AddMessage(MessageCategory Category, MessageSeverity Severity, MessageId ID, byte* pDescription)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, MessageCategory, MessageSeverity, MessageId, byte*, int>)(lpVtbl[28]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), Category, Severity, ID, pDescription);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.AddApplicationMessage" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult AddApplicationMessage(MessageSeverity Severity, byte* pDescription)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, MessageSeverity, byte*, int>)(lpVtbl[29]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), Severity, pDescription);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.SetBreakOnCategory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult SetBreakOnCategory(MessageCategory Category, Bool32 bEnable)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, MessageCategory, Bool32, int>)(lpVtbl[30]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), Category, bEnable);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.SetBreakOnSeverity" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult SetBreakOnSeverity(MessageSeverity Severity, Bool32 bEnable)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, MessageSeverity, Bool32, int>)(lpVtbl[31]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), Severity, bEnable);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.SetBreakOnID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult SetBreakOnID(MessageId ID, Bool32 bEnable)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, MessageId, Bool32, int>)(lpVtbl[32]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), ID, bEnable);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetBreakOnCategory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public Bool32 GetBreakOnCategory(MessageCategory Category)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, MessageCategory, Bool32>)(lpVtbl[33]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), Category);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetBreakOnSeverity" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public Bool32 GetBreakOnSeverity(MessageSeverity Severity)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, MessageSeverity, Bool32>)(lpVtbl[34]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), Severity);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetBreakOnID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public Bool32 GetBreakOnID(MessageId ID)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, MessageId, Bool32>)(lpVtbl[35]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), ID);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.SetMuteDebugOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public void SetMuteDebugOutput(Bool32 bMute)
	{
		((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, Bool32, void>)(lpVtbl[36]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), bMute);
	}

	/// <inheritdoc cref="ID3D12InfoQueue.GetMuteDebugOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public Bool32 GetMuteDebugOutput()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, Bool32>)(lpVtbl[37]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12InfoQueue1::RegisterMessageCallback"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public HResult RegisterMessageCallback(delegate* unmanaged[Stdcall]<MessageCategory, MessageSeverity, MessageId, byte*, void*, void> CallbackFunc, MessageCallbackFlags CallbackFilterFlags, void* pContext, uint* pCallbackCookie)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, delegate* unmanaged[Stdcall]<MessageCategory, MessageSeverity, MessageId, byte*, void*, void>, MessageCallbackFlags, void*, uint*, int>)(lpVtbl[38]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), CallbackFunc, CallbackFilterFlags, pContext, pCallbackCookie);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12InfoQueue1::UnregisterMessageCallback"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult UnregisterMessageCallback(uint CallbackCookie)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12InfoQueue1*, uint, int>)(lpVtbl[39]))((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), CallbackCookie);
	}

	public interface Interface : ID3D12InfoQueue.Interface
	{
		[VtblIndex(38)]
		HResult RegisterMessageCallback(delegate* unmanaged[Stdcall]<MessageCategory, MessageSeverity, MessageId, byte*, void*, void> CallbackFunc, MessageCallbackFlags CallbackFilterFlags, void* pContext, uint* pCallbackCookie);

		[VtblIndex(39)]
		HResult UnregisterMessageCallback(uint CallbackCookie);
	}
}

