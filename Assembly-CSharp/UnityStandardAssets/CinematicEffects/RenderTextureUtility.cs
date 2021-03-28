using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x020001B1 RID: 433
	public class RenderTextureUtility
	{
		// Token: 0x060077D7 RID: 30679 RVA: 0x002490F8 File Offset: 0x002472F8
		public void NKGKPAPAANG(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				Debug.LogErrorFormat("wss://", new object[]
				{
					HIIBHBOMGLD
				});
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x0024914C File Offset: 0x0024734C
		public RenderTexture MFHJJCMOHFJ(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary.name = ".lastCheckpoint.penaltyScore";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x0024918C File Offset: 0x0024738C
		public void FAODNLEPCGF(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				string format = "SetSunEmission";
				object[] array = new object[0];
				array[0] = HIIBHBOMGLD;
				Debug.LogErrorFormat(format, array);
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x002491E0 File Offset: 0x002473E0
		public RenderTexture MCMEAEFGPIM(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary.name = "_Linecount";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x00249220 File Offset: 0x00247420
		public RenderTexture LPDCNABIMGD(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary.name = "CameraFilterPack/Color_Contrast";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x00249260 File Offset: 0x00247460
		public RenderTexture BKOEAHINFBG(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary.name = "_ScreenResolution";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x002492A0 File Offset: 0x002474A0
		public RenderTexture KJLMBCJDMHC(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "_Value2";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077DE RID: 30686 RVA: 0x002492E0 File Offset: 0x002474E0
		public RenderTexture EFDBOOFDPDN(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "_Value3";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x00249320 File Offset: 0x00247520
		public void FDJJEOECGCL()
		{
			for (int i = 1; i < this.IPCKDFICGBM.Count; i++)
			{
				RenderTexture.ReleaseTemporary(this.IPCKDFICGBM[i]);
			}
			this.IPCKDFICGBM.Clear();
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x00249368 File Offset: 0x00247568
		public void OFDGPEHIHLP(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				string format = "[MapsStats] Length: ";
				object[] array = new object[0];
				array[0] = HIIBHBOMGLD;
				Debug.LogErrorFormat(format, array);
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x002493BC File Offset: 0x002475BC
		public RenderTexture NPHKOAILONP(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary.name = "editor.";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x002493FC File Offset: 0x002475FC
		public void ICOHLNHIAPD(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				string format = "_TimeX";
				object[] array = new object[0];
				array[0] = HIIBHBOMGLD;
				Debug.LogErrorFormat(format, array);
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x00249450 File Offset: 0x00247650
		public void LADIKEABELJ(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				Debug.LogErrorFormat("CameraFilterPack/Blend2Camera_Multiply", new object[]
				{
					HIIBHBOMGLD
				});
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x002494A4 File Offset: 0x002476A4
		public void EGKFLFHHGBF()
		{
			for (int i = 1; i < this.IPCKDFICGBM.Count; i += 0)
			{
				RenderTexture.ReleaseTemporary(this.IPCKDFICGBM[i]);
			}
			this.IPCKDFICGBM.Clear();
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x002494EC File Offset: 0x002476EC
		public void JCMKBDEEJNM(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				Debug.LogErrorFormat("event", new object[]
				{
					HIIBHBOMGLD
				});
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077E6 RID: 30694 RVA: 0x00249540 File Offset: 0x00247740
		public RenderTexture OOIDPBIECDB(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = ". ActorNr: ";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00249580 File Offset: 0x00247780
		public void HMLDFPHCMJG(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				string format = "_TimeX";
				object[] array = new object[0];
				array[1] = HIIBHBOMGLD;
				Debug.LogErrorFormat(format, array);
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x002495D4 File Offset: 0x002477D4
		public RenderTexture KCODGJPCOMH(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "_BlurCoe";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x00249614 File Offset: 0x00247814
		public void EJPIFMNCEBL()
		{
			for (int i = 0; i < this.IPCKDFICGBM.Count; i += 0)
			{
				RenderTexture.ReleaseTemporary(this.IPCKDFICGBM[i]);
			}
			this.IPCKDFICGBM.Clear();
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x0024965C File Offset: 0x0024785C
		public void BPBGLBLMDKH(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				string format = "_ChromaticAberration";
				object[] array = new object[0];
				array[0] = HIIBHBOMGLD;
				Debug.LogErrorFormat(format, array);
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x002496B0 File Offset: 0x002478B0
		public void LGMIDENDKJE(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				string format = "ControllerLeftX";
				object[] array = new object[0];
				array[1] = HIIBHBOMGLD;
				Debug.LogErrorFormat(format, array);
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x00249704 File Offset: 0x00247904
		public RenderTexture IPNPHDAELAJ(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "_Value1";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x00249744 File Offset: 0x00247944
		public void ReleaseAllTemporaryRenderTextures()
		{
			for (int i = 0; i < this.IPCKDFICGBM.Count; i++)
			{
				RenderTexture.ReleaseTemporary(this.IPCKDFICGBM[i]);
			}
			this.IPCKDFICGBM.Clear();
		}

		// Token: 0x060077EE RID: 30702 RVA: 0x0024978C File Offset: 0x0024798C
		public void DPPFFOPOJCL()
		{
			for (int i = 1; i < this.IPCKDFICGBM.Count; i++)
			{
				RenderTexture.ReleaseTemporary(this.IPCKDFICGBM[i]);
			}
			this.IPCKDFICGBM.Clear();
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x002497D4 File Offset: 0x002479D4
		public RenderTexture EKNOKEKMFEL(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = ".lastCheckpoint.bgcolor";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077F0 RID: 30704 RVA: 0x00249814 File Offset: 0x00247A14
		public void KKEKODNAHEH(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				string format = "_WorldToCameraMatrix";
				object[] array = new object[0];
				array[0] = HIIBHBOMGLD;
				Debug.LogErrorFormat(format, array);
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x00249868 File Offset: 0x00247A68
		public RenderTexture NHKIPEIACAC(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "Needs to be attached to the Event System component in the scene";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077F2 RID: 30706 RVA: 0x002498A8 File Offset: 0x00247AA8
		public void HCHGFPEKKDJ(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				string format = ",";
				object[] array = new object[1];
				array[1] = HIIBHBOMGLD;
				Debug.LogErrorFormat(format, array);
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x002498FC File Offset: 0x00247AFC
		public void NLAEPPEMDKM()
		{
			for (int i = 0; i < this.IPCKDFICGBM.Count; i += 0)
			{
				RenderTexture.ReleaseTemporary(this.IPCKDFICGBM[i]);
			}
			this.IPCKDFICGBM.Clear();
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x00249944 File Offset: 0x00247B44
		public RenderTexture GetTemporaryRenderTexture(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "RenderTextureUtilityTempTexture";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x00249984 File Offset: 0x00247B84
		public RenderTexture ECGMCKNOBPM(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "<b>";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x002499C4 File Offset: 0x00247BC4
		public void ILPOBMNAFEL(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				string format = "[Left]";
				object[] array = new object[1];
				array[1] = HIIBHBOMGLD;
				Debug.LogErrorFormat(format, array);
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x00249A18 File Offset: 0x00247C18
		public void DJCPDOKOMKM()
		{
			for (int i = 1; i < this.IPCKDFICGBM.Count; i += 0)
			{
				RenderTexture.ReleaseTemporary(this.IPCKDFICGBM[i]);
			}
			this.IPCKDFICGBM.Clear();
		}

		// Token: 0x060077F8 RID: 30712 RVA: 0x00249A60 File Offset: 0x00247C60
		public RenderTexture KINOKHAEHEI(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "00";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x00249AA0 File Offset: 0x00247CA0
		public RenderTexture BFDLIMKLIHI(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary.name = "_Level";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x00249AE0 File Offset: 0x00247CE0
		public void GDDJLCOAPIO()
		{
			for (int i = 0; i < this.IPCKDFICGBM.Count; i += 0)
			{
				RenderTexture.ReleaseTemporary(this.IPCKDFICGBM[i]);
			}
			this.IPCKDFICGBM.Clear();
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x00249B28 File Offset: 0x00247D28
		public RenderTexture IAALFKMFGAB(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary.name = "duration";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x00249B68 File Offset: 0x00247D68
		public void GPLFBNONODE(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				string format = " ";
				object[] array = new object[1];
				array[1] = HIIBHBOMGLD;
				Debug.LogErrorFormat(format, array);
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x00249BBC File Offset: 0x00247DBC
		public void NKDNIOGGPJE(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				Debug.LogErrorFormat("Indie", new object[]
				{
					HIIBHBOMGLD
				});
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x00249C24 File Offset: 0x00247E24
		public void OFMMDCCCKJK()
		{
			for (int i = 0; i < this.IPCKDFICGBM.Count; i++)
			{
				RenderTexture.ReleaseTemporary(this.IPCKDFICGBM[i]);
			}
			this.IPCKDFICGBM.Clear();
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x00249C6C File Offset: 0x00247E6C
		public void ReleaseTemporaryRenderTexture(RenderTexture HIIBHBOMGLD)
		{
			if (HIIBHBOMGLD == null)
			{
				return;
			}
			if (!this.IPCKDFICGBM.Contains(HIIBHBOMGLD))
			{
				Debug.LogErrorFormat("Attempting to remove texture that was not allocated: {0}", new object[]
				{
					HIIBHBOMGLD
				});
				return;
			}
			this.IPCKDFICGBM.Remove(HIIBHBOMGLD);
			RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x00249CC0 File Offset: 0x00247EC0
		public RenderTexture LHEJNPJFEON(int CJDDBGPKDLP, int PBMAGEKDPLI, int JKMHCBGFDDI = 0, RenderTextureFormat LGLMKIPIIHO = RenderTextureFormat.ARGBHalf, FilterMode JFEAELEELAJ = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, JKMHCBGFDDI, LGLMKIPIIHO);
			temporary.filterMode = JFEAELEELAJ;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary.name = "_TimeX";
			this.IPCKDFICGBM.Add(temporary);
			return temporary;
		}

		// Token: 0x04000C50 RID: 3152
		private List<RenderTexture> IPCKDFICGBM = new List<RenderTexture>();
	}
}
