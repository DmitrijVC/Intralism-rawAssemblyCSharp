using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x02000194 RID: 404
	public abstract class VirtualInput
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060074CF RID: 29903 RVA: 0x0023CB3B File Offset: 0x0023AD3B
		// (set) Token: 0x060074D0 RID: 29904 RVA: 0x0023CB43 File Offset: 0x0023AD43
		public Vector3 virtualMousePosition { get; private set; }

		// Token: 0x060074D1 RID: 29905 RVA: 0x0023CB4C File Offset: 0x0023AD4C
		public bool AxisExists(string EBEHBBDKDFJ)
		{
			return this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ);
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x0023CB5A File Offset: 0x0023AD5A
		public bool ButtonExists(string EBEHBBDKDFJ)
		{
			return this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ);
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x0023CB68 File Offset: 0x0023AD68
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis NPBNCBFNBAF)
		{
			if (this.JOFMOEEOMCD.ContainsKey(NPBNCBFNBAF.name))
			{
				Debug.LogError("There is already a virtual axis named " + NPBNCBFNBAF.name + " registered.");
			}
			else
			{
				this.JOFMOEEOMCD.Add(NPBNCBFNBAF.name, NPBNCBFNBAF);
				if (!NPBNCBFNBAF.matchWithInputManager)
				{
					this.AHKAGDCKMLE.Add(NPBNCBFNBAF.name);
				}
			}
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x0023CBD8 File Offset: 0x0023ADD8
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton NACBMIFLLEK)
		{
			if (this.EPFOGMBOGLH.ContainsKey(NACBMIFLLEK.name))
			{
				Debug.LogError("There is already a virtual button named " + NACBMIFLLEK.name + " registered.");
			}
			else
			{
				this.EPFOGMBOGLH.Add(NACBMIFLLEK.name, NACBMIFLLEK);
				if (!NACBMIFLLEK.matchWithInputManager)
				{
					this.AHKAGDCKMLE.Add(NACBMIFLLEK.name);
				}
			}
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x0023CC48 File Offset: 0x0023AE48
		public void UnRegisterVirtualAxis(string EBEHBBDKDFJ)
		{
			if (this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.JOFMOEEOMCD.Remove(EBEHBBDKDFJ);
			}
		}

		// Token: 0x060074D6 RID: 29910 RVA: 0x0023CC68 File Offset: 0x0023AE68
		public void UnRegisterVirtualButton(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.EPFOGMBOGLH.Remove(EBEHBBDKDFJ);
			}
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x0023CC88 File Offset: 0x0023AE88
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string EBEHBBDKDFJ)
		{
			return (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ)) ? null : this.JOFMOEEOMCD[EBEHBBDKDFJ];
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x0023CCB0 File Offset: 0x0023AEB0
		public void SetVirtualMousePositionX(float HBJIMONFKNL)
		{
			this.virtualMousePosition = new Vector3(HBJIMONFKNL, this.virtualMousePosition.y, this.virtualMousePosition.z);
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x0023CCE8 File Offset: 0x0023AEE8
		public void SetVirtualMousePositionY(float HBJIMONFKNL)
		{
			this.virtualMousePosition = new Vector3(this.virtualMousePosition.x, HBJIMONFKNL, this.virtualMousePosition.z);
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x0023CD20 File Offset: 0x0023AF20
		public void SetVirtualMousePositionZ(float HBJIMONFKNL)
		{
			this.virtualMousePosition = new Vector3(this.virtualMousePosition.x, this.virtualMousePosition.y, HBJIMONFKNL);
		}

		// Token: 0x060074DB RID: 29915
		public abstract float GetAxis(string EBEHBBDKDFJ, bool IBFFEGJDFNA);

		// Token: 0x060074DC RID: 29916
		public abstract bool GetButton(string EBEHBBDKDFJ);

		// Token: 0x060074DD RID: 29917
		public abstract bool GetButtonDown(string EBEHBBDKDFJ);

		// Token: 0x060074DE RID: 29918
		public abstract bool GetButtonUp(string EBEHBBDKDFJ);

		// Token: 0x060074DF RID: 29919
		public abstract void SetButtonDown(string EBEHBBDKDFJ);

		// Token: 0x060074E0 RID: 29920
		public abstract void SetButtonUp(string EBEHBBDKDFJ);

		// Token: 0x060074E1 RID: 29921
		public abstract void SetAxisPositive(string EBEHBBDKDFJ);

		// Token: 0x060074E2 RID: 29922
		public abstract void SetAxisNegative(string EBEHBBDKDFJ);

		// Token: 0x060074E3 RID: 29923
		public abstract void SetAxisZero(string EBEHBBDKDFJ);

		// Token: 0x060074E4 RID: 29924
		public abstract void SetAxis(string EBEHBBDKDFJ, float DPNHODJHGJL);

		// Token: 0x060074E5 RID: 29925
		public abstract Vector3 MousePosition();

		// Token: 0x04000BDB RID: 3035
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> JOFMOEEOMCD = new Dictionary<string, CrossPlatformInputManager.VirtualAxis>();

		// Token: 0x04000BDC RID: 3036
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> EPFOGMBOGLH = new Dictionary<string, CrossPlatformInputManager.VirtualButton>();

		// Token: 0x04000BDD RID: 3037
		protected List<string> AHKAGDCKMLE = new List<string>();
	}
}
