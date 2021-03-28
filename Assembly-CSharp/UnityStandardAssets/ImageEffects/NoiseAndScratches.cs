using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001EB RID: 491
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	[ExecuteInEditMode]
	public class NoiseAndScratches : MonoBehaviour
	{
		// Token: 0x06007ECB RID: 32459 RVA: 0x002A288C File Offset: 0x002A0A8C
		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("Noise shaders are not set up! Disabling noise effect.");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007ECC RID: 32460 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void BJOHDLNDFAD()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007ECD RID: 32461 RVA: 0x002A2950 File Offset: 0x002A0B50
		protected Material CFEDGDGBCHE()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = HideFlags.DontUnloadUnusedAsset;
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007ECE RID: 32462 RVA: 0x002A29F0 File Offset: 0x002A0BF0
		protected Material LDNADDJMIPK()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)(-81);
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007ECF RID: 32463 RVA: 0x002A2A90 File Offset: 0x002A0C90
		private void HIOJCEEFKMJ()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 489f, 656f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 2f, 678f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 235f, 1614f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1359f, 1946f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 361f, 16f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 931f, 913f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1726f, 10f);
		}

		// Token: 0x06007ED0 RID: 32464 RVA: 0x002A2B5C File Offset: 0x002A0D5C
		protected void KDMKDEKCELE()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("0,1,true,0");
				base.enabled = true;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = false;
			}
		}

		// Token: 0x06007ED1 RID: 32465 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void ICDBMJKMIKC()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007ED2 RID: 32466 RVA: 0x002A2BE8 File Offset: 0x002A0DE8
		private void GFBJOHMDKCG()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 0f, 5f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 0f, 5f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 0f, 5f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 0f, 5f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1f, 30f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 0f, 1f);
			this.grainSize = Mathf.Clamp(this.grainSize, 0.1f, 50f);
		}

		// Token: 0x06007ED3 RID: 32467 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void HONBLGFDMLL()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007ED4 RID: 32468 RVA: 0x002A2CB4 File Offset: 0x002A0EB4
		protected void BGDPIHMAACO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("Committing changes...");
				base.enabled = true;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007ED5 RID: 32469 RVA: 0x002A2D40 File Offset: 0x002A0F40
		protected void NCNPAKFAFOE()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("_CenterY");
				base.enabled = true;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007ED6 RID: 32470 RVA: 0x002A2DCC File Offset: 0x002A0FCC
		private void FCBAMFPKNPN()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 326f, 1202f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 811f, 1650f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1680f, 1584f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1426f, 1966f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 927f, 847f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 158f, 1871f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1754f, 482f);
		}

		// Token: 0x06007ED7 RID: 32471 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void JNGMIAFLBDL()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007ED8 RID: 32472 RVA: 0x002A2E98 File Offset: 0x002A1098
		protected Material GHHPOGODBHB()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags)114;
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007ED9 RID: 32473 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void GAOOPEEBGJA()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007EDA RID: 32474 RVA: 0x002A2F38 File Offset: 0x002A1138
		protected void EGEPLFGKGLI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = false;
			}
		}

		// Token: 0x06007EDB RID: 32475 RVA: 0x002A2FC4 File Offset: 0x002A11C4
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.GFBJOHMDKCG();
			if (this.POPBKOPEELE <= 1237f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 1082f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.KBOPGONOCNP();
			material.SetTexture("Needs to be attached to the Event System component in the scene", this.grainTexture);
			material.SetTexture("[Up]", this.scratchTexture);
			float num = 1689f / this.grainSize;
			material.SetVector("settings.crosshairopacity", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("SpawnObj", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("scene ", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1226f, 312f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void JLNNHKPHMAB()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x002A3144 File Offset: 0x002A1344
		protected Material FEAEGGCNIAA()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags)(-118);
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)(-99);
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x002A31E4 File Offset: 0x002A13E4
		protected Material OCHJIMJNEMO()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)(-117);
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007EDF RID: 32479 RVA: 0x002A3284 File Offset: 0x002A1484
		private void HANMFFCEOCK()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1327f, 678f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1412f, 1789f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1448f, 880f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 68f, 148f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1135f, 1926f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 543f, 839f);
			this.grainSize = Mathf.Clamp(this.grainSize, 26f, 248f);
		}

		// Token: 0x06007EE1 RID: 32481 RVA: 0x002A33B8 File Offset: 0x002A15B8
		private void PJKAGNNNFGK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.GFBJOHMDKCG();
			if (this.POPBKOPEELE <= 493f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 879f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.FHFLKLMFHOI();
			material.SetTexture("HiddenToggle", this.grainTexture);
			material.SetTexture("[PlayerController] ", this.scratchTexture);
			float num = 429f / this.grainSize;
			material.SetVector(". Client should be in a room. Current connectionStateDetailed: ", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("&search=", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_BlurVector", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1712f, 891f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EE2 RID: 32482 RVA: 0x002A3538 File Offset: 0x002A1738
		protected void IHLMNAGPKDA()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("\" that takes ");
				base.enabled = true;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = false;
			}
		}

		// Token: 0x06007EE3 RID: 32483 RVA: 0x002A35C4 File Offset: 0x002A17C4
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.GFBJOHMDKCG();
			if (this.POPBKOPEELE <= 0f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 2f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.NBPKMLMCHFN;
			material.SetTexture("_GrainTex", this.grainTexture);
			material.SetTexture("_ScratchTex", this.scratchTexture);
			float num = 1f / this.grainSize;
			material.SetVector("_GrainOffsetScale", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("_ScratchOffsetScale", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_Intensity", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 0f, 0f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EE4 RID: 32484 RVA: 0x002A3744 File Offset: 0x002A1944
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.GFBJOHMDKCG();
			if (this.POPBKOPEELE <= 517f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 1399f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.LDNADDJMIPK();
			material.SetTexture("[LevelEditorScene] Exported to ", this.grainTexture);
			material.SetTexture("ShowSprite", this.scratchTexture);
			float num = 679f / this.grainSize;
			material.SetVector("error", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector(". Current number of cells is ", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("sfxVolume", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 690f, 1667f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EE5 RID: 32485 RVA: 0x002A38C4 File Offset: 0x002A1AC4
		protected void FHGKIOOMMOH()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("_Value6");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = false;
			}
		}

		// Token: 0x06007EE6 RID: 32486 RVA: 0x002A3950 File Offset: 0x002A1B50
		private void DHJKAOMONAJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.KCHPIGEJELN();
			if (this.POPBKOPEELE <= 392f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 362f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.NBPKMLMCHFN;
			material.SetTexture("_Value7", this.grainTexture);
			material.SetTexture("<color=white>", this.scratchTexture);
			float num = 1705f / this.grainSize;
			material.SetVector("restrictions", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("CheckpointsScoreText", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1133f, 595f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EE7 RID: 32487 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void MGFFNGEGFDC()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x002A3AD0 File Offset: 0x002A1CD0
		private void MMBPPEPNNLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.APEIBMLNMEE();
			if (this.POPBKOPEELE <= 466f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 1644f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.BFGNMFCNDBC();
			material.SetTexture("_ScreenResolution", this.grainTexture);
			material.SetTexture("_DistortionSize", this.scratchTexture);
			float num = 947f / this.grainSize;
			material.SetVector("[ItemsHandler] Found ", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("#combo", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("Bad parameters for getstring! Use <key> <value>", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 208f, 1234f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EE9 RID: 32489 RVA: 0x002A3C50 File Offset: 0x002A1E50
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.HANMFFCEOCK();
			if (this.POPBKOPEELE <= 414f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 1181f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.FAIFBBGFAIB();
			material.SetTexture("_ScreenResolution", this.grainTexture);
			material.SetTexture(" registered.", this.scratchTexture);
			float num = 1316f / this.grainSize;
			material.SetVector("_ScreenResolution", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("float,0", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("GroupNameText", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 713f, 741f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EEA RID: 32490 RVA: 0x002A3DD0 File Offset: 0x002A1FD0
		private void NEALKDCJCJH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.HANMFFCEOCK();
			if (this.POPBKOPEELE <= 724f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 1884f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.OCHJIMJNEMO();
			material.SetTexture("_MainTex2", this.grainTexture);
			material.SetTexture("BitsData", this.scratchTexture);
			float num = 1259f / this.grainSize;
			material.SetVector("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("RanksButton", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("</color>", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1350f, 1620f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EEB RID: 32491 RVA: 0x002A3F50 File Offset: 0x002A2150
		protected void PKLOBJHKFEO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("workshop.");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007EEC RID: 32492 RVA: 0x002A3FDC File Offset: 0x002A21DC
		private void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.HIOJCEEFKMJ();
			if (this.POPBKOPEELE <= 1684f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 1599f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.EFDEIFCDAFG();
			material.SetTexture("Electronic", this.grainTexture);
			material.SetTexture("_FixDistance", this.scratchTexture);
			float num = 375f / this.grainSize;
			material.SetVector("_PosX", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Status: ", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("You have added the SecondScrollRect to a scroll view that already has both directions selected", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 176f, 694f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EED RID: 32493 RVA: 0x002A415C File Offset: 0x002A235C
		protected void KIMMMCJFMAB()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("#8E8E8EFF");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = false;
			}
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x002A41E8 File Offset: 0x002A23E8
		private void AODKAMLEIOJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.HANMFFCEOCK();
			if (this.POPBKOPEELE <= 256f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 796f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.FHFLKLMFHOI();
			material.SetTexture("_Red_C", this.grainTexture);
			material.SetTexture("[Right-Down]", this.scratchTexture);
			float num = 1539f / this.grainSize;
			material.SetVector("DPADHOR", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("_CenterX", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector(".completed", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 586f, 433f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EEF RID: 32495 RVA: 0x002A4368 File Offset: 0x002A2568
		private void APEIBMLNMEE()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1767f, 1092f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 426f, 316f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 477f, 809f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 112f, 1888f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 306f, 904f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 1233f, 1999f);
			this.grainSize = Mathf.Clamp(this.grainSize, 230f, 842f);
		}

		// Token: 0x06007EF0 RID: 32496 RVA: 0x002A4434 File Offset: 0x002A2634
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.FCBAMFPKNPN();
			if (this.POPBKOPEELE <= 1243f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 1062f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.ADGHJOHKEHG();
			material.SetTexture(" has ", this.grainTexture);
			material.SetTexture("Horizontal", this.scratchTexture);
			float num = 800f / this.grainSize;
			material.SetVector("_History1ChromaTex", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("_Curve", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("\" call.", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1504f, 122f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EF1 RID: 32497 RVA: 0x002A45B4 File Offset: 0x002A27B4
		protected Material LONNIJMNKFB()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags)(-110);
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)(-86);
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void CPAJLKHMOJB()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06007EF3 RID: 32499 RVA: 0x002A4654 File Offset: 0x002A2854
		protected Material NBPKMLMCHFN
		{
			get
			{
				if (this.FACAJJODADL == null)
				{
					this.FACAJJODADL = new Material(this.shaderRGB);
					this.FACAJJODADL.hideFlags = HideFlags.HideAndDontSave;
				}
				if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
				{
					this.NEKJGMJANAA = new Material(this.shaderYUV);
					this.NEKJGMJANAA.hideFlags = HideFlags.HideAndDontSave;
				}
				return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
			}
		}

		// Token: 0x06007EF4 RID: 32500 RVA: 0x002A46F4 File Offset: 0x002A28F4
		protected Material FHFLKLMFHOI()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags)(-83);
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)70;
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007EF5 RID: 32501 RVA: 0x002A4794 File Offset: 0x002A2994
		private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.APEIBMLNMEE();
			if (this.POPBKOPEELE <= 1037f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 308f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.EFDEIFCDAFG();
			material.SetTexture("PLEASE WAIT", this.grainTexture);
			material.SetTexture("SetParent", this.scratchTexture);
			float num = 398f / this.grainSize;
			material.SetVector("Scenes List:", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Game Version: ", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_BlendTex", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 21f, 1694f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007EF6 RID: 32502 RVA: 0x002A4914 File Offset: 0x002A2B14
		protected Material HKGAONMOBMH()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags)64;
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)(-121);
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007EF7 RID: 32503 RVA: 0x002A49B4 File Offset: 0x002A2BB4
		private void KCHPIGEJELN()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 1757f, 1230f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 1716f, 21f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 1395f, 885f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 1994f, 1373f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 924f, 1879f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 664f, 1892f);
			this.grainSize = Mathf.Clamp(this.grainSize, 1581f, 220f);
		}

		// Token: 0x06007EF8 RID: 32504 RVA: 0x002A4A80 File Offset: 0x002A2C80
		protected Material KBOPGONOCNP()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags)123;
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)(-77);
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007EF9 RID: 32505 RVA: 0x002A4B20 File Offset: 0x002A2D20
		protected void DIPDEHOOBPG()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("_Value3");
				base.enabled = true;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void DPFOEBCADNP()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void IFIHBNJKEKD()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x002A4BAC File Offset: 0x002A2DAC
		protected void FNCDAPDOBBI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("CameraFilterPack/Drawing_Lines");
				base.enabled = true;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007EFD RID: 32509 RVA: 0x002A4C38 File Offset: 0x002A2E38
		protected void NBGIMIDICKE()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007EFE RID: 32510 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void HGDDCINLDAD()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007EFF RID: 32511 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void OnDisable()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007F00 RID: 32512 RVA: 0x002A4CC4 File Offset: 0x002A2EC4
		protected void OHFOLGANOLC()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x002A4D50 File Offset: 0x002A2F50
		protected void COIJKMKIEAK()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log(":");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = false;
			}
		}

		// Token: 0x06007F02 RID: 32514 RVA: 0x002A4DDC File Offset: 0x002A2FDC
		protected void DKOPKPBLDHH()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("\\");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007F03 RID: 32515 RVA: 0x002A4E68 File Offset: 0x002A3068
		private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.APEIBMLNMEE();
			if (this.POPBKOPEELE <= 1559f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 34f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.KBOPGONOCNP();
			material.SetTexture("_Value2", this.grainTexture);
			material.SetTexture("ShowTitle", this.scratchTexture);
			float num = 1668f / this.grainSize;
			material.SetVector("workshop.", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("_ColorBuffer", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("UsernameText", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1037f, 1351f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x002A4FE8 File Offset: 0x002A31E8
		protected Material EFDEIFCDAFG()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags)(-81);
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)105;
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007F05 RID: 32517 RVA: 0x002A5088 File Offset: 0x002A3288
		private void EMKCNMFNDDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.HANMFFCEOCK();
			if (this.POPBKOPEELE <= 151f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 805f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.HKGAONMOBMH();
			material.SetTexture("UI Extensions/UI Image Crop", this.grainTexture);
			material.SetTexture("_ScreenResolution", this.scratchTexture);
			float num = 1764f / this.grainSize;
			material.SetVector("ENABLE_USER_LUT", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("id", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("Updated!", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1393f, 1889f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x002A5208 File Offset: 0x002A3408
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.HIOJCEEFKMJ();
			if (this.POPBKOPEELE <= 1113f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 881f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.OCHJIMJNEMO();
			material.SetTexture("settings.arcsdestroydelay", this.grainTexture);
			material.SetTexture("L1", this.scratchTexture);
			float num = 852f / this.grainSize;
			material.SetVector("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("Map id for", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("menu.playedpage", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 99f, 1930f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007F07 RID: 32519 RVA: 0x002A5388 File Offset: 0x002A3588
		protected Material ADGHJOHKEHG()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)(-120);
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007F08 RID: 32520 RVA: 0x002A5428 File Offset: 0x002A3628
		private void LPFDJPCIADE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.GFBJOHMDKCG();
			if (this.POPBKOPEELE <= 1929f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 1347f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.OCHJIMJNEMO();
			material.SetTexture("_Red_B", this.grainTexture);
			material.SetTexture("checkpoint", this.scratchTexture);
			float num = 1481f / this.grainSize;
			material.SetVector("NewMusicFileSelector", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("0", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_ProjInfo", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 576f, 310f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007F09 RID: 32521 RVA: 0x002A2916 File Offset: 0x002A0B16
		protected void CNDACAHCCOI()
		{
			if (this.FACAJJODADL)
			{
				UnityEngine.Object.DestroyImmediate(this.FACAJJODADL);
			}
			if (this.NEKJGMJANAA)
			{
				UnityEngine.Object.DestroyImmediate(this.NEKJGMJANAA);
			}
		}

		// Token: 0x06007F0A RID: 32522 RVA: 0x002A55A8 File Offset: 0x002A37A8
		protected void ICILLMAKLMI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("CameraFilterPack/Film_ColorPerfection");
				base.enabled = true;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007F0B RID: 32523 RVA: 0x002A5634 File Offset: 0x002A3834
		protected Material FAIFBBGFAIB()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags)(-88);
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)(-110);
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007F0C RID: 32524 RVA: 0x002A56D4 File Offset: 0x002A38D4
		protected Material BFGNMFCNDBC()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags)124;
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = (HideFlags)118;
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007F0D RID: 32525 RVA: 0x002A5774 File Offset: 0x002A3974
		private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.APEIBMLNMEE();
			if (this.POPBKOPEELE <= 1021f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 481f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.LDNADDJMIPK();
			material.SetTexture("1,30,true,0", this.grainTexture);
			material.SetTexture("Chat", this.scratchTexture);
			float num = 1331f / this.grainSize;
			material.SetVector("[MapsSystem] Unloading maps resources...", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("ItemsStoreButton", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("Text", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 1763f, 340f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007F0E RID: 32526 RVA: 0x002A58F4 File Offset: 0x002A3AF4
		protected void MNBPNHNAEBK()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("High");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007F0F RID: 32527 RVA: 0x002A5980 File Offset: 0x002A3B80
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.GFBJOHMDKCG();
			if (this.POPBKOPEELE <= 1980f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 531f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.FEAEGGCNIAA();
			material.SetTexture("offsets", this.grainTexture);
			material.SetTexture(" Remote called.", this.scratchTexture);
			float num = 633f / this.grainSize;
			material.SetVector(" on effect ", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_TimeX", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 162f, 258f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007F10 RID: 32528 RVA: 0x002A5B00 File Offset: 0x002A3D00
		private void OAHHAAKEBDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.APEIBMLNMEE();
			if (this.POPBKOPEELE <= 837f)
			{
				this.POPBKOPEELE = UnityEngine.Random.value * 1670f / this.scratchFPS;
				this.FDPBBBFDNNB = UnityEngine.Random.value;
				this.DLLANHPBMBD = UnityEngine.Random.value;
			}
			this.POPBKOPEELE -= Time.deltaTime;
			Material material = this.BFGNMFCNDBC();
			material.SetTexture(" - Contains ", this.grainTexture);
			material.SetTexture("ReJoinRoom failed due to offline mode.", this.scratchTexture);
			float num = 680f / this.grainSize;
			material.SetVector("[PlayerBase] SetBGColor error: ", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("id", new Vector4(this.FDPBBBFDNNB + UnityEngine.Random.value * this.scratchJitter, this.DLLANHPBMBD + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("&page=", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 759f, 281f));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material);
		}

		// Token: 0x06007F11 RID: 32529 RVA: 0x002A5C80 File Offset: 0x002A3E80
		protected Material HFBJAOFLCJI()
		{
			if (this.FACAJJODADL == null)
			{
				this.FACAJJODADL = new Material(this.shaderRGB);
				this.FACAJJODADL.hideFlags = (HideFlags)(-83);
			}
			if (this.NEKJGMJANAA == null && !this.FHDKPALHAKN)
			{
				this.NEKJGMJANAA = new Material(this.shaderYUV);
				this.NEKJGMJANAA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			return (this.FHDKPALHAKN || this.monochrome) ? this.FACAJJODADL : this.NEKJGMJANAA;
		}

		// Token: 0x06007F12 RID: 32530 RVA: 0x002A5D20 File Offset: 0x002A3F20
		protected void FJNCHGLIEMA()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("). ");
				base.enabled = true;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = true;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = true;
			}
		}

		// Token: 0x06007F13 RID: 32531 RVA: 0x002A5DAC File Offset: 0x002A3FAC
		protected void FHPFJBFCOOF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("_Value2");
				base.enabled = false;
			}
			else if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!this.shaderYUV.isSupported)
			{
				this.FHDKPALHAKN = false;
			}
		}

		// Token: 0x04000E36 RID: 3638
		public bool monochrome = true;

		// Token: 0x04000E37 RID: 3639
		private bool FHDKPALHAKN;

		// Token: 0x04000E38 RID: 3640
		[Range(0f, 5f)]
		public float grainIntensityMin = 0.1f;

		// Token: 0x04000E39 RID: 3641
		[Range(0f, 5f)]
		public float grainIntensityMax = 0.2f;

		// Token: 0x04000E3A RID: 3642
		[Range(0.1f, 50f)]
		public float grainSize = 2f;

		// Token: 0x04000E3B RID: 3643
		[Range(0f, 5f)]
		public float scratchIntensityMin = 0.05f;

		// Token: 0x04000E3C RID: 3644
		[Range(0f, 5f)]
		public float scratchIntensityMax = 0.25f;

		// Token: 0x04000E3D RID: 3645
		[Range(1f, 30f)]
		public float scratchFPS = 10f;

		// Token: 0x04000E3E RID: 3646
		[Range(0f, 1f)]
		public float scratchJitter = 0.01f;

		// Token: 0x04000E3F RID: 3647
		public Texture grainTexture;

		// Token: 0x04000E40 RID: 3648
		public Texture scratchTexture;

		// Token: 0x04000E41 RID: 3649
		public Shader shaderRGB;

		// Token: 0x04000E42 RID: 3650
		public Shader shaderYUV;

		// Token: 0x04000E43 RID: 3651
		private Material FACAJJODADL;

		// Token: 0x04000E44 RID: 3652
		private Material NEKJGMJANAA;

		// Token: 0x04000E45 RID: 3653
		private float POPBKOPEELE;

		// Token: 0x04000E46 RID: 3654
		private float FDPBBBFDNNB;

		// Token: 0x04000E47 RID: 3655
		private float DLLANHPBMBD;
	}
}
