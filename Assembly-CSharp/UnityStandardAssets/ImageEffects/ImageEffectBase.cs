using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001E7 RID: 487
	[AddComponentMenu("")]
	[RequireComponent(typeof(Camera))]
	public class ImageEffectBase : MonoBehaviour
	{
		// Token: 0x06007D74 RID: 32116 RVA: 0x0029A2F1 File Offset: 0x002984F1
		protected Material GCDFNHMJMIP()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D75 RID: 32117 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void HLIAEEMGBHN()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007D76 RID: 32118 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void NPLCENPNJBM()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007D77 RID: 32119 RVA: 0x0029A39E File Offset: 0x0029859E
		protected virtual void FANADGBGCPI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007D78 RID: 32120 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void ALMGMOOHLMA()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D79 RID: 32121 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void DAHFFNNIGML()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007D7A RID: 32122 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void EJJEDJIOFAB()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D7B RID: 32123 RVA: 0x0029A3F6 File Offset: 0x002985F6
		protected virtual void EGEPLFGKGLI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007D7C RID: 32124 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void LECCHIAFGGE()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D7D RID: 32125 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void IMCKJCHKMKB()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007D7E RID: 32126 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void GBGAMCPNBCC()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D7F RID: 32127 RVA: 0x0029A39E File Offset: 0x0029859E
		protected virtual void MMPHNFPPEHO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007D80 RID: 32128 RVA: 0x0029A431 File Offset: 0x00298631
		protected Material ABHDNGIHBKE()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D81 RID: 32129 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void LGHCJCFHEMF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007D82 RID: 32130 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void DKPBBJINKMG()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D83 RID: 32131 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void MNBPNHNAEBK()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007D84 RID: 32132 RVA: 0x0029A3F6 File Offset: 0x002985F6
		protected virtual void KOJKBFDNGDK()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007D85 RID: 32133 RVA: 0x0029A468 File Offset: 0x00298668
		protected Material EJDPNJAEAKJ()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D86 RID: 32134 RVA: 0x0029A49F File Offset: 0x0029869F
		protected Material HHIFMIPPMPF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D87 RID: 32135 RVA: 0x0029A4D6 File Offset: 0x002986D6
		protected Material HEINDEMCGIK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-80);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D88 RID: 32136 RVA: 0x0029A50D File Offset: 0x0029870D
		protected Material IGKFMCPDNOI()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D89 RID: 32137 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void CNPINCHINJA()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D8B RID: 32139 RVA: 0x0029A3F6 File Offset: 0x002985F6
		protected virtual void DBLILJGKGHJ()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007D8C RID: 32140 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void EDCMIPNCPLB()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D8D RID: 32141 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void EKCKJLFFAID()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D8E RID: 32142 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void ABEIEGDHBNO()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D8F RID: 32143 RVA: 0x0029A544 File Offset: 0x00298744
		protected Material FGENHBKMPDA()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)80;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x0029A3F6 File Offset: 0x002985F6
		protected virtual void JHANGPCOCIG()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007D91 RID: 32145 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void KHIGHFJKPFG()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007D92 RID: 32146 RVA: 0x0029A57B File Offset: 0x0029877B
		protected Material BAGICADFBAB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D93 RID: 32147 RVA: 0x0029A3F6 File Offset: 0x002985F6
		protected virtual void ECBILENEOOL()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007D94 RID: 32148 RVA: 0x0029A5B2 File Offset: 0x002987B2
		protected Material MICHFGAOPKM()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D95 RID: 32149 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void HOMNAHDDNHJ()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D96 RID: 32150 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void IMGGCJICLHK()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D97 RID: 32151 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void COOHIILCOCO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007D98 RID: 32152 RVA: 0x0029A5E9 File Offset: 0x002987E9
		protected Material LPPEPKGFOEM()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-87);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D99 RID: 32153 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void DFENCIHAADO()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D9A RID: 32154 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void JMAIIENCEKE()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D9B RID: 32155 RVA: 0x0029A39E File Offset: 0x0029859E
		protected virtual void BEBNOKFLJPH()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007D9C RID: 32156 RVA: 0x0029A620 File Offset: 0x00298820
		protected Material PGPEMMBJOOG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007D9D RID: 32157 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void GNMGIHFKJIJ()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007D9E RID: 32158 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void ADPLHDFJFID()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007D9F RID: 32159 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void PGMMBADJIKH()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DA0 RID: 32160 RVA: 0x0029A657 File Offset: 0x00298857
		protected Material IGIAPKPKGPK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-66);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DA1 RID: 32161 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void ANCKKLFPGDI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DA2 RID: 32162 RVA: 0x0029A39E File Offset: 0x0029859E
		protected virtual void FIKFJDFELIP()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DA3 RID: 32163 RVA: 0x0029A68E File Offset: 0x0029888E
		protected Material IIJMIPBMMBF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)72;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DA4 RID: 32164 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void OEIBFOHPOPD()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DA5 RID: 32165 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void OnDisable()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x0029A39E File Offset: 0x0029859E
		protected virtual void MDNHCLKNCLE()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x0029A6C5 File Offset: 0x002988C5
		protected Material LDNADDJMIPK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)122;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DA8 RID: 32168 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void GLEJGFLCLPJ()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DA9 RID: 32169 RVA: 0x0029A39E File Offset: 0x0029859E
		protected virtual void DBEMDAJDDDA()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DAA RID: 32170 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void DKGBFNCOAEO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DAB RID: 32171 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void FMNPFCHBLJF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DAC RID: 32172 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void AIBNKIDADPI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DAD RID: 32173 RVA: 0x0029A3F6 File Offset: 0x002985F6
		protected virtual void FLKEJJEGCFA()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06007DAE RID: 32174 RVA: 0x0029A6FC File Offset: 0x002988FC
		protected Material NBPKMLMCHFN
		{
			get
			{
				if (this.JLHCDOPFJOI == null)
				{
					this.JLHCDOPFJOI = new Material(this.shader);
					this.JLHCDOPFJOI.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.JLHCDOPFJOI;
			}
		}

		// Token: 0x06007DAF RID: 32175 RVA: 0x0029A733 File Offset: 0x00298933
		protected Material LMLENGFLEBD()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DB0 RID: 32176 RVA: 0x0029A76A File Offset: 0x0029896A
		protected Material OKJOKHGJHGF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DB1 RID: 32177 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void BGDPIHMAACO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DB2 RID: 32178 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void DHNGNHGDPLM()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DB3 RID: 32179 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void FPHLDMMAOEF()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DB4 RID: 32180 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void EKPLGFAEOBE()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DB5 RID: 32181 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void HPFIHLMKIPF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DB6 RID: 32182 RVA: 0x0029A3F6 File Offset: 0x002985F6
		protected virtual void KLILJHJNICK()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DB7 RID: 32183 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void IHHNCCOGLPN()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DB8 RID: 32184 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void FGOPJMGNHGO()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DB9 RID: 32185 RVA: 0x0029A3F6 File Offset: 0x002985F6
		protected virtual void MMOKKAPFGAK()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DBA RID: 32186 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void GKNKIIEALCH()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DBB RID: 32187 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void FJIKDJAMOHA()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DBC RID: 32188 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void AMHEJBMLFNM()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DBD RID: 32189 RVA: 0x0029A7A1 File Offset: 0x002989A1
		protected Material IIBLJCKLGFG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x0029A39E File Offset: 0x0029859E
		protected virtual void CEAGPJBGBMH()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DBF RID: 32191 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void BFEILOMHNPC()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DC0 RID: 32192 RVA: 0x0029A7D8 File Offset: 0x002989D8
		protected Material EMDFHOKEGNG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-85);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x0029A3F6 File Offset: 0x002985F6
		protected virtual void MJEFMIPLFAB()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DC2 RID: 32194 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void LADCJEIALMH()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DC3 RID: 32195 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void JKFDDNMPOJH()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DC4 RID: 32196 RVA: 0x0029A80F File Offset: 0x00298A0F
		protected Material LEIAFCPJMDP()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DC5 RID: 32197 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void CHOPDIGHJNH()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DC6 RID: 32198 RVA: 0x0029A846 File Offset: 0x00298A46
		protected Material CIAFLBFJLEJ()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DC7 RID: 32199 RVA: 0x0029A87D File Offset: 0x00298A7D
		protected Material OOMFJGPAOKL()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-74);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DC8 RID: 32200 RVA: 0x0029A8B4 File Offset: 0x00298AB4
		protected Material OLHDPICFBOF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DC9 RID: 32201 RVA: 0x0029A8EB File Offset: 0x00298AEB
		protected Material NJDIODJNGGA()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DCA RID: 32202 RVA: 0x0029A39E File Offset: 0x0029859E
		protected virtual void NNFMIAFHMJM()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DCB RID: 32203 RVA: 0x0029A922 File Offset: 0x00298B22
		protected Material NFMGLIKNOOC()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void BMGPBIBPBLA()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void ODGMCJILIHF()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DCE RID: 32206 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void FDNONDCGGCG()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DCF RID: 32207 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void FDPOFMCFBMF()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DD0 RID: 32208 RVA: 0x0029A959 File Offset: 0x00298B59
		protected Material FLGPDBBKAIP()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)71;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DD1 RID: 32209 RVA: 0x0029A657 File Offset: 0x00298857
		protected Material GJHPODJOBHL()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-66);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DD2 RID: 32210 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void PNNPDMHLFHE()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DD3 RID: 32211 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void DOFDGBGEDFI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DD4 RID: 32212 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void NCNPAKFAFOE()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DD5 RID: 32213 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void AOKOLPEGHDD()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DD6 RID: 32214 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void KMIEAGOFLBN()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DD7 RID: 32215 RVA: 0x0029A468 File Offset: 0x00298668
		protected Material EPCGJFCCAFH()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x0029A990 File Offset: 0x00298B90
		protected Material JFDGLLEOPGB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-83);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DD9 RID: 32217 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void EKCDEFDELMP()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DDA RID: 32218 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void OFPPIKHNJOD()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x0029A3F6 File Offset: 0x002985F6
		protected virtual void EIMNPCMHJLJ()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x0029A9C7 File Offset: 0x00298BC7
		protected Material MCDGIILBNIF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-91);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DDD RID: 32221 RVA: 0x0029A9FE File Offset: 0x00298BFE
		protected Material DONENAMLFLF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DDE RID: 32222 RVA: 0x0029AA35 File Offset: 0x00298C35
		protected Material NLFJGMBCICG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-77);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x0029AA6C File Offset: 0x00298C6C
		protected Material DNLMFEGJJDD()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~HideFlags.HideInHierarchy;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DE0 RID: 32224 RVA: 0x0029A9FE File Offset: 0x00298BFE
		protected Material AELJLBOJAIL()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void ALNNIDLFILB()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void MGFFNGEGFDC()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DE3 RID: 32227 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void ALJEADNKJPO()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void LLKKGGLNIDF()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x0029A80F File Offset: 0x00298A0F
		protected Material CBCNOEIALHB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DE6 RID: 32230 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void KCCIEMBMOBA()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DE7 RID: 32231 RVA: 0x0029AAA3 File Offset: 0x00298CA3
		protected Material GJHLADDCMFF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)67;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DE8 RID: 32232 RVA: 0x0029A39E File Offset: 0x0029859E
		protected virtual void JECMJNFGBGC()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void JNALDALAJLG()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DEA RID: 32234 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void MKFLBEGJJDC()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DEB RID: 32235 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DEC RID: 32236 RVA: 0x0029A39E File Offset: 0x0029859E
		protected virtual void JOHOFNKJDEB()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007DED RID: 32237 RVA: 0x0029AADA File Offset: 0x00298CDA
		protected Material CFCPHFMKHII()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DEE RID: 32238 RVA: 0x0029A9C7 File Offset: 0x00298BC7
		protected Material FOOCJIDNGBB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-91);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DEF RID: 32239 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void PAEGLMEOKHP()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DF0 RID: 32240 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void FEHCNJLLJMP()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DF1 RID: 32241 RVA: 0x0029AB11 File Offset: 0x00298D11
		protected Material OIBHFCLJKDB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DF2 RID: 32242 RVA: 0x0029A544 File Offset: 0x00298744
		protected Material HEHKGPKLAKK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)80;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DF3 RID: 32243 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void FAMLCFNDGNI()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DF4 RID: 32244 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void HLHJBJGEEEA()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DF5 RID: 32245 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void IABLKKAALGI()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DF6 RID: 32246 RVA: 0x0029A3D9 File Offset: 0x002985D9
		protected virtual void IEFMONDKKJN()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007DF7 RID: 32247 RVA: 0x0029AB48 File Offset: 0x00298D48
		protected Material HKGAONMOBMH()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DF8 RID: 32248 RVA: 0x0029A7D8 File Offset: 0x002989D8
		protected Material HKHBBBFLGJH()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-85);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DF9 RID: 32249 RVA: 0x0029A363 File Offset: 0x00298563
		protected virtual void ALJEJJCIMJN()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007DFA RID: 32250 RVA: 0x0029AB7F File Offset: 0x00298D7F
		protected Material CECICEGFHKL()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-117);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007DFB RID: 32251 RVA: 0x0029A328 File Offset: 0x00298528
		protected virtual void NBGIMIDICKE()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x04000E1F RID: 3615
		public Shader shader;

		// Token: 0x04000E20 RID: 3616
		private Material JLHCDOPFJOI;
	}
}
