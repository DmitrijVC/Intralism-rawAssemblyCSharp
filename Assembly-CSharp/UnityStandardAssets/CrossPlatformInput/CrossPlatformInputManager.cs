using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput.PlatformSpecific;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x02000183 RID: 387
	public static class CrossPlatformInputManager
	{
		// Token: 0x0600723B RID: 29243 RVA: 0x00237C86 File Offset: 0x00235E86
		static CrossPlatformInputManager()
		{
			CrossPlatformInputManager.KOIJFMMEPDI = CrossPlatformInputManager.GJFDMIIAKAF;
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x00237CA6 File Offset: 0x00235EA6
		public static void SwitchActiveInputMethod(CrossPlatformInputManager.ActiveInputMethod IGBDMBFCDMP)
		{
			if (IGBDMBFCDMP != CrossPlatformInputManager.ActiveInputMethod.Hardware)
			{
				if (IGBDMBFCDMP == CrossPlatformInputManager.ActiveInputMethod.Touch)
				{
					CrossPlatformInputManager.KOIJFMMEPDI = CrossPlatformInputManager.LJJFLGPPCNJ;
				}
			}
			else
			{
				CrossPlatformInputManager.KOIJFMMEPDI = CrossPlatformInputManager.GJFDMIIAKAF;
			}
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x00237CD8 File Offset: 0x00235ED8
		public static bool AxisExists(string EBEHBBDKDFJ)
		{
			return CrossPlatformInputManager.KOIJFMMEPDI.AxisExists(EBEHBBDKDFJ);
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x00237CE5 File Offset: 0x00235EE5
		public static bool ButtonExists(string EBEHBBDKDFJ)
		{
			return CrossPlatformInputManager.KOIJFMMEPDI.ButtonExists(EBEHBBDKDFJ);
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x00237CF2 File Offset: 0x00235EF2
		public static void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis NPBNCBFNBAF)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.RegisterVirtualAxis(NPBNCBFNBAF);
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x00237CFF File Offset: 0x00235EFF
		public static void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton NACBMIFLLEK)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.RegisterVirtualButton(NACBMIFLLEK);
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x00237D0C File Offset: 0x00235F0C
		public static void UnRegisterVirtualAxis(string EBEHBBDKDFJ)
		{
			if (EBEHBBDKDFJ == null)
			{
				throw new ArgumentNullException("name");
			}
			CrossPlatformInputManager.KOIJFMMEPDI.UnRegisterVirtualAxis(EBEHBBDKDFJ);
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x00237D2A File Offset: 0x00235F2A
		public static void UnRegisterVirtualButton(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.UnRegisterVirtualButton(EBEHBBDKDFJ);
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x00237D37 File Offset: 0x00235F37
		public static CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string EBEHBBDKDFJ)
		{
			return CrossPlatformInputManager.KOIJFMMEPDI.VirtualAxisReference(EBEHBBDKDFJ);
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x00237D44 File Offset: 0x00235F44
		public static float GetAxis(string EBEHBBDKDFJ)
		{
			return CrossPlatformInputManager.ACAAPGJOABC(EBEHBBDKDFJ, false);
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x00237D4D File Offset: 0x00235F4D
		public static float GetAxisRaw(string EBEHBBDKDFJ)
		{
			return CrossPlatformInputManager.ACAAPGJOABC(EBEHBBDKDFJ, true);
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x00237D56 File Offset: 0x00235F56
		private static float ACAAPGJOABC(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			return CrossPlatformInputManager.KOIJFMMEPDI.GetAxis(EBEHBBDKDFJ, IBFFEGJDFNA);
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x00237D64 File Offset: 0x00235F64
		public static bool GetButton(string EBEHBBDKDFJ)
		{
			return CrossPlatformInputManager.KOIJFMMEPDI.GetButton(EBEHBBDKDFJ);
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x00237D71 File Offset: 0x00235F71
		public static bool GetButtonDown(string EBEHBBDKDFJ)
		{
			return CrossPlatformInputManager.KOIJFMMEPDI.GetButtonDown(EBEHBBDKDFJ);
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x00237D7E File Offset: 0x00235F7E
		public static bool GetButtonUp(string EBEHBBDKDFJ)
		{
			return CrossPlatformInputManager.KOIJFMMEPDI.GetButtonUp(EBEHBBDKDFJ);
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x00237D8B File Offset: 0x00235F8B
		public static void SetButtonDown(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.SetButtonDown(EBEHBBDKDFJ);
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x00237D98 File Offset: 0x00235F98
		public static void SetButtonUp(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.SetButtonUp(EBEHBBDKDFJ);
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x00237DA5 File Offset: 0x00235FA5
		public static void SetAxisPositive(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.SetAxisPositive(EBEHBBDKDFJ);
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x00237DB2 File Offset: 0x00235FB2
		public static void SetAxisNegative(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.SetAxisNegative(EBEHBBDKDFJ);
		}

		// Token: 0x0600724E RID: 29262 RVA: 0x00237DBF File Offset: 0x00235FBF
		public static void SetAxisZero(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.SetAxisZero(EBEHBBDKDFJ);
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00237DCC File Offset: 0x00235FCC
		public static void SetAxis(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.SetAxis(EBEHBBDKDFJ, DPNHODJHGJL);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06007250 RID: 29264 RVA: 0x00237DDA File Offset: 0x00235FDA
		public static Vector3 mousePosition
		{
			get
			{
				return CrossPlatformInputManager.KOIJFMMEPDI.MousePosition();
			}
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x00237DE6 File Offset: 0x00235FE6
		public static void SetVirtualMousePositionX(float HBJIMONFKNL)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.SetVirtualMousePositionX(HBJIMONFKNL);
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x00237DF3 File Offset: 0x00235FF3
		public static void SetVirtualMousePositionY(float HBJIMONFKNL)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.SetVirtualMousePositionY(HBJIMONFKNL);
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00237E00 File Offset: 0x00236000
		public static void SetVirtualMousePositionZ(float HBJIMONFKNL)
		{
			CrossPlatformInputManager.KOIJFMMEPDI.SetVirtualMousePositionZ(HBJIMONFKNL);
		}

		// Token: 0x04000B95 RID: 2965
		private static VirtualInput KOIJFMMEPDI;

		// Token: 0x04000B96 RID: 2966
		private static VirtualInput LJJFLGPPCNJ = new MobileInput();

		// Token: 0x04000B97 RID: 2967
		private static VirtualInput GJFDMIIAKAF = new StandaloneInput();

		// Token: 0x02000184 RID: 388
		public enum ActiveInputMethod
		{
			// Token: 0x04000B99 RID: 2969
			Hardware,
			// Token: 0x04000B9A RID: 2970
			Touch
		}

		// Token: 0x02000185 RID: 389
		public class VirtualAxis
		{
			// Token: 0x17000146 RID: 326
			// (get) Token: 0x06007254 RID: 29268 RVA: 0x00237E0D File Offset: 0x0023600D
			public float GetValueRaw
			{
				get
				{
					return this.DOBFMEJECBI;
				}
			}

			// Token: 0x06007255 RID: 29269 RVA: 0x00237E15 File Offset: 0x00236015
			public void LCAAPKEOIMI()
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.name);
			}

			// Token: 0x06007256 RID: 29270 RVA: 0x00237E22 File Offset: 0x00236022
			private void OMLNMHEBOPK(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x06007257 RID: 29271 RVA: 0x00237E22 File Offset: 0x00236022
			private void KCLAKEMOAIB(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x06007258 RID: 29272 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool ICEBLLCEGPN()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x06007259 RID: 29273 RVA: 0x00237E0D File Offset: 0x0023600D
			public float MOMIHHIMFCE()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x0600725A RID: 29274 RVA: 0x00237E33 File Offset: 0x00236033
			public string FJILPMMKGOA()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x0600725B RID: 29275 RVA: 0x00237E3B File Offset: 0x0023603B
			public void KHPOJPKOEJP()
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.MKBJNAPKDFB());
			}

			// Token: 0x0600725C RID: 29276 RVA: 0x00237E33 File Offset: 0x00236033
			public string AKMGEIPGOEF()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x0600725D RID: 29277 RVA: 0x00237E0D File Offset: 0x0023600D
			public float EELFPMNKKNN()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x0600725E RID: 29278 RVA: 0x00237E33 File Offset: 0x00236033
			public string PKGOBHOENBN()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x0600725F RID: 29279 RVA: 0x00237E0D File Offset: 0x0023600D
			public float ODIKCOGLFLN()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x06007260 RID: 29280 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool OBPBFPKMBBE()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x06007261 RID: 29281 RVA: 0x00237E0D File Offset: 0x0023600D
			public float NPHNIDDOGDI()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x06007262 RID: 29282 RVA: 0x00237E48 File Offset: 0x00236048
			public VirtualAxis(string EBEHBBDKDFJ, bool OGKNLINFENB)
			{
				this.name = EBEHBBDKDFJ;
				this.matchWithInputManager = OGKNLINFENB;
			}

			// Token: 0x06007263 RID: 29283 RVA: 0x00237E5E File Offset: 0x0023605E
			public void Update(float DPNHODJHGJL)
			{
				this.DOBFMEJECBI = DPNHODJHGJL;
			}

			// Token: 0x06007264 RID: 29284 RVA: 0x00237E0D File Offset: 0x0023600D
			public float BEBAEPPOHEG()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x06007265 RID: 29285 RVA: 0x00237E67 File Offset: 0x00236067
			public void FAJPCAIIKHF()
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.MLIGBALKGCF());
			}

			// Token: 0x06007266 RID: 29286 RVA: 0x00237E0D File Offset: 0x0023600D
			public float CKMJENEJODB()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06007267 RID: 29287 RVA: 0x00237E33 File Offset: 0x00236033
			// (set) Token: 0x06007280 RID: 29312 RVA: 0x00237E22 File Offset: 0x00236022
			public string name { get; private set; }

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x06007291 RID: 29329 RVA: 0x00237E2B File Offset: 0x0023602B
			// (set) Token: 0x06007268 RID: 29288 RVA: 0x00237E74 File Offset: 0x00236074
			public bool matchWithInputManager { get; private set; }

			// Token: 0x06007269 RID: 29289 RVA: 0x00237E7D File Offset: 0x0023607D
			public VirtualAxis(string EBEHBBDKDFJ) : this(EBEHBBDKDFJ, true)
			{
			}

			// Token: 0x0600726A RID: 29290 RVA: 0x00237E5E File Offset: 0x0023605E
			public void JDGFCEPDKAJ(float DPNHODJHGJL)
			{
				this.DOBFMEJECBI = DPNHODJHGJL;
			}

			// Token: 0x0600726B RID: 29291 RVA: 0x00237E22 File Offset: 0x00236022
			private void ICHDCGHJCFN(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x0600726C RID: 29292 RVA: 0x00237E74 File Offset: 0x00236074
			private void HMEANCEBMFL(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x0600726D RID: 29293 RVA: 0x00237E5E File Offset: 0x0023605E
			public void LLJLDLLNFBH(float DPNHODJHGJL)
			{
				this.DOBFMEJECBI = DPNHODJHGJL;
			}

			// Token: 0x0600726E RID: 29294 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool FOBAJFPDFJI()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x0600726F RID: 29295 RVA: 0x00237E0D File Offset: 0x0023600D
			public float DEIHPCMEHBO()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x06007270 RID: 29296 RVA: 0x00237E22 File Offset: 0x00236022
			private void GBOPDJEDJDA(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x06007271 RID: 29297 RVA: 0x00237E0D File Offset: 0x0023600D
			public float BHIEDEMLNNB()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x06007272 RID: 29298 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool LJEIANFLOCK()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x06007273 RID: 29299 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool HFBBBHDEDNM()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x06007274 RID: 29300 RVA: 0x00237E0D File Offset: 0x0023600D
			public float LIILIMDGNMH()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x06007275 RID: 29301 RVA: 0x00237E74 File Offset: 0x00236074
			private void LMJCPCJJOHF(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x06007276 RID: 29302 RVA: 0x00237E15 File Offset: 0x00236015
			public void Remove()
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.name);
			}

			// Token: 0x06007277 RID: 29303 RVA: 0x00237E87 File Offset: 0x00236087
			public void HPFNAMAOKLC()
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.FJILPMMKGOA());
			}

			// Token: 0x06007278 RID: 29304 RVA: 0x00237E33 File Offset: 0x00236033
			public string GGPGMDEPNLA()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x06007279 RID: 29305 RVA: 0x00237E74 File Offset: 0x00236074
			private void CNFACGMLBNB(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x0600727A RID: 29306 RVA: 0x00237E5E File Offset: 0x0023605E
			public void IBHACCEEFFI(float DPNHODJHGJL)
			{
				this.DOBFMEJECBI = DPNHODJHGJL;
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x0600727B RID: 29307 RVA: 0x00237E0D File Offset: 0x0023600D
			public float GetValue
			{
				get
				{
					return this.DOBFMEJECBI;
				}
			}

			// Token: 0x0600727C RID: 29308 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool AHIJKMANBDP()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x0600727D RID: 29309 RVA: 0x00237E5E File Offset: 0x0023605E
			public void NKLIHNJCHOG(float DPNHODJHGJL)
			{
				this.DOBFMEJECBI = DPNHODJHGJL;
			}

			// Token: 0x0600727E RID: 29310 RVA: 0x00237E0D File Offset: 0x0023600D
			public float ADGPGPJICDG()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x0600727F RID: 29311 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool BDOFGDCMAHF()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x06007281 RID: 29313 RVA: 0x00237E74 File Offset: 0x00236074
			private void KCOJAAMLHEL(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x06007282 RID: 29314 RVA: 0x00237E33 File Offset: 0x00236033
			public string DPGOJAHONLO()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x06007283 RID: 29315 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool PHDNONPONMC()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x06007284 RID: 29316 RVA: 0x00237E33 File Offset: 0x00236033
			public string MKBJNAPKDFB()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x06007285 RID: 29317 RVA: 0x00237E33 File Offset: 0x00236033
			public string AHLIEDMHOIE()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x06007286 RID: 29318 RVA: 0x00237E94 File Offset: 0x00236094
			public void HKBINDMJGFJ()
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.FBNKCHBOGIH());
			}

			// Token: 0x06007287 RID: 29319 RVA: 0x00237E33 File Offset: 0x00236033
			public string PLHFPGGEFFD()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x06007288 RID: 29320 RVA: 0x00237E74 File Offset: 0x00236074
			private void JPJJFNPAELJ(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x06007289 RID: 29321 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool KAEAPEOFJNI()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x0600728A RID: 29322 RVA: 0x00237E22 File Offset: 0x00236022
			private void BECALLBICNF(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x0600728B RID: 29323 RVA: 0x00237E22 File Offset: 0x00236022
			private void PIHEAOADFPF(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x0600728C RID: 29324 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool DNHEPAGGBMP()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x0600728D RID: 29325 RVA: 0x00237E33 File Offset: 0x00236033
			public string OKFFDKOAGJL()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x0600728E RID: 29326 RVA: 0x00237E74 File Offset: 0x00236074
			private void PJODPDOPHNP(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x0600728F RID: 29327 RVA: 0x00237E5E File Offset: 0x0023605E
			public void BGFJOEPFOPM(float DPNHODJHGJL)
			{
				this.DOBFMEJECBI = DPNHODJHGJL;
			}

			// Token: 0x06007290 RID: 29328 RVA: 0x00237E33 File Offset: 0x00236033
			public string FBNKCHBOGIH()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x06007292 RID: 29330 RVA: 0x00237E5E File Offset: 0x0023605E
			public void FOMNCPKKCFN(float DPNHODJHGJL)
			{
				this.DOBFMEJECBI = DPNHODJHGJL;
			}

			// Token: 0x06007293 RID: 29331 RVA: 0x00237E5E File Offset: 0x0023605E
			public void JNBPKNNBMDI(float DPNHODJHGJL)
			{
				this.DOBFMEJECBI = DPNHODJHGJL;
			}

			// Token: 0x06007294 RID: 29332 RVA: 0x00237E0D File Offset: 0x0023600D
			public float LBKDMGKJAJJ()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x06007295 RID: 29333 RVA: 0x00237E0D File Offset: 0x0023600D
			public float NMACMHAONFI()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x06007296 RID: 29334 RVA: 0x00237E2B File Offset: 0x0023602B
			public bool LPNMKNOIENE()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x06007297 RID: 29335 RVA: 0x00237E0D File Offset: 0x0023600D
			public float HHBDOCNHMNH()
			{
				return this.DOBFMEJECBI;
			}

			// Token: 0x06007298 RID: 29336 RVA: 0x00237EA1 File Offset: 0x002360A1
			public void OIGFKCBEMLN()
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.AODIDBMFBDJ());
			}

			// Token: 0x06007299 RID: 29337 RVA: 0x00237E74 File Offset: 0x00236074
			private void ODEIBDONLME(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x0600729A RID: 29338 RVA: 0x00237E5E File Offset: 0x0023605E
			public void NDAJBJFJGCF(float DPNHODJHGJL)
			{
				this.DOBFMEJECBI = DPNHODJHGJL;
			}

			// Token: 0x0600729B RID: 29339 RVA: 0x00237E33 File Offset: 0x00236033
			public string AODIDBMFBDJ()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x0600729C RID: 29340 RVA: 0x00237E22 File Offset: 0x00236022
			private void HJOFMCJGAFD(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x0600729D RID: 29341 RVA: 0x00237EAE File Offset: 0x002360AE
			public void JJPCNFLGLDL()
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.DPGOJAHONLO());
			}

			// Token: 0x0600729E RID: 29342 RVA: 0x00237E33 File Offset: 0x00236033
			public string MLIGBALKGCF()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x04000B9C RID: 2972
			private float DOBFMEJECBI;
		}

		// Token: 0x02000186 RID: 390
		public class VirtualButton
		{
			// Token: 0x0600729F RID: 29343 RVA: 0x00237EBB File Offset: 0x002360BB
			public string NJHMCLPHDAI()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x060072A0 RID: 29344 RVA: 0x00237EC3 File Offset: 0x002360C3
			public void JLIOOPBKFIL()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = true;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072A1 RID: 29345 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void FBCEIIHLCMD(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072A2 RID: 29346 RVA: 0x00237EEC File Offset: 0x002360EC
			public void AEFEJCAACFJ()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = false;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072A3 RID: 29347 RVA: 0x00237F0C File Offset: 0x0023610C
			private void OMLNMHEBOPK(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072A4 RID: 29348 RVA: 0x00237F15 File Offset: 0x00236115
			public void JBDICEAGNCM()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.PNEFCDGNLJA());
			}

			// Token: 0x060072A5 RID: 29349 RVA: 0x00237EBB File Offset: 0x002360BB
			public string ENKGOIFGOCK()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x060072A6 RID: 29350 RVA: 0x00237F22 File Offset: 0x00236122
			public void AFIJKLKEGEJ()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.IBJGCBCCMJC());
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060072A7 RID: 29351 RVA: 0x00237EBB File Offset: 0x002360BB
			// (set) Token: 0x060072E1 RID: 29409 RVA: 0x00237F0C File Offset: 0x0023610C
			public string name { get; private set; }

			// Token: 0x060072A8 RID: 29352 RVA: 0x00237F0C File Offset: 0x0023610C
			private void MKAHFDKCFHB(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072A9 RID: 29353 RVA: 0x00237F2F File Offset: 0x0023612F
			public bool DBGAEKIIMGK()
			{
				return this.AJIDJEEJLBD;
			}

			// Token: 0x060072AA RID: 29354 RVA: 0x00237EC3 File Offset: 0x002360C3
			public void IDOKGPNBJBG()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = true;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072AB RID: 29355 RVA: 0x00237F37 File Offset: 0x00236137
			public void NKINFKJBCJA()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.ENKGOIFGOCK());
			}

			// Token: 0x060072AC RID: 29356 RVA: 0x00237F44 File Offset: 0x00236144
			public bool FEHPDDIECMK()
			{
				return this.AOGBIDFCKEP == Time.frameCount - 1;
			}

			// Token: 0x060072AD RID: 29357 RVA: 0x00237F44 File Offset: 0x00236144
			public bool LNJGMIGLICB()
			{
				return this.AOGBIDFCKEP == Time.frameCount - 1;
			}

			// Token: 0x060072AE RID: 29358 RVA: 0x00237F55 File Offset: 0x00236155
			public bool PHDNONPONMC()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x060072AF RID: 29359 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool DBOEEGIEDFA()
			{
				return this.ACNJFLPMICC - Time.frameCount == -1;
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060072B0 RID: 29360 RVA: 0x00237F44 File Offset: 0x00236144
			public bool GetButtonUp
			{
				get
				{
					return this.AOGBIDFCKEP == Time.frameCount - 1;
				}
			}

			// Token: 0x060072B1 RID: 29361 RVA: 0x00237F44 File Offset: 0x00236144
			public bool DNFBINHIDPH()
			{
				return this.AOGBIDFCKEP == Time.frameCount - 1;
			}

			// Token: 0x060072B2 RID: 29362 RVA: 0x00237F0C File Offset: 0x0023610C
			private void EKHIHEIJJKC(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072B3 RID: 29363 RVA: 0x00237F44 File Offset: 0x00236144
			public bool AFHPDJEPPID()
			{
				return this.AOGBIDFCKEP == Time.frameCount - 1;
			}

			// Token: 0x060072B4 RID: 29364 RVA: 0x00237F6E File Offset: 0x0023616E
			public void HFFEFJELMEH()
			{
				this.AJIDJEEJLBD = true;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x060072B5 RID: 29365 RVA: 0x00237F2F File Offset: 0x0023612F
			public bool LGLADBKNNKJ()
			{
				return this.AJIDJEEJLBD;
			}

			// Token: 0x060072B6 RID: 29366 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool AHOEEDLKCKE()
			{
				return this.ACNJFLPMICC - Time.frameCount == -1;
			}

			// Token: 0x060072B7 RID: 29367 RVA: 0x00237EEC File Offset: 0x002360EC
			public void GANPFLLEKEJ()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = false;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072B8 RID: 29368 RVA: 0x00237F55 File Offset: 0x00236155
			public bool IDIEAICPBBL()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x060072B9 RID: 29369 RVA: 0x00237F6E File Offset: 0x0023616E
			public void JIEDIPAIPAD()
			{
				this.AJIDJEEJLBD = true;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x060072BA RID: 29370 RVA: 0x00237EBB File Offset: 0x002360BB
			public string OAHNELNLIHO()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x060072BB RID: 29371 RVA: 0x00237F2F File Offset: 0x0023612F
			public bool LPBMODOPDOI()
			{
				return this.AJIDJEEJLBD;
			}

			// Token: 0x060072BC RID: 29372 RVA: 0x00237EBB File Offset: 0x002360BB
			public string FNHKGEOOLKL()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x060072BD RID: 29373 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void PCBDFADOPNL(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072BE RID: 29374 RVA: 0x00237F82 File Offset: 0x00236182
			public void Remove()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.name);
			}

			// Token: 0x060072BF RID: 29375 RVA: 0x00237F8F File Offset: 0x0023618F
			public void EKAAMBFENNM()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.OAHNELNLIHO());
			}

			// Token: 0x060072C0 RID: 29376 RVA: 0x00237F55 File Offset: 0x00236155
			public bool PGNEMDJNMNP()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x060072C1 RID: 29377 RVA: 0x00237F0C File Offset: 0x0023610C
			private void LIFIGAILIFN(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072C2 RID: 29378 RVA: 0x00237F22 File Offset: 0x00236122
			public void FFBIHFFKPEL()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.IBJGCBCCMJC());
			}

			// Token: 0x060072C3 RID: 29379 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void MIBNNHCNCLJ(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072C4 RID: 29380 RVA: 0x00237F9C File Offset: 0x0023619C
			public VirtualButton(string EBEHBBDKDFJ) : this(EBEHBBDKDFJ, true)
			{
			}

			// Token: 0x060072C5 RID: 29381 RVA: 0x00237F0C File Offset: 0x0023610C
			private void GIAPMNMLIMM(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072C6 RID: 29382 RVA: 0x00237FA6 File Offset: 0x002361A6
			public void IJOHLMNMBBO()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.NHFKPEIGHHB());
			}

			// Token: 0x060072C7 RID: 29383 RVA: 0x00237EC3 File Offset: 0x002360C3
			public void JJNMCNPKDCA()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = true;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072C8 RID: 29384 RVA: 0x00237F55 File Offset: 0x00236155
			public bool NLJOCANKDHP()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x060072C9 RID: 29385 RVA: 0x00237EBB File Offset: 0x002360BB
			public string GNCEGDEEMOA()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x060072CA RID: 29386 RVA: 0x00237FB3 File Offset: 0x002361B3
			public VirtualButton(string EBEHBBDKDFJ, bool OGKNLINFENB)
			{
				this.name = EBEHBBDKDFJ;
				this.matchWithInputManager = OGKNLINFENB;
			}

			// Token: 0x060072CB RID: 29387 RVA: 0x00237F55 File Offset: 0x00236155
			public bool CMFGFBMGCEO()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x060072CC RID: 29388 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool GetButtonDown
			{
				get
				{
					return this.ACNJFLPMICC - Time.frameCount == -1;
				}
			}

			// Token: 0x060072CD RID: 29389 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool LMIDFLOKIJD()
			{
				return this.ACNJFLPMICC - Time.frameCount == -1;
			}

			// Token: 0x060072CE RID: 29390 RVA: 0x00237F2F File Offset: 0x0023612F
			public bool KEEEMAGCDNN()
			{
				return this.AJIDJEEJLBD;
			}

			// Token: 0x060072CF RID: 29391 RVA: 0x00237EBB File Offset: 0x002360BB
			public string PNEFCDGNLJA()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x060072D0 RID: 29392 RVA: 0x00237FD9 File Offset: 0x002361D9
			public void FJHPAHEDLKC()
			{
				this.AJIDJEEJLBD = false;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x060072D1 RID: 29393 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void ELOAGAJPOJC(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072D2 RID: 29394 RVA: 0x00237EBB File Offset: 0x002360BB
			public string HBLACMCHNMB()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x060072D3 RID: 29395 RVA: 0x00237F55 File Offset: 0x00236155
			public bool JCAIPJIOLFK()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x060072D4 RID: 29396 RVA: 0x00237F55 File Offset: 0x00236155
			public bool BNGBCNADGPC()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x060072D5 RID: 29397 RVA: 0x00237FD9 File Offset: 0x002361D9
			public void IIIGIGNJJAF()
			{
				this.AJIDJEEJLBD = false;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x060072D6 RID: 29398 RVA: 0x00237EEC File Offset: 0x002360EC
			public void LJMIPFBAPAD()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = false;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072D7 RID: 29399 RVA: 0x00237F44 File Offset: 0x00236144
			public bool KHGNLNPEFKE()
			{
				return this.AOGBIDFCKEP == Time.frameCount - 1;
			}

			// Token: 0x060072D8 RID: 29400 RVA: 0x00237F6E File Offset: 0x0023616E
			public void NGMFKBJPCME()
			{
				this.AJIDJEEJLBD = true;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x060072D9 RID: 29401 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void HAOGNINJFHH(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072DA RID: 29402 RVA: 0x00237F2F File Offset: 0x0023612F
			public bool MLGMIAFKGIH()
			{
				return this.AJIDJEEJLBD;
			}

			// Token: 0x060072DB RID: 29403 RVA: 0x00237F8F File Offset: 0x0023618F
			public void IOFAKOJHMGA()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.OAHNELNLIHO());
			}

			// Token: 0x060072DC RID: 29404 RVA: 0x00237EBB File Offset: 0x002360BB
			public string IBJGCBCCMJC()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x060072DD RID: 29405 RVA: 0x00237EEC File Offset: 0x002360EC
			public void DOHIMHJFIMH()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = false;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072DE RID: 29406 RVA: 0x00237FED File Offset: 0x002361ED
			public void JJPCNFLGLDL()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.FJGONAPHLIP());
			}

			// Token: 0x060072DF RID: 29407 RVA: 0x00237F0C File Offset: 0x0023610C
			private void NDJKGMJLLOB(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072E0 RID: 29408 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void ADBLMLIAPMO(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072E2 RID: 29410 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool NFNPHICBDMI()
			{
				return this.ACNJFLPMICC - Time.frameCount == -1;
			}

			// Token: 0x060072E3 RID: 29411 RVA: 0x00237EC3 File Offset: 0x002360C3
			public void Pressed()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = true;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072E4 RID: 29412 RVA: 0x00237F44 File Offset: 0x00236144
			public bool APIBFBMFKHH()
			{
				return this.AOGBIDFCKEP == Time.frameCount - 1;
			}

			// Token: 0x060072E5 RID: 29413 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool HBCEJLBNMKP()
			{
				return this.ACNJFLPMICC - Time.frameCount == -1;
			}

			// Token: 0x060072E6 RID: 29414 RVA: 0x00237FD9 File Offset: 0x002361D9
			public void HHOEHMPIPGD()
			{
				this.AJIDJEEJLBD = false;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x060072E7 RID: 29415 RVA: 0x00237F6E File Offset: 0x0023616E
			public void NNCGKGKFBAL()
			{
				this.AJIDJEEJLBD = true;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x060072E8 RID: 29416 RVA: 0x00237EC3 File Offset: 0x002360C3
			public void JJEINPPFEKI()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = true;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072E9 RID: 29417 RVA: 0x00237F0C File Offset: 0x0023610C
			private void BMELPPMKFMI(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072EA RID: 29418 RVA: 0x00237F44 File Offset: 0x00236144
			public bool HBKFKJHFABP()
			{
				return this.AOGBIDFCKEP == Time.frameCount - 1;
			}

			// Token: 0x060072EB RID: 29419 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void MDPAJLEEDLD(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072EC RID: 29420 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void DKLOEEOCFEP(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072ED RID: 29421 RVA: 0x00237EEC File Offset: 0x002360EC
			public void AHOIEDPGMPE()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = false;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072EE RID: 29422 RVA: 0x00237EC3 File Offset: 0x002360C3
			public void DCILAIKBLMC()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = true;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072EF RID: 29423 RVA: 0x00237FFA File Offset: 0x002361FA
			public void PNFFHJPMCPJ()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.GEJFHBNKAKK());
			}

			// Token: 0x060072F0 RID: 29424 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool ANBNOCFFCGN()
			{
				return this.ACNJFLPMICC - Time.frameCount == -1;
			}

			// Token: 0x060072F1 RID: 29425 RVA: 0x00238007 File Offset: 0x00236207
			public void KLPEIGGAOBH()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.NJHMCLPHDAI());
			}

			// Token: 0x060072F2 RID: 29426 RVA: 0x00237F0C File Offset: 0x0023610C
			private void DNCEMDGBHCD(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072F3 RID: 29427 RVA: 0x00237F55 File Offset: 0x00236155
			public bool PKIPLHDHOCF()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x060072F4 RID: 29428 RVA: 0x00237F6E File Offset: 0x0023616E
			public void FLGMNKODIGN()
			{
				this.AJIDJEEJLBD = true;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060072F5 RID: 29429 RVA: 0x00237F2F File Offset: 0x0023612F
			public bool GetButton
			{
				get
				{
					return this.AJIDJEEJLBD;
				}
			}

			// Token: 0x060072F6 RID: 29430 RVA: 0x00237EC3 File Offset: 0x002360C3
			public void NCHONCDANGN()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = true;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072F7 RID: 29431 RVA: 0x00237EBB File Offset: 0x002360BB
			public string FJGONAPHLIP()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x0600730F RID: 29455 RVA: 0x00237F55 File Offset: 0x00236155
			// (set) Token: 0x060072F8 RID: 29432 RVA: 0x00237EE3 File Offset: 0x002360E3
			public bool matchWithInputManager { get; private set; }

			// Token: 0x060072F9 RID: 29433 RVA: 0x00237F2F File Offset: 0x0023612F
			public bool FDBNBGAAIAF()
			{
				return this.AJIDJEEJLBD;
			}

			// Token: 0x060072FA RID: 29434 RVA: 0x00237EC3 File Offset: 0x002360C3
			public void GKIJFMLOKPA()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = true;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x060072FB RID: 29435 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void POMNCDLCDPI(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x060072FC RID: 29436 RVA: 0x00238014 File Offset: 0x00236214
			public bool MJEAFFHODKE()
			{
				return this.AOGBIDFCKEP == Time.frameCount - 0;
			}

			// Token: 0x060072FD RID: 29437 RVA: 0x00237F8F File Offset: 0x0023618F
			public void LCOHKDBLJBH()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.OAHNELNLIHO());
			}

			// Token: 0x060072FE RID: 29438 RVA: 0x00238025 File Offset: 0x00236225
			public void FDLPPICPLAD()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.FNHKGEOOLKL());
			}

			// Token: 0x060072FF RID: 29439 RVA: 0x00237F44 File Offset: 0x00236144
			public bool OANKMFCCJOM()
			{
				return this.AOGBIDFCKEP == Time.frameCount - 1;
			}

			// Token: 0x06007300 RID: 29440 RVA: 0x00237EBB File Offset: 0x002360BB
			public string NHFKPEIGHHB()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x06007301 RID: 29441 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool KHENAAAJJNP()
			{
				return this.ACNJFLPMICC - Time.frameCount == -1;
			}

			// Token: 0x06007302 RID: 29442 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void FGBHNPFNHLA(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x06007303 RID: 29443 RVA: 0x00237FD9 File Offset: 0x002361D9
			public void GBANPAGMLOP()
			{
				this.AJIDJEEJLBD = false;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x06007304 RID: 29444 RVA: 0x00237EE3 File Offset: 0x002360E3
			private void EDKACHLDGFD(bool DPNHODJHGJL)
			{
				this.<DJIEECPANAK>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x06007305 RID: 29445 RVA: 0x00237F2F File Offset: 0x0023612F
			public bool EODBJNNEHJM()
			{
				return this.AJIDJEEJLBD;
			}

			// Token: 0x06007306 RID: 29446 RVA: 0x00237F15 File Offset: 0x00236115
			public void OIGFKCBEMLN()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.PNEFCDGNLJA());
			}

			// Token: 0x06007307 RID: 29447 RVA: 0x00237FD9 File Offset: 0x002361D9
			public void IAKOCGPNHJM()
			{
				this.AJIDJEEJLBD = false;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x06007308 RID: 29448 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool DAPDDIKKCOC()
			{
				return this.ACNJFLPMICC - Time.frameCount == -1;
			}

			// Token: 0x06007309 RID: 29449 RVA: 0x00237F6E File Offset: 0x0023616E
			public void IBICLKIGNLA()
			{
				this.AJIDJEEJLBD = true;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x0600730A RID: 29450 RVA: 0x00237FA6 File Offset: 0x002361A6
			public void PABDAJGGKNL()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.NHFKPEIGHHB());
			}

			// Token: 0x0600730B RID: 29451 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool DJIJNCPMLCB()
			{
				return this.ACNJFLPMICC - Time.frameCount == -1;
			}

			// Token: 0x0600730C RID: 29452 RVA: 0x00237F55 File Offset: 0x00236155
			public bool OGEEKAIIDFA()
			{
				return this.<DJIEECPANAK>k__BackingField;
			}

			// Token: 0x0600730D RID: 29453 RVA: 0x00237FD9 File Offset: 0x002361D9
			public void Released()
			{
				this.AJIDJEEJLBD = false;
				this.AOGBIDFCKEP = Time.frameCount;
			}

			// Token: 0x0600730E RID: 29454 RVA: 0x00237F5D File Offset: 0x0023615D
			public bool LNGKNGOABBN()
			{
				return this.ACNJFLPMICC - Time.frameCount == -1;
			}

			// Token: 0x06007310 RID: 29456 RVA: 0x00237EEC File Offset: 0x002360EC
			public void NKCDGPBMKDM()
			{
				if (this.AJIDJEEJLBD)
				{
					return;
				}
				this.AJIDJEEJLBD = false;
				this.ACNJFLPMICC = Time.frameCount;
			}

			// Token: 0x06007311 RID: 29457 RVA: 0x00237F44 File Offset: 0x00236144
			public bool CGJFHOGCEOA()
			{
				return this.AOGBIDFCKEP == Time.frameCount - 1;
			}

			// Token: 0x06007312 RID: 29458 RVA: 0x00237EBB File Offset: 0x002360BB
			public string GEJFHBNKAKK()
			{
				return this.<ABFPNNINPGB>k__BackingField;
			}

			// Token: 0x06007313 RID: 29459 RVA: 0x00237F0C File Offset: 0x0023610C
			private void DGKLNDOAAPO(string DPNHODJHGJL)
			{
				this.<ABFPNNINPGB>k__BackingField = DPNHODJHGJL;
			}

			// Token: 0x06007314 RID: 29460 RVA: 0x00237F82 File Offset: 0x00236182
			public void FCPOHOGELHJ()
			{
				CrossPlatformInputManager.UnRegisterVirtualButton(this.name);
			}

			// Token: 0x04000BA0 RID: 2976
			private int ACNJFLPMICC = -5;

			// Token: 0x04000BA1 RID: 2977
			private int AOGBIDFCKEP = -5;

			// Token: 0x04000BA2 RID: 2978
			private bool AJIDJEEJLBD;
		}
	}
}
