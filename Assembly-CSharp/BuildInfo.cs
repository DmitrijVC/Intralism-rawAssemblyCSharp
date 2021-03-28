using System;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200040A RID: 1034
public class BuildInfo : MonoBehaviour
{
	// Token: 0x0600ECFB RID: 60667 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x0600ECFC RID: 60668 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0600ECFD RID: 60669 RVA: 0x00533A44 File Offset: 0x00531C44
	private void MKIMDFLBFOM()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "_MainTex2";
			int cchNameBufferSize = 4;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "Set Sun Colors" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Scrollbar" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[3];
		array[0] = this.PKOAMLGGDDI;
		array[1] = "Set satellite trail width";
		array[8] = this.FONGIBAJEMO;
		array[2] = this.KCJEFKBENKA;
		array[5] = ((!flag) ? string.Empty : "Set arcs speed. Base value - 15");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().MDDADJIHOJP());
	}

	// Token: 0x0600ECFE RID: 60670 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x0600ECFF RID: 60671 RVA: 0x00533B40 File Offset: 0x00531D40
	private void JHANGPCOCIG()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "OnPlayerGameMessage";
			int cchNameBufferSize = 2;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "mapid" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("AudioSampler" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[4];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "maps.";
		array[3] = this.FONGIBAJEMO;
		array[5] = this.KCJEFKBENKA;
		array[0] = ((!flag) ? string.Empty : "_Value");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().CMENLDIKOGJ());
	}

	// Token: 0x0600ED00 RID: 60672 RVA: 0x00533C3C File Offset: 0x00531E3C
	private void JONGNKNLLND()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = ". The group number should be at least 1.";
			int cchNameBufferSize = 4;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "_Value7" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("LeaderboardsButton" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[0];
		array[1] = this.PKOAMLGGDDI;
		array[1] = "CameraFilterPack/EXTRA_Rotation";
		array[7] = this.FONGIBAJEMO;
		array[4] = this.KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "EnableRankedNotificationsToggle");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().ICFEFPIGPFC());
	}

	// Token: 0x0600ED01 RID: 60673 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x0600ED02 RID: 60674 RVA: 0x00533D38 File Offset: 0x00531F38
	private void PDHKMDBNGGN()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "Uploading preview image...";
			int cchNameBufferSize = 0;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = " PhotonNetwork.networkingPeer.AvailableRegions " + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("PublishButton" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[]
		{
			this.PKOAMLGGDDI,
			"Connecting to server"
		};
		array[1] = this.FONGIBAJEMO;
		array[0] = this.KCJEFKBENKA;
		array[0] = ((!flag) ? string.Empty : "OneHand");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().IPFKCJENGAC());
	}

	// Token: 0x0600ED03 RID: 60675 RVA: 0x00533E34 File Offset: 0x00532034
	private void FIKFJDFELIP()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "#ok";
			int cchNameBufferSize = 4;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "ready" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log(" Time: " + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[]
		{
			null,
			this.PKOAMLGGDDI
		};
		array[1] = "_Value2";
		array[2] = this.FONGIBAJEMO;
		array[7] = this.KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "gold");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().DPCDAONEBPK());
	}

	// Token: 0x0600ED04 RID: 60676 RVA: 0x00533F30 File Offset: 0x00532130
	private void MNBPNHNAEBK()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "_Value2";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "_ScreenResolution" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Blurred" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[6];
		array[1] = this.PKOAMLGGDDI;
		array[0] = "_Distortion";
		array[8] = this.FONGIBAJEMO;
		array[1] = this.KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "UpdateNewsTileStart");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().MKGMGJJIELK());
	}

	// Token: 0x0600ED05 RID: 60677 RVA: 0x0053402C File Offset: 0x0053222C
	private void JKBMKPDGCHG()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "tagElement";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "/" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("CameraFilterPack/Vision_Rainbow" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[5];
		array[1] = this.PKOAMLGGDDI;
		array[1] = "BestScoreText";
		array[1] = this.FONGIBAJEMO;
		array[4] = this.KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "\n");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().PPNKOMMDAPD());
	}

	// Token: 0x0600ED06 RID: 60678 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600ED07 RID: 60679 RVA: 0x00534128 File Offset: 0x00532328
	private void OHFOLGANOLC()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = ").";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "AudioSampler" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("event" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[2];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "InfoCanvas";
		array[4] = this.FONGIBAJEMO;
		array[2] = this.KCJEFKBENKA;
		array[5] = ((!flag) ? string.Empty : "CameraFilterPack/Distortion_Aspiration");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().FJJOIELAMOG());
	}

	// Token: 0x0600ED08 RID: 60680 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600ED09 RID: 60681 RVA: 0x00534224 File Offset: 0x00532424
	private void PMPKMGKAAJH()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "#";
			int cchNameBufferSize = 1;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "Connected to gameserver." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("mapid" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[]
		{
			this.PKOAMLGGDDI
		};
		array[0] = "_Axis";
		array[4] = this.FONGIBAJEMO;
		array[4] = this.KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "value");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().AHHDHBNKFEG());
	}

	// Token: 0x0600ED0A RID: 60682 RVA: 0x00534320 File Offset: 0x00532520
	private void DKOPKPBLDHH()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "_TimeX";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "ScreenResolutionPanel" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("0.00" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[0];
		array[1] = this.PKOAMLGGDDI;
		array[0] = "Anomaly_Intensity";
		array[0] = this.FONGIBAJEMO;
		array[3] = this.KCJEFKBENKA;
		array[1] = ((!flag) ? string.Empty : "Anomaly_Near");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().AHHDHBNKFEG());
	}

	// Token: 0x0600ED0B RID: 60683 RVA: 0x0053441C File Offset: 0x0053261C
	private void CHOPDIGHJNH()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "\\\\";
			int cchNameBufferSize = 7;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "NewMapHandsCountSlider" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("type" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[7];
		array[0] = this.PKOAMLGGDDI;
		array[1] = "CameraFilterPack_Paper4";
		array[4] = this.FONGIBAJEMO;
		array[4] = this.KCJEFKBENKA;
		array[2] = ((!flag) ? string.Empty : "_Value4");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().AHHDHBNKFEG());
	}

	// Token: 0x0600ED0C RID: 60684 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x0600ED0D RID: 60685 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x0600ED0E RID: 60686 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x0600ED0F RID: 60687 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x0600ED10 RID: 60688 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x0600ED11 RID: 60689 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x0600ED12 RID: 60690 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600ED13 RID: 60691 RVA: 0x00534518 File Offset: 0x00532718
	private void FANADGBGCPI()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "ShadersToggle";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "CameraFilterPack/Glow_Glow" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_ScreenResolution" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[6];
		array[1] = this.PKOAMLGGDDI;
		array[0] = "1,30,true,0";
		array[5] = this.FONGIBAJEMO;
		array[2] = this.KCJEFKBENKA;
		array[1] = ((!flag) ? string.Empty : "_Value5");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().AHALHEPONLD());
	}

	// Token: 0x0600ED14 RID: 60692 RVA: 0x00534614 File Offset: 0x00532814
	private void KCCIEMBMOBA()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "_Value";
			int cchNameBufferSize = 1;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "The number of players playing your game: " + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("maps." + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[2];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "FreqVolume: ";
		array[4] = this.FONGIBAJEMO;
		array[2] = this.KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "_WhiteBalance");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().JDCFAOHDFIN());
	}

	// Token: 0x0600ED15 RID: 60693 RVA: 0x00534710 File Offset: 0x00532910
	private void ECBILENEOOL()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "Set satellite clockwise rotattion speed";
			int cchNameBufferSize = 7;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "difficulty" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Value" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[8];
		array[0] = this.PKOAMLGGDDI;
		array[1] = "TotalHitsScoreText";
		array[6] = this.FONGIBAJEMO;
		array[6] = this.KCJEFKBENKA;
		array[6] = ((!flag) ? string.Empty : "JoinRoom failed. In offline mode you still have to leave a room to enter another.");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().IIBOBNHHGCK());
	}

	// Token: 0x0600ED16 RID: 60694 RVA: 0x0053480C File Offset: 0x00532A0C
	private void DIPDEHOOBPG()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "settings.cameramovements";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "HandsCountSlider" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Sat" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[3];
		array[1] = this.PKOAMLGGDDI;
		array[0] = "Observed type is not serializable: ";
		array[6] = this.FONGIBAJEMO;
		array[7] = this.KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "_ScreenResolution");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().BKGOINFBAMJ());
	}

	// Token: 0x0600ED17 RID: 60695 RVA: 0x00534908 File Offset: 0x00532B08
	private void HMPGIFBJFIK()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "[MenuScene] Error: ";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: " + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("1" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[8];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "SetSpeed";
		array[4] = this.FONGIBAJEMO;
		array[3] = this.KCJEFKBENKA;
		array[2] = ((!flag) ? string.Empty : ".sawoutdatedmessage");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().MKGMGJJIELK());
	}

	// Token: 0x0600ED18 RID: 60696 RVA: 0x00534A04 File Offset: 0x00532C04
	private void DBLILJGKGHJ()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = ". Current number of cells is ";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "_BlurredColor" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("settings.volume.sfx" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[4];
		array[0] = this.PKOAMLGGDDI;
		array[1] = "Toggle {0} is not part of ToggleGroup {1}";
		array[4] = this.FONGIBAJEMO;
		array[8] = this.KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "_Value");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().INFHBGJLHBH());
	}

	// Token: 0x0600ED19 RID: 60697 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x0600ED1A RID: 60698 RVA: 0x00534B00 File Offset: 0x00532D00
	private void NBGIMIDICKE()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "SupportLogger Info: PUN {0}: ";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "/music" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("ConfigVersionSlider" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[]
		{
			null,
			this.PKOAMLGGDDI
		};
		array[1] = "Texture2";
		array[7] = this.FONGIBAJEMO;
		array[2] = this.KCJEFKBENKA;
		array[6] = ((!flag) ? string.Empty : "GlassDistortion");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().COFOOEGOLFA());
	}

	// Token: 0x0600ED1B RID: 60699 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x0600ED1C RID: 60700 RVA: 0x00534BFC File Offset: 0x00532DFC
	private void DBEMDAJDDDA()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "/Assets/MyImage";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "CameraFilterPack/Special_Bubble" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("LevelEditor/icons" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[6];
		array[0] = this.PKOAMLGGDDI;
		array[1] = "Texture2";
		array[4] = this.FONGIBAJEMO;
		array[8] = this.KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "float,50");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().ELMCDLKBCKK());
	}

	// Token: 0x0600ED1D RID: 60701 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x0600ED1E RID: 60702 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x0600ED1F RID: 60703 RVA: 0x00534CF8 File Offset: 0x00532EF8
	private void GPNAOAKCMHC()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "LastNewsButton";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "High" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Case-Sensitive" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[8];
		array[1] = this.PKOAMLGGDDI;
		array[1] = "[PlayerBase] ShowTitle error: ";
		array[7] = this.FONGIBAJEMO;
		array[5] = this.KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "_TimeX");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().CMENLDIKOGJ());
	}

	// Token: 0x0600ED20 RID: 60704 RVA: 0x00534DF4 File Offset: 0x00532FF4
	private void ODBNMPGBCGO()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "Items/";
			int cchNameBufferSize = 7;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "_Intensity" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("#random #common #item" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[7];
		array[1] = this.PKOAMLGGDDI;
		array[0] = " ";
		array[3] = this.FONGIBAJEMO;
		array[1] = this.KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "GhostFade2");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().NLOJOMGEGNG());
	}

	// Token: 0x0600ED21 RID: 60705 RVA: 0x00534EF0 File Offset: 0x005330F0
	private void LBAJLLFMMMP()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "sounds/no_hit";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "Editor/" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("0,1,true,0" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[1];
		array[0] = this.PKOAMLGGDDI;
		array[1] = "Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ";
		array[8] = this.FONGIBAJEMO;
		array[7] = this.KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "Joystick1Button6");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().MDCHJDCJHKJ());
	}

	// Token: 0x0600ED22 RID: 60706 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x0600ED23 RID: 60707 RVA: 0x00534FEC File Offset: 0x005331EC
	private void Start()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "public";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = " b." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("[BuildInfo] Error: " + ex.ToString());
		}
		this.EAFAMAMDNEG.text = string.Concat(new string[]
		{
			this.PKOAMLGGDDI,
			"\nv.",
			this.FONGIBAJEMO,
			this.KCJEFKBENKA,
			(!flag) ? string.Empty : " BETA"
		});
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	// Token: 0x0600ED24 RID: 60708 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x0600ED25 RID: 60709 RVA: 0x005350E8 File Offset: 0x005332E8
	private void KMCPMOGKDEH()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "_Value2";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "y" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("[MapsEditor] Creating new item..." + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[6];
		array[0] = this.PKOAMLGGDDI;
		array[1] = "Item created: Id: ";
		array[5] = this.FONGIBAJEMO;
		array[7] = this.KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "offsets");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().PBIPCILMAOC());
	}

	// Token: 0x0600ED26 RID: 60710 RVA: 0x005351E4 File Offset: 0x005333E4
	private void AGEJKLMJGDO()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "failed";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "MenuScene" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_ScreenResolution" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[3];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "input";
		array[7] = this.FONGIBAJEMO;
		array[1] = this.KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "UsernameText");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().ABEOMIHEDLN());
	}

	// Token: 0x0600ED27 RID: 60711 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x0600ED28 RID: 60712 RVA: 0x005352E0 File Offset: 0x005334E0
	private void KDMKDEKCELE()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "UseScanLineSize";
			int cchNameBufferSize = 0;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "duration" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Gameplay/particles" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[]
		{
			null,
			this.PKOAMLGGDDI
		};
		array[0] = "z";
		array[0] = this.FONGIBAJEMO;
		array[8] = this.KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : " user's map(s)");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().IPFKCJENGAC());
	}

	// Token: 0x0600ED29 RID: 60713 RVA: 0x005353DC File Offset: 0x005335DC
	private void JECMJNFGBGC()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "colorD";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "speed" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("GhostPosY" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[]
		{
			this.PKOAMLGGDDI,
			"LoadPlayerEnvironment",
			null,
			null,
			null,
			null,
			null,
			this.FONGIBAJEMO
		};
		array[2] = this.KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "[PlayerController] ");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().OAKKDDEAIBN());
	}

	// Token: 0x0600ED2A RID: 60714 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x0600ED2B RID: 60715 RVA: 0x005354D8 File Offset: 0x005336D8
	private void ICILLMAKLMI()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "visible";
			int cchNameBufferSize = 0;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "Jan" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Scrollbar" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[0];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "NEW_ACHIEVEMENT_1_";
		array[5] = this.FONGIBAJEMO;
		array[6] = this.KCJEFKBENKA;
		array[6] = ((!flag) ? string.Empty : "Save Game");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().IPFKCJENGAC());
	}

	// Token: 0x0600ED2C RID: 60716 RVA: 0x005355D4 File Offset: 0x005337D4
	private void JOPCCCCHNLI()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "The region arrays from Name Server are not ok. Must be non-null and same length. ";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "maps." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("CameraFilterPack/Drawing_Manga_FlashWhite" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[6];
		array[1] = this.PKOAMLGGDDI;
		array[1] = "_Value4";
		array[4] = this.FONGIBAJEMO;
		array[5] = this.KCJEFKBENKA;
		array[0] = ((!flag) ? string.Empty : "1.87");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().MDCHJDCJHKJ());
	}

	// Token: 0x0600ED2D RID: 60717 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600ED2E RID: 60718 RVA: 0x005356D0 File Offset: 0x005338D0
	private void BEBNOKFLJPH()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "EventMenu";
			int cchNameBufferSize = 2;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "_Value5" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("caret" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[6];
		array[1] = this.PKOAMLGGDDI;
		array[0] = "_TimeX";
		array[8] = this.FONGIBAJEMO;
		array[3] = this.KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "_Value10");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().ANKDOLLBGDD());
	}

	// Token: 0x0600ED2F RID: 60719 RVA: 0x005357CC File Offset: 0x005339CC
	private void PAKPHKPDKGE()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "{\"items\":";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "\r" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("#turnoninternet" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[4];
		array[1] = this.PKOAMLGGDDI;
		array[0] = " now: ";
		array[8] = this.FONGIBAJEMO;
		array[3] = this.KCJEFKBENKA;
		array[0] = ((!flag) ? string.Empty : "menu.selectedplaymode");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().IDPBCFBOBJP());
	}

	// Token: 0x0600ED30 RID: 60720 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x0600ED31 RID: 60721 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x0600ED32 RID: 60722 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x0600ED33 RID: 60723 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x0600ED34 RID: 60724 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x0600ED35 RID: 60725 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x0600ED36 RID: 60726 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x0600ED37 RID: 60727 RVA: 0x005358C8 File Offset: 0x00533AC8
	private void MMMDPANNAIO()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "CameraFilterPack/VHS_Tracking";
			int cchNameBufferSize = 2;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "Text" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("\\n" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[2];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "#tryagain";
		array[5] = this.FONGIBAJEMO;
		array[2] = this.KCJEFKBENKA;
		array[4] = ((!flag) ? string.Empty : "_TapHigh");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().ENGDDMDBGFH());
	}

	// Token: 0x0600ED38 RID: 60728 RVA: 0x005359C4 File Offset: 0x00533BC4
	private void PKLOBJHKFEO()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "_Value2";
			int cchNameBufferSize = 5;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "Exit to Windows" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Playing " + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[6];
		array[0] = this.PKOAMLGGDDI;
		array[1] = "<b>Speed</b>:";
		array[6] = this.FONGIBAJEMO;
		array[7] = this.KCJEFKBENKA;
		array[0] = ((!flag) ? string.Empty : "_CenterX");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().CMENLDIKOGJ());
	}

	// Token: 0x0600ED39 RID: 60729 RVA: 0x00535AC0 File Offset: 0x00533CC0
	private void HDMDKOKOOJC()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "#";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "_SoftZDistance" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("EnableRankedNotificationsToggle" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[4];
		array[1] = this.PKOAMLGGDDI;
		array[0] = "Waiting to start";
		array[7] = this.FONGIBAJEMO;
		array[4] = this.KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "CameraFilterPack/Atmosphere_Rain_Pro");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().ANKDOLLBGDD());
	}

	// Token: 0x0600ED3B RID: 60731 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x0600ED3C RID: 60732 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x0600ED3D RID: 60733 RVA: 0x00535BD0 File Offset: 0x00533DD0
	private void IDJKNBDKHBD()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "CameraFilterPack/Blend2Camera_LighterColor";
			int cchNameBufferSize = 3;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "RPCs can only be sent in rooms. Call of \"" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Saturation" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[3];
		array[1] = this.PKOAMLGGDDI;
		array[0] = "maps.";
		array[7] = this.FONGIBAJEMO;
		array[6] = this.KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "Set satellite radius (offset)");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().NOBOCGLGFFD());
	}

	// Token: 0x0600ED3E RID: 60734 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x0600ED3F RID: 60735 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x0600ED40 RID: 60736 RVA: 0x00535CCC File Offset: 0x00533ECC
	private void FEHCNJLLJMP()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = " left";
			int cchNameBufferSize = 1;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "[LevelEditorScene] Error: Timeout :S" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("itemdefid[0]" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[5];
		array[1] = this.PKOAMLGGDDI;
		array[0] = "_Value2";
		array[2] = this.FONGIBAJEMO;
		array[6] = this.KCJEFKBENKA;
		array[2] = ((!flag) ? string.Empty : "LoadingStatusText");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().PBIPCILMAOC());
	}

	// Token: 0x0600ED41 RID: 60737 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600ED42 RID: 60738 RVA: 0x00535DC8 File Offset: 0x00533FC8
	private void ANCKKLFPGDI()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "_DistortionSize";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = " does not exist!" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_ScreenResolution" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[6];
		array[1] = this.PKOAMLGGDDI;
		array[0] = "LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}";
		array[8] = this.FONGIBAJEMO;
		array[1] = this.KCJEFKBENKA;
		array[3] = ((!flag) ? string.Empty : "</i>");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().MDCHJDCJHKJ());
	}

	// Token: 0x0600ED43 RID: 60739 RVA: 0x00535EC4 File Offset: 0x005340C4
	private void DLBODOFAJGM()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "_Red_G";
			int cchNameBufferSize = 6;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "[Up-Down]" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("player.blackwhite" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[6];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "StartTime already set: ";
		array[3] = this.FONGIBAJEMO;
		array[5] = this.KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "Tab1Content");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().LCDKMHEGHJN());
	}

	// Token: 0x0600ED44 RID: 60740 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600ED45 RID: 60741 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x0600ED46 RID: 60742 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x0600ED47 RID: 60743 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x0600ED48 RID: 60744 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x0600ED49 RID: 60745 RVA: 0x00535FC0 File Offset: 0x005341C0
	private void EPEGAEGDJAM()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "event";
			int cchNameBufferSize = 1;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "_TimeX" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Object ID. Case-Sensitive" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[4];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "z";
		array[1] = this.FONGIBAJEMO;
		array[2] = this.KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "StartTime already set: ");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().MDDADJIHOJP());
	}

	// Token: 0x0600ED4A RID: 60746 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x0600ED4B RID: 60747 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x0600ED4C RID: 60748 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x0600ED4D RID: 60749 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x0600ED4E RID: 60750 RVA: 0x005360BC File Offset: 0x005342BC
	private void HIPEHGNBJMN()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "maps.";
			int cchNameBufferSize = 1;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "Horizontal" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Value4" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[4];
		array[1] = this.PKOAMLGGDDI;
		array[1] = "Add Environment Sprite";
		array[3] = this.FONGIBAJEMO;
		array[0] = this.KCJEFKBENKA;
		array[1] = ((!flag) ? string.Empty : "_Distortion");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().INFHBGJLHBH());
	}

	// Token: 0x0600ED4F RID: 60751 RVA: 0x005361B8 File Offset: 0x005343B8
	private void NPLCENPNJBM()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "_EmissionColor";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "Could not execute RPC " + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("FPSToggle" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[]
		{
			null,
			this.PKOAMLGGDDI
		};
		array[0] = "_TimeX";
		array[1] = this.FONGIBAJEMO;
		array[4] = this.KCJEFKBENKA;
		array[1] = ((!flag) ? string.Empty : "x");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
	}

	// Token: 0x0600ED50 RID: 60752 RVA: 0x005362B4 File Offset: 0x005344B4
	private void FHGKIOOMMOH()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "BlockSize";
			int cchNameBufferSize = 2;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "_Value2" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_Visualize" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[8];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "_Value2";
		array[5] = this.FONGIBAJEMO;
		array[7] = this.KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "selColor");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().DPCDAONEBPK());
	}

	// Token: 0x0600ED51 RID: 60753 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x0600ED52 RID: 60754 RVA: 0x005363B0 File Offset: 0x005345B0
	private void CFFCLAHMBAA()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = "CameraFilterPack/Vision_Plasma";
			int cchNameBufferSize = 8;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "," + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("UI Extensions/UIAdditive" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[8];
		array[0] = this.PKOAMLGGDDI;
		array[0] = "StartButton";
		array[2] = this.FONGIBAJEMO;
		array[8] = this.KCJEFKBENKA;
		array[1] = ((!flag) ? string.Empty : "[ImageLoader] Loaded image from ");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().IDPBCFBOBJP());
	}

	// Token: 0x0600ED53 RID: 60755 RVA: 0x005364AC File Offset: 0x005346AC
	private void CIPKEPDELJB()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = false;
		try
		{
			string text = ".lastCheckpoint.perfectHits";
			int cchNameBufferSize = 2;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = true;
			}
			this.KCJEFKBENKA = "MapEnd" + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("_ColorRGB" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[1];
		array[0] = this.PKOAMLGGDDI;
		array[1] = "ACCEPT";
		array[1] = this.FONGIBAJEMO;
		array[0] = this.KCJEFKBENKA;
		array[8] = ((!flag) ? string.Empty : "_DistortionSize");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().ENGDDMDBGFH());
	}

	// Token: 0x0600ED54 RID: 60756 RVA: 0x005365A8 File Offset: 0x005347A8
	private void FMFNILJIEIA()
	{
		this.EAFAMAMDNEG = base.GetComponent<Text>();
		this.PKOAMLGGDDI = this.EAFAMAMDNEG.text;
		this.FONGIBAJEMO = Helpers.GetGameVersion();
		bool flag = true;
		try
		{
			string text = "_Value3";
			int cchNameBufferSize = 0;
			if (SteamApps.GetCurrentBetaName(out text, cchNameBufferSize))
			{
				flag = false;
			}
			this.KCJEFKBENKA = "[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information." + SteamApps.GetAppBuildId();
		}
		catch (Exception ex)
		{
			Debug.Log("Set particles start speed" + ex.ToString());
		}
		Text eafamamdneg = this.EAFAMAMDNEG;
		string[] array = new string[4];
		array[1] = this.PKOAMLGGDDI;
		array[0] = "_ScreenResolution";
		array[7] = this.FONGIBAJEMO;
		array[6] = this.KCJEFKBENKA;
		array[7] = ((!flag) ? string.Empty : "Joystick1Button4");
		eafamamdneg.text = string.Concat(array);
		base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().COFOOEGOLFA());
	}

	// Token: 0x04001A92 RID: 6802
	private string FONGIBAJEMO = string.Empty;

	// Token: 0x04001A93 RID: 6803
	private Text EAFAMAMDNEG;

	// Token: 0x04001A94 RID: 6804
	private string PKOAMLGGDDI;

	// Token: 0x04001A95 RID: 6805
	private string KCJEFKBENKA;
}
