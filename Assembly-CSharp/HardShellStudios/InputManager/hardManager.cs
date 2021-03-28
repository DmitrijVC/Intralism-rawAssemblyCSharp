using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HardShellStudios.InputManager
{
	// Token: 0x02000161 RID: 353
	[AddComponentMenu("Hard Shell Studios/Input Manager/Input Manager")]
	[Serializable]
	public class hardManager : Singleton<hardManager>
	{
		// Token: 0x0600684A RID: 26698 RVA: 0x001F4DA0 File Offset: 0x001F2FA0
		private int GDHIFOHJLIA(hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (!this.useController)
			{
				if (NPBNCBFNBAF >= -94 && NPBNCBFNBAF <= -38)
				{
					return 0;
				}
				return NPBNCBFNBAF;
			}
			else
			{
				switch (IJAFMJMIJGK)
				{
				case (hardKey.controllerMap)105:
					return 62;
				case (hardKey.controllerMap)106:
					return 82;
				case (hardKey.controllerMap)107:
					return -56;
				case (hardKey.controllerMap)108:
					return 97;
				default:
					return NPBNCBFNBAF;
				}
			}
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x001F4DF8 File Offset: 0x001F2FF8
		public void KNBCBBCMPAE(string MDDCBDHGNPA, bool CKLPEJDAMME, KeyCode FEFOLHEFCKP)
		{
			this.currentBindFrom = null;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			int enfdcphdphc = 0;
			if (FEFOLHEFCKP.ToString().Contains("_EmissionGain") && this.useController)
			{
				enfdcphdphc = 7;
				this.IJNDKCEDGLA(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
			else if (!FEFOLHEFCKP.ToString().Contains("player.mysteryitem"))
			{
				this.FEPDBECKAMO(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x001F4E84 File Offset: 0x001F3084
		public void LMBAPDADHLN()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "\n\n• ";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				string key = str + keyValuePair.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
				string str2 = keyValuePair2.Value.keyInput.ToString();
				string str3 = "_ScreenResolution";
				KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
				PlayerPrefs.SetString(key, str2 + str3 + keyValuePair3.Value.keyWheelState.ToString());
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str4 = "InventoryButton";
				KeyValuePair<string, hardKey> keyValuePair4 = enumerator2.Current;
				string key2 = str4 + keyValuePair4.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair5 = enumerator2.Current;
				string str5 = keyValuePair5.Value.keyInput2.ToString();
				string str6 = "_Value2";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				PlayerPrefs.SetString(key2, str5 + str6 + keyValuePair6.Value.keyWheelState2.ToString());
			}
			PlayerPrefs.Save();
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x001F4FAC File Offset: 0x001F31AC
		private KeyCode GGMAKIMPGHJ(KeyCode AKOENHBOCOD, hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (NPBNCBFNBAF == 2 && this.useController)
			{
				return this.ACIHMMAJIGB(IJAFMJMIJGK);
			}
			if (NPBNCBFNBAF >= 73 && NPBNCBFNBAF <= -76)
			{
				AKOENHBOCOD = KeyCode.None;
				if (!this.useController)
				{
					NPBNCBFNBAF = 0;
				}
			}
			return AKOENHBOCOD;
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x001F4FF8 File Offset: 0x001F31F8
		public void CBPLAPNKKEC(string EBEHBBDKDFJ)
		{
			for (int i = 1; i < this.inputs.Length; i++)
			{
				if (this.inputs[i].keyName.Equals(EBEHBBDKDFJ))
				{
					if (PlayerPrefs.HasKey("_LightIntensity" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey(" not exist" + this.inputs[i].keyName);
					}
					if (PlayerPrefs.HasKey("PUNCloudBestRegion" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("_Value4" + this.inputs[i].keyName);
					}
					this.keyMaps[this.inputs[i].keyName].keyInput = this.ADGLLCIHPPK(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyInput2 = this.KOMNAAJCNPN(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					this.keyMaps[this.inputs[i].keyName].keyWheelState = this.KLMPGIKGLFD(this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.KLMPGIKGLFD(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					break;
				}
			}
			Debug.Log("[DiscordController] Responding no to Ask to Join request" + EBEHBBDKDFJ + "_History2ChromaTex");
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x001F5224 File Offset: 0x001F3424
		private KeyCode EIMJIMLIFLL(hardKey.controllerMap IJAFMJMIJGK)
		{
			switch (IJAFMJMIJGK)
			{
			case hardKey.controllerMap.None:
				return (KeyCode)134;
			case hardKey.controllerMap.Square:
				return (KeyCode)77;
			case hardKey.controllerMap.Cross:
				return KeyCode.M;
			case hardKey.controllerMap.Circle:
				return (KeyCode)(-113);
			case hardKey.controllerMap.Triangle:
				return (KeyCode)(-58);
			case hardKey.controllerMap.L1:
				return KeyCode.Exclaim;
			case hardKey.controllerMap.R1:
				return (KeyCode)(-117);
			case hardKey.controllerMap.L2:
				return (KeyCode)25;
			case hardKey.controllerMap.R2:
				return (KeyCode)(-104);
			case hardKey.controllerMap.Share:
				return (KeyCode)(-124);
			case hardKey.controllerMap.Options:
				return KeyCode.G;
			case hardKey.controllerMap.LeftStick:
				return (KeyCode)(-38);
			case hardKey.controllerMap.RightStick:
				return KeyCode.H;
			case hardKey.controllerMap.PSHome:
				return KeyCode.Plus;
			case hardKey.controllerMap.Trackpad:
				return KeyCode.None;
			case hardKey.controllerMap.DPadUp:
				return KeyCode.None;
			case hardKey.controllerMap.DPadDown:
				return KeyCode.None;
			case hardKey.controllerMap.DPadLeft:
				return (KeyCode)1;
			default:
				return (KeyCode)1;
			}
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x001F52E4 File Offset: 0x001F34E4
		public bool GetKey(string AKOENHBOCOD)
		{
			bool result = false;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 5)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.mouseScrollDelta.y > 0f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 2)
			{
				if (Input.mouseScrollDelta.y < 0f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 10 && this.useController)
			{
				if (Input.GetAxis("DPADVER") == 1f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 11 && this.useController)
			{
				if (Input.GetAxis("DPADVER") == -1f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 12 && this.useController)
			{
				if (Input.GetAxis("DPADHOR") == -1f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 13 && this.useController && Input.GetAxis("DPADHOR") == 1f)
			{
				result = true;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 5)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.mouseScrollDelta.y > 0f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2)
			{
				if (Input.mouseScrollDelta.y < 0f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 10 && this.useController)
			{
				if (Input.GetAxis("DPADVER") == 1f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 11 && this.useController)
			{
				if (Input.GetAxis("DPADVER") == -1f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 12 && this.useController)
			{
				if (Input.GetAxis("DPADHOR") < 0f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 13 && this.useController && Input.GetAxis("DPADHOR") < 0f)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x001F5650 File Offset: 0x001F3850
		public void MHKODFJJBFO()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "settings.crosshairopacity";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				string key = str + keyValuePair.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
				string str2 = keyValuePair2.Value.keyInput.ToString();
				string str3 = "Fade";
				KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
				PlayerPrefs.SetString(key, str2 + str3 + keyValuePair3.Value.keyWheelState.ToString());
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str4 = "maps.";
				KeyValuePair<string, hardKey> keyValuePair4 = enumerator2.Current;
				string key2 = str4 + keyValuePair4.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair5 = enumerator2.Current;
				string str5 = keyValuePair5.Value.keyInput2.ToString();
				string str6 = "ticket";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				PlayerPrefs.SetString(key2, str5 + str6 + keyValuePair6.Value.keyWheelState2.ToString());
			}
			PlayerPrefs.Save();
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x001F5778 File Offset: 0x001F3978
		public bool EEHOFPBLFOP(string AKOENHBOCOD)
		{
			bool result = false;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 3)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y > 1324f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 2)
			{
				if (Input.mouseScrollDelta.y < 926f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 8 && this.useController)
			{
				if (Input.GetAxis("player.arrow") == 1866f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -59 && this.useController)
			{
				if (Input.GetAxis(",") == 654f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -55 && this.useController)
			{
				if (Input.GetAxis("_Value") == 1527f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 102 && this.useController && Input.GetAxis("_ThirdTex") == 1469f)
			{
				result = false;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 6)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				if (Input.mouseScrollDelta.y > 1660f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8)
			{
				if (Input.mouseScrollDelta.y < 1531f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 71 && this.useController)
			{
				if (Input.GetAxis("]") == 772f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 92 && this.useController)
			{
				if (Input.GetAxis(" - LOCAL") == 242f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 92 && this.useController)
			{
				if (Input.GetAxis("Submit") < 132f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 48 && this.useController && Input.GetAxis("Scene") < 1122f)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x001F5AE4 File Offset: 0x001F3CE4
		public void HardStartRebind(string MDDCBDHGNPA, bool CKLPEJDAMME, KeyCode FEFOLHEFCKP)
		{
			this.currentBindFrom = null;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			int enfdcphdphc = 0;
			if (FEFOLHEFCKP.ToString().Contains("Joystick1Button") && this.useController)
			{
				enfdcphdphc = 5;
				this.AEOJMNEPCNB(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
			else if (!FEFOLHEFCKP.ToString().Contains("Joystick"))
			{
				this.AEOJMNEPCNB(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x001F5B70 File Offset: 0x001F3D70
		public void resetKey(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.inputs.Length; i++)
			{
				if (this.inputs[i].keyName.Equals(EBEHBBDKDFJ))
				{
					if (PlayerPrefs.HasKey("settings_bindings_" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("settings_bindings_" + this.inputs[i].keyName);
					}
					if (PlayerPrefs.HasKey("settings_bindings_sec_" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("settings_bindings_sec_" + this.inputs[i].keyName);
					}
					this.keyMaps[this.inputs[i].keyName].keyInput = this.PMFEAAANBAH(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyInput2 = this.PMFEAAANBAH(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					this.keyMaps[this.inputs[i].keyName].keyWheelState = this.DGDBKJBHPGL(this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.DGDBKJBHPGL(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					break;
				}
			}
			Debug.Log("The binding '" + EBEHBBDKDFJ + "' has been reset to the fault value");
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x001F5D9C File Offset: 0x001F3F9C
		private void KLILJHJNICK()
		{
			for (int i = 1; i < this.inputs.Length; i++)
			{
				int axisType = this.inputs[i].axisType;
				int axisType2 = this.inputs[i].axisType2;
				if (this.inputs[i].axisType > 0)
				{
					this.inputs[i].primaryKeycode = (KeyCode)1;
				}
				if (this.inputs[i].axisType2 > 0)
				{
					this.inputs[i].secondaryKeycode = (KeyCode)1;
				}
				hardKey hardKey = new hardKey(this.inputs[i].keyName, this.ADGLLCIHPPK(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, axisType), this.KKJOMMJDDGJ(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, axisType2), this.CFDEHHCOMAO(this.inputs[i].controllerOne, axisType), this.GLPFLDOGMOA(this.inputs[i].controllerTwo, axisType2), this.inputs[i].saveKey);
				this.keyMaps.Add(hardKey.keyName, hardKey);
			}
			this.JHKBENOCEGD();
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x001F5EFC File Offset: 0x001F40FC
		public string HBGIABCPKCG(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			string text = string.Empty;
			int num;
			if (!CKLPEJDAMME)
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState;
			}
			else
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput2.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState2;
			}
			if (num == 0)
			{
				if (text.Contains("/"))
				{
					text = text.Replace("#combo", string.Empty);
				}
				else if (text.Contains("GlassesColor"))
				{
					text = text.Replace("CameraFilterPack/Drawing_Comics", "Had to lookup view that wasn't in photonViewList: ");
				}
				else if (text.Contains("_Speed"))
				{
					text = text.Replace("_AdaptationSpeed", "CameraFilterPack/Blend2Camera_Multiply");
				}
				else if (text.Contains(" "))
				{
					text = text.Replace("id", "JoinButton");
				}
				else if (text.Contains(": "))
				{
					text = text.Replace("1332644700", "#useticket");
				}
				else if (text.Contains("event"))
				{
					text = text.Replace("#ok", "LevelEditor/patterns");
				}
				else if (text.Contains("input"))
				{
					text = "deleteall";
				}
				else if (text.Contains("SetSatelliteRotationSpeed"))
				{
					text = "settings.fps";
				}
				else if (text.Contains("CameraFilterPack/Gradients_Hue"))
				{
					text = "#rt";
				}
				else if (text.Contains("EnableRankedNotificationsToggle"))
				{
					text = "Joystick1Button0" + text.Replace(". The group number should be at least 1.", string.Empty);
				}
			}
			else if (num == 0)
			{
				text = "HiddenToggle";
			}
			else if (num == 3)
			{
				text = "_Value";
			}
			else if (num == 0)
			{
				text = "CameraFilterPack/Gradients_Stripe";
			}
			else if (num == 1)
			{
				text = "_TimeX";
			}
			else if (num == 3)
			{
				if (this.controllerType == 0)
				{
					if (text == "Uploading preview image...")
					{
						text = "RestartButton";
					}
					else if (text == "CameraFilterPack/TV_VHS_Rewind")
					{
						text = "CameraFilterPack/TV_WideScreenHV";
					}
					else if (text == "ResourcesConfig")
					{
						text = ":\n";
					}
					else if (text == "VIGNETTE_DESAT")
					{
						text = "_EdgeSharpness";
					}
					else if (text == "CameraFilterPack/BlurTiltShift")
					{
						text = "{0:0} hour{1}, ";
					}
					else if (text == ".lastCheckpoint.incorrectScore")
					{
						text = "Submit";
					}
					else if (text == "_Distortion")
					{
						text = "_TimeX";
					}
					else if (text == "blue")
					{
						text = "#savemapchanges?";
					}
					else if (text == "Joystick1Button")
					{
						text = "player.bluebat";
					}
					else if (text == "_Offsets")
					{
						text = "_EmissionColor";
					}
					else if (text == " in-game items")
					{
						text = "Object ID. Case-Sensitive";
					}
					else if (text == "_Distance")
					{
						text = "default";
					}
					else if (text == "float,0")
					{
						text = "CameraFilterPack_TV_Noise3";
					}
					else if (text == "_Value5")
					{
						text = "MapCreationCanvas";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == " x ")
					{
						text = "If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ";
					}
					else if (text == "n/a")
					{
						text = "GlassDistortion";
					}
					else if (text == "LevelProgressBar")
					{
						text = "hardcoreinfo";
					}
					else if (text == "_FrustumCornersWS")
					{
						text = "y";
					}
					else if (text == "Case-Sensitive")
					{
						text = "_DiffuseColor";
					}
					else if (text == "[ResourcesManager] Load image error: ")
					{
						text = ":\n";
					}
					else if (text == " takes from: ")
					{
						text = "_Blood";
					}
					else if (text == "IntraTime")
					{
						text = "http://steamcommunity.com/sharedfiles/filedetails/?id=";
					}
					else if (text == ".mp3")
					{
						text = "_ScreenResolution";
					}
					else if (text == "_Value2")
					{
						text = "PlaySound";
					}
					else if (text == "RecordButton")
					{
						text = "achievements.21.progress";
					}
					else if (text == "_Luminance")
					{
						text = "_Value";
					}
					else if (text == "_Value3")
					{
						text = "FinalScoreSmallText";
					}
				}
				else if (this.controllerType == 2)
				{
					if (text == "z")
					{
						text = "_RampTex";
					}
					else if (text == "_Distortion")
					{
						text = "???";
					}
					else if (text == "_Value3")
					{
						text = "Set Particles Speed";
					}
					else if (text == "</color>")
					{
						text = "Joystick1Button8";
					}
					else if (text == "_ScreenResolution")
					{
						text = "<start_index> <end_index>";
					}
					else if (text == "End index must in an integer.")
					{
						text = "It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.";
					}
					else if (text == "_HardBlend")
					{
						text = "Inside cells:\n";
					}
					else if (text == "?")
					{
						text = "CameraFilterPack/Vision_Rainbow";
					}
					else if (text == "settings.volume.game")
					{
						text = "_DiffuseColor";
					}
					else if (text == "Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'")
					{
						text = "OPEN";
					}
					else if (text == ": ")
					{
						text = "NetworkScene";
					}
					else if (text == "Player Disconnected")
					{
						text = " Also make sure to disable sprite packing for this sprite.";
					}
					else if (text == "InstantiateRpc")
					{
						text = "shader.frost";
					}
				}
				else if (this.controllerType == 4)
				{
					if (text == "bans.viewed.")
					{
						text = "SetParent";
					}
					else if (text == "icon.png")
					{
						text = ".lastCheckpoint.longestComboScore";
					}
					else if (text == " at ")
					{
						text = "roomDescription";
					}
					else if (text == "value")
					{
						text = "_ScreenResolution";
					}
					else if (text == "https://bugs.khb-soft.ru/set_project.php?project_id=1")
					{
						text = "_ScreenResolution";
					}
					else if (text == "_Value2")
					{
						text = "_Line";
					}
					else if (text == "_Parameter")
					{
						text = "' ping: ";
					}
					else if (text == "\"")
					{
						text = "_TimeX";
					}
					else if (text == "_Blue_G")
					{
						text = "_Value2";
					}
					else if (text == "Share")
					{
						text = "_Fade";
					}
					else if (text == "X")
					{
						text = "_ScreenResolution";
					}
					else if (text == "CameraFilterPack/Distortion_Twist_Square")
					{
						text = " ";
					}
					else if (text == "Added GameObject to prefabDictionary: ")
					{
						text = "_Max";
					}
				}
			}
			else if (num == -91)
			{
				text = "ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.";
			}
			else if (num == 84)
			{
				text = "Failed to InstantiateSceneObject prefab: ";
			}
			else if (num == 22)
			{
				text = "settings_bindings_sec_";
			}
			else if (num == -53)
			{
				text = "ns";
			}
			return text;
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x001F6744 File Offset: 0x001F4944
		private void EGEPLFGKGLI()
		{
			for (int i = 1; i < this.inputs.Length; i++)
			{
				int axisType = this.inputs[i].axisType;
				int axisType2 = this.inputs[i].axisType2;
				if (this.inputs[i].axisType > 1)
				{
					this.inputs[i].primaryKeycode = KeyCode.None;
				}
				if (this.inputs[i].axisType2 > 1)
				{
					this.inputs[i].secondaryKeycode = (KeyCode)1;
				}
				hardKey hardKey = new hardKey(this.inputs[i].keyName, this.ADGLLCIHPPK(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, axisType), this.ABANLHOFHJG(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, axisType2), this.FKOHIOILLGB(this.inputs[i].controllerOne, axisType), this.MKLOMANJMKP(this.inputs[i].controllerTwo, axisType2), this.inputs[i].saveKey);
				this.keyMaps.Add(hardKey.keyName, hardKey);
			}
			this.GELJHKMFIKC();
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x001F68A4 File Offset: 0x001F4AA4
		private void Start()
		{
			for (int i = 0; i < this.inputs.Length; i++)
			{
				int axisType = this.inputs[i].axisType;
				int axisType2 = this.inputs[i].axisType2;
				if (this.inputs[i].axisType > 0)
				{
					this.inputs[i].primaryKeycode = KeyCode.None;
				}
				if (this.inputs[i].axisType2 > 0)
				{
					this.inputs[i].secondaryKeycode = KeyCode.None;
				}
				hardKey hardKey = new hardKey(this.inputs[i].keyName, this.PMFEAAANBAH(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, axisType), this.PMFEAAANBAH(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, axisType2), this.DGDBKJBHPGL(this.inputs[i].controllerOne, axisType), this.DGDBKJBHPGL(this.inputs[i].controllerTwo, axisType2), this.inputs[i].saveKey);
				this.keyMaps.Add(hardKey.keyName, hardKey);
			}
			this.loadBindings();
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x001F6A04 File Offset: 0x001F4C04
		public KeyCode AGIAGGCEGMD(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			KeyCode result;
			try
			{
				if (!CKLPEJDAMME)
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput;
				}
				else
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput2;
				}
			}
			catch
			{
				Debug.LogWarning("_Greenness" + AKOENHBOCOD);
				result = KeyCode.None;
			}
			return result;
		}

		// Token: 0x0600685A RID: 26714 RVA: 0x001F6A70 File Offset: 0x001F4C70
		public void JBCPEEBCPKF(bool KBEGCGHFMMC)
		{
			if (KBEGCGHFMMC)
			{
				Cursor.lockState = CursorLockMode.None;
			}
			else
			{
				Cursor.lockState = CursorLockMode.Locked;
			}
		}

		// Token: 0x0600685B RID: 26715 RVA: 0x001F6A8C File Offset: 0x001F4C8C
		public void NPHBPIEOHCL()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "colorA";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				if (PlayerPrefs.HasKey(str + keyValuePair.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
					if (dictionary[keyValuePair2.Value.keyName].saveKey)
					{
						string str2 = "All bindings reset to default values. PlayerPrefs have been removed for each key.";
						KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
						string @string = PlayerPrefs.GetString(str2 + keyValuePair3.Value.keyName);
						char[] array = new char[1];
						array[1] = 'I';
						string[] array2 = @string.Split(array);
						int num = int.Parse(array2[0]);
						if (this.useController || (!this.useController && (num <= -79 || num >= -102)))
						{
							Dictionary<string, hardKey> dictionary2 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair4 = enumerator.Current;
							dictionary2[keyValuePair4.Value.keyName].keyInput = (KeyCode)Enum.Parse(typeof(KeyCode), array2[1]);
							Dictionary<string, hardKey> dictionary3 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair5 = enumerator.Current;
							dictionary3[keyValuePair5.Value.keyName].keyWheelState = int.Parse(array2[1]);
						}
					}
				}
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str3 = "0";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				if (PlayerPrefs.HasKey(str3 + keyValuePair6.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary4 = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair7 = enumerator2.Current;
					if (dictionary4[keyValuePair7.Value.keyName].saveKey)
					{
						string str4 = "Speed";
						KeyValuePair<string, hardKey> keyValuePair8 = enumerator2.Current;
						string string2 = PlayerPrefs.GetString(str4 + keyValuePair8.Value.keyName);
						char[] array3 = new char[0];
						array3[1] = '<';
						string[] array4 = string2.Split(array3);
						int num2 = int.Parse(array4[1]);
						if (this.useController || (!this.useController && (num2 <= -23 || num2 >= 42)))
						{
							Dictionary<string, hardKey> dictionary5 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair9 = enumerator2.Current;
							dictionary5[keyValuePair9.Value.keyName].keyInput2 = (KeyCode)Enum.Parse(typeof(KeyCode), array4[0]);
							Dictionary<string, hardKey> dictionary6 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair10 = enumerator2.Current;
							dictionary6[keyValuePair10.Value.keyName].keyWheelState2 = int.Parse(array4[1]);
						}
					}
				}
			}
			if (PlayerPrefs.HasKey("threshold") && this.saveControllerType)
			{
				this.controllerType = PlayerPrefs.GetInt("[DiscordController] Responding no to Ask to Join request");
			}
			this.MHKODFJJBFO();
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x001F6D56 File Offset: 0x001F4F56
		public void MouseLock(bool KBEGCGHFMMC)
		{
			if (KBEGCGHFMMC)
			{
				Cursor.lockState = CursorLockMode.Locked;
			}
			else
			{
				Cursor.lockState = CursorLockMode.None;
			}
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x001F6D70 File Offset: 0x001F4F70
		public string HMNIIOFEMND(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			string text = string.Empty;
			int num;
			if (!CKLPEJDAMME)
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState;
			}
			else
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput2.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState2;
			}
			if (num == 0)
			{
				if (text.Contains("Uploading preview image"))
				{
					text = text.Replace("y", string.Empty);
				}
				else if (text.Contains("#getrewardnow "))
				{
					text = text.Replace("USE_UV_BASED_REPROJECTION", "_Offsets");
				}
				else if (text.Contains("Joystick1Button11"))
				{
					text = text.Replace("inventory.selected.", "player.egglipszerotwo");
				}
				else if (text.Contains("You must complete your map before submiting it to Workshop"))
				{
					text = text.Replace("GlassDistortion", "_EdgeThresholdMin");
				}
				else if (text.Contains("_Distortion"))
				{
					text = text.Replace("pointBuffer", "Can't start OFFLINE mode while connected!");
				}
				else if (text.Contains("catched: "))
				{
					text = text.Replace(",viewkeys", "ticket.ticket1");
				}
				else if (text.Contains("Item "))
				{
					text = "_NeutralTonemapperParams1";
				}
				else if (text.Contains("Left"))
				{
					text = "ConfigVersionSlider";
				}
				else if (text.Contains("[LevelEditorScene] Error: Timeout :S"))
				{
					text = "[NetworkManager] Joined room with ";
				}
				else if (text.Contains("System.String"))
				{
					text = "https://www.youtube.com/watch?v=cDVXukrKo74" + text.Replace("_Value7", string.Empty);
				}
			}
			else if (num == 0)
			{
				text = "recipes";
			}
			else if (num == 5)
			{
				text = "/C tasklist";
			}
			else if (num == 4)
			{
				text = "_Value";
			}
			else if (num == 8)
			{
				text = "_Visualize";
			}
			else if (num == 8)
			{
				if (this.controllerType == 0)
				{
					if (text == "RoomDescriptionText")
					{
						text = "Reconnect() disabled the offline mode. No longer offline.";
					}
					else if (text == "skin.no_hit")
					{
						text = "_Params";
					}
					else if (text == "[DiscordController] Init")
					{
						text = "SaveButton";
					}
					else if (text == "_DiffuseColor")
					{
						text = "Reconnect() disabled the offline mode. No longer offline.";
					}
					else if (text == "[EditorEvent] Exception: ")
					{
						text = "_VignettingDirt";
					}
					else if (text == "GlassesColor")
					{
						text = "master";
					}
					else if (text == "Error: Can not set the OnSerialize rate higher than the overall SendRate.")
					{
						text = "CameraFilterPack/TV_Noise";
					}
					else if (text == "steamid")
					{
						text = "127.0.0.1";
					}
					else if (text == "127.0.0.1")
					{
						text = "SetParticlesParticleSpeed";
					}
					else if (text == "inventory.selected.")
					{
						text = "/";
					}
					else if (text == " b.")
					{
						text = "Item invalid. Make sure your mod contains at leats one file.";
					}
					else if (text == "Cant ask anyone else for PickupItem spawn times.")
					{
						text = "error";
					}
					else if (text == "TransferOwnership() view ")
					{
						text = "SpeedSlider";
					}
					else if (text == "ViewMenu")
					{
						text = "\\n";
					}
				}
				else if (this.controllerType == 1)
				{
					if (text == "_Val3")
					{
						text = "float,10";
					}
					else if (text == "maps.")
					{
						text = "Validating mod pack...";
					}
					else if (text == "_Greenness")
					{
						text = "Joystick1Button5";
					}
					else if (text == "Intensity")
					{
						text = "_ScreenResolution";
					}
					else if (text == "Fade")
					{
						text = "' found!";
					}
					else if (text == "NewMapHandsCountSlider")
					{
						text = "_StretchWidth";
					}
					else if (text == "_Blend")
					{
						text = "CameraFilterPack/Colors_DarkColor";
					}
					else if (text == "\"")
					{
						text = "_BlueAmplifier";
					}
					else if (text == "CameraFilterPack_RainFX_Anm2")
					{
						text = "checkpoint";
					}
					else if (text == "_Distortion")
					{
						text = "_Value7";
					}
					else if (text == " ")
					{
						text = "<color=white>";
					}
					else if (text == "[Up]")
					{
						text = "_Value";
					}
					else if (text == "settings.hideui")
					{
						text = "_Color_G";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "id")
					{
						text = "MenuScene";
					}
					else if (text == "_TimeX")
					{
						text = "_Value";
					}
					else if (text == "Object ID. Case-Sensitive")
					{
						text = "PhotonView with ID ";
					}
					else if (text == "float,0")
					{
						text = "InventoryContent";
					}
					else if (text == "PossibleMapPointsText")
					{
						text = "settings.selectormapsperpage";
					}
					else if (text == "DISTORT")
					{
						text = "player.xp";
					}
					else if (text == "_Amount")
					{
						text = "_BlurArea";
					}
					else if (text == "move")
					{
						text = "settings_bindings_";
					}
					else if (text == "curScn")
					{
						text = "PenaltyScoreText";
					}
					else if (text == "HighScaleShot")
					{
						text = "AddEnvironmentSprite";
					}
					else if (text == "Bad parameters for reset! Use \"reset <challengeid>\"")
					{
						text = "No Name";
					}
					else if (text == "_Value")
					{
						text = "_Offsets";
					}
					else if (text == "_Green_R")
					{
						text = "Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction";
					}
				}
				else if (this.controllerType == 2)
				{
					if (text == "SetParticlesEmission")
					{
						text = "PUN-instantiated '";
					}
					else if (text == "_Value")
					{
						text = "_Value";
					}
					else if (text == "_TimeX")
					{
						text = "Joystick1Button2";
					}
					else if (text == "_BlurVector")
					{
						text = "GameScene";
					}
					else if (text == "position")
					{
						text = "_Value";
					}
					else if (text == "_BlurredColor")
					{
						text = ":";
					}
					else if (text == "_Value13")
					{
						text = "Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change";
					}
					else if (text == " cannot be used as a 3D LUT.")
					{
						text = " != ";
					}
					else if (text == "Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results")
					{
						text = "float,0";
					}
					else if (text == "UseFinalGlassColor")
					{
						text = "RedoButton";
					}
					else if (text == "IconImage")
					{
						text = "shader.none";
					}
					else if (text == "CameraFilterPack/Colors_Threshold")
					{
						text = "{0}";
					}
					else if (text == "accuracy")
					{
						text = "_Value";
					}
				}
			}
			else if (num == 125)
			{
				text = "_MainTex2";
			}
			else if (num == 39)
			{
				text = "_Value4";
			}
			else if (num == 57)
			{
				text = "Fade";
			}
			else if (num == -117)
			{
				text = "_ProjectToPixelMatrix";
			}
			return text;
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x001F75B8 File Offset: 0x001F57B8
		private void FJNCHGLIEMA()
		{
			for (int i = 1; i < this.inputs.Length; i++)
			{
				int axisType = this.inputs[i].axisType;
				int axisType2 = this.inputs[i].axisType2;
				if (this.inputs[i].axisType > 1)
				{
					this.inputs[i].primaryKeycode = KeyCode.None;
				}
				if (this.inputs[i].axisType2 > 1)
				{
					this.inputs[i].secondaryKeycode = (KeyCode)1;
				}
				hardKey hardKey = new hardKey(this.inputs[i].keyName, this.OHOFOPDJKAB(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, axisType), this.PMFEAAANBAH(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, axisType2), this.BFFMNNNMPGD(this.inputs[i].controllerOne, axisType), this.BFFMNNNMPGD(this.inputs[i].controllerTwo, axisType2), this.inputs[i].saveKey);
				this.keyMaps.Add(hardKey.keyName, hardKey);
			}
			this.JHKBENOCEGD();
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x001F7718 File Offset: 0x001F5918
		public bool LBGDAHDPJGF(string AKOENHBOCOD)
		{
			bool result = false;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 6)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.mouseScrollDelta.y > 1150f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 7)
			{
				if (Input.mouseScrollDelta.y < 1209f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -72 && this.useController)
			{
				if (Input.GetAxis("_Light2") == 1033f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -16 && this.useController)
			{
				if (Input.GetAxis("ok") == 1306f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -72 && this.useController)
			{
				if (Input.GetAxis(" from: ") == 862f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 105 && this.useController && Input.GetAxis("Fade") == 879f)
			{
				result = true;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				if (Input.mouseScrollDelta.y > 1685f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 4)
			{
				if (Input.mouseScrollDelta.y < 769f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -123 && this.useController)
			{
				if (Input.GetAxis(" | ") == 53f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 45 && this.useController)
			{
				if (Input.GetAxis("_Noise") == 788f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -106 && this.useController)
			{
				if (Input.GetAxis(" ") < 181f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -32 && this.useController && Input.GetAxis("w") < 352f)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x001F7A81 File Offset: 0x001F5C81
		public void ELEAJJPHHBG(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
		{
			this.currentBindFrom = FEFOLHEFCKP;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			base.StartCoroutine(this.OMHEPOFKCDH());
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x001F7AA8 File Offset: 0x001F5CA8
		private int BFFMNNNMPGD(hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (!this.useController)
			{
				if (NPBNCBFNBAF >= 43 && NPBNCBFNBAF <= 30)
				{
					return 0;
				}
				return NPBNCBFNBAF;
			}
			else
			{
				switch (IJAFMJMIJGK)
				{
				case (hardKey.controllerMap)95:
					return 36;
				case (hardKey.controllerMap)96:
					return 83;
				case (hardKey.controllerMap)97:
					return 99;
				case (hardKey.controllerMap)98:
					return -18;
				default:
					return NPBNCBFNBAF;
				}
			}
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x001F7B00 File Offset: 0x001F5D00
		public void EKHECHADALG()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "EventSystem";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				string key = str + keyValuePair.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
				string str2 = keyValuePair2.Value.keyInput.ToString();
				string str3 = "OK";
				KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
				PlayerPrefs.SetString(key, str2 + str3 + keyValuePair3.Value.keyWheelState.ToString());
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str4 = "CameraFilterPack/Blend2Camera_Difference";
				KeyValuePair<string, hardKey> keyValuePair4 = enumerator2.Current;
				string key2 = str4 + keyValuePair4.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair5 = enumerator2.Current;
				string str5 = keyValuePair5.Value.keyInput2.ToString();
				string str6 = "SetParent";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				PlayerPrefs.SetString(key2, str5 + str6 + keyValuePair6.Value.keyWheelState2.ToString());
			}
			PlayerPrefs.Save();
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x001F7C28 File Offset: 0x001F5E28
		public void JCNIOFNEBGC()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "_TimeX";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				string key = str + keyValuePair.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
				string str2 = keyValuePair2.Value.keyInput.ToString();
				string str3 = "settings.shaders.bloomintencity";
				KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
				PlayerPrefs.SetString(key, str2 + str3 + keyValuePair3.Value.keyWheelState.ToString());
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str4 = "_ScreenResolution";
				KeyValuePair<string, hardKey> keyValuePair4 = enumerator2.Current;
				string key2 = str4 + keyValuePair4.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair5 = enumerator2.Current;
				string str5 = keyValuePair5.Value.keyInput2.ToString();
				string str6 = ",";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				PlayerPrefs.SetString(key2, str5 + str6 + keyValuePair6.Value.keyWheelState2.ToString());
			}
			PlayerPrefs.Save();
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x001F7D50 File Offset: 0x001F5F50
		public KeyCode GetKeyCode(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			KeyCode result;
			try
			{
				if (!CKLPEJDAMME)
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput;
				}
				else
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput2;
				}
			}
			catch
			{
				Debug.LogWarning("Failed to 'GetKeyCode' for key: " + AKOENHBOCOD);
				result = KeyCode.None;
			}
			return result;
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x001F7DBC File Offset: 0x001F5FBC
		private void AEOJMNEPCNB(string HLIMCDFHPGC, KeyCode EFKFJOKDOIH, int ENFDCPHDPHC)
		{
			if (EFKFJOKDOIH == KeyCode.Delete)
			{
				EFKFJOKDOIH = KeyCode.None;
			}
			if (!this.replaceSecond)
			{
				this.keyMaps[HLIMCDFHPGC].keyInput = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState = ENFDCPHDPHC;
			}
			else
			{
				this.keyMaps[HLIMCDFHPGC].keyInput2 = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState2 = ENFDCPHDPHC;
			}
			if (this.currentBindFrom != null)
			{
				this.currentBindFrom.beingBound = false;
			}
			this.SaveBindings();
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x001F7E50 File Offset: 0x001F6050
		public void KECCJEELHJE()
		{
			for (int i = 0; i < this.inputs.Length; i += 0)
			{
				if (PlayerPrefs.HasKey("Did not read byte array properly" + this.inputs[i].keyName))
				{
					PlayerPrefs.DeleteKey("GlassesColor2" + this.inputs[i].keyName);
				}
				if (PlayerPrefs.HasKey("EventConfigButton" + this.inputs[i].keyName))
				{
					PlayerPrefs.DeleteKey("SelectorMusicToggle" + this.inputs[i].keyName);
				}
				this.keyMaps[this.inputs[i].keyName].keyInput = this.ADGLLCIHPPK(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
				this.keyMaps[this.inputs[i].keyName].keyInput2 = this.PMFEAAANBAH(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
				this.keyMaps[this.inputs[i].keyName].keyWheelState = this.GLPFLDOGMOA(this.inputs[i].controllerOne, this.inputs[i].axisType);
				this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.GDHIFOHJLIA(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
			}
			if (PlayerPrefs.HasKey("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change."))
			{
				PlayerPrefs.DeleteKey("SetEnvSpriteColor");
			}
			Debug.Log("UI Extensions/UILinearDodge");
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x001F806C File Offset: 0x001F626C
		private KeyCode KKJOMMJDDGJ(KeyCode AKOENHBOCOD, hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (NPBNCBFNBAF == 2 && this.useController)
			{
				return this.MACGBCMIJAC(IJAFMJMIJGK);
			}
			if (NPBNCBFNBAF >= -77 && NPBNCBFNBAF <= -28)
			{
				AKOENHBOCOD = KeyCode.None;
				if (!this.useController)
				{
					NPBNCBFNBAF = 1;
				}
			}
			return AKOENHBOCOD;
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x001F80B8 File Offset: 0x001F62B8
		public void PCAGIGPDFKK()
		{
			for (int i = 1; i < this.inputs.Length; i += 0)
			{
				if (PlayerPrefs.HasKey("mapselector.orderby" + this.inputs[i].keyName))
				{
					PlayerPrefs.DeleteKey("SetSunLerpSpeed" + this.inputs[i].keyName);
				}
				if (PlayerPrefs.HasKey("LogStats" + this.inputs[i].keyName))
				{
					PlayerPrefs.DeleteKey("_Intensity" + this.inputs[i].keyName);
				}
				this.keyMaps[this.inputs[i].keyName].keyInput = this.ABANLHOFHJG(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
				this.keyMaps[this.inputs[i].keyName].keyInput2 = this.ABANLHOFHJG(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
				this.keyMaps[this.inputs[i].keyName].keyWheelState = this.DGDBKJBHPGL(this.inputs[i].controllerOne, this.inputs[i].axisType);
				this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.KLMPGIKGLFD(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
			}
			if (PlayerPrefs.HasKey("<color=#"))
			{
				PlayerPrefs.DeleteKey(" Remote called.");
			}
			Debug.Log("_TimeX");
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x001F82FC File Offset: 0x001F64FC
		public void LDCDBIBDNAN(string EBEHBBDKDFJ)
		{
			for (int i = 1; i < this.inputs.Length; i++)
			{
				if (this.inputs[i].keyName.Equals(EBEHBBDKDFJ))
				{
					if (PlayerPrefs.HasKey("_Overlay" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("_VignetteTex" + this.inputs[i].keyName);
					}
					if (PlayerPrefs.HasKey("_Far" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("_Value3" + this.inputs[i].keyName);
					}
					this.keyMaps[this.inputs[i].keyName].keyInput = this.KOMNAAJCNPN(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyInput2 = this.OHOFOPDJKAB(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					this.keyMaps[this.inputs[i].keyName].keyWheelState = this.KLMPGIKGLFD(this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.GDHIFOHJLIA(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					break;
				}
			}
			Debug.Log("_MainTexBlurred" + EBEHBBDKDFJ + "float,0");
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x001F8528 File Offset: 0x001F6728
		public string GetKeyName(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			string text = string.Empty;
			int num;
			if (!CKLPEJDAMME)
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState;
			}
			else
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput2.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState2;
			}
			if (num == 0)
			{
				if (text.Contains("Alpha"))
				{
					text = text.Replace("Alpha", string.Empty);
				}
				else if (text.Contains("Keypad"))
				{
					text = text.Replace("Keypad", "Keypad ");
				}
				else if (text.Contains("Left"))
				{
					text = text.Replace("Left", "Left ");
				}
				else if (text.Contains("Right"))
				{
					text = text.Replace("Right", "Right ");
				}
				else if (text.Contains("Up"))
				{
					text = text.Replace("Up", "Up ");
				}
				else if (text.Contains("Down"))
				{
					text = text.Replace("Down", "Down ");
				}
				else if (text.Contains("Mouse0"))
				{
					text = "Left Click";
				}
				else if (text.Contains("Mouse1"))
				{
					text = "Right Click";
				}
				else if (text.Contains("Mouse2"))
				{
					text = "Middle Click";
				}
				else if (text.Contains("Mouse"))
				{
					text = "Mouse " + text.Replace("Mouse", string.Empty);
				}
			}
			else if (num == 1)
			{
				text = "Mouse Wheel Up";
			}
			else if (num == 2)
			{
				text = "Mouse Wheel Down";
			}
			else if (num == 3)
			{
				text = "Mouse X";
			}
			else if (num == 4)
			{
				text = "Mouse Y";
			}
			else if (num == 5)
			{
				if (this.controllerType == 0)
				{
					if (text == "Joystick1Button0")
					{
						text = "Square";
					}
					else if (text == "Joystick1Button1")
					{
						text = "Cross";
					}
					else if (text == "Joystick1Button2")
					{
						text = "Circle";
					}
					else if (text == "Joystick1Button3")
					{
						text = "Triangle";
					}
					else if (text == "Joystick1Button4")
					{
						text = "L1";
					}
					else if (text == "Joystick1Button5")
					{
						text = "R1";
					}
					else if (text == "Joystick1Button6")
					{
						text = "L2";
					}
					else if (text == "Joystick1Button7")
					{
						text = "R2";
					}
					else if (text == "Joystick1Button8")
					{
						text = "Share";
					}
					else if (text == "Joystick1Button9")
					{
						text = "Options";
					}
					else if (text == "Joystick1Button10")
					{
						text = "Left Stick Click";
					}
					else if (text == "Joystick1Button11")
					{
						text = "Right Stick Click";
					}
					else if (text == "Joystick1Button12")
					{
						text = "PS Home";
					}
					else if (text == "JoystickButton13")
					{
						text = "Trackpad";
					}
				}
				else if (this.controllerType == 1)
				{
					if (text == "Joystick1Button0")
					{
						text = "Square";
					}
					else if (text == "Joystick1Button1")
					{
						text = "Cross";
					}
					else if (text == "Joystick1Button2")
					{
						text = "Circle";
					}
					else if (text == "Joystick1Button3")
					{
						text = "Triangle";
					}
					else if (text == "Joystick1Button4")
					{
						text = "L1";
					}
					else if (text == "Joystick1Button5")
					{
						text = "R1";
					}
					else if (text == "Joystick1Button6")
					{
						text = "L2";
					}
					else if (text == "Joystick1Button7")
					{
						text = "R2";
					}
					else if (text == "Joystick1Button8")
					{
						text = "Select";
					}
					else if (text == "Joystick1Button9")
					{
						text = "Start";
					}
					else if (text == "Joystick1Button10")
					{
						text = "Left Stick Click";
					}
					else if (text == "Joystick1Button11")
					{
						text = "Right Stick Click";
					}
					else if (text == "Joystick1Button12")
					{
						text = "PS Home";
					}
				}
				else if (this.controllerType == 2)
				{
					if (text == "Joystick1Button0")
					{
						text = "X";
					}
					else if (text == "Joystick1Button1")
					{
						text = "A";
					}
					else if (text == "Joystick1Button2")
					{
						text = "B";
					}
					else if (text == "Joystick1Button3")
					{
						text = "Y";
					}
					else if (text == "Joystick1Button4")
					{
						text = "LB";
					}
					else if (text == "Joystick1Button5")
					{
						text = "RB";
					}
					else if (text == "Joystick1Button6")
					{
						text = "LT";
					}
					else if (text == "Joystick1Button7")
					{
						text = "RT";
					}
					else if (text == "Joystick1Button8")
					{
						text = "View";
					}
					else if (text == "Joystick1Button9")
					{
						text = "Menu";
					}
					else if (text == "Joystick1Button10")
					{
						text = "Left Stick Click";
					}
					else if (text == "Joystick1Button11")
					{
						text = "Right Stick Click";
					}
					else if (text == "Joystick1Button12")
					{
						text = "Xbox Home";
					}
				}
				else if (this.controllerType == 3)
				{
					if (text == "Joystick1Button0")
					{
						text = "X";
					}
					else if (text == "Joystick1Button1")
					{
						text = "A";
					}
					else if (text == "Joystick1Button2")
					{
						text = "B";
					}
					else if (text == "Joystick1Button3")
					{
						text = "Y";
					}
					else if (text == "Joystick1Button4")
					{
						text = "LB";
					}
					else if (text == "Joystick1Button5")
					{
						text = "RB";
					}
					else if (text == "Joystick1Button6")
					{
						text = "LT";
					}
					else if (text == "Joystick1Button7")
					{
						text = "RT";
					}
					else if (text == "Joystick1Button8")
					{
						text = "Back";
					}
					else if (text == "Joystick1Button9")
					{
						text = "Start";
					}
					else if (text == "Joystick1Button10")
					{
						text = "Left Stick Click";
					}
					else if (text == "Joystick1Button11")
					{
						text = "Right Stick Click";
					}
					else if (text == "Joystick1Button12")
					{
						text = "Xbox Home";
					}
				}
			}
			else if (num == 10)
			{
				text = "D-Pad Up";
			}
			else if (num == 11)
			{
				text = "D-Pad Down";
			}
			else if (num == 12)
			{
				text = "D-Pad Right";
			}
			else if (num == 13)
			{
				text = "D-Pad Left";
			}
			return text;
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x001F8D70 File Offset: 0x001F6F70
		public bool ILIEIBNOPHM(string AKOENHBOCOD)
		{
			bool result = true;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 3)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y > 130f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.mouseScrollDelta.y < 607f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 104 && this.useController)
			{
				if (Input.GetAxis("_Value2") == 240f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 113 && this.useController)
			{
				if (Input.GetAxis("(\\[ *b *\\])") == 940f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 114 && this.useController)
			{
				if (Input.GetAxis("settings.hitvariation") == 818f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -123 && this.useController && Input.GetAxis("SupportLogger OnApplicationPause: ") == 1241f)
			{
				result = false;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				if (Input.mouseScrollDelta.y > 1812f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 5)
			{
				if (Input.mouseScrollDelta.y < 838f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -61 && this.useController)
			{
				if (Input.GetAxis("{0} hours ago") == 11f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 90 && this.useController)
			{
				if (Input.GetAxis("CrosshairOpacitySlider") == 460f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 39 && this.useController)
			{
				if (Input.GetAxis("Lightning") < 38f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 31 && this.useController && Input.GetAxis("STICKRVER") < 1253f)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x001F90DC File Offset: 0x001F72DC
		public void GBGNJCKMJLG()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "ArcsNoHitsoundTimeDelaySlider";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				if (PlayerPrefs.HasKey(str + keyValuePair.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
					if (dictionary[keyValuePair2.Value.keyName].saveKey)
					{
						string str2 = "RoomPlayersCountText";
						KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
						string @string = PlayerPrefs.GetString(str2 + keyValuePair3.Value.keyName);
						char[] array = new char[0];
						array[1] = 'v';
						string[] array2 = @string.Split(array);
						int num = int.Parse(array2[0]);
						if (this.useController || (!this.useController && (num <= -128 || num >= 83)))
						{
							Dictionary<string, hardKey> dictionary2 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair4 = enumerator.Current;
							dictionary2[keyValuePair4.Value.keyName].keyInput = (KeyCode)Enum.Parse(typeof(KeyCode), array2[1]);
							Dictionary<string, hardKey> dictionary3 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair5 = enumerator.Current;
							dictionary3[keyValuePair5.Value.keyName].keyWheelState = int.Parse(array2[0]);
						}
					}
				}
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str3 = "turn";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				if (PlayerPrefs.HasKey(str3 + keyValuePair6.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary4 = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair7 = enumerator2.Current;
					if (dictionary4[keyValuePair7.Value.keyName].saveKey)
					{
						string str4 = "IncorrectHitsScoreText";
						KeyValuePair<string, hardKey> keyValuePair8 = enumerator2.Current;
						string string2 = PlayerPrefs.GetString(str4 + keyValuePair8.Value.keyName);
						char[] array3 = new char[1];
						array3[1] = '=';
						string[] array4 = string2.Split(array3);
						int num2 = int.Parse(array4[0]);
						if (this.useController || (!this.useController && (num2 <= -67 || num2 >= 9)))
						{
							Dictionary<string, hardKey> dictionary5 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair9 = enumerator2.Current;
							dictionary5[keyValuePair9.Value.keyName].keyInput2 = (KeyCode)Enum.Parse(typeof(KeyCode), array4[1]);
							Dictionary<string, hardKey> dictionary6 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair10 = enumerator2.Current;
							dictionary6[keyValuePair10.Value.keyName].keyWheelState2 = int.Parse(array4[1]);
						}
					}
				}
			}
			if (PlayerPrefs.HasKey("_ScreenResolution") && this.saveControllerType)
			{
				this.controllerType = PlayerPrefs.GetInt(".played");
			}
			this.EKHECHADALG();
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x001F93A8 File Offset: 0x001F75A8
		public void FDIJEBJPPNP()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "Joystick1Button9";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				if (PlayerPrefs.HasKey(str + keyValuePair.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
					if (dictionary[keyValuePair2.Value.keyName].saveKey)
					{
						string str2 = "LostLive";
						KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
						string @string = PlayerPrefs.GetString(str2 + keyValuePair3.Value.keyName);
						char[] array = new char[0];
						array[1] = (char)-49;
						string[] array2 = @string.Split(array);
						int num = int.Parse(array2[1]);
						if (this.useController || (!this.useController && (num <= -23 || num >= 90)))
						{
							Dictionary<string, hardKey> dictionary2 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair4 = enumerator.Current;
							dictionary2[keyValuePair4.Value.keyName].keyInput = (KeyCode)Enum.Parse(typeof(KeyCode), array2[0]);
							Dictionary<string, hardKey> dictionary3 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair5 = enumerator.Current;
							dictionary3[keyValuePair5.Value.keyName].keyWheelState = int.Parse(array2[1]);
						}
					}
				}
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str3 = "menu.selectedplaymode";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				if (PlayerPrefs.HasKey(str3 + keyValuePair6.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary4 = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair7 = enumerator2.Current;
					if (dictionary4[keyValuePair7.Value.keyName].saveKey)
					{
						string str4 = "_Value2";
						KeyValuePair<string, hardKey> keyValuePair8 = enumerator2.Current;
						string string2 = PlayerPrefs.GetString(str4 + keyValuePair8.Value.keyName);
						char[] array3 = new char[0];
						array3[1] = (char)-96;
						string[] array4 = string2.Split(array3);
						int num2 = int.Parse(array4[0]);
						if (this.useController || (!this.useController && (num2 <= 19 || num2 >= -115)))
						{
							Dictionary<string, hardKey> dictionary5 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair9 = enumerator2.Current;
							dictionary5[keyValuePair9.Value.keyName].keyInput2 = (KeyCode)Enum.Parse(typeof(KeyCode), array4[1]);
							Dictionary<string, hardKey> dictionary6 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair10 = enumerator2.Current;
							dictionary6[keyValuePair10.Value.keyName].keyWheelState2 = int.Parse(array4[1]);
						}
					}
				}
			}
			if (PlayerPrefs.HasKey("LevelURLInputField") && this.saveControllerType)
			{
				this.controllerType = PlayerPrefs.GetInt("CheckpointsScoreText");
			}
			this.DGDMGPLLPNG();
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x001F6D56 File Offset: 0x001F4F56
		public void AHLAJOFJBOC(bool KBEGCGHFMMC)
		{
			if (KBEGCGHFMMC)
			{
				Cursor.lockState = CursorLockMode.Locked;
			}
			else
			{
				Cursor.lockState = CursorLockMode.None;
			}
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x001F9674 File Offset: 0x001F7874
		public string HDELGDBGOCG(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			string text = string.Empty;
			int num;
			if (!CKLPEJDAMME)
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState;
			}
			else
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput2.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState2;
			}
			if (num == 0)
			{
				if (text.Contains(" "))
				{
					text = text.Replace(": ", string.Empty);
				}
				else if (text.Contains(": "))
				{
					text = text.Replace("[ResourcesManager] Load image error: ", " not exist");
				}
				else if (text.Contains("SAVE"))
				{
					text = text.Replace("_TimeX", "_Blue_B");
				}
				else if (text.Contains("_TimeX"))
				{
					text = text.Replace("_ScreenResolution", "id");
				}
				else if (text.Contains("MenuPlayButton"))
				{
					text = text.Replace("_SweaterSize", "workshop.");
				}
				else if (text.Contains("_Distortion"))
				{
					text = text.Replace("_TimeX", "_MainTex2");
				}
				else if (text.Contains("_Value2"))
				{
					text = "OnDeserialize";
				}
				else if (text.Contains("mapselector.orderby"))
				{
					text = "_TimeX";
				}
				else if (text.Contains("The number of objects sent via a PhotonStreamQueue has to be the same each frame"))
				{
					text = "[TextSaver] Text saved to ";
				}
				else if (text.Contains("Internal LUT"))
				{
					text = "Bad parameters for setbool! Use <key> <value>" + text.Replace("PlayerBase_", string.Empty);
				}
			}
			else if (num == 1)
			{
				text = "_TimeX";
			}
			else if (num == 1)
			{
				text = "CameraFilterPack/Blend2Camera_Subtract";
			}
			else if (num == 7)
			{
				text = "menutheme.melancholicose";
			}
			else if (num == 3)
			{
				text = "_TileMaxLoop";
			}
			else if (num == 5)
			{
				if (this.controllerType == 0)
				{
					if (text == "#failed")
					{
						text = "_ScreenResolution";
					}
					else if (text == "_AlphaUV")
					{
						text = "_MainTex2";
					}
					else if (text == ".lastCheckpoint.correctScore")
					{
						text = "Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception";
					}
					else if (text == "_ScreenResolution")
					{
						text = "open";
					}
					else if (text == "There is already a virtual button named ")
					{
						text = "{0} days ago";
					}
					else if (text == "settings.fps")
					{
						text = "_Value2";
					}
					else if (text == "ItemsCountText")
					{
						text = "settings.enablehitsoundsinnormal";
					}
					else if (text == "Joystick1Button7")
					{
						text = "_Value4";
					}
					else if (text == "TotalHitsScoreText")
					{
						text = "resource id";
					}
					else if (text == "B")
					{
						text = "Hex value #RRGGBB";
					}
					else if (text == "Tab1Content")
					{
						text = "_Blue_R";
					}
					else if (text == "MenuScene")
					{
						text = "_Value4";
					}
					else if (text == "_Value4")
					{
						text = "_ScreenResolution";
					}
					else if (text == "Editor/")
					{
						text = "_ScreenResolution";
					}
				}
				else if (this.controllerType == 1)
				{
					if (text == "id")
					{
						text = "[RanksSystem] Init";
					}
					else if (text == "_History1LumaTex")
					{
						text = "#combo";
					}
					else if (text == "Fade")
					{
						text = " Time: ";
					}
					else if (text == "ItemsCountText")
					{
						text = "[DiscordController] Responding no to Ask to Join request";
					}
					else if (text == "_Value3")
					{
						text = "CameraFilterPack/Distortion_Twist_Square";
					}
					else if (text == "Case-Sensitive")
					{
						text = "_ColorBuffer";
					}
					else if (text == ".workshop.json")
					{
						text = "Fade";
					}
					else if (text == "SetSatelliteColor")
					{
						text = "/";
					}
					else if (text == "Hidden/Image Effects/Cinematic/Bloom")
					{
						text = " ";
					}
					else if (text == "CameraFilterPack/Blend2Camera_Hue")
					{
						text = "_Distortion";
					}
					else if (text == "[LevelEditorScene] Error: Timeout :S")
					{
						text = "Drop_Near";
					}
					else if (text == "checkpoint")
					{
						text = "ItemsCountText";
					}
					else if (text == "SetSatelliteRotationSpeed")
					{
						text = "RanksButton";
					}
				}
				else if (this.controllerType == 1)
				{
					if (text == "CameraFilterPack/Glow_Glow")
					{
						text = "VisionBlur";
					}
					else if (text == "maps.")
					{
						text = "ConfigVersionSlider";
					}
					else if (text == "_ScreenResolution")
					{
						text = "editor.";
					}
					else if (text == "_TapMedium")
					{
						text = ".g";
					}
					else if (text == "[DiscordController] Init")
					{
						text = "...";
					}
					else if (text == "_ScreenResolution")
					{
						text = "_TimeX";
					}
					else if (text == "_SpotSize")
					{
						text = "LoadingStatusText";
					}
					else if (text == "maps.")
					{
						text = "#ok";
					}
					else if (text == " not exist")
					{
						text = "Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings";
					}
					else if (text == "Case-Sensitive")
					{
						text = "_RgbTex";
					}
					else if (text == "Event Received")
					{
						text = "Texture2";
					}
					else if (text == "_Value2")
					{
						text = ": ";
					}
					else if (text == "_MainTex2")
					{
						text = " BETA";
					}
				}
				else if (this.controllerType == 5)
				{
					if (text == "editorVolume")
					{
						text = "[Up]";
					}
					else if (text == "Set camera background color")
					{
						text = "_ScreenResolution";
					}
					else if (text == "_FadeFX")
					{
						text = " [";
					}
					else if (text == ":")
					{
						text = "Send";
					}
					else if (text == "The given 2D texture ")
					{
						text = "_Value2";
					}
					else if (text == "_ScreenResolution")
					{
						text = "_Amount";
					}
					else if (text == "#status")
					{
						text = "_ScreenResolution";
					}
					else if (text == "#rt")
					{
						text = "WARNING: rotation axis set to 0 on ";
					}
					else if (text == "AudioSampler")
					{
						text = "MapEnd";
					}
					else if (text == "_BlendTex")
					{
						text = "GenerationMenu";
					}
					else if (text == "_LutTex")
					{
						text = "[MapsData] Found ";
					}
					else if (text == "tintColor")
					{
						text = "Beat Detected";
					}
					else if (text == "Bass")
					{
						text = "_Value2";
					}
				}
			}
			else if (num == -50)
			{
				text = "_ScreenResolution";
			}
			else if (num == 120)
			{
				text = "_Value";
			}
			else if (num == 123)
			{
				text = "<color=#{0}>{1}</color>";
			}
			else if (num == 106)
			{
				text = "offline";
			}
			return text;
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x001F6A70 File Offset: 0x001F4C70
		public void GADCEGEPFCN(bool KBEGCGHFMMC)
		{
			if (KBEGCGHFMMC)
			{
				Cursor.lockState = CursorLockMode.None;
			}
			else
			{
				Cursor.lockState = CursorLockMode.Locked;
			}
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x001F9EBC File Offset: 0x001F80BC
		public bool GetKeyDown(string AKOENHBOCOD)
		{
			bool result = false;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 5)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.mouseScrollDelta.y > 0f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 2)
			{
				if (Input.mouseScrollDelta.y < 0f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 10)
			{
				if (Input.GetAxis("DPADVER") == 1f && Input.GetAxis("DPADVER") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("DPADVER");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 11)
			{
				if (Input.GetAxis("DPADVER") == -1f && Input.GetAxis("DPADVER") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("DPADVER");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 12)
			{
				if (Input.GetAxis("DPADHOR") == 1f && Input.GetAxis("DPADHOR") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("DPADHOR");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 13)
			{
				if (Input.GetAxis("DPADHOR") == -1f && Input.GetAxis("DPADHOR") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("DPADHOR");
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 5)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.mouseScrollDelta.y > 0f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2)
			{
				if (Input.mouseScrollDelta.y < 0f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 10 && this.useController)
			{
				if (Input.GetAxis("DPADVER") == 1f && Input.GetAxis("DPADVER") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("DPADVER");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 11 && this.useController)
			{
				if (Input.GetAxis("DPADVER") == -1f && Input.GetAxis("DPADVER") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("DPADVER");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 12 && this.useController)
			{
				if (Input.GetAxis("DPADHOR") == 1f && Input.GetAxis("DPADHOR") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("DPADHOR");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 13 && this.useController)
			{
				if (Input.GetAxis("DPADHOR") == -1f && Input.GetAxis("DPADHOR") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("DPADHOR");
			}
			return result;
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x001FA3D4 File Offset: 0x001F85D4
		public KeyCode HLJDHFHKHDD(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			KeyCode result;
			try
			{
				if (!CKLPEJDAMME)
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput;
				}
				else
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput2;
				}
			}
			catch
			{
				Debug.LogWarning("_ScreenResolution" + AKOENHBOCOD);
				result = KeyCode.None;
			}
			return result;
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x001FA440 File Offset: 0x001F8640
		public string MKCKJLLCMED(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			string text = string.Empty;
			int num;
			if (!CKLPEJDAMME)
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState;
			}
			else
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput2.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState2;
			}
			if (num == 0)
			{
				if (text.Contains("Editor/"))
				{
					text = text.Replace("<color=#", string.Empty);
				}
				else if (text.Contains("EnableRankingToggle"))
				{
					text = text.Replace("_AlphaHexa", "_Value2");
				}
				else if (text.Contains("_TapLowBackground"))
				{
					text = text.Replace("masterVolume", "Set Satellite Sensitivity");
				}
				else if (text.Contains("/icon"))
				{
					text = text.Replace(" ", "CameraFilterPack/TV_WideScreenHV");
				}
				else if (text.Contains("Editor/"))
				{
					text = text.Replace("_Speed", "_Green_C");
				}
				else if (text.Contains("EditMenu"))
				{
					text = text.Replace("_TimeX", "_AreaTex");
				}
				else if (text.Contains("_Value5"))
				{
					text = "' found!";
				}
				else if (text.Contains("note.2"))
				{
					text = "No font defined. Found font: ";
				}
				else if (text.Contains("_ChannelMixerRed"))
				{
					text = "CameraFilterPack_3D_Computer1";
				}
				else if (text.Contains("{0:0} hour{1}, "))
				{
					text = "Simulate" + text.Replace("_FadeFX", string.Empty);
				}
			}
			else if (num == 0)
			{
				text = "CameraFilterPack/Drawing_Manga5";
			}
			else if (num == 7)
			{
				text = "_Value";
			}
			else if (num == 8)
			{
				text = "#tryagain";
			}
			else if (num == 5)
			{
				text = "Menu";
			}
			else if (num == 8)
			{
				if (this.controllerType == 0)
				{
					if (text == "_MainTex")
					{
						text = "OK";
					}
					else if (text == "Add Environment Object")
					{
						text = "SetBGColor";
					}
					else if (text == "_SizeY")
					{
						text = "MultiplayerButton";
					}
					else if (text == "_ReflectionBufferSize")
					{
						text = "_BlurFilterDistance";
					}
					else if (text == "CurrentTimeLabel")
					{
						text = "&map=";
					}
					else if (text == "_Value")
					{
						text = "Editor";
					}
					else if (text == "CameraFilterPack/Alien_Vision")
					{
						text = "_ScreenResolution";
					}
					else if (text == "_Value4")
					{
						text = "ResourceIDInputField";
					}
					else if (text == "ReplyMatch is false! ")
					{
						text = "settings.volume.game";
					}
					else if (text == "_Distortion")
					{
						text = "ItemNameBGImage";
					}
					else if (text == "Mouse ")
					{
						text = "EnableRankingToggle";
					}
					else if (text == "settings.fps")
					{
						text = "CameraFilterPack/Drawing_BluePrint";
					}
					else if (text == "mapselector.tags.")
					{
						text = "z";
					}
					else if (text == "_Level")
					{
						text = "_FarCamera";
					}
				}
				else if (this.controllerType == 1)
				{
					if (text == "TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}")
					{
						text = "[NetworkManager] Connected to ";
					}
					else if (text == "#pleasewait")
					{
						text = "CameraFilterPack/Light_Water2";
					}
					else if (text == "_BlurVector")
					{
						text = "BadgeText";
					}
					else if (text == "_Threshhold")
					{
						text = "Up";
					}
					else if (text == "SpawnObj")
					{
						text = "steamid";
					}
					else if (text == "<b>Max Score</b>:")
					{
						text = "_Near";
					}
					else if (text == "[MapsStats] Max score: ")
					{
						text = "Bad parameters for getint! Use <key> <value>";
					}
					else if (text == "#C8C8C8FF")
					{
						text = "_Value";
					}
					else if (text == "_TimeX")
					{
						text = ": ";
					}
					else if (text == "_Near")
					{
						text = "player.xp";
					}
					else if (text == "Editor")
					{
						text = "#yes";
					}
					else if (text == "[PlayerController] ")
					{
						text = "settings.selectormapsperpage";
					}
					else if (text == "downloading")
					{
						text = "_Value8";
					}
				}
				else if (this.controllerType == 7)
				{
					if (text == "float,0")
					{
						text = "Command not found!";
					}
					else if (text == "RECORD [R]")
					{
						text = "resource id";
					}
					else if (text == "<b>#")
					{
						text = " methods \"";
					}
					else if (text == "#ok")
					{
						text = "CameraFilterPack/Colors_Adjust_ColorRGB";
					}
					else if (text == "[LobbyPlayerElement] Created lpe for ")
					{
						text = "_CameraToWorldMatrix";
					}
					else if (text == "BitsData")
					{
						text = "_ScreenResolution";
					}
					else if (text == "[Right]")
					{
						text = "MenuVolumeSlider";
					}
					else if (text == "_Value1")
					{
						text = "Cannot send messages when not connected. Either connect to Photon OR use offline mode!";
					}
					else if (text == "/")
					{
						text = "[DiscordController] Error {0}: {1}";
					}
					else if (text == "achievements.21.completed.")
					{
						text = "Set sun beat detection sensitivity";
					}
					else if (text == "{STEAM_CLAN_IMAGE}")
					{
						text = ".workshop.json";
					}
					else if (text == "_Glow")
					{
						text = "_TimeX";
					}
					else if (text == "inventory.itemscash")
					{
						text = "maps.";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "_FixDistance")
					{
						text = "#C8C8C8FF";
					}
					else if (text == "The given 2D texture ")
					{
						text = "id";
					}
					else if (text == "_TimeX")
					{
						text = "Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings";
					}
					else if (text == "/")
					{
						text = "Event Received";
					}
					else if (text == "CameraFilterPack/Glasses_On")
					{
						text = "[ReplayScene] Loading replay: ";
					}
					else if (text == "Items/")
					{
						text = "SetScale";
					}
					else if (text == "Horizontal")
					{
						text = "mapselector.filter.favoriteonly";
					}
					else if (text == ".played")
					{
						text = "_Visualize";
					}
					else if (text == " scene: ")
					{
						text = "CameraFilterPack/TV_Noise";
					}
					else if (text == "/")
					{
						text = "[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(";
					}
					else if (text == "[LevelEditorScene] Print Audio Wave: Start")
					{
						text = "_ScreenResolution";
					}
					else if (text == "CameraFilterPack/Blend2Camera_LinearLight")
					{
						text = "Can't set visible when not in that room.";
					}
					else if (text == "GameMessagesDurationSlider")
					{
						text = "_MainTex2";
					}
				}
			}
			else if (num == 44)
			{
				text = "CameraFilterPack/BlurTiltShift_Hole";
			}
			else if (num == 30)
			{
				text = "Editor";
			}
			else if (num == 21)
			{
				text = "_TimeX";
			}
			else if (num == -10)
			{
				text = "Failed to 'network-remove' GameObject because has no PhotonView components: ";
			}
			return text;
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x001FAC86 File Offset: 0x001F8E86
		public void BAIMLCIHANB(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
		{
			this.currentBindFrom = FEFOLHEFCKP;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			base.StartCoroutine(this.AOPOILFPHPP());
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x001FACAC File Offset: 0x001F8EAC
		public float FALNNGMABKM(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
		{
			if (this.KDHDPECKBJC(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (this.FDECOACMNLK(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue -= IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.JFAAMDHHPMB(AKOENHBOCOD) && !this.EDPNHOAFGAJ(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 716f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1044f, 1098f);
			return this.keyMaps[AKOENHBOCOD].keyValue;
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x001FAD9C File Offset: 0x001F8F9C
		private void DINGPBIKFBO(string HLIMCDFHPGC, KeyCode EFKFJOKDOIH, int ENFDCPHDPHC)
		{
			if (EFKFJOKDOIH == (KeyCode)31)
			{
				EFKFJOKDOIH = (KeyCode)1;
			}
			if (!this.replaceSecond)
			{
				this.keyMaps[HLIMCDFHPGC].keyInput = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState = ENFDCPHDPHC;
			}
			else
			{
				this.keyMaps[HLIMCDFHPGC].keyInput2 = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState2 = ENFDCPHDPHC;
			}
			if (this.currentBindFrom != null)
			{
				this.currentBindFrom.beingBound = false;
			}
			this.SaveBindings();
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x001FAE30 File Offset: 0x001F9030
		public float APOFKODCAJG(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
		{
			if (this.MBPBBEPPFNI(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (this.MBPBBEPPFNI(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue -= IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.ILIEIBNOPHM(AKOENHBOCOD) && !this.JFAAMDHHPMB(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 1067f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1028f, 1953f);
			return this.keyMaps[AKOENHBOCOD].keyValue;
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x001FAF20 File Offset: 0x001F9120
		public void LLKMFDLIDIE(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.inputs.Length; i += 0)
			{
				if (this.inputs[i].keyName.Equals(EBEHBBDKDFJ))
				{
					if (PlayerPrefs.HasKey("MenuScene" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey(".icon" + this.inputs[i].keyName);
					}
					if (PlayerPrefs.HasKey("1.87" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("_Value" + this.inputs[i].keyName);
					}
					this.keyMaps[this.inputs[i].keyName].keyInput = this.JJKFLOFDIBN(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyInput2 = this.GGMAKIMPGHJ(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					this.keyMaps[this.inputs[i].keyName].keyWheelState = this.KLMPGIKGLFD(this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.KLMPGIKGLFD(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					break;
				}
			}
			Debug.Log("_Value5" + EBEHBBDKDFJ + "LeaderboardsButton");
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x001FB14C File Offset: 0x001F934C
		private KeyCode ACIHMMAJIGB(hardKey.controllerMap IJAFMJMIJGK)
		{
			switch (IJAFMJMIJGK)
			{
			case hardKey.controllerMap.None:
				return (KeyCode)(-174);
			case hardKey.controllerMap.Square:
				return (KeyCode)85;
			case hardKey.controllerMap.Cross:
				return (KeyCode)(-155);
			case hardKey.controllerMap.Circle:
				return (KeyCode)(-27);
			case hardKey.controllerMap.Triangle:
				return KeyCode.LeftParen;
			case hardKey.controllerMap.L1:
				return (KeyCode)(-162);
			case hardKey.controllerMap.R1:
				return (KeyCode)(-127);
			case hardKey.controllerMap.L2:
				return (KeyCode)142;
			case hardKey.controllerMap.R2:
				return (KeyCode)81;
			case hardKey.controllerMap.Share:
				return KeyCode.S;
			case hardKey.controllerMap.Options:
				return (KeyCode)(-92);
			case hardKey.controllerMap.LeftStick:
				return (KeyCode)(-155);
			case hardKey.controllerMap.RightStick:
				return (KeyCode)129;
			case hardKey.controllerMap.PSHome:
				return KeyCode.Underscore;
			case hardKey.controllerMap.Trackpad:
				return KeyCode.None;
			case hardKey.controllerMap.DPadUp:
				return KeyCode.None;
			case hardKey.controllerMap.DPadDown:
				return KeyCode.None;
			case hardKey.controllerMap.DPadLeft:
				return (KeyCode)1;
			default:
				return (KeyCode)1;
			}
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x001FB20C File Offset: 0x001F940C
		public void JMJIPLKIBJM()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "PerfectHitsScoreText";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				string key = str + keyValuePair.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
				string str2 = keyValuePair2.Value.keyInput.ToString();
				string str3 = "USE_PREDICATION";
				KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
				PlayerPrefs.SetString(key, str2 + str3 + keyValuePair3.Value.keyWheelState.ToString());
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str4 = "en";
				KeyValuePair<string, hardKey> keyValuePair4 = enumerator2.Current;
				string key2 = str4 + keyValuePair4.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair5 = enumerator2.Current;
				string str5 = keyValuePair5.Value.keyInput2.ToString();
				string str6 = "rd";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				PlayerPrefs.SetString(key2, str5 + str6 + keyValuePair6.Value.keyWheelState2.ToString());
			}
			PlayerPrefs.Save();
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x001FB334 File Offset: 0x001F9534
		public float DIPMFECGHMF(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
		{
			if (this.FDECOACMNLK(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (this.ILIEIBNOPHM(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue -= IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.FDECOACMNLK(AKOENHBOCOD) && !this.MBPBBEPPFNI(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 1764f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 237f, 398f);
			return this.keyMaps[AKOENHBOCOD].keyValue;
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x001FB424 File Offset: 0x001F9624
		private int DGDBKJBHPGL(hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (!this.useController)
			{
				if (NPBNCBFNBAF >= 10 && NPBNCBFNBAF <= 13)
				{
					return 0;
				}
				return NPBNCBFNBAF;
			}
			else
			{
				switch (IJAFMJMIJGK)
				{
				case hardKey.controllerMap.DPadUp:
					return 10;
				case hardKey.controllerMap.DPadDown:
					return 11;
				case hardKey.controllerMap.DPadLeft:
					return 13;
				case hardKey.controllerMap.DPadRight:
					return 12;
				default:
					return NPBNCBFNBAF;
				}
			}
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x001FB47C File Offset: 0x001F967C
		public bool LLHHMEPCPJK(string AKOENHBOCOD)
		{
			bool result = false;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y > 55f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 7)
			{
				if (Input.mouseScrollDelta.y < 358f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -24)
			{
				if (Input.GetAxis("_ScreenResolution") == 1292f && Input.GetAxis("_FixDistance") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("513510");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 51)
			{
				if (Input.GetAxis("Editor/") == 927f && Input.GetAxis("EndlessLoopsScoreText") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis(" left");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 120)
			{
				if (Input.GetAxis("_FixDistance") == 310f && Input.GetAxis("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_TimeX");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 67)
			{
				if (Input.GetAxis("Object ID. Case-Sensitive") == 689f && Input.GetAxis(": ") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("ClearEnvironment");
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 5)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				if (Input.mouseScrollDelta.y > 1208f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2)
			{
				if (Input.mouseScrollDelta.y < 723f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -11 && this.useController)
			{
				if (Input.GetAxis("PLEASE WAIT") == 590f && Input.GetAxis("BadgeText") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Fade");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -35 && this.useController)
			{
				if (Input.GetAxis("DPADVER") == 1345f && Input.GetAxis("Using constructor for new PingNativeStatic()") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis(".status");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 81 && this.useController)
			{
				if (Input.GetAxis("maps.") == 881f && Input.GetAxis("Reset") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Start");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 69 && this.useController)
			{
				if (Input.GetAxis("CameraFilterPack/Blend2Camera_Hue") == 789f && Input.GetAxis("Offline") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("[Sound Manager] Audio clip is null, cannot play sound");
			}
			return result;
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x001FB994 File Offset: 0x001F9B94
		public void LKFFKGMBPIO()
		{
			for (int i = 0; i < this.inputs.Length; i++)
			{
				if (PlayerPrefs.HasKey(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package." + this.inputs[i].keyName))
				{
					PlayerPrefs.DeleteKey("_Wavy" + this.inputs[i].keyName);
				}
				if (PlayerPrefs.HasKey("_FixDistance" + this.inputs[i].keyName))
				{
					PlayerPrefs.DeleteKey("_InvRenderTargetSize" + this.inputs[i].keyName);
				}
				this.keyMaps[this.inputs[i].keyName].keyInput = this.OHOFOPDJKAB(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
				this.keyMaps[this.inputs[i].keyName].keyInput2 = this.JJKFLOFDIBN(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
				this.keyMaps[this.inputs[i].keyName].keyWheelState = this.LPJLPDOAMAA(this.inputs[i].controllerOne, this.inputs[i].axisType);
				this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.GLPFLDOGMOA(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
			}
			if (PlayerPrefs.HasKey("_EmissionGain"))
			{
				PlayerPrefs.DeleteKey("caret");
			}
			Debug.Log("_Value");
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x001FBBB0 File Offset: 0x001F9DB0
		public string DOMEGOCFKKH(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			string text = string.Empty;
			int num;
			if (!CKLPEJDAMME)
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState;
			}
			else
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput2.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState2;
			}
			if (num == 0)
			{
				if (text.Contains("_BlurSize"))
				{
					text = text.Replace("english", string.Empty);
				}
				else if (text.Contains("_Value"))
				{
					text = text.Replace("Classical", "/");
				}
				else if (text.Contains(": "))
				{
					text = text.Replace("_Scale", "The number of objects sent via a PhotonStreamQueue has to be the same each frame");
				}
				else if (text.Contains("ws://"))
				{
					text = text.Replace("settings.arcsnohitsoundtimedelay", "Bad parameters for setbool! Use <key> <value>");
				}
				else if (text.Contains("Set satellite audio input"))
				{
					text = text.Replace("PointerExit ", "BitsData");
				}
				else if (text.Contains("Fade"))
				{
					text = text.Replace("_Distortion", "_Value3");
				}
				else if (text.Contains("RestartButton"))
				{
					text = "Could not execute RPC ";
				}
				else if (text.Contains("_Value2"))
				{
					text = "[MapEditor] Updating map assets";
				}
				else if (text.Contains("Ev DestroyAll! By PlayerId: "))
				{
					text = "--------------------------------";
				}
				else if (text.Contains("id"))
				{
					text = "player.greenarc" + text.Replace("_ScreenResolution", string.Empty);
				}
			}
			else if (num == 0)
			{
				text = "NewMusicFileSelector";
			}
			else if (num == 3)
			{
				text = "https://bitbucket.org/khb-soft/intralismarcsviewer/";
			}
			else if (num == 5)
			{
				text = "_Gain";
			}
			else if (num == 1)
			{
				text = "_ColorBuffer";
			}
			else if (num == 0)
			{
				if (this.controllerType == 0)
				{
					if (text == "OpAuthenticate()")
					{
						text = "-1";
					}
					else if (text == ".")
					{
						text = "_LightIntensity";
					}
					else if (text == "Keypad ")
					{
						text = "Down";
					}
					else if (text == " cannot be used as a 3D LUT.")
					{
						text = "_TimeX";
					}
					else if (text == "_Distortion")
					{
						text = "_TimeX";
					}
					else if (text == "steamid")
					{
						text = "_TimeX";
					}
					else if (text == "UseFinalGlassColor")
					{
						text = "_UserLutTex";
					}
					else if (text == "HandsCountSlider")
					{
						text = " failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ";
					}
					else if (text == "}")
					{
						text = "DPADHOR";
					}
					else if (text == "_DiffuseColor")
					{
						text = "_Value2";
					}
					else if (text == "_TimeX")
					{
						text = "_SphereSize";
					}
					else if (text == "player.greenarc")
					{
						text = "settings.enablehitsoundsinnormal";
					}
					else if (text == "/")
					{
						text = "_Distortion";
					}
					else if (text == "Avoid using this directly. Thanks.")
					{
						text = "_TimeX";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "0.000")
					{
						text = "SpawnObj";
					}
					else if (text == "RootCanvas")
					{
						text = "_BlurVector";
					}
					else if (text == "Uploading content")
					{
						text = "[MapsStats] Difficulty: ";
					}
					else if (text == "CameraFilterPack_Atmosphere_Rain_FX")
					{
						text = "CameraFilterPack_Atmosphere_Rain_FX";
					}
					else if (text == " ownership transfered to: ")
					{
						text = "SetPosition";
					}
					else if (text == "_EmissionColor")
					{
						text = "_Value";
					}
					else if (text == "_DistortionWave")
					{
						text = "_Green_B";
					}
					else if (text == ".status")
					{
						text = ".status";
					}
					else if (text == "settings.fps")
					{
						text = "_ToneCurveRange";
					}
					else if (text == "_Value")
					{
						text = "_TimeX";
					}
					else if (text == "Can't SendMove. Turn is finished by this player.")
					{
						text = "_Value";
					}
					else if (text == "System.String")
					{
						text = "_ScreenResolution";
					}
					else if (text == "value")
					{
						text = "_OcclusionTexture";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "_Value3")
					{
						text = "_Green_R";
					}
					else if (text == ".lastCheckpoint.perfectHits")
					{
						text = "_TimeX";
					}
					else if (text == "CameraFilterPack/TV_Vignetting")
					{
						text = "Image";
					}
					else if (text == "X")
					{
						text = "RequestForPickupItems";
					}
					else if (text == "_Distortion")
					{
						text = "_MainTex";
					}
					else if (text == "win")
					{
						text = "#tryagain";
					}
					else if (text == "MultiplayerButton")
					{
						text = "MapperNameText";
					}
					else if (text == "Drop_Far")
					{
						text = "_EmissionColor";
					}
					else if (text == " cannot be used as a 3D LUT.")
					{
						text = "_ScreenResolution";
					}
					else if (text == "Warning: No Shape Curve set for CurveWaveform.cs on ")
					{
						text = "Scenes List:";
					}
					else if (text == "CameraFilterPack/Blend2Camera_Multiply")
					{
						text = "_MainTex2";
					}
					else if (text == " Path: ")
					{
						text = "RT";
					}
					else if (text == "settings.enablerankingnotifications")
					{
						text = "_BlurVector";
					}
				}
				else if (this.controllerType == 6)
				{
					if (text == "#score")
					{
						text = "_Curve";
					}
					else if (text == "Tab2Content")
					{
						text = "In Network lobby";
					}
					else if (text == "Tab2Content")
					{
						text = ".completed";
					}
					else if (text == "_ScreenResolution")
					{
						text = "_DotSize";
					}
					else if (text == "_ChromaticAberration")
					{
						text = "maps.";
					}
					else if (text == "mapselector.orderby")
					{
						text = "Ignored PU RPC, cause item is inactive. ";
					}
					else if (text == " != ")
					{
						text = "[MapEditor] Loading map: ";
					}
					else if (text == "CameraFilterPack/EXTRA_Rotation")
					{
						text = "skin.";
					}
					else if (text == "CameraFilterPack/TV_BrokenGlass")
					{
						text = "Fill";
					}
					else if (text == "CheckResources () for ")
					{
						text = " ";
					}
					else if (text == "maps.")
					{
						text = "ok";
					}
					else if (text == "/")
					{
						text = "CameraFilterPack/Light_Water2";
					}
					else if (text == "_Value")
					{
						text = "DPADHOR";
					}
				}
			}
			else if (num == -23)
			{
				text = "_TimeX";
			}
			else if (num == -10)
			{
				text = "_Curve";
			}
			else if (num == -37)
			{
				text = "_TimeX";
			}
			else if (num == 93)
			{
				text = "_Value3";
			}
			return text;
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x001F6A70 File Offset: 0x001F4C70
		public void GJKHADOOHAG(bool KBEGCGHFMMC)
		{
			if (KBEGCGHFMMC)
			{
				Cursor.lockState = CursorLockMode.None;
			}
			else
			{
				Cursor.lockState = CursorLockMode.Locked;
			}
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x001FC3F8 File Offset: 0x001FA5F8
		public void DGDMGPLLPNG()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "CameraFilterPack/BlurTiltShift_Hole";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				string key = str + keyValuePair.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
				string str2 = keyValuePair2.Value.keyInput.ToString();
				string str3 = ".highscore";
				KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
				PlayerPrefs.SetString(key, str2 + str3 + keyValuePair3.Value.keyWheelState.ToString());
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str4 = ".lastCheckpoint.comboScore";
				KeyValuePair<string, hardKey> keyValuePair4 = enumerator2.Current;
				string key2 = str4 + keyValuePair4.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair5 = enumerator2.Current;
				string str5 = keyValuePair5.Value.keyInput2.ToString();
				string str6 = "_RampTex";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				PlayerPrefs.SetString(key2, str5 + str6 + keyValuePair6.Value.keyWheelState2.ToString());
			}
			PlayerPrefs.Save();
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x001FC520 File Offset: 0x001FA720
		public float HKJBNBBHFAC(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
		{
			if (this.ILIEIBNOPHM(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (this.EDPNHOAFGAJ(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue -= IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.JFAAMDHHPMB(AKOENHBOCOD) && !this.LBGDAHDPJGF(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 944f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1361f, 740f);
			return this.keyMaps[AKOENHBOCOD].keyValue;
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x001FC610 File Offset: 0x001FA810
		public void FGNFNHNPOHJ(string MDDCBDHGNPA, bool CKLPEJDAMME, KeyCode FEFOLHEFCKP)
		{
			this.currentBindFrom = null;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			int enfdcphdphc = 0;
			if (FEFOLHEFCKP.ToString().Contains("_MainTex2") && this.useController)
			{
				enfdcphdphc = 1;
				this.DINGPBIKFBO(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
			else if (!FEFOLHEFCKP.ToString().Contains("z"))
			{
				this.IJNDKCEDGLA(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x001FC69C File Offset: 0x001FA89C
		public void NLGAJMPLJDF(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.inputs.Length; i++)
			{
				if (this.inputs[i].keyName.Equals(EBEHBBDKDFJ))
				{
					if (PlayerPrefs.HasKey("_Value" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("Setting autoCleanUpPlayerObjects while in a room is not supported." + this.inputs[i].keyName);
					}
					if (PlayerPrefs.HasKey("OpSetPropertiesOfActor()" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("_ScreenResolution" + this.inputs[i].keyName);
					}
					this.keyMaps[this.inputs[i].keyName].keyInput = this.PMFEAAANBAH(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyInput2 = this.ABANLHOFHJG(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					this.keyMaps[this.inputs[i].keyName].keyWheelState = this.GDHIFOHJLIA(this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.BFFMNNNMPGD(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					break;
				}
			}
			Debug.Log("ComboScoreText" + EBEHBBDKDFJ + "F3");
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x001FC8C8 File Offset: 0x001FAAC8
		public void HOHMPDJGDKE(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
		{
			this.currentBindFrom = FEFOLHEFCKP;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			base.StartCoroutine(this.LPLCPEMCBAE());
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x001FC8EC File Offset: 0x001FAAEC
		public float NAAGJBMAELF(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
		{
			if (this.MBPBBEPPFNI(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (this.EDPNHOAFGAJ(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue -= IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.ILIEIBNOPHM(AKOENHBOCOD) && !this.GetKey(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 427f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 953f, 1084f);
			return this.keyMaps[AKOENHBOCOD].keyValue;
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x001FC8C8 File Offset: 0x001FAAC8
		public void LNDLBIHGGDN(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
		{
			this.currentBindFrom = FEFOLHEFCKP;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			base.StartCoroutine(this.LPLCPEMCBAE());
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x001FC9DC File Offset: 0x001FABDC
		public float JPGNPGEHBOI(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
		{
			if (this.MBPBBEPPFNI(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (this.LBGDAHDPJGF(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue -= IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.ILIEIBNOPHM(AKOENHBOCOD) && !this.ILIEIBNOPHM(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 622f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1821f, 1648f);
			return this.keyMaps[AKOENHBOCOD].keyValue;
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x001FCACC File Offset: 0x001FACCC
		public void SaveBindings()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "settings_bindings_";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				string key = str + keyValuePair.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
				string str2 = keyValuePair2.Value.keyInput.ToString();
				string str3 = "^";
				KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
				PlayerPrefs.SetString(key, str2 + str3 + keyValuePair3.Value.keyWheelState.ToString());
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str4 = "settings_bindings_sec_";
				KeyValuePair<string, hardKey> keyValuePair4 = enumerator2.Current;
				string key2 = str4 + keyValuePair4.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair5 = enumerator2.Current;
				string str5 = keyValuePair5.Value.keyInput2.ToString();
				string str6 = "^";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				PlayerPrefs.SetString(key2, str5 + str6 + keyValuePair6.Value.keyWheelState2.ToString());
			}
			PlayerPrefs.Save();
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x001FCBF4 File Offset: 0x001FADF4
		private KeyCode NJBFCMCGEBI(hardKey.controllerMap IJAFMJMIJGK)
		{
			switch (IJAFMJMIJGK)
			{
			case hardKey.controllerMap.Square:
				return (KeyCode)(-54);
			case hardKey.controllerMap.Cross:
				return KeyCode.V;
			case hardKey.controllerMap.Circle:
				return (KeyCode)188;
			case hardKey.controllerMap.Triangle:
				return (KeyCode)80;
			case hardKey.controllerMap.L1:
				return (KeyCode)184;
			case hardKey.controllerMap.R1:
				return KeyCode.RightParen;
			case hardKey.controllerMap.L2:
				return KeyCode.Semicolon;
			case hardKey.controllerMap.R2:
				return (KeyCode)(-29);
			case hardKey.controllerMap.Share:
				return (KeyCode)(-189);
			case hardKey.controllerMap.Options:
				return KeyCode.Alpha9;
			case hardKey.controllerMap.LeftStick:
				return (KeyCode)137;
			case hardKey.controllerMap.RightStick:
				return (KeyCode)(-102);
			case hardKey.controllerMap.PSHome:
				return (KeyCode)29;
			case hardKey.controllerMap.Trackpad:
				return (KeyCode)(-94);
			case hardKey.controllerMap.DPadUp:
				return (KeyCode)1;
			case hardKey.controllerMap.DPadDown:
				return (KeyCode)1;
			case hardKey.controllerMap.DPadLeft:
				return KeyCode.None;
			case hardKey.controllerMap.DPadRight:
				return KeyCode.None;
			default:
				return KeyCode.None;
			}
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x001FCCB4 File Offset: 0x001FAEB4
		public void HJOCNBNLNMG()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "Result for ";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				string key = str + keyValuePair.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
				string str2 = keyValuePair2.Value.keyInput.ToString();
				string str3 = "3d text";
				KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
				PlayerPrefs.SetString(key, str2 + str3 + keyValuePair3.Value.keyWheelState.ToString());
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str4 = "[PlayerController] ";
				KeyValuePair<string, hardKey> keyValuePair4 = enumerator2.Current;
				string key2 = str4 + keyValuePair4.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair5 = enumerator2.Current;
				string str5 = keyValuePair5.Value.keyInput2.ToString();
				string str6 = "CameraFilterPack/3D_Scan_Scene";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				PlayerPrefs.SetString(key2, str5 + str6 + keyValuePair6.Value.keyWheelState2.ToString());
			}
			PlayerPrefs.Save();
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x001FCDDC File Offset: 0x001FAFDC
		public bool BDJBOAIMHGL(string AKOENHBOCOD)
		{
			bool result = true;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 6)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.mouseScrollDelta.y > 161f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y < 464f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -25)
			{
				if (Input.GetAxis("player.watermelon") == 663f && Input.GetAxis("_SoftZDistance") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_Value");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 90)
			{
				if (Input.GetAxis("BadgeText") == 167f && Input.GetAxis("_PixelsPerMeterAtOneMeter") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("PUNCloudBestRegion");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 39)
			{
				if (Input.GetAxis("/") == 1618f && Input.GetAxis("Source directory does not exist or could not be found: ") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Deleted event");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 71)
			{
				if (Input.GetAxis("_CenterX") == 1186f && Input.GetAxis("_Val") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("[RanksSystem] Init");
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 6)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.mouseScrollDelta.y > 398f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2)
			{
				if (Input.mouseScrollDelta.y < 127f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 46 && this.useController)
			{
				if (Input.GetAxis("maps.") == 827f && Input.GetAxis("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("ServerSettings: ");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -45 && this.useController)
			{
				if (Input.GetAxis("Down") == 99f && Input.GetAxis("CameraFilterPack/Blend2Camera_Difference") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("MainThreadExecuter");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -52 && this.useController)
			{
				if (Input.GetAxis("_Value1") == 1397f && Input.GetAxis("_Distortion") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Data/Editor/leveltemplate");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -24 && this.useController)
			{
				if (Input.GetAxis("_Value4") == 1166f && Input.GetAxis("[MenuScene] Error: ") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("BitsData");
			}
			return result;
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x001FD2F1 File Offset: 0x001FB4F1
		public void LJFEBNEOADJ(bool KBEGCGHFMMC)
		{
			if (KBEGCGHFMMC)
			{
				Cursor.lockState = CursorLockMode.None;
			}
			else
			{
				Cursor.lockState = CursorLockMode.None;
			}
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x001FD30C File Offset: 0x001FB50C
		private int CFDEHHCOMAO(hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (!this.useController)
			{
				if (NPBNCBFNBAF >= 127 && NPBNCBFNBAF <= 1)
				{
					return 1;
				}
				return NPBNCBFNBAF;
			}
			else
			{
				switch (IJAFMJMIJGK)
				{
				case hardKey.controllerMap.DPadLeft:
					return 89;
				case hardKey.controllerMap.DPadRight:
					return 47;
				case (hardKey.controllerMap)19:
					return -74;
				case (hardKey.controllerMap)20:
					return -124;
				default:
					return NPBNCBFNBAF;
				}
			}
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x001FD364 File Offset: 0x001FB564
		private void DNOKDAFFPIK(string HLIMCDFHPGC, KeyCode EFKFJOKDOIH, int ENFDCPHDPHC)
		{
			if (EFKFJOKDOIH == (KeyCode)(-60))
			{
				EFKFJOKDOIH = KeyCode.None;
			}
			if (!this.replaceSecond)
			{
				this.keyMaps[HLIMCDFHPGC].keyInput = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState = ENFDCPHDPHC;
			}
			else
			{
				this.keyMaps[HLIMCDFHPGC].keyInput2 = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState2 = ENFDCPHDPHC;
			}
			if (this.currentBindFrom != null)
			{
				this.currentBindFrom.beingBound = false;
			}
			this.JCNIOFNEBGC();
		}

		// Token: 0x06006891 RID: 26769 RVA: 0x001FD3F8 File Offset: 0x001FB5F8
		private void BIDEDFCMIJA(string HLIMCDFHPGC, KeyCode EFKFJOKDOIH, int ENFDCPHDPHC)
		{
			if (EFKFJOKDOIH == (KeyCode)26)
			{
				EFKFJOKDOIH = (KeyCode)1;
			}
			if (!this.replaceSecond)
			{
				this.keyMaps[HLIMCDFHPGC].keyInput = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState = ENFDCPHDPHC;
			}
			else
			{
				this.keyMaps[HLIMCDFHPGC].keyInput2 = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState2 = ENFDCPHDPHC;
			}
			if (this.currentBindFrom != null)
			{
				this.currentBindFrom.beingBound = true;
			}
			this.MHKODFJJBFO();
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x001FD48C File Offset: 0x001FB68C
		private int GLPFLDOGMOA(hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (!this.useController)
			{
				if (NPBNCBFNBAF >= 19 && NPBNCBFNBAF <= -54)
				{
					return 0;
				}
				return NPBNCBFNBAF;
			}
			else
			{
				switch (IJAFMJMIJGK)
				{
				case (hardKey.controllerMap)(-104):
					return 105;
				case (hardKey.controllerMap)(-103):
					return -32;
				case (hardKey.controllerMap)(-102):
					return -48;
				case (hardKey.controllerMap)(-101):
					return 107;
				default:
					return NPBNCBFNBAF;
				}
			}
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x001FD4E4 File Offset: 0x001FB6E4
		private int FKOHIOILLGB(hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (!this.useController)
			{
				if (NPBNCBFNBAF >= -72 && NPBNCBFNBAF <= -81)
				{
					return 0;
				}
				return NPBNCBFNBAF;
			}
			else
			{
				switch (IJAFMJMIJGK)
				{
				case (hardKey.controllerMap)(-25):
					return 89;
				case (hardKey.controllerMap)(-24):
					return -2;
				case (hardKey.controllerMap)(-23):
					return -86;
				case (hardKey.controllerMap)(-22):
					return 58;
				default:
					return NPBNCBFNBAF;
				}
			}
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x001FD53C File Offset: 0x001FB73C
		private void FEPDBECKAMO(string HLIMCDFHPGC, KeyCode EFKFJOKDOIH, int ENFDCPHDPHC)
		{
			if (EFKFJOKDOIH == KeyCode.E)
			{
				EFKFJOKDOIH = KeyCode.None;
			}
			if (!this.replaceSecond)
			{
				this.keyMaps[HLIMCDFHPGC].keyInput = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState = ENFDCPHDPHC;
			}
			else
			{
				this.keyMaps[HLIMCDFHPGC].keyInput2 = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState2 = ENFDCPHDPHC;
			}
			if (this.currentBindFrom != null)
			{
				this.currentBindFrom.beingBound = true;
			}
			this.SaveBindings();
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x001FD5D0 File Offset: 0x001FB7D0
		public void MGHMFJAHGOC(hardInput.controllerType HMGBJCGOLMI)
		{
			switch (HMGBJCGOLMI)
			{
			case hardInput.controllerType.PS3:
				this.controllerType = 0;
				PlayerPrefs.SetInt("#ok", 0);
				break;
			case hardInput.controllerType.PS4:
				this.controllerType = 0;
				PlayerPrefs.SetInt("#random #common #item", 1);
				break;
			case hardInput.controllerType.XBOX1:
				this.controllerType = 0;
				PlayerPrefs.SetInt("_MainTex2", 2);
				break;
			case hardInput.controllerType.XBOX360:
				this.controllerType = 5;
				PlayerPrefs.SetInt("[PlayerController] ", 0);
				break;
			}
			PlayerPrefs.Save();
		}

		// Token: 0x06006896 RID: 26774 RVA: 0x001FD65C File Offset: 0x001FB85C
		public void JDFLEIALCNP()
		{
			for (int i = 0; i < this.inputs.Length; i++)
			{
				if (PlayerPrefs.HasKey("ReplyMatch is false! " + this.inputs[i].keyName))
				{
					PlayerPrefs.DeleteKey("white" + this.inputs[i].keyName);
				}
				if (PlayerPrefs.HasKey("Loading..." + this.inputs[i].keyName))
				{
					PlayerPrefs.DeleteKey("/" + this.inputs[i].keyName);
				}
				this.keyMaps[this.inputs[i].keyName].keyInput = this.PMFEAAANBAH(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
				this.keyMaps[this.inputs[i].keyName].keyInput2 = this.PMFEAAANBAH(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
				this.keyMaps[this.inputs[i].keyName].keyWheelState = this.CFDEHHCOMAO(this.inputs[i].controllerOne, this.inputs[i].axisType);
				this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.GDHIFOHJLIA(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
			}
			if (PlayerPrefs.HasKey("_TimeX"))
			{
				PlayerPrefs.DeleteKey("float,1.5");
			}
			Debug.Log(" not exist");
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x001FD878 File Offset: 0x001FBA78
		private int KLMPGIKGLFD(hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (!this.useController)
			{
				if (NPBNCBFNBAF >= 11 && NPBNCBFNBAF <= 96)
				{
					return 0;
				}
				return NPBNCBFNBAF;
			}
			else
			{
				switch (IJAFMJMIJGK)
				{
				case (hardKey.controllerMap)(-12):
					return -2;
				case (hardKey.controllerMap)(-11):
					return 18;
				case (hardKey.controllerMap)(-10):
					return -101;
				case (hardKey.controllerMap)(-9):
					return -13;
				default:
					return NPBNCBFNBAF;
				}
			}
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x001FD8D0 File Offset: 0x001FBAD0
		private void IJNDKCEDGLA(string HLIMCDFHPGC, KeyCode EFKFJOKDOIH, int ENFDCPHDPHC)
		{
			if (EFKFJOKDOIH == (KeyCode)(-94))
			{
				EFKFJOKDOIH = (KeyCode)1;
			}
			if (!this.replaceSecond)
			{
				this.keyMaps[HLIMCDFHPGC].keyInput = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState = ENFDCPHDPHC;
			}
			else
			{
				this.keyMaps[HLIMCDFHPGC].keyInput2 = EFKFJOKDOIH;
				this.keyMaps[HLIMCDFHPGC].keyWheelState2 = ENFDCPHDPHC;
			}
			if (this.currentBindFrom != null)
			{
				this.currentBindFrom.beingBound = false;
			}
			this.JMJIPLKIBJM();
		}

		// Token: 0x06006899 RID: 26777 RVA: 0x001FD964 File Offset: 0x001FBB64
		private IEnumerator KFCGPOKIMLP()
		{
			yield return new WaitForEndOfFrame();
			if (!this.useController)
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f)
				{
					yield return null;
				}
			}
			else
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f && Input.GetAxis("DPADHOR") == 0f && Input.GetAxis("DPADVER") == 0f)
				{
					yield return null;
				}
			}
			if (Input.mouseScrollDelta.y != 0f)
			{
				if (Input.mouseScrollDelta.y > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 1);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 2);
				}
			}
			else if (this.useController && Input.GetAxis("DPADVER") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADVER") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 10);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 11);
				}
			}
			else if (this.useController && Input.GetAxis("DPADHOR") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADHOR") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 12);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 13);
				}
			}
			else
			{
				IEnumerator enumerator = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						KeyCode keyCode = (KeyCode)obj;
						if (Input.GetKeyDown(keyCode))
						{
							int enfdcphdphc = 0;
							if (keyCode.ToString().Contains("Joystick1Button") && this.useController)
							{
								enfdcphdphc = 5;
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
							else if (!keyCode.ToString().Contains("Joystick"))
							{
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
			yield break;
		}

		// Token: 0x0600689A RID: 26778 RVA: 0x001FD980 File Offset: 0x001FBB80
		private KeyCode OHOFOPDJKAB(KeyCode AKOENHBOCOD, hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (NPBNCBFNBAF == 3 && this.useController)
			{
				return this.LBNBIHMECGJ(IJAFMJMIJGK);
			}
			if (NPBNCBFNBAF >= -51 && NPBNCBFNBAF <= -44)
			{
				AKOENHBOCOD = KeyCode.None;
				if (!this.useController)
				{
					NPBNCBFNBAF = 0;
				}
			}
			return AKOENHBOCOD;
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x001FD9CC File Offset: 0x001FBBCC
		public float KAAAJPGMNCP(string AKOENHBOCOD, float IKOENAGPJCG)
		{
			if (this.MBPBBEPPFNI(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.OJJNMDMGNOP(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 337f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1128f, 1313f);
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 6 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_Bloom0") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 8 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_Value4") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 4 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 5 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_SweaterSize") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 7 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 7 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis(" has been disabled as it's not supported on the current platform.") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 6 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 4 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("ConnectUsingSettings() disabled the offline mode. No longer offline.") * IKOENAGPJCG;
				}
			}
			else if ((this.keyMaps[AKOENHBOCOD].keyWheelState == 100 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 123 && this.useController)) && this.useController)
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_ScreenResolution") * IKOENAGPJCG;
			}
			return Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1195f, 410f);
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x001FDCC8 File Offset: 0x001FBEC8
		public bool MOFCDBDBOOL(string AKOENHBOCOD)
		{
			bool result = true;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 3)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y > 622f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 3)
			{
				if (Input.mouseScrollDelta.y < 1693f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 119)
			{
				if (Input.GetAxis("_TimeX") == 1441f && Input.GetAxis("_ScreenResolution") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("No child content found, exiting..");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 20)
			{
				if (Input.GetAxis("[MenuScene] Error: ") == 1955f && Input.GetAxis("_ScreenResolution") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Tab2Content");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 4)
			{
				if (Input.GetAxis("menu.playedpage") == 941f && Input.GetAxis(": ") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_TimeX");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -104)
			{
				if (Input.GetAxis("_Value3") == 79f && Input.GetAxis("UI Extensions/UI Image Crop") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_RangeScale");
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				if (Input.mouseScrollDelta.y > 130f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2)
			{
				if (Input.mouseScrollDelta.y < 991f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 47 && this.useController)
			{
				if (Input.GetAxis("Value") == 1337f && Input.GetAxis("/GetNews/pinnednewsid") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("workshop.");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -87 && this.useController)
			{
				if (Input.GetAxis("_MainTex2") == 1667f && Input.GetAxis("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("#timeuntilend: ");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -101 && this.useController)
			{
				if (Input.GetAxis(" workshop map(s)") == 306f && Input.GetAxis("YES") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("MenuScene");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 96 && this.useController)
			{
				if (Input.GetAxis("_ScreenResolution") == 1850f && Input.GetAxis(": ") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis(" item(s) in inventory");
			}
			return result;
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x001FE1E0 File Offset: 0x001FC3E0
		public void AMCGDGOHNDE(string EBEHBBDKDFJ)
		{
			for (int i = 1; i < this.inputs.Length; i++)
			{
				if (this.inputs[i].keyName.Equals(EBEHBBDKDFJ))
				{
					if (PlayerPrefs.HasKey("InfoButton" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("_Color2" + this.inputs[i].keyName);
					}
					if (PlayerPrefs.HasKey("_Amount" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("bad" + this.inputs[i].keyName);
					}
					this.keyMaps[this.inputs[i].keyName].keyInput = this.OHOFOPDJKAB(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyInput2 = this.ADGLLCIHPPK(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					this.keyMaps[this.inputs[i].keyName].keyWheelState = this.FKOHIOILLGB(this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.KLMPGIKGLFD(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					break;
				}
			}
			Debug.Log("_Green_B" + EBEHBBDKDFJ + "maps.");
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x001FE40C File Offset: 0x001FC60C
		public void HardStartRebind(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
		{
			this.currentBindFrom = FEFOLHEFCKP;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			base.StartCoroutine(this.HNLGCDEALMM());
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x001FE430 File Offset: 0x001FC630
		private void AEOLJEIDMDB()
		{
			for (int i = 1; i < this.inputs.Length; i++)
			{
				int axisType = this.inputs[i].axisType;
				int axisType2 = this.inputs[i].axisType2;
				if (this.inputs[i].axisType > 1)
				{
					this.inputs[i].primaryKeycode = KeyCode.None;
				}
				if (this.inputs[i].axisType2 > 1)
				{
					this.inputs[i].secondaryKeycode = KeyCode.None;
				}
				hardKey hardKey = new hardKey(this.inputs[i].keyName, this.KKJOMMJDDGJ(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, axisType), this.ADGLLCIHPPK(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, axisType2), this.CFDEHHCOMAO(this.inputs[i].controllerOne, axisType), this.LPJLPDOAMAA(this.inputs[i].controllerTwo, axisType2), this.inputs[i].saveKey);
				this.keyMaps.Add(hardKey.keyName, hardKey);
			}
			this.JHKBENOCEGD();
		}

		// Token: 0x060068A0 RID: 26784 RVA: 0x001F6A70 File Offset: 0x001F4C70
		public void DIOBKGMFAMA(bool KBEGCGHFMMC)
		{
			if (KBEGCGHFMMC)
			{
				Cursor.lockState = CursorLockMode.None;
			}
			else
			{
				Cursor.lockState = CursorLockMode.Locked;
			}
		}

		// Token: 0x060068A1 RID: 26785 RVA: 0x001FE58E File Offset: 0x001FC78E
		public void LOAPPGBKBIE(bool KLJHIMOGHOH)
		{
			Cursor.visible = KLJHIMOGHOH;
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x001FE58E File Offset: 0x001FC78E
		public void GPFKHMIPLEP(bool KLJHIMOGHOH)
		{
			Cursor.visible = KLJHIMOGHOH;
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x001FE598 File Offset: 0x001FC798
		private KeyCode LBNBIHMECGJ(hardKey.controllerMap IJAFMJMIJGK)
		{
			switch (IJAFMJMIJGK)
			{
			case hardKey.controllerMap.Square:
				return (KeyCode)(-120);
			case hardKey.controllerMap.Cross:
				return (KeyCode)(-183);
			case hardKey.controllerMap.Circle:
				return KeyCode.Backslash;
			case hardKey.controllerMap.Triangle:
				return (KeyCode)(-136);
			case hardKey.controllerMap.L1:
				return (KeyCode)68;
			case hardKey.controllerMap.R1:
				return (KeyCode)(-3);
			case hardKey.controllerMap.L2:
				return (KeyCode)65;
			case hardKey.controllerMap.R2:
				return (KeyCode)194;
			case hardKey.controllerMap.Share:
				return (KeyCode)(-1);
			case hardKey.controllerMap.Options:
				return (KeyCode)(-124);
			case hardKey.controllerMap.LeftStick:
				return (KeyCode)(-78);
			case hardKey.controllerMap.RightStick:
				return (KeyCode)(-158);
			case hardKey.controllerMap.PSHome:
				return KeyCode.E;
			case hardKey.controllerMap.Trackpad:
				return (KeyCode)(-74);
			case hardKey.controllerMap.DPadUp:
				return KeyCode.None;
			case hardKey.controllerMap.DPadDown:
				return KeyCode.None;
			case hardKey.controllerMap.DPadLeft:
				return (KeyCode)1;
			case hardKey.controllerMap.DPadRight:
				return KeyCode.None;
			default:
				return KeyCode.None;
			}
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x001FE658 File Offset: 0x001FC858
		private KeyCode CIPFFCPGONN(hardKey.controllerMap IJAFMJMIJGK)
		{
			switch (IJAFMJMIJGK)
			{
			case hardKey.controllerMap.Square:
				return KeyCode.DoubleQuote;
			case hardKey.controllerMap.Cross:
				return (KeyCode)(-33);
			case hardKey.controllerMap.Circle:
				return (KeyCode)(-99);
			case hardKey.controllerMap.Triangle:
				return (KeyCode)(-25);
			case hardKey.controllerMap.L1:
				return (KeyCode)(-20);
			case hardKey.controllerMap.R1:
				return (KeyCode)168;
			case hardKey.controllerMap.L2:
				return KeyCode.Slash;
			case hardKey.controllerMap.R2:
				return KeyCode.L;
			case hardKey.controllerMap.Share:
				return (KeyCode)150;
			case hardKey.controllerMap.Options:
				return KeyCode.RightParen;
			case hardKey.controllerMap.LeftStick:
				return (KeyCode)138;
			case hardKey.controllerMap.RightStick:
				return (KeyCode)190;
			case hardKey.controllerMap.PSHome:
				return (KeyCode)(-95);
			case hardKey.controllerMap.Trackpad:
				return (KeyCode)(-165);
			case hardKey.controllerMap.DPadUp:
				return (KeyCode)1;
			case hardKey.controllerMap.DPadDown:
				return (KeyCode)1;
			case hardKey.controllerMap.DPadLeft:
				return KeyCode.None;
			case hardKey.controllerMap.DPadRight:
				return (KeyCode)1;
			default:
				return (KeyCode)1;
			}
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x001FE718 File Offset: 0x001FC918
		private KeyCode ABANLHOFHJG(KeyCode AKOENHBOCOD, hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (NPBNCBFNBAF == 8 && this.useController)
			{
				return this.CIPFFCPGONN(IJAFMJMIJGK);
			}
			if (NPBNCBFNBAF >= 16 && NPBNCBFNBAF <= 76)
			{
				AKOENHBOCOD = KeyCode.None;
				if (!this.useController)
				{
					NPBNCBFNBAF = 0;
				}
			}
			return AKOENHBOCOD;
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x001FE764 File Offset: 0x001FC964
		private void JECMJNFGBGC()
		{
			for (int i = 0; i < this.inputs.Length; i++)
			{
				int axisType = this.inputs[i].axisType;
				int axisType2 = this.inputs[i].axisType2;
				if (this.inputs[i].axisType > 1)
				{
					this.inputs[i].primaryKeycode = (KeyCode)1;
				}
				if (this.inputs[i].axisType2 > 1)
				{
					this.inputs[i].secondaryKeycode = KeyCode.None;
				}
				hardKey hardKey = new hardKey(this.inputs[i].keyName, this.OHOFOPDJKAB(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, axisType), this.KKJOMMJDDGJ(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, axisType2), this.CFDEHHCOMAO(this.inputs[i].controllerOne, axisType), this.LPJLPDOAMAA(this.inputs[i].controllerTwo, axisType2), this.inputs[i].saveKey);
				this.keyMaps.Add(hardKey.keyName, hardKey);
			}
			this.GELJHKMFIKC();
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x001FE8C4 File Offset: 0x001FCAC4
		public float IFGIEPDAEDM(string AKOENHBOCOD, float IKOENAGPJCG)
		{
			if (this.JFAAMDHHPMB(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.FDECOACMNLK(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 543f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 757f, 1126f);
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 8 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_ScreenResolution") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 4 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_TimeX") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 7 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Set sun colors") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 7 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("CameraFilterPack_3D_Matrix1") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 5 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("CameraFilterPack/BlurTiltShift_Hole") * IKOENAGPJCG;
				}
			}
			else if ((this.keyMaps[AKOENHBOCOD].keyWheelState == -65 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 52 && this.useController)) && this.useController)
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("note.7") * IKOENAGPJCG;
			}
			return Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1935f, 1918f);
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x001FEBC0 File Offset: 0x001FCDC0
		public string DDKHCBANBED(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			string text = string.Empty;
			int num;
			if (!CKLPEJDAMME)
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState;
			}
			else
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput2.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState2;
			}
			if (num == 0)
			{
				if (text.Contains("_Value"))
				{
					text = text.Replace("Fade", string.Empty);
				}
				else if (text.Contains("/"))
				{
					text = text.Replace("_FlipAlphaMask", "FrostCanvas");
				}
				else if (text.Contains("_Value"))
				{
					text = text.Replace("_TimeX", "CameraFilterPack/Colors_Adjust_FullColors");
				}
				else if (text.Contains("SpawnObj"))
				{
					text = text.Replace("The other scroll rect doesnt support scrolling horizontally", "Init");
				}
				else if (text.Contains("00"))
				{
					text = text.Replace("_Value", "1177138211");
				}
				else if (text.Contains("maps."))
				{
					text = text.Replace("_Value3", "OPEN FILE");
				}
				else if (text.Contains("_Speed"))
				{
					text = "EventSystem";
				}
				else if (text.Contains("Joystick1Button3"))
				{
					text = "id";
				}
				else if (text.Contains("pointBuffer"))
				{
					text = "targetColor";
				}
				else if (text.Contains("_ChannelMixerRed"))
				{
					text = "<i>" + text.Replace("_ScreenResolution", string.Empty);
				}
			}
			else if (num == 1)
			{
				text = "CameraFilterPack/FX_Hexagon";
			}
			else if (num == 2)
			{
				text = "blue";
			}
			else if (num == 1)
			{
				text = "x";
			}
			else if (num == 0)
			{
				text = "settings_bindings_sec_";
			}
			else if (num == 1)
			{
				if (this.controllerType == 0)
				{
					if (text == "[PowerUp]")
					{
						text = "[NetworkManager] Connection failed: ";
					}
					else if (text == ",")
					{
						text = "#";
					}
					else if (text == "L2")
					{
						text = "_Value3";
					}
					else if (text == "_MainTex2")
					{
						text = "_TimeX";
					}
					else if (text == "ERROR You have missing MonoBehaviours on your gameobjects!")
					{
						text = "Set sun emission (glow)";
					}
					else if (text == "[LocalizationService] All languages: ")
					{
						text = "CameraFilterPack/Distortion_ShockWave";
					}
					else if (text == "_TimeX")
					{
						text = "RestartButton";
					}
					else if (text == "HandsCountSlider")
					{
						text = "CameraFilterPack/Blur_Blurry";
					}
					else if (text == "???")
					{
						text = "LoadingStatusText";
					}
					else if (text == "_Value3")
					{
						text = "Couldn't call DestroyAll() as only the master client is allowed to call this.";
					}
					else if (text == "SetSatelliteSensitivity")
					{
						text = "_TimeX";
					}
					else if (text == "Y")
					{
						text = "STICKLHOR";
					}
					else if (text == "_TimeX")
					{
						text = "_Value2";
					}
					else if (text == "_Intensity")
					{
						text = "Authentication failed: '{0}' Code: {1}";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "GlassesColor2")
					{
						text = "BestScoreText";
					}
					else if (text == "Right")
					{
						text = ".highscore";
					}
					else if (text == "maps.")
					{
						text = "_ScreenResolution";
					}
					else if (text == "_PositionX")
					{
						text = "_TimeX";
					}
					else if (text == "_TimeX")
					{
						text = "0.00";
					}
					else if (text == "_Near")
					{
						text = "CameraFilterPack/Vision_Psycho";
					}
					else if (text == "_Radius")
					{
						text = "Fade";
					}
					else if (text == ".highscore")
					{
						text = "_NoisePerChannel";
					}
					else if (text == "mapselector.filter.favoriteonly")
					{
						text = "settings.arcsdestroydelay";
					}
					else if (text == "RoomPlayersCountText")
					{
						text = "_TimeX";
					}
					else if (text == "_CenterX")
					{
						text = "player.redlifering";
					}
					else if (text == "menu.hardcoreinfo")
					{
						text = "maps.";
					}
					else if (text == "_ScreenResolution")
					{
						text = "_Speed";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "CameraFilterPack/Vision_Aura")
					{
						text = "_Value";
					}
					else if (text == "_LowRez")
					{
						text = "_ScreenResolution";
					}
					else if (text == "\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)")
					{
						text = "ItemNameBGImage";
					}
					else if (text == "_Value")
					{
						text = "_Value2";
					}
					else if (text == "_FresnelFade")
					{
						text = "RedoButton";
					}
					else if (text == "MultiplayerButton")
					{
						text = "_Value";
					}
					else if (text == "Failed to InstantiateSceneObject prefab: ")
					{
						text = "_Value";
					}
					else if (text == "{0}{1}{2}={3}")
					{
						text = "Working commands:\nreset <challengeid>\nresetall";
					}
					else if (text == "/")
					{
						text = "_FixDistance";
					}
					else if (text == ".mp3")
					{
						text = "[PlayerController] ";
					}
					else if (text == "StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use")
					{
						text = "_ScreenResolution";
					}
					else if (text == "CameraFilterPack/Blend2Camera_Darken")
					{
						text = "_TimeX";
					}
					else if (text == "Tab1Content")
					{
						text = " This is not possible to be called for standalone input. Please check your platform and code where this is called";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "_DistortionLevel")
					{
						text = "GlassAberration";
					}
					else if (text == "_ScreenResolution")
					{
						text = "CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
					}
					else if (text == "_LensDirt")
					{
						text = "_TimeX";
					}
					else if (text == "B")
					{
						text = "CameraFilterPack/Fly_Vision";
					}
					else if (text == "_TimeX")
					{
						text = ".png";
					}
					else if (text == "[Up]")
					{
						text = ".mp3";
					}
					else if (text == "ticket.ticket1")
					{
						text = "ShowTitle";
					}
					else if (text == "_ScreenResolution")
					{
						text = "_TimeX";
					}
					else if (text == "selector")
					{
						text = "_VelocityScale";
					}
					else if (text == "/Saved Games/")
					{
						text = "addNewButton";
					}
					else if (text == "_MainTex2")
					{
						text = "CameraFilterPack/Edge_Edge_filter";
					}
					else if (text == "offsets")
					{
						text = "#";
					}
					else if (text == "No Name")
					{
						text = "/";
					}
				}
			}
			else if (num == -96)
			{
				text = ".completedMaps";
			}
			else if (num == 110)
			{
				text = "\t";
			}
			else if (num == -113)
			{
				text = "_Value3";
			}
			else if (num == 101)
			{
				text = "_TimeX";
			}
			return text;
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x001FF408 File Offset: 0x001FD608
		public void GELJHKMFIKC()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "player.goldarc";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				if (PlayerPrefs.HasKey(str + keyValuePair.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
					if (dictionary[keyValuePair2.Value.keyName].saveKey)
					{
						string str2 = "float,10";
						KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
						string @string = PlayerPrefs.GetString(str2 + keyValuePair3.Value.keyName);
						char[] array = new char[0];
						array[0] = (char)-12;
						string[] array2 = @string.Split(array);
						int num = int.Parse(array2[0]);
						if (this.useController || (!this.useController && (num <= -87 || num >= -71)))
						{
							Dictionary<string, hardKey> dictionary2 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair4 = enumerator.Current;
							dictionary2[keyValuePair4.Value.keyName].keyInput = (KeyCode)Enum.Parse(typeof(KeyCode), array2[0]);
							Dictionary<string, hardKey> dictionary3 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair5 = enumerator.Current;
							dictionary3[keyValuePair5.Value.keyName].keyWheelState = int.Parse(array2[0]);
						}
					}
				}
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str3 = "ScrollPanel";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				if (PlayerPrefs.HasKey(str3 + keyValuePair6.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary4 = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair7 = enumerator2.Current;
					if (dictionary4[keyValuePair7.Value.keyName].saveKey)
					{
						string str4 = "_Value2";
						KeyValuePair<string, hardKey> keyValuePair8 = enumerator2.Current;
						string string2 = PlayerPrefs.GetString(str4 + keyValuePair8.Value.keyName);
						char[] array3 = new char[1];
						array3[1] = (char)-71;
						string[] array4 = string2.Split(array3);
						int num2 = int.Parse(array4[1]);
						if (this.useController || (!this.useController && (num2 <= -15 || num2 >= 110)))
						{
							Dictionary<string, hardKey> dictionary5 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair9 = enumerator2.Current;
							dictionary5[keyValuePair9.Value.keyName].keyInput2 = (KeyCode)Enum.Parse(typeof(KeyCode), array4[0]);
							Dictionary<string, hardKey> dictionary6 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair10 = enumerator2.Current;
							dictionary6[keyValuePair10.Value.keyName].keyWheelState2 = int.Parse(array4[0]);
						}
					}
				}
			}
			if (PlayerPrefs.HasKey("_Green_R") && this.saveControllerType)
			{
				this.controllerType = PlayerPrefs.GetInt("bpmgrid");
			}
			this.EKHECHADALG();
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x001FF6D4 File Offset: 0x001FD8D4
		public float GFIOHABJNCG(string AKOENHBOCOD, float IKOENAGPJCG)
		{
			if (this.KDHDPECKBJC(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.EEHOFPBLFOP(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 1519f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 374f, 981f);
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 3 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 7)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_ScreenResolution") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 2 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 6)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Joystick1Button2") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 4 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 3 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("CameraFilterPack/FX_Spot") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 3 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("traffic") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 5 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("tagElement") * IKOENAGPJCG;
				}
			}
			else if ((this.keyMaps[AKOENHBOCOD].keyWheelState == 49 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 31 && this.useController)) && this.useController)
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_MainTex2") * IKOENAGPJCG;
			}
			return Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1740f, 169f);
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x001FF9D0 File Offset: 0x001FDBD0
		public void EMHAKHKJKMG(string MDDCBDHGNPA, bool CKLPEJDAMME, KeyCode FEFOLHEFCKP)
		{
			this.currentBindFrom = null;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			int enfdcphdphc = 1;
			if (FEFOLHEFCKP.ToString().Contains("_ColorLevel") && this.useController)
			{
				enfdcphdphc = 8;
				this.IJNDKCEDGLA(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
			else if (!FEFOLHEFCKP.ToString().Contains("UseFinalGlassColor"))
			{
				this.IJNDKCEDGLA(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x001FFA5C File Offset: 0x001FDC5C
		public float GCDMKFIGIPC(string AKOENHBOCOD, float IKOENAGPJCG)
		{
			if (this.JFAAMDHHPMB(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.KDHDPECKBJC(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 1274f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1255f, 1159f);
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 8 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 6)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("intensity") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 5)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("R:") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 2 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 7 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_ScratchOffsetScale") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 7 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 5 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("RecordButton") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 5 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Editor/") * IKOENAGPJCG;
				}
			}
			else if ((this.keyMaps[AKOENHBOCOD].keyWheelState == -56 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 107 && this.useController)) && this.useController)
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Missing shader in ") * IKOENAGPJCG;
			}
			return Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1973f, 1117f);
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x001FFD58 File Offset: 0x001FDF58
		public void resetSavedKeys()
		{
			for (int i = 0; i < this.inputs.Length; i++)
			{
				if (PlayerPrefs.HasKey("settings_bindings_" + this.inputs[i].keyName))
				{
					PlayerPrefs.DeleteKey("settings_bindings_" + this.inputs[i].keyName);
				}
				if (PlayerPrefs.HasKey("settings_bindings_sec_" + this.inputs[i].keyName))
				{
					PlayerPrefs.DeleteKey("settings_bindings_sec_" + this.inputs[i].keyName);
				}
				this.keyMaps[this.inputs[i].keyName].keyInput = this.PMFEAAANBAH(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
				this.keyMaps[this.inputs[i].keyName].keyInput2 = this.PMFEAAANBAH(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
				this.keyMaps[this.inputs[i].keyName].keyWheelState = this.DGDBKJBHPGL(this.inputs[i].controllerOne, this.inputs[i].axisType);
				this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.DGDBKJBHPGL(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
			}
			if (PlayerPrefs.HasKey("settings_bindings_controller_type"))
			{
				PlayerPrefs.DeleteKey("settings_bindings_controller_type");
			}
			Debug.Log("All bindings reset to default values. PlayerPrefs have been removed for each key.");
		}

		// Token: 0x060068AE RID: 26798 RVA: 0x001FFF74 File Offset: 0x001FE174
		public void ECIEMPEMHPL(string MDDCBDHGNPA, bool CKLPEJDAMME, KeyCode FEFOLHEFCKP)
		{
			this.currentBindFrom = null;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			int enfdcphdphc = 1;
			if (FEFOLHEFCKP.ToString().Contains("a") && this.useController)
			{
				enfdcphdphc = 0;
				this.IJNDKCEDGLA(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
			else if (!FEFOLHEFCKP.ToString().Contains(","))
			{
				this.BIDEDFCMIJA(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x00200000 File Offset: 0x001FE200
		public void DJFANNNIDNA()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "curScn";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				if (PlayerPrefs.HasKey(str + keyValuePair.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
					if (dictionary[keyValuePair2.Value.keyName].saveKey)
					{
						string str2 = "CameraFilterPack/Vision_Tunnel";
						KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
						string[] array = PlayerPrefs.GetString(str2 + keyValuePair3.Value.keyName).Split(new char[]
						{
							(char)-24
						});
						int num = int.Parse(array[0]);
						if (this.useController || (!this.useController && (num <= -117 || num >= 5)))
						{
							Dictionary<string, hardKey> dictionary2 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair4 = enumerator.Current;
							dictionary2[keyValuePair4.Value.keyName].keyInput = (KeyCode)Enum.Parse(typeof(KeyCode), array[1]);
							Dictionary<string, hardKey> dictionary3 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair5 = enumerator.Current;
							dictionary3[keyValuePair5.Value.keyName].keyWheelState = int.Parse(array[1]);
						}
					}
				}
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str3 = "Scrollbar";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				if (PlayerPrefs.HasKey(str3 + keyValuePair6.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary4 = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair7 = enumerator2.Current;
					if (dictionary4[keyValuePair7.Value.keyName].saveKey)
					{
						string str4 = "NO";
						KeyValuePair<string, hardKey> keyValuePair8 = enumerator2.Current;
						string @string = PlayerPrefs.GetString(str4 + keyValuePair8.Value.keyName);
						char[] array2 = new char[0];
						array2[1] = (char)-85;
						string[] array3 = @string.Split(array2);
						int num2 = int.Parse(array3[1]);
						if (this.useController || (!this.useController && (num2 <= 103 || num2 >= -16)))
						{
							Dictionary<string, hardKey> dictionary5 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair9 = enumerator2.Current;
							dictionary5[keyValuePair9.Value.keyName].keyInput2 = (KeyCode)Enum.Parse(typeof(KeyCode), array3[1]);
							Dictionary<string, hardKey> dictionary6 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair10 = enumerator2.Current;
							dictionary6[keyValuePair10.Value.keyName].keyWheelState2 = int.Parse(array3[1]);
						}
					}
				}
			}
			if (PlayerPrefs.HasKey("x") && this.saveControllerType)
			{
				this.controllerType = PlayerPrefs.GetInt("</color>");
			}
			this.MHKODFJJBFO();
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x002002CC File Offset: 0x001FE4CC
		private KeyCode JJKFLOFDIBN(KeyCode AKOENHBOCOD, hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (NPBNCBFNBAF == 3 && this.useController)
			{
				return this.NJBFCMCGEBI(IJAFMJMIJGK);
			}
			if (NPBNCBFNBAF >= 117 && NPBNCBFNBAF <= 110)
			{
				AKOENHBOCOD = (KeyCode)1;
				if (!this.useController)
				{
					NPBNCBFNBAF = 0;
				}
			}
			return AKOENHBOCOD;
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x00200318 File Offset: 0x001FE518
		public string ANFCJOFGCBE(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			string text = string.Empty;
			int num;
			if (!CKLPEJDAMME)
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState;
			}
			else
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput2.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState2;
			}
			if (num == 0)
			{
				if (text.Contains("_Offsets"))
				{
					text = text.Replace("[MapEditor] Prepairing map editor...", string.Empty);
				}
				else if (text.Contains("CameraFilterPack/Blend2Camera_ColorBurn"))
				{
					text = text.Replace("Found best region: '", "[SERVER] Kicked ");
				}
				else if (text.Contains("PenaltyScoreText"))
				{
					text = text.Replace("_TimeX", "player.xp");
				}
				else if (text.Contains(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation."))
				{
					text = text.Replace("true", "_Offsets");
				}
				else if (text.Contains("MapConfig"))
				{
					text = text.Replace(" ", "Error: you cannot read this stream that you are writing!");
				}
				else if (text.Contains("_TimeX"))
				{
					text = text.Replace("value", "Using constructor for new PingNativeDynamic()");
				}
				else if (text.Contains("[PlayerBase] Loading checkpoint data"))
				{
					text = "Tab1Content";
				}
				else if (text.Contains("CameraFilterPack/Colors_Adjust_PreFilters"))
				{
					text = "_Red_R";
				}
				else if (text.Contains("_ScreenResolution"))
				{
					text = "AreaTex";
				}
				else if (text.Contains("Waiting to start"))
				{
					text = ": " + text.Replace("GlassDistortion", string.Empty);
				}
			}
			else if (num == 0)
			{
				text = "[LevelEditorScene] Error: You're not logged into Steam!";
			}
			else if (num == 6)
			{
				text = "[DiscordController] Disconnect {0}: {1}";
			}
			else if (num == 8)
			{
				text = "public";
			}
			else if (num == 1)
			{
				text = "SpawnObj";
			}
			else if (num == 4)
			{
				if (this.controllerType == 0)
				{
					if (text == "Error: you cannot write/send to this stream that you are reading!")
					{
						text = "GameVolumeSlider";
					}
					else if (text == "_Scale")
					{
						text = "LevelURLInputField";
					}
					else if (text == "settings.enablehitsoundsinnormal")
					{
						text = "_Bloom5";
					}
					else if (text == " timeUntilRespawn: ")
					{
						text = "_Jitter";
					}
					else if (text == " to: ")
					{
						text = "Editor/";
					}
					else if (text == "Object ID. Case-Sensitive")
					{
						text = "Bad parameters for set! Use <language>";
					}
					else if (text == "_TimeX")
					{
						text = "_Value2";
					}
					else if (text == "float")
					{
						text = "Reset";
					}
					else if (text == "_FadeDistance")
					{
						text = "*.workshop.json";
					}
					else if (text == "CameraFilterPack/Blur_DitherOffset")
					{
						text = "_AdaptationSpeed";
					}
					else if (text == "player.arrow")
					{
						text = "settings.fps";
					}
					else if (text == "_Intensity")
					{
						text = "_Near";
					}
					else if (text == "_Threshhold")
					{
						text = "[Up]";
					}
					else if (text == "blue")
					{
						text = "Items/";
					}
				}
				else if (this.controllerType == 1)
				{
					if (text == "_ScreenEdgeFading")
					{
						text = "players";
					}
					else if (text == "Submit")
					{
						text = "_Value3";
					}
					else if (text == "cipherText")
					{
						text = "11";
					}
					else if (text == "_EdgeThreshold")
					{
						text = "Please attach component to a Graphical UI component";
					}
					else if (text == "Mouse0")
					{
						text = "_TimeX";
					}
					else if (text == "[GameEvent] Exeption:")
					{
						text = "#mapnotloaded";
					}
					else if (text == "CameraFilterPack_Sweater")
					{
						text = "_TimeX";
					}
					else if (text == "From {0} at Index {1} \n")
					{
						text = " : ";
					}
					else if (text == "[#clicktoacceptchallenge]")
					{
						text = "_ScreenResolution";
					}
					else if (text == "#ok")
					{
						text = "_CameraToWorldMatrix";
					}
					else if (text == "_Intensity")
					{
						text = "_ScreenResolution";
					}
					else if (text == "#C8C8C8FF")
					{
						text = "_Offsets";
					}
					else if (text == "_Parasite")
					{
						text = "[PlayerController] ";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "[NetworkManager] Found ")
					{
						text = "Object ID. Case-Sensitive";
					}
					else if (text == "ConnectUsingSettings() disabled the offline mode. No longer offline.")
					{
						text = "_Value4";
					}
					else if (text == ",")
					{
						text = "_ScreenResolution";
					}
					else if (text == "_Blue_R")
					{
						text = "ready";
					}
					else if (text == "_Value13")
					{
						text = "Authentication failed: '{0}' Code: {1}";
					}
					else if (text == "CameraFilterPack/Blend2Camera_Darken")
					{
						text = "#tryagain";
					}
					else if (text == "_BlurRadius4")
					{
						text = "_FarCamera";
					}
					else if (text == "Tried to Initialize the SteamAPI twice in one session!")
					{
						text = "[PlayerController] ";
					}
					else if (text == "_MainTexBlurred")
					{
						text = "Color's hex value #RRGGBBAA";
					}
					else if (text == "_Colored")
					{
						text = "/";
					}
					else if (text == "NEW_ACHIEVEMENT_1_21")
					{
						text = "_Value3";
					}
					else if (text == "_VignetteDesat")
					{
						text = "Left";
					}
					else if (text == "_Value2")
					{
						text = "TotalTimeLabel";
					}
				}
				else if (this.controllerType == 2)
				{
					if (text == "3d text")
					{
						text = "Failed to InstantiateSceneObject prefab: ";
					}
					else if (text == "SubmitUserVote:")
					{
						text = "Start";
					}
					else if (text == "_Intensity")
					{
						text = ": ";
					}
					else if (text == "HitVariationSlider")
					{
						text = "_ScreenResolution";
					}
					else if (text == "Error: I/O Failure! :(")
					{
						text = "UsernameText";
					}
					else if (text == "VHS")
					{
						text = "_ScreenResolution";
					}
					else if (text == "UseFinalGlassColor")
					{
						text = "In Network lobby";
					}
					else if (text == "1.87")
					{
						text = "_Value2";
					}
					else if (text == "_Value2")
					{
						text = "CameraFilterPack/TV_Artefact";
					}
					else if (text == "Tab1Content")
					{
						text = "_Rand";
					}
					else if (text == "_ScreenResolution")
					{
						text = "DPADHOR";
					}
					else if (text == "_Value3")
					{
						text = "value";
					}
					else if (text == "/")
					{
						text = "LoadingStatusText";
					}
				}
			}
			else if (num == 124)
			{
				text = "menutheme.coldheat";
			}
			else if (num == 33)
			{
				text = "CameraFilterPack/Color_GrayScale";
			}
			else if (num == 5)
			{
				text = "(\\[ *i *\\])";
			}
			else if (num == -99)
			{
				text = "Keypad ";
			}
			return text;
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x00200B60 File Offset: 0x001FED60
		public void MKIOAGDKPFD(hardInput.controllerType HMGBJCGOLMI)
		{
			switch (HMGBJCGOLMI)
			{
			case hardInput.controllerType.PS3:
				this.controllerType = 0;
				PlayerPrefs.SetInt("Sequence contains no elements", 0);
				break;
			case hardInput.controllerType.PS4:
				this.controllerType = 0;
				PlayerPrefs.SetInt("Creating new item...", 1);
				break;
			case hardInput.controllerType.XBOX1:
				this.controllerType = 4;
				PlayerPrefs.SetInt("Down ", 4);
				break;
			case hardInput.controllerType.XBOX360:
				this.controllerType = 2;
				PlayerPrefs.SetInt("Horizontal", 1);
				break;
			}
			PlayerPrefs.Save();
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x00200BEC File Offset: 0x001FEDEC
		private IEnumerator AOPOILFPHPP()
		{
			yield return new WaitForEndOfFrame();
			if (!this.useController)
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f)
				{
					yield return null;
				}
			}
			else
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f && Input.GetAxis("DPADHOR") == 0f && Input.GetAxis("DPADVER") == 0f)
				{
					yield return null;
				}
			}
			if (Input.mouseScrollDelta.y != 0f)
			{
				if (Input.mouseScrollDelta.y > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 1);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 2);
				}
			}
			else if (this.useController && Input.GetAxis("DPADVER") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADVER") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 10);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 11);
				}
			}
			else if (this.useController && Input.GetAxis("DPADHOR") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADHOR") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 12);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 13);
				}
			}
			else
			{
				IEnumerator enumerator = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						KeyCode keyCode = (KeyCode)obj;
						if (Input.GetKeyDown(keyCode))
						{
							int enfdcphdphc = 0;
							if (keyCode.ToString().Contains("Joystick1Button") && this.useController)
							{
								enfdcphdphc = 5;
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
							else if (!keyCode.ToString().Contains("Joystick"))
							{
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
			yield break;
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x00200C08 File Offset: 0x001FEE08
		private int MKLOMANJMKP(hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (!this.useController)
			{
				if (NPBNCBFNBAF >= -126 && NPBNCBFNBAF <= -32)
				{
					return 0;
				}
				return NPBNCBFNBAF;
			}
			else
			{
				switch (IJAFMJMIJGK)
				{
				case (hardKey.controllerMap)(-112):
					return 44;
				case (hardKey.controllerMap)(-111):
					return 112;
				case (hardKey.controllerMap)(-110):
					return -119;
				case (hardKey.controllerMap)(-109):
					return -74;
				default:
					return NPBNCBFNBAF;
				}
			}
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x00200C60 File Offset: 0x001FEE60
		public float GetAxis(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
		{
			if (this.GetKey(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (this.GetKey(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue -= IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.GetKey(AKOENHBOCOD) && !this.GetKey(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 0f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, -1f, 1f);
			return this.keyMaps[AKOENHBOCOD].keyValue;
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x00200D50 File Offset: 0x001FEF50
		public void setControllerType(hardInput.controllerType HMGBJCGOLMI)
		{
			switch (HMGBJCGOLMI)
			{
			case hardInput.controllerType.PS3:
				this.controllerType = 0;
				PlayerPrefs.SetInt("settings_bindings_controller_type", 0);
				break;
			case hardInput.controllerType.PS4:
				this.controllerType = 1;
				PlayerPrefs.SetInt("settings_bindings_controller_type", 1);
				break;
			case hardInput.controllerType.XBOX1:
				this.controllerType = 2;
				PlayerPrefs.SetInt("settings_bindings_controller_type", 2);
				break;
			case hardInput.controllerType.XBOX360:
				this.controllerType = 3;
				PlayerPrefs.SetInt("settings_bindings_controller_type", 3);
				break;
			}
			PlayerPrefs.Save();
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x00200DDC File Offset: 0x001FEFDC
		public void HJMOHHOAEHL(hardInput.controllerType HMGBJCGOLMI)
		{
			switch (HMGBJCGOLMI)
			{
			case hardInput.controllerType.PS3:
				this.controllerType = 1;
				PlayerPrefs.SetInt("CameraFilterPack/Glasses_On", 0);
				break;
			case hardInput.controllerType.PS4:
				this.controllerType = 1;
				PlayerPrefs.SetInt("BitsData", 1);
				break;
			case hardInput.controllerType.XBOX1:
				this.controllerType = 6;
				PlayerPrefs.SetInt("CameraFilterPack/Blend2Camera_LinearBurn", 1);
				break;
			case hardInput.controllerType.XBOX360:
				this.controllerType = 4;
				PlayerPrefs.SetInt("TotalHitsScoreText", 2);
				break;
			}
			PlayerPrefs.Save();
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x001FE58E File Offset: 0x001FC78E
		public void MouseVisble(bool KLJHIMOGHOH)
		{
			Cursor.visible = KLJHIMOGHOH;
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x00200E68 File Offset: 0x001FF068
		private IEnumerator LPLCPEMCBAE()
		{
			yield return new WaitForEndOfFrame();
			if (!this.useController)
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f)
				{
					yield return null;
				}
			}
			else
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f && Input.GetAxis("DPADHOR") == 0f && Input.GetAxis("DPADVER") == 0f)
				{
					yield return null;
				}
			}
			if (Input.mouseScrollDelta.y != 0f)
			{
				if (Input.mouseScrollDelta.y > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 1);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 2);
				}
			}
			else if (this.useController && Input.GetAxis("DPADVER") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADVER") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 10);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 11);
				}
			}
			else if (this.useController && Input.GetAxis("DPADHOR") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADHOR") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 12);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 13);
				}
			}
			else
			{
				IEnumerator enumerator = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						KeyCode keyCode = (KeyCode)obj;
						if (Input.GetKeyDown(keyCode))
						{
							int enfdcphdphc = 0;
							if (keyCode.ToString().Contains("Joystick1Button") && this.useController)
							{
								enfdcphdphc = 5;
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
							else if (!keyCode.ToString().Contains("Joystick"))
							{
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
			yield break;
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00200E84 File Offset: 0x001FF084
		public string LLHHBNHCIAD(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			string text = string.Empty;
			int num;
			if (!CKLPEJDAMME)
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState;
			}
			else
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput2.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState2;
			}
			if (num == 0)
			{
				if (text.Contains("float,0"))
				{
					text = text.Replace("_Value3", string.Empty);
				}
				else if (text.Contains("[LevelEditorScene] Exported to "))
				{
					text = text.Replace("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", "Warning: No Shape Curve set for CurveWaveform.cs on ");
				}
				else if (text.Contains("]. Please verify you have this gameobject in a Resources folder."))
				{
					text = text.Replace("CameraFilterPack/3D_Scan_Scene", "ExitButton");
				}
				else if (text.Contains("<color=#{0}>{1}</color>"))
				{
					text = text.Replace("_Size", "_ScreenResolution");
				}
				else if (text.Contains("menu.playedpage"))
				{
					text = text.Replace("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", "/icon");
				}
				else if (text.Contains("new round"))
				{
					text = text.Replace("CameraFilterPack/Blend2Camera_LinearDodge", "_ScreenResolution");
				}
				else if (text.Contains("CameraFilterPack/Distortion_BigFace"))
				{
					text = "maps.";
				}
				else if (text.Contains("settings.volume.editor"))
				{
					text = "ResourceFileSelector";
				}
				else if (text.Contains("_SecondTex"))
				{
					text = "icon.png";
				}
				else if (text.Contains("_Value3"))
				{
					text = "Set Particles Input" + text.Replace("_ScreenResolution", string.Empty);
				}
			}
			else if (num == 1)
			{
				text = "\"";
			}
			else if (num == 1)
			{
				text = "IncorrectHitsScoreText";
			}
			else if (num == 7)
			{
				text = "mapselector.filter.subscribedonly";
			}
			else if (num == 5)
			{
				text = "_Color2";
			}
			else if (num == 3)
			{
				if (this.controllerType == 0)
				{
					if (text == "_Value3")
					{
						text = "_MainTex";
					}
					else if (text == "_Red_G")
					{
						text = "/Segment-[Up]";
					}
					else if (text == "Created")
					{
						text = "CrosshairOpacitySlider";
					}
					else if (text == "_ScreenResolution")
					{
						text = "id";
					}
					else if (text == "float,1.5")
					{
						text = "challenges.";
					}
					else if (text == "_Value5")
					{
						text = "_Value4";
					}
					else if (text == "id")
					{
						text = "MenuVolumeSlider";
					}
					else if (text == "Item created: Id: ")
					{
						text = "PointsScoreText";
					}
					else if (text == "_Radius")
					{
						text = "Set Particles Gravity";
					}
					else if (text == " scene view IDs from last level.")
					{
						text = "mapselector.filter.favoriteonly";
					}
					else if (text == "mapselector.lastSearch")
					{
						text = "OpenButton";
					}
					else if (text == "achievements.21.completed.")
					{
						text = "CameraFilterPack/Drawing_Manga2";
					}
					else if (text == "UndoButton")
					{
						text = "_ScreenResolution";
					}
					else if (text == "workshop.")
					{
						text = "L2";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "CameraFilterPack/Colors_RgbClamp")
					{
						text = "settings.enablerankingnotifications";
					}
					else if (text == "_TimeX")
					{
						text = "0.00";
					}
					else if (text == "No valid adaptive tonemapper type found!")
					{
						text = "CameraFilterPack_VHS1";
					}
					else if (text == "0.00")
					{
						text = "USE_PREDICATION";
					}
					else if (text == "_MainTex2")
					{
						text = "MapEditorScene";
					}
					else if (text == "_Value2")
					{
						text = "#tryagain";
					}
					else if (text == "note.2")
					{
						text = "_ScreenResolution";
					}
					else if (text == "_Value")
					{
						text = "&search=";
					}
					else if (text == "</color>")
					{
						text = "Tab2Content";
					}
					else if (text == "Curve texture")
					{
						text = "_LutTex";
					}
					else if (text == "settings.shaders.bloomintencity")
					{
						text = "[MenuScene] Error: ";
					}
					else if (text == " SecondsBeforeRespawn: ")
					{
						text = "_TimeX";
					}
					else if (text == "OK")
					{
						text = "_Angle";
					}
				}
				else if (this.controllerType == 8)
				{
					if (text == "Ok")
					{
						text = "Lerp speed. Recomended 10";
					}
					else if (text == " This is not possible to be called for standalone input. Please check your platform and code where this is called")
					{
						text = "_Visualize";
					}
					else if (text == ": ")
					{
						text = "_Value6";
					}
					else if (text == "inventory.selected.")
					{
						text = "[PlayerController] ";
					}
					else if (text == "SpectatingUserInfo")
					{
						text = "#tryagain";
					}
					else if (text == "_MainTex2")
					{
						text = " scene: ";
					}
					else if (text == "CameraFilterPack/Blur_GaussianBlur")
					{
						text = "_Value2";
					}
					else if (text == "You must complete your map before submiting it to Workshop")
					{
						text = "[ResourcesManager] Load text error: not found";
					}
					else if (text == ". Verify the Prefab is in a Resources folder (and not in a subfolder)")
					{
						text = "Set Satellite Trail MinVertexDistance";
					}
					else if (text == " ")
					{
						text = "R2";
					}
					else if (text == "_MainTex")
					{
						text = "ChallengesButton";
					}
					else if (text == "BadgeText")
					{
						text = "_Value2";
					}
					else if (text == "[Left]")
					{
						text = "_Value3";
					}
				}
				else if (this.controllerType == 8)
				{
					if (text == " is set to dontSave = true, continuing loop.")
					{
						text = "ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ";
					}
					else if (text == "event")
					{
						text = "_WorldToCameraMatrix";
					}
					else if (text == "Fade")
					{
						text = "Received OnSerialization for view ID ";
					}
					else if (text == "win")
					{
						text = "SUBMIT '{0}' FILES";
					}
					else if (text == "Waiting to start")
					{
						text = "_MainTex2";
					}
					else if (text == "ConfigVersionSlider")
					{
						text = "_CenterY";
					}
					else if (text == "[NetworkManager] Join failed")
					{
						text = "_TimeX";
					}
					else if (text == "skin.")
					{
						text = "RB";
					}
					else if (text == "#or")
					{
						text = "_Bullet_5";
					}
					else if (text == "[LevelEditorScene] Updated")
					{
						text = "bans.viewed.";
					}
					else if (text == "CameraFilterPack/FX_Mirror")
					{
						text = "_ScreenResolution";
					}
					else if (text == ".sawoutdatedmessage")
					{
						text = ":";
					}
					else if (text == "player.blackcat")
					{
						text = " - StoreAuthURLResponse] - ";
					}
				}
			}
			else if (num == -11)
			{
				text = "No regions available. Are you sure your appid is valid and setup?";
			}
			else if (num == -36)
			{
				text = "_Value2";
			}
			else if (num == 62)
			{
				text = "CameraFilterPack_OldFilm1";
			}
			else if (num == 65)
			{
				text = "HPToggle";
			}
			return text;
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x002016CC File Offset: 0x001FF8CC
		public bool JFAAMDHHPMB(string AKOENHBOCOD)
		{
			bool result = true;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 3)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y > 988f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 4)
			{
				if (Input.mouseScrollDelta.y < 1254f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -66 && this.useController)
			{
				if (Input.GetAxis("_Offsets") == 1665f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -113 && this.useController)
			{
				if (Input.GetAxis("steamid") == 1669f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 100 && this.useController)
			{
				if (Input.GetAxis(" should be overwritten.") == 1224f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 5 && this.useController && Input.GetAxis("maps.") == 1109f)
			{
				result = true;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 4)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.mouseScrollDelta.y > 571f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8)
			{
				if (Input.mouseScrollDelta.y < 1918f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 51 && this.useController)
			{
				if (Input.GetAxis("maps.") == 413f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -32 && this.useController)
			{
				if (Input.GetAxis("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception") == 888f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -109 && this.useController)
			{
				if (Input.GetAxis("_Value2") < 1600f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 26 && this.useController && Input.GetAxis("ERROR: Make sure your mod contains at leats one file!") < 823f)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x00201A38 File Offset: 0x001FFC38
		public bool AAGBOMOINFK(string AKOENHBOCOD)
		{
			bool result = true;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 2)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.mouseScrollDelta.y > 1884f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 6)
			{
				if (Input.mouseScrollDelta.y < 886f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -44)
			{
				if (Input.GetAxis("id") == 1061f && Input.GetAxis("AvatarImage") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis(" not found");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 82)
			{
				if (Input.GetAxis("_Value") == 410f && Input.GetAxis("0") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_TapLowBackground");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -38)
			{
				if (Input.GetAxis("#tryagain") == 1998f && Input.GetAxis("<b>Intralism Items Uploader</b> by Oxy949") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 45)
			{
				if (Input.GetAxis("hidden") == 15f && Input.GetAxis("status") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("mapid");
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				if (Input.mouseScrollDelta.y > 34f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2)
			{
				if (Input.mouseScrollDelta.y < 1346f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 117 && this.useController)
			{
				if (Input.GetAxis("image") == 614f && Input.GetAxis("[PlayerController] ") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("SetPlayerDistance");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1 && this.useController)
			{
				if (Input.GetAxis("Xbox Home") == 851f && Input.GetAxis("_Value") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("settings.volume.sfx");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8 && this.useController)
			{
				if (Input.GetAxis("MenuScene") == 391f && Input.GetAxis("_DiffuseColor") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Rotate environment object to the rotation");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -4 && this.useController)
			{
				if (Input.GetAxis(" Server: ") == 688f && Input.GetAxis("_Value2") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("BitsData");
			}
			return result;
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x00201F50 File Offset: 0x00200150
		public void CMKEEPJPEIK(string MDDCBDHGNPA, bool CKLPEJDAMME, KeyCode FEFOLHEFCKP)
		{
			this.currentBindFrom = null;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			int enfdcphdphc = 1;
			if (FEFOLHEFCKP.ToString().Contains("Cross") && this.useController)
			{
				enfdcphdphc = 3;
				this.AEOJMNEPCNB(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
			else if (!FEFOLHEFCKP.ToString().Contains(".lastCheckpoint.playerdistance"))
			{
				this.IJNDKCEDGLA(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00201FDC File Offset: 0x002001DC
		public KeyCode HAFLFCKGBMM(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			KeyCode result;
			try
			{
				if (!CKLPEJDAMME)
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput;
				}
				else
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput2;
				}
			}
			catch
			{
				Debug.LogWarning("DPADHOR" + AKOENHBOCOD);
				result = (KeyCode)1;
			}
			return result;
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x00202048 File Offset: 0x00200248
		public bool MBPBBEPPFNI(string AKOENHBOCOD)
		{
			bool result = false;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 2)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.mouseScrollDelta.y > 1499f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.mouseScrollDelta.y < 772f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 125 && this.useController)
			{
				if (Input.GetAxis("CameraFilterPack/TV_Horror") == 1197f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 62 && this.useController)
			{
				if (Input.GetAxis("settings.cameramovements") == 296f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -91 && this.useController)
			{
				if (Input.GetAxis("_TimeX") == 377f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 51 && this.useController && Input.GetAxis("Set satellite trail width") == 1558f)
			{
				result = true;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.mouseScrollDelta.y > 1349f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.mouseScrollDelta.y < 255f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 79 && this.useController)
			{
				if (Input.GetAxis("tip") == 1678f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -64 && this.useController)
			{
				if (Input.GetAxis("speed") == 1246f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -86 && this.useController)
			{
				if (Input.GetAxis("TotalTimeLabel") < 576f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -75 && this.useController && Input.GetAxis("Fade") < 1230f)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x002023B4 File Offset: 0x002005B4
		public float FBPJMFLFDIB(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
		{
			if (this.LBGDAHDPJGF(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (this.EDPNHOAFGAJ(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue -= IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.LBGDAHDPJGF(AKOENHBOCOD) && !this.MBPBBEPPFNI(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 1403f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1231f, 108f);
			return this.keyMaps[AKOENHBOCOD].keyValue;
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x002024A4 File Offset: 0x002006A4
		public KeyCode CLBENCAJDKH(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			KeyCode result;
			try
			{
				if (!CKLPEJDAMME)
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput;
				}
				else
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput2;
				}
			}
			catch
			{
				Debug.LogWarning("_Near" + AKOENHBOCOD);
				result = (KeyCode)1;
			}
			return result;
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x001F7A81 File Offset: 0x001F5C81
		public void AJDKOPKFJCC(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
		{
			this.currentBindFrom = FEFOLHEFCKP;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			base.StartCoroutine(this.OMHEPOFKCDH());
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x00202510 File Offset: 0x00200710
		public void JHKBENOCEGD()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "_ScreenResolution";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				if (PlayerPrefs.HasKey(str + keyValuePair.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
					if (dictionary[keyValuePair2.Value.keyName].saveKey)
					{
						string str2 = "checkpoint";
						KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
						string @string = PlayerPrefs.GetString(str2 + keyValuePair3.Value.keyName);
						char[] array = new char[0];
						array[1] = 'k';
						string[] array2 = @string.Split(array);
						int num = int.Parse(array2[0]);
						if (this.useController || (!this.useController && (num <= 68 || num >= -10)))
						{
							Dictionary<string, hardKey> dictionary2 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair4 = enumerator.Current;
							dictionary2[keyValuePair4.Value.keyName].keyInput = (KeyCode)Enum.Parse(typeof(KeyCode), array2[1]);
							Dictionary<string, hardKey> dictionary3 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair5 = enumerator.Current;
							dictionary3[keyValuePair5.Value.keyName].keyWheelState = int.Parse(array2[1]);
						}
					}
				}
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str3 = "SetParent";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				if (PlayerPrefs.HasKey(str3 + keyValuePair6.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary4 = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair7 = enumerator2.Current;
					if (dictionary4[keyValuePair7.Value.keyName].saveKey)
					{
						string str4 = "masterSteamID";
						KeyValuePair<string, hardKey> keyValuePair8 = enumerator2.Current;
						string string2 = PlayerPrefs.GetString(str4 + keyValuePair8.Value.keyName);
						char[] array3 = new char[0];
						array3[0] = (char)-80;
						string[] array4 = string2.Split(array3);
						int num2 = int.Parse(array4[1]);
						if (this.useController || (!this.useController && (num2 <= 115 || num2 >= -58)))
						{
							Dictionary<string, hardKey> dictionary5 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair9 = enumerator2.Current;
							dictionary5[keyValuePair9.Value.keyName].keyInput2 = (KeyCode)Enum.Parse(typeof(KeyCode), array4[0]);
							Dictionary<string, hardKey> dictionary6 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair10 = enumerator2.Current;
							dictionary6[keyValuePair10.Value.keyName].keyWheelState2 = int.Parse(array4[1]);
						}
					}
				}
			}
			if (PlayerPrefs.HasKey("menu.tabid") && this.saveControllerType)
			{
				this.controllerType = PlayerPrefs.GetInt("[ResourcesManager] Load text error: not found");
			}
			this.DGDMGPLLPNG();
		}

		// Token: 0x060068C4 RID: 26820 RVA: 0x002027DC File Offset: 0x002009DC
		public void PFBDLOENJGP(string MDDCBDHGNPA, bool CKLPEJDAMME, KeyCode FEFOLHEFCKP)
		{
			this.currentBindFrom = null;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			int enfdcphdphc = 1;
			if (FEFOLHEFCKP.ToString().Contains("_TimeX") && this.useController)
			{
				enfdcphdphc = 3;
				this.BIDEDFCMIJA(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
			else if (!FEFOLHEFCKP.ToString().Contains("[Down]"))
			{
				this.IJNDKCEDGLA(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
		}

		// Token: 0x060068C5 RID: 26821 RVA: 0x00202868 File Offset: 0x00200A68
		private KeyCode MACGBCMIJAC(hardKey.controllerMap IJAFMJMIJGK)
		{
			switch (IJAFMJMIJGK)
			{
			case hardKey.controllerMap.Square:
				return KeyCode.Joystick1Button0;
			case hardKey.controllerMap.Cross:
				return KeyCode.Joystick1Button1;
			case hardKey.controllerMap.Circle:
				return KeyCode.Joystick1Button2;
			case hardKey.controllerMap.Triangle:
				return KeyCode.Joystick1Button3;
			case hardKey.controllerMap.L1:
				return KeyCode.Joystick1Button4;
			case hardKey.controllerMap.R1:
				return KeyCode.Joystick1Button5;
			case hardKey.controllerMap.L2:
				return KeyCode.Joystick1Button6;
			case hardKey.controllerMap.R2:
				return KeyCode.Joystick1Button7;
			case hardKey.controllerMap.Share:
				return KeyCode.Joystick1Button8;
			case hardKey.controllerMap.Options:
				return KeyCode.Joystick1Button9;
			case hardKey.controllerMap.LeftStick:
				return KeyCode.Joystick1Button10;
			case hardKey.controllerMap.RightStick:
				return KeyCode.Joystick1Button11;
			case hardKey.controllerMap.PSHome:
				return KeyCode.Joystick1Button12;
			case hardKey.controllerMap.Trackpad:
				return KeyCode.Joystick1Button13;
			case hardKey.controllerMap.DPadUp:
				return KeyCode.None;
			case hardKey.controllerMap.DPadDown:
				return KeyCode.None;
			case hardKey.controllerMap.DPadLeft:
				return KeyCode.None;
			case hardKey.controllerMap.DPadRight:
				return KeyCode.None;
			default:
				return KeyCode.None;
			}
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00202928 File Offset: 0x00200B28
		private KeyCode ADGLLCIHPPK(KeyCode AKOENHBOCOD, hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (NPBNCBFNBAF == 8 && this.useController)
			{
				return this.CIPFFCPGONN(IJAFMJMIJGK);
			}
			if (NPBNCBFNBAF >= -36 && NPBNCBFNBAF <= 67)
			{
				AKOENHBOCOD = KeyCode.None;
				if (!this.useController)
				{
					NPBNCBFNBAF = 1;
				}
			}
			return AKOENHBOCOD;
		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x00202974 File Offset: 0x00200B74
		public float GetAxis(string AKOENHBOCOD, float IKOENAGPJCG)
		{
			if (this.GetKey(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.GetKey(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 0f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, -1f, 1f);
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 3 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 3)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Mouse X") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 4 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 4)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Mouse Y") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 6 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 6 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("STICKLHOR") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 7 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 7 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("STICKLVER") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 8 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("STICKRHOR") * IKOENAGPJCG;
				}
			}
			else if ((this.keyMaps[AKOENHBOCOD].keyWheelState == 9 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 9 && this.useController)) && this.useController)
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("STICKRVER") * IKOENAGPJCG;
			}
			return Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, -1f, 1f);
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x00202C70 File Offset: 0x00200E70
		private IEnumerator BDEAJLHBLHL()
		{
			yield return new WaitForEndOfFrame();
			if (!this.useController)
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f)
				{
					yield return null;
				}
			}
			else
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f && Input.GetAxis("DPADHOR") == 0f && Input.GetAxis("DPADVER") == 0f)
				{
					yield return null;
				}
			}
			if (Input.mouseScrollDelta.y != 0f)
			{
				if (Input.mouseScrollDelta.y > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 1);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 2);
				}
			}
			else if (this.useController && Input.GetAxis("DPADVER") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADVER") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 10);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 11);
				}
			}
			else if (this.useController && Input.GetAxis("DPADHOR") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADHOR") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 12);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 13);
				}
			}
			else
			{
				IEnumerator enumerator = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						KeyCode keyCode = (KeyCode)obj;
						if (Input.GetKeyDown(keyCode))
						{
							int enfdcphdphc = 0;
							if (keyCode.ToString().Contains("Joystick1Button") && this.useController)
							{
								enfdcphdphc = 5;
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
							else if (!keyCode.ToString().Contains("Joystick"))
							{
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
			yield break;
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x00202C8C File Offset: 0x00200E8C
		public void KKDFBNLBMEM(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.inputs.Length; i++)
			{
				if (this.inputs[i].keyName.Equals(EBEHBBDKDFJ))
				{
					if (PlayerPrefs.HasKey("settings.enablehitsoundsinnormal" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("_GlowColor" + this.inputs[i].keyName);
					}
					if (PlayerPrefs.HasKey("RoomDescriptionText" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("TotalHitsScoreText" + this.inputs[i].keyName);
					}
					this.keyMaps[this.inputs[i].keyName].keyInput = this.ADGLLCIHPPK(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyInput2 = this.KOMNAAJCNPN(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					this.keyMaps[this.inputs[i].keyName].keyWheelState = this.CFDEHHCOMAO(this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.BFFMNNNMPGD(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					break;
				}
			}
			Debug.Log("_ScreenResolution" + EBEHBBDKDFJ + "RecieveChatMessage");
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x00202EB8 File Offset: 0x002010B8
		public string OILCJPGHLLF(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			string text = string.Empty;
			int num;
			if (!CKLPEJDAMME)
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState;
			}
			else
			{
				text = this.keyMaps[AKOENHBOCOD].keyInput2.ToString();
				num = this.keyMaps[AKOENHBOCOD].keyWheelState2;
			}
			if (num == 0)
			{
				if (text.Contains("Joystick1Button12"))
				{
					text = text.Replace("restrictions\n\n#until: ", string.Empty);
				}
				else if (text.Contains(" from: "))
				{
					text = text.Replace("_GrainTex", "ticket");
				}
				else if (text.Contains("_ScreenResolution"))
				{
					text = text.Replace("UseScanLine", ".sav");
				}
				else if (text.Contains(") but there is no recycle bin setup for it. Falling back to Instantiate"))
				{
					text = text.Replace("IntraSig", "Failed to 'network-remove' GameObject because has no PhotonView components: ");
				}
				else if (text.Contains("_PrevViewProj"))
				{
					text = text.Replace("_BlurredColor", "_Fade");
				}
				else if (text.Contains("#savemapchanges?"))
				{
					text = text.Replace(" respawn: ", "Rotate environment object to the rotation");
				}
				else if (text.Contains("_BlurRadius4"))
				{
					text = "[NetworkManager] Join failed";
				}
				else if (text.Contains("Set Particles Input"))
				{
					text = " - ";
				}
				else if (text.Contains("string"))
				{
					text = "_MatrixColor";
				}
				else if (text.Contains("_ScreenResolution"))
				{
					text = "_TimeX" + text.Replace("settings.arcshitsoundtimedelay", string.Empty);
				}
			}
			else if (num == 0)
			{
				text = "UseFinalGlassColor";
			}
			else if (num == 2)
			{
				text = "_EmissionGain";
			}
			else if (num == 1)
			{
				text = "SetSpeed";
			}
			else if (num == 2)
			{
				text = "Bad parameters for getint! Use <key> <value>";
			}
			else if (num == 7)
			{
				if (this.controllerType == 0)
				{
					if (text == "OpGetGameList not sent. LobbyType must be SqlLobby.")
					{
						text = "_Far";
					}
					else if (text == "[PlayerBase] Got checkpoint at ")
					{
						text = "settings.volume.sfx";
					}
					else if (text == " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.")
					{
						text = "<b>[";
					}
					else if (text == "(scene)")
					{
						text = "Loading maps";
					}
					else if (text == "#random #epic #item")
					{
						text = "_Speed";
					}
					else if (text == "#onrankchangedowntext")
					{
						text = "ShadersToggle";
					}
					else if (text == "JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.")
					{
						text = "SupportLogger OnLeftRoom().";
					}
					else if (text == "Couldn't call DestroyAll() as only the master client is allowed to call this.")
					{
						text = "--------------------------------";
					}
					else if (text == "StartTime already set: ")
					{
						text = "_TimeX";
					}
					else if (text == "bool")
					{
						text = "_BlurredColor";
					}
					else if (text == "Switch environment sprite image")
					{
						text = "OxOD.lastPath";
					}
					else if (text == ".")
					{
						text = "maps.";
					}
					else if (text == "_ScreenResolution")
					{
						text = "_Value12";
					}
					else if (text == "GameScene")
					{
						text = ".g";
					}
				}
				else if (this.controllerType == 1)
				{
					if (text == "/Segment-[Left]")
					{
						text = "SfxVolumeSlider";
					}
					else if (text == "_History1ChromaTex")
					{
						text = "ConfigVersionSlider";
					}
					else if (text == "_Value8")
					{
						text = "UseScanLine";
					}
					else if (text == "close")
					{
						text = "UseScanLineSize";
					}
					else if (text == "[SERVER] Player ")
					{
						text = "_Threshhold";
					}
					else if (text == "workshop.")
					{
						text = "_Value4";
					}
					else if (text == "Simulate")
					{
						text = "_Distortion";
					}
					else if (text == "SetSatelliteEmission")
					{
						text = "L2";
					}
					else if (text == "bad")
					{
						text = ".completedMaps";
					}
					else if (text == "[PlayerBase] Current attempt: ")
					{
						text = "_TimeX";
					}
					else if (text == "[PlayerController] ")
					{
						text = "SetSpeed";
					}
					else if (text == "LevelURLInputField")
					{
						text = "_OffsetScale";
					}
					else if (text == "Scenes List:")
					{
						text = "SpeedSlider";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "_Amount")
					{
						text = " ";
					}
					else if (text == ".lastCheckpoint.isMapCompleted")
					{
						text = "Editor";
					}
					else if (text == "Data/Skins/")
					{
						text = "No Dispatcher exists in the scene. Actions will not be invoked!";
					}
					else if (text == "maps.")
					{
						text = "VoteUpToggle";
					}
					else if (text == "isVisible")
					{
						text = "_Value4";
					}
					else if (text == "x")
					{
						text = " - ";
					}
					else if (text == "CameraFilterPack/Noise_TV_2")
					{
						text = "menu.selectedlevelid";
					}
					else if (text == "_TimeX")
					{
						text = "\"";
					}
					else if (text == "_TimeX")
					{
						text = "_Value2";
					}
					else if (text == "workshop.")
					{
						text = "skin.hit_normal";
					}
					else if (text == "FPSToggle")
					{
						text = "Jump";
					}
					else if (text == "settings.volume.menu")
					{
						text = "_Distortion";
					}
					else if (text == "maps.")
					{
						text = " canvas not found";
					}
				}
				else if (this.controllerType == 0)
				{
					if (text == "_ScreenResolution")
					{
						text = "Tab2Content";
					}
					else if (text == "Start")
					{
						text = "MapConfig";
					}
					else if (text == "_Value4")
					{
						text = "_TimeX";
					}
					else if (text == "_Value6")
					{
						text = "\n";
					}
					else if (text == " is not supported on this platform!")
					{
						text = "#md5submitionfailed: ";
					}
					else if (text == "Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ")
					{
						text = "menu.copyright";
					}
					else if (text == "/../")
					{
						text = "_Offsets";
					}
					else if (text == "_Value")
					{
						text = "MAPS NOT FOUND";
					}
					else if (text == "PunSupportLogger")
					{
						text = "-showlogs";
					}
					else if (text == "CameraFilterPack/Sharpen_Sharpen")
					{
						text = "HelpMenu";
					}
					else if (text == "[ReplayScene] Loading replay: ")
					{
						text = "editorVolume";
					}
					else if (text == "SetTrailZoomSpeed")
					{
						text = "AvatarImage";
					}
					else if (text == "Texture3")
					{
						text = " argument(s): ";
					}
				}
			}
			else if (num == -1)
			{
				text = "_TimeX";
			}
			else if (num == -119)
			{
				text = "_CurTex";
			}
			else if (num == 11)
			{
				text = "https://steamcommunity.com/app/513510/workshop/";
			}
			else if (num == -31)
			{
				text = "GhostFade";
			}
			return text;
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x00203700 File Offset: 0x00201900
		public KeyCode FPNHCCEFMPJ(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			KeyCode result;
			try
			{
				if (!CKLPEJDAMME)
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput;
				}
				else
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput2;
				}
			}
			catch
			{
				Debug.LogWarning("Operation failed: " + AKOENHBOCOD);
				result = KeyCode.None;
			}
			return result;
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x0020376C File Offset: 0x0020196C
		public float BLAJOOJBOLD(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
		{
			if (this.OJJNMDMGNOP(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (this.MBPBBEPPFNI(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue -= IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.EDPNHOAFGAJ(AKOENHBOCOD) && !this.GetKey(CBHEHDPFFGE))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 1767f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 122f, 930f);
			return this.keyMaps[AKOENHBOCOD].keyValue;
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x001FC8C8 File Offset: 0x001FAAC8
		public void HKMGFPGHALH(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
		{
			this.currentBindFrom = FEFOLHEFCKP;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			base.StartCoroutine(this.LPLCPEMCBAE());
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x0020385C File Offset: 0x00201A5C
		public void LAHIHKLOHAN()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "PhotonView register is ignored, because viewID is 0. No id assigned yet to: ";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				string key = str + keyValuePair.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
				string str2 = keyValuePair2.Value.keyInput.ToString();
				string str3 = "IconImage";
				KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
				PlayerPrefs.SetString(key, str2 + str3 + keyValuePair3.Value.keyWheelState.ToString());
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str4 = "Object ID. Case-Sensitive";
				KeyValuePair<string, hardKey> keyValuePair4 = enumerator2.Current;
				string key2 = str4 + keyValuePair4.Value.keyName;
				KeyValuePair<string, hardKey> keyValuePair5 = enumerator2.Current;
				string str5 = keyValuePair5.Value.keyInput2.ToString();
				string str6 = "Reload Steam Inventory";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				PlayerPrefs.SetString(key2, str5 + str6 + keyValuePair6.Value.keyWheelState2.ToString());
			}
			PlayerPrefs.Save();
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x00203984 File Offset: 0x00201B84
		private KeyCode KOMNAAJCNPN(KeyCode AKOENHBOCOD, hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (NPBNCBFNBAF == 2 && this.useController)
			{
				return this.LBNBIHMECGJ(IJAFMJMIJGK);
			}
			if (NPBNCBFNBAF >= 4 && NPBNCBFNBAF <= -65)
			{
				AKOENHBOCOD = (KeyCode)1;
				if (!this.useController)
				{
					NPBNCBFNBAF = 0;
				}
			}
			return AKOENHBOCOD;
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x002039D0 File Offset: 0x00201BD0
		public bool EDPNHOAFGAJ(string AKOENHBOCOD)
		{
			bool result = true;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 2)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y > 201f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 6)
			{
				if (Input.mouseScrollDelta.y < 745f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 85 && this.useController)
			{
				if (Input.GetAxis("_Value") == 1677f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -123 && this.useController)
			{
				if (Input.GetAxis("|") == 827f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -98 && this.useController)
			{
				if (Input.GetAxis("PlayButton") == 1034f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -41 && this.useController && Input.GetAxis("offline") == 917f)
			{
				result = true;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				if (Input.mouseScrollDelta.y > 182f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 7)
			{
				if (Input.mouseScrollDelta.y < 464f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -126 && this.useController)
			{
				if (Input.GetAxis("intensity") == 355f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -68 && this.useController)
			{
				if (Input.GetAxis("_TimeX") == 1024f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 120 && this.useController)
			{
				if (Input.GetAxis("_Intensity") < 1992f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 55 && this.useController && Input.GetAxis("action") < 1280f)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x00203D3C File Offset: 0x00201F3C
		public KeyCode LPFPHNNOKMD(string AKOENHBOCOD, bool CKLPEJDAMME)
		{
			KeyCode result;
			try
			{
				if (!CKLPEJDAMME)
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput;
				}
				else
				{
					result = this.keyMaps[AKOENHBOCOD].keyInput2;
				}
			}
			catch
			{
				Debug.LogWarning("_DiffuseColor" + AKOENHBOCOD);
				result = KeyCode.None;
			}
			return result;
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x00203DA8 File Offset: 0x00201FA8
		public void PLCCCOBPMCB(hardInput.controllerType HMGBJCGOLMI)
		{
			switch (HMGBJCGOLMI)
			{
			case hardInput.controllerType.PS3:
				this.controllerType = 0;
				PlayerPrefs.SetInt("Jump", 1);
				break;
			case hardInput.controllerType.PS4:
				this.controllerType = 1;
				PlayerPrefs.SetInt("...", 1);
				break;
			case hardInput.controllerType.XBOX1:
				this.controllerType = 4;
				PlayerPrefs.SetInt("\n\n#", 2);
				break;
			case hardInput.controllerType.XBOX360:
				this.controllerType = 1;
				PlayerPrefs.SetInt("FreqVolume: ", 6);
				break;
			}
			PlayerPrefs.Save();
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x00203E34 File Offset: 0x00202034
		private int LPJLPDOAMAA(hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (!this.useController)
			{
				if (NPBNCBFNBAF >= -46 && NPBNCBFNBAF <= 0)
				{
					return 0;
				}
				return NPBNCBFNBAF;
			}
			else
			{
				switch (IJAFMJMIJGK)
				{
				case (hardKey.controllerMap)65:
					return 40;
				case (hardKey.controllerMap)66:
					return 17;
				case (hardKey.controllerMap)67:
					return -52;
				case (hardKey.controllerMap)68:
					return 10;
				default:
					return NPBNCBFNBAF;
				}
			}
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x00203E8C File Offset: 0x0020208C
		public void LBBAGIOGKHL(hardInput.controllerType HMGBJCGOLMI)
		{
			switch (HMGBJCGOLMI)
			{
			case hardInput.controllerType.PS3:
				this.controllerType = 0;
				PlayerPrefs.SetInt("SetSatelliteColor", 0);
				break;
			case hardInput.controllerType.PS4:
				this.controllerType = 1;
				PlayerPrefs.SetInt("Hidden/Subpixel Morphological Anti-aliasing", 1);
				break;
			case hardInput.controllerType.XBOX1:
				this.controllerType = 3;
				PlayerPrefs.SetInt("offsets", 6);
				break;
			case hardInput.controllerType.XBOX360:
				this.controllerType = 8;
				PlayerPrefs.SetInt("#tryagain", 1);
				break;
			}
			PlayerPrefs.Save();
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x00203F18 File Offset: 0x00202118
		private KeyCode KIIDKBCFFHA(hardKey.controllerMap IJAFMJMIJGK)
		{
			switch (IJAFMJMIJGK)
			{
			case hardKey.controllerMap.Square:
				return (KeyCode)(-83);
			case hardKey.controllerMap.Cross:
				return (KeyCode)17;
			case hardKey.controllerMap.Circle:
				return (KeyCode)180;
			case hardKey.controllerMap.Triangle:
				return (KeyCode)(-88);
			case hardKey.controllerMap.L1:
				return KeyCode.Alpha5;
			case hardKey.controllerMap.R1:
				return (KeyCode)(-117);
			case hardKey.controllerMap.L2:
				return (KeyCode)(-111);
			case hardKey.controllerMap.R2:
				return KeyCode.O;
			case hardKey.controllerMap.Share:
				return KeyCode.W;
			case hardKey.controllerMap.Options:
				return KeyCode.Alpha2;
			case hardKey.controllerMap.LeftStick:
				return (KeyCode)165;
			case hardKey.controllerMap.RightStick:
				return (KeyCode)(-32);
			case hardKey.controllerMap.PSHome:
				return (KeyCode)7;
			case hardKey.controllerMap.Trackpad:
				return (KeyCode)(-154);
			case hardKey.controllerMap.DPadUp:
				return (KeyCode)1;
			case hardKey.controllerMap.DPadDown:
				return (KeyCode)1;
			case hardKey.controllerMap.DPadLeft:
				return KeyCode.None;
			case hardKey.controllerMap.DPadRight:
				return KeyCode.None;
			default:
				return KeyCode.None;
			}
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x00203FD8 File Offset: 0x002021D8
		public bool KDHDPECKBJC(string AKOENHBOCOD)
		{
			bool result = false;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 8)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y > 805f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 5)
			{
				if (Input.mouseScrollDelta.y < 859f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 52 && this.useController)
			{
				if (Input.GetAxis("1.87") == 778f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -12 && this.useController)
			{
				if (Input.GetAxis("Reload Steam Inventory") == 1545f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 64 && this.useController)
			{
				if (Input.GetAxis("Text") == 1200f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 52 && this.useController && Input.GetAxis("settings.shaders.bloomintencity") == 1184f)
			{
				result = false;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 3)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.mouseScrollDelta.y > 1077f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 4)
			{
				if (Input.mouseScrollDelta.y < 1750f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 125 && this.useController)
			{
				if (Input.GetAxis("<start_index> <end_index>") == 710f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -59 && this.useController)
			{
				if (Input.GetAxis("_Value") == 663f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -65 && this.useController)
			{
				if (Input.GetAxis("SetRotation") < 1415f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 121 && this.useController && Input.GetAxis("roomDescription") < 27f)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x00204344 File Offset: 0x00202544
		public void loadBindings()
		{
			Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string str = "settings_bindings_";
				KeyValuePair<string, hardKey> keyValuePair = enumerator.Current;
				if (PlayerPrefs.HasKey(str + keyValuePair.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair2 = enumerator.Current;
					if (dictionary[keyValuePair2.Value.keyName].saveKey)
					{
						string str2 = "settings_bindings_";
						KeyValuePair<string, hardKey> keyValuePair3 = enumerator.Current;
						string[] array = PlayerPrefs.GetString(str2 + keyValuePair3.Value.keyName).Split(new char[]
						{
							'^'
						});
						int num = int.Parse(array[1]);
						if (this.useController || (!this.useController && (num <= 10 || num >= 13)))
						{
							Dictionary<string, hardKey> dictionary2 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair4 = enumerator.Current;
							dictionary2[keyValuePair4.Value.keyName].keyInput = (KeyCode)Enum.Parse(typeof(KeyCode), array[0]);
							Dictionary<string, hardKey> dictionary3 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair5 = enumerator.Current;
							dictionary3[keyValuePair5.Value.keyName].keyWheelState = int.Parse(array[1]);
						}
					}
				}
			}
			Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string str3 = "settings_bindings_sec_";
				KeyValuePair<string, hardKey> keyValuePair6 = enumerator2.Current;
				if (PlayerPrefs.HasKey(str3 + keyValuePair6.Value.keyName))
				{
					Dictionary<string, hardKey> dictionary4 = this.keyMaps;
					KeyValuePair<string, hardKey> keyValuePair7 = enumerator2.Current;
					if (dictionary4[keyValuePair7.Value.keyName].saveKey)
					{
						string str4 = "settings_bindings_sec_";
						KeyValuePair<string, hardKey> keyValuePair8 = enumerator2.Current;
						string[] array2 = PlayerPrefs.GetString(str4 + keyValuePair8.Value.keyName).Split(new char[]
						{
							'^'
						});
						int num2 = int.Parse(array2[1]);
						if (this.useController || (!this.useController && (num2 <= 10 || num2 >= 13)))
						{
							Dictionary<string, hardKey> dictionary5 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair9 = enumerator2.Current;
							dictionary5[keyValuePair9.Value.keyName].keyInput2 = (KeyCode)Enum.Parse(typeof(KeyCode), array2[0]);
							Dictionary<string, hardKey> dictionary6 = this.keyMaps;
							KeyValuePair<string, hardKey> keyValuePair10 = enumerator2.Current;
							dictionary6[keyValuePair10.Value.keyName].keyWheelState2 = int.Parse(array2[1]);
						}
					}
				}
			}
			if (PlayerPrefs.HasKey("settings_bindings_controller_type") && this.saveControllerType)
			{
				this.controllerType = PlayerPrefs.GetInt("settings_bindings_controller_type");
			}
			this.SaveBindings();
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x00204610 File Offset: 0x00202810
		public bool FDECOACMNLK(string AKOENHBOCOD)
		{
			bool result = false;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 5)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.mouseScrollDelta.y > 398f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y < 1918f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 68 && this.useController)
			{
				if (Input.GetAxis("restrictions") == 1322f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 17 && this.useController)
			{
				if (Input.GetAxis("CameraFilterPack/Light_Water") == 3f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -123 && this.useController)
			{
				if (Input.GetAxis("colorB") == 1320f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 111 && this.useController && Input.GetAxis("_Value") == 1651f)
			{
				result = true;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.mouseScrollDelta.y > 1423f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8)
			{
				if (Input.mouseScrollDelta.y < 1405f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -59 && this.useController)
			{
				if (Input.GetAxis("Please attach component to a Graphical UI component") == 1957f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 39 && this.useController)
			{
				if (Input.GetAxis("ok") == 1772f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -3 && this.useController)
			{
				if (Input.GetAxis("Added event") < 602f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -112 && this.useController && Input.GetAxis("_Blue_G") < 1747f)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x0020497C File Offset: 0x00202B7C
		private void AKHCOBHHGJP()
		{
			for (int i = 0; i < this.inputs.Length; i++)
			{
				int axisType = this.inputs[i].axisType;
				int axisType2 = this.inputs[i].axisType2;
				if (this.inputs[i].axisType > 0)
				{
					this.inputs[i].primaryKeycode = (KeyCode)1;
				}
				if (this.inputs[i].axisType2 > 0)
				{
					this.inputs[i].secondaryKeycode = KeyCode.None;
				}
				hardKey hardKey = new hardKey(this.inputs[i].keyName, this.OHOFOPDJKAB(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, axisType), this.KKJOMMJDDGJ(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, axisType2), this.MKLOMANJMKP(this.inputs[i].controllerOne, axisType), this.FKOHIOILLGB(this.inputs[i].controllerTwo, axisType2), this.inputs[i].saveKey);
				this.keyMaps.Add(hardKey.keyName, hardKey);
			}
			this.GBGNJCKMJLG();
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x00204ADC File Offset: 0x00202CDC
		public void ECHAEPLPDJK(string MDDCBDHGNPA, bool CKLPEJDAMME, KeyCode FEFOLHEFCKP)
		{
			this.currentBindFrom = null;
			this.replaceSecond = CKLPEJDAMME;
			this.currentRebind = MDDCBDHGNPA;
			int enfdcphdphc = 0;
			if (FEFOLHEFCKP.ToString().Contains("Failed to Instantiate prefab:") && this.useController)
			{
				enfdcphdphc = 1;
				this.DINGPBIKFBO(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
			else if (!FEFOLHEFCKP.ToString().Contains("_Value2"))
			{
				this.AEOJMNEPCNB(this.currentRebind, FEFOLHEFCKP, enfdcphdphc);
			}
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x00204B68 File Offset: 0x00202D68
		private KeyCode PMFEAAANBAH(KeyCode AKOENHBOCOD, hardKey.controllerMap IJAFMJMIJGK, int NPBNCBFNBAF)
		{
			if (NPBNCBFNBAF == 5 && this.useController)
			{
				return this.MACGBCMIJAC(IJAFMJMIJGK);
			}
			if (NPBNCBFNBAF >= 10 && NPBNCBFNBAF <= 13)
			{
				AKOENHBOCOD = KeyCode.None;
				if (!this.useController)
				{
					NPBNCBFNBAF = 0;
				}
			}
			return AKOENHBOCOD;
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x00204BB4 File Offset: 0x00202DB4
		private IEnumerator OMHEPOFKCDH()
		{
			yield return new WaitForEndOfFrame();
			if (!this.useController)
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f)
				{
					yield return null;
				}
			}
			else
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f && Input.GetAxis("DPADHOR") == 0f && Input.GetAxis("DPADVER") == 0f)
				{
					yield return null;
				}
			}
			if (Input.mouseScrollDelta.y != 0f)
			{
				if (Input.mouseScrollDelta.y > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 1);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 2);
				}
			}
			else if (this.useController && Input.GetAxis("DPADVER") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADVER") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 10);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 11);
				}
			}
			else if (this.useController && Input.GetAxis("DPADHOR") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADHOR") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 12);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 13);
				}
			}
			else
			{
				IEnumerator enumerator = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						KeyCode keyCode = (KeyCode)obj;
						if (Input.GetKeyDown(keyCode))
						{
							int enfdcphdphc = 0;
							if (keyCode.ToString().Contains("Joystick1Button") && this.useController)
							{
								enfdcphdphc = 5;
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
							else if (!keyCode.ToString().Contains("Joystick"))
							{
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
			yield break;
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x00204BD0 File Offset: 0x00202DD0
		public bool OJJNMDMGNOP(string AKOENHBOCOD)
		{
			bool result = false;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 2)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y > 990f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 7)
			{
				if (Input.mouseScrollDelta.y < 1828f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -103 && this.useController)
			{
				if (Input.GetAxis("_Value") == 766f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 5 && this.useController)
			{
				if (Input.GetAxis("[Up]") == 1849f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 108 && this.useController)
			{
				if (Input.GetAxis("Ownership mode == fixed. Ignoring request.") == 486f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 79 && this.useController && Input.GetAxis("hidden") == 1011f)
			{
				result = true;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8)
			{
				if (Input.GetKey(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				if (Input.mouseScrollDelta.y > 805f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 3)
			{
				if (Input.mouseScrollDelta.y < 237f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 34 && this.useController)
			{
				if (Input.GetAxis("{0:0} hour{1}, ") == 60f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 99 && this.useController)
			{
				if (Input.GetAxis("mapselector.filter.subscribedonly") == 885f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 99 && this.useController)
			{
				if (Input.GetAxis("_TimeX") < 1901f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 52 && this.useController && Input.GetAxis("_VelocityTex") < 306f)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x00204F3C File Offset: 0x0020313C
		public void LLJCCGFLIPL(string EBEHBBDKDFJ)
		{
			for (int i = 1; i < this.inputs.Length; i += 0)
			{
				if (this.inputs[i].keyName.Equals(EBEHBBDKDFJ))
				{
					if (PlayerPrefs.HasKey("Bad parameters for getint! Use <key> <value>" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("CameraFilterPack/FX_EarthQuake" + this.inputs[i].keyName);
					}
					if (PlayerPrefs.HasKey("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}" + this.inputs[i].keyName))
					{
						PlayerPrefs.DeleteKey("GameScene" + this.inputs[i].keyName);
					}
					this.keyMaps[this.inputs[i].keyName].keyInput = this.KOMNAAJCNPN(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyInput2 = this.KOMNAAJCNPN(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					this.keyMaps[this.inputs[i].keyName].keyWheelState = this.DGDBKJBHPGL(this.inputs[i].controllerOne, this.inputs[i].axisType);
					this.keyMaps[this.inputs[i].keyName].keyWheelState2 = this.FKOHIOILLGB(this.inputs[i].controllerTwo, this.inputs[i].axisType2);
					break;
				}
			}
			Debug.Log("/" + EBEHBBDKDFJ + "No font defined. Found font: ");
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x00205168 File Offset: 0x00203368
		public void MPIEAKCINJD(hardInput.controllerType HMGBJCGOLMI)
		{
			switch (HMGBJCGOLMI)
			{
			case hardInput.controllerType.PS3:
				this.controllerType = 1;
				PlayerPrefs.SetInt(" respawn: ", 1);
				break;
			case hardInput.controllerType.PS4:
				this.controllerType = 0;
				PlayerPrefs.SetInt("CameraFilterPack/Vision_Psycho", 1);
				break;
			case hardInput.controllerType.XBOX1:
				this.controllerType = 1;
				PlayerPrefs.SetInt("Scenes List:", 6);
				break;
			case hardInput.controllerType.XBOX360:
				this.controllerType = 0;
				PlayerPrefs.SetInt("_SunPosition", 0);
				break;
			}
			PlayerPrefs.Save();
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x002051F4 File Offset: 0x002033F4
		public bool GJPKJMNGJKG(string AKOENHBOCOD)
		{
			bool result = false;
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput))
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0)
			{
				if (Input.mouseScrollDelta.y > 230f)
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1)
			{
				if (Input.mouseScrollDelta.y < 1573f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -27)
			{
				if (Input.GetAxis("menu.playedpage") == 621f && Input.GetAxis("Tab2Content") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_AdaptParams");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == -9)
			{
				if (Input.GetAxis("_ScreenResolution") == 1626f && Input.GetAxis("st") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_TimeX");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 58)
			{
				if (Input.GetAxis("ResetButton") == 1233f && Input.GetAxis(" or ") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 25)
			{
				if (Input.GetAxis("[Right-Left]") == 1819f && Input.GetAxis(".lastCheckpoint.currentCombo") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("CameraFilterPack/FX_DarkMatter");
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.GetKeyDown(this.keyMaps[AKOENHBOCOD].keyInput2))
				{
					result = true;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				if (Input.mouseScrollDelta.y > 428f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1)
			{
				if (Input.mouseScrollDelta.y < 841f)
				{
					result = false;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 76 && this.useController)
			{
				if (Input.GetAxis(". Prefab must have a PhotonView component.") == 936f && Input.GetAxis("_Value") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_Value4");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -110 && this.useController)
			{
				if (Input.GetAxis("The other scroll rect doesnt support scrolling vertically") == 1349f && Input.GetAxis("_Value2") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = false;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis(".progress");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == -81 && this.useController)
			{
				if (Input.GetAxis("SetParticlesParticleSpeed") == 1211f && Input.GetAxis("Gameplay/LobbyPlayerIconElement") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("#91CCFF");
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 50 && this.useController)
			{
				if (Input.GetAxis("id") == 1322f && Input.GetAxis("_EmissionGain") != this.keyMaps[AKOENHBOCOD].keyValue)
				{
					result = true;
				}
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_Value4");
			}
			return result;
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x0020570C File Offset: 0x0020390C
		private IEnumerator HNLGCDEALMM()
		{
			yield return new WaitForEndOfFrame();
			if (!this.useController)
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f)
				{
					yield return null;
				}
			}
			else
			{
				while (!Input.anyKeyDown && Input.mouseScrollDelta.y == 0f && Input.GetAxis("DPADHOR") == 0f && Input.GetAxis("DPADVER") == 0f)
				{
					yield return null;
				}
			}
			if (Input.mouseScrollDelta.y != 0f)
			{
				if (Input.mouseScrollDelta.y > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 1);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 2);
				}
			}
			else if (this.useController && Input.GetAxis("DPADVER") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADVER") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 10);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 11);
				}
			}
			else if (this.useController && Input.GetAxis("DPADHOR") != 0f)
			{
				if (this.useController && Input.GetAxis("DPADHOR") > 0f)
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 12);
				}
				else
				{
					this.AEOJMNEPCNB(this.currentRebind, KeyCode.None, 13);
				}
			}
			else
			{
				IEnumerator enumerator = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						KeyCode keyCode = (KeyCode)obj;
						if (Input.GetKeyDown(keyCode))
						{
							int enfdcphdphc = 0;
							if (keyCode.ToString().Contains("Joystick1Button") && this.useController)
							{
								enfdcphdphc = 5;
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
							else if (!keyCode.ToString().Contains("Joystick"))
							{
								this.AEOJMNEPCNB(this.currentRebind, keyCode, enfdcphdphc);
							}
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
			yield break;
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x00205728 File Offset: 0x00203928
		public float ELKNGBPEBED(string AKOENHBOCOD, float IKOENAGPJCG)
		{
			if (this.EDPNHOAFGAJ(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue += IKOENAGPJCG * Time.deltaTime;
			}
			if (!this.FDECOACMNLK(AKOENHBOCOD))
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Mathf.MoveTowards(this.keyMaps[AKOENHBOCOD].keyValue, 887f, IKOENAGPJCG * Time.deltaTime);
			}
			this.keyMaps[AKOENHBOCOD].keyValue = Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 1742f, 503f);
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 0)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis(".a") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 6 || this.keyMaps[AKOENHBOCOD].keyWheelState2 == 3)
			{
				return this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_NoiseAmount") * IKOENAGPJCG;
			}
			if (this.keyMaps[AKOENHBOCOD].keyWheelState == 6 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 1 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("DPADVER") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 0 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 8 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("]. Please verify you have this gameobject in a Resources folder.") * IKOENAGPJCG;
				}
			}
			else if (this.keyMaps[AKOENHBOCOD].keyWheelState == 1 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 2 && this.useController))
			{
				if (this.useController)
				{
					this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.") * IKOENAGPJCG;
				}
			}
			else if ((this.keyMaps[AKOENHBOCOD].keyWheelState == -84 || (this.keyMaps[AKOENHBOCOD].keyWheelState2 == 10 && this.useController)) && this.useController)
			{
				this.keyMaps[AKOENHBOCOD].keyValue = Input.GetAxis("_HighlightSuppression") * IKOENAGPJCG;
			}
			return Mathf.Clamp(this.keyMaps[AKOENHBOCOD].keyValue, 930f, 1633f);
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x00205A24 File Offset: 0x00203C24
		private void DLBODOFAJGM()
		{
			for (int i = 1; i < this.inputs.Length; i++)
			{
				int axisType = this.inputs[i].axisType;
				int axisType2 = this.inputs[i].axisType2;
				if (this.inputs[i].axisType > 0)
				{
					this.inputs[i].primaryKeycode = (KeyCode)1;
				}
				if (this.inputs[i].axisType2 > 0)
				{
					this.inputs[i].secondaryKeycode = (KeyCode)1;
				}
				hardKey hardKey = new hardKey(this.inputs[i].keyName, this.ABANLHOFHJG(this.inputs[i].primaryKeycode, this.inputs[i].controllerOne, axisType), this.KOMNAAJCNPN(this.inputs[i].secondaryKeycode, this.inputs[i].controllerTwo, axisType2), this.GDHIFOHJLIA(this.inputs[i].controllerOne, axisType), this.KLMPGIKGLFD(this.inputs[i].controllerTwo, axisType2), this.inputs[i].saveKey);
				this.keyMaps.Add(hardKey.keyName, hardKey);
			}
			this.loadBindings();
		}

		// Token: 0x04000ACA RID: 2762
		[SerializeField]
		public hardManager.givenInputs[] inputs = new hardManager.givenInputs[0];

		// Token: 0x04000ACB RID: 2763
		private Dictionary<string, hardKey> keyMaps = new Dictionary<string, hardKey>();

		// Token: 0x04000ACC RID: 2764
		private string currentRebind = string.Empty;

		// Token: 0x04000ACD RID: 2765
		private bool replaceSecond;

		// Token: 0x04000ACE RID: 2766
		private hardInputUI currentBindFrom;

		// Token: 0x04000ACF RID: 2767
		public bool saveControllerType;

		// Token: 0x04000AD0 RID: 2768
		public bool useController;

		// Token: 0x04000AD1 RID: 2769
		public int controllerType;

		// Token: 0x04000AD2 RID: 2770
		private float lastX;

		// Token: 0x04000AD3 RID: 2771
		private float lastY;

		// Token: 0x02000162 RID: 354
		[Serializable]
		public struct givenInputs
		{
			// Token: 0x04000AD4 RID: 2772
			public string keyName;

			// Token: 0x04000AD5 RID: 2773
			public KeyCode primaryKeycode;

			// Token: 0x04000AD6 RID: 2774
			public KeyCode secondaryKeycode;

			// Token: 0x04000AD7 RID: 2775
			public int axisType;

			// Token: 0x04000AD8 RID: 2776
			public int axisType2;

			// Token: 0x04000AD9 RID: 2777
			public hardKey.controllerMap controllerOne;

			// Token: 0x04000ADA RID: 2778
			public hardKey.controllerMap controllerTwo;

			// Token: 0x04000ADB RID: 2779
			public bool saveKey;
		}
	}
}
