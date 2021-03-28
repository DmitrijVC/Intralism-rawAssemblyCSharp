using System;
using UnityEngine;

namespace Assets.Pixelation.Example.Scripts
{
	// Token: 0x02000378 RID: 888
	[AddComponentMenu("")]
	[RequireComponent(typeof(Camera))]
	public class ImageEffectBase : MonoBehaviour
	{
		// Token: 0x0600C355 RID: 50005 RVA: 0x0046FABF File Offset: 0x0046DCBF
		protected virtual void FEHCNJLLJMP()
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

		// Token: 0x0600C356 RID: 50006 RVA: 0x0046FAFA File Offset: 0x0046DCFA
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

		// Token: 0x0600C357 RID: 50007 RVA: 0x0046FB35 File Offset: 0x0046DD35
		protected Material LONNIJMNKFB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C358 RID: 50008 RVA: 0x0046FB6C File Offset: 0x0046DD6C
		protected virtual void KCCIEMBMOBA()
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

		// Token: 0x0600C359 RID: 50009 RVA: 0x0046FBA7 File Offset: 0x0046DDA7
		protected Material NFMGLIKNOOC()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)126;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C35A RID: 50010 RVA: 0x0046FBDE File Offset: 0x0046DDDE
		protected Material IONHGBPGCHK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-74);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C35B RID: 50011 RVA: 0x0046FB6C File Offset: 0x0046DD6C
		protected virtual void EGEPLFGKGLI()
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

		// Token: 0x0600C35C RID: 50012 RVA: 0x0046FC15 File Offset: 0x0046DE15
		protected virtual void JHLGHODFJOO()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x0600C35D RID: 50013 RVA: 0x0046FC15 File Offset: 0x0046DE15
		protected virtual void FPHLDMMAOEF()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x0600C35E RID: 50014 RVA: 0x0046FC32 File Offset: 0x0046DE32
		protected virtual void NPLCENPNJBM()
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

		// Token: 0x0600C35F RID: 50015 RVA: 0x0046FC15 File Offset: 0x0046DE15
		protected virtual void OnDisable()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x0600C360 RID: 50016 RVA: 0x0046FB6C File Offset: 0x0046DD6C
		protected virtual void EPEGAEGDJAM()
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

		// Token: 0x0600C361 RID: 50017 RVA: 0x0046FC15 File Offset: 0x0046DE15
		protected virtual void OCCGJMPAJIK()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x0600C362 RID: 50018 RVA: 0x0046FAFA File Offset: 0x0046DCFA
		protected virtual void NCNPAKFAFOE()
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

		// Token: 0x0600C363 RID: 50019 RVA: 0x0046FC15 File Offset: 0x0046DE15
		protected virtual void LECCHIAFGGE()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x0600C364 RID: 50020 RVA: 0x0046FABF File Offset: 0x0046DCBF
		protected virtual void EFJDNLGNACH()
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

		// Token: 0x0600C365 RID: 50021 RVA: 0x0046FC15 File Offset: 0x0046DE15
		protected virtual void NJHJHBOJKIC()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x0600C366 RID: 50022 RVA: 0x0046FC6D File Offset: 0x0046DE6D
		protected Material DNLMFEGJJDD()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-76);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C367 RID: 50023 RVA: 0x0046FCA4 File Offset: 0x0046DEA4
		protected Material IGKFMCPDNOI()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-101);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C368 RID: 50024 RVA: 0x0046FCDB File Offset: 0x0046DEDB
		protected Material HFBJAOFLCJI()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-89);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C369 RID: 50025 RVA: 0x0046FC15 File Offset: 0x0046DE15
		protected virtual void FKEJGBFDCAH()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x0600C36A RID: 50026 RVA: 0x0046FABF File Offset: 0x0046DCBF
		protected virtual void CIPKEPDELJB()
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

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600C36B RID: 50027 RVA: 0x0046FD12 File Offset: 0x0046DF12
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

		// Token: 0x0600C36C RID: 50028 RVA: 0x0046FD49 File Offset: 0x0046DF49
		protected Material MMOODGIODPC()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C36D RID: 50029 RVA: 0x0046FD80 File Offset: 0x0046DF80
		protected Material HKGAONMOBMH()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-70);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C36E RID: 50030 RVA: 0x0046FC15 File Offset: 0x0046DE15
		protected virtual void EAHCLIEEJOG()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x0600C370 RID: 50032 RVA: 0x0046FDB7 File Offset: 0x0046DFB7
		protected Material GCDFNHMJMIP()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)109;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C371 RID: 50033 RVA: 0x0046FB6C File Offset: 0x0046DD6C
		protected virtual void NNCCPEBIAKH()
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

		// Token: 0x0600C372 RID: 50034 RVA: 0x0046FDEE File Offset: 0x0046DFEE
		protected Material HCGJCMDJPGD()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C373 RID: 50035 RVA: 0x0046FE25 File Offset: 0x0046E025
		protected Material IIBLJCKLGFG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C374 RID: 50036 RVA: 0x0046FE5C File Offset: 0x0046E05C
		protected Material EFDEIFCDAFG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)110;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C375 RID: 50037 RVA: 0x0046FE93 File Offset: 0x0046E093
		protected Material AELJLBOJAIL()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)89;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C376 RID: 50038 RVA: 0x0046FABF File Offset: 0x0046DCBF
		protected virtual void DIPDEHOOBPG()
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

		// Token: 0x0600C377 RID: 50039 RVA: 0x0046FECA File Offset: 0x0046E0CA
		protected Material GKILCDHJFEG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)94;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C378 RID: 50040 RVA: 0x0046FC15 File Offset: 0x0046DE15
		protected virtual void BFEILOMHNPC()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
		}

		// Token: 0x0600C379 RID: 50041 RVA: 0x0046FF01 File Offset: 0x0046E101
		protected Material DEFBJOCJJKF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C37A RID: 50042 RVA: 0x0046FB6C File Offset: 0x0046DD6C
		protected virtual void JILOMOBDPIA()
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

		// Token: 0x0600C37B RID: 50043 RVA: 0x0046FC32 File Offset: 0x0046DE32
		protected virtual void FHGKIOOMMOH()
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

		// Token: 0x0600C37C RID: 50044 RVA: 0x0046FB6C File Offset: 0x0046DD6C
		protected virtual void DKOPKPBLDHH()
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

		// Token: 0x0600C37D RID: 50045 RVA: 0x0046FF38 File Offset: 0x0046E138
		protected Material PLBEJJIHFPB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C37E RID: 50046 RVA: 0x0046FC32 File Offset: 0x0046DE32
		protected virtual void HLIAEEMGBHN()
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

		// Token: 0x0600C37F RID: 50047 RVA: 0x0046FF6F File Offset: 0x0046E16F
		protected Material DBOLLHHMKKN()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)88;
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C380 RID: 50048 RVA: 0x0046FB6C File Offset: 0x0046DD6C
		protected virtual void AGEJKLMJGDO()
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

		// Token: 0x0600C381 RID: 50049 RVA: 0x0046FABF File Offset: 0x0046DCBF
		protected virtual void IHLMNAGPKDA()
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

		// Token: 0x0600C382 RID: 50050 RVA: 0x0046FFA6 File Offset: 0x0046E1A6
		protected Material NBMPPNFKFLB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-92);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600C383 RID: 50051 RVA: 0x0046FFDD File Offset: 0x0046E1DD
		protected Material HHIFMIPPMPF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = new Material(this.shader);
				this.JLHCDOPFJOI.hideFlags = (HideFlags)(-112);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0400171D RID: 5917
		public Shader shader;

		// Token: 0x0400171E RID: 5918
		private Material JLHCDOPFJOI;
	}
}
