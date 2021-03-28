using System;
using System.Collections.Generic;
using System.IO;
using SSAA;
using UnityEngine;

// Token: 0x0200022C RID: 556
public class SuperSampling_SSAA : MonoBehaviour
{
	// Token: 0x060086D4 RID: 34516 RVA: 0x002F38B8 File Offset: 0x002F1AB8
	private void PLIKADJCEPO()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086D5 RID: 34517 RVA: 0x002F3940 File Offset: 0x002F1B40
	private void GFBOBIBIOMC()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("Texture2");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags)(-103);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x060086D6 RID: 34518 RVA: 0x002F39FC File Offset: 0x002F1BFC
	private void CPAJLKHMOJB()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086D7 RID: 34519 RVA: 0x002F3A84 File Offset: 0x002F1C84
	private void GAOOPEEBGJA()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086D8 RID: 34520 RVA: 0x002F3B0C File Offset: 0x002F1D0C
	private void EODOHEAKJFO()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086D9 RID: 34521 RVA: 0x002F3B94 File Offset: 0x002F1D94
	private void MLLPGPANCHI()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("SetSunMaxSize");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = HideFlags.DontSaveInBuild;
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags)(-75);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x060086DA RID: 34522 RVA: 0x002F3C50 File Offset: 0x002F1E50
	private void ODGMCJILIHF()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086DB RID: 34523 RVA: 0x002F3CD8 File Offset: 0x002F1ED8
	public Texture2D OAMFALFGMAO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value2");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -107);
		renderTexture.name = "_Value4";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == " This is not possible to be called for standalone input. Please check your platform and code where this is called")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(528f, 308f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "_LightIntensity")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x060086DC RID: 34524 RVA: 0x002F3E44 File Offset: 0x002F2044
	private void LNIOFCGDDKP()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("maps.");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)(-123);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags)(-65);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x060086DD RID: 34525 RVA: 0x002F3F00 File Offset: 0x002F2100
	private void JHJGJJKELJM()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086DE RID: 34526 RVA: 0x002F3F88 File Offset: 0x002F2188
	public void MCKLKGMHGJB(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.JHLLOHINKHK(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "Music End";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[0];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[5] = "_Green_R";
				array[3] = num.ToString();
				array[5] = "_TimeX";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -91);
			string[] array2 = new string[3];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[3] = "_FlipAlphaMask";
			array2[7] = num.ToString();
			array2[4] = "_MainTex2";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x060086DF RID: 34527 RVA: 0x002F4068 File Offset: 0x002F2268
	public void EFIECJGFGNN(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.JHLLOHINKHK(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "_Value2";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[3];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[6] = " : ";
				array[4] = num.ToString();
				array[5] = "OpCreateRoom()";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -72);
			string[] array2 = new string[8];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[7] = "ScreenResolutionPanel";
			array2[4] = num.ToString();
			array2[1] = "[PlayerController] ";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x060086E0 RID: 34528 RVA: 0x002F4148 File Offset: 0x002F2348
	private void ALMGMOOHLMA()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086E1 RID: 34529 RVA: 0x002F41D0 File Offset: 0x002F23D0
	private void HLCMOFCEJLP()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("_ScreenResolution");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags)99;
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x060086E2 RID: 34530 RVA: 0x002F428C File Offset: 0x002F248C
	private void FGBDGGCBFLP()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086E3 RID: 34531 RVA: 0x002F4314 File Offset: 0x002F2514
	public void DIEPEDEBLCL(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.NKCGNACKBCO(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "#ok";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[5];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[3] = "Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings";
				array[2] = num.ToString();
				array[1] = "CameraFilterPack/Drawing_Paper2";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -69);
			string[] array2 = new string[3];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[8] = ".lastCheckpoint.playerdistance";
			array2[4] = num.ToString();
			array2[7] = "win";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x060086E4 RID: 34532 RVA: 0x002F43F4 File Offset: 0x002F25F4
	private void HIFPDKKBDHJ()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("StartButton");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)(-84);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x060086E5 RID: 34533 RVA: 0x002F44B0 File Offset: 0x002F26B0
	private void CCPEDDLAMIB()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086E6 RID: 34534 RVA: 0x002F4538 File Offset: 0x002F2738
	public void EJFGHDJBFOA(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.MGAAIBEFBMC(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + ".status";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[7];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[3] = "PointsScoreText";
				array[3] = num.ToString();
				array[0] = "_Value3";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -63);
			string[] array2 = new string[4];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[0] = "bans.viewed.";
			array2[8] = num.ToString();
			array2[1] = "Finished";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x060086E8 RID: 34536 RVA: 0x002F4654 File Offset: 0x002F2854
	public void GGOFDJNNGJG(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.NKCGNACKBCO(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "Preparing configuration";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[3];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[0] = "\\n";
				array[1] = num.ToString();
				array[0] = "win";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -199);
			string[] array2 = new string[5];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[2] = "Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ";
			array2[3] = num.ToString();
			array2[0] = "/";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x060086E9 RID: 34537 RVA: 0x002F4734 File Offset: 0x002F2934
	public void FBFJNCBLGFE(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.OACNGCEJIIF(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "_FixDistance";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[8];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[1] = "_MatrixColor";
				array[8] = num.ToString();
				array[4] = "player.arrow";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -111);
			string[] array2 = new string[3];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[6] = ", ";
			array2[7] = num.ToString();
			array2[0] = "_VelTex";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x060086EA RID: 34538 RVA: 0x002F4814 File Offset: 0x002F2A14
	private void OFMNDBNFBDJ()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086EB RID: 34539 RVA: 0x002F489C File Offset: 0x002F2A9C
	public Texture2D IPDGGMEKEFK(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning(",");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -110);
		renderTexture.name = "LevelNameText";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_Value2")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1489f, 1996f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "_Size")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x060086EC RID: 34540 RVA: 0x002F4A08 File Offset: 0x002F2C08
	public Texture2D PEKPICNMIME(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Could not execute RPC ");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -39);
		renderTexture.name = "blue";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "FinalScoreSmallText")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(579f, 1592f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "#{0}")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x060086ED RID: 34541 RVA: 0x002F4B74 File Offset: 0x002F2D74
	private void BILILBEBLFL()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("CheckCombo");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x060086EE RID: 34542 RVA: 0x002F4C30 File Offset: 0x002F2E30
	private void KGHFKHBPHEH()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning(": ");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags)(-88);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x060086EF RID: 34543 RVA: 0x002F4CEC File Offset: 0x002F2EEC
	public Texture2D PCMNPNPIIBO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_ScreenResolution");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 117);
		renderTexture.name = "_ScreenResolution";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "CameraFilterPack/Distortion_Twist_Square")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)8, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1593f, 1092f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "event")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x060086F0 RID: 34544 RVA: 0x002F4E58 File Offset: 0x002F3058
	public Texture2D JIPMODJMCBA(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Preparing content...");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -32);
		renderTexture.name = "[PlayerBase] New highscore";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "Testing, a toggle has toggled [")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)8, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(133f, 1673f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "#pleasewait")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x060086F1 RID: 34545 RVA: 0x002F4FC4 File Offset: 0x002F31C4
	private void IMGGCJICLHK()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086F2 RID: 34546 RVA: 0x002F504C File Offset: 0x002F324C
	private void HNNKIOHCDKG()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("mapselector.lastSearch");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x060086F3 RID: 34547 RVA: 0x002F5108 File Offset: 0x002F3308
	public Texture2D GADHJJAGIKL(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning(" not exist");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -53);
		renderTexture.name = "score";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "notready")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(946f, 882f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "File not found: {0}")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x060086F4 RID: 34548 RVA: 0x002F5274 File Offset: 0x002F3474
	public Texture2D NJJBBNNOPEN(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("yes");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 54);
		renderTexture.name = "OnSerialize";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_TimeX")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)6, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(819f, 1377f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "PlayButton")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x060086F5 RID: 34549 RVA: 0x002F53E0 File Offset: 0x002F35E0
	private void EBBOJPEPDCN()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning(" : ");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x060086F6 RID: 34550 RVA: 0x002F549C File Offset: 0x002F369C
	private void OnDisable()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086F7 RID: 34551 RVA: 0x002F5524 File Offset: 0x002F3724
	private void FPHLDMMAOEF()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086F8 RID: 34552 RVA: 0x002F55AC File Offset: 0x002F37AC
	public void ALJHIFOGBOF(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.CMJLMAPPKJN(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "f";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[0];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[8] = "Scale environment object by the values";
				array[3] = num.ToString();
				array[6] = "_Offsets";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -87);
			string[] array2 = new string[7];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[8] = "[";
			array2[4] = num.ToString();
			array2[4] = "_MainTex2";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x060086F9 RID: 34553 RVA: 0x002F568C File Offset: 0x002F388C
	private void LLAJPKFNDIG()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("[MapEditor] Loading map: ");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)66;
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x060086FA RID: 34554 RVA: 0x002F5748 File Offset: 0x002F3948
	private void BOLBPPHJBMI()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086FB RID: 34555 RVA: 0x002F57D0 File Offset: 0x002F39D0
	public void EDEEACBFLLB(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.BEPBCKNNOKI(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "inventory.selected.";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[6];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[4] = "Joystick1Button5";
				array[5] = num.ToString();
				array[2] = "skin.no_hit";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 102);
			string[] array2 = new string[]
			{
				null,
				Application.dataPath
			};
			array2[0] = BNJFKKGOACF;
			array2[5] = "_Speed";
			array2[6] = num.ToString();
			array2[1] = "_HexaColor";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x060086FC RID: 34556 RVA: 0x002F58B0 File Offset: 0x002F3AB0
	public Texture2D CMJLMAPPKJN(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Bloom4");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 31);
		renderTexture.name = "pointBuffer";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_TimeX")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)8, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(952f, 949f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "EventMenu")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x060086FD RID: 34557 RVA: 0x002F5A1C File Offset: 0x002F3C1C
	private void HLLHJIDOOGA()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x060086FE RID: 34558 RVA: 0x002F5AA4 File Offset: 0x002F3CA4
	public Texture2D JACDHDCAIGO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_EmissionColor");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -97);
		renderTexture.name = "No Name";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "Drop_Near")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(487f, 594f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "y")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x060086FF RID: 34559 RVA: 0x002F5C10 File Offset: 0x002F3E10
	public Texture2D POCDDNALBLE(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("settings.arcsnohitsoundtimedelay");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 64);
		renderTexture.name = "LevelConfigButton";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "No Dispatcher exists in the scene. Actions will not be invoked!")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(245f, 689f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "Tab1Content")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008700 RID: 34560 RVA: 0x002F5D7C File Offset: 0x002F3F7C
	public void CHIDAPAGIEP(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.IPDGGMEKEFK(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "SpawnObj";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[4];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[6] = "_ScreenResolution";
				array[7] = num.ToString();
				array[6] = "player.yellowarc";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -18);
			string[] array2 = new string[7];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[5] = "VIGNETTE_BLUR";
			array2[8] = num.ToString();
			array2[0] = "_Jitter";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x06008701 RID: 34561 RVA: 0x002F5E5C File Offset: 0x002F405C
	public Texture2D EOEBNKPBHBN(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Set Object Position");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -100);
		renderTexture.name = "EnableRankingToggle";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "solo")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)6, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1681f, 1405f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "0,7,true,0")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008702 RID: 34562 RVA: 0x002F5FC8 File Offset: 0x002F41C8
	private void IABLKKAALGI()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x06008703 RID: 34563 RVA: 0x002F6050 File Offset: 0x002F4250
	private void MLEAHDDGEMJ()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("BitsData");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)121;
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x06008704 RID: 34564 RVA: 0x002F610C File Offset: 0x002F430C
	private void OnEnable()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("No Camera attached!");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x06008705 RID: 34565 RVA: 0x002F61C8 File Offset: 0x002F43C8
	public Texture2D DFANEKNGDKE(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value2");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 18);
		renderTexture.name = "Observed type is not serializable: ";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "UseScanLineSize")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(63f, 1089f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "CameraFilterPack/Gradients_Therma")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008706 RID: 34566 RVA: 0x002F6334 File Offset: 0x002F4534
	private void EDBEHEKMGFH()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x06008707 RID: 34567 RVA: 0x002F63BC File Offset: 0x002F45BC
	public Texture2D MCCLGPDABKG(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("DPADHOR");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 117);
		renderTexture.name = "Scene";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "[DiscordController] Responding yes to Ask to Join request")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1594f, 294f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == ".")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008708 RID: 34568 RVA: 0x002F6528 File Offset: 0x002F4728
	public Texture2D AMLJDBBPBIM(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Preparing content");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 43);
		renderTexture.name = ". Client should be in a room. Current connectionStateDetailed: ";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "note.4")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB565, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1047f, 901f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "skin.hit_perfect")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008709 RID: 34569 RVA: 0x002F6694 File Offset: 0x002F4894
	public Texture2D CHOFLJOLHBM(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_NeighborMaxTex");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 16);
		renderTexture.name = "_MainTex2";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "/?page=ranks")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1189f, 41f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "DPADVER")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x0600870A RID: 34570 RVA: 0x002F6800 File Offset: 0x002F4A00
	private void NGEGCLCPPCD()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x0600870B RID: 34571 RVA: 0x002F68BC File Offset: 0x002F4ABC
	public Texture2D IJEHFLHANJO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("file://");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 39);
		renderTexture.name = "float,0";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "GameMessagesDurationSlider")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)0, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1660f, 270f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "_BlurRadius")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x0600870C RID: 34572 RVA: 0x002F6A28 File Offset: 0x002F4C28
	public Texture2D BEPBCKNNOKI(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_TimeX");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -61);
		renderTexture.name = "_Color_G";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "[Up-Right-Down-Left]")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)0, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1157f, 567f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "_Red_G")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x0600870D RID: 34573 RVA: 0x002F6B94 File Offset: 0x002F4D94
	public Texture2D BNCKICDHIHM(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -119);
		renderTexture.name = "_MaxRadiusOrKInPaper";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == ". Using max value: 255.")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(863f, 1073f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "_Bullet_11")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x0600870E RID: 34574 RVA: 0x002F6D00 File Offset: 0x002F4F00
	private void HNILMGEKDEC()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x0600870F RID: 34575 RVA: 0x002F6D88 File Offset: 0x002F4F88
	public void PLBPHIPBEAA(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.JIPMODJMCBA(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "[MapEditor] Reset";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[5];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[8] = "_Level";
				array[3] = num.ToString();
				array[6] = "_ScreenResolution";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -162);
			string[] array2 = new string[8];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[3] = "PLEASE WAIT";
			array2[5] = num.ToString();
			array2[2] = "[PlayerController] ";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x06008710 RID: 34576 RVA: 0x002F6E68 File Offset: 0x002F5068
	public Texture2D GetHighScaledScreenshot(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Screenshots only supported in PlayMode");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 24);
		renderTexture.name = "HighScaleShot";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "SSAARenderTargetCamera")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(0f, 0f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "HighScaleShot")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008711 RID: 34577 RVA: 0x002F6FD4 File Offset: 0x002F51D4
	private void DLMPALHKMON()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x06008712 RID: 34578 RVA: 0x002F705C File Offset: 0x002F525C
	public Texture2D OACNGCEJIIF(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning(".wav");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -41);
		renderTexture.name = "Search: ";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_ScreenResolution")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB565, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1844f, 135f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "player.greenlifering")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008713 RID: 34579 RVA: 0x002F71C8 File Offset: 0x002F53C8
	private void IDIEBLNAEIF()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("itemid");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x06008714 RID: 34580 RVA: 0x002F7284 File Offset: 0x002F5484
	private void PAEGLMEOKHP()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x06008715 RID: 34581 RVA: 0x002F730C File Offset: 0x002F550C
	private void LLKKGGLNIDF()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x06008716 RID: 34582 RVA: 0x002F7394 File Offset: 0x002F5594
	public void IIIJBFGDJGG(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.DLNHCDBLAPG(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "ResetSpeed";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[]
				{
					null,
					Application.dataPath
				};
				array[0] = BNJFKKGOACF;
				array[6] = "_DistortionSize";
				array[2] = num.ToString();
				array[8] = "Set Sun Emission";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != 143);
			string[] array2 = new string[3];
			array2[0] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[7] = "SaveButton";
			array2[2] = num.ToString();
			array2[6] = "(\\[ *i *\\])";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x06008717 RID: 34583 RVA: 0x002F7474 File Offset: 0x002F5674
	public Texture2D BMAIMBGMFBB(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: ");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 106);
		renderTexture.name = ".icon";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "settings.shaders")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(275f, 99f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "challenges.")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008718 RID: 34584 RVA: 0x002F75E0 File Offset: 0x002F57E0
	public Texture2D AKJLMMOIOCD(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value2");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -20);
		renderTexture.name = "Please specify either t or f.";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_Blend")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1200f, 763f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "GraphicsQualitySlider")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008719 RID: 34585 RVA: 0x002F774C File Offset: 0x002F594C
	public void TakeHighScaledShot(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D highScaledScreenshot = this.GetHighScaledScreenshot(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = highScaledScreenshot.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(highScaledScreenshot);
		string path = Application.dataPath + BNJFKKGOACF + ".png";
		if (File.Exists(path))
		{
			int num = 1;
			while (File.Exists(string.Concat(new string[]
			{
				Application.dataPath,
				BNJFKKGOACF,
				" (",
				num.ToString(),
				").png"
			})))
			{
				num++;
				if (num == 2147483647)
				{
					break;
				}
			}
			path = string.Concat(new string[]
			{
				Application.dataPath,
				BNJFKKGOACF,
				" (",
				num.ToString(),
				").png"
			});
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x0600871A RID: 34586 RVA: 0x002F782C File Offset: 0x002F5A2C
	public void HHBEFOLGBGP(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.CHOFLJOLHBM(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "Other";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[8];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[5] = "ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms";
				array[7] = num.ToString();
				array[1] = "No";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -25);
			string[] array2 = new string[0];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[2] = "/";
			array2[1] = num.ToString();
			array2[4] = "3d text";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x0600871B RID: 34587 RVA: 0x002F790C File Offset: 0x002F5B0C
	private void AONJNAGNLIH()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("DPADHOR");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)85;
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = (HideFlags)98;
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x0600871C RID: 34588 RVA: 0x002F79C8 File Offset: 0x002F5BC8
	private void GKNKIIEALCH()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x0600871D RID: 34589 RVA: 0x002F7A50 File Offset: 0x002F5C50
	private void HONBLGFDMLL()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x0600871E RID: 34590 RVA: 0x002F7AD8 File Offset: 0x002F5CD8
	public Texture2D MGAAIBEFBMC(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning(".");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -128);
		renderTexture.name = "_MainTex2";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "1.87")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.Alpha8, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(651f, 959f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "_MainTex2")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x0600871F RID: 34591 RVA: 0x002F7C44 File Offset: 0x002F5E44
	public Texture2D LNCHHJAKOMO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning(" ");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 95);
		renderTexture.name = "SlidingArea";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "Already exist!")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)6, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1570f, 93f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "{0} seconds ago")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008720 RID: 34592 RVA: 0x002F7DB0 File Offset: 0x002F5FB0
	public void LHFFAFIOADE(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.NJJBBNNOPEN(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "settings.crosshairopacity";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[5];
				array[0] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[3] = "maps.";
				array[0] = num.ToString();
				array[4] = "CameraFilterPack_TV_Noise3";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != 162);
			string[] array2 = new string[7];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[3] = "/icon";
			array2[6] = num.ToString();
			array2[0] = "_Blue_G";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x06008721 RID: 34593 RVA: 0x002F7E90 File Offset: 0x002F6090
	private void JOONHGHGKKF()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA component2 = base.gameObject.GetComponent<internal_SSAA>();
			if (component2 != null)
			{
				UnityEngine.Object.Destroy(component2);
			}
		}
		else
		{
			SSAARenderTarget component3 = base.gameObject.GetComponent<SSAARenderTarget>();
			if (component3 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component3);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}
	}

	// Token: 0x06008722 RID: 34594 RVA: 0x002F7F18 File Offset: 0x002F6118
	public Texture2D GBPMKPOAGLH(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value5");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -115);
		renderTexture.name = "Y";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_Value3")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB565, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1568f, 311f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "/icon")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008723 RID: 34595 RVA: 0x002F8084 File Offset: 0x002F6284
	public Texture2D GFAPADNBEMG(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("settings.shaders");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 96);
		renderTexture.name = "Set Particles Emission";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "deletemap")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB24, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1045f, 998f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "_ScreenResolution")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008724 RID: 34596 RVA: 0x002F81F0 File Offset: 0x002F63F0
	private void PPGEGFMNIKO()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("_BlurArea");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags)(-80);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = ~HideFlags.HideInHierarchy;
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x06008725 RID: 34597 RVA: 0x002F82AC File Offset: 0x002F64AC
	public void EILMFGOCGFB(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.JACDHDCAIGO(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "<b>";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[5];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[4] = "_TimeX";
				array[3] = num.ToString();
				array[1] = "_Distance";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != -184);
			string[] array2 = new string[3];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[0] = "_FarCamera";
			array2[4] = num.ToString();
			array2[5] = "player.bluelifering";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x06008726 RID: 34598 RVA: 0x002F838C File Offset: 0x002F658C
	public void HNDNIPLDDIC(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.CMJLMAPPKJN(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "#availablechallenges";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[]
				{
					null,
					Application.dataPath
				};
				array[1] = BNJFKKGOACF;
				array[8] = "player.crystal";
				array[1] = num.ToString();
				array[6] = "_Value4";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != 109);
			string[] array2 = new string[0];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[5] = "Set crosshair emission (glow)";
			array2[8] = num.ToString();
			array2[6] = "Fade";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x06008727 RID: 34599 RVA: 0x002F846C File Offset: 0x002F666C
	public Texture2D ICKKMILLAMF(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value2");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 52);
		renderTexture.name = "offsets";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "maps.")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGB565, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(769f, 482f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "CameraFilterPack/Oculus_NightVision5")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008728 RID: 34600 RVA: 0x002F85D8 File Offset: 0x002F67D8
	public Texture2D DLNHCDBLAPG(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("CameraFilterPack/Blend2Camera_LighterColor");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 27);
		renderTexture.name = "CameraFilterPack/BlurTiltShift_V";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "\" to target: ")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1384f, 847f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "RarityImage")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008729 RID: 34601 RVA: 0x002F8744 File Offset: 0x002F6944
	public void OMHCFMDMNGC(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.POCDDNALBLE(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "ERROR";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[0];
				array[0] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[3] = "_EmissionColor";
				array[0] = num.ToString();
				array[7] = "_Parameter";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -165);
			string[] array2 = new string[6];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[7] = "_EdgeWeight";
			array2[4] = num.ToString();
			array2[0] = "_Value4";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x0600872A RID: 34602 RVA: 0x002F8824 File Offset: 0x002F6A24
	public void EFMODJEDBCJ(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D highScaledScreenshot = this.GetHighScaledScreenshot(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = highScaledScreenshot.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(highScaledScreenshot);
		string path = Application.dataPath + BNJFKKGOACF + "In Main Menu";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[5];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[1] = "[MapsData] Bad map: ";
				array[4] = num.ToString();
				array[7] = "mapselector.filter.subscribedonly";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -113);
			string[] array2 = new string[0];
			array2[1] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[5] = "_Offsets";
			array2[0] = num.ToString();
			array2[0] = "Item invalid. Make sure your mod contains at leats one file.";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x0600872B RID: 34603 RVA: 0x002F8904 File Offset: 0x002F6B04
	public void JKLKJODEGCJ(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.EOEBNKPBHBN(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "ComboScoreText";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[3];
				array[1] = Application.dataPath;
				array[0] = BNJFKKGOACF;
				array[2] = "_Offsets";
				array[1] = num.ToString();
				array[5] = "inventory.selected.";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != -104);
			string[] array2 = new string[4];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[6] = "Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()";
			array2[5] = num.ToString();
			array2[8] = "https://twitch.tv/intralism";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x0600872C RID: 34604 RVA: 0x002F89E4 File Offset: 0x002F6BE4
	public Texture2D OKFFJKINMAH(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("Reset All");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 53);
		renderTexture.name = "settings.gamemessagesduration";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "GlassesColor2")
			{
				list.RemoveAt(i);
				i -= 0;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.RGBA32, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(702f, 1348f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "\n")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x0600872D RID: 34605 RVA: 0x002F8B50 File Offset: 0x002F6D50
	public void BLIFPBNDNIJ(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.BEPBCKNNOKI(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "CameraFilterPack/Vision_AuraDistortion";
		if (File.Exists(path))
		{
			int num = 0;
			do
			{
				string[] array = new string[4];
				array[1] = Application.dataPath;
				array[1] = BNJFKKGOACF;
				array[5] = ".sawoutdatedmessage";
				array[2] = num.ToString();
				array[3] = "[Right]";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num++;
			}
			while (num != 86);
			string[] array2 = new string[7];
			array2[0] = Application.dataPath;
			array2[1] = BNJFKKGOACF;
			array2[0] = "settings.shaders";
			array2[8] = num.ToString();
			array2[2] = "_TimeX";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x0600872E RID: 34606 RVA: 0x002F8C30 File Offset: 0x002F6E30
	public Texture2D NKCGNACKBCO(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("#EA4137");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, -95);
		renderTexture.name = "_Value13";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!list[i].enabled || list[i].gameObject.name == "CameraFilterPack_Glasses_On3")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, TextureFormat.ARGB4444, false);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(258f, 1132f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 1, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "Start")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x0600872F RID: 34607 RVA: 0x002F8D9C File Offset: 0x002F6F9C
	private void FDIJLKIIMLL()
	{
		Camera component = base.GetComponent<Camera>();
		if (component == null)
		{
			Debug.LogWarning("#TBD");
			return;
		}
		if (component.targetTexture == null)
		{
			internal_SSAA internal_SSAA = base.gameObject.AddComponent<internal_SSAA>();
			internal_SSAA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			internal_SSAA.Filter = this.Filter;
			internal_SSAA.ChangeScale(this.Scale);
			internal_SSAA.Format = this.renderTextureFormat;
		}
		else
		{
			SSAARenderTarget ssaarenderTarget = base.gameObject.AddComponent<SSAARenderTarget>();
			ssaarenderTarget.hideFlags = HideFlags.None;
			ssaarenderTarget.Scale = this.Scale;
			ssaarenderTarget.TargetTexture = component.targetTexture;
			ssaarenderTarget.Filter = this.Filter;
			ssaarenderTarget.Format = this.renderTextureFormat;
		}
	}

	// Token: 0x06008730 RID: 34608 RVA: 0x002F8E58 File Offset: 0x002F7058
	public Texture2D JHLLOHINKHK(int CJDDBGPKDLP = 1920, int PBMAGEKDPLI = 1080, float FEKLHOPGFNC = 2f, SSAAFilter KGBFDONIDNE = SSAAFilter.BilinearSharper)
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning("_Value");
			return null;
		}
		RenderTexture renderTexture = new RenderTexture(CJDDBGPKDLP, PBMAGEKDPLI, 113);
		renderTexture.name = "_TimeX";
		List<Camera> list = new List<Camera>((Camera[])UnityEngine.Object.FindObjectsOfType(typeof(Camera)));
		for (int i = 1; i < list.Count; i++)
		{
			if (!list[i].enabled || list[i].gameObject.name == "_TimeX")
			{
				list.RemoveAt(i);
				i--;
			}
		}
		SSAARenderTarget.SampleSSAAForTexture(renderTexture, FEKLHOPGFNC, KGBFDONIDNE, list);
		Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI, (TextureFormat)6, true);
		RenderTexture.active = renderTexture;
		texture2D.ReadPixels(new Rect(1254f, 1693f, (float)CJDDBGPKDLP, (float)PBMAGEKDPLI), 0, 1);
		texture2D.Apply();
		RenderTexture.active = null;
		foreach (Camera camera in list)
		{
			if (camera.targetTexture != null && camera.targetTexture.name == "settings.enablehitsoundsinrelax")
			{
				camera.targetTexture = null;
			}
		}
		renderTexture.Release();
		return texture2D;
	}

	// Token: 0x06008731 RID: 34609 RVA: 0x002F8FC4 File Offset: 0x002F71C4
	public void GIKIMOHMMKD(int CJDDBGPKDLP, int PBMAGEKDPLI, float FEKLHOPGFNC, SSAAFilter KGBFDONIDNE, string BNJFKKGOACF)
	{
		Texture2D texture2D = this.PEKPICNMIME(CJDDBGPKDLP, PBMAGEKDPLI, FEKLHOPGFNC, KGBFDONIDNE);
		byte[] bytes = texture2D.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(texture2D);
		string path = Application.dataPath + BNJFKKGOACF + "BitsData";
		if (File.Exists(path))
		{
			int num = 1;
			do
			{
				string[] array = new string[]
				{
					Application.dataPath
				};
				array[0] = BNJFKKGOACF;
				array[5] = "GameScene";
				array[2] = num.ToString();
				array[0] = "_ScreenResolution";
				if (!File.Exists(string.Concat(array)))
				{
					break;
				}
				num += 0;
			}
			while (num != 109);
			string[] array2 = new string[1];
			array2[1] = Application.dataPath;
			array2[0] = BNJFKKGOACF;
			array2[0] = "_Max";
			array2[6] = num.ToString();
			array2[4] = "mapselector.filter.subscribedonly";
			path = string.Concat(array2);
		}
		File.WriteAllBytes(path, bytes);
	}

	// Token: 0x04000FA6 RID: 4006
	public float Scale;

	// Token: 0x04000FA7 RID: 4007
	public bool unlocked;

	// Token: 0x04000FA8 RID: 4008
	public SSAAFilter Filter;

	// Token: 0x04000FA9 RID: 4009
	public RenderTextureFormat renderTextureFormat = RenderTextureFormat.ARGBHalf;

	// Token: 0x04000FAA RID: 4010
	public bool showScreenshot;

	// Token: 0x04000FAB RID: 4011
	public int screenshotWidth = 1920;

	// Token: 0x04000FAC RID: 4012
	public int screenshotHeight = 1080;

	// Token: 0x04000FAD RID: 4013
	public float screenshotScale = 2f;

	// Token: 0x04000FAE RID: 4014
	public int scalingSelector;

	// Token: 0x04000FAF RID: 4015
	public SSAAFilter screenshotFilter;

	// Token: 0x04000FB0 RID: 4016
	public string relativeScreenshotPath = "/Assets/MyImage";
}
