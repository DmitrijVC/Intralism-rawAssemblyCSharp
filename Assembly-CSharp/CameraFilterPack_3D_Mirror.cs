using System;
using UnityEngine;

// Token: 0x02000025 RID: 37
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Mirror")]
public class CameraFilterPack_3D_Mirror : MonoBehaviour
{
	// Token: 0x06000872 RID: 2162 RVA: 0x00040B9D File Offset: 0x0003ED9D
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00040BD4 File Offset: 0x0003EDD4
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x00040C0B File Offset: 0x0003EE0B
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("JoinRoom failed. A roomname is required. If you don't know one, how will you join?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00040C30 File Offset: 0x0003EE30
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1020f)
			{
				this.HBJJOCHGOPH = 1704f;
			}
			this.MMOODGIODPC().SetFloat(" - StoreAuthURLResponse] - ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1908f)
				{
					this._Distance = 1116f;
				}
				if (this._Distance < 880f)
				{
					this._Distance = 555f;
				}
				this.DOHGBNPMBKG().SetFloat("mapselector.filter.officialsortmode", this._Distance);
			}
			else
			{
				this.HKGAONMOBMH().SetFloat("BitsData", this._Distance);
			}
			this.KHCLIAMBBNC().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this._Size);
			this.EPCGJFCCAFH().SetFloat("z", this._FixDistance);
			this.NJDIODJNGGA().SetFloat(" not exist", this.Fade);
			this.EOCCJGIGEGJ().SetFloat("inventory.selected.", this.Lightning);
			this.BBIMPFGLDCP().SetFloat("Destroy all spawned environment objects", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MHBAIEKFBIJ().SetFloat("id", 394f / farClipPlane);
			this.MFHPKGICPIO().SetVector("BadgeImage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 610f, 604f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00040E0C File Offset: 0x0003F00C
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00040E43 File Offset: 0x0003F043
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00040E60 File Offset: 0x0003F060
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 522f)
			{
				this.HBJJOCHGOPH = 1229f;
			}
			this.KHCLIAMBBNC().SetFloat("cancel", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 621f)
				{
					this._Distance = 679f;
				}
				if (this._Distance < 587f)
				{
					this._Distance = 167f;
				}
				this.EOCCJGIGEGJ().SetFloat("GameScene", this._Distance);
			}
			else
			{
				this.OOMFJGPAOKL().SetFloat("ConfigVersionSlider", this._Distance);
			}
			this.FOOCJIDNGBB().SetFloat("_ScreenResolution", this._Size);
			this.NBPKMLMCHFN.SetFloat("Set Object Position", this._FixDistance);
			this.BBIMPFGLDCP().SetFloat("IntraTime", this.Fade);
			this.LMLENGFLEBD().SetFloat("float,1.5", this.Lightning);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/Blend2Camera_Difference", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KBOPGONOCNP().SetFloat("_NoiseTex", 57f / farClipPlane);
			this.FKEOGPDLBDD().SetVector("Share", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 569f, 1414f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x0004103C File Offset: 0x0003F23C
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00040E43 File Offset: 0x0003F043
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x00041074 File Offset: 0x0003F274
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 523f)
			{
				this.HBJJOCHGOPH = 232f;
			}
			this.CFEDGDGBCHE().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1503f)
				{
					this._Distance = 655f;
				}
				if (this._Distance < 77f)
				{
					this._Distance = 38f;
				}
				this.FOOCJIDNGBB().SetFloat("cancel", this._Distance);
			}
			else
			{
				this.DOHGBNPMBKG().SetFloat("[PlayerController] ", this._Distance);
			}
			this.EJDPNJAEAKJ().SetFloat("loadscene", this._Size);
			this.KEMJNOMIPHN().SetFloat("_Value", this._FixDistance);
			this.MHBAIEKFBIJ().SetFloat("_Blue_R", this.Fade);
			this.FEAEGGCNIAA().SetFloat("TwoHands", this.Lightning);
			this.OOMFJGPAOKL().SetFloat("_Value", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KBOPGONOCNP().SetFloat("SetPlayerDistance", 1070f / farClipPlane);
			this.MFHPKGICPIO().SetVector("SetSatelliteLerpSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1870f, 1571f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00041250 File Offset: 0x0003F450
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("_AdaptionSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00041274 File Offset: 0x0003F474
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x000412AB File Offset: 0x0003F4AB
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00040E43 File Offset: 0x0003F043
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x000412CF File Offset: 0x0003F4CF
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x00040E43 File Offset: 0x0003F043
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x00041308 File Offset: 0x0003F508
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1002f)
			{
				this.HBJJOCHGOPH = 1536f;
			}
			this.NLFJGMBCICG().SetFloat("_Value2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1495f)
				{
					this._Distance = 603f;
				}
				if (this._Distance < 1036f)
				{
					this._Distance = 827f;
				}
				this.ABHDNGIHBKE().SetFloat("MenuScene", this._Distance);
			}
			else
			{
				this.MFHPKGICPIO().SetFloat("maps.", this._Distance);
			}
			this.DOHGBNPMBKG().SetFloat("_Value4", this._Size);
			this.EPCGJFCCAFH().SetFloat("maps.", this._FixDistance);
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.Fade);
			this.LMLENGFLEBD().SetFloat("_DistortionLevel", this.Lightning);
			this.BBIMPFGLDCP().SetFloat("PlayerBase_", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NJDIODJNGGA().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", 680f / farClipPlane);
			this.CFEDGDGBCHE().SetVector("ShowSprite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 864f, 416f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x000414E4 File Offset: 0x0003F6E4
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x00040E43 File Offset: 0x0003F043
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00041508 File Offset: 0x0003F708
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("Joystick1Button11");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x00040E43 File Offset: 0x0003F043
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x0004152C File Offset: 0x0003F72C
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00041563 File Offset: 0x0003F763
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x0004159A File Offset: 0x0003F79A
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x00040E43 File Offset: 0x0003F043
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x000415D1 File Offset: 0x0003F7D1
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x000415F5 File Offset: 0x0003F7F5
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00040E43 File Offset: 0x0003F043
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x0004162C File Offset: 0x0003F82C
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("Down ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00041650 File Offset: 0x0003F850
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("sprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00041674 File Offset: 0x0003F874
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1152f)
			{
				this.HBJJOCHGOPH = 1118f;
			}
			this.DOHGBNPMBKG().SetFloat("[SaveSystem] Init from ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1957f)
				{
					this._Distance = 579f;
				}
				if (this._Distance < 971f)
				{
					this._Distance = 1934f;
				}
				this.EJDPNJAEAKJ().SetFloat("ERROR You should never change PhotonPlayer IDs!", this._Distance);
			}
			else
			{
				this.ABHDNGIHBKE().SetFloat("???", this._Distance);
			}
			this.EJDPNJAEAKJ().SetFloat("CurrentTimeLabel", this._Size);
			this.LMLENGFLEBD().SetFloat("USE_CORNER_DETECTION", this._FixDistance);
			this.KHCLIAMBBNC().SetFloat("EnableRankedNotificationsToggle", this.Fade);
			this.HKGAONMOBMH().SetFloat("UpperMid", this.Lightning);
			this.ABHDNGIHBKE().SetFloat("Set particless emission (glow)", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EJDPNJAEAKJ().SetFloat("_Value2", 1560f / farClipPlane);
			this.HKGAONMOBMH().SetVector("_Red_G", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 584f, 589f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00041850 File Offset: 0x0003FA50
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 854f)
			{
				this.HBJJOCHGOPH = 567f;
			}
			this.MHBAIEKFBIJ().SetFloat("Parent object ID. Case-Sensitive", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 264f)
				{
					this._Distance = 1447f;
				}
				if (this._Distance < 718f)
				{
					this._Distance = 1808f;
				}
				this.FEAEGGCNIAA().SetFloat("?", this._Distance);
			}
			else
			{
				this.OOMFJGPAOKL().SetFloat("maps.", this._Distance);
			}
			this.OOMFJGPAOKL().SetFloat("0,1,false", this._Size);
			this.MHBAIEKFBIJ().SetFloat("Connecting to server", this._FixDistance);
			this.ENKPNJMPDEB().SetFloat("Text", this.Fade);
			this.FEAEGGCNIAA().SetFloat(": ", this.Lightning);
			this.FOOCJIDNGBB().SetFloat("[PlayerController] ", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("x", 321f / farClipPlane);
			this.HKGAONMOBMH().SetVector("Drop_Far", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 310f, 483f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x00040E43 File Offset: 0x0003F043
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00041A2C File Offset: 0x0003FC2C
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1759f)
			{
				this.HBJJOCHGOPH = 609f;
			}
			this.ABHDNGIHBKE().SetFloat("_Value3", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 183f)
				{
					this._Distance = 530f;
				}
				if (this._Distance < 1357f)
				{
					this._Distance = 1737f;
				}
				this.NBPKMLMCHFN.SetFloat(" now: ", this._Distance);
			}
			else
			{
				this.FOOCJIDNGBB().SetFloat("wss://", this._Distance);
			}
			this.MHBAIEKFBIJ().SetFloat("Triangle", this._Size);
			this.EPCGJFCCAFH().SetFloat("Vertical", this._FixDistance);
			this.EPCGJFCCAFH().SetFloat(": ", this.Fade);
			this.ENKPNJMPDEB().SetFloat("\" gets executed locally only, if at all.", this.Lightning);
			this.MMOODGIODPC().SetFloat("No player left to ask", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPCHMEKDCHI().SetFloat("float,0", 356f / farClipPlane);
			this.NLFJGMBCICG().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1988f, 1375f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x00040E43 File Offset: 0x0003F043
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00041C08 File Offset: 0x0003FE08
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x00041C3F File Offset: 0x0003FE3F
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x00041C76 File Offset: 0x0003FE76
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x00041C9A File Offset: 0x0003FE9A
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("_ChannelMixerBlue");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x00040E43 File Offset: 0x0003F043
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x00041CBE File Offset: 0x0003FEBE
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.time");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00041CE2 File Offset: 0x0003FEE2
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

	// Token: 0x060008A4 RID: 2212 RVA: 0x00040E43 File Offset: 0x0003F043
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x00040E43 File Offset: 0x0003F043
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x00041D1C File Offset: 0x0003FF1C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1317f)
			{
				this.HBJJOCHGOPH = 1858f;
			}
			this.BBIMPFGLDCP().SetFloat("maphash", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 777f)
				{
					this._Distance = 1189f;
				}
				if (this._Distance < 1680f)
				{
					this._Distance = 324f;
				}
				this.MFHPKGICPIO().SetFloat("_MainTex", this._Distance);
			}
			else
			{
				this.CFEDGDGBCHE().SetFloat("Square", this._Distance);
			}
			this.LNLKMDPHDCC().SetFloat("_Value6", this._Size);
			this.BBIMPFGLDCP().SetFloat("Fade", this._FixDistance);
			this.ENKPNJMPDEB().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.Fade);
			this.EJDPNJAEAKJ().SetFloat("_TimeX", this.Lightning);
			this.LMLENGFLEBD().SetFloat("#C8C8C8FF", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EOCCJGIGEGJ().SetFloat("Text", 253f / farClipPlane);
			this.DOHGBNPMBKG().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 678f, 411f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x00040E43 File Offset: 0x0003F043
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x00040E43 File Offset: 0x0003F043
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x00041EF8 File Offset: 0x000400F8
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1890f)
			{
				this.HBJJOCHGOPH = 1172f;
			}
			this.NBPKMLMCHFN.SetFloat("VisionBlur", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 652f)
				{
					this._Distance = 123f;
				}
				if (this._Distance < 1742f)
				{
					this._Distance = 1787f;
				}
				this.NJDIODJNGGA().SetFloat("SetSatelliteTrailLength", this._Distance);
			}
			else
			{
				this.MHBAIEKFBIJ().SetFloat("_Value2", this._Distance);
			}
			this.NLFJGMBCICG().SetFloat("Skipping packet for ", this._Size);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this._FixDistance);
			this.FKEOGPDLBDD().SetFloat("_Value4", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Lightning);
			this.MMOODGIODPC().SetFloat("event", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKGAONMOBMH().SetFloat("_DotSize", 1764f / farClipPlane);
			this.LPCHMEKDCHI().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 587f, 868f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x000420D4 File Offset: 0x000402D4
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 746f)
			{
				this.HBJJOCHGOPH = 1986f;
			}
			this.MFHPKGICPIO().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1473f)
				{
					this._Distance = 1714f;
				}
				if (this._Distance < 757f)
				{
					this._Distance = 1502f;
				}
				this.MFHPKGICPIO().SetFloat("PublishButton", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("[SERVER] Player ", this._Distance);
			}
			this.DOHGBNPMBKG().SetFloat("_Value3", this._Size);
			this.HKGAONMOBMH().SetFloat("_Value", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("_DotSize", this.Fade);
			this.FEAEGGCNIAA().SetFloat("_Value5", this.Lightning);
			this.KEMJNOMIPHN().SetFloat("#ok", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/Distortion_Water_Drop", 336f / farClipPlane);
			this.NLFJGMBCICG().SetVector("SlidingArea", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 870f, 1899f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x000422B0 File Offset: 0x000404B0
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 205f)
			{
				this.HBJJOCHGOPH = 1864f;
			}
			this.NBPKMLMCHFN.SetFloat("Please specify a map name or buildID", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 177f)
				{
					this._Distance = 1914f;
				}
				if (this._Distance < 639f)
				{
					this._Distance = 966f;
				}
				this.ENKPNJMPDEB().SetFloat("mapselector.filter.subscribedonly", this._Distance);
			}
			else
			{
				this.LNLKMDPHDCC().SetFloat("_ScreenResolution", this._Distance);
			}
			this.EOCCJGIGEGJ().SetFloat("Malformed RPC; this should never occur. Content: ", this._Size);
			this.FOOCJIDNGBB().SetFloat("/", this._FixDistance);
			this.ENKPNJMPDEB().SetFloat("menu.playedsolo", this.Fade);
			this.FKEOGPDLBDD().SetFloat("start", this.Lightning);
			this.FOOCJIDNGBB().SetFloat("Message duration multiplier. Recomended 1", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKGAONMOBMH().SetFloat("threshold", 938f / farClipPlane);
			this.EOCCJGIGEGJ().SetVector("_WorldToCameraMatrix", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1370f, 1165f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x0004248C File Offset: 0x0004068C
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("---");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x00040E43 File Offset: 0x0003F043
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x000424B0 File Offset: 0x000406B0
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x000424E7 File Offset: 0x000406E7
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("leave");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x00040E43 File Offset: 0x0003F043
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x0004250B File Offset: 0x0004070B
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00042544 File Offset: 0x00040744
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1328f)
			{
				this.HBJJOCHGOPH = 568f;
			}
			this.EPCGJFCCAFH().SetFloat("value", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 463f)
				{
					this._Distance = 224f;
				}
				if (this._Distance < 1809f)
				{
					this._Distance = 1322f;
				}
				this.CFEDGDGBCHE().SetFloat("Items/", this._Distance);
			}
			else
			{
				this.KBOPGONOCNP().SetFloat("_ScreenResolution", this._Distance);
			}
			this.CFEDGDGBCHE().SetFloat("y", this._Size);
			this.KHCLIAMBBNC().SetFloat("/config", this._FixDistance);
			this.DOHGBNPMBKG().SetFloat("CameraFilterPack/BlurHole", this.Fade);
			this.MHBAIEKFBIJ().SetFloat("SSAARenderTargetCamera", this.Lightning);
			this.KEMJNOMIPHN().SetFloat("Connection error: ", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LMLENGFLEBD().SetFloat("\n", 499f / farClipPlane);
			this.LPCHMEKDCHI().SetVector("_Blue_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 154f, 1525f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00040E43 File Offset: 0x0003F043
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x00042720 File Offset: 0x00040920
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("EventData0DropDownList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00042744 File Offset: 0x00040944
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 679f)
			{
				this.HBJJOCHGOPH = 1150f;
			}
			this.ABHDNGIHBKE().SetFloat("PossibleMapPointsText", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1398f)
				{
					this._Distance = 1609f;
				}
				if (this._Distance < 1071f)
				{
					this._Distance = 1104f;
				}
				this.EJDPNJAEAKJ().SetFloat("EnableRankedNotificationsToggle", this._Distance);
			}
			else
			{
				this.EPCGJFCCAFH().SetFloat("CameraFilterPack/Drawing_Manga5", this._Distance);
			}
			this.EJDPNJAEAKJ().SetFloat(". ActorNr: ", this._Size);
			this.LMLENGFLEBD().SetFloat("#tryagain", this._FixDistance);
			this.KHCLIAMBBNC().SetFloat("#ok", this.Fade);
			this.MFHPKGICPIO().SetFloat("AudioSampler", this.Lightning);
			this.LPCHMEKDCHI().SetFloat("Found best region: '", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FKEOGPDLBDD().SetFloat("Image", 1587f / farClipPlane);
			this.FOOCJIDNGBB().SetVector("YES", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 690f, 1094f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00042920 File Offset: 0x00040B20
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 716f)
			{
				this.HBJJOCHGOPH = 1093f;
			}
			this.LPCHMEKDCHI().SetFloat(" b.", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 533f)
				{
					this._Distance = 944f;
				}
				if (this._Distance < 1519f)
				{
					this._Distance = 1134f;
				}
				this.ENKPNJMPDEB().SetFloat("colorC", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("Failed to InstantiateSceneObject prefab: ", this._Distance);
			}
			this.CFEDGDGBCHE().SetFloat("_Value3", this._Size);
			this.OOMFJGPAOKL().SetFloat("curScn", this._FixDistance);
			this.NLFJGMBCICG().SetFloat("player.orangearc", this.Fade);
			this.LNLKMDPHDCC().SetFloat("MapEnd", this.Lightning);
			this.HKGAONMOBMH().SetFloat("_Factor", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OOMFJGPAOKL().SetFloat("OPEN FILE", 33f / farClipPlane);
			this.ENKPNJMPDEB().SetVector("menu.selectedplaymode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1570f, 19f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00040E43 File Offset: 0x0003F043
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00042AFC File Offset: 0x00040CFC
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1786f)
			{
				this.HBJJOCHGOPH = 790f;
			}
			this.FEAEGGCNIAA().SetFloat("#rt", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1936f)
				{
					this._Distance = 139f;
				}
				if (this._Distance < 1425f)
				{
					this._Distance = 1501f;
				}
				this.FEAEGGCNIAA().SetFloat("Tab1Content", this._Distance);
			}
			else
			{
				this.OOMFJGPAOKL().SetFloat(" joined", this._Distance);
			}
			this.KBOPGONOCNP().SetFloat("Jazz", this._Size);
			this.MMOODGIODPC().SetFloat(" Kb", this._FixDistance);
			this.MFHPKGICPIO().SetFloat("_Value3", this.Fade);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/OldFilm_Cutting1", this.Lightning);
			this.ENKPNJMPDEB().SetFloat("GlassColor", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DOHGBNPMBKG().SetFloat("PointsScoreText", 957f / farClipPlane);
			this.CFEDGDGBCHE().SetVector("float,10", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 123f, 945f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x00042CD8 File Offset: 0x00040ED8
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("menu.enableselectormusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00042CFC File Offset: 0x00040EFC
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x00042D34 File Offset: 0x00040F34
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
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Lightning", this.Lightning);
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

	// Token: 0x060008BF RID: 2239 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00042F10 File Offset: 0x00041110
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1693f)
			{
				this.HBJJOCHGOPH = 896f;
			}
			this.KHCLIAMBBNC().SetFloat("Joystick1Button2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 551f)
				{
					this._Distance = 891f;
				}
				if (this._Distance < 448f)
				{
					this._Distance = 258f;
				}
				this.MMOODGIODPC().SetFloat("_Value4", this._Distance);
			}
			else
			{
				this.KHCLIAMBBNC().SetFloat("_BlurCoe", this._Distance);
			}
			this.FOOCJIDNGBB().SetFloat("AudioSampler", this._Size);
			this.NJDIODJNGGA().SetFloat("/", this._FixDistance);
			this.NJDIODJNGGA().SetFloat("icon", this.Fade);
			this.NLFJGMBCICG().SetFloat("Scene", this.Lightning);
			this.LPCHMEKDCHI().SetFloat(" ", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EPCGJFCCAFH().SetFloat("checkpoint", 1225f / farClipPlane);
			this.LNLKMDPHDCC().SetVector("RequestOwnership(): ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1579f, 117f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x000412AB File Offset: 0x0003F4AB
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00040E43 File Offset: 0x0003F043
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x000430EC File Offset: 0x000412EC
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00040E43 File Offset: 0x0003F043
	private void JMAIIENCEKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x000414E4 File Offset: 0x0003F6E4
	private void MEBPBNLBECA()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00043124 File Offset: 0x00041324
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 37f)
			{
				this.HBJJOCHGOPH = 324f;
			}
			this.BBIMPFGLDCP().SetFloat(" not exist", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 727f)
				{
					this._Distance = 262f;
				}
				if (this._Distance < 1094f)
				{
					this._Distance = 1165f;
				}
				this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", this._Distance);
			}
			else
			{
				this.ABHDNGIHBKE().SetFloat("_Green_B", this._Distance);
			}
			this.ABHDNGIHBKE().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", this._Size);
			this.LPCHMEKDCHI().SetFloat("_Light2", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("ResetButton", this.Fade);
			this.KEMJNOMIPHN().SetFloat("steamid", this.Lightning);
			this.NJDIODJNGGA().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FOOCJIDNGBB().SetFloat("CameraFilterPack/TV_Vintage", 291f / farClipPlane);
			this.EJDPNJAEAKJ().SetVector("_FadeShield", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1638f, 249f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x00043300 File Offset: 0x00041500
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x00043337 File Offset: 0x00041537
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x0004336E File Offset: 0x0004156E
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00043392 File Offset: 0x00041592
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00040E43 File Offset: 0x0003F043
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x000433C9 File Offset: 0x000415C9
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("From {0} at Index {1} \n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x000433ED File Offset: 0x000415ED
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Mirror");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00043411 File Offset: 0x00041611
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x00043448 File Offset: 0x00041648
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x000434CC File Offset: 0x000416CC
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1951f)
			{
				this.HBJJOCHGOPH = 1147f;
			}
			this.LMLENGFLEBD().SetFloat("-1", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1687f)
				{
					this._Distance = 209f;
				}
				if (this._Distance < 510f)
				{
					this._Distance = 1856f;
				}
				this.MFHPKGICPIO().SetFloat("_Value3", this._Distance);
			}
			else
			{
				this.HKGAONMOBMH().SetFloat("X", this._Distance);
			}
			this.MMOODGIODPC().SetFloat("Joystick1Button8", this._Size);
			this.MFHPKGICPIO().SetFloat("/", this._FixDistance);
			this.EJDPNJAEAKJ().SetFloat("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", this.Fade);
			this.EJDPNJAEAKJ().SetFloat("1234332714", this.Lightning);
			this.MHBAIEKFBIJ().SetFloat("RecordButton", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EPCGJFCCAFH().SetFloat("ready", 1706f / farClipPlane);
			this.EPCGJFCCAFH().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 717f, 1166f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x000436A8 File Offset: 0x000418A8
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("Left Stick Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00040E43 File Offset: 0x0003F043
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x000436CC File Offset: 0x000418CC
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("deletemap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x000436F0 File Offset: 0x000418F0
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 407f)
			{
				this.HBJJOCHGOPH = 1775f;
			}
			this.EJDPNJAEAKJ().SetFloat("z", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 965f)
				{
					this._Distance = 1577f;
				}
				if (this._Distance < 1241f)
				{
					this._Distance = 1442f;
				}
				this.FEAEGGCNIAA().SetFloat("_Far", this._Distance);
			}
			else
			{
				this.ABHDNGIHBKE().SetFloat("ViewID {0} {1}{2}", this._Distance);
			}
			this.NLFJGMBCICG().SetFloat("DPADHOR", this._Size);
			this.LNLKMDPHDCC().SetFloat("EndlessLoopsScoreText", this._FixDistance);
			this.DOHGBNPMBKG().SetFloat("_Value", this.Fade);
			this.LMLENGFLEBD().SetFloat("Status: ", this.Lightning);
			this.OOMFJGPAOKL().SetFloat("maps.", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKGAONMOBMH().SetFloat("lobby '{0}'[{1}]", 691f / farClipPlane);
			this.KBOPGONOCNP().SetVector("note.1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 760f, 1509f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x000438CC File Offset: 0x00041ACC
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00040E43 File Offset: 0x0003F043
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00043903 File Offset: 0x00041B03
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00040E43 File Offset: 0x0003F043
	private void NDDNJNCINDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x0004393A File Offset: 0x00041B3A
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00043971 File Offset: 0x00041B71
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00040E43 File Offset: 0x0003F043
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x000439A8 File Offset: 0x00041BA8
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1423f)
			{
				this.HBJJOCHGOPH = 1131f;
			}
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 877f)
				{
					this._Distance = 305f;
				}
				if (this._Distance < 464f)
				{
					this._Distance = 957f;
				}
				this.EJDPNJAEAKJ().SetFloat("_TimeX", this._Distance);
			}
			else
			{
				this.NLFJGMBCICG().SetFloat("Set Crosshair Emission", this._Distance);
			}
			this.EOCCJGIGEGJ().SetFloat("maps.", this._Size);
			this.ENKPNJMPDEB().SetFloat("_DotSize", this._FixDistance);
			this.MMOODGIODPC().SetFloat("_Green_C", this.Fade);
			this.LNLKMDPHDCC().SetFloat("_EmissionGain", this.Lightning);
			this.ABHDNGIHBKE().SetFloat("masterSteamID", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NJDIODJNGGA().SetFloat("Anomaly_Far", 1062f / farClipPlane);
			this.MHBAIEKFBIJ().SetVector("_Val", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 448f, 978f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00043B84 File Offset: 0x00041D84
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x00040E43 File Offset: 0x0003F043
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00040E43 File Offset: 0x0003F043
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00040E43 File Offset: 0x0003F043
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00040E43 File Offset: 0x0003F043
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x00043BA8 File Offset: 0x00041DA8
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x04000144 RID: 324
	public Shader SCShader;

	// Token: 0x04000145 RID: 325
	public bool _Visualize;

	// Token: 0x04000146 RID: 326
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000147 RID: 327
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000148 RID: 328
	private Material BJFKDHHMLJH;

	// Token: 0x04000149 RID: 329
	[Range(0f, 100f)]
	public float _FixDistance = 1.5f;

	// Token: 0x0400014A RID: 330
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.4f;

	// Token: 0x0400014B RID: 331
	[Range(0f, 0.5f)]
	public float _Size = 0.5f;

	// Token: 0x0400014C RID: 332
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x0400014D RID: 333
	[Range(0f, 2f)]
	public float Lightning = 2f;

	// Token: 0x0400014E RID: 334
	public bool AutoAnimatedNear;

	// Token: 0x0400014F RID: 335
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x04000150 RID: 336
	public static Color ChangeColorRGB;
}
