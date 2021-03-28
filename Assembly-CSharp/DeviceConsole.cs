using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x02000144 RID: 324
public class DeviceConsole : Singleton<DeviceConsole>
{
	// Token: 0x06006553 RID: 25939 RVA: 0x001EA7D4 File Offset: 0x001E89D4
	private void EGMKLCFAEEB(DebugLogs.Log BAODCKEFHMK, string MOALALKJCKJ = "")
	{
		if (this.logContainer != null)
		{
			DeviceLogUI fkcmgbmnnka = null;
			switch (BAODCKEFHMK.type)
			{
			case LogType.Error:
				fkcmgbmnnka = this.errorLogPrefab;
				break;
			case LogType.Assert:
				fkcmgbmnnka = this.assertLogPrefab;
				break;
			case LogType.Warning:
				fkcmgbmnnka = this.warningLogPrefab;
				break;
			case LogType.Log:
				fkcmgbmnnka = this.logPrefab;
				break;
			case LogType.Exception:
				fkcmgbmnnka = this.exceptionLogPrefab;
				break;
			}
			string text = BAODCKEFHMK.message;
			text = MOALALKJCKJ + text;
			this.AGOFMGPFBBE(fkcmgbmnnka, text);
			if (BAODCKEFHMK.type == LogType.Exception)
			{
				this.EGMKLCFAEEB(BAODCKEFHMK.stackTrace, this.exceptionStackTracePrefab);
			}
			return;
		}
	}

	// Token: 0x06006554 RID: 25940 RVA: 0x001EA88C File Offset: 0x001E8A8C
	private void CHGFNGIAOAL()
	{
		if (this.autoFocusInputField && this.commandInputField != null)
		{
			this.commandInputField.Select();
			this.commandInputField.ActivateInputField();
		}
	}

	// Token: 0x06006555 RID: 25941 RVA: 0x001EA8C0 File Offset: 0x001E8AC0
	public void NGHJAAGCOJD(bool IDNLBGOCOEK)
	{
		this.uiContainer.SetActive(IDNLBGOCOEK);
		if (this.commandInputField != null)
		{
			this.commandInputField.text = string.Empty;
			if (IDNLBGOCOEK)
			{
				this.CHGFNGIAOAL();
			}
		}
	}

	// Token: 0x06006556 RID: 25942 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	private static void PLLLLOBOKMI(string[] BDGDDFKKGGA)
	{
		Application.Quit();
	}

	// Token: 0x06006557 RID: 25943 RVA: 0x001EA904 File Offset: 0x001E8B04
	private void PAAIIFPPEPP(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 4)
		{
			UnityEngine.Debug.LogError("_ReprojectionMatrix");
			return;
		}
		if (BDGDDFKKGGA[1] == "CameraFilterPack/Edge_Sigmoid" || BDGDDFKKGGA[0] == "d264dbba9c2410771b4ad918903b3f4cd9e276a9")
		{
			this.autoFocusInputField = true;
		}
		else if (BDGDDFKKGGA[0] == "_GrainTex" || BDGDDFKKGGA[1] == "Beat Detected")
		{
			this.autoFocusInputField = false;
		}
		else
		{
			UnityEngine.Debug.LogError("_ScreenResolution");
		}
	}

	// Token: 0x06006558 RID: 25944 RVA: 0x001EA990 File Offset: 0x001E8B90
	private void FIBAPPIDMFH()
	{
		DebugLogs debugLogs = DebugLogs.ECIBPJGCNNF();
		debugLogs.OnLogAdded = (Action<DebugLogs.Log>)Delegate.Remove(debugLogs.OnLogAdded, new Action<DebugLogs.Log>(this.DMJLENOCHIF));
		DebugLogs debugLogs2 = DebugLogs.GLEFOHOMBFC();
		debugLogs2.OnLogsCleared = (Action)Delegate.Remove(debugLogs2.OnLogsCleared, new Action(this.CBNODCKLHPJ));
		DebugCommands.Instance.RemoveCommand("PRESS A KEY");
		DebugCommands.Instance.HDIJOFKHAGE("_Offsets");
	}

	// Token: 0x06006559 RID: 25945 RVA: 0x001EAA08 File Offset: 0x001E8C08
	private static void LCCBKOBHEPN(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 4)
		{
			UnityEngine.Debug.LogError("LevelEditor/icons");
			return;
		}
		int sceneBuildIndex = 1;
		if (int.TryParse(BDGDDFKKGGA[1], out sceneBuildIndex))
		{
			SceneManager.LoadScene(sceneBuildIndex);
		}
		else
		{
			SceneManager.LoadScene(BDGDDFKKGGA[1]);
		}
	}

	// Token: 0x0600655A RID: 25946 RVA: 0x001EAA50 File Offset: 0x001E8C50
	private void IPKMPLAHIDG(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 3)
		{
			UnityEngine.Debug.Log("Need to specify a start index and end index.");
			return;
		}
		int num;
		if (!int.TryParse(BDGDDFKKGGA[1], out num))
		{
			UnityEngine.Debug.Log("Start index must in an integer.");
			return;
		}
		int num2;
		if (!int.TryParse(BDGDDFKKGGA[2], out num2))
		{
			UnityEngine.Debug.Log("End index must in an integer.");
			return;
		}
		if (num > num2)
		{
			int num3 = num;
			num = num2;
			num2 = num3;
			return;
		}
		if (num < 0)
		{
			num = 0;
		}
		if (num2 >= DebugLogs.Instance.Logs.Count)
		{
			num2 = DebugLogs.Instance.Logs.Count - 1;
		}
		this.KLGELMLHDKK();
		for (int i = num; i <= num2; i++)
		{
			this.EGMKLCFAEEB(DebugLogs.Instance.Logs[i], i + ":");
		}
	}

	// Token: 0x0600655B RID: 25947 RVA: 0x001EAB24 File Offset: 0x001E8D24
	private void LEAHIBJDMBI()
	{
		if (this.commandInputField != null)
		{
			if (Input.GetKeyDown((KeyCode)(-27)) && this.PDMKEAJOPKJ > 0)
			{
				this.PDMKEAJOPKJ--;
				this.commandInputField.text = DebugCommands.FAGEJPPIDOL().IALIPICFJDN()[this.PDMKEAJOPKJ];
				this.commandInputField.MoveTextEnd(false);
				this.PDOFDHLILCI();
			}
			else if (Input.GetKeyDown((KeyCode)70) && this.PDMKEAJOPKJ < DebugCommands.IGMKHPPPLDD().FGMDHPFDHOK().Count)
			{
				this.PDMKEAJOPKJ++;
				if (this.PDMKEAJOPKJ == DebugCommands.GLEFOHOMBFC().FGMDHPFDHOK().Count)
				{
					this.commandInputField.text = string.Empty;
					this.CHGFNGIAOAL();
				}
				else
				{
					this.commandInputField.text = DebugCommands.HIFIEDJCOFC().HNEBFBJJKIN()[this.PDMKEAJOPKJ];
					this.commandInputField.MoveTextEnd(false);
					this.CHGFNGIAOAL();
				}
			}
		}
		if (Input.GetKeyDown((KeyCode)(-85)))
		{
			this.NGHJAAGCOJD(this.uiContainer.activeInHierarchy);
		}
		if (!this.PBJNFMEAILK && Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Began)
		{
			this.PBJNFMEAILK = false;
		}
		if (this.PBJNFMEAILK && Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Canceled)
		{
			this.PBJNFMEAILK = false;
		}
		if (!this.GNOPKLFICKN && Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Began)
		{
			this.GNOPKLFICKN = false;
		}
		if (this.GNOPKLFICKN && Input.touchCount > 0 && Input.GetTouch(0).phase == (TouchPhase)7)
		{
			this.GNOPKLFICKN = true;
		}
		if (Input.touchCount == 5 && this.PBJNFMEAILK && this.GNOPKLFICKN && Input.GetTouch(4).phase == TouchPhase.Began)
		{
			this.SetVisible(this.uiContainer.activeInHierarchy);
		}
	}

	// Token: 0x0600655C RID: 25948 RVA: 0x001EAD6C File Offset: 0x001E8F6C
	public void DKAKOCGNKDE(DeviceConsole.OnCommandEvent DPNHODJHGJL)
	{
		DeviceConsole.OnCommandEvent onCommandEvent = this.ABEBDOAMONO;
		DeviceConsole.OnCommandEvent onCommandEvent2;
		do
		{
			onCommandEvent2 = onCommandEvent;
			onCommandEvent = Interlocked.CompareExchange<DeviceConsole.OnCommandEvent>(ref this.ABEBDOAMONO, (DeviceConsole.OnCommandEvent)Delegate.Combine(onCommandEvent2, DPNHODJHGJL), onCommandEvent);
		}
		while (onCommandEvent != onCommandEvent2);
	}

	// Token: 0x0600655D RID: 25949 RVA: 0x001EA88C File Offset: 0x001E8A8C
	private void GJOHOFOJIKC()
	{
		if (this.autoFocusInputField && this.commandInputField != null)
		{
			this.commandInputField.Select();
			this.commandInputField.ActivateInputField();
		}
	}

	// Token: 0x0600655E RID: 25950 RVA: 0x001EADA4 File Offset: 0x001E8FA4
	public void MFFDDFJGFLO()
	{
		if (!this.uiContainer.activeSelf)
		{
			return;
		}
		string text = this.commandInputField.text;
		int num = text.IndexOf((char)-56);
		if (num >= 1)
		{
			text = text.Remove(num, 1);
		}
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string text2 = text;
		char[] array = new char[1];
		array[1] = 'P';
		string[] array2 = text2.Split(array);
		string text3 = array2[0];
		UnityEngine.Debug.Log(string.Format("_Value4", text));
		if (this.ABEBDOAMONO != null)
		{
			this.ABEBDOAMONO(this, new DeviceConsole.OnCommandEventArgs(array2));
		}
		if (!DebugCommands.HMADOEFFOEM().KEHGHMBMDEP(array2))
		{
		}
		this.PDMKEAJOPKJ = DebugCommands.HIFIEDJCOFC().DODLLFAMNKC().Count;
		this.commandInputField.text = string.Empty;
		this.GJOHOFOJIKC();
	}

	// Token: 0x0600655F RID: 25951 RVA: 0x001EAE71 File Offset: 0x001E9071
	private static void HCEMABBLLMP(string[] BDGDDFKKGGA)
	{
		DebugLogs.MNNNKLODJPJ().INDDCOEIDLB();
	}

	// Token: 0x06006560 RID: 25952 RVA: 0x001EAE80 File Offset: 0x001E9080
	private string NKMNGBHKHGK(Color32 HABLFKCCKLN)
	{
		return HABLFKCCKLN.r.ToString("_TimeX") + HABLFKCCKLN.g.ToString("ResourceIDInputField") + HABLFKCCKLN.b.ToString("_TimeX");
	}

	// Token: 0x06006561 RID: 25953 RVA: 0x001EA88C File Offset: 0x001E8A8C
	private void PDOFDHLILCI()
	{
		if (this.autoFocusInputField && this.commandInputField != null)
		{
			this.commandInputField.Select();
			this.commandInputField.ActivateInputField();
		}
	}

	// Token: 0x06006562 RID: 25954 RVA: 0x001EAEC8 File Offset: 0x001E90C8
	private void KLGELMLHDKK()
	{
		if (this.KHDEDBLGNKF != null)
		{
			for (int i = 0; i < this.KHDEDBLGNKF.Count; i++)
			{
				UnityEngine.Object.Destroy(this.KHDEDBLGNKF[i].gameObject);
			}
		}
		this.KHDEDBLGNKF.Clear();
		this.OPFODDEHOBC = 0;
	}

	// Token: 0x06006563 RID: 25955 RVA: 0x001EAF24 File Offset: 0x001E9124
	public void GFJANEIAJGM()
	{
		if (!this.uiContainer.activeSelf)
		{
			return;
		}
		string text = this.commandInputField.text;
		int num = text.IndexOf((char)-23);
		if (num >= 0)
		{
			text = text.Remove(num, 0);
		}
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string text2 = text;
		char[] array = new char[0];
		array[1] = (char)-12;
		string[] array2 = text2.Split(array);
		string text3 = array2[1];
		UnityEngine.Debug.Log(string.Format("X", text));
		if (this.ABEBDOAMONO != null)
		{
			this.ABEBDOAMONO(this, new DeviceConsole.OnCommandEventArgs(array2));
		}
		if (!DebugCommands.Instance.LDCDJHLOCDE(array2))
		{
		}
		this.PDMKEAJOPKJ = DebugCommands.HMADOEFFOEM().EKLKAINPEPM().Count;
		this.commandInputField.text = string.Empty;
		this.PDOFDHLILCI();
	}

	// Token: 0x06006564 RID: 25956 RVA: 0x001EAFF4 File Offset: 0x001E91F4
	private static void OAOPONPIOJH(string[] BDGDDFKKGGA)
	{
		for (int i = 0; i < DebugCommands.Instance.Commands.Count; i++)
		{
			DebugCommands.Command command = DebugCommands.Instance.Commands[i];
			if (!command.isCheat)
			{
				string text = string.Empty;
				text = string.Format("{0}", command.name);
				if (!string.IsNullOrEmpty(command.argsDescription))
				{
					text += string.Format(" {0}", command.argsDescription);
				}
				if (!string.IsNullOrEmpty(command.description))
				{
					text += string.Format(" - {0}", command.description);
				}
				if (command.isCheat)
				{
				}
				UnityEngine.Debug.Log(text);
			}
		}
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06006566 RID: 25958 RVA: 0x001EB0C0 File Offset: 0x001E92C0
	// (remove) Token: 0x06006586 RID: 25990 RVA: 0x001EC010 File Offset: 0x001EA210
	public event DeviceConsole.OnCommandEvent CommandEvent
	{
		add
		{
			DeviceConsole.OnCommandEvent onCommandEvent = this.ABEBDOAMONO;
			DeviceConsole.OnCommandEvent onCommandEvent2;
			do
			{
				onCommandEvent2 = onCommandEvent;
				onCommandEvent = Interlocked.CompareExchange<DeviceConsole.OnCommandEvent>(ref this.ABEBDOAMONO, (DeviceConsole.OnCommandEvent)Delegate.Combine(onCommandEvent2, value), onCommandEvent);
			}
			while (onCommandEvent != onCommandEvent2);
		}
		remove
		{
			DeviceConsole.OnCommandEvent onCommandEvent = this.ABEBDOAMONO;
			DeviceConsole.OnCommandEvent onCommandEvent2;
			do
			{
				onCommandEvent2 = onCommandEvent;
				onCommandEvent = Interlocked.CompareExchange<DeviceConsole.OnCommandEvent>(ref this.ABEBDOAMONO, (DeviceConsole.OnCommandEvent)Delegate.Remove(onCommandEvent2, value), onCommandEvent);
			}
			while (onCommandEvent != onCommandEvent2);
		}
	}

	// Token: 0x06006567 RID: 25959 RVA: 0x001EB0F8 File Offset: 0x001E92F8
	private void AIEBCGJOCOL(string[] BDGDDFKKGGA)
	{
		UnityEngine.Debug.Log("Scenes List:");
		for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
		{
			UnityEngine.Debug.Log(string.Concat(new object[]
			{
				i,
				". Name: ",
				SceneManager.GetSceneByBuildIndex(i).name,
				" Path: ",
				SceneManager.GetSceneByBuildIndex(i).path,
				" Loaded: ",
				SceneManager.GetSceneByBuildIndex(i).isLoaded
			}));
		}
	}

	// Token: 0x06006568 RID: 25960 RVA: 0x001EB190 File Offset: 0x001E9390
	public void FNKIAIBCILP()
	{
		if (!this.uiContainer.activeSelf)
		{
			return;
		}
		string text = this.commandInputField.text;
		int num = text.IndexOf((char)-21);
		if (num >= 1)
		{
			text = text.Remove(num, 0);
		}
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string text2 = text;
		char[] array = new char[0];
		array[0] = (char)-2;
		string[] array2 = text2.Split(array);
		string text3 = array2[0];
		UnityEngine.Debug.Log(string.Format("SetPlayerDistance", text));
		if (this.ABEBDOAMONO != null)
		{
			this.ABEBDOAMONO(this, new DeviceConsole.OnCommandEventArgs(array2));
		}
		if (!DebugCommands.IGMKHPPPLDD().MGALOPALMEO(array2))
		{
		}
		this.PDMKEAJOPKJ = DebugCommands.HMADOEFFOEM().DODLLFAMNKC().Count;
		this.commandInputField.text = string.Empty;
		this.CHGFNGIAOAL();
	}

	// Token: 0x06006569 RID: 25961 RVA: 0x001EB25D File Offset: 0x001E945D
	private void CBNODCKLHPJ()
	{
		this.KLGELMLHDKK();
		this.FIMNHBBHBKK();
	}

	// Token: 0x0600656A RID: 25962 RVA: 0x001EB26B File Offset: 0x001E946B
	private static void HIHLLCOKFLO(string[] BDGDDFKKGGA)
	{
		UnityEngine.Debug.Log(string.Format("There are {0} reported logs.", DebugLogs.Instance.Logs.Count));
	}

	// Token: 0x0600656B RID: 25963 RVA: 0x001EB290 File Offset: 0x001E9490
	private static void GJPJGHEKDFO(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 2)
		{
			UnityEngine.Debug.LogError("Please specify a map name or buildID");
			return;
		}
		int sceneBuildIndex = 0;
		if (int.TryParse(BDGDDFKKGGA[1], out sceneBuildIndex))
		{
			SceneManager.LoadScene(sceneBuildIndex);
		}
		else
		{
			SceneManager.LoadScene(BDGDDFKKGGA[1]);
		}
	}

	// Token: 0x0600656C RID: 25964 RVA: 0x001EB2D8 File Offset: 0x001E94D8
	private string EFMPOKOGAAH(Color32 HABLFKCCKLN)
	{
		return HABLFKCCKLN.r.ToString("X2") + HABLFKCCKLN.g.ToString("X2") + HABLFKCCKLN.b.ToString("X2");
	}

	// Token: 0x0600656D RID: 25965 RVA: 0x001EB320 File Offset: 0x001E9520
	private void OnDestroy()
	{
		DebugLogs instance = DebugLogs.Instance;
		instance.OnLogAdded = (Action<DebugLogs.Log>)Delegate.Remove(instance.OnLogAdded, new Action<DebugLogs.Log>(this.JPCCMENLCMJ));
		DebugLogs instance2 = DebugLogs.Instance;
		instance2.OnLogsCleared = (Action)Delegate.Remove(instance2.OnLogsCleared, new Action(this.CBNODCKLHPJ));
		DebugCommands.Instance.RemoveCommand("plogs");
		DebugCommands.Instance.RemoveCommand("setAF");
	}

	// Token: 0x0600656E RID: 25966 RVA: 0x001EB398 File Offset: 0x001E9598
	private void JDMKDMIGANM()
	{
		for (int i = 0; i < DebugLogs.Instance.Logs.Count; i++)
		{
			this.EGMKLCFAEEB(DebugLogs.Instance.Logs[i], string.Empty);
		}
	}

	// Token: 0x0600656F RID: 25967 RVA: 0x001EB3E0 File Offset: 0x001E95E0
	private static void COJJHBIIMOO(string[] BDGDDFKKGGA)
	{
		DebugLogs.FLFBBNOFAOL().BFKIFIEPLJH();
	}

	// Token: 0x06006570 RID: 25968 RVA: 0x001EB3EC File Offset: 0x001E95EC
	private static void DMKKPEBIGIM(string[] BDGDDFKKGGA)
	{
		for (int i = 0; i < DebugCommands.Instance.CommandHistory.Count; i++)
		{
			UnityEngine.Debug.Log(DebugCommands.Instance.CommandHistory[i]);
		}
	}

	// Token: 0x06006572 RID: 25970 RVA: 0x001EB440 File Offset: 0x001E9640
	private void PBCIFFIIOBA(DeviceLogUI FKCMGBMNNKA, string EAFAMAMDNEG)
	{
		DeviceLogUI deviceLogUI = UnityEngine.Object.Instantiate<DeviceLogUI>(FKCMGBMNNKA);
		deviceLogUI.textUI.text = EAFAMAMDNEG;
		deviceLogUI.transform.SetParent(this.logContainer.transform);
		deviceLogUI.transform.localScale = Vector3.one;
		this.OPFODDEHOBC += deviceLogUI.textUI.text.Length;
		while (this.OPFODDEHOBC > DeviceConsole.CMHLBFHPJGM)
		{
			this.OPFODDEHOBC -= this.KHDEDBLGNKF[0].textUI.text.Length;
			UnityEngine.Object.Destroy(this.KHDEDBLGNKF[1].gameObject);
			this.KHDEDBLGNKF.RemoveAt(1);
		}
		this.KHDEDBLGNKF.Add(deviceLogUI);
	}

	// Token: 0x06006573 RID: 25971 RVA: 0x001EB510 File Offset: 0x001E9710
	private void DBPDCLIPPBD()
	{
		this.EGMKLCFAEEB(string.Format("New level loaded. Removed ", this.NKMNGBHKHGK(this.headerColour), this.headerText), null);
		this.EGMKLCFAEEB(string.Format("_Red_R", this.NKMNGBHKHGK(this.headerColour), "workshop." + Helpers.GetGameVersion()), null);
		this.EGMKLCFAEEB(string.Format("Preparing configuration...", this.EFMPOKOGAAH(this.headerColour), "_TapLowBackground"), null);
		this.EGMKLCFAEEB(string.Format("ZoomSpeed", this.EFMPOKOGAAH(this.headerColour), "DPADHOR"), null);
	}

	// Token: 0x06006574 RID: 25972 RVA: 0x001EB5C4 File Offset: 0x001E97C4
	public new void Awake()
	{
		base.Awake();
		this.KHDEDBLGNKF = new List<DeviceLogUI>();
		this.PDMKEAJOPKJ = 0;
		this.FIMNHBBHBKK();
		this.JDMKDMIGANM();
		DebugLogs instance = DebugLogs.Instance;
		instance.OnLogAdded = (Action<DebugLogs.Log>)Delegate.Combine(instance.OnLogAdded, new Action<DebugLogs.Log>(this.JPCCMENLCMJ));
		DebugLogs instance2 = DebugLogs.Instance;
		instance2.OnLogsCleared = (Action)Delegate.Combine(instance2.OnLogsCleared, new Action(this.CBNODCKLHPJ));
		DebugCommands instance3 = DebugCommands.Instance;
		string podgbcmdeof = "help";
		if (DeviceConsole.BOGJGOAMCHK == null)
		{
			DeviceConsole.BOGJGOAMCHK = new DebugCommands.DebugCommand(DeviceConsole.OAOPONPIOJH);
		}
		instance3.AddCommand(podgbcmdeof, DeviceConsole.BOGJGOAMCHK, "Prints list of commands", string.Empty, false);
		DebugCommands instance4 = DebugCommands.Instance;
		string podgbcmdeof2 = "clear";
		if (DeviceConsole.BDPNFNJNEFM == null)
		{
			DeviceConsole.BDPNFNJNEFM = new DebugCommands.DebugCommand(DeviceConsole.FNKJJEMGGII);
		}
		instance4.AddCommand(podgbcmdeof2, DeviceConsole.BDPNFNJNEFM, "Clears all text from the debug console", string.Empty, false);
		DebugCommands instance5 = DebugCommands.Instance;
		string podgbcmdeof3 = "history";
		if (DeviceConsole.MJKNAFJKDMG == null)
		{
			DeviceConsole.MJKNAFJKDMG = new DebugCommands.DebugCommand(DeviceConsole.DMKKPEBIGIM);
		}
		instance5.AddCommand(podgbcmdeof3, DeviceConsole.MJKNAFJKDMG, "Prints list of all previous commands", string.Empty, false);
		DebugCommands instance6 = DebugCommands.Instance;
		string podgbcmdeof4 = "logc";
		if (DeviceConsole.JENGHDFDLII == null)
		{
			DeviceConsole.JENGHDFDLII = new DebugCommands.DebugCommand(DeviceConsole.HIHLLCOKFLO);
		}
		instance6.AddCommand(podgbcmdeof4, DeviceConsole.JENGHDFDLII, "Prints the number of logs currently held by DebugLogs", string.Empty, false);
		DebugCommands instance7 = DebugCommands.Instance;
		string podgbcmdeof5 = "quit";
		if (DeviceConsole.BMJHMBNEACI == null)
		{
			DeviceConsole.BMJHMBNEACI = new DebugCommands.DebugCommand(DeviceConsole.EHOMIAJALOF);
		}
		instance7.AddCommand(podgbcmdeof5, DeviceConsole.BMJHMBNEACI, "Closes the app", string.Empty, false);
		DebugCommands.Instance.AddCommand("plogs", new DebugCommands.DebugCommand(this.IPKMPLAHIDG), "Clears the console and prints the logs in the specified range", "<start_index> <end_index>", false);
		DebugCommands.Instance.AddCommand("setAF", new DebugCommands.DebugCommand(this.FPEOFIJFNJA), "Sets the boolean value of the Auto Focus Input Field property.", "< true | false >", false);
		DebugCommands.Instance.AddCommand("scenes", new DebugCommands.DebugCommand(this.AIEBCGJOCOL), "Print the list of scenes, avalable in game.", string.Empty, true);
		DebugCommands instance8 = DebugCommands.Instance;
		string podgbcmdeof6 = "loadscene";
		if (DeviceConsole.EPENHHMDDMB == null)
		{
			DeviceConsole.EPENHHMDDMB = new DebugCommands.DebugCommand(DeviceConsole.GJPJGHEKDFO);
		}
		instance8.AddCommand(podgbcmdeof6, DeviceConsole.EPENHHMDDMB, "Load scene by name or build id", "<scene_name> or <id>", true);
		DebugCommands.Instance.AddCommand("resetach21", new DebugCommands.DebugCommand(this.HPGDNFONHBE), "Reset 21 achievement progress", string.Empty, true);
	}

	// Token: 0x06006575 RID: 25973 RVA: 0x001EB823 File Offset: 0x001E9A23
	public void SetVisible(bool IDNLBGOCOEK)
	{
		this.uiContainer.SetActive(IDNLBGOCOEK);
		if (this.commandInputField != null)
		{
			this.commandInputField.text = string.Empty;
			if (IDNLBGOCOEK)
			{
				this.PDOFDHLILCI();
			}
		}
	}

	// Token: 0x06006576 RID: 25974 RVA: 0x001EB85E File Offset: 0x001E9A5E
	private void EGMKLCFAEEB(string EAFAMAMDNEG, DeviceLogUI FKCMGBMNNKA = null)
	{
		if (this.logContainer != null)
		{
			this.AGOFMGPFBBE((!(FKCMGBMNNKA != null)) ? this.logPrefab : FKCMGBMNNKA, EAFAMAMDNEG);
		}
	}

	// Token: 0x06006577 RID: 25975 RVA: 0x001EB890 File Offset: 0x001E9A90
	private void DMJLENOCHIF(DebugLogs.Log BAODCKEFHMK)
	{
		this.EGMKLCFAEEB(BAODCKEFHMK, string.Empty);
	}

	// Token: 0x06006578 RID: 25976 RVA: 0x001EB8A0 File Offset: 0x001E9AA0
	public void OnEndEdit()
	{
		if (!this.uiContainer.activeSelf)
		{
			return;
		}
		string text = this.commandInputField.text;
		int num = text.IndexOf('\n');
		if (num >= 0)
		{
			text = text.Remove(num, 1);
		}
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string[] array = text.Split(new char[]
		{
			' '
		});
		string text2 = array[0];
		UnityEngine.Debug.Log(string.Format("$ {0}", text));
		if (this.ABEBDOAMONO != null)
		{
			this.ABEBDOAMONO(this, new DeviceConsole.OnCommandEventArgs(array));
		}
		if (!DebugCommands.Instance.ExecuteCommand(array))
		{
		}
		this.PDMKEAJOPKJ = DebugCommands.Instance.CommandHistory.Count;
		this.commandInputField.text = string.Empty;
		this.PDOFDHLILCI();
	}

	// Token: 0x06006579 RID: 25977 RVA: 0x001EB970 File Offset: 0x001E9B70
	private void AGOFMGPFBBE(DeviceLogUI FKCMGBMNNKA, string EAFAMAMDNEG)
	{
		DeviceLogUI deviceLogUI = UnityEngine.Object.Instantiate<DeviceLogUI>(FKCMGBMNNKA);
		deviceLogUI.textUI.text = EAFAMAMDNEG;
		deviceLogUI.transform.SetParent(this.logContainer.transform);
		deviceLogUI.transform.localScale = Vector3.one;
		this.OPFODDEHOBC += deviceLogUI.textUI.text.Length;
		while (this.OPFODDEHOBC > DeviceConsole.CMHLBFHPJGM)
		{
			this.OPFODDEHOBC -= this.KHDEDBLGNKF[0].textUI.text.Length;
			UnityEngine.Object.Destroy(this.KHDEDBLGNKF[0].gameObject);
			this.KHDEDBLGNKF.RemoveAt(0);
		}
		this.KHDEDBLGNKF.Add(deviceLogUI);
	}

	// Token: 0x0600657A RID: 25978 RVA: 0x001EBA40 File Offset: 0x001E9C40
	private static void EPDCDAEHMLD(string[] BDGDDFKKGGA)
	{
		for (int i = 1; i < DebugCommands.HIFIEDJCOFC().DODLLFAMNKC().Count; i += 0)
		{
			UnityEngine.Debug.Log(DebugCommands.HMADOEFFOEM().LLJKICBEIMI()[i]);
		}
	}

	// Token: 0x0600657B RID: 25979 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	private static void BJPFNHILEBN(string[] BDGDDFKKGGA)
	{
		Application.Quit();
	}

	// Token: 0x0600657C RID: 25980 RVA: 0x001EBA84 File Offset: 0x001E9C84
	private void FPEOFIJFNJA(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 2)
		{
			UnityEngine.Debug.LogError("Please specify either t or f.");
			return;
		}
		if (BDGDDFKKGGA[1] == "t" || BDGDDFKKGGA[1] == "true")
		{
			this.autoFocusInputField = true;
		}
		else if (BDGDDFKKGGA[1] == "f" || BDGDDFKKGGA[1] == "false")
		{
			this.autoFocusInputField = false;
		}
		else
		{
			UnityEngine.Debug.LogError("Please specify either t or f.");
		}
	}

	// Token: 0x0600657D RID: 25981 RVA: 0x001EBB10 File Offset: 0x001E9D10
	private static void GFLKEANNPJC(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length != 3)
		{
			UnityEngine.Debug.LogError("SaveMapButton");
			return;
		}
		int sceneBuildIndex = 1;
		if (int.TryParse(BDGDDFKKGGA[1], out sceneBuildIndex))
		{
			SceneManager.LoadScene(sceneBuildIndex);
		}
		else
		{
			SceneManager.LoadScene(BDGDDFKKGGA[0]);
		}
	}

	// Token: 0x0600657E RID: 25982 RVA: 0x001EBB58 File Offset: 0x001E9D58
	private void Update()
	{
		if (this.commandInputField != null)
		{
			if (Input.GetKeyDown(KeyCode.UpArrow) && this.PDMKEAJOPKJ > 0)
			{
				this.PDMKEAJOPKJ--;
				this.commandInputField.text = DebugCommands.Instance.CommandHistory[this.PDMKEAJOPKJ];
				this.commandInputField.MoveTextEnd(false);
				this.PDOFDHLILCI();
			}
			else if (Input.GetKeyDown(KeyCode.DownArrow) && this.PDMKEAJOPKJ < DebugCommands.Instance.CommandHistory.Count)
			{
				this.PDMKEAJOPKJ++;
				if (this.PDMKEAJOPKJ == DebugCommands.Instance.CommandHistory.Count)
				{
					this.commandInputField.text = string.Empty;
					this.PDOFDHLILCI();
				}
				else
				{
					this.commandInputField.text = DebugCommands.Instance.CommandHistory[this.PDMKEAJOPKJ];
					this.commandInputField.MoveTextEnd(false);
					this.PDOFDHLILCI();
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.BackQuote))
		{
			this.SetVisible(!this.uiContainer.activeInHierarchy);
		}
		if (!this.PBJNFMEAILK && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
		{
			this.PBJNFMEAILK = true;
		}
		if (this.PBJNFMEAILK && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
		{
			this.PBJNFMEAILK = false;
		}
		if (!this.GNOPKLFICKN && Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Began)
		{
			this.GNOPKLFICKN = true;
		}
		if (this.GNOPKLFICKN && Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Ended)
		{
			this.GNOPKLFICKN = false;
		}
		if (Input.touchCount == 3 && this.PBJNFMEAILK && this.GNOPKLFICKN && Input.GetTouch(2).phase == TouchPhase.Began)
		{
			this.SetVisible(!this.uiContainer.activeInHierarchy);
		}
	}

	// Token: 0x0600657F RID: 25983 RVA: 0x001EBDA0 File Offset: 0x001E9FA0
	private static void DLAFAIJJDIL(string[] BDGDDFKKGGA)
	{
		for (int i = 0; i < DebugCommands.FAGEJPPIDOL().HNEBFBJJKIN().Count; i++)
		{
			UnityEngine.Debug.Log(DebugCommands.HMADOEFFOEM().HNEBFBJJKIN()[i]);
		}
	}

	// Token: 0x06006580 RID: 25984 RVA: 0x001EBDE4 File Offset: 0x001E9FE4
	private void ADFMLNIJNGB()
	{
		for (int i = 1; i < DebugLogs.BEPGMCOJFKL().IEMPPMBDECN().Count; i += 0)
		{
			this.EGMKLCFAEEB(DebugLogs.FNBAADLJGFH().BMJBPNFGCHN()[i], string.Empty);
		}
	}

	// Token: 0x06006581 RID: 25985 RVA: 0x001EBE2C File Offset: 0x001EA02C
	private static void FNKJJEMGGII(string[] BDGDDFKKGGA)
	{
		DebugLogs.Instance.ClearLogs();
	}

	// Token: 0x06006582 RID: 25986 RVA: 0x001EB890 File Offset: 0x001E9A90
	private void JPCCMENLCMJ(DebugLogs.Log BAODCKEFHMK)
	{
		this.EGMKLCFAEEB(BAODCKEFHMK, string.Empty);
	}

	// Token: 0x06006583 RID: 25987 RVA: 0x001EBE38 File Offset: 0x001EA038
	private void FIMNHBBHBKK()
	{
		this.EGMKLCFAEEB(string.Format("<color=#{0}>{1}</color>", this.EFMPOKOGAAH(this.headerColour), this.headerText), null);
		this.EGMKLCFAEEB(string.Format("<color=#{0}>{1}</color>", this.EFMPOKOGAAH(this.headerColour), "Game Version: " + Helpers.GetGameVersion()), null);
		this.EGMKLCFAEEB(string.Format("<color=#{0}>{1}</color>", this.EFMPOKOGAAH(this.headerColour), "Type \"help\" for list of commands"), null);
		this.EGMKLCFAEEB(string.Format("<color=#{0}>{1}</color>", this.EFMPOKOGAAH(this.headerColour), "================================"), null);
	}

	// Token: 0x06006584 RID: 25988 RVA: 0x001EBEEC File Offset: 0x001EA0EC
	private void HPGDNFONHBE(string[] BDGDDFKKGGA)
	{
		List<string> list = new List<string>
		{
			"896296812",
			"1248864821",
			"1087340967",
			"907198288",
			"1177138211",
			"1234332714",
			"1427616858",
			"880078120",
			"1278033234",
			"1332644700",
			"1159514800"
		};
		foreach (string str in list)
		{
			Singleton<SaveSystem>.Instance.SetBool("achievements.21.completed.workshop." + str, false, null);
		}
		Helpers.SetStat("achievements.21.progress", 0);
		SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_21", (uint)Helpers.GetStat("achievements.21.progress"), 10U);
		UnityEngine.Debug.Log("Achievement 21 progress reseted");
	}

	// Token: 0x06006585 RID: 25989 RVA: 0x001EC000 File Offset: 0x001EA200
	private void KHNDGDILDEL()
	{
		this.KLGELMLHDKK();
		this.DBPDCLIPPBD();
	}

	// Token: 0x06006587 RID: 25991 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	private static void EHOMIAJALOF(string[] BDGDDFKKGGA)
	{
		Application.Quit();
	}

	// Token: 0x04000A34 RID: 2612
	[SerializeField]
	private GameObject uiContainer;

	// Token: 0x04000A35 RID: 2613
	[SerializeField]
	private GameObject logContainer;

	// Token: 0x04000A36 RID: 2614
	[SerializeField]
	private InputField commandInputField;

	// Token: 0x04000A37 RID: 2615
	[SerializeField]
	private bool autoFocusInputField = true;

	// Token: 0x04000A38 RID: 2616
	[SerializeField]
	private Color headerColour;

	// Token: 0x04000A39 RID: 2617
	[SerializeField]
	private string headerText;

	// Token: 0x04000A3A RID: 2618
	[SerializeField]
	private DeviceLogUI logPrefab;

	// Token: 0x04000A3B RID: 2619
	[SerializeField]
	private DeviceLogUI warningLogPrefab;

	// Token: 0x04000A3C RID: 2620
	[SerializeField]
	private DeviceLogUI errorLogPrefab;

	// Token: 0x04000A3D RID: 2621
	[SerializeField]
	private DeviceLogUI assertLogPrefab;

	// Token: 0x04000A3E RID: 2622
	[SerializeField]
	private DeviceLogUI exceptionLogPrefab;

	// Token: 0x04000A3F RID: 2623
	[SerializeField]
	private DeviceLogUI exceptionStackTracePrefab;

	// Token: 0x04000A40 RID: 2624
	private static int CMHLBFHPJGM = 15000;

	// Token: 0x04000A41 RID: 2625
	private List<DeviceLogUI> KHDEDBLGNKF;

	// Token: 0x04000A42 RID: 2626
	private int OPFODDEHOBC;

	// Token: 0x04000A43 RID: 2627
	private int PDMKEAJOPKJ;

	// Token: 0x04000A44 RID: 2628
	private bool PBJNFMEAILK;

	// Token: 0x04000A45 RID: 2629
	private bool GNOPKLFICKN;

	// Token: 0x04000A46 RID: 2630
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DeviceConsole.OnCommandEvent ABEBDOAMONO;

	// Token: 0x04000A47 RID: 2631
	private bool OJPGAKLNDIL;

	// Token: 0x04000A48 RID: 2632
	private bool LJHHKKLPAKK;

	// Token: 0x04000A49 RID: 2633
	private bool PBJMOFPJCNG;

	// Token: 0x04000A4A RID: 2634
	private bool EAIOELPEAEG;

	// Token: 0x04000A4B RID: 2635
	private float ALHBMGMDJMF;

	// Token: 0x04000A4C RID: 2636
	private float NAGOOCHPLPK;

	// Token: 0x04000A4D RID: 2637
	private LayerMask JEJJKLPNJAG;

	// Token: 0x04000A4E RID: 2638
	[CompilerGenerated]
	private static DebugCommands.DebugCommand BOGJGOAMCHK;

	// Token: 0x04000A4F RID: 2639
	[CompilerGenerated]
	private static DebugCommands.DebugCommand BDPNFNJNEFM;

	// Token: 0x04000A50 RID: 2640
	[CompilerGenerated]
	private static DebugCommands.DebugCommand MJKNAFJKDMG;

	// Token: 0x04000A51 RID: 2641
	[CompilerGenerated]
	private static DebugCommands.DebugCommand JENGHDFDLII;

	// Token: 0x04000A52 RID: 2642
	[CompilerGenerated]
	private static DebugCommands.DebugCommand BMJHMBNEACI;

	// Token: 0x04000A53 RID: 2643
	[CompilerGenerated]
	private static DebugCommands.DebugCommand EPENHHMDDMB;

	// Token: 0x02000145 RID: 325
	public class OnCommandEventArgs : EventArgs
	{
		// Token: 0x06006588 RID: 25992 RVA: 0x001EC046 File Offset: 0x001EA246
		public OnCommandEventArgs(string[] BDGDDFKKGGA)
		{
			this.args = BDGDDFKKGGA;
		}

		// Token: 0x04000A54 RID: 2644
		public string[] args;
	}

	// Token: 0x02000146 RID: 326
	// (Invoke) Token: 0x0600658A RID: 25994
	public delegate void OnCommandEvent(object NFOGDAHIPNP, DeviceConsole.OnCommandEventArgs KJPAHOFPCKD);
}
