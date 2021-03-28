using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MoonSharp.Interpreter;
using UnityEngine;

// Token: 0x0200043A RID: 1082
public class LuaEnvironment : Singleton<LuaEnvironment>
{
	// Token: 0x0600F728 RID: 63272 RVA: 0x005523AB File Offset: 0x005505AB
	public static void PlaySound(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlaySound((AudioClip)ResourcesManager.GetLoadedResource(NGLCFNBJCIN));
	}

	// Token: 0x0600F729 RID: 63273 RVA: 0x005523C3 File Offset: 0x005505C3
	public GameState BGFLHMPLIHO()
	{
		return this.CCNDFDNOFDO;
	}

	// Token: 0x170003DD RID: 989
	// (get) Token: 0x0600F72A RID: 63274 RVA: 0x005523CB File Offset: 0x005505CB
	public bool Finished
	{
		get
		{
			return this.OEGKPMHIJGF;
		}
	}

	// Token: 0x0600F72B RID: 63275 RVA: 0x005523D3 File Offset: 0x005505D3
	[CompilerGenerated]
	private static void HLIPOKKEOHB(string BDIMLMKEEKO)
	{
		Debug.Log(BDIMLMKEEKO);
	}

	// Token: 0x0600F72C RID: 63276 RVA: 0x005523DB File Offset: 0x005505DB
	public void EBFHDLKMOIN(FinishedMapInfo DPNHODJHGJL)
	{
		this.DKGEKMEAJDN = DPNHODJHGJL;
	}

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x0600F746 RID: 63302 RVA: 0x00552A41 File Offset: 0x00550C41
	// (set) Token: 0x0600F72E RID: 63278 RVA: 0x005523DB File Offset: 0x005505DB
	public FinishedMapInfo FMI
	{
		get
		{
			return this.DKGEKMEAJDN;
		}
		set
		{
			this.DKGEKMEAJDN = value;
		}
	}

	// Token: 0x0600F72F RID: 63279 RVA: 0x00552418 File Offset: 0x00550618
	public bool DFAIJFMEOAC(string CPCBPCJLDNC)
	{
		return this.MCDKGOLIBAP("SetSatelliteEmission" + CPCBPCJLDNC);
	}

	// Token: 0x0600F730 RID: 63280 RVA: 0x0055242C File Offset: 0x0055062C
	public void Init()
	{
		ScriptOptions defaultOptions = Script.DefaultOptions;
		if (LuaEnvironment.LNIJKGECNME == null)
		{
			LuaEnvironment.LNIJKGECNME = new Action<string>(LuaEnvironment.HLIPOKKEOHB);
		}
		defaultOptions.DebugPrint = LuaEnvironment.LNIJKGECNME;
		UserData.RegisterAssembly(null, false);
		this.ICOMJMLACPH = new Stack<MoonSharp.Interpreter.Coroutine>();
		this.LOKOJMIKEEL = new Script(CoreModules.Preset_SoftSandbox);
		Table globals = this.LOKOJMIKEEL.Globals;
		object key = "PlaySound";
		if (LuaEnvironment.BOGJGOAMCHK == null)
		{
			LuaEnvironment.BOGJGOAMCHK = new Action<string>(LuaEnvironment.PlaySound);
		}
		globals[key] = LuaEnvironment.BOGJGOAMCHK;
		Table globals2 = this.LOKOJMIKEEL.Globals;
		object key2 = "PlayMusic";
		if (LuaEnvironment.BDPNFNJNEFM == null)
		{
			LuaEnvironment.BDPNFNJNEFM = new Action<string>(LuaEnvironment.PlayMusic);
		}
		globals2[key2] = LuaEnvironment.BDPNFNJNEFM;
		Table globals3 = this.LOKOJMIKEEL.Globals;
		object key3 = "StopMusic";
		if (LuaEnvironment.MJKNAFJKDMG == null)
		{
			LuaEnvironment.MJKNAFJKDMG = new Action(LuaEnvironment.StopMusic);
		}
		globals3[key3] = LuaEnvironment.MJKNAFJKDMG;
		Table globals4 = this.LOKOJMIKEEL.Globals;
		object key4 = "StopSounds";
		if (LuaEnvironment.JENGHDFDLII == null)
		{
			LuaEnvironment.JENGHDFDLII = new Action(LuaEnvironment.StopSounds);
		}
		globals4[key4] = LuaEnvironment.JENGHDFDLII;
		this.JIMECEDODAF = new GameEventInfo();
		this.LOKOJMIKEEL.Globals["event"] = UserData.Create(this.JIMECEDODAF);
		this.DKGEKMEAJDN = new FinishedMapInfo();
		this.LOKOJMIKEEL.Globals["play"] = UserData.Create(this.DKGEKMEAJDN);
		this.CCNDFDNOFDO = new GameState();
	}

	// Token: 0x0600F731 RID: 63281 RVA: 0x005525AB File Offset: 0x005507AB
	public static void KIMDPEAEODG()
	{
		Singleton<SoundManager>.Instance.StopAllMusic();
	}

	// Token: 0x0600F732 RID: 63282 RVA: 0x005525B7 File Offset: 0x005507B7
	public static void NCCIEIENFMC(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlayMusic((AudioClip)ResourcesManager.KLNILBOBLIL(NGLCFNBJCIN), 1758f, false, false);
	}

	// Token: 0x0600F733 RID: 63283 RVA: 0x005525D8 File Offset: 0x005507D8
	private bool MCDKGOLIBAP(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[1];
			array[0] = this.LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[8] = NIJLKJIPFCC;
			array[2] = Environment.NewLine;
			array[7] = this.BIAPMBPJPHE;
			string code = string.Concat(array);
			dynValue = this.LOKOJMIKEEL.DoString(code, null, null);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	// Token: 0x0600F734 RID: 63284 RVA: 0x00552658 File Offset: 0x00550858
	public void JDHJHEDPFPH(GameEventInfo DPNHODJHGJL)
	{
		this.JIMECEDODAF = DPNHODJHGJL;
	}

	// Token: 0x0600F735 RID: 63285 RVA: 0x00552661 File Offset: 0x00550861
	public void RunFirstInit()
	{
		this.Init();
	}

	// Token: 0x0600F736 RID: 63286 RVA: 0x00552669 File Offset: 0x00550869
	public void AOBLOMMDBFB()
	{
		this.IFGOHEOEGKH();
	}

	// Token: 0x0600F737 RID: 63287 RVA: 0x00552671 File Offset: 0x00550871
	public static void MCMEJKMCEMK()
	{
		Singleton<SoundManager>.Instance.GEHIKFMPALA();
	}

	// Token: 0x0600F738 RID: 63288 RVA: 0x00552680 File Offset: 0x00550880
	private bool BCJNNAKCCKH(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string code = string.Concat(new string[]
			{
				this.LAKLDHDHLDL,
				Environment.NewLine,
				NIJLKJIPFCC,
				Environment.NewLine,
				this.BIAPMBPJPHE
			});
			dynValue = this.LOKOJMIKEEL.DoString(code, null, null);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	// Token: 0x0600F739 RID: 63289 RVA: 0x005523AB File Offset: 0x005505AB
	public static void MGAFPLHNCIO(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlaySound((AudioClip)ResourcesManager.GetLoadedResource(NGLCFNBJCIN));
	}

	// Token: 0x0600F73A RID: 63290 RVA: 0x00552700 File Offset: 0x00550900
	public GameEventInfo PEJJMEIFHDK()
	{
		return this.JIMECEDODAF;
	}

	// Token: 0x0600F73B RID: 63291 RVA: 0x00552708 File Offset: 0x00550908
	public bool CheckFinishedMapCondition(string CPCBPCJLDNC)
	{
		return this.BCJNNAKCCKH("return " + CPCBPCJLDNC);
	}

	// Token: 0x0600F73C RID: 63292 RVA: 0x005523CB File Offset: 0x005505CB
	public bool PFOGPEBKMPE()
	{
		return this.OEGKPMHIJGF;
	}

	// Token: 0x0600F73D RID: 63293 RVA: 0x0055271C File Offset: 0x0055091C
	public void IFGOHEOEGKH()
	{
		ScriptOptions defaultOptions = Script.DefaultOptions;
		if (LuaEnvironment.LNIJKGECNME == null)
		{
			LuaEnvironment.LNIJKGECNME = new Action<string>(LuaEnvironment.IOCIMOEILGA);
		}
		defaultOptions.DebugPrint = LuaEnvironment.LNIJKGECNME;
		UserData.RegisterAssembly(null, true);
		this.ICOMJMLACPH = new Stack<MoonSharp.Interpreter.Coroutine>();
		this.LOKOJMIKEEL = new Script(~(CoreModules.Basic | CoreModules.GlobalConsts | CoreModules.TableIterators | CoreModules.Table));
		Table globals = this.LOKOJMIKEEL.Globals;
		object key = "_ScreenResolution";
		if (LuaEnvironment.BOGJGOAMCHK == null)
		{
			LuaEnvironment.BOGJGOAMCHK = new Action<string>(LuaEnvironment.MLDOGKCDPEL);
		}
		globals[key] = LuaEnvironment.BOGJGOAMCHK;
		Table globals2 = this.LOKOJMIKEEL.Globals;
		object key2 = "_Red_G";
		if (LuaEnvironment.BDPNFNJNEFM == null)
		{
			LuaEnvironment.BDPNFNJNEFM = new Action<string>(LuaEnvironment.PlayMusic);
		}
		globals2[key2] = LuaEnvironment.BDPNFNJNEFM;
		Table globals3 = this.LOKOJMIKEEL.Globals;
		object key3 = " - ";
		if (LuaEnvironment.MJKNAFJKDMG == null)
		{
			LuaEnvironment.MJKNAFJKDMG = new Action(LuaEnvironment.StopMusic);
		}
		globals3[key3] = LuaEnvironment.MJKNAFJKDMG;
		Table globals4 = this.LOKOJMIKEEL.Globals;
		object key4 = "_BorderColor";
		if (LuaEnvironment.JENGHDFDLII == null)
		{
			LuaEnvironment.JENGHDFDLII = new Action(LuaEnvironment.LNCGFCJAENP);
		}
		globals4[key4] = LuaEnvironment.JENGHDFDLII;
		this.JIMECEDODAF = new GameEventInfo();
		this.LOKOJMIKEEL.Globals["_Value"] = UserData.Create(this.JIMECEDODAF);
		this.DKGEKMEAJDN = new FinishedMapInfo();
		this.LOKOJMIKEEL.Globals["CameraFilterPack/Light_Water"] = UserData.Create(this.DKGEKMEAJDN);
		this.CCNDFDNOFDO = new GameState();
	}

	// Token: 0x170003DE RID: 990
	// (get) Token: 0x0600F73E RID: 63294 RVA: 0x005523C3 File Offset: 0x005505C3
	public GameState LuaGameState
	{
		get
		{
			return this.CCNDFDNOFDO;
		}
	}

	// Token: 0x0600F73F RID: 63295 RVA: 0x005525AB File Offset: 0x005507AB
	public static void StopMusic()
	{
		Singleton<SoundManager>.Instance.StopAllMusic();
	}

	// Token: 0x0600F740 RID: 63296 RVA: 0x0055289C File Offset: 0x00550A9C
	public void AdvanceScript()
	{
		if (this.ICOMJMLACPH.Count > 0)
		{
			try
			{
				MoonSharp.Interpreter.Coroutine coroutine = this.ICOMJMLACPH.Peek();
				DynValue dynValue = coroutine.Resume();
				if (coroutine.State == CoroutineState.Dead)
				{
					this.ICOMJMLACPH.Pop();
					this.OEGKPMHIJGF = true;
				}
				if (dynValue.Type == DataType.Function)
				{
					this.ICOMJMLACPH.Push(this.LOKOJMIKEEL.CreateCoroutine(dynValue).Coroutine);
				}
			}
			catch (ScriptRuntimeException ex)
			{
				Debug.LogError(ex.DecoratedMessage);
				this.OEGKPMHIJGF = true;
				this.ICOMJMLACPH.Clear();
			}
		}
		else
		{
			this.OEGKPMHIJGF = true;
		}
	}

	// Token: 0x0600F741 RID: 63297 RVA: 0x00552958 File Offset: 0x00550B58
	public void EBIJMBJCPIG()
	{
		if (this.ICOMJMLACPH.Count > 0)
		{
			try
			{
				MoonSharp.Interpreter.Coroutine coroutine = this.ICOMJMLACPH.Peek();
				DynValue dynValue = coroutine.Resume();
				if (coroutine.State == CoroutineState.Suspended)
				{
					this.ICOMJMLACPH.Pop();
					this.OEGKPMHIJGF = true;
				}
				if (dynValue.Type == DataType.Number)
				{
					this.ICOMJMLACPH.Push(this.LOKOJMIKEEL.CreateCoroutine(dynValue).Coroutine);
				}
			}
			catch (ScriptRuntimeException ex)
			{
				Debug.LogError(ex.DecoratedMessage);
				this.OEGKPMHIJGF = false;
				this.ICOMJMLACPH.Clear();
			}
		}
		else
		{
			this.OEGKPMHIJGF = true;
		}
	}

	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x0600F754 RID: 63316 RVA: 0x00552700 File Offset: 0x00550900
	// (set) Token: 0x0600F742 RID: 63298 RVA: 0x00552658 File Offset: 0x00550858
	public GameEventInfo GEI
	{
		get
		{
			return this.JIMECEDODAF;
		}
		set
		{
			this.JIMECEDODAF = value;
		}
	}

	// Token: 0x0600F743 RID: 63299 RVA: 0x00552A14 File Offset: 0x00550C14
	public bool RunCheckCondionScript(string CJKEBFLPKKD)
	{
		return this.BCJNNAKCCKH(CJKEBFLPKKD);
	}

	// Token: 0x0600F744 RID: 63300 RVA: 0x00552A1D File Offset: 0x00550C1D
	public static void LNCGFCJAENP()
	{
		Singleton<SoundManager>.Instance.PGBLEMNPOIP();
	}

	// Token: 0x0600F745 RID: 63301 RVA: 0x00552A29 File Offset: 0x00550C29
	public static void MLDOGKCDPEL(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.DPNPEKBEPKE((AudioClip)ResourcesManager.OPIGIBCFLHE(NGLCFNBJCIN));
	}

	// Token: 0x0600F747 RID: 63303 RVA: 0x00552A49 File Offset: 0x00550C49
	public static void PlayMusic(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlayMusic((AudioClip)ResourcesManager.GetLoadedResource(NGLCFNBJCIN), 1f, true, false);
	}

	// Token: 0x0600F748 RID: 63304 RVA: 0x00552A68 File Offset: 0x00550C68
	public static void StopSounds()
	{
		Singleton<SoundManager>.Instance.StopAllSounds();
	}

	// Token: 0x0600F749 RID: 63305 RVA: 0x00552658 File Offset: 0x00550858
	public void GLOGJGHFFII(GameEventInfo DPNHODJHGJL)
	{
		this.JIMECEDODAF = DPNHODJHGJL;
	}

	// Token: 0x0600F74A RID: 63306 RVA: 0x00552A74 File Offset: 0x00550C74
	public bool AHKNANJJBJM(string CPCBPCJLDNC)
	{
		return this.DFHGAEEMHCA("Blues" + CPCBPCJLDNC);
	}

	// Token: 0x0600F74B RID: 63307 RVA: 0x00552661 File Offset: 0x00550861
	public void CEBILICFHAN()
	{
		this.Init();
	}

	// Token: 0x0600F74C RID: 63308 RVA: 0x00552661 File Offset: 0x00550861
	public void MCPIGBBEIHD()
	{
		this.Init();
	}

	// Token: 0x0600F74D RID: 63309 RVA: 0x00552A88 File Offset: 0x00550C88
	private bool BFEOBMCCHIK(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[8];
			array[0] = this.LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[2] = NIJLKJIPFCC;
			array[1] = Environment.NewLine;
			array[4] = this.BIAPMBPJPHE;
			string code = string.Concat(array);
			dynValue = this.LOKOJMIKEEL.DoString(code, null, null);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	// Token: 0x0600F74E RID: 63310 RVA: 0x00552708 File Offset: 0x00550908
	public bool CheckMapEventCondition(string CPCBPCJLDNC)
	{
		return this.BCJNNAKCCKH("return " + CPCBPCJLDNC);
	}

	// Token: 0x0600F74F RID: 63311 RVA: 0x00552B08 File Offset: 0x00550D08
	public bool BCKENCHNKJB(string CJKEBFLPKKD)
	{
		return this.MCDKGOLIBAP(CJKEBFLPKKD);
	}

	// Token: 0x0600F750 RID: 63312 RVA: 0x00552B14 File Offset: 0x00550D14
	private bool DFHGAEEMHCA(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[7];
			array[0] = this.LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[5] = NIJLKJIPFCC;
			array[2] = Environment.NewLine;
			array[7] = this.BIAPMBPJPHE;
			string code = string.Concat(array);
			dynValue = this.LOKOJMIKEEL.DoString(code, null, null);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	// Token: 0x0600F751 RID: 63313 RVA: 0x00552B94 File Offset: 0x00550D94
	public static void IJGCPKCFBMA(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.HFCDOGPNMCE((AudioClip)ResourcesManager.HIILLNPNNOB(NGLCFNBJCIN), 272f, true, true);
	}

	// Token: 0x0600F752 RID: 63314 RVA: 0x00552658 File Offset: 0x00550858
	public void BHFPNAPAFNM(GameEventInfo DPNHODJHGJL)
	{
		this.JIMECEDODAF = DPNHODJHGJL;
	}

	// Token: 0x0600F753 RID: 63315 RVA: 0x00552700 File Offset: 0x00550900
	public GameEventInfo NOCNNNKPEGI()
	{
		return this.JIMECEDODAF;
	}

	// Token: 0x0600F755 RID: 63317 RVA: 0x00552BB4 File Offset: 0x00550DB4
	private bool CAMLLJKNLKC(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[1];
			array[0] = this.LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[7] = NIJLKJIPFCC;
			array[8] = Environment.NewLine;
			array[0] = this.BIAPMBPJPHE;
			string code = string.Concat(array);
			dynValue = this.LOKOJMIKEEL.DoString(code, null, null);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	// Token: 0x0600F756 RID: 63318 RVA: 0x00552700 File Offset: 0x00550900
	public GameEventInfo KNBBEFDHELF()
	{
		return this.JIMECEDODAF;
	}

	// Token: 0x0600F757 RID: 63319 RVA: 0x005523D3 File Offset: 0x005505D3
	private static void IOCIMOEILGA(string BDIMLMKEEKO)
	{
		Debug.Log(BDIMLMKEEKO);
	}

	// Token: 0x04001B62 RID: 7010
	private bool OEGKPMHIJGF = true;

	// Token: 0x04001B63 RID: 7011
	private Script LOKOJMIKEEL;

	// Token: 0x04001B64 RID: 7012
	private Stack<MoonSharp.Interpreter.Coroutine> ICOMJMLACPH;

	// Token: 0x04001B65 RID: 7013
	private GameState CCNDFDNOFDO;

	// Token: 0x04001B66 RID: 7014
	private string CIGLJOGKLFA;

	// Token: 0x04001B67 RID: 7015
	private string OMOCDFBLLPC;

	// Token: 0x04001B68 RID: 7016
	private readonly string LAKLDHDHLDL = "local CheckCondition = function()";

	// Token: 0x04001B69 RID: 7017
	private readonly string BIAPMBPJPHE = "end" + Environment.NewLine + "return CheckCondition()";

	// Token: 0x04001B6A RID: 7018
	private FinishedMapInfo DKGEKMEAJDN;

	// Token: 0x04001B6B RID: 7019
	private GameEventInfo JIMECEDODAF;

	// Token: 0x04001B6C RID: 7020
	[CompilerGenerated]
	private static Action<string> BOGJGOAMCHK;

	// Token: 0x04001B6D RID: 7021
	[CompilerGenerated]
	private static Action<string> BDPNFNJNEFM;

	// Token: 0x04001B6E RID: 7022
	[CompilerGenerated]
	private static Action MJKNAFJKDMG;

	// Token: 0x04001B6F RID: 7023
	[CompilerGenerated]
	private static Action JENGHDFDLII;

	// Token: 0x04001B70 RID: 7024
	[CompilerGenerated]
	private static Action<string> LNIJKGECNME;
}
