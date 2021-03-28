using System;
using UnityEngine;

// Token: 0x02000023 RID: 35
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Inverse")]
public class CameraFilterPack_3D_Inverse : MonoBehaviour
{
	// Token: 0x06000753 RID: 1875 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x0003900F File Offset: 0x0003720F
	private Material HBLDMJCOAHA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x0002523B File Offset: 0x0002343B
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00039046 File Offset: 0x00037246
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x0003907D File Offset: 0x0003727D
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("LeaderboardsButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void BMGPBIBPBLA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x000390A1 File Offset: 0x000372A1
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x000390C8 File Offset: 0x000372C8
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1245f)
			{
				this.HBJJOCHGOPH = 1541f;
			}
			this.ADBKPGFMNKO().SetFloat("_Value", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 480f)
				{
					this._Distance = 1384f;
				}
				if (this._Distance < 387f)
				{
					this._Distance = 1830f;
				}
				this.ADBKPGFMNKO().SetFloat("CameraFilterPack/AAA_Blood_Plus", this._Distance);
			}
			else
			{
				this.GCDFNHMJMIP().SetFloat("_Value2", this._Distance);
			}
			this.MCDGIILBNIF().SetFloat("Texture2", this._Size);
			this.CFEDGDGBCHE().SetFloat("[ERROR KEY {0}]", this._FixDistance);
			this.CEKJODEAMGB().SetFloat("Tab2Content", this.LightIntensity);
			this.LPPEPKGFOEM().SetFloat("steamid", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IGIAPKPKGPK().SetFloat("[DiscordController] Join request {0}#{1}: {2}", 1195f / farClipPlane);
			this.LPPEPKGFOEM().SetVector("LoadingStatusText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 35f, 1294f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00039290 File Offset: 0x00037490
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 750f)
			{
				this.HBJJOCHGOPH = 782f;
			}
			this.OLHDPICFBOF().SetFloat("#mapalreadyexistupdate", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1303f)
				{
					this._Distance = 1141f;
				}
				if (this._Distance < 545f)
				{
					this._Distance = 1552f;
				}
				this.FLGPDBBKAIP().SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction", this._Distance);
			}
			else
			{
				this.CEKJODEAMGB().SetFloat("_Intensity", this._Distance);
			}
			this.HHLFDHNEIAH().SetFloat("sounds/hit_normal", this._Size);
			this.EFDEIFCDAFG().SetFloat("_TimeX", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("There are too many cells created by your subdivision options. Maximum allowed number of cells is ", this.LightIntensity);
			this.FEAEGGCNIAA().SetFloat("PLEASE WAIT", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CEKJODEAMGB().SetFloat("#{0:00} '{1}'{2} {3}", 518f / farClipPlane);
			this.LONNIJMNKFB().SetVector(";", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1749f, 1436f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00039456 File Offset: 0x00037656
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x0003948D File Offset: 0x0003768D
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("Please define the RectTransform for the Center viewport of the scrollable area");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x0002523B File Offset: 0x0002343B
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x000394B1 File Offset: 0x000376B1
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("You need to have a Graphic control (such as an Image) for the list [");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x000394D5 File Offset: 0x000376D5
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x0003950C File Offset: 0x0003770C
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_MaxSteps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00039530 File Offset: 0x00037730
	private void IBJIBLHJKMG()
	{
		this.SCShader = Shader.Find("player.bluelifering");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00039554 File Offset: 0x00037754
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("_BgColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00039578 File Offset: 0x00037778
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("_Circle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x0003959C File Offset: 0x0003779C
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find("[PlayerBase] Invoke event ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x000395C0 File Offset: 0x000377C0
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x000395F7 File Offset: 0x000377F7
	private void DKEHGPPOKEA()
	{
		this.SCShader = Shader.Find("SAVE");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void JAFOCEDILNK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x0003961B File Offset: 0x0003781B
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("music");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x0003963F File Offset: 0x0003783F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Inverse");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00039663 File Offset: 0x00037863
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x0003969C File Offset: 0x0003789C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1853f)
			{
				this.HBJJOCHGOPH = 1392f;
			}
			this.CIAFLBFJLEJ().SetFloat("Texture2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1365f)
				{
					this._Distance = 770f;
				}
				if (this._Distance < 159f)
				{
					this._Distance = 666f;
				}
				this.ADBKPGFMNKO().SetFloat(".progress", this._Distance);
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("LoadingStatusText", this._Distance);
			}
			this.HBLDMJCOAHA().SetFloat("note.1", this._Size);
			this.LELKBCALFCF().SetFloat("Tab2Content", this._FixDistance);
			this.LDNADDJMIPK().SetFloat("_Visualize", this.LightIntensity);
			this.LDNADDJMIPK().SetFloat("/", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPMLLJKMAMP().SetFloat("_SoftZDistance", 915f / farClipPlane);
			this.LELKBCALFCF().SetVector("OnRelease", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 78f, 616f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x0002523B File Offset: 0x0002343B
	private void POEMOLBJDLG()
	{
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00039864 File Offset: 0x00037A64
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1756f)
			{
				this.HBJJOCHGOPH = 1330f;
			}
			this.JFDGLLEOPGB().SetFloat("_Blend", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1160f)
				{
					this._Distance = 1553f;
				}
				if (this._Distance < 1351f)
				{
					this._Distance = 1153f;
				}
				this.CIAFLBFJLEJ().SetFloat("CameraFilterPack/FX_Glitch2", this._Distance);
			}
			else
			{
				this.CIAFLBFJLEJ().SetFloat("Data/Maps/", this._Distance);
			}
			this.JFDGLLEOPGB().SetFloat("EnableRankingToggle", this._Size);
			this.ELBMIEOIABA().SetFloat("#reward: ", this._FixDistance);
			this.IGIAPKPKGPK().SetFloat("_Noise", this.LightIntensity);
			this.MCDGIILBNIF().SetFloat("Unknown player asked for PickupItems", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ELBMIEOIABA().SetFloat("BloodAlternative2", 1939f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_ColorRGB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 304f, 59f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x0002523B File Offset: 0x0002343B
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00039A2A File Offset: 0x00037C2A
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Subtract");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00039A4E File Offset: 0x00037C4E
	private void FEGJMDDIDIC()
	{
		this.SCShader = Shader.Find("DontDestroy");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00039A74 File Offset: 0x00037C74
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 917f)
			{
				this.HBJJOCHGOPH = 1851f;
			}
			this.OIMMPLPBLBK().SetFloat("LoadingStatusText", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1870f)
				{
					this._Distance = 1996f;
				}
				if (this._Distance < 125f)
				{
					this._Distance = 1612f;
				}
				this.IGIAPKPKGPK().SetFloat("int", this._Distance);
			}
			else
			{
				this.ADGHJOHKEHG().SetFloat("CameraFilterPack/Gradients_Rainbow", this._Distance);
			}
			this.IGKFMCPDNOI().SetFloat("w", this._Size);
			this.CIAFLBFJLEJ().SetFloat("UsernameText", this._FixDistance);
			this.OIMMPLPBLBK().SetFloat("/", this.LightIntensity);
			this.LDNADDJMIPK().SetFloat("AudioSampler", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat(" ", 15f / farClipPlane);
			this.EJDPNJAEAKJ().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1949f, 1322f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00039C3A File Offset: 0x00037E3A
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Blizzard1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00039C5E File Offset: 0x00037E5E
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("[");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00039C82 File Offset: 0x00037E82
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00039CA6 File Offset: 0x00037EA6
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("settings.enablehitsoundsinnormal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00039CCA File Offset: 0x00037ECA
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x00039CEE File Offset: 0x00037EEE
	private Material FNAFGEMJBDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00039D25 File Offset: 0x00037F25
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("https://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00039D49 File Offset: 0x00037F49
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00039D80 File Offset: 0x00037F80
	private void KODKKCOKEPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1490f)
			{
				this.HBJJOCHGOPH = 330f;
			}
			this.CIAFLBFJLEJ().SetFloat("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1263f)
				{
					this._Distance = 1874f;
				}
				if (this._Distance < 1978f)
				{
					this._Distance = 1469f;
				}
				this.OIIDAKBILMI().SetFloat("mapselector.filter.officialsortmode", this._Distance);
			}
			else
			{
				this.MALMMJNPILJ().SetFloat("Hex value #RRGGBB", this._Distance);
			}
			this.LPPEPKGFOEM().SetFloat("_MaxRadiusOrKInPaper", this._Size);
			this.MMOODGIODPC().SetFloat("_Value", this._FixDistance);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/FX_Glitch3", this.LightIntensity);
			this.MMOODGIODPC().SetFloat("EventSystem", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BBIMPFGLDCP().SetFloat("input", 1551f / farClipPlane);
			this.LPPEPKGFOEM().SetVector("_BgFade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 274f, 1406f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00039F46 File Offset: 0x00038146
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("_OcclusionTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00039F6C File Offset: 0x0003816C
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1402f)
			{
				this.HBJJOCHGOPH = 582f;
			}
			this.LDNADDJMIPK().SetFloat("Joystick1Button10", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 858f)
				{
					this._Distance = 1511f;
				}
				if (this._Distance < 26f)
				{
					this._Distance = 144f;
				}
				this.ELBMIEOIABA().SetFloat("mapselector.orderby", this._Distance);
			}
			else
			{
				this.HBLDMJCOAHA().SetFloat("CameraFilterPack_Paper1", this._Distance);
			}
			this.HHLFDHNEIAH().SetFloat("</color>", this._Size);
			this.LPPEPKGFOEM().SetFloat("Left", this._FixDistance);
			this.EFDEIFCDAFG().SetFloat("Vertical", this.LightIntensity);
			this.OLHDPICFBOF().SetFloat(".lastCheckpoint.lives", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFDEIFCDAFG().SetFloat("#done", 1878f / farClipPlane);
			this.ELBMIEOIABA().SetVector("_CenterY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 542f, 1182f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x0003A132 File Offset: 0x00038332
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x0003A169 File Offset: 0x00038369
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x0003A18D File Offset: 0x0003838D
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("Source: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x0003A1B1 File Offset: 0x000383B1
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("settings.fps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x0003A1D5 File Offset: 0x000383D5
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x0003A20C File Offset: 0x0003840C
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x0003A244 File Offset: 0x00038444
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1328f)
			{
				this.HBJJOCHGOPH = 758f;
			}
			this.LDNADDJMIPK().SetFloat("0,1,false", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1963f)
				{
					this._Distance = 255f;
				}
				if (this._Distance < 712f)
				{
					this._Distance = 1609f;
				}
				this.ADBKPGFMNKO().SetFloat("_Bloom2", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("_Value3", this._Distance);
			}
			this.OIMMPLPBLBK().SetFloat("_Green_R", this._Size);
			this.LELKBCALFCF().SetFloat("deletemap", this._FixDistance);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.LightIntensity);
			this.EJDPNJAEAKJ().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BBIMPFGLDCP().SetFloat("_TapMedium", 1921f / farClipPlane);
			this.LELKBCALFCF().SetVector("_Saturation", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 273f, 768f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x0003A40C File Offset: 0x0003860C
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1173f)
			{
				this.HBJJOCHGOPH = 856f;
			}
			this.MMOODGIODPC().SetFloat("_Value4", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 852f)
				{
					this._Distance = 1226f;
				}
				if (this._Distance < 1568f)
				{
					this._Distance = 1311f;
				}
				this.FLGPDBBKAIP().SetFloat("{0:0} hour{1}, ", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat(" canvas not found", this._Distance);
			}
			this.JFDGLLEOPGB().SetFloat("[RanksSystem] Ranks updated. Next update: ", this._Size);
			this.ELBMIEOIABA().SetFloat(" on effect ", this._FixDistance);
			this.CFEDGDGBCHE().SetFloat("_Value", this.LightIntensity);
			this.CIAFLBFJLEJ().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPPEPKGFOEM().SetFloat("_Bullet_11", 1462f / farClipPlane);
			this.OIIDAKBILMI().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 900f, 727f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FNAFGEMJBDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00039D49 File Offset: 0x00037F49
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

	// Token: 0x060007A3 RID: 1955 RVA: 0x0003A629 File Offset: 0x00038829
	private void DOFDGBGEDFI()
	{
		this.SCShader = Shader.Find("ready");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x0003A64D File Offset: 0x0003884D
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x0003A684 File Offset: 0x00038884
	private void HAAFIECGECG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 677f)
			{
				this.HBJJOCHGOPH = 777f;
			}
			this.HHIAIGCAHDA().SetFloat("ChangeSelectedLevel", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 220f)
				{
					this._Distance = 1576f;
				}
				if (this._Distance < 1439f)
				{
					this._Distance = 1179f;
				}
				this.LPPEPKGFOEM().SetFloat("_Axis", this._Distance);
			}
			else
			{
				this.HHIAIGCAHDA().SetFloat("_Value4", this._Distance);
			}
			this.OIMMPLPBLBK().SetFloat("settings.customdataskin", this._Size);
			this.EFDEIFCDAFG().SetFloat("_ScreenResolution", this._FixDistance);
			this.BBIMPFGLDCP().SetFloat("RecordButton", this.LightIntensity);
			this.MMOODGIODPC().SetFloat("Tab1Content", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FNAFGEMJBDA().SetFloat("_ContrastGainGamma", 1459f / farClipPlane);
			this.MALMMJNPILJ().SetVector("Sequence contains no elements", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 887f, 1498f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x0003A84C File Offset: 0x00038A4C
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 286f)
			{
				this.HBJJOCHGOPH = 448f;
			}
			this.LDNADDJMIPK().SetFloat(":\n", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1219f)
				{
					this._Distance = 1303f;
				}
				if (this._Distance < 794f)
				{
					this._Distance = 484f;
				}
				this.FAIFBBGFAIB().SetFloat(".lastCheckpoint.checkpointsUsed", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this._Distance);
			}
			this.ELBMIEOIABA().SetFloat("_FrustumCornersWS", this._Size);
			this.ADBKPGFMNKO().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", this._FixDistance);
			this.BBIMPFGLDCP().SetFloat("#exit", this.LightIntensity);
			this.HBLDMJCOAHA().SetFloat("note.0", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LONNIJMNKFB().SetFloat("color", 48f / farClipPlane);
			this.FLGPDBBKAIP().SetVector("ArcsDestroyDelaySlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1395f, 1845f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x0003AA14 File Offset: 0x00038C14
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1017f)
			{
				this.HBJJOCHGOPH = 1609f;
			}
			this.MALMMJNPILJ().SetFloat("SaveButton", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1271f)
				{
					this._Distance = 1303f;
				}
				if (this._Distance < 859f)
				{
					this._Distance = 224f;
				}
				this.HHIAIGCAHDA().SetFloat(": ", this._Distance);
			}
			else
			{
				this.LPPEPKGFOEM().SetFloat("downloading", this._Distance);
			}
			this.LPMLLJKMAMP().SetFloat("[PlayerBase] Reset", this._Size);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/Gradients_Desert", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("EXCEPTION:", this.LightIntensity);
			this.GCDFNHMJMIP().SetFloat("_Value5", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("[DiscordController] Init", 776f / farClipPlane);
			this.FEAEGGCNIAA().SetVector("grid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1855f, 554f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x0003ABDC File Offset: 0x00038DDC
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1327f)
			{
				this.HBJJOCHGOPH = 1799f;
			}
			this.BBIMPFGLDCP().SetFloat("Bad modpack name: {0}", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1911f)
				{
					this._Distance = 395f;
				}
				if (this._Distance < 1383f)
				{
					this._Distance = 1858f;
				}
				this.ADGHJOHKEHG().SetFloat("_Blend", this._Distance);
			}
			else
			{
				this.CIAFLBFJLEJ().SetFloat("id", this._Distance);
			}
			this.CFEDGDGBCHE().SetFloat("targetColor", this._Size);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Color_Chromatic_Plus", this._FixDistance);
			this.CIAFLBFJLEJ().SetFloat("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", this.LightIntensity);
			this.CIAFLBFJLEJ().SetFloat("_Radius", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GCDFNHMJMIP().SetFloat("PLAY [SPACE]", 1998f / farClipPlane);
			this.HHIAIGCAHDA().SetVector("CameraFilterPack_AAA_Blood2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1738f, 1842f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x0003ADA2 File Offset: 0x00038FA2
	private void HPFIHLMKIPF()
	{
		this.SCShader = Shader.Find("OPEN FILE");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x0003ADC8 File Offset: 0x00038FC8
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 770f)
			{
				this.HBJJOCHGOPH = 1257f;
			}
			this.ADGHJOHKEHG().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1387f)
				{
					this._Distance = 428f;
				}
				if (this._Distance < 1485f)
				{
					this._Distance = 143f;
				}
				this.CIAFLBFJLEJ().SetFloat(" not exist", this._Distance);
			}
			else
			{
				this.LONNIJMNKFB().SetFloat("gameVolume", this._Distance);
			}
			this.IGIAPKPKGPK().SetFloat("_TimeX", this._Size);
			this.OIIDAKBILMI().SetFloat("BitsData", this._FixDistance);
			this.OIIDAKBILMI().SetFloat("blue", this.LightIntensity);
			this.EFDEIFCDAFG().SetFloat("challenges.", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OIMMPLPBLBK().SetFloat("OK", 1862f / farClipPlane);
			this.FNAFGEMJBDA().SetVector("Oct", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1371f, 1265f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x0003AF8E File Offset: 0x0003918E
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("settings.arcsnohitsoundtimedelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x0003AFB2 File Offset: 0x000391B2
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x0003AFE9 File Offset: 0x000391E9
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x0003B020 File Offset: 0x00039220
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void DIGHKAJILJH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x0003B057 File Offset: 0x00039257
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x0003B07C File Offset: 0x0003927C
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
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1f)
				{
					this._Distance = -1f;
				}
				if (this._Distance < -1f)
				{
					this._Distance = 1f;
				}
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_Far", this._Size);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_FarCamera", 1000f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x0003B242 File Offset: 0x00039442
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("_BlurDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x0003B266 File Offset: 0x00039466
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x0003B29D File Offset: 0x0003949D
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("_CenterY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x0003B2C4 File Offset: 0x000394C4
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1911f)
			{
				this.HBJJOCHGOPH = 778f;
			}
			this.ADGHJOHKEHG().SetFloat("IntraSig", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1444f)
				{
					this._Distance = 1110f;
				}
				if (this._Distance < 983f)
				{
					this._Distance = 606f;
				}
				this.NBPKMLMCHFN.SetFloat("Edited unlock conditions", this._Distance);
			}
			else
			{
				this.BBIMPFGLDCP().SetFloat("settings.disablestoryboard", this._Distance);
			}
			this.LPPEPKGFOEM().SetFloat("RespawnAfter", this._Size);
			this.IGIAPKPKGPK().SetFloat("/", this._FixDistance);
			this.LONNIJMNKFB().SetFloat("_Red_R", this.LightIntensity);
			this.BBIMPFGLDCP().SetFloat("set environment id", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MALMMJNPILJ().SetFloat("_Value3", 1096f / farClipPlane);
			this.EFDEIFCDAFG().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 306f, 23f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x0003B48C File Offset: 0x0003968C
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 488f)
			{
				this.HBJJOCHGOPH = 699f;
			}
			this.MCDGIILBNIF().SetFloat("_DotSize", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 283f)
				{
					this._Distance = 143f;
				}
				if (this._Distance < 1122f)
				{
					this._Distance = 1244f;
				}
				this.ADBKPGFMNKO().SetFloat("1.87", this._Distance);
			}
			else
			{
				this.LPMLLJKMAMP().SetFloat("CameraFilterPack/TV_Rgb", this._Distance);
			}
			this.IGIAPKPKGPK().SetFloat("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", this._Size);
			this.MMOODGIODPC().SetFloat("[MapEditor] Loading map: ", this._FixDistance);
			this.CIAFLBFJLEJ().SetFloat("LoadMapCanvas", this.LightIntensity);
			this.HBLDMJCOAHA().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CIAFLBFJLEJ().SetFloat("_LutTex", 117f / farClipPlane);
			this.OLHDPICFBOF().SetVector("on master", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1579f, 437f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x0003B652 File Offset: 0x00039852
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x0003B689 File Offset: 0x00039889
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x0003B6C0 File Offset: 0x000398C0
	private void MODENHKMKOC()
	{
		this.SCShader = Shader.Find(". Check if the server is available.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x0003B6E4 File Offset: 0x000398E4
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x0003B71B File Offset: 0x0003991B
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x0003B73F File Offset: 0x0003993F
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x0003B778 File Offset: 0x00039978
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1335f)
			{
				this.HBJJOCHGOPH = 589f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1762f)
				{
					this._Distance = 1850f;
				}
				if (this._Distance < 1902f)
				{
					this._Distance = 113f;
				}
				this.FLGPDBBKAIP().SetFloat("CameraFilterPack/3D_Scan_Scene", this._Distance);
			}
			else
			{
				this.OIMMPLPBLBK().SetFloat("Editor/", this._Distance);
			}
			this.IGIAPKPKGPK().SetFloat("OK", this._Size);
			this.CEKJODEAMGB().SetFloat("-", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("LoadingStatusText", this.LightIntensity);
			this.LPMLLJKMAMP().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CEKJODEAMGB().SetFloat("float,1", 692f / farClipPlane);
			this.HHLFDHNEIAH().SetVector("Preparing content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1100f, 1624f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x0003B940 File Offset: 0x00039B40
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1606f)
			{
				this.HBJJOCHGOPH = 700f;
			}
			this.ADBKPGFMNKO().SetFloat("image", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1884f)
				{
					this._Distance = 1411f;
				}
				if (this._Distance < 347f)
				{
					this._Distance = 612f;
				}
				this.LPMLLJKMAMP().SetFloat("settings.gamemessagesduration", this._Distance);
			}
			else
			{
				this.HHIAIGCAHDA().SetFloat("View ({3}){0} on {1} {2}", this._Distance);
			}
			this.LDNADDJMIPK().SetFloat("Items/", this._Size);
			this.GCDFNHMJMIP().SetFloat("_Green_R", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("#FFFFFFFF", this.LightIntensity);
			this.OIIDAKBILMI().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LDNADDJMIPK().SetFloat("[NetworkManager] Exited", 499f / farClipPlane);
			this.FLGPDBBKAIP().SetVector("GhostSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1239f, 759f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0003BB06 File Offset: 0x00039D06
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x0003BB3D File Offset: 0x00039D3D
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x0003BB74 File Offset: 0x00039D74
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 468f)
			{
				this.HBJJOCHGOPH = 123f;
			}
			this.OIIDAKBILMI().SetFloat("settings.shaders", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 470f)
				{
					this._Distance = 1325f;
				}
				if (this._Distance < 161f)
				{
					this._Distance = 1970f;
				}
				this.IGKFMCPDNOI().SetFloat("Joystick1Button3", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat("0 - background, 1 - foreground", this._Distance);
			}
			this.CEKJODEAMGB().SetFloat("OnStatusChanged: {0} current State: {1}", this._Size);
			this.CFEDGDGBCHE().SetFloat("float,0", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("no lives color", this.LightIntensity);
			this.GCDFNHMJMIP().SetFloat("CameraFilterPack/Distortion_Heat", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LELKBCALFCF().SetFloat("LoadingStatusText", 757f / farClipPlane);
			this.FAIFBBGFAIB().SetVector("settings.selectormapsperpage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1508f, 1127f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FNAFGEMJBDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x0003BD3A File Offset: 0x00039F3A
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x0003BD71 File Offset: 0x00039F71
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x0002523B File Offset: 0x0002343B
	private void CPCDFMMLHLO()
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x0003BDA8 File Offset: 0x00039FA8
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 651f)
			{
				this.HBJJOCHGOPH = 901f;
			}
			this.FAIFBBGFAIB().SetFloat("_Value13", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1840f)
				{
					this._Distance = 108f;
				}
				if (this._Distance < 83f)
				{
					this._Distance = 1149f;
				}
				this.FLGPDBBKAIP().SetFloat("\n\n• ", this._Distance);
			}
			else
			{
				this.IGIAPKPKGPK().SetFloat("Turn", this._Distance);
			}
			this.ELBMIEOIABA().SetFloat("_Value", this._Size);
			this.CIAFLBFJLEJ().SetFloat("shader.frost", this._FixDistance);
			this.FNAFGEMJBDA().SetFloat("MainButton", this.LightIntensity);
			this.HBLDMJCOAHA().SetFloat("_BlurDirectionPacked", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LELKBCALFCF().SetFloat("player.circle", 879f / farClipPlane);
			this.FNAFGEMJBDA().SetVector("CameraFilterPack/Blur_Noise", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1174f, 787f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x0003BF6E File Offset: 0x0003A16E
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x0003BFA8 File Offset: 0x0003A1A8
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 526f)
			{
				this.HBJJOCHGOPH = 822f;
			}
			this.HHIAIGCAHDA().SetFloat(",", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1631f)
				{
					this._Distance = 1920f;
				}
				if (this._Distance < 885f)
				{
					this._Distance = 748f;
				}
				this.IGKFMCPDNOI().SetFloat("_ScreenResolution", this._Distance);
			}
			else
			{
				this.HHLFDHNEIAH().SetFloat("Missing shader for image effect {0}", this._Distance);
			}
			this.HBLDMJCOAHA().SetFloat("_TimeX", this._Size);
			this.MMOODGIODPC().SetFloat("_ScreenResolution", this._FixDistance);
			this.LDNADDJMIPK().SetFloat("_Speed", this.LightIntensity);
			this.FLGPDBBKAIP().SetFloat("_PositionX", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EJDPNJAEAKJ().SetFloat("GlassesColor2", 1084f / farClipPlane);
			this.CFEDGDGBCHE().SetVector("FinishMap", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 539f, 46f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x0003C16E File Offset: 0x0003A36E
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x0003C1A5 File Offset: 0x0003A3A5
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x0003C1DC File Offset: 0x0003A3DC
	private void EKCJHNJGGAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1006f)
			{
				this.HBJJOCHGOPH = 635f;
			}
			this.CIAFLBFJLEJ().SetFloat("Data/Localization", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 286f)
				{
					this._Distance = 1497f;
				}
				if (this._Distance < 876f)
				{
					this._Distance = 1492f;
				}
				this.JFDGLLEOPGB().SetFloat("OK", this._Distance);
			}
			else
			{
				this.OLHDPICFBOF().SetFloat("_Value3", this._Distance);
			}
			this.HBLDMJCOAHA().SetFloat("deletemap", this._Size);
			this.HHLFDHNEIAH().SetFloat("achievements.26.progress", this._FixDistance);
			this.FNAFGEMJBDA().SetFloat("GhostPosX", this.LightIntensity);
			this.HBLDMJCOAHA().SetFloat("\n", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HHLFDHNEIAH().SetFloat("_ProjInfo", 217f / farClipPlane);
			this.MMOODGIODPC().SetVector("SetSatelliteColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1426f, 1624f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0003C3A4 File Offset: 0x0003A5A4
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 667f)
			{
				this.HBJJOCHGOPH = 766f;
			}
			this.MMOODGIODPC().SetFloat("Internal LUT", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1429f)
				{
					this._Distance = 1180f;
				}
				if (this._Distance < 1060f)
				{
					this._Distance = 1128f;
				}
				this.LPMLLJKMAMP().SetFloat("_ScreenResolution", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat(" left", this._Distance);
			}
			this.HHLFDHNEIAH().SetFloat("x", this._Size);
			this.ADBKPGFMNKO().SetFloat("_CenterX", this._FixDistance);
			this.HBLDMJCOAHA().SetFloat("_Light", this.LightIntensity);
			this.CEKJODEAMGB().SetFloat("21x3", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MMOODGIODPC().SetFloat("connect", 1196f / farClipPlane);
			this.FAIFBBGFAIB().SetVector("CameraFilterPack/Blend2Camera_Overlay", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 993f, 934f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x0003C56A File Offset: 0x0003A76A
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00038FF2 File Offset: 0x000371F2
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x0003C5A1 File Offset: 0x0003A7A1
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x0003C5D8 File Offset: 0x0003A7D8
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1996f)
			{
				this.HBJJOCHGOPH = 1689f;
			}
			this.EJDPNJAEAKJ().SetFloat(" {0}", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1569f)
				{
					this._Distance = 1754f;
				}
				if (this._Distance < 1976f)
				{
					this._Distance = 833f;
				}
				this.NBPKMLMCHFN.SetFloat("Items/", this._Distance);
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("#kicked", this._Distance);
			}
			this.LONNIJMNKFB().SetFloat("Mar", this._Size);
			this.ADGHJOHKEHG().SetFloat("value", this._FixDistance);
			this.CIAFLBFJLEJ().SetFloat("Failed to Instantiate prefab:", this.LightIntensity);
			this.CEKJODEAMGB().SetFloat("player.linea", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFDEIFCDAFG().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", 742f / farClipPlane);
			this.ADGHJOHKEHG().SetVector("[Right]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1046f, 929f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x0003C79E File Offset: 0x0003A99E
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x0003C7D5 File Offset: 0x0003A9D5
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("CrosshairOpacitySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x0003C7FC File Offset: 0x0003A9FC
	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1001f)
			{
				this.HBJJOCHGOPH = 499f;
			}
			this.BBIMPFGLDCP().SetFloat("_BlurCoe", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 602f)
				{
					this._Distance = 447f;
				}
				if (this._Distance < 1686f)
				{
					this._Distance = 434f;
				}
				this.JFDGLLEOPGB().SetFloat("_ExposureAdjustment", this._Distance);
			}
			else
			{
				this.GCDFNHMJMIP().SetFloat("B", this._Distance);
			}
			this.LONNIJMNKFB().SetFloat("LevelEditor/CustomEventEditor-Text", this._Size);
			this.FLGPDBBKAIP().SetFloat("OK", this._FixDistance);
			this.LELKBCALFCF().SetFloat("_Value3", this.LightIntensity);
			this.FAIFBBGFAIB().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HBLDMJCOAHA().SetFloat("NEW_ACHIEVEMENT_1_", 817f / farClipPlane);
			this.MCDGIILBNIF().SetVector("[MenuScene] Error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 13f, 1885f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x0003C9C4 File Offset: 0x0003ABC4
	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1466f)
			{
				this.HBJJOCHGOPH = 1822f;
			}
			this.CIAFLBFJLEJ().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 142f)
				{
					this._Distance = 1054f;
				}
				if (this._Distance < 1933f)
				{
					this._Distance = 79f;
				}
				this.HHIAIGCAHDA().SetFloat("_TimeX", this._Distance);
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("mapselector.lastSearch", this._Distance);
			}
			this.CFEDGDGBCHE().SetFloat("&", this._Size);
			this.FNAFGEMJBDA().SetFloat("CameraFilterPack/Drawing_Crosshatch", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("_Value2", this.LightIntensity);
			this.OIMMPLPBLBK().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MMOODGIODPC().SetFloat("00", 121f / farClipPlane);
			this.CIAFLBFJLEJ().SetVector("_DistortionLevel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1241f, 325f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x0003CB8C File Offset: 0x0003AD8C
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 117f)
			{
				this.HBJJOCHGOPH = 943f;
			}
			this.LONNIJMNKFB().SetFloat("Default UI Material", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1166f)
				{
					this._Distance = 1657f;
				}
				if (this._Distance < 793f)
				{
					this._Distance = 757f;
				}
				this.FAIFBBGFAIB().SetFloat("setAF", this._Distance);
			}
			else
			{
				this.LELKBCALFCF().SetFloat("settings.enablehitsoundsinrelax", this._Distance);
			}
			this.LONNIJMNKFB().SetFloat("_Value", this._Size);
			this.GCDFNHMJMIP().SetFloat("Electronic", this._FixDistance);
			this.IGKFMCPDNOI().SetFloat("ICollection", this.LightIntensity);
			this.ADGHJOHKEHG().SetFloat("SAVE", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FLGPDBBKAIP().SetFloat("BestRegion checks region: ", 504f / farClipPlane);
			this.LONNIJMNKFB().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1847f, 1775f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x0003CD54 File Offset: 0x0003AF54
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 808f)
			{
				this.HBJJOCHGOPH = 1105f;
			}
			this.NBPKMLMCHFN.SetFloat("setstring", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 474f)
				{
					this._Distance = 1004f;
				}
				if (this._Distance < 1859f)
				{
					this._Distance = 1050f;
				}
				this.MALMMJNPILJ().SetFloat("Set Satellite Emission", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("_Value", this._Distance);
			}
			this.EJDPNJAEAKJ().SetFloat("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", this._Size);
			this.LDNADDJMIPK().SetFloat("_Value2", this._FixDistance);
			this.FNAFGEMJBDA().SetFloat("shader.sunny", this.LightIntensity);
			this.MALMMJNPILJ().SetFloat(" with a prefix of ", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OIIDAKBILMI().SetFloat("/", 1395f / farClipPlane);
			this.ELBMIEOIABA().SetVector("Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1972f, 150f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x0003CF1A File Offset: 0x0003B11A
	private Material MALMMJNPILJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x0400012B RID: 299
	public Shader SCShader;

	// Token: 0x0400012C RID: 300
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400012D RID: 301
	public bool _Visualize;

	// Token: 0x0400012E RID: 302
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400012F RID: 303
	private Material BJFKDHHMLJH;

	// Token: 0x04000130 RID: 304
	[Range(0f, 100f)]
	public float _FixDistance = 1.5f;

	// Token: 0x04000131 RID: 305
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.4f;

	// Token: 0x04000132 RID: 306
	[Range(0f, 0.5f)]
	public float _Size = 0.5f;

	// Token: 0x04000133 RID: 307
	[Range(0f, 1f)]
	public float LightIntensity = 1f;

	// Token: 0x04000134 RID: 308
	public bool AutoAnimatedNear;

	// Token: 0x04000135 RID: 309
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x04000136 RID: 310
	public static Color ChangeColorRGB;
}
