using System;
using UnityEngine;

// Token: 0x020000E1 RID: 225
[AddComponentMenu("Camera Filter Pack/Gradients/Ansi")]
[ExecuteInEditMode]
public class CameraFilterPack_Gradients_Ansi : MonoBehaviour
{
	// Token: 0x060044B1 RID: 17585 RVA: 0x0002523B File Offset: 0x0002343B
	private void ALNNIDLFILB()
	{
	}

	// Token: 0x060044B2 RID: 17586 RVA: 0x00154C80 File Offset: 0x00152E80
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 254f)
			{
				this.HBJJOCHGOPH = 141f;
			}
			this.BAGICADFBAB().SetFloat("_SpherePositionY", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("[LevelEditorScene] Map submitted!", this.ALGIDJONBGN);
			this.DBOLLHHMKKN().SetFloat(".g", this.IMNDKCGGPEH);
			this.BBIMPFGLDCP().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 295f, 818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044B3 RID: 17587 RVA: 0x0002523B File Offset: 0x0002343B
	private void CIPKEPDELJB()
	{
	}

	// Token: 0x060044B4 RID: 17588 RVA: 0x00154D54 File Offset: 0x00152F54
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 431f)
			{
				this.HBJJOCHGOPH = 726f;
			}
			this.OIBHFCLJKDB().SetFloat("#ok", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Antialiasing_FXAA", this.ALGIDJONBGN);
			this.HHLFDHNEIAH().SetFloat("The number of objects sent via a PhotonStreamQueue has to be the same each frame", this.IMNDKCGGPEH);
			this.LMLENGFLEBD().SetVector("Text", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 115f, 944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044B5 RID: 17589 RVA: 0x00154E27 File Offset: 0x00153027
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044B6 RID: 17590 RVA: 0x00154E44 File Offset: 0x00153044
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 52f)
			{
				this.HBJJOCHGOPH = 1999f;
			}
			this.OIIDAKBILMI().SetFloat("player.mysteryitem", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("CameraFilterPack/FX_Grid", this.ALGIDJONBGN);
			this.BAGICADFBAB().SetFloat("#forever", this.IMNDKCGGPEH);
			this.PDEAHJPOMEF().SetVector("float,0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 602f, 720f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044B7 RID: 17591 RVA: 0x0002523B File Offset: 0x0002343B
	private void COIJKMKIEAK()
	{
	}

	// Token: 0x060044B8 RID: 17592 RVA: 0x0002523B File Offset: 0x0002343B
	private void CCFEDENFNEF()
	{
	}

	// Token: 0x060044B9 RID: 17593 RVA: 0x0002523B File Offset: 0x0002343B
	private void FHPFJBFCOOF()
	{
	}

	// Token: 0x060044BA RID: 17594 RVA: 0x00154E27 File Offset: 0x00153027
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044BB RID: 17595 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x060044BC RID: 17596 RVA: 0x00154F17 File Offset: 0x00153117
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044BD RID: 17597 RVA: 0x00154F4E File Offset: 0x0015314E
	private Material OIBHFCLJKDB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044BE RID: 17598 RVA: 0x00154E27 File Offset: 0x00153027
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044BF RID: 17599 RVA: 0x0002523B File Offset: 0x0002343B
	private void FEHCNJLLJMP()
	{
	}

	// Token: 0x060044C0 RID: 17600 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x060044C1 RID: 17601 RVA: 0x00154F88 File Offset: 0x00153188
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1221f)
			{
				this.HBJJOCHGOPH = 916f;
			}
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("SpawnObj", this.ALGIDJONBGN);
			this.HKIMAANBGMJ().SetFloat("_TimeX", this.IMNDKCGGPEH);
			this.KJMECMIGJJA().SetVector("Failed to 'GetKeyCode' for key: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 101f, 1173f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044C2 RID: 17602 RVA: 0x0015505C File Offset: 0x0015325C
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.ALGIDJONBGN);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.IMNDKCGGPEH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044C3 RID: 17603 RVA: 0x0015512F File Offset: 0x0015332F
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044C4 RID: 17604 RVA: 0x00155168 File Offset: 0x00153368
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1527f)
			{
				this.HBJJOCHGOPH = 378f;
			}
			this.CFEDGDGBCHE().SetFloat("achievements.21.completed.workshop.", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", this.ALGIDJONBGN);
			this.BBIMPFGLDCP().SetFloat("/", this.IMNDKCGGPEH);
			this.CFEDGDGBCHE().SetVector("finished", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 363f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044C5 RID: 17605 RVA: 0x00154E27 File Offset: 0x00153027
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044C6 RID: 17606 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNNFHBOOPIN()
	{
	}

	// Token: 0x060044C7 RID: 17607 RVA: 0x00154E27 File Offset: 0x00153027
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044C8 RID: 17608 RVA: 0x0002523B File Offset: 0x0002343B
	private void NPLCENPNJBM()
	{
	}

	// Token: 0x060044C9 RID: 17609 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x060044CA RID: 17610 RVA: 0x00154E27 File Offset: 0x00153027
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044CB RID: 17611 RVA: 0x00154E27 File Offset: 0x00153027
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044CC RID: 17612 RVA: 0x0015523C File Offset: 0x0015343C
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 687f)
			{
				this.HBJJOCHGOPH = 1278f;
			}
			this.OIBHFCLJKDB().SetFloat("menu.tabid", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Can't do manual instantiation without PhotonView component.", this.ALGIDJONBGN);
			this.LMLENGFLEBD().SetFloat("settings.volume.editor", this.IMNDKCGGPEH);
			this.DIOAAHJDMLK().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 533f, 247f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044CD RID: 17613 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x060044CE RID: 17614 RVA: 0x00154E27 File Offset: 0x00153027
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044CF RID: 17615 RVA: 0x00155310 File Offset: 0x00153510
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 956f)
			{
				this.HBJJOCHGOPH = 1394f;
			}
			this.HHIAIGCAHDA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", this.ALGIDJONBGN);
			this.HKIMAANBGMJ().SetFloat("Beat Detected", this.IMNDKCGGPEH);
			this.OIIDAKBILMI().SetVector("/icon", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 57f, 1555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044D0 RID: 17616 RVA: 0x001553E3 File Offset: 0x001535E3
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044D1 RID: 17617 RVA: 0x0002523B File Offset: 0x0002343B
	private void LIBGAKMKHJJ()
	{
	}

	// Token: 0x060044D2 RID: 17618 RVA: 0x0015541C File Offset: 0x0015361C
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 843f)
			{
				this.HBJJOCHGOPH = 1954f;
			}
			this.BAGICADFBAB().SetFloat("EnableRankedNotificationsToggle", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", this.ALGIDJONBGN);
			this.CIAFLBFJLEJ().SetFloat("OK", this.IMNDKCGGPEH);
			this.LMLENGFLEBD().SetVector("_Speed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 106f, 112f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044D3 RID: 17619 RVA: 0x001554F0 File Offset: 0x001536F0
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1604f)
			{
				this.HBJJOCHGOPH = 1488f;
			}
			this.CFEDGDGBCHE().SetFloat("The given 2D texture ", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("fade in duration", this.ALGIDJONBGN);
			this.DIOAAHJDMLK().SetFloat("_Green_R", this.IMNDKCGGPEH);
			this.OIIDAKBILMI().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 838f, 1561f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044D4 RID: 17620 RVA: 0x0002523B File Offset: 0x0002343B
	private void FANADGBGCPI()
	{
	}

	// Token: 0x060044D5 RID: 17621 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDPDMBFLHLP()
	{
	}

	// Token: 0x060044D6 RID: 17622 RVA: 0x001555C3 File Offset: 0x001537C3
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044D7 RID: 17623 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060044D8 RID: 17624 RVA: 0x0002523B File Offset: 0x0002343B
	private void FLKEJJEGCFA()
	{
	}

	// Token: 0x060044D9 RID: 17625 RVA: 0x0002523B File Offset: 0x0002343B
	private void IGPCNCJIEOJ()
	{
	}

	// Token: 0x060044DA RID: 17626 RVA: 0x001555FC File Offset: 0x001537FC
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 167f)
			{
				this.HBJJOCHGOPH = 751f;
			}
			this.HHIAIGCAHDA().SetFloat("Editor", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("maps.", this.ALGIDJONBGN);
			this.NBPKMLMCHFN.SetFloat("\t", this.IMNDKCGGPEH);
			this.BBIMPFGLDCP().SetVector("set id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 898f, 600f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044DB RID: 17627 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060044DC RID: 17628 RVA: 0x001556CF File Offset: 0x001538CF
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044DD RID: 17629 RVA: 0x00155708 File Offset: 0x00153908
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 940f)
			{
				this.HBJJOCHGOPH = 510f;
			}
			this.EJDPNJAEAKJ().SetFloat("Rotate environment object to the rotation", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("(\\[ *quote *\\])", this.ALGIDJONBGN);
			this.DIOAAHJDMLK().SetFloat("[LocalizationService] All keys for ", this.IMNDKCGGPEH);
			this.KJMECMIGJJA().SetVector("RB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 518f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044DE RID: 17630 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060044DF RID: 17631 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGDMLHLJIDK()
	{
	}

	// Token: 0x060044E0 RID: 17632 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDJKNBDKHBD()
	{
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060044E1 RID: 17633 RVA: 0x001557DB File Offset: 0x001539DB
	private Material NBPKMLMCHFN
	{
		get
		{
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return this.BJFKDHHMLJH;
		}
	}

	// Token: 0x060044E3 RID: 17635 RVA: 0x00154E27 File Offset: 0x00153027
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044E4 RID: 17636 RVA: 0x0015583B File Offset: 0x00153A3B
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044E5 RID: 17637 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060044E6 RID: 17638 RVA: 0x00155874 File Offset: 0x00153A74
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 714f)
			{
				this.HBJJOCHGOPH = 556f;
			}
			this.OIBHFCLJKDB().SetFloat("IncorrectHitsScoreText", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("_Value1", this.ALGIDJONBGN);
			this.OIIDAKBILMI().SetFloat("DPADVER", this.IMNDKCGGPEH);
			this.DIOAAHJDMLK().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 844f, 1261f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044E7 RID: 17639 RVA: 0x0002523B File Offset: 0x0002343B
	private void JMEOGJHCONJ()
	{
	}

	// Token: 0x060044E8 RID: 17640 RVA: 0x00154E27 File Offset: 0x00153027
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044E9 RID: 17641 RVA: 0x00155947 File Offset: 0x00153B47
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044EA RID: 17642 RVA: 0x00155980 File Offset: 0x00153B80
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1035f)
			{
				this.HBJJOCHGOPH = 1132f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value2", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("_MainTex2", this.ALGIDJONBGN);
			this.DBOLLHHMKKN().SetFloat("_Value6", this.IMNDKCGGPEH);
			this.BAGICADFBAB().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 475f, 1184f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044EB RID: 17643 RVA: 0x00155A53 File Offset: 0x00153C53
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044EC RID: 17644 RVA: 0x00155A8C File Offset: 0x00153C8C
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1702f)
			{
				this.HBJJOCHGOPH = 635f;
			}
			this.MJJIEHANFJA().SetFloat("_Value12", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("player.orangelifering", this.ALGIDJONBGN);
			this.BAGICADFBAB().SetFloat("_MainTex2", this.IMNDKCGGPEH);
			this.PDEAHJPOMEF().SetVector(" Mb", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1758f, 332f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044ED RID: 17645 RVA: 0x00155B60 File Offset: 0x00153D60
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1962f)
			{
				this.HBJJOCHGOPH = 231f;
			}
			this.BBIMPFGLDCP().SetFloat("Right Click", this.HBJJOCHGOPH);
			this.HHLFDHNEIAH().SetFloat("_TimeX", this.ALGIDJONBGN);
			this.HHIAIGCAHDA().SetFloat("win", this.IMNDKCGGPEH);
			this.NLFJGMBCICG().SetVector(".", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1151f, 884f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044EE RID: 17646 RVA: 0x00155C34 File Offset: 0x00153E34
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1828f)
			{
				this.HBJJOCHGOPH = 798f;
			}
			this.NLFJGMBCICG().SetFloat("shader.pixel", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("_MainTex", this.ALGIDJONBGN);
			this.HKIMAANBGMJ().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.IMNDKCGGPEH);
			this.HKIMAANBGMJ().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 930f, 12f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044EF RID: 17647 RVA: 0x00155D07 File Offset: 0x00153F07
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044F0 RID: 17648 RVA: 0x00155D3E File Offset: 0x00153F3E
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044F1 RID: 17649 RVA: 0x00155D78 File Offset: 0x00153F78
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 343f)
			{
				this.HBJJOCHGOPH = 256f;
			}
			this.BAGICADFBAB().SetFloat("error", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("_MinVelocity", this.ALGIDJONBGN);
			this.CFEDGDGBCHE().SetFloat("[PlayerBase] New highscore", this.IMNDKCGGPEH);
			this.BAGICADFBAB().SetVector(".lastCheckpoint.lives", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 382f, 969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044F2 RID: 17650 RVA: 0x0002523B File Offset: 0x0002343B
	private void FDNONDCGGCG()
	{
	}

	// Token: 0x060044F3 RID: 17651 RVA: 0x00155E4C File Offset: 0x0015404C
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 623f)
			{
				this.HBJJOCHGOPH = 1905f;
			}
			this.DBOLLHHMKKN().SetFloat("_ArScale", this.HBJJOCHGOPH);
			this.BBIMPFGLDCP().SetFloat("Lerp speed. Recomended 10", this.ALGIDJONBGN);
			this.OIBHFCLJKDB().SetFloat("Right Stick Click", this.IMNDKCGGPEH);
			this.OIIDAKBILMI().SetVector("BestRegion checks region: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 581f, 1316f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044F4 RID: 17652 RVA: 0x0002523B File Offset: 0x0002343B
	private void JILOMOBDPIA()
	{
	}

	// Token: 0x060044F5 RID: 17653 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x060044F6 RID: 17654 RVA: 0x00154E27 File Offset: 0x00153027
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044F7 RID: 17655 RVA: 0x00155F1F File Offset: 0x0015411F
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044F8 RID: 17656 RVA: 0x0002523B File Offset: 0x0002343B
	private void EFJDNLGNACH()
	{
	}

	// Token: 0x060044F9 RID: 17657 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x060044FA RID: 17658 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIMMMCJFMAB()
	{
	}

	// Token: 0x060044FB RID: 17659 RVA: 0x0002523B File Offset: 0x0002343B
	private void KNBJBNDGCIJ()
	{
	}

	// Token: 0x060044FC RID: 17660 RVA: 0x00154E27 File Offset: 0x00153027
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044FD RID: 17661 RVA: 0x0002523B File Offset: 0x0002343B
	private void CPCDFMMLHLO()
	{
	}

	// Token: 0x060044FE RID: 17662 RVA: 0x00155F56 File Offset: 0x00154156
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044FF RID: 17663 RVA: 0x00154E27 File Offset: 0x00153027
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004500 RID: 17664 RVA: 0x00155F90 File Offset: 0x00154190
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 866f)
			{
				this.HBJJOCHGOPH = 373f;
			}
			this.CFEDGDGBCHE().SetFloat("_Red_B", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("BadgeText", this.ALGIDJONBGN);
			this.KBOPGONOCNP().SetFloat("player.gamecompleted", this.IMNDKCGGPEH);
			this.EJDPNJAEAKJ().SetVector("_Distance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1859f, 869f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004501 RID: 17665 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06004502 RID: 17666 RVA: 0x00156063 File Offset: 0x00154263
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004503 RID: 17667 RVA: 0x0015609C File Offset: 0x0015429C
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 589f)
			{
				this.HBJJOCHGOPH = 809f;
			}
			this.NLFJGMBCICG().SetFloat("settings_bindings_", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("GameScene", this.ALGIDJONBGN);
			this.EJDPNJAEAKJ().SetFloat("Parameter levelId must be int or string!", this.IMNDKCGGPEH);
			this.MJJIEHANFJA().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 771f, 396f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004504 RID: 17668 RVA: 0x0015616F File Offset: 0x0015436F
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004505 RID: 17669 RVA: 0x0002523B File Offset: 0x0002343B
	private void DFFKKLAPHCC()
	{
	}

	// Token: 0x06004506 RID: 17670 RVA: 0x00154E27 File Offset: 0x00153027
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004507 RID: 17671 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06004508 RID: 17672 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBAJLLFMMMP()
	{
	}

	// Token: 0x06004509 RID: 17673 RVA: 0x001561A8 File Offset: 0x001543A8
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 388f)
			{
				this.HBJJOCHGOPH = 1796f;
			}
			this.OIIDAKBILMI().SetFloat("Submit", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("[GameEvent] Exeption:", this.ALGIDJONBGN);
			this.LMLENGFLEBD().SetFloat("_Value", this.IMNDKCGGPEH);
			this.PDEAHJPOMEF().SetVector(".lastCheckpoint.maxLongestCombo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 329f, 830f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600450A RID: 17674 RVA: 0x00154E27 File Offset: 0x00153027
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600450B RID: 17675 RVA: 0x0002523B File Offset: 0x0002343B
	private void IMCKJCHKMKB()
	{
	}

	// Token: 0x0600450C RID: 17676 RVA: 0x00155F56 File Offset: 0x00154156
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600450D RID: 17677 RVA: 0x00154E27 File Offset: 0x00153027
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600450E RID: 17678 RVA: 0x0015627C File Offset: 0x0015447C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1096f)
			{
				this.HBJJOCHGOPH = 700f;
			}
			this.CFEDGDGBCHE().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("_MatrixSize", this.ALGIDJONBGN);
			this.OIIDAKBILMI().SetFloat("_Value2", this.IMNDKCGGPEH);
			this.LMLENGFLEBD().SetVector("_Value6", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1170f, 84f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600450F RID: 17679 RVA: 0x00154E27 File Offset: 0x00153027
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004510 RID: 17680 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06004511 RID: 17681 RVA: 0x00156350 File Offset: 0x00154550
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1662f)
			{
				this.HBJJOCHGOPH = 1104f;
			}
			this.PDEAHJPOMEF().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("_Intensity", this.ALGIDJONBGN);
			this.HHIAIGCAHDA().SetFloat("achievements.21.completed.workshop.", this.IMNDKCGGPEH);
			this.EMDFHOKEGNG().SetVector("seconds", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 676f, 253f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004512 RID: 17682 RVA: 0x00156424 File Offset: 0x00154624
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 876f)
			{
				this.HBJJOCHGOPH = 1330f;
			}
			this.HHLFDHNEIAH().SetFloat("maps.", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("#.##", this.ALGIDJONBGN);
			this.HKIMAANBGMJ().SetFloat("CameraFilterPack/AAA_Blood_Hit", this.IMNDKCGGPEH);
			this.KBOPGONOCNP().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 33f, 777f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004513 RID: 17683 RVA: 0x001564F8 File Offset: 0x001546F8
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 938f)
			{
				this.HBJJOCHGOPH = 1788f;
			}
			this.NBPKMLMCHFN.SetFloat("offsets", this.HBJJOCHGOPH);
			this.HHLFDHNEIAH().SetFloat("Case-Sensitive", this.ALGIDJONBGN);
			this.PDEAHJPOMEF().SetFloat("GameScene", this.IMNDKCGGPEH);
			this.DIOAAHJDMLK().SetVector("settings.arcsdestroydelay", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1423f, 1601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004514 RID: 17684 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06004515 RID: 17685 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06004516 RID: 17686 RVA: 0x0002523B File Offset: 0x0002343B
	private void JECMJNFGBGC()
	{
	}

	// Token: 0x06004517 RID: 17687 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPFOFGJPNCI()
	{
	}

	// Token: 0x06004518 RID: 17688 RVA: 0x00154E27 File Offset: 0x00153027
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004519 RID: 17689 RVA: 0x001565CC File Offset: 0x001547CC
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1045f)
			{
				this.HBJJOCHGOPH = 1822f;
			}
			this.BAGICADFBAB().SetFloat("arcs", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_BlurredColor", this.ALGIDJONBGN);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this.IMNDKCGGPEH);
			this.NLFJGMBCICG().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 434f, 523f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600451A RID: 17690 RVA: 0x0015669F File Offset: 0x0015489F
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600451B RID: 17691 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCCIEMBMOBA()
	{
	}

	// Token: 0x0600451C RID: 17692 RVA: 0x0002523B File Offset: 0x0002343B
	private void DKGBFNCOAEO()
	{
	}

	// Token: 0x0600451D RID: 17693 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600451E RID: 17694 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x0600451F RID: 17695 RVA: 0x00154E27 File Offset: 0x00153027
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004520 RID: 17696 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06004521 RID: 17697 RVA: 0x0002523B File Offset: 0x0002343B
	private void KLILJHJNICK()
	{
	}

	// Token: 0x06004522 RID: 17698 RVA: 0x001566D8 File Offset: 0x001548D8
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 752f)
			{
				this.HBJJOCHGOPH = 1098f;
			}
			this.KBOPGONOCNP().SetFloat("Set Sun MaxSize", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("_Value2", this.ALGIDJONBGN);
			this.CFEDGDGBCHE().SetFloat("_CenterY", this.IMNDKCGGPEH);
			this.BBIMPFGLDCP().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 919f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004523 RID: 17699 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEDDNDHCLNN()
	{
	}

	// Token: 0x06004524 RID: 17700 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06004525 RID: 17701 RVA: 0x001567AC File Offset: 0x001549AC
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 988f)
			{
				this.HBJJOCHGOPH = 1031f;
			}
			this.OIBHFCLJKDB().SetFloat("|", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("PunSupportLogger", this.ALGIDJONBGN);
			this.EMDFHOKEGNG().SetFloat("[MapEditor] Loading music...", this.IMNDKCGGPEH);
			this.HHLFDHNEIAH().SetVector("received</b>\n#reason: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1321f, 1552f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004526 RID: 17702 RVA: 0x00154E27 File Offset: 0x00153027
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004527 RID: 17703 RVA: 0x0015687F File Offset: 0x00154A7F
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004528 RID: 17704 RVA: 0x001568B8 File Offset: 0x00154AB8
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1522f)
			{
				this.HBJJOCHGOPH = 1461f;
			}
			this.CFEDGDGBCHE().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("Hidden/DepthOfField/BokehSplatting", this.ALGIDJONBGN);
			this.MJJIEHANFJA().SetFloat(" | ", this.IMNDKCGGPEH);
			this.CFEDGDGBCHE().SetVector("RPC: 'OnAwakeRPC' PhotonView: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 658f, 608f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004529 RID: 17705 RVA: 0x00154E27 File Offset: 0x00153027
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600452A RID: 17706 RVA: 0x00154E27 File Offset: 0x00153027
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600452B RID: 17707 RVA: 0x0015698B File Offset: 0x00154B8B
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600452C RID: 17708 RVA: 0x001569C4 File Offset: 0x00154BC4
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1460f)
			{
				this.HBJJOCHGOPH = 701f;
			}
			this.EJDPNJAEAKJ().SetFloat("B", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("_Value2", this.ALGIDJONBGN);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Screen", this.IMNDKCGGPEH);
			this.OIIDAKBILMI().SetVector("RecordButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1072f, 840f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600452D RID: 17709 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x0600452E RID: 17710 RVA: 0x00154E27 File Offset: 0x00153027
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600452F RID: 17711 RVA: 0x0002523B File Offset: 0x0002343B
	private void FMNPFCHBLJF()
	{
	}

	// Token: 0x06004530 RID: 17712 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x04000761 RID: 1889
	public Shader SCShader;

	// Token: 0x04000762 RID: 1890
	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_Ansi";

	// Token: 0x04000763 RID: 1891
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000764 RID: 1892
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000765 RID: 1893
	private Material BJFKDHHMLJH;

	// Token: 0x04000766 RID: 1894
	[Range(0f, 1f)]
	private float ALGIDJONBGN;

	// Token: 0x04000767 RID: 1895
	[Range(0f, 1f)]
	private float IMNDKCGGPEH = 0.2f;
}
