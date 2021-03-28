using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200019A RID: 410
	[AddComponentMenu("Image Effects/Cinematic/Anti-aliasing")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class AntiAliasing : MonoBehaviour
	{
		// Token: 0x0600754E RID: 30030 RVA: 0x0023F48E File Offset: 0x0023D68E
		private void PLBOFEPBPKC()
		{
			this.m_SMAA.DPFOEBCADNP();
			this.m_FXAA.OnDisable();
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x0023F4A6 File Offset: 0x0023D6A6
		private void BAJBKAHCJJK()
		{
			this.ONLEEJHJPMJ().OnPreCull(this.EFLBLMMIDMJ());
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x0023F4B9 File Offset: 0x0023D6B9
		private void IDKPHKOCOLD()
		{
			this.m_SMAA.MLLPGPANCHI(this);
			this.m_FXAA.OnEnable(this);
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera PLOCEKNJIHL()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera OPMKECFDFAN()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06007553 RID: 30035 RVA: 0x0023F4F8 File Offset: 0x0023D6F8
		private void JNLADMPFFCB()
		{
			this.DCIPCPGMMFM().OnPostRender(this.OPMKECFDFAN());
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x0023F50B File Offset: 0x0023D70B
		private void FGOPJMGNHGO()
		{
			this.m_SMAA.PLIKADJCEPO();
			this.m_FXAA.NJHJHBOJKIC();
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x0023F523 File Offset: 0x0023D723
		private void MHDGCELMFHH()
		{
			this.CFKPIPLLKIL().OnPostRender(this.HLGLACJPJIJ());
		}

		// Token: 0x06007556 RID: 30038 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera HFBKPEHGMBJ()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06007557 RID: 30039 RVA: 0x0023F536 File Offset: 0x0023D736
		// (set) Token: 0x0600755A RID: 30042 RVA: 0x0023F558 File Offset: 0x0023D758
		public int method
		{
			get
			{
				return this.m_Method;
			}
			set
			{
				if (this.m_Method == value)
				{
					return;
				}
				this.m_Method = value;
			}
		}

		// Token: 0x06007558 RID: 30040 RVA: 0x0023F53E File Offset: 0x0023D73E
		private void FDIJLKIIMLL()
		{
			this.m_SMAA.LHGFCBDACBM(this);
			this.m_FXAA.JBBCMAJIMCA(this);
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera BEOLNDPBCFH()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x0023F56E File Offset: 0x0023D76E
		private void IEJCEFENLOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.MEEBNCDKBEK().OnRenderImage(this.LDGPHNNCHNP(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x0600755C RID: 30044 RVA: 0x0023F583 File Offset: 0x0023D783
		private void OnPreCull()
		{
			this.current.OnPreCull(this.cameraComponent);
		}

		// Token: 0x0600755D RID: 30045 RVA: 0x0023F596 File Offset: 0x0023D796
		public IAntiAliasing APJHPMBGNMC()
		{
			if (this.OKNKJNLHBIF() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x0600755E RID: 30046 RVA: 0x0023F5B0 File Offset: 0x0023D7B0
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.current.OnRenderImage(this.cameraComponent, HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x0600755F RID: 30047 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera BKFGPNLLBOA()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x0023F5C5 File Offset: 0x0023D7C5
		public IAntiAliasing ONLEEJHJPMJ()
		{
			if (this.MBNKFMKMOPO() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x0023F5DF File Offset: 0x0023D7DF
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.APJHPMBGNMC().OnRenderImage(this.BEOLNDPBCFH(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera HAOPDLCNBPL()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x0023F558 File Offset: 0x0023D758
		public void BCDFPMPINCE(int DPNHODJHGJL)
		{
			if (this.m_Method == DPNHODJHGJL)
			{
				return;
			}
			this.m_Method = DPNHODJHGJL;
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera LDGPHNNCHNP()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x0023F5F4 File Offset: 0x0023D7F4
		private void OnDisable()
		{
			this.m_SMAA.OnDisable();
			this.m_FXAA.OnDisable();
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x0023F60C File Offset: 0x0023D80C
		private void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.CFKPIPLLKIL().OnRenderImage(this.HAOPDLCNBPL(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x06007567 RID: 30055 RVA: 0x0023F621 File Offset: 0x0023D821
		private void MPJCMKFFKHH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.CJPKGKCIJIM().OnRenderImage(this.AACCCOPEDDI(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x06007568 RID: 30056 RVA: 0x0023F636 File Offset: 0x0023D836
		private void PHJLHCMCCKE()
		{
			this.m_SMAA.OnDisable();
			this.m_FXAA.DLMPALHKMON();
		}

		// Token: 0x06007569 RID: 30057 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera MKGFHJNFKJP()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x0023F64E File Offset: 0x0023D84E
		private void HGJKBDGABKM()
		{
			this.m_SMAA.OnEnable(this);
			this.m_FXAA.LHGFCBDACBM(this);
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x0023F668 File Offset: 0x0023D868
		public IAntiAliasing OBAKBGOCHIA()
		{
			if (this.GCOECJEELAM() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x0023F558 File Offset: 0x0023D758
		public void AIFHFNNFHEE(int DPNHODJHGJL)
		{
			if (this.m_Method == DPNHODJHGJL)
			{
				return;
			}
			this.m_Method = DPNHODJHGJL;
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x0023F682 File Offset: 0x0023D882
		private void HAABAJAHEBF()
		{
			this.CFKPIPLLKIL().OnPreCull(this.PCNDAFPPGCB());
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x0023F695 File Offset: 0x0023D895
		private void CDCLDBFMKOG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.OBAKBGOCHIA().OnRenderImage(this.LDGPHNNCHNP(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x0023F6AA File Offset: 0x0023D8AA
		private void GBGAMCPNBCC()
		{
			this.m_SMAA.PLIKADJCEPO();
			this.m_FXAA.DLMPALHKMON();
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x0023F6C2 File Offset: 0x0023D8C2
		private void MDMDGKHDPKP()
		{
			this.m_SMAA.OnEnable(this);
			this.m_FXAA.LLDBPKHDPKI(this);
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x0023F5F4 File Offset: 0x0023D7F4
		private void FJIKDJAMOHA()
		{
			this.m_SMAA.OnDisable();
			this.m_FXAA.OnDisable();
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x0023F6DC File Offset: 0x0023D8DC
		private void ONAFNCDKEMD()
		{
			this.DCIPCPGMMFM().OnPostRender(this.PLOCEKNJIHL());
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x0023F558 File Offset: 0x0023D758
		public void NOKIOJDABIO(int DPNHODJHGJL)
		{
			if (this.m_Method == DPNHODJHGJL)
			{
				return;
			}
			this.m_Method = DPNHODJHGJL;
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x0023F536 File Offset: 0x0023D736
		public int NCNGLJPJAOM()
		{
			return this.m_Method;
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera AHMKMPKCHCD()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x0023F558 File Offset: 0x0023D758
		public void LOOACHKIBOI(int DPNHODJHGJL)
		{
			if (this.m_Method == DPNHODJHGJL)
			{
				return;
			}
			this.m_Method = DPNHODJHGJL;
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera PCNDAFPPGCB()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x0023F636 File Offset: 0x0023D836
		private void HLLHJIDOOGA()
		{
			this.m_SMAA.OnDisable();
			this.m_FXAA.DLMPALHKMON();
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x0023F536 File Offset: 0x0023D736
		public int MBNKFMKMOPO()
		{
			return this.m_Method;
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x0023F6AA File Offset: 0x0023D8AA
		private void BKGJOECFMID()
		{
			this.m_SMAA.PLIKADJCEPO();
			this.m_FXAA.DLMPALHKMON();
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x0023F6EF File Offset: 0x0023D8EF
		private void LPAHKJCIOKM()
		{
			this.APJHPMBGNMC().OnPostRender(this.HFBKPEHGMBJ());
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x0023F702 File Offset: 0x0023D902
		private void OIODCJBKMAP()
		{
			this.ONLEEJHJPMJ().OnPostRender(this.EFLBLMMIDMJ());
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x0023F536 File Offset: 0x0023D736
		public int HGBCHDHCOFL()
		{
			return this.m_Method;
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x0023F715 File Offset: 0x0023D915
		private void GHEAMPAKNBI()
		{
			this.MEEBNCDKBEK().OnPostRender(this.OPMKECFDFAN());
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x0023F558 File Offset: 0x0023D758
		public void HBIFKILBPFO(int DPNHODJHGJL)
		{
			if (this.m_Method == DPNHODJHGJL)
			{
				return;
			}
			this.m_Method = DPNHODJHGJL;
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera AACCCOPEDDI()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x0023F728 File Offset: 0x0023D928
		private void CJPACPMNIEB()
		{
			this.APJHPMBGNMC().OnPostRender(this.PLOCEKNJIHL());
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x0023F73B File Offset: 0x0023D93B
		public IAntiAliasing CJPKGKCIJIM()
		{
			if (this.NCNGLJPJAOM() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x0023F755 File Offset: 0x0023D955
		private void OnPostRender()
		{
			this.current.OnPostRender(this.cameraComponent);
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x0023F768 File Offset: 0x0023D968
		private void ABHEECINLJA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.OBAKBGOCHIA().OnRenderImage(this.PCNDAFPPGCB(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x0023F536 File Offset: 0x0023D736
		public int LEJABICCHML()
		{
			return this.m_Method;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06007586 RID: 30086 RVA: 0x0023F77D File Offset: 0x0023D97D
		public IAntiAliasing current
		{
			get
			{
				if (this.method == 0)
				{
					return this.m_SMAA;
				}
				return this.m_FXAA;
			}
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x0023F797 File Offset: 0x0023D997
		private void ELBCJPNKPCD()
		{
			this.ONLEEJHJPMJ().OnPreCull(this.HLGLACJPJIJ());
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x0023F7AA File Offset: 0x0023D9AA
		private void MCMMAKMIIDN()
		{
			this.DCIPCPGMMFM().OnPostRender(this.LDGPHNNCHNP());
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x0023F7BD File Offset: 0x0023D9BD
		private void BOLBPPHJBMI()
		{
			this.m_SMAA.OnDisable();
			this.m_FXAA.NJHJHBOJKIC();
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x0023F7F3 File Offset: 0x0023D9F3
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.OBAKBGOCHIA().OnRenderImage(this.KKOBMMPGLEO(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x0023F558 File Offset: 0x0023D758
		public void FEDKOFMOMFG(int DPNHODJHGJL)
		{
			if (this.m_Method == DPNHODJHGJL)
			{
				return;
			}
			this.m_Method = DPNHODJHGJL;
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x0023F558 File Offset: 0x0023D758
		public void ENGPKBAMLEG(int DPNHODJHGJL)
		{
			if (this.m_Method == DPNHODJHGJL)
			{
				return;
			}
			this.m_Method = DPNHODJHGJL;
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x0023F808 File Offset: 0x0023DA08
		private void JCCIHFMBFJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.CFKPIPLLKIL().OnRenderImage(this.PCNDAFPPGCB(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x0023F536 File Offset: 0x0023D736
		public int JCCMLJAKPPO()
		{
			return this.m_Method;
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x0023F536 File Offset: 0x0023D736
		public int GCOECJEELAM()
		{
			return this.m_Method;
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x0023F755 File Offset: 0x0023D955
		private void DFHHNBHJHLF()
		{
			this.current.OnPostRender(this.cameraComponent);
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x0023F81D File Offset: 0x0023DA1D
		private void NJOINKJBPLI()
		{
			this.MEEBNCDKBEK().OnPostRender(this.MKGFHJNFKJP());
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x0023F830 File Offset: 0x0023DA30
		private void PPGEGFMNIKO()
		{
			this.m_SMAA.LHGFCBDACBM(this);
			this.m_FXAA.LHGFCBDACBM(this);
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x0023F84A File Offset: 0x0023DA4A
		private void EDBEHEKMGFH()
		{
			this.m_SMAA.DPFOEBCADNP();
			this.m_FXAA.DLMPALHKMON();
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x0023F5C5 File Offset: 0x0023D7C5
		public IAntiAliasing MEEBNCDKBEK()
		{
			if (this.MBNKFMKMOPO() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x0023F4B9 File Offset: 0x0023D6B9
		private void GBFPAEDPOPP()
		{
			this.m_SMAA.MLLPGPANCHI(this);
			this.m_FXAA.OnEnable(this);
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x0023F536 File Offset: 0x0023D736
		public int EGLDNKHCLOJ()
		{
			return this.m_Method;
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x0023F621 File Offset: 0x0023D821
		private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.CJPKGKCIJIM().OnRenderImage(this.AACCCOPEDDI(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x0023F6AA File Offset: 0x0023D8AA
		private void IFJDKDFLGBG()
		{
			this.m_SMAA.PLIKADJCEPO();
			this.m_FXAA.DLMPALHKMON();
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x0023F6C2 File Offset: 0x0023D8C2
		private void JHBPINEKDPE()
		{
			this.m_SMAA.OnEnable(this);
			this.m_FXAA.LLDBPKHDPKI(this);
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x0023F558 File Offset: 0x0023D758
		public void JMGOPCLEHEA(int DPNHODJHGJL)
		{
			if (this.m_Method == DPNHODJHGJL)
			{
				return;
			}
			this.m_Method = DPNHODJHGJL;
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x0023F862 File Offset: 0x0023DA62
		private void LLDBPKHDPKI()
		{
			this.m_SMAA.MLLPGPANCHI(this);
			this.m_FXAA.GFLAINNLMBO(this);
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera KKOBMMPGLEO()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600759E RID: 30110 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera cameraComponent
		{
			get
			{
				if (this.CMMMNLFGCJB == null)
				{
					this.CMMMNLFGCJB = base.GetComponent<Camera>();
				}
				return this.CMMMNLFGCJB;
			}
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera MMMGEDOOLJE()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x0023F73B File Offset: 0x0023D93B
		public IAntiAliasing DCIPCPGMMFM()
		{
			if (this.NCNGLJPJAOM() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x0023F536 File Offset: 0x0023D736
		public int NFLCAICKJGP()
		{
			return this.m_Method;
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x0023F558 File Offset: 0x0023D758
		public void IBPPIDLJKOD(int DPNHODJHGJL)
		{
			if (this.m_Method == DPNHODJHGJL)
			{
				return;
			}
			this.m_Method = DPNHODJHGJL;
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x0023F87C File Offset: 0x0023DA7C
		private void IBEAPBDAOCC()
		{
			this.m_SMAA.MLLPGPANCHI(this);
			this.m_FXAA.PAHNKEGFGHB(this);
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x0023F896 File Offset: 0x0023DA96
		private void EMKCNMFNDDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.CFKPIPLLKIL().OnRenderImage(this.MKGFHJNFKJP(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x0023F558 File Offset: 0x0023D758
		public void POCHENKLLNA(int DPNHODJHGJL)
		{
			if (this.m_Method == DPNHODJHGJL)
			{
				return;
			}
			this.m_Method = DPNHODJHGJL;
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera PIOEJJPOADP()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x0023F5F4 File Offset: 0x0023D7F4
		private void OFIMMFHFHDD()
		{
			this.m_SMAA.OnDisable();
			this.m_FXAA.OnDisable();
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x0023F8AB File Offset: 0x0023DAAB
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.OBAKBGOCHIA().OnRenderImage(this.HFBKPEHGMBJ(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x0023F8C0 File Offset: 0x0023DAC0
		private void BFJNKBCEBDD()
		{
			this.CFKPIPLLKIL().OnPreCull(this.AACCCOPEDDI());
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x0023F596 File Offset: 0x0023D796
		public IAntiAliasing CFKPIPLLKIL()
		{
			if (this.OKNKJNLHBIF() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera EFLBLMMIDMJ()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x0023F8D3 File Offset: 0x0023DAD3
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.ONLEEJHJPMJ().OnRenderImage(this.BEOLNDPBCFH(), HLBKCLPNHEB, BMMLHGHKBNM);
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x0023F536 File Offset: 0x0023D736
		public int OKNKJNLHBIF()
		{
			return this.m_Method;
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x0023F8E8 File Offset: 0x0023DAE8
		private void OnEnable()
		{
			this.m_SMAA.OnEnable(this);
			this.m_FXAA.OnEnable(this);
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x0023F4D3 File Offset: 0x0023D6D3
		public Camera HLGLACJPJIJ()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x04000BFC RID: 3068
		[SerializeField]
		private SMAA m_SMAA = new SMAA();

		// Token: 0x04000BFD RID: 3069
		[SerializeField]
		private FXAA m_FXAA = new FXAA();

		// Token: 0x04000BFE RID: 3070
		[SerializeField]
		[HideInInspector]
		private int m_Method;

		// Token: 0x04000BFF RID: 3071
		private Camera CMMMNLFGCJB;

		// Token: 0x0200019B RID: 411
		public enum Method
		{
			// Token: 0x04000C01 RID: 3073
			Smaa,
			// Token: 0x04000C02 RID: 3074
			Fxaa
		}
	}
}
