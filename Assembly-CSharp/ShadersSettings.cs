using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000465 RID: 1125
public class ShadersSettings : MonoBehaviour
{
	// Token: 0x0601014E RID: 65870 RVA: 0x005853DE File Offset: 0x005835DE
	public void JDMJBEFJFFI()
	{
		if (this.LKEHPMEBFLI())
		{
			Singleton<SaveSystem>.Instance.SetInt("_Bullet_9", 0, null);
			this.KOFBBFHEPDL(false);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x0601014F RID: 65871 RVA: 0x00585409 File Offset: 0x00583609
	public void FHIMJOBNOEK(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.JIBBFJCCOAG();
		}
		else
		{
			this.EnableShaders();
		}
	}

	// Token: 0x06010150 RID: 65872 RVA: 0x00585422 File Offset: 0x00583622
	public void GKEOHHCNOHJ()
	{
		if (!this.JPDCNEKAGPE())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_ToneCurve", 0, null);
			this.AFIGHIGANDO(true);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x06010151 RID: 65873 RVA: 0x0058544D File Offset: 0x0058364D
	private void MGMAOBPPOBJ()
	{
		this.BFPCNLFIKHJ(false);
	}

	// Token: 0x06010152 RID: 65874 RVA: 0x00585456 File Offset: 0x00583656
	private void Start()
	{
		this.InitShaders(false);
	}

	// Token: 0x06010153 RID: 65875 RVA: 0x0058545F File Offset: 0x0058365F
	public void FJGPLDPOENI(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.ODCLLIJEEKK();
		}
		else
		{
			this.LLCPDHAHNBB();
		}
	}

	// Token: 0x06010154 RID: 65876 RVA: 0x00585478 File Offset: 0x00583678
	public void JIBBFJCCOAG()
	{
		if (this.IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("FinalScoreText", 0, null);
			this.FFBECDHOODB(false);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x06010155 RID: 65877 RVA: 0x005854A3 File Offset: 0x005836A3
	public void CPMMPBIOAFI()
	{
		if (this.JPDCNEKAGPE())
		{
			this.OOEMBMAOMLG();
		}
		else
		{
			this.NOJLADHDCMN();
		}
	}

	// Token: 0x06010156 RID: 65878 RVA: 0x005854C1 File Offset: 0x005836C1
	public void NDILKMLKABI(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("0,1,false", DPNHODJHGJL, null);
		this.MMKIOONIIKI(false);
	}

	// Token: 0x06010157 RID: 65879 RVA: 0x005854DC File Offset: 0x005836DC
	public bool IMFKJCKJGEK()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.HasKey("FToA", null))
		{
			result = (Singleton<SaveSystem>.Instance.JLPLKBDBIJC("maps.", null) != 1 || true);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("settings.volume.editor", 1, null);
		}
		return result;
	}

	// Token: 0x06010158 RID: 65880 RVA: 0x00585535 File Offset: 0x00583735
	private void IHLMNAGPKDA()
	{
		this.HHGHDFHAOLG(true);
	}

	// Token: 0x06010159 RID: 65881 RVA: 0x0058553E File Offset: 0x0058373E
	public void JNEIFHIJMJH(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.JIBBFJCCOAG();
		}
		else
		{
			this.BPDHNOABAEF();
		}
	}

	// Token: 0x0601015A RID: 65882 RVA: 0x00585557 File Offset: 0x00583757
	public void SetBloomIntencity(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.shaders.bloomintencity", DPNHODJHGJL, null);
		this.InitShaders(false);
	}

	// Token: 0x0601015B RID: 65883 RVA: 0x00585571 File Offset: 0x00583771
	private void DLBODOFAJGM()
	{
		this.FFBECDHOODB(true);
	}

	// Token: 0x0601015C RID: 65884 RVA: 0x0058557A File Offset: 0x0058377A
	private void PMPKMGKAAJH()
	{
		this.KOFBBFHEPDL(false);
	}

	// Token: 0x0601015D RID: 65885 RVA: 0x00585583 File Offset: 0x00583783
	public void OKJDFNAJHKF()
	{
		if (!this.IBFEBKLBJOL())
		{
			Singleton<SaveSystem>.Instance.SetInt("_Intensity", 0, null);
			this.KOFBBFHEPDL(true);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x0601015E RID: 65886 RVA: 0x005855AE File Offset: 0x005837AE
	public void JJKGKBINCFA()
	{
		if (!this.IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.SetInt("_FgOverlap", 0, null);
			this.GPPCOECMHCO(true);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x0601015F RID: 65887 RVA: 0x005855D9 File Offset: 0x005837D9
	public void MEOOODAGIFA()
	{
		if (this.LKEHPMEBFLI())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("CameraFilterPack/TV_ARCADE_Fast", 1, null);
			this.CIPHKEJMMNC(false);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x06010160 RID: 65888 RVA: 0x00585604 File Offset: 0x00583804
	public void IAKMAMPPIOL(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.AACDGOIDPIP();
		}
		else
		{
			this.OKJDFNAJHKF();
		}
	}

	// Token: 0x06010161 RID: 65889 RVA: 0x0058561D File Offset: 0x0058381D
	public void ABIECDCDFEL(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("OpJoinRoom()", DPNHODJHGJL, null);
		this.InitShaders(true);
	}

	// Token: 0x06010162 RID: 65890 RVA: 0x00585637 File Offset: 0x00583837
	public void HLCBHFBPINN()
	{
		if (this.LKEHPMEBFLI())
		{
			this.JCGPEFPIGCG();
		}
		else
		{
			this.HFKGKNCGDNE();
		}
	}

	// Token: 0x06010163 RID: 65891 RVA: 0x00585655 File Offset: 0x00583855
	public void GAEJKGGIPBA()
	{
		if (!this.NPJEECOOCCL())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("_ColorB", 0, null);
			this.BFPCNLFIKHJ(true);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x06010164 RID: 65892 RVA: 0x00585680 File Offset: 0x00583880
	public void AHCOJEKGEMK(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("_ScreenResolution", DPNHODJHGJL, null);
		this.CMNFKFBMFPM(false);
	}

	// Token: 0x06010165 RID: 65893 RVA: 0x0058569C File Offset: 0x0058389C
	public void GPPCOECMHCO(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_ScreenResolution");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!this.JPDCNEKAGPE()) ? 0 : 3);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("history", 1098f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.IBFEBKLBJOL()) ? 0 : 0);
		}
	}

	// Token: 0x06010166 RID: 65894 RVA: 0x00585730 File Offset: 0x00583930
	public void JOBLANDDCCL()
	{
		if (this.IMFKJCKJGEK())
		{
			this.JDMJBEFJFFI();
		}
		else
		{
			this.OGDAKOCBFBG();
		}
	}

	// Token: 0x06010167 RID: 65895 RVA: 0x0058574E File Offset: 0x0058394E
	public void APBAPLKBMEP()
	{
		if (!this.IBFEBKLBJOL())
		{
			Singleton<SaveSystem>.Instance.SetInt("CameraFilterPack/TV_Posterize", 1, null);
			this.HHGHDFHAOLG(false);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x06010168 RID: 65896 RVA: 0x00585779 File Offset: 0x00583979
	public void NOJLADHDCMN()
	{
		if (!this.IBFEBKLBJOL())
		{
			Singleton<SaveSystem>.Instance.SetInt("CameraFilterPack/TV_Video3D", 1, null);
			this.HHGHDFHAOLG(false);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x06010169 RID: 65897 RVA: 0x005857A4 File Offset: 0x005839A4
	private void CCLNNLCOPBL()
	{
		this.GPPCOECMHCO(true);
	}

	// Token: 0x0601016A RID: 65898 RVA: 0x005857B0 File Offset: 0x005839B0
	public void CIPHKEJMMNC(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("{0,-18} {1,18}");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!this.JPDCNEKAGPE()) ? 1 : 4);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.NPNOOLFEDKN(" - PUBLISHED #", 65f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.LKEHPMEBFLI()) ? 1 : 1);
		}
	}

	// Token: 0x0601016B RID: 65899 RVA: 0x00585844 File Offset: 0x00583A44
	private void JMEOGJHCONJ()
	{
		this.GPPCOECMHCO(false);
	}

	// Token: 0x0601016C RID: 65900 RVA: 0x00585850 File Offset: 0x00583A50
	public void MMKIOONIIKI(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_MainTex2");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!this.IMFKJCKJGEK()) ? 0 : 3);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("local CheckCondition = function()", 1403f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.IMFKJCKJGEK()) ? 0 : 1);
		}
	}

	// Token: 0x0601016D RID: 65901 RVA: 0x005858E4 File Offset: 0x00583AE4
	public void KOFBBFHEPDL(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("[PlayerBase] Delete checkpoint data");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!this.IBFEBKLBJOL()) ? 0 : 1);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("<b>", 1934f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.IMFKJCKJGEK()) ? 1 : 1);
		}
	}

	// Token: 0x0601016E RID: 65902 RVA: 0x00585978 File Offset: 0x00583B78
	public void JGPHIGBDAIB()
	{
		if (!this.IMFKJCKJGEK())
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA("_Value2", 1, null);
			this.InitShaders(true);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x0601016F RID: 65903 RVA: 0x005859A3 File Offset: 0x00583BA3
	public void AMEGAHMINJJ(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("other.dust1", DPNHODJHGJL, null);
		this.InitShaders(true);
	}

	// Token: 0x06010170 RID: 65904 RVA: 0x005859C0 File Offset: 0x00583BC0
	public void InitShaders(bool PJDIHKOBGBA = false)
	{
		foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Player"))
		{
			QualitySettings.antiAliasing = ((!this.IsShadersEnabled()) ? 0 : 8);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.GetFloat("settings.shaders.bloomintencity", 0.05f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.IsShadersEnabled()) ? 0 : 1);
		}
	}

	// Token: 0x06010171 RID: 65905 RVA: 0x00585844 File Offset: 0x00583A44
	private void KLILJHJNICK()
	{
		this.GPPCOECMHCO(false);
	}

	// Token: 0x06010172 RID: 65906 RVA: 0x00585A54 File Offset: 0x00583C54
	public void NGNHIDADMBK()
	{
		if (this.JPDCNEKAGPE())
		{
			this.AACDGOIDPIP();
		}
		else
		{
			this.HBIGHCFKHLA();
		}
	}

	// Token: 0x06010173 RID: 65907 RVA: 0x00585A72 File Offset: 0x00583C72
	public void BPDHNOABAEF()
	{
		if (!this.IMFKJCKJGEK())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("_Threshhold", 0, null);
			this.FFBECDHOODB(true);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x06010174 RID: 65908 RVA: 0x00585A9D File Offset: 0x00583C9D
	public void IPKPGHIHMKA()
	{
		if (this.NPJEECOOCCL())
		{
			this.JDMJBEFJFFI();
		}
		else
		{
			this.HBIGHCFKHLA();
		}
	}

	// Token: 0x06010175 RID: 65909 RVA: 0x00585ABB File Offset: 0x00583CBB
	public void GOEMELDAIBB(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.AACDGOIDPIP();
		}
		else
		{
			this.GAEJKGGIPBA();
		}
	}

	// Token: 0x06010176 RID: 65910 RVA: 0x00585AD4 File Offset: 0x00583CD4
	public void SetShadersEnabled(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.DisableShaders();
		}
		else
		{
			this.EnableShaders();
		}
	}

	// Token: 0x06010177 RID: 65911 RVA: 0x00585AED File Offset: 0x00583CED
	private void NPLCENPNJBM()
	{
		this.AFIGHIGANDO(true);
	}

	// Token: 0x06010178 RID: 65912 RVA: 0x00585AF6 File Offset: 0x00583CF6
	public void OHJBECDKMGN(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.OOEMBMAOMLG();
		}
		else
		{
			this.HFKGKNCGDNE();
		}
	}

	// Token: 0x06010179 RID: 65913 RVA: 0x00585B0F File Offset: 0x00583D0F
	public void PHMAOCKKFBE()
	{
		if (this.LKEHPMEBFLI())
		{
			this.JIBBFJCCOAG();
		}
		else
		{
			this.OGDAKOCBFBG();
		}
	}

	// Token: 0x0601017A RID: 65914 RVA: 0x00585B30 File Offset: 0x00583D30
	public bool NPJEECOOCCL()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("<b>#", null))
		{
			result = (Singleton<SaveSystem>.Instance.DNBCCNHDJDK("Tab2Content", null) == 1 && false);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("CameraFilterPack_WaterDrop", 1, null);
		}
		return result;
	}

	// Token: 0x0601017B RID: 65915 RVA: 0x00585B8C File Offset: 0x00583D8C
	public void BFPCNLFIKHJ(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_NoiseTex");
		for (int i = 1; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!this.JPDCNEKAGPE()) ? 1 : 5);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", 348f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.IsShadersEnabled()) ? 1 : 0);
		}
	}

	// Token: 0x0601017C RID: 65916 RVA: 0x00585C20 File Offset: 0x00583E20
	public void EnableShaders()
	{
		if (!this.IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.shaders", 1, null);
			this.InitShaders(true);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x0601017D RID: 65917 RVA: 0x00585C4C File Offset: 0x00583E4C
	public void MDFKIELMPMG(bool PJDIHKOBGBA = false)
	{
		foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("#done"))
		{
			QualitySettings.antiAliasing = ((!this.LKEHPMEBFLI()) ? 1 : 4);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("_TimeX", 418f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.IBFEBKLBJOL()) ? 0 : 0);
		}
	}

	// Token: 0x0601017E RID: 65918 RVA: 0x00585CE0 File Offset: 0x00583EE0
	public void ELMKGILDNEF()
	{
		if (!this.IBFEBKLBJOL())
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA("http://steamcommunity.com/sharedfiles/filedetails/?id=", 1, null);
			this.KOFBBFHEPDL(true);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x0601017F RID: 65919 RVA: 0x0058544D File Offset: 0x0058364D
	private void FMFNILJIEIA()
	{
		this.BFPCNLFIKHJ(false);
	}

	// Token: 0x06010180 RID: 65920 RVA: 0x00585D0C File Offset: 0x00583F0C
	public void HHGHDFHAOLG(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Message duration multiplier. Recomended 1");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!this.NPJEECOOCCL()) ? 0 : 5);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", 1901f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.IsShadersEnabled()) ? 0 : 1);
		}
	}

	// Token: 0x06010181 RID: 65921 RVA: 0x00585DA0 File Offset: 0x00583FA0
	public void ToggleShaders()
	{
		if (this.IsShadersEnabled())
		{
			this.DisableShaders();
		}
		else
		{
			this.EnableShaders();
		}
	}

	// Token: 0x06010182 RID: 65922 RVA: 0x00585DBE File Offset: 0x00583FBE
	private void DKOPKPBLDHH()
	{
		this.MMKIOONIIKI(true);
	}

	// Token: 0x06010183 RID: 65923 RVA: 0x00585DC8 File Offset: 0x00583FC8
	public bool IsShadersEnabled()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.HasKey("settings.shaders", null))
		{
			result = (Singleton<SaveSystem>.Instance.GetInt("settings.shaders", null) == 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.shaders", 1, null);
		}
		return result;
	}

	// Token: 0x06010184 RID: 65924 RVA: 0x00585E21 File Offset: 0x00584021
	public void FAFOBFMEHJM()
	{
		if (!this.IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("(", 0, null);
			this.HHGHDFHAOLG(true);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x06010185 RID: 65925 RVA: 0x00585E4C File Offset: 0x0058404C
	public void CIPIONFIKBP(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.DisableShaders();
		}
		else
		{
			this.JGPHIGBDAIB();
		}
	}

	// Token: 0x06010186 RID: 65926 RVA: 0x00585E65 File Offset: 0x00584065
	private void MMMDPANNAIO()
	{
		this.AFIGHIGANDO(false);
	}

	// Token: 0x06010187 RID: 65927 RVA: 0x00585E6E File Offset: 0x0058406E
	public void PIMLCIOKBDI()
	{
		if (this.LKEHPMEBFLI())
		{
			this.MEOOODAGIFA();
		}
		else
		{
			this.HBIGHCFKHLA();
		}
	}

	// Token: 0x06010188 RID: 65928 RVA: 0x00585E8C File Offset: 0x0058408C
	public void AACDGOIDPIP()
	{
		if (this.IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("mapselector.filter.subscribedonly", 0, null);
			this.FFBECDHOODB(false);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x06010189 RID: 65929 RVA: 0x00585EB7 File Offset: 0x005840B7
	public void OEJCBBNCJNL()
	{
		if (this.IMFKJCKJGEK())
		{
			this.JIBBFJCCOAG();
		}
		else
		{
			this.BPDHNOABAEF();
		}
	}

	// Token: 0x0601018A RID: 65930 RVA: 0x00585ED5 File Offset: 0x005840D5
	public void IJJKKEPOMLG(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.AACDGOIDPIP();
		}
		else
		{
			this.LLCPDHAHNBB();
		}
	}

	// Token: 0x0601018C RID: 65932 RVA: 0x00585EEE File Offset: 0x005840EE
	public void ODCLLIJEEKK()
	{
		if (this.LKEHPMEBFLI())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("[Down]", 0, null);
			this.HHGHDFHAOLG(false);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x0601018D RID: 65933 RVA: 0x00585F19 File Offset: 0x00584119
	public void HBIGHCFKHLA()
	{
		if (!this.IMFKJCKJGEK())
		{
			Singleton<SaveSystem>.Instance.SetInt("Tab2Content", 0, null);
			this.MMKIOONIIKI(false);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x0601018E RID: 65934 RVA: 0x00585F44 File Offset: 0x00584144
	public void KGNBFNMKJJK()
	{
		if (this.LKEHPMEBFLI())
		{
			this.AACDGOIDPIP();
		}
		else
		{
			this.JJKGKBINCFA();
		}
	}

	// Token: 0x0601018F RID: 65935 RVA: 0x00585F62 File Offset: 0x00584162
	public void LLCPDHAHNBB()
	{
		if (!this.IBFEBKLBJOL())
		{
			Singleton<SaveSystem>.Instance.SetInt("_ScreenResolution", 1, null);
			this.AKNILDKHOMM(false);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x06010190 RID: 65936 RVA: 0x00585F8D File Offset: 0x0058418D
	public void JCGPEFPIGCG()
	{
		if (this.JPDCNEKAGPE())
		{
			Singleton<SaveSystem>.Instance.SetInt("_Bloom4", 1, null);
			this.GCKBDIHCBEJ(false);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x06010191 RID: 65937 RVA: 0x00585FB8 File Offset: 0x005841B8
	private void HDMDKOKOOJC()
	{
		this.BFPCNLFIKHJ(true);
	}

	// Token: 0x06010192 RID: 65938 RVA: 0x00585FC1 File Offset: 0x005841C1
	public void EGIIEPKIHNJ(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("ItemsCountText", DPNHODJHGJL, null);
		this.GCKBDIHCBEJ(false);
	}

	// Token: 0x06010193 RID: 65939 RVA: 0x00585FDB File Offset: 0x005841DB
	private void CIPKEPDELJB()
	{
		this.InitShaders(true);
	}

	// Token: 0x06010194 RID: 65940 RVA: 0x00585FE4 File Offset: 0x005841E4
	public void OOEMBMAOMLG()
	{
		if (this.LKEHPMEBFLI())
		{
			Singleton<SaveSystem>.Instance.SetInt("OK", 0, null);
			this.AKNILDKHOMM(false);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x06010195 RID: 65941 RVA: 0x0058600F File Offset: 0x0058420F
	public void ILLCENCPNFH(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("Set sun lerp speed", DPNHODJHGJL, null);
		this.InitShaders(false);
	}

	// Token: 0x06010196 RID: 65942 RVA: 0x00586029 File Offset: 0x00584229
	public void GKMGCKKIJNL(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("settings.hitvariation", DPNHODJHGJL, null);
		this.CIPHKEJMMNC(false);
	}

	// Token: 0x06010197 RID: 65943 RVA: 0x00586043 File Offset: 0x00584243
	public void DisableShaders()
	{
		if (this.IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.shaders", 0, null);
			this.InitShaders(false);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x06010198 RID: 65944 RVA: 0x00586070 File Offset: 0x00584270
	public void CMNFKFBMFPM(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Zoom speed. Base 1.5");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!this.JPDCNEKAGPE()) ? 0 : 2);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("mapselector.filter.favoriteonly", 526f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.NPJEECOOCCL()) ? 0 : 0);
		}
	}

	// Token: 0x06010199 RID: 65945 RVA: 0x00586104 File Offset: 0x00584304
	public void OGDAKOCBFBG()
	{
		if (!this.NPJEECOOCCL())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("sounds/hit_perfect", 1, null);
			this.MDFKIELMPMG(true);
			SceneManager.LoadScene(1);
		}
	}

	// Token: 0x0601019A RID: 65946 RVA: 0x00586130 File Offset: 0x00584330
	public void AKNILDKHOMM(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Exposure");
		for (int i = 1; i < array.Length; i++)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!this.IMFKJCKJGEK()) ? 0 : 1);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("No regions available. Are you sure your appid is valid and setup?", 774f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.JPDCNEKAGPE()) ? 0 : 1);
		}
	}

	// Token: 0x0601019B RID: 65947 RVA: 0x005861C4 File Offset: 0x005843C4
	public void FBMIALGODFI()
	{
		if (!this.JPDCNEKAGPE())
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("RecieveChatActionMessage", 1, null);
			this.AKNILDKHOMM(true);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x0601019C RID: 65948 RVA: 0x005861F0 File Offset: 0x005843F0
	public void FFBECDHOODB(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_TimeX");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!this.NPJEECOOCCL()) ? 0 : 6);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_FixDistance", 737f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.LKEHPMEBFLI()) ? 0 : 1);
		}
	}

	// Token: 0x0601019D RID: 65949 RVA: 0x00586284 File Offset: 0x00584484
	public void HFKGKNCGDNE()
	{
		if (!this.IsShadersEnabled())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_ScreenResolution", 0, null);
			this.MMKIOONIIKI(false);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x0601019E RID: 65950 RVA: 0x005862B0 File Offset: 0x005844B0
	public bool JPDCNEKAGPE()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.HasKey("Fade", null))
		{
			result = (Singleton<SaveSystem>.Instance.JLPLKBDBIJC("NetworkScene", null) == 1 && false);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("FinalScoreText", 1, null);
		}
		return result;
	}

	// Token: 0x0601019F RID: 65951 RVA: 0x0058630C File Offset: 0x0058450C
	public bool IBFEBKLBJOL()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("Set Background Color", null))
		{
			result = (Singleton<SaveSystem>.Instance.DNBCCNHDJDK("Joystick1Button12", null) == 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("float", 1, null);
		}
		return result;
	}

	// Token: 0x060101A0 RID: 65952 RVA: 0x00586365 File Offset: 0x00584565
	public void GPKFLFILBNN()
	{
		if (this.NPJEECOOCCL())
		{
			this.OOEMBMAOMLG();
		}
		else
		{
			this.HBIGHCFKHLA();
		}
	}

	// Token: 0x060101A1 RID: 65953 RVA: 0x00586383 File Offset: 0x00584583
	public void LGFOFBAGGFD()
	{
		if (this.LKEHPMEBFLI())
		{
			this.JIBBFJCCOAG();
		}
		else
		{
			this.OKJDFNAJHKF();
		}
	}

	// Token: 0x060101A2 RID: 65954 RVA: 0x005863A1 File Offset: 0x005845A1
	public void FOCJGHNFOLH(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("_ScreenResolution", DPNHODJHGJL, null);
		this.InitShaders(true);
	}

	// Token: 0x060101A3 RID: 65955 RVA: 0x005863BB File Offset: 0x005845BB
	private void JILOMOBDPIA()
	{
		this.KOFBBFHEPDL(true);
	}

	// Token: 0x060101A4 RID: 65956 RVA: 0x005863C4 File Offset: 0x005845C4
	public void GAHNGGPDDKO(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.ODCLLIJEEKK();
		}
		else
		{
			this.NOJLADHDCMN();
		}
	}

	// Token: 0x060101A5 RID: 65957 RVA: 0x005863DD File Offset: 0x005845DD
	public void NLODLNAGEBP(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("GhostFade", DPNHODJHGJL, null);
		this.KOFBBFHEPDL(false);
	}

	// Token: 0x060101A6 RID: 65958 RVA: 0x00585FB8 File Offset: 0x005841B8
	private void IMCKJCHKMKB()
	{
		this.BFPCNLFIKHJ(true);
	}

	// Token: 0x060101A7 RID: 65959 RVA: 0x005863F7 File Offset: 0x005845F7
	public void OEDLDFJMEEF()
	{
		if (this.NPJEECOOCCL())
		{
			this.OOEMBMAOMLG();
		}
		else
		{
			this.JJKGKBINCFA();
		}
	}

	// Token: 0x060101A8 RID: 65960 RVA: 0x00586415 File Offset: 0x00584615
	public void OHKEOCAILIA()
	{
		if (!this.IMFKJCKJGEK())
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("MaxLivesSlider", 0, null);
			this.HHGHDFHAOLG(false);
			SceneManager.LoadScene(0);
		}
	}

	// Token: 0x060101A9 RID: 65961 RVA: 0x00586440 File Offset: 0x00584640
	public void GCKBDIHCBEJ(bool PJDIHKOBGBA = false)
	{
		foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("_Distortion"))
		{
			QualitySettings.antiAliasing = ((!this.IsShadersEnabled()) ? 0 : 2);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("_DotSize", 456f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.NPJEECOOCCL()) ? 0 : 0);
		}
	}

	// Token: 0x060101AA RID: 65962 RVA: 0x005864D4 File Offset: 0x005846D4
	private void ANCKKLFPGDI()
	{
		this.CIPHKEJMMNC(true);
	}

	// Token: 0x060101AB RID: 65963 RVA: 0x005864E0 File Offset: 0x005846E0
	public bool LKEHPMEBFLI()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("#failed!", null))
		{
			result = (Singleton<SaveSystem>.Instance.PPBFNLHCKCP("action", null) != 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("< true | false >", 0, null);
		}
		return result;
	}

	// Token: 0x060101AC RID: 65964 RVA: 0x0058653C File Offset: 0x0058473C
	public void AFIGHIGANDO(bool PJDIHKOBGBA = false)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("ChangeSelectedLevel");
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject gameObject = array[i];
			QualitySettings.antiAliasing = ((!this.IBFEBKLBJOL()) ? 0 : 5);
			if (gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>())
			{
				gameObject.GetComponentInChildren<SENaturalBloomAndDirtyLens>().bloomIntensity = Singleton<SaveSystem>.Instance.GetFloat("Search: ", 1701f, null);
			}
		}
		if (PJDIHKOBGBA)
		{
			QualitySettings.SetQualityLevel((!this.IMFKJCKJGEK()) ? 0 : 1);
		}
	}

	// Token: 0x060101AD RID: 65965 RVA: 0x005865D0 File Offset: 0x005847D0
	public void NPBGBPBBOGB(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("The given 2D texture ", DPNHODJHGJL, null);
		this.HHGHDFHAOLG(false);
	}
}
