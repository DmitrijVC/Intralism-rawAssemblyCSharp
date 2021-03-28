using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001BF RID: 447
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Antialiasing : PostEffectsBase
	{
		// Token: 0x060078E4 RID: 30948 RVA: 0x00253B18 File Offset: 0x00251D18
		public virtual bool ILFLIDAJMDD()
		{
			base.NPOEJIDLJGK(false);
			this.LGHECEBJLIG = base.KDCLGAPCAOA(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.EBBLDMMIAJP(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.HONCELNGAHC(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.NAJEHEHHDOJ(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.MOKEIJGLJOF(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.MJEINBKBPII(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.PAFINHBHDIK(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.KFAEEPBKBOJ();
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x00253BF8 File Offset: 0x00251DF8
		public Material MJJLJPOPOPE()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00253C94 File Offset: 0x00251E94
		public Material NDPFLNELDHN()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x00253D30 File Offset: 0x00251F30
		public void KOIKNJLPOPA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("GroupNameText", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("Netw. Sim.", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == (AAMode)7 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.SSAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 3;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.SSAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 8);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.NFAA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("AVG Misses:", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("Tab1Content", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x00253F74 File Offset: 0x00252174
		public void MNMONMPIPPO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat(".b", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("CameraFilterPack/Drawing_Toon", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("wss://", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == (AAMode)8 && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 3;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA3Console && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("true", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("#failed!", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x002541B8 File Offset: 0x002523B8
		public virtual bool MKKNILHMBIC()
		{
			base.FNIFJAENDIB(true);
			this.LGHECEBJLIG = base.KDCLGAPCAOA(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.MJEINBKBPII(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.FBMINAINPAF(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.KBOKLFOHPAP(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.KBOKLFOHPAP(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.NAJEHEHHDOJ(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.KDCLGAPCAOA(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.ILPCOBPBAFM();
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x00254298 File Offset: 0x00252498
		public virtual bool HDDNBPJGGFK()
		{
			base.IBFDMKMOBCA(true);
			this.LGHECEBJLIG = base.HONCELNGAHC(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.EBBLDMMIAJP(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.DAGBGAFBBMH(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.EBBLDMMIAJP(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.NAJEHEHHDOJ(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.DEDLAJNJMIG(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.NCOMILNCHJO(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.NLMMMBMGLJL();
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x00254378 File Offset: 0x00252578
		public Material AJNFJNEFBBJ()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x00254414 File Offset: 0x00252614
		public Material HIPCAFIPPFB()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x002544B0 File Offset: 0x002526B0
		public void CDCLDBFMKOG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("#restart", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("addNewButton", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("GameVolumeSlider", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA3Console && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.NFAA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("_SecondTex", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_BorderSize", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x002546F4 File Offset: 0x002528F4
		public virtual bool EICPCBFEDNI()
		{
			base.IBFDMKMOBCA(true);
			this.LGHECEBJLIG = base.NAJEHEHHDOJ(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.FBMINAINPAF(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.DAGBGAFBBMH(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.DAGBGAFBBMH(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.FBMINAINPAF(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.MJEINBKBPII(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.HONCELNGAHC(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.HCBFPHFFGFJ();
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x002547D4 File Offset: 0x002529D4
		public override bool ILMGHBFANON()
		{
			base.CKIAMHAKJOK(false);
			this.LGHECEBJLIG = base.DAGBGAFBBMH(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.DEDLAJNJMIG(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.DEDLAJNJMIG(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.KBOKLFOHPAP(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.PAFINHBHDIK(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.MOKEIJGLJOF(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.PAFINHBHDIK(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.OEHBMMAFJGG();
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x002548B4 File Offset: 0x00252AB4
		public Material NFEPGCLCHNO()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x00254950 File Offset: 0x00252B50
		public virtual bool EIBHLNIFKHD()
		{
			base.KNGDKKMDKOG(true);
			this.LGHECEBJLIG = base.MJEINBKBPII(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.EBBLDMMIAJP(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.KDCLGAPCAOA(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.PAFINHBHDIK(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.HONCELNGAHC(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.KBOKLFOHPAP(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.MJEINBKBPII(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.JKOMCICEKHD();
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x00254A30 File Offset: 0x00252C30
		public void KFGGHDFLDIP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("_TimeX", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("DPADHOR", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("shader.future", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == (AAMode)7 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.DLAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 6;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.DLAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == (AAMode)7 && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 7);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("CameraFilterPack/TV_CompressionFX", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x00254CC8 File Offset: 0x00252EC8
		public Material EKIADOCFCHE()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060078F5 RID: 30965 RVA: 0x00254D64 File Offset: 0x00252F64
		public virtual bool HKEMNPKHLEO()
		{
			base.DCHKKHDGBLJ(false);
			this.LGHECEBJLIG = base.PAFINHBHDIK(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.NAJEHEHHDOJ(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.PAFINHBHDIK(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.EBBLDMMIAJP(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.HONCELNGAHC(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.DAGBGAFBBMH(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.PAFINHBHDIK(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.DJLJMNPHEJI();
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x00254E44 File Offset: 0x00253044
		public void OLFAPNGMBPL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("[DiscordController] Join ({0})", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("finished", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("_Val2", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA2 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 5;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.NFAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.DLAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.NFAA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("/icon", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat(",", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060078F7 RID: 30967 RVA: 0x00255088 File Offset: 0x00253288
		public void DGMODDJIAKL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("Operation failed: ", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_BaseTex", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("{0}", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.DLAA && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 2;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA2 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 7);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == (AAMode)7 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("CameraFilterPack/TV_Rgb", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("PUNCloudBestRegion", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x002552CC File Offset: 0x002534CC
		public void OHDKDLLBNFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("PunPickup", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("SUBMIT '{0}' FILES", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("failed", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA2 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == (AAMode)8 && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 7;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == (AAMode)8 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == (AAMode)7 && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.DLAA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("icon.png", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("[PlayerController] ", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x00255510 File Offset: 0x00253710
		public virtual bool BMCAJHFDDAF()
		{
			base.IBFDMKMOBCA(true);
			this.LGHECEBJLIG = base.DAGBGAFBBMH(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.EBBLDMMIAJP(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.EBBLDMMIAJP(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.NCOMILNCHJO(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.MJEINBKBPII(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.NAJEHEHHDOJ(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.KDCLGAPCAOA(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.HCBFPHFFGFJ();
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x002555F0 File Offset: 0x002537F0
		public Material LLJGPLLFGPG()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x0025568C File Offset: 0x0025388C
		public Material DGAJFNDAGMM()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x00255728 File Offset: 0x00253928
		public Material ECDNKOOILDF()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060078FD RID: 30973 RVA: 0x002557C4 File Offset: 0x002539C4
		public Material GBBHLOKBGIM()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x00255860 File Offset: 0x00253A60
		public void HLAIEDEHIBC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("_ScreenResolution", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_DistortionLevel", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("isVisible", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == (AAMode)8 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 4);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA2 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("scene ", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("LevelNameInputField", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x00255AA4 File Offset: 0x00253CA4
		public void LPFDJPCIADE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("ready", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_PrevViewProj", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("{0} minutes ago", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == (AAMode)7 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.SSAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 2;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == (AAMode)8 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.SSAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 6);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == (AAMode)8 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("Beat Detected", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_Visualize", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x00255CE8 File Offset: 0x00253EE8
		public virtual bool ELHBKCFNCOJ()
		{
			base.MBMLNJJEONO(true);
			this.LGHECEBJLIG = base.PAFINHBHDIK(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.FBMINAINPAF(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.HONCELNGAHC(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.KDCLGAPCAOA(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.DANHMNKJEFI(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.DANHMNKJEFI(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.MJEINBKBPII(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.JKOMCICEKHD();
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x00255DC8 File Offset: 0x00253FC8
		public void JKAKHLNPNNP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("Simulate", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("RecordButton", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("Send", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == (AAMode)8 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 2;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 8);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA3Console && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat(" should be overwritten.", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_ScreenResolution", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x0025600C File Offset: 0x0025420C
		public Material MPHBOMEPOGE()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x002560A8 File Offset: 0x002542A8
		public virtual bool GHHAAPCBJJD()
		{
			base.CKIAMHAKJOK(true);
			this.LGHECEBJLIG = base.KDCLGAPCAOA(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.DAGBGAFBBMH(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.HONCELNGAHC(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.EBBLDMMIAJP(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.MJEINBKBPII(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.DANHMNKJEFI(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.NAJEHEHHDOJ(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.MIFAKEPHPBO();
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x00256188 File Offset: 0x00254388
		public void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("GameScene", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("mapselector.filter.rateduponly", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA3Console && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.SSAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 2;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.SSAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.DLAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 5);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.NFAA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("Items/", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("InventoryGrid", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007905 RID: 30981 RVA: 0x002563CC File Offset: 0x002545CC
		public Material IJOKDJNGMJM()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007906 RID: 30982 RVA: 0x00256468 File Offset: 0x00254668
		public Material CLFHOAOMFJI()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x00256504 File Offset: 0x00254704
		public Material AJAEANHAAFA()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x002565A0 File Offset: 0x002547A0
		public virtual bool MPOHEEECMIF()
		{
			base.KNGDKKMDKOG(false);
			this.LGHECEBJLIG = base.PAFINHBHDIK(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.PAFINHBHDIK(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.DAGBGAFBBMH(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.DANHMNKJEFI(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.NCOMILNCHJO(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.NCOMILNCHJO(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.HONCELNGAHC(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.MIFAKEPHPBO();
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x00256680 File Offset: 0x00254880
		public Material PNPJHNLFIDE()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x0025671C File Offset: 0x0025491C
		public virtual bool KJAAENHDHHC()
		{
			base.DCHKKHDGBLJ(false);
			this.LGHECEBJLIG = base.MJEINBKBPII(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.KDCLGAPCAOA(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.KDCLGAPCAOA(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.KBOKLFOHPAP(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.KDCLGAPCAOA(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.DANHMNKJEFI(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.NAJEHEHHDOJ(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.JKOMCICEKHD();
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x002567FC File Offset: 0x002549FC
		public virtual bool OCADOBLPPAA()
		{
			base.LMEBEGFJGEM(true);
			this.LGHECEBJLIG = base.NCOMILNCHJO(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.MJEINBKBPII(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.MJEINBKBPII(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.PAFINHBHDIK(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.KDCLGAPCAOA(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.HONCELNGAHC(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.KDCLGAPCAOA(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.IOIPJPBGIPB();
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x002568DC File Offset: 0x00254ADC
		public void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("workshop.", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_Value4", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("InfoButton", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA2 && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 3;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.SSAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.DLAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("Chat", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("0,1,false", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600790D RID: 30989 RVA: 0x00256B20 File Offset: 0x00254D20
		public virtual bool CIDNHACINGF()
		{
			base.DCHKKHDGBLJ(true);
			this.LGHECEBJLIG = base.EBBLDMMIAJP(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.MJEINBKBPII(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.EBBLDMMIAJP(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.HONCELNGAHC(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.DAGBGAFBBMH(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.DAGBGAFBBMH(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.DAGBGAFBBMH(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.IOIPJPBGIPB();
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600790E RID: 30990 RVA: 0x00256C00 File Offset: 0x00254E00
		public Material GBMMFHGPEGO()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x00256C9C File Offset: 0x00254E9C
		public void BIMCKDIHBPO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat(" cannot be used as a 3D LUT.", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("[Right-Left]", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("BadgeText", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.DLAA && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 7;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == (AAMode)8 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == (AAMode)8 && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.SSAA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("L1", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("settings.shaders.bloomintencity", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x00256EE0 File Offset: 0x002550E0
		public virtual bool BKNCNFMHIGH()
		{
			base.DHHGCBANGJL(false);
			this.LGHECEBJLIG = base.PAFINHBHDIK(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.DAGBGAFBBMH(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.KBOKLFOHPAP(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.DAGBGAFBBMH(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.MOKEIJGLJOF(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.PAFINHBHDIK(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.FBMINAINPAF(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.ILPCOBPBAFM();
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x00256FC0 File Offset: 0x002551C0
		public Material HOHFCNPLKIJ()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x0025705C File Offset: 0x0025525C
		public virtual bool CGNGNMFABEP()
		{
			base.DCHKKHDGBLJ(true);
			this.LGHECEBJLIG = base.HONCELNGAHC(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.FBMINAINPAF(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.NCOMILNCHJO(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.DEDLAJNJMIG(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.NCOMILNCHJO(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.DANHMNKJEFI(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.DEDLAJNJMIG(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.OEHBMMAFJGG();
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x0025713C File Offset: 0x0025533C
		public void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("CameraFilterPack/FX_Glitch2", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("Saved Game: ", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("_ReflectionBufferSize", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA3Console && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 2;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == (AAMode)8 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.NFAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 7);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat(".lastCheckpoint.playerdistance", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("CameraFilterPack_OldFilm1", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x00257380 File Offset: 0x00255580
		public void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("Object ID. Case-Sensitive", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("#savemapbeforeuploading", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("z", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == (AAMode)7 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA2 && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA3Console && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 5);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA2 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("_TimeX", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_ThirdTex", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x002575C4 File Offset: 0x002557C4
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.LGHECEBJLIG = base.MOKEIJGLJOF(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.MOKEIJGLJOF(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.MOKEIJGLJOF(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.MOKEIJGLJOF(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.MOKEIJGLJOF(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.MOKEIJGLJOF(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.MOKEIJGLJOF(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.HCBFPHFFGFJ();
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x002576A4 File Offset: 0x002558A4
		public void ABOJKHKBJLN(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("_Threshhold", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("_Distance", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.SSAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 7;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == (AAMode)8 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == (AAMode)7 && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA2 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("</b>", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_Value2", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x002578E8 File Offset: 0x00255AE8
		public virtual bool HFLMDNIGNBD()
		{
			base.IHMNPAHGNFF(false);
			this.LGHECEBJLIG = base.FBMINAINPAF(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.NAJEHEHHDOJ(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.DEDLAJNJMIG(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.PAFINHBHDIK(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.EBBLDMMIAJP(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.MOKEIJGLJOF(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.MOKEIJGLJOF(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.KFAEEPBKBOJ();
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x002579C8 File Offset: 0x00255BC8
		public Material NICBKJDMGLH()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x00257A64 File Offset: 0x00255C64
		public Material IAMMKOGAEPB()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x00257B00 File Offset: 0x00255D00
		public void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("LoadMapCanvas", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("effector", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("_ScreenResolution", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA2 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 5;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA3Console && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == (AAMode)7 && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA2 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("---", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("ControllerLeftX", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x00257D44 File Offset: 0x00255F44
		public void JCCIHFMBFJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("w", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_ScreenResolution", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("[Left]", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA2 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.NFAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 8;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == (AAMode)8 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.SSAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 4);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == (AAMode)8 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("Malformed RPC; this should never occur. Content: ", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_ColorKey", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x00257F88 File Offset: 0x00256188
		public virtual bool PHEIDFBDELF()
		{
			base.FNIFJAENDIB(true);
			this.LGHECEBJLIG = base.NCOMILNCHJO(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.PAFINHBHDIK(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.KDCLGAPCAOA(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.DAGBGAFBBMH(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.DAGBGAFBBMH(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.PAFINHBHDIK(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.DAGBGAFBBMH(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.HCBFPHFFGFJ();
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x00258068 File Offset: 0x00256268
		public void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("Failed to Instantiate prefab: ", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_Near", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("Editor/", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA3Console && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA3Console && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 6;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA2 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.DLAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 8);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == (AAMode)7 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("_CenterX", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("settings.enableranking", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x002582AC File Offset: 0x002564AC
		public virtual bool FEIGCNHEINM()
		{
			base.NPOEJIDLJGK(false);
			this.LGHECEBJLIG = base.KDCLGAPCAOA(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.MOKEIJGLJOF(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.KBOKLFOHPAP(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.PAFINHBHDIK(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.DANHMNKJEFI(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.KDCLGAPCAOA(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.EBBLDMMIAJP(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.IOIPJPBGIPB();
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x0025838C File Offset: 0x0025658C
		public Material HAOLPOKOFFE()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x00258428 File Offset: 0x00256628
		public void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("_EdgeThresholdMin", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_EdgeThreshold", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("_EdgeSharpness", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 4;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.SSAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.DLAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.NFAA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("_OffsetScale", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_BlurRadius", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x0025866C File Offset: 0x0025686C
		public override bool OEECIHEGJHE()
		{
			base.CKIAMHAKJOK(false);
			this.LGHECEBJLIG = base.KDCLGAPCAOA(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.HONCELNGAHC(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.NCOMILNCHJO(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.DAGBGAFBBMH(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.MJEINBKBPII(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.MJEINBKBPII(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.DANHMNKJEFI(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.MIFAKEPHPBO();
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007922 RID: 31010 RVA: 0x0025874C File Offset: 0x0025694C
		public Material PHMPKCLLJBO()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007923 RID: 31011 RVA: 0x002587E8 File Offset: 0x002569E8
		public virtual bool DKHGIAOFFKM()
		{
			base.MBMLNJJEONO(true);
			this.LGHECEBJLIG = base.NAJEHEHHDOJ(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.DANHMNKJEFI(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.PAFINHBHDIK(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.KBOKLFOHPAP(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.DAGBGAFBBMH(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.FBMINAINPAF(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.KDCLGAPCAOA(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.IOIPJPBGIPB();
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x002588C8 File Offset: 0x00256AC8
		public virtual bool PHJJGBHNECJ()
		{
			base.DHHGCBANGJL(true);
			this.LGHECEBJLIG = base.NCOMILNCHJO(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.MJEINBKBPII(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.MOKEIJGLJOF(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.KBOKLFOHPAP(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.KBOKLFOHPAP(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.EBBLDMMIAJP(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.DAGBGAFBBMH(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.IOIPJPBGIPB();
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007925 RID: 31013 RVA: 0x002589A8 File Offset: 0x00256BA8
		public Material PMLPGAOMFPD()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007926 RID: 31014 RVA: 0x00258A44 File Offset: 0x00256C44
		public void PLEOOAJIMEE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("player.currentrank", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_Color_B", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("Bad parameters for set! Use <language>", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == (AAMode)7 && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 6;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == (AAMode)7 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == (AAMode)7 && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 5);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA2 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("_EmissionColor", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_ScreenResolution", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007927 RID: 31015 RVA: 0x00258C88 File Offset: 0x00256E88
		public void BODGDCPNBLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("R2", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("YES", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("_Value4", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.SSAA && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.SSAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 8;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA2 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.DLAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 4);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == (AAMode)7 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("_Blue_B", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("intensity", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x00258ECC File Offset: 0x002570CC
		public virtual bool AFMAMEFKALN()
		{
			base.JOMCJOEOLHP(true);
			this.LGHECEBJLIG = base.DEDLAJNJMIG(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.KBOKLFOHPAP(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.KBOKLFOHPAP(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.KDCLGAPCAOA(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.KBOKLFOHPAP(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.HONCELNGAHC(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.KDCLGAPCAOA(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.IOIPJPBGIPB();
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007929 RID: 31017 RVA: 0x00258FAC File Offset: 0x002571AC
		public void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("Tab2Content", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.DLAA && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.NFAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == (AAMode)8 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA2 && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 6);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == (AAMode)8 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("/", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("icon", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x002591F0 File Offset: 0x002573F0
		public void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("_Blue_G", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("Ignored PU RPC, cause item is inactive. ", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("AddEnvironmentSprite", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.SSAA && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA3Console && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 4;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.SSAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 3);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == (AAMode)8 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat(" ; ", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_Value3", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x00259434 File Offset: 0x00257634
		public Material DAOPGCIGLAB()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x002594D0 File Offset: 0x002576D0
		public Material EKHIMKLOMOJ()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x0025956C File Offset: 0x0025776C
		public virtual bool EJIGOLAIMHP()
		{
			base.FNIFJAENDIB(false);
			this.LGHECEBJLIG = base.FBMINAINPAF(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.KDCLGAPCAOA(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.HONCELNGAHC(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.DANHMNKJEFI(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.NCOMILNCHJO(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.HONCELNGAHC(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.KDCLGAPCAOA(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.JKOMCICEKHD();
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x0025964C File Offset: 0x0025784C
		public Material CurrentAAMaterial()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x002596E8 File Offset: 0x002578E8
		public Material DEHBJCHGGBD()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x00259784 File Offset: 0x00257984
		public virtual bool BDBLODKHNGF()
		{
			base.FNIFJAENDIB(true);
			this.LGHECEBJLIG = base.DEDLAJNJMIG(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.KBOKLFOHPAP(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.NCOMILNCHJO(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.EBBLDMMIAJP(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.FBMINAINPAF(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.DANHMNKJEFI(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.MOKEIJGLJOF(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.HCBFPHFFGFJ();
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x00259864 File Offset: 0x00257A64
		public Material EEIJJBNDAEJ()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x00259900 File Offset: 0x00257B00
		public Material IPOPGLDALMO()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x0025999C File Offset: 0x00257B9C
		public void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("Finished", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("0,1,false", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("[LevelEditorScene] Error: Timeout :S", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.NFAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 5;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA3Console && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.SSAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 4);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA3Console && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("_Value4", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_Value", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x00259BE0 File Offset: 0x00257DE0
		public void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("z", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_Value", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("player.dragon", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.DLAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 8;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.NFAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA2 && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 7);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == (AAMode)8 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("[ReplayScene] Loading replay: ", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_BaseTex", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x00259E24 File Offset: 0x00258024
		public Material DBENEAKEAOC()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x00259EC0 File Offset: 0x002580C0
		public void HCOGCFOBBMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("settings.shaders", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("a year ago", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("_MainTex2", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == (AAMode)7 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.SSAA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 0;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == (AAMode)7 && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.DLAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.NFAA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("Edited unlock conditions", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("NetworkCanvas", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x0025A104 File Offset: 0x00258304
		public Material KDJAGPFEMCG()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x0025A1A0 File Offset: 0x002583A0
		public void NBHMOIGDDAD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("_ScreenResolution", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_PositionX", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("skin.", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA2 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 8;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.DLAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 7);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.DLAA && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("_Value2", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("editor.", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x0025A3E4 File Offset: 0x002585E4
		public virtual bool DIAEBALGKAP()
		{
			base.IHMNPAHGNFF(false);
			this.LGHECEBJLIG = base.EBBLDMMIAJP(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.NCOMILNCHJO(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.PAFINHBHDIK(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.HONCELNGAHC(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.NAJEHEHHDOJ(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.NAJEHEHHDOJ(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.DANHMNKJEFI(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.IOIPJPBGIPB();
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x0025A4C4 File Offset: 0x002586C4
		public void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA3Console && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("_TimeX", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("restrictions\n\n#until: ", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("_BlurVector", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == AAMode.FXAA3Console && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 3;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.NFAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.NFAA && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 6);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == (AAMode)8 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat("]", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_CameraClipInfo", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x0025A708 File Offset: 0x00258908
		public virtual bool IGHCJDIBGKP()
		{
			base.CKIAMHAKJOK(true);
			this.LGHECEBJLIG = base.NAJEHEHHDOJ(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.DAGBGAFBBMH(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.MOKEIJGLJOF(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.MOKEIJGLJOF(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.MOKEIJGLJOF(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.DAGBGAFBBMH(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.MJEINBKBPII(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.KFAEEPBKBOJ();
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x0025A7E8 File Offset: 0x002589E8
		public Material LCFDLFHDHCD()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x0025A884 File Offset: 0x00258A84
		public void IHAAHFFMJLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("mapid", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("settings.volume.menu", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("_Blue_R", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == (AAMode)8 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 8;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.SSAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA2 && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA3Console && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("_Value3", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("_MainTex2", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x0025AAC8 File Offset: 0x00258CC8
		public void NHNMJJBFLJP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("BadgeText", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("_ColorG", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("Edited unlock conditions", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == (AAMode)7 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA3Console && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 5;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.FXAA3Console && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 0);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 1 : 7);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == (AAMode)8 && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 1;
				this.HEKPJMOEIFB.SetFloat("Item ", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("Ignored PU RPC, cause item is inactive. ", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 0 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600793F RID: 31039 RVA: 0x0025AD0C File Offset: 0x00258F0C
		public void NEIOOEKEOPC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.mode == AAMode.FXAA2 && this.ACGMEBDKMGO != null)
			{
				this.ACGMEBDKMGO.SetFloat("_Parameter", this.edgeThresholdMin);
				this.ACGMEBDKMGO.SetFloat("float,0", this.edgeThreshold);
				this.ACGMEBDKMGO.SetFloat("%", this.edgeSharpness);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ACGMEBDKMGO);
			}
			else if (this.mode == (AAMode)8 && this.FDECHNLLEGF != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FDECHNLLEGF);
			}
			else if (this.mode == AAMode.FXAA1PresetA && this.LGHECEBJLIG != null)
			{
				HLBKCLPNHEB.anisoLevel = 8;
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LGHECEBJLIG);
				HLBKCLPNHEB.anisoLevel = 1;
			}
			else if (this.mode == AAMode.FXAA2 && this.DAGEPCOJKJA != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DAGEPCOJKJA);
			}
			else if (this.mode == AAMode.NFAA && this.FCJOCKNGEDE != null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.FCJOCKNGEDE);
			}
			else if (this.mode == AAMode.FXAA1PresetB && this.KFCHKLIENGH != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.KFCHKLIENGH, 1);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.KFCHKLIENGH, (!this.dlaaSharp) ? 0 : 8);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this.mode == AAMode.FXAA3Console && this.HEKPJMOEIFB != null)
			{
				HLBKCLPNHEB.anisoLevel = 0;
				this.HEKPJMOEIFB.SetFloat(": ", this.offsetScale);
				this.HEKPJMOEIFB.SetFloat("#scoresubmitionfailed: ", this.blurRadius);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HEKPJMOEIFB, (!this.showGeneratedNormals) ? 1 : 1);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x0025AF50 File Offset: 0x00259150
		public Material BICFANOFJMK()
		{
			Material result;
			switch (this.mode)
			{
			case AAMode.FXAA2:
				result = this.DAGEPCOJKJA;
				break;
			case AAMode.FXAA3Console:
				result = this.ACGMEBDKMGO;
				break;
			case AAMode.FXAA1PresetA:
				result = this.LGHECEBJLIG;
				break;
			case AAMode.FXAA1PresetB:
				result = this.FDECHNLLEGF;
				break;
			case AAMode.NFAA:
				result = this.HEKPJMOEIFB;
				break;
			case AAMode.SSAA:
				result = this.FCJOCKNGEDE;
				break;
			case AAMode.DLAA:
				result = this.KFCHKLIENGH;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06007941 RID: 31041 RVA: 0x0025AFEC File Offset: 0x002591EC
		public virtual bool LPDMNDMCPCO()
		{
			base.IBFDMKMOBCA(true);
			this.LGHECEBJLIG = base.NAJEHEHHDOJ(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.MOKEIJGLJOF(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.KDCLGAPCAOA(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.KDCLGAPCAOA(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.KDCLGAPCAOA(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.MOKEIJGLJOF(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.DEDLAJNJMIG(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.OEHBMMAFJGG();
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x0025B0CC File Offset: 0x002592CC
		public virtual bool CGMIAKDJFDD()
		{
			base.KNGDKKMDKOG(true);
			this.LGHECEBJLIG = base.MJEINBKBPII(this.shaderFXAAPreset2, this.LGHECEBJLIG);
			this.FDECHNLLEGF = base.NAJEHEHHDOJ(this.shaderFXAAPreset3, this.FDECHNLLEGF);
			this.DAGEPCOJKJA = base.HONCELNGAHC(this.shaderFXAAII, this.DAGEPCOJKJA);
			this.ACGMEBDKMGO = base.EBBLDMMIAJP(this.shaderFXAAIII, this.ACGMEBDKMGO);
			this.HEKPJMOEIFB = base.NCOMILNCHJO(this.nfaaShader, this.HEKPJMOEIFB);
			this.FCJOCKNGEDE = base.KDCLGAPCAOA(this.ssaaShader, this.FCJOCKNGEDE);
			this.KFCHKLIENGH = base.DANHMNKJEFI(this.dlaaShader, this.KFCHKLIENGH);
			if (!this.ssaaShader.isSupported)
			{
				base.HCBFPHFFGFJ();
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x04000CB4 RID: 3252
		public AAMode mode = AAMode.FXAA3Console;

		// Token: 0x04000CB5 RID: 3253
		public bool showGeneratedNormals;

		// Token: 0x04000CB6 RID: 3254
		public float offsetScale = 0.2f;

		// Token: 0x04000CB7 RID: 3255
		public float blurRadius = 18f;

		// Token: 0x04000CB8 RID: 3256
		public float edgeThresholdMin = 0.05f;

		// Token: 0x04000CB9 RID: 3257
		public float edgeThreshold = 0.2f;

		// Token: 0x04000CBA RID: 3258
		public float edgeSharpness = 4f;

		// Token: 0x04000CBB RID: 3259
		public bool dlaaSharp;

		// Token: 0x04000CBC RID: 3260
		public Shader ssaaShader;

		// Token: 0x04000CBD RID: 3261
		private Material FCJOCKNGEDE;

		// Token: 0x04000CBE RID: 3262
		public Shader dlaaShader;

		// Token: 0x04000CBF RID: 3263
		private Material KFCHKLIENGH;

		// Token: 0x04000CC0 RID: 3264
		public Shader nfaaShader;

		// Token: 0x04000CC1 RID: 3265
		private Material HEKPJMOEIFB;

		// Token: 0x04000CC2 RID: 3266
		public Shader shaderFXAAPreset2;

		// Token: 0x04000CC3 RID: 3267
		private Material LGHECEBJLIG;

		// Token: 0x04000CC4 RID: 3268
		public Shader shaderFXAAPreset3;

		// Token: 0x04000CC5 RID: 3269
		private Material FDECHNLLEGF;

		// Token: 0x04000CC6 RID: 3270
		public Shader shaderFXAAII;

		// Token: 0x04000CC7 RID: 3271
		private Material DAGEPCOJKJA;

		// Token: 0x04000CC8 RID: 3272
		public Shader shaderFXAAIII;

		// Token: 0x04000CC9 RID: 3273
		private Material ACGMEBDKMGO;
	}
}
