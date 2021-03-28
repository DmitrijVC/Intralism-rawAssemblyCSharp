using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001E4 RID: 484
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Fisheye : PostEffectsBase
	{
		// Token: 0x06007CEB RID: 31979 RVA: 0x00291A27 File Offset: 0x0028FC27
		public virtual bool LPDMNDMCPCO()
		{
			base.CKIAMHAKJOK(false);
			this.BMNOJPICKAI = base.EDFIBHNHAAB(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CEC RID: 31980 RVA: 0x00291A60 File Offset: 0x0028FC60
		private void LPFDJPCIADE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 906f;
			float num2 = (float)HLBKCLPNHEB.width * 1750f / ((float)HLBKCLPNHEB.height * 146f);
			this.BMNOJPICKAI.SetVector("note.0", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007CEE RID: 31982 RVA: 0x00291B06 File Offset: 0x0028FD06
		public virtual bool JDPOEILHKLC()
		{
			base.IHMNPAHGNFF(true);
			this.BMNOJPICKAI = base.AJKPGPKKHHB(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x00291B3F File Offset: 0x0028FD3F
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.BMNOJPICKAI = base.EDFIBHNHAAB(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CF0 RID: 31984 RVA: 0x00291B78 File Offset: 0x0028FD78
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1226f;
			float num2 = (float)HLBKCLPNHEB.width * 1997f / ((float)HLBKCLPNHEB.height * 1414f);
			this.BMNOJPICKAI.SetVector("_HueShift", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007CF1 RID: 31985 RVA: 0x00291C00 File Offset: 0x0028FE00
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 506f;
			float num2 = (float)HLBKCLPNHEB.width * 422f / ((float)HLBKCLPNHEB.height * 417f);
			this.BMNOJPICKAI.SetVector("Items/", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x00291C88 File Offset: 0x0028FE88
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1447f;
			float num2 = (float)HLBKCLPNHEB.width * 1477f / ((float)HLBKCLPNHEB.height * 616f);
			this.BMNOJPICKAI.SetVector("Ev OwnershipTransfer. ViewID ", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007CF3 RID: 31987 RVA: 0x00291D10 File Offset: 0x0028FF10
		private void OHDKDLLBNFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 598f;
			float num2 = (float)HLBKCLPNHEB.width * 1849f / ((float)HLBKCLPNHEB.height * 792f);
			this.BMNOJPICKAI.SetVector("tagElement", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x00291D98 File Offset: 0x0028FF98
		public virtual bool KLLLLEOIGHG()
		{
			base.NPOEJIDLJGK(false);
			this.BMNOJPICKAI = base.LKIJNGDHLAK(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CF5 RID: 31989 RVA: 0x00291DD1 File Offset: 0x0028FFD1
		public virtual bool GCLELPIDOCM()
		{
			base.FNIFJAENDIB(true);
			this.BMNOJPICKAI = base.LKIJNGDHLAK(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x00291E0C File Offset: 0x0029000C
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1171f;
			float num2 = (float)HLBKCLPNHEB.width * 1556f / ((float)HLBKCLPNHEB.height * 1296f);
			this.BMNOJPICKAI.SetVector("_Green_R", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007CF7 RID: 31991 RVA: 0x00291E94 File Offset: 0x00290094
		public virtual bool GHHAAPCBJJD()
		{
			base.NPOEJIDLJGK(true);
			this.BMNOJPICKAI = base.GJKHKCOAFDB(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CF8 RID: 31992 RVA: 0x00291ED0 File Offset: 0x002900D0
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 0.15625f;
			float num2 = (float)HLBKCLPNHEB.width * 1f / ((float)HLBKCLPNHEB.height * 1f);
			this.BMNOJPICKAI.SetVector("intensity", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007CF9 RID: 31993 RVA: 0x00291F58 File Offset: 0x00290158
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1003f;
			float num2 = (float)HLBKCLPNHEB.width * 400f / ((float)HLBKCLPNHEB.height * 447f);
			this.BMNOJPICKAI.SetVector("&search=", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007CFA RID: 31994 RVA: 0x00291FE0 File Offset: 0x002901E0
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1373f;
			float num2 = (float)HLBKCLPNHEB.width * 355f / ((float)HLBKCLPNHEB.height * 954f);
			this.BMNOJPICKAI.SetVector("_Alpha2", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007CFB RID: 31995 RVA: 0x00292068 File Offset: 0x00290268
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 449f;
			float num2 = (float)HLBKCLPNHEB.width * 776f / ((float)HLBKCLPNHEB.height * 414f);
			this.BMNOJPICKAI.SetVector("Scale environment object by the values", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007CFC RID: 31996 RVA: 0x002920F0 File Offset: 0x002902F0
		public virtual bool NHCNNDEHICD()
		{
			base.MBMLNJJEONO(false);
			this.BMNOJPICKAI = base.EDFIBHNHAAB(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CFD RID: 31997 RVA: 0x00292129 File Offset: 0x00290329
		public virtual bool AMKCNLBKLDJ()
		{
			base.JOMCJOEOLHP(false);
			this.BMNOJPICKAI = base.KDHKHOHMKCG(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x00292162 File Offset: 0x00290362
		public virtual bool KBPPNPKJIJG()
		{
			base.FNIFJAENDIB(true);
			this.BMNOJPICKAI = base.EDFIBHNHAAB(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CFF RID: 31999 RVA: 0x0029219B File Offset: 0x0029039B
		public virtual bool KIELKBGLNKO()
		{
			base.DHHGCBANGJL(true);
			this.BMNOJPICKAI = base.EDFIBHNHAAB(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D00 RID: 32000 RVA: 0x002921D4 File Offset: 0x002903D4
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1489f;
			float num2 = (float)HLBKCLPNHEB.width * 1105f / ((float)HLBKCLPNHEB.height * 1724f);
			this.BMNOJPICKAI.SetVector("DPADVER", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007D01 RID: 32001 RVA: 0x0029225C File Offset: 0x0029045C
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1227f;
			float num2 = (float)HLBKCLPNHEB.width * 945f / ((float)HLBKCLPNHEB.height * 1740f);
			this.BMNOJPICKAI.SetVector("CameraFilterPack/Distortion_BlackHole", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007D02 RID: 32002 RVA: 0x002922E4 File Offset: 0x002904E4
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 947f;
			float num2 = (float)HLBKCLPNHEB.width * 452f / ((float)HLBKCLPNHEB.height * 1116f);
			this.BMNOJPICKAI.SetVector("_CenterRadius", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007D03 RID: 32003 RVA: 0x0029236C File Offset: 0x0029056C
		public override bool ILMGHBFANON()
		{
			base.FNIFJAENDIB(true);
			this.BMNOJPICKAI = base.GJKHKCOAFDB(this.fishEyeShader, this.BMNOJPICKAI);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x002923A8 File Offset: 0x002905A8
		private void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 354f;
			float num2 = (float)HLBKCLPNHEB.width * 1997f / ((float)HLBKCLPNHEB.height * 1928f);
			this.BMNOJPICKAI.SetVector("/Segment-[Down]", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x00292430 File Offset: 0x00290630
		private void DDBNDCAFHOA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1851f;
			float num2 = (float)HLBKCLPNHEB.width * 1853f / ((float)HLBKCLPNHEB.height * 1678f);
			this.BMNOJPICKAI.SetVector("_DistCenterScale", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x002924B8 File Offset: 0x002906B8
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1675f;
			float num2 = (float)HLBKCLPNHEB.width * 1098f / ((float)HLBKCLPNHEB.height * 299f);
			this.BMNOJPICKAI.SetVector("_ScreenResolution", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007D07 RID: 32007 RVA: 0x00292540 File Offset: 0x00290740
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 898f;
			float num2 = (float)HLBKCLPNHEB.width * 1114f / ((float)HLBKCLPNHEB.height * 1862f);
			this.BMNOJPICKAI.SetVector("SetBGColor", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x002925C8 File Offset: 0x002907C8
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1245f;
			float num2 = (float)HLBKCLPNHEB.width * 257f / ((float)HLBKCLPNHEB.height * 1467f);
			this.BMNOJPICKAI.SetVector("Tab2Content", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BMNOJPICKAI);
		}

		// Token: 0x04000E10 RID: 3600
		[Range(0f, 1.5f)]
		public float strengthX = 0.05f;

		// Token: 0x04000E11 RID: 3601
		[Range(0f, 1.5f)]
		public float strengthY = 0.05f;

		// Token: 0x04000E12 RID: 3602
		public Shader fishEyeShader;

		// Token: 0x04000E13 RID: 3603
		private Material BMNOJPICKAI;
	}
}
