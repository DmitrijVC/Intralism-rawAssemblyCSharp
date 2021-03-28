using System;
using UnityEngine;

// Token: 0x020000AA RID: 170
[AddComponentMenu("Camera Filter Pack/Drawing/NewCellShading")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_NewCellShading : MonoBehaviour
{
	// Token: 0x06003321 RID: 13089 RVA: 0x0010A388 File Offset: 0x00108588
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 365f)
			{
				this.HBJJOCHGOPH = 1935f;
			}
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("CameraFilterPack/Drawing_EnhancedComics", this.Threshold);
			this.MHBAIEKFBIJ().SetVector(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003322 RID: 13090 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06003323 RID: 13091 RVA: 0x0010A43E File Offset: 0x0010863E
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("Save level before uploading?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003324 RID: 13092 RVA: 0x0010A462 File Offset: 0x00108662
	private void FIJHDKIPENG()
	{
		this.SCShader = Shader.Find("[PlayerBase] SpawnObj error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003325 RID: 13093 RVA: 0x0010A486 File Offset: 0x00108686
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003326 RID: 13094 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003327 RID: 13095 RVA: 0x0010A4DA File Offset: 0x001086DA
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003328 RID: 13096 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003329 RID: 13097 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x0600332A RID: 13098 RVA: 0x0010A511 File Offset: 0x00108711
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600332B RID: 13099 RVA: 0x0010A538 File Offset: 0x00108738
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1786f)
			{
				this.HBJJOCHGOPH = 651f;
			}
			this.MHBAIEKFBIJ().SetFloat("resource", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", this.Threshold);
			this.PDEAHJPOMEF().SetVector("_Value4", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600332C RID: 13100 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x0600332D RID: 13101 RVA: 0x0010A5EE File Offset: 0x001087EE
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600332E RID: 13102 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600332F RID: 13103 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06003330 RID: 13104 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003331 RID: 13105 RVA: 0x0010A612 File Offset: 0x00108812
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_NewCellShading");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003332 RID: 13106 RVA: 0x0010A636 File Offset: 0x00108836
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("ENABLE_EYE_ADAPTATION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003333 RID: 13107 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003334 RID: 13108 RVA: 0x0010A65A File Offset: 0x0010885A
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003335 RID: 13109 RVA: 0x0010A691 File Offset: 0x00108891
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003336 RID: 13110 RVA: 0x0010A6C8 File Offset: 0x001088C8
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003337 RID: 13111 RVA: 0x0010A6FF File Offset: 0x001088FF
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003338 RID: 13112 RVA: 0x0010A736 File Offset: 0x00108936
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003339 RID: 13113 RVA: 0x0010A770 File Offset: 0x00108970
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1738f)
			{
				this.HBJJOCHGOPH = 62f;
			}
			this.FLOHGDECHHH().SetFloat("1", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("Items/", this.Threshold);
			this.KJMECMIGJJA().SetVector("?", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600333A RID: 13114 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x0600333B RID: 13115 RVA: 0x0010A826 File Offset: 0x00108A26
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600333C RID: 13116 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0600333D RID: 13117 RVA: 0x0010A85D File Offset: 0x00108A5D
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Video3D");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600333E RID: 13118 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600333F RID: 13119 RVA: 0x0010A881 File Offset: 0x00108A81
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("_Size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003340 RID: 13120 RVA: 0x0010A8A5 File Offset: 0x00108AA5
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003341 RID: 13121 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x06003342 RID: 13122 RVA: 0x0010A8DC File Offset: 0x00108ADC
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003343 RID: 13123 RVA: 0x0010A914 File Offset: 0x00108B14
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1586f)
			{
				this.HBJJOCHGOPH = 1258f;
			}
			this.KOHGPKOFEJO().SetFloat("StartButton", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("[SoundManager] Loaded skin audio", this.Threshold);
			this.NBPKMLMCHFN.SetVector("hidden", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003344 RID: 13124 RVA: 0x0010A9CC File Offset: 0x00108BCC
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1680f)
			{
				this.HBJJOCHGOPH = 1905f;
			}
			this.LENEJAGLCNL().SetFloat("_CenterY", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_OcclusionTexture", this.Threshold);
			this.LPDOGGFOBDH().SetVector("_Screen", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003345 RID: 13125 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003346 RID: 13126 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06003347 RID: 13127 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003348 RID: 13128 RVA: 0x0010AA82 File Offset: 0x00108C82
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003349 RID: 13129 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x0600334A RID: 13130 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600334B RID: 13131 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600334C RID: 13132 RVA: 0x0010AABC File Offset: 0x00108CBC
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 999f)
			{
				this.HBJJOCHGOPH = 458f;
			}
			this.KJMECMIGJJA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", this.Threshold);
			this.NBPKMLMCHFN.SetVector("_Visualize", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600334D RID: 13133 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x0600334E RID: 13134 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600334F RID: 13135 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003350 RID: 13136 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003351 RID: 13137 RVA: 0x0010AB74 File Offset: 0x00108D74
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 455f)
			{
				this.HBJJOCHGOPH = 1479f;
			}
			this.KJMECMIGJJA().SetFloat(".png", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("?page=addtip", this.Threshold);
			this.LPDOGGFOBDH().SetVector("DPADVER", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003352 RID: 13138 RVA: 0x0010AC2A File Offset: 0x00108E2A
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("-1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003353 RID: 13139 RVA: 0x0010AC50 File Offset: 0x00108E50
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 464f)
			{
				this.HBJJOCHGOPH = 503f;
			}
			this.KEMJNOMIPHN().SetFloat("_WaveIntensity", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("_RampOffset", this.Threshold);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/TV_Noise", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003354 RID: 13140 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003355 RID: 13141 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003356 RID: 13142 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06003357 RID: 13143 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06003358 RID: 13144 RVA: 0x0010AD06 File Offset: 0x00108F06
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003359 RID: 13145 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600335A RID: 13146 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x0600335B RID: 13147 RVA: 0x0010AD3D File Offset: 0x00108F3D
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("ReplyMatch is false! ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600335C RID: 13148 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600335D RID: 13149 RVA: 0x0010AD61 File Offset: 0x00108F61
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("_SizeY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600335E RID: 13150 RVA: 0x0010AD85 File Offset: 0x00108F85
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("setstring");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600335F RID: 13151 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06003360 RID: 13152 RVA: 0x0010ADAC File Offset: 0x00108FAC
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 655f)
			{
				this.HBJJOCHGOPH = 1758f;
			}
			this.PDEAHJPOMEF().SetFloat("pointBuffer", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat(".", this.Threshold);
			this.MFHPKGICPIO().SetVector("null", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003361 RID: 13153 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06003362 RID: 13154 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06003363 RID: 13155 RVA: 0x0010AE62 File Offset: 0x00109062
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003364 RID: 13156 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06003365 RID: 13157 RVA: 0x0010AE9C File Offset: 0x0010909C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 561f)
			{
				this.HBJJOCHGOPH = 1050f;
			}
			this.NMDBCDFPGOK().SetFloat(": ", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat(".mp3", this.Threshold);
			this.NMDBCDFPGOK().SetVector("_WhiteBalance", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003366 RID: 13158 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003367 RID: 13159 RVA: 0x0010AF54 File Offset: 0x00109154
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 131f)
			{
				this.HBJJOCHGOPH = 357f;
			}
			this.KJMECMIGJJA().SetFloat("Joystick1Button6", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("Save", this.Threshold);
			this.MHBAIEKFBIJ().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003368 RID: 13160 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003369 RID: 13161 RVA: 0x0010B00C File Offset: 0x0010920C
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
			this.NBPKMLMCHFN.SetFloat("_Threshold", this.Threshold);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600336A RID: 13162 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600336B RID: 13163 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600336C RID: 13164 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600336D RID: 13165 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x0600336E RID: 13166 RVA: 0x0010B0C4 File Offset: 0x001092C4
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 171f)
			{
				this.HBJJOCHGOPH = 804f;
			}
			this.KOHGPKOFEJO().SetFloat(". Prefab must have a PhotonView component.", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("/", this.Threshold);
			this.FEAEGGCNIAA().SetVector(".", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600336F RID: 13167 RVA: 0x0010B17A File Offset: 0x0010937A
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003370 RID: 13168 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06003371 RID: 13169 RVA: 0x0010B1B1 File Offset: 0x001093B1
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003372 RID: 13170 RVA: 0x0010B1E8 File Offset: 0x001093E8
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("st");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003373 RID: 13171 RVA: 0x0010B20C File Offset: 0x0010940C
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003374 RID: 13172 RVA: 0x0010B243 File Offset: 0x00109443
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003375 RID: 13173 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003376 RID: 13174 RVA: 0x0010B243 File Offset: 0x00109443
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003377 RID: 13175 RVA: 0x0010B27A File Offset: 0x0010947A
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003378 RID: 13176 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003379 RID: 13177 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x0600337B RID: 13179 RVA: 0x0010B2CF File Offset: 0x001094CF
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("_BlurParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600337C RID: 13180 RVA: 0x0010A736 File Offset: 0x00108936
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600337D RID: 13181 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x0600337E RID: 13182 RVA: 0x0010B2F3 File Offset: 0x001094F3
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600337F RID: 13183 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003380 RID: 13184 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06003381 RID: 13185 RVA: 0x0010B318 File Offset: 0x00109518
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1798f)
			{
				this.HBJJOCHGOPH = 1341f;
			}
			this.DBOLLHHMKKN().SetFloat("_Value", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("_ContrastGainGamma", this.Threshold);
			this.MHBAIEKFBIJ().SetVector("mapselector.tags.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003382 RID: 13186 RVA: 0x0010B3CE File Offset: 0x001095CE
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("[Left]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003383 RID: 13187 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06003384 RID: 13188 RVA: 0x0010B3F2 File Offset: 0x001095F2
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("player.xp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003385 RID: 13189 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003386 RID: 13190 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06003387 RID: 13191 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06003388 RID: 13192 RVA: 0x0010B416 File Offset: 0x00109616
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("#failed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003389 RID: 13193 RVA: 0x0010B43A File Offset: 0x0010963A
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("mapselector.filter.subscribedonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600338A RID: 13194 RVA: 0x0010B45E File Offset: 0x0010965E
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600338B RID: 13195 RVA: 0x0010B498 File Offset: 0x00109698
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 976f)
			{
				this.HBJJOCHGOPH = 312f;
			}
			this.MHBAIEKFBIJ().SetFloat("CameraFilterPack/Edge_Neon", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("R1", this.Threshold);
			this.MFHPKGICPIO().SetVector("new round", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600338C RID: 13196 RVA: 0x0010B54E File Offset: 0x0010974E
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("Set particles start speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600338D RID: 13197 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x0600338E RID: 13198 RVA: 0x0010B572 File Offset: 0x00109772
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

	// Token: 0x0600338F RID: 13199 RVA: 0x0010B5AC File Offset: 0x001097AC
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1272f)
			{
				this.HBJJOCHGOPH = 73f;
			}
			this.CEKJODEAMGB().SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("Feb", this.Threshold);
			this.ADBKPGFMNKO().SetVector("Keeping GameObject in the scene: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003390 RID: 13200 RVA: 0x0010B664 File Offset: 0x00109864
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1507f)
			{
				this.HBJJOCHGOPH = 302f;
			}
			this.FLOHGDECHHH().SetFloat("0.00", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("maps.", this.Threshold);
			this.JLHLHKPHDFO().SetVector("arc", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003391 RID: 13201 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003392 RID: 13202 RVA: 0x0010B71A File Offset: 0x0010991A
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("_EmissionGain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003393 RID: 13203 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void NDDNJNCINDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003394 RID: 13204 RVA: 0x0010A4BD File Offset: 0x001086BD
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003395 RID: 13205 RVA: 0x0010B73E File Offset: 0x0010993E
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040005BD RID: 1469
	public Shader SCShader;

	// Token: 0x040005BE RID: 1470
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005BF RID: 1471
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040005C0 RID: 1472
	private Material BJFKDHHMLJH;

	// Token: 0x040005C1 RID: 1473
	[Range(0f, 1f)]
	public float Threshold = 0.2f;
}
