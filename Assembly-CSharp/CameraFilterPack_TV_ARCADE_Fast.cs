using System;
using UnityEngine;

// Token: 0x02000110 RID: 272
[AddComponentMenu("Camera Filter Pack/TV/ARCADE_Fast")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_ARCADE_Fast : MonoBehaviour
{
	// Token: 0x06005468 RID: 21608 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06005469 RID: 21609 RVA: 0x001A2404 File Offset: 0x001A0604
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600546A RID: 21610 RVA: 0x001A243B File Offset: 0x001A063B
	private void MDNHCLKNCLE()
	{
		this.FPHEBLMINDA = (Resources.Load("_OcclusionTexture") as Texture2D);
		this.SCShader = Shader.Find("float,1.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600546B RID: 21611 RVA: 0x001A2474 File Offset: 0x001A0674
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600546C RID: 21612 RVA: 0x001A2474 File Offset: 0x001A0674
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600546D RID: 21613 RVA: 0x001A2474 File Offset: 0x001A0674
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600546E RID: 21614 RVA: 0x001A2494 File Offset: 0x001A0694
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 333f)
			{
				this.HBJJOCHGOPH = 1303f;
			}
			this.CECJJMKLEAK().SetFloat(" Kb", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("2hands", this.Interferance_Size);
			this.KAFBNOBOIAJ().SetFloat("BitsData", this.Interferance_Speed);
			this.ADBKPGFMNKO().SetFloat("_ScreenResolution", this.Contrast);
			this.DKKBFFHBHJE().SetFloat("shader.future", this.Fade);
			this.OIMMPLPBLBK().SetVector("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 960f, 447f));
			this.CECJJMKLEAK().SetTexture("(scene)", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600546F RID: 21615 RVA: 0x001A25AC File Offset: 0x001A07AC
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 407f)
			{
				this.HBJJOCHGOPH = 1172f;
			}
			this.DKNJGHFLAIF().SetFloat("_SoftZDistance", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("-1", this.Interferance_Size);
			this.NDMPCDHADMJ().SetFloat("/", this.Interferance_Speed);
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this.Contrast);
			this.EPCGJFCCAFH().SetFloat("Set Sun MaxSize", this.Fade);
			this.EPBAAGMGPAP().SetVector("settings.volume.editor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 313f, 375f));
			this.FAIFBBGFAIB().SetTexture("[PlayerBase] Ready", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005470 RID: 21616 RVA: 0x001A26C4 File Offset: 0x001A08C4
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 788f)
			{
				this.HBJJOCHGOPH = 274f;
			}
			this.NLFJGMBCICG().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("_ScreenResolution", this.Interferance_Size);
			this.GKILCDHJFEG().SetFloat("Committing changes...", this.Interferance_Speed);
			this.GKILCDHJFEG().SetFloat("float,10", this.Contrast);
			this.EPCGJFCCAFH().SetFloat("[PlayerController] ", this.Fade);
			this.OHKGGPFGLFD().SetVector("team", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1164f, 1999f));
			this.CECJJMKLEAK().SetTexture("https://steamcommunity.com/sharedfiles/filedetails/?id=", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005471 RID: 21617 RVA: 0x001A27D9 File Offset: 0x001A09D9
	private void AGEJKLMJGDO()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value4") as Texture2D);
		this.SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005472 RID: 21618 RVA: 0x001A2474 File Offset: 0x001A0674
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005473 RID: 21619 RVA: 0x001A2474 File Offset: 0x001A0674
	private void CAKNMILHHNE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005474 RID: 21620 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06005475 RID: 21621 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06005476 RID: 21622 RVA: 0x001A2474 File Offset: 0x001A0674
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005477 RID: 21623 RVA: 0x001A2474 File Offset: 0x001A0674
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005478 RID: 21624 RVA: 0x001A2812 File Offset: 0x001A0A12
	private void OGJJDKENBNC()
	{
		this.FPHEBLMINDA = (Resources.Load("_Red_G") as Texture2D);
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005479 RID: 21625 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600547A RID: 21626 RVA: 0x001A284B File Offset: 0x001A0A4B
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600547B RID: 21627 RVA: 0x001A2882 File Offset: 0x001A0A82
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600547C RID: 21628 RVA: 0x001A28BC File Offset: 0x001A0ABC
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1724f)
			{
				this.HBJJOCHGOPH = 30f;
			}
			this.FAIFBBGFAIB().SetFloat("Committing changes...", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetFloat("gold", this.Interferance_Size);
			this.OHKGGPFGLFD().SetFloat(".jpg", this.Interferance_Speed);
			this.LNLKMDPHDCC().SetFloat("Set sun lerp speed", this.Contrast);
			this.CECJJMKLEAK().SetFloat("_TimeX", this.Fade);
			this.NDMPCDHADMJ().SetVector("Cancel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1749f, 1121f));
			this.NBPKMLMCHFN.SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600547D RID: 21629 RVA: 0x001A2474 File Offset: 0x001A0674
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600547E RID: 21630 RVA: 0x001A2474 File Offset: 0x001A0674
	private void ODLMOJDBPPG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600547F RID: 21631 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06005480 RID: 21632 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06005481 RID: 21633 RVA: 0x001A29D4 File Offset: 0x001A0BD4
	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 637f)
			{
				this.HBJJOCHGOPH = 1977f;
			}
			this.LMLENGFLEBD().SetFloat("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("music", this.Interferance_Size);
			this.MCDGIILBNIF().SetFloat("_Offsets", this.Interferance_Speed);
			this.GKILCDHJFEG().SetFloat("OnAwakeRPC", this.Contrast);
			this.GKILCDHJFEG().SetFloat("_Value3", this.Fade);
			this.EPBAAGMGPAP().SetVector("No Dispatcher exists in the scene. Actions will not be invoked!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 667f, 1630f));
			this.NBPKMLMCHFN.SetTexture("CameraFilterPack/Pixelisation_OilPaintHQ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005482 RID: 21634 RVA: 0x001A2AEC File Offset: 0x001A0CEC
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1052f)
			{
				this.HBJJOCHGOPH = 1906f;
			}
			this.OHKGGPFGLFD().SetFloat("#C8C8C8FF", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("n/a", this.Interferance_Size);
			this.NBPKMLMCHFN.SetFloat("_ReprojectionMatrix", this.Interferance_Speed);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/TV_Videoflip", this.Contrast);
			this.EPBAAGMGPAP().SetFloat("OpenButton", this.Fade);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 691f, 293f));
			this.ADBKPGFMNKO().SetTexture("_Visualize", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005483 RID: 21635 RVA: 0x001A2C01 File Offset: 0x001A0E01
	private void HMPGIFBJFIK()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Blend2Camera_Darken") as Texture2D);
		this.SCShader = Shader.Find("mapselector.filter.subscribedonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005484 RID: 21636 RVA: 0x001A2474 File Offset: 0x001A0674
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005485 RID: 21637 RVA: 0x001A2C3A File Offset: 0x001A0E3A
	private Material EPBAAGMGPAP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005486 RID: 21638 RVA: 0x001A2C71 File Offset: 0x001A0E71
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load("Run a command for data system") as Texture2D);
		this.SCShader = Shader.Find("_ChangeBlue");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005487 RID: 21639 RVA: 0x001A2CAC File Offset: 0x001A0EAC
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1277f)
			{
				this.HBJJOCHGOPH = 1678f;
			}
			this.LMLENGFLEBD().SetFloat("ticket", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", this.Interferance_Size);
			this.PEIMCBBHLBJ().SetFloat("LoadingStatusText", this.Interferance_Speed);
			this.ADBKPGFMNKO().SetFloat("The observed monobehaviour (", this.Contrast);
			this.OHKGGPFGLFD().SetFloat("1159514800", this.Fade);
			this.KAFBNOBOIAJ().SetVector(" Remote called.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 753f, 1517f));
			this.EPBAAGMGPAP().SetTexture("downloading", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005488 RID: 21640 RVA: 0x001A2DC4 File Offset: 0x001A0FC4
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1193f)
			{
				this.HBJJOCHGOPH = 567f;
			}
			this.PEIMCBBHLBJ().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetFloat("skin.hit_normal", this.Interferance_Size);
			this.ADBKPGFMNKO().SetFloat("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", this.Interferance_Speed);
			this.JCPDCGIJKJD().SetFloat("leave", this.Contrast);
			this.JDMJJGEHMJO().SetFloat("Set sun min/max size", this.Fade);
			this.GKILCDHJFEG().SetVector("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 688f, 1529f));
			this.PEIMCBBHLBJ().SetTexture("Reload Maps", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600548A RID: 21642 RVA: 0x0002523B File Offset: 0x0002343B
	private void JFMIDILENDO()
	{
	}

	// Token: 0x0600548B RID: 21643 RVA: 0x001A2474 File Offset: 0x001A0674
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600548C RID: 21644 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x0600548D RID: 21645 RVA: 0x001A2474 File Offset: 0x001A0674
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600548E RID: 21646 RVA: 0x001A2474 File Offset: 0x001A0674
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600548F RID: 21647 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06005490 RID: 21648 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06005491 RID: 21649 RVA: 0x001A2F18 File Offset: 0x001A1118
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1f)
			{
				this.HBJJOCHGOPH = 119f;
			}
			this.DKNJGHFLAIF().SetFloat("/", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_TimeX", this.Interferance_Size);
			this.MCDGIILBNIF().SetFloat("z", this.Interferance_Speed);
			this.DKKBFFHBHJE().SetFloat("Bad parameters for getbool! Use <key> <value>", this.Contrast);
			this.JDMJJGEHMJO().SetFloat("RECORD [R]", this.Fade);
			this.PEIMCBBHLBJ().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1043f, 194f));
			this.FAIFBBGFAIB().SetTexture("SubmitUserVote:", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005492 RID: 21650 RVA: 0x001A302D File Offset: 0x001A122D
	private void NNFMIAFHMJM()
	{
		this.FPHEBLMINDA = (Resources.Load("/icon") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005493 RID: 21651 RVA: 0x001A3066 File Offset: 0x001A1266
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005494 RID: 21652 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06005495 RID: 21653 RVA: 0x001A309D File Offset: 0x001A129D
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005496 RID: 21654 RVA: 0x001A30D4 File Offset: 0x001A12D4
	private void EGEPLFGKGLI()
	{
		this.FPHEBLMINDA = (Resources.Load("\\") as Texture2D);
		this.SCShader = Shader.Find("#outdatedmap! Challenges will not work!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06005497 RID: 21655 RVA: 0x001A310D File Offset: 0x001A130D
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

	// Token: 0x06005498 RID: 21656 RVA: 0x001A3144 File Offset: 0x001A1344
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005499 RID: 21657 RVA: 0x001A317C File Offset: 0x001A137C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1163f)
			{
				this.HBJJOCHGOPH = 544f;
			}
			this.JDMJJGEHMJO().SetFloat("Data/Maps/", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("{0} days ago", this.Interferance_Size);
			this.EPCGJFCCAFH().SetFloat("_ScreenResolution", this.Interferance_Speed);
			this.EPBAAGMGPAP().SetFloat("owner: ", this.Contrast);
			this.GKILCDHJFEG().SetFloat("CameraFilterPack/TV_Vignetting", this.Fade);
			this.CECJJMKLEAK().SetVector("Can not SetMasterClient(). Not in room or in offlineMode.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1293f, 1494f));
			this.JDMJJGEHMJO().SetTexture("_DistortionSize", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600549A RID: 21658 RVA: 0x001A2474 File Offset: 0x001A0674
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600549B RID: 21659 RVA: 0x001A3294 File Offset: 0x001A1494
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Interferance_Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Interferance_Speed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Contrast);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600549C RID: 21660 RVA: 0x0002523B File Offset: 0x0002343B
	private void BDBFMPGAKCE()
	{
	}

	// Token: 0x0600549D RID: 21661 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600549E RID: 21662 RVA: 0x001A33AC File Offset: 0x001A15AC
	private void IKKOIKKIDEG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 950f)
			{
				this.HBJJOCHGOPH = 457f;
			}
			this.DKNJGHFLAIF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_Blue_G", this.Interferance_Size);
			this.GKILCDHJFEG().SetFloat("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", this.Interferance_Speed);
			this.NDMPCDHADMJ().SetFloat("Set Trail Zoom Speed", this.Contrast);
			this.JDMJJGEHMJO().SetFloat("#exitmapeditor", this.Fade);
			this.HBLDMJCOAHA().SetVector("settings.enableselectormusic", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 52f, 1103f));
			this.DBOLLHHMKKN().SetTexture("custom", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600549F RID: 21663 RVA: 0x001A2474 File Offset: 0x001A0674
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054A0 RID: 21664 RVA: 0x001A34C1 File Offset: 0x001A16C1
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054A1 RID: 21665 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x060054A2 RID: 21666 RVA: 0x001A34F8 File Offset: 0x001A16F8
	private void DPLLKHHLDBB()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("[ItemsHandler] Item not found:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060054A3 RID: 21667 RVA: 0x001A2474 File Offset: 0x001A0674
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054A4 RID: 21668 RVA: 0x001A3534 File Offset: 0x001A1734
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 388f)
			{
				this.HBJJOCHGOPH = 832f;
			}
			this.EPBAAGMGPAP().SetFloat("Texture2", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("[EditorEvent] Exception: ", this.Interferance_Size);
			this.NLFJGMBCICG().SetFloat("_Tint", this.Interferance_Speed);
			this.JDMJJGEHMJO().SetFloat("\n", this.Contrast);
			this.PEIMCBBHLBJ().SetFloat("action", this.Fade);
			this.CECJJMKLEAK().SetVector("_Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 455f, 455f));
			this.PEIMCBBHLBJ().SetTexture("_Blue_B", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054A5 RID: 21669 RVA: 0x001A2474 File Offset: 0x001A0674
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054A6 RID: 21670 RVA: 0x001A3649 File Offset: 0x001A1849
	private Material JDMJJGEHMJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054A7 RID: 21671 RVA: 0x001A2474 File Offset: 0x001A0674
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054A8 RID: 21672 RVA: 0x001A3680 File Offset: 0x001A1880
	private void LFAFJKJAEEL()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060054A9 RID: 21673 RVA: 0x001A36B9 File Offset: 0x001A18B9
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054AA RID: 21674 RVA: 0x001A36F0 File Offset: 0x001A18F0
	private void LIBGAKMKHJJ()
	{
		this.FPHEBLMINDA = (Resources.Load("<command>") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_ColorDodge");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060054AB RID: 21675 RVA: 0x001A3729 File Offset: 0x001A1929
	private void JMEOGJHCONJ()
	{
		this.FPHEBLMINDA = (Resources.Load("[MapEditor] Importing map: ") as Texture2D);
		this.SCShader = Shader.Find("DeleteButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060054AC RID: 21676 RVA: 0x0002523B File Offset: 0x0002343B
	private void KPBKHFNLNBA()
	{
	}

	// Token: 0x060054AD RID: 21677 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x060054AE RID: 21678 RVA: 0x001A3762 File Offset: 0x001A1962
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054AF RID: 21679 RVA: 0x001A2474 File Offset: 0x001A0674
	private void ALJEADNKJPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054B0 RID: 21680 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060054B1 RID: 21681 RVA: 0x001A3799 File Offset: 0x001A1999
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054B2 RID: 21682 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x060054B3 RID: 21683 RVA: 0x001A37D0 File Offset: 0x001A19D0
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1806f)
			{
				this.HBJJOCHGOPH = 1439f;
			}
			this.HBLDMJCOAHA().SetFloat("2", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat(" - {0}", this.Interferance_Size);
			this.HEINDEMCGIK().SetFloat(".workshop.json", this.Interferance_Speed);
			this.KAFBNOBOIAJ().SetFloat("--------------------------------", this.Contrast);
			this.CECJJMKLEAK().SetFloat("_Value3", this.Fade);
			this.CECJJMKLEAK().SetVector("settings.volume.game", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1833f, 641f));
			this.LNLKMDPHDCC().SetTexture("workshop.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054B4 RID: 21684 RVA: 0x001A38E5 File Offset: 0x001A1AE5
	private Material PEIMCBBHLBJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054B5 RID: 21685 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x060054B6 RID: 21686 RVA: 0x001A391C File Offset: 0x001A1B1C
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054B7 RID: 21687 RVA: 0x001A2474 File Offset: 0x001A0674
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054B8 RID: 21688 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x060054B9 RID: 21689 RVA: 0x001A3954 File Offset: 0x001A1B54
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 87f)
			{
				this.HBJJOCHGOPH = 91f;
			}
			this.DKKBFFHBHJE().SetFloat("_Value1", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("BitsData", this.Interferance_Size);
			this.LNLKMDPHDCC().SetFloat("USE_DIAG_SEARCH", this.Interferance_Speed);
			this.GKILCDHJFEG().SetFloat("_Value", this.Contrast);
			this.MCDGIILBNIF().SetFloat("3d text", this.Fade);
			this.EPBAAGMGPAP().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 841f, 1737f));
			this.DKKBFFHBHJE().SetTexture("Uploader", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054BA RID: 21690 RVA: 0x001A3A6C File Offset: 0x001A1C6C
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1669f)
			{
				this.HBJJOCHGOPH = 1533f;
			}
			this.NLFJGMBCICG().SetFloat("_DistanceParams", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("_TimeX", this.Interferance_Size);
			this.FAIFBBGFAIB().SetFloat("_Glitch", this.Interferance_Speed);
			this.DKKBFFHBHJE().SetFloat("[MapsData] Bad map: ", this.Contrast);
			this.JCPDCGIJKJD().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", this.Fade);
			this.DBOLLHHMKKN().SetVector("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 645f, 1661f));
			this.MCDGIILBNIF().SetTexture("open", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054BB RID: 21691 RVA: 0x001A3B81 File Offset: 0x001A1D81
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054BC RID: 21692 RVA: 0x001A3BB8 File Offset: 0x001A1DB8
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 28f)
			{
				this.HBJJOCHGOPH = 989f;
			}
			this.OHKGGPFGLFD().SetFloat("CameraFilterPack/FX_Hypno", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("player.abstract", this.Interferance_Size);
			this.MNLKBFFKHIE().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", this.Interferance_Speed);
			this.MCDGIILBNIF().SetFloat("_CurveParams", this.Contrast);
			this.NLFJGMBCICG().SetFloat("_FresnelFadePower", this.Fade);
			this.NDMPCDHADMJ().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 590f, 1731f));
			this.JCPDCGIJKJD().SetTexture("_Distortion", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054BD RID: 21693 RVA: 0x001A3CCD File Offset: 0x001A1ECD
	private void ICILLMAKLMI()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("_ForegroundBlurExtrude");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060054BE RID: 21694 RVA: 0x001A3D08 File Offset: 0x001A1F08
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1778f)
			{
				this.HBJJOCHGOPH = 1410f;
			}
			this.MCDGIILBNIF().SetFloat("HighScaleShot", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("Other", this.Interferance_Size);
			this.JCPDCGIJKJD().SetFloat("1", this.Interferance_Speed);
			this.DKKBFFHBHJE().SetFloat("_Distortion", this.Contrast);
			this.HEINDEMCGIK().SetFloat("_MinVelocity", this.Fade);
			this.KAFBNOBOIAJ().SetVector("z", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1678f, 542f));
			this.LMLENGFLEBD().SetTexture("_Value3", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054BF RID: 21695 RVA: 0x001A2474 File Offset: 0x001A0674
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054C0 RID: 21696 RVA: 0x001A3E1D File Offset: 0x001A201D
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054C1 RID: 21697 RVA: 0x001A3E54 File Offset: 0x001A2054
	private void AEMGPJDJGBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("\\") as Texture2D);
		this.SCShader = Shader.Find("speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060054C2 RID: 21698 RVA: 0x001A3E90 File Offset: 0x001A2090
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1555f)
			{
				this.HBJJOCHGOPH = 146f;
			}
			this.DBOLLHHMKKN().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("Error: Someone else(", this.Interferance_Size);
			this.NDMPCDHADMJ().SetFloat("threshold", this.Interferance_Speed);
			this.FAIFBBGFAIB().SetFloat("Editor/", this.Contrast);
			this.NDMPCDHADMJ().SetFloat("Done!", this.Fade);
			this.EPBAAGMGPAP().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1624f, 1668f));
			this.DKNJGHFLAIF().SetTexture(": ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPBAAGMGPAP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054C3 RID: 21699 RVA: 0x001A2474 File Offset: 0x001A0674
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054C4 RID: 21700 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x060054C5 RID: 21701 RVA: 0x001A2474 File Offset: 0x001A0674
	private void KMIEAGOFLBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054C6 RID: 21702 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060054C7 RID: 21703 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x060054C8 RID: 21704 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x060054C9 RID: 21705 RVA: 0x001A3FA5 File Offset: 0x001A21A5
	private void JOHOFNKJDEB()
	{
		this.FPHEBLMINDA = (Resources.Load("LevelNameText") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060054CA RID: 21706 RVA: 0x001A3FE0 File Offset: 0x001A21E0
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 467f)
			{
				this.HBJJOCHGOPH = 629f;
			}
			this.DKKBFFHBHJE().SetFloat("TStart", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("Incoming: \n", this.Interferance_Size);
			this.DKKBFFHBHJE().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", this.Interferance_Speed);
			this.DKKBFFHBHJE().SetFloat("player.neon", this.Contrast);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/3D_Myst", this.Fade);
			this.PEIMCBBHLBJ().SetVector(" = ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 616f, 426f));
			this.DKNJGHFLAIF().SetTexture("_Distortion", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054CB RID: 21707 RVA: 0x001A2474 File Offset: 0x001A0674
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054CC RID: 21708 RVA: 0x001A40F5 File Offset: 0x001A22F5
	private Material HBLDMJCOAHA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054CD RID: 21709 RVA: 0x001A412C File Offset: 0x001A232C
	private void FHGKIOOMMOH()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("Updated!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060054CE RID: 21710 RVA: 0x001A4165 File Offset: 0x001A2365
	private void OHFOLGANOLC()
	{
		this.FPHEBLMINDA = (Resources.Load("GlassesColor") as Texture2D);
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060054CF RID: 21711 RVA: 0x001A41A0 File Offset: 0x001A23A0
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 31f)
			{
				this.HBJJOCHGOPH = 905f;
			}
			this.LMLENGFLEBD().SetFloat("Drop_With_Obj", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("BitsData", this.Interferance_Size);
			this.JDMJJGEHMJO().SetFloat("_ScreenResolution", this.Interferance_Speed);
			this.LMLENGFLEBD().SetFloat("FileMenu", this.Contrast);
			this.DKKBFFHBHJE().SetFloat("[PlayerBase] SetPlayerDistance error: ", this.Fade);
			this.MNLKBFFKHIE().SetVector("No regions available. Are you sure your appid is valid and setup?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 960f, 496f));
			this.EPBAAGMGPAP().SetTexture("EXCEPTION:", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054D0 RID: 21712 RVA: 0x001A2474 File Offset: 0x001A0674
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054D1 RID: 21713 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x060054D2 RID: 21714 RVA: 0x001A42B8 File Offset: 0x001A24B8
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 649f)
			{
				this.HBJJOCHGOPH = 1730f;
			}
			this.JCPDCGIJKJD().SetFloat("#exit", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("id", this.Interferance_Size);
			this.EPCGJFCCAFH().SetFloat("Default UI Material", this.Interferance_Speed);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Contrast);
			this.CECJJMKLEAK().SetFloat("editor.", this.Fade);
			this.HEINDEMCGIK().SetVector("_ClutTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1612f, 54f));
			this.MCDGIILBNIF().SetTexture("Illegal view ID:", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054D3 RID: 21715 RVA: 0x001A43CD File Offset: 0x001A25CD
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054D4 RID: 21716 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x060054D5 RID: 21717 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x060054D6 RID: 21718 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x060054D7 RID: 21719 RVA: 0x001A4404 File Offset: 0x001A2604
	private void DKEHGPPOKEA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value1") as Texture2D);
		this.SCShader = Shader.Find("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060054D8 RID: 21720 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x060054D9 RID: 21721 RVA: 0x001A443D File Offset: 0x001A263D
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_TV_Arcade1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/TV_ARCADE_Fast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060054DA RID: 21722 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x060054DB RID: 21723 RVA: 0x0002523B File Offset: 0x0002343B
	private void KPNKCNJBMKB()
	{
	}

	// Token: 0x060054DC RID: 21724 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x060054DD RID: 21725 RVA: 0x001A4478 File Offset: 0x001A2678
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1958f)
			{
				this.HBJJOCHGOPH = 1747f;
			}
			this.OHKGGPFGLFD().SetFloat("_CurveTex", this.HBJJOCHGOPH);
			this.JDMJJGEHMJO().SetFloat(" ", this.Interferance_Size);
			this.EPBAAGMGPAP().SetFloat("_Bullet_11", this.Interferance_Speed);
			this.NBPKMLMCHFN.SetFloat("Bad parameters for getbool! Use <key> <value>", this.Contrast);
			this.DBOLLHHMKKN().SetFloat("_Value4", this.Fade);
			this.MCDGIILBNIF().SetVector("Mouse Y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1581f, 256f));
			this.DKNJGHFLAIF().SetTexture("Set Sun Lerp Speed", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054DE RID: 21726 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060054DF RID: 21727 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060054E0 RID: 21728 RVA: 0x001A2474 File Offset: 0x001A0674
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054E1 RID: 21729 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x060054E2 RID: 21730 RVA: 0x001A458D File Offset: 0x001A278D
	private void NEFHGMNAPEP()
	{
		this.FPHEBLMINDA = (Resources.Load("Editor/") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Aspiration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060054E3 RID: 21731 RVA: 0x001A45C6 File Offset: 0x001A27C6
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054E4 RID: 21732 RVA: 0x0002523B File Offset: 0x0002343B
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x060054E5 RID: 21733 RVA: 0x001A2474 File Offset: 0x001A0674
	private void IBKFIFHFMFF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054E6 RID: 21734 RVA: 0x001A2474 File Offset: 0x001A0674
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054E7 RID: 21735 RVA: 0x001A2474 File Offset: 0x001A0674
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054E8 RID: 21736 RVA: 0x001A4600 File Offset: 0x001A2800
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1728f)
			{
				this.HBJJOCHGOPH = 1424f;
			}
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack/Distortion_Dream", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("-1", this.Interferance_Size);
			this.NDMPCDHADMJ().SetFloat("<size=24>", this.Interferance_Speed);
			this.MNLKBFFKHIE().SetFloat("_Saturation", this.Contrast);
			this.DBOLLHHMKKN().SetFloat("Fade", this.Fade);
			this.FAIFBBGFAIB().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 738f, 1517f));
			this.FAIFBBGFAIB().SetTexture("_SunColor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054E9 RID: 21737 RVA: 0x001A2474 File Offset: 0x001A0674
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054EA RID: 21738 RVA: 0x001A4715 File Offset: 0x001A2915
	private void PEDHPEMNHBF()
	{
		this.FPHEBLMINDA = (Resources.Load("X") as Texture2D);
		this.SCShader = Shader.Find("_Distance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060054EB RID: 21739 RVA: 0x001A2474 File Offset: 0x001A0674
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054EC RID: 21740 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x060054ED RID: 21741 RVA: 0x001A2474 File Offset: 0x001A0674
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054EE RID: 21742 RVA: 0x001A4750 File Offset: 0x001A2950
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1564f)
			{
				this.HBJJOCHGOPH = 533f;
			}
			this.PEIMCBBHLBJ().SetFloat("#FFDA44CC", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", this.Interferance_Size);
			this.OHKGGPFGLFD().SetFloat("OperationResponse ignored while disconnecting. Code: ", this.Interferance_Speed);
			this.DBOLLHHMKKN().SetFloat("[LevelEditorScene] Print Audio Wave: Start", this.Contrast);
			this.EPBAAGMGPAP().SetFloat("_ScreenResolution", this.Fade);
			this.EPBAAGMGPAP().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1961f, 194f));
			this.JDMJJGEHMJO().SetTexture("/../", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054EF RID: 21743 RVA: 0x001A2474 File Offset: 0x001A0674
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054F0 RID: 21744 RVA: 0x001A4868 File Offset: 0x001A2A68
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1716f)
			{
				this.HBJJOCHGOPH = 1866f;
			}
			this.NBPKMLMCHFN.SetFloat("score:", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("inventory.selected.", this.Interferance_Size);
			this.OIMMPLPBLBK().SetFloat(". Calling ConnectToRegionMaster() is: ", this.Interferance_Speed);
			this.EPCGJFCCAFH().SetFloat("Jump", this.Contrast);
			this.JCPDCGIJKJD().SetFloat("challenges.", this.Fade);
			this.NDMPCDHADMJ().SetVector("Parent ID", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1022f, 279f));
			this.CECJJMKLEAK().SetTexture("BitsData", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054F1 RID: 21745 RVA: 0x001A4980 File Offset: 0x001A2B80
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1479f)
			{
				this.HBJJOCHGOPH = 1499f;
			}
			this.LMLENGFLEBD().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("x", this.Interferance_Size);
			this.NBPKMLMCHFN.SetFloat("_SpawnHeuristic", this.Interferance_Speed);
			this.ADBKPGFMNKO().SetFloat("?", this.Contrast);
			this.OHKGGPFGLFD().SetFloat("Hex value #RRGGBB", this.Fade);
			this.PEIMCBBHLBJ().SetVector("CameraFilterPack/Drawing_Manga2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 132f, 1372f));
			this.FAIFBBGFAIB().SetTexture("DISTORT", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054F2 RID: 21746 RVA: 0x001A4A98 File Offset: 0x001A2C98
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 96f)
			{
				this.HBJJOCHGOPH = 18f;
			}
			this.OHKGGPFGLFD().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("float,0", this.Interferance_Size);
			this.OHKGGPFGLFD().SetFloat("1234332714", this.Interferance_Speed);
			this.FAIFBBGFAIB().SetFloat("input", this.Contrast);
			this.JDMJJGEHMJO().SetFloat("[Left]", this.Fade);
			this.HBLDMJCOAHA().SetVector("sounds/hit_wrong", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 708f, 703f));
			this.MNLKBFFKHIE().SetTexture("Curve texture", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054F3 RID: 21747 RVA: 0x001A4BAD File Offset: 0x001A2DAD
	private void BKIGIIINEDH()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("error");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060054F4 RID: 21748 RVA: 0x001A4BE6 File Offset: 0x001A2DE6
	private void FEGJMDDIDIC()
	{
		this.FPHEBLMINDA = (Resources.Load("&page=") as Texture2D);
		this.SCShader = Shader.Find("_Blue_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060054F5 RID: 21749 RVA: 0x001A45C6 File Offset: 0x001A27C6
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054F6 RID: 21750 RVA: 0x001A4C1F File Offset: 0x001A2E1F
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054F7 RID: 21751 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x060054F8 RID: 21752 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBIGHNGAAID()
	{
	}

	// Token: 0x060054F9 RID: 21753 RVA: 0x001A4C56 File Offset: 0x001A2E56
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("_Distortion") as Texture2D);
		this.SCShader = Shader.Find("_CenterX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060054FA RID: 21754 RVA: 0x001A4C8F File Offset: 0x001A2E8F
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060054FB RID: 21755 RVA: 0x001A2474 File Offset: 0x001A0674
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060054FC RID: 21756 RVA: 0x001A4CC8 File Offset: 0x001A2EC8
	private void IGJPPFJOFKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1152f)
			{
				this.HBJJOCHGOPH = 102f;
			}
			this.MCDGIILBNIF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("[EditorEvent] Exception: ", this.Interferance_Size);
			this.OHKGGPFGLFD().SetFloat("offsets", this.Interferance_Speed);
			this.NBPKMLMCHFN.SetFloat("y", this.Contrast);
			this.HEINDEMCGIK().SetFloat("CameraFilterPack_Glasses_On7", this.Fade);
			this.DKNJGHFLAIF().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1912f, 1439f));
			this.FAIFBBGFAIB().SetTexture("[Up-Right-Down-Left]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054FD RID: 21757 RVA: 0x001A4DE0 File Offset: 0x001A2FE0
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 474f)
			{
				this.HBJJOCHGOPH = 1644f;
			}
			this.DKKBFFHBHJE().SetFloat(".lastCheckpoint.correctScore", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat(" ", this.Interferance_Size);
			this.LMLENGFLEBD().SetFloat("_Value4", this.Interferance_Speed);
			this.JDMJJGEHMJO().SetFloat("_OcclusionBlurTexture", this.Contrast);
			this.OIMMPLPBLBK().SetFloat("SetSatelliteTrailMinVertexDistance", this.Fade);
			this.NDMPCDHADMJ().SetVector("list", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 540f, 864f));
			this.DKNJGHFLAIF().SetTexture("Rock", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054FE RID: 21758 RVA: 0x001A4EF8 File Offset: 0x001A30F8
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1551f)
			{
				this.HBJJOCHGOPH = 542f;
			}
			this.HEINDEMCGIK().SetFloat("_Value", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("_Distortion", this.Interferance_Size);
			this.DKNJGHFLAIF().SetFloat("_Value6", this.Interferance_Speed);
			this.JCPDCGIJKJD().SetFloat(" GameServer:", this.Contrast);
			this.KAFBNOBOIAJ().SetFloat("Joystick1Button2", this.Fade);
			this.EPBAAGMGPAP().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 440f, 1071f));
			this.MCDGIILBNIF().SetTexture(":", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060054FF RID: 21759 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06005500 RID: 21760 RVA: 0x001A2474 File Offset: 0x001A0674
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005501 RID: 21761 RVA: 0x001A500D File Offset: 0x001A320D
	private void CNGAJDBOCLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("Error: Timeout :S");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005502 RID: 21762 RVA: 0x001A5046 File Offset: 0x001A3246
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040008D2 RID: 2258
	public Shader SCShader;

	// Token: 0x040008D3 RID: 2259
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008D4 RID: 2260
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040008D5 RID: 2261
	private Material BJFKDHHMLJH;

	// Token: 0x040008D6 RID: 2262
	[Range(0f, 0.05f)]
	public float Interferance_Size = 0.02f;

	// Token: 0x040008D7 RID: 2263
	[Range(0f, 4f)]
	public float Interferance_Speed = 0.5f;

	// Token: 0x040008D8 RID: 2264
	[Range(0f, 10f)]
	public float Contrast = 1f;

	// Token: 0x040008D9 RID: 2265
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x040008DA RID: 2266
	private Texture2D FPHEBLMINDA;
}
