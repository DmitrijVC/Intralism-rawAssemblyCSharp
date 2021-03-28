using System;
using HardShellStudios.InputManager;
using UnityEngine;

// Token: 0x0200015C RID: 348
public class hardInput : MonoBehaviour
{
	// Token: 0x060067A4 RID: 26532 RVA: 0x001F30B1 File Offset: 0x001F12B1
	public static string NFAMPNFLAEJ(string AKOENHBOCOD, bool BIDPCNEDFME)
	{
		return Singleton<hardManager>.Instance.HDELGDBGOCG(AKOENHBOCOD, BIDPCNEDFME);
	}

	// Token: 0x060067A5 RID: 26533 RVA: 0x001F30BF File Offset: 0x001F12BF
	public static float GetAxis(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.GetAxis(AKOENHBOCOD, CBHEHDPFFGE, IKOENAGPJCG);
	}

	// Token: 0x060067A6 RID: 26534 RVA: 0x001F30CE File Offset: 0x001F12CE
	public static bool CHAJOGCCKDA(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.GetKeyDown(AKOENHBOCOD);
	}

	// Token: 0x060067A7 RID: 26535 RVA: 0x001F30DC File Offset: 0x001F12DC
	public static hardInput.controllerType GetControllerType()
	{
		switch (Singleton<hardManager>.Instance.controllerType)
		{
		case 1:
			return hardInput.controllerType.PS4;
		case 2:
			return hardInput.controllerType.XBOX1;
		case 3:
			return hardInput.controllerType.XBOX360;
		default:
			return hardInput.controllerType.PS3;
		}
	}

	// Token: 0x060067A8 RID: 26536 RVA: 0x001F3114 File Offset: 0x001F1314
	public static bool GKLCHNPAEAL(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.GetKey(AKOENHBOCOD);
	}

	// Token: 0x060067A9 RID: 26537 RVA: 0x001F3121 File Offset: 0x001F1321
	public static void OLHMLFIEIDO(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
	{
		Singleton<hardManager>.Instance.BAIMLCIHANB(MDDCBDHGNPA, CKLPEJDAMME, FEFOLHEFCKP);
	}

	// Token: 0x060067AA RID: 26538 RVA: 0x001F3130 File Offset: 0x001F1330
	public static bool NGFFMGKPMNP(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.GJPKJMNGJKG(AKOENHBOCOD);
	}

	// Token: 0x060067AB RID: 26539 RVA: 0x001F313D File Offset: 0x001F133D
	public static int DMPGINIIIFJ()
	{
		return Singleton<hardManager>.Instance.controllerType;
	}

	// Token: 0x060067AC RID: 26540 RVA: 0x001F3149 File Offset: 0x001F1349
	public static string EPIFCBNFKNO(string AKOENHBOCOD, bool BIDPCNEDFME)
	{
		return Singleton<hardManager>.Instance.MKCKJLLCMED(AKOENHBOCOD, BIDPCNEDFME);
	}

	// Token: 0x060067AD RID: 26541 RVA: 0x001F3157 File Offset: 0x001F1357
	public static void ForceRebind(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.HardStartRebind(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	// Token: 0x060067AE RID: 26542 RVA: 0x001F3166 File Offset: 0x001F1366
	public static float DAKLFCPPJDB(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.FALNNGMABKM(AKOENHBOCOD, CBHEHDPFFGE, IKOENAGPJCG);
	}

	// Token: 0x060067AF RID: 26543 RVA: 0x001F3175 File Offset: 0x001F1375
	public static bool KFKHHOLEGOK(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.KDHDPECKBJC(AKOENHBOCOD);
	}

	// Token: 0x060067B0 RID: 26544 RVA: 0x001F3182 File Offset: 0x001F1382
	public static KeyCode DOGMPIJBDAA(string AKOENHBOCOD, bool DFBNBCOFIFK)
	{
		return Singleton<hardManager>.Instance.CLBENCAJDKH(AKOENHBOCOD, DFBNBCOFIFK);
	}

	// Token: 0x060067B1 RID: 26545 RVA: 0x001F3190 File Offset: 0x001F1390
	public static void HardStartRebind(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
	{
		Singleton<hardManager>.Instance.HardStartRebind(MDDCBDHGNPA, CKLPEJDAMME, FEFOLHEFCKP);
	}

	// Token: 0x060067B2 RID: 26546 RVA: 0x001F319F File Offset: 0x001F139F
	public static void OAIAELNMMKC(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.LJFEBNEOADJ(JOKLAPMFDGO);
	}

	// Token: 0x060067B3 RID: 26547 RVA: 0x001F31AC File Offset: 0x001F13AC
	public static bool AADFFLGEJPP(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.MOFCDBDBOOL(AKOENHBOCOD);
	}

	// Token: 0x060067B4 RID: 26548 RVA: 0x001F313D File Offset: 0x001F133D
	public static int MHGLJHAPGAH()
	{
		return Singleton<hardManager>.Instance.controllerType;
	}

	// Token: 0x060067B5 RID: 26549 RVA: 0x001F31BC File Offset: 0x001F13BC
	public static hardInput.controllerType PJLOEACMLHO()
	{
		switch (Singleton<hardManager>.Instance.controllerType)
		{
		case 1:
			return hardInput.controllerType.PS3;
		case 2:
			return (hardInput.controllerType)4;
		case 3:
			return hardInput.controllerType.PS3;
		default:
			return hardInput.controllerType.PS4;
		}
	}

	// Token: 0x060067B6 RID: 26550 RVA: 0x001F313D File Offset: 0x001F133D
	public static int OKOPFPIEOLE()
	{
		return Singleton<hardManager>.Instance.controllerType;
	}

	// Token: 0x060067B7 RID: 26551 RVA: 0x001F31F4 File Offset: 0x001F13F4
	public static void ADDMOGHAPPA(string HPLOOEJMLFD)
	{
		Singleton<hardManager>.Instance.LDCDBIBDNAN(HPLOOEJMLFD);
	}

	// Token: 0x060067B8 RID: 26552 RVA: 0x001F3201 File Offset: 0x001F1401
	public static void JOJBOPLIEIF(hardInput.controllerType HMGBJCGOLMI)
	{
		Singleton<hardManager>.Instance.MPIEAKCINJD(HMGBJCGOLMI);
	}

	// Token: 0x060067B9 RID: 26553 RVA: 0x001F30CE File Offset: 0x001F12CE
	public static bool GetKeyDown(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.GetKeyDown(AKOENHBOCOD);
	}

	// Token: 0x060067BA RID: 26554 RVA: 0x001F320E File Offset: 0x001F140E
	public static void SetControllerType(hardInput.controllerType HMGBJCGOLMI)
	{
		Singleton<hardManager>.Instance.setControllerType(HMGBJCGOLMI);
	}

	// Token: 0x060067BB RID: 26555 RVA: 0x001F321B File Offset: 0x001F141B
	public static void ECIMNKJADCB(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.ECIEMPEMHPL(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	// Token: 0x060067BC RID: 26556 RVA: 0x001F322A File Offset: 0x001F142A
	public static void CNHLFADKBOL(bool CGCEBPNHLIP)
	{
		Singleton<hardManager>.Instance.GPFKHMIPLEP(CGCEBPNHLIP);
	}

	// Token: 0x060067BD RID: 26557 RVA: 0x001F321B File Offset: 0x001F141B
	public static void HBGCDCCFNDJ(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.ECIEMPEMHPL(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	// Token: 0x060067BE RID: 26558 RVA: 0x001F3114 File Offset: 0x001F1314
	public static bool GetKey(string AKOENHBOCOD)
	{
		return Singleton<hardManager>.Instance.GetKey(AKOENHBOCOD);
	}

	// Token: 0x060067BF RID: 26559 RVA: 0x001F3237 File Offset: 0x001F1437
	public static void JKCPGIDFPOF(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.GJKHADOOHAG(JOKLAPMFDGO);
	}

	// Token: 0x060067C0 RID: 26560 RVA: 0x001F313D File Offset: 0x001F133D
	public static int GetControllerTypeIndex()
	{
		return Singleton<hardManager>.Instance.controllerType;
	}

	// Token: 0x060067C1 RID: 26561 RVA: 0x001F3244 File Offset: 0x001F1444
	public static void BAHDOGHKOLG(hardInput.controllerType HMGBJCGOLMI)
	{
		Singleton<hardManager>.Instance.MGHMFJAHGOC(HMGBJCGOLMI);
	}

	// Token: 0x060067C2 RID: 26562 RVA: 0x001F313D File Offset: 0x001F133D
	public static int KPJLKHBOGGI()
	{
		return Singleton<hardManager>.Instance.controllerType;
	}

	// Token: 0x060067C3 RID: 26563 RVA: 0x001F3254 File Offset: 0x001F1454
	public static hardInput.controllerType ONBPEBFBKNH()
	{
		switch (Singleton<hardManager>.Instance.controllerType)
		{
		case 1:
			return hardInput.controllerType.PS3;
		case 2:
			return (hardInput.controllerType)8;
		case 3:
			return hardInput.controllerType.PS3;
		default:
			return hardInput.controllerType.PS4;
		}
	}

	// Token: 0x060067C4 RID: 26564 RVA: 0x001F328C File Offset: 0x001F148C
	public static void MLBHACCKKDF(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.PFBDLOENJGP(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	// Token: 0x060067C5 RID: 26565 RVA: 0x001F31F4 File Offset: 0x001F13F4
	public static void LDNIGNMHCOM(string HPLOOEJMLFD)
	{
		Singleton<hardManager>.Instance.LDCDBIBDNAN(HPLOOEJMLFD);
	}

	// Token: 0x060067C6 RID: 26566 RVA: 0x001F329B File Offset: 0x001F149B
	public static void BDDFOBPPHMC(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.JBCPEEBCPKF(JOKLAPMFDGO);
	}

	// Token: 0x060067C7 RID: 26567 RVA: 0x001F32A8 File Offset: 0x001F14A8
	public static hardInput.controllerType MMOLCHLLCMM()
	{
		switch (Singleton<hardManager>.Instance.controllerType)
		{
		case 0:
			return hardInput.controllerType.PS4;
		case 1:
			return (hardInput.controllerType)4;
		case 2:
			return hardInput.controllerType.PS3;
		default:
			return hardInput.controllerType.PS4;
		}
	}

	// Token: 0x060067C8 RID: 26568 RVA: 0x001F32E0 File Offset: 0x001F14E0
	public static void ResetBinding(string HPLOOEJMLFD)
	{
		Singleton<hardManager>.Instance.resetKey(HPLOOEJMLFD);
	}

	// Token: 0x060067C9 RID: 26569 RVA: 0x001F32ED File Offset: 0x001F14ED
	public static float PMJHMIKCPBI(string AKOENHBOCOD, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.GFIOHABJNCG(AKOENHBOCOD, IKOENAGPJCG);
	}

	// Token: 0x060067CA RID: 26570 RVA: 0x001F32FB File Offset: 0x001F14FB
	public static KeyCode MBEBKPNJGOP(string AKOENHBOCOD, bool DFBNBCOFIFK)
	{
		return Singleton<hardManager>.Instance.FPNHCCEFMPJ(AKOENHBOCOD, DFBNBCOFIFK);
	}

	// Token: 0x060067CB RID: 26571 RVA: 0x001F3309 File Offset: 0x001F1509
	public static KeyCode GetKeyCode(string AKOENHBOCOD, bool DFBNBCOFIFK)
	{
		return Singleton<hardManager>.Instance.GetKeyCode(AKOENHBOCOD, DFBNBCOFIFK);
	}

	// Token: 0x060067CC RID: 26572 RVA: 0x001F3317 File Offset: 0x001F1517
	public static string GetKeyName(string AKOENHBOCOD, bool BIDPCNEDFME)
	{
		return Singleton<hardManager>.Instance.GetKeyName(AKOENHBOCOD, BIDPCNEDFME);
	}

	// Token: 0x060067CD RID: 26573 RVA: 0x001F3325 File Offset: 0x001F1525
	public static void ResetAllBindings()
	{
		Singleton<hardManager>.Instance.resetSavedKeys();
	}

	// Token: 0x060067CE RID: 26574 RVA: 0x001F3331 File Offset: 0x001F1531
	public static void JONAFAINKKM()
	{
		Singleton<hardManager>.Instance.JDFLEIALCNP();
	}

	// Token: 0x060067CF RID: 26575 RVA: 0x001F333D File Offset: 0x001F153D
	public static void KNFDDKEBKJC(string MDDCBDHGNPA, bool CKLPEJDAMME, hardInputUI FEFOLHEFCKP)
	{
		Singleton<hardManager>.Instance.HKMGFPGHALH(MDDCBDHGNPA, CKLPEJDAMME, FEFOLHEFCKP);
	}

	// Token: 0x060067D1 RID: 26577 RVA: 0x001F334C File Offset: 0x001F154C
	public static void MouseLock(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.MouseLock(JOKLAPMFDGO);
	}

	// Token: 0x060067D2 RID: 26578 RVA: 0x001F3201 File Offset: 0x001F1401
	public static void CEEHKMILMFP(hardInput.controllerType HMGBJCGOLMI)
	{
		Singleton<hardManager>.Instance.MPIEAKCINJD(HMGBJCGOLMI);
	}

	// Token: 0x060067D3 RID: 26579 RVA: 0x001F3359 File Offset: 0x001F1559
	public static float GMNJKCNIPGD(string AKOENHBOCOD, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.GCDMKFIGIPC(AKOENHBOCOD, IKOENAGPJCG);
	}

	// Token: 0x060067D4 RID: 26580 RVA: 0x001F3367 File Offset: 0x001F1567
	public static void OLLPEIBAMOG(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.FGNFNHNPOHJ(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	// Token: 0x060067D5 RID: 26581 RVA: 0x001F3376 File Offset: 0x001F1576
	public static void ALPEDOCMBGL(hardInput.controllerType HMGBJCGOLMI)
	{
		Singleton<hardManager>.Instance.HJMOHHOAEHL(HMGBJCGOLMI);
	}

	// Token: 0x060067D6 RID: 26582 RVA: 0x001F3384 File Offset: 0x001F1584
	public static hardInput.controllerType IGGONOJJBLD()
	{
		switch (Singleton<hardManager>.Instance.controllerType)
		{
		case 1:
			return hardInput.controllerType.PS3;
		case 2:
			return hardInput.controllerType.PS3;
		case 3:
			return (hardInput.controllerType)8;
		default:
			return hardInput.controllerType.PS3;
		}
	}

	// Token: 0x060067D7 RID: 26583 RVA: 0x001F33BC File Offset: 0x001F15BC
	public static void GLPGDEKMIGI(bool CGCEBPNHLIP)
	{
		Singleton<hardManager>.Instance.LOAPPGBKBIE(CGCEBPNHLIP);
	}

	// Token: 0x060067D8 RID: 26584 RVA: 0x001F3237 File Offset: 0x001F1437
	public static void HBJILCLJEDH(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.GJKHADOOHAG(JOKLAPMFDGO);
	}

	// Token: 0x060067D9 RID: 26585 RVA: 0x001F30BF File Offset: 0x001F12BF
	public static float JLPPEGBDNKA(string AKOENHBOCOD, string CBHEHDPFFGE, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.GetAxis(AKOENHBOCOD, CBHEHDPFFGE, IKOENAGPJCG);
	}

	// Token: 0x060067DA RID: 26586 RVA: 0x001F33C9 File Offset: 0x001F15C9
	public static float GetAxis(string AKOENHBOCOD, float IKOENAGPJCG)
	{
		return Singleton<hardManager>.Instance.GetAxis(AKOENHBOCOD, IKOENAGPJCG);
	}

	// Token: 0x060067DB RID: 26587 RVA: 0x001F3367 File Offset: 0x001F1567
	public static void HIOAICLAMNA(string AKOENHBOCOD, bool DFBNBCOFIFK, KeyCode PDBIJAAEGAP)
	{
		Singleton<hardManager>.Instance.FGNFNHNPOHJ(AKOENHBOCOD, DFBNBCOFIFK, PDBIJAAEGAP);
	}

	// Token: 0x060067DC RID: 26588 RVA: 0x001F334C File Offset: 0x001F154C
	public static void EAIKAGGFJNI(bool JOKLAPMFDGO)
	{
		Singleton<hardManager>.Instance.MouseLock(JOKLAPMFDGO);
	}

	// Token: 0x060067DD RID: 26589 RVA: 0x001F33D7 File Offset: 0x001F15D7
	public static void MouseVisible(bool CGCEBPNHLIP)
	{
		Singleton<hardManager>.Instance.MouseVisble(CGCEBPNHLIP);
	}

	// Token: 0x0200015D RID: 349
	public enum controllerType
	{
		// Token: 0x04000AA6 RID: 2726
		PS3,
		// Token: 0x04000AA7 RID: 2727
		PS4,
		// Token: 0x04000AA8 RID: 2728
		XBOX1,
		// Token: 0x04000AA9 RID: 2729
		XBOX360
	}
}
