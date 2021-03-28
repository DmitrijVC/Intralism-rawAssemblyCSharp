using System;
using UnityEngine;

// Token: 0x02000064 RID: 100
[AddComponentMenu("Camera Filter Pack/Blur/Radial")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Radial : MonoBehaviour
{
	// Token: 0x06001B8D RID: 7053 RVA: 0x000AA988 File Offset: 0x000A8B88
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1518f)
			{
				this.HBJJOCHGOPH = 176f;
			}
			this.OGMEGHKECAH().SetFloat("shader.crispwinter", this.HBJJOCHGOPH);
			this.FOOCJIDNGBB().SetFloat("CameraFilterPack/Blend2Camera_VividLight", this.Intensity);
			this.IGKFMCPDNOI().SetFloat("_BlurRadius", this.MovX);
			this.EOCCJGIGEGJ().SetFloat("SetSatelliteTrailLength", this.MovY);
			this.NBPKMLMCHFN.SetFloat("deletemap", this.KJIKOEIAENF);
			this.FLOHGDECHHH().SetVector("Item ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1457f, 807f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B8E RID: 7054 RVA: 0x000AAA87 File Offset: 0x000A8C87
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B8F RID: 7055 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06001B90 RID: 7056 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B91 RID: 7057 RVA: 0x000AAADC File Offset: 0x000A8CDC
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1184f)
			{
				this.HBJJOCHGOPH = 971f;
			}
			this.HKGAONMOBMH().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.GBFOAHKAJEK().SetFloat("SetSatelliteColor", this.Intensity);
			this.IGKFMCPDNOI().SetFloat("Connected to gameserver.", this.MovX);
			this.KEMJNOMIPHN().SetFloat("finished", this.MovY);
			this.OGMEGHKECAH().SetFloat("System.String", this.KJIKOEIAENF);
			this.OLHDPICFBOF().SetVector("mapselector.filter.rateduponly", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 427f, 1970f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x000AABDB File Offset: 0x000A8DDB
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x000AAC12 File Offset: 0x000A8E12
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x000AAC4C File Offset: 0x000A8E4C
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 134f)
			{
				this.HBJJOCHGOPH = 796f;
			}
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/Edge_Sobel", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("Blues", this.Intensity);
			this.FLOHGDECHHH().SetFloat("_MidGrey", this.MovX);
			this.PDEAHJPOMEF().SetFloat("_Value4", this.MovY);
			this.GBFOAHKAJEK().SetFloat("SetSatelliteRotationSpeed", this.KJIKOEIAENF);
			this.IGKFMCPDNOI().SetVector("_Red_B", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1038f, 1390f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x000AAD4B File Offset: 0x000A8F4B
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x000AAD70 File Offset: 0x000A8F70
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 489f)
			{
				this.HBJJOCHGOPH = 1765f;
			}
			this.GBFOAHKAJEK().SetFloat("#ok", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("_ScreenResolution", this.Intensity);
			this.MNLKBFFKHIE().SetFloat("menu.selectedplaymode", this.MovX);
			this.LDNADDJMIPK().SetFloat("MenuScene", this.MovY);
			this.HNFFHCLNBDN().SetFloat("SpawnObj", this.KJIKOEIAENF);
			this.HKHBBBFLGJH().SetVector("TBD", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1596f, 480f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x000AAE6F File Offset: 0x000A906F
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("Set Sun Emission");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B99 RID: 7065 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIPBNBKNICE()
	{
	}

	// Token: 0x06001B9A RID: 7066 RVA: 0x000AAE94 File Offset: 0x000A9094
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 15f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("#no", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("maps.", this.Intensity);
			this.PDEAHJPOMEF().SetFloat("Could not find RPC with index: ", this.MovX);
			this.DONENAMLFLF().SetFloat("_Speed", this.MovY);
			this.HKGAONMOBMH().SetFloat("_TimeX", this.KJIKOEIAENF);
			this.OLHDPICFBOF().SetVector("The given 2D texture ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1018f, 1132f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B9B RID: 7067 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06001B9C RID: 7068 RVA: 0x000AAF93 File Offset: 0x000A9193
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("\" error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B9D RID: 7069 RVA: 0x000AAFB7 File Offset: 0x000A91B7
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("SetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x000AAFDC File Offset: 0x000A91DC
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1944f)
			{
				this.HBJJOCHGOPH = 937f;
			}
			this.FLOHGDECHHH().SetFloat("AccuracyScoreText", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("_TimeX", this.Intensity);
			this.KDMBOKLMADJ().SetFloat("SpawnObj", this.MovX);
			this.LDNADDJMIPK().SetFloat("Left", this.MovY);
			this.PDEAHJPOMEF().SetFloat("Error! no audio sources attached to AudioSampler.css", this.KJIKOEIAENF);
			this.OLHDPICFBOF().SetVector("Joystick1Button0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 420f, 1676f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x000AB0DB File Offset: 0x000A92DB
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BA1 RID: 7073 RVA: 0x000AB112 File Offset: 0x000A9312
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BA2 RID: 7074 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BA4 RID: 7076 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x000AB138 File Offset: 0x000A9338
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1879f)
			{
				this.HBJJOCHGOPH = 1126f;
			}
			this.OLHDPICFBOF().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("player.deleted", this.Intensity);
			this.ADGHJOHKEHG().SetFloat("PhotonView with ID ", this.MovX);
			this.LELKBCALFCF().SetFloat("_TimeX", this.MovY);
			this.DONENAMLFLF().SetFloat("Set satellite emission (glow)", this.KJIKOEIAENF);
			this.DONENAMLFLF().SetVector(" - Contains ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 821f, 1203f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x000AB237 File Offset: 0x000A9437
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Radial");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x000AB25B File Offset: 0x000A945B
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x000AB27F File Offset: 0x000A947F
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("selector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x000AB2A3 File Offset: 0x000A94A3
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("EXCEPTION:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x000AB2C7 File Offset: 0x000A94C7
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x000AB2EB File Offset: 0x000A94EB
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x000AB324 File Offset: 0x000A9524
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1039f)
			{
				this.HBJJOCHGOPH = 304f;
			}
			this.LDNADDJMIPK().SetFloat("Item ", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat(" timeUntilRespawnBasedOnTimeBase:", this.Intensity);
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.MovX);
			this.HKGAONMOBMH().SetFloat("_ColorG", this.MovY);
			this.OGMEGHKECAH().SetFloat("_TimeX", this.KJIKOEIAENF);
			this.KEMJNOMIPHN().SetVector("_Val3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 386f, 491f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x000AB424 File Offset: 0x000A9624
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1801f)
			{
				this.HBJJOCHGOPH = 1148f;
			}
			this.OJMHIMIPKME().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("[MapsStats] Map ID: ", this.Intensity);
			this.OCHJIMJNEMO().SetFloat("Received OnSerialization for view ID ", this.MovX);
			this.HNFFHCLNBDN().SetFloat("OnReadyClick", this.MovY);
			this.OJMHIMIPKME().SetFloat("TimeBGSlider", this.KJIKOEIAENF);
			this.OCHJIMJNEMO().SetVector(".lastCheckpoint.perfectHits", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 256f, 110f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x000AB523 File Offset: 0x000A9723
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("BlockSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BB5 RID: 7093 RVA: 0x000AABDB File Offset: 0x000A8DDB
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x000AB548 File Offset: 0x000A9748
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 475f)
			{
				this.HBJJOCHGOPH = 1463f;
			}
			this.NLFJGMBCICG().SetFloat("RecieveChatActionMessage", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("_Far", this.Intensity);
			this.OJMHIMIPKME().SetFloat("_TimeX", this.MovX);
			this.LELKBCALFCF().SetFloat("_Value2", this.MovY);
			this.FOOCJIDNGBB().SetFloat("_Value", this.KJIKOEIAENF);
			this.KEMAALEODNH().SetVector("Image", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 84f, 360f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x000AB647 File Offset: 0x000A9847
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x000AB67E File Offset: 0x000A987E
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x000AB6B5 File Offset: 0x000A98B5
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x000AB6DC File Offset: 0x000A98DC
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 192f)
			{
				this.HBJJOCHGOPH = 759f;
			}
			this.DONENAMLFLF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("SUCCESS! Item submitted! :D :D :D", this.Intensity);
			this.KEMAALEODNH().SetFloat("_SceneFogParams", this.MovX);
			this.EOCCJGIGEGJ().SetFloat("id", this.MovY);
			this.HEHKGPKLAKK().SetFloat("Send", this.KJIKOEIAENF);
			this.MNLKBFFKHIE().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1750f, 370f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x000AB7DB File Offset: 0x000A99DB
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("player.linea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x000AB800 File Offset: 0x000A9A00
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1559f)
			{
				this.HBJJOCHGOPH = 779f;
			}
			this.OLHDPICFBOF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("/", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("float,1", this.MovX);
			this.MNLKBFFKHIE().SetFloat("_Value2", this.MovY);
			this.NBPKMLMCHFN.SetFloat("offsets", this.KJIKOEIAENF);
			this.NLFJGMBCICG().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 734f, 314f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x000AB900 File Offset: 0x000A9B00
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.MovX);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.MovY);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.KJIKOEIAENF);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x000AB9FF File Offset: 0x000A9BFF
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void OHIJGCLBMJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BC4 RID: 7108 RVA: 0x000ABA36 File Offset: 0x000A9C36
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("SetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x000ABA5A File Offset: 0x000A9C5A
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find("Depth textures aren't supported on this device ({0})");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x0002523B File Offset: 0x0002343B
	private void POEMOLBJDLG()
	{
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x000ABA7E File Offset: 0x000A9C7E
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("<b>(╯°□°）╯︵ ┻━┻</b>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x000ABAA2 File Offset: 0x000A9CA2
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x000ABADC File Offset: 0x000A9CDC
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 637f)
			{
				this.HBJJOCHGOPH = 580f;
			}
			this.OLHDPICFBOF().SetFloat("ShowTitle", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("Bad modpack name: {0}", this.Intensity);
			this.MNLKBFFKHIE().SetFloat("stretchWidth", this.MovX);
			this.EOCCJGIGEGJ().SetFloat("DPADHOR", this.MovY);
			this.EJDPNJAEAKJ().SetFloat("ArcsDestroyDelaySlider", this.KJIKOEIAENF);
			this.HKGAONMOBMH().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 941f, 1693f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x000ABBDC File Offset: 0x000A9DDC
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1664f)
			{
				this.HBJJOCHGOPH = 972f;
			}
			this.HNFFHCLNBDN().SetFloat("ns", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("_Value4", this.Intensity);
			this.ADGHJOHKEHG().SetFloat("DPADHOR", this.MovX);
			this.FOOCJIDNGBB().SetFloat("Start Color's hex value #RRGGBBAA", this.MovY);
			this.ADGHJOHKEHG().SetFloat("_MainTex2", this.KJIKOEIAENF);
			this.GBFOAHKAJEK().SetVector("Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1054f, 422f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x000ABCDB File Offset: 0x000A9EDB
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x000ABCFF File Offset: 0x000A9EFF
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Screens");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x000ABAA2 File Offset: 0x000A9CA2
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BD3 RID: 7123 RVA: 0x000ABD24 File Offset: 0x000A9F24
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1237f)
			{
				this.HBJJOCHGOPH = 200f;
			}
			this.HKGAONMOBMH().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("settings_bindings_sec_", this.Intensity);
			this.PDEAHJPOMEF().SetFloat("sounds/hit_perfect", this.MovX);
			this.KEMJNOMIPHN().SetFloat("_Value2", this.MovY);
			this.OLHDPICFBOF().SetFloat("_Vibrance", this.KJIKOEIAENF);
			this.KDMBOKLMADJ().SetVector("skin.no_hit", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1950f, 1154f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x000ABE24 File Offset: 0x000AA024
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 821f)
			{
				this.HBJJOCHGOPH = 1958f;
			}
			this.DONENAMLFLF().SetFloat("DPADHOR", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("CameraFilterPack/Vision_Psycho", this.Intensity);
			this.OGMEGHKECAH().SetFloat("_Value2", this.MovX);
			this.GBFOAHKAJEK().SetFloat("settings.selectormapsperpage", this.MovY);
			this.ADGHJOHKEHG().SetFloat("HitInRelaxMusicToggle", this.KJIKOEIAENF);
			this.KDMBOKLMADJ().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1794f, 836f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x000AB112 File Offset: 0x000A9312
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BD7 RID: 7127 RVA: 0x000ABF23 File Offset: 0x000AA123
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BD8 RID: 7128 RVA: 0x000AB2EB File Offset: 0x000A94EB
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x000ABF47 File Offset: 0x000AA147
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BDA RID: 7130 RVA: 0x000ABF80 File Offset: 0x000AA180
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 473f)
			{
				this.HBJJOCHGOPH = 895f;
			}
			this.PDEAHJPOMEF().SetFloat("SaveMapButton", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat(".completed", this.Intensity);
			this.HEHKGPKLAKK().SetFloat("OpJoinRoom()", this.MovX);
			this.KDMBOKLMADJ().SetFloat("ViewMenu", this.MovY);
			this.OGMEGHKECAH().SetFloat("_Value2", this.KJIKOEIAENF);
			this.EFDEIFCDAFG().SetVector("_Size", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 962f, 441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x000AC07F File Offset: 0x000AA27F
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BDC RID: 7132 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x000AC0B6 File Offset: 0x000AA2B6
	private Material GBFOAHKAJEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x000AC0ED File Offset: 0x000AA2ED
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("{0:0} minute{1}, ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x000AC111 File Offset: 0x000AA311
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x000AC148 File Offset: 0x000AA348
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("TotalHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x000AC16C File Offset: 0x000AA36C
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 319f)
			{
				this.HBJJOCHGOPH = 1084f;
			}
			this.LELKBCALFCF().SetFloat("JoinButton", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", this.Intensity);
			this.NLFJGMBCICG().SetFloat("_FgOverlap", this.MovX);
			this.OJMHIMIPKME().SetFloat("_TreatBackfaceHitAsMiss", this.MovY);
			this.EJDPNJAEAKJ().SetFloat("ItemNameText", this.KJIKOEIAENF);
			this.OCHJIMJNEMO().SetVector("#ok", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1884f, 473f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x000AC26B File Offset: 0x000AA46B
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("LeaderboardsButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAJKLKJJKEJ()
	{
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x000AC28F File Offset: 0x000AA48F
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x000AC2B4 File Offset: 0x000AA4B4
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 230f)
			{
				this.HBJJOCHGOPH = 1600f;
			}
			this.OLHDPICFBOF().SetFloat("RestartButton", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("R2", this.Intensity);
			this.OLHDPICFBOF().SetFloat("\n\n• ", this.MovX);
			this.GBFOAHKAJEK().SetFloat("_Value4", this.MovY);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.KJIKOEIAENF);
			this.HKGAONMOBMH().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1972f, 1751f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void ALJEADNKJPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x000AC3B4 File Offset: 0x000AA5B4
	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 978f)
			{
				this.HBJJOCHGOPH = 1481f;
			}
			this.FLOHGDECHHH().SetFloat("FreqVolume: ", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat(" ", this.Intensity);
			this.KDMBOKLMADJ().SetFloat("Joystick1Button2", this.MovX);
			this.OGMEGHKECAH().SetFloat("CameraFilterPack/Gradients_ElectricGradient", this.MovY);
			this.EJDPNJAEAKJ().SetFloat("[Left]", this.KJIKOEIAENF);
			this.HKGAONMOBMH().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 787f, 1890f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x000AC4B3 File Offset: 0x000AA6B3
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x000AC4D7 File Offset: 0x000AA6D7
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("Please attach component to a Graphical UI component");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BF0 RID: 7152 RVA: 0x000AC4FC File Offset: 0x000AA6FC
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1124f)
			{
				this.HBJJOCHGOPH = 628f;
			}
			this.HEHKGPKLAKK().SetFloat("/", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("Keeping GameObject in the scene: ", this.Intensity);
			this.HEHKGPKLAKK().SetFloat("Object ID. Case-Sensitive", this.MovX);
			this.KDMBOKLMADJ().SetFloat("_BlurRadius4", this.MovY);
			this.KDMBOKLMADJ().SetFloat("_Value", this.KJIKOEIAENF);
			this.MNLKBFFKHIE().SetVector("[UI] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1481f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x000AC5FC File Offset: 0x000AA7FC
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 790f)
			{
				this.HBJJOCHGOPH = 1125f;
			}
			this.KDMBOKLMADJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("ready", this.Intensity);
			this.IGKFMCPDNOI().SetFloat("_Blue_R", this.MovX);
			this.NLFJGMBCICG().SetFloat("]", this.MovY);
			this.ADGHJOHKEHG().SetFloat("ticket", this.KJIKOEIAENF);
			this.KEMAALEODNH().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 112f, 1535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x000AC6FB File Offset: 0x000AA8FB
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x000AC732 File Offset: 0x000AA932
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x000AC769 File Offset: 0x000AA969
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void NDDNJNCINDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x000AC7A0 File Offset: 0x000AA9A0
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 952f)
			{
				this.HBJJOCHGOPH = 205f;
			}
			this.NBPKMLMCHFN.SetFloat("%", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("-", this.Intensity);
			this.HEHKGPKLAKK().SetFloat("_CenterX", this.MovX);
			this.ADGHJOHKEHG().SetFloat("_TileMaxLoop", this.MovY);
			this.KEMAALEODNH().SetFloat("ItemsUploader", this.KJIKOEIAENF);
			this.NBPKMLMCHFN.SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 148f, 130f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x000AC89F File Offset: 0x000AAA9F
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x000AC8C3 File Offset: 0x000AAAC3
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001BFD RID: 7165 RVA: 0x000AC8E7 File Offset: 0x000AAAE7
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001BFE RID: 7166 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x000AC91E File Offset: 0x000AAB1E
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x000AC958 File Offset: 0x000AAB58
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1103f)
			{
				this.HBJJOCHGOPH = 1078f;
			}
			this.EJDPNJAEAKJ().SetFloat("menu.enableselectormusic", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_MainTex2", this.Intensity);
			this.EOCCJGIGEGJ().SetFloat(".lastCheckpoint.perfectHits", this.MovX);
			this.OGMEGHKECAH().SetFloat("_Far", this.MovY);
			this.LELKBCALFCF().SetFloat("float,0", this.KJIKOEIAENF);
			this.MNLKBFFKHIE().SetVector("Triangle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 482f, 282f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x000ACA57 File Offset: 0x000AAC57
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("Can't SendMove. Turn is finished by this player.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x000ACA7B File Offset: 0x000AAC7B
	private void OGJJDKENBNC()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Print Audio Wave: Done");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x000ACA9F File Offset: 0x000AAC9F
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06001C07 RID: 7175 RVA: 0x000ACAC3 File Offset: 0x000AACC3
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

	// Token: 0x06001C08 RID: 7176 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x000ACAFA File Offset: 0x000AACFA
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x000ACB31 File Offset: 0x000AAD31
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x000ACBA7 File Offset: 0x000AADA7
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x000AAABE File Offset: 0x000A8CBE
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x000ACBE0 File Offset: 0x000AADE0
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1260f)
			{
				this.HBJJOCHGOPH = 259f;
			}
			this.MNLKBFFKHIE().SetFloat("SlidingArea", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("B:", this.Intensity);
			this.HEHKGPKLAKK().SetFloat("EventSystem", this.MovX);
			this.OCHJIMJNEMO().SetFloat("players", this.MovY);
			this.NBPKMLMCHFN.SetFloat("No peer to communicate with. ", this.KJIKOEIAENF);
			this.KDMBOKLMADJ().SetVector("_Green_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1988f, 1530f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x0002523B File Offset: 0x0002343B
	private void CPCDFMMLHLO()
	{
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x000ACCDF File Offset: 0x000AAEDF
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x000AB112 File Offset: 0x000A9312
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C17 RID: 7191 RVA: 0x000ACD18 File Offset: 0x000AAF18
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1557f)
			{
				this.HBJJOCHGOPH = 510f;
			}
			this.OCHJIMJNEMO().SetFloat("ENABLE_USER_LUT", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("USE_UV_BASED_REPROJECTION", this.Intensity);
			this.PDEAHJPOMEF().SetFloat(" ", this.MovX);
			this.OJMHIMIPKME().SetFloat("1", this.MovY);
			this.HKGAONMOBMH().SetFloat("Received OnSerialization for view ID ", this.KJIKOEIAENF);
			this.OJMHIMIPKME().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 635f, 249f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x000AC6FB File Offset: 0x000AA8FB
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040003D3 RID: 979
	public Shader SCShader;

	// Token: 0x040003D4 RID: 980
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003D5 RID: 981
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003D6 RID: 982
	private Material BJFKDHHMLJH;

	// Token: 0x040003D7 RID: 983
	[Range(-0.5f, 0.5f)]
	public float Intensity = 0.125f;

	// Token: 0x040003D8 RID: 984
	[Range(-2f, 2f)]
	public float MovX = 0.5f;

	// Token: 0x040003D9 RID: 985
	[Range(-2f, 2f)]
	public float MovY = 0.5f;

	// Token: 0x040003DA RID: 986
	[Range(0f, 10f)]
	private float KJIKOEIAENF = 1f;
}
