using System;
using UnityEngine;

// Token: 0x02000089 RID: 137
[AddComponentMenu("Camera Filter Pack/Distortion/Dream2")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Dream2 : MonoBehaviour
{
	// Token: 0x06002741 RID: 10049 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06002742 RID: 10050 RVA: 0x000DC36C File Offset: 0x000DA56C
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002743 RID: 10051 RVA: 0x000DC390 File Offset: 0x000DA590
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002744 RID: 10052 RVA: 0x000DC3B0 File Offset: 0x000DA5B0
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 569f)
			{
				this.HBJJOCHGOPH = 1156f;
			}
			this.GJHLADDCMFF().SetFloat("Loading inventory", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("[GameScene] Checkpoints count: ", this.Speed);
			this.BLMPMOIDGMG().SetFloat("CameraFilterPack/EyesVision_1", this.Distortion);
			this.HKHBBBFLGJH().SetVector("[Up-Right-Left]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 220f, 694f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002745 RID: 10053 RVA: 0x000DC484 File Offset: 0x000DA684
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 296f)
			{
				this.HBJJOCHGOPH = 1514f;
			}
			this.HKHBBBFLGJH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("_Value3", this.Speed);
			this.HKHBBBFLGJH().SetFloat("#{0:00} '{1}'{2} {3}", this.Distortion);
			this.KGOLDDBHIFN().SetVector(" but this PhotonView does not exist! View was/is ours.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1702f, 885f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002746 RID: 10054 RVA: 0x000DC557 File Offset: 0x000DA757
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002747 RID: 10055 RVA: 0x000DC390 File Offset: 0x000DA590
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002748 RID: 10056 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06002749 RID: 10057 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x000DC58E File Offset: 0x000DA78E
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("menuVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x000DC5B2 File Offset: 0x000DA7B2
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600274C RID: 10060 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x0600274D RID: 10061 RVA: 0x000DC5E9 File Offset: 0x000DA7E9
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x000DC620 File Offset: 0x000DA820
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("[MapEditor] Loading music...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600274F RID: 10063 RVA: 0x000DC644 File Offset: 0x000DA844
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find(" SecondsBeforeRespawn: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x000DC668 File Offset: 0x000DA868
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Dream2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x000DC68C File Offset: 0x000DA88C
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("\" call.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x000DC6B0 File Offset: 0x000DA8B0
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 373f)
			{
				this.HBJJOCHGOPH = 1443f;
			}
			this.HEHKGPKLAKK().SetFloat("speed", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("SetBGColor", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Offsets", this.Distortion);
			this.OGMEGHKECAH().SetVector("Joystick1Button0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 426f, 1830f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x000DC783 File Offset: 0x000DA983
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002754 RID: 10068 RVA: 0x000DC390 File Offset: 0x000DA590
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002755 RID: 10069 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06002756 RID: 10070 RVA: 0x000DC7A7 File Offset: 0x000DA9A7
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("#rt");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002757 RID: 10071 RVA: 0x000DC7CB File Offset: 0x000DA9CB
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002758 RID: 10072 RVA: 0x000DC802 File Offset: 0x000DAA02
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002759 RID: 10073 RVA: 0x000DC839 File Offset: 0x000DAA39
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("_Sat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600275A RID: 10074 RVA: 0x000DC85D File Offset: 0x000DAA5D
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("Item ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600275B RID: 10075 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600275C RID: 10076 RVA: 0x000DC884 File Offset: 0x000DAA84
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1498f)
			{
				this.HBJJOCHGOPH = 1311f;
			}
			this.DNLMFEGJJDD().SetFloat("Set Crosshair Emission", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("\n", this.Speed);
			this.EOCCJGIGEGJ().SetFloat("_VelocityScale", this.Distortion);
			this.KGOLDDBHIFN().SetVector("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1991f, 172f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600275D RID: 10077 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x0600275E RID: 10078 RVA: 0x000DC390 File Offset: 0x000DA590
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600275F RID: 10079 RVA: 0x000DC957 File Offset: 0x000DAB57
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002760 RID: 10080 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06002761 RID: 10081 RVA: 0x000DC98E File Offset: 0x000DAB8E
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002762 RID: 10082 RVA: 0x000DC9C5 File Offset: 0x000DABC5
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002763 RID: 10083 RVA: 0x000DC390 File Offset: 0x000DA590
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002764 RID: 10084 RVA: 0x000DC390 File Offset: 0x000DA590
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002765 RID: 10085 RVA: 0x000DC390 File Offset: 0x000DA590
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002766 RID: 10086 RVA: 0x000DC9FC File Offset: 0x000DABFC
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 323f)
			{
				this.HBJJOCHGOPH = 1653f;
			}
			this.NBPKMLMCHFN.SetFloat("float,0", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("Reload Maps", this.Speed);
			this.NBPKMLMCHFN.SetFloat("menu.playedsolo", this.Distortion);
			this.BLMPMOIDGMG().SetVector("Loss ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 253f, 1133f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002767 RID: 10087 RVA: 0x000DCAD0 File Offset: 0x000DACD0
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 962f)
			{
				this.HBJJOCHGOPH = 448f;
			}
			this.IGIAPKPKGPK().SetFloat("Set Trail Zoom Speed", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("id", this.Speed);
			this.LPMLLJKMAMP().SetFloat("float,1", this.Distortion);
			this.DNLMFEGJJDD().SetVector("_NoOuterClip", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1054f, 496f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002768 RID: 10088 RVA: 0x000DCBA4 File Offset: 0x000DADA4
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 195f)
			{
				this.HBJJOCHGOPH = 373f;
			}
			this.OKJOKHGJHGF().SetFloat("_Blue_R", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("color", this.Speed);
			this.HEHKGPKLAKK().SetFloat("SfxVolumeSlider", this.Distortion);
			this.LPMLLJKMAMP().SetVector("CameraFilterPack/Blend2Camera_BlueScreen", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 101f, 336f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002769 RID: 10089 RVA: 0x000DCC77 File Offset: 0x000DAE77
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600276A RID: 10090 RVA: 0x000DC390 File Offset: 0x000DA590
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600276B RID: 10091 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x0600276C RID: 10092 RVA: 0x000DCCAE File Offset: 0x000DAEAE
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("No child content found, exiting..");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x0600276D RID: 10093 RVA: 0x000DCCD2 File Offset: 0x000DAED2
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

	// Token: 0x0600276E RID: 10094 RVA: 0x000DCD0C File Offset: 0x000DAF0C
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1806f)
			{
				this.HBJJOCHGOPH = 701f;
			}
			this.DNLMFEGJJDD().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("#startofflinemessage", this.Speed);
			this.OKJOKHGJHGF().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", this.Distortion);
			this.GJHLADDCMFF().SetVector("title", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 989f, 867f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600276F RID: 10095 RVA: 0x000DCDDF File Offset: 0x000DAFDF
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002770 RID: 10096 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06002771 RID: 10097 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06002773 RID: 10099 RVA: 0x000DCE2C File Offset: 0x000DB02C
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("_Level");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x000DCE50 File Offset: 0x000DB050
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 477f)
			{
				this.HBJJOCHGOPH = 1166f;
			}
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/BlurTiltShift_Hole", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("1", this.Speed);
			this.BLMPMOIDGMG().SetFloat("Anomaly_With_Obj", this.Distortion);
			this.NBPKMLMCHFN.SetVector("HiddenToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1847f, 21f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x000DCF24 File Offset: 0x000DB124
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1386f)
			{
				this.HBJJOCHGOPH = 1915f;
			}
			this.LDNADDJMIPK().SetFloat("HiddenToggle", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("_ScreenResolution", this.Speed);
			this.KJMECMIGJJA().SetFloat("InventoryContent", this.Distortion);
			this.DNLMFEGJJDD().SetVector("GameScene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1727f, 1134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06002777 RID: 10103 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06002778 RID: 10104 RVA: 0x000DCFF7 File Offset: 0x000DB1F7
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x000DC390 File Offset: 0x000DA590
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600277A RID: 10106 RVA: 0x000DD02E File Offset: 0x000DB22E
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("hand");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x000DC390 File Offset: 0x000DA590
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x000DD054 File Offset: 0x000DB254
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1867f)
			{
				this.HBJJOCHGOPH = 986f;
			}
			this.DNLMFEGJJDD().SetFloat("settings.enableselectormusic", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("_ChromaticAberration", this.Speed);
			this.NBPKMLMCHFN.SetFloat("RoomNameText", this.Distortion);
			this.OKJOKHGJHGF().SetVector("CameraFilterPack/TV_ARCADE_Fast", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1910f, 1488f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600277D RID: 10109 RVA: 0x000DD128 File Offset: 0x000DB328
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
			this.NBPKMLMCHFN.SetFloat("_Speed", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x000DC390 File Offset: 0x000DA590
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x000DC390 File Offset: 0x000DA590
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002781 RID: 10113 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x000DD1FC File Offset: 0x000DB3FC
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1392f)
			{
				this.HBJJOCHGOPH = 1076f;
			}
			this.HKGAONMOBMH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/Edge_Neon", this.Speed);
			this.EOCCJGIGEGJ().SetFloat("ComboScoreText", this.Distortion);
			this.OGMEGHKECAH().SetVector(";", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 623f, 1106f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002783 RID: 10115 RVA: 0x000DD2D0 File Offset: 0x000DB4D0
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1211f)
			{
				this.HBJJOCHGOPH = 1876f;
			}
			this.HKGAONMOBMH().SetFloat("_Shadow", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("\n\n• ", this.Speed);
			this.NBPKMLMCHFN.SetFloat(") error: ", this.Distortion);
			this.HKHBBBFLGJH().SetVector("GlassesColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1091f, 960f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06002785 RID: 10117 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06002786 RID: 10118 RVA: 0x000DD3A3 File Offset: 0x000DB5A3
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x000DD3DA File Offset: 0x000DB5DA
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x000DD414 File Offset: 0x000DB614
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1656f)
			{
				this.HBJJOCHGOPH = 270f;
			}
			this.HKGAONMOBMH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.Speed);
			this.GCDFNHMJMIP().SetFloat(":", this.Distortion);
			this.LDNADDJMIPK().SetVector("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1300f, 14f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x000DD4E8 File Offset: 0x000DB6E8
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1077f)
			{
				this.HBJJOCHGOPH = 1448f;
			}
			this.KGOLDDBHIFN().SetFloat("_FarCamera", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_TimeX", this.Speed);
			this.IGIAPKPKGPK().SetFloat("Could not find RPC with index: ", this.Distortion);
			this.LPMLLJKMAMP().SetVector("_Color_G", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 842f, 1138f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x000DC390 File Offset: 0x000DA590
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600278B RID: 10123 RVA: 0x000DD5BB File Offset: 0x000DB7BB
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600278D RID: 10125 RVA: 0x000DC390 File Offset: 0x000DA590
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600278E RID: 10126 RVA: 0x000DD5F2 File Offset: 0x000DB7F2
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x000DC36C File Offset: 0x000DA56C
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002790 RID: 10128 RVA: 0x000DC390 File Offset: 0x000DA590
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06002792 RID: 10130 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x000DD629 File Offset: 0x000DB829
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002794 RID: 10132 RVA: 0x000DD660 File Offset: 0x000DB860
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 638f)
			{
				this.HBJJOCHGOPH = 988f;
			}
			this.OGMEGHKECAH().SetFloat("Fade", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("Drop_Near", this.Speed);
			this.NBPKMLMCHFN.SetFloat("plogs", this.Distortion);
			this.DNLMFEGJJDD().SetVector("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1226f, 559f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002795 RID: 10133 RVA: 0x000DC390 File Offset: 0x000DA590
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002796 RID: 10134 RVA: 0x000DD733 File Offset: 0x000DB933
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("Inside cells:\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002797 RID: 10135 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06002798 RID: 10136 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06002799 RID: 10137 RVA: 0x000DC390 File Offset: 0x000DA590
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600279A RID: 10138 RVA: 0x000DD757 File Offset: 0x000DB957
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("mapselector.orderby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600279B RID: 10139 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x0600279C RID: 10140 RVA: 0x000DD77B File Offset: 0x000DB97B
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("caret");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040004E8 RID: 1256
	public Shader SCShader;

	// Token: 0x040004E9 RID: 1257
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004EA RID: 1258
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004EB RID: 1259
	private Material BJFKDHHMLJH;

	// Token: 0x040004EC RID: 1260
	[Range(0f, 100f)]
	public float Distortion = 6f;

	// Token: 0x040004ED RID: 1261
	[Range(0f, 32f)]
	public float Speed = 5f;
}
