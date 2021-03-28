using System;
using Assets.Pixelation.Scripts;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CinematicEffects;
using UnityStandardAssets.ImageEffects;

// Token: 0x02000464 RID: 1124
public class ShaderItemHandler : MonoBehaviour
{
	// Token: 0x060100DF RID: 65759 RVA: 0x0057EDE4 File Offset: 0x0057CFE4
	private void KFACDBHDAOD()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.CGJOIHHJLEL();
		}
	}

	// Token: 0x060100E0 RID: 65760 RVA: 0x0057EE06 File Offset: 0x0057D006
	private void LBPCODPOJAH()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DABDHKLHECK();
		}
	}

	// Token: 0x060100E1 RID: 65761 RVA: 0x0057EE28 File Offset: 0x0057D028
	private void GDJNNMGCGGK()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("_ChannelMixerGreen" + InventoryItemType.Ticket.ToString().ToLower(), "Failed to Destroy objects of playerId: ", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "title");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "Tab1Content");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use") && id == "_ScreenResolution");
			if (id == "settings.gamemessagesduration")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1854f;
			}
			else if (id == "x")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 252f;
			}
			base.GetComponent<ColorCorrectionCurves>().MENIGCOFDFC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "3;4;9;10;21x6");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "mapselector.orderby");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == " x ");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "[PlayerController] ");
		}
		if (GameObject.Find("_Value") && GameObject.Find("_Blend").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Value").GetComponentInChildren<Image>().enabled = (id == "_TimeX");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x060100E2 RID: 65762 RVA: 0x0057F0C1 File Offset: 0x0057D2C1
	private void DNENFLNCIJP()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.LJLKKJEFFLK();
		}
	}

	// Token: 0x060100E3 RID: 65763 RVA: 0x0057F0E3 File Offset: 0x0057D2E3
	private void DDBOODLPCAM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DLIGNKPKAOP();
		}
	}

	// Token: 0x060100E4 RID: 65764 RVA: 0x0057F105 File Offset: 0x0057D305
	public void HINJNBJFGHD()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.GCNNKEMKPGM();
		}
	}

	// Token: 0x060100E5 RID: 65765 RVA: 0x0057F12E File Offset: 0x0057D32E
	public void PHIBAJAFNEO()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.LJLKKJEFFLK();
		}
	}

	// Token: 0x060100E6 RID: 65766 RVA: 0x0057F158 File Offset: 0x0057D358
	private void KBLLBKNNBGO()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO("_MaxRadiusOrKInPaper" + InventoryItemType.Shader.ToString().ToLower(), "Joystick1Button6", null);
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "GlassAberration");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "CameraFilterPack/Drawing_Manga_Flash_Color");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "CameraFilterPack_Paper1") && id == "Could not execute RPC ");
			if (id == "accuracy")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1856f;
			}
			else if (id == "CameraFilterPack/Blend2Camera_Luminosity")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 242f;
			}
			base.GetComponent<ColorCorrectionCurves>().UpdateParameters();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "#ok");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "menu.selectedplaymode");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "_ScreenResolution");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "_TimeX");
		}
		if (GameObject.Find(" canvas not found") && GameObject.Find("/").GetComponentInChildren<Image>())
		{
			GameObject.Find("[").GetComponentInChildren<Image>().enabled = (id == "{}");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x060100E7 RID: 65767 RVA: 0x0057F3F1 File Offset: 0x0057D5F1
	private void AAPKBNDHBLI()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.AGMEELGLEEE();
		}
	}

	// Token: 0x060100E8 RID: 65768 RVA: 0x0057F413 File Offset: 0x0057D613
	public void CKJCPBPMBFF()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.OOHLEMKHNKJ();
		}
	}

	// Token: 0x060100E9 RID: 65769 RVA: 0x0057F43C File Offset: 0x0057D63C
	private void CGBHOELMAOC()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.LKBBGBBEJKP();
		}
	}

	// Token: 0x060100EA RID: 65770 RVA: 0x0057F460 File Offset: 0x0057D660
	private void DLIGNKPKAOP()
	{
		string s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("_ScreenResolution" + ((InventoryItemType)8).ToString().ToLower(), "_FresnelFade", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "inventory.itemscash");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "LoadMapCanvas");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "EventSystem" || id == "JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
			if (id == "Save the map before exiting?")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1966f;
			}
			else if (id == "Out {0,4} | In {1,4} | Sum {2,4}")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1087f;
			}
			base.GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "UnityEngine.MonoBehaviour");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "Can't set visible when not in that room.");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "ticket");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "ticket");
		}
		if (GameObject.Find("Protocol switch from: ") && GameObject.Find("B").GetComponentInChildren<Image>())
		{
			GameObject.Find("Hidden/Subpixel Morphological Anti-aliasing").GetComponentInChildren<Image>().enabled = (id == "{0}{1}{2}");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x060100EB RID: 65771 RVA: 0x0057F6F9 File Offset: 0x0057D8F9
	public void LLAHPNGMEOO()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.CGJOIHHJLEL();
		}
	}

	// Token: 0x060100EC RID: 65772 RVA: 0x0057F722 File Offset: 0x0057D922
	private void MDCFIHDPLIG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.FHADLGLMIBG();
		}
	}

	// Token: 0x060100ED RID: 65773 RVA: 0x0057F744 File Offset: 0x0057D944
	public void JEFKEOFNKIM()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DBONMCBDEPG();
		}
	}

	// Token: 0x060100EE RID: 65774 RVA: 0x0057F770 File Offset: 0x0057D970
	private void DABDHKLHECK()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("?page=addtip" + ((InventoryItemType)6).ToString().ToLower(), "_Near", null);
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "[Right-Left]");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "Maps Editor v.");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "-showlogs") && id == "_Value2");
			if (id == "mapselector.tags.")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 688f;
			}
			else if (id == " Server: ")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 334f;
			}
			base.GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "MenuScene");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == " item(s) in inventory");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "_Value2");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "settings.disablestoryboard");
		}
		if (GameObject.Find("OK") && GameObject.Find("inventory.itemscash").GetComponentInChildren<Image>())
		{
			GameObject.Find("Tab2Content").GetComponentInChildren<Image>().enabled = (id == "[LevelEditorScene] Error: You're not logged into Steam!");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x060100EF RID: 65775 RVA: 0x0057FA0C File Offset: 0x0057DC0C
	private void PLKGKBPAIOP()
	{
		string s = Singleton<SaveSystem>.Instance.CEDJCDAPIAH("{0}{1}:{2}" + InventoryItemType.Player.ToString().ToLower(), " from: ", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "Skipping region because it's not in PhotonServerSettings.EnabledRegions: ");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "maps.");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "RestartButton") && id == "_Value4");
			if (id == "https://bugs.khb-soft.ru/set_project.php?project_id=1")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 993f;
			}
			else if (id == " does not exist!")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 858f;
			}
			base.GetComponent<ColorCorrectionCurves>().MENIGCOFDFC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "R:");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "Can't set Room.MaxPlayers to: ");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "Default UI Material");
		}
		if (GameObject.Find("The shader ") && GameObject.Find("_TimeX").GetComponentInChildren<Image>())
		{
			GameObject.Find("wss://").GetComponentInChildren<Image>().enabled = (id == "_BlurVector");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x060100F0 RID: 65776 RVA: 0x0057FCA5 File Offset: 0x0057DEA5
	public void HBKEHHCMMBN()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.MOABIEIPGHN();
		}
	}

	// Token: 0x060100F1 RID: 65777 RVA: 0x0057FCCE File Offset: 0x0057DECE
	private void IDIIELPAMCJ()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.KIBEDOCDGCG();
		}
	}

	// Token: 0x060100F2 RID: 65778 RVA: 0x0057FCF0 File Offset: 0x0057DEF0
	private void FHADLGLMIBG()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), "shader.none", null);
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(@string)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "shader.invert");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "shader.pixel");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "shader.future" || id == "shader.frost");
			if (id == "shader.future")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1f;
			}
			else if (id == "shader.frost")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1f;
			}
			base.GetComponent<ColorCorrectionCurves>().UpdateParameters();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "shader.ghost");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "shader.sunny");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "shader.crispwinter");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "shader.sunny");
		}
		if (GameObject.Find("FrostCanvas") && GameObject.Find("FrostCanvas").GetComponentInChildren<Image>())
		{
			GameObject.Find("FrostCanvas").GetComponentInChildren<Image>().enabled = (id == "shader.frost");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x060100F3 RID: 65779 RVA: 0x0057FF89 File Offset: 0x0057E189
	public void GAJEPOEIOPP()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.PKOINEADGNA();
		}
	}

	// Token: 0x060100F4 RID: 65780 RVA: 0x0057FFB2 File Offset: 0x0057E1B2
	public void EFEONCCCKNP()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.PKOINEADGNA();
		}
	}

	// Token: 0x060100F5 RID: 65781 RVA: 0x0057FFDB File Offset: 0x0057E1DB
	public void EHGHEEJNPIN()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.BEPABLJNPOE();
		}
	}

	// Token: 0x060100F6 RID: 65782 RVA: 0x00580004 File Offset: 0x0057E204
	private void BEPABLJNPOE()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("CameraFilterPack/Atmosphere_Rain_Pro" + InventoryItemType.Other.ToString().ToLower(), "shader.frost", null);
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(@string)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == ".");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == ". Verify the Prefab is in a Resources folder (and not in a subfolder)");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "_Value2" || id == "/");
			if (id == ": ")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 762f;
			}
			else if (id == "(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 15f;
			}
			base.GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "{0}");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "finished");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "_TimeX");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "CameraFilterPack_Broken_Screen1");
		}
		if (GameObject.Find("Middle Click") && GameObject.Find("BadgeText").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Amount").GetComponentInChildren<Image>().enabled = (id == "id");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x060100F7 RID: 65783 RVA: 0x0058029D File Offset: 0x0057E49D
	public void JJFLHFCBENC()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.BEPABLJNPOE();
		}
	}

	// Token: 0x060100F8 RID: 65784 RVA: 0x005802C6 File Offset: 0x0057E4C6
	public void CPJHNDOBFOD()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.LKBBGBBEJKP();
		}
	}

	// Token: 0x060100F9 RID: 65785 RVA: 0x005802EF File Offset: 0x0057E4EF
	private void NCPAFCKGJEA()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.GCNNKEMKPGM();
		}
	}

	// Token: 0x060100FA RID: 65786 RVA: 0x00580314 File Offset: 0x0057E514
	private void MDACKFPPNAE()
	{
		string s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("Texture2" + InventoryItemType.Other.ToString().ToLower(), "settings.volume.sfx", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "/icon");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "_Vibrance");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "Please specify either t or f.") && id == "Set Particle Size");
			if (id == "Item created: Id: ")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1540f;
			}
			else if (id == "_TimeX")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 91f;
			}
			base.GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "value");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "inventory.selected.");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "BloomShaderValueSlider");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "/config");
		}
		if (GameObject.Find("_Value5") && GameObject.Find("Instantiating: ").GetComponentInChildren<Image>())
		{
			GameObject.Find("[PlayerBase] New highscore").GetComponentInChildren<Image>().enabled = (id == "Fade");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x060100FB RID: 65787 RVA: 0x0057F722 File Offset: 0x0057D922
	private void Update()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.FHADLGLMIBG();
		}
	}

	// Token: 0x060100FC RID: 65788 RVA: 0x005805AD File Offset: 0x0057E7AD
	public void LHIEKHPLMFI()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.PNLBMKHFPEA();
		}
	}

	// Token: 0x060100FD RID: 65789 RVA: 0x005805D8 File Offset: 0x0057E7D8
	private void OOHLEMKHNKJ()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("[Left]" + InventoryItemType.MenuTheme.ToString().ToLower(), "Set satellite MinVertexDistance - how much distance should be between to points of the trail line", null);
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(@string)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "steamid");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "Scrollbar");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "_TimeX") && id == "https://store.steampowered.com/recommended/recommendgame/");
			if (id == "YES")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1650f;
			}
			else if (id == "_ScreenResolution")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 11f;
			}
			base.GetComponent<ColorCorrectionCurves>().UpdateParameters();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "Tab2Content");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "The given 2D texture ");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "_Bloom2");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ");
		}
		if (GameObject.Find("No Camera attached!") && GameObject.Find("FileMenu").GetComponentInChildren<Image>())
		{
			GameObject.Find("BitsData").GetComponentInChildren<Image>().enabled = (id == "#score");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x060100FE RID: 65790 RVA: 0x00580871 File Offset: 0x0057EA71
	public void JHCJHPNAPDI()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.CGJOIHHJLEL();
		}
	}

	// Token: 0x060100FF RID: 65791 RVA: 0x0058089C File Offset: 0x0057EA9C
	private void DEBPOMCFBJO()
	{
		string s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("Waiting to start" + ((InventoryItemType)7).ToString().ToLower(), "value", null);
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "bloomintencity:");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "Start Color's hex value #RRGGBBAA");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "_Value" || id == "_Green_B");
			if (id == "RequestForPickupItems")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 780f;
			}
			else if (id == "health")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1218f;
			}
			base.GetComponent<ColorCorrectionCurves>().IKKLJLDADAK();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "z");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "_BlurCoe");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "Items/");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "_MainTex2");
		}
		if (GameObject.Find("Jump") && GameObject.Find("Joystick1Button2").GetComponentInChildren<Image>())
		{
			GameObject.Find("_MainTex2").GetComponentInChildren<Image>().enabled = (id == "_ScreenResolution");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x06010100 RID: 65792 RVA: 0x00580B35 File Offset: 0x0057ED35
	public void IFGOHEOEGKH()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.GDJNNMGCGGK();
		}
	}

	// Token: 0x06010101 RID: 65793 RVA: 0x00580B60 File Offset: 0x0057ED60
	private void KIBEDOCDGCG()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO("X" + InventoryItemType.Other.ToString().ToLower(), "(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)", null);
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "OnDeserialize");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "Change Note:") && id == "{0}sec average:");
			if (id == ") error: ")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 837f;
			}
			else if (id == "_Amount")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 350f;
			}
			base.GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == " Message: ");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "_Value");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "RecieveChatActionMessage");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "_Offset");
		}
		if (GameObject.Find("Mouse") && GameObject.Find("settings_bindings_sec_").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Value2").GetComponentInChildren<Image>().enabled = (id == "Bad parameters for init! Use \"init\" or \"init <savename>\"");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x06010102 RID: 65794 RVA: 0x00580DF9 File Offset: 0x0057EFF9
	public void CDDHLFNJOGC()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DEPPOJEPCJC();
		}
	}

	// Token: 0x06010103 RID: 65795 RVA: 0x00580E22 File Offset: 0x0057F022
	public void PFMJPIJONIP()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.FHCANIGKFLD();
		}
	}

	// Token: 0x06010104 RID: 65796 RVA: 0x00580E4B File Offset: 0x0057F04B
	public void Init()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.FHADLGLMIBG();
		}
	}

	// Token: 0x06010105 RID: 65797 RVA: 0x00580E74 File Offset: 0x0057F074
	private void GCNNKEMKPGM()
	{
		string s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("SpawnObj" + InventoryItemType.Player.ToString().ToLower(), "CameraFilterPack/Color_BrightContrastSaturation", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "CameraFilterPack/Blur_Blurry");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == " or player:");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "ItemNameText" || id == "_ScreenResolution");
			if (id == "_ColorRGB")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 551f;
			}
			else if (id == "_FixDistance")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1813f;
			}
			base.GetComponent<ColorCorrectionCurves>().ANDGHMDPICK();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "_MainTex2");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "NEW");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "_ProjInfo");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "Result for ");
		}
		if (GameObject.Find("Editor/") && GameObject.Find(".lastCheckpoint.bgcolor").GetComponentInChildren<Image>())
		{
			GameObject.Find("Ownership mode == fixed. Ignoring request.").GetComponentInChildren<Image>().enabled = (id == "#forever");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x06010106 RID: 65798 RVA: 0x0058110D File Offset: 0x0057F30D
	private void KDJEJBBDILE()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DBONMCBDEPG();
		}
	}

	// Token: 0x06010107 RID: 65799 RVA: 0x0058112F File Offset: 0x0057F32F
	private void COGBDFKOHKK()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.NDACFLFLANE();
		}
	}

	// Token: 0x06010108 RID: 65800 RVA: 0x00581154 File Offset: 0x0057F354
	private void DKLJCAINIDG()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA(".icon" + ((InventoryItemType)8).ToString().ToLower(), "mapid", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "...");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "[MapsData] User's maps was loaded");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "Parent object ID. Case-Sensitive") && id == "Most likely the game became empty during the switch to GameServer.");
			if (id == "_BlurVector")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 119f;
			}
			else if (id == "Texture2")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 935f;
			}
			base.GetComponent<ColorCorrectionCurves>().ANDGHMDPICK();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "\t");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "_Value4");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "settings.volume.menu");
		}
		if (GameObject.Find("_DistortionWave") && GameObject.Find("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data").GetComponentInChildren<Image>())
		{
			GameObject.Find("shader.future").GetComponentInChildren<Image>().enabled = (id == "Sep");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x06010109 RID: 65801 RVA: 0x005813F0 File Offset: 0x0057F5F0
	private void ONJOOAAILAJ()
	{
		string s = Singleton<SaveSystem>.Instance.JLBFLBAHGIP("warning: Audio Source: " + ((InventoryItemType)7).ToString().ToLower(), "CameraFilterPack/Vision_AuraDistortion", null);
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "float,10");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "_DistortionSize");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "Joystick1Button2") && id == "Set sun min/max size");
			if (id == "_Visualize")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1623f;
			}
			else if (id == "true")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 288f;
			}
			base.GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "z");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "Outgoing: \n");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "blue");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "#done");
		}
		if (GameObject.Find("UseFinalGlassColor") && GameObject.Find("<b>#").GetComponentInChildren<Image>())
		{
			GameObject.Find("skins").GetComponentInChildren<Image>().enabled = (id == "false");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x0601010A RID: 65802 RVA: 0x00581689 File Offset: 0x0057F889
	private void OCMKCBBCEFG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.ABBNNMHMLOI();
		}
	}

	// Token: 0x0601010B RID: 65803 RVA: 0x005816AC File Offset: 0x0057F8AC
	private void JOMJICOMCEK()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("_ScreenResolution" + ((InventoryItemType)7).ToString().ToLower(), "<b>", null);
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "_Value4");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "_Value3");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "float,0") && id == "_TimeX");
			if (id == "_Distortion")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1235f;
			}
			else if (id == "_Threshhold")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 401f;
			}
			base.GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "SpawnObj");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "RT");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "Fade");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "action");
		}
		if (GameObject.Find("_ScreenResolution") && GameObject.Find("Gameplay/sprite").GetComponentInChildren<Image>())
		{
			GameObject.Find("_ForegroundBlurExtrude").GetComponentInChildren<Image>().enabled = (id == " ");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x0601010C RID: 65804 RVA: 0x0058110D File Offset: 0x0057F30D
	private void ANKIJGCGCBF()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DBONMCBDEPG();
		}
	}

	// Token: 0x0601010D RID: 65805 RVA: 0x00581945 File Offset: 0x0057FB45
	private void FJHFOBHJEHL()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.LAGGOOCMLBJ();
		}
	}

	// Token: 0x0601010E RID: 65806 RVA: 0x00581967 File Offset: 0x0057FB67
	private void OPCLBGHAPMG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.JOMJICOMCEK();
		}
	}

	// Token: 0x0601010F RID: 65807 RVA: 0x0058198C File Offset: 0x0057FB8C
	private void FHCANIGKFLD()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("[PlayerController] " + InventoryItemType.MenuTheme.ToString().ToLower(), "id", null);
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "CameraFilterPack/Blend2Camera_BlueScreen");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "RestartButton");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "_Wavy" || id == "EventMenu");
			if (id == "_ScreenResolution")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1633f;
			}
			else if (id == "Case-Sensitive")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1914f;
			}
			base.GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "CameraFilterPack/Blur_Steam");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "setint");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "Most likely the game became empty during the switch to GameServer.");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "_ScreenResolution");
		}
		if (GameObject.Find("Set Sun MinSize") && GameObject.Find("SpeedSlider").GetComponentInChildren<Image>())
		{
			GameObject.Find("player.goldlollipop").GetComponentInChildren<Image>().enabled = (id == "request");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x06010110 RID: 65808 RVA: 0x00581C28 File Offset: 0x0057FE28
	private void JMFMKCDKGHK()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO("_Blue_G" + ((InventoryItemType)6).ToString().ToLower(), "ShineEffect", null);
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "Protocol switch from: ");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == ".completedMaps");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "_Value5") && id == "/icon");
			if (id == "_Value2")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 975f;
			}
			else if (id == "Ignored PU RPC, cause item is inactive. ")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1668f;
			}
			base.GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "ShadersToggle");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "LevelConfigButton");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == ".highscore");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "_Brightness");
		}
		if (GameObject.Find("_Value") && GameObject.Find("CameraFilterPack/Blur_Steam").GetComponentInChildren<Image>())
		{
			GameObject.Find("workshop.").GetComponentInChildren<Image>().enabled = (id == "shader.future");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x06010111 RID: 65809 RVA: 0x00581EC4 File Offset: 0x005800C4
	private void GLLNAELOMBK()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("_Value3" + InventoryItemType.MenuTheme.ToString().ToLower(), "<b>#", null);
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "settings.shaders.bloomintencity");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "_MaxRadiusOrKInPaper");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == " ") && id == "Lag ");
			if (id == "_CenterX")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1013f;
			}
			else if (id == "UpperMid")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1392f;
			}
			base.GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "Editor/");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "#tryagain");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "Turn");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "#{0:00} '{1}'{2} {3}");
		}
		if (GameObject.Find("[PlayerController] ") && GameObject.Find("_TexelOffsetScale").GetComponentInChildren<Image>())
		{
			GameObject.Find("CameraFilterPack/Blend2Camera_Overlay").GetComponentInChildren<Image>().enabled = (id == "seconds");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x06010112 RID: 65810 RVA: 0x0058215D File Offset: 0x0058035D
	public void MIAIEKCLEAO()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DLIGNKPKAOP();
		}
	}

	// Token: 0x06010113 RID: 65811 RVA: 0x00581945 File Offset: 0x0057FB45
	private void OBAEDJJDCPN()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.LAGGOOCMLBJ();
		}
	}

	// Token: 0x06010114 RID: 65812 RVA: 0x00582186 File Offset: 0x00580386
	private void KCDBBPKIFNJ()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.FHCANIGKFLD();
		}
	}

	// Token: 0x06010115 RID: 65813 RVA: 0x0057EDE4 File Offset: 0x0057CFE4
	private void IKIDIJLIGOH()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.CGJOIHHJLEL();
		}
	}

	// Token: 0x06010116 RID: 65814 RVA: 0x005821A8 File Offset: 0x005803A8
	private void KMEONPMCNJG()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.MDACKFPPNAE();
		}
	}

	// Token: 0x06010117 RID: 65815 RVA: 0x0057F3F1 File Offset: 0x0057D5F1
	private void LLDHEJIEDHO()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.AGMEELGLEEE();
		}
	}

	// Token: 0x06010118 RID: 65816 RVA: 0x005821CA File Offset: 0x005803CA
	public void LKEPIEEIMAE()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.MDACKFPPNAE();
		}
	}

	// Token: 0x06010119 RID: 65817 RVA: 0x005821F3 File Offset: 0x005803F3
	public void GINPIKEJGJD()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.ONJOOAAILAJ();
		}
	}

	// Token: 0x0601011A RID: 65818 RVA: 0x0058221C File Offset: 0x0058041C
	private void NDACFLFLANE()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO("mapselector.tags." + InventoryItemType.Shader.ToString().ToLower(), ":", null);
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == ".status");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "_Size");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "_ScreenResolution" || id == "Creating awesome map");
			if (id == "BitsData")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 20f;
			}
			else if (id == "[NetworkManager] Found ")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1006f;
			}
			base.GetComponent<ColorCorrectionCurves>().IKKLJLDADAK();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "[MapsStats] Map ID: ");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "_Level");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "Working commands:\nreset <challengeid>\nresetall");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "https://steamcommunity.com/sharedfiles/filedetails/?id=");
		}
		if (GameObject.Find("player.licenceaccepted") && GameObject.Find("\\\\").GetComponentInChildren<Image>())
		{
			GameObject.Find("GlassAberration").GetComponentInChildren<Image>().enabled = (id == "CameraFilterPack_VHS2");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x0601011B RID: 65819 RVA: 0x005824B8 File Offset: 0x005806B8
	private void LKBBGBBEJKP()
	{
		string s = Singleton<SaveSystem>.Instance.JLBFLBAHGIP("Result for " + InventoryItemType.Shader.ToString().ToLower(), "Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", null);
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "PunSupportLogger");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "RecieveChatMessage");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "Source: ") && id == "SetRotation");
			if (id == "/files/editor_manual.pdf")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 372f;
			}
			else if (id == "/")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1654f;
			}
			base.GetComponent<ColorCorrectionCurves>().IKKLJLDADAK();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "[Up]");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "#finished");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "TwoHands");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "#ok");
		}
		if (GameObject.Find("cameramovements:") && GameObject.Find("_Value2").GetComponentInChildren<Image>())
		{
			GameObject.Find("icon").GetComponentInChildren<Image>().enabled = (id == "GlassAberration");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x0601011C RID: 65820 RVA: 0x00582754 File Offset: 0x00580954
	private void CGJOIHHJLEL()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO(".a" + ((InventoryItemType)7).ToString().ToLower(), "_Glitch", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "menutheme.summerbreeze");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "_TimeX");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "_TimeX") && id == "[LevelEditorScene] Error: Timeout :S");
			if (id == "_Distortion")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1576f;
			}
			else if (id == "default")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 917f;
			}
			base.GetComponent<ColorCorrectionCurves>().IKKLJLDADAK();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "_FinalReflectionTexture");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "[PlayerBase] Unknown event: ");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "player.dragon");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "false");
		}
		if (GameObject.Find("_Near") && GameObject.Find("#scoresubmitionfailed: ").GetComponentInChildren<Image>())
		{
			GameObject.Find("maps.").GetComponentInChildren<Image>().enabled = (id == "shader.future");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x0601011D RID: 65821 RVA: 0x005829F0 File Offset: 0x00580BF0
	private void PKOINEADGNA()
	{
		string s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("_DistCenterScale" + InventoryItemType.MenuTheme.ToString().ToLower(), "_Value7", null);
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "menu.playedpage");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "SetRotation");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "\nCreated by Oxy949" || id == "_VignettingColor");
			if (id == "settings_bindings_")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 976f;
			}
			else if (id == "BitsData")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 131f;
			}
			base.GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "_Amount");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "[LobbyPlayerElement] Created lpe for ");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "pointBuffer");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "_Value6");
		}
		if (GameObject.Find("_MainTex2") && GameObject.Find("Editor").GetComponentInChildren<Image>())
		{
			GameObject.Find("_FixDistance").GetComponentInChildren<Image>().enabled = (id == "IntraSig");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x0601011E RID: 65822 RVA: 0x00582C8C File Offset: 0x00580E8C
	private void JMCFOJNCCLJ()
	{
		string @string = Singleton<SaveSystem>.Instance.GetString("GameScene" + ((InventoryItemType)8).ToString().ToLower(), "_XCrop", null);
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(@string)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "<b>#");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "player.ice");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "ShadersToggle") && id == "CameraFilterPack/Drawing_Manga5");
			if (id == " TimeOfRespawn: ")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 660f;
			}
			else if (id == "CameraFilterPack/TV_LED")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 701f;
			}
			base.GetComponent<ColorCorrectionCurves>().MENIGCOFDFC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "EnableRankingToggle");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "ScrollPanel");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "_CenterY");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "#tryagain");
		}
		if (GameObject.Find("_TimeX") && GameObject.Find("_MainTex").GetComponentInChildren<Image>())
		{
			GameObject.Find("x").GetComponentInChildren<Image>().enabled = (id == "_SizeX");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x0601011F RID: 65823 RVA: 0x00582F28 File Offset: 0x00581128
	private void PNLBMKHFPEA()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("yyyy-MM-dd HH:mm:ss" + InventoryItemType.Other.ToString().ToLower(), "There is already a virtual axis named ", null);
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "Source directory does not exist or could not be found: ");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "PenaltyScoreText");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "[PlayerController] ") && id == "LoadMapCanvas");
			if (id == "LB")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 571f;
			}
			else if (id == ".a")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1482f;
			}
			base.GetComponent<ColorCorrectionCurves>().ANDGHMDPICK();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "_ScreenResolution");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "CameraFilterPack/3D_Distortion");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "EventSystem");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == ".lastCheckpoint.incorrectScore");
		}
		if (GameObject.Find("_TimeX") && GameObject.Find("88f00bdf0ad61b16b803971ebe071962").GetComponentInChildren<Image>())
		{
			GameObject.Find("BitsData").GetComponentInChildren<Image>().enabled = (id == "Unknown player asked for PickupItems");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x06010120 RID: 65824 RVA: 0x005831C1 File Offset: 0x005813C1
	public void CPFOEFKOJGA()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DABDHKLHECK();
		}
	}

	// Token: 0x06010121 RID: 65825 RVA: 0x005831EC File Offset: 0x005813EC
	private void LAGGOOCMLBJ()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("Waiting to start" + InventoryItemType.Shader.ToString().ToLower(), "_FixDistance", null);
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "BitsData");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "MenuScene");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "_Value2" || id == "/");
			if (id == "_Value4")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1974f;
			}
			else if (id == "Particles/Additive")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 594f;
			}
			base.GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "\nCreated by Oxy949");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "{0:x2}");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "Despawn environment object by id");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "SpawnObj");
		}
		if (GameObject.Find("_Distance") && GameObject.Find("_TimeX").GetComponentInChildren<Image>())
		{
			GameObject.Find("mapselector.lastSearch").GetComponentInChildren<Image>().enabled = (id == "settings.volume.menu");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x06010122 RID: 65826 RVA: 0x00583485 File Offset: 0x00581685
	public void ALKBNPMCEOM()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.GLLNAELOMBK();
		}
	}

	// Token: 0x06010123 RID: 65827 RVA: 0x0058112F File Offset: 0x0057F32F
	private void FOLDLDLFFLM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.NDACFLFLANE();
		}
	}

	// Token: 0x06010124 RID: 65828 RVA: 0x0057FCCE File Offset: 0x0057DECE
	private void HIKKPDACJGI()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.KIBEDOCDGCG();
		}
	}

	// Token: 0x06010125 RID: 65829 RVA: 0x0057F0E3 File Offset: 0x0057D2E3
	private void FGNFILLNPJK()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DLIGNKPKAOP();
		}
	}

	// Token: 0x06010126 RID: 65830 RVA: 0x005834B0 File Offset: 0x005816B0
	private void NKMAIAJDLHB()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("RestartButton" + InventoryItemType.Other.ToString().ToLower(), "checkpoint", null);
		string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == ";");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "MapEditorScene");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "blue" || id == "SetParticlesColor");
			if (id == "Editor/")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1987f;
			}
			else if (id == "Down")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1290f;
			}
			base.GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "HandsCountSlider");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "LostLive");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "Item invalid. Make sure your mod contains at leats one file.");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "907198288");
		}
		if (GameObject.Find("_Distortion") && GameObject.Find("MusicFileSelector").GetComponentInChildren<Image>())
		{
			GameObject.Find("CameraFilterPack_Blizzard1").GetComponentInChildren<Image>().enabled = (id == "SAVE");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x06010127 RID: 65831 RVA: 0x0058374C File Offset: 0x0058194C
	private void DBONMCBDEPG()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("_TimeX" + ((InventoryItemType)6).ToString().ToLower(), "_Visualize", null);
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == " url: ");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "IconImage");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "[ResourcesManager] Unloading data resources") && id == "CameraFilterPack/BlurHole");
			if (id == "LeaderboardsButton")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 499f;
			}
			else if (id == ".GoalProgress")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 107f;
			}
			base.GetComponent<ColorCorrectionCurves>().IKKLJLDADAK();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == ".played");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "<b>");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == ": ");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == ").png");
		}
		if (GameObject.Find("_ScreenResolution") && GameObject.Find("event").GetComponentInChildren<Image>())
		{
			GameObject.Find("loadscene").GetComponentInChildren<Image>().enabled = (id == "_Vignetting");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x06010128 RID: 65832 RVA: 0x005839E8 File Offset: 0x00581BE8
	private void PKDDPFLCAHI()
	{
		string s = Singleton<SaveSystem>.Instance.CKJPNOHLJJO("Lag " + ((InventoryItemType)6).ToString().ToLower(), "_Value", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "UI Extensions/UILinearDodge");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "ResourceIDInputField");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "#changenote") && id == "FullscreenToggle");
			if (id == "_Value2")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1209f;
			}
			else if (id == "menu.tabid")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1969f;
			}
			base.GetComponent<ColorCorrectionCurves>().EJMOKDJNDBC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "_Offsets");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "CameraFilterPack/Blend2Camera_ColorDodge");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == " cannot be used as a 3D LUT.");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "_BlurVector");
		}
		if (GameObject.Find("_Intensity") && GameObject.Find("ReconnectToMaster() with AuthValues == null is not correct!").GetComponentInChildren<Image>())
		{
			GameObject.Find("a").GetComponentInChildren<Image>().enabled = (id == "#newhighscore");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x06010129 RID: 65833 RVA: 0x00583C81 File Offset: 0x00581E81
	public void FAIMAGILFLO()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.GDPOFILIMJB();
		}
	}

	// Token: 0x0601012A RID: 65834 RVA: 0x00583CAA File Offset: 0x00581EAA
	private void HMNLHMLILKD()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.PLKGKBPAIOP();
		}
	}

	// Token: 0x0601012B RID: 65835 RVA: 0x00583CCC File Offset: 0x00581ECC
	private void POJFHDFJOPE()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.OOHLEMKHNKJ();
		}
	}

	// Token: 0x0601012C RID: 65836 RVA: 0x00583CEE File Offset: 0x00581EEE
	private void LMADKINICIN()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.PNLBMKHFPEA();
		}
	}

	// Token: 0x0601012D RID: 65837 RVA: 0x00581967 File Offset: 0x0057FB67
	private void FABKIGNFECE()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.JOMJICOMCEK();
		}
	}

	// Token: 0x0601012E RID: 65838 RVA: 0x00583D10 File Offset: 0x00581F10
	private void DEPPOJEPCJC()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("_TimeX" + InventoryItemType.Shader.ToString().ToLower(), "CameraFilterPack/Color_Sepia", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "clear");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "Editor");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "MascotChallenge2019" || id == "float,0");
			if (id == "#finished")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1560f;
			}
			else if (id == "Mouse X")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1914f;
			}
			base.GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "CHROMATIC_ABERRATION");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "[Right]");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "Subscribed cells:\n");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == ".");
		}
		if (GameObject.Find("_Value2") && GameObject.Find(" to: ").GetComponentInChildren<Image>())
		{
			GameObject.Find("_Value2").GetComponentInChildren<Image>().enabled = (id == "_LightIntensity");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x0601012F RID: 65839 RVA: 0x00583FA9 File Offset: 0x005821A9
	public void LCKKDMKJJEF()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DBONMCBDEPG();
		}
	}

	// Token: 0x06010130 RID: 65840 RVA: 0x005821CA File Offset: 0x005803CA
	public void BKEFJPOHKDE()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.MDACKFPPNAE();
		}
	}

	// Token: 0x06010131 RID: 65841 RVA: 0x00583FD2 File Offset: 0x005821D2
	private void GHILDCBCDJI()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.ALGHFMOEINN();
		}
	}

	// Token: 0x06010132 RID: 65842 RVA: 0x00583FF4 File Offset: 0x005821F4
	private void LJLKKJEFFLK()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("Preparing content..." + ((InventoryItemType)5).ToString().ToLower(), "_ScreenResolution", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "SetSatelliteEmission");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "music");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "finished" || id == "CameraFilterPack/Noise_TV_2");
			if (id == "_ScreenResolution")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1727f;
			}
			else if (id == "_Intensity")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 318f;
			}
			base.GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "_ScreenResolution");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "_MainTex2");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "\"");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "Editor");
		}
		if (GameObject.Find("/?player=") && GameObject.Find("_FilteredReflections").GetComponentInChildren<Image>())
		{
			GameObject.Find("challenges/").GetComponentInChildren<Image>().enabled = (id == "Reading preview file failed!: \"{0}\"");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x06010133 RID: 65843 RVA: 0x00583485 File Offset: 0x00581685
	public void BOMFGAMNHIE()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.GLLNAELOMBK();
		}
	}

	// Token: 0x06010134 RID: 65844 RVA: 0x0058428D File Offset: 0x0058248D
	public void EOPEMLDJAAO()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.GLLNAELOMBK();
		}
	}

	// Token: 0x06010135 RID: 65845 RVA: 0x00583FD2 File Offset: 0x005821D2
	private void GPFJMKCGHGB()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.ALGHFMOEINN();
		}
	}

	// Token: 0x06010136 RID: 65846 RVA: 0x005842B6 File Offset: 0x005824B6
	private void LDDKCCMHMIC()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DEBPOMCFBJO();
		}
	}

	// Token: 0x06010137 RID: 65847 RVA: 0x005842D8 File Offset: 0x005824D8
	public void OCHADIJNDJK()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.MDACKFPPNAE();
		}
	}

	// Token: 0x06010138 RID: 65848 RVA: 0x005842D8 File Offset: 0x005824D8
	public void LILOGPDPFDA()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.MDACKFPPNAE();
		}
	}

	// Token: 0x06010139 RID: 65849 RVA: 0x00584304 File Offset: 0x00582504
	private void AGMEELGLEEE()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE(" This is not possible to be called for standalone input. Please check your platform and code where this is called" + InventoryItemType.Shader.ToString().ToLower(), "Editor/", null);
		string id = Singleton<ItemsHandler>.Instance.GJHAJNLENFB(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == ".jpg");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "CameraFilterPack/Blend2Camera_LinearDodge");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "_RandomTexture" || id == "/../");
			if (id == "ItemNameText")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1513f;
			}
			else if (id == "PlayButton")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 557f;
			}
			base.GetComponent<ColorCorrectionCurves>().JDCODMMDPII();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == " has been disabled as it's not supported on the current platform.");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "Triangle");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "_ReflectionBlur");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "0,1,false");
		}
		if (GameObject.Find("FinalScoreSmallText") && GameObject.Find("_Value2").GetComponentInChildren<Image>())
		{
			GameObject.Find("FinalScoreText").GetComponentInChildren<Image>().enabled = (id == "CameraFilterPack/FX_ZebraColor");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x0601013B RID: 65851 RVA: 0x005845A0 File Offset: 0x005827A0
	private void HJPEHBPMPEK()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("player.licenceaccepted" + InventoryItemType.MenuTheme.ToString().ToLower(), "Color's hex value #RRGGBBAA", null);
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "Could not execute RPC ");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "HandsCountSlider");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "FinalScoreSmallText" || id == "_Value");
			if (id == "PossibleMapPointsText")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 920f;
			}
			else if (id == "_Value2")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1428f;
			}
			base.GetComponent<ColorCorrectionCurves>().ANDGHMDPICK();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "PUNCloudBestRegion");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == " not exist");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "[EditorEvent] Exception: ");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "Data/Maps/");
		}
		if (GameObject.Find("Drop_With_Obj") && GameObject.Find("Noise shaders are not set up! Disabling noise effect.").GetComponentInChildren<Image>())
		{
			GameObject.Find("_TimeX").GetComponentInChildren<Image>().enabled = (id == "sfxVolume");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x0601013C RID: 65852 RVA: 0x00581945 File Offset: 0x0057FB45
	private void IEMEHGCFAPD()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.LAGGOOCMLBJ();
		}
	}

	// Token: 0x0601013D RID: 65853 RVA: 0x0058483C File Offset: 0x00582A3C
	private void MOABIEIPGHN()
	{
		string s = Singleton<SaveSystem>.Instance.CEDJCDAPIAH("[Singleton] An instance of '" + InventoryItemType.MenuTheme.ToString().ToLower(), "SelectorMusicToggle", null);
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "-1");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "Tab2Content");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "OpGetGameList not sent. Lobby cannot be null." || id == "visible");
			if (id == "SetSunInput")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1105f;
			}
			else if (id == "Gameplay/Base")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 138f;
			}
			base.GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "[NetworkManager] Connected to ");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "settings.gamemessagesduration");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "_TimeX");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "CameraFilterPack/Blend2Camera_Subtract");
		}
		if (GameObject.Find(".lastCheckpoint.bgcolor") && GameObject.Find("_Value2").GetComponentInChildren<Image>())
		{
			GameObject.Find("CameraFilterPack/Drawing_BluePrint").GetComponentInChildren<Image>().enabled = (id == "MapFolderInputField");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x0601013E RID: 65854 RVA: 0x00584AD5 File Offset: 0x00582CD5
	public void GCNKIJDNPMD()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.PKDDPFLCAHI();
		}
	}

	// Token: 0x0601013F RID: 65855 RVA: 0x00584AFE File Offset: 0x00582CFE
	private void KMKLDAJLCNM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DEPPOJEPCJC();
		}
	}

	// Token: 0x06010140 RID: 65856 RVA: 0x00584B20 File Offset: 0x00582D20
	private void ALGHFMOEINN()
	{
		string s = Singleton<SaveSystem>.Instance.FDPKMMIOGOE("_MainTex2" + InventoryItemType.Other.ToString().ToLower(), "_Value", null);
		string id = Singleton<ItemsHandler>.Instance.HALDCNOECLE(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "_FresnelFade");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == " ");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "_Near" || id == "_Value4");
			if (id == "_Far")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1346f;
			}
			else if (id == "Set particles gravity")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1079f;
			}
			base.GetComponent<ColorCorrectionCurves>().UpdateParameters();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "Hex value #RRGGBB");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "LowMid");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "_Value4");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "[PlayerController] ");
		}
		if (GameObject.Find("_Distance") && GameObject.Find("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End").GetComponentInChildren<Image>())
		{
			GameObject.Find("z").GetComponentInChildren<Image>().enabled = (id == "_Distortion");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x06010141 RID: 65857 RVA: 0x00584DBC File Offset: 0x00582FBC
	private void ABBNNMHMLOI()
	{
		string s = Singleton<SaveSystem>.Instance.JLBFLBAHGIP("0.00" + InventoryItemType.Other.ToString().ToLower(), "JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", null);
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "_LightIntensity");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = false;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "Deleted event");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (!(id == "Created") && id == "#pleasewait");
			if (id == "ItemsStoreButton")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1135f;
			}
			else if (id == "Editor/")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 562f;
			}
			base.GetComponent<ColorCorrectionCurves>().MENIGCOFDFC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "[Up]");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "_Distortion");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "#later");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "_TimeX");
		}
		if (GameObject.Find("_TimeX") && GameObject.Find("ResourcesConfig").GetComponentInChildren<Image>())
		{
			GameObject.Find("#").GetComponentInChildren<Image>().enabled = (id == "https://www.youtube.com/watch?v=cDVXukrKo74");
		}
		this.KCFOBKNIELP = false;
	}

	// Token: 0x06010142 RID: 65858 RVA: 0x00581689 File Offset: 0x0057F889
	private void BGDONBMDPGM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.ABBNNMHMLOI();
		}
	}

	// Token: 0x06010143 RID: 65859 RVA: 0x00583CEE File Offset: 0x00581EEE
	private void LCJHDLKJEOM()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.PNLBMKHFPEA();
		}
	}

	// Token: 0x06010144 RID: 65860 RVA: 0x00585055 File Offset: 0x00583255
	private void HPNNCNNFMGK()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.NKMAIAJDLHB();
		}
	}

	// Token: 0x06010145 RID: 65861 RVA: 0x0057FFB2 File Offset: 0x0057E1B2
	public void AOEEOKNJDCK()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.PKOINEADGNA();
		}
	}

	// Token: 0x06010146 RID: 65862 RVA: 0x00585078 File Offset: 0x00583278
	private void GDPOFILIMJB()
	{
		string s = Singleton<SaveSystem>.Instance.LFFECBOPPHA("SaveButton" + InventoryItemType.MenuTheme.ToString().ToLower(), "error", null);
		string id = Singleton<ItemsHandler>.Instance.DNPHLBJMMEM(ulong.Parse(s)).item.id;
		if (base.GetComponent<InvertColors>())
		{
			base.GetComponent<InvertColors>().enabled = (id == "_Value");
		}
		if (base.GetComponent<LensAberrations>())
		{
			base.GetComponent<LensAberrations>().enabled = true;
		}
		if (base.GetComponent<Chunky>())
		{
			base.GetComponent<Chunky>().enabled = (id == "SetSunDirectionVector");
		}
		if (base.GetComponent<ColorCorrectionCurves>())
		{
			base.GetComponent<ColorCorrectionCurves>().enabled = (id == "UndoButton" || id == "Joystick1Button10");
			if (id == "[RanksSystem] Ranks: no need to update")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1415f;
			}
			else if (id == "CameraFilterPack/Colors_HUE_Rotate")
			{
				base.GetComponent<ColorCorrectionCurves>().redChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().greenChannel = this.down;
				base.GetComponent<ColorCorrectionCurves>().blueChannel = this.up;
				base.GetComponent<ColorCorrectionCurves>().saturation = 1202f;
			}
			base.GetComponent<ColorCorrectionCurves>().AHHBDBKBJOC();
		}
		if (base.GetComponent<CameraFilterPack_TV_Old_Movie_2>())
		{
			base.GetComponent<CameraFilterPack_TV_Old_Movie_2>().enabled = (id == "?");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus>().enabled = (id == "OpAuthenticate()");
		}
		if (base.GetComponent<CameraFilterPack_Lut_Plus_2>())
		{
			base.GetComponent<CameraFilterPack_Lut_Plus_2>().enabled = (id == "Default UI Material");
		}
		if (base.GetComponent<CameraFilterPack_TV_80>())
		{
			base.GetComponent<CameraFilterPack_TV_80>().enabled = (id == "note.0");
		}
		if (GameObject.Find("Result for ") && GameObject.Find("/").GetComponentInChildren<Image>())
		{
			GameObject.Find("<b>Difficulty</b>:").GetComponentInChildren<Image>().enabled = (id == "_TimeX");
		}
		this.KCFOBKNIELP = true;
	}

	// Token: 0x06010147 RID: 65863 RVA: 0x00581945 File Offset: 0x0057FB45
	private void JBNPEHMDCMI()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.LAGGOOCMLBJ();
		}
	}

	// Token: 0x06010148 RID: 65864 RVA: 0x00585311 File Offset: 0x00583511
	public void MDPJHKECLOF()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.KIBEDOCDGCG();
		}
	}

	// Token: 0x06010149 RID: 65865 RVA: 0x0058533A File Offset: 0x0058353A
	public void PIEPPKMBJHI()
	{
		this.KCFOBKNIELP = true;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.GDJNNMGCGGK();
		}
	}

	// Token: 0x0601014A RID: 65866 RVA: 0x00585363 File Offset: 0x00583563
	public void FCKLLMEPONC()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.PNLBMKHFPEA();
		}
	}

	// Token: 0x0601014B RID: 65867 RVA: 0x0058538C File Offset: 0x0058358C
	public void FEJAAGGMBOE()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.DKLJCAINIDG();
		}
	}

	// Token: 0x0601014C RID: 65868 RVA: 0x00581945 File Offset: 0x0057FB45
	private void EJFJENFKLND()
	{
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.LAGGOOCMLBJ();
		}
	}

	// Token: 0x0601014D RID: 65869 RVA: 0x005853B5 File Offset: 0x005835B5
	public void PMAGMPCMGPB()
	{
		this.KCFOBKNIELP = false;
		if (Singleton<ItemsHandler>.Instance.isLoaded && !this.KCFOBKNIELP)
		{
			this.NKMAIAJDLHB();
		}
	}

	// Token: 0x04001C6A RID: 7274
	public AnimationCurve up;

	// Token: 0x04001C6B RID: 7275
	public AnimationCurve down;

	// Token: 0x04001C6C RID: 7276
	private bool KCFOBKNIELP;
}
