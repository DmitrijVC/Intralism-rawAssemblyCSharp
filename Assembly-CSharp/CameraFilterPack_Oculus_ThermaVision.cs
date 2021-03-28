using System;
using UnityEngine;

// Token: 0x020000FE RID: 254
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/ThermaVision")]
public class CameraFilterPack_Oculus_ThermaVision : MonoBehaviour
{
	// Token: 0x06004F75 RID: 20341 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F76 RID: 20342 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004F77 RID: 20343 RVA: 0x0018D369 File Offset: 0x0018B569
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Hell_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004F78 RID: 20344 RVA: 0x0018D390 File Offset: 0x0018B590
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1367f)
			{
				this.HBJJOCHGOPH = 1776f;
			}
			this.BAGICADFBAB().SetFloat("#tryagain", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("Set particles gravity", this.Therma_Variation);
			this.INOBFNCKFGK().SetFloat("_PColor2", this.OGLODCDJJLB);
			this.BLMPMOIDGMG().SetFloat("_DepthLevel", this.ALELLLFCDBF);
			this.OOMFJGPAOKL().SetFloat("EventTimeInputField", this.NFDIFLHGJKB);
			this.LPMLLJKMAMP().SetVector("Left Click", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1849f, 1972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F79 RID: 20345 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06004F7A RID: 20346 RVA: 0x0018D48F File Offset: 0x0018B68F
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("grid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F7B RID: 20347 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F7C RID: 20348 RVA: 0x0018D4B3 File Offset: 0x0018B6B3
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("_SmoothStart");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F7D RID: 20349 RVA: 0x0018D4D7 File Offset: 0x0018B6D7
	private Material PEIMCBBHLBJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F7E RID: 20350 RVA: 0x0018D50E File Offset: 0x0018B70E
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("skin.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004F7F RID: 20351 RVA: 0x0018D532 File Offset: 0x0018B732
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F80 RID: 20352 RVA: 0x0018D558 File Offset: 0x0018B758
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 512f)
			{
				this.HBJJOCHGOPH = 1405f;
			}
			this.DIOAAHJDMLK().SetFloat("_DotSize", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("x", this.Therma_Variation);
			this.INOBFNCKFGK().SetFloat("SetParticlesInput", this.OGLODCDJJLB);
			this.INOBFNCKFGK().SetFloat("RespawnAfter", this.ALELLLFCDBF);
			this.NBMPPNFKFLB().SetFloat("offsets", this.NFDIFLHGJKB);
			this.EHDJJANLINB().SetVector("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 588f, 836f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F81 RID: 20353 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06004F82 RID: 20354 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F83 RID: 20355 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06004F84 RID: 20356 RVA: 0x0018D658 File Offset: 0x0018B858
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1101f)
			{
				this.HBJJOCHGOPH = 1030f;
			}
			this.CIAFLBFJLEJ().SetFloat("settings.shaders.bloomintencity", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("_TimeX", this.Therma_Variation);
			this.OOMFJGPAOKL().SetFloat(".lastCheckpoint.perfectHits", this.OGLODCDJJLB);
			this.FOOCJIDNGBB().SetFloat("settings.shaders", this.ALELLLFCDBF);
			this.OJMHIMIPKME().SetFloat("CameraFilterPack_Blizzard1", this.NFDIFLHGJKB);
			this.CIAFLBFJLEJ().SetVector("CameraFilterPack/Blend2Camera_SoftLight", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 768f, 1712f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F85 RID: 20357 RVA: 0x0018D757 File Offset: 0x0018B957
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F86 RID: 20358 RVA: 0x0018D78E File Offset: 0x0018B98E
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F87 RID: 20359 RVA: 0x0018D7C5 File Offset: 0x0018B9C5
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F88 RID: 20360 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F89 RID: 20361 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06004F8A RID: 20362 RVA: 0x0018D7FC File Offset: 0x0018B9FC
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F8B RID: 20363 RVA: 0x0018D833 File Offset: 0x0018BA33
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F8C RID: 20364 RVA: 0x0018D86A File Offset: 0x0018BA6A
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F8D RID: 20365 RVA: 0x0018D8A4 File Offset: 0x0018BAA4
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 716f)
			{
				this.HBJJOCHGOPH = 418f;
			}
			this.INOBFNCKFGK().SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("CheckResources () for ", this.Therma_Variation);
			this.INOBFNCKFGK().SetFloat("_Green_G", this.OGLODCDJJLB);
			this.JFDGLLEOPGB().SetFloat("_Value2", this.ALELLLFCDBF);
			this.DIOAAHJDMLK().SetFloat(",", this.NFDIFLHGJKB);
			this.LPMLLJKMAMP().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1988f, 1370f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F8E RID: 20366 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x06004F8F RID: 20367 RVA: 0x0018D9A3 File Offset: 0x0018BBA3
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("_Extra3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F90 RID: 20368 RVA: 0x0018D9C8 File Offset: 0x0018BBC8
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 698f)
			{
				this.HBJJOCHGOPH = 1272f;
			}
			this.EHDJJANLINB().SetFloat("Subscribed cells:\n", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("Object ID. Case-Sensitive", this.Therma_Variation);
			this.FOOCJIDNGBB().SetFloat("CameraFilterPack/Blur_Bloom", this.OGLODCDJJLB);
			this.IKAIDLJKLFC().SetFloat(".completed", this.ALELLLFCDBF);
			this.JFDGLLEOPGB().SetFloat("ticket", this.NFDIFLHGJKB);
			this.FLGPDBBKAIP().SetVector("#useticket", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1941f, 1245f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F91 RID: 20369 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F92 RID: 20370 RVA: 0x0018DAC8 File Offset: 0x0018BCC8
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1940f)
			{
				this.HBJJOCHGOPH = 910f;
			}
			this.IKAIDLJKLFC().SetFloat("Selection Box", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat(" beatThreshold: ", this.Therma_Variation);
			this.HCGJCMDJPGD().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", this.OGLODCDJJLB);
			this.BLMPMOIDGMG().SetFloat("_Value2", this.ALELLLFCDBF);
			this.HHIFMIPPMPF().SetFloat("_PrevViewProj", this.NFDIFLHGJKB);
			this.HHIFMIPPMPF().SetVector("0.00:0.00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 319f, 1597f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F93 RID: 20371 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F94 RID: 20372 RVA: 0x0018DBC7 File Offset: 0x0018BDC7
	private Material GBFOAHKAJEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F95 RID: 20373 RVA: 0x0018DBFE File Offset: 0x0018BDFE
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F96 RID: 20374 RVA: 0x0018DC35 File Offset: 0x0018BE35
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Gradients_Tech");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004F97 RID: 20375 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F98 RID: 20376 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06004F99 RID: 20377 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F9A RID: 20378 RVA: 0x0018DC5C File Offset: 0x0018BE5C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 20f)
			{
				this.HBJJOCHGOPH = 855f;
			}
			this.DEFBJOCJJKF().SetFloat("GameScene", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("_ScreenResolution", this.Therma_Variation);
			this.INOBFNCKFGK().SetFloat("_FarCamera", this.OGLODCDJJLB);
			this.IKAIDLJKLFC().SetFloat("DifficultyBG", this.ALELLLFCDBF);
			this.CIAFLBFJLEJ().SetFloat("powerup.1", this.NFDIFLHGJKB);
			this.LPMLLJKMAMP().SetVector("Created by ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 327f, 1453f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F9B RID: 20379 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F9C RID: 20380 RVA: 0x0018DD5B File Offset: 0x0018BF5B
	private Material IKAIDLJKLFC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F9D RID: 20381 RVA: 0x0018DD94 File Offset: 0x0018BF94
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 359f)
			{
				this.HBJJOCHGOPH = 1480f;
			}
			this.BAGICADFBAB().SetFloat("_ToPrevViewProjCombined", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("CameraFilterPack/Distortion_BlackHole", this.Therma_Variation);
			this.LPMLLJKMAMP().SetFloat("0.00:0.00", this.OGLODCDJJLB);
			this.LDNADDJMIPK().SetFloat("Uploading preview image", this.ALELLLFCDBF);
			this.CFEDGDGBCHE().SetFloat("SetSunColors", this.NFDIFLHGJKB);
			this.KGOLDDBHIFN().SetVector("[LevelEditorScene] Print Audio Wave: Start", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 845f, 185f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F9E RID: 20382 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void HCDBNAKGDJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F9F RID: 20383 RVA: 0x0018DE94 File Offset: 0x0018C094
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1869f)
			{
				this.HBJJOCHGOPH = 1071f;
			}
			this.CFEDGDGBCHE().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("_ScreenResolution", this.Therma_Variation);
			this.EHDJJANLINB().SetFloat("_CenterX", this.OGLODCDJJLB);
			this.KGOLDDBHIFN().SetFloat(", data: ", this.ALELLLFCDBF);
			this.NBMPPNFKFLB().SetFloat("x", this.NFDIFLHGJKB);
			this.CECJJMKLEAK().SetVector("Network destroy Instantiated GO: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1818f, 417f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FA0 RID: 20384 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FA1 RID: 20385 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FA2 RID: 20386 RVA: 0x0018DF93 File Offset: 0x0018C193
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FA3 RID: 20387 RVA: 0x0018DFCA File Offset: 0x0018C1CA
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/EyesVision_1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004FA4 RID: 20388 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06004FA5 RID: 20389 RVA: 0x0018DFEE File Offset: 0x0018C1EE
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Fly_Vision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FA6 RID: 20390 RVA: 0x0018E012 File Offset: 0x0018C212
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FA7 RID: 20391 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FA8 RID: 20392 RVA: 0x0018E049 File Offset: 0x0018C249
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FA9 RID: 20393 RVA: 0x0018E080 File Offset: 0x0018C280
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1770f)
			{
				this.HBJJOCHGOPH = 562f;
			}
			this.HKHBBBFLGJH().SetFloat("No Name", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("true", this.Therma_Variation);
			this.JFDGLLEOPGB().SetFloat("#no", this.OGLODCDJJLB);
			this.CIAFLBFJLEJ().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", this.ALELLLFCDBF);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_ARCADE_Fast", this.NFDIFLHGJKB);
			this.KGOLDDBHIFN().SetVector("LevelNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 86f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FAA RID: 20394 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMNOHLNANIP()
	{
	}

	// Token: 0x06004FAB RID: 20395 RVA: 0x0018E17F File Offset: 0x0018C37F
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("CameraFilterPack/VHS_Tracking");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FAC RID: 20396 RVA: 0x0018E1A3 File Offset: 0x0018C3A3
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find(" from: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FAD RID: 20397 RVA: 0x0018E1C8 File Offset: 0x0018C3C8
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1000f)
			{
				this.HBJJOCHGOPH = 1461f;
			}
			this.DEFBJOCJJKF().SetFloat("Result for ", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("start", this.Therma_Variation);
			this.JFDGLLEOPGB().SetFloat("FinalScoreSmallText", this.OGLODCDJJLB);
			this.FAIFBBGFAIB().SetFloat("[RanksSystem] Init", this.ALELLLFCDBF);
			this.CFEDGDGBCHE().SetFloat("Lag ", this.NFDIFLHGJKB);
			this.CIAFLBFJLEJ().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1835f, 94f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FAE RID: 20398 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06004FAF RID: 20399 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FB0 RID: 20400 RVA: 0x0018E2C8 File Offset: 0x0018C4C8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 312f)
			{
				this.HBJJOCHGOPH = 1514f;
			}
			this.OOMFJGPAOKL().SetFloat("{0}", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("The other scroll rect doesnt support scrolling vertically", this.Therma_Variation);
			this.FAIFBBGFAIB().SetFloat("_EmissionGain", this.OGLODCDJJLB);
			this.NBMPPNFKFLB().SetFloat("Gameplay/Base", this.ALELLLFCDBF);
			this.DONENAMLFLF().SetFloat("HightScoreMaxPointsText", this.NFDIFLHGJKB);
			this.FOOCJIDNGBB().SetVector("_Intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 164f, 1899f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FB2 RID: 20402 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06004FB3 RID: 20403 RVA: 0x0018E3FC File Offset: 0x0018C5FC
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 557f)
			{
				this.HBJJOCHGOPH = 1451f;
			}
			this.JFDGLLEOPGB().SetFloat(": ", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetFloat("maps.", this.Therma_Variation);
			this.OOMFJGPAOKL().SetFloat("_Near", this.OGLODCDJJLB);
			this.HHIFMIPPMPF().SetFloat("SpawnObj", this.ALELLLFCDBF);
			this.FLGPDBBKAIP().SetFloat("_ScreenResolution", this.NFDIFLHGJKB);
			this.DONENAMLFLF().SetVector("menu.enableselectormusic", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 392f, 1718f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06004FB4 RID: 20404 RVA: 0x0018E4FB File Offset: 0x0018C6FB
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

	// Token: 0x06004FB5 RID: 20405 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FB6 RID: 20406 RVA: 0x0018E534 File Offset: 0x0018C734
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1415f)
			{
				this.HBJJOCHGOPH = 1234f;
			}
			this.CIAFLBFJLEJ().SetFloat("OpAuthenticate()", this.HBJJOCHGOPH);
			this.FLGPDBBKAIP().SetFloat("YES", this.Therma_Variation);
			this.FOOCJIDNGBB().SetFloat("_Value4", this.OGLODCDJJLB);
			this.FOOCJIDNGBB().SetFloat("ArcsDestroyDelaySlider", this.ALELLLFCDBF);
			this.CECJJMKLEAK().SetFloat("_Value", this.NFDIFLHGJKB);
			this.DEFBJOCJJKF().SetVector("settings.volume.editor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 324f, 87f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FB7 RID: 20407 RVA: 0x0018E633 File Offset: 0x0018C833
	private void CEDFFAOOPOG()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004FB8 RID: 20408 RVA: 0x0018E658 File Offset: 0x0018C858
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1465f)
			{
				this.HBJJOCHGOPH = 866f;
			}
			this.GBFOAHKAJEK().SetFloat("Scene", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("OpGetGameList not sent. Lobby cannot be null.", this.Therma_Variation);
			this.HCGJCMDJPGD().SetFloat("_Value2", this.OGLODCDJJLB);
			this.INOBFNCKFGK().SetFloat("y", this.ALELLLFCDBF);
			this.LPMLLJKMAMP().SetFloat("maps.", this.NFDIFLHGJKB);
			this.OOMFJGPAOKL().SetVector(" url: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1218f, 770f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FB9 RID: 20409 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FBA RID: 20410 RVA: 0x0018E758 File Offset: 0x0018C958
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1892f)
			{
				this.HBJJOCHGOPH = 1306f;
			}
			this.FLGPDBBKAIP().SetFloat("Preparing configuration", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_MainTex", this.Therma_Variation);
			this.IKAIDLJKLFC().SetFloat("_Bloom3", this.OGLODCDJJLB);
			this.BAGICADFBAB().SetFloat("_EmissionColor", this.ALELLLFCDBF);
			this.OOMFJGPAOKL().SetFloat("NEW_ACHIEVEMENT_1_21", this.NFDIFLHGJKB);
			this.HCGJCMDJPGD().SetVector("ns", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1759f, 1674f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FBB RID: 20411 RVA: 0x0018E857 File Offset: 0x0018CA57
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FBC RID: 20412 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FBD RID: 20413 RVA: 0x0018E88E File Offset: 0x0018CA8E
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("/icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FBE RID: 20414 RVA: 0x0018E8B2 File Offset: 0x0018CAB2
	private void FEGJMDDIDIC()
	{
		this.SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004FBF RID: 20415 RVA: 0x0018E8D6 File Offset: 0x0018CAD6
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FC0 RID: 20416 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FC1 RID: 20417 RVA: 0x0018E90D File Offset: 0x0018CB0D
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FC2 RID: 20418 RVA: 0x0018E944 File Offset: 0x0018CB44
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1020f)
			{
				this.HBJJOCHGOPH = 1191f;
			}
			this.FAIFBBGFAIB().SetFloat("_Near", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("X2", this.Therma_Variation);
			this.DEFBJOCJJKF().SetFloat("_TimeX", this.OGLODCDJJLB);
			this.CIAFLBFJLEJ().SetFloat("float,10", this.ALELLLFCDBF);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this.NFDIFLHGJKB);
			this.DEFBJOCJJKF().SetVector("Tab2Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 857f, 578f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FC3 RID: 20419 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FC4 RID: 20420 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FC5 RID: 20421 RVA: 0x0018EA44 File Offset: 0x0018CC44
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 957f)
			{
				this.HBJJOCHGOPH = 1757f;
			}
			this.BLMPMOIDGMG().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("close", this.Therma_Variation);
			this.OJMHIMIPKME().SetFloat("_Value", this.OGLODCDJJLB);
			this.NBMPPNFKFLB().SetFloat("Set satellite color", this.ALELLLFCDBF);
			this.GBFOAHKAJEK().SetFloat("_RayStepSize", this.NFDIFLHGJKB);
			this.HKHBBBFLGJH().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1528f, 1276f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FC6 RID: 20422 RVA: 0x0018EB44 File Offset: 0x0018CD44
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1210f)
			{
				this.HBJJOCHGOPH = 1445f;
			}
			this.CIAFLBFJLEJ().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("Set Particles Color", this.Therma_Variation);
			this.GBFOAHKAJEK().SetFloat("ScrollPanel", this.OGLODCDJJLB);
			this.LDNADDJMIPK().SetFloat("Keypad", this.ALELLLFCDBF);
			this.DONENAMLFLF().SetFloat("_MainTex2", this.NFDIFLHGJKB);
			this.NBPKMLMCHFN.SetVector("OnAwakeRPC", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 898f, 1817f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FC7 RID: 20423 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FC8 RID: 20424 RVA: 0x0018EC43 File Offset: 0x0018CE43
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("F3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004FC9 RID: 20425 RVA: 0x0018EC68 File Offset: 0x0018CE68
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1421f)
			{
				this.HBJJOCHGOPH = 1880f;
			}
			this.DIOAAHJDMLK().SetFloat("_CenterX", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("ResetButton", this.Therma_Variation);
			this.LDNADDJMIPK().SetFloat("#getrewardfailed: ", this.OGLODCDJJLB);
			this.CECJJMKLEAK().SetFloat(".sav", this.ALELLLFCDBF);
			this.CIAFLBFJLEJ().SetFloat("_MainTex2", this.NFDIFLHGJKB);
			this.FAIFBBGFAIB().SetVector("Copy from ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 971f, 1521f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FCA RID: 20426 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06004FCB RID: 20427 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06004FCC RID: 20428 RVA: 0x0018ED68 File Offset: 0x0018CF68
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 588f)
			{
				this.HBJJOCHGOPH = 1593f;
			}
			this.NBPKMLMCHFN.SetFloat("_ForceYSwap", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_Value3", this.Therma_Variation);
			this.LPMLLJKMAMP().SetFloat("float,1", this.OGLODCDJJLB);
			this.CFEDGDGBCHE().SetFloat("_Value2", this.ALELLLFCDBF);
			this.JCPDCGIJKJD().SetFloat("Cross", this.NFDIFLHGJKB);
			this.FOOCJIDNGBB().SetVector("GlassColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1563f, 1534f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FCD RID: 20429 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FCE RID: 20430 RVA: 0x0018EE67 File Offset: 0x0018D067
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FCF RID: 20431 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FD0 RID: 20432 RVA: 0x0018EE8B File Offset: 0x0018D08B
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("UI Extensions/UIMultiply");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FD1 RID: 20433 RVA: 0x0018EEAF File Offset: 0x0018D0AF
	private void AIBNKIDADPI()
	{
		this.SCShader = Shader.Find("original.tutorial");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FD2 RID: 20434 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FD3 RID: 20435 RVA: 0x0018EED3 File Offset: 0x0018D0D3
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("player.redlifering");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FD4 RID: 20436 RVA: 0x0018EEF7 File Offset: 0x0018D0F7
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004FD5 RID: 20437 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06004FD6 RID: 20438 RVA: 0x0018EF1B File Offset: 0x0018D11B
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FD7 RID: 20439 RVA: 0x0018EF54 File Offset: 0x0018D154
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1615f)
			{
				this.HBJJOCHGOPH = 1984f;
			}
			this.FOOCJIDNGBB().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("#lives", this.Therma_Variation);
			this.PEIMCBBHLBJ().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.OGLODCDJJLB);
			this.BAGICADFBAB().SetFloat("_Value", this.ALELLLFCDBF);
			this.JCPDCGIJKJD().SetFloat("Moved event", this.NFDIFLHGJKB);
			this.BLMPMOIDGMG().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 757f, 1322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FD8 RID: 20440 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FD9 RID: 20441 RVA: 0x0018F054 File Offset: 0x0018D254
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 191f)
			{
				this.HBJJOCHGOPH = 57f;
			}
			this.EHDJJANLINB().SetFloat("[Right-Down-Left]", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("inventory.lastitemscount", this.Therma_Variation);
			this.KGOLDDBHIFN().SetFloat("_SoftZDistance", this.OGLODCDJJLB);
			this.HCGJCMDJPGD().SetFloat("#exitmapeditor", this.ALELLLFCDBF);
			this.IKAIDLJKLFC().SetFloat("CameraFilterPack_TV_BrokenGlass1", this.NFDIFLHGJKB);
			this.FLGPDBBKAIP().SetVector(" ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 923f, 1225f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FDA RID: 20442 RVA: 0x0018F153 File Offset: 0x0018D353
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FDB RID: 20443 RVA: 0x0018F18A File Offset: 0x0018D38A
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FDC RID: 20444 RVA: 0x0018F1C1 File Offset: 0x0018D3C1
	private void IBLGHLNNAHN()
	{
		this.SCShader = Shader.Find(".GoalProgress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004FDD RID: 20445 RVA: 0x0018F1E5 File Offset: 0x0018D3E5
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FDE RID: 20446 RVA: 0x0018F21C File Offset: 0x0018D41C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 684f)
			{
				this.HBJJOCHGOPH = 1905f;
			}
			this.FLGPDBBKAIP().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat(" ", this.Therma_Variation);
			this.OOMFJGPAOKL().SetFloat("_ThirdTex", this.OGLODCDJJLB);
			this.LPMLLJKMAMP().SetFloat("[Down]", this.ALELLLFCDBF);
			this.BLMPMOIDGMG().SetFloat("EditMenu", this.NFDIFLHGJKB);
			this.LDNADDJMIPK().SetVector("_BlurRadius4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 281f, 1130f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FDF RID: 20447 RVA: 0x0018F31B File Offset: 0x0018D51B
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("[Sound Manager] Audio clip is null, cannot play music");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FE0 RID: 20448 RVA: 0x0018F33F File Offset: 0x0018D53F
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("OnMastedChangeScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FE1 RID: 20449 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06004FE2 RID: 20450 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06004FE3 RID: 20451 RVA: 0x0018F363 File Offset: 0x0018D563
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("ScrollPanel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004FE4 RID: 20452 RVA: 0x0018F387 File Offset: 0x0018D587
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Oculus_ThermaVision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004FE5 RID: 20453 RVA: 0x0018F3AB File Offset: 0x0018D5AB
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FE6 RID: 20454 RVA: 0x0018F3E4 File Offset: 0x0018D5E4
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 220f)
			{
				this.HBJJOCHGOPH = 1673f;
			}
			this.PEIMCBBHLBJ().SetFloat("<command>", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("#,0.00", this.Therma_Variation);
			this.CFEDGDGBCHE().SetFloat("SetPosition", this.OGLODCDJJLB);
			this.FAIFBBGFAIB().SetFloat("_BlurCoe", this.ALELLLFCDBF);
			this.FOOCJIDNGBB().SetFloat("_Value", this.NFDIFLHGJKB);
			this.CFEDGDGBCHE().SetVector("Set the end of the map. Use this if you want to cut the long music.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 260f, 659f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FE7 RID: 20455 RVA: 0x0018F4E3 File Offset: 0x0018D6E3
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FE8 RID: 20456 RVA: 0x0018F51A File Offset: 0x0018D71A
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.currentCombo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004FE9 RID: 20457 RVA: 0x0018F540 File Offset: 0x0018D740
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 509f)
			{
				this.HBJJOCHGOPH = 465f;
			}
			this.CECJJMKLEAK().SetFloat("Health Stats", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("_Color", this.Therma_Variation);
			this.KGOLDDBHIFN().SetFloat("_MainTex", this.OGLODCDJJLB);
			this.PEIMCBBHLBJ().SetFloat("\n", this.ALELLLFCDBF);
			this.OJMHIMIPKME().SetFloat("Reconnect() disabled the offline mode. No longer offline.", this.NFDIFLHGJKB);
			this.LDNADDJMIPK().SetVector("_Red_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1956f, 1014f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FEA RID: 20458 RVA: 0x0018F640 File Offset: 0x0018D840
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 912f)
			{
				this.HBJJOCHGOPH = 1367f;
			}
			this.NBPKMLMCHFN.SetFloat("ERROR: Make sure your mod contains at leats one file!", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("CountEventsGoal", this.Therma_Variation);
			this.JCPDCGIJKJD().SetFloat("StartButton", this.OGLODCDJJLB);
			this.DEFBJOCJJKF().SetFloat("float,0", this.ALELLLFCDBF);
			this.FAIFBBGFAIB().SetFloat("Data/Skins/", this.NFDIFLHGJKB);
			this.CFEDGDGBCHE().SetVector("a year ago", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1756f, 494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FEB RID: 20459 RVA: 0x0018F740 File Offset: 0x0018D940
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 900f)
			{
				this.HBJJOCHGOPH = 1367f;
			}
			this.HCGJCMDJPGD().SetFloat("_Value", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("offsets", this.Therma_Variation);
			this.INOBFNCKFGK().SetFloat("_ScreenResolution", this.OGLODCDJJLB);
			this.FOOCJIDNGBB().SetFloat("_Value2", this.ALELLLFCDBF);
			this.LPMLLJKMAMP().SetFloat("Hidden/TonemappingColorGrading", this.NFDIFLHGJKB);
			this.IKAIDLJKLFC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 936f, 901f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FEC RID: 20460 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FED RID: 20461 RVA: 0x0018F83F File Offset: 0x0018DA3F
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("stats on");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004FEE RID: 20462 RVA: 0x0018F864 File Offset: 0x0018DA64
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1963f)
			{
				this.HBJJOCHGOPH = 1486f;
			}
			this.BAGICADFBAB().SetFloat("EditMenu", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("SetSunMinSize", this.Therma_Variation);
			this.PEIMCBBHLBJ().SetFloat(". The group number should be at least 1.", this.OGLODCDJJLB);
			this.HHIFMIPPMPF().SetFloat("_BlurVector", this.ALELLLFCDBF);
			this.CIAFLBFJLEJ().SetFloat("InputField", this.NFDIFLHGJKB);
			this.FAIFBBGFAIB().SetVector("FPSToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 974f, 1791f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FEF RID: 20463 RVA: 0x0018F964 File Offset: 0x0018DB64
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 989f)
			{
				this.HBJJOCHGOPH = 1385f;
			}
			this.FOOCJIDNGBB().SetFloat(" ", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat(":", this.Therma_Variation);
			this.JFDGLLEOPGB().SetFloat("error", this.OGLODCDJJLB);
			this.FLGPDBBKAIP().SetFloat("_Gain", this.ALELLLFCDBF);
			this.OJMHIMIPKME().SetFloat("0,7,true,0", this.NFDIFLHGJKB);
			this.OOMFJGPAOKL().SetVector("IntraTime", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 988f, 1213f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FF0 RID: 20464 RVA: 0x0018FA64 File Offset: 0x0018DC64
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1284f)
			{
				this.HBJJOCHGOPH = 1005f;
			}
			this.IKAIDLJKLFC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", this.Therma_Variation);
			this.HHIFMIPPMPF().SetFloat("player.xp", this.OGLODCDJJLB);
			this.FAIFBBGFAIB().SetFloat("_Extra3", this.ALELLLFCDBF);
			this.JFDGLLEOPGB().SetFloat(".workshop.json", this.NFDIFLHGJKB);
			this.CECJJMKLEAK().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1501f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FF1 RID: 20465 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FF2 RID: 20466 RVA: 0x0018FB64 File Offset: 0x0018DD64
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Therma_Variation);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.OGLODCDJJLB);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ALELLLFCDBF);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.NFDIFLHGJKB);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FF3 RID: 20467 RVA: 0x0018FC63 File Offset: 0x0018DE63
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FF4 RID: 20468 RVA: 0x0018FC9C File Offset: 0x0018DE9C
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 957f)
			{
				this.HBJJOCHGOPH = 715f;
			}
			this.DEFBJOCJJKF().SetFloat("/Segment-[Down]", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("Editor/", this.Therma_Variation);
			this.OOMFJGPAOKL().SetFloat("pointBuffer", this.OGLODCDJJLB);
			this.DIOAAHJDMLK().SetFloat("_ScreenResolution", this.ALELLLFCDBF);
			this.NBPKMLMCHFN.SetFloat("_Visualize", this.NFDIFLHGJKB);
			this.HCGJCMDJPGD().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 275f, 906f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FF5 RID: 20469 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FF6 RID: 20470 RVA: 0x0018FD9B File Offset: 0x0018DF9B
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FF7 RID: 20471 RVA: 0x0018D34C File Offset: 0x0018B54C
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004FF8 RID: 20472 RVA: 0x0002523B File Offset: 0x0002343B
	private void AOLABBMIEIM()
	{
	}

	// Token: 0x06004FF9 RID: 20473 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06004FFA RID: 20474 RVA: 0x0018FDD2 File Offset: 0x0018DFD2
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FFB RID: 20475 RVA: 0x0018FE0C File Offset: 0x0018E00C
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 732f)
			{
				this.HBJJOCHGOPH = 1366f;
			}
			this.DIOAAHJDMLK().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_Visualize", this.Therma_Variation);
			this.CECJJMKLEAK().SetFloat("open", this.OGLODCDJJLB);
			this.DIOAAHJDMLK().SetFloat("RespawnAfter", this.ALELLLFCDBF);
			this.FLGPDBBKAIP().SetFloat("Editor/", this.NFDIFLHGJKB);
			this.CECJJMKLEAK().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1034f, 1632f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004FFC RID: 20476 RVA: 0x0018FF0B File Offset: 0x0018E10B
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004FFD RID: 20477 RVA: 0x0018FF2F File Offset: 0x0018E12F
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FFE RID: 20478 RVA: 0x0018FF66 File Offset: 0x0018E166
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004FFF RID: 20479 RVA: 0x0018FF9D File Offset: 0x0018E19D
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("Unsupported type: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000850 RID: 2128
	public Shader SCShader;

	// Token: 0x04000851 RID: 2129
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000852 RID: 2130
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000853 RID: 2131
	private Material BJFKDHHMLJH;

	// Token: 0x04000854 RID: 2132
	[Range(0f, 1f)]
	public float Therma_Variation = 0.5f;

	// Token: 0x04000855 RID: 2133
	[Range(0f, 8f)]
	private float OGLODCDJJLB = 3f;

	// Token: 0x04000856 RID: 2134
	[Range(0f, 4f)]
	private float ALELLLFCDBF;

	// Token: 0x04000857 RID: 2135
	[Range(0f, 16f)]
	private float NFDIFLHGJKB = 1f;
}
