using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x020002AC RID: 684
	[AddComponentMenu("UI/Extensions/Extensions Toggle Group")]
	[DisallowMultipleComponent]
	public class ExtensionsToggleGroup : UIBehaviour
	{
		// Token: 0x0600A481 RID: 42113 RVA: 0x003DAC84 File Offset: 0x003D8E84
		private void MOGGGJGGPIC(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "menu.playedsolo";
				object[] array = new object[3];
				array[1] = LKJEKCHLMHN;
				array[1] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x003DACC1 File Offset: 0x003D8EC1
		private void NEAEODLKHPJ(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "_InvRenderTargetSize";
				object[] array = new object[3];
				array[1] = LKJEKCHLMHN;
				array[1] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x003DACFE File Offset: 0x003D8EFE
		private static bool FGPKHKLNLBG(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.MNLDFHKEIOE();
		}

		// Token: 0x0600A484 RID: 42116 RVA: 0x003DAD06 File Offset: 0x003D8F06
		public void KPNNJIMDGBA(bool DPNHODJHGJL)
		{
			Debug.Log(" Owner called." + DPNHODJHGJL + "achievements.21.progress");
		}

		// Token: 0x0600A485 RID: 42117 RVA: 0x003DAD22 File Offset: 0x003D8F22
		public ExtensionsToggle GLOLHBKIGPP()
		{
			return this.<PDAAAECABIP>k__BackingField;
		}

		// Token: 0x0600A486 RID: 42118 RVA: 0x003DAD2A File Offset: 0x003D8F2A
		private static bool LCLKCEOPBHP(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.isOn;
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x003DAD32 File Offset: 0x003D8F32
		public void ADGPPOPDFAE(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.EKIFOBBPKHP));
			}
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x003DAD69 File Offset: 0x003D8F69
		public void JBDNFINCNIF(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.BCOJEPHOKHO));
			}
		}

		// Token: 0x0600A489 RID: 42121 RVA: 0x003DAD9F File Offset: 0x003D8F9F
		private void LNMIFMDLFBC(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "_Curve";
				object[] array = new object[4];
				array[0] = LKJEKCHLMHN;
				array[0] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A48A RID: 42122 RVA: 0x003DADDC File Offset: 0x003D8FDC
		public IEnumerable<ExtensionsToggle> NKPNNAINPML()
		{
			IEnumerable<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.CLCBJCKCBDD == null)
			{
				ExtensionsToggleGroup.CLCBJCKCBDD = new Func<ExtensionsToggle, bool>(ExtensionsToggleGroup.GMBILDNEDFD);
			}
			return hlagmpfpbaa.Where(ExtensionsToggleGroup.CLCBJCKCBDD);
		}

		// Token: 0x0600A48B RID: 42123 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void MFNBNFMPGKJ(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A48C RID: 42124 RVA: 0x003DAE0F File Offset: 0x003D900F
		protected ExtensionsToggleGroup()
		{
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x003DAE38 File Offset: 0x003D9038
		public void FBOIDKNMMFI(ExtensionsToggle LKJEKCHLMHN)
		{
			this.NEAEODLKHPJ(LKJEKCHLMHN);
			for (int i = 0; i < this.HLAGMPFPBAA.Count; i++)
			{
				if (this.HLAGMPFPBAA[i] == LKJEKCHLMHN)
				{
					this.HLFFIMEDOBN(LKJEKCHLMHN);
				}
				else
				{
					this.HLAGMPFPBAA[i].isOn = true;
				}
			}
			this.onToggleGroupChanged.Invoke(this.PLNKAAFDOLH());
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x003DAEB0 File Offset: 0x003D90B0
		public void MGELAALCJLG()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = true;
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i++)
			{
				this.HLAGMPFPBAA[i].isOn = false;
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A48F RID: 42127 RVA: 0x003DAF00 File Offset: 0x003D9100
		public bool NCPGKCELEOB()
		{
			List<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.LNIJKGECNME == null)
			{
				ExtensionsToggleGroup.LNIJKGECNME = new Predicate<ExtensionsToggle>(ExtensionsToggleGroup.EJBNKAIICJF);
			}
			return hlagmpfpbaa.Find(ExtensionsToggleGroup.LNIJKGECNME) != null;
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x003DAD2A File Offset: 0x003D8F2A
		[CompilerGenerated]
		private static bool IECEKINGHPH(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.isOn;
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x003DAD22 File Offset: 0x003D8F22
		public ExtensionsToggle DIEGGLCPGPN()
		{
			return this.<PDAAAECABIP>k__BackingField;
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x003DAF30 File Offset: 0x003D9130
		public IEnumerable<ExtensionsToggle> HMFDCLCLMEC()
		{
			IEnumerable<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.CLCBJCKCBDD == null)
			{
				ExtensionsToggleGroup.CLCBJCKCBDD = new Func<ExtensionsToggle, bool>(ExtensionsToggleGroup.LCLKCEOPBHP);
			}
			return hlagmpfpbaa.Where(ExtensionsToggleGroup.CLCBJCKCBDD);
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x003DAF5A File Offset: 0x003D915A
		public bool AnyTogglesOn()
		{
			List<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.LNIJKGECNME == null)
			{
				ExtensionsToggleGroup.LNIJKGECNME = new Predicate<ExtensionsToggle>(ExtensionsToggleGroup.JNEICHJCHJG);
			}
			return hlagmpfpbaa.Find(ExtensionsToggleGroup.LNIJKGECNME) != null;
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x003DAF8A File Offset: 0x003D918A
		private void OIGDCJHJFHI(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = ":";
				object[] array = new object[6];
				array[0] = LKJEKCHLMHN;
				array[0] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600A495 RID: 42133 RVA: 0x003DAD22 File Offset: 0x003D8F22
		// (set) Token: 0x0600A4E7 RID: 42215 RVA: 0x003DB143 File Offset: 0x003D9343
		public ExtensionsToggle SelectedToggle { get; private set; }

		// Token: 0x0600A496 RID: 42134 RVA: 0x003DAFC7 File Offset: 0x003D91C7
		public void HNLKNEHKCJH(bool DPNHODJHGJL)
		{
			Debug.Log("_Value3" + DPNHODJHGJL + "_Value");
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x003DAFE4 File Offset: 0x003D91E4
		public void JHCGJNOHOJK(ExtensionsToggle LKJEKCHLMHN)
		{
			this.NEAEODLKHPJ(LKJEKCHLMHN);
			for (int i = 0; i < this.HLAGMPFPBAA.Count; i++)
			{
				if (this.HLAGMPFPBAA[i] == LKJEKCHLMHN)
				{
					this.AOMJOJGGNMO(LKJEKCHLMHN);
				}
				else
				{
					this.HLAGMPFPBAA[i].isOn = true;
				}
			}
			this.onToggleGroupChanged.Invoke(this.NIPEGGKCHEB());
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x003DB05A File Offset: 0x003D925A
		private void BEPGAGMPFDP(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "EventSystem";
				object[] array = new object[]
				{
					LKJEKCHLMHN
				};
				array[0] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x003DB097 File Offset: 0x003D9297
		public void AJIOAIEAELN(bool DPNHODJHGJL)
		{
			Debug.Log("Add Environment Object" + DPNHODJHGJL + " or ");
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x003DB0B4 File Offset: 0x003D92B4
		public void KNPBHANGBNJ()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = true;
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				this.HLAGMPFPBAA[i].isOn = false;
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x003DB104 File Offset: 0x003D9304
		public void KLKIJKOJJOJ(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.BCOJEPHOKHO));
			}
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x003DB13B File Offset: 0x003D933B
		public bool OEKOBDEMFDI()
		{
			return this.m_AllowSwitchOff;
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x003DB143 File Offset: 0x003D9343
		private void AOMJOJGGNMO(ExtensionsToggle DPNHODJHGJL)
		{
			this.<PDAAAECABIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x003DB14C File Offset: 0x003D934C
		public void DMMCPLDPFBL()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = false;
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i++)
			{
				this.HLAGMPFPBAA[i].GPBKPNBCJEL(false);
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x003DB19C File Offset: 0x003D939C
		private static bool NMGPODGGOPJ(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.CKHMHGANJBA();
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x003DB1A4 File Offset: 0x003D93A4
		public void HCLCKKDAFCN(bool DPNHODJHGJL)
		{
			Debug.Log("\"" + DPNHODJHGJL + "_Value5");
		}

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x003DB1C0 File Offset: 0x003D93C0
		public void LNAFDGEOHEP(bool DPNHODJHGJL)
		{
			Debug.Log("Set Satellite Input" + DPNHODJHGJL + "SaveButton");
		}

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x003DB1DC File Offset: 0x003D93DC
		public void DBNOGOBOPIO(ExtensionsToggle LKJEKCHLMHN)
		{
			this.NEAEODLKHPJ(LKJEKCHLMHN);
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i++)
			{
				if (this.HLAGMPFPBAA[i] == LKJEKCHLMHN)
				{
					this.MGJPJJAMCCL(LKJEKCHLMHN);
				}
				else
				{
					this.HLAGMPFPBAA[i].isOn = true;
				}
			}
			this.onToggleGroupChanged.Invoke(this.GHGPNEFCNKI());
		}

		// Token: 0x0600A4A3 RID: 42147 RVA: 0x003DAD2A File Offset: 0x003D8F2A
		private static bool BHGBOCAJEAB(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.isOn;
		}

		// Token: 0x0600A4A4 RID: 42148 RVA: 0x003DB13B File Offset: 0x003D933B
		public bool OGIGACJBJKL()
		{
			return this.m_AllowSwitchOff;
		}

		// Token: 0x0600A4A5 RID: 42149 RVA: 0x003DB252 File Offset: 0x003D9452
		public void MKOBIFCPMHC(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.NCGCGJFPIGL));
			}
		}

		// Token: 0x0600A4A6 RID: 42150 RVA: 0x003DB289 File Offset: 0x003D9489
		private void BEKIMFMCHPL(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A4A7 RID: 42151 RVA: 0x003DAD32 File Offset: 0x003D8F32
		public void BNOHEJFOLNG(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.EKIFOBBPKHP));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600A4A8 RID: 42152 RVA: 0x003DB13B File Offset: 0x003D933B
		// (set) Token: 0x0600A4B0 RID: 42160 RVA: 0x003DAE06 File Offset: 0x003D9006
		public bool allowSwitchOff
		{
			get
			{
				return this.m_AllowSwitchOff;
			}
			set
			{
				this.m_AllowSwitchOff = value;
			}
		}

		// Token: 0x0600A4A9 RID: 42153 RVA: 0x003DB297 File Offset: 0x003D9497
		public IEnumerable<ExtensionsToggle> DPBDFAJLMJE()
		{
			IEnumerable<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.CLCBJCKCBDD == null)
			{
				ExtensionsToggleGroup.CLCBJCKCBDD = new Func<ExtensionsToggle, bool>(ExtensionsToggleGroup.NMGPODGGOPJ);
			}
			return hlagmpfpbaa.Where(ExtensionsToggleGroup.CLCBJCKCBDD);
		}

		// Token: 0x0600A4AA RID: 42154 RVA: 0x003DB13B File Offset: 0x003D933B
		public bool JMKLPKBMCDP()
		{
			return this.m_AllowSwitchOff;
		}

		// Token: 0x0600A4AB RID: 42155 RVA: 0x003DB2C1 File Offset: 0x003D94C1
		public void KDPENOAJHON(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.NCGCGJFPIGL));
			}
		}

		// Token: 0x0600A4AC RID: 42156 RVA: 0x003DB289 File Offset: 0x003D9489
		private void DBPKNOCOJIH(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A4AD RID: 42157 RVA: 0x003DB2F8 File Offset: 0x003D94F8
		public void HCAJJHGHGKG(ExtensionsToggle LKJEKCHLMHN)
		{
			this.LADAMCANPLJ(LKJEKCHLMHN);
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i++)
			{
				if (this.HLAGMPFPBAA[i] == LKJEKCHLMHN)
				{
					this.IBLKEFFPNOP(LKJEKCHLMHN);
				}
				else
				{
					this.HLAGMPFPBAA[i].isOn = false;
				}
			}
			this.onToggleGroupChanged.Invoke(this.GHGPNEFCNKI());
		}

		// Token: 0x0600A4AE RID: 42158 RVA: 0x003DB36E File Offset: 0x003D956E
		public void HasAToggleFlipped(bool DPNHODJHGJL)
		{
			Debug.Log("Testing, a toggle has toggled [" + DPNHODJHGJL + "]");
		}

		// Token: 0x0600A4AF RID: 42159 RVA: 0x003DB38C File Offset: 0x003D958C
		public void FPJLOCDFDNI()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = false;
			for (int i = 0; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				this.HLAGMPFPBAA[i].GPBKPNBCJEL(true);
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A4B1 RID: 42161 RVA: 0x003DB19C File Offset: 0x003D939C
		private static bool FBOHGBIHAAJ(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.CKHMHGANJBA();
		}

		// Token: 0x0600A4B2 RID: 42162 RVA: 0x003DB3DC File Offset: 0x003D95DC
		public void NotifyToggleOn(ExtensionsToggle LKJEKCHLMHN)
		{
			this.CBDPFGBBKON(LKJEKCHLMHN);
			for (int i = 0; i < this.HLAGMPFPBAA.Count; i++)
			{
				if (this.HLAGMPFPBAA[i] == LKJEKCHLMHN)
				{
					this.SelectedToggle = LKJEKCHLMHN;
				}
				else
				{
					this.HLAGMPFPBAA[i].isOn = false;
				}
			}
			this.onToggleGroupChanged.Invoke(this.AnyTogglesOn());
		}

		// Token: 0x0600A4B3 RID: 42163 RVA: 0x003DAD2A File Offset: 0x003D8F2A
		private static bool BGMHKBIIIDF(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.isOn;
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x003DB452 File Offset: 0x003D9652
		private static bool HCEOPFIHAKK(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.KJAEDHPGFOB();
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x003DB297 File Offset: 0x003D9497
		public IEnumerable<ExtensionsToggle> AHJCEBMNMBB()
		{
			IEnumerable<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.CLCBJCKCBDD == null)
			{
				ExtensionsToggleGroup.CLCBJCKCBDD = new Func<ExtensionsToggle, bool>(ExtensionsToggleGroup.NMGPODGGOPJ);
			}
			return hlagmpfpbaa.Where(ExtensionsToggleGroup.CLCBJCKCBDD);
		}

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x003DAD22 File Offset: 0x003D8F22
		public ExtensionsToggle LIJIGBAFGIM()
		{
			return this.<PDAAAECABIP>k__BackingField;
		}

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x003DB45A File Offset: 0x003D965A
		public void PMPHEAKLEDH(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.FFDMKLOILOO));
			}
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x003DB490 File Offset: 0x003D9690
		public void FOOJFFDPBDI(bool DPNHODJHGJL)
		{
			Debug.Log("_LightIntensity" + DPNHODJHGJL + "player.xp");
		}

		// Token: 0x0600A4B9 RID: 42169 RVA: 0x003DB19C File Offset: 0x003D939C
		private static bool HMCDLHILPBB(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.CKHMHGANJBA();
		}

		// Token: 0x0600A4BA RID: 42170 RVA: 0x003DB4AC File Offset: 0x003D96AC
		public bool ABOBAFAEODI()
		{
			List<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.LNIJKGECNME == null)
			{
				ExtensionsToggleGroup.LNIJKGECNME = new Predicate<ExtensionsToggle>(ExtensionsToggleGroup.EDGADHPMKGD);
			}
			return hlagmpfpbaa.Find(ExtensionsToggleGroup.LNIJKGECNME) != null;
		}

		// Token: 0x0600A4BB RID: 42171 RVA: 0x003DB19C File Offset: 0x003D939C
		private static bool OPEMCNHFCFP(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.CKHMHGANJBA();
		}

		// Token: 0x0600A4BC RID: 42172 RVA: 0x003DB4DC File Offset: 0x003D96DC
		public void BBODKJKMBCA()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = true;
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				this.HLAGMPFPBAA[i].isOn = true;
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A4BD RID: 42173 RVA: 0x003DB52C File Offset: 0x003D972C
		public void LODOIBACJKM(bool DPNHODJHGJL)
		{
			Debug.Log("_Value2" + DPNHODJHGJL + "CameraFilterPack/Blend2Camera_Overlay");
		}

		// Token: 0x0600A4BE RID: 42174 RVA: 0x003DB104 File Offset: 0x003D9304
		public void FOMBNHFMFME(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.BCOJEPHOKHO));
			}
		}

		// Token: 0x0600A4BF RID: 42175 RVA: 0x003DB548 File Offset: 0x003D9748
		public bool NIPEGGKCHEB()
		{
			List<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.LNIJKGECNME == null)
			{
				ExtensionsToggleGroup.LNIJKGECNME = new Predicate<ExtensionsToggle>(ExtensionsToggleGroup.FGPKHKLNLBG);
			}
			return hlagmpfpbaa.Find(ExtensionsToggleGroup.LNIJKGECNME) != null;
		}

		// Token: 0x0600A4C0 RID: 42176 RVA: 0x003DACFE File Offset: 0x003D8EFE
		private static bool PJBJEJJBAPI(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.MNLDFHKEIOE();
		}

		// Token: 0x0600A4C1 RID: 42177 RVA: 0x003DB289 File Offset: 0x003D9489
		private void KLJANCCFOML(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x003DAD2A File Offset: 0x003D8F2A
		private static bool HADDLMFIHDM(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.isOn;
		}

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x003DB578 File Offset: 0x003D9778
		public void COGKPMEHENL(bool DPNHODJHGJL)
		{
			Debug.Log("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event." + DPNHODJHGJL + "_TimeX");
		}

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x003DACFE File Offset: 0x003D8EFE
		private static bool GMBILDNEDFD(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.MNLDFHKEIOE();
		}

		// Token: 0x0600A4C5 RID: 42181 RVA: 0x003DB594 File Offset: 0x003D9794
		private void CBDPFGBBKON(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				throw new ArgumentException(string.Format("Toggle {0} is not part of ToggleGroup {1}", new object[]
				{
					LKJEKCHLMHN,
					this
				}));
			}
		}

		// Token: 0x0600A4C6 RID: 42182 RVA: 0x003DB289 File Offset: 0x003D9489
		private void FFDMKLOILOO(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x003DB19C File Offset: 0x003D939C
		private static bool DGOFIFJKNIM(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.CKHMHGANJBA();
		}

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x003DB5D1 File Offset: 0x003D97D1
		public bool GHGPNEFCNKI()
		{
			List<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.LNIJKGECNME == null)
			{
				ExtensionsToggleGroup.LNIJKGECNME = new Predicate<ExtensionsToggle>(ExtensionsToggleGroup.OPEMCNHFCFP);
			}
			return hlagmpfpbaa.Find(ExtensionsToggleGroup.LNIJKGECNME) != null;
		}

		// Token: 0x0600A4C9 RID: 42185 RVA: 0x003DB601 File Offset: 0x003D9801
		public bool IFIOBBEELPO()
		{
			List<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.LNIJKGECNME == null)
			{
				ExtensionsToggleGroup.LNIJKGECNME = new Predicate<ExtensionsToggle>(ExtensionsToggleGroup.BGMHKBIIIDF);
			}
			return hlagmpfpbaa.Find(ExtensionsToggleGroup.LNIJKGECNME) != null;
		}

		// Token: 0x0600A4CA RID: 42186 RVA: 0x003DB631 File Offset: 0x003D9831
		public IEnumerable<ExtensionsToggle> ActiveToggles()
		{
			IEnumerable<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.CLCBJCKCBDD == null)
			{
				ExtensionsToggleGroup.CLCBJCKCBDD = new Func<ExtensionsToggle, bool>(ExtensionsToggleGroup.IECEKINGHPH);
			}
			return hlagmpfpbaa.Where(ExtensionsToggleGroup.CLCBJCKCBDD);
		}

		// Token: 0x0600A4CB RID: 42187 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void ABKNOEOIBCK(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x003DB65B File Offset: 0x003D985B
		private void MJMLCCDBDPC(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "event";
				object[] array = new object[0];
				array[0] = LKJEKCHLMHN;
				array[0] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A4CD RID: 42189 RVA: 0x003DB698 File Offset: 0x003D9898
		public void KMMFGEACEAO(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.BIBBFADPOBC));
			}
		}

		// Token: 0x0600A4CE RID: 42190 RVA: 0x003DB6D0 File Offset: 0x003D98D0
		public void LMJKJCLEAGE(ExtensionsToggle LKJEKCHLMHN)
		{
			this.BEPGAGMPFDP(LKJEKCHLMHN);
			for (int i = 0; i < this.HLAGMPFPBAA.Count; i++)
			{
				if (this.HLAGMPFPBAA[i] == LKJEKCHLMHN)
				{
					this.SelectedToggle = LKJEKCHLMHN;
				}
				else
				{
					this.HLAGMPFPBAA[i].GPBKPNBCJEL(true);
				}
			}
			this.onToggleGroupChanged.Invoke(this.PLNKAAFDOLH());
		}

		// Token: 0x0600A4CF RID: 42191 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void AFKANGOPAHP(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A4D0 RID: 42192 RVA: 0x003DB746 File Offset: 0x003D9946
		public void DANIJHKGICO(bool DPNHODJHGJL)
		{
			Debug.Log("_Value4" + DPNHODJHGJL + "GlassesColor2");
		}

		// Token: 0x0600A4D1 RID: 42193 RVA: 0x003DB764 File Offset: 0x003D9964
		public void MCDAALHNDDG(ExtensionsToggle LKJEKCHLMHN)
		{
			this.MBMNODDEFPB(LKJEKCHLMHN);
			for (int i = 0; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				if (this.HLAGMPFPBAA[i] == LKJEKCHLMHN)
				{
					this.LKGDGJHPIBF(LKJEKCHLMHN);
				}
				else
				{
					this.HLAGMPFPBAA[i].GPBKPNBCJEL(false);
				}
			}
			this.onToggleGroupChanged.Invoke(this.AnyTogglesOn());
		}

		// Token: 0x0600A4D2 RID: 42194 RVA: 0x003DB7DC File Offset: 0x003D99DC
		public void IOMECBNFDEF()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = true;
			for (int i = 0; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				this.HLAGMPFPBAA[i].GPBKPNBCJEL(false);
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A4D3 RID: 42195 RVA: 0x003DB289 File Offset: 0x003D9489
		private void LGELCJHBGIM(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A4D4 RID: 42196 RVA: 0x003DB143 File Offset: 0x003D9343
		private void JOPCCCKACLA(ExtensionsToggle DPNHODJHGJL)
		{
			this.<PDAAAECABIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600A4D5 RID: 42197 RVA: 0x003DB143 File Offset: 0x003D9343
		private void HLFFIMEDOBN(ExtensionsToggle DPNHODJHGJL)
		{
			this.<PDAAAECABIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600A4D6 RID: 42198 RVA: 0x003DB143 File Offset: 0x003D9343
		private void MGJPJJAMCCL(ExtensionsToggle DPNHODJHGJL)
		{
			this.<PDAAAECABIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600A4D7 RID: 42199 RVA: 0x003DB82C File Offset: 0x003D9A2C
		public void GABCKDLDDAH(bool DPNHODJHGJL)
		{
			Debug.Log("plainText" + DPNHODJHGJL + "/../");
		}

		// Token: 0x0600A4D8 RID: 42200 RVA: 0x003DAD69 File Offset: 0x003D8F69
		public void PEPGKNBEDDC(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.BCOJEPHOKHO));
			}
		}

		// Token: 0x0600A4D9 RID: 42201 RVA: 0x003DB848 File Offset: 0x003D9A48
		public void FNEFCGLJNIO(bool DPNHODJHGJL)
		{
			Debug.Log("_Distortion" + DPNHODJHGJL + "STICKRHOR");
		}

		// Token: 0x0600A4DA RID: 42202 RVA: 0x003DAD2A File Offset: 0x003D8F2A
		private static bool EJBNKAIICJF(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.isOn;
		}

		// Token: 0x0600A4DB RID: 42203 RVA: 0x003DB864 File Offset: 0x003D9A64
		public void HPCCEPCILED()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = true;
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				this.HLAGMPFPBAA[i].isOn = true;
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A4DC RID: 42204 RVA: 0x003DB8B4 File Offset: 0x003D9AB4
		public void EBDIAJGEMAP()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = true;
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i++)
			{
				this.HLAGMPFPBAA[i].GPBKPNBCJEL(false);
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A4DD RID: 42205 RVA: 0x003DB904 File Offset: 0x003D9B04
		public void HLIMABOOEEE(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.KLJANCCFOML));
			}
		}

		// Token: 0x0600A4DE RID: 42206 RVA: 0x003DB93A File Offset: 0x003D9B3A
		public void CDAPAMDKGKH(bool DPNHODJHGJL)
		{
			Debug.Log("FToA" + DPNHODJHGJL + "_TimeX");
		}

		// Token: 0x0600A4DF RID: 42207 RVA: 0x003DB956 File Offset: 0x003D9B56
		private void NGDHGAFLBBD(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "#ok";
				object[] array = new object[5];
				array[1] = LKJEKCHLMHN;
				array[0] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A4E0 RID: 42208 RVA: 0x003DB13B File Offset: 0x003D933B
		public bool GEAPNFNIPNA()
		{
			return this.m_AllowSwitchOff;
		}

		// Token: 0x0600A4E1 RID: 42209 RVA: 0x003DAD22 File Offset: 0x003D8F22
		public ExtensionsToggle PLGIKIEGKJJ()
		{
			return this.<PDAAAECABIP>k__BackingField;
		}

		// Token: 0x0600A4E2 RID: 42210 RVA: 0x003DB993 File Offset: 0x003D9B93
		public void ILDICABNDNL(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.AIJPOEKNIOK));
			}
		}

		// Token: 0x0600A4E3 RID: 42211 RVA: 0x003DB289 File Offset: 0x003D9489
		private void BCOJEPHOKHO(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A4E4 RID: 42212 RVA: 0x003DB9C9 File Offset: 0x003D9BC9
		public void JPLMBIIOODL(bool DPNHODJHGJL)
		{
			Debug.Log("[DiscordController] Connected to {0}#{1}: {2}" + DPNHODJHGJL + "Ok");
		}

		// Token: 0x0600A4E5 RID: 42213 RVA: 0x003DAD2A File Offset: 0x003D8F2A
		private static bool EDGADHPMKGD(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.isOn;
		}

		// Token: 0x0600A4E6 RID: 42214 RVA: 0x003DB9E5 File Offset: 0x003D9BE5
		public IEnumerable<ExtensionsToggle> DHFDBMOGBBP()
		{
			IEnumerable<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.CLCBJCKCBDD == null)
			{
				ExtensionsToggleGroup.CLCBJCKCBDD = new Func<ExtensionsToggle, bool>(ExtensionsToggleGroup.HCEOPFIHAKK);
			}
			return hlagmpfpbaa.Where(ExtensionsToggleGroup.CLCBJCKCBDD);
		}

		// Token: 0x0600A4E8 RID: 42216 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void MGFPPALLABI(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A4E9 RID: 42217 RVA: 0x003DB452 File Offset: 0x003D9652
		private static bool IEAKHFAPLBC(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.KJAEDHPGFOB();
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void IELIAHLOEMP(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A4EB RID: 42219 RVA: 0x003DB452 File Offset: 0x003D9652
		private static bool JCHLPOFGEBC(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.KJAEDHPGFOB();
		}

		// Token: 0x0600A4EC RID: 42220 RVA: 0x003DBA0F File Offset: 0x003D9C0F
		public void IEPCNCLIKOB(bool DPNHODJHGJL)
		{
			Debug.Log("_PColor" + DPNHODJHGJL + "_OcclusionBlurTexture");
		}

		// Token: 0x0600A4ED RID: 42221 RVA: 0x003DB289 File Offset: 0x003D9489
		private void BIBBFADPOBC(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A4EE RID: 42222 RVA: 0x003DB289 File Offset: 0x003D9489
		private void PJDMNDCAPJF(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A4EF RID: 42223 RVA: 0x003DBA2B File Offset: 0x003D9C2B
		public void AAAFHMDLMNP(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.IHGDBGPALHP));
			}
		}

		// Token: 0x0600A4F0 RID: 42224 RVA: 0x003DB452 File Offset: 0x003D9652
		private static bool EEKLCPLFOMB(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.KJAEDHPGFOB();
		}

		// Token: 0x0600A4F1 RID: 42225 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void EBHNDNIGCDO(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A4F2 RID: 42226 RVA: 0x003DB252 File Offset: 0x003D9452
		public void ICMKGJGMKAH(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.NCGCGJFPIGL));
			}
		}

		// Token: 0x0600A4F3 RID: 42227 RVA: 0x003DB19C File Offset: 0x003D939C
		private static bool DNEIKIIEOAJ(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.CKHMHGANJBA();
		}

		// Token: 0x0600A4F4 RID: 42228 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void ECHGBJDBIDE(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A4F5 RID: 42229 RVA: 0x003DAD69 File Offset: 0x003D8F69
		public void RegisterToggle(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.BCOJEPHOKHO));
			}
		}

		// Token: 0x0600A4F6 RID: 42230 RVA: 0x003DAD2A File Offset: 0x003D8F2A
		[CompilerGenerated]
		private static bool JNEICHJCHJG(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.isOn;
		}

		// Token: 0x0600A4F7 RID: 42231 RVA: 0x003DB104 File Offset: 0x003D9304
		public void UnregisterToggle(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.BCOJEPHOKHO));
			}
		}

		// Token: 0x0600A4F8 RID: 42232 RVA: 0x003DBA64 File Offset: 0x003D9C64
		public void BCBNHGCBAKN(ExtensionsToggle LKJEKCHLMHN)
		{
			this.NEAEODLKHPJ(LKJEKCHLMHN);
			for (int i = 0; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				if (this.HLAGMPFPBAA[i] == LKJEKCHLMHN)
				{
					this.IBLKEFFPNOP(LKJEKCHLMHN);
				}
				else
				{
					this.HLAGMPFPBAA[i].isOn = true;
				}
			}
			this.onToggleGroupChanged.Invoke(this.NBLHIOAFCJO());
		}

		// Token: 0x0600A4F9 RID: 42233 RVA: 0x003DAD22 File Offset: 0x003D8F22
		public ExtensionsToggle GBHIHMCMDDA()
		{
			return this.<PDAAAECABIP>k__BackingField;
		}

		// Token: 0x0600A4FA RID: 42234 RVA: 0x003DBADA File Offset: 0x003D9CDA
		public void FNFDOJEOKFL(bool DPNHODJHGJL)
		{
			Debug.Log("UI Extensions/SoftMaskShaderText" + DPNHODJHGJL + "GlassAberration");
		}

		// Token: 0x0600A4FB RID: 42235 RVA: 0x003DB19C File Offset: 0x003D939C
		private static bool NPOCCEHDPDC(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.CKHMHGANJBA();
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void OJJNAFAKIHG(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x003DB289 File Offset: 0x003D9489
		private void IHGDBGPALHP(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A4FE RID: 42238 RVA: 0x003DAF30 File Offset: 0x003D9130
		public IEnumerable<ExtensionsToggle> DHLMKOLDGBM()
		{
			IEnumerable<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.CLCBJCKCBDD == null)
			{
				ExtensionsToggleGroup.CLCBJCKCBDD = new Func<ExtensionsToggle, bool>(ExtensionsToggleGroup.LCLKCEOPBHP);
			}
			return hlagmpfpbaa.Where(ExtensionsToggleGroup.CLCBJCKCBDD);
		}

		// Token: 0x0600A4FF RID: 42239 RVA: 0x003DBAF6 File Offset: 0x003D9CF6
		public void OPNNJABCJIB(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.EKIFOBBPKHP));
			}
		}

		// Token: 0x0600A500 RID: 42240 RVA: 0x003DBB2C File Offset: 0x003D9D2C
		public void GALLOEEJJIJ()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = false;
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				this.HLAGMPFPBAA[i].isOn = false;
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A501 RID: 42241 RVA: 0x003DBB7C File Offset: 0x003D9D7C
		public void KEMIHPHCKGD(bool DPNHODJHGJL)
		{
			Debug.Log("Set particless emission (glow)" + DPNHODJHGJL + "' has been reset to the fault value");
		}

		// Token: 0x0600A502 RID: 42242 RVA: 0x003DBB98 File Offset: 0x003D9D98
		private void LADAMCANPLJ(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "MultiplayerButton";
				object[] array = new object[8];
				array[1] = LKJEKCHLMHN;
				array[0] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A503 RID: 42243 RVA: 0x003DB143 File Offset: 0x003D9343
		private void IBLKEFFPNOP(ExtensionsToggle DPNHODJHGJL)
		{
			this.<PDAAAECABIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x003DB289 File Offset: 0x003D9489
		private void AIJPOEKNIOK(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A505 RID: 42245 RVA: 0x003DBBD5 File Offset: 0x003D9DD5
		private void ELLLBABCIBG(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "_Saturation";
				object[] array = new object[6];
				array[0] = LKJEKCHLMHN;
				array[1] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A506 RID: 42246 RVA: 0x003DBC12 File Offset: 0x003D9E12
		public void NJHFJPAEODF(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.LGELCJHBGIM));
			}
		}

		// Token: 0x0600A507 RID: 42247 RVA: 0x003DB143 File Offset: 0x003D9343
		private void LKGDGJHPIBF(ExtensionsToggle DPNHODJHGJL)
		{
			this.<PDAAAECABIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600A508 RID: 42248 RVA: 0x003DB698 File Offset: 0x003D9898
		public void GGCNMPDDCIL(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.BIBBFADPOBC));
			}
		}

		// Token: 0x0600A509 RID: 42249 RVA: 0x003DB452 File Offset: 0x003D9652
		private static bool NDBIEIKGJCJ(ExtensionsToggle IACGDFHKCAE)
		{
			return IACGDFHKCAE.KJAEDHPGFOB();
		}

		// Token: 0x0600A50A RID: 42250 RVA: 0x003DB993 File Offset: 0x003D9B93
		public void EJNMBNGKKAJ(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.AIJPOEKNIOK));
			}
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x003DBC4C File Offset: 0x003D9E4C
		public void INLOPIOFGCN()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = true;
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				this.HLAGMPFPBAA[i].GPBKPNBCJEL(false);
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x003DB13B File Offset: 0x003D933B
		public bool ILEGILJLILA()
		{
			return this.m_AllowSwitchOff;
		}

		// Token: 0x0600A50D RID: 42253 RVA: 0x003DBC9C File Offset: 0x003D9E9C
		public void FOAPHMMHAEC(bool DPNHODJHGJL)
		{
			Debug.Log("_TimeX" + DPNHODJHGJL + "DPADVER");
		}

		// Token: 0x0600A50E RID: 42254 RVA: 0x003DBCB8 File Offset: 0x003D9EB8
		public void SetAllTogglesOff()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = true;
			for (int i = 0; i < this.HLAGMPFPBAA.Count; i++)
			{
				this.HLAGMPFPBAA[i].isOn = false;
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x0600A50F RID: 42255 RVA: 0x003DBD08 File Offset: 0x003D9F08
		public void KMGMINMHLCB(ExtensionsToggle LKJEKCHLMHN)
		{
			this.MJMLCCDBDPC(LKJEKCHLMHN);
			for (int i = 0; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				if (this.HLAGMPFPBAA[i] == LKJEKCHLMHN)
				{
					this.HLFFIMEDOBN(LKJEKCHLMHN);
				}
				else
				{
					this.HLAGMPFPBAA[i].GPBKPNBCJEL(true);
				}
			}
			this.onToggleGroupChanged.Invoke(this.NCPGKCELEOB());
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void NHNMCDIGJMK(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A511 RID: 42257 RVA: 0x003DB289 File Offset: 0x003D9489
		private void NCGCGJFPIGL(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A512 RID: 42258 RVA: 0x003DBD7E File Offset: 0x003D9F7E
		private void CGNEAHIJHNM(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "_Exponent";
				object[] array = new object[3];
				array[1] = LKJEKCHLMHN;
				array[0] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A513 RID: 42259 RVA: 0x003DBDBB File Offset: 0x003D9FBB
		public void EJKHGFIICPP(bool DPNHODJHGJL)
		{
			Debug.Log("_Visualize" + DPNHODJHGJL + "Chat");
		}

		// Token: 0x0600A514 RID: 42260 RVA: 0x003DBDD7 File Offset: 0x003D9FD7
		public void HasTheGroupToggle(bool DPNHODJHGJL)
		{
			Debug.Log("Testing, the group has toggled [" + DPNHODJHGJL + "]");
		}

		// Token: 0x0600A515 RID: 42261 RVA: 0x003DBDF3 File Offset: 0x003D9FF3
		public void DBEEGOODOHE(bool DPNHODJHGJL)
		{
			Debug.Log("_FadeFX" + DPNHODJHGJL + "_ScreenResolution");
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x003DB13B File Offset: 0x003D933B
		public bool JGOIBHNEELF()
		{
			return this.m_AllowSwitchOff;
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x003DBE0F File Offset: 0x003DA00F
		public void OEKGIHIEHIG(bool DPNHODJHGJL)
		{
			Debug.Log("_ScreenResolution" + DPNHODJHGJL + "_Green_G");
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void AANGAMGLNDA(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x003DBE2B File Offset: 0x003DA02B
		public void FFECBIOALCG(ExtensionsToggle LKJEKCHLMHN)
		{
			if (!this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Add(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.AddListener(new UnityAction<bool>(this.PJDMNDCAPJF));
			}
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x003DBE64 File Offset: 0x003DA064
		public void ABCEPPEELDH(ExtensionsToggle LKJEKCHLMHN)
		{
			this.CBDPFGBBKON(LKJEKCHLMHN);
			for (int i = 1; i < this.HLAGMPFPBAA.Count; i += 0)
			{
				if (this.HLAGMPFPBAA[i] == LKJEKCHLMHN)
				{
					this.MGJPJJAMCCL(LKJEKCHLMHN);
				}
				else
				{
					this.HLAGMPFPBAA[i].GPBKPNBCJEL(false);
				}
			}
			this.onToggleGroupChanged.Invoke(this.GHGPNEFCNKI());
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x003DBEDA File Offset: 0x003DA0DA
		private void PDIGIHPLGIH(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "BitsData";
				object[] array = new object[3];
				array[0] = LKJEKCHLMHN;
				array[1] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x003DBF17 File Offset: 0x003DA117
		private void HHBNELMLDOM(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "BitsData";
				object[] array = new object[8];
				array[1] = LKJEKCHLMHN;
				array[1] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x003DBF54 File Offset: 0x003DA154
		public void DIGPKOFGENM(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.BEKIMFMCHPL));
			}
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x003DBF8B File Offset: 0x003DA18B
		public void NPCFHDMCCNB(ExtensionsToggle LKJEKCHLMHN)
		{
			if (this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				this.HLAGMPFPBAA.Remove(LKJEKCHLMHN);
				LKJEKCHLMHN.onValueChanged.RemoveListener(new UnityAction<bool>(this.FFDMKLOILOO));
			}
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x003DBFC2 File Offset: 0x003DA1C2
		public bool NBLHIOAFCJO()
		{
			List<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.LNIJKGECNME == null)
			{
				ExtensionsToggleGroup.LNIJKGECNME = new Predicate<ExtensionsToggle>(ExtensionsToggleGroup.FBOHGBIHAAJ);
			}
			return hlagmpfpbaa.Find(ExtensionsToggleGroup.LNIJKGECNME) != null;
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x003DAE06 File Offset: 0x003D9006
		public void LELKKBEHJBK(bool DPNHODJHGJL)
		{
			this.m_AllowSwitchOff = DPNHODJHGJL;
		}

		// Token: 0x0600A521 RID: 42273 RVA: 0x003DB289 File Offset: 0x003D9489
		private void EKIFOBBPKHP(bool BENEBKFCPDE)
		{
			this.onToggleGroupToggleChanged.Invoke(BENEBKFCPDE);
		}

		// Token: 0x0600A522 RID: 42274 RVA: 0x003DAF00 File Offset: 0x003D9100
		public bool PLNKAAFDOLH()
		{
			List<ExtensionsToggle> hlagmpfpbaa = this.HLAGMPFPBAA;
			if (ExtensionsToggleGroup.LNIJKGECNME == null)
			{
				ExtensionsToggleGroup.LNIJKGECNME = new Predicate<ExtensionsToggle>(ExtensionsToggleGroup.EJBNKAIICJF);
			}
			return hlagmpfpbaa.Find(ExtensionsToggleGroup.LNIJKGECNME) != null;
		}

		// Token: 0x0600A523 RID: 42275 RVA: 0x003DBFF2 File Offset: 0x003DA1F2
		private void MBMNODDEFPB(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "Texture3";
				object[] array = new object[0];
				array[0] = LKJEKCHLMHN;
				array[1] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0600A524 RID: 42276 RVA: 0x003DAD22 File Offset: 0x003D8F22
		public ExtensionsToggle MJBOAIGEGGJ()
		{
			return this.<PDAAAECABIP>k__BackingField;
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x003DC02F File Offset: 0x003DA22F
		private void DFNLNFIBMGO(ExtensionsToggle LKJEKCHLMHN)
		{
			if (LKJEKCHLMHN == null || !this.HLAGMPFPBAA.Contains(LKJEKCHLMHN))
			{
				string format = "_Fade";
				object[] array = new object[5];
				array[0] = LKJEKCHLMHN;
				array[1] = this;
				throw new ArgumentException(string.Format(format, array));
			}
		}

		// Token: 0x0400129A RID: 4762
		[SerializeField]
		private bool m_AllowSwitchOff;

		// Token: 0x0400129B RID: 4763
		private List<ExtensionsToggle> HLAGMPFPBAA = new List<ExtensionsToggle>();

		// Token: 0x0400129C RID: 4764
		public ExtensionsToggleGroup.ToggleGroupEvent onToggleGroupChanged = new ExtensionsToggleGroup.ToggleGroupEvent();

		// Token: 0x0400129D RID: 4765
		public ExtensionsToggleGroup.ToggleGroupEvent onToggleGroupToggleChanged = new ExtensionsToggleGroup.ToggleGroupEvent();

		// Token: 0x0400129F RID: 4767
		[CompilerGenerated]
		private static Predicate<ExtensionsToggle> LNIJKGECNME;

		// Token: 0x040012A0 RID: 4768
		[CompilerGenerated]
		private static Func<ExtensionsToggle, bool> CLCBJCKCBDD;

		// Token: 0x020002AD RID: 685
		[Serializable]
		public class ToggleGroupEvent : UnityEvent<bool>
		{
		}
	}
}
