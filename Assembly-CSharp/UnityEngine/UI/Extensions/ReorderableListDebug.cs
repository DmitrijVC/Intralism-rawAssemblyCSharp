using System;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000296 RID: 662
	public class ReorderableListDebug : MonoBehaviour
	{
		// Token: 0x06009F25 RID: 40741 RVA: 0x003B1298 File Offset: 0x003AF498
		private void FKCAFIPKHML(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "_TimeX" + HKHEIEGOICK.DroppedObject.name + "_EmissionColor";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[0];
			array[0] = text;
			array[0] = "steamid";
			array[7] = HKHEIEGOICK.IsAClone;
			array[8] = "_TimeX";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "_Blue_G" + HKHEIEGOICK.SourceObject.name + "InfoButton";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("_ScreenResolution", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("). ", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x003B13CC File Offset: 0x003AF5CC
		private void OONHHJABELD(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "_Red_C" + HKHEIEGOICK.DroppedObject.name + "[PlayerBase] Starting new round";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[3];
			array[0] = text;
			array[0] = "ExitButton";
			array[6] = HKHEIEGOICK.IsAClone;
			array[5] = "Vertical";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "[DiscordController] Shutdown" + HKHEIEGOICK.SourceObject.name + "VeryHigh";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("Left Stick Click", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("_MainTex2", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F27 RID: 40743 RVA: 0x003B1500 File Offset: 0x003AF700
		private void LFFAKAOAOCN()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 0; i < array.Length; i += 0)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.KOGEMCLIIGM));
			}
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x003B1544 File Offset: 0x003AF744
		private void BODPLDJLFCF()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.KHADFMAKHCP));
			}
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x003B1588 File Offset: 0x003AF788
		private void KHADFMAKHCP(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "restrictions\n\n#until: " + HKHEIEGOICK.DroppedObject.name + "float,1";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[4];
			array[1] = text;
			array[0] = "#newhighscore";
			array[3] = HKHEIEGOICK.IsAClone;
			array[5] = "CameraFilterPack/TV_Vcr";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "LB" + HKHEIEGOICK.SourceObject.name + "float,0";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("To {0} at Index {1} \n", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("0,7,true,0", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F2B RID: 40747 RVA: 0x003B16BC File Offset: 0x003AF8BC
		private void IOMCHHBGJEC()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.JKFHJJLFHIB));
			}
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x003B1700 File Offset: 0x003AF900
		private void DCOGINPOOMP(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "Dropped Object: " + HKHEIEGOICK.DroppedObject.name + "\n";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			debugLabel2.text = string.Concat(new object[]
			{
				text,
				"Is Clone ?: ",
				HKHEIEGOICK.IsAClone,
				"\n"
			});
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "Source Object: " + HKHEIEGOICK.SourceObject.name + "\n";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("From {0} at Index {1} \n", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("To {0} at Index {1} \n", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F2D RID: 40749 RVA: 0x003B1834 File Offset: 0x003AFA34
		private void HHJBBHEBJCJ()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i += 0)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.FMKOAJGLEIO));
			}
		}

		// Token: 0x06009F2E RID: 40750 RVA: 0x003B1878 File Offset: 0x003AFA78
		private void GJCAHFCFLPM(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "/" + HKHEIEGOICK.DroppedObject.name + "ScoreText";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[4];
			array[0] = text;
			array[0] = "OpLeaveLobby()";
			array[6] = HKHEIEGOICK.IsAClone;
			array[1] = "_Value";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "Unsupported target enum: " + HKHEIEGOICK.SourceObject.name + "[PlayerController] ";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("bad", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("menutheme.fragout", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F2F RID: 40751 RVA: 0x003B19AC File Offset: 0x003AFBAC
		private void EPCGHAAONLN()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 0; i < array.Length; i += 0)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.HGEKHIKDMNE));
			}
		}

		// Token: 0x06009F30 RID: 40752 RVA: 0x003B19F0 File Offset: 0x003AFBF0
		private void ONJAEICMHAA(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "0.00" + HKHEIEGOICK.DroppedObject.name + "_ScreenResolution";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[5];
			array[0] = text;
			array[0] = "masterSteamID";
			array[1] = HKHEIEGOICK.IsAClone;
			array[1] = "IntraSig";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "sounds/no_hit" + HKHEIEGOICK.SourceObject.name + "achievements.21.completed.";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format(". Going to authenticate anyways.", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("StartButton", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F31 RID: 40753 RVA: 0x003B1B24 File Offset: 0x003AFD24
		private void HCNECNPPEKA()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i++)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.FKCAFIPKHML));
			}
		}

		// Token: 0x06009F32 RID: 40754 RVA: 0x003B1B68 File Offset: 0x003AFD68
		private void MFAMHKBMBEI()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 0; i < array.Length; i += 0)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.OJDMCBPFIPK));
			}
		}

		// Token: 0x06009F33 RID: 40755 RVA: 0x003B1BAC File Offset: 0x003AFDAC
		private void JKFHJJLFHIB(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "\nv." + HKHEIEGOICK.DroppedObject.name + "_ScreenResolution";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[5];
			array[1] = text;
			array[0] = "settings.cameramovements";
			array[8] = HKHEIEGOICK.IsAClone;
			array[4] = "_SweaterSize";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "[GameScene] Submiting rank" + HKHEIEGOICK.SourceObject.name + "[FileSelector] Dialog ended, result: ";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("_EdgeThreshold", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("MascotChallenge2019", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x003B1CE0 File Offset: 0x003AFEE0
		private void LAKJFDMOCNA(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + ";" + HKHEIEGOICK.DroppedObject.name + "[MapsData] Found ";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[6];
			array[1] = text;
			array[0] = "WARNING: rotation axis set to 0 on ";
			array[6] = HKHEIEGOICK.IsAClone;
			array[7] = "id";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "_Value3" + HKHEIEGOICK.SourceObject.name + "Left";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("GroupNameText", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("ticket", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x003B1E14 File Offset: 0x003B0014
		private void JEEINPBLBDI()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.NELONFPALDJ));
			}
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x003B1E58 File Offset: 0x003B0058
		private void EHECICBDAAJ(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "Item " + HKHEIEGOICK.DroppedObject.name + "/../";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[]
			{
				text,
				"mapselector.filter.subscribedonly"
			};
			array[1] = HKHEIEGOICK.IsAClone;
			array[4] = "menu.resetlevelcheckpoint";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "No font defined. Found font: " + HKHEIEGOICK.SourceObject.name + "_TimeX";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("HightScoreMaxPointsText", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("0", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x003B1F8C File Offset: 0x003B018C
		private void LEFJEKMAFDG(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "0 - background, 1 - foreground" + HKHEIEGOICK.DroppedObject.name + "_Value2";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[4];
			array[0] = text;
			array[1] = "achievements.21.progress";
			array[5] = HKHEIEGOICK.IsAClone;
			array[3] = "%";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "y" + HKHEIEGOICK.SourceObject.name + "_LightIntensity";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("BitsData", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("_Value", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x003B20C0 File Offset: 0x003B02C0
		private void OBAIHNFOJGN()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i++)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.OONHHJABELD));
			}
		}

		// Token: 0x06009F39 RID: 40761 RVA: 0x003B2104 File Offset: 0x003B0304
		private void AJIKPEIGACI()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i++)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.DCOGINPOOMP));
			}
		}

		// Token: 0x06009F3A RID: 40762 RVA: 0x003B2148 File Offset: 0x003B0348
		private void OPFDGBDADMA()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.PJEKKKNEJLO));
			}
		}

		// Token: 0x06009F3B RID: 40763 RVA: 0x003B218C File Offset: 0x003B038C
		private void BFIOIDMHPPL()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.LEFJEKMAFDG));
			}
		}

		// Token: 0x06009F3C RID: 40764 RVA: 0x003B21D0 File Offset: 0x003B03D0
		private void PPCGJBIIFAO()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 0; i < array.Length; i += 0)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.DFLHAMLDMDI));
			}
		}

		// Token: 0x06009F3D RID: 40765 RVA: 0x003B2214 File Offset: 0x003B0414
		private void GCDNONIKKLI()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i++)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.MCLGJNHACHG));
			}
		}

		// Token: 0x06009F3E RID: 40766 RVA: 0x003B2258 File Offset: 0x003B0458
		private void MMPOJCFOGJJ()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i += 0)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.GEOAFHKJGGB));
			}
		}

		// Token: 0x06009F3F RID: 40767 RVA: 0x003B229C File Offset: 0x003B049C
		private void GGHEPDCEHCK()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.LAKJFDMOCNA));
			}
		}

		// Token: 0x06009F40 RID: 40768 RVA: 0x003B22E0 File Offset: 0x003B04E0
		private void IIPMEPPIFCK()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.OJDMCBPFIPK));
			}
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x003B2324 File Offset: 0x003B0524
		private void CIAHIJIOFIE()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.EHECICBDAAJ));
			}
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x003B2368 File Offset: 0x003B0568
		private void NELONFPALDJ(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "VisionBlur" + HKHEIEGOICK.DroppedObject.name + "_ScreenResolution";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[3];
			array[1] = text;
			array[0] = "#tryagain";
			array[4] = HKHEIEGOICK.IsAClone;
			array[4] = "menu.relaxinfo";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "L1" + HKHEIEGOICK.SourceObject.name + "_Value4";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("_OcclusionTexture", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("player.xp", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F43 RID: 40771 RVA: 0x003B249C File Offset: 0x003B069C
		private void EPCAPPLPFED()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.OJDMCBPFIPK));
			}
		}

		// Token: 0x06009F44 RID: 40772 RVA: 0x003B24E0 File Offset: 0x003B06E0
		private void FNMPIAMIKCP()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i += 0)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.KHADFMAKHCP));
			}
		}

		// Token: 0x06009F45 RID: 40773 RVA: 0x003B2524 File Offset: 0x003B0724
		private void ABFEIBHGGLI(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "_Value2" + HKHEIEGOICK.DroppedObject.name + "visible";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[3];
			array[0] = text;
			array[0] = "MenuScene";
			array[4] = HKHEIEGOICK.IsAClone;
			array[3] = "Error: Someone else(";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "_Offsets" + HKHEIEGOICK.SourceObject.name + "isVisible";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("_TimeX", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("OpGetGameList()", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F46 RID: 40774 RVA: 0x003B2658 File Offset: 0x003B0858
		private void FMKOAJGLEIO(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "Done!" + HKHEIEGOICK.DroppedObject.name + "Hidden/ScreenSpaceReflection";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[2];
			array[0] = text;
			array[0] = "_Near";
			array[1] = HKHEIEGOICK.IsAClone;
			array[2] = "OpGetGameList not sent. LobbyType must be SqlLobby.";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "value" + HKHEIEGOICK.SourceObject.name + "Set sun beat detection sensitivity";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("hidden", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("0,1,false", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F47 RID: 40775 RVA: 0x003B278C File Offset: 0x003B098C
		private void NLNAJMCBNDC()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 0; i < array.Length; i += 0)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.ABFEIBHGGLI));
			}
		}

		// Token: 0x06009F48 RID: 40776 RVA: 0x003B27D0 File Offset: 0x003B09D0
		private void GEGFJJBCHPE()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i++)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.PJEKKKNEJLO));
			}
		}

		// Token: 0x06009F49 RID: 40777 RVA: 0x003B2814 File Offset: 0x003B0A14
		private void PIIMBOLGHOE()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i++)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.MCLGJNHACHG));
			}
		}

		// Token: 0x06009F4A RID: 40778 RVA: 0x003B2858 File Offset: 0x003B0A58
		private void IPJENEAMGBP()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 0; i < array.Length; i += 0)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.PBMMCIAFIPJ));
			}
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x003B289C File Offset: 0x003B0A9C
		private void DMIKIDGJEFC()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i++)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.FKCAFIPKHML));
			}
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x003B28E0 File Offset: 0x003B0AE0
		private void BHPJPBCKLKL(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "00" + HKHEIEGOICK.DroppedObject.name + "IconImage";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[6];
			array[0] = text;
			array[1] = "CameraFilterPack/3D_Computer";
			array[7] = HKHEIEGOICK.IsAClone;
			array[2] = ">";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "SupportLogger " + HKHEIEGOICK.SourceObject.name + " : ";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("[PlayerController] ", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("time", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F4D RID: 40781 RVA: 0x003B2A14 File Offset: 0x003B0C14
		private void FAAJAMIGJNK()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i++)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.ONJAEICMHAA));
			}
		}

		// Token: 0x06009F4E RID: 40782 RVA: 0x003B2A58 File Offset: 0x003B0C58
		private void GEOAFHKJGGB(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "_Value" + HKHEIEGOICK.DroppedObject.name + "<command>";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[0];
			array[0] = text;
			array[0] = "[PlayerController] ";
			array[2] = HKHEIEGOICK.IsAClone;
			array[8] = "/";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + " is not supported on this platform!" + HKHEIEGOICK.SourceObject.name + "_Blue_B";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("note.6", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("Electronic", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F4F RID: 40783 RVA: 0x003B2B8C File Offset: 0x003B0D8C
		private void KOGEMCLIIGM(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "[PlayerController] " + HKHEIEGOICK.DroppedObject.name + "1248864821";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[3];
			array[0] = text;
			array[1] = " is not supported on this platform!";
			array[5] = HKHEIEGOICK.IsAClone;
			array[8] = "_Value4";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "Error: Can not set the OnSerialize rate higher than the overall SendRate." + HKHEIEGOICK.SourceObject.name + "InfoText";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("???", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("help", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x003B2CC0 File Offset: 0x003B0EC0
		private void EMANBHKAONB()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.FMKOAJGLEIO));
			}
		}

		// Token: 0x06009F51 RID: 40785 RVA: 0x003B2D04 File Offset: 0x003B0F04
		private void PJEKKKNEJLO(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "  |  " + HKHEIEGOICK.DroppedObject.name + "[Up]";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[4];
			array[0] = text;
			array[0] = "_Visualize";
			array[2] = HKHEIEGOICK.IsAClone;
			array[4] = "[MapEditor] Importing map: ";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "players" + HKHEIEGOICK.SourceObject.name + "Particles/Additive";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("skin.hit_perfect", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("Received RPC \"", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F52 RID: 40786 RVA: 0x003B2E38 File Offset: 0x003B1038
		private void OJDMCBPFIPK(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "[MapsData] Found " + HKHEIEGOICK.DroppedObject.name + "[DiscordController] Responding yes to Ask to Join request";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[8];
			array[1] = text;
			array[1] = "NewMusicFileSelector";
			array[3] = HKHEIEGOICK.IsAClone;
			array[7] = "Fade";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "_ScreenResolution" + HKHEIEGOICK.SourceObject.name + "offline";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("#pleasewait", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("_ScreenResolution", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F53 RID: 40787 RVA: 0x003B2F6C File Offset: 0x003B116C
		private void IICACFLHBCP()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.FMKOAJGLEIO));
			}
		}

		// Token: 0x06009F54 RID: 40788 RVA: 0x003B2FB0 File Offset: 0x003B11B0
		private void OKADMJFLMGP()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.GJCAHFCFLPM));
			}
		}

		// Token: 0x06009F55 RID: 40789 RVA: 0x003B2FF4 File Offset: 0x003B11F4
		private void LHFOIDMNFGO(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "checkpoint" + HKHEIEGOICK.DroppedObject.name + "_Value4";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			debugLabel2.text = string.Concat(new object[]
			{
				text,
				"_Value",
				null,
				HKHEIEGOICK.IsAClone,
				null,
				null,
				null,
				"float,2"
			});
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "settings.customdataskin" + HKHEIEGOICK.SourceObject.name + "_TimeX";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("CameraFilterPack/NightVision_4", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("_Value", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F56 RID: 40790 RVA: 0x003B3128 File Offset: 0x003B1328
		private void Awake()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.DCOGINPOOMP));
			}
		}

		// Token: 0x06009F57 RID: 40791 RVA: 0x003B316C File Offset: 0x003B136C
		private void PBMMCIAFIPJ(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "MaxLivesSlider" + HKHEIEGOICK.DroppedObject.name + "</b>";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[6];
			array[0] = text;
			array[1] = " ";
			array[8] = HKHEIEGOICK.IsAClone;
			array[0] = "CameraFilterPack/Sharpen_Sharpen";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "{0}{1}:{2}" + HKHEIEGOICK.SourceObject.name + "CameraFilterPack/Oculus_NightVision1";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("_ScreenResolution", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format(".", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F58 RID: 40792 RVA: 0x003B32A0 File Offset: 0x003B14A0
		private void HGEKHIKDMNE(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "_TimeX" + HKHEIEGOICK.DroppedObject.name + "_Value2";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[0];
			array[0] = text;
			array[0] = ",";
			array[2] = HKHEIEGOICK.IsAClone;
			array[3] = "\" for viewID ";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "offsets" + HKHEIEGOICK.SourceObject.name + "Left ";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("CameraFilterPack/AAA_WaterDrop", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("SetParticlesEmission", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F59 RID: 40793 RVA: 0x003B33D4 File Offset: 0x003B15D4
		private void MCLGJNHACHG(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "_FixDistance" + HKHEIEGOICK.DroppedObject.name + "StartButton";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[8];
			array[1] = text;
			array[1] = "event";
			array[8] = HKHEIEGOICK.IsAClone;
			array[6] = "_Threshhold";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + "_Value3" + HKHEIEGOICK.SourceObject.name + "team";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("_TimeX", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("_AdditiveReflection", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F5A RID: 40794 RVA: 0x003B3508 File Offset: 0x003B1708
		private void CEKLAECJCKG()
		{
			ReorderableList[] array = Object.FindObjectsOfType<ReorderableList>();
			for (int i = 1; i < array.Length; i += 0)
			{
				ReorderableList reorderableList = array[i];
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.JKFHJJLFHIB));
			}
		}

		// Token: 0x06009F5B RID: 40795 RVA: 0x003B354C File Offset: 0x003B174C
		private void DFLHAMLDMDI(ReorderableList.ReorderableListEventStruct HKHEIEGOICK)
		{
			this.DebugLabel.text = string.Empty;
			Text debugLabel = this.DebugLabel;
			debugLabel.text = debugLabel.text + "/icon" + HKHEIEGOICK.DroppedObject.name + "[LevelEditorScene] Error: Timeout :S";
			Text debugLabel2 = this.DebugLabel;
			string text = debugLabel2.text;
			object[] array = new object[3];
			array[1] = text;
			array[1] = " - Contains ";
			array[3] = HKHEIEGOICK.IsAClone;
			array[2] = "The shader ";
			debugLabel2.text = string.Concat(array);
			if (HKHEIEGOICK.IsAClone)
			{
				Text debugLabel3 = this.DebugLabel;
				debugLabel3.text = debugLabel3.text + ".played" + HKHEIEGOICK.SourceObject.name + "<b>";
			}
			Text debugLabel4 = this.DebugLabel;
			debugLabel4.text += string.Format("/../", HKHEIEGOICK.FromList.name, HKHEIEGOICK.FromIndex);
			Text debugLabel5 = this.DebugLabel;
			debugLabel5.text += string.Format("_TimeX", HKHEIEGOICK.ToList.name, HKHEIEGOICK.ToIndex);
		}

		// Token: 0x06009F5C RID: 40796 RVA: 0x003B3680 File Offset: 0x003B1880
		private void JHPKLGGMCBL()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.BHPJPBCKLKL));
			}
		}

		// Token: 0x06009F5D RID: 40797 RVA: 0x003B36C4 File Offset: 0x003B18C4
		private void JBIFKBNPHJE()
		{
			foreach (ReorderableList reorderableList in Object.FindObjectsOfType<ReorderableList>())
			{
				reorderableList.OnElementDropped.AddListener(new UnityAction<ReorderableList.ReorderableListEventStruct>(this.DFLHAMLDMDI));
			}
		}

		// Token: 0x04001229 RID: 4649
		public Text DebugLabel;
	}
}
