using System;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x0200030F RID: 783
public class PhotonLagSimulationGui : MonoBehaviour
{
	// Token: 0x0600B2C4 RID: 45764 RVA: 0x0041869C File Offset: 0x0041689C
	public void FDNONDCGGCG()
	{
		this.HBBPFLDICHB(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B2C5 RID: 45765 RVA: 0x004186AC File Offset: 0x004168AC
	public void PDKFMFCMPGE()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.HDAOIDAMNJO() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.IPNKKHBLGLD), "_Value4", new GUILayoutOption[1]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.JACBDFDCLFC), "LevelInfoInputField", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B2C6 RID: 45766 RVA: 0x00418734 File Offset: 0x00416934
	public void OnGUI()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.Peer == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.CKHOOGMFDMD), "Netw. Sim.", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.PONJJDMBJHI), "Netw. Sim.", new GUILayoutOption[0]);
		}
	}

	// Token: 0x0600B2C7 RID: 45767 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer DLNPKPBLFOM()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B2C8 RID: 45768 RVA: 0x004187C1 File Offset: 0x004169C1
	private void GELJPJKIIAF(int ENDMCOMANKJ)
	{
		GUILayout.Label("%", new GUILayoutOption[1]);
	}

	// Token: 0x0600B2C9 RID: 45769 RVA: 0x004187D3 File Offset: 0x004169D3
	public void KHNALNPPGNC(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2CA RID: 45770 RVA: 0x004187D3 File Offset: 0x004169D3
	public void KDEMAJFLMEB(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2CB RID: 45771 RVA: 0x004187D3 File Offset: 0x004169D3
	public void MPHKBLFLGID(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2CC RID: 45772 RVA: 0x004187DC File Offset: 0x004169DC
	public void IEHKJPADFFM()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.NMIOPAHIFGH() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.ANAOLAFEDON), "_LowRez", new GUILayoutOption[1]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.IAALADGFAJC), "HightScoreMaxPointsText", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B2CD RID: 45773 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer GENJEBLGKEF()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B2CE RID: 45774 RVA: 0x004187D3 File Offset: 0x004169D3
	public void EHHABKDKECJ(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2CF RID: 45775 RVA: 0x00418861 File Offset: 0x00416A61
	private void ILGBINPBIBG(int ENDMCOMANKJ)
	{
		GUILayout.Label("Exception while connecting to: ", new GUILayoutOption[1]);
	}

	// Token: 0x0600B2D0 RID: 45776 RVA: 0x004187D3 File Offset: 0x004169D3
	public void PJCPDOBOLPE(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2D1 RID: 45777 RVA: 0x00418874 File Offset: 0x00416A74
	private void EKECEMMEIDL(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("ItemNameText", this.NPBLKIPOKMF().RoundTripTime, this.Peer.RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.HDNDGHCJEGJ().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Intensity", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.NMIOPAHIFGH().IsSimulationEnabled = flag;
		}
		float num = (float)this.HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_TimeX" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 1554f, 1183f, new GUILayoutOption[0]);
		this.BCIJDDBHDLP().NetworkSimulationSettings.IncomingLag = (int)num;
		this.BCIJDDBHDLP().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.NMIOPAHIFGH().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("Data/Skins/" + num2, new GUILayoutOption[0]);
		num2 = GUILayout.HorizontalSlider(num2, 985f, 194f, new GUILayoutOption[0]);
		this.IJCHMGDEGCK().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.MKGMMLABLFD().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.AIMLGHOJNEG().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("Operation " + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 865f, 1614f, new GUILayoutOption[0]);
		this.BOBONFBENHG().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.MDIEKLDMNDJ().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1813f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B2D2 RID: 45778 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer IJCHMGDEGCK()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B2D3 RID: 45779 RVA: 0x00418A44 File Offset: 0x00416C44
	private void IPNKKHBLGLD(int ENDMCOMANKJ)
	{
		GUILayout.Label("_Offsets", new GUILayoutOption[1]);
	}

	// Token: 0x0600B2D4 RID: 45780 RVA: 0x00418A58 File Offset: 0x00416C58
	private void DIBCOOGCKDC(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("offsets", this.PBNJOGMIBDL().RoundTripTime, this.NPBLKIPOKMF().RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.Peer.IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "ConfigVersionSlider", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.GGJGMLLHLKP().IsSimulationEnabled = flag;
		}
		float num = (float)this.LOJMNGHPOOM().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_FarCamera" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 1287f, 1653f, new GUILayoutOption[0]);
		this.GENJEBLGKEF().NetworkSimulationSettings.IncomingLag = (int)num;
		this.ODMKOICGKGD().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.IJCHMGDEGCK().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("<b>" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1062f, 138f, new GUILayoutOption[1]);
		this.LOJMNGHPOOM().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.PBNJOGMIBDL().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.MDIEKLDMNDJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("GlassAberration" + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 1952f, 1817f, new GUILayoutOption[1]);
		this.LOJMNGHPOOM().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.NPBLKIPOKMF().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1449f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B2D5 RID: 45781 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer PBNJOGMIBDL()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B2D6 RID: 45782 RVA: 0x00418C28 File Offset: 0x00416E28
	private void DMPJMALHHGC(int ENDMCOMANKJ)
	{
		GUILayout.Label("_Value2", new GUILayoutOption[0]);
	}

	// Token: 0x0600B2D7 RID: 45783 RVA: 0x004187D3 File Offset: 0x004169D3
	public void OIPINPCNKIE(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2D8 RID: 45784 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer ALEBHIOJOMO()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B2D9 RID: 45785 RVA: 0x00418C3C File Offset: 0x00416E3C
	private void LPLGLCLMFFL(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("/", this.GENJEBLGKEF().RoundTripTime, this.FABGKNDAMPK().RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.DLNPKPBLFOM().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "OpSettings()", new GUILayoutOption[0]);
		if (flag != isSimulationEnabled)
		{
			this.IJCHMGDEGCK().IsSimulationEnabled = flag;
		}
		float num = (float)this.ALEBHIOJOMO().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("(\\[ */ *b *\\])" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 199f, 519f, new GUILayoutOption[1]);
		this.PBNJOGMIBDL().NetworkSimulationSettings.IncomingLag = (int)num;
		this.BOBONFBENHG().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.HDAOIDAMNJO().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("," + num2, new GUILayoutOption[0]);
		num2 = GUILayout.HorizontalSlider(num2, 1855f, 1703f, new GUILayoutOption[0]);
		this.NNOPMLIPGGI().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.ALEBHIOJOMO().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_ScreenResolution" + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 1500f, 297f, new GUILayoutOption[0]);
		this.IJCHMGDEGCK().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.NNOPMLIPGGI().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 866f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B2DA RID: 45786 RVA: 0x00418E0C File Offset: 0x0041700C
	public void FFBECHMKMPK()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.LOJMNGHPOOM() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.ALMHGGJAPKN), "tagElement", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.ICNPOLOPHHL), "Object ID. Case-Sensitive", new GUILayoutOption[0]);
		}
	}

	// Token: 0x0600B2DB RID: 45787 RVA: 0x00418E94 File Offset: 0x00417094
	public void GGJKHODKNOC()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.PBNJOGMIBDL() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.IPNKKHBLGLD), "_Value", new GUILayoutOption[1]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.JACBDFDCLFC), "Joystick1Button4", new GUILayoutOption[0]);
		}
	}

	// Token: 0x0600B2DC RID: 45788 RVA: 0x00418F1C File Offset: 0x0041711C
	private void EHIODMNFFEH(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("Reset All", this.OBLGFLGCCFP().RoundTripTime, this.Peer.RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = this.MDIEKLDMNDJ().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Visualize", new GUILayoutOption[0]);
		if (flag != isSimulationEnabled)
		{
			this.BOBONFBENHG().IsSimulationEnabled = flag;
		}
		float num = (float)this.BCIJDDBHDLP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label(".lastCheckpoint.incorrectScore" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 620f, 1308f, new GUILayoutOption[1]);
		this.GENJEBLGKEF().NetworkSimulationSettings.IncomingLag = (int)num;
		this.NMIOPAHIFGH().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.IJCHMGDEGCK().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("ok" + num2, new GUILayoutOption[0]);
		num2 = GUILayout.HorizontalSlider(num2, 589f, 1456f, new GUILayoutOption[0]);
		this.LOJMNGHPOOM().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.FABGKNDAMPK().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.IJCHMGDEGCK().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label(").png" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 101f, 1216f, new GUILayoutOption[0]);
		this.NNOPMLIPGGI().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.IJCHMGDEGCK().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1008f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B2DD RID: 45789 RVA: 0x004190EC File Offset: 0x004172EC
	public void GIMFEMMLANB()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.NPBLKIPOKMF() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.GELJPJKIIAF), "_UV_Transform", new GUILayoutOption[1]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.BFFCJEDADJG), "_MaxBlurRadius", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B2DE RID: 45790 RVA: 0x00419174 File Offset: 0x00417374
	public void JABMMIMOJMJ()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.HDAOIDAMNJO() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.HMMBOEGODIP), "_ScreenResolution", new GUILayoutOption[1]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.DIBCOOGCKDC), "settings.arcshitsoundtimedelay", new GUILayoutOption[0]);
		}
	}

	// Token: 0x0600B2DF RID: 45791 RVA: 0x004191FC File Offset: 0x004173FC
	public void CDLHBDMJAJI()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.LOJMNGHPOOM() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.CBKCFPBJDEL), "&page=", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.IAALADGFAJC), "_Size", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B2E0 RID: 45792 RVA: 0x00419281 File Offset: 0x00417481
	public void BEBNOKFLJPH()
	{
		this.ELFGOKFMMHC(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B2E1 RID: 45793 RVA: 0x00419290 File Offset: 0x00417490
	private void PONJJDMBJHI(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("Rtt:{0,4} +/-{1,3}", this.Peer.RoundTripTime, this.Peer.RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.Peer.IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Simulate", new GUILayoutOption[0]);
		if (flag != isSimulationEnabled)
		{
			this.Peer.IsSimulationEnabled = flag;
		}
		float num = (float)this.Peer.NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("Lag " + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 0f, 500f, new GUILayoutOption[0]);
		this.Peer.NetworkSimulationSettings.IncomingLag = (int)num;
		this.Peer.NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.Peer.NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("Jit " + num2, new GUILayoutOption[0]);
		num2 = GUILayout.HorizontalSlider(num2, 0f, 100f, new GUILayoutOption[0]);
		this.Peer.NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.Peer.NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.Peer.NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("Loss " + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 0f, 10f, new GUILayoutOption[0]);
		this.Peer.NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.Peer.NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 100f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B2E2 RID: 45794 RVA: 0x00419460 File Offset: 0x00417660
	private void MPOICLNJGJO(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_Near", this.DLNPKPBLFOM().RoundTripTime, this.MKGMMLABLFD().RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.LHELEHPOIDN().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "DifficultyBG", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.ALEBHIOJOMO().IsSimulationEnabled = flag;
		}
		float num = (float)this.BOBONFBENHG().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("#ok" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 368f, 1300f, new GUILayoutOption[0]);
		this.PNJIPPOIOEP().NetworkSimulationSettings.IncomingLag = (int)num;
		this.BOBONFBENHG().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.HDAOIDAMNJO().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("LeaderboardsButton" + num2, new GUILayoutOption[0]);
		num2 = GUILayout.HorizontalSlider(num2, 1671f, 61f, new GUILayoutOption[0]);
		this.ODMKOICGKGD().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.AIMLGHOJNEG().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.MDIEKLDMNDJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("float,1.5" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 488f, 38f, new GUILayoutOption[1]);
		this.HDAOIDAMNJO().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.PNJIPPOIOEP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1059f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B2E3 RID: 45795 RVA: 0x00419630 File Offset: 0x00417830
	private void PGLDHAIEJGK(int ENDMCOMANKJ)
	{
		GUILayout.Label("EventSystem", new GUILayoutOption[1]);
	}

	// Token: 0x0600B2E4 RID: 45796 RVA: 0x00419642 File Offset: 0x00417842
	public void DPLLKHHLDBB()
	{
		this.PJCPDOBOLPE(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B2E5 RID: 45797 RVA: 0x00419650 File Offset: 0x00417850
	private void IAALADGFAJC(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_ScreenResolution", this.PBNJOGMIBDL().RoundTripTime, this.PNJIPPOIOEP().RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.BOBONFBENHG().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Set satellite radius (offset)", new GUILayoutOption[0]);
		if (flag != isSimulationEnabled)
		{
			this.MDIEKLDMNDJ().IsSimulationEnabled = flag;
		}
		float num = (float)this.GENJEBLGKEF().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("SupportLogger " + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 1012f, 10f, new GUILayoutOption[1]);
		this.FABGKNDAMPK().NetworkSimulationSettings.IncomingLag = (int)num;
		this.AIMLGHOJNEG().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.FBOALIJENCM().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("Sets the boolean value of the Auto Focus Input Field property." + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1101f, 676f, new GUILayoutOption[1]);
		this.NNOPMLIPGGI().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.MDIEKLDMNDJ().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.ODMKOICGKGD().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_ScreenResolution" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 723f, 1466f, new GUILayoutOption[1]);
		this.PBNJOGMIBDL().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.DLNPKPBLFOM().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 524f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B2E6 RID: 45798 RVA: 0x00419820 File Offset: 0x00417A20
	private void ICNPOLOPHHL(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_Far", this.BCIJDDBHDLP().RoundTripTime, this.Peer.RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = this.DLNPKPBLFOM().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Curve", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.NPBLKIPOKMF().IsSimulationEnabled = flag;
		}
		float num = (float)this.BOBONFBENHG().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("float,1.5" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 1057f, 139f, new GUILayoutOption[0]);
		this.NPBLKIPOKMF().NetworkSimulationSettings.IncomingLag = (int)num;
		this.OBLGFLGCCFP().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.PBNJOGMIBDL().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("NO" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1650f, 655f, new GUILayoutOption[0]);
		this.HDNDGHCJEGJ().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.ALEBHIOJOMO().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.GGJGMLLHLKP().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("CameraFilterPack/AAA_Super_Hexagon" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 538f, 1917f, new GUILayoutOption[1]);
		this.ODMKOICGKGD().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.GGJGMLLHLKP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 583f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B2E7 RID: 45799 RVA: 0x004187D3 File Offset: 0x004169D3
	public void MOECMBJKKDD(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2E8 RID: 45800 RVA: 0x004199F0 File Offset: 0x00417BF0
	private void HDFOAJAFMDK(int ENDMCOMANKJ)
	{
		GUILayout.Label(".played", new GUILayoutOption[1]);
	}

	// Token: 0x0600B2E9 RID: 45801 RVA: 0x004187D3 File Offset: 0x004169D3
	public void HBBPFLDICHB(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2EA RID: 45802 RVA: 0x00419A02 File Offset: 0x00417C02
	public void AGEJKLMJGDO()
	{
		this.AFMPNJBFLGN(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B2EB RID: 45803 RVA: 0x004187D3 File Offset: 0x004169D3
	public void AFNCJLOGLBB(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2EC RID: 45804 RVA: 0x00419A0F File Offset: 0x00417C0F
	private void CKHOOGMFDMD(int ENDMCOMANKJ)
	{
		GUILayout.Label("No peer to communicate with. ", new GUILayoutOption[0]);
	}

	// Token: 0x0600B2ED RID: 45805 RVA: 0x004187D3 File Offset: 0x004169D3
	public void AFMPNJBFLGN(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2EE RID: 45806 RVA: 0x00419A21 File Offset: 0x00417C21
	public void JILOMOBDPIA()
	{
		this.FDOCLMLMBFI(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B2EF RID: 45807 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer NPBLKIPOKMF()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B2F0 RID: 45808 RVA: 0x00419A2E File Offset: 0x00417C2E
	private void MALIOOJFHPG(int ENDMCOMANKJ)
	{
		GUILayout.Label("_EmissionGain", new GUILayoutOption[0]);
	}

	// Token: 0x0600B2F1 RID: 45809 RVA: 0x00419A40 File Offset: 0x00417C40
	public void KGNKDPBGJHC()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.GENJEBLGKEF() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.DKNKGNEHMMB), "LevelEditor/patterns", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.NNJJDHIOMIA), "shader.future", new GUILayoutOption[0]);
		}
	}

	// Token: 0x0600B2F2 RID: 45810 RVA: 0x004187D3 File Offset: 0x004169D3
	public void MBCHBLHDNBB(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2F3 RID: 45811 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer BOBONFBENHG()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B2F4 RID: 45812 RVA: 0x00419AC5 File Offset: 0x00417CC5
	public void IGPCNCJIEOJ()
	{
		this.NFCBEFDNDBG(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B2F5 RID: 45813 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer HDAOIDAMNJO()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B2F6 RID: 45814 RVA: 0x004187D3 File Offset: 0x004169D3
	public void LKFMMEBLCMK(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2F7 RID: 45815 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer MKGMMLABLFD()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x0600B302 RID: 45826 RVA: 0x004187B9 File Offset: 0x004169B9
	// (set) Token: 0x0600B2F8 RID: 45816 RVA: 0x004187D3 File Offset: 0x004169D3
	public PhotonPeer Peer { get; set; }

	// Token: 0x0600B2F9 RID: 45817 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer AIMLGHOJNEG()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B2FA RID: 45818 RVA: 0x00419AD4 File Offset: 0x00417CD4
	public void OGAIIBPLJBB()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.MDIEKLDMNDJ() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.PGLDHAIEJGK), "[Right]", new GUILayoutOption[1]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.DIBCOOGCKDC), "[MapsData] Bad map: ", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B2FB RID: 45819 RVA: 0x00419B5C File Offset: 0x00417D5C
	public void PCABPJAANFH()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.OBLGFLGCCFP() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.OBJPCCJPACN), "_Value2", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.PONJJDMBJHI), "X", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B2FC RID: 45820 RVA: 0x00419BE1 File Offset: 0x00417DE1
	public void DLBODOFAJGM()
	{
		this.EEGCKCPJPPH(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B2FD RID: 45821 RVA: 0x00419BF0 File Offset: 0x00417DF0
	public void OGBJNAAAEGI()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.ODMKOICGKGD() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.IPNKKHBLGLD), "id", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.EHIODMNFFEH), "CameraFilterPack/FX_InverChromiLum", new GUILayoutOption[0]);
		}
	}

	// Token: 0x0600B2FE RID: 45822 RVA: 0x004187D3 File Offset: 0x004169D3
	public void DAKLEHINMLD(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B2FF RID: 45823 RVA: 0x00419C75 File Offset: 0x00417E75
	public void CFFCLAHMBAA()
	{
		this.EGOIGBGDOGB(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B300 RID: 45824 RVA: 0x00419A02 File Offset: 0x00417C02
	public void KLILJHJNICK()
	{
		this.AFMPNJBFLGN(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B301 RID: 45825 RVA: 0x00419C82 File Offset: 0x00417E82
	private void HDEFDLBOLFF(int ENDMCOMANKJ)
	{
		GUILayout.Label("mapselector.filter.favoriteonly", new GUILayoutOption[1]);
	}

	// Token: 0x0600B303 RID: 45827 RVA: 0x00419C94 File Offset: 0x00417E94
	private void PLICDMBDNPI(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_InvViewProj", this.MDIEKLDMNDJ().RoundTripTime, this.NMIOPAHIFGH().RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.Peer.IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Value3", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.OBLGFLGCCFP().IsSimulationEnabled = flag;
		}
		float num = (float)this.BOBONFBENHG().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("mapselector.filter.rateduponly" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 965f, 15f, new GUILayoutOption[0]);
		this.ODMKOICGKGD().NetworkSimulationSettings.IncomingLag = (int)num;
		this.PBNJOGMIBDL().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.GENJEBLGKEF().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("Back" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1287f, 1082f, new GUILayoutOption[0]);
		this.IJCHMGDEGCK().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.Peer.NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.PBNJOGMIBDL().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("SpawnObj" + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 837f, 915f, new GUILayoutOption[1]);
		this.NMIOPAHIFGH().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.MDIEKLDMNDJ().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 640f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B304 RID: 45828 RVA: 0x00419E64 File Offset: 0x00418064
	private void CNOFJKHEELP(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("UI Extensions/UIMultiply", this.GGJGMLLHLKP().RoundTripTime, this.MKGMMLABLFD().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = this.NPBLKIPOKMF().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Crosshair1", new GUILayoutOption[0]);
		if (flag != isSimulationEnabled)
		{
			this.GENJEBLGKEF().IsSimulationEnabled = flag;
		}
		float num = (float)this.BOBONFBENHG().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("LevelInfoInputField" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 1253f, 677f, new GUILayoutOption[0]);
		this.HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLag = (int)num;
		this.Peer.NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.AIMLGHOJNEG().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label(". Calling ConnectToRegionMaster() is: " + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1570f, 1937f, new GUILayoutOption[0]);
		this.GENJEBLGKEF().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.GGJGMLLHLKP().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.BCIJDDBHDLP().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("Load scene by name or build id" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1351f, 1584f, new GUILayoutOption[0]);
		this.GGJGMLLHLKP().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.LHELEHPOIDN().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1495f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B305 RID: 45829 RVA: 0x0041A034 File Offset: 0x00418234
	public void AFOKJPBHIEG()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.HDNDGHCJEGJ() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.CBKCFPBJDEL), "_NoiseScale", new GUILayoutOption[1]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.MPOICLNJGJO), "true", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B306 RID: 45830 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer PNJIPPOIOEP()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B307 RID: 45831 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer ODMKOICGKGD()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B308 RID: 45832 RVA: 0x0041A0B9 File Offset: 0x004182B9
	private void PGKMEFFAFJE(int ENDMCOMANKJ)
	{
		GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
	}

	// Token: 0x0600B309 RID: 45833 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer LOJMNGHPOOM()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B30A RID: 45834 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer HDNDGHCJEGJ()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B30B RID: 45835 RVA: 0x0041A0CB File Offset: 0x004182CB
	private void ALMHGGJAPKN(int ENDMCOMANKJ)
	{
		GUILayout.Label("_Bullet_7", new GUILayoutOption[0]);
	}

	// Token: 0x0600B30C RID: 45836 RVA: 0x0041A0E0 File Offset: 0x004182E0
	public void JDJNNDBHBNP()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.HDAOIDAMNJO() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.BBOAGLIEBEI), "Joystick1Button10", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.JACBDFDCLFC), "<command>", new GUILayoutOption[0]);
		}
	}

	// Token: 0x0600B30D RID: 45837 RVA: 0x0041A165 File Offset: 0x00418365
	private void OBJPCCJPACN(int ENDMCOMANKJ)
	{
		GUILayout.Label("HIDE CONFIG [Ctrl+E]", new GUILayoutOption[0]);
	}

	// Token: 0x0600B30E RID: 45838 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer OBLGFLGCCFP()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B30F RID: 45839 RVA: 0x00419A21 File Offset: 0x00417C21
	public void ECBILENEOOL()
	{
		this.FDOCLMLMBFI(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B310 RID: 45840 RVA: 0x004187D3 File Offset: 0x004169D3
	public void EGOIGBGDOGB(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B311 RID: 45841 RVA: 0x0041A178 File Offset: 0x00418378
	private void JACBDFDCLFC(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("Screen Space Reflections", this.ALEBHIOJOMO().RoundTripTime, this.ALEBHIOJOMO().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = this.OBLGFLGCCFP().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "QuickSave", new GUILayoutOption[0]);
		if (flag != isSimulationEnabled)
		{
			this.NMIOPAHIFGH().IsSimulationEnabled = flag;
		}
		float num = (float)this.ALEBHIOJOMO().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("HPText" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 569f, 1101f, new GUILayoutOption[1]);
		this.MKGMMLABLFD().NetworkSimulationSettings.IncomingLag = (int)num;
		this.IJCHMGDEGCK().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.HDAOIDAMNJO().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("x" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1271f, 1705f, new GUILayoutOption[0]);
		this.LHELEHPOIDN().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.MDIEKLDMNDJ().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_Value2" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1674f, 1181f, new GUILayoutOption[0]);
		this.HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.HDAOIDAMNJO().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1585f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B313 RID: 45843 RVA: 0x0041A37E File Offset: 0x0041857E
	public void FHGKIOOMMOH()
	{
		this.AFNCJLOGLBB(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B314 RID: 45844 RVA: 0x0041A38B File Offset: 0x0041858B
	private void HMMBOEGODIP(int ENDMCOMANKJ)
	{
		GUILayout.Label("Jump", new GUILayoutOption[0]);
	}

	// Token: 0x0600B315 RID: 45845 RVA: 0x0041A39D File Offset: 0x0041859D
	private void BBOAGLIEBEI(int ENDMCOMANKJ)
	{
		GUILayout.Label("finished", new GUILayoutOption[0]);
	}

	// Token: 0x0600B316 RID: 45846 RVA: 0x0041A3B0 File Offset: 0x004185B0
	public void FGGKEOLKCNH()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.MDIEKLDMNDJ() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.CKHOOGMFDMD), " has ", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.MPOICLNJGJO), "seconds", new GUILayoutOption[0]);
		}
	}

	// Token: 0x0600B317 RID: 45847 RVA: 0x0041A438 File Offset: 0x00418638
	private void BOKMOLOLOAN(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("#submit", this.NMIOPAHIFGH().RoundTripTime, this.OBLGFLGCCFP().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = this.NNOPMLIPGGI().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "CheckpointsScoreText", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.GENJEBLGKEF().IsSimulationEnabled = flag;
		}
		float num = (float)this.OBLGFLGCCFP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("CameraFilterPack/Light_Rainbow2" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 119f, 1685f, new GUILayoutOption[1]);
		this.HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLag = (int)num;
		this.FBOALIJENCM().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.IJCHMGDEGCK().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label(").png" + num2, new GUILayoutOption[0]);
		num2 = GUILayout.HorizontalSlider(num2, 210f, 1475f, new GUILayoutOption[0]);
		this.Peer.NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.HDAOIDAMNJO().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.GGJGMLLHLKP().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_Value" + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 1401f, 1572f, new GUILayoutOption[1]);
		this.BCIJDDBHDLP().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.DLNPKPBLFOM().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 403f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B318 RID: 45848 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer BCIJDDBHDLP()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B319 RID: 45849 RVA: 0x004187D3 File Offset: 0x004169D3
	public void AKEAKKPPNPF(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B31A RID: 45850 RVA: 0x0041A37E File Offset: 0x0041857E
	public void BMOFEBKGLFI()
	{
		this.AFNCJLOGLBB(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B31B RID: 45851 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer NNOPMLIPGGI()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B31C RID: 45852 RVA: 0x0041A608 File Offset: 0x00418808
	private void BLJBEBLDEKB(int ENDMCOMANKJ)
	{
		GUILayout.Label("achievements.21.progress", new GUILayoutOption[1]);
	}

	// Token: 0x0600B31D RID: 45853 RVA: 0x00419BE1 File Offset: 0x00417DE1
	public void MMPHNFPPEHO()
	{
		this.EEGCKCPJPPH(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B31E RID: 45854 RVA: 0x0041A61C File Offset: 0x0041881C
	public void DDFOMFBPFFB()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.Peer == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.PGLDHAIEJGK), "_Value", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.BFFCJEDADJG), "_TimeX", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B31F RID: 45855 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer GGJGMLLHLKP()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B320 RID: 45856 RVA: 0x0041869C File Offset: 0x0041689C
	public void JONGNKNLLND()
	{
		this.HBBPFLDICHB(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B321 RID: 45857 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer FABGKNDAMPK()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B322 RID: 45858 RVA: 0x004187D3 File Offset: 0x004169D3
	public void ELFGOKFMMHC(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B323 RID: 45859 RVA: 0x0041A6A4 File Offset: 0x004188A4
	private void NNJJDHIOMIA(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("maps.", this.FBOALIJENCM().RoundTripTime, this.Peer.RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = this.PNJIPPOIOEP().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_TapMedium", new GUILayoutOption[0]);
		if (flag != isSimulationEnabled)
		{
			this.GENJEBLGKEF().IsSimulationEnabled = flag;
		}
		float num = (float)this.PNJIPPOIOEP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_Value" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 1975f, 250f, new GUILayoutOption[0]);
		this.DLNPKPBLFOM().NetworkSimulationSettings.IncomingLag = (int)num;
		this.DLNPKPBLFOM().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.BCIJDDBHDLP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("Right Stick Click" + num2, new GUILayoutOption[0]);
		num2 = GUILayout.HorizontalSlider(num2, 1344f, 1514f, new GUILayoutOption[0]);
		this.ODMKOICGKGD().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.ODMKOICGKGD().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.MDIEKLDMNDJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("event" + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 1042f, 1392f, new GUILayoutOption[0]);
		this.NPBLKIPOKMF().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.BCIJDDBHDLP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1162f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B324 RID: 45860 RVA: 0x0041A874 File Offset: 0x00418A74
	private void DAPKGKFKLKL(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format(":\n", this.IJCHMGDEGCK().RoundTripTime, this.DLNPKPBLFOM().RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.LOJMNGHPOOM().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Value3", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.LOJMNGHPOOM().IsSimulationEnabled = flag;
		}
		float num = (float)this.DLNPKPBLFOM().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("Error: Can not set the OnSerialize rate higher than the overall SendRate." + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 1149f, 1598f, new GUILayoutOption[1]);
		this.NPBLKIPOKMF().NetworkSimulationSettings.IncomingLag = (int)num;
		this.HDNDGHCJEGJ().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.HDNDGHCJEGJ().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("[LocalizationService] Error: " + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1896f, 1820f, new GUILayoutOption[0]);
		this.ALEBHIOJOMO().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.GGJGMLLHLKP().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.MDIEKLDMNDJ().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("OK" + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 1877f, 370f, new GUILayoutOption[0]);
		this.NMIOPAHIFGH().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.HDNDGHCJEGJ().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 893f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B325 RID: 45861 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer FBOALIJENCM()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B326 RID: 45862 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer NMIOPAHIFGH()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B327 RID: 45863 RVA: 0x004187D3 File Offset: 0x004169D3
	public void NFCBEFDNDBG(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B328 RID: 45864 RVA: 0x004187D3 File Offset: 0x004169D3
	public void IFNJMMPONJA(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B329 RID: 45865 RVA: 0x0041AA44 File Offset: 0x00418C44
	private void ANAOLAFEDON(int ENDMCOMANKJ)
	{
		GUILayout.Label("MenuRecordButton", new GUILayoutOption[0]);
	}

	// Token: 0x0600B32A RID: 45866 RVA: 0x0041AA58 File Offset: 0x00418C58
	private void GGMICJGBCBF(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("checkpoint", this.PNJIPPOIOEP().RoundTripTime, this.LOJMNGHPOOM().RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.GGJGMLLHLKP().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "Scale environment object by the values", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.DLNPKPBLFOM().IsSimulationEnabled = flag;
		}
		float num = (float)this.FBOALIJENCM().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_Blue_C" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 1237f, 1464f, new GUILayoutOption[1]);
		this.GENJEBLGKEF().NetworkSimulationSettings.IncomingLag = (int)num;
		this.NPBLKIPOKMF().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.BCIJDDBHDLP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label(",viewkeys" + num2, new GUILayoutOption[0]);
		num2 = GUILayout.HorizontalSlider(num2, 371f, 1365f, new GUILayoutOption[1]);
		this.ODMKOICGKGD().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.NNOPMLIPGGI().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.GENJEBLGKEF().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("visible" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1568f, 1622f, new GUILayoutOption[1]);
		this.AIMLGHOJNEG().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.PBNJOGMIBDL().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1140f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B32B RID: 45867 RVA: 0x0041AC28 File Offset: 0x00418E28
	public void FBDOGLBMDNG()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.HDNDGHCJEGJ() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.OBJPCCJPACN), "Please specify either t or f.", new GUILayoutOption[1]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.BOKMOLOLOAN), "---", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B32C RID: 45868 RVA: 0x004187D3 File Offset: 0x004169D3
	public void FDOCLMLMBFI(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B32D RID: 45869 RVA: 0x004187D3 File Offset: 0x004169D3
	public void EEGCKCPJPPH(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B32E RID: 45870 RVA: 0x0041ACAD File Offset: 0x00418EAD
	public void Start()
	{
		this.Peer = PhotonNetwork.JNJJAMNLOHA;
	}

	// Token: 0x0600B32F RID: 45871 RVA: 0x0041ACBC File Offset: 0x00418EBC
	private void IHIGABDJEEC(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("in seconds. 0 - forever", this.HDAOIDAMNJO().RoundTripTime, this.NNOPMLIPGGI().RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.NMIOPAHIFGH().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "#tryagain", new GUILayoutOption[0]);
		if (flag != isSimulationEnabled)
		{
			this.LHELEHPOIDN().IsSimulationEnabled = flag;
		}
		float num = (float)this.PNJIPPOIOEP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_Value3" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 916f, 265f, new GUILayoutOption[0]);
		this.MKGMMLABLFD().NetworkSimulationSettings.IncomingLag = (int)num;
		this.BCIJDDBHDLP().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.PNJIPPOIOEP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_Distance" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 1233f, 214f, new GUILayoutOption[1]);
		this.FABGKNDAMPK().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.FBOALIJENCM().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.NNOPMLIPGGI().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("challengeid" + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 1666f, 1927f, new GUILayoutOption[0]);
		this.NNOPMLIPGGI().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.GGJGMLLHLKP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 409f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B330 RID: 45872 RVA: 0x0041AE8C File Offset: 0x0041908C
	private void IHMAOOAPLPO(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("_ScreenResolution", this.GENJEBLGKEF().RoundTripTime, this.MDIEKLDMNDJ().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = this.FBOALIJENCM().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "RoomDescriptionText", new GUILayoutOption[0]);
		if (flag != isSimulationEnabled)
		{
			this.GENJEBLGKEF().IsSimulationEnabled = flag;
		}
		float num = (float)this.BOBONFBENHG().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("_ScreenResolution" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 1519f, 584f, new GUILayoutOption[1]);
		this.IJCHMGDEGCK().NetworkSimulationSettings.IncomingLag = (int)num;
		this.OBLGFLGCCFP().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.AIMLGHOJNEG().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_ScreenResolution" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 127f, 401f, new GUILayoutOption[0]);
		this.OBLGFLGCCFP().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.PNJIPPOIOEP().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.NMIOPAHIFGH().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("SetSpeed" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1893f, 1866f, new GUILayoutOption[1]);
		this.GENJEBLGKEF().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.OBLGFLGCCFP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 251f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B331 RID: 45873 RVA: 0x004187D3 File Offset: 0x004169D3
	public void IJGEPFCBHDF(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B332 RID: 45874 RVA: 0x0041B05C File Offset: 0x0041925C
	private void GHFMFJNDCBH(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("Fill", this.DLNPKPBLFOM().RoundTripTime, this.PNJIPPOIOEP().RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.NPBLKIPOKMF().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "settings.volume.sfx", new GUILayoutOption[0]);
		if (flag != isSimulationEnabled)
		{
			this.NMIOPAHIFGH().IsSimulationEnabled = flag;
		}
		float num = (float)this.IJCHMGDEGCK().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label(": " + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 187f, 537f, new GUILayoutOption[1]);
		this.LHELEHPOIDN().NetworkSimulationSettings.IncomingLag = (int)num;
		this.NNOPMLIPGGI().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.MKGMMLABLFD().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_ScreenResolution" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 453f, 1011f, new GUILayoutOption[1]);
		this.MKGMMLABLFD().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.LHELEHPOIDN().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.FABGKNDAMPK().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("couldn't be found!" + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 1989f, 1944f, new GUILayoutOption[0]);
		this.DLNPKPBLFOM().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.PNJIPPOIOEP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1830f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B333 RID: 45875 RVA: 0x0041B22C File Offset: 0x0041942C
	public void NMHIDAOMOGO()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.DLNPKPBLFOM() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.MALIOOJFHPG), "BadgeImage", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.MPOICLNJGJO), "_Value", new GUILayoutOption[0]);
		}
	}

	// Token: 0x0600B334 RID: 45876 RVA: 0x0041A37E File Offset: 0x0041857E
	public void KMCPMOGKDEH()
	{
		this.AFNCJLOGLBB(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B335 RID: 45877 RVA: 0x0041B2B1 File Offset: 0x004194B1
	private void CBKCFPBJDEL(int ENDMCOMANKJ)
	{
		GUILayout.Label("grid", new GUILayoutOption[0]);
	}

	// Token: 0x0600B336 RID: 45878 RVA: 0x0041B2C3 File Offset: 0x004194C3
	public void NNCCPEBIAKH()
	{
		this.LKFMMEBLCMK(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B337 RID: 45879 RVA: 0x0041B2D0 File Offset: 0x004194D0
	public void FCCFGOEKDKG()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.BOBONFBENHG() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.HDFOAJAFMDK), "YES", new GUILayoutOption[0]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.DAPKGKFKLKL), "CameraFilterPack_Paper2", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B338 RID: 45880 RVA: 0x0041B358 File Offset: 0x00419558
	private void CBDBMEAEBMH(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format(": ", this.HDNDGHCJEGJ().RoundTripTime, this.MDIEKLDMNDJ().RoundTripTimeVariance), new GUILayoutOption[0]);
		bool isSimulationEnabled = this.LHELEHPOIDN().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_Value4", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.LOJMNGHPOOM().IsSimulationEnabled = flag;
		}
		float num = (float)this.HDAOIDAMNJO().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("ReconnectToMaster() with AuthValues == null is not correct!" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 878f, 1873f, new GUILayoutOption[1]);
		this.BCIJDDBHDLP().NetworkSimulationSettings.IncomingLag = (int)num;
		this.ODMKOICGKGD().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.ALEBHIOJOMO().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("#,0.00" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 720f, 50f, new GUILayoutOption[0]);
		this.OBLGFLGCCFP().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.GGJGMLLHLKP().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.ODMKOICGKGD().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("ResetSpeed" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 20f, 1109f, new GUILayoutOption[1]);
		this.HDNDGHCJEGJ().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.PNJIPPOIOEP().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1754f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B339 RID: 45881 RVA: 0x0041B528 File Offset: 0x00419728
	public void JLJHPNKKJPJ()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.FABGKNDAMPK() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.CKHOOGMFDMD), "CameraFilterPack/Blur_GaussianBlur", new GUILayoutOption[1]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.HMPHAICGEJK), "Set particless emission (glow)", new GUILayoutOption[0]);
		}
	}

	// Token: 0x0600B33A RID: 45882 RVA: 0x004187D3 File Offset: 0x004169D3
	public void BJANBIOLJFB(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B33B RID: 45883 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer LHELEHPOIDN()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B33C RID: 45884 RVA: 0x0041B5B0 File Offset: 0x004197B0
	private void HMPHAICGEJK(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("steamid", this.HDNDGHCJEGJ().RoundTripTime, this.GENJEBLGKEF().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = this.FABGKNDAMPK().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "mapselector.orderby", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.NMIOPAHIFGH().IsSimulationEnabled = flag;
		}
		float num = (float)this.LOJMNGHPOOM().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label(":" + num, new GUILayoutOption[1]);
		num = GUILayout.HorizontalSlider(num, 361f, 699f, new GUILayoutOption[1]);
		this.FBOALIJENCM().NetworkSimulationSettings.IncomingLag = (int)num;
		this.HDAOIDAMNJO().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.LOJMNGHPOOM().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("_SoftZDistance" + num2, new GUILayoutOption[0]);
		num2 = GUILayout.HorizontalSlider(num2, 833f, 1200f, new GUILayoutOption[0]);
		this.BOBONFBENHG().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.ALEBHIOJOMO().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.NNOPMLIPGGI().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_Value" + num3, new GUILayoutOption[0]);
		num3 = GUILayout.HorizontalSlider(num3, 930f, 1554f, new GUILayoutOption[1]);
		this.OBLGFLGCCFP().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.DLNPKPBLFOM().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 1144f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B33D RID: 45885 RVA: 0x0041B780 File Offset: 0x00419980
	private void BFFCJEDADJG(int ENDMCOMANKJ)
	{
		GUILayout.Label(string.Format("CameraFilterPack_Atmosphere_Rain_FX", this.NMIOPAHIFGH().RoundTripTime, this.OBLGFLGCCFP().RoundTripTimeVariance), new GUILayoutOption[1]);
		bool isSimulationEnabled = this.NPBLKIPOKMF().IsSimulationEnabled;
		bool flag = GUILayout.Toggle(isSimulationEnabled, "_TimeX", new GUILayoutOption[1]);
		if (flag != isSimulationEnabled)
		{
			this.BOBONFBENHG().IsSimulationEnabled = flag;
		}
		float num = (float)this.GGJGMLLHLKP().NetworkSimulationSettings.IncomingLag;
		GUILayout.Label("\0\0" + num, new GUILayoutOption[0]);
		num = GUILayout.HorizontalSlider(num, 279f, 138f, new GUILayoutOption[1]);
		this.IJCHMGDEGCK().NetworkSimulationSettings.IncomingLag = (int)num;
		this.IJCHMGDEGCK().NetworkSimulationSettings.OutgoingLag = (int)num;
		float num2 = (float)this.OBLGFLGCCFP().NetworkSimulationSettings.IncomingJitter;
		GUILayout.Label("error" + num2, new GUILayoutOption[1]);
		num2 = GUILayout.HorizontalSlider(num2, 872f, 1133f, new GUILayoutOption[1]);
		this.GENJEBLGKEF().NetworkSimulationSettings.IncomingJitter = (int)num2;
		this.NNOPMLIPGGI().NetworkSimulationSettings.OutgoingJitter = (int)num2;
		float num3 = (float)this.NPBLKIPOKMF().NetworkSimulationSettings.IncomingLossPercentage;
		GUILayout.Label("_Value3" + num3, new GUILayoutOption[1]);
		num3 = GUILayout.HorizontalSlider(num3, 1659f, 1707f, new GUILayoutOption[0]);
		this.GGJGMLLHLKP().NetworkSimulationSettings.IncomingLossPercentage = (int)num3;
		this.IJCHMGDEGCK().NetworkSimulationSettings.OutgoingLossPercentage = (int)num3;
		if (GUI.changed)
		{
			this.WindowRect.height = 710f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B33E RID: 45886 RVA: 0x0041B950 File Offset: 0x00419B50
	public void FIKFJDFELIP()
	{
		this.BBBKFCHNLJH(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B33F RID: 45887 RVA: 0x004187D3 File Offset: 0x004169D3
	public void MFKKGNBFNPL(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B340 RID: 45888 RVA: 0x0041B960 File Offset: 0x00419B60
	public void LGMADMDBKNE()
	{
		if (!this.Visible)
		{
			return;
		}
		if (this.IJCHMGDEGCK() == null)
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.BLJBEBLDEKB), "#startofflinemessage", new GUILayoutOption[1]);
		}
		else
		{
			this.WindowRect = GUILayout.Window(this.WindowId, this.WindowRect, new GUI.WindowFunction(this.HMPHAICGEJK), "menu.selectedplaymode", new GUILayoutOption[1]);
		}
	}

	// Token: 0x0600B341 RID: 45889 RVA: 0x004187B9 File Offset: 0x004169B9
	public PhotonPeer MDIEKLDMNDJ()
	{
		return this.<IIILKHCAJKM>k__BackingField;
	}

	// Token: 0x0600B342 RID: 45890 RVA: 0x0041B9E5 File Offset: 0x00419BE5
	private void LFPCFFJGFEL(int ENDMCOMANKJ)
	{
		GUILayout.Label(" = ", new GUILayoutOption[1]);
	}

	// Token: 0x0600B343 RID: 45891 RVA: 0x004187D3 File Offset: 0x004169D3
	public void BBBKFCHNLJH(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B344 RID: 45892 RVA: 0x0041B9F7 File Offset: 0x00419BF7
	private void DKNKGNEHMMB(int ENDMCOMANKJ)
	{
		GUILayout.Label("RedoButton", new GUILayoutOption[0]);
	}

	// Token: 0x0600B345 RID: 45893 RVA: 0x0041BA09 File Offset: 0x00419C09
	public void KHIGHFJKPFG()
	{
		this.MBCHBLHDNBB(PhotonNetwork.JNJJAMNLOHA);
	}

	// Token: 0x0600B346 RID: 45894 RVA: 0x004187D3 File Offset: 0x004169D3
	public void NODJAFLLGIK(PhotonPeer DPNHODJHGJL)
	{
		this.<IIILKHCAJKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x040014F9 RID: 5369
	public Rect WindowRect = new Rect(0f, 100f, 120f, 100f);

	// Token: 0x040014FA RID: 5370
	public int WindowId = 101;

	// Token: 0x040014FB RID: 5371
	public bool Visible = true;
}
