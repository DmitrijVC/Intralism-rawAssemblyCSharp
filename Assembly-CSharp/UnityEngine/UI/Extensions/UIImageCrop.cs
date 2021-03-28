using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000266 RID: 614
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	[AddComponentMenu("UI/Effects/Extensions/UIImageCrop")]
	public class UIImageCrop : MonoBehaviour
	{
		// Token: 0x060092C0 RID: 37568 RVA: 0x0033F248 File Offset: 0x0033D448
		public void JBECGLMNMDE(float MAPDMFKHMLO)
		{
			this.XCrop = Mathf.Clamp01(MAPDMFKHMLO);
			this.HCACMMMJBKL.SetFloat(this.PKGIAGCGLJC, this.XCrop);
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x0033F26D File Offset: 0x0033D46D
		public void FKDKJKCAHJC()
		{
			this.IKCPPDJMDNM();
			this.PHCFJKHPPGM(this.XCrop);
			this.SetYCrop(this.YCrop);
		}

		// Token: 0x060092C2 RID: 37570 RVA: 0x0033F248 File Offset: 0x0033D448
		public void SetXCrop(float MAPDMFKHMLO)
		{
			this.XCrop = Mathf.Clamp01(MAPDMFKHMLO);
			this.HCACMMMJBKL.SetFloat(this.PKGIAGCGLJC, this.XCrop);
		}

		// Token: 0x060092C3 RID: 37571 RVA: 0x0033F28D File Offset: 0x0033D48D
		public void GKCDJKHMOCK(float LINKEMAKKCD)
		{
			this.YCrop = Mathf.Clamp01(LINKEMAKKCD);
			this.HCACMMMJBKL.SetFloat(this.LBEMPFIGBLB, this.YCrop);
		}

		// Token: 0x060092C4 RID: 37572 RVA: 0x0033F2B2 File Offset: 0x0033D4B2
		private void KMCPMOGKDEH()
		{
			this.BKNPMIDAJBM();
		}

		// Token: 0x060092C5 RID: 37573 RVA: 0x0033F2BC File Offset: 0x0033D4BC
		public void CDJAHGPCJOM()
		{
			this.HIIJANADKDO = base.GetComponent<MaskableGraphic>();
			this.PKGIAGCGLJC = Shader.PropertyToID("/");
			this.LBEMPFIGBLB = Shader.PropertyToID("_Value3");
			if (this.HIIJANADKDO != null)
			{
				if (this.HIIJANADKDO.material == null || this.HIIJANADKDO.material.name == "_MainTex2")
				{
					this.HIIJANADKDO.material = new Material(Shader.Find("Hello World, is my item a clone? ["));
				}
				this.HCACMMMJBKL = this.HIIJANADKDO.material;
			}
			else
			{
				Debug.LogError("Joystick1Button10");
			}
		}

		// Token: 0x060092C6 RID: 37574 RVA: 0x0033F375 File Offset: 0x0033D575
		private void NNCCPEBIAKH()
		{
			this.SetMaterial();
		}

		// Token: 0x060092C7 RID: 37575 RVA: 0x0033F37D File Offset: 0x0033D57D
		public void MLAGEPNCCGM()
		{
			this.ODNOBFHFGAA();
			this.JBECGLMNMDE(this.XCrop);
			this.GNNPLEAEAMO(this.YCrop);
		}

		// Token: 0x060092C8 RID: 37576 RVA: 0x0033F3A0 File Offset: 0x0033D5A0
		public void BKNPMIDAJBM()
		{
			this.HIIJANADKDO = base.GetComponent<MaskableGraphic>();
			this.PKGIAGCGLJC = Shader.PropertyToID("Joystick1Button12");
			this.LBEMPFIGBLB = Shader.PropertyToID("mapselector.tags.");
			if (this.HIIJANADKDO != null)
			{
				if (this.HIIJANADKDO.material == null || this.HIIJANADKDO.material.name == "InfoButton")
				{
					this.HIIJANADKDO.material = new Material(Shader.Find("[CraftingPanel] Init"));
				}
				this.HCACMMMJBKL = this.HIIJANADKDO.material;
			}
			else
			{
				Debug.LogError("CameraFilterPack/Blur_Dithering2x2");
			}
		}

		// Token: 0x060092C9 RID: 37577 RVA: 0x0033F248 File Offset: 0x0033D448
		public void KAFGIDGLIMB(float MAPDMFKHMLO)
		{
			this.XCrop = Mathf.Clamp01(MAPDMFKHMLO);
			this.HCACMMMJBKL.SetFloat(this.PKGIAGCGLJC, this.XCrop);
		}

		// Token: 0x060092CA RID: 37578 RVA: 0x0033F28D File Offset: 0x0033D48D
		public void DEDMGCAFNMF(float LINKEMAKKCD)
		{
			this.YCrop = Mathf.Clamp01(LINKEMAKKCD);
			this.HCACMMMJBKL.SetFloat(this.LBEMPFIGBLB, this.YCrop);
		}

		// Token: 0x060092CB RID: 37579 RVA: 0x0033F459 File Offset: 0x0033D659
		public void CCKABCDEOJC()
		{
			this.DPGMKGOCHDB();
			this.SetXCrop(this.XCrop);
			this.PCAPDNJDGEH(this.YCrop);
		}

		// Token: 0x060092CC RID: 37580 RVA: 0x0033F47C File Offset: 0x0033D67C
		public void FPAGNNAONEK()
		{
			this.HIIJANADKDO = base.GetComponent<MaskableGraphic>();
			this.PKGIAGCGLJC = Shader.PropertyToID("colorB");
			this.LBEMPFIGBLB = Shader.PropertyToID("In Main Menu");
			if (this.HIIJANADKDO != null)
			{
				if (this.HIIJANADKDO.material == null || this.HIIJANADKDO.material.name == "settings.shaders.bloomintencity")
				{
					this.HIIJANADKDO.material = new Material(Shader.Find("LoadPlayerSkin"));
				}
				this.HCACMMMJBKL = this.HIIJANADKDO.material;
			}
			else
			{
				Debug.LogError("_ScreenResolution");
			}
		}

		// Token: 0x060092CD RID: 37581 RVA: 0x0033F538 File Offset: 0x0033D738
		public void IKCPPDJMDNM()
		{
			this.HIIJANADKDO = base.GetComponent<MaskableGraphic>();
			this.PKGIAGCGLJC = Shader.PropertyToID("_Intensity");
			this.LBEMPFIGBLB = Shader.PropertyToID("_Distortion");
			if (this.HIIJANADKDO != null)
			{
				if (this.HIIJANADKDO.material == null || this.HIIJANADKDO.material.name == "Hidden/Fast Approximate Anti-aliasing")
				{
					this.HIIJANADKDO.material = new Material(Shader.Find("menu.selectedplaymode"));
				}
				this.HCACMMMJBKL = this.HIIJANADKDO.material;
			}
			else
			{
				Debug.LogError("_TimeX");
			}
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x0033F28D File Offset: 0x0033D48D
		public void SetYCrop(float LINKEMAKKCD)
		{
			this.YCrop = Mathf.Clamp01(LINKEMAKKCD);
			this.HCACMMMJBKL.SetFloat(this.LBEMPFIGBLB, this.YCrop);
		}

		// Token: 0x060092D0 RID: 37584 RVA: 0x0033F2B2 File Offset: 0x0033D4B2
		private void PAKPHKPDKGE()
		{
			this.BKNPMIDAJBM();
		}

		// Token: 0x060092D1 RID: 37585 RVA: 0x0033F5F4 File Offset: 0x0033D7F4
		public void DPGMKGOCHDB()
		{
			this.HIIJANADKDO = base.GetComponent<MaskableGraphic>();
			this.PKGIAGCGLJC = Shader.PropertyToID("_Green_B");
			this.LBEMPFIGBLB = Shader.PropertyToID("y");
			if (this.HIIJANADKDO != null)
			{
				if (this.HIIJANADKDO.material == null || this.HIIJANADKDO.material.name == "settings_bindings_sec_")
				{
					this.HIIJANADKDO.material = new Material(Shader.Find("Exit to menu?"));
				}
				this.HCACMMMJBKL = this.HIIJANADKDO.material;
			}
			else
			{
				Debug.LogError("_Offsets");
			}
		}

		// Token: 0x060092D2 RID: 37586 RVA: 0x0033F6B0 File Offset: 0x0033D8B0
		public void OFBNBBNPJCK()
		{
			this.HIIJANADKDO = base.GetComponent<MaskableGraphic>();
			this.PKGIAGCGLJC = Shader.PropertyToID("_Value3");
			this.LBEMPFIGBLB = Shader.PropertyToID("StartRound");
			if (this.HIIJANADKDO != null)
			{
				if (this.HIIJANADKDO.material == null || this.HIIJANADKDO.material.name == "_TimeX")
				{
					this.HIIJANADKDO.material = new Material(Shader.Find("Using constructor for new PingNativeStatic()"));
				}
				this.HCACMMMJBKL = this.HIIJANADKDO.material;
			}
			else
			{
				Debug.LogError("Can not SetMasterClient(). Not in room or in offlineMode.");
			}
		}

		// Token: 0x060092D3 RID: 37587 RVA: 0x0033F76C File Offset: 0x0033D96C
		public void SetMaterial()
		{
			this.HIIJANADKDO = base.GetComponent<MaskableGraphic>();
			this.PKGIAGCGLJC = Shader.PropertyToID("_XCrop");
			this.LBEMPFIGBLB = Shader.PropertyToID("_YCrop");
			if (this.HIIJANADKDO != null)
			{
				if (this.HIIJANADKDO.material == null || this.HIIJANADKDO.material.name == "Default UI Material")
				{
					this.HIIJANADKDO.material = new Material(Shader.Find("UI Extensions/UI Image Crop"));
				}
				this.HCACMMMJBKL = this.HIIJANADKDO.material;
			}
			else
			{
				Debug.LogError("Please attach component to a Graphical UI component");
			}
		}

		// Token: 0x060092D4 RID: 37588 RVA: 0x0033F825 File Offset: 0x0033DA25
		public void EONOOEJDNEF()
		{
			this.OFBNBBNPJCK();
			this.PHCFJKHPPGM(this.XCrop);
			this.SetYCrop(this.YCrop);
		}

		// Token: 0x060092D5 RID: 37589 RVA: 0x0033F375 File Offset: 0x0033D575
		private void Start()
		{
			this.SetMaterial();
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x0033F248 File Offset: 0x0033D448
		public void PHCFJKHPPGM(float MAPDMFKHMLO)
		{
			this.XCrop = Mathf.Clamp01(MAPDMFKHMLO);
			this.HCACMMMJBKL.SetFloat(this.PKGIAGCGLJC, this.XCrop);
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x0033F248 File Offset: 0x0033D448
		public void JKMFPPKCNDG(float MAPDMFKHMLO)
		{
			this.XCrop = Mathf.Clamp01(MAPDMFKHMLO);
			this.HCACMMMJBKL.SetFloat(this.PKGIAGCGLJC, this.XCrop);
		}

		// Token: 0x060092D8 RID: 37592 RVA: 0x0033F845 File Offset: 0x0033DA45
		public void OnValidate()
		{
			this.SetMaterial();
			this.SetXCrop(this.XCrop);
			this.SetYCrop(this.YCrop);
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x0033F28D File Offset: 0x0033D48D
		public void GNNPLEAEAMO(float LINKEMAKKCD)
		{
			this.YCrop = Mathf.Clamp01(LINKEMAKKCD);
			this.HCACMMMJBKL.SetFloat(this.LBEMPFIGBLB, this.YCrop);
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x0033F868 File Offset: 0x0033DA68
		public void ODNOBFHFGAA()
		{
			this.HIIJANADKDO = base.GetComponent<MaskableGraphic>();
			this.PKGIAGCGLJC = Shader.PropertyToID("NEW_ACHIEVEMENT_1_21");
			this.LBEMPFIGBLB = Shader.PropertyToID("#ok");
			if (this.HIIJANADKDO != null)
			{
				if (this.HIIJANADKDO.material == null || this.HIIJANADKDO.material.name == "Other")
				{
					this.HIIJANADKDO.material = new Material(Shader.Find("[PlayerController] "));
				}
				this.HCACMMMJBKL = this.HIIJANADKDO.material;
			}
			else
			{
				Debug.LogError("Fade");
			}
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x0033F921 File Offset: 0x0033DB21
		public void LOOGLMFBJHK()
		{
			this.ODNOBFHFGAA();
			this.KAFGIDGLIMB(this.XCrop);
			this.DEDMGCAFNMF(this.YCrop);
		}

		// Token: 0x060092DC RID: 37596 RVA: 0x0033F28D File Offset: 0x0033D48D
		public void PCAPDNJDGEH(float LINKEMAKKCD)
		{
			this.YCrop = Mathf.Clamp01(LINKEMAKKCD);
			this.HCACMMMJBKL.SetFloat(this.LBEMPFIGBLB, this.YCrop);
		}

		// Token: 0x040010E3 RID: 4323
		private MaskableGraphic HIIJANADKDO;

		// Token: 0x040010E4 RID: 4324
		private Material HCACMMMJBKL;

		// Token: 0x040010E5 RID: 4325
		private int PKGIAGCGLJC;

		// Token: 0x040010E6 RID: 4326
		private int LBEMPFIGBLB;

		// Token: 0x040010E7 RID: 4327
		public float XCrop;

		// Token: 0x040010E8 RID: 4328
		public float YCrop;
	}
}
