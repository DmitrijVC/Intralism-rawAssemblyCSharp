using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001D9 RID: 473
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class CreaseShading : PostEffectsBase
	{
		// Token: 0x06007C26 RID: 31782 RVA: 0x00283140 File Offset: 0x00281340
		public virtual bool FKHOCKAEMLD()
		{
			base.JOMCJOEOLHP(false);
			this.HKNGEKKGPFK = base.KDHKHOHMKCG(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.GJKHKCOAFDB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.GJKHKCOAFDB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x002831B4 File Offset: 0x002813B4
		private void OHDKDLLBNFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 166f * (float)width / (694f * (float)height);
			float num2 = 1702f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 6, height / 4, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 7, 0);
				this.HKNGEKKGPFK.SetVector("editor.", new Vector4(686f, this.spread * num2, 1520f, 1719f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 7, 0);
				this.HKNGEKKGPFK.SetVector("CameraFilterPack/Blend2Camera_PinLight", new Vector4(this.spread * num2 / num, 1902f, 1293f, 96f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("Object ID. Case-Sensitive", temporary);
			this.GAJEJCJIGIO.SetTexture("_Value", renderTexture);
			this.GAJEJCJIGIO.SetFloat(") of this PhotonView does not implement OnPhotonSerializeView()!", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x00283344 File Offset: 0x00281544
		public virtual bool NHCNNDEHICD()
		{
			base.DHHGCBANGJL(true);
			this.HKNGEKKGPFK = base.KDHKHOHMKCG(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.GJKHKCOAFDB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.AJKPGPKKHHB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C29 RID: 31785 RVA: 0x002833B8 File Offset: 0x002815B8
		public virtual bool CIDNHACINGF()
		{
			base.KHNPMDDIJAJ(false);
			this.HKNGEKKGPFK = base.GJKHKCOAFDB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.AJKPGPKKHHB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.NODBMINMALP(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C2A RID: 31786 RVA: 0x0028342C File Offset: 0x0028162C
		private void DHJKAOMONAJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1355f * (float)width / (424f * (float)height);
			float num2 = 1994f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 8, height / 2, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 2, 1);
				this.HKNGEKKGPFK.SetVector("Right Click", new Vector4(625f, this.spread * num2, 23f, 788f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 7, 1);
				this.HKNGEKKGPFK.SetVector("Gameplay/sun", new Vector4(this.spread * num2 / num, 1969f, 919f, 1861f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_Value", temporary);
			this.GAJEJCJIGIO.SetTexture("_Value6", renderTexture);
			this.GAJEJCJIGIO.SetFloat("Right Stick Click", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C2B RID: 31787 RVA: 0x002835BC File Offset: 0x002817BC
		private void CDCLDBFMKOG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 481f * (float)width / (1434f * (float)height);
			float num2 = 1165f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 8, height / 7, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 1, 0);
				this.HKNGEKKGPFK.SetVector("_DiffuseColor", new Vector4(1402f, this.spread * num2, 1894f, 61f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 4, 0);
				this.HKNGEKKGPFK.SetVector("SupportLogger ", new Vector4(this.spread * num2 / num, 240f, 148f, 1951f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("RespawnAfter", temporary);
			this.GAJEJCJIGIO.SetTexture("_ColorBuffer", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_MainTex", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C2C RID: 31788 RVA: 0x0028374C File Offset: 0x0028194C
		private void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1911f * (float)width / (643f * (float)height);
			float num2 = 1288f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 0, height / 0, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 8, 0);
				this.HKNGEKKGPFK.SetVector("maps.", new Vector4(559f, this.spread * num2, 159f, 643f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 4, height / 5, 1);
				this.HKNGEKKGPFK.SetVector("_Value4", new Vector4(this.spread * num2 / num, 1453f, 453f, 1407f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_Value2", temporary);
			this.GAJEJCJIGIO.SetTexture(" ", renderTexture);
			this.GAJEJCJIGIO.SetFloat("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x002838DC File Offset: 0x00281ADC
		public virtual bool KIELKBGLNKO()
		{
			base.MBMLNJJEONO(true);
			this.HKNGEKKGPFK = base.AJKPGPKKHHB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.LKIJNGDHLAK(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.NODBMINMALP(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x00283950 File Offset: 0x00281B50
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 271f * (float)width / (1174f * (float)height);
			float num2 = 1704f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 7, height / 5, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 4, 1);
				this.HKNGEKKGPFK.SetVector("Reading preview file failed!: \"{0}\"", new Vector4(1247f, this.spread * num2, 1098f, 1145f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 3, height / 7, 1);
				this.HKNGEKKGPFK.SetVector("System.Single", new Vector4(this.spread * num2 / num, 924f, 151f, 382f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("No player left to ask", temporary);
			this.GAJEJCJIGIO.SetTexture("Prints the number of logs currently held by DebugLogs", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_TimeX", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x00283AE0 File Offset: 0x00281CE0
		public virtual bool HBNCKBEPKGF()
		{
			base.KNGDKKMDKOG(false);
			this.HKNGEKKGPFK = base.LKIJNGDHLAK(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.EDFIBHNHAAB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.LKIJNGDHLAK(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x00283B54 File Offset: 0x00281D54
		private void KOIKNJLPOPA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1866f * (float)width / (115f * (float)height);
			float num2 = 679f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 8, height / 0, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 2, 1);
				this.HKNGEKKGPFK.SetVector("offsets", new Vector4(977f, this.spread * num2, 18f, 825f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 6, 1);
				this.HKNGEKKGPFK.SetVector("CameraFilterPack/Drawing_NewCellShading", new Vector4(this.spread * num2 / num, 1631f, 1675f, 1968f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("w", temporary);
			this.GAJEJCJIGIO.SetTexture("_Value6", renderTexture);
			this.GAJEJCJIGIO.SetFloat("tintColor", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x00283CE4 File Offset: 0x00281EE4
		public virtual bool ENDFLCJNOGA()
		{
			base.IBFDMKMOBCA(false);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.EDFIBHNHAAB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.NODBMINMALP(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x00283D58 File Offset: 0x00281F58
		public virtual bool EICPCBFEDNI()
		{
			base.JOMCJOEOLHP(true);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.ECNEGNMAMDE(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.ECNEGNMAMDE(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x00283DCC File Offset: 0x00281FCC
		private void OKNOJEEGONA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1970f * (float)width / (948f * (float)height);
			float num2 = 1772f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 7, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 4, 1);
				this.HKNGEKKGPFK.SetVector("_ConsoleSettings", new Vector4(378f, this.spread * num2, 872f, 887f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 5, height / 6, 1);
				this.HKNGEKKGPFK.SetVector("GroupNameText", new Vector4(this.spread * num2 / num, 453f, 1172f, 1793f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_TimeX", temporary);
			this.GAJEJCJIGIO.SetTexture("CameraFilterPack/3D_Binary", renderTexture);
			this.GAJEJCJIGIO.SetFloat("speed", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C34 RID: 31796 RVA: 0x00283F5C File Offset: 0x0028215C
		public virtual bool NOABPEFKKHK()
		{
			base.DHHGCBANGJL(true);
			this.HKNGEKKGPFK = base.NODBMINMALP(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.GJKHKCOAFDB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.AJKPGPKKHHB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x00283FD0 File Offset: 0x002821D0
		public virtual bool KIBBICMGDMF()
		{
			base.FNIFJAENDIB(true);
			this.HKNGEKKGPFK = base.KDHKHOHMKCG(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.AJKPGPKKHHB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.NODBMINMALP(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C36 RID: 31798 RVA: 0x00284044 File Offset: 0x00282244
		public virtual bool GOEOHOLLPKJ()
		{
			base.KHNPMDDIJAJ(true);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.GJKHKCOAFDB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.ECNEGNMAMDE(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x002840B8 File Offset: 0x002822B8
		public virtual bool EJIGOLAIMHP()
		{
			base.IHMNPAHGNFF(false);
			this.HKNGEKKGPFK = base.GJKHKCOAFDB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.GJKHKCOAFDB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.AJKPGPKKHHB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x0028412C File Offset: 0x0028232C
		private void IEJCEFENLOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1831f * (float)width / (284f * (float)height);
			float num2 = 1711f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 5, height / 6, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 5, 0);
				this.HKNGEKKGPFK.SetVector("st", new Vector4(1724f, this.spread * num2, 742f, 816f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 6, height / 7, 1);
				this.HKNGEKKGPFK.SetVector(" respawn in future: ", new Vector4(this.spread * num2 / num, 108f, 888f, 585f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("[FileSelector] Starting file dialog", temporary);
			this.GAJEJCJIGIO.SetTexture("CameraFilterPack/Blend2Camera_VividLight", renderTexture);
			this.GAJEJCJIGIO.SetFloat("BadgeImage", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x002842BC File Offset: 0x002824BC
		public override bool ILMGHBFANON()
		{
			base.NPOEJIDLJGK(false);
			this.HKNGEKKGPFK = base.AJKPGPKKHHB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.GJKHKCOAFDB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.GJKHKCOAFDB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x00284330 File Offset: 0x00282530
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1f * (float)width / (1f * (float)height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				this.HKNGEKKGPFK.SetVector("offsets", new Vector4(0f, this.spread * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				this.HKNGEKKGPFK.SetVector("offsets", new Vector4(this.spread * num2 / num, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_HrDepthTex", temporary);
			this.GAJEJCJIGIO.SetTexture("_LrDepthTex", renderTexture);
			this.GAJEJCJIGIO.SetFloat("intensity", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x002844C0 File Offset: 0x002826C0
		private void NEALKDCJCJH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1938f * (float)width / (1606f * (float)height);
			float num2 = 1975f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 6, height / 4, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 2, 0);
				this.HKNGEKKGPFK.SetVector("SetSatelliteRotationSpeed", new Vector4(1013f, this.spread * num2, 1145f, 126f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 3, 0);
				this.HKNGEKKGPFK.SetVector("Save", new Vector4(this.spread * num2 / num, 1261f, 385f, 880f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_Green_B", temporary);
			this.GAJEJCJIGIO.SetTexture("_ScreenResolution", renderTexture);
			this.GAJEJCJIGIO.SetFloat("SetSpeed", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x00284650 File Offset: 0x00282850
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 655f * (float)width / (315f * (float)height);
			float num2 = 266f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 0, height / 3, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 3, height / 0, 1);
				this.HKNGEKKGPFK.SetVector(". local RequestedView.ownerId: ", new Vector4(807f, this.spread * num2, 173f, 1118f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 8, height / 1, 1);
				this.HKNGEKKGPFK.SetVector("/", new Vector4(this.spread * num2 / num, 688f, 1607f, 895f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("EnableRankedNotificationsToggle", temporary);
			this.GAJEJCJIGIO.SetTexture("Tab2Content", renderTexture);
			this.GAJEJCJIGIO.SetFloat("maps.", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x002847E0 File Offset: 0x002829E0
		private void OAHHAAKEBDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 946f * (float)width / (1642f * (float)height);
			float num2 = 1022f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 0, 1);
				this.HKNGEKKGPFK.SetVector("inventory.lastitemscount", new Vector4(871f, this.spread * num2, 889f, 1557f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 2, 0);
				this.HKNGEKKGPFK.SetVector("_Blue_R", new Vector4(this.spread * num2 / num, 376f, 77f, 1069f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("wss://", temporary);
			this.GAJEJCJIGIO.SetTexture("_Distortion", renderTexture);
			this.GAJEJCJIGIO.SetFloat("DPADHOR", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x00284970 File Offset: 0x00282B70
		private void JKMBDBCDJAL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 296f * (float)width / (438f * (float)height);
			float num2 = 1223f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 7, height / 8, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 6, height / 5, 0);
				this.HKNGEKKGPFK.SetVector("#TBD", new Vector4(425f, this.spread * num2, 1694f, 1539f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 7, height / 8, 0);
				this.HKNGEKKGPFK.SetVector("_PositionY", new Vector4(this.spread * num2 / num, 1860f, 1241f, 278f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("maps.", temporary);
			this.GAJEJCJIGIO.SetTexture("Copy from ", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_Value7", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x00284B00 File Offset: 0x00282D00
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1281f * (float)width / (385f * (float)height);
			float num2 = 366f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 3, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 7, 0);
				this.HKNGEKKGPFK.SetVector("Please define the RectTransform for the Center viewport of the scrollable area", new Vector4(693f, this.spread * num2, 464f, 1223f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 8, height / 5, 1);
				this.HKNGEKKGPFK.SetVector("0.00", new Vector4(this.spread * num2 / num, 750f, 1937f, 888f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("Populate Mesh Data", temporary);
			this.GAJEJCJIGIO.SetTexture("_DiffuseColor", renderTexture);
			this.GAJEJCJIGIO.SetFloat(") error: ", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C40 RID: 31808 RVA: 0x00284C90 File Offset: 0x00282E90
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1344f * (float)width / (1660f * (float)height);
			float num2 = 48f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 3, height / 0, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 1);
				this.HKNGEKKGPFK.SetVector("SelectorMusicToggle", new Vector4(244f, this.spread * num2, 564f, 1725f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 6, height / 3, 1);
				this.HKNGEKKGPFK.SetVector("win", new Vector4(this.spread * num2 / num, 1694f, 47f, 1511f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("CameraFilterPack_Glasses_On4", temporary);
			this.GAJEJCJIGIO.SetTexture(" connected: ", renderTexture);
			this.GAJEJCJIGIO.SetFloat("Set sun beat detection sensitivity", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C41 RID: 31809 RVA: 0x00284E20 File Offset: 0x00283020
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 330f * (float)width / (5f * (float)height);
			float num2 = 553f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 5, height / 2, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 8, 0);
				this.HKNGEKKGPFK.SetVector("Please attach component to a Graphical UI component", new Vector4(275f, this.spread * num2, 1426f, 594f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 2, 1);
				this.HKNGEKKGPFK.SetVector("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", new Vector4(this.spread * num2 / num, 18f, 898f, 213f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_FarCamera", temporary);
			this.GAJEJCJIGIO.SetTexture(".lastCheckpoint.lives", renderTexture);
			this.GAJEJCJIGIO.SetFloat("UI", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x00284FB0 File Offset: 0x002831B0
		public virtual bool BDBLODKHNGF()
		{
			base.JOMCJOEOLHP(false);
			this.HKNGEKKGPFK = base.NODBMINMALP(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.AJKPGPKKHHB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.ECNEGNMAMDE(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x00285024 File Offset: 0x00283224
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1996f * (float)width / (1179f * (float)height);
			float num2 = 1521f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 1, height / 5, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 0, 0);
				this.HKNGEKKGPFK.SetVector(" b.", new Vector4(1119f, this.spread * num2, 1992f, 1791f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
				this.HKNGEKKGPFK.SetVector("EditMenu", new Vector4(this.spread * num2 / num, 318f, 1386f, 765f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_Value2", temporary);
			this.GAJEJCJIGIO.SetTexture("Vertical", renderTexture);
			this.GAJEJCJIGIO.SetFloat("Ignored PU RPC, cause item is inactive. ", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x002851B4 File Offset: 0x002833B4
		public override bool BNMLMGBCHHI()
		{
			base.NPOEJIDLJGK(false);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.LKIJNGDHLAK(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.GJKHKCOAFDB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C45 RID: 31813 RVA: 0x00285228 File Offset: 0x00283428
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1897f * (float)width / (128f * (float)height);
			float num2 = 1719f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 7, height / 3, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 6, height / 7, 0);
				this.HKNGEKKGPFK.SetVector("{0}={2}: {1} \"{3}\"", new Vector4(47f, this.spread * num2, 438f, 1783f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 4, 1);
				this.HKNGEKKGPFK.SetVector("Bad parameters for reset! Use \"reset <challengeid>\"", new Vector4(this.spread * num2 / num, 1211f, 1327f, 696f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("OPEN FILE", temporary);
			this.GAJEJCJIGIO.SetTexture("float,0", renderTexture);
			this.GAJEJCJIGIO.SetFloat("CameraFilterPack/Distortion_Twist", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C46 RID: 31814 RVA: 0x002853B8 File Offset: 0x002835B8
		private void AFCICEAOBHL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 773f * (float)width / (1194f * (float)height);
			float num2 = 1873f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 7, height / 0, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 3, height / 0, 0);
				this.HKNGEKKGPFK.SetVector("BitsData", new Vector4(522f, this.spread * num2, 696f, 1666f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 4, height / 7, 0);
				this.HKNGEKKGPFK.SetVector("_Value", new Vector4(this.spread * num2 / num, 1943f, 376f, 94f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("SetEnvSpriteColor", temporary);
			this.GAJEJCJIGIO.SetTexture(",", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_Value2", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C47 RID: 31815 RVA: 0x00285548 File Offset: 0x00283748
		public virtual bool ACEIOFMECMD()
		{
			base.NPOEJIDLJGK(false);
			this.HKNGEKKGPFK = base.AJKPGPKKHHB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.EDFIBHNHAAB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.GJKHKCOAFDB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x002855BC File Offset: 0x002837BC
		private void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1478f * (float)width / (1503f * (float)height);
			float num2 = 313f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 6, height / 8, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 5, height / 7, 1);
				this.HKNGEKKGPFK.SetVector("_MainTex2", new Vector4(1549f, this.spread * num2, 1776f, 547f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 0, 0);
				this.HKNGEKKGPFK.SetVector("Set Particles Gravity", new Vector4(this.spread * num2 / num, 1368f, 192f, 465f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("SlidingArea", temporary);
			this.GAJEJCJIGIO.SetTexture("music.ogg", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_ScreenResolution", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x0028574C File Offset: 0x0028394C
		public virtual bool NKMDBJOGHDI()
		{
			base.NPOEJIDLJGK(true);
			this.HKNGEKKGPFK = base.GJKHKCOAFDB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.ECNEGNMAMDE(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.ECNEGNMAMDE(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x002857C0 File Offset: 0x002839C0
		public virtual bool IHNGNCCNPCK()
		{
			base.DHHGCBANGJL(false);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.EDFIBHNHAAB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.GJKHKCOAFDB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x00285834 File Offset: 0x00283A34
		public virtual bool PDEFIDFBKFE()
		{
			base.DCHKKHDGBLJ(false);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.ECNEGNMAMDE(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.AJKPGPKKHHB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C4C RID: 31820 RVA: 0x002858A8 File Offset: 0x00283AA8
		public virtual bool BMCAJHFDDAF()
		{
			base.DHHGCBANGJL(false);
			this.HKNGEKKGPFK = base.NODBMINMALP(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.NODBMINMALP(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.KDHKHOHMKCG(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C4D RID: 31821 RVA: 0x0028591C File Offset: 0x00283B1C
		public virtual bool FNEACOMEPBL()
		{
			base.CKIAMHAKJOK(true);
			this.HKNGEKKGPFK = base.ECNEGNMAMDE(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.KDHKHOHMKCG(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.LKIJNGDHLAK(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C4E RID: 31822 RVA: 0x00285990 File Offset: 0x00283B90
		public virtual bool OCADOBLPPAA()
		{
			base.MBMLNJJEONO(true);
			this.HKNGEKKGPFK = base.KDHKHOHMKCG(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.ECNEGNMAMDE(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.EDFIBHNHAAB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C4F RID: 31823 RVA: 0x00285A04 File Offset: 0x00283C04
		public virtual bool ELHBKCFNCOJ()
		{
			base.NPOEJIDLJGK(false);
			this.HKNGEKKGPFK = base.LKIJNGDHLAK(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.KDHKHOHMKCG(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.ECNEGNMAMDE(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x00285A78 File Offset: 0x00283C78
		public virtual bool FEIGCNHEINM()
		{
			base.DCHKKHDGBLJ(true);
			this.HKNGEKKGPFK = base.LKIJNGDHLAK(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.ECNEGNMAMDE(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.EDFIBHNHAAB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x00285AEC File Offset: 0x00283CEC
		public virtual bool HBBIDMLLFFD()
		{
			base.IBFDMKMOBCA(false);
			this.HKNGEKKGPFK = base.LKIJNGDHLAK(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.EDFIBHNHAAB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.GJKHKCOAFDB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x00285B60 File Offset: 0x00283D60
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1277f * (float)width / (392f * (float)height);
			float num2 = 627f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 7, height / 1, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 1, 0);
				this.HKNGEKKGPFK.SetVector("null", new Vector4(1301f, this.spread * num2, 1359f, 863f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 4, 1);
				this.HKNGEKKGPFK.SetVector("Editor/", new Vector4(this.spread * num2 / num, 936f, 795f, 1490f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_Value2", temporary);
			this.GAJEJCJIGIO.SetTexture("AppID: {0}*** GameVersion: {1} PeerId: {2} ", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_PColor2", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x00285CF0 File Offset: 0x00283EF0
		private void IFMHIDNCFFH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1637f * (float)width / (912f * (float)height);
			float num2 = 1664f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 8, height / 4, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 7, 0);
				this.HKNGEKKGPFK.SetVector("player.currentrank", new Vector4(1975f, this.spread * num2, 1548f, 28f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 7, height / 4, 0);
				this.HKNGEKKGPFK.SetVector("_TexelOffsetScale", new Vector4(this.spread * num2 / num, 634f, 1493f, 244f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("Received event Leave for unknown player ID: {0}", temporary);
			this.GAJEJCJIGIO.SetTexture("OpAuthenticate()", renderTexture);
			this.GAJEJCJIGIO.SetFloat("#changenote", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C54 RID: 31828 RVA: 0x00285E80 File Offset: 0x00284080
		private void PJKAGNNNFGK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1170f * (float)width / (1707f * (float)height);
			float num2 = 553f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 4, height / 6, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 3, 0);
				this.HKNGEKKGPFK.SetVector("_MainTex2", new Vector4(526f, this.spread * num2, 518f, 1749f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 4, height / 1, 1);
				this.HKNGEKKGPFK.SetVector(" not found", new Vector4(this.spread * num2 / num, 156f, 1799f, 666f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("DISTORT", temporary);
			this.GAJEJCJIGIO.SetTexture("_ScreenResolution", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_LensDirtIntensity", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C55 RID: 31829 RVA: 0x00286010 File Offset: 0x00284210
		public virtual bool APBDJCHNNEH()
		{
			base.MBMLNJJEONO(false);
			this.HKNGEKKGPFK = base.NODBMINMALP(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.GJKHKCOAFDB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.LKIJNGDHLAK(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x00286084 File Offset: 0x00284284
		public virtual bool DPFJOPGMFHN()
		{
			base.DHHGCBANGJL(true);
			this.HKNGEKKGPFK = base.ECNEGNMAMDE(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.AJKPGPKKHHB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.AJKPGPKKHHB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x002860F8 File Offset: 0x002842F8
		public virtual bool EIBHLNIFKHD()
		{
			base.IHMNPAHGNFF(true);
			this.HKNGEKKGPFK = base.KDHKHOHMKCG(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.GJKHKCOAFDB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.LKIJNGDHLAK(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x0028616C File Offset: 0x0028436C
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1154f * (float)width / (929f * (float)height);
			float num2 = 797f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 0, height / 4, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 2, 1);
				this.HKNGEKKGPFK.SetVector("z", new Vector4(799f, this.spread * num2, 897f, 216f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 3, 1);
				this.HKNGEKKGPFK.SetVector("_Offsets", new Vector4(this.spread * num2 / num, 926f, 1944f, 602f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("maps.", temporary);
			this.GAJEJCJIGIO.SetTexture(".played", renderTexture);
			this.GAJEJCJIGIO.SetFloat("SetSatelliteTrailLength", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C59 RID: 31833 RVA: 0x002862FC File Offset: 0x002844FC
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(true);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.EDFIBHNHAAB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.EDFIBHNHAAB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C5A RID: 31834 RVA: 0x00286370 File Offset: 0x00284570
		private void MMBPPEPNNLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 766f * (float)width / (1392f * (float)height);
			float num2 = 194f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 1, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 1);
				this.HKNGEKKGPFK.SetVector("SupportLogger OnConnectedToPhoton().", new Vector4(84f, this.spread * num2, 1398f, 1317f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 3, 1);
				this.HKNGEKKGPFK.SetVector("Failed to InstantiateSceneObject prefab:", new Vector4(this.spread * num2 / num, 1379f, 939f, 173f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("OnPressRight", temporary);
			this.GAJEJCJIGIO.SetTexture("player.gamecompleted", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_Value2", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x00286500 File Offset: 0x00284700
		private void DDBNDCAFHOA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1076f * (float)width / (1426f * (float)height);
			float num2 = 1138f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 1, height / 8, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 4, 0);
				this.HKNGEKKGPFK.SetVector("_TimeX", new Vector4(284f, this.spread * num2, 159f, 1709f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 3, height / 2, 0);
				this.HKNGEKKGPFK.SetVector("EventTimeInputField", new Vector4(this.spread * num2 / num, 541f, 940f, 944f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("SetParticlesParticleSpeed", temporary);
			this.GAJEJCJIGIO.SetTexture("ExitButton", renderTexture);
			this.GAJEJCJIGIO.SetFloat("SupportLogger OnDisconnectedFromPhoton().", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x00286690 File Offset: 0x00284890
		private void BLMICAMBBCD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1560f * (float)width / (556f * (float)height);
			float num2 = 1689f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 8, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 2, 1);
				this.HKNGEKKGPFK.SetVector("_MatrixColor", new Vector4(1577f, this.spread * num2, 542f, 1405f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 8, height / 8, 1);
				this.HKNGEKKGPFK.SetVector("workshop.", new Vector4(this.spread * num2 / num, 222f, 364f, 401f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("[PlayerController] ", temporary);
			this.GAJEJCJIGIO.SetTexture("#", renderTexture);
			this.GAJEJCJIGIO.SetFloat("CameraFilterPack/Pixelisation_Dot", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x00286820 File Offset: 0x00284A20
		public virtual bool JDPOEILHKLC()
		{
			base.JOMCJOEOLHP(false);
			this.HKNGEKKGPFK = base.AJKPGPKKHHB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.EDFIBHNHAAB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.NODBMINMALP(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x00286894 File Offset: 0x00284A94
		private void NFJFHPCMEGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 481f * (float)width / (958f * (float)height);
			float num2 = 251f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 1, height / 7, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 1, 1);
				this.HKNGEKKGPFK.SetVector("R:", new Vector4(1216f, this.spread * num2, 1349f, 1868f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 4, height / 3, 0);
				this.HKNGEKKGPFK.SetVector("0.00", new Vector4(this.spread * num2 / num, 1783f, 1082f, 546f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_Value2", temporary);
			this.GAJEJCJIGIO.SetTexture("_MaxRadiusOrKInPaper", renderTexture);
			this.GAJEJCJIGIO.SetFloat("OK", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x00286A24 File Offset: 0x00284C24
		public virtual bool BKNCNFMHIGH()
		{
			base.NPOEJIDLJGK(false);
			this.HKNGEKKGPFK = base.NODBMINMALP(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.LKIJNGDHLAK(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.NODBMINMALP(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x00286A98 File Offset: 0x00284C98
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 528f * (float)width / (131f * (float)height);
			float num2 = 255f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 5, height / 1, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 8, 1);
				this.HKNGEKKGPFK.SetVector(".", new Vector4(951f, this.spread * num2, 503f, 419f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 4, height / 1, 1);
				this.HKNGEKKGPFK.SetVector("_ScreenResolution", new Vector4(this.spread * num2 / num, 1667f, 1917f, 809f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("Instrumental", temporary);
			this.GAJEJCJIGIO.SetTexture("PS Home", renderTexture);
			this.GAJEJCJIGIO.SetFloat("stretchWidth", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x00286C28 File Offset: 0x00284E28
		private void PACLEGDKKPI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1240f * (float)width / (572f * (float)height);
			float num2 = 941f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 1, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 4, 1);
				this.HKNGEKKGPFK.SetVector("_ColorBuffer", new Vector4(1284f, this.spread * num2, 1608f, 816f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 3, height / 1, 0);
				this.HKNGEKKGPFK.SetVector("_Near", new Vector4(this.spread * num2 / num, 1025f, 1019f, 1475f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("Changed config", temporary);
			this.GAJEJCJIGIO.SetTexture(".completed", renderTexture);
			this.GAJEJCJIGIO.SetFloat("CameraFilterPack/Blend2Camera_Saturation", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C62 RID: 31842 RVA: 0x00286DB8 File Offset: 0x00284FB8
		private void ABHEECINLJA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 620f * (float)width / (490f * (float)height);
			float num2 = 701f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 3, height / 5, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 3, height / 3, 1);
				this.HKNGEKKGPFK.SetVector("t", new Vector4(640f, this.spread * num2, 486f, 545f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 5, 0);
				this.HKNGEKKGPFK.SetVector("Using Stopwatch as precision timer for PUN.", new Vector4(this.spread * num2 / num, 1727f, 1515f, 1433f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_EdgeSize", temporary);
			this.GAJEJCJIGIO.SetTexture("ItemTemplate", renderTexture);
			this.GAJEJCJIGIO.SetFloat("Joystick1Button2", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x00286F48 File Offset: 0x00285148
		private void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1149f * (float)width / (813f * (float)height);
			float num2 = 345f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 5, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 6, height / 8, 0);
				this.HKNGEKKGPFK.SetVector("_Value2", new Vector4(96f, this.spread * num2, 1147f, 1247f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 1, 1);
				this.HKNGEKKGPFK.SetVector("_SSAO", new Vector4(this.spread * num2 / num, 290f, 821f, 1452f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("position", temporary);
			this.GAJEJCJIGIO.SetTexture("time", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_FarCamera", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x002870D8 File Offset: 0x002852D8
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 295f * (float)width / (275f * (float)height);
			float num2 = 1224f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 3, height / 4, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 5, 1);
				this.HKNGEKKGPFK.SetVector("Joystick1Button2", new Vector4(1047f, this.spread * num2, 1941f, 1867f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 1, 0);
				this.HKNGEKKGPFK.SetVector("rarity", new Vector4(this.spread * num2 / num, 362f, 616f, 161f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_Color_R", temporary);
			this.GAJEJCJIGIO.SetTexture("_GrainOffsetScale", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_EmissionGain", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x00287268 File Offset: 0x00285468
		public virtual bool JIJIMMICLAM()
		{
			base.IBFDMKMOBCA(false);
			this.HKNGEKKGPFK = base.ECNEGNMAMDE(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.LKIJNGDHLAK(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.KDHKHOHMKCG(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x002872DC File Offset: 0x002854DC
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 42f * (float)width / (171f * (float)height);
			float num2 = 611f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 1, height / 7, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 8, 1);
				this.HKNGEKKGPFK.SetVector(" left", new Vector4(264f, this.spread * num2, 1369f, 600f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 3, height / 5, 1);
				this.HKNGEKKGPFK.SetVector("SetLives", new Vector4(this.spread * num2 / num, 1989f, 332f, 1079f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("ViewID {0} {1}{2}", temporary);
			this.GAJEJCJIGIO.SetTexture("CameraFilterPack/3D_BlackHole", renderTexture);
			this.GAJEJCJIGIO.SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x0028746C File Offset: 0x0028566C
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1547f * (float)width / (1042f * (float)height);
			float num2 = 1056f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 7, height / 7, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 1, 0);
				this.HKNGEKKGPFK.SetVector("_Value4", new Vector4(970f, this.spread * num2, 988f, 1424f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 5, height / 7, 1);
				this.HKNGEKKGPFK.SetVector("mapselector.lastSearch", new Vector4(this.spread * num2 / num, 163f, 316f, 1506f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("[MapsData] Preloading workshop", temporary);
			this.GAJEJCJIGIO.SetTexture("_BlurCoe", renderTexture);
			this.GAJEJCJIGIO.SetFloat("[Right]", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x002875FC File Offset: 0x002857FC
		private void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 59f * (float)width / (1419f * (float)height);
			float num2 = 762f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 3, height / 3, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 1, 0);
				this.HKNGEKKGPFK.SetVector("_Value4", new Vector4(650f, this.spread * num2, 485f, 210f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 1, 1);
				this.HKNGEKKGPFK.SetVector("_PixelsPerMeterAtOneMeter", new Vector4(this.spread * num2 / num, 323f, 1033f, 1789f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("BloodAlternative1", temporary);
			this.GAJEJCJIGIO.SetTexture("PhotonView with ID ", renderTexture);
			this.GAJEJCJIGIO.SetFloat("Dropped Object: ", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x0028778C File Offset: 0x0028598C
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 496f * (float)width / (264f * (float)height);
			float num2 = 992f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 8, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 5, height / 7, 0);
				this.HKNGEKKGPFK.SetVector("[Up]", new Vector4(1962f, this.spread * num2, 1828f, 1863f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 5, height / 7, 0);
				this.HKNGEKKGPFK.SetVector("Vertical", new Vector4(this.spread * num2 / num, 234f, 135f, 915f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("#forever", temporary);
			this.GAJEJCJIGIO.SetTexture("other.dust2", renderTexture);
			this.GAJEJCJIGIO.SetFloat("MapCreationCanvas", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x0028791C File Offset: 0x00285B1C
		public virtual bool INPJJOOGMMO()
		{
			base.IBFDMKMOBCA(true);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.ECNEGNMAMDE(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.LKIJNGDHLAK(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C6B RID: 31851 RVA: 0x00287990 File Offset: 0x00285B90
		private void EMKCNMFNDDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 648f * (float)width / (125f * (float)height);
			float num2 = 1503f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 3, 1);
				this.HKNGEKKGPFK.SetVector("bpmgrid", new Vector4(277f, this.spread * num2, 550f, 1928f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 0, 1);
				this.HKNGEKKGPFK.SetVector("Reset All", new Vector4(this.spread * num2 / num, 1278f, 1098f, 459f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("OK", temporary);
			this.GAJEJCJIGIO.SetTexture("f", renderTexture);
			this.GAJEJCJIGIO.SetFloat("GlassDistortion", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x00287B44 File Offset: 0x00285D44
		public virtual bool JFFKKNHBANB()
		{
			base.JOMCJOEOLHP(false);
			this.HKNGEKKGPFK = base.NODBMINMALP(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.LKIJNGDHLAK(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.NODBMINMALP(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x00287BB8 File Offset: 0x00285DB8
		private void LPFHEJNMEOO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 475f * (float)width / (1460f * (float)height);
			float num2 = 649f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 4, height / 3, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 7, 0);
				this.HKNGEKKGPFK.SetVector("CameraFilterPack/3D_Myst", new Vector4(1580f, this.spread * num2, 276f, 928f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 5, 1);
				this.HKNGEKKGPFK.SetVector("Joystick1Button5", new Vector4(this.spread * num2 / num, 1422f, 1131f, 836f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_Val", temporary);
			this.GAJEJCJIGIO.SetTexture("Can't set MaxPlayers when not in that room.", renderTexture);
			this.GAJEJCJIGIO.SetFloat(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C6F RID: 31855 RVA: 0x00287D48 File Offset: 0x00285F48
		public virtual bool HDDNBPJGGFK()
		{
			base.KHNPMDDIJAJ(false);
			this.HKNGEKKGPFK = base.NODBMINMALP(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.KDHKHOHMKCG(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.AJKPGPKKHHB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x00287DBC File Offset: 0x00285FBC
		public virtual bool KLLLLEOIGHG()
		{
			base.FNIFJAENDIB(true);
			this.HKNGEKKGPFK = base.GJKHKCOAFDB(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.EDFIBHNHAAB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.NODBMINMALP(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x00287E30 File Offset: 0x00286030
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1528f * (float)width / (1407f * (float)height);
			float num2 = 473f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 1, height / 0, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 7, 0);
				this.HKNGEKKGPFK.SetVector("MenuPlayButton", new Vector4(381f, this.spread * num2, 1083f, 1085f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 0, 1);
				this.HKNGEKKGPFK.SetVector("AudioClip", new Vector4(this.spread * num2 / num, 1633f, 276f, 1881f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_TimeX", temporary);
			this.GAJEJCJIGIO.SetTexture("#ok", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_Green_R", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x00287FC0 File Offset: 0x002861C0
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 707f * (float)width / (122f * (float)height);
			float num2 = 1298f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 5, height / 1, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 4, 0);
				this.HKNGEKKGPFK.SetVector("[PlayerBase] Delete checkpoint data", new Vector4(446f, this.spread * num2, 298f, 790f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 4, height / 6, 0);
				this.HKNGEKKGPFK.SetVector("Tab1Content", new Vector4(this.spread * num2 / num, 1579f, 832f, 1443f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("_DistortionLevel", temporary);
			this.GAJEJCJIGIO.SetTexture("menu.selectedplaymode", renderTexture);
			this.GAJEJCJIGIO.SetFloat("settings_bindings_", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C73 RID: 31859 RVA: 0x00288150 File Offset: 0x00286350
		public virtual bool MPJAPLPIDMG()
		{
			base.KHNPMDDIJAJ(true);
			this.HKNGEKKGPFK = base.NODBMINMALP(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.NODBMINMALP(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.AJKPGPKKHHB(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x002881C4 File Offset: 0x002863C4
		public virtual bool ANCBDJKLGAI()
		{
			base.FNIFJAENDIB(true);
			this.HKNGEKKGPFK = base.LKIJNGDHLAK(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.AJKPGPKKHHB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.KDHKHOHMKCG(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x00288238 File Offset: 0x00286438
		public virtual bool MKKNILHMBIC()
		{
			base.IHMNPAHGNFF(false);
			this.HKNGEKKGPFK = base.ECNEGNMAMDE(this.blurShader, this.HKNGEKKGPFK);
			this.MDBPEKNHHMA = base.AJKPGPKKHHB(this.depthFetchShader, this.MDBPEKNHHMA);
			this.GAJEJCJIGIO = base.LKIJNGDHLAK(this.creaseApplyShader, this.GAJEJCJIGIO);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x002882AC File Offset: 0x002864AC
		private void HCOGCFOBBMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1474f * (float)width / (1115f * (float)height);
			float num2 = 509f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 3, height / 8, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 1, 0);
				this.HKNGEKKGPFK.SetVector("_LoopCount", new Vector4(1291f, this.spread * num2, 170f, 1315f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 4, height / 5, 1);
				this.HKNGEKKGPFK.SetVector("ItemNameBGImage", new Vector4(this.spread * num2 / num, 1220f, 755f, 1732f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("ArcsHitsoundTimeDelaySlider", temporary);
			this.GAJEJCJIGIO.SetTexture("_TreatBackfaceHitAsMiss", renderTexture);
			this.GAJEJCJIGIO.SetFloat("achievements.id", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C77 RID: 31863 RVA: 0x0028843C File Offset: 0x0028663C
		private void OLFAPNGMBPL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 1210f * (float)width / (1804f * (float)height);
			float num2 = 926f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 7, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 7, 1);
				this.HKNGEKKGPFK.SetVector(".lastCheckpoint.incorrectScore", new Vector4(1271f, this.spread * num2, 292f, 193f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 8, height / 0, 1);
				this.HKNGEKKGPFK.SetVector("_Intensity", new Vector4(this.spread * num2 / num, 712f, 1997f, 1354f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("maphash", temporary);
			this.GAJEJCJIGIO.SetTexture("_TimeX", renderTexture);
			this.GAJEJCJIGIO.SetFloat("PS Home", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C78 RID: 31864 RVA: 0x002885CC File Offset: 0x002867CC
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			float num = 8f * (float)width / (1611f * (float)height);
			float num2 = 926f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 8, height / 6, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MDBPEKNHHMA);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 1, 0);
				this.HKNGEKKGPFK.SetVector("_Value2", new Vector4(1514f, this.spread * num2, 25f, 1304f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 6, 0);
				this.HKNGEKKGPFK.SetVector("_Value2", new Vector4(this.spread * num2 / num, 1330f, 1647f, 584f));
				Graphics.Blit(renderTexture, temporary2, this.HKNGEKKGPFK);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.GAJEJCJIGIO.SetTexture("keep aspect ratio", temporary);
			this.GAJEJCJIGIO.SetTexture("Set sun colors", renderTexture);
			this.GAJEJCJIGIO.SetFloat("_Value3", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GAJEJCJIGIO);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x04000D9C RID: 3484
		public float intensity = 0.5f;

		// Token: 0x04000D9D RID: 3485
		public int softness = 1;

		// Token: 0x04000D9E RID: 3486
		public float spread = 1f;

		// Token: 0x04000D9F RID: 3487
		public Shader blurShader;

		// Token: 0x04000DA0 RID: 3488
		private Material HKNGEKKGPFK;

		// Token: 0x04000DA1 RID: 3489
		public Shader depthFetchShader;

		// Token: 0x04000DA2 RID: 3490
		private Material MDBPEKNHHMA;

		// Token: 0x04000DA3 RID: 3491
		public Shader creaseApplyShader;

		// Token: 0x04000DA4 RID: 3492
		private Material GAJEJCJIGIO;
	}
}
