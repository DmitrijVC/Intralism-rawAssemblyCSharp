using System;
using UnityEngine;

namespace HardShellStudios.InputManager
{
	// Token: 0x0200015F RID: 351
	public class hardKey : IComparable<hardKey>
	{
		// Token: 0x0600683D RID: 26685 RVA: 0x001F4D59 File Offset: 0x001F2F59
		public hardKey(string DMLMNFJNLDN, KeyCode IFMPKEDMLAA, KeyCode BOGBABBPHGD, int GIDLONLOKCD, int AFLLCGALPDB, bool OAMINJOPKPL)
		{
			this.keyName = DMLMNFJNLDN;
			this.keyInput = IFMPKEDMLAA;
			this.keyInput2 = BOGBABBPHGD;
			this.keyWheelState = GIDLONLOKCD;
			this.keyWheelState2 = AFLLCGALPDB;
			this.keyValue = 0f;
			this.saveKey = OAMINJOPKPL;
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x001F4D99 File Offset: 0x001F2F99
		public int GIEKOIGAFMK(hardKey AGGOHIAAMHN)
		{
			return 1;
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public int OMGAPIBMDCB(hardKey AGGOHIAAMHN)
		{
			return 0;
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x001F4D99 File Offset: 0x001F2F99
		public int LLCJKKKGAMB(hardKey AGGOHIAAMHN)
		{
			return 1;
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public int BKKIHKAINEH(hardKey AGGOHIAAMHN)
		{
			return 0;
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public int IAENOMFBIHM(hardKey AGGOHIAAMHN)
		{
			return 0;
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public int MCAANHCGGMB(hardKey AGGOHIAAMHN)
		{
			return 0;
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public int MBOALHPJAEC(hardKey AGGOHIAAMHN)
		{
			return 0;
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x001F4D99 File Offset: 0x001F2F99
		public int CompareTo(hardKey AGGOHIAAMHN)
		{
			return 1;
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public int MMGDBNIPFDG(hardKey AGGOHIAAMHN)
		{
			return 0;
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public int NEBFFIGJFJD(hardKey AGGOHIAAMHN)
		{
			return 0;
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x001F4D99 File Offset: 0x001F2F99
		public int MNMCKOLLDDK(hardKey AGGOHIAAMHN)
		{
			return 1;
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x001F4D99 File Offset: 0x001F2F99
		public int MBLCDGLLAAI(hardKey AGGOHIAAMHN)
		{
			return 1;
		}

		// Token: 0x04000AAF RID: 2735
		public string keyName;

		// Token: 0x04000AB0 RID: 2736
		public KeyCode keyInput;

		// Token: 0x04000AB1 RID: 2737
		public KeyCode keyInput2;

		// Token: 0x04000AB2 RID: 2738
		public int keyWheelState;

		// Token: 0x04000AB3 RID: 2739
		public int keyWheelState2;

		// Token: 0x04000AB4 RID: 2740
		public float keyValue;

		// Token: 0x04000AB5 RID: 2741
		public bool saveKey;

		// Token: 0x02000160 RID: 352
		public enum controllerMap
		{
			// Token: 0x04000AB7 RID: 2743
			None,
			// Token: 0x04000AB8 RID: 2744
			Square,
			// Token: 0x04000AB9 RID: 2745
			Cross,
			// Token: 0x04000ABA RID: 2746
			Circle,
			// Token: 0x04000ABB RID: 2747
			Triangle,
			// Token: 0x04000ABC RID: 2748
			L1,
			// Token: 0x04000ABD RID: 2749
			R1,
			// Token: 0x04000ABE RID: 2750
			L2,
			// Token: 0x04000ABF RID: 2751
			R2,
			// Token: 0x04000AC0 RID: 2752
			Share,
			// Token: 0x04000AC1 RID: 2753
			Options,
			// Token: 0x04000AC2 RID: 2754
			LeftStick,
			// Token: 0x04000AC3 RID: 2755
			RightStick,
			// Token: 0x04000AC4 RID: 2756
			PSHome,
			// Token: 0x04000AC5 RID: 2757
			Trackpad,
			// Token: 0x04000AC6 RID: 2758
			DPadUp,
			// Token: 0x04000AC7 RID: 2759
			DPadDown,
			// Token: 0x04000AC8 RID: 2760
			DPadLeft,
			// Token: 0x04000AC9 RID: 2761
			DPadRight
		}
	}
}
