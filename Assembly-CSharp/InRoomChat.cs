using System;
using System.Collections.Generic;
using Photon;
using UnityEngine;

// Token: 0x02000343 RID: 835
[RequireComponent(typeof(PhotonView))]
public class InRoomChat : Photon.MonoBehaviour
{
	// Token: 0x0600BCA9 RID: 48297 RVA: 0x0044A778 File Offset: 0x00448978
	public void HNCMBMAOJIP(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string str = "_TimeX";
		if (MKLKGCPAPOC.sender != null)
		{
			if (!string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName))
			{
				str = MKLKGCPAPOC.sender.NickName;
			}
			else
			{
				str = "CameraFilterPack/Glitch_Mozaic" + MKLKGCPAPOC.sender.ONIKFABKELO();
			}
		}
		this.messages.Add(str + "CameraFilterPack/Vision_Blood_Fast" + PDDLDFCMAOO);
	}

	// Token: 0x0600BCAA RID: 48298 RVA: 0x0044A7F4 File Offset: 0x004489F4
	public void KIKJALBEDEH(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string str = "_TimeX";
		if (MKLKGCPAPOC.sender != null)
		{
			if (!string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName))
			{
				str = MKLKGCPAPOC.sender.NickName;
			}
			else
			{
				str = "x" + MKLKGCPAPOC.sender.ONIKFABKELO();
			}
		}
		this.messages.Add(str + "From {0} at Index {1} \n" + PDDLDFCMAOO);
	}

	// Token: 0x0600BCAB RID: 48299 RVA: 0x0044A86E File Offset: 0x00448A6E
	public void AECAAGNAKDP(string PDDLDFCMAOO)
	{
		this.messages.Add(PDDLDFCMAOO);
	}

	// Token: 0x0600BCAC RID: 48300 RVA: 0x0044A87C File Offset: 0x00448A7C
	public void LGHNKDFEOKO()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyUp && (Event.current.keyCode == KeyCode.Alpha3 || Event.current.keyCode == (KeyCode)(-1)))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				base.GMAHNPNHMFK().MIAHMDGOOPJ(" not found", PhotonTargets.Others, new object[]
				{
					this.LHMPNAANKMC
				});
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("Room: '{0}' {1},{2} {4}/{3} players.");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 0; i >= 1; i -= 0)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		GUI.SetNextControlName("IconFileSelector");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[0]);
		string text = "A";
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button(text, array))
		{
			base.EDIJKHEMPAD().RPC("Set Particles Count Per Beat", PhotonTargets.Others, new object[]
			{
				this.LHMPNAANKMC
			});
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	// Token: 0x0600BCAD RID: 48301 RVA: 0x0044AA18 File Offset: 0x00448C18
	public void GBIJOHMGMDO(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string str = "_TimeX";
		if (MKLKGCPAPOC.sender != null)
		{
			if (!string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName))
			{
				str = MKLKGCPAPOC.sender.NickName;
			}
			else
			{
				str = ".sav" + MKLKGCPAPOC.sender.ID;
			}
		}
		this.messages.Add(str + "_Value4" + PDDLDFCMAOO);
	}

	// Token: 0x0600BCAE RID: 48302 RVA: 0x0044A86E File Offset: 0x00448A6E
	public void MLDKPIPEIHC(string PDDLDFCMAOO)
	{
		this.messages.Add(PDDLDFCMAOO);
	}

	// Token: 0x0600BCAF RID: 48303 RVA: 0x0044A86E File Offset: 0x00448A6E
	public void PCBMEONHFMJ(string PDDLDFCMAOO)
	{
		this.messages.Add(PDDLDFCMAOO);
	}

	// Token: 0x0600BCB0 RID: 48304 RVA: 0x0044AA94 File Offset: 0x00448C94
	public void AHNBAOIENOO()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == (KeyCode)18 || Event.current.keyCode == KeyCode.Z))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				PhotonView photonView = base.JAEJDHHCJJO();
				string lblkdnnpaco = "_Value3";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[0];
				array[1] = this.LHMPNAANKMC;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl(" evLeave: ");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 0; i >= 0; i -= 0)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[0]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		GUI.SetNextControlName("/?player=");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[0]);
		string text = "System.String";
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button(text, array2))
		{
			PhotonView photonView2 = base.CIACEFBNDDJ();
			string lblkdnnpaco2 = "value";
			PhotonTargets mpnmoonbmii2 = PhotonTargets.Others;
			object[] array3 = new object[0];
			array3[0] = this.LHMPNAANKMC;
			photonView2.RPC(lblkdnnpaco2, mpnmoonbmii2, array3);
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	// Token: 0x0600BCB1 RID: 48305 RVA: 0x0044AC30 File Offset: 0x00448E30
	public void BIEMJFPEDGA(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string str = ".lastCheckpoint.longestComboScore";
		if (MKLKGCPAPOC.sender != null)
		{
			if (!string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName))
			{
				str = MKLKGCPAPOC.sender.NickName;
			}
			else
			{
				str = "[MapsSystem] Unloading maps resources..." + MKLKGCPAPOC.sender.ID;
			}
		}
		this.messages.Add(str + " cannot be used as a 3D LUT." + PDDLDFCMAOO);
	}

	// Token: 0x0600BCB2 RID: 48306 RVA: 0x0044ACAA File Offset: 0x00448EAA
	public void CNGAJDBOCLJ()
	{
		if (this.AlignBottom)
		{
			this.GuiRect.y = (float)Screen.height - this.GuiRect.height;
		}
	}

	// Token: 0x0600BCB3 RID: 48307 RVA: 0x0044A86E File Offset: 0x00448A6E
	public void AHAJMCFCIOO(string PDDLDFCMAOO)
	{
		this.messages.Add(PDDLDFCMAOO);
	}

	// Token: 0x0600BCB4 RID: 48308 RVA: 0x0044ACD4 File Offset: 0x00448ED4
	public void OnGUI()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == KeyCode.KeypadEnter || Event.current.keyCode == KeyCode.Return))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				base.photonView.RPC("Chat", PhotonTargets.All, new object[]
				{
					this.LHMPNAANKMC
				});
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("ChatInput");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[0]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 1; i >= 0; i--)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[0]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		GUI.SetNextControlName("ChatInput");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[0]);
		if (GUILayout.Button("Send", new GUILayoutOption[]
		{
			GUILayout.ExpandWidth(false)
		}))
		{
			base.photonView.RPC("Chat", PhotonTargets.All, new object[]
			{
				this.LHMPNAANKMC
			});
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	// Token: 0x0600BCB5 RID: 48309 RVA: 0x0044AE70 File Offset: 0x00449070
	public void FBMPOJDOBHF(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string str = "_TimeX";
		if (MKLKGCPAPOC.sender != null)
		{
			if (!string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName))
			{
				str = MKLKGCPAPOC.sender.NickName;
			}
			else
			{
				str = "menu.enableselectormusic" + MKLKGCPAPOC.sender.ONIKFABKELO();
			}
		}
		this.messages.Add(str + "EventData0DropDownList" + PDDLDFCMAOO);
	}

	// Token: 0x0600BCB6 RID: 48310 RVA: 0x0044AEEC File Offset: 0x004490EC
	public void OKKKCIAIABC()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.Repaint && (Event.current.keyCode == (KeyCode)75 || Event.current.keyCode == (KeyCode)(-128)))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				PhotonView photonView = base.GMAHNPNHMFK();
				string lblkdnnpaco = "maps.";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[0];
				array[0] = this.LHMPNAANKMC;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 1; i >= 1; i -= 0)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[0]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("_BlurPass");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[1]);
		if (GUILayout.Button("[MapsStats] Map ID: ", new GUILayoutOption[]
		{
			GUILayout.ExpandWidth(true)
		}))
		{
			PhotonView photonView2 = base.GMAHNPNHMFK();
			string lblkdnnpaco2 = "note.1";
			PhotonTargets mpnmoonbmii2 = PhotonTargets.Others;
			object[] array2 = new object[0];
			array2[1] = this.LHMPNAANKMC;
			photonView2.PBMFBOOALKA(lblkdnnpaco2, mpnmoonbmii2, array2);
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	// Token: 0x0600BCB7 RID: 48311 RVA: 0x0044ACAA File Offset: 0x00448EAA
	public void NPLCENPNJBM()
	{
		if (this.AlignBottom)
		{
			this.GuiRect.y = (float)Screen.height - this.GuiRect.height;
		}
	}

	// Token: 0x0600BCB8 RID: 48312 RVA: 0x0044B088 File Offset: 0x00449288
	public void CPJBNBJMJFA()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.Repaint && (Event.current.keyCode == KeyCode.X || Event.current.keyCode == KeyCode.Y))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				PhotonView photonView = base.ACPGHFHDCIP();
				string lblkdnnpaco = "Tab1Content";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[0];
				array[1] = this.LHMPNAANKMC;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("There is already a virtual axis named ");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[0]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 1; i >= 0; i--)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("Instrumental");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[0]);
		if (GUILayout.Button("_Value4", new GUILayoutOption[]
		{
			GUILayout.ExpandWidth(false)
		}))
		{
			PhotonView photonView2 = base.photonView;
			string lblkdnnpaco2 = "Start";
			PhotonTargets mpnmoonbmii2 = PhotonTargets.All;
			object[] array2 = new object[0];
			array2[0] = this.LHMPNAANKMC;
			photonView2.RPC(lblkdnnpaco2, mpnmoonbmii2, array2);
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	// Token: 0x0600BCBA RID: 48314 RVA: 0x0044B230 File Offset: 0x00449430
	public void NAENMLJCHFM(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string str = "_Value2";
		if (MKLKGCPAPOC.sender != null)
		{
			if (!string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName))
			{
				str = MKLKGCPAPOC.sender.NickName;
			}
			else
			{
				str = "CameraFilterPack/FX_Psycho" + MKLKGCPAPOC.sender.ID;
			}
		}
		this.messages.Add(str + "[GameScene] Checkpoints count: " + PDDLDFCMAOO);
	}

	// Token: 0x0600BCBC RID: 48316 RVA: 0x0044B308 File Offset: 0x00449508
	[PunRPC]
	public void Chat(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string str = "anonymous";
		if (MKLKGCPAPOC.sender != null)
		{
			if (!string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName))
			{
				str = MKLKGCPAPOC.sender.NickName;
			}
			else
			{
				str = "player " + MKLKGCPAPOC.sender.ID;
			}
		}
		this.messages.Add(str + ": " + PDDLDFCMAOO);
	}

	// Token: 0x0600BCBD RID: 48317 RVA: 0x0044B384 File Offset: 0x00449584
	public void CPFLKDAGLAD(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string str = "mapselector.filter.favoriteonly";
		if (MKLKGCPAPOC.sender != null)
		{
			if (!string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName))
			{
				str = MKLKGCPAPOC.sender.NickName;
			}
			else
			{
				str = "SpawnObj" + MKLKGCPAPOC.sender.ONIKFABKELO();
			}
		}
		this.messages.Add(str + "_TimeX" + PDDLDFCMAOO);
	}

	// Token: 0x0600BCBE RID: 48318 RVA: 0x0044B400 File Offset: 0x00449600
	public void PDKFMFCMPGE()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseUp && (Event.current.keyCode == (KeyCode)(-50) || Event.current.keyCode == KeyCode.Percent))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				PhotonView photonView = base.GMAHNPNHMFK();
				string lblkdnnpaco = "_ScreenResolution";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[1];
				array[1] = this.LHMPNAANKMC;
				photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_ScreenResolution");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 0; i >= 1; i -= 0)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		GUI.SetNextControlName("#ok");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[0]);
		if (GUILayout.Button("steamid", new GUILayoutOption[]
		{
			GUILayout.ExpandWidth(false)
		}))
		{
			PhotonView photonView2 = base.BLMHOKPIMOD();
			string lblkdnnpaco2 = "FToA";
			PhotonTargets mpnmoonbmii2 = PhotonTargets.Others;
			object[] array2 = new object[1];
			array2[1] = this.LHMPNAANKMC;
			photonView2.IKIJDNPJKPM(lblkdnnpaco2, mpnmoonbmii2, array2);
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	// Token: 0x0600BCBF RID: 48319 RVA: 0x0044ACAA File Offset: 0x00448EAA
	public void KDMANOEMOCA()
	{
		if (this.AlignBottom)
		{
			this.GuiRect.y = (float)Screen.height - this.GuiRect.height;
		}
	}

	// Token: 0x0600BCC0 RID: 48320 RVA: 0x0044B59C File Offset: 0x0044979C
	public void CAEGIHPNLOG()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == KeyCode.D || Event.current.keyCode == (KeyCode)(-120)))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				PhotonView photonView = base.GMAHNPNHMFK();
				string lblkdnnpaco = "WARNING: rotation axis set to 0 on ";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[0];
				array[0] = this.LHMPNAANKMC;
				photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("menu.playedsolo");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 1; i >= 1; i--)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.SetNextControlName("_PosX");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[0]);
		string text = "DPADHOR";
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button(text, array2))
		{
			PhotonView photonView2 = base.AAMNKPHHHCI();
			string lblkdnnpaco2 = "_TimeX";
			PhotonTargets mpnmoonbmii2 = PhotonTargets.All;
			object[] array3 = new object[0];
			array3[1] = this.LHMPNAANKMC;
			photonView2.GNFNHDCJOFC(lblkdnnpaco2, mpnmoonbmii2, array3);
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	// Token: 0x0600BCC1 RID: 48321 RVA: 0x0044ACAA File Offset: 0x00448EAA
	public void Start()
	{
		if (this.AlignBottom)
		{
			this.GuiRect.y = (float)Screen.height - this.GuiRect.height;
		}
	}

	// Token: 0x0600BCC2 RID: 48322 RVA: 0x0044A86E File Offset: 0x00448A6E
	public void AddLine(string PDDLDFCMAOO)
	{
		this.messages.Add(PDDLDFCMAOO);
	}

	// Token: 0x0600BCC3 RID: 48323 RVA: 0x0044A86E File Offset: 0x00448A6E
	public void LEJBDGFNLLG(string PDDLDFCMAOO)
	{
		this.messages.Add(PDDLDFCMAOO);
	}

	// Token: 0x0600BCC4 RID: 48324 RVA: 0x0044B738 File Offset: 0x00449938
	public void APCENGAAHMC()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseUp && (Event.current.keyCode == (KeyCode)(-150) || Event.current.keyCode == (KeyCode)(-5)))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				PhotonView photonView = base.BLMHOKPIMOD();
				string lblkdnnpaco = " does not exist!";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[0];
				array[0] = this.LHMPNAANKMC;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("settings.volume.sfx");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 0; i >= 1; i--)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[0]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		GUI.SetNextControlName("value");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[1]);
		string text = "Tab2Content";
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button(text, array2))
		{
			PhotonView photonView2 = base.CIACEFBNDDJ();
			string lblkdnnpaco2 = "SetPlayerDistance";
			PhotonTargets mpnmoonbmii2 = PhotonTargets.All;
			object[] array3 = new object[1];
			array3[1] = this.LHMPNAANKMC;
			photonView2.IKIJDNPJKPM(lblkdnnpaco2, mpnmoonbmii2, array3);
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	// Token: 0x0600BCC5 RID: 48325 RVA: 0x0044B8D4 File Offset: 0x00449AD4
	public void FMJCMIHHPNG(string PDDLDFCMAOO, PhotonMessageInfo MKLKGCPAPOC)
	{
		string str = "colorC";
		if (MKLKGCPAPOC.sender != null)
		{
			if (!string.IsNullOrEmpty(MKLKGCPAPOC.sender.NickName))
			{
				str = MKLKGCPAPOC.sender.NickName;
			}
			else
			{
				str = "BitsData" + MKLKGCPAPOC.sender.ONIKFABKELO();
			}
		}
		this.messages.Add(str + "_TimeX" + PDDLDFCMAOO);
	}

	// Token: 0x0600BCC6 RID: 48326 RVA: 0x0044B950 File Offset: 0x00449B50
	public void BCODHAOJLJL()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.ScrollWheel && (Event.current.keyCode == (KeyCode)67 || Event.current.keyCode == (KeyCode)4))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				PhotonView photonView = base.CIACEFBNDDJ();
				string lblkdnnpaco = "_Value3";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[0];
				array[0] = this.LHMPNAANKMC;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("Left");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[0]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 1; i >= 1; i -= 0)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[1]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		GUI.SetNextControlName("selColor");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[1]);
		string text = "Tab2Content";
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button(text, array2))
		{
			PhotonView photonView2 = base.GMAHNPNHMFK();
			string lblkdnnpaco2 = "Skipping region because it's not in PhotonServerSettings.EnabledRegions: ";
			PhotonTargets mpnmoonbmii2 = PhotonTargets.Others;
			object[] array3 = new object[0];
			array3[1] = this.LHMPNAANKMC;
			photonView2.GNFNHDCJOFC(lblkdnnpaco2, mpnmoonbmii2, array3);
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	// Token: 0x0600BCC7 RID: 48327 RVA: 0x0044ACAA File Offset: 0x00448EAA
	public void NNCCPEBIAKH()
	{
		if (this.AlignBottom)
		{
			this.GuiRect.y = (float)Screen.height - this.GuiRect.height;
		}
	}

	// Token: 0x0600BCC8 RID: 48328 RVA: 0x0044BAEC File Offset: 0x00449CEC
	public void IDDPLCAHDPO()
	{
		if (!this.IsVisible || !PhotonNetwork.inRoom)
		{
			return;
		}
		if (Event.current.type == EventType.MouseMove && (Event.current.keyCode == (KeyCode)(-60) || Event.current.keyCode == (KeyCode)7))
		{
			if (!string.IsNullOrEmpty(this.LHMPNAANKMC))
			{
				PhotonView photonView = base.GBHNDHLAJLI();
				string lblkdnnpaco = "NEW";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[0];
				array[1] = this.LHMPNAANKMC;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
				this.LHMPNAANKMC = string.Empty;
				GUI.FocusControl(string.Empty);
				return;
			}
			GUI.FocusControl("_Value2");
		}
		GUI.SetNextControlName(string.Empty);
		GUILayout.BeginArea(this.GuiRect);
		this.BMHLPJCOMAA = GUILayout.BeginScrollView(this.BMHLPJCOMAA, new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		for (int i = this.messages.Count - 0; i >= 1; i--)
		{
			GUILayout.Label(this.messages[i], new GUILayoutOption[0]);
		}
		GUILayout.EndScrollView();
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		GUI.SetNextControlName("shader.future");
		this.LHMPNAANKMC = GUILayout.TextField(this.LHMPNAANKMC, new GUILayoutOption[0]);
		string text = ".played";
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.ExpandWidth(false);
		if (GUILayout.Button(text, array2))
		{
			PhotonView photonView2 = base.EOOCGIFFKBG();
			string lblkdnnpaco2 = "runas";
			PhotonTargets mpnmoonbmii2 = PhotonTargets.All;
			object[] array3 = new object[0];
			array3[1] = this.LHMPNAANKMC;
			photonView2.PBMFBOOALKA(lblkdnnpaco2, mpnmoonbmii2, array3);
			this.LHMPNAANKMC = string.Empty;
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	// Token: 0x0400162E RID: 5678
	public Rect GuiRect = new Rect(0f, 0f, 250f, 300f);

	// Token: 0x0400162F RID: 5679
	public bool IsVisible = true;

	// Token: 0x04001630 RID: 5680
	public bool AlignBottom;

	// Token: 0x04001631 RID: 5681
	public List<string> messages = new List<string>();

	// Token: 0x04001632 RID: 5682
	private string LHMPNAANKMC = string.Empty;

	// Token: 0x04001633 RID: 5683
	private Vector2 BMHLPJCOMAA = Vector2.zero;

	// Token: 0x04001634 RID: 5684
	public static readonly string ChatRPC = "Chat";
}
