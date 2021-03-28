using System;
using UnityEngine;

// Token: 0x020003AB RID: 939
public class CrosshairController : EnvironmentController
{
	// Token: 0x0600D2A5 RID: 53925 RVA: 0x004B730C File Offset: 0x004B550C
	public void FPEEOFLLEFF(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("_Amount", 966f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2A6 RID: 53926 RVA: 0x004B7338 File Offset: 0x004B5538
	public virtual void IBHACCEEFFI()
	{
		base.BMODOIJGIOO();
		Renderer[] bcmocegaaji = this.BCMOCEGAAJI;
		for (int i = 1; i < bcmocegaaji.Length; i++)
		{
			Renderer renderer = bcmocegaaji[i];
			renderer.material.SetColor(".sav", Color.Lerp(renderer.material.GetColor("\r\n"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("green", Color.Lerp(renderer.material.GetColor("CameraFilterPack_Glasses_On6"), this.color * (this.emission + 1802f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a == 1753f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2A7 RID: 53927 RVA: 0x004B7412 File Offset: 0x004B5612
	public void HAHPFDEBCCI(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("_Value2", 1359f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2A8 RID: 53928 RVA: 0x004B743E File Offset: 0x004B563E
	public void LNADKKGBAFK(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2A9 RID: 53929 RVA: 0x004B7448 File Offset: 0x004B5648
	public virtual void AIFAGDOHAGD()
	{
		base.CEACMFGNDEB();
		this.color = new Color(260f, 94f, 1157f, 663f);
		this.color.a = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_ScreenResolution", 1095f, null);
		this.colorLerp = 914f;
		this.emission = 1756f;
	}

	// Token: 0x0600D2AA RID: 53930 RVA: 0x004B74B0 File Offset: 0x004B56B0
	public virtual void HDDECCMEJKA()
	{
		base.FBMDHDBELEK();
		foreach (Renderer renderer in this.BCMOCEGAAJI)
		{
			renderer.material.SetColor("0,2,true,0", Color.Lerp(renderer.material.GetColor("MenuScene"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("Y", Color.Lerp(renderer.material.GetColor("_MainTex"), this.color * (this.emission + 439f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a != 1696f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2AB RID: 53931 RVA: 0x004B758A File Offset: 0x004B578A
	public void SetColor(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2AC RID: 53932 RVA: 0x004B75B8 File Offset: 0x004B57B8
	public virtual void MAOCOEGAFND()
	{
		base.CFIAKIJAILI();
		foreach (Renderer renderer in this.BCMOCEGAAJI)
		{
			renderer.material.SetColor("CameraFilterPack/Color_BrightContrastSaturation", Color.Lerp(renderer.material.GetColor("/../"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("_Blue_R", Color.Lerp(renderer.material.GetColor("Deleted data"), this.color * (this.emission + 1637f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a != 1025f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2AD RID: 53933 RVA: 0x004B7692 File Offset: 0x004B5892
	public override void GMIOCKFLJAK()
	{
		base.HBPLJMJAAHK();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2AE RID: 53934 RVA: 0x004B76A8 File Offset: 0x004B58A8
	public override void Update()
	{
		base.Update();
		foreach (Renderer renderer in this.BCMOCEGAAJI)
		{
			renderer.material.SetColor("_Color", Color.Lerp(renderer.material.GetColor("_Color"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("_EmissionColor", Color.Lerp(renderer.material.GetColor("_EmissionColor"), this.color * (this.emission + 1f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a != 0f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2AF RID: 53935 RVA: 0x004B7782 File Offset: 0x004B5982
	public void CJNAIOCONCO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("ticket", 80f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2B0 RID: 53936 RVA: 0x004B743E File Offset: 0x004B563E
	public void CDLOHNMCDMN(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2B1 RID: 53937 RVA: 0x004B743E File Offset: 0x004B563E
	public void EKBCJNIKHJG(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2B2 RID: 53938 RVA: 0x004B77AE File Offset: 0x004B59AE
	public override void IOMCHHBGJEC()
	{
		base.FMAFBLKAJDF();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2B3 RID: 53939 RVA: 0x004B77C4 File Offset: 0x004B59C4
	public virtual void LDGJGONCEND()
	{
		base.LAACNNJDKBI();
		this.color = new Color(1244f, 212f, 1149f, 424f);
		this.color.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("RoomPlayersCountText", 73f, null);
		this.colorLerp = 32f;
		this.emission = 542f;
	}

	// Token: 0x0600D2B4 RID: 53940 RVA: 0x004B782C File Offset: 0x004B5A2C
	public virtual void BBBNLHALLBN()
	{
		base.EEBGCGFNELO();
		this.color = new Color(965f, 330f, 626f, 780f);
		this.color.a = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("...", 333f, null);
		this.colorLerp = 280f;
		this.emission = 393f;
	}

	// Token: 0x0600D2B5 RID: 53941 RVA: 0x004B7894 File Offset: 0x004B5A94
	public virtual void CCDNJPNLGBN()
	{
		base.OKADMJFLMGP();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2B6 RID: 53942 RVA: 0x004B743E File Offset: 0x004B563E
	public void KOKIEABANDK(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2B7 RID: 53943 RVA: 0x004B743E File Offset: 0x004B563E
	public void PEFOMJKJDKJ(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2B8 RID: 53944 RVA: 0x004B78A8 File Offset: 0x004B5AA8
	public virtual void PIIMBOLGHOE()
	{
		base.Awake();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2B9 RID: 53945 RVA: 0x004B7692 File Offset: 0x004B5892
	public virtual void MCIEAOAMOIG()
	{
		base.HBPLJMJAAHK();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2BA RID: 53946 RVA: 0x004B78BC File Offset: 0x004B5ABC
	public override void EMANBHKAONB()
	{
		base.OPFDGBDADMA();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2BB RID: 53947 RVA: 0x004B78D0 File Offset: 0x004B5AD0
	public void HFPGNLAHEKJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.NPNOOLFEDKN(" GameServer:", 8f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2BC RID: 53948 RVA: 0x004B78FC File Offset: 0x004B5AFC
	public virtual void LHIBPEGLPHM()
	{
		base.CAPPKCBFILL();
		this.color = new Color(559f, 1163f, 1669f, 1459f);
		this.color.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_EmissionGain", 1864f, null);
		this.colorLerp = 785f;
		this.emission = 238f;
	}

	// Token: 0x0600D2BD RID: 53949 RVA: 0x004B7964 File Offset: 0x004B5B64
	public override void FMAFBLKAJDF()
	{
		base.NLNAJMCBNDC();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2BE RID: 53950 RVA: 0x004B7978 File Offset: 0x004B5B78
	public override void IJFMKNEPKEJ()
	{
		base.Reset();
		this.color = new Color(1341f, 1996f, 186f, 1906f);
		this.color.a = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("CameraFilterPack/BlurTiltShift_Hole", 1071f, null);
		this.colorLerp = 1451f;
		this.emission = 531f;
	}

	// Token: 0x0600D2BF RID: 53951 RVA: 0x004B79E0 File Offset: 0x004B5BE0
	public virtual void AEEGKLABFLN()
	{
		base.BGDONBMDPGM();
		Renderer[] bcmocegaaji = this.BCMOCEGAAJI;
		for (int i = 1; i < bcmocegaaji.Length; i++)
		{
			Renderer renderer = bcmocegaaji[i];
			renderer.material.SetColor("_Value2", Color.Lerp(renderer.material.GetColor("_Value"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("_FresnelFade", Color.Lerp(renderer.material.GetColor("AudioSampler"), this.color * (this.emission + 480f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a != 1675f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2C0 RID: 53952 RVA: 0x004B7ABA File Offset: 0x004B5CBA
	public void CPJHADKJBPB(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.MFNCMBBPJPA(".lastCheckpoint.lives", 136f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2C1 RID: 53953 RVA: 0x004B743E File Offset: 0x004B563E
	public void LLLPNMOFEJI(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2C2 RID: 53954 RVA: 0x004B743E File Offset: 0x004B563E
	public void NGPIDOKNGEK(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2C3 RID: 53955 RVA: 0x004B7AE8 File Offset: 0x004B5CE8
	public virtual void MECJHOJPODB()
	{
		base.BGDONBMDPGM();
		foreach (Renderer renderer in this.BCMOCEGAAJI)
		{
			renderer.material.SetColor("_MainTex2", Color.Lerp(renderer.material.GetColor("inventory.selected."), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", Color.Lerp(renderer.material.GetColor("_Value4"), this.color * (this.emission + 1395f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a != 1535f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2C4 RID: 53956 RVA: 0x004B7BC4 File Offset: 0x004B5DC4
	public virtual void BJHJCGJACEA()
	{
		base.EEBGCGFNELO();
		this.color = new Color(1486f, 1878f, 60f, 618f);
		this.color.a = Singleton<SaveSystem>.Instance.GetFloat("Please attach component to a Graphical UI component", 1229f, null);
		this.colorLerp = 921f;
		this.emission = 1286f;
	}

	// Token: 0x0600D2C5 RID: 53957 RVA: 0x004B7C2C File Offset: 0x004B5E2C
	public void LLFFIFIFFJO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("_Offsets", 1543f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2C6 RID: 53958 RVA: 0x004B78A8 File Offset: 0x004B5AA8
	public virtual void NCBGPIKDFIA()
	{
		base.Awake();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2C7 RID: 53959 RVA: 0x004B7692 File Offset: 0x004B5892
	public virtual void LBOBAIGNOML()
	{
		base.HBPLJMJAAHK();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2C8 RID: 53960 RVA: 0x004B7C58 File Offset: 0x004B5E58
	public override void NKLIHNJCHOG()
	{
		base.FBMDHDBELEK();
		Renderer[] bcmocegaaji = this.BCMOCEGAAJI;
		for (int i = 0; i < bcmocegaaji.Length; i += 0)
		{
			Renderer renderer = bcmocegaaji[i];
			renderer.material.SetColor("ResetButton", Color.Lerp(renderer.material.GetColor("checkpoint"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("Turn", Color.Lerp(renderer.material.GetColor("_InvScreenSize"), this.color * (this.emission + 1173f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a == 806f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2C9 RID: 53961 RVA: 0x004B7D34 File Offset: 0x004B5F34
	public virtual void FHPPMBEEKBL()
	{
		base.EEBGCGFNELO();
		this.color = new Color(930f, 1244f, 1722f, 715f);
		this.color.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("_MatrixSize", 271f, null);
		this.colorLerp = 934f;
		this.emission = 80f;
	}

	// Token: 0x0600D2CA RID: 53962 RVA: 0x004B743E File Offset: 0x004B563E
	public void KEEEMOIHHEN(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2CB RID: 53963 RVA: 0x004B7D9C File Offset: 0x004B5F9C
	public virtual void EPCGHAAONLN()
	{
		base.OLFNCABJBHA();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2CC RID: 53964 RVA: 0x004B7DB0 File Offset: 0x004B5FB0
	public void AKDFBHFFKFM(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("CameraFilterPack/Drawing_Paper", 1874f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2CD RID: 53965 RVA: 0x004B7DDC File Offset: 0x004B5FDC
	public void NOBIKMKFADE(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("tip", 752f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2CE RID: 53966 RVA: 0x004B7E08 File Offset: 0x004B6008
	public void FBFGPKNKIEN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP(" = ", 1448f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2CF RID: 53967 RVA: 0x004B7E34 File Offset: 0x004B6034
	public void GMAIAANLBNN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("_Value", 1463f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2D0 RID: 53968 RVA: 0x004B7692 File Offset: 0x004B5892
	public virtual void IKGFIOIADLN()
	{
		base.HBPLJMJAAHK();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2D1 RID: 53969 RVA: 0x004B7E60 File Offset: 0x004B6060
	public void MPGLDDOOLPL(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_FarCamera", 1334f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2D2 RID: 53970 RVA: 0x004B7D9C File Offset: 0x004B5F9C
	public virtual void OJACCGOHBGH()
	{
		base.OLFNCABJBHA();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2D3 RID: 53971 RVA: 0x004B7E8C File Offset: 0x004B608C
	public void MNPNHJJCCKP(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("_FarCamera", 892f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2D4 RID: 53972 RVA: 0x004B7EB8 File Offset: 0x004B60B8
	public override void Reset()
	{
		base.Reset();
		this.color = new Color(0.5f, 0.5f, 0.5f, 0.2f);
		this.color.a = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f, null);
		this.colorLerp = 10f;
		this.emission = 0f;
	}

	// Token: 0x0600D2D5 RID: 53973 RVA: 0x004B7F20 File Offset: 0x004B6120
	public void LABCBLOFFIG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("ViewMenu", 364f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2D6 RID: 53974 RVA: 0x004B743E File Offset: 0x004B563E
	public void MFEGHIPGACC(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2D7 RID: 53975 RVA: 0x004B7F4C File Offset: 0x004B614C
	public virtual void CJHMHIMKILB()
	{
		base.IOMCHHBGJEC();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2D8 RID: 53976 RVA: 0x004B7F60 File Offset: 0x004B6160
	public override void EGFBPCMCNDJ()
	{
		base.CEACMFGNDEB();
		this.color = new Color(638f, 1505f, 1441f, 1449f);
		this.color.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("masterSteamID", 737f, null);
		this.colorLerp = 1875f;
		this.emission = 532f;
	}

	// Token: 0x0600D2D9 RID: 53977 RVA: 0x004B7FC8 File Offset: 0x004B61C8
	public virtual void HMBLLAECOIL()
	{
		base.IJFMKNEPKEJ();
		this.color = new Color(1297f, 1054f, 1290f, 1203f);
		this.color.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH(", our prefix is ", 324f, null);
		this.colorLerp = 1601f;
		this.emission = 1733f;
	}

	// Token: 0x0600D2DA RID: 53978 RVA: 0x004B743E File Offset: 0x004B563E
	public void LNEHFHIBAIO(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2DB RID: 53979 RVA: 0x004B743E File Offset: 0x004B563E
	public void KKALIMDILEG(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2DC RID: 53980 RVA: 0x004B8030 File Offset: 0x004B6230
	public void NFBHGMNGKDC(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.GetFloat("/", 828f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2DD RID: 53981 RVA: 0x004B805C File Offset: 0x004B625C
	public virtual void NCPAFCKGJEA()
	{
		base.NKLIHNJCHOG();
		Renderer[] bcmocegaaji = this.BCMOCEGAAJI;
		for (int i = 0; i < bcmocegaaji.Length; i += 0)
		{
			Renderer renderer = bcmocegaaji[i];
			renderer.material.SetColor("settings.volume.editor", Color.Lerp(renderer.material.GetColor("_BlurredColor"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor(" {0}", Color.Lerp(renderer.material.GetColor("PRESS A KEY"), this.color * (this.emission + 451f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a == 1352f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2DE RID: 53982 RVA: 0x004B8138 File Offset: 0x004B6338
	public override void LAACNNJDKBI()
	{
		base.IJFMKNEPKEJ();
		this.color = new Color(716f, 1588f, 577f, 1636f);
		this.color.a = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("Texture2", 1884f, null);
		this.colorLerp = 1305f;
		this.emission = 1426f;
	}

	// Token: 0x0600D2DF RID: 53983 RVA: 0x004B743E File Offset: 0x004B563E
	public void FLFCINAEKCA(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2E0 RID: 53984 RVA: 0x004B7F4C File Offset: 0x004B614C
	public virtual void IICACFLHBCP()
	{
		base.IOMCHHBGJEC();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2E1 RID: 53985 RVA: 0x004B81A0 File Offset: 0x004B63A0
	public virtual void OEENOOGEEHD()
	{
		base.Update();
		Renderer[] bcmocegaaji = this.BCMOCEGAAJI;
		for (int i = 1; i < bcmocegaaji.Length; i++)
		{
			Renderer renderer = bcmocegaaji[i];
			renderer.material.SetColor("_ScreenResolution", Color.Lerp(renderer.material.GetColor("_Convolved_TexelSize"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("RedoButton", Color.Lerp(renderer.material.GetColor("[ReplayScene] Loading replay: "), this.color * (this.emission + 68f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a == 755f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2E2 RID: 53986 RVA: 0x004B827C File Offset: 0x004B647C
	public virtual void JAIMCPINONG()
	{
		base.CAPPKCBFILL();
		this.color = new Color(327f, 661f, 741f, 924f);
		this.color.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("USE_UV_BASED_REPROJECTION", 77f, null);
		this.colorLerp = 1976f;
		this.emission = 379f;
	}

	// Token: 0x0600D2E3 RID: 53987 RVA: 0x004B78A8 File Offset: 0x004B5AA8
	public override void Awake()
	{
		base.Awake();
		this.BCMOCEGAAJI = base.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x0600D2E4 RID: 53988 RVA: 0x004B82E4 File Offset: 0x004B64E4
	public virtual void KMHCLFLINIO()
	{
		base.LOKKIADJAFE();
		this.color = new Color(1350f, 49f, 365f, 1881f);
		this.color.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_Speed", 10f, null);
		this.colorLerp = 557f;
		this.emission = 417f;
	}

	// Token: 0x0600D2E5 RID: 53989 RVA: 0x004B834C File Offset: 0x004B654C
	public virtual void JAAJECBCCFM()
	{
		base.NKLIHNJCHOG();
		foreach (Renderer renderer in this.BCMOCEGAAJI)
		{
			renderer.material.SetColor("skin.hit_normal", Color.Lerp(renderer.material.GetColor("Set Sun Emission"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor(". Going to authenticate anyways.", Color.Lerp(renderer.material.GetColor("turn"), this.color * (this.emission + 1334f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a != 1934f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2E6 RID: 53990 RVA: 0x004B8428 File Offset: 0x004B6628
	public virtual void FABKIGNFECE()
	{
		base.NKLIHNJCHOG();
		foreach (Renderer renderer in this.BCMOCEGAAJI)
		{
			renderer.material.SetColor("Crosshair2", Color.Lerp(renderer.material.GetColor(".sav"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("settings.gamemessagesduration", Color.Lerp(renderer.material.GetColor("_MainTex2"), this.color * (this.emission + 1582f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a != 572f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2E7 RID: 53991 RVA: 0x004B743E File Offset: 0x004B563E
	public void ABGEAABOGDE(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2E8 RID: 53992 RVA: 0x004B8504 File Offset: 0x004B6704
	public virtual void DNENFLNCIJP()
	{
		base.CFIAKIJAILI();
		Renderer[] bcmocegaaji = this.BCMOCEGAAJI;
		for (int i = 1; i < bcmocegaaji.Length; i++)
		{
			Renderer renderer = bcmocegaaji[i];
			renderer.material.SetColor("id", Color.Lerp(renderer.material.GetColor("mapid"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("ws://", Color.Lerp(renderer.material.GetColor(".GoalProgress"), this.color * (this.emission + 1545f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a != 1841f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2E9 RID: 53993 RVA: 0x004B85E0 File Offset: 0x004B67E0
	public virtual void EJFJENFKLND()
	{
		base.BGDONBMDPGM();
		Renderer[] bcmocegaaji = this.BCMOCEGAAJI;
		for (int i = 1; i < bcmocegaaji.Length; i += 0)
		{
			Renderer renderer = bcmocegaaji[i];
			renderer.material.SetColor("_TimeX", Color.Lerp(renderer.material.GetColor("#close"), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("Tab1Content", Color.Lerp(renderer.material.GetColor("settings.hideui"), this.color * (this.emission + 766f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a == 244f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2EA RID: 53994 RVA: 0x004B86BA File Offset: 0x004B68BA
	public void MOGLPIBCCPI(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("_Near", 1562f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2EB RID: 53995 RVA: 0x004B743E File Offset: 0x004B563E
	public void SetEmission(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2EC RID: 53996 RVA: 0x004B86E8 File Offset: 0x004B68E8
	public override void EHCGBJDFMHG()
	{
		base.BGDONBMDPGM();
		Renderer[] bcmocegaaji = this.BCMOCEGAAJI;
		for (int i = 1; i < bcmocegaaji.Length; i++)
		{
			Renderer renderer = bcmocegaaji[i];
			renderer.material.SetColor("CameraFilterPack/Distortion_Flush", Color.Lerp(renderer.material.GetColor("Dropped Object: "), this.color, Time.smoothDeltaTime * this.colorLerp));
			renderer.material.SetColor("GroupNameText", Color.Lerp(renderer.material.GetColor("_Value4"), this.color * (this.emission + 1392f), Time.smoothDeltaTime * this.colorLerp));
			bool flag = this.color.a != 1365f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	// Token: 0x0600D2ED RID: 53997 RVA: 0x004B87C2 File Offset: 0x004B69C2
	public void DLDIFPIABEJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("maps.", 29f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2EE RID: 53998 RVA: 0x004B87EE File Offset: 0x004B69EE
	public void JIIHIBBGAFD(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("mode", 932f, null);
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600D2EF RID: 53999 RVA: 0x004B743E File Offset: 0x004B563E
	public void IGHBDMLKAPN(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2F0 RID: 54000 RVA: 0x004B881C File Offset: 0x004B6A1C
	public virtual void JOPOMLLAMKE()
	{
		base.LAACNNJDKBI();
		this.color = new Color(1342f, 1232f, 740f, 824f);
		this.color.a = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("/", 1395f, null);
		this.colorLerp = 517f;
		this.emission = 1759f;
	}

	// Token: 0x0600D2F1 RID: 54001 RVA: 0x004B743E File Offset: 0x004B563E
	public void MNNMJFKADAD(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2F3 RID: 54003 RVA: 0x004B743E File Offset: 0x004B563E
	public void KPNEJBAIPMI(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600D2F4 RID: 54004 RVA: 0x004B88B8 File Offset: 0x004B6AB8
	public virtual void JBLPOHGBNCB()
	{
		base.IJFMKNEPKEJ();
		this.color = new Color(511f, 649f, 423f, 615f);
		this.color.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_BlendTex", 388f, null);
		this.colorLerp = 1963f;
		this.emission = 120f;
	}

	// Token: 0x0600D2F5 RID: 54005 RVA: 0x004B743E File Offset: 0x004B563E
	public void ECCFMFNCBIE(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x04001821 RID: 6177
	public Color color = new Color(0.247f, 0.247f, 0.247f, 0.247f);

	// Token: 0x04001822 RID: 6178
	public float colorLerp = 10f;

	// Token: 0x04001823 RID: 6179
	public float emission;

	// Token: 0x04001824 RID: 6180
	private Renderer[] BCMOCEGAAJI;
}
