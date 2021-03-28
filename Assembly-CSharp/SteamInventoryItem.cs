using System;

// Token: 0x02000429 RID: 1065
public class SteamInventoryItem
{
	// Token: 0x0600F415 RID: 62485 RVA: 0x00549F9A File Offset: 0x0054819A
	public SteamInventoryItem(ulong MOANAJGGPLK, InventoryItemData DBIMJHMKHNK, bool NIGBAPGIKDF = false)
	{
		this.steamid = MOANAJGGPLK;
		this.item = DBIMJHMKHNK;
		this.isLocal = NIGBAPGIKDF;
	}

	// Token: 0x0600F416 RID: 62486 RVA: 0x00549FB7 File Offset: 0x005481B7
	public SteamInventoryItem(SteamInventoryItem POONBAIJMMC)
	{
		this.steamid = POONBAIJMMC.steamid;
		this.item = POONBAIJMMC.item;
		this.isLocal = POONBAIJMMC.isLocal;
	}

	// Token: 0x04001B14 RID: 6932
	public ulong steamid;

	// Token: 0x04001B15 RID: 6933
	public InventoryItemData item;

	// Token: 0x04001B16 RID: 6934
	public bool isLocal;
}
