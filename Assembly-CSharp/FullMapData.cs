using System;
using System.Collections.Generic;
using System.Globalization;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x0200043F RID: 1087
[Serializable]
public class FullMapData
{
	// Token: 0x0600F7A7 RID: 63399 RVA: 0x005539E8 File Offset: 0x00551BE8
	public int PEJKDKHOAGL()
	{
		string hfefhopolik = "_FgOverlap" + Singleton<MapsSystem>.Instance.GetMapID(this) + "editorVolume";
		return Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hfefhopolik, 1, null);
	}

	// Token: 0x0600F7A8 RID: 63400 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool MGOOJGFIBIA()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7A9 RID: 63401 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool CIJHLOJPEGD()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7AA RID: 63402 RVA: 0x00553A50 File Offset: 0x00551C50
	public int EAEBLPBBMIF()
	{
		string hfefhopolik = "CameraFilterPack/Color_Sepia" + Singleton<MapsSystem>.Instance.GetMapID(this) + "PossibleMapMaxScoreText";
		return Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7AB RID: 63403 RVA: 0x00553A8C File Offset: 0x00551C8C
	public bool ALKOICIAKON()
	{
		bool flag = true;
		if (this.source == FullMapData.MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string[] array = text.Split(new char[]
				{
					(char)-38
				});
				if (array.Length == 4)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array[0], null))
					{
						string text2 = array[0];
						if (text2 == null)
						{
							goto IL_14F;
						}
						if (!(text2 == "AddEnvironmentSprite"))
						{
							if (!(text2 == "_Smooth"))
							{
								if (!(text2 == "_FarCamera"))
								{
									if (!(text2 == "Mid"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.GetString(array[1], null) != array[4])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[1], null) != ((!(array[5] == "player.xp")) ? 0 : 0))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.DHAINALDNBG(array[0], null) != float.Parse(array[1], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array[0], null) != int.Parse(array[5]))
						{
							flag = false;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array[0] == "{0}_{1}")
					{
						flag = false;
					}
					else
					{
						Debug.Log(" not exist" + array[1] + "_Value3");
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag && this.NLOMMLOEMFD())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7AC RID: 63404 RVA: 0x00553CA0 File Offset: 0x00551EA0
	public bool CDPJMPONHPP()
	{
		string hfefhopolik = "[LocalizationService] All languages: " + Singleton<MapsSystem>.Instance.GetMapID(this) + "_InvRenderTargetSize";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hfefhopolik, 1, null) != 0;
	}

	// Token: 0x0600F7AD RID: 63405 RVA: 0x00553CE8 File Offset: 0x00551EE8
	public bool BFDEKPGIMNH()
	{
		bool flag = true;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string[] array = text.Split(new char[]
				{
					(char)-95
				});
				if (array.Length == 5)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array[1], null))
					{
						string text2 = array[1];
						if (text2 == null)
						{
							goto IL_14F;
						}
						if (!(text2 == "Set satellite trail length in seconds"))
						{
							if (!(text2 == "[NetworkManager] Connected to "))
							{
								if (!(text2 == "[EditorEvent] Exception: "))
								{
									if (!(text2 == "RanksButton"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array[0], null) != array[5])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[0], null) != ((!(array[6] == "ConnectToMaster() disabled the offline mode. No longer offline.")) ? 0 : 1))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.PEBDFGFNFBE(array[0], null) != float.Parse(array[0], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array[1], null) != int.Parse(array[0]))
						{
							flag = false;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array[0] == "{0}sec average:")
					{
						flag = true;
					}
					else
					{
						Debug.Log("EventTimeInputField" + array[0] + "_Distortion");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.DKPIPGNIILL())
			{
				flag = false;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7AE RID: 63406 RVA: 0x00553EFC File Offset: 0x005520FC
	public bool OMGDEIDPPJO()
	{
		string hfefhopolik = "GlassesColor2" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "<b>#";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hfefhopolik, 1, null) == 1 && false;
	}

	// Token: 0x0600F7AF RID: 63407 RVA: 0x00553F44 File Offset: 0x00552144
	public int OEBJCMGAKIG()
	{
		string hfefhopolik = "RB" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "{0} hours ago";
		return Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7B0 RID: 63408 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool PJDJCGKHEIC()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7B1 RID: 63409 RVA: 0x00553F80 File Offset: 0x00552180
	public int HFFDDPCGKGE()
	{
		string hfefhopolik = "SpeedSlider" + Singleton<MapsSystem>.Instance.GetMapID(this) + "CONTRAST";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hfefhopolik, 1, null);
	}

	// Token: 0x0600F7B2 RID: 63410 RVA: 0x00553FBC File Offset: 0x005521BC
	public bool MLDFFCPMHHF()
	{
		bool flag = true;
		if (this.source == FullMapData.MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[0];
				array[0] = '}';
				string[] array2 = text2.Split(array);
				if (array2.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array2[0], null))
					{
						string text3 = array2[1];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "MainButton"))
						{
							if (!(text3 == "NEW_ACHIEVEMENT_1_21"))
							{
								if (!(text3 == "_Near"))
								{
									if (!(text3 == "workshop."))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[0], null) != array2[1])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[1], null) != ((!(array2[1] == "_ScreenResolution")) ? 0 : 1))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.GetFloat(array2[0], null) != float.Parse(array2[3], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[1], null) != int.Parse(array2[4]))
						{
							flag = false;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array2[0] == "[ItemsHandler] No connection to item server: ")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_PrefilterOffs" + array2[0] + "#ok");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.BLDMPJOMGDN())
			{
				flag = false;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7B3 RID: 63411 RVA: 0x005541D0 File Offset: 0x005523D0
	public bool PKLOGJMINMG()
	{
		return this.mapData == null || !(this.icon != null) || this.clip != null;
	}

	// Token: 0x0600F7B4 RID: 63412 RVA: 0x00554200 File Offset: 0x00552400
	public bool PMFLELFGPJO()
	{
		string hfefhopolik = "Y" + Singleton<MapsSystem>.Instance.GetMapID(this) + " not exist";
		return Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hfefhopolik, 1, null) != 0;
	}

	// Token: 0x0600F7B5 RID: 63413 RVA: 0x005541D0 File Offset: 0x005523D0
	public bool MBJKBLDPIGJ()
	{
		return this.mapData == null || !(this.icon != null) || this.clip != null;
	}

	// Token: 0x0600F7B6 RID: 63414 RVA: 0x00554248 File Offset: 0x00552448
	public int BOPGHGGEAMP()
	{
		string hfefhopolik = "Editor" + Singleton<MapsSystem>.Instance.GetMapID(this) + "MapConfig";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hfefhopolik, 1, null);
	}

	// Token: 0x0600F7B7 RID: 63415 RVA: 0x00554284 File Offset: 0x00552484
	public bool CCBCIPKOBAF()
	{
		bool flag = true;
		if (this.source == FullMapData.MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[0];
				array[1] = (char)-46;
				string[] array2 = text2.Split(array);
				if (array2.Length == 7)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[0], null))
					{
						string text3 = array2[1];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "workshop."))
						{
							if (!(text3 == "Set sun emission (glow)"))
							{
								if (!(text3 == "Sent count: "))
								{
									if (!(text3 == "skin.hit_perfect"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.NBMEANCMGEH(array2[1], null) != array2[8])
									{
										flag = true;
									}
								}
								else if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array2[1], null) != ((!(array2[8] == "LeaderboardsButton")) ? 0 : 0))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.GetFloat(array2[1], null) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array2[1], null) != int.Parse(array2[6]))
						{
							flag = false;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array2[1] == "CHROMATIC_ABERRATION")
					{
						flag = false;
					}
					else
					{
						Debug.Log(". We have no such PhotonView! Ignored this if you're leaving a room. State: " + array2[1] + "CameraFilterPack/Deep_OilPaintHQ");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.MDKFJHPDIKB())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7B8 RID: 63416 RVA: 0x00554498 File Offset: 0x00552698
	public bool OCEJPDINCLF()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string[] array = text.Split(new char[]
				{
					'\b'
				});
				if (array.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array[0], null))
					{
						string text2 = array[1];
						if (text2 == null)
						{
							goto IL_14F;
						}
						if (!(text2 == "CameraFilterPack/Color_Switching"))
						{
							if (!(text2 == " is muted"))
							{
								if (!(text2 == "_PosY"))
								{
									if (!(text2 == "Move environment object to the position"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.GetString(array[0], null) != array[0])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[1], null) != ((!(array[2] == "_Visualize")) ? 0 : 0))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.PEBDFGFNFBE(array[1], null) != float.Parse(array[8], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array[1], null) != int.Parse(array[3]))
						{
							flag = false;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array[1] == "CrosshairOpacitySlider")
					{
						flag = true;
					}
					else
					{
						Debug.Log("--------------------------------" + array[0] + "[PlayerController] ");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.HMKCHDJOHBP())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7B9 RID: 63417 RVA: 0x005546AC File Offset: 0x005528AC
	public bool JKCNBMOJNIG()
	{
		string hfefhopolik = "_Value4" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "RULES";
		return Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hfefhopolik, 0, null) != 0 || true;
	}

	// Token: 0x0600F7BA RID: 63418 RVA: 0x005541D0 File Offset: 0x005523D0
	public bool KPMGJOPLNAO()
	{
		return this.mapData == null || !(this.icon != null) || this.clip != null;
	}

	// Token: 0x0600F7BB RID: 63419 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool FNJACLINNAP()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7BC RID: 63420 RVA: 0x005546F4 File Offset: 0x005528F4
	public bool FOBKMKFNKKD()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string[] array = text.Split(new char[]
				{
					(char)-103
				});
				if (array.Length == 1)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array[1], null))
					{
						string text2 = array[0];
						if (text2 == null)
						{
							goto IL_14F;
						}
						if (!(text2 == "Result for "))
						{
							if (!(text2 == "SelectorMapsCountSlider"))
							{
								if (!(text2 == "#rt"))
								{
									if (!(text2 == "RoomNameText"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.CFLCJCJHNKD(array[1], null) != array[8])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.GetInt(array[1], null) != ((!(array[0] == "BitsData")) ? 1 : 0))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.PEBDFGFNFBE(array[1], null) != float.Parse(array[1], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.GetInt(array[0], null) != int.Parse(array[8]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array[0] == "_AdaptParams")
					{
						flag = false;
					}
					else
					{
						Debug.Log("Skipping EstablishEncryption. Protocol is secure." + array[0] + "Ok");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag && this.HMKCHDJOHBP())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7BD RID: 63421 RVA: 0x00554908 File Offset: 0x00552B08
	public bool NLOMMLOEMFD()
	{
		string hfefhopolik = "ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster." + Singleton<MapsSystem>.Instance.GetMapID(this) + "BadgeText";
		return Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null) != 1;
	}

	// Token: 0x0600F7BE RID: 63422 RVA: 0x00554950 File Offset: 0x00552B50
	public bool LNEHFGGGCBG()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return false;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[0];
				array[1] = (char)-22;
				string[] array2 = text2.Split(array);
				if (array2.Length == 5)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array2[0], null))
					{
						string text3 = array2[0];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "Despawn environment object by id"))
						{
							if (!(text3 == "{}"))
							{
								if (!(text3 == "CameraFilterPack_VHS2"))
								{
									if (!(text3 == "mapselector.filter.favoriteonly"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[0], null) != array2[1])
									{
										flag = true;
									}
								}
								else if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array2[0], null) != ((!(array2[5] == "_Distortion")) ? 0 : 0))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.DHAINALDNBG(array2[1], null) != float.Parse(array2[5], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[1], null) != int.Parse(array2[5]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array2[1] == "maps.")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Value" + array2[1] + "CameraFilterPack/Blend2Camera_HardLight");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag && this.PMFLELFGPJO())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7BF RID: 63423 RVA: 0x00554B64 File Offset: 0x00552D64
	public bool LJDJLGHOHLE()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return false;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[1];
				array[1] = 'p';
				string[] array2 = text2.Split(array);
				if (array2.Length == 2)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array2[0], null))
					{
						string text3 = array2[0];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "{0}sec average:"))
						{
							if (!(text3 == "_Distortion"))
							{
								if (!(text3 == "HitInRelaxMusicToggle"))
								{
									if (!(text3 == "_Value"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.ELHODPGACDI(array2[0], null) != array2[6])
									{
										flag = true;
									}
								}
								else if (Singleton<SaveSystem>.Instance.GetInt(array2[0], null) != ((!(array2[2] == "In Main Menu")) ? 0 : 0))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.KIKJOOJFIJK(array2[0], null) != float.Parse(array2[1], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.GetInt(array2[1], null) != int.Parse(array2[4]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array2[0] == "HandsCountSlider")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_ChangeRed" + array2[1] + "[");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.JKCNBMOJNIG())
			{
				flag = false;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7C0 RID: 63424 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool OCAIILGBCIL()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7C1 RID: 63425 RVA: 0x00554D78 File Offset: 0x00552F78
	public int MODGBDKBPFH()
	{
		string hfefhopolik = "value" + Singleton<MapsSystem>.Instance.GetMapID(this) + "checkpoint";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hfefhopolik, 1, null);
	}

	// Token: 0x0600F7C2 RID: 63426 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool MPFNDFFDLEE()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7C3 RID: 63427 RVA: 0x00554DB4 File Offset: 0x00552FB4
	public bool OKMHKMIOAOL()
	{
		bool flag = true;
		if (this.source == FullMapData.MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[0];
				array[0] = 'h';
				string[] array2 = text2.Split(array);
				if (array2.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array2[0], null))
					{
						string text3 = array2[1];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "_TimeX"))
						{
							if (!(text3 == "D-Pad Up"))
							{
								if (!(text3 == "_VignetteTex"))
								{
									if (!(text3 == "[Right]"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.ELHODPGACDI(array2[0], null) != array2[8])
									{
										flag = true;
									}
								}
								else if (Singleton<SaveSystem>.Instance.GetInt(array2[1], null) != ((!(array2[2] == "Keeping GameObject in the scene: ")) ? 0 : 1))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.KIKJOOJFIJK(array2[0], null) != float.Parse(array2[4], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[1], null) != int.Parse(array2[0]))
						{
							flag = false;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array2[0] == "_TimeX")
					{
						flag = true;
					}
					else
					{
						Debug.Log("_Intensity" + array2[0] + "_TimeX");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag && this.NEOLBDBDGHC())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7C4 RID: 63428 RVA: 0x00554FC8 File Offset: 0x005531C8
	public bool DHEEIODOKHO()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string[] array = text.Split(new char[]
				{
					'x'
				});
				if (array.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array[1], null))
					{
						string text2 = array[1];
						if (text2 == null)
						{
							goto IL_14F;
						}
						if (!(text2 == "InfoText"))
						{
							if (!(text2 == " or "))
							{
								if (!(text2 == "_MainTex2"))
								{
									if (!(text2 == "_BlurParams"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array[1], null) != array[0])
									{
										flag = true;
									}
								}
								else if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array[1], null) != ((!(array[7] == "#forever")) ? 0 : 1))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.PEBDFGFNFBE(array[1], null) != float.Parse(array[5], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.GetInt(array[1], null) != int.Parse(array[3]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array[1] == "_Green_G")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Green_B" + array[1] + "_ReflectionTexture0");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.PIPAOGHLBEK())
			{
				flag = false;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7C5 RID: 63429 RVA: 0x005551DC File Offset: 0x005533DC
	public int GACJAKOPOMH()
	{
		string hfefhopolik = "Editor/" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "gold";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hfefhopolik, 1, null);
	}

	// Token: 0x0600F7C6 RID: 63430 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool isLoaded()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7C7 RID: 63431 RVA: 0x005541D0 File Offset: 0x005523D0
	public bool CNFFJELPCPN()
	{
		return this.mapData == null || !(this.icon != null) || this.clip != null;
	}

	// Token: 0x0600F7C8 RID: 63432 RVA: 0x005541D0 File Offset: 0x005523D0
	public bool ECBBEOAIGEJ()
	{
		return this.mapData == null || !(this.icon != null) || this.clip != null;
	}

	// Token: 0x0600F7C9 RID: 63433 RVA: 0x00555218 File Offset: 0x00553418
	public bool OFMOFIFNKBI()
	{
		bool flag = true;
		if (this.source == FullMapData.MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string[] array = text.Split(new char[]
				{
					'\0'
				});
				if (array.Length == 0)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array[0], null))
					{
						string text2 = array[1];
						if (text2 == null)
						{
							goto IL_14F;
						}
						if (!(text2 == "Xbox Home"))
						{
							if (!(text2 == "CameraFilterPack/3D_Mirror"))
							{
								if (!(text2 == ","))
								{
									if (!(text2 == "#91CCFF"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.IPEDKOMAKPP(array[1], null) != array[4])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[1], null) != ((!(array[3] == "ResetButton")) ? 0 : 1))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.HLPKNPJIHKM(array[1], null) != float.Parse(array[6], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
						}
						else if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array[1], null) != int.Parse(array[7]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array[1] == ". Going to authenticate anyways.")
					{
						flag = true;
					}
					else
					{
						Debug.Log("_Distortion" + array[0] + "_Value2");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.PIPAOGHLBEK())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7CA RID: 63434 RVA: 0x0055542C File Offset: 0x0055362C
	public bool DKPIPGNIILL()
	{
		string hfefhopolik = "CameraFilterPack/Blend2Camera_Exclusion" + Singleton<MapsSystem>.Instance.GetMapID(this) + ": ";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hfefhopolik, 1, null) == 0 && false;
	}

	// Token: 0x0600F7CB RID: 63435 RVA: 0x00555474 File Offset: 0x00553674
	public int PlayedCount()
	{
		string hfefhopolik = "maps." + Singleton<MapsSystem>.Instance.GetMapID(this) + ".played";
		return Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7CC RID: 63436 RVA: 0x005554B0 File Offset: 0x005536B0
	public bool LEOIFKNDNJH()
	{
		string hfefhopolik = ":</b> " + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "CameraFilterPack/Atmosphere_Rain";
		return Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null) != 0 || true;
	}

	// Token: 0x0600F7CD RID: 63437 RVA: 0x005554F8 File Offset: 0x005536F8
	public int ECIODFMIBHD()
	{
		string hfefhopolik = "maps." + Singleton<MapsSystem>.Instance.GetMapID(this) + "Netw. Sim.";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7CE RID: 63438 RVA: 0x00555534 File Offset: 0x00553734
	public bool ADBIEAHEION()
	{
		string hfefhopolik = "[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "From {0} at Index {1} \n";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hfefhopolik, 1, null) != 0 || true;
	}

	// Token: 0x0600F7CF RID: 63439 RVA: 0x0055557C File Offset: 0x0055377C
	public bool DJOFFCOAKHO()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[1];
				array[1] = (char)-64;
				string[] array2 = text2.Split(array);
				if (array2.Length == 7)
				{
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array2[1], null))
					{
						string text3 = array2[0];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "End Value should be greater than the start value, values not changed"))
						{
							if (!(text3 == "CameraFilterPack/Blend2Camera_GreenScreen"))
							{
								if (!(text3 == "settings.volume.game"))
								{
									if (!(text3 == "_SpawnHeuristic"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[0], null) != array2[7])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[0], null) != ((!(array2[2] == "player.redarc")) ? 0 : 0))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.DHAINALDNBG(array2[0], null) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[0], null) != int.Parse(array2[2]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array2[1] == "[PhotonMessageInfo: Sender='{1}' Senttime={0}]")
					{
						flag = true;
					}
					else
					{
						Debug.Log("System.Int64" + array2[0] + " cannot be used as a 3D LUT.");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.PMFLELFGPJO())
			{
				flag = false;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7D0 RID: 63440 RVA: 0x00555790 File Offset: 0x00553990
	public bool PNEDDBEECLL()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string[] array = text.Split(new char[]
				{
					'u'
				});
				if (array.Length == 8)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array[0], null))
					{
						string text2 = array[1];
						if (text2 == null)
						{
							goto IL_14F;
						}
						if (!(text2 == "_FixDistance"))
						{
							if (!(text2 == "CameraFilterPack_Atmosphere_Rain_FX"))
							{
								if (!(text2 == "CameraFilterPack/Glasses_OnX"))
								{
									if (!(text2 == "_TimeX"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.CFLCJCJHNKD(array[0], null) != array[5])
									{
										flag = true;
									}
								}
								else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[1], null) != ((!(array[6] == "file://")) ? 0 : 1))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.PEBDFGFNFBE(array[0], null) != float.Parse(array[3], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[0], null) != int.Parse(array[4]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array[1] == "_HighlightSuppression")
					{
						flag = true;
					}
					else
					{
						Debug.Log("CameraFilterPack/TV_Vcr" + array[0] + "Set Object Position");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.NEOLBDBDGHC())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7D1 RID: 63441 RVA: 0x005559A4 File Offset: 0x00553BA4
	public int IONLHCPKHHH()
	{
		string hfefhopolik = " This is not possible to be called for standalone input. Please check your platform and code where this is called" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_BlurPass";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hfefhopolik, 1, null);
	}

	// Token: 0x0600F7D2 RID: 63442 RVA: 0x005559E0 File Offset: 0x00553BE0
	public bool NEOLBDBDGHC()
	{
		string hfefhopolik = "Message duration multiplier. Recomended 1" + Singleton<MapsSystem>.Instance.GetMapID(this) + "/";
		return Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hfefhopolik, 0, null) == 0;
	}

	// Token: 0x0600F7D3 RID: 63443 RVA: 0x00555A28 File Offset: 0x00553C28
	public FullMapData(MapData CLCBMMEKBBC, string FJDHGDHKNNG, FullMapData.MapSource HLBKCLPNHEB, Sprite BBFDELDIDOG, AudioClip BKGCLBJFADE, bool IGHBADHOACF, Dictionary<string, UnityEngine.Object> CJFFPFEHNFI, string IJHEEPGHPBJ = null, ulong CDAGKANOOHO = 0UL)
	{
		this.mapData = CLCBMMEKBBC;
		this.fullLevelPath = FJDHGDHKNNG;
		this.source = HLBKCLPNHEB;
		this.icon = BBFDELDIDOG;
		this.clip = BKGCLBJFADE;
		this.resources = CJFFPFEHNFI;
		this.workshopId = IJHEEPGHPBJ;
		this.mapperSteamID = CDAGKANOOHO;
	}

	// Token: 0x0600F7D4 RID: 63444 RVA: 0x00555A94 File Offset: 0x00553C94
	public bool HELOOLFBJFP()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[0];
				array[0] = '\n';
				string[] array2 = text2.Split(array);
				if (array2.Length == 2)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[1], null))
					{
						string text3 = array2[0];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "VIGNETTE_DESAT"))
						{
							if (!(text3 == "ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms"))
							{
								if (!(text3 == "UpdateNewsTileStart"))
								{
									if (!(text3 == "[Up]"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.IPEDKOMAKPP(array2[0], null) != array2[5])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array2[1], null) != ((!(array2[6] == "CameraFilterPack_Atmosphere_Rain_FX")) ? 1 : 0))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.GLDCKMNIIDE(array2[1], null) != float.Parse(array2[4], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array2[0], null) != int.Parse(array2[0]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array2[1] == "_ScreenResolution")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Value3" + array2[1] + "Tab2Content");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.HMKCHDJOHBP())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7D5 RID: 63445 RVA: 0x00555CA8 File Offset: 0x00553EA8
	public bool KLNEJBEJFIG()
	{
		string hfefhopolik = "CameraFilterPack/Vision_Warp" + Singleton<MapsSystem>.Instance.GetMapID(this) + "Curve texture";
		return Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hfefhopolik, 1, null) == 1;
	}

	// Token: 0x0600F7D6 RID: 63446 RVA: 0x00555CF0 File Offset: 0x00553EF0
	public bool EBOCANCDINH()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[0];
				array[1] = '/';
				string[] array2 = text2.Split(array);
				if (array2.Length == 8)
				{
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array2[0], null))
					{
						string text3 = array2[1];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "_Value3"))
						{
							if (!(text3 == "Spawn new environment object (sun, satellite etc) and sets its id"))
							{
								if (!(text3 == "_TimeX"))
								{
									if (!(text3 == "offsets"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.IPEDKOMAKPP(array2[0], null) != array2[1])
									{
										flag = true;
									}
								}
								else if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[0], null) != ((!(array2[8] == "_MainTex2")) ? 0 : 0))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.DHAINALDNBG(array2[0], null) != float.Parse(array2[8], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[0], null) != int.Parse(array2[7]))
						{
							flag = false;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array2[0] == "_EmissionColor")
					{
						flag = false;
					}
					else
					{
						Debug.Log("/" + array2[1] + "challenges.");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag && this.HMKCHDJOHBP())
			{
				flag = false;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7D7 RID: 63447 RVA: 0x00555F04 File Offset: 0x00554104
	public bool HMKCHDJOHBP()
	{
		string hfefhopolik = "CameraFilterPack/Colors_HUE_Rotate" + Singleton<MapsSystem>.Instance.GetMapID(this) + "player.lollipop";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hfefhopolik, 1, null) == 0 && false;
	}

	// Token: 0x0600F7D8 RID: 63448 RVA: 0x00555F4C File Offset: 0x0055414C
	public bool isLevelCompleted()
	{
		string hfefhopolik = "maps." + Singleton<MapsSystem>.Instance.GetMapID(this) + ".completed";
		return Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null) == 1;
	}

	// Token: 0x0600F7D9 RID: 63449 RVA: 0x00555F94 File Offset: 0x00554194
	public bool ANOAPDBPHEJ()
	{
		string hfefhopolik = "_ScreenResolution" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_TimeX";
		return Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null) == 0 && false;
	}

	// Token: 0x0600F7DA RID: 63450 RVA: 0x005541D0 File Offset: 0x005523D0
	public bool ILGNBBPJEAL()
	{
		return this.mapData == null || !(this.icon != null) || this.clip != null;
	}

	// Token: 0x0600F7DB RID: 63451 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool ALFACFFDNLM()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7DC RID: 63452 RVA: 0x00555FDC File Offset: 0x005541DC
	public int FJBBONCHGGP()
	{
		string hfefhopolik = "Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages." + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "_Value1";
		return Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hfefhopolik, 1, null);
	}

	// Token: 0x0600F7DD RID: 63453 RVA: 0x00556018 File Offset: 0x00554218
	public bool NGILJKKGOCI()
	{
		bool flag = true;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[0];
				array[1] = 'l';
				string[] array2 = text2.Split(array);
				if (array2.Length == 6)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[1], null))
					{
						string text3 = array2[0];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "_Value6"))
						{
							if (!(text3 == "player.russia"))
							{
								if (!(text3 == "..."))
								{
									if (!(text3 == "float,0"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.IPEDKOMAKPP(array2[1], null) != array2[3])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[0], null) != ((!(array2[4] == "]")) ? 1 : 0))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.HLPKNPJIHKM(array2[0], null) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[0], null) != int.Parse(array2[3]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array2[1] == ".png")
					{
						flag = false;
					}
					else
					{
						Debug.Log(" not exist" + array2[1] + "id");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.NLOMMLOEMFD())
			{
				flag = false;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7DE RID: 63454 RVA: 0x0055622C File Offset: 0x0055442C
	public bool MDKFJHPDIKB()
	{
		string hfefhopolik = "value" + Singleton<MapsSystem>.Instance.GetMapID(this) + "SetPlayerDistance";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hfefhopolik, 1, null) == 1 && false;
	}

	// Token: 0x0600F7DF RID: 63455 RVA: 0x00556274 File Offset: 0x00554474
	public bool ENDBLADJEAN()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[1];
				array[1] = (char)-66;
				string[] array2 = text2.Split(array);
				if (array2.Length == 0)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array2[0], null))
					{
						string text3 = array2[1];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "DPADHOR"))
						{
							if (!(text3 == "_MaxBlurRadius"))
							{
								if (!(text3 == "SetRoomStartTimestamp"))
								{
									if (!(text3 == "RarityImage"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[0], null) != array2[8])
									{
										flag = true;
									}
								}
								else if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array2[0], null) != ((!(array2[4] == ".g")) ? 0 : 0))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.KIKJOOJFIJK(array2[1], null) != float.Parse(array2[0], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[0], null) != int.Parse(array2[0]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array2[1] == "_TimeX")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_TimeX" + array2[0] + "[NetworkManager] roomInfo.name: ");
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag && this.NEOLBDBDGHC())
			{
				flag = false;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7E0 RID: 63456 RVA: 0x00556488 File Offset: 0x00554688
	public FullMapData(FullMapData FICNDPKIGND)
	{
		this.mapData = new MapData(FICNDPKIGND.mapData);
		this.fullLevelPath = FICNDPKIGND.fullLevelPath;
		this.source = FICNDPKIGND.source;
		this.icon = FICNDPKIGND.icon;
		this.clip = FICNDPKIGND.clip;
		this.resources = new Dictionary<string, UnityEngine.Object>(FICNDPKIGND.resources.Count);
		foreach (KeyValuePair<string, UnityEngine.Object> keyValuePair in FICNDPKIGND.resources)
		{
			this.resources.Add(keyValuePair.Key, keyValuePair.Value);
		}
		this.workshopId = FICNDPKIGND.workshopId;
		this.mapperSteamID = FICNDPKIGND.mapperSteamID;
	}

	// Token: 0x0600F7E1 RID: 63457 RVA: 0x00556584 File Offset: 0x00554784
	public int PJPELKFHJHD()
	{
		string hfefhopolik = "UseScanLineSize" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "[PlayerBase] SetPlayerDistance error: ";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7E2 RID: 63458 RVA: 0x005565C0 File Offset: 0x005547C0
	public int DIKHIJIFJGM()
	{
		string hfefhopolik = "turn" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "_MainTex2";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7E3 RID: 63459 RVA: 0x005541D0 File Offset: 0x005523D0
	public bool LFNHEMDIAFA()
	{
		return this.mapData == null || !(this.icon != null) || this.clip != null;
	}

	// Token: 0x0600F7E4 RID: 63460 RVA: 0x005565FC File Offset: 0x005547FC
	public int EIJOBPLFDEI()
	{
		string hfefhopolik = "Editor/" + Singleton<MapsSystem>.Instance.GetMapID(this) + "Tab2Content";
		return Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 1, null);
	}

	// Token: 0x0600F7E5 RID: 63461 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool MEAEFNFILMP()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7E6 RID: 63462 RVA: 0x00556638 File Offset: 0x00554838
	public int JHIPKBIECOL()
	{
		string hfefhopolik = "shader.future" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7E7 RID: 63463 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool POJFNMCAJAC()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7E8 RID: 63464 RVA: 0x00556674 File Offset: 0x00554874
	public bool KDKMPKPGLJI()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[0];
				array[0] = 'G';
				string[] array2 = text2.Split(array);
				if (array2.Length == 0)
				{
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array2[0], null))
					{
						string text3 = array2[0];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "_SoftZDistance"))
						{
							if (!(text3 == "Set Particles Color"))
							{
								if (!(text3 == "Hidden/Subpixel Morphological Anti-aliasing"))
								{
									if (!(text3 == "[Right]"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.ELHODPGACDI(array2[0], null) != array2[3])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.GetInt(array2[0], null) != ((!(array2[5] == "_TimeX")) ? 0 : 0))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.DHAINALDNBG(array2[1], null) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array2[1], null) != int.Parse(array2[2]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array2[1] == "_Distance")
					{
						flag = true;
					}
					else
					{
						Debug.Log("cipherText" + array2[0] + "s");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag && this.PIPAOGHLBEK())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7E9 RID: 63465 RVA: 0x00556888 File Offset: 0x00554A88
	public bool HKEMIPBLILH()
	{
		string hfefhopolik = "_EdgeSharpness" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "shader.frost";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hfefhopolik, 1, null) == 1 && false;
	}

	// Token: 0x0600F7EA RID: 63466 RVA: 0x005568D0 File Offset: 0x00554AD0
	public int LLKCKLNCINB()
	{
		string hfefhopolik = "CameraFilterPack/Light_Rainbow2" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Value2";
		return Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hfefhopolik, 1, null);
	}

	// Token: 0x0600F7EB RID: 63467 RVA: 0x0055690C File Offset: 0x00554B0C
	public bool DPMPIPOCALF()
	{
		bool flag = true;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string[] array = text.Split(new char[]
				{
					(char)-15
				});
				if (array.Length == 1)
				{
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array[1], null))
					{
						string text2 = array[1];
						if (text2 == null)
						{
							goto IL_14F;
						}
						if (!(text2 == "Hex value #RRGGBB"))
						{
							if (!(text2 == " joined"))
							{
								if (!(text2 == "_Near"))
								{
									if (!(text2 == "_BlurVector"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array[0], null) != array[2])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array[0], null) != ((!(array[7] == "_TimeX")) ? 1 : 0))
								{
									flag = true;
								}
							}
							else if (Singleton<SaveSystem>.Instance.KIKJOOJFIJK(array[0], null) != float.Parse(array[2], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array[1], null) != int.Parse(array[2]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array[0] == "#discord{0}joinrequest")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Green_B" + array[0] + "ItemsStoreButton");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.ANOAPDBPHEJ())
			{
				flag = false;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7EC RID: 63468 RVA: 0x00556B20 File Offset: 0x00554D20
	public bool PIPAOGHLBEK()
	{
		string hfefhopolik = "Playing " + Singleton<MapsSystem>.Instance.GetMapID(this) + "/../";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hfefhopolik, 0, null) == 1;
	}

	// Token: 0x0600F7ED RID: 63469 RVA: 0x00556B68 File Offset: 0x00554D68
	public bool IJALKKJMGKB()
	{
		string hfefhopolik = " " + Singleton<MapsSystem>.Instance.GetMapID(this) + "0.00";
		return Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hfefhopolik, 1, null) != 0;
	}

	// Token: 0x0600F7EE RID: 63470 RVA: 0x00556BB0 File Offset: 0x00554DB0
	public int NMGNOGDAJBM()
	{
		string hfefhopolik = "Keeping GameObject in the scene: " + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "_Value3";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7EF RID: 63471 RVA: 0x005541D0 File Offset: 0x005523D0
	public bool DLAPKAHEACC()
	{
		return this.mapData == null || !(this.icon != null) || this.clip != null;
	}

	// Token: 0x0600F7F0 RID: 63472 RVA: 0x00556BEC File Offset: 0x00554DEC
	public int EEPMDAPCLAA()
	{
		string hfefhopolik = "float,2" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "_Visualize";
		return Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7F1 RID: 63473 RVA: 0x00553A21 File Offset: 0x00551C21
	public bool DDEFCGDKGNJ()
	{
		return this.mapData != null && this.icon != null && this.clip != null;
	}

	// Token: 0x0600F7F2 RID: 63474 RVA: 0x00556C28 File Offset: 0x00554E28
	public int GGMOOLJNBJH()
	{
		string hfefhopolik = "PlayMusic" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Offsets";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7F3 RID: 63475 RVA: 0x00556C64 File Offset: 0x00554E64
	public int KKDAFANMBAI()
	{
		string hfefhopolik = "Left Stick Click" + Singleton<MapsSystem>.Instance.GetMapID(this) + "inventory.itemscash";
		return Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hfefhopolik, 0, null);
	}

	// Token: 0x0600F7F4 RID: 63476 RVA: 0x00556CA0 File Offset: 0x00554EA0
	public bool GMMJNEOCBPI()
	{
		bool flag = true;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return false;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[0];
				array[0] = (char)-96;
				string[] array2 = text2.Split(array);
				if (array2.Length == 7)
				{
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array2[1], null))
					{
						string text3 = array2[0];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "[DiscordController] Shutdown"))
						{
							if (!(text3 == "[Left]"))
							{
								if (!(text3 == "BitsData"))
								{
									if (!(text3 == "OperationResponse unhandled: {0}"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.CFLCJCJHNKD(array2[0], null) != array2[5])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[1], null) != ((!(array2[2] == "LoadingStatusText")) ? 0 : 0))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.EJEGKIDILDJ(array2[1], null) != float.Parse(array2[7], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[1], null) != int.Parse(array2[5]))
						{
							flag = true;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array2[0] == "The given 2D texture ")
					{
						flag = true;
					}
					else
					{
						Debug.Log("OK" + array2[1] + "_Value3");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.MDKFJHPDIKB())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7F5 RID: 63477 RVA: 0x00556EB4 File Offset: 0x005550B4
	public bool isUnlocked()
	{
		bool flag = true;
		if (this.source == FullMapData.MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string[] array = text.Split(new char[]
				{
					','
				});
				if (array.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array[0], null))
					{
						string text2 = array[1];
						if (text2 == null)
						{
							goto IL_14F;
						}
						if (!(text2 == "int"))
						{
							if (!(text2 == "float"))
							{
								if (!(text2 == "bool"))
								{
									if (!(text2 == "string"))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.GetString(array[0], null) != array[2])
									{
										flag = false;
									}
								}
								else if (Singleton<SaveSystem>.Instance.GetInt(array[0], null) != ((!(array[2] == "true")) ? 0 : 1))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.GetFloat(array[0], null) != float.Parse(array[2], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
						}
						else if (Singleton<SaveSystem>.Instance.GetInt(array[0], null) != int.Parse(array[2]))
						{
							flag = false;
						}
						continue;
						IL_14F:
						flag = false;
					}
					else if (array[1] == "bool")
					{
						flag = false;
					}
					else
					{
						Debug.Log("[MapsData] Key " + array[0] + " not found");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.isLevelCompleted())
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7F6 RID: 63478 RVA: 0x005570C8 File Offset: 0x005552C8
	public bool FOAKIJPOHEH()
	{
		bool flag = false;
		if (this.source == FullMapData.MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string text in this.mapData.unlockConditions)
			{
				string text2 = text;
				char[] array = new char[1];
				array[1] = (char)-15;
				string[] array2 = text2.Split(array);
				if (array2.Length == 0)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array2[0], null))
					{
						string text3 = array2[0];
						if (text3 == null)
						{
							goto IL_14F;
						}
						if (!(text3 == "_Value2"))
						{
							if (!(text3 == "_Value"))
							{
								if (!(text3 == ".a"))
								{
									if (!(text3 == " Owner called."))
									{
										goto IL_14F;
									}
									if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[1], null) != array2[3])
									{
										flag = true;
									}
								}
								else if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[0], null) != ((!(array2[2] == "Added event")) ? 0 : 1))
								{
									flag = false;
								}
							}
							else if (Singleton<SaveSystem>.Instance.GetFloat(array2[1], null) != float.Parse(array2[3], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
						}
						else if (Singleton<SaveSystem>.Instance.GetInt(array2[0], null) != int.Parse(array2[4]))
						{
							flag = false;
						}
						continue;
						IL_14F:
						flag = true;
					}
					else if (array2[1] == "_Offsets")
					{
						flag = true;
					}
					else
					{
						Debug.Log("_Near" + array2[0] + ",");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag && this.JKCNBMOJNIG())
			{
				flag = false;
			}
		}
		catch (Exception)
		{
		}
		return flag;
	}

	// Token: 0x0600F7F7 RID: 63479 RVA: 0x005572DC File Offset: 0x005554DC
	public bool BLDMPJOMGDN()
	{
		string hfefhopolik = "_Value2" + Singleton<MapsSystem>.Instance.GetMapID(this) + "#{0:00}{1}{2}";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hfefhopolik, 0, null) == 0;
	}

	// Token: 0x04001B8B RID: 7051
	public Dictionary<string, UnityEngine.Object> resources = new Dictionary<string, UnityEngine.Object>();

	// Token: 0x04001B8C RID: 7052
	public MapData mapData;

	// Token: 0x04001B8D RID: 7053
	public ObscuredString workshopId;

	// Token: 0x04001B8E RID: 7054
	public ulong mapperSteamID;

	// Token: 0x04001B8F RID: 7055
	public FullMapData.MapSource source;

	// Token: 0x04001B90 RID: 7056
	public string fullLevelPath = string.Empty;

	// Token: 0x04001B91 RID: 7057
	public Sprite icon;

	// Token: 0x04001B92 RID: 7058
	public AudioClip clip;

	// Token: 0x02000440 RID: 1088
	public enum MapSource
	{
		// Token: 0x04001B94 RID: 7060
		Original,
		// Token: 0x04001B95 RID: 7061
		Editor,
		// Token: 0x04001B96 RID: 7062
		Workshop
	}
}
