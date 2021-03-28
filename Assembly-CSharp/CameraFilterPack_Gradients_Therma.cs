using System;
using UnityEngine;

// Token: 0x020000EA RID: 234
[AddComponentMenu("Camera Filter Pack/Gradients/Thermal")]
[ExecuteInEditMode]
public class CameraFilterPack_Gradients_Therma : MonoBehaviour
{
	// Token: 0x06004814 RID: 18452 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06004815 RID: 18453 RVA: 0x00160A97 File Offset: 0x0015EC97
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004816 RID: 18454 RVA: 0x00160ACE File Offset: 0x0015ECCE
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004817 RID: 18455 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004818 RID: 18456 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004819 RID: 18457 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600481A RID: 18458 RVA: 0x00160B24 File Offset: 0x0015ED24
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 264f)
			{
				this.HBJJOCHGOPH = 1128f;
			}
			this.LPMLLJKMAMP().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_Value7", this.Switch);
			this.ABHDNGIHBKE().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", this.Fade);
			this.GCDFNHMJMIP().SetVector("EndlessLoopsScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1729f, 1254f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600481B RID: 18459 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x0600481C RID: 18460 RVA: 0x00160BF7 File Offset: 0x0015EDF7
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600481D RID: 18461 RVA: 0x00160C1C File Offset: 0x0015EE1C
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600481E RID: 18462 RVA: 0x00160C54 File Offset: 0x0015EE54
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1970f)
			{
				this.HBJJOCHGOPH = 241f;
			}
			this.ABHDNGIHBKE().SetFloat(" : ", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("player.bluelifering", this.Switch);
			this.PLBEJJIHFPB().SetFloat("VoteDownToggle", this.Fade);
			this.CEKJODEAMGB().SetVector("MenuScene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1643f, 566f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600481F RID: 18463 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06004820 RID: 18464 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004821 RID: 18465 RVA: 0x00160D28 File Offset: 0x0015EF28
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 77f)
			{
				this.HBJJOCHGOPH = 892f;
			}
			this.HNICHJCGJOC().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_ChromaticAberration", this.Switch);
			this.PDEAHJPOMEF().SetFloat("clicked ", this.Fade);
			this.FEAEGGCNIAA().SetVector("checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 824f, 927f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004822 RID: 18466 RVA: 0x00160DFC File Offset: 0x0015EFFC
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 643f)
			{
				this.HBJJOCHGOPH = 786f;
			}
			this.NBMPPNFKFLB().SetFloat("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("EventTimeInputField", this.Switch);
			this.NBMPPNFKFLB().SetFloat("Failed to 'network-remove' GameObject because it's null.", this.Fade);
			this.CEKJODEAMGB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1266f, 266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004823 RID: 18467 RVA: 0x00160ED0 File Offset: 0x0015F0D0
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 665f)
			{
				this.HBJJOCHGOPH = 1050f;
			}
			this.FEAEGGCNIAA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_ScreenResolution", this.Switch);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Fade);
			this.NBMPPNFKFLB().SetVector("http://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1933f, 483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004824 RID: 18468 RVA: 0x00160FA4 File Offset: 0x0015F1A4
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 670f)
			{
				this.HBJJOCHGOPH = 831f;
			}
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("Fade", this.Switch);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Fade);
			this.CEKJODEAMGB().SetVector("<color=#{0}>{1}</color>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1833f, 1642f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004825 RID: 18469 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06004826 RID: 18470 RVA: 0x00161078 File Offset: 0x0015F278
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 552f)
			{
				this.HBJJOCHGOPH = 694f;
			}
			this.GCDFNHMJMIP().SetFloat("SaveButton", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("finished", this.Switch);
			this.PDEAHJPOMEF().SetFloat("sprite", this.Fade);
			this.AELJLBOJAIL().SetVector("EventData0DropDownList", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1340f, 1029f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004827 RID: 18471 RVA: 0x00160BF7 File Offset: 0x0015EDF7
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004828 RID: 18472 RVA: 0x0016114C File Offset: 0x0015F34C
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 889f)
			{
				this.HBJJOCHGOPH = 402f;
			}
			this.ABHDNGIHBKE().SetFloat("_Value", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("IntraTime", this.Switch);
			this.FLOHGDECHHH().SetFloat("_Value3", this.Fade);
			this.PLBEJJIHFPB().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1648f, 1983f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004829 RID: 18473 RVA: 0x00160BF7 File Offset: 0x0015EDF7
	private void Start()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600482A RID: 18474 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600482B RID: 18475 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600482C RID: 18476 RVA: 0x00160BF7 File Offset: 0x0015EDF7
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600482D RID: 18477 RVA: 0x0016121F File Offset: 0x0015F41F
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600482E RID: 18478 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600482F RID: 18479 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06004830 RID: 18480 RVA: 0x00161258 File Offset: 0x0015F458
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 991f)
			{
				this.HBJJOCHGOPH = 1155f;
			}
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Edge_Golden", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("RPCs can only be sent in rooms. Call of \"", this.Switch);
			this.NBMPPNFKFLB().SetFloat("_NeighborMaxTex", this.Fade);
			this.NDMPCDHADMJ().SetVector("AudioSampler", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 979f, 1723f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004831 RID: 18481 RVA: 0x00160BF7 File Offset: 0x0015EDF7
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004832 RID: 18482 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004833 RID: 18483 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004834 RID: 18484 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06004835 RID: 18485 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004837 RID: 18487 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06004838 RID: 18488 RVA: 0x00161360 File Offset: 0x0015F560
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 893f)
			{
				this.HBJJOCHGOPH = 1317f;
			}
			this.NDMPCDHADMJ().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("Fade", this.Switch);
			this.FEAEGGCNIAA().SetFloat("speed", this.Fade);
			this.NBMPPNFKFLB().SetVector("LevelEditor/CustomEventEditor-", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 520f, 967f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004839 RID: 18489 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x0600483A RID: 18490 RVA: 0x00161433 File Offset: 0x0015F633
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600483B RID: 18491 RVA: 0x00161458 File Offset: 0x0015F658
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 616f)
			{
				this.HBJJOCHGOPH = 1420f;
			}
			this.FLOHGDECHHH().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("_Value7", this.Switch);
			this.NBPKMLMCHFN.SetFloat("y", this.Fade);
			this.AELJLBOJAIL().SetVector("_SprTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 635f, 193f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600483C RID: 18492 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x0600483D RID: 18493 RVA: 0x0016152C File Offset: 0x0015F72C
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1636f)
			{
				this.HBJJOCHGOPH = 579f;
			}
			this.KEMAALEODNH().SetFloat("AVG Misses:", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_Red_C", this.Switch);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.Fade);
			this.HNICHJCGJOC().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 817f, 354f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600483E RID: 18494 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x0600483F RID: 18495 RVA: 0x00161600 File Offset: 0x0015F800
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1040f)
			{
				this.HBJJOCHGOPH = 865f;
			}
			this.NBMPPNFKFLB().SetFloat("settings_bindings_controller_type", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("CrosshairOpacitySlider", this.Switch);
			this.GCDFNHMJMIP().SetFloat("float", this.Fade);
			this.NBMPPNFKFLB().SetVector("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1522f, 1486f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004840 RID: 18496 RVA: 0x001616D3 File Offset: 0x0015F8D3
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004841 RID: 18497 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06004842 RID: 18498 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004843 RID: 18499 RVA: 0x0016170A File Offset: 0x0015F90A
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004844 RID: 18500 RVA: 0x00161741 File Offset: 0x0015F941
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06004845 RID: 18501 RVA: 0x00161778 File Offset: 0x0015F978
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

	// Token: 0x06004846 RID: 18502 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06004847 RID: 18503 RVA: 0x001617AF File Offset: 0x0015F9AF
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004848 RID: 18504 RVA: 0x001617E8 File Offset: 0x0015F9E8
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Switch);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004849 RID: 18505 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x0600484A RID: 18506 RVA: 0x001618BC File Offset: 0x0015FABC
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1427f)
			{
				this.HBJJOCHGOPH = 1144f;
			}
			this.AELJLBOJAIL().SetFloat("float,0", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("BadgeText", this.Switch);
			this.BFGNMFCNDBC().SetFloat("Joystick1Button2", this.Fade);
			this.CEKJODEAMGB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 492f, 1600f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600484B RID: 18507 RVA: 0x00161990 File Offset: 0x0015FB90
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 68f)
			{
				this.HBJJOCHGOPH = 328f;
			}
			this.FEAEGGCNIAA().SetFloat("#tryagain", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("event", this.Switch);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.Fade);
			this.EPCGJFCCAFH().SetVector("11", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1966f, 688f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600484C RID: 18508 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0600484D RID: 18509 RVA: 0x00161A64 File Offset: 0x0015FC64
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 765f)
			{
				this.HBJJOCHGOPH = 1135f;
			}
			this.FEAEGGCNIAA().SetFloat("GridDataStoryboard", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_Value4", this.Switch);
			this.FEAEGGCNIAA().SetFloat(" not exist", this.Fade);
			this.NBPKMLMCHFN.SetVector("_Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 503f, 433f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600484E RID: 18510 RVA: 0x00161B38 File Offset: 0x0015FD38
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 135f)
			{
				this.HBJJOCHGOPH = 1864f;
			}
			this.AELJLBOJAIL().SetFloat("_SoftZDistance", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Blend2Camera_HardMix", this.Switch);
			this.EPCGJFCCAFH().SetFloat("EventData0DropDownList", this.Fade);
			this.BFGNMFCNDBC().SetVector("Obtain test Item", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 15f, 1308f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600484F RID: 18511 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06004850 RID: 18512 RVA: 0x00161433 File Offset: 0x0015F633
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004851 RID: 18513 RVA: 0x00161C0B File Offset: 0x0015FE0B
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004852 RID: 18514 RVA: 0x00161C44 File Offset: 0x0015FE44
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1317f)
			{
				this.HBJJOCHGOPH = 985f;
			}
			this.NBMPPNFKFLB().SetFloat("DifficultyBG", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("[MapEditor] Updating top menu", this.Switch);
			this.AELJLBOJAIL().SetFloat("id", this.Fade);
			this.ABHDNGIHBKE().SetVector("Loss ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 956f, 1493f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004853 RID: 18515 RVA: 0x00161D17 File Offset: 0x0015FF17
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004854 RID: 18516 RVA: 0x00160BF7 File Offset: 0x0015EDF7
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004855 RID: 18517 RVA: 0x00161D50 File Offset: 0x0015FF50
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 318f)
			{
				this.HBJJOCHGOPH = 600f;
			}
			this.CEKJODEAMGB().SetFloat("RB", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("Fade", this.Switch);
			this.PLBEJJIHFPB().SetFloat("maphash", this.Fade);
			this.NBMPPNFKFLB().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 7f, 1934f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004856 RID: 18518 RVA: 0x00161E23 File Offset: 0x00160023
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004857 RID: 18519 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004858 RID: 18520 RVA: 0x00161433 File Offset: 0x0015F633
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004859 RID: 18521 RVA: 0x00161E5A File Offset: 0x0016005A
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600485A RID: 18522 RVA: 0x00161E91 File Offset: 0x00160091
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600485B RID: 18523 RVA: 0x00161EC8 File Offset: 0x001600C8
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1316f)
			{
				this.HBJJOCHGOPH = 926f;
			}
			this.GCDFNHMJMIP().SetFloat("#ok", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat(" ", this.Switch);
			this.FLOHGDECHHH().SetFloat("_MainTex2", this.Fade);
			this.BFGNMFCNDBC().SetVector("_SSAO", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 739f, 387f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600485C RID: 18524 RVA: 0x00161F9C File Offset: 0x0016019C
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1431f)
			{
				this.HBJJOCHGOPH = 1721f;
			}
			this.EPCGJFCCAFH().SetFloat("Set sun beat detection sensitivity", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_ContrastGainGamma", this.Switch);
			this.NDMPCDHADMJ().SetFloat("_ScreenResolution", this.Fade);
			this.NBPKMLMCHFN.SetVector("11", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 223f, 1351f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600485D RID: 18525 RVA: 0x0016206F File Offset: 0x0016026F
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600485E RID: 18526 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x0600485F RID: 18527 RVA: 0x001620A8 File Offset: 0x001602A8
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1657f)
			{
				this.HBJJOCHGOPH = 443f;
			}
			this.CEKJODEAMGB().SetFloat("challenges/", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("maps.", this.Switch);
			this.BFGNMFCNDBC().SetFloat("_NeighbourMaxTex", this.Fade);
			this.FEAEGGCNIAA().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 855f, 1266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004860 RID: 18528 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004861 RID: 18529 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004862 RID: 18530 RVA: 0x00161433 File Offset: 0x0015F633
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004863 RID: 18531 RVA: 0x0016217B File Offset: 0x0016037B
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004864 RID: 18532 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06004865 RID: 18533 RVA: 0x00160B05 File Offset: 0x0015ED05
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004866 RID: 18534 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x040007A0 RID: 1952
	public Shader SCShader;

	// Token: 0x040007A1 RID: 1953
	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_Therma";

	// Token: 0x040007A2 RID: 1954
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007A3 RID: 1955
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007A4 RID: 1956
	private Material BJFKDHHMLJH;

	// Token: 0x040007A5 RID: 1957
	[Range(0f, 1f)]
	public float Switch = 1f;

	// Token: 0x040007A6 RID: 1958
	[Range(0f, 1f)]
	public float Fade = 1f;
}
