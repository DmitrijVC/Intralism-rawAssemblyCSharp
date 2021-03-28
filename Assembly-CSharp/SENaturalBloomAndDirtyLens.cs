using System;
using UnityEngine;

// Token: 0x02000171 RID: 369
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Sonic Ether/SE Natural Bloom and Dirty Lens")]
public class SENaturalBloomAndDirtyLens : MonoBehaviour
{
	// Token: 0x06006C7E RID: 27774 RVA: 0x00219CF4 File Offset: 0x00217EF4
	private void HMPGIFBJFIK()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006C7F RID: 27775 RVA: 0x00219D50 File Offset: 0x00217F50
	private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)98;
		this.NBPKMLMCHFN.SetFloat("_CenterX", Mathf.Exp(this.bloomIntensity) - 1438f);
		this.NBPKMLMCHFN.SetFloat("\\n", Mathf.Exp(this.lensDirtIntensity) - 1560f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 5;
		for (int i = 1; i < 2; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 349f;
			}
			else
			{
				num4 = 1599f;
			}
			if (i == 7)
			{
				num4 = 544f;
			}
			for (int j = 1; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("_ScreenResolution", (this.NCCDJFKEGLH * 38f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("maps.", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_FarCamera", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("Horizontal", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("st", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 7;
		}
		this.NBPKMLMCHFN.SetTexture("new round", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006C80 RID: 27776 RVA: 0x00219FF0 File Offset: 0x002181F0
	private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)74;
		this.NBPKMLMCHFN.SetFloat("_Value", Mathf.Exp(this.bloomIntensity) - 317f);
		this.NBPKMLMCHFN.SetFloat("_Color", Mathf.Exp(this.lensDirtIntensity) - 1207f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 3;
		for (int i = 1; i < 8; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 568f;
			}
			else
			{
				num4 = 459f;
			}
			if (i == 8)
			{
				num4 = 234f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("SAVE FILE", (this.NCCDJFKEGLH * 1548f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("GroupNameText", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture(" not exist", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("[PlayerBase] Loaded custom model: ", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture(".", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 3;
		}
		this.NBPKMLMCHFN.SetTexture("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006C81 RID: 27777 RVA: 0x0021A290 File Offset: 0x00218490
	private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat(".GoalProgress", Mathf.Exp(this.bloomIntensity) - 1156f);
		this.NBPKMLMCHFN.SetFloat("Traffic Stats", Mathf.Exp(this.lensDirtIntensity) - 103f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 0;
		for (int i = 0; i < 3; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1434f;
			}
			else
			{
				num4 = 274f;
			}
			if (i == 0)
			{
				num4 = 816f;
			}
			for (int j = 1; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("HPToggle", (this.NCCDJFKEGLH * 1130f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("Multiplayer", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_Blue_B", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("#random #common #item", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_FgOverlap", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("finished", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 5;
			num2 /= 5;
		}
		this.NBPKMLMCHFN.SetTexture("_Value", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006C82 RID: 27778 RVA: 0x0021A530 File Offset: 0x00218730
	private void HHKBBEFJEBC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat("Gameplay/particles", Mathf.Exp(this.bloomIntensity) - 792f);
		this.NBPKMLMCHFN.SetFloat("CameraFilterPack/3D_Myst", Mathf.Exp(this.lensDirtIntensity) - 1690f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 8;
		for (int i = 0; i < 4; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 523f;
			}
			else
			{
				num4 = 724f;
			}
			if (i == 7)
			{
				num4 = 1009f;
			}
			for (int j = 0; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_LinearLight", (this.NCCDJFKEGLH * 1378f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("{0}", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture(".wav", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("MouseY", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("Bad parameters for getint! Use <key> <value>", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture(" ", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 0;
		}
		this.NBPKMLMCHFN.SetTexture("_Value", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006C83 RID: 27779 RVA: 0x0021A7D0 File Offset: 0x002189D0
	private void ICILLMAKLMI()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006C84 RID: 27780 RVA: 0x0021A82C File Offset: 0x00218A2C
	private void NBGIMIDICKE()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006C85 RID: 27781 RVA: 0x0021A888 File Offset: 0x00218A88
	private void FLKEJJEGCFA()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006C86 RID: 27782 RVA: 0x0021A8E4 File Offset: 0x00218AE4
	private void KOJKBFDNGDK()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006C87 RID: 27783 RVA: 0x0021A940 File Offset: 0x00218B40
	private void ABIOAMNCEOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		this.NBPKMLMCHFN.SetFloat("HiddenToggle", Mathf.Exp(this.bloomIntensity) - 566f);
		this.NBPKMLMCHFN.SetFloat("color", Mathf.Exp(this.lensDirtIntensity) - 1720f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 7;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 7;
		for (int i = 1; i < 8; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1107f;
			}
			else
			{
				num4 = 1699f;
			}
			if (i == 6)
			{
				num4 = 1532f;
			}
			for (int j = 0; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", (this.NCCDJFKEGLH * 1762f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_BlurDirectionPacked", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture(" from: ", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("#close", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_Value1", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("CameraFilterPack/FX_Ascii", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_Radius", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 6;
		}
		this.NBPKMLMCHFN.SetTexture("_ScreenResolution", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006C88 RID: 27784 RVA: 0x0021ABE0 File Offset: 0x00218DE0
	private void HGJJPACDBEP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)119;
		this.NBPKMLMCHFN.SetFloat(" Remote called.", Mathf.Exp(this.bloomIntensity) - 536f);
		this.NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Exp(this.lensDirtIntensity) - 393f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 6;
		for (int i = 0; i < 2; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1937f;
			}
			else
			{
				num4 = 1645f;
			}
			if (i == 4)
			{
				num4 = 1176f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat(" - ", (this.NCCDJFKEGLH * 1126f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("#tryagain", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("Operation failed: ", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_CenterX", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("closed", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 2;
		}
		this.NBPKMLMCHFN.SetTexture("z", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006C89 RID: 27785 RVA: 0x0021AE80 File Offset: 0x00219080
	private void CCLNNLCOPBL()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006C8A RID: 27786 RVA: 0x0021AEDC File Offset: 0x002190DC
	private void EDPDMBFLHLP()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006C8B RID: 27787 RVA: 0x0021AF38 File Offset: 0x00219138
	private void JABNHMIHBHC()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006C8C RID: 27788 RVA: 0x0021AF93 File Offset: 0x00219193
	private void LLKKGGLNIDF()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C8D RID: 27789 RVA: 0x0021AF93 File Offset: 0x00219193
	private void IBPAMDEAGJL()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C8E RID: 27790 RVA: 0x0021AFB0 File Offset: 0x002191B0
	private void BGMNONMHAJP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-117);
		this.NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Exp(this.bloomIntensity) - 1166f);
		this.NBPKMLMCHFN.SetFloat("Reset All", Mathf.Exp(this.lensDirtIntensity) - 1760f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 4;
		for (int i = 0; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 157f;
			}
			else
			{
				num4 = 243f;
			}
			if (i == 0)
			{
				num4 = 1296f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("_Value", (this.NCCDJFKEGLH * 1490f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("Item ", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("yyyy-MM-dd HH:mm:ss", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_ConsoleSettings", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("[EMPTY]", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("Best region found in PlayerPrefs. Connecting to: ", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 8;
		}
		this.NBPKMLMCHFN.SetTexture("SendVacantViewIds()", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006C8F RID: 27791 RVA: 0x0021AF93 File Offset: 0x00219193
	private void GKNKIIEALCH()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C90 RID: 27792 RVA: 0x0021AF93 File Offset: 0x00219193
	private void FDMAEPOHDMK()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C91 RID: 27793 RVA: 0x0021B250 File Offset: 0x00219450
	private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat("VIGNETTE_BLUR", Mathf.Exp(this.bloomIntensity) - 1759f);
		this.NBPKMLMCHFN.SetFloat("#ok", Mathf.Exp(this.lensDirtIntensity) - 1613f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 5;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 6;
		for (int i = 1; i < 4; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1048f;
			}
			else
			{
				num4 = 879f;
			}
			if (i == 1)
			{
				num4 = 565f;
			}
			for (int j = 0; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("_ScreenResolution", (this.NCCDJFKEGLH * 1607f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("Set EnvSprite Image", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_CameraToWorldMatrix", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("restart", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("[Up-Right-Left]", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 4;
		}
		this.NBPKMLMCHFN.SetTexture("Loss ", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006C92 RID: 27794 RVA: 0x0021AF93 File Offset: 0x00219193
	private void DHENLPJJOEN()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C93 RID: 27795 RVA: 0x0021AF93 File Offset: 0x00219193
	private void BAEHKBADMAO()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C94 RID: 27796 RVA: 0x0021B4F0 File Offset: 0x002196F0
	private void MEBPBNLBECA()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006C95 RID: 27797 RVA: 0x0021AF93 File Offset: 0x00219193
	private void FGBDGGCBFLP()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C96 RID: 27798 RVA: 0x0021AF93 File Offset: 0x00219193
	private void EDBEHEKMGFH()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C97 RID: 27799 RVA: 0x0021AF93 File Offset: 0x00219193
	private void HNILMGEKDEC()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C98 RID: 27800 RVA: 0x0021AF93 File Offset: 0x00219193
	private void HLLHJIDOOGA()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C99 RID: 27801 RVA: 0x0021B54C File Offset: 0x0021974C
	private void FEHCNJLLJMP()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006C9A RID: 27802 RVA: 0x0021AF93 File Offset: 0x00219193
	private void GBGAMCPNBCC()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C9B RID: 27803 RVA: 0x0021AF93 File Offset: 0x00219193
	private void OFPPIKHNJOD()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C9C RID: 27804 RVA: 0x0021AF93 File Offset: 0x00219193
	private void FKDEEJFNNJC()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C9D RID: 27805 RVA: 0x0021AF93 File Offset: 0x00219193
	private void KLDNGKBMDAN()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006C9E RID: 27806 RVA: 0x0021B5A8 File Offset: 0x002197A8
	private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat("MenuScene", Mathf.Exp(this.bloomIntensity) - 994f);
		this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Color_Chromatic_Aberration", Mathf.Exp(this.lensDirtIntensity) - 383f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 5;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 0;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 386f;
			}
			else
			{
				num4 = 990f;
			}
			if (i == 2)
			{
				num4 = 1070f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("_Amount", (this.NCCDJFKEGLH * 1117f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("<b>#", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_NoOuterClip", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("skin.", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("/", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("Player Connected", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 1;
		}
		this.NBPKMLMCHFN.SetTexture("Please wait..", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006C9F RID: 27807 RVA: 0x0021AF93 File Offset: 0x00219193
	private void EDCMIPNCPLB()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CA0 RID: 27808 RVA: 0x0021B848 File Offset: 0x00219A48
	private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = HideFlags.HideAndDontSave;
		this.NBPKMLMCHFN.SetFloat("_BloomIntensity", Mathf.Exp(this.bloomIntensity) - 1f);
		this.NBPKMLMCHFN.SetFloat("_LensDirtIntensity", Mathf.Exp(this.lensDirtIntensity) - 1f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 2;
		for (int i = 0; i < 6; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 1f;
			}
			else
			{
				num4 = 0.5f;
			}
			if (i == 2)
			{
				num4 = 0.75f;
			}
			for (int j = 0; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("_BlurSize", (this.NCCDJFKEGLH * 0.5f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_Bloom0", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_Bloom1", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_Bloom2", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_Bloom3", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_Bloom4", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_Bloom5", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 2;
		}
		this.NBPKMLMCHFN.SetTexture("_LensDirt", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CA1 RID: 27809 RVA: 0x0021BAE8 File Offset: 0x00219CE8
	private void CEDFFAOOPOG()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CA2 RID: 27810 RVA: 0x0021AF93 File Offset: 0x00219193
	private void MFBCLNAHEFO()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CA3 RID: 27811 RVA: 0x0021BB44 File Offset: 0x00219D44
	private void NFJFHPCMEGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat("Result for ", Mathf.Exp(this.bloomIntensity) - 519f);
		this.NBPKMLMCHFN.SetFloat("OK", Mathf.Exp(this.lensDirtIntensity) - 1341f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 6;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 672f;
			}
			else
			{
				num4 = 668f;
			}
			if (i == 6)
			{
				num4 = 1326f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat(".completedMaps", (this.NCCDJFKEGLH * 680f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("#startofflinemessage", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("[MenuScene] Error: ", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture(".", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("EventSystem", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 1;
		}
		this.NBPKMLMCHFN.SetTexture(" not exist", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006CA4 RID: 27812 RVA: 0x0021BDE4 File Offset: 0x00219FE4
	private void NEFHGMNAPEP()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CA5 RID: 27813 RVA: 0x0021BE40 File Offset: 0x0021A040
	private void GNJDKAECPKA()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CA6 RID: 27814 RVA: 0x0021BE9C File Offset: 0x0021A09C
	private void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)96;
		this.NBPKMLMCHFN.SetFloat("mapselector.filter.rateduponly", Mathf.Exp(this.bloomIntensity) - 846f);
		this.NBPKMLMCHFN.SetFloat("InfoText", Mathf.Exp(this.lensDirtIntensity) - 1663f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 4;
		for (int i = 1; i < 4; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 1259f;
			}
			else
			{
				num4 = 222f;
			}
			if (i == 1)
			{
				num4 = 1107f;
			}
			for (int j = 0; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("maps.", (this.NCCDJFKEGLH * 970f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("The shader ", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_Value3", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_DistortionSize", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("yyyy-MM-dd HH:mm:ss", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 7;
		}
		this.NBPKMLMCHFN.SetTexture("Joystick1Button10", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006CA7 RID: 27815 RVA: 0x0021C13C File Offset: 0x0021A33C
	private void CGDMLHLJIDK()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CA8 RID: 27816 RVA: 0x0021C198 File Offset: 0x0021A398
	private void AKHCOBHHGJP()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CA9 RID: 27817 RVA: 0x0021AF93 File Offset: 0x00219193
	private void KMOCDAOKGLI()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CAA RID: 27818 RVA: 0x0021AF93 File Offset: 0x00219193
	private void OnDisable()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CAB RID: 27819 RVA: 0x0021AF93 File Offset: 0x00219193
	private void CPAJLKHMOJB()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CAC RID: 27820 RVA: 0x0021AF93 File Offset: 0x00219193
	private void MKFLBEGJJDC()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CAD RID: 27821 RVA: 0x0021C1F4 File Offset: 0x0021A3F4
	private void MKIMDFLBFOM()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CAE RID: 27822 RVA: 0x0021C250 File Offset: 0x0021A450
	private void CCFEDENFNEF()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CAF RID: 27823 RVA: 0x0021C2AC File Offset: 0x0021A4AC
	private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-126);
		this.NBPKMLMCHFN.SetFloat("PhotonView with ID ", Mathf.Exp(this.bloomIntensity) - 1721f);
		this.NBPKMLMCHFN.SetFloat("Vertical", Mathf.Exp(this.lensDirtIntensity) - 1273f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 3;
		for (int i = 1; i < 5; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1420f;
			}
			else
			{
				num4 = 1620f;
			}
			if (i == 8)
			{
				num4 = 1271f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("workshop.", (this.NCCDJFKEGLH * 184f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_Blue_C", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("player.orangelifering", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("CameraFilterPack/TV_Videoflip", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture(".r", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("offsets", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("Version 1.0", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 8;
		}
		this.NBPKMLMCHFN.SetTexture("input", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CB0 RID: 27824 RVA: 0x0021C54C File Offset: 0x0021A74C
	private void MGMAOBPPOBJ()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CB1 RID: 27825 RVA: 0x0021C5A8 File Offset: 0x0021A7A8
	private void JKMBDBCDJAL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)69;
		this.NBPKMLMCHFN.SetFloat("skin.", Mathf.Exp(this.bloomIntensity) - 1890f);
		this.NBPKMLMCHFN.SetFloat("menuthemes", Mathf.Exp(this.lensDirtIntensity) - 1758f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 3;
		for (int i = 0; i < 1; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 1762f;
			}
			else
			{
				num4 = 497f;
			}
			if (i == 5)
			{
				num4 = 821f;
			}
			for (int j = 0; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("#scoresubmitionfailed: ", (this.NCCDJFKEGLH * 1117f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("[LevelEditorScene] Error: You're not logged into Steam!", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("EndlessLoopsScoreText", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("CameraFilterPack/Colors_DarkColor", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("SetScale", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("LoadPlayerSkin", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 5;
			num2 /= 0;
		}
		this.NBPKMLMCHFN.SetTexture("DPADVER", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CB2 RID: 27826 RVA: 0x0021C848 File Offset: 0x0021AA48
	private void BMIOFJFMCBG()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CB3 RID: 27827 RVA: 0x0021C8A4 File Offset: 0x0021AAA4
	private void MODENHKMKOC()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CB4 RID: 27828 RVA: 0x0021AF93 File Offset: 0x00219193
	private void ELDMKIAPNGP()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CB5 RID: 27829 RVA: 0x0021AF93 File Offset: 0x00219193
	private void BLKGOMCPEKI()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CB6 RID: 27830 RVA: 0x0021AF93 File Offset: 0x00219193
	private void DLMPALHKMON()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CB7 RID: 27831 RVA: 0x0021C900 File Offset: 0x0021AB00
	private void KDOCJGGAOII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)76;
		this.NBPKMLMCHFN.SetFloat("inventory.selected.", Mathf.Exp(this.bloomIntensity) - 626f);
		this.NBPKMLMCHFN.SetFloat("Missing shader in ", Mathf.Exp(this.lensDirtIntensity) - 1822f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 7;
		for (int i = 0; i < 1; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 717f;
			}
			else
			{
				num4 = 115f;
			}
			if (i == 8)
			{
				num4 = 491f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("LevelEditor/icons", (this.NCCDJFKEGLH * 1576f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("/icon", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("VisionBlur", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("Keypad", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("InventoryButton", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 5;
		}
		this.NBPKMLMCHFN.SetTexture("#FFFFFF", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CB8 RID: 27832 RVA: 0x0021CBA0 File Offset: 0x0021ADA0
	private void FHGKIOOMMOH()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CB9 RID: 27833 RVA: 0x0021CBFC File Offset: 0x0021ADFC
	private void Start()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CBA RID: 27834 RVA: 0x0021CC58 File Offset: 0x0021AE58
	private void PLEOOAJIMEE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = ~HideFlags.HideInInspector;
		this.NBPKMLMCHFN.SetFloat("_Value5", Mathf.Exp(this.bloomIntensity) - 1690f);
		this.NBPKMLMCHFN.SetFloat("CameraFilterPack_Paper2", Mathf.Exp(this.lensDirtIntensity) - 952f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 6;
		for (int i = 0; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1857f;
			}
			else
			{
				num4 = 912f;
			}
			if (i == 7)
			{
				num4 = 1262f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("_GreenAmplifier", (this.NCCDJFKEGLH * 1999f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("Scenes List:", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("inventory.selected.", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("DPADHOR", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_SecondTex", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("[MenuScene] Error: ", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 4;
		}
		this.NBPKMLMCHFN.SetTexture("float,2", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006CBB RID: 27835 RVA: 0x0021AF93 File Offset: 0x00219193
	private void LINKAMEPKGM()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CBC RID: 27836 RVA: 0x0021AF93 File Offset: 0x00219193
	private void BNLENEDAHHL()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CBD RID: 27837 RVA: 0x0021CEF8 File Offset: 0x0021B0F8
	private void IDJKNBDKHBD()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CBE RID: 27838 RVA: 0x0021CF54 File Offset: 0x0021B154
	private void NPLCENPNJBM()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CBF RID: 27839 RVA: 0x0021CFB0 File Offset: 0x0021B1B0
	private void KMCPMOGKDEH()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CC0 RID: 27840 RVA: 0x0021D00C File Offset: 0x0021B20C
	private void DHJKAOMONAJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat("FToA", Mathf.Exp(this.bloomIntensity) - 1665f);
		this.NBPKMLMCHFN.SetFloat("mapselector.orderby", Mathf.Exp(this.lensDirtIntensity) - 489f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 3;
		for (int i = 1; i < 6; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 292f;
			}
			else
			{
				num4 = 106f;
			}
			if (i == 5)
			{
				num4 = 828f;
			}
			for (int j = 0; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("_Offsets", (this.NCCDJFKEGLH * 1205f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("element", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture(".jpg", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("Day_", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_ReflectionTexture3", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 1;
		}
		this.NBPKMLMCHFN.SetTexture("Done!", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CC1 RID: 27841 RVA: 0x0021D2AC File Offset: 0x0021B4AC
	private void CHOPDIGHJNH()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CC2 RID: 27842 RVA: 0x0021D308 File Offset: 0x0021B508
	private void ALNNIDLFILB()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CC3 RID: 27843 RVA: 0x0021D364 File Offset: 0x0021B564
	private void DAHFFNNIGML()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CC4 RID: 27844 RVA: 0x0021AF93 File Offset: 0x00219193
	private void HCDBNAKGDJC()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CC5 RID: 27845 RVA: 0x0021D3C0 File Offset: 0x0021B5C0
	private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", Mathf.Exp(this.bloomIntensity) - 797f);
		this.NBPKMLMCHFN.SetFloat("BadgeText", Mathf.Exp(this.lensDirtIntensity) - 839f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 3;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 2;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 200f;
			}
			else
			{
				num4 = 1914f;
			}
			if (i == 1)
			{
				num4 = 1317f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("_Screen", (this.NCCDJFKEGLH * 592f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_Near", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture(".lastCheckpoint.checkpointsUsed", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_FixDistance", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("[DiscordController] Sectate ({0})", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("ns", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 5;
		}
		this.NBPKMLMCHFN.SetTexture("Failed to 'GetKeyCode' for key: ", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CC6 RID: 27846 RVA: 0x0021D660 File Offset: 0x0021B860
	private void IHAAHFFMJLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-112);
		this.NBPKMLMCHFN.SetFloat("quit", Mathf.Exp(this.bloomIntensity) - 465f);
		this.NBPKMLMCHFN.SetFloat("_Value2", Mathf.Exp(this.lensDirtIntensity) - 1627f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 2;
		for (int i = 0; i < 4; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 735f;
			}
			else
			{
				num4 = 1129f;
			}
			if (i == 5)
			{
				num4 = 130f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("Fade", (this.NCCDJFKEGLH * 63f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_BorderSize", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_EmissionColor", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("Items", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("arcs", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 2;
		}
		this.NBPKMLMCHFN.SetTexture("/", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006CC7 RID: 27847 RVA: 0x0021AF93 File Offset: 0x00219193
	private void FJIKDJAMOHA()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CC8 RID: 27848 RVA: 0x0021AF93 File Offset: 0x00219193
	private void MCKCCPLJIFE()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CC9 RID: 27849 RVA: 0x0021D900 File Offset: 0x0021BB00
	private void NDBPCNICGLC()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CCA RID: 27850 RVA: 0x0021D95C File Offset: 0x0021BB5C
	private void EGKNJMMAOAO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-107);
		this.NBPKMLMCHFN.SetFloat("EnableRankingToggle", Mathf.Exp(this.bloomIntensity) - 1344f);
		this.NBPKMLMCHFN.SetFloat("/Saved Games/", Mathf.Exp(this.lensDirtIntensity) - 577f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 8;
		for (int i = 0; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 728f;
			}
			else
			{
				num4 = 1378f;
			}
			if (i == 7)
			{
				num4 = 787f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", (this.NCCDJFKEGLH * 1258f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture(".highscore", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_LightIntensity", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("UseFinalGlassColor", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_SprTex", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("Crosshair1", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_CameraWS", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 0;
		}
		this.NBPKMLMCHFN.SetTexture("_Red_B", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CCB RID: 27851 RVA: 0x0021DBFC File Offset: 0x0021BDFC
	private void MMPHNFPPEHO()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CCC RID: 27852 RVA: 0x0021DC58 File Offset: 0x0021BE58
	private void KHIGHFJKPFG()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CCD RID: 27853 RVA: 0x0021AF93 File Offset: 0x00219193
	private void AMHEJBMLFNM()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CCE RID: 27854 RVA: 0x0021DCB4 File Offset: 0x0021BEB4
	private void KPOCGNOKNOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-86);
		this.NBPKMLMCHFN.SetFloat("VisionBlur", Mathf.Exp(this.bloomIntensity) - 1007f);
		this.NBPKMLMCHFN.SetFloat("Left", Mathf.Exp(this.lensDirtIntensity) - 298f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 0;
		for (int i = 0; i < 5; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 1716f;
			}
			else
			{
				num4 = 1821f;
			}
			if (i == 7)
			{
				num4 = 890f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("23x3", (this.NCCDJFKEGLH * 1146f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_HSV", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("GlassColor", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("ArcsDestroyDelaySlider", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("Traffic Stats", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 7;
		}
		this.NBPKMLMCHFN.SetTexture("mainmenu", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006CCF RID: 27855 RVA: 0x0021DF54 File Offset: 0x0021C154
	private void GENCBNFIILN(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat("_Value3", Mathf.Exp(this.bloomIntensity) - 208f);
		this.NBPKMLMCHFN.SetFloat("ShowSprite", Mathf.Exp(this.lensDirtIntensity) - 1020f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 3;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 8;
		for (int i = 1; i < 0; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1201f;
			}
			else
			{
				num4 = 415f;
			}
			if (i == 2)
			{
				num4 = 1708f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("_Color", (this.NCCDJFKEGLH * 1464f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("[NetworkManager] Connecting...", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_PosX", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_Radius", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("[Up-Right-Down]", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("[ItemsHandler] Loading ", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("SetSunDirectionVector", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 1;
		}
		this.NBPKMLMCHFN.SetTexture(".lastCheckpoint.bgcolor", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006CD0 RID: 27856 RVA: 0x0021E1F4 File Offset: 0x0021C3F4
	private void ALJEJJCIMJN()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CD1 RID: 27857 RVA: 0x0021AF93 File Offset: 0x00219193
	private void ODGMCJILIHF()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CD2 RID: 27858 RVA: 0x0021AF93 File Offset: 0x00219193
	private void HONBLGFDMLL()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CD3 RID: 27859 RVA: 0x0021E250 File Offset: 0x0021C450
	private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-107);
		this.NBPKMLMCHFN.SetFloat("finished", Mathf.Exp(this.bloomIntensity) - 1451f);
		this.NBPKMLMCHFN.SetFloat("Case-Sensitive", Mathf.Exp(this.lensDirtIntensity) - 762f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 1;
		for (int i = 1; i < 1; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 1026f;
			}
			else
			{
				num4 = 593f;
			}
			if (i == 7)
			{
				num4 = 401f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("yes", (this.NCCDJFKEGLH * 112f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("Year_", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("-1", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("bans.viewed.", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("To Log", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("CameraFilterPack/Glasses_On", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 1;
		}
		this.NBPKMLMCHFN.SetTexture("_FarCamera", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006CD4 RID: 27860 RVA: 0x0021E4F0 File Offset: 0x0021C6F0
	private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)116;
		this.NBPKMLMCHFN.SetFloat("RoomDescriptionText", Mathf.Exp(this.bloomIntensity) - 905f);
		this.NBPKMLMCHFN.SetFloat("_Value5", Mathf.Exp(this.lensDirtIntensity) - 400f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 7;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 38f;
			}
			else
			{
				num4 = 1653f;
			}
			if (i == 8)
			{
				num4 = 1177f;
			}
			for (int j = 1; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("https://bugs.khb-soft.ru/set_project.php?project_id=1", (this.NCCDJFKEGLH * 1545f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("PerfectHitsScoreText", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("ShadersToggle", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture(": ", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_OffsetScale", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("mapselector.filter.subscribedonly", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 0;
		}
		this.NBPKMLMCHFN.SetTexture("_SweaterSize", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CD5 RID: 27861 RVA: 0x0021E790 File Offset: 0x0021C990
	private void LKBOEPPBLIF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)117;
		this.NBPKMLMCHFN.SetFloat("GameScene", Mathf.Exp(this.bloomIntensity) - 393f);
		this.NBPKMLMCHFN.SetFloat("_PosY", Mathf.Exp(this.lensDirtIntensity) - 1382f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 0;
		for (int i = 1; i < 7; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1322f;
			}
			else
			{
				num4 = 798f;
			}
			if (i == 8)
			{
				num4 = 1079f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("Screen Space Reflections", (this.NCCDJFKEGLH * 1569f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("settings.volume.menu", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("UsernameText", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("GhostFade", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("Inside cells:\n", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("maps.", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 2;
		}
		this.NBPKMLMCHFN.SetTexture("settings.disablestoryboard", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CD6 RID: 27862 RVA: 0x0021EA30 File Offset: 0x0021CC30
	private void MNBPNHNAEBK()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CD7 RID: 27863 RVA: 0x0021EA8C File Offset: 0x0021CC8C
	private void OPHBLNNGFKG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)96;
		this.NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Exp(this.bloomIntensity) - 202f);
		this.NBPKMLMCHFN.SetFloat("BadgeText", Mathf.Exp(this.lensDirtIntensity) - 723f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 1;
		for (int i = 1; i < 6; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 248f;
			}
			else
			{
				num4 = 654f;
			}
			if (i == 7)
			{
				num4 = 1064f;
			}
			for (int j = 1; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("_Near", (this.NCCDJFKEGLH * 1234f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_PrevViewProj", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("UseScanLine", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("TotalHitsScoreText", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_BlurPass", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("setfloat", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("Scene", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 8;
		}
		this.NBPKMLMCHFN.SetTexture("_ColorBuffer", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CD8 RID: 27864 RVA: 0x0021ED2C File Offset: 0x0021CF2C
	private void JCCIHFMBFJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", Mathf.Exp(this.bloomIntensity) - 1082f);
		this.NBPKMLMCHFN.SetFloat("settings.shaders.bloomintencity", Mathf.Exp(this.lensDirtIntensity) - 917f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 0;
		for (int i = 0; i < 4; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1611f;
			}
			else
			{
				num4 = 728f;
			}
			if (i == 3)
			{
				num4 = 1700f;
			}
			for (int j = 1; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", (this.NCCDJFKEGLH * 508f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_Offsets", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("Coroutine container not configured... did you forget to call Init?", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("[Left]", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("ticket.ticket1", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture(" evLeave: ", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 4;
		}
		this.NBPKMLMCHFN.SetTexture("[SteamManager] Connection established, authorization", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CD9 RID: 27865 RVA: 0x0021EFCC File Offset: 0x0021D1CC
	private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat("_LutTex", Mathf.Exp(this.bloomIntensity) - 9f);
		this.NBPKMLMCHFN.SetFloat("Set Crosshair Color", Mathf.Exp(this.lensDirtIntensity) - 1520f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 3;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 6;
		for (int i = 1; i < 1; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 487f;
			}
			else
			{
				num4 = 979f;
			}
			if (i == 0)
			{
				num4 = 1910f;
			}
			for (int j = 1; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("data", (this.NCCDJFKEGLH * 1583f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("SlidingArea", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("maps.", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("event", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_Red_G", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 0;
		}
		this.NBPKMLMCHFN.SetTexture("FileLabel", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006CDA RID: 27866 RVA: 0x0021F26C File Offset: 0x0021D46C
	private void GAANDCGCBHF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.NBPKMLMCHFN.SetFloat("HandleEventLeave for player ID: ", Mathf.Exp(this.bloomIntensity) - 953f);
		this.NBPKMLMCHFN.SetFloat("ready", Mathf.Exp(this.lensDirtIntensity) - 1679f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 5;
		for (int i = 0; i < 7; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 279f;
			}
			else
			{
				num4 = 1350f;
			}
			if (i == 6)
			{
				num4 = 1777f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("_BlurRadius4", (this.NCCDJFKEGLH * 1360f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("HandsCountSlider", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("shader.frost", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("Oct", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("\\\\", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("#newhighscore", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 8;
		}
		this.NBPKMLMCHFN.SetTexture("Set sun beat detection sensitivity", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CDB RID: 27867 RVA: 0x0021F50C File Offset: 0x0021D70C
	private void ILCFPCIPENO()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CDC RID: 27868 RVA: 0x0021F568 File Offset: 0x0021D768
	private void FIKFJDFELIP()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CDD RID: 27869 RVA: 0x0021F5C4 File Offset: 0x0021D7C4
	private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-67);
		this.NBPKMLMCHFN.SetFloat("/", Mathf.Exp(this.bloomIntensity) - 1242f);
		this.NBPKMLMCHFN.SetFloat("PunSupportLogger", Mathf.Exp(this.lensDirtIntensity) - 567f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 4;
		for (int i = 1; i < 3; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 1055f;
			}
			else
			{
				num4 = 1804f;
			}
			if (i == 3)
			{
				num4 = 1407f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("_Distance", (this.NCCDJFKEGLH * 889f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_DistortionLevel", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("blue", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_CutOff", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("GlassesColor", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_Threshold", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("#mapnotloaded", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 5;
		}
		this.NBPKMLMCHFN.SetTexture(", data: ", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CDE RID: 27870 RVA: 0x0021F864 File Offset: 0x0021DA64
	private void HPFOFGJPNCI()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CDF RID: 27871 RVA: 0x0021F8C0 File Offset: 0x0021DAC0
	private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		this.NBPKMLMCHFN.SetFloat("UseScanLineSize", Mathf.Exp(this.bloomIntensity) - 547f);
		this.NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Exp(this.lensDirtIntensity) - 1436f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 4;
		for (int i = 0; i < 0; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1622f;
			}
			else
			{
				num4 = 1367f;
			}
			if (i == 6)
			{
				num4 = 1299f;
			}
			for (int j = 0; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("cipherText", (this.NCCDJFKEGLH * 837f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("z", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("GlassAberration", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_AdaptParams", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("MouseX", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_DiffuseColor", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_EmissionColor", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 7;
		}
		this.NBPKMLMCHFN.SetTexture("ReconnectAndRejoin() disabled the offline mode. No longer offline.", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CE0 RID: 27872 RVA: 0x0021FB60 File Offset: 0x0021DD60
	private void AEMGPJDJGBJ()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CE1 RID: 27873 RVA: 0x0021AF93 File Offset: 0x00219193
	private void JNGMIAFLBDL()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CE2 RID: 27874 RVA: 0x0021FBBC File Offset: 0x0021DDBC
	private void IKDNLHLBHID()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CE3 RID: 27875 RVA: 0x0021FC18 File Offset: 0x0021DE18
	private void DPLLKHHLDBB()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CE4 RID: 27876 RVA: 0x0021AF93 File Offset: 0x00219193
	private void IFIHBNJKEKD()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CE5 RID: 27877 RVA: 0x0021FC74 File Offset: 0x0021DE74
	private void IMCKJCHKMKB()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CE6 RID: 27878 RVA: 0x0021AF93 File Offset: 0x00219193
	private void JOJFHFHOCHO()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CE7 RID: 27879 RVA: 0x0021FCD0 File Offset: 0x0021DED0
	private void JIHNFLGAMJE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		this.NBPKMLMCHFN.SetFloat("float,0", Mathf.Exp(this.bloomIntensity) - 796f);
		this.NBPKMLMCHFN.SetFloat("_Val2", Mathf.Exp(this.lensDirtIntensity) - 1405f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 1;
		for (int i = 1; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 291f;
			}
			else
			{
				num4 = 239f;
			}
			if (i == 2)
			{
				num4 = 537f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Luminosity", (this.NCCDJFKEGLH * 1463f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("CameraFilterPack/Blend2Camera_Overlay", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("settings.cameramovements", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("UpperMid", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture(",", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture(") but there is no recycle bin setup for it", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("BackButton", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 8;
		}
		this.NBPKMLMCHFN.SetTexture("1", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CE8 RID: 27880 RVA: 0x0021FF70 File Offset: 0x0021E170
	private void LFAFJKJAEEL()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CE9 RID: 27881 RVA: 0x0021AF93 File Offset: 0x00219193
	private void AOKOLPEGHDD()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CEA RID: 27882 RVA: 0x0021FFCC File Offset: 0x0021E1CC
	private void JKBMKPDGCHG()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CEB RID: 27883 RVA: 0x00220028 File Offset: 0x0021E228
	private void KOIKNJLPOPA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-69);
		this.NBPKMLMCHFN.SetFloat("[NetworkManager] Join failed", Mathf.Exp(this.bloomIntensity) - 875f);
		this.NBPKMLMCHFN.SetFloat("_LensDirt", Mathf.Exp(this.lensDirtIntensity) - 302f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 5;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 2;
		for (int i = 0; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 1371f;
			}
			else
			{
				num4 = 1823f;
			}
			if (i == 0)
			{
				num4 = 1322f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("Set the end of the map. Use this if you want to cut the long music.", (this.NCCDJFKEGLH * 475f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_TapMedium", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("CameraFilterPack/Blend2Camera_ColorDodge", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture(":</b> ", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("https://www.youtube.com/watch?v=cDVXukrKo74", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_Blue_G", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 6;
		}
		this.NBPKMLMCHFN.SetTexture("ICollection", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CEC RID: 27884 RVA: 0x002202C8 File Offset: 0x0021E4C8
	private void PMPKMGKAAJH()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CED RID: 27885 RVA: 0x00220324 File Offset: 0x0021E524
	private void JJCEACGCOHB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-68);
		this.NBPKMLMCHFN.SetFloat("settings.selectormapsperpage", Mathf.Exp(this.bloomIntensity) - 1061f);
		this.NBPKMLMCHFN.SetFloat(" (inactive)", Mathf.Exp(this.lensDirtIntensity) - 1872f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 7;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 1;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 945f;
			}
			else
			{
				num4 = 489f;
			}
			if (i == 4)
			{
				num4 = 1926f;
			}
			for (int j = 1; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("SetSunLerpSpeed", (this.NCCDJFKEGLH * 920f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("CameraFilterPack/Lut_PlayWith", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_Value3", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_Value3", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("ResetSpeed", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("SetRotation", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 5;
		}
		this.NBPKMLMCHFN.SetTexture("Ownership mode == fixed. Ignoring request.", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CEE RID: 27886 RVA: 0x002205C4 File Offset: 0x0021E7C4
	private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-127);
		this.NBPKMLMCHFN.SetFloat("#restart", Mathf.Exp(this.bloomIntensity) - 1280f);
		this.NBPKMLMCHFN.SetFloat("BadgeText", Mathf.Exp(this.lensDirtIntensity) - 946f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 7;
		for (int i = 0; i < 5; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 885f;
			}
			else
			{
				num4 = 371f;
			}
			if (i == 2)
			{
				num4 = 1539f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat(".played", (this.NCCDJFKEGLH * 1511f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("mapselector.orderby", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("GameModeText", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_Visualize", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("</color>", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("UseScanLine", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("Set EnvSprite Color", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 7;
		}
		this.NBPKMLMCHFN.SetTexture("_TimeX", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CEF RID: 27887 RVA: 0x00220864 File Offset: 0x0021EA64
	private void NEIOOEKEOPC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-69);
		this.NBPKMLMCHFN.SetFloat("_Distance", Mathf.Exp(this.bloomIntensity) - 1223f);
		this.NBPKMLMCHFN.SetFloat(" isInactive: ", Mathf.Exp(this.lensDirtIntensity) - 1377f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 5;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1188f;
			}
			else
			{
				num4 = 1963f;
			}
			if (i == 2)
			{
				num4 = 507f;
			}
			for (int j = 1; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", (this.NCCDJFKEGLH * 933f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("Set Sun MaxSize", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("mapselector.filter.favoriteonly", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("Vertical", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("Tab2Content", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("0", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("CameraFilterPack/Color_BrightContrastSaturation", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 1;
		}
		this.NBPKMLMCHFN.SetTexture("[LevelEditorScene] Print Audio Wave: Start", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006CF0 RID: 27888 RVA: 0x00220B04 File Offset: 0x0021ED04
	private void FNCDAPDOBBI()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CF1 RID: 27889 RVA: 0x00220B60 File Offset: 0x0021ED60
	private void DKOPKPBLDHH()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CF2 RID: 27890 RVA: 0x0021AF93 File Offset: 0x00219193
	private void PLIKADJCEPO()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CF3 RID: 27891 RVA: 0x0021AF93 File Offset: 0x00219193
	private void ODAIMOJLJOF()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CF4 RID: 27892 RVA: 0x00220BBC File Offset: 0x0021EDBC
	private void HIPEHGNBJMN()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CF5 RID: 27893 RVA: 0x00220C18 File Offset: 0x0021EE18
	private void DOFDGBGEDFI()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CF6 RID: 27894 RVA: 0x0021AF93 File Offset: 0x00219193
	private void EKCKJLFFAID()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CF7 RID: 27895 RVA: 0x00220C74 File Offset: 0x0021EE74
	private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)92;
		this.NBPKMLMCHFN.SetFloat("maps.", Mathf.Exp(this.bloomIntensity) - 769f);
		this.NBPKMLMCHFN.SetFloat("menu.tabid", Mathf.Exp(this.lensDirtIntensity) - 418f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 8;
		for (int i = 1; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 375f;
			}
			else
			{
				num4 = 1010f;
			}
			if (i == 8)
			{
				num4 = 1798f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("_BlurPass", (this.NCCDJFKEGLH * 1281f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("Tab2Content", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("View ({3}){0} on {1} {2}", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("CameraFilterPack/Vision_Hell_Blood", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("RoomPlayersCountText", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("y", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 8;
		}
		this.NBPKMLMCHFN.SetTexture("BadgeText", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006CF8 RID: 27896 RVA: 0x00220F14 File Offset: 0x0021F114
	private void BOPKKCAFODF()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006CF9 RID: 27897 RVA: 0x00220F70 File Offset: 0x0021F170
	private void ANCKKLFPGDI()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CFA RID: 27898 RVA: 0x00220FCC File Offset: 0x0021F1CC
	private void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = HideFlags.HideInHierarchy;
		this.NBPKMLMCHFN.SetFloat("settings.enableranking", Mathf.Exp(this.bloomIntensity) - 1834f);
		this.NBPKMLMCHFN.SetFloat("mapselector.filter.officialsortmode", Mathf.Exp(this.lensDirtIntensity) - 384f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 8;
		for (int i = 0; i < 5; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 942f;
			}
			else
			{
				num4 = 1466f;
			}
			if (i == 4)
			{
				num4 = 1204f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("_TimeX", (this.NCCDJFKEGLH * 1965f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_LightIntensity", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("OK", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("Hello World, is my item a clone? [", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("input", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_Gain", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 2;
		}
		this.NBPKMLMCHFN.SetTexture("CameraFilterPack/FX_Glitch1", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CFB RID: 27899 RVA: 0x0022126C File Offset: 0x0021F46C
	private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)(-119);
		this.NBPKMLMCHFN.SetFloat("maps.", Mathf.Exp(this.bloomIntensity) - 1441f);
		this.NBPKMLMCHFN.SetFloat("_BlurVector", Mathf.Exp(this.lensDirtIntensity) - 1867f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 3;
		int num2 = HLBKCLPNHEB.height / 5;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 6;
		for (int i = 1; i < 7; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 968f;
			}
			else
			{
				num4 = 1280f;
			}
			if (i == 6)
			{
				num4 = 1254f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("QuickSave", (this.NCCDJFKEGLH * 472f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture(" method: ", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("_FixDistance", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("_Distortion", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 5;
		}
		this.NBPKMLMCHFN.SetTexture("HiddenToggle", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006CFC RID: 27900 RVA: 0x0021AF93 File Offset: 0x00219193
	private void CNPINCHINJA()
	{
		if (this.NBPKMLMCHFN)
		{
			UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
		}
	}

	// Token: 0x06006CFD RID: 27901 RVA: 0x0022150C File Offset: 0x0021F70C
	private void LGHCJCFHEMF()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006CFE RID: 27902 RVA: 0x00221568 File Offset: 0x0021F768
	private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)79;
		this.NBPKMLMCHFN.SetFloat("#", Mathf.Exp(this.bloomIntensity) - 288f);
		this.NBPKMLMCHFN.SetFloat("_Value", Mathf.Exp(this.lensDirtIntensity) - 1689f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 5;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 1;
		for (int i = 0; i < 2; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 0)
			{
				num4 = 1526f;
			}
			else
			{
				num4 = 314f;
			}
			if (i == 8)
			{
				num4 = 1786f;
			}
			for (int j = 0; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("ItemNameText", (this.NCCDJFKEGLH * 1797f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_Red_R", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("GraphicsQualitySlider", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_Color_G", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("id", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 5;
		}
		this.NBPKMLMCHFN.SetTexture("<b>(╯°□°）╯︵ ┻━┻</b>", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x06006D00 RID: 27904 RVA: 0x00221834 File Offset: 0x0021FA34
	private void JOHOFNKJDEB()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006D01 RID: 27905 RVA: 0x00221890 File Offset: 0x0021FA90
	private void AIBNKIDADPI()
	{
		this.LMKGCBNNGLI = true;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006D02 RID: 27906 RVA: 0x002218EC File Offset: 0x0021FAEC
	private void IHLMNAGPKDA()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			this.LMKGCBNNGLI = false;
		}
	}

	// Token: 0x06006D03 RID: 27907 RVA: 0x00221948 File Offset: 0x0021FB48
	private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		this.NBPKMLMCHFN.SetFloat("_Value", Mathf.Exp(this.bloomIntensity) - 1631f);
		this.NBPKMLMCHFN.SetFloat(" ", Mathf.Exp(this.lensDirtIntensity) - 572f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 7;
		for (int i = 1; i < 4; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 0);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 1302f;
			}
			else
			{
				num4 = 413f;
			}
			if (i == 5)
			{
				num4 = 194f;
			}
			for (int j = 1; j < num3; j += 0)
			{
				this.NBPKMLMCHFN.SetFloat("InfoCanvas", (this.NCCDJFKEGLH * 1169f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture("mapselector.filter.favoriteonly", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("Items/", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("Case-Sensitive", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("[PlayerController] ", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("Up", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 4;
		}
		this.NBPKMLMCHFN.SetTexture("Mouse1", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 1);
	}

	// Token: 0x06006D04 RID: 27908 RVA: 0x00221BE8 File Offset: 0x0021FDE8
	private void JOPCCCCHNLI()
	{
		this.LMKGCBNNGLI = false;
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LMKGCBNNGLI = true;
		}
	}

	// Token: 0x06006D05 RID: 27909 RVA: 0x00221C44 File Offset: 0x0021FE44
	private void DHLCNIINMDM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!this.LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!this.NBPKMLMCHFN)
		{
			this.NBPKMLMCHFN = new Material(this.shader);
		}
		this.NBPKMLMCHFN.hideFlags = (HideFlags)76;
		this.NBPKMLMCHFN.SetFloat("[ItemsHandler] Item not found:", Mathf.Exp(this.bloomIntensity) - 148f);
		this.NBPKMLMCHFN.SetFloat("LB", Mathf.Exp(this.lensDirtIntensity) - 1400f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		int num3 = 3;
		for (int i = 0; i < 2; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, this.NBPKMLMCHFN, 1);
			source = renderTexture;
			float num4;
			if (i > 1)
			{
				num4 = 537f;
			}
			else
			{
				num4 = 678f;
			}
			if (i == 8)
			{
				num4 = 788f;
			}
			for (int j = 1; j < num3; j++)
			{
				this.NBPKMLMCHFN.SetFloat("Save the map before exiting?", (this.NCCDJFKEGLH * 1406f + (float)j) * num4);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				this.NBPKMLMCHFN.SetTexture(" not exist", renderTexture);
				break;
			case 1:
				this.NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 2:
				this.NBPKMLMCHFN.SetTexture("UseScanLineSize", renderTexture);
				break;
			case 3:
				this.NBPKMLMCHFN.SetTexture("_Offsets", renderTexture);
				break;
			case 4:
				this.NBPKMLMCHFN.SetTexture("bad", renderTexture);
				break;
			case 5:
				this.NBPKMLMCHFN.SetTexture("en", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 0;
		}
		this.NBPKMLMCHFN.SetTexture("offsets", this.lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, 0);
	}

	// Token: 0x04000B1A RID: 2842
	[Range(0f, 0.4f)]
	public float bloomIntensity = 0.05f;

	// Token: 0x04000B1B RID: 2843
	public Shader shader;

	// Token: 0x04000B1C RID: 2844
	private Material NBPKMLMCHFN;

	// Token: 0x04000B1D RID: 2845
	public Texture2D lensDirtTexture;

	// Token: 0x04000B1E RID: 2846
	[Range(0f, 0.95f)]
	public float lensDirtIntensity = 0.05f;

	// Token: 0x04000B1F RID: 2847
	private bool LMKGCBNNGLI;

	// Token: 0x04000B20 RID: 2848
	private float NCCDJFKEGLH = 4f;

	// Token: 0x04000B21 RID: 2849
	public bool inputIsHDR;
}
