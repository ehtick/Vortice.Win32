// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue"]/*' />
/// <unmanaged>ID3D11InfoQueue</unmanaged>
[Guid("6543dbb6-1b48-42f5-ab82-e97ec74326f6")]
[NativeTypeName("struct ID3D11InfoQueue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11InfoQueue : ID3D11InfoQueue.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11InfoQueue
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xB6, 0xDB, 0x43, 0x65,
				0x48, 0x1B,
				0xF5, 0x42,
				0xAB,
				0x82,
				0xE9,
				0x7E,
				0xC7,
				0x43,
				0x26,
				0xF6
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11InfoQueue));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, uint>)(lpVtbl[1]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, uint>)(lpVtbl[2]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::SetMessageCountLimit"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetMessageCountLimit(ulong MessageCountLimit)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, ulong, int>)(lpVtbl[3]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), MessageCountLimit);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::ClearStoredMessages"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void ClearStoredMessages()
	{
		((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, void>)(lpVtbl[4]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetMessage"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetMessage(ulong MessageIndex, Message* pMessage, nuint* pMessageByteLength)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)(lpVtbl[5]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), MessageIndex, pMessage, pMessageByteLength);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetNumMessagesAllowedByStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public ulong GetNumMessagesAllowedByStorageFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, ulong>)(lpVtbl[6]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetNumMessagesDeniedByStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public ulong GetNumMessagesDeniedByStorageFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, ulong>)(lpVtbl[7]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetNumStoredMessages"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public ulong GetNumStoredMessages()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, ulong>)(lpVtbl[8]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetNumStoredMessagesAllowedByRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, ulong>)(lpVtbl[9]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetNumMessagesDiscardedByMessageCountLimit"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ulong GetNumMessagesDiscardedByMessageCountLimit()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, ulong>)(lpVtbl[10]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetMessageCountLimit"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public ulong GetMessageCountLimit()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, ulong>)(lpVtbl[11]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::AddStorageFilterEntries"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult AddStorageFilterEntries(InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, InfoQueueFilter*, int>)(lpVtbl[12]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetStorageFilter(InfoQueueFilter* pFilter, nuint* pFilterByteLength)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)(lpVtbl[13]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::ClearStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public void ClearStorageFilter()
	{
		((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, void>)(lpVtbl[14]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::PushEmptyStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult PushEmptyStorageFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, int>)(lpVtbl[15]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::PushCopyOfStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult PushCopyOfStorageFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, int>)(lpVtbl[16]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::PushStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult PushStorageFilter(InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, InfoQueueFilter*, int>)(lpVtbl[17]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::PopStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void PopStorageFilter()
	{
		((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, void>)(lpVtbl[18]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetStorageFilterStackSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public uint GetStorageFilterStackSize()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, uint>)(lpVtbl[19]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::AddRetrievalFilterEntries"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult AddRetrievalFilterEntries(InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, InfoQueueFilter*, int>)(lpVtbl[20]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetRetrievalFilter(InfoQueueFilter* pFilter, nuint* pFilterByteLength)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)(lpVtbl[21]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::ClearRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public void ClearRetrievalFilter()
	{
		((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, void>)(lpVtbl[22]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::PushEmptyRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult PushEmptyRetrievalFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, int>)(lpVtbl[23]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::PushCopyOfRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult PushCopyOfRetrievalFilter()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, int>)(lpVtbl[24]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::PushRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult PushRetrievalFilter(InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, InfoQueueFilter*, int>)(lpVtbl[25]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::PopRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public void PopRetrievalFilter()
	{
		((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, void>)(lpVtbl[26]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetRetrievalFilterStackSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public uint GetRetrievalFilterStackSize()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, uint>)(lpVtbl[27]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::AddMessage"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult AddMessage(MessageCategory Category, MessageSeverity Severity, MessageId ID, byte* pDescription)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageId, byte*, int>)(lpVtbl[28]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Category, Severity, ID, pDescription);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::AddApplicationMessage"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult AddApplicationMessage(MessageSeverity Severity, byte* pDescription)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, MessageSeverity, byte*, int>)(lpVtbl[29]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::SetBreakOnCategory"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult SetBreakOnCategory(MessageCategory Category, Bool32 bEnable)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, MessageCategory, Bool32, int>)(lpVtbl[30]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Category, bEnable);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::SetBreakOnSeverity"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult SetBreakOnSeverity(MessageSeverity Severity, Bool32 bEnable)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, MessageSeverity, Bool32, int>)(lpVtbl[31]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Severity, bEnable);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::SetBreakOnID"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult SetBreakOnID(MessageId ID, Bool32 bEnable)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, MessageId, Bool32, int>)(lpVtbl[32]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), ID, bEnable);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetBreakOnCategory"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public Bool32 GetBreakOnCategory(MessageCategory Category)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, MessageCategory, Bool32>)(lpVtbl[33]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Category);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetBreakOnSeverity"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public Bool32 GetBreakOnSeverity(MessageSeverity Severity)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, MessageSeverity, Bool32>)(lpVtbl[34]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Severity);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetBreakOnID"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public Bool32 GetBreakOnID(MessageId ID)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, MessageId, Bool32>)(lpVtbl[35]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), ID);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::SetMuteDebugOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public void SetMuteDebugOutput(Bool32 bMute)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, Bool32, void>)(lpVtbl[36]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), bMute);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11InfoQueue::GetMuteDebugOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public Bool32 GetMuteDebugOutput()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11InfoQueue*, Bool32>)(lpVtbl[37]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult SetMessageCountLimit(ulong MessageCountLimit);

		[VtblIndex(4)]
		void ClearStoredMessages();

		[VtblIndex(5)]
		HResult GetMessage(ulong MessageIndex, Message* pMessage, nuint* pMessageByteLength);

		[VtblIndex(6)]
		ulong GetNumMessagesAllowedByStorageFilter();

		[VtblIndex(7)]
		ulong GetNumMessagesDeniedByStorageFilter();

		[VtblIndex(8)]
		ulong GetNumStoredMessages();

		[VtblIndex(9)]
		ulong GetNumStoredMessagesAllowedByRetrievalFilter();

		[VtblIndex(10)]
		ulong GetNumMessagesDiscardedByMessageCountLimit();

		[VtblIndex(11)]
		ulong GetMessageCountLimit();

		[VtblIndex(12)]
		HResult AddStorageFilterEntries(InfoQueueFilter* pFilter);

		[VtblIndex(13)]
		HResult GetStorageFilter(InfoQueueFilter* pFilter, nuint* pFilterByteLength);

		[VtblIndex(14)]
		void ClearStorageFilter();

		[VtblIndex(15)]
		HResult PushEmptyStorageFilter();

		[VtblIndex(16)]
		HResult PushCopyOfStorageFilter();

		[VtblIndex(17)]
		HResult PushStorageFilter(InfoQueueFilter* pFilter);

		[VtblIndex(18)]
		void PopStorageFilter();

		[VtblIndex(19)]
		uint GetStorageFilterStackSize();

		[VtblIndex(20)]
		HResult AddRetrievalFilterEntries(InfoQueueFilter* pFilter);

		[VtblIndex(21)]
		HResult GetRetrievalFilter(InfoQueueFilter* pFilter, nuint* pFilterByteLength);

		[VtblIndex(22)]
		void ClearRetrievalFilter();

		[VtblIndex(23)]
		HResult PushEmptyRetrievalFilter();

		[VtblIndex(24)]
		HResult PushCopyOfRetrievalFilter();

		[VtblIndex(25)]
		HResult PushRetrievalFilter(InfoQueueFilter* pFilter);

		[VtblIndex(26)]
		void PopRetrievalFilter();

		[VtblIndex(27)]
		uint GetRetrievalFilterStackSize();

		[VtblIndex(28)]
		HResult AddMessage(MessageCategory Category, MessageSeverity Severity, MessageId ID, byte* pDescription);

		[VtblIndex(29)]
		HResult AddApplicationMessage(MessageSeverity Severity, byte* pDescription);

		[VtblIndex(30)]
		HResult SetBreakOnCategory(MessageCategory Category, Bool32 bEnable);

		[VtblIndex(31)]
		HResult SetBreakOnSeverity(MessageSeverity Severity, Bool32 bEnable);

		[VtblIndex(32)]
		HResult SetBreakOnID(MessageId ID, Bool32 bEnable);

		[VtblIndex(33)]
		Bool32 GetBreakOnCategory(MessageCategory Category);

		[VtblIndex(34)]
		Bool32 GetBreakOnSeverity(MessageSeverity Severity);

		[VtblIndex(35)]
		Bool32 GetBreakOnID(MessageId ID);

		[VtblIndex(36)]
		void SetMuteDebugOutput(Bool32 bMute);

		[VtblIndex(37)]
		Bool32 GetMuteDebugOutput();
	}
}

