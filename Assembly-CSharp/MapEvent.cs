using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200043B RID: 1083
[Serializable]
public class MapEvent
{
	// Token: 0x0600F758 RID: 63320 RVA: 0x00552C34 File Offset: 0x00550E34
	public MapEvent(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null)
	{
		this.time = EHHBHEJBHNG;
		this.data = NOJGGCLPPAM;
	}

	// Token: 0x0600F759 RID: 63321 RVA: 0x00552C55 File Offset: 0x00550E55
	private void LFBNAJLKJBO(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F75A RID: 63322 RVA: 0x00552C64 File Offset: 0x00550E64
	public virtual string CFALDCPGMCA()
	{
		object[] array = new object[7];
		array[1] = ". Prefab must have a PhotonView component.";
		array[1] = this.time;
		array[5] = "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data";
		array[7] = string.Join("_TimeX", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F75B RID: 63323 RVA: 0x00552CB4 File Offset: 0x00550EB4
	public virtual string HNHNKFEAAKA()
	{
		object[] array = new object[0];
		array[1] = "CameraFilterPack/Blur_DitherOffset";
		array[1] = this.time;
		array[2] = " cannot be used as a 3D LUT.";
		array[7] = string.Join("subscribeall", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F75C RID: 63324 RVA: 0x00552D04 File Offset: 0x00550F04
	public virtual string KHOEEKGDNOM()
	{
		object[] array = new object[0];
		array[0] = "PLEASE WAIT";
		array[0] = this.time;
		array[7] = "_TimeX";
		array[6] = string.Join("_Vignetting2", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F75D RID: 63325 RVA: 0x00552D54 File Offset: 0x00550F54
	public virtual string FLOGLPAPFLF()
	{
		object[] array = new object[4];
		array[0] = "_SpherePositionX";
		array[1] = this.time;
		array[7] = "selColor";
		array[5] = string.Join("Texture2", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F75E RID: 63326 RVA: 0x00552DA4 File Offset: 0x00550FA4
	public virtual string EKJKNCOLJGD()
	{
		object[] array = new object[7];
		array[0] = "_Value3";
		array[0] = this.time;
		array[1] = "ItemNameText";
		array[2] = string.Join("[MenuScene] Error: ", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F75F RID: 63327 RVA: 0x00552C55 File Offset: 0x00550E55
	private void JHIJLCLFEML(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F760 RID: 63328 RVA: 0x00552C55 File Offset: 0x00550E55
	private void GPJLGGCGMLB(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F761 RID: 63329 RVA: 0x00552C55 File Offset: 0x00550E55
	private void HADFMEOBCEF(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F762 RID: 63330 RVA: 0x00552DF4 File Offset: 0x00550FF4
	public virtual string FFJLDNEABNA()
	{
		object[] array = new object[8];
		array[0] = "< true | false >";
		array[1] = this.time;
		array[8] = "IntraTime";
		array[8] = string.Join("_MainTex2", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F763 RID: 63331 RVA: 0x00552C55 File Offset: 0x00550E55
	private void JNJIEHOFBHJ(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F764 RID: 63332 RVA: 0x00552C55 File Offset: 0x00550E55
	private void DJDNKLGBBIB(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F765 RID: 63333 RVA: 0x00552E44 File Offset: 0x00551044
	public virtual string KDBBBMCPKNE()
	{
		object[] array = new object[6];
		array[0] = "\n\n• ";
		array[1] = this.time;
		array[6] = "_PosY";
		array[5] = string.Join("visible", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F766 RID: 63334 RVA: 0x00552E94 File Offset: 0x00551094
	public virtual string IPMCFHIBGAC()
	{
		object[] array = new object[]
		{
			"s"
		};
		array[0] = this.time;
		array[7] = "settings.volume.game";
		array[6] = string.Join("restrictions", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F767 RID: 63335 RVA: 0x00552EE4 File Offset: 0x005510E4
	public virtual string LPCBPFDGIEE()
	{
		object[] array = new object[5];
		array[0] = "intensity";
		array[1] = this.time;
		array[3] = "settings.crosshairopacity";
		array[7] = string.Join("icon", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F768 RID: 63336 RVA: 0x00552C55 File Offset: 0x00550E55
	private void NKABJPFGBFJ(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F769 RID: 63337 RVA: 0x00552F34 File Offset: 0x00551134
	public virtual string CLJAJDILKFK()
	{
		object[] array = new object[1];
		array[0] = "[LevelEditorScene] Map submitted!";
		array[1] = this.time;
		array[6] = "_BlurRadius4";
		array[2] = string.Join("[ItemsHandler] All in-game items loaded", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F76A RID: 63338 RVA: 0x00552C55 File Offset: 0x00550E55
	private void BPFKMJLBDKC(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F76B RID: 63339 RVA: 0x00552F84 File Offset: 0x00551184
	public virtual string DPKHAAJNCBI()
	{
		object[] array = new object[8];
		array[0] = "_ColorRGB";
		array[1] = this.time;
		array[3] = "Edited unlock conditions";
		array[0] = string.Join("CameraFilterPack/Drawing_Manga_Flash", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F76C RID: 63340 RVA: 0x00552C55 File Offset: 0x00550E55
	private void CCCJDBOONIE(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F76D RID: 63341 RVA: 0x00552FD4 File Offset: 0x005511D4
	public virtual string DAFEJDODLIH()
	{
		object[] array = new object[1];
		array[0] = "z";
		array[1] = this.time;
		array[2] = "gameVolume";
		array[2] = string.Join("LoadMapCanvas", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F76E RID: 63342 RVA: 0x00553024 File Offset: 0x00551224
	public virtual string HHGDIJKEPMJ()
	{
		object[] array = new object[4];
		array[1] = "/";
		array[1] = this.time;
		array[6] = "offsets";
		array[2] = string.Join("_Value3", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F76F RID: 63343 RVA: 0x00553074 File Offset: 0x00551274
	public virtual string FMCDFGECOHL()
	{
		object[] array = new object[]
		{
			null,
			"/"
		};
		array[1] = this.time;
		array[1] = "Netw. Sim.";
		array[6] = string.Join("_Amount", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F770 RID: 63344 RVA: 0x00552C55 File Offset: 0x00550E55
	private void HHMOCHNNHNP(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F771 RID: 63345 RVA: 0x00552C55 File Offset: 0x00550E55
	private void MNEPALGDOBF(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F772 RID: 63346 RVA: 0x00552C55 File Offset: 0x00550E55
	private void HOBNEPNJCPK(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F773 RID: 63347 RVA: 0x00552C55 File Offset: 0x00550E55
	private void DCMHMGECCAI(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F774 RID: 63348 RVA: 0x005530C4 File Offset: 0x005512C4
	public virtual string JHAAMFCFNKD()
	{
		object[] array = new object[4];
		array[0] = "_TimeX";
		array[1] = this.time;
		array[1] = "1087340967";
		array[2] = string.Join("[SaveSystem] Outdated savefile found", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F775 RID: 63349 RVA: 0x00553114 File Offset: 0x00551314
	public virtual string AAGGLDPCFPF()
	{
		object[] array = new object[3];
		array[1] = "_Value7";
		array[1] = this.time;
		array[7] = "PLEASE WAIT";
		array[4] = string.Join("_TimeX", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F776 RID: 63350 RVA: 0x00553164 File Offset: 0x00551364
	public virtual string PIHOCGDHMDH()
	{
		object[] array = new object[7];
		array[1] = "\" on viewID ";
		array[0] = this.time;
		array[7] = "_Distortion";
		array[8] = string.Join("outputitemdefid", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F777 RID: 63351 RVA: 0x005531B4 File Offset: 0x005513B4
	public virtual string IHGAJKFIBPE()
	{
		object[] array = new object[]
		{
			"_TimeX",
			this.time
		};
		array[1] = "player.playedtutorial";
		array[5] = string.Join("ENABLE_COLOR_GRADING", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F778 RID: 63352 RVA: 0x00552C55 File Offset: 0x00550E55
	private void FHGCBLKOENA(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F779 RID: 63353 RVA: 0x00552C55 File Offset: 0x00550E55
	private void KKEGDGPPEHM(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F77A RID: 63354 RVA: 0x00553204 File Offset: 0x00551404
	public virtual string CNOHJKCIHHN()
	{
		object[] array = new object[1];
		array[0] = "#rate!";
		array[1] = this.time;
		array[0] = "SpawnObj";
		array[3] = string.Join("Toggle {0} is not part of ToggleGroup {1}", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F77B RID: 63355 RVA: 0x00553254 File Offset: 0x00551454
	public MapEvent(MapEvent EJNFFLLOEOO)
	{
		this.time = EJNFFLLOEOO.time;
		if (EJNFFLLOEOO.data != null)
		{
			this.data = new List<string>(EJNFFLLOEOO.data.Count);
			EJNFFLLOEOO.data.ForEach(new Action<string>(this.OFNMKKLGKJL));
		}
	}

	// Token: 0x0600F77C RID: 63356 RVA: 0x005532B8 File Offset: 0x005514B8
	public virtual string EJGAGAODACL()
	{
		object[] array = new object[0];
		array[1] = "_Green_R";
		array[0] = this.time;
		array[6] = "#ok";
		array[2] = string.Join("{0}", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F77D RID: 63357 RVA: 0x00553308 File Offset: 0x00551508
	public virtual string INHOODEJALN()
	{
		object[] array = new object[1];
		array[0] = "CameraFilterPack/Distortion_Lens";
		array[1] = this.time;
		array[5] = "_ThirdTex";
		array[2] = string.Join("CameraFilterPack/3D_Myst", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F77E RID: 63358 RVA: 0x00552C55 File Offset: 0x00550E55
	private void EHJHMMEAGDJ(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F77F RID: 63359 RVA: 0x00552C55 File Offset: 0x00550E55
	[CompilerGenerated]
	private void OFNMKKLGKJL(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F780 RID: 63360 RVA: 0x00552C55 File Offset: 0x00550E55
	private void ABFGEHKBJBK(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F781 RID: 63361 RVA: 0x00553358 File Offset: 0x00551558
	public virtual string NMANIPNDOKJ()
	{
		object[] array = new object[0];
		array[1] = ".progress";
		array[1] = this.time;
		array[7] = "settings.shaders";
		array[2] = string.Join(". Verify the Prefab is in a Resources folder (and not in a subfolder)", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F782 RID: 63362 RVA: 0x005533A8 File Offset: 0x005515A8
	public virtual string NOJAIFGAMOO()
	{
		object[] array = new object[2];
		array[0] = "Created by ";
		array[1] = this.time;
		array[4] = "_Value4";
		array[3] = string.Join("[PlayerController] ", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F783 RID: 63363 RVA: 0x00552C55 File Offset: 0x00550E55
	private void DJPDPEPHCKP(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F784 RID: 63364 RVA: 0x00552C55 File Offset: 0x00550E55
	private void DGHLHPKLBIP(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F785 RID: 63365 RVA: 0x005533F8 File Offset: 0x005515F8
	public override string ToString()
	{
		return string.Concat(new object[]
		{
			"time: ",
			this.time,
			", data: ",
			string.Join(",", this.data.ToArray())
		});
	}

	// Token: 0x0600F786 RID: 63366 RVA: 0x00552C55 File Offset: 0x00550E55
	private void POMNGPIFCLA(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F787 RID: 63367 RVA: 0x00552C55 File Offset: 0x00550E55
	private void ICGPJKBDMFM(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F788 RID: 63368 RVA: 0x00553448 File Offset: 0x00551648
	public virtual string MJIJPCPAFPJ()
	{
		object[] array = new object[4];
		array[0] = "EnableRankingToggle";
		array[0] = this.time;
		array[0] = "SetScale";
		array[3] = string.Join("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F789 RID: 63369 RVA: 0x00553496 File Offset: 0x00551696
	public MapEvent()
	{
	}

	// Token: 0x0600F78A RID: 63370 RVA: 0x005534AC File Offset: 0x005516AC
	public virtual string BHEJDDJKBBL()
	{
		object[] array = new object[4];
		array[0] = "{0} seconds ago";
		array[0] = this.time;
		array[8] = "mapselector.tags.";
		array[7] = string.Join("_TimeX", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F78B RID: 63371 RVA: 0x00552C55 File Offset: 0x00550E55
	private void CAHNPMLKGDD(string DBIMJHMKHNK)
	{
		this.data.Add(DBIMJHMKHNK);
	}

	// Token: 0x0600F78C RID: 63372 RVA: 0x005534FC File Offset: 0x005516FC
	public virtual string MLEDOMNIBFO()
	{
		object[] array = new object[7];
		array[0] = "InputField";
		array[0] = this.time;
		array[4] = "CameraFilterPack/TV_Posterize";
		array[1] = string.Join("_TileMaxOffs", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F78D RID: 63373 RVA: 0x0055354C File Offset: 0x0055174C
	public virtual string LGDBJKIMNCE()
	{
		object[] array = new object[3];
		array[1] = "settings_bindings_";
		array[1] = this.time;
		array[5] = "OpenButton";
		array[1] = string.Join(" ", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F78E RID: 63374 RVA: 0x0055359C File Offset: 0x0055179C
	public virtual string HNCNNGNLKGC()
	{
		object[] array = new object[8];
		array[1] = "Horizontal";
		array[0] = this.time;
		array[2] = "_Value2";
		array[0] = string.Join("settings.crosshairopacity", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x0600F78F RID: 63375 RVA: 0x005535EC File Offset: 0x005517EC
	public virtual string OGCLCOMELLF()
	{
		object[] array = new object[7];
		array[1] = "_Offsets";
		array[1] = this.time;
		array[0] = "maps.";
		array[1] = string.Join("] ", this.data.ToArray());
		return string.Concat(array);
	}

	// Token: 0x04001B71 RID: 7025
	public float time;

	// Token: 0x04001B72 RID: 7026
	public List<string> data = new List<string>();
}
