using System;

// Token: 0x020002F3 RID: 755
public enum EventCaching : byte
{
	// Token: 0x04001423 RID: 5155
	DoNotCache,
	// Token: 0x04001424 RID: 5156
	[Obsolete]
	MergeCache,
	// Token: 0x04001425 RID: 5157
	[Obsolete]
	ReplaceCache,
	// Token: 0x04001426 RID: 5158
	[Obsolete]
	RemoveCache,
	// Token: 0x04001427 RID: 5159
	AddToRoomCache,
	// Token: 0x04001428 RID: 5160
	AddToRoomCacheGlobal,
	// Token: 0x04001429 RID: 5161
	RemoveFromRoomCache,
	// Token: 0x0400142A RID: 5162
	RemoveFromRoomCacheForActorsLeft,
	// Token: 0x0400142B RID: 5163
	SliceIncreaseIndex = 10,
	// Token: 0x0400142C RID: 5164
	SliceSetIndex,
	// Token: 0x0400142D RID: 5165
	SlicePurgeIndex,
	// Token: 0x0400142E RID: 5166
	SlicePurgeUpToIndex
}
