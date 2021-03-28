using System;
using UnityEngine;

// Token: 0x020000EC RID: 236
[AddComponentMenu("Camera Filter Pack/Light/Rainbow2")]
[ExecuteInEditMode]
public class CameraFilterPack_Light_Rainbow2 : MonoBehaviour
{
	// Token: 0x06004886 RID: 18566 RVA: 0x00162804 File Offset: 0x00160A04
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004887 RID: 18567 RVA: 0x00162824 File Offset: 0x00160A24
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1859f)
			{
				this.HBJJOCHGOPH = 557f;
			}
			this.FOOCJIDNGBB().SetFloat("y", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("/", this.Value);
			this.NBMPPNFKFLB().SetVector("InfoCanvas", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1584f, 592f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004888 RID: 18568 RVA: 0x001628E4 File Offset: 0x00160AE4
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1102f)
			{
				this.HBJJOCHGOPH = 1635f;
			}
			this.FLGPDBBKAIP().SetFloat("Fade", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("ns.exitgames.com", this.Value);
			this.DBOLLHHMKKN().SetVector("PossibleMapPointsText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1114f, 790f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004889 RID: 18569 RVA: 0x00162804 File Offset: 0x00160A04
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600488A RID: 18570 RVA: 0x001629A4 File Offset: 0x00160BA4
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 543f)
			{
				this.HBJJOCHGOPH = 831f;
			}
			this.DBOLLHHMKKN().SetFloat("w", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("Authentication failed: '{0}' Code: {1}", this.Value);
			this.ACHNOHCLGOO().SetVector("null", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1654f, 970f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600488B RID: 18571 RVA: 0x00162A61 File Offset: 0x00160C61
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600488C RID: 18572 RVA: 0x00162804 File Offset: 0x00160A04
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600488D RID: 18573 RVA: 0x00162804 File Offset: 0x00160A04
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600488E RID: 18574 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600488F RID: 18575 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06004890 RID: 18576 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06004891 RID: 18577 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06004892 RID: 18578 RVA: 0x00162804 File Offset: 0x00160A04
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004893 RID: 18579 RVA: 0x00162A98 File Offset: 0x00160C98
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("[MapsData] Installed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004894 RID: 18580 RVA: 0x00162804 File Offset: 0x00160A04
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004895 RID: 18581 RVA: 0x00162ABC File Offset: 0x00160CBC
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1221f)
			{
				this.HBJJOCHGOPH = 953f;
			}
			this.NLFJGMBCICG().SetFloat("-", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("GLITCH", this.Value);
			this.OOMFJGPAOKL().SetVector(".", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 54f, 694f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004896 RID: 18582 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06004897 RID: 18583 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06004898 RID: 18584 RVA: 0x00162B7C File Offset: 0x00160D7C
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004899 RID: 18585 RVA: 0x00162804 File Offset: 0x00160A04
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600489A RID: 18586 RVA: 0x00162C39 File Offset: 0x00160E39
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600489B RID: 18587 RVA: 0x00162C70 File Offset: 0x00160E70
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600489C RID: 18588 RVA: 0x00162CA7 File Offset: 0x00160EA7
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600489D RID: 18589 RVA: 0x00162CE0 File Offset: 0x00160EE0
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1916f)
			{
				this.HBJJOCHGOPH = 382f;
			}
			this.HNICHJCGJOC().SetFloat("{0}={2}: {1} \"{3}\"", this.HBJJOCHGOPH);
			this.FOOCJIDNGBB().SetFloat("Loading", this.Value);
			this.GJHPODJOBHL().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 507f, 201f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600489E RID: 18590 RVA: 0x00162D9D File Offset: 0x00160F9D
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600489F RID: 18591 RVA: 0x00162DD4 File Offset: 0x00160FD4
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048A0 RID: 18592 RVA: 0x00162E0B File Offset: 0x0016100B
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048A1 RID: 18593 RVA: 0x00162E44 File Offset: 0x00161044
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 881f)
			{
				this.HBJJOCHGOPH = 145f;
			}
			this.DKKBFFHBHJE().SetFloat("CurrentTimeLabel", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_Val3", this.Value);
			this.FOOCJIDNGBB().SetVector(". This client's player: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1504f, 1896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048A2 RID: 18594 RVA: 0x00162F01 File Offset: 0x00161101
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048A3 RID: 18595 RVA: 0x00162F38 File Offset: 0x00161138
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("Oct");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060048A4 RID: 18596 RVA: 0x00162F5C File Offset: 0x0016115C
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("' ping: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060048A5 RID: 18597 RVA: 0x00162F80 File Offset: 0x00161180
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048A6 RID: 18598 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x060048A7 RID: 18599 RVA: 0x00162FB7 File Offset: 0x001611B7
	private void IKDNLHLBHID()
	{
		this.SCShader = Shader.Find("Loading");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060048A8 RID: 18600 RVA: 0x00162FDB File Offset: 0x001611DB
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("Editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060048A9 RID: 18601 RVA: 0x00162FFF File Offset: 0x001611FF
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060048AA RID: 18602 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060048AB RID: 18603 RVA: 0x00163023 File Offset: 0x00161223
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find(". Not Destroying GameObject or PhotonViews!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060048AC RID: 18604 RVA: 0x00163047 File Offset: 0x00161247
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060048AD RID: 18605 RVA: 0x0016306B File Offset: 0x0016126B
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048AE RID: 18606 RVA: 0x00162804 File Offset: 0x00160A04
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048AF RID: 18607 RVA: 0x00162804 File Offset: 0x00160A04
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048B0 RID: 18608 RVA: 0x001630A2 File Offset: 0x001612A2
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("ItemTemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060048B1 RID: 18609 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060048B2 RID: 18610 RVA: 0x001630C8 File Offset: 0x001612C8
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 574f)
			{
				this.HBJJOCHGOPH = 774f;
			}
			this.DOMEEFLPEPJ().SetFloat("menu.enableselectormusic", this.HBJJOCHGOPH);
			this.FLGPDBBKAIP().SetFloat("#failed: ", this.Value);
			this.NLFJGMBCICG().SetVector(".status", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1871f, 1769f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048B3 RID: 18611 RVA: 0x00162804 File Offset: 0x00160A04
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048B4 RID: 18612 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x060048B5 RID: 18613 RVA: 0x00163185 File Offset: 0x00161385
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("Waiting for AvailableRegions. State: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060048B6 RID: 18614 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x060048B7 RID: 18615 RVA: 0x001631A9 File Offset: 0x001613A9
	private void MEBPBNLBECA()
	{
		this.SCShader = Shader.Find("ready");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060048B8 RID: 18616 RVA: 0x001631D0 File Offset: 0x001613D0
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1215f)
			{
				this.HBJJOCHGOPH = 1564f;
			}
			this.HNICHJCGJOC().SetFloat("???", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat(" ", this.Value);
			this.GJHPODJOBHL().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1126f, 452f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048B9 RID: 18617 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x060048BA RID: 18618 RVA: 0x0016328D File Offset: 0x0016148D
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_BrokenGlass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060048BB RID: 18619 RVA: 0x001632B1 File Offset: 0x001614B1
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048BC RID: 18620 RVA: 0x001632E8 File Offset: 0x001614E8
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048BD RID: 18621 RVA: 0x00163320 File Offset: 0x00161520
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 244f)
			{
				this.HBJJOCHGOPH = 1387f;
			}
			this.CECJJMKLEAK().SetFloat("Set Sun MinSize", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("Joystick1Button4", this.Value);
			this.GJHPODJOBHL().SetVector(".b", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 678f, 1261f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048BE RID: 18622 RVA: 0x00162804 File Offset: 0x00160A04
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048BF RID: 18623 RVA: 0x001633DD File Offset: 0x001615DD
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("#no");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060048C0 RID: 18624 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x060048C1 RID: 18625 RVA: 0x00163401 File Offset: 0x00161601
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048C2 RID: 18626 RVA: 0x00163438 File Offset: 0x00161638
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1128f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.HNICHJCGJOC().SetFloat("received</b>\n#reason: ", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("_MainTex2", this.Value);
			this.GJHPODJOBHL().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1848f, 559f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048C3 RID: 18627 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x060048C4 RID: 18628 RVA: 0x001634F5 File Offset: 0x001616F5
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048C5 RID: 18629 RVA: 0x0016352C File Offset: 0x0016172C
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048C6 RID: 18630 RVA: 0x00163564 File Offset: 0x00161764
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1691f)
			{
				this.HBJJOCHGOPH = 350f;
			}
			this.EFDEIFCDAFG().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("OneHand", this.Value);
			this.DOMEEFLPEPJ().SetVector("menutheme", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 212f, 1351f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048C7 RID: 18631 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x060048C8 RID: 18632 RVA: 0x00163624 File Offset: 0x00161824
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 116f)
			{
				this.HBJJOCHGOPH = 1650f;
			}
			this.HHIFMIPPMPF().SetFloat("z", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("+", this.Value);
			this.HNICHJCGJOC().SetVector("_LutTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 97f, 1453f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048C9 RID: 18633 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x060048CA RID: 18634 RVA: 0x00162804 File Offset: 0x00160A04
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048CB RID: 18635 RVA: 0x001636E1 File Offset: 0x001618E1
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048CC RID: 18636 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x060048CD RID: 18637 RVA: 0x00163718 File Offset: 0x00161918
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1109f)
			{
				this.HBJJOCHGOPH = 25f;
			}
			this.MFHPKGICPIO().SetFloat("StartCanvas", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("maps.", this.Value);
			this.NBPKMLMCHFN.SetVector("_History4LumaTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 9f, 1180f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048CE RID: 18638 RVA: 0x00162804 File Offset: 0x00160A04
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048CF RID: 18639 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060048D0 RID: 18640 RVA: 0x001637D8 File Offset: 0x001619D8
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 827f)
			{
				this.HBJJOCHGOPH = 1656f;
			}
			this.GJHPODJOBHL().SetFloat("CameraFilterPack/FX_8bits_gb", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this.Value);
			this.NLFJGMBCICG().SetVector("inventory.itemscash", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1087f, 705f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048D1 RID: 18641 RVA: 0x00163895 File Offset: 0x00161A95
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048D2 RID: 18642 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x060048D3 RID: 18643 RVA: 0x001638CC File Offset: 0x00161ACC
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 414f)
			{
				this.HBJJOCHGOPH = 775f;
			}
			this.BAGICADFBAB().SetFloat("</i>", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", this.Value);
			this.FLGPDBBKAIP().SetVector("Created", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 75f, 541f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048D4 RID: 18644 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060048D5 RID: 18645 RVA: 0x00162804 File Offset: 0x00160A04
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048D6 RID: 18646 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x060048D7 RID: 18647 RVA: 0x00163989 File Offset: 0x00161B89
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060048D8 RID: 18648 RVA: 0x00162804 File Offset: 0x00160A04
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048D9 RID: 18649 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x060048DA RID: 18650 RVA: 0x00162804 File Offset: 0x00160A04
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048DB RID: 18651 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x060048DC RID: 18652 RVA: 0x001639B0 File Offset: 0x00161BB0
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 49f)
			{
				this.HBJJOCHGOPH = 1460f;
			}
			this.NBMPPNFKFLB().SetFloat(".completed", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("GlassesColor2", this.Value);
			this.EFDEIFCDAFG().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1310f, 722f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048DD RID: 18653 RVA: 0x00163A6D File Offset: 0x00161C6D
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Light_Rainbow2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060048DE RID: 18654 RVA: 0x00163A91 File Offset: 0x00161C91
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048DF RID: 18655 RVA: 0x00163AC8 File Offset: 0x00161CC8
	private void AEMGPJDJGBJ()
	{
		this.SCShader = Shader.Find("Finished");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060048E0 RID: 18656 RVA: 0x00162804 File Offset: 0x00160A04
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048E1 RID: 18657 RVA: 0x00162804 File Offset: 0x00160A04
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048E2 RID: 18658 RVA: 0x00163AEC File Offset: 0x00161CEC
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("SetSatelliteTrailLength");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060048E3 RID: 18659 RVA: 0x00163B10 File Offset: 0x00161D10
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 424f)
			{
				this.HBJJOCHGOPH = 94f;
			}
			this.KEMAALEODNH().SetFloat("ChallengesButton", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("_ScreenResolution", this.Value);
			this.BAGICADFBAB().SetVector("#combo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 860f, 1982f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048E4 RID: 18660 RVA: 0x00163BCD File Offset: 0x00161DCD
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("InfoCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060048E5 RID: 18661 RVA: 0x00163BF1 File Offset: 0x00161DF1
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048E6 RID: 18662 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x060048E7 RID: 18663 RVA: 0x00163C28 File Offset: 0x00161E28
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048E8 RID: 18664 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x060048EA RID: 18666 RVA: 0x00163C80 File Offset: 0x00161E80
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1184f)
			{
				this.HBJJOCHGOPH = 1167f;
			}
			this.DBOLLHHMKKN().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("Set Satellite Trail Width", this.Value);
			this.NBPKMLMCHFN.SetVector("/icon", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 101f, 324f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048EB RID: 18667 RVA: 0x00163D3D File Offset: 0x00161F3D
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048EC RID: 18668 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x060048ED RID: 18669 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060048EE RID: 18670 RVA: 0x00163D74 File Offset: 0x00161F74
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048EF RID: 18671 RVA: 0x00163DAB File Offset: 0x00161FAB
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048F0 RID: 18672 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060048F1 RID: 18673 RVA: 0x00162804 File Offset: 0x00160A04
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048F2 RID: 18674 RVA: 0x00163DE2 File Offset: 0x00161FE2
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048F3 RID: 18675 RVA: 0x00163E1C File Offset: 0x0016201C
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1783f)
			{
				this.HBJJOCHGOPH = 719f;
			}
			this.HKGAONMOBMH().SetFloat("UI Extensions/UI Image Crop", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("...", this.Value);
			this.EOCCJGIGEGJ().SetVector("Please attach component to a Graphical UI component", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 965f, 1206f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048F4 RID: 18676 RVA: 0x0016352C File Offset: 0x0016172C
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060048F5 RID: 18677 RVA: 0x00163EDC File Offset: 0x001620DC
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 728f)
			{
				this.HBJJOCHGOPH = 11f;
			}
			this.NBPKMLMCHFN.SetFloat("Instantiating: ", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("_TimeX", this.Value);
			this.OOMFJGPAOKL().SetVector("<command>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1964f, 1220f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048F6 RID: 18678 RVA: 0x00162804 File Offset: 0x00160A04
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048F7 RID: 18679 RVA: 0x00163F99 File Offset: 0x00162199
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x060048F8 RID: 18680 RVA: 0x00163FD0 File Offset: 0x001621D0
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

	// Token: 0x060048F9 RID: 18681 RVA: 0x00164007 File Offset: 0x00162207
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Blurry");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060048FA RID: 18682 RVA: 0x00162804 File Offset: 0x00160A04
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060048FB RID: 18683 RVA: 0x0016402C File Offset: 0x0016222C
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 160f)
			{
				this.HBJJOCHGOPH = 1371f;
			}
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Vision_Blood", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("menu.selectedplaymode", this.Value);
			this.HNICHJCGJOC().SetVector("/../", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1504f, 1042f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048FC RID: 18684 RVA: 0x001640EC File Offset: 0x001622EC
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 934f)
			{
				this.HBJJOCHGOPH = 183f;
			}
			this.BAGICADFBAB().SetFloat("settings.arcshitsoundtimedelay", this.HBJJOCHGOPH);
			this.FLGPDBBKAIP().SetFloat(" Remote called.", this.Value);
			this.NBMPPNFKFLB().SetVector("Created by ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 876f, 1435f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048FD RID: 18685 RVA: 0x001641AC File Offset: 0x001623AC
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 465f)
			{
				this.HBJJOCHGOPH = 551f;
			}
			this.DOMEEFLPEPJ().SetFloat("Maps Editor v.", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("UI/Particles/Hidden", this.Value);
			this.NLFJGMBCICG().SetVector("_AdaptTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1557f, 342f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060048FE RID: 18686 RVA: 0x00164269 File Offset: 0x00162469
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("UseFinalGlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040007AC RID: 1964
	public Shader SCShader;

	// Token: 0x040007AD RID: 1965
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007AE RID: 1966
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007AF RID: 1967
	private Material BJFKDHHMLJH;

	// Token: 0x040007B0 RID: 1968
	[Range(0.01f, 5f)]
	public float Value = 1.5f;
}
