using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001DD RID: 477
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		// Token: 0x06007C8E RID: 31886 RVA: 0x0028AFF4 File Offset: 0x002891F4
		private void AFPDNPCJNFP(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, DepthOfFieldDeprecated.DofBlurriness OGFJPFIMOHG, int PMEDOCEEAHL, float MJFBFHDCCLE)
		{
			this.FKAKEHJOIDL.SetTexture("In Map Editor", BHNGOLDNELC);
			RenderTexture temporary = RenderTexture.GetTemporary(HANEOLNMOEF.width, HANEOLNMOEF.height);
			if (OGFJPFIMOHG > (DepthOfFieldDeprecated.DofBlurriness)0)
			{
				this.CFBPFHHIPEK(BHNGOLDNELC, HANEOLNMOEF, PMEDOCEEAHL, MJFBFHDCCLE, temporary);
				if (OGFJPFIMOHG > (DepthOfFieldDeprecated.DofBlurriness)8)
				{
					this.FKAKEHJOIDL.SetVector("_CenterX", new Vector4(1166f, MJFBFHDCCLE * this.NMOLKKBMGEC, 590f, 568f));
					Graphics.Blit(HANEOLNMOEF, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
					this.FKAKEHJOIDL.SetVector("LivesSlider", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 1341f, 455f, 1363f));
					Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
				}
			}
			else
			{
				this.FKAKEHJOIDL.SetVector("Joystick1Button1", new Vector4(1148f, MJFBFHDCCLE * this.NMOLKKBMGEC, 362f, 1137f));
				Graphics.Blit(BHNGOLDNELC, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
				this.FKAKEHJOIDL.SetVector("Crosshair1", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 1142f, 553f, 1851f));
				Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x0028B148 File Offset: 0x00289348
		private void COGPAKANEKA()
		{
			this.FKAKEHJOIDL = base.ECNEGNMAMDE(this.dofBlurShader, this.FKAKEHJOIDL);
			this.HBIFCBKMMDC = base.ECNEGNMAMDE(this.dofShader, this.HBIFCBKMMDC);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.OEPNIHPDAHN = base.NODBMINMALP(this.bokehShader, this.OEPNIHPDAHN);
			}
		}

		// Token: 0x06007C90 RID: 31888 RVA: 0x0028B1D4 File Offset: 0x002893D4
		private float KJMFPJKGLOE(float JOCAFKLENDG)
		{
			return this.CNMFDOINHOL.WorldToViewportPoint((JOCAFKLENDG - this.CNMFDOINHOL.nearClipPlane) * this.CNMFDOINHOL.transform.forward + this.CNMFDOINHOL.transform.position).z / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x0028B243 File Offset: 0x00289443
		private void HGJKBDGABKM()
		{
			this.CNMFDOINHOL = base.GetComponent<Camera>();
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007C92 RID: 31890 RVA: 0x0028B264 File Offset: 0x00289464
		private int CMJKCCMFFPO(int KIHHCOMDHBL)
		{
			int num = KIHHCOMDHBL;
			if (this.resolution == DepthOfFieldDeprecated.DofResolution.Low)
			{
				num *= 4;
			}
			if (this.resolution == (DepthOfFieldDeprecated.DofResolution)8)
			{
				num *= 1;
			}
			return num;
		}

		// Token: 0x06007C93 RID: 31891 RVA: 0x0028B294 File Offset: 0x00289494
		public virtual bool NHCNNDEHICD()
		{
			base.DCHKKHDGBLJ(true);
			this.FKAKEHJOIDL = base.GJKHKCOAFDB(this.dofBlurShader, this.FKAKEHJOIDL);
			this.HBIFCBKMMDC = base.LKIJNGDHLAK(this.dofShader, this.HBIFCBKMMDC);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.OEPNIHPDAHN = base.GJKHKCOAFDB(this.bokehShader, this.OEPNIHPDAHN);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C94 RID: 31892 RVA: 0x0028B340 File Offset: 0x00289540
		private void PILIBPCEPOK(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, int PMEDOCEEAHL, float MJFBFHDCCLE, RenderTexture GEEGEOCEKDA)
		{
			this.FKAKEHJOIDL.SetVector("OperationResponse ignored while disconnecting. Code: ", new Vector4(229f, MJFBFHDCCLE * this.NMOLKKBMGEC, 851f, 911f));
			Graphics.Blit(BHNGOLDNELC, GEEGEOCEKDA, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("NO", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 542f, 156f, 1387f));
			Graphics.Blit(GEEGEOCEKDA, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("Drop_Floor_Fluid", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, MJFBFHDCCLE * this.NMOLKKBMGEC, 1000f, 342f));
			Graphics.Blit(HANEOLNMOEF, GEEGEOCEKDA, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("_TimeX", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, -MJFBFHDCCLE * this.NMOLKKBMGEC, 652f, 1076f));
			Graphics.Blit(GEEGEOCEKDA, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
		}

		// Token: 0x06007C95 RID: 31893 RVA: 0x0028B45C File Offset: 0x0028965C
		private int BMIBPGEPLCC(int KIHHCOMDHBL)
		{
			int num = KIHHCOMDHBL;
			if (this.resolution == DepthOfFieldDeprecated.DofResolution.Low)
			{
				num *= 4;
			}
			if (this.resolution == (DepthOfFieldDeprecated.DofResolution)1)
			{
				num *= 4;
			}
			return num;
		}

		// Token: 0x06007C96 RID: 31894 RVA: 0x0028B48C File Offset: 0x0028968C
		private void GKOMKJHNMLO(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, DepthOfFieldDeprecated.DofBlurriness OGFJPFIMOHG, int PMEDOCEEAHL, float MJFBFHDCCLE)
		{
			this.FKAKEHJOIDL.SetTexture("_TapHigh", BHNGOLDNELC);
			RenderTexture temporary = RenderTexture.GetTemporary(HANEOLNMOEF.width, HANEOLNMOEF.height);
			if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.Low)
			{
				this.CFBPFHHIPEK(BHNGOLDNELC, HANEOLNMOEF, PMEDOCEEAHL, MJFBFHDCCLE, temporary);
				if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.High)
				{
					this.FKAKEHJOIDL.SetVector("offsets", new Vector4(0f, MJFBFHDCCLE * this.NMOLKKBMGEC, 0f, 0f));
					Graphics.Blit(HANEOLNMOEF, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
					this.FKAKEHJOIDL.SetVector("offsets", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 0f, 0f, 0f));
					Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
				}
			}
			else
			{
				this.FKAKEHJOIDL.SetVector("offsets", new Vector4(0f, MJFBFHDCCLE * this.NMOLKKBMGEC, 0f, 0f));
				Graphics.Blit(BHNGOLDNELC, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
				this.FKAKEHJOIDL.SetVector("offsets", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 0f, 0f, 0f));
				Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007C97 RID: 31895 RVA: 0x0028B243 File Offset: 0x00289443
		private void OnEnable()
		{
			this.CNMFDOINHOL = base.GetComponent<Camera>();
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007C98 RID: 31896 RVA: 0x0028B5E0 File Offset: 0x002897E0
		private void PKIFLMLPOAD()
		{
			if (this.HEBNMCEPMDH)
			{
				RenderTexture.ReleaseTemporary(this.HEBNMCEPMDH);
			}
			if (this.ELEJLIKAEBC)
			{
				RenderTexture.ReleaseTemporary(this.ELEJLIKAEBC);
			}
			if (this.LFOOOIHIFIL)
			{
				RenderTexture.ReleaseTemporary(this.LFOOOIHIFIL);
			}
			if (this.HHKOGNNEKON)
			{
				RenderTexture.ReleaseTemporary(this.HHKOGNNEKON);
			}
			if (this.BOFPPGCEIDO)
			{
				RenderTexture.ReleaseTemporary(this.BOFPPGCEIDO);
			}
			if (this.CEPKBFEEIFC)
			{
				RenderTexture.ReleaseTemporary(this.CEPKBFEEIFC);
			}
		}

		// Token: 0x06007C99 RID: 31897 RVA: 0x0028B690 File Offset: 0x00289890
		private void LHBMOKOHNKC(bool NLEPGIPJPLL, RenderTexture HLBKCLPNHEB, int IMDGFHEAHLC, int NFFHBDFFINP)
		{
			this.HEBNMCEPMDH = null;
			if (NLEPGIPJPLL)
			{
				this.HEBNMCEPMDH = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
			}
			this.LFOOOIHIFIL = RenderTexture.GetTemporary(HLBKCLPNHEB.width / IMDGFHEAHLC, HLBKCLPNHEB.height / IMDGFHEAHLC, 0);
			this.ELEJLIKAEBC = RenderTexture.GetTemporary(HLBKCLPNHEB.width / IMDGFHEAHLC, HLBKCLPNHEB.height / IMDGFHEAHLC, 1);
			this.HHKOGNNEKON = RenderTexture.GetTemporary(HLBKCLPNHEB.width / NFFHBDFFINP, HLBKCLPNHEB.height / NFFHBDFFINP, 1);
			this.BOFPPGCEIDO = null;
			this.CEPKBFEEIFC = null;
			if (this.bokeh)
			{
				this.BOFPPGCEIDO = RenderTexture.GetTemporary(HLBKCLPNHEB.width / (NFFHBDFFINP * this.bokehDownsample), HLBKCLPNHEB.height / (NFFHBDFFINP * this.bokehDownsample), 1, RenderTextureFormat.ARGB2101010);
				this.CEPKBFEEIFC = RenderTexture.GetTemporary(HLBKCLPNHEB.width / (NFFHBDFFINP * this.bokehDownsample), HLBKCLPNHEB.height / (NFFHBDFFINP * this.bokehDownsample), 0, RenderTextureFormat.Default);
				this.BOFPPGCEIDO.filterMode = FilterMode.Point;
				this.CEPKBFEEIFC.filterMode = FilterMode.Point;
				RenderTexture.active = this.CEPKBFEEIFC;
				GL.Clear(true, false, new Color(1547f, 1871f, 344f, 788f));
			}
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			this.ELEJLIKAEBC.filterMode = FilterMode.Point;
			this.LFOOOIHIFIL.filterMode = FilterMode.Bilinear;
			this.HHKOGNNEKON.filterMode = FilterMode.Point;
			if (this.HEBNMCEPMDH)
			{
				this.HEBNMCEPMDH.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x06007C9A RID: 31898 RVA: 0x0028B818 File Offset: 0x00289A18
		private void CCIKKFFAHFI(bool NLEPGIPJPLL, RenderTexture HLBKCLPNHEB, int IMDGFHEAHLC, int NFFHBDFFINP)
		{
			this.HEBNMCEPMDH = null;
			if (NLEPGIPJPLL)
			{
				this.HEBNMCEPMDH = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
			}
			this.LFOOOIHIFIL = RenderTexture.GetTemporary(HLBKCLPNHEB.width / IMDGFHEAHLC, HLBKCLPNHEB.height / IMDGFHEAHLC, 0);
			this.ELEJLIKAEBC = RenderTexture.GetTemporary(HLBKCLPNHEB.width / IMDGFHEAHLC, HLBKCLPNHEB.height / IMDGFHEAHLC, 0);
			this.HHKOGNNEKON = RenderTexture.GetTemporary(HLBKCLPNHEB.width / NFFHBDFFINP, HLBKCLPNHEB.height / NFFHBDFFINP, 0);
			this.BOFPPGCEIDO = null;
			this.CEPKBFEEIFC = null;
			if (this.bokeh)
			{
				this.BOFPPGCEIDO = RenderTexture.GetTemporary(HLBKCLPNHEB.width / (NFFHBDFFINP * this.bokehDownsample), HLBKCLPNHEB.height / (NFFHBDFFINP * this.bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				this.CEPKBFEEIFC = RenderTexture.GetTemporary(HLBKCLPNHEB.width / (NFFHBDFFINP * this.bokehDownsample), HLBKCLPNHEB.height / (NFFHBDFFINP * this.bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				this.BOFPPGCEIDO.filterMode = FilterMode.Bilinear;
				this.CEPKBFEEIFC.filterMode = FilterMode.Bilinear;
				RenderTexture.active = this.CEPKBFEEIFC;
				GL.Clear(false, true, new Color(0f, 0f, 0f, 0f));
			}
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			this.ELEJLIKAEBC.filterMode = FilterMode.Bilinear;
			this.LFOOOIHIFIL.filterMode = FilterMode.Bilinear;
			this.HHKOGNNEKON.filterMode = FilterMode.Bilinear;
			if (this.HEBNMCEPMDH)
			{
				this.HEBNMCEPMDH.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x06007C9B RID: 31899 RVA: 0x0028B9A0 File Offset: 0x00289BA0
		private int HFGJNDIAMME(int KIHHCOMDHBL)
		{
			int num = KIHHCOMDHBL;
			if (this.resolution == DepthOfFieldDeprecated.DofResolution.High)
			{
				num *= 2;
			}
			if (this.resolution == DepthOfFieldDeprecated.DofResolution.Low)
			{
				num *= 2;
			}
			return num;
		}

		// Token: 0x06007C9C RID: 31900 RVA: 0x0028B243 File Offset: 0x00289443
		private void LGELACBDPEH()
		{
			this.CNMFDOINHOL = base.GetComponent<Camera>();
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007C9D RID: 31901 RVA: 0x0028B9D0 File Offset: 0x00289BD0
		private void OIIGDOOEECN(bool NLEPGIPJPLL, RenderTexture HLBKCLPNHEB, int IMDGFHEAHLC, int NFFHBDFFINP)
		{
			this.HEBNMCEPMDH = null;
			if (NLEPGIPJPLL)
			{
				this.HEBNMCEPMDH = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
			}
			this.LFOOOIHIFIL = RenderTexture.GetTemporary(HLBKCLPNHEB.width / IMDGFHEAHLC, HLBKCLPNHEB.height / IMDGFHEAHLC, 0);
			this.ELEJLIKAEBC = RenderTexture.GetTemporary(HLBKCLPNHEB.width / IMDGFHEAHLC, HLBKCLPNHEB.height / IMDGFHEAHLC, 0);
			this.HHKOGNNEKON = RenderTexture.GetTemporary(HLBKCLPNHEB.width / NFFHBDFFINP, HLBKCLPNHEB.height / NFFHBDFFINP, 0);
			this.BOFPPGCEIDO = null;
			this.CEPKBFEEIFC = null;
			if (this.bokeh)
			{
				this.BOFPPGCEIDO = RenderTexture.GetTemporary(HLBKCLPNHEB.width / (NFFHBDFFINP * this.bokehDownsample), HLBKCLPNHEB.height / (NFFHBDFFINP * this.bokehDownsample), 1, RenderTextureFormat.ARGB2101010);
				this.CEPKBFEEIFC = RenderTexture.GetTemporary(HLBKCLPNHEB.width / (NFFHBDFFINP * this.bokehDownsample), HLBKCLPNHEB.height / (NFFHBDFFINP * this.bokehDownsample), 1, RenderTextureFormat.Depth);
				this.BOFPPGCEIDO.filterMode = FilterMode.Bilinear;
				this.CEPKBFEEIFC.filterMode = FilterMode.Point;
				RenderTexture.active = this.CEPKBFEEIFC;
				GL.Clear(false, true, new Color(880f, 1361f, 1657f, 1403f));
			}
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			this.ELEJLIKAEBC.filterMode = FilterMode.Bilinear;
			this.LFOOOIHIFIL.filterMode = FilterMode.Point;
			this.HHKOGNNEKON.filterMode = FilterMode.Bilinear;
			if (this.HEBNMCEPMDH)
			{
				this.HEBNMCEPMDH.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x06007C9E RID: 31902 RVA: 0x0028BB58 File Offset: 0x00289D58
		private void EAAIFEBIIBG(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, DepthOfFieldDeprecated.DofBlurriness OGFJPFIMOHG, int PMEDOCEEAHL, float MJFBFHDCCLE)
		{
			this.FKAKEHJOIDL.SetTexture("CameraFilterPack/Blend2Camera_Divide", BHNGOLDNELC);
			RenderTexture temporary = RenderTexture.GetTemporary(HANEOLNMOEF.width, HANEOLNMOEF.height);
			if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.Low)
			{
				this.PILIBPCEPOK(BHNGOLDNELC, HANEOLNMOEF, PMEDOCEEAHL, MJFBFHDCCLE, temporary);
				if (OGFJPFIMOHG > (DepthOfFieldDeprecated.DofBlurriness)8)
				{
					this.FKAKEHJOIDL.SetVector("0.00", new Vector4(1246f, MJFBFHDCCLE * this.NMOLKKBMGEC, 1373f, 1990f));
					Graphics.Blit(HANEOLNMOEF, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
					this.FKAKEHJOIDL.SetVector("[EditorEvent] Exception: ", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 1251f, 1357f, 680f));
					Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
				}
			}
			else
			{
				this.FKAKEHJOIDL.SetVector("_VelocityTex", new Vector4(1511f, MJFBFHDCCLE * this.NMOLKKBMGEC, 1232f, 1675f));
				Graphics.Blit(BHNGOLDNELC, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
				this.FKAKEHJOIDL.SetVector("Tab1Content", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 1876f, 1204f, 271f));
				Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007C9F RID: 31903 RVA: 0x0028BCAC File Offset: 0x00289EAC
		private void AFHDKJFDLCJ()
		{
			if (this.HEBNMCEPMDH)
			{
				RenderTexture.ReleaseTemporary(this.HEBNMCEPMDH);
			}
			if (this.ELEJLIKAEBC)
			{
				RenderTexture.ReleaseTemporary(this.ELEJLIKAEBC);
			}
			if (this.LFOOOIHIFIL)
			{
				RenderTexture.ReleaseTemporary(this.LFOOOIHIFIL);
			}
			if (this.HHKOGNNEKON)
			{
				RenderTexture.ReleaseTemporary(this.HHKOGNNEKON);
			}
			if (this.BOFPPGCEIDO)
			{
				RenderTexture.ReleaseTemporary(this.BOFPPGCEIDO);
			}
			if (this.CEPKBFEEIFC)
			{
				RenderTexture.ReleaseTemporary(this.CEPKBFEEIFC);
			}
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x0028BD5B File Offset: 0x00289F5B
		private void IMGGCJICLHK()
		{
			MLLAJENMBFL.ALPNBMHLMOP();
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x0028BD64 File Offset: 0x00289F64
		private void NFPCLHOGCDB()
		{
			this.FKAKEHJOIDL = base.EDFIBHNHAAB(this.dofBlurShader, this.FKAKEHJOIDL);
			this.HBIFCBKMMDC = base.EDFIBHNHAAB(this.dofShader, this.HBIFCBKMMDC);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.OEPNIHPDAHN = base.EDFIBHNHAAB(this.bokehShader, this.OEPNIHPDAHN);
			}
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x0028BDF0 File Offset: 0x00289FF0
		private void LFMPBIIKIAM(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, DepthOfFieldDeprecated.DofBlurriness OGFJPFIMOHG, int PMEDOCEEAHL, float MJFBFHDCCLE)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(HANEOLNMOEF.width, HANEOLNMOEF.height);
			if (OGFJPFIMOHG > (DepthOfFieldDeprecated.DofBlurriness)0)
			{
				this.PILIBPCEPOK(BHNGOLDNELC, HANEOLNMOEF, PMEDOCEEAHL, MJFBFHDCCLE, temporary);
				if (OGFJPFIMOHG > (DepthOfFieldDeprecated.DofBlurriness)7)
				{
					this.FKAKEHJOIDL.SetVector("_TimeX", new Vector4(708f, MJFBFHDCCLE * this.NMOLKKBMGEC, 142f, 1595f));
					Graphics.Blit(HANEOLNMOEF, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
					this.FKAKEHJOIDL.SetVector("  |  ", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 602f, 157f, 1821f));
					Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
				}
			}
			else
			{
				this.FKAKEHJOIDL.SetVector("workshop.", new Vector4(255f, MJFBFHDCCLE * this.NMOLKKBMGEC, 1776f, 1416f));
				Graphics.Blit(BHNGOLDNELC, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
				this.FKAKEHJOIDL.SetVector("BitsData", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 1151f, 359f, 301f));
				Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x0028BF34 File Offset: 0x0028A134
		private void KCDMFJLHEOP(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, int PMEDOCEEAHL, float MJFBFHDCCLE, RenderTexture GEEGEOCEKDA)
		{
			this.FKAKEHJOIDL.SetVector("sounds/no_hit", new Vector4(1692f, MJFBFHDCCLE * this.NMOLKKBMGEC, 1934f, 1225f));
			Graphics.Blit(BHNGOLDNELC, GEEGEOCEKDA, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("clicked ", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 507f, 1679f, 502f));
			Graphics.Blit(GEEGEOCEKDA, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("Cross", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, MJFBFHDCCLE * this.NMOLKKBMGEC, 1318f, 165f));
			Graphics.Blit(HANEOLNMOEF, GEEGEOCEKDA, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("[EditorEvent] Exception: ", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, -MJFBFHDCCLE * this.NMOLKKBMGEC, 258f, 758f));
			Graphics.Blit(GEEGEOCEKDA, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
		}

		// Token: 0x06007CA4 RID: 31908 RVA: 0x0028C04F File Offset: 0x0028A24F
		private void EJJEDJIOFAB()
		{
			MLLAJENMBFL.Cleanup();
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x0028C058 File Offset: 0x0028A258
		private int ELBFILKHEGL()
		{
			int result = 0;
			if (this.resolution == DepthOfFieldDeprecated.DofResolution.Medium)
			{
				result = 2;
			}
			else if (this.resolution == DepthOfFieldDeprecated.DofResolution.High)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x0028C08C File Offset: 0x0028A28C
		private void HDHNACENPAC()
		{
			this.FKAKEHJOIDL = base.AJKPGPKKHHB(this.dofBlurShader, this.FKAKEHJOIDL);
			this.HBIFCBKMMDC = base.EDFIBHNHAAB(this.dofShader, this.HBIFCBKMMDC);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.OEPNIHPDAHN = base.EDFIBHNHAAB(this.bokehShader, this.OEPNIHPDAHN);
			}
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x0028C118 File Offset: 0x0028A318
		private void PACLEGDKKPI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.smoothness < 93f)
			{
				this.smoothness = 747f;
			}
			this.bokeh = (!this.bokeh || this.bokehSupport);
			float num = (!this.bokeh) ? 542f : DepthOfFieldDeprecated.JFDCOIIJDPH;
			bool flag = this.quality > (DepthOfFieldDeprecated.Dof34QualitySetting)0;
			float num2 = this.focalSize / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.IAJGMLGBOEN = ((!this.objectFocus) ? this.DBAHGBBNMOG(this.focalPoint) : (this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position).z / this.CNMFDOINHOL.farClipPlane));
				this.HKECIAKHAHN = this.IAJGMLGBOEN * this.smoothness;
				this.KIBGBAIJAIM = this.HKECIAKHAHN;
				flag = (!flag || this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.CNMFDOINHOL.farClipPlane;
					this.IAJGMLGBOEN = vector.z;
				}
				else
				{
					this.IAJGMLGBOEN = this.KJMFPJKGLOE(this.focalZDistance);
				}
				this.HKECIAKHAHN = this.focalZStartCurve;
				this.KIBGBAIJAIM = this.focalZEndCurve;
				flag = (!flag || this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			this.KCHCNFBLFDO = 1494f * (float)HLBKCLPNHEB.width / (1970f * (float)HLBKCLPNHEB.height);
			this.NMOLKKBMGEC = 643f;
			this.HBIFCBKMMDC.SetFloat("#scoresubmitionfailed: ", this.foregroundBlurExtrude);
			this.HBIFCBKMMDC.SetVector("settings.volume.editor", new Vector4((!this.simpleTweakMode) ? this.HKECIAKHAHN : (77f / this.HKECIAKHAHN), (!this.simpleTweakMode) ? this.KIBGBAIJAIM : (814f / this.KIBGBAIJAIM), num2 * 1005f, this.IAJGMLGBOEN));
			this.HBIFCBKMMDC.SetVector(".", new Vector4(1890f / (301f * (float)HLBKCLPNHEB.width), 596f / (652f * (float)HLBKCLPNHEB.height), 328f, 813f));
			int num3 = this.LLOKAHCGOCC();
			int nffhbdffinp = this.LPLDBEMMFJK(num3);
			this.LHBMOKOHNKC(flag, HLBKCLPNHEB, num3, nffhbdffinp);
			Graphics.Blit(HLBKCLPNHEB, HLBKCLPNHEB, this.HBIFCBKMMDC, 7);
			this.JHFFDCOIDJH(HLBKCLPNHEB, this.LFOOOIHIFIL);
			this.FGPMDNINMJL(this.LFOOOIHIFIL, this.LFOOOIHIFIL, (DepthOfFieldDeprecated.DofBlurriness)0, 3, this.maxBlurSpread);
			if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)7 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.HBIFCBKMMDC.SetVector("OnDeserialize", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 308f, 469f));
				Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 29);
				Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.FGPMDNINMJL(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread * num);
			}
			else
			{
				this.ABGNELIGNEI(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.FBLOGOILHNG(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread);
			}
			this.FKAKEHJOIDL.SetTexture("Error: you cannot read this stream that you are writing!", this.HHKOGNNEKON);
			this.FKAKEHJOIDL.SetTexture("_MainTex2", this.LFOOOIHIFIL);
			Graphics.Blit(null, this.ELEJLIKAEBC, this.FKAKEHJOIDL, 1);
			if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)6 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.LNLDNPIMEEF(this.CEPKBFEEIFC, this.BOFPPGCEIDO, this.ELEJLIKAEBC);
			}
			this.HBIFCBKMMDC.SetTexture("OK", this.ELEJLIKAEBC);
			this.HBIFCBKMMDC.SetTexture("MenuScene", this.LFOOOIHIFIL);
			Graphics.Blit(HLBKCLPNHEB, (!flag) ? BMMLHGHKBNM : this.HEBNMCEPMDH, this.HBIFCBKMMDC, (!this.visualize) ? 1 : 1);
			if (flag)
			{
				Graphics.Blit(this.HEBNMCEPMDH, HLBKCLPNHEB, this.HBIFCBKMMDC, 8);
				this.GDKEPFLCPEJ(HLBKCLPNHEB, this.LFOOOIHIFIL);
				this.GKOMKJHNMLO(this.LFOOOIHIFIL, this.LFOOOIHIFIL, (DepthOfFieldDeprecated.DofBlurriness)0, 2, this.maxBlurSpread);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)4 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HBIFCBKMMDC.SetVector("[MenuScene] Error: ", new Vector4(this.bokehThresholdContrast * 925f, this.bokehThresholdLuminance, 467f, 117f));
					Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 31);
					Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
					this.EAAIFEBIIBG(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread * num);
				}
				else
				{
					this.GKOMKJHNMLO(this.LFOOOIHIFIL, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.HHKOGNNEKON, this.ELEJLIKAEBC);
				this.HBIFCBKMMDC.SetTexture("_Value3", this.ELEJLIKAEBC);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HBIFCBKMMDC, (!this.visualize) ? 6 : 1);
				if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.Background & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.BPIKKHFFDEE(this.CEPKBFEEIFC, this.BOFPPGCEIDO, BMMLHGHKBNM);
				}
			}
			this.AFHDKJFDLCJ();
		}

		// Token: 0x06007CA8 RID: 31912 RVA: 0x0028C734 File Offset: 0x0028A934
		public virtual bool GOEOHOLLPKJ()
		{
			base.JOMCJOEOLHP(true);
			this.FKAKEHJOIDL = base.ECNEGNMAMDE(this.dofBlurShader, this.FKAKEHJOIDL);
			this.HBIFCBKMMDC = base.KDHKHOHMKCG(this.dofShader, this.HBIFCBKMMDC);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.OEPNIHPDAHN = base.KDHKHOHMKCG(this.bokehShader, this.OEPNIHPDAHN);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CA9 RID: 31913 RVA: 0x0028C7E0 File Offset: 0x0028A9E0
		private void IHJBGIEKLOF()
		{
			if (this.HEBNMCEPMDH)
			{
				RenderTexture.ReleaseTemporary(this.HEBNMCEPMDH);
			}
			if (this.ELEJLIKAEBC)
			{
				RenderTexture.ReleaseTemporary(this.ELEJLIKAEBC);
			}
			if (this.LFOOOIHIFIL)
			{
				RenderTexture.ReleaseTemporary(this.LFOOOIHIFIL);
			}
			if (this.HHKOGNNEKON)
			{
				RenderTexture.ReleaseTemporary(this.HHKOGNNEKON);
			}
			if (this.BOFPPGCEIDO)
			{
				RenderTexture.ReleaseTemporary(this.BOFPPGCEIDO);
			}
			if (this.CEPKBFEEIFC)
			{
				RenderTexture.ReleaseTemporary(this.CEPKBFEEIFC);
			}
		}

		// Token: 0x06007CAA RID: 31914 RVA: 0x0028C890 File Offset: 0x0028AA90
		private int LLOKAHCGOCC()
		{
			int result = 1;
			if (this.resolution == (DepthOfFieldDeprecated.DofResolution)7)
			{
				result = 2;
			}
			else if (this.resolution == (DepthOfFieldDeprecated.DofResolution)5)
			{
				result = 8;
			}
			return result;
		}

		// Token: 0x06007CAB RID: 31915 RVA: 0x0028C8C4 File Offset: 0x0028AAC4
		private int EFIEOCMDGLP()
		{
			int result = 0;
			if (this.resolution == (DepthOfFieldDeprecated.DofResolution)0)
			{
				result = 3;
			}
			else if (this.resolution == (DepthOfFieldDeprecated.DofResolution)7)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06007CAC RID: 31916 RVA: 0x0028C8F8 File Offset: 0x0028AAF8
		private void BGDGIPOADBK(RenderTexture HJIOCDOBPKD, RenderTexture CKJJLLEBBLA, RenderTexture BNIKLMOBMHO)
		{
			if (this.OEPNIHPDAHN)
			{
				Mesh[] array = MLLAJENMBFL.HCAIIGLNPDF(CKJJLLEBBLA.width, CKJJLLEBBLA.height);
				RenderTexture.active = CKJJLLEBBLA;
				GL.Clear(true, true, new Color(1494f, 1484f, 957f, 749f));
				GL.PushMatrix();
				GL.LoadIdentity();
				HJIOCDOBPKD.filterMode = FilterMode.Point;
				float num = (float)HJIOCDOBPKD.width * 1013f / ((float)HJIOCDOBPKD.height * 611f);
				float num2 = 1760f / (1076f * (float)HJIOCDOBPKD.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.JFDCOIIJDPH * this.NMOLKKBMGEC;
				this.OEPNIHPDAHN.SetTexture("Texture2", HJIOCDOBPKD);
				this.OEPNIHPDAHN.SetTexture("_DistCenterScale", this.bokehTexture);
				this.OEPNIHPDAHN.SetVector("Result for ", new Vector4(num2, num2 * num, 1913f, 744f * num));
				this.OEPNIHPDAHN.SetFloat("There is already a virtual button named ", this.bokehIntensity);
				this.OEPNIHPDAHN.SetPass(0);
				Mesh[] array2 = array;
				for (int i = 1; i < array2.Length; i++)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(CKJJLLEBBLA, BNIKLMOBMHO, this.HBIFCBKMMDC, 8);
				HJIOCDOBPKD.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x06007CAD RID: 31917 RVA: 0x0028CA6C File Offset: 0x0028AC6C
		private int BHCOLPFFHPO(int KIHHCOMDHBL)
		{
			int num = KIHHCOMDHBL;
			if (this.resolution == DepthOfFieldDeprecated.DofResolution.Medium)
			{
				num *= 1;
			}
			if (this.resolution == (DepthOfFieldDeprecated.DofResolution)5)
			{
				num *= 5;
			}
			return num;
		}

		// Token: 0x06007CAE RID: 31918 RVA: 0x0028CA9C File Offset: 0x0028AC9C
		private void LNLDNPIMEEF(RenderTexture HJIOCDOBPKD, RenderTexture CKJJLLEBBLA, RenderTexture BNIKLMOBMHO)
		{
			if (this.OEPNIHPDAHN)
			{
				Mesh[] array = MLLAJENMBFL.OIPMNNLOHLA(CKJJLLEBBLA.width, CKJJLLEBBLA.height);
				RenderTexture.active = CKJJLLEBBLA;
				GL.Clear(false, false, new Color(1041f, 169f, 520f, 111f));
				GL.PushMatrix();
				GL.LoadIdentity();
				HJIOCDOBPKD.filterMode = FilterMode.Point;
				float num = (float)HJIOCDOBPKD.width * 765f / ((float)HJIOCDOBPKD.height * 24f);
				float num2 = 180f / (385f * (float)HJIOCDOBPKD.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.JFDCOIIJDPH * this.NMOLKKBMGEC;
				this.OEPNIHPDAHN.SetTexture("Fill", HJIOCDOBPKD);
				this.OEPNIHPDAHN.SetTexture("colorA", this.bokehTexture);
				this.OEPNIHPDAHN.SetVector("{0} hours ago", new Vector4(num2, num2 * num, 477f, 777f * num));
				this.OEPNIHPDAHN.SetFloat("file://", this.bokehIntensity);
				this.OEPNIHPDAHN.SetPass(0);
				Mesh[] array2 = array;
				for (int i = 1; i < array2.Length; i++)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(CKJJLLEBBLA, BNIKLMOBMHO, this.HBIFCBKMMDC, 0);
				HJIOCDOBPKD.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x06007CAF RID: 31919 RVA: 0x0028CC10 File Offset: 0x0028AE10
		private int FCNCHNIEEKA(int KIHHCOMDHBL)
		{
			int num = KIHHCOMDHBL;
			if (this.resolution == (DepthOfFieldDeprecated.DofResolution)7)
			{
				num *= 2;
			}
			if (this.resolution == DepthOfFieldDeprecated.DofResolution.High)
			{
				num *= 3;
			}
			return num;
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x0028CD2C File Offset: 0x0028AF2C
		private void CFBPFHHIPEK(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, int PMEDOCEEAHL, float MJFBFHDCCLE, RenderTexture GEEGEOCEKDA)
		{
			this.FKAKEHJOIDL.SetVector("offsets", new Vector4(0f, MJFBFHDCCLE * this.NMOLKKBMGEC, 0f, 0f));
			Graphics.Blit(BHNGOLDNELC, GEEGEOCEKDA, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("offsets", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 0f, 0f, 0f));
			Graphics.Blit(GEEGEOCEKDA, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("offsets", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, MJFBFHDCCLE * this.NMOLKKBMGEC, 0f, 0f));
			Graphics.Blit(HANEOLNMOEF, GEEGEOCEKDA, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("offsets", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, -MJFBFHDCCLE * this.NMOLKKBMGEC, 0f, 0f));
			Graphics.Blit(GEEGEOCEKDA, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
		}

		// Token: 0x06007CB2 RID: 31922 RVA: 0x0028CE48 File Offset: 0x0028B048
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.smoothness < 0.1f)
			{
				this.smoothness = 0.1f;
			}
			this.bokeh = (this.bokeh && this.bokehSupport);
			float num = (!this.bokeh) ? 1f : DepthOfFieldDeprecated.JFDCOIIJDPH;
			bool flag = this.quality > DepthOfFieldDeprecated.Dof34QualitySetting.OnlyBackground;
			float num2 = this.focalSize / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.IAJGMLGBOEN = ((!this.objectFocus) ? this.DBAHGBBNMOG(this.focalPoint) : (this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position).z / this.CNMFDOINHOL.farClipPlane));
				this.HKECIAKHAHN = this.IAJGMLGBOEN * this.smoothness;
				this.KIBGBAIJAIM = this.HKECIAKHAHN;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.CNMFDOINHOL.farClipPlane;
					this.IAJGMLGBOEN = vector.z;
				}
				else
				{
					this.IAJGMLGBOEN = this.DBAHGBBNMOG(this.focalZDistance);
				}
				this.HKECIAKHAHN = this.focalZStartCurve;
				this.KIBGBAIJAIM = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			this.KCHCNFBLFDO = 1f * (float)HLBKCLPNHEB.width / (1f * (float)HLBKCLPNHEB.height);
			this.NMOLKKBMGEC = 0.001953125f;
			this.HBIFCBKMMDC.SetFloat("_ForegroundBlurExtrude", this.foregroundBlurExtrude);
			this.HBIFCBKMMDC.SetVector("_CurveParams", new Vector4((!this.simpleTweakMode) ? this.HKECIAKHAHN : (1f / this.HKECIAKHAHN), (!this.simpleTweakMode) ? this.KIBGBAIJAIM : (1f / this.KIBGBAIJAIM), num2 * 0.5f, this.IAJGMLGBOEN));
			this.HBIFCBKMMDC.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)HLBKCLPNHEB.width), 1f / (1f * (float)HLBKCLPNHEB.height), 0f, 0f));
			int num3 = this.NPNLNIJMGJN();
			int nffhbdffinp = this.HFGJNDIAMME(num3);
			this.CCIKKFFAHFI(flag, HLBKCLPNHEB, num3, nffhbdffinp);
			Graphics.Blit(HLBKCLPNHEB, HLBKCLPNHEB, this.HBIFCBKMMDC, 3);
			this.EMGALHMELEM(HLBKCLPNHEB, this.LFOOOIHIFIL);
			this.OBJNLPLDBCL(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 4, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.HBIFCBKMMDC.SetVector("_Threshhold", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 0.95f, 0f));
				Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 11);
				Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.OBJNLPLDBCL(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread * num);
			}
			else
			{
				this.EMGALHMELEM(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.OBJNLPLDBCL(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread);
			}
			this.FKAKEHJOIDL.SetTexture("_TapLow", this.HHKOGNNEKON);
			this.FKAKEHJOIDL.SetTexture("_TapMedium", this.LFOOOIHIFIL);
			Graphics.Blit(null, this.ELEJLIKAEBC, this.FKAKEHJOIDL, 3);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.BPIKKHFFDEE(this.CEPKBFEEIFC, this.BOFPPGCEIDO, this.ELEJLIKAEBC);
			}
			this.HBIFCBKMMDC.SetTexture("_TapLowBackground", this.ELEJLIKAEBC);
			this.HBIFCBKMMDC.SetTexture("_TapMedium", this.LFOOOIHIFIL);
			Graphics.Blit(HLBKCLPNHEB, (!flag) ? BMMLHGHKBNM : this.HEBNMCEPMDH, this.HBIFCBKMMDC, (!this.visualize) ? 0 : 2);
			if (flag)
			{
				Graphics.Blit(this.HEBNMCEPMDH, HLBKCLPNHEB, this.HBIFCBKMMDC, 5);
				this.EMGALHMELEM(HLBKCLPNHEB, this.LFOOOIHIFIL);
				this.GKOMKJHNMLO(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 2, this.maxBlurSpread);
				if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HBIFCBKMMDC.SetVector("_Threshhold", new Vector4(this.bokehThresholdContrast * 0.5f, this.bokehThresholdLuminance, 0f, 0f));
					Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 11);
					Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
					this.GKOMKJHNMLO(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread * num);
				}
				else
				{
					this.GKOMKJHNMLO(this.LFOOOIHIFIL, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.HHKOGNNEKON, this.ELEJLIKAEBC);
				this.HBIFCBKMMDC.SetTexture("_TapLowForeground", this.ELEJLIKAEBC);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HBIFCBKMMDC, (!this.visualize) ? 4 : 1);
				if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.BPIKKHFFDEE(this.CEPKBFEEIFC, this.BOFPPGCEIDO, BMMLHGHKBNM);
				}
			}
			this.MENBHPCIOAF();
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x0028D464 File Offset: 0x0028B664
		private void BPIKKHFFDEE(RenderTexture HJIOCDOBPKD, RenderTexture CKJJLLEBBLA, RenderTexture BNIKLMOBMHO)
		{
			if (this.OEPNIHPDAHN)
			{
				Mesh[] meshes = MLLAJENMBFL.GetMeshes(CKJJLLEBBLA.width, CKJJLLEBBLA.height);
				RenderTexture.active = CKJJLLEBBLA;
				GL.Clear(false, true, new Color(0f, 0f, 0f, 0f));
				GL.PushMatrix();
				GL.LoadIdentity();
				HJIOCDOBPKD.filterMode = FilterMode.Point;
				float num = (float)HJIOCDOBPKD.width * 1f / ((float)HJIOCDOBPKD.height * 1f);
				float num2 = 2f / (1f * (float)HJIOCDOBPKD.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.JFDCOIIJDPH * this.NMOLKKBMGEC;
				this.OEPNIHPDAHN.SetTexture("_Source", HJIOCDOBPKD);
				this.OEPNIHPDAHN.SetTexture("_MainTex", this.bokehTexture);
				this.OEPNIHPDAHN.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
				this.OEPNIHPDAHN.SetFloat("_Intensity", this.bokehIntensity);
				this.OEPNIHPDAHN.SetPass(0);
				foreach (Mesh mesh in meshes)
				{
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(CKJJLLEBBLA, BNIKLMOBMHO, this.HBIFCBKMMDC, 8);
				HJIOCDOBPKD.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x06007CB5 RID: 31925 RVA: 0x0028D5EC File Offset: 0x0028B7EC
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.smoothness < 1421f)
			{
				this.smoothness = 815f;
			}
			this.bokeh = (this.bokeh && this.bokehSupport);
			float num = (!this.bokeh) ? 1509f : DepthOfFieldDeprecated.JFDCOIIJDPH;
			bool flag = this.quality > DepthOfFieldDeprecated.Dof34QualitySetting.OnlyBackground;
			float num2 = this.focalSize / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.IAJGMLGBOEN = ((!this.objectFocus) ? this.DBAHGBBNMOG(this.focalPoint) : (this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position).z / this.CNMFDOINHOL.farClipPlane));
				this.HKECIAKHAHN = this.IAJGMLGBOEN * this.smoothness;
				this.KIBGBAIJAIM = this.HKECIAKHAHN;
				flag = (!flag || this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.CNMFDOINHOL.farClipPlane;
					this.IAJGMLGBOEN = vector.z;
				}
				else
				{
					this.IAJGMLGBOEN = this.KJMFPJKGLOE(this.focalZDistance);
				}
				this.HKECIAKHAHN = this.focalZStartCurve;
				this.KIBGBAIJAIM = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			this.KCHCNFBLFDO = 687f * (float)HLBKCLPNHEB.width / (446f * (float)HLBKCLPNHEB.height);
			this.NMOLKKBMGEC = 892f;
			this.HBIFCBKMMDC.SetFloat(" - LOCAL", this.foregroundBlurExtrude);
			this.HBIFCBKMMDC.SetVector("TStart", new Vector4((!this.simpleTweakMode) ? this.HKECIAKHAHN : (1037f / this.HKECIAKHAHN), (!this.simpleTweakMode) ? this.KIBGBAIJAIM : (1048f / this.KIBGBAIJAIM), num2 * 212f, this.IAJGMLGBOEN));
			this.HBIFCBKMMDC.SetVector("[ResourcesManager] Load image error: ", new Vector4(1269f / (150f * (float)HLBKCLPNHEB.width), 1771f / (1736f * (float)HLBKCLPNHEB.height), 1055f, 1839f));
			int num3 = this.LLOKAHCGOCC();
			int nffhbdffinp = this.HFGJNDIAMME(num3);
			this.OIIGDOOEECN(flag, HLBKCLPNHEB, num3, nffhbdffinp);
			Graphics.Blit(HLBKCLPNHEB, HLBKCLPNHEB, this.HBIFCBKMMDC, 4);
			this.ABGNELIGNEI(HLBKCLPNHEB, this.LFOOOIHIFIL);
			this.LFMPBIIKIAM(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 8, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.BackgroundAndForeground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.HBIFCBKMMDC.SetVector(":", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 310f, 814f));
				Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 62);
				Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.OBJNLPLDBCL(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread * num);
			}
			else
			{
				this.JHFFDCOIDJH(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.OBJNLPLDBCL(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
			}
			this.FKAKEHJOIDL.SetTexture("SetParticlesInput", this.HHKOGNNEKON);
			this.FKAKEHJOIDL.SetTexture("_Vignette", this.LFOOOIHIFIL);
			Graphics.Blit(null, this.ELEJLIKAEBC, this.FKAKEHJOIDL, 2);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.Background & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.HKPLLMMMLOP(this.CEPKBFEEIFC, this.BOFPPGCEIDO, this.ELEJLIKAEBC);
			}
			this.HBIFCBKMMDC.SetTexture(" - ", this.ELEJLIKAEBC);
			this.HBIFCBKMMDC.SetTexture("_Value6", this.LFOOOIHIFIL);
			Graphics.Blit(HLBKCLPNHEB, (!flag) ? BMMLHGHKBNM : this.HEBNMCEPMDH, this.HBIFCBKMMDC, (!this.visualize) ? 1 : 0);
			if (flag)
			{
				Graphics.Blit(this.HEBNMCEPMDH, HLBKCLPNHEB, this.HBIFCBKMMDC, 8);
				this.JHFFDCOIDJH(HLBKCLPNHEB, this.LFOOOIHIFIL);
				this.HIEOEDDHBPL(this.LFOOOIHIFIL, this.LFOOOIHIFIL, (DepthOfFieldDeprecated.DofBlurriness)0, 3, this.maxBlurSpread);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)0 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HBIFCBKMMDC.SetVector("#tryagain", new Vector4(this.bokehThresholdContrast * 122f, this.bokehThresholdLuminance, 688f, 1132f));
					Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 67);
					Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
					this.EAAIFEBIIBG(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread * num);
				}
				else
				{
					this.HIEOEDDHBPL(this.LFOOOIHIFIL, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.HHKOGNNEKON, this.ELEJLIKAEBC);
				this.HBIFCBKMMDC.SetTexture("[Down]", this.ELEJLIKAEBC);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HBIFCBKMMDC, (!this.visualize) ? 5 : 1);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)4 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HKPLLMMMLOP(this.CEPKBFEEIFC, this.BOFPPGCEIDO, BMMLHGHKBNM);
				}
			}
			this.AFHDKJFDLCJ();
		}

		// Token: 0x06007CB6 RID: 31926 RVA: 0x0028DC08 File Offset: 0x0028BE08
		private void EMGALHMELEM(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.HBIFCBKMMDC.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)HANEOLNMOEF.width), 1f / (1f * (float)HANEOLNMOEF.height), 0f, 0f));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.HBIFCBKMMDC, DepthOfFieldDeprecated.HKCKKGDOHGD);
		}

		// Token: 0x06007CB7 RID: 31927 RVA: 0x0028DC6C File Offset: 0x0028BE6C
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.smoothness < 486f)
			{
				this.smoothness = 1484f;
			}
			this.bokeh = (this.bokeh && this.bokehSupport);
			float num = (!this.bokeh) ? 1104f : DepthOfFieldDeprecated.JFDCOIIJDPH;
			bool flag = this.quality > DepthOfFieldDeprecated.Dof34QualitySetting.OnlyBackground;
			float num2 = this.focalSize / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.IAJGMLGBOEN = ((!this.objectFocus) ? this.DBAHGBBNMOG(this.focalPoint) : (this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position).z / this.CNMFDOINHOL.farClipPlane));
				this.HKECIAKHAHN = this.IAJGMLGBOEN * this.smoothness;
				this.KIBGBAIJAIM = this.HKECIAKHAHN;
				flag = (!flag || this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.CNMFDOINHOL.farClipPlane;
					this.IAJGMLGBOEN = vector.z;
				}
				else
				{
					this.IAJGMLGBOEN = this.KJMFPJKGLOE(this.focalZDistance);
				}
				this.HKECIAKHAHN = this.focalZStartCurve;
				this.KIBGBAIJAIM = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			this.KCHCNFBLFDO = 596f * (float)HLBKCLPNHEB.width / (920f * (float)HLBKCLPNHEB.height);
			this.NMOLKKBMGEC = 364f;
			this.HBIFCBKMMDC.SetFloat("Right Stick Click", this.foregroundBlurExtrude);
			this.HBIFCBKMMDC.SetVector("CameraFilterPack/Drawing_Manga_Flash_Color", new Vector4((!this.simpleTweakMode) ? this.HKECIAKHAHN : (1884f / this.HKECIAKHAHN), (!this.simpleTweakMode) ? this.KIBGBAIJAIM : (388f / this.KIBGBAIJAIM), num2 * 1080f, this.IAJGMLGBOEN));
			this.HBIFCBKMMDC.SetVector("_Value3", new Vector4(1159f / (1432f * (float)HLBKCLPNHEB.width), 244f / (1810f * (float)HLBKCLPNHEB.height), 145f, 642f));
			int num3 = this.LLOKAHCGOCC();
			int nffhbdffinp = this.BMIBPGEPLCC(num3);
			this.CCIKKFFAHFI(flag, HLBKCLPNHEB, num3, nffhbdffinp);
			Graphics.Blit(HLBKCLPNHEB, HLBKCLPNHEB, this.HBIFCBKMMDC, 4);
			this.EMGALHMELEM(HLBKCLPNHEB, this.LFOOOIHIFIL);
			this.OBJNLPLDBCL(this.LFOOOIHIFIL, this.LFOOOIHIFIL, (DepthOfFieldDeprecated.DofBlurriness)0, 0, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.BackgroundAndForeground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.HBIFCBKMMDC.SetVector(" = ", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 731f, 1465f));
				Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 125);
				Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.FGPMDNINMJL(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread * num);
			}
			else
			{
				this.ABGNELIGNEI(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.LFMPBIIKIAM(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
			}
			this.FKAKEHJOIDL.SetTexture("_Green_C", this.HHKOGNNEKON);
			this.FKAKEHJOIDL.SetTexture("IconFileSelector", this.LFOOOIHIFIL);
			Graphics.Blit(null, this.ELEJLIKAEBC, this.FKAKEHJOIDL, 4);
			if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)0 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.BGDGIPOADBK(this.CEPKBFEEIFC, this.BOFPPGCEIDO, this.ELEJLIKAEBC);
			}
			this.HBIFCBKMMDC.SetTexture("_ScreenResolution", this.ELEJLIKAEBC);
			this.HBIFCBKMMDC.SetTexture("_ChannelMixerBlue", this.LFOOOIHIFIL);
			Graphics.Blit(HLBKCLPNHEB, (!flag) ? BMMLHGHKBNM : this.HEBNMCEPMDH, this.HBIFCBKMMDC, (!this.visualize) ? 0 : 7);
			if (flag)
			{
				Graphics.Blit(this.HEBNMCEPMDH, HLBKCLPNHEB, this.HBIFCBKMMDC, 5);
				this.GDKEPFLCPEJ(HLBKCLPNHEB, this.LFOOOIHIFIL);
				this.GKOMKJHNMLO(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 1, this.maxBlurSpread);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)6 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HBIFCBKMMDC.SetVector("Set particles start speed", new Vector4(this.bokehThresholdContrast * 925f, this.bokehThresholdLuminance, 776f, 136f));
					Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, -115);
					Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
					this.HIEOEDDHBPL(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread * num);
				}
				else
				{
					this.GKOMKJHNMLO(this.LFOOOIHIFIL, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.HHKOGNNEKON, this.ELEJLIKAEBC);
				this.HBIFCBKMMDC.SetTexture("CameraFilterPack/Alien_Vision", this.ELEJLIKAEBC);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HBIFCBKMMDC, (!this.visualize) ? 2 : 0);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)7 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.PHGBAGOLIPD(this.CEPKBFEEIFC, this.BOFPPGCEIDO, BMMLHGHKBNM);
				}
			}
			this.PKIFLMLPOAD();
		}

		// Token: 0x06007CB8 RID: 31928 RVA: 0x0028E288 File Offset: 0x0028C488
		private float EOGHDOHBPLD(float JOCAFKLENDG)
		{
			return this.CNMFDOINHOL.WorldToViewportPoint((JOCAFKLENDG - this.CNMFDOINHOL.nearClipPlane) * this.CNMFDOINHOL.transform.forward + this.CNMFDOINHOL.transform.position).z / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
		}

		// Token: 0x06007CB9 RID: 31929 RVA: 0x0028E2F8 File Offset: 0x0028C4F8
		private void AKDJLEILFPI(RenderTexture HJIOCDOBPKD, RenderTexture CKJJLLEBBLA, RenderTexture BNIKLMOBMHO)
		{
			if (this.OEPNIHPDAHN)
			{
				Mesh[] array = MLLAJENMBFL.EGPKLMDIONP(CKJJLLEBBLA.width, CKJJLLEBBLA.height);
				RenderTexture.active = CKJJLLEBBLA;
				GL.Clear(true, false, new Color(1557f, 490f, 213f, 1224f));
				GL.PushMatrix();
				GL.LoadIdentity();
				HJIOCDOBPKD.filterMode = FilterMode.Point;
				float num = (float)HJIOCDOBPKD.width * 545f / ((float)HJIOCDOBPKD.height * 419f);
				float num2 = 1107f / (558f * (float)HJIOCDOBPKD.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.JFDCOIIJDPH * this.NMOLKKBMGEC;
				this.OEPNIHPDAHN.SetTexture("#exit", HJIOCDOBPKD);
				this.OEPNIHPDAHN.SetTexture("/", this.bokehTexture);
				this.OEPNIHPDAHN.SetVector("gameVolume", new Vector4(num2, num2 * num, 1846f, 651f * num));
				this.OEPNIHPDAHN.SetFloat("_TimeX", this.bokehIntensity);
				this.OEPNIHPDAHN.SetPass(0);
				Mesh[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(CKJJLLEBBLA, BNIKLMOBMHO, this.HBIFCBKMMDC, 8);
				HJIOCDOBPKD.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x0028E46C File Offset: 0x0028C66C
		private void FHHMFEKLLKP(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, int PMEDOCEEAHL, float MJFBFHDCCLE, RenderTexture GEEGEOCEKDA)
		{
			this.FKAKEHJOIDL.SetVector("player.abstract", new Vector4(783f, MJFBFHDCCLE * this.NMOLKKBMGEC, 1759f, 849f));
			Graphics.Blit(BHNGOLDNELC, GEEGEOCEKDA, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("Crosshair1", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 1969f, 648f, 387f));
			Graphics.Blit(GEEGEOCEKDA, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("ResetButton", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, MJFBFHDCCLE * this.NMOLKKBMGEC, 1744f, 352f));
			Graphics.Blit(HANEOLNMOEF, GEEGEOCEKDA, this.FKAKEHJOIDL, PMEDOCEEAHL);
			this.FKAKEHJOIDL.SetVector("Mouse ", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, -MJFBFHDCCLE * this.NMOLKKBMGEC, 961f, 588f));
			Graphics.Blit(GEEGEOCEKDA, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x0028E588 File Offset: 0x0028C788
		private void PJKAGNNNFGK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.smoothness < 116f)
			{
				this.smoothness = 1188f;
			}
			this.bokeh = (!this.bokeh || this.bokehSupport);
			float num = (!this.bokeh) ? 842f : DepthOfFieldDeprecated.JFDCOIIJDPH;
			bool flag = this.quality > (DepthOfFieldDeprecated.Dof34QualitySetting)0;
			float num2 = this.focalSize / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.IAJGMLGBOEN = ((!this.objectFocus) ? this.DBAHGBBNMOG(this.focalPoint) : (this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position).z / this.CNMFDOINHOL.farClipPlane));
				this.HKECIAKHAHN = this.IAJGMLGBOEN * this.smoothness;
				this.KIBGBAIJAIM = this.HKECIAKHAHN;
				flag = (!flag || this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.CNMFDOINHOL.farClipPlane;
					this.IAJGMLGBOEN = vector.z;
				}
				else
				{
					this.IAJGMLGBOEN = this.EOGHDOHBPLD(this.focalZDistance);
				}
				this.HKECIAKHAHN = this.focalZStartCurve;
				this.KIBGBAIJAIM = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			this.KCHCNFBLFDO = 857f * (float)HLBKCLPNHEB.width / (1778f * (float)HLBKCLPNHEB.height);
			this.NMOLKKBMGEC = 1896f;
			this.HBIFCBKMMDC.SetFloat("EndlessLoopsScoreText", this.foregroundBlurExtrude);
			this.HBIFCBKMMDC.SetVector("InventoryGrid", new Vector4((!this.simpleTweakMode) ? this.HKECIAKHAHN : (197f / this.HKECIAKHAHN), (!this.simpleTweakMode) ? this.KIBGBAIJAIM : (794f / this.KIBGBAIJAIM), num2 * 992f, this.IAJGMLGBOEN));
			this.HBIFCBKMMDC.SetVector("bloomintencity:", new Vector4(1149f / (1413f * (float)HLBKCLPNHEB.width), 325f / (477f * (float)HLBKCLPNHEB.height), 116f, 1228f));
			int num3 = this.ELBFILKHEGL();
			int nffhbdffinp = this.HFGJNDIAMME(num3);
			this.OIIGDOOEECN(flag, HLBKCLPNHEB, num3, nffhbdffinp);
			Graphics.Blit(HLBKCLPNHEB, HLBKCLPNHEB, this.HBIFCBKMMDC, 2);
			this.GDKEPFLCPEJ(HLBKCLPNHEB, this.LFOOOIHIFIL);
			this.FGPMDNINMJL(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 3, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.BackgroundAndForeground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.HBIFCBKMMDC.SetVector("_TimeX", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 13f, 1358f));
				Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 59);
				Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.LFMPBIIKIAM(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread * num);
			}
			else
			{
				this.ABGNELIGNEI(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.OBJNLPLDBCL(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
			}
			this.FKAKEHJOIDL.SetTexture("CameraFilterPack/Blend2Camera_LighterColor", this.HHKOGNNEKON);
			this.FKAKEHJOIDL.SetTexture("GlassesColor", this.LFOOOIHIFIL);
			Graphics.Blit(null, this.ELEJLIKAEBC, this.FKAKEHJOIDL, 0);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.BackgroundAndForeground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.PHGBAGOLIPD(this.CEPKBFEEIFC, this.BOFPPGCEIDO, this.ELEJLIKAEBC);
			}
			this.HBIFCBKMMDC.SetTexture("_MainTex2", this.ELEJLIKAEBC);
			this.HBIFCBKMMDC.SetTexture("DPADHOR", this.LFOOOIHIFIL);
			Graphics.Blit(HLBKCLPNHEB, (!flag) ? BMMLHGHKBNM : this.HEBNMCEPMDH, this.HBIFCBKMMDC, (!this.visualize) ? 0 : 8);
			if (flag)
			{
				Graphics.Blit(this.HEBNMCEPMDH, HLBKCLPNHEB, this.HBIFCBKMMDC, 2);
				this.EMGALHMELEM(HLBKCLPNHEB, this.LFOOOIHIFIL);
				this.HIEOEDDHBPL(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 5, this.maxBlurSpread);
				if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.BackgroundAndForeground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HBIFCBKMMDC.SetVector("_Val", new Vector4(this.bokehThresholdContrast * 229f, this.bokehThresholdLuminance, 1121f, 783f));
					Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 110);
					Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
					this.AFPDNPCJNFP(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread * num);
				}
				else
				{
					this.EAAIFEBIIBG(this.LFOOOIHIFIL, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.HHKOGNNEKON, this.ELEJLIKAEBC);
				this.HBIFCBKMMDC.SetTexture("_Offsets", this.ELEJLIKAEBC);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HBIFCBKMMDC, (!this.visualize) ? 4 : 0);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)8 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.LNLDNPIMEEF(this.CEPKBFEEIFC, this.BOFPPGCEIDO, BMMLHGHKBNM);
				}
			}
			this.OHGHMBGFACB();
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x0028EBA4 File Offset: 0x0028CDA4
		private void FBLOGOILHNG(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, DepthOfFieldDeprecated.DofBlurriness OGFJPFIMOHG, int PMEDOCEEAHL, float MJFBFHDCCLE)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(HANEOLNMOEF.width, HANEOLNMOEF.height);
			if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.Low)
			{
				this.FHHMFEKLLKP(BHNGOLDNELC, HANEOLNMOEF, PMEDOCEEAHL, MJFBFHDCCLE, temporary);
				if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.VeryHigh)
				{
					this.FKAKEHJOIDL.SetVector("_Value3", new Vector4(1614f, MJFBFHDCCLE * this.NMOLKKBMGEC, 951f, 385f));
					Graphics.Blit(HANEOLNMOEF, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
					this.FKAKEHJOIDL.SetVector("Case-Sensitive", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 1393f, 1150f, 653f));
					Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
				}
			}
			else
			{
				this.FKAKEHJOIDL.SetVector("_Value2", new Vector4(1220f, MJFBFHDCCLE * this.NMOLKKBMGEC, 135f, 467f));
				Graphics.Blit(BHNGOLDNELC, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
				this.FKAKEHJOIDL.SetVector("_ScreenResolution", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 374f, 831f, 1750f));
				Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x0028ECE8 File Offset: 0x0028CEE8
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.smoothness < 155f)
			{
				this.smoothness = 1765f;
			}
			this.bokeh = (!this.bokeh || this.bokehSupport);
			float num = (!this.bokeh) ? 1323f : DepthOfFieldDeprecated.JFDCOIIJDPH;
			bool flag = this.quality > (DepthOfFieldDeprecated.Dof34QualitySetting)0;
			float num2 = this.focalSize / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.IAJGMLGBOEN = ((!this.objectFocus) ? this.DBAHGBBNMOG(this.focalPoint) : (this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position).z / this.CNMFDOINHOL.farClipPlane));
				this.HKECIAKHAHN = this.IAJGMLGBOEN * this.smoothness;
				this.KIBGBAIJAIM = this.HKECIAKHAHN;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.CNMFDOINHOL.farClipPlane;
					this.IAJGMLGBOEN = vector.z;
				}
				else
				{
					this.IAJGMLGBOEN = this.KJMFPJKGLOE(this.focalZDistance);
				}
				this.HKECIAKHAHN = this.focalZStartCurve;
				this.KIBGBAIJAIM = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			this.KCHCNFBLFDO = 160f * (float)HLBKCLPNHEB.width / (575f * (float)HLBKCLPNHEB.height);
			this.NMOLKKBMGEC = 806f;
			this.HBIFCBKMMDC.SetFloat("_Offsets", this.foregroundBlurExtrude);
			this.HBIFCBKMMDC.SetVector("back", new Vector4((!this.simpleTweakMode) ? this.HKECIAKHAHN : (681f / this.HKECIAKHAHN), (!this.simpleTweakMode) ? this.KIBGBAIJAIM : (531f / this.KIBGBAIJAIM), num2 * 0f, this.IAJGMLGBOEN));
			this.HBIFCBKMMDC.SetVector("_Size", new Vector4(1526f / (79f * (float)HLBKCLPNHEB.width), 1516f / (796f * (float)HLBKCLPNHEB.height), 1926f, 222f));
			int num3 = this.NPNLNIJMGJN();
			int nffhbdffinp = this.LPLDBEMMFJK(num3);
			this.CCIKKFFAHFI(flag, HLBKCLPNHEB, num3, nffhbdffinp);
			Graphics.Blit(HLBKCLPNHEB, HLBKCLPNHEB, this.HBIFCBKMMDC, 8);
			this.ABGNELIGNEI(HLBKCLPNHEB, this.LFOOOIHIFIL);
			this.FBLOGOILHNG(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 6, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.Background & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.HBIFCBKMMDC.SetVector("_Value3", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 351f, 1429f));
				Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 57);
				Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.LFMPBIIKIAM(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread * num);
			}
			else
			{
				this.GDKEPFLCPEJ(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.FGPMDNINMJL(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread);
			}
			this.FKAKEHJOIDL.SetTexture("_Amount", this.HHKOGNNEKON);
			this.FKAKEHJOIDL.SetTexture("a year ago", this.LFOOOIHIFIL);
			Graphics.Blit(null, this.ELEJLIKAEBC, this.FKAKEHJOIDL, 6);
			if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)7 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.AKDJLEILFPI(this.CEPKBFEEIFC, this.BOFPPGCEIDO, this.ELEJLIKAEBC);
			}
			this.HBIFCBKMMDC.SetTexture("ticket", this.ELEJLIKAEBC);
			this.HBIFCBKMMDC.SetTexture("shader.sunny", this.LFOOOIHIFIL);
			Graphics.Blit(HLBKCLPNHEB, (!flag) ? BMMLHGHKBNM : this.HEBNMCEPMDH, this.HBIFCBKMMDC, (!this.visualize) ? 0 : 2);
			if (flag)
			{
				Graphics.Blit(this.HEBNMCEPMDH, HLBKCLPNHEB, this.HBIFCBKMMDC, 0);
				this.JHFFDCOIDJH(HLBKCLPNHEB, this.LFOOOIHIFIL);
				this.AFPDNPCJNFP(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 6, this.maxBlurSpread);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)6 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HBIFCBKMMDC.SetVector("_Value6", new Vector4(this.bokehThresholdContrast * 1241f, this.bokehThresholdLuminance, 1639f, 1817f));
					Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 52);
					Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
					this.AFPDNPCJNFP(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread * num);
				}
				else
				{
					this.EAAIFEBIIBG(this.LFOOOIHIFIL, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread);
				}
				Graphics.Blit(this.HHKOGNNEKON, this.ELEJLIKAEBC);
				this.HBIFCBKMMDC.SetTexture("Joystick1Button5", this.ELEJLIKAEBC);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HBIFCBKMMDC, (!this.visualize) ? 4 : 0);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)7 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.LNLDNPIMEEF(this.CEPKBFEEIFC, this.BOFPPGCEIDO, BMMLHGHKBNM);
				}
			}
			this.OHGHMBGFACB();
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x0028F304 File Offset: 0x0028D504
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.smoothness < 1075f)
			{
				this.smoothness = 363f;
			}
			this.bokeh = (this.bokeh && this.bokehSupport);
			float num = (!this.bokeh) ? 161f : DepthOfFieldDeprecated.JFDCOIIJDPH;
			bool flag = this.quality > (DepthOfFieldDeprecated.Dof34QualitySetting)0;
			float num2 = this.focalSize / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.IAJGMLGBOEN = ((!this.objectFocus) ? this.DBAHGBBNMOG(this.focalPoint) : (this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position).z / this.CNMFDOINHOL.farClipPlane));
				this.HKECIAKHAHN = this.IAJGMLGBOEN * this.smoothness;
				this.KIBGBAIJAIM = this.HKECIAKHAHN;
				flag = (!flag || this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.CNMFDOINHOL.farClipPlane;
					this.IAJGMLGBOEN = vector.z;
				}
				else
				{
					this.IAJGMLGBOEN = this.EOGHDOHBPLD(this.focalZDistance);
				}
				this.HKECIAKHAHN = this.focalZStartCurve;
				this.KIBGBAIJAIM = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			this.KCHCNFBLFDO = 617f * (float)HLBKCLPNHEB.width / (1754f * (float)HLBKCLPNHEB.height);
			this.NMOLKKBMGEC = 851f;
			this.HBIFCBKMMDC.SetFloat("Alpha", this.foregroundBlurExtrude);
			this.HBIFCBKMMDC.SetVector("isVisible", new Vector4((!this.simpleTweakMode) ? this.HKECIAKHAHN : (1032f / this.HKECIAKHAHN), (!this.simpleTweakMode) ? this.KIBGBAIJAIM : (1766f / this.KIBGBAIJAIM), num2 * 1219f, this.IAJGMLGBOEN));
			this.HBIFCBKMMDC.SetVector("{0} minutes ago", new Vector4(930f / (1047f * (float)HLBKCLPNHEB.width), 517f / (1193f * (float)HLBKCLPNHEB.height), 1529f, 285f));
			int num3 = this.LLOKAHCGOCC();
			int nffhbdffinp = this.HFGJNDIAMME(num3);
			this.CCIKKFFAHFI(flag, HLBKCLPNHEB, num3, nffhbdffinp);
			Graphics.Blit(HLBKCLPNHEB, HLBKCLPNHEB, this.HBIFCBKMMDC, 5);
			this.BEBMGPOCCNC(HLBKCLPNHEB, this.LFOOOIHIFIL);
			this.FBLOGOILHNG(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 2, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.HBIFCBKMMDC.SetVector("Feb", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 785f, 106f));
				Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 87);
				Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.LFMPBIIKIAM(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread * num);
			}
			else
			{
				this.EMGALHMELEM(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.FGPMDNINMJL(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread);
			}
			this.FKAKEHJOIDL.SetTexture("/../", this.HHKOGNNEKON);
			this.FKAKEHJOIDL.SetTexture("RecieveChatActionMessage", this.LFOOOIHIFIL);
			Graphics.Blit(null, this.ELEJLIKAEBC, this.FKAKEHJOIDL, 3);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.LNLDNPIMEEF(this.CEPKBFEEIFC, this.BOFPPGCEIDO, this.ELEJLIKAEBC);
			}
			this.HBIFCBKMMDC.SetTexture("_ThirdTex", this.ELEJLIKAEBC);
			this.HBIFCBKMMDC.SetTexture("_PositionY", this.LFOOOIHIFIL);
			Graphics.Blit(HLBKCLPNHEB, (!flag) ? BMMLHGHKBNM : this.HEBNMCEPMDH, this.HBIFCBKMMDC, (!this.visualize) ? 1 : 2);
			if (flag)
			{
				Graphics.Blit(this.HEBNMCEPMDH, HLBKCLPNHEB, this.HBIFCBKMMDC, 1);
				this.BEBMGPOCCNC(HLBKCLPNHEB, this.LFOOOIHIFIL);
				this.GKOMKJHNMLO(this.LFOOOIHIFIL, this.LFOOOIHIFIL, (DepthOfFieldDeprecated.DofBlurriness)0, 2, this.maxBlurSpread);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)0 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HBIFCBKMMDC.SetVector("workshop.", new Vector4(this.bokehThresholdContrast * 395f, this.bokehThresholdLuminance, 1533f, 502f));
					Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, -50);
					Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
					this.AFPDNPCJNFP(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread * num);
				}
				else
				{
					this.HIEOEDDHBPL(this.LFOOOIHIFIL, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.HHKOGNNEKON, this.ELEJLIKAEBC);
				this.HBIFCBKMMDC.SetTexture(".completedCount", this.ELEJLIKAEBC);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HBIFCBKMMDC, (!this.visualize) ? 2 : 1);
				if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.LNLDNPIMEEF(this.CEPKBFEEIFC, this.BOFPPGCEIDO, BMMLHGHKBNM);
				}
			}
			this.OHGHMBGFACB();
		}

		// Token: 0x06007CBF RID: 31935 RVA: 0x0028F920 File Offset: 0x0028DB20
		private float DBAHGBBNMOG(float JOCAFKLENDG)
		{
			return this.CNMFDOINHOL.WorldToViewportPoint((JOCAFKLENDG - this.CNMFDOINHOL.nearClipPlane) * this.CNMFDOINHOL.transform.forward + this.CNMFDOINHOL.transform.position).z / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
		}

		// Token: 0x06007CC0 RID: 31936 RVA: 0x0028F990 File Offset: 0x0028DB90
		private void FGPMDNINMJL(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, DepthOfFieldDeprecated.DofBlurriness OGFJPFIMOHG, int PMEDOCEEAHL, float MJFBFHDCCLE)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(HANEOLNMOEF.width, HANEOLNMOEF.height);
			if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.Low)
			{
				this.KCDMFJLHEOP(BHNGOLDNELC, HANEOLNMOEF, PMEDOCEEAHL, MJFBFHDCCLE, temporary);
				if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.Low)
				{
					this.FKAKEHJOIDL.SetVector("SpawnObj", new Vector4(1469f, MJFBFHDCCLE * this.NMOLKKBMGEC, 1403f, 1494f));
					Graphics.Blit(HANEOLNMOEF, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
					this.FKAKEHJOIDL.SetVector("' ping: ", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 1521f, 354f, 537f));
					Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
				}
			}
			else
			{
				this.FKAKEHJOIDL.SetVector("CameraFilterPack/Lut_Simple", new Vector4(936f, MJFBFHDCCLE * this.NMOLKKBMGEC, 726f, 1159f));
				Graphics.Blit(BHNGOLDNELC, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
				this.FKAKEHJOIDL.SetVector("Joystick", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 665f, 170f, 1498f));
				Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007CC1 RID: 31937 RVA: 0x0028FAD4 File Offset: 0x0028DCD4
		public virtual bool BCDIEBGNBEG()
		{
			base.FNIFJAENDIB(true);
			this.FKAKEHJOIDL = base.GJKHKCOAFDB(this.dofBlurShader, this.FKAKEHJOIDL);
			this.HBIFCBKMMDC = base.AJKPGPKKHHB(this.dofShader, this.HBIFCBKMMDC);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.OEPNIHPDAHN = base.ECNEGNMAMDE(this.bokehShader, this.OEPNIHPDAHN);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CC2 RID: 31938 RVA: 0x0028FB80 File Offset: 0x0028DD80
		public virtual bool OBEFMKGPJLI()
		{
			base.KHNPMDDIJAJ(true);
			this.FKAKEHJOIDL = base.ECNEGNMAMDE(this.dofBlurShader, this.FKAKEHJOIDL);
			this.HBIFCBKMMDC = base.AJKPGPKKHHB(this.dofShader, this.HBIFCBKMMDC);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.OEPNIHPDAHN = base.EDFIBHNHAAB(this.bokehShader, this.OEPNIHPDAHN);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CC3 RID: 31939 RVA: 0x0028FC2C File Offset: 0x0028DE2C
		private void CLLJDEAJDNL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.smoothness < 1674f)
			{
				this.smoothness = 909f;
			}
			this.bokeh = (!this.bokeh || this.bokehSupport);
			float num = (!this.bokeh) ? 1866f : DepthOfFieldDeprecated.JFDCOIIJDPH;
			bool flag = this.quality > (DepthOfFieldDeprecated.Dof34QualitySetting)0;
			float num2 = this.focalSize / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.IAJGMLGBOEN = ((!this.objectFocus) ? this.EOGHDOHBPLD(this.focalPoint) : (this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position).z / this.CNMFDOINHOL.farClipPlane));
				this.HKECIAKHAHN = this.IAJGMLGBOEN * this.smoothness;
				this.KIBGBAIJAIM = this.HKECIAKHAHN;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.CNMFDOINHOL.farClipPlane;
					this.IAJGMLGBOEN = vector.z;
				}
				else
				{
					this.IAJGMLGBOEN = this.EOGHDOHBPLD(this.focalZDistance);
				}
				this.HKECIAKHAHN = this.focalZStartCurve;
				this.KIBGBAIJAIM = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			this.KCHCNFBLFDO = 1835f * (float)HLBKCLPNHEB.width / (408f * (float)HLBKCLPNHEB.height);
			this.NMOLKKBMGEC = 1671f;
			this.HBIFCBKMMDC.SetFloat("SupportLogger OnJoinedRoom(", this.foregroundBlurExtrude);
			this.HBIFCBKMMDC.SetVector(". The group number should be at least 1.", new Vector4((!this.simpleTweakMode) ? this.HKECIAKHAHN : (1938f / this.HKECIAKHAHN), (!this.simpleTweakMode) ? this.KIBGBAIJAIM : (823f / this.KIBGBAIJAIM), num2 * 1795f, this.IAJGMLGBOEN));
			this.HBIFCBKMMDC.SetVector("CameraFilterPack/Lut_TestMode", new Vector4(433f / (1476f * (float)HLBKCLPNHEB.width), 188f / (439f * (float)HLBKCLPNHEB.height), 1186f, 689f));
			int num3 = this.ELBFILKHEGL();
			int nffhbdffinp = this.BMIBPGEPLCC(num3);
			this.CCIKKFFAHFI(flag, HLBKCLPNHEB, num3, nffhbdffinp);
			Graphics.Blit(HLBKCLPNHEB, HLBKCLPNHEB, this.HBIFCBKMMDC, 2);
			this.GDKEPFLCPEJ(HLBKCLPNHEB, this.LFOOOIHIFIL);
			this.OBJNLPLDBCL(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 4, this.maxBlurSpread);
			if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)8 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.HBIFCBKMMDC.SetVector("plainText", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 239f, 1122f));
				Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, -99);
				Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.FBLOGOILHNG(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread * num);
			}
			else
			{
				this.EMGALHMELEM(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.LFMPBIIKIAM(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread);
			}
			this.FKAKEHJOIDL.SetTexture("#yes", this.HHKOGNNEKON);
			this.FKAKEHJOIDL.SetTexture("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", this.LFOOOIHIFIL);
			Graphics.Blit(null, this.ELEJLIKAEBC, this.FKAKEHJOIDL, 6);
			if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)7 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.AKDJLEILFPI(this.CEPKBFEEIFC, this.BOFPPGCEIDO, this.ELEJLIKAEBC);
			}
			this.HBIFCBKMMDC.SetTexture("_TimeX", this.ELEJLIKAEBC);
			this.HBIFCBKMMDC.SetTexture("\\", this.LFOOOIHIFIL);
			Graphics.Blit(HLBKCLPNHEB, (!flag) ? BMMLHGHKBNM : this.HEBNMCEPMDH, this.HBIFCBKMMDC, (!this.visualize) ? 0 : 0);
			if (flag)
			{
				Graphics.Blit(this.HEBNMCEPMDH, HLBKCLPNHEB, this.HBIFCBKMMDC, 2);
				this.BEBMGPOCCNC(HLBKCLPNHEB, this.LFOOOIHIFIL);
				this.HIEOEDDHBPL(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 8, this.maxBlurSpread);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)6 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HBIFCBKMMDC.SetVector("AddEnvironmentObject", new Vector4(this.bokehThresholdContrast * 843f, this.bokehThresholdLuminance, 43f, 1061f));
					Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, -118);
					Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
					this.AFPDNPCJNFP(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread * num);
				}
				else
				{
					this.AFPDNPCJNFP(this.LFOOOIHIFIL, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.HHKOGNNEKON, this.ELEJLIKAEBC);
				this.HBIFCBKMMDC.SetTexture("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", this.ELEJLIKAEBC);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HBIFCBKMMDC, (!this.visualize) ? 1 : 1);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)4 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HKPLLMMMLOP(this.CEPKBFEEIFC, this.BOFPPGCEIDO, BMMLHGHKBNM);
				}
			}
			this.MENBHPCIOAF();
		}

		// Token: 0x06007CC4 RID: 31940 RVA: 0x00290247 File Offset: 0x0028E447
		private void PPFGHAKKLMN()
		{
			this.CNMFDOINHOL = base.GetComponent<Camera>();
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x06007CC5 RID: 31941 RVA: 0x0028C04F File Offset: 0x0028A24F
		private void OnDisable()
		{
			MLLAJENMBFL.Cleanup();
		}

		// Token: 0x06007CC6 RID: 31942 RVA: 0x00290268 File Offset: 0x0028E468
		private int NPNLNIJMGJN()
		{
			int result = 1;
			if (this.resolution == DepthOfFieldDeprecated.DofResolution.Medium)
			{
				result = 2;
			}
			else if (this.resolution == DepthOfFieldDeprecated.DofResolution.Low)
			{
				result = 2;
			}
			return result;
		}

		// Token: 0x06007CC7 RID: 31943 RVA: 0x0029029C File Offset: 0x0028E49C
		private void HKPLLMMMLOP(RenderTexture HJIOCDOBPKD, RenderTexture CKJJLLEBBLA, RenderTexture BNIKLMOBMHO)
		{
			if (this.OEPNIHPDAHN)
			{
				Mesh[] array = MLLAJENMBFL.NDLJOOHNLEC(CKJJLLEBBLA.width, CKJJLLEBBLA.height);
				RenderTexture.active = CKJJLLEBBLA;
				GL.Clear(true, false, new Color(1846f, 1446f, 641f, 1589f));
				GL.PushMatrix();
				GL.LoadIdentity();
				HJIOCDOBPKD.filterMode = FilterMode.Point;
				float num = (float)HJIOCDOBPKD.width * 1172f / ((float)HJIOCDOBPKD.height * 1628f);
				float num2 = 1137f / (1751f * (float)HJIOCDOBPKD.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.JFDCOIIJDPH * this.NMOLKKBMGEC;
				this.OEPNIHPDAHN.SetTexture("_Offsets", HJIOCDOBPKD);
				this.OEPNIHPDAHN.SetTexture("useSrcAlphaAsMask", this.bokehTexture);
				this.OEPNIHPDAHN.SetVector("2", new Vector4(num2, num2 * num, 1622f, 1907f * num));
				this.OEPNIHPDAHN.SetFloat(". Name: ", this.bokehIntensity);
				this.OEPNIHPDAHN.SetPass(1);
				Mesh[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(CKJJLLEBBLA, BNIKLMOBMHO, this.HBIFCBKMMDC, 4);
				HJIOCDOBPKD.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x06007CC8 RID: 31944 RVA: 0x00290410 File Offset: 0x0028E610
		private int JCCJAKBFIJA(int KIHHCOMDHBL)
		{
			int num = KIHHCOMDHBL;
			if (this.resolution == DepthOfFieldDeprecated.DofResolution.Low)
			{
				num *= 6;
			}
			if (this.resolution == (DepthOfFieldDeprecated.DofResolution)1)
			{
				num *= 3;
			}
			return num;
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x00290440 File Offset: 0x0028E640
		private void EAHCLIEEJOG()
		{
			MLLAJENMBFL.CPIHKPFFHFD();
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x00290448 File Offset: 0x0028E648
		private void ILKMHIMOFNH()
		{
			this.FKAKEHJOIDL = base.KDHKHOHMKCG(this.dofBlurShader, this.FKAKEHJOIDL);
			this.HBIFCBKMMDC = base.ECNEGNMAMDE(this.dofShader, this.HBIFCBKMMDC);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.OEPNIHPDAHN = base.ECNEGNMAMDE(this.bokehShader, this.OEPNIHPDAHN);
			}
		}

		// Token: 0x06007CCB RID: 31947 RVA: 0x002904D4 File Offset: 0x0028E6D4
		private void JOJFHFHOCHO()
		{
			MLLAJENMBFL.KMHDKCNHIAF();
		}

		// Token: 0x06007CCC RID: 31948 RVA: 0x002904DC File Offset: 0x0028E6DC
		private void HIEOEDDHBPL(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, DepthOfFieldDeprecated.DofBlurriness OGFJPFIMOHG, int PMEDOCEEAHL, float MJFBFHDCCLE)
		{
			this.FKAKEHJOIDL.SetTexture("\\", BHNGOLDNELC);
			RenderTexture temporary = RenderTexture.GetTemporary(HANEOLNMOEF.width, HANEOLNMOEF.height);
			if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.Low)
			{
				this.FHHMFEKLLKP(BHNGOLDNELC, HANEOLNMOEF, PMEDOCEEAHL, MJFBFHDCCLE, temporary);
				if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.Low)
				{
					this.FKAKEHJOIDL.SetVector("rd", new Vector4(1215f, MJFBFHDCCLE * this.NMOLKKBMGEC, 1588f, 1070f));
					Graphics.Blit(HANEOLNMOEF, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
					this.FKAKEHJOIDL.SetVector("_Value4", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 764f, 444f, 1012f));
					Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
				}
			}
			else
			{
				this.FKAKEHJOIDL.SetVector("LevelEditor/patterns", new Vector4(884f, MJFBFHDCCLE * this.NMOLKKBMGEC, 79f, 731f));
				Graphics.Blit(BHNGOLDNELC, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
				this.FKAKEHJOIDL.SetVector("setbool", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 1057f, 1715f, 1342f));
				Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x00290630 File Offset: 0x0028E830
		private void BEBMGPOCCNC(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.HBIFCBKMMDC.SetVector("Items/", new Vector4(688f / (234f * (float)HANEOLNMOEF.width), 1262f / (1836f * (float)HANEOLNMOEF.height), 1129f, 1864f));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.HBIFCBKMMDC, DepthOfFieldDeprecated.HKCKKGDOHGD);
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x00290694 File Offset: 0x0028E894
		private void OHGHMBGFACB()
		{
			if (this.HEBNMCEPMDH)
			{
				RenderTexture.ReleaseTemporary(this.HEBNMCEPMDH);
			}
			if (this.ELEJLIKAEBC)
			{
				RenderTexture.ReleaseTemporary(this.ELEJLIKAEBC);
			}
			if (this.LFOOOIHIFIL)
			{
				RenderTexture.ReleaseTemporary(this.LFOOOIHIFIL);
			}
			if (this.HHKOGNNEKON)
			{
				RenderTexture.ReleaseTemporary(this.HHKOGNNEKON);
			}
			if (this.BOFPPGCEIDO)
			{
				RenderTexture.ReleaseTemporary(this.BOFPPGCEIDO);
			}
			if (this.CEPKBFEEIFC)
			{
				RenderTexture.ReleaseTemporary(this.CEPKBFEEIFC);
			}
		}

		// Token: 0x06007CCF RID: 31951 RVA: 0x00290744 File Offset: 0x0028E944
		private void PHGBAGOLIPD(RenderTexture HJIOCDOBPKD, RenderTexture CKJJLLEBBLA, RenderTexture BNIKLMOBMHO)
		{
			if (this.OEPNIHPDAHN)
			{
				Mesh[] array = MLLAJENMBFL.NHHAKHFDHBJ(CKJJLLEBBLA.width, CKJJLLEBBLA.height);
				RenderTexture.active = CKJJLLEBBLA;
				GL.Clear(true, false, new Color(241f, 1965f, 814f, 310f));
				GL.PushMatrix();
				GL.LoadIdentity();
				HJIOCDOBPKD.filterMode = FilterMode.Bilinear;
				float num = (float)HJIOCDOBPKD.width * 1050f / ((float)HJIOCDOBPKD.height * 1584f);
				float num2 = 61f / (1038f * (float)HJIOCDOBPKD.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.JFDCOIIJDPH * this.NMOLKKBMGEC;
				this.OEPNIHPDAHN.SetTexture("[Right]", HJIOCDOBPKD);
				this.OEPNIHPDAHN.SetTexture("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", this.bokehTexture);
				this.OEPNIHPDAHN.SetVector("MapEnd", new Vector4(num2, num2 * num, 174f, 1289f * num));
				this.OEPNIHPDAHN.SetFloat("System.Int32", this.bokehIntensity);
				this.OEPNIHPDAHN.SetPass(1);
				Mesh[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(CKJJLLEBBLA, BNIKLMOBMHO, this.HBIFCBKMMDC, 2);
				HJIOCDOBPKD.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x06007CD0 RID: 31952 RVA: 0x002908B8 File Offset: 0x0028EAB8
		private void HCJEEINBNBN()
		{
			this.FKAKEHJOIDL = base.GJKHKCOAFDB(this.dofBlurShader, this.FKAKEHJOIDL);
			this.HBIFCBKMMDC = base.AJKPGPKKHHB(this.dofShader, this.HBIFCBKMMDC);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.OEPNIHPDAHN = base.ECNEGNMAMDE(this.bokehShader, this.OEPNIHPDAHN);
			}
		}

		// Token: 0x06007CD1 RID: 31953 RVA: 0x00290944 File Offset: 0x0028EB44
		private void MENBHPCIOAF()
		{
			if (this.HEBNMCEPMDH)
			{
				RenderTexture.ReleaseTemporary(this.HEBNMCEPMDH);
			}
			if (this.ELEJLIKAEBC)
			{
				RenderTexture.ReleaseTemporary(this.ELEJLIKAEBC);
			}
			if (this.LFOOOIHIFIL)
			{
				RenderTexture.ReleaseTemporary(this.LFOOOIHIFIL);
			}
			if (this.HHKOGNNEKON)
			{
				RenderTexture.ReleaseTemporary(this.HHKOGNNEKON);
			}
			if (this.BOFPPGCEIDO)
			{
				RenderTexture.ReleaseTemporary(this.BOFPPGCEIDO);
			}
			if (this.CEPKBFEEIFC)
			{
				RenderTexture.ReleaseTemporary(this.CEPKBFEEIFC);
			}
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x002909F4 File Offset: 0x0028EBF4
		private void OBJNLPLDBCL(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF, DepthOfFieldDeprecated.DofBlurriness OGFJPFIMOHG, int PMEDOCEEAHL, float MJFBFHDCCLE)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(HANEOLNMOEF.width, HANEOLNMOEF.height);
			if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.Low)
			{
				this.CFBPFHHIPEK(BHNGOLDNELC, HANEOLNMOEF, PMEDOCEEAHL, MJFBFHDCCLE, temporary);
				if (OGFJPFIMOHG > DepthOfFieldDeprecated.DofBlurriness.High)
				{
					this.FKAKEHJOIDL.SetVector("offsets", new Vector4(0f, MJFBFHDCCLE * this.NMOLKKBMGEC, 0f, 0f));
					Graphics.Blit(HANEOLNMOEF, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
					this.FKAKEHJOIDL.SetVector("offsets", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 0f, 0f, 0f));
					Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
				}
			}
			else
			{
				this.FKAKEHJOIDL.SetVector("offsets", new Vector4(0f, MJFBFHDCCLE * this.NMOLKKBMGEC, 0f, 0f));
				Graphics.Blit(BHNGOLDNELC, temporary, this.FKAKEHJOIDL, PMEDOCEEAHL);
				this.FKAKEHJOIDL.SetVector("offsets", new Vector4(MJFBFHDCCLE / this.KCHCNFBLFDO * this.NMOLKKBMGEC, 0f, 0f, 0f));
				Graphics.Blit(temporary, HANEOLNMOEF, this.FKAKEHJOIDL, PMEDOCEEAHL);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x00290B38 File Offset: 0x0028ED38
		private void JHFFDCOIDJH(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.HBIFCBKMMDC.SetVector("Ownership mode == fixed. Ignoring request.", new Vector4(821f / (1050f * (float)HANEOLNMOEF.width), 1317f / (1339f * (float)HANEOLNMOEF.height), 1383f, 1194f));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.HBIFCBKMMDC, DepthOfFieldDeprecated.HKCKKGDOHGD);
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x00290B9C File Offset: 0x0028ED9C
		private void OAHHAAKEBDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.smoothness < 1053f)
			{
				this.smoothness = 1445f;
			}
			this.bokeh = (this.bokeh && this.bokehSupport);
			float num = (!this.bokeh) ? 1901f : DepthOfFieldDeprecated.JFDCOIIJDPH;
			bool flag = this.quality > (DepthOfFieldDeprecated.Dof34QualitySetting)0;
			float num2 = this.focalSize / (this.CNMFDOINHOL.farClipPlane - this.CNMFDOINHOL.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.IAJGMLGBOEN = ((!this.objectFocus) ? this.KJMFPJKGLOE(this.focalPoint) : (this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position).z / this.CNMFDOINHOL.farClipPlane));
				this.HKECIAKHAHN = this.IAJGMLGBOEN * this.smoothness;
				this.KIBGBAIJAIM = this.HKECIAKHAHN;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.CNMFDOINHOL.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.CNMFDOINHOL.farClipPlane;
					this.IAJGMLGBOEN = vector.z;
				}
				else
				{
					this.IAJGMLGBOEN = this.DBAHGBBNMOG(this.focalZDistance);
				}
				this.HKECIAKHAHN = this.focalZStartCurve;
				this.KIBGBAIJAIM = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.CNMFDOINHOL.nearClipPlane + Mathf.Epsilon);
			}
			this.KCHCNFBLFDO = 1708f * (float)HLBKCLPNHEB.width / (1388f * (float)HLBKCLPNHEB.height);
			this.NMOLKKBMGEC = 1816f;
			this.HBIFCBKMMDC.SetFloat("CameraFilterPack_Paper2", this.foregroundBlurExtrude);
			this.HBIFCBKMMDC.SetVector("{0}", new Vector4((!this.simpleTweakMode) ? this.HKECIAKHAHN : (326f / this.HKECIAKHAHN), (!this.simpleTweakMode) ? this.KIBGBAIJAIM : (763f / this.KIBGBAIJAIM), num2 * 170f, this.IAJGMLGBOEN));
			this.HBIFCBKMMDC.SetVector("_ScreenResolution", new Vector4(1547f / (927f * (float)HLBKCLPNHEB.width), 672f / (1392f * (float)HLBKCLPNHEB.height), 823f, 1632f));
			int num3 = this.NPNLNIJMGJN();
			int nffhbdffinp = this.LPLDBEMMFJK(num3);
			this.LHBMOKOHNKC(flag, HLBKCLPNHEB, num3, nffhbdffinp);
			Graphics.Blit(HLBKCLPNHEB, HLBKCLPNHEB, this.HBIFCBKMMDC, 5);
			this.ABGNELIGNEI(HLBKCLPNHEB, this.LFOOOIHIFIL);
			this.FGPMDNINMJL(this.LFOOOIHIFIL, this.LFOOOIHIFIL, DepthOfFieldDeprecated.DofBlurriness.Low, 7, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.BackgroundAndForeground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.HBIFCBKMMDC.SetVector("SetSunSensitivity", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 1457f, 474f));
				Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 4);
				Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.FBLOGOILHNG(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread * num);
			}
			else
			{
				this.JHFFDCOIDJH(this.LFOOOIHIFIL, this.HHKOGNNEKON);
				this.LFMPBIIKIAM(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread);
			}
			this.FKAKEHJOIDL.SetTexture("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", this.HHKOGNNEKON);
			this.FKAKEHJOIDL.SetTexture("_TimeX", this.LFOOOIHIFIL);
			Graphics.Blit(null, this.ELEJLIKAEBC, this.FKAKEHJOIDL, 2);
			if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.BackgroundAndForeground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
			{
				this.LNLDNPIMEEF(this.CEPKBFEEIFC, this.BOFPPGCEIDO, this.ELEJLIKAEBC);
			}
			this.HBIFCBKMMDC.SetTexture("_Distortion", this.ELEJLIKAEBC);
			this.HBIFCBKMMDC.SetTexture("time", this.LFOOOIHIFIL);
			Graphics.Blit(HLBKCLPNHEB, (!flag) ? BMMLHGHKBNM : this.HEBNMCEPMDH, this.HBIFCBKMMDC, (!this.visualize) ? 0 : 8);
			if (flag)
			{
				Graphics.Blit(this.HEBNMCEPMDH, HLBKCLPNHEB, this.HBIFCBKMMDC, 1);
				this.GDKEPFLCPEJ(HLBKCLPNHEB, this.LFOOOIHIFIL);
				this.EAAIFEBIIBG(this.LFOOOIHIFIL, this.LFOOOIHIFIL, (DepthOfFieldDeprecated.DofBlurriness)0, 0, this.maxBlurSpread);
				if (this.bokeh && ((DepthOfFieldDeprecated.BokehDestination)4 & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.HBIFCBKMMDC.SetVector("float,1.5", new Vector4(this.bokehThresholdContrast * 1489f, this.bokehThresholdLuminance, 1552f, 35f));
					Graphics.Blit(this.LFOOOIHIFIL, this.CEPKBFEEIFC, this.HBIFCBKMMDC, 88);
					Graphics.Blit(this.LFOOOIHIFIL, this.HHKOGNNEKON);
					this.GKOMKJHNMLO(this.HHKOGNNEKON, this.HHKOGNNEKON, this.bluriness, 0, this.maxBlurSpread * num);
				}
				else
				{
					this.EAAIFEBIIBG(this.LFOOOIHIFIL, this.HHKOGNNEKON, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.HHKOGNNEKON, this.ELEJLIKAEBC);
				this.HBIFCBKMMDC.SetTexture("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ", this.ELEJLIKAEBC);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HBIFCBKMMDC, (!this.visualize) ? 4 : 0);
				if (this.bokeh && (DepthOfFieldDeprecated.BokehDestination.BackgroundAndForeground & this.bokehDestination) != (DepthOfFieldDeprecated.BokehDestination)0)
				{
					this.BPIKKHFFDEE(this.CEPKBFEEIFC, this.BOFPPGCEIDO, BMMLHGHKBNM);
				}
			}
			this.OHGHMBGFACB();
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x002911B8 File Offset: 0x0028F3B8
		private void PDOEIKKCPMM()
		{
			if (this.HEBNMCEPMDH)
			{
				RenderTexture.ReleaseTemporary(this.HEBNMCEPMDH);
			}
			if (this.ELEJLIKAEBC)
			{
				RenderTexture.ReleaseTemporary(this.ELEJLIKAEBC);
			}
			if (this.LFOOOIHIFIL)
			{
				RenderTexture.ReleaseTemporary(this.LFOOOIHIFIL);
			}
			if (this.HHKOGNNEKON)
			{
				RenderTexture.ReleaseTemporary(this.HHKOGNNEKON);
			}
			if (this.BOFPPGCEIDO)
			{
				RenderTexture.ReleaseTemporary(this.BOFPPGCEIDO);
			}
			if (this.CEPKBFEEIFC)
			{
				RenderTexture.ReleaseTemporary(this.CEPKBFEEIFC);
			}
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x00291268 File Offset: 0x0028F468
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(true);
			this.FKAKEHJOIDL = base.EDFIBHNHAAB(this.dofBlurShader, this.FKAKEHJOIDL);
			this.HBIFCBKMMDC = base.EDFIBHNHAAB(this.dofShader, this.HBIFCBKMMDC);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.OEPNIHPDAHN = base.EDFIBHNHAAB(this.bokehShader, this.OEPNIHPDAHN);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x00291314 File Offset: 0x0028F514
		private int LPLDBEMMFJK(int KIHHCOMDHBL)
		{
			int num = KIHHCOMDHBL;
			if (this.resolution == (DepthOfFieldDeprecated.DofResolution)7)
			{
				num *= 8;
			}
			if (this.resolution == (DepthOfFieldDeprecated.DofResolution)5)
			{
				num *= 1;
			}
			return num;
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x00291344 File Offset: 0x0028F544
		private void ABGNELIGNEI(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.HBIFCBKMMDC.SetVector("<color=white>PhotonView Group: ", new Vector4(339f / (200f * (float)HANEOLNMOEF.width), 1464f / (1557f * (float)HANEOLNMOEF.height), 1701f, 924f));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.HBIFCBKMMDC, DepthOfFieldDeprecated.HKCKKGDOHGD);
		}

		// Token: 0x06007CD9 RID: 31961 RVA: 0x002913A8 File Offset: 0x0028F5A8
		private void GDKEPFLCPEJ(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.HBIFCBKMMDC.SetVector("id", new Vector4(450f / (948f * (float)HANEOLNMOEF.width), 1157f / (84f * (float)HANEOLNMOEF.height), 479f, 537f));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.HBIFCBKMMDC, DepthOfFieldDeprecated.HKCKKGDOHGD);
		}

		// Token: 0x04000DC5 RID: 3525
		private static int HKCKKGDOHGD = 6;

		// Token: 0x04000DC6 RID: 3526
		private static float JFDCOIIJDPH = 2f;

		// Token: 0x04000DC7 RID: 3527
		public DepthOfFieldDeprecated.Dof34QualitySetting quality = DepthOfFieldDeprecated.Dof34QualitySetting.OnlyBackground;

		// Token: 0x04000DC8 RID: 3528
		public DepthOfFieldDeprecated.DofResolution resolution = DepthOfFieldDeprecated.DofResolution.Low;

		// Token: 0x04000DC9 RID: 3529
		public bool simpleTweakMode = true;

		// Token: 0x04000DCA RID: 3530
		public float focalPoint = 1f;

		// Token: 0x04000DCB RID: 3531
		public float smoothness = 0.5f;

		// Token: 0x04000DCC RID: 3532
		public float focalZDistance;

		// Token: 0x04000DCD RID: 3533
		public float focalZStartCurve = 1f;

		// Token: 0x04000DCE RID: 3534
		public float focalZEndCurve = 1f;

		// Token: 0x04000DCF RID: 3535
		private float HKECIAKHAHN = 2f;

		// Token: 0x04000DD0 RID: 3536
		private float KIBGBAIJAIM = 2f;

		// Token: 0x04000DD1 RID: 3537
		private float IAJGMLGBOEN = 0.1f;

		// Token: 0x04000DD2 RID: 3538
		public Transform objectFocus;

		// Token: 0x04000DD3 RID: 3539
		public float focalSize;

		// Token: 0x04000DD4 RID: 3540
		public DepthOfFieldDeprecated.DofBlurriness bluriness = DepthOfFieldDeprecated.DofBlurriness.High;

		// Token: 0x04000DD5 RID: 3541
		public float maxBlurSpread = 1.75f;

		// Token: 0x04000DD6 RID: 3542
		public float foregroundBlurExtrude = 1.15f;

		// Token: 0x04000DD7 RID: 3543
		public Shader dofBlurShader;

		// Token: 0x04000DD8 RID: 3544
		private Material FKAKEHJOIDL;

		// Token: 0x04000DD9 RID: 3545
		public Shader dofShader;

		// Token: 0x04000DDA RID: 3546
		private Material HBIFCBKMMDC;

		// Token: 0x04000DDB RID: 3547
		public bool visualize;

		// Token: 0x04000DDC RID: 3548
		public DepthOfFieldDeprecated.BokehDestination bokehDestination = DepthOfFieldDeprecated.BokehDestination.Background;

		// Token: 0x04000DDD RID: 3549
		private float KCHCNFBLFDO = 1.25f;

		// Token: 0x04000DDE RID: 3550
		private float NMOLKKBMGEC = 0.001953125f;

		// Token: 0x04000DDF RID: 3551
		public bool bokeh;

		// Token: 0x04000DE0 RID: 3552
		public bool bokehSupport = true;

		// Token: 0x04000DE1 RID: 3553
		public Shader bokehShader;

		// Token: 0x04000DE2 RID: 3554
		public Texture2D bokehTexture;

		// Token: 0x04000DE3 RID: 3555
		public float bokehScale = 2.4f;

		// Token: 0x04000DE4 RID: 3556
		public float bokehIntensity = 0.15f;

		// Token: 0x04000DE5 RID: 3557
		public float bokehThresholdContrast = 0.1f;

		// Token: 0x04000DE6 RID: 3558
		public float bokehThresholdLuminance = 0.55f;

		// Token: 0x04000DE7 RID: 3559
		public int bokehDownsample = 1;

		// Token: 0x04000DE8 RID: 3560
		private Material OEPNIHPDAHN;

		// Token: 0x04000DE9 RID: 3561
		private Camera CNMFDOINHOL;

		// Token: 0x04000DEA RID: 3562
		private RenderTexture HEBNMCEPMDH;

		// Token: 0x04000DEB RID: 3563
		private RenderTexture LFOOOIHIFIL;

		// Token: 0x04000DEC RID: 3564
		private RenderTexture ELEJLIKAEBC;

		// Token: 0x04000DED RID: 3565
		private RenderTexture HHKOGNNEKON;

		// Token: 0x04000DEE RID: 3566
		private RenderTexture BOFPPGCEIDO;

		// Token: 0x04000DEF RID: 3567
		private RenderTexture CEPKBFEEIFC;

		// Token: 0x020001DE RID: 478
		public enum Dof34QualitySetting
		{
			// Token: 0x04000DF1 RID: 3569
			OnlyBackground = 1,
			// Token: 0x04000DF2 RID: 3570
			BackgroundAndForeground
		}

		// Token: 0x020001DF RID: 479
		public enum DofResolution
		{
			// Token: 0x04000DF4 RID: 3572
			High = 2,
			// Token: 0x04000DF5 RID: 3573
			Medium,
			// Token: 0x04000DF6 RID: 3574
			Low
		}

		// Token: 0x020001E0 RID: 480
		public enum DofBlurriness
		{
			// Token: 0x04000DF8 RID: 3576
			Low = 1,
			// Token: 0x04000DF9 RID: 3577
			High,
			// Token: 0x04000DFA RID: 3578
			VeryHigh = 4
		}

		// Token: 0x020001E1 RID: 481
		public enum BokehDestination
		{
			// Token: 0x04000DFC RID: 3580
			Background = 1,
			// Token: 0x04000DFD RID: 3581
			Foreground,
			// Token: 0x04000DFE RID: 3582
			BackgroundAndForeground
		}
	}
}
