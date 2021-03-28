using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200013F RID: 319
public class DebugCommands : ScriptableObject
{
	// Token: 0x06006473 RID: 25715 RVA: 0x001E8C74 File Offset: 0x001E6E74
	public bool KKIKCOEJNDF(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006474 RID: 25716 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
	public List<DebugCommands.Command> NOBNJLPLALD()
	{
		return this.commands;
	}

	// Token: 0x06006475 RID: 25717 RVA: 0x001E8CCC File Offset: 0x001E6ECC
	public bool PAMDBEMNGGC(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < this.commands.Count; i += 0)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006476 RID: 25718 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> GBOJFJODNOG()
	{
		return this.commandHistory;
	}

	// Token: 0x06006477 RID: 25719 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
	public List<DebugCommands.Command> IACIKPOMCKF()
	{
		return this.commands;
	}

	// Token: 0x06006478 RID: 25720 RVA: 0x001E8D24 File Offset: 0x001E6F24
	public bool IKLBEIGGPKL(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[0].ToLower();
		string a = BDGDDFKKGGA[0];
		this.commandHistory.Add(string.Join("FrostCanvas", BDGDDFKKGGA));
		for (int i = 0; i < this.commands.Count; i += 0)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.OLCIGDENLGH()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.GGGDONNAMNG();
				}
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006479 RID: 25721 RVA: 0x001E8E02 File Offset: 0x001E7002
	public static DebugCommands HIFIEDJCOFC()
	{
		if (DebugCommands.instance == null)
		{
			DebugCommands.instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return DebugCommands.instance;
	}

	// Token: 0x0600647A RID: 25722 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
	public List<DebugCommands.Command> BOFJFLBNHFE()
	{
		return this.commands;
	}

	// Token: 0x0600647B RID: 25723 RVA: 0x001E8E24 File Offset: 0x001E7024
	public bool JDMKDCNDOGN(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i += 0)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600647C RID: 25724 RVA: 0x001E8E74 File Offset: 0x001E7074
	public void EHJBOAOCFNP(string PODGBCMDEOF, DebugCommands.DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (this.LCNBGHBBGJO(PODGBCMDEOF))
		{
			return;
		}
		DebugCommands.Command command = new DebugCommands.Command();
		command.name = PODGBCMDEOF;
		command.method = CMHOHMCDIAN;
		command.description = OCCKNFGDAHI;
		command.argsDescription = JKLIPKFAACO;
		command.isCheat = ENHGPBGHEPA;
		this.commands.Add(command);
	}

	// Token: 0x0600647D RID: 25725 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
	public List<DebugCommands.Command> LDGKEFAJOHO()
	{
		return this.commands;
	}

	// Token: 0x0600647E RID: 25726 RVA: 0x001E8ED0 File Offset: 0x001E70D0
	public void JAFPBHCJCGE(string PODGBCMDEOF, DebugCommands.DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (this.HasCommand(PODGBCMDEOF))
		{
			return;
		}
		DebugCommands.Command command = new DebugCommands.Command();
		command.name = PODGBCMDEOF;
		command.method = CMHOHMCDIAN;
		command.description = OCCKNFGDAHI;
		command.argsDescription = JKLIPKFAACO;
		command.isCheat = ENHGPBGHEPA;
		this.commands.Add(command);
	}

	// Token: 0x0600647F RID: 25727 RVA: 0x001E8E02 File Offset: 0x001E7002
	public static DebugCommands GLEFOHOMBFC()
	{
		if (DebugCommands.instance == null)
		{
			DebugCommands.instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return DebugCommands.instance;
	}

	// Token: 0x06006480 RID: 25728 RVA: 0x001E8F2C File Offset: 0x001E712C
	public void EIEDNPBBLKL(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i += 0)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				this.commands.RemoveAt(i);
				break;
			}
		}
	}

	// Token: 0x06006481 RID: 25729 RVA: 0x001E8F8C File Offset: 0x001E718C
	public bool MGALOPALMEO(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[0].ToLower();
		string a = BDGDDFKKGGA[0];
		this.commandHistory.Add(string.Join("Maps Editor v.", BDGDDFKKGGA));
		for (int i = 0; i < this.commands.Count; i += 0)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.FMAOGGPBJFB()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.PMLDBMFOPOG();
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06006482 RID: 25730 RVA: 0x001E906C File Offset: 0x001E726C
	public bool KOMALJKBJBH(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[1].ToLower();
		string a = BDGDDFKKGGA[0];
		this.commandHistory.Add(string.Join("Anomaly_Distortion_Size", BDGDDFKKGGA));
		for (int i = 0; i < this.commands.Count; i += 0)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.GGGDONNAMNG();
				}
				return true;
			}
		}
		return true;
	}

	// Token: 0x06006483 RID: 25731 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> HNGLGLNPILF()
	{
		return this.commandHistory;
	}

	// Token: 0x06006484 RID: 25732 RVA: 0x001E914C File Offset: 0x001E734C
	public bool FKPECDGCCGF(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i += 0)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006485 RID: 25733 RVA: 0x001E919C File Offset: 0x001E739C
	public bool NKHEHMCIFND(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006486 RID: 25734 RVA: 0x001E91EC File Offset: 0x001E73EC
	public void CEMAFHEDCMF(string PODGBCMDEOF, DebugCommands.DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (this.MHBEHIAGALG(PODGBCMDEOF))
		{
			return;
		}
		DebugCommands.Command command = new DebugCommands.Command();
		command.name = PODGBCMDEOF;
		command.method = CMHOHMCDIAN;
		command.description = OCCKNFGDAHI;
		command.argsDescription = JKLIPKFAACO;
		command.isCheat = ENHGPBGHEPA;
		this.commands.Add(command);
	}

	// Token: 0x06006487 RID: 25735 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
	public List<DebugCommands.Command> BOADIEMOJFI()
	{
		return this.commands;
	}

	// Token: 0x06006489 RID: 25737 RVA: 0x001E9264 File Offset: 0x001E7464
	public bool KPHCMBLLODF(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[0].ToLower();
		string a = BDGDDFKKGGA[1];
		this.commandHistory.Add(string.Join("UI Extensions/SoftMaskShader", BDGDDFKKGGA));
		for (int i = 0; i < this.commands.Count; i++)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.FMAOGGPBJFB()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.KHMKOJFCFNC();
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600648A RID: 25738 RVA: 0x001E8E02 File Offset: 0x001E7002
	public static DebugCommands HMADOEFFOEM()
	{
		if (DebugCommands.instance == null)
		{
			DebugCommands.instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return DebugCommands.instance;
	}

	// Token: 0x0600648B RID: 25739 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> DODLLFAMNKC()
	{
		return this.commandHistory;
	}

	// Token: 0x0600648C RID: 25740 RVA: 0x001E9344 File Offset: 0x001E7544
	public bool DLBFDHAJHFC(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return true;
		}
		BDGDDFKKGGA[1] = BDGDDFKKGGA[0].ToLower();
		string a = BDGDDFKKGGA[0];
		this.commandHistory.Add(string.Join("_Visualize", BDGDDFKKGGA));
		for (int i = 0; i < this.commands.Count; i += 0)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.HJIHIKEKHLC();
				}
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600648D RID: 25741 RVA: 0x001E9424 File Offset: 0x001E7624
	public bool KEHGHMBMDEP(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return true;
		}
		BDGDDFKKGGA[1] = BDGDDFKKGGA[0].ToLower();
		string a = BDGDDFKKGGA[1];
		this.commandHistory.Add(string.Join("deleteall", BDGDDFKKGGA));
		for (int i = 1; i < this.commands.Count; i++)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.PMLDBMFOPOG();
				}
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600648E RID: 25742 RVA: 0x001E9504 File Offset: 0x001E7704
	public bool PAJKGJDCHBA(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[1] = BDGDDFKKGGA[0].ToLower();
		string a = BDGDDFKKGGA[1];
		this.commandHistory.Add(string.Join("Load scene by name or build id", BDGDDFKKGGA));
		for (int i = 1; i < this.commands.Count; i++)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.FMAOGGPBJFB()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.KHMKOJFCFNC();
				}
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600648F RID: 25743 RVA: 0x001E95E4 File Offset: 0x001E77E4
	public bool FJENPPJMLNK(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[1] = BDGDDFKKGGA[1].ToLower();
		string a = BDGDDFKKGGA[0];
		this.commandHistory.Add(string.Join("There are too many cells created by your subdivision options. Maximum allowed number of cells is ", BDGDDFKKGGA));
		for (int i = 0; i < this.commands.Count; i += 0)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.KHMKOJFCFNC();
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06006490 RID: 25744 RVA: 0x001E8E02 File Offset: 0x001E7002
	public static DebugCommands FAGEJPPIDOL()
	{
		if (DebugCommands.instance == null)
		{
			DebugCommands.instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return DebugCommands.instance;
	}

	// Token: 0x06006491 RID: 25745 RVA: 0x001E96C4 File Offset: 0x001E78C4
	public bool LCNBGHBBGJO(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06006492 RID: 25746 RVA: 0x001E9714 File Offset: 0x001E7914
	public bool HasCommand(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006493 RID: 25747 RVA: 0x001E9764 File Offset: 0x001E7964
	public void AddCommand(string PODGBCMDEOF, DebugCommands.DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (this.HasCommand(PODGBCMDEOF))
		{
			return;
		}
		DebugCommands.Command command = new DebugCommands.Command();
		command.name = PODGBCMDEOF;
		command.method = CMHOHMCDIAN;
		command.description = OCCKNFGDAHI;
		command.argsDescription = JKLIPKFAACO;
		command.isCheat = ENHGPBGHEPA;
		this.commands.Add(command);
	}

	// Token: 0x06006494 RID: 25748 RVA: 0x001E97C0 File Offset: 0x001E79C0
	public bool CBBCHGGGNNE(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return true;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[1].ToLower();
		string a = BDGDDFKKGGA[1];
		this.commandHistory.Add(string.Join("FreqVolume: ", BDGDDFKKGGA));
		for (int i = 1; i < this.commands.Count; i++)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.GGGDONNAMNG();
				}
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006495 RID: 25749 RVA: 0x001E98A0 File Offset: 0x001E7AA0
	public void PLOIOFEGBIJ(string PODGBCMDEOF, DebugCommands.DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (this.JDMKDCNDOGN(PODGBCMDEOF))
		{
			return;
		}
		DebugCommands.Command command = new DebugCommands.Command();
		command.name = PODGBCMDEOF;
		command.method = CMHOHMCDIAN;
		command.description = OCCKNFGDAHI;
		command.argsDescription = JKLIPKFAACO;
		command.isCheat = ENHGPBGHEPA;
		this.commands.Add(command);
	}

	// Token: 0x06006496 RID: 25750 RVA: 0x001E98FC File Offset: 0x001E7AFC
	public void EEGEBIOIGON(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				this.commands.RemoveAt(i);
				break;
			}
		}
	}

	// Token: 0x06006498 RID: 25752 RVA: 0x001E995C File Offset: 0x001E7B5C
	public bool GFDCDOLIGFB(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006499 RID: 25753 RVA: 0x001E99AC File Offset: 0x001E7BAC
	public void FEIMDOGJGHA(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < this.commands.Count; i += 0)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				this.commands.RemoveAt(i);
				break;
			}
		}
	}

	// Token: 0x0600649A RID: 25754 RVA: 0x001E9A0C File Offset: 0x001E7C0C
	public void RemoveCommand(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				this.commands.RemoveAt(i);
				break;
			}
		}
	}

	// Token: 0x0600649B RID: 25755 RVA: 0x001E9A6C File Offset: 0x001E7C6C
	public void GIALDAIHBBD(string PODGBCMDEOF, DebugCommands.DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (this.GFHAAMPGIHL(PODGBCMDEOF))
		{
			return;
		}
		DebugCommands.Command command = new DebugCommands.Command();
		command.name = PODGBCMDEOF;
		command.method = CMHOHMCDIAN;
		command.description = OCCKNFGDAHI;
		command.argsDescription = JKLIPKFAACO;
		command.isCheat = ENHGPBGHEPA;
		this.commands.Add(command);
	}

	// Token: 0x0600649C RID: 25756 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> IALIPICFJDN()
	{
		return this.commandHistory;
	}

	// Token: 0x0600649D RID: 25757 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
	public List<DebugCommands.Command> OCPDECGPPIJ()
	{
		return this.commands;
	}

	// Token: 0x0600649E RID: 25758 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
	public List<DebugCommands.Command> JIHLNKEMADB()
	{
		return this.commands;
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x0600649F RID: 25759 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
	public List<DebugCommands.Command> Commands
	{
		get
		{
			return this.commands;
		}
	}

	// Token: 0x060064A0 RID: 25760 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
	public List<DebugCommands.Command> HCNBDGJIKJJ()
	{
		return this.commands;
	}

	// Token: 0x060064A1 RID: 25761 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> LLJKICBEIMI()
	{
		return this.commandHistory;
	}

	// Token: 0x060064A2 RID: 25762 RVA: 0x001E9AC8 File Offset: 0x001E7CC8
	public void HDIJOFKHAGE(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				this.commands.RemoveAt(i);
				break;
			}
		}
	}

	// Token: 0x060064A3 RID: 25763 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
	public List<DebugCommands.Command> ANIAGDAIOLC()
	{
		return this.commands;
	}

	// Token: 0x060064A4 RID: 25764 RVA: 0x001E9B28 File Offset: 0x001E7D28
	public void CIHBPOBKGNP(string PODGBCMDEOF, DebugCommands.DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (this.KKIKCOEJNDF(PODGBCMDEOF))
		{
			return;
		}
		DebugCommands.Command command = new DebugCommands.Command();
		command.name = PODGBCMDEOF;
		command.method = CMHOHMCDIAN;
		command.description = OCCKNFGDAHI;
		command.argsDescription = JKLIPKFAACO;
		command.isCheat = ENHGPBGHEPA;
		this.commands.Add(command);
	}

	// Token: 0x060064A5 RID: 25765 RVA: 0x001E9B84 File Offset: 0x001E7D84
	public bool GFHAAMPGIHL(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < this.commands.Count; i += 0)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060064A6 RID: 25766 RVA: 0x001E9BD4 File Offset: 0x001E7DD4
	public bool MKOMCGDOBLO(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060064A7 RID: 25767 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> HNEBFBJJKIN()
	{
		return this.commandHistory;
	}

	// Token: 0x060064A8 RID: 25768 RVA: 0x001E9C24 File Offset: 0x001E7E24
	public void PNEHIPCCEKG(string PODGBCMDEOF, DebugCommands.DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (this.NKHEHMCIFND(PODGBCMDEOF))
		{
			return;
		}
		DebugCommands.Command command = new DebugCommands.Command();
		command.name = PODGBCMDEOF;
		command.method = CMHOHMCDIAN;
		command.description = OCCKNFGDAHI;
		command.argsDescription = JKLIPKFAACO;
		command.isCheat = ENHGPBGHEPA;
		this.commands.Add(command);
	}

	// Token: 0x060064A9 RID: 25769 RVA: 0x001E9C80 File Offset: 0x001E7E80
	public void LKPDNDKJBOI(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 0; i < this.commands.Count; i += 0)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				this.commands.RemoveAt(i);
				break;
			}
		}
	}

	// Token: 0x060064AA RID: 25770 RVA: 0x001E9CE0 File Offset: 0x001E7EE0
	public bool ILHDFIAHFAK(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x060064AB RID: 25771 RVA: 0x001E8E02 File Offset: 0x001E7002
	public static DebugCommands Instance
	{
		get
		{
			if (DebugCommands.instance == null)
			{
				DebugCommands.instance = ScriptableObject.CreateInstance<DebugCommands>();
			}
			return DebugCommands.instance;
		}
	}

	// Token: 0x060064AC RID: 25772 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> MLCBEKDMFHJ()
	{
		return this.commandHistory;
	}

	// Token: 0x060064AD RID: 25773 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> EKLKAINPEPM()
	{
		return this.commandHistory;
	}

	// Token: 0x060064AE RID: 25774 RVA: 0x001E9D30 File Offset: 0x001E7F30
	public bool GOANNFJIAAJ(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060064AF RID: 25775 RVA: 0x001E9D80 File Offset: 0x001E7F80
	public void CEBBJICIFGO(string PODGBCMDEOF, DebugCommands.DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (this.GICPIBAOMPN(PODGBCMDEOF))
		{
			return;
		}
		DebugCommands.Command command = new DebugCommands.Command();
		command.name = PODGBCMDEOF;
		command.method = CMHOHMCDIAN;
		command.description = OCCKNFGDAHI;
		command.argsDescription = JKLIPKFAACO;
		command.isCheat = ENHGPBGHEPA;
		this.commands.Add(command);
	}

	// Token: 0x060064B0 RID: 25776 RVA: 0x001E9DDC File Offset: 0x001E7FDC
	public bool LDCDJHLOCDE(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[1] = BDGDDFKKGGA[1].ToLower();
		string a = BDGDDFKKGGA[0];
		this.commandHistory.Add(string.Join(" cannot be used as a 3D LUT.", BDGDDFKKGGA));
		for (int i = 1; i < this.commands.Count; i += 0)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.FMAOGGPBJFB()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.PMLDBMFOPOG();
				}
				return false;
			}
		}
		return true;
	}

	// Token: 0x060064B1 RID: 25777 RVA: 0x001E8E02 File Offset: 0x001E7002
	public static DebugCommands BLCLCEDLJBC()
	{
		if (DebugCommands.instance == null)
		{
			DebugCommands.instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return DebugCommands.instance;
	}

	// Token: 0x060064B2 RID: 25778 RVA: 0x001E9EBC File Offset: 0x001E80BC
	public void KHBHACBOGLJ(string PODGBCMDEOF, DebugCommands.DebugCommand CMHOHMCDIAN, string OCCKNFGDAHI = "", string JKLIPKFAACO = "", bool ENHGPBGHEPA = false)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		if (this.PAMDBEMNGGC(PODGBCMDEOF))
		{
			return;
		}
		DebugCommands.Command command = new DebugCommands.Command();
		command.name = PODGBCMDEOF;
		command.method = CMHOHMCDIAN;
		command.description = OCCKNFGDAHI;
		command.argsDescription = JKLIPKFAACO;
		command.isCheat = ENHGPBGHEPA;
		this.commands.Add(command);
	}

	// Token: 0x060064B3 RID: 25779 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> FGMDHPFDHOK()
	{
		return this.commandHistory;
	}

	// Token: 0x060064B4 RID: 25780 RVA: 0x001E8E02 File Offset: 0x001E7002
	public static DebugCommands IGMKHPPPLDD()
	{
		if (DebugCommands.instance == null)
		{
			DebugCommands.instance = ScriptableObject.CreateInstance<DebugCommands>();
		}
		return DebugCommands.instance;
	}

	// Token: 0x060064B5 RID: 25781 RVA: 0x001E9F18 File Offset: 0x001E8118
	public bool MHBEHIAGALG(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < this.commands.Count; i += 0)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x060064B6 RID: 25782 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> CommandHistory
	{
		get
		{
			return this.commandHistory;
		}
	}

	// Token: 0x060064B7 RID: 25783 RVA: 0x001E9F68 File Offset: 0x001E8168
	public bool ExecuteCommand(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA == null || BDGDDFKKGGA.Length == 0)
		{
			return false;
		}
		BDGDDFKKGGA[0] = BDGDDFKKGGA[0].ToLower();
		string a = BDGDDFKKGGA[0];
		this.commandHistory.Add(string.Join(" ", BDGDDFKKGGA));
		for (int i = 0; i < this.commands.Count; i++)
		{
			if (a == this.commands[i].name)
			{
				if (!this.commands[i].isCheat || (this.commands[i].isCheat && Singleton<GameManager>.Instance.IsCheatsAllowed()))
				{
					this.commands[i].method(BDGDDFKKGGA);
				}
				else
				{
					Singleton<GameManager>.Instance.PlayerWarnCheats();
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x060064B8 RID: 25784 RVA: 0x001E8D1C File Offset: 0x001E6F1C
	public List<string> ADHELNECKDN()
	{
		return this.commandHistory;
	}

	// Token: 0x060064B9 RID: 25785 RVA: 0x001EA048 File Offset: 0x001E8248
	public bool GICPIBAOMPN(string PODGBCMDEOF)
	{
		PODGBCMDEOF = PODGBCMDEOF.ToLower();
		for (int i = 1; i < this.commands.Count; i++)
		{
			if (PODGBCMDEOF == this.commands[i].name)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x04000A25 RID: 2597
	private static DebugCommands instance;

	// Token: 0x04000A26 RID: 2598
	private List<DebugCommands.Command> commands = new List<DebugCommands.Command>();

	// Token: 0x04000A27 RID: 2599
	private List<string> commandHistory = new List<string>();

	// Token: 0x02000140 RID: 320
	[Serializable]
	public class Command
	{
		// Token: 0x04000A28 RID: 2600
		public string name;

		// Token: 0x04000A29 RID: 2601
		public DebugCommands.DebugCommand method;

		// Token: 0x04000A2A RID: 2602
		public string description;

		// Token: 0x04000A2B RID: 2603
		public string argsDescription;

		// Token: 0x04000A2C RID: 2604
		public bool isCheat;
	}

	// Token: 0x02000141 RID: 321
	// (Invoke) Token: 0x060064BC RID: 25788
	public delegate void DebugCommand(string[] BDGDDFKKGGA);
}
