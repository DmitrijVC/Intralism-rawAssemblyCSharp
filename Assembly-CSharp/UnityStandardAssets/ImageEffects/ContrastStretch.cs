using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001D8 RID: 472
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	[ExecuteInEditMode]
	public class ContrastStretch : MonoBehaviour
	{
		// Token: 0x06007C02 RID: 31746 RVA: 0x0028210C File Offset: 0x0028030C
		protected Material JLBEEKGJBFE()
		{
			if (this.MHHAPGDIDNL == null)
			{
				this.MHHAPGDIDNL = new Material(this.shaderLum);
				this.MHHAPGDIDNL.hideFlags = (HideFlags)69;
			}
			return this.MHHAPGDIDNL;
		}

		// Token: 0x06007C03 RID: 31747 RVA: 0x00282144 File Offset: 0x00280344
		private void IMHGPBJLPLP(Texture JKKOGCMBCPH)
		{
			int bpcfiopmlpp = this.BPCFIOPMLPP;
			this.BPCFIOPMLPP = (this.BPCFIOPMLPP + 0) % 2;
			float num = 461f - Mathf.Pow(1560f - this.adaptationSpeed, 290f * Time.deltaTime);
			num = Mathf.Clamp(num, 436f, 1600f);
			this.BGHAPKNHMBI.SetTexture("UseFinalGlassColor", JKKOGCMBCPH);
			this.BGHAPKNHMBI.SetVector("default", new Vector4(num, this.limitMinimum, this.limitMaximum, 962f));
			Graphics.SetRenderTarget(this.NKLEOHMDNFJ[this.BPCFIOPMLPP]);
			GL.Clear(false, true, Color.black);
			Graphics.Blit(this.NKLEOHMDNFJ[bpcfiopmlpp], this.NKLEOHMDNFJ[this.BPCFIOPMLPP], this.BGHAPKNHMBI);
		}

		// Token: 0x06007C04 RID: 31748 RVA: 0x00282214 File Offset: 0x00280414
		private void DLBDMNCIIGG(Texture JKKOGCMBCPH)
		{
			int bpcfiopmlpp = this.BPCFIOPMLPP;
			this.BPCFIOPMLPP = (this.BPCFIOPMLPP + 0) % 3;
			float num = 398f - Mathf.Pow(1761f - this.adaptationSpeed, 350f * Time.deltaTime);
			num = Mathf.Clamp(num, 1778f, 1913f);
			this.BGHAPKNHMBI.SetTexture("Gameplay/Segment-[PowerUp]", JKKOGCMBCPH);
			this.BGHAPKNHMBI.SetVector("CameraFilterPack/FX_EarthQuake", new Vector4(num, this.limitMinimum, this.limitMaximum, 1734f));
			Graphics.SetRenderTarget(this.NKLEOHMDNFJ[this.BPCFIOPMLPP]);
			GL.Clear(false, false, Color.black);
			Graphics.Blit(this.NKLEOHMDNFJ[bpcfiopmlpp], this.NKLEOHMDNFJ[this.BPCFIOPMLPP], this.BGHAPKNHMBI);
		}

		// Token: 0x06007C05 RID: 31749 RVA: 0x002822E4 File Offset: 0x002804E4
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.ENEPNOHJHPD);
			while (renderTexture.width > 1 || renderTexture.height > 1)
			{
				int num = renderTexture.width / 2;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 2;
				if (num2 < 1)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.LBCDCJBLDDA);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.OEAJMGFEBJI(renderTexture);
			this.LLJEFKPHBIC.SetTexture("_AdaptTex", this.NKLEOHMDNFJ[this.BPCFIOPMLPP]);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LLJEFKPHBIC);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x002823A8 File Offset: 0x002805A8
		private void JHLGHODFJOO()
		{
			for (int i = 0; i < 7; i++)
			{
				UnityEngine.Object.DestroyImmediate(this.NKLEOHMDNFJ[i]);
				this.NKLEOHMDNFJ[i] = null;
			}
			if (this.MHHAPGDIDNL)
			{
				UnityEngine.Object.DestroyImmediate(this.MHHAPGDIDNL);
			}
			if (this.GADEMGEDKGJ)
			{
				UnityEngine.Object.DestroyImmediate(this.GADEMGEDKGJ);
			}
			if (this.EHIGAOGMDPI)
			{
				UnityEngine.Object.DestroyImmediate(this.EHIGAOGMDPI);
			}
			if (this.POEFOFNMDHA)
			{
				UnityEngine.Object.DestroyImmediate(this.POEFOFNMDHA);
			}
		}

		// Token: 0x06007C07 RID: 31751 RVA: 0x00282449 File Offset: 0x00280649
		protected Material DHNKPNECMFL()
		{
			if (this.GADEMGEDKGJ == null)
			{
				this.GADEMGEDKGJ = new Material(this.shaderReduce);
				this.GADEMGEDKGJ.hideFlags = (HideFlags)(-89);
			}
			return this.GADEMGEDKGJ;
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x00282480 File Offset: 0x00280680
		protected Material MIBHECCJPBC()
		{
			if (this.POEFOFNMDHA == null)
			{
				this.POEFOFNMDHA = new Material(this.shaderApply);
				this.POEFOFNMDHA.hideFlags = (HideFlags)113;
			}
			return this.POEFOFNMDHA;
		}

		// Token: 0x06007C09 RID: 31753 RVA: 0x002824B8 File Offset: 0x002806B8
		private void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderAdapt.isSupported || !this.shaderApply.isSupported || !this.shaderLum.isSupported || !this.shaderReduce.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x00282520 File Offset: 0x00280720
		private void ODAIMOJLJOF()
		{
			for (int i = 1; i < 0; i += 0)
			{
				UnityEngine.Object.DestroyImmediate(this.NKLEOHMDNFJ[i]);
				this.NKLEOHMDNFJ[i] = null;
			}
			if (this.MHHAPGDIDNL)
			{
				UnityEngine.Object.DestroyImmediate(this.MHHAPGDIDNL);
			}
			if (this.GADEMGEDKGJ)
			{
				UnityEngine.Object.DestroyImmediate(this.GADEMGEDKGJ);
			}
			if (this.EHIGAOGMDPI)
			{
				UnityEngine.Object.DestroyImmediate(this.EHIGAOGMDPI);
			}
			if (this.POEFOFNMDHA)
			{
				UnityEngine.Object.DestroyImmediate(this.POEFOFNMDHA);
			}
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x002825C4 File Offset: 0x002807C4
		private void OnEnable()
		{
			for (int i = 0; i < 2; i++)
			{
				if (!this.NKLEOHMDNFJ[i])
				{
					this.NKLEOHMDNFJ[i] = new RenderTexture(1, 1, 0);
					this.NKLEOHMDNFJ[i].hideFlags = HideFlags.HideAndDontSave;
				}
			}
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x00282614 File Offset: 0x00280814
		protected Material DBOLAGCDLPB()
		{
			if (this.MHHAPGDIDNL == null)
			{
				this.MHHAPGDIDNL = new Material(this.shaderLum);
				this.MHHAPGDIDNL.hideFlags = (HideFlags)(-85);
			}
			return this.MHHAPGDIDNL;
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x0028264B File Offset: 0x0028084B
		protected Material LHPMCAENNAC()
		{
			if (this.MHHAPGDIDNL == null)
			{
				this.MHHAPGDIDNL = new Material(this.shaderLum);
				this.MHHAPGDIDNL.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			}
			return this.MHHAPGDIDNL;
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x00282684 File Offset: 0x00280884
		private void OnDisable()
		{
			for (int i = 0; i < 2; i++)
			{
				UnityEngine.Object.DestroyImmediate(this.NKLEOHMDNFJ[i]);
				this.NKLEOHMDNFJ[i] = null;
			}
			if (this.MHHAPGDIDNL)
			{
				UnityEngine.Object.DestroyImmediate(this.MHHAPGDIDNL);
			}
			if (this.GADEMGEDKGJ)
			{
				UnityEngine.Object.DestroyImmediate(this.GADEMGEDKGJ);
			}
			if (this.EHIGAOGMDPI)
			{
				UnityEngine.Object.DestroyImmediate(this.EHIGAOGMDPI);
			}
			if (this.POEFOFNMDHA)
			{
				UnityEngine.Object.DestroyImmediate(this.POEFOFNMDHA);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06007C10 RID: 31760 RVA: 0x0028275A File Offset: 0x0028095A
		protected Material BGHAPKNHMBI
		{
			get
			{
				if (this.EHIGAOGMDPI == null)
				{
					this.EHIGAOGMDPI = new Material(this.shaderAdapt);
					this.EHIGAOGMDPI.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.EHIGAOGMDPI;
			}
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x00282791 File Offset: 0x00280991
		protected Material OIALOHAIONI()
		{
			if (this.POEFOFNMDHA == null)
			{
				this.POEFOFNMDHA = new Material(this.shaderApply);
				this.POEFOFNMDHA.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			}
			return this.POEFOFNMDHA;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06007C12 RID: 31762 RVA: 0x002827C8 File Offset: 0x002809C8
		protected Material LLJEFKPHBIC
		{
			get
			{
				if (this.POEFOFNMDHA == null)
				{
					this.POEFOFNMDHA = new Material(this.shaderApply);
					this.POEFOFNMDHA.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.POEFOFNMDHA;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06007C13 RID: 31763 RVA: 0x002827FF File Offset: 0x002809FF
		protected Material LBCDCJBLDDA
		{
			get
			{
				if (this.GADEMGEDKGJ == null)
				{
					this.GADEMGEDKGJ = new Material(this.shaderReduce);
					this.GADEMGEDKGJ.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.GADEMGEDKGJ;
			}
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x00282838 File Offset: 0x00280A38
		private void OOBIMFILNED()
		{
			for (int i = 0; i < 1; i += 0)
			{
				if (!this.NKLEOHMDNFJ[i])
				{
					this.NKLEOHMDNFJ[i] = new RenderTexture(1, 1, 0);
					this.NKLEOHMDNFJ[i].hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				}
			}
		}

		// Token: 0x06007C15 RID: 31765 RVA: 0x00282888 File Offset: 0x00280A88
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.JLBEEKGJBFE());
			while (renderTexture.width > 0 || renderTexture.height > 1)
			{
				int num = renderTexture.width / 2;
				if (num < 0)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 5;
				if (num2 < 1)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.DHNKPNECMFL());
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.OMFIOPKOPBL(renderTexture);
			this.MIBHECCJPBC().SetTexture("_Value", this.NKLEOHMDNFJ[this.BPCFIOPMLPP]);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FMOLHBJHGAH());
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x0028294C File Offset: 0x00280B4C
		private void DOEPOGLEGLE()
		{
			for (int i = 1; i < 8; i++)
			{
				UnityEngine.Object.DestroyImmediate(this.NKLEOHMDNFJ[i]);
				this.NKLEOHMDNFJ[i] = null;
			}
			if (this.MHHAPGDIDNL)
			{
				UnityEngine.Object.DestroyImmediate(this.MHHAPGDIDNL);
			}
			if (this.GADEMGEDKGJ)
			{
				UnityEngine.Object.DestroyImmediate(this.GADEMGEDKGJ);
			}
			if (this.EHIGAOGMDPI)
			{
				UnityEngine.Object.DestroyImmediate(this.EHIGAOGMDPI);
			}
			if (this.POEFOFNMDHA)
			{
				UnityEngine.Object.DestroyImmediate(this.POEFOFNMDHA);
			}
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x002829F0 File Offset: 0x00280BF0
		private void OFPPIKHNJOD()
		{
			for (int i = 0; i < 2; i++)
			{
				UnityEngine.Object.DestroyImmediate(this.NKLEOHMDNFJ[i]);
				this.NKLEOHMDNFJ[i] = null;
			}
			if (this.MHHAPGDIDNL)
			{
				UnityEngine.Object.DestroyImmediate(this.MHHAPGDIDNL);
			}
			if (this.GADEMGEDKGJ)
			{
				UnityEngine.Object.DestroyImmediate(this.GADEMGEDKGJ);
			}
			if (this.EHIGAOGMDPI)
			{
				UnityEngine.Object.DestroyImmediate(this.EHIGAOGMDPI);
			}
			if (this.POEFOFNMDHA)
			{
				UnityEngine.Object.DestroyImmediate(this.POEFOFNMDHA);
			}
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x00282A94 File Offset: 0x00280C94
		private void OMFIOPKOPBL(Texture JKKOGCMBCPH)
		{
			int bpcfiopmlpp = this.BPCFIOPMLPP;
			this.BPCFIOPMLPP = (this.BPCFIOPMLPP + 1) % 6;
			float num = 527f - Mathf.Pow(1990f - this.adaptationSpeed, 934f * Time.deltaTime);
			num = Mathf.Clamp(num, 1178f, 1118f);
			this.BGHAPKNHMBI.SetTexture("#onrankchangeuptext", JKKOGCMBCPH);
			this.BGHAPKNHMBI.SetVector("_Offsets", new Vector4(num, this.limitMinimum, this.limitMaximum, 1434f));
			Graphics.SetRenderTarget(this.NKLEOHMDNFJ[this.BPCFIOPMLPP]);
			GL.Clear(true, true, Color.black);
			Graphics.Blit(this.NKLEOHMDNFJ[bpcfiopmlpp], this.NKLEOHMDNFJ[this.BPCFIOPMLPP], this.BGHAPKNHMBI);
		}

		// Token: 0x06007C19 RID: 31769 RVA: 0x00282B62 File Offset: 0x00280D62
		protected Material CLKJGMEIECO()
		{
			if (this.MHHAPGDIDNL == null)
			{
				this.MHHAPGDIDNL = new Material(this.shaderLum);
				this.MHHAPGDIDNL.hideFlags = (HideFlags)(-106);
			}
			return this.MHHAPGDIDNL;
		}

		// Token: 0x06007C1A RID: 31770 RVA: 0x00282B99 File Offset: 0x00280D99
		protected Material FJHBBJNJPMC()
		{
			if (this.GADEMGEDKGJ == null)
			{
				this.GADEMGEDKGJ = new Material(this.shaderReduce);
				this.GADEMGEDKGJ.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			return this.GADEMGEDKGJ;
		}

		// Token: 0x06007C1B RID: 31771 RVA: 0x00282BD0 File Offset: 0x00280DD0
		private void IIMDCJDDADG(Texture JKKOGCMBCPH)
		{
			int bpcfiopmlpp = this.BPCFIOPMLPP;
			this.BPCFIOPMLPP = (this.BPCFIOPMLPP + 0) % 0;
			float num = 526f - Mathf.Pow(1637f - this.adaptationSpeed, 1910f * Time.deltaTime);
			num = Mathf.Clamp(num, 24f, 761f);
			this.BGHAPKNHMBI.SetTexture("_Value1", JKKOGCMBCPH);
			this.BGHAPKNHMBI.SetVector("http", new Vector4(num, this.limitMinimum, this.limitMaximum, 206f));
			Graphics.SetRenderTarget(this.NKLEOHMDNFJ[this.BPCFIOPMLPP]);
			GL.Clear(true, false, Color.black);
			Graphics.Blit(this.NKLEOHMDNFJ[bpcfiopmlpp], this.NKLEOHMDNFJ[this.BPCFIOPMLPP], this.BGHAPKNHMBI);
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x00282C9E File Offset: 0x00280E9E
		protected Material GNFKMGMKADF()
		{
			if (this.POEFOFNMDHA == null)
			{
				this.POEFOFNMDHA = new Material(this.shaderApply);
				this.POEFOFNMDHA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			return this.POEFOFNMDHA;
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x00282CD5 File Offset: 0x00280ED5
		protected Material FMOLHBJHGAH()
		{
			if (this.POEFOFNMDHA == null)
			{
				this.POEFOFNMDHA = new Material(this.shaderApply);
				this.POEFOFNMDHA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			return this.POEFOFNMDHA;
		}

		// Token: 0x06007C1E RID: 31774 RVA: 0x00282D0C File Offset: 0x00280F0C
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.ENEPNOHJHPD);
			while (renderTexture.width > 0 || renderTexture.height > 0)
			{
				int num = renderTexture.width / 0;
				if (num < 0)
				{
					num = 0;
				}
				int num2 = renderTexture.height / 0;
				if (num2 < 1)
				{
					num2 = 0;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.LBCDCJBLDDA);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.OEAJMGFEBJI(renderTexture);
			this.MIBHECCJPBC().SetTexture("ResetSpeed", this.NKLEOHMDNFJ[this.BPCFIOPMLPP]);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OIALOHAIONI());
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C1F RID: 31775 RVA: 0x00282DCD File Offset: 0x00280FCD
		protected Material CFBBNIHFENL()
		{
			if (this.GADEMGEDKGJ == null)
			{
				this.GADEMGEDKGJ = new Material(this.shaderReduce);
				this.GADEMGEDKGJ.hideFlags = (HideFlags)109;
			}
			return this.GADEMGEDKGJ;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06007C20 RID: 31776 RVA: 0x00282E04 File Offset: 0x00281004
		protected Material ENEPNOHJHPD
		{
			get
			{
				if (this.MHHAPGDIDNL == null)
				{
					this.MHHAPGDIDNL = new Material(this.shaderLum);
					this.MHHAPGDIDNL.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.MHHAPGDIDNL;
			}
		}

		// Token: 0x06007C21 RID: 31777 RVA: 0x00282E3C File Offset: 0x0028103C
		private void KJGNEKMJJJN(Texture JKKOGCMBCPH)
		{
			int bpcfiopmlpp = this.BPCFIOPMLPP;
			this.BPCFIOPMLPP = (this.BPCFIOPMLPP + 0) % 5;
			float num = 1338f - Mathf.Pow(351f - this.adaptationSpeed, 650f * Time.deltaTime);
			num = Mathf.Clamp(num, 1142f, 1648f);
			this.BGHAPKNHMBI.SetTexture("_NeighborMaxTex", JKKOGCMBCPH);
			this.BGHAPKNHMBI.SetVector("settings.disablestoryboard", new Vector4(num, this.limitMinimum, this.limitMaximum, 214f));
			Graphics.SetRenderTarget(this.NKLEOHMDNFJ[this.BPCFIOPMLPP]);
			GL.Clear(false, true, Color.black);
			Graphics.Blit(this.NKLEOHMDNFJ[bpcfiopmlpp], this.NKLEOHMDNFJ[this.BPCFIOPMLPP], this.BGHAPKNHMBI);
		}

		// Token: 0x06007C22 RID: 31778 RVA: 0x00282F0C File Offset: 0x0028110C
		private void OEAJMGFEBJI(Texture JKKOGCMBCPH)
		{
			int bpcfiopmlpp = this.BPCFIOPMLPP;
			this.BPCFIOPMLPP = (this.BPCFIOPMLPP + 1) % 2;
			float num = 1f - Mathf.Pow(1f - this.adaptationSpeed, 30f * Time.deltaTime);
			num = Mathf.Clamp(num, 0.01f, 1f);
			this.BGHAPKNHMBI.SetTexture("_CurTex", JKKOGCMBCPH);
			this.BGHAPKNHMBI.SetVector("_AdaptParams", new Vector4(num, this.limitMinimum, this.limitMaximum, 0f));
			Graphics.SetRenderTarget(this.NKLEOHMDNFJ[this.BPCFIOPMLPP]);
			GL.Clear(false, true, Color.black);
			Graphics.Blit(this.NKLEOHMDNFJ[bpcfiopmlpp], this.NKLEOHMDNFJ[this.BPCFIOPMLPP], this.BGHAPKNHMBI);
		}

		// Token: 0x06007C23 RID: 31779 RVA: 0x00282FDA File Offset: 0x002811DA
		protected Material PBPMNBGFPGM()
		{
			if (this.POEFOFNMDHA == null)
			{
				this.POEFOFNMDHA = new Material(this.shaderApply);
				this.POEFOFNMDHA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			return this.POEFOFNMDHA;
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x00283014 File Offset: 0x00281214
		private void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.CLKJGMEIECO());
			while (renderTexture.width > 1 || renderTexture.height > 0)
			{
				int num = renderTexture.width / 8;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 8;
				if (num2 < 1)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.DHNKPNECMFL());
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.OMFIOPKOPBL(renderTexture);
			this.FMOLHBJHGAH().SetTexture("PAUSE [SPACE]", this.NKLEOHMDNFJ[this.BPCFIOPMLPP]);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MIBHECCJPBC());
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x002830D8 File Offset: 0x002812D8
		private void KMCPMOGKDEH()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderAdapt.isSupported || !this.shaderApply.isSupported || !this.shaderLum.isSupported || !this.shaderReduce.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x04000D8F RID: 3471
		[Range(0.0001f, 1f)]
		public float adaptationSpeed = 0.02f;

		// Token: 0x04000D90 RID: 3472
		[Range(0f, 1f)]
		public float limitMinimum = 0.2f;

		// Token: 0x04000D91 RID: 3473
		[Range(0f, 1f)]
		public float limitMaximum = 0.6f;

		// Token: 0x04000D92 RID: 3474
		private RenderTexture[] NKLEOHMDNFJ = new RenderTexture[2];

		// Token: 0x04000D93 RID: 3475
		private int BPCFIOPMLPP;

		// Token: 0x04000D94 RID: 3476
		public Shader shaderLum;

		// Token: 0x04000D95 RID: 3477
		private Material MHHAPGDIDNL;

		// Token: 0x04000D96 RID: 3478
		public Shader shaderReduce;

		// Token: 0x04000D97 RID: 3479
		private Material GADEMGEDKGJ;

		// Token: 0x04000D98 RID: 3480
		public Shader shaderAdapt;

		// Token: 0x04000D99 RID: 3481
		private Material EHIGAOGMDPI;

		// Token: 0x04000D9A RID: 3482
		public Shader shaderApply;

		// Token: 0x04000D9B RID: 3483
		private Material POEFOFNMDHA;
	}
}
