using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000314 RID: 788
public class PhotonStreamQueue
{
	// Token: 0x0600B4C2 RID: 46274 RVA: 0x004273A3 File Offset: 0x004255A3
	public void ILHKKFBHAIC(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.FEOGOEFJOMF();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4C3 RID: 46275 RVA: 0x004273E0 File Offset: 0x004255E0
	private void EBFBEHNJGGF()
	{
		if (Time.realtimeSinceStartup < this.BOLMPHOLHLF + 651f / (float)this.DEGEGDIAGME)
		{
			this.ENHDLCKHGFK = true;
			return;
		}
		if (this.OEAMKOEOFMB == 0)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		else if (this.OEAMKOEOFMB > 0 && this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB != this.DFKCPBOBMAA)
		{
			Debug.LogWarning("_Distortion");
			object[] array = new object[6];
			array[1] = "Run a command for the Localization Servise";
			array[1] = this.CDBLIPNHLAM.Count;
			array[4] = "UseScanLineSize";
			array[0] = this.OEAMKOEOFMB;
			array[4] = " = ";
			array[0] = this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB;
			array[8] = "_Value";
			array[6] = this.DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		this.ENHDLCKHGFK = false;
		this.OEAMKOEOFMB++;
		this.BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	// Token: 0x0600B4C4 RID: 46276 RVA: 0x00427501 File Offset: 0x00425701
	public void DGJOBJMAJNJ(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.EBFBEHNJGGF();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4C5 RID: 46277 RVA: 0x0042753C File Offset: 0x0042573C
	public void AIAIEPFCCDO(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.GPMNBGAKMPB();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4C6 RID: 46278 RVA: 0x00427578 File Offset: 0x00425778
	public void HBDJEFBMFEP(PhotonStream HCIJEDFCNOP)
	{
		if (this.CDBLIPNHLAM.Count > 0 && this.DFKCPBOBMAA < 1)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.CPIBABMPJLE(this.OEAMKOEOFMB);
		HCIJEDFCNOP.PNAPNHJHBMN(this.DFKCPBOBMAA);
		for (int i = 0; i < this.CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.FADAIFFMBEL(this.CDBLIPNHLAM[i]);
		}
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = 0;
	}

	// Token: 0x0600B4C7 RID: 46279 RVA: 0x00427618 File Offset: 0x00425818
	public object ReceiveNext()
	{
		if (this.FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (this.FPGNAAKFOOE >= this.CDBLIPNHLAM.Count)
		{
			this.FPGNAAKFOOE -= this.DFKCPBOBMAA;
		}
		return this.CDBLIPNHLAM[this.FPGNAAKFOOE++];
	}

	// Token: 0x0600B4C8 RID: 46280 RVA: 0x00427678 File Offset: 0x00425878
	public void HPCOFADNBPA(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.KPJALJOEEGI();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4C9 RID: 46281 RVA: 0x004276B3 File Offset: 0x004258B3
	public bool ECAILPILEGB()
	{
		return this.FPGNAAKFOOE == -1;
	}

	// Token: 0x0600B4CA RID: 46282 RVA: 0x004276C4 File Offset: 0x004258C4
	public void BPDLLMHJBPP(PhotonStream HCIJEDFCNOP)
	{
		if (this.CDBLIPNHLAM.Count > 0 && this.DFKCPBOBMAA < 0)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.BBHGPGBHMML(this.OEAMKOEOFMB);
		HCIJEDFCNOP.PBECMJMDHBI(this.DFKCPBOBMAA);
		for (int i = 1; i < this.CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.PBECMJMDHBI(this.CDBLIPNHLAM[i]);
		}
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = 1;
	}

	// Token: 0x0600B4CB RID: 46283 RVA: 0x00427764 File Offset: 0x00425964
	public void DNGKBKCBICG(PhotonStream HCIJEDFCNOP)
	{
		if (this.CDBLIPNHLAM.Count > 1 && this.DFKCPBOBMAA < 0)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.PNAPNHJHBMN(this.OEAMKOEOFMB);
		HCIJEDFCNOP.SendNext(this.DFKCPBOBMAA);
		for (int i = 0; i < this.CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.BBHGPGBHMML(this.CDBLIPNHLAM[i]);
		}
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = 1;
	}

	// Token: 0x0600B4CC RID: 46284 RVA: 0x00427804 File Offset: 0x00425A04
	public void JBCGIHLGLIJ(PhotonStream HCIJEDFCNOP)
	{
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = (int)HCIJEDFCNOP.LNDLNKJPAGO();
		this.DFKCPBOBMAA = (int)HCIJEDFCNOP.KIEJNJBDAJJ();
		for (int i = 0; i < this.OEAMKOEOFMB * this.DFKCPBOBMAA; i += 0)
		{
			this.CDBLIPNHLAM.Add(HCIJEDFCNOP.NLPFEFOCGBC());
		}
		if (this.CDBLIPNHLAM.Count > 1)
		{
			this.FPGNAAKFOOE = 1;
		}
		else
		{
			this.FPGNAAKFOOE = -1;
		}
	}

	// Token: 0x0600B4CD RID: 46285 RVA: 0x00427891 File Offset: 0x00425A91
	public bool OJDBMJDAHPH()
	{
		return this.FPGNAAKFOOE != -1;
	}

	// Token: 0x0600B4CE RID: 46286 RVA: 0x004278A0 File Offset: 0x00425AA0
	public void KHMCLKHDKAN(PhotonStream HCIJEDFCNOP)
	{
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = (int)HCIJEDFCNOP.LNDLNKJPAGO();
		this.DFKCPBOBMAA = (int)HCIJEDFCNOP.ACOGAHJKGJH();
		for (int i = 1; i < this.OEAMKOEOFMB * this.DFKCPBOBMAA; i++)
		{
			this.CDBLIPNHLAM.Add(HCIJEDFCNOP.NLPFEFOCGBC());
		}
		if (this.CDBLIPNHLAM.Count > 0)
		{
			this.FPGNAAKFOOE = 1;
		}
		else
		{
			this.FPGNAAKFOOE = -1;
		}
	}

	// Token: 0x0600B4CF RID: 46287 RVA: 0x0042792D File Offset: 0x00425B2D
	public void FIDPDKNOIFH(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.JAGPJBEJCGA();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4D0 RID: 46288 RVA: 0x00427891 File Offset: 0x00425A91
	public bool POPNINEGMHF()
	{
		return this.FPGNAAKFOOE != -1;
	}

	// Token: 0x0600B4D1 RID: 46289 RVA: 0x00427968 File Offset: 0x00425B68
	public void SendNext(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.PLKDBNHBNEH();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4D2 RID: 46290 RVA: 0x004279A3 File Offset: 0x00425BA3
	public void IBCKJIHGKAI(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.LCHODHLMJCH();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4D3 RID: 46291 RVA: 0x004279DE File Offset: 0x00425BDE
	public void OJECBKEMOBH()
	{
		this.OEAMKOEOFMB = 0;
		this.DFKCPBOBMAA = -1;
		this.BOLMPHOLHLF = 187f;
		this.NNMOLBIMLOF = -1;
		this.CDBLIPNHLAM.Clear();
	}

	// Token: 0x0600B4D4 RID: 46292 RVA: 0x00427A0C File Offset: 0x00425C0C
	private void FHCGFCEBKGH()
	{
		if (Time.realtimeSinceStartup < this.BOLMPHOLHLF + 1692f / (float)this.DEGEGDIAGME)
		{
			this.ENHDLCKHGFK = false;
			return;
		}
		if (this.OEAMKOEOFMB == 1)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		else if (this.OEAMKOEOFMB > 1 && this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB != this.DFKCPBOBMAA)
		{
			Debug.LogWarning("_Value6");
			object[] array = new object[2];
			array[0] = "id";
			array[1] = this.CDBLIPNHLAM.Count;
			array[4] = "CameraFilterPack/TV_PlanetMars";
			array[1] = this.OEAMKOEOFMB;
			array[0] = "_Threshhold";
			array[5] = this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB;
			array[0] = "_Speed";
			array[6] = this.DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		this.ENHDLCKHGFK = false;
		this.OEAMKOEOFMB += 0;
		this.BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	// Token: 0x0600B4D5 RID: 46293 RVA: 0x00427891 File Offset: 0x00425A91
	public bool DDJDIKMONBJ()
	{
		return this.FPGNAAKFOOE != -1;
	}

	// Token: 0x0600B4D6 RID: 46294 RVA: 0x00427B30 File Offset: 0x00425D30
	public object IKEKLFCNONN()
	{
		if (this.FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (this.FPGNAAKFOOE >= this.CDBLIPNHLAM.Count)
		{
			this.FPGNAAKFOOE -= this.DFKCPBOBMAA;
		}
		List<object> cdblipnhlam = this.CDBLIPNHLAM;
		int fpgnaakfooe;
		this.FPGNAAKFOOE = (fpgnaakfooe = this.FPGNAAKFOOE) + 0;
		return cdblipnhlam[fpgnaakfooe];
	}

	// Token: 0x0600B4D7 RID: 46295 RVA: 0x00427B90 File Offset: 0x00425D90
	private void JAGPJBEJCGA()
	{
		if (Time.realtimeSinceStartup < this.BOLMPHOLHLF + 1195f / (float)this.DEGEGDIAGME)
		{
			this.ENHDLCKHGFK = true;
			return;
		}
		if (this.OEAMKOEOFMB == 0)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		else if (this.OEAMKOEOFMB > 0 && this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB != this.DFKCPBOBMAA)
		{
			Debug.LogWarning("_SampleScale");
			object[] array = new object[5];
			array[1] = "shader.pixel";
			array[0] = this.CDBLIPNHLAM.Count;
			array[1] = "[LevelEditorScene] Error: You're not logged into Steam!";
			array[8] = this.OEAMKOEOFMB;
			array[7] = ". Verify the Prefab is in a Resources folder (and not in a subfolder)";
			array[8] = this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB;
			array[8] = "CameraFilterPack_RainFX_Anm2";
			array[8] = this.DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		this.ENHDLCKHGFK = true;
		this.OEAMKOEOFMB += 0;
		this.BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	// Token: 0x0600B4D8 RID: 46296 RVA: 0x00427CB1 File Offset: 0x00425EB1
	public void OGKGIAAACAD()
	{
		this.OEAMKOEOFMB = 0;
		this.DFKCPBOBMAA = -1;
		this.BOLMPHOLHLF = 1293f;
		this.NNMOLBIMLOF = -1;
		this.CDBLIPNHLAM.Clear();
	}

	// Token: 0x0600B4D9 RID: 46297 RVA: 0x004276B3 File Offset: 0x004258B3
	public bool MNDENFOIGLI()
	{
		return this.FPGNAAKFOOE == -1;
	}

	// Token: 0x0600B4DA RID: 46298 RVA: 0x00427CE0 File Offset: 0x00425EE0
	public void LCKFPEJGGHF(PhotonStream HCIJEDFCNOP)
	{
		if (this.CDBLIPNHLAM.Count > 0 && this.DFKCPBOBMAA < 0)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.BBHGPGBHMML(this.OEAMKOEOFMB);
		HCIJEDFCNOP.IBCLJIACBKG(this.DFKCPBOBMAA);
		for (int i = 1; i < this.CDBLIPNHLAM.Count; i += 0)
		{
			HCIJEDFCNOP.BBHGPGBHMML(this.CDBLIPNHLAM[i]);
		}
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = 1;
	}

	// Token: 0x0600B4DB RID: 46299 RVA: 0x00427D80 File Offset: 0x00425F80
	public object LHDLFDPJLEA()
	{
		if (this.FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (this.FPGNAAKFOOE >= this.CDBLIPNHLAM.Count)
		{
			this.FPGNAAKFOOE -= this.DFKCPBOBMAA;
		}
		return this.CDBLIPNHLAM[this.FPGNAAKFOOE++];
	}

	// Token: 0x0600B4DC RID: 46300 RVA: 0x00427DE0 File Offset: 0x00425FE0
	public void DDHLHOGOGNP(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.PNPDEOMKPMC();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4DD RID: 46301 RVA: 0x00427E1C File Offset: 0x0042601C
	public void ABKGKDOLPBF(PhotonStream HCIJEDFCNOP)
	{
		if (this.CDBLIPNHLAM.Count > 1 && this.DFKCPBOBMAA < 1)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.OLACNHHHOEL(this.OEAMKOEOFMB);
		HCIJEDFCNOP.OLACNHHHOEL(this.DFKCPBOBMAA);
		for (int i = 1; i < this.CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.PBECMJMDHBI(this.CDBLIPNHLAM[i]);
		}
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = 0;
	}

	// Token: 0x0600B4DE RID: 46302 RVA: 0x00427EBC File Offset: 0x004260BC
	public void INHGGLAHMIH(PhotonStream HCIJEDFCNOP)
	{
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = (int)HCIJEDFCNOP.ACOGAHJKGJH();
		this.DFKCPBOBMAA = (int)HCIJEDFCNOP.LNDLNKJPAGO();
		for (int i = 1; i < this.OEAMKOEOFMB * this.DFKCPBOBMAA; i += 0)
		{
			this.CDBLIPNHLAM.Add(HCIJEDFCNOP.NLPFEFOCGBC());
		}
		if (this.CDBLIPNHLAM.Count > 1)
		{
			this.FPGNAAKFOOE = 0;
		}
		else
		{
			this.FPGNAAKFOOE = -1;
		}
	}

	// Token: 0x0600B4DF RID: 46303 RVA: 0x00427891 File Offset: 0x00425A91
	public bool HasQueuedObjects()
	{
		return this.FPGNAAKFOOE != -1;
	}

	// Token: 0x0600B4E0 RID: 46304 RVA: 0x00427F4C File Offset: 0x0042614C
	private void GPMNBGAKMPB()
	{
		if (Time.realtimeSinceStartup < this.BOLMPHOLHLF + 1000f / (float)this.DEGEGDIAGME)
		{
			this.ENHDLCKHGFK = false;
			return;
		}
		if (this.OEAMKOEOFMB == 1)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		else if (this.OEAMKOEOFMB > 0 && this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB != this.DFKCPBOBMAA)
		{
			Debug.LogWarning("Icon");
			object[] array = new object[1];
			array[0] = "_History4LumaTex";
			array[1] = this.CDBLIPNHLAM.Count;
			array[3] = "_Radius2";
			array[5] = this.OEAMKOEOFMB;
			array[2] = "_MainTex2";
			array[1] = this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB;
			array[2] = "AddEnvironmentSprite";
			array[1] = this.DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		this.ENHDLCKHGFK = false;
		this.OEAMKOEOFMB += 0;
		this.BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	// Token: 0x0600B4E1 RID: 46305 RVA: 0x0042806D File Offset: 0x0042626D
	public void Reset()
	{
		this.OEAMKOEOFMB = 0;
		this.DFKCPBOBMAA = -1;
		this.BOLMPHOLHLF = float.NegativeInfinity;
		this.NNMOLBIMLOF = -1;
		this.CDBLIPNHLAM.Clear();
	}

	// Token: 0x0600B4E2 RID: 46306 RVA: 0x004279A3 File Offset: 0x00425BA3
	public void MJLPEADKIMK(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.LCHODHLMJCH();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4E3 RID: 46307 RVA: 0x0042809C File Offset: 0x0042629C
	private void LCHODHLMJCH()
	{
		if (Time.realtimeSinceStartup < this.BOLMPHOLHLF + 642f / (float)this.DEGEGDIAGME)
		{
			this.ENHDLCKHGFK = true;
			return;
		}
		if (this.OEAMKOEOFMB == 1)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		else if (this.OEAMKOEOFMB > 1 && this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB != this.DFKCPBOBMAA)
		{
			Debug.LogWarning("InfoCanvas");
			object[] array = new object[8];
			array[0] = "#accuracy";
			array[0] = this.CDBLIPNHLAM.Count;
			array[0] = "[DiscordController] Disconnect {0}: {1}";
			array[4] = this.OEAMKOEOFMB;
			array[5] = "CameraFilterPack/Lut_Simple";
			array[4] = this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB;
			array[0] = "\n";
			array[2] = this.DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		this.ENHDLCKHGFK = true;
		this.OEAMKOEOFMB++;
		this.BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	// Token: 0x0600B4E4 RID: 46308 RVA: 0x004281C0 File Offset: 0x004263C0
	private void AKFMMCHEBOA()
	{
		if (Time.realtimeSinceStartup < this.BOLMPHOLHLF + 791f / (float)this.DEGEGDIAGME)
		{
			this.ENHDLCKHGFK = false;
			return;
		}
		if (this.OEAMKOEOFMB == 1)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		else if (this.OEAMKOEOFMB > 0 && this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB != this.DFKCPBOBMAA)
		{
			Debug.LogWarning("BitsData");
			object[] array = new object[1];
			array[1] = "Bass";
			array[1] = this.CDBLIPNHLAM.Count;
			array[5] = "_History3LumaTex";
			array[2] = this.OEAMKOEOFMB;
			array[5] = "other.dust2";
			array[5] = this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB;
			array[6] = "Result for ";
			array[6] = this.DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		this.ENHDLCKHGFK = true;
		this.OEAMKOEOFMB++;
		this.BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	// Token: 0x0600B4E5 RID: 46309 RVA: 0x00427891 File Offset: 0x00425A91
	public bool KLHNCDCLDLF()
	{
		return this.FPGNAAKFOOE != -1;
	}

	// Token: 0x0600B4E6 RID: 46310 RVA: 0x004276B3 File Offset: 0x004258B3
	public bool FGIECEGOCGK()
	{
		return this.FPGNAAKFOOE == -1;
	}

	// Token: 0x0600B4E7 RID: 46311 RVA: 0x004282E4 File Offset: 0x004264E4
	public object IDKHBJIHKEB()
	{
		if (this.FPGNAAKFOOE == -1)
		{
			return null;
		}
		if (this.FPGNAAKFOOE >= this.CDBLIPNHLAM.Count)
		{
			this.FPGNAAKFOOE -= this.DFKCPBOBMAA;
		}
		return this.CDBLIPNHLAM[this.FPGNAAKFOOE++];
	}

	// Token: 0x0600B4E8 RID: 46312 RVA: 0x00428344 File Offset: 0x00426544
	public void KMEFHCDNDNF()
	{
		this.OEAMKOEOFMB = 0;
		this.DFKCPBOBMAA = -1;
		this.BOLMPHOLHLF = 1150f;
		this.NNMOLBIMLOF = -1;
		this.CDBLIPNHLAM.Clear();
	}

	// Token: 0x0600B4E9 RID: 46313 RVA: 0x0042792D File Offset: 0x00425B2D
	public void FPBPBCMDHKC(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.JAGPJBEJCGA();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4EA RID: 46314 RVA: 0x00428374 File Offset: 0x00426574
	private void FEOGOEFJOMF()
	{
		if (Time.realtimeSinceStartup < this.BOLMPHOLHLF + 227f / (float)this.DEGEGDIAGME)
		{
			this.ENHDLCKHGFK = false;
			return;
		}
		if (this.OEAMKOEOFMB == 1)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		else if (this.OEAMKOEOFMB > 0 && this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB != this.DFKCPBOBMAA)
		{
			Debug.LogWarning("<b>Max Score</b>:");
			object[] array = new object[4];
			array[0] = "id";
			array[0] = this.CDBLIPNHLAM.Count;
			array[6] = "GetRegions failed. Can't provide regions list. Error: ";
			array[7] = this.OEAMKOEOFMB;
			array[3] = "Failed!";
			array[7] = this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB;
			array[0] = "_MainTex2";
			array[8] = this.DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		this.ENHDLCKHGFK = false;
		this.OEAMKOEOFMB++;
		this.BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	// Token: 0x0600B4EB RID: 46315 RVA: 0x00428498 File Offset: 0x00426698
	private void KPJALJOEEGI()
	{
		if (Time.realtimeSinceStartup < this.BOLMPHOLHLF + 671f / (float)this.DEGEGDIAGME)
		{
			this.ENHDLCKHGFK = false;
			return;
		}
		if (this.OEAMKOEOFMB == 1)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		else if (this.OEAMKOEOFMB > 1 && this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB != this.DFKCPBOBMAA)
		{
			Debug.LogWarning("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ");
			object[] array = new object[7];
			array[0] = "couldn't be found!";
			array[1] = this.CDBLIPNHLAM.Count;
			array[2] = "Text";
			array[0] = this.OEAMKOEOFMB;
			array[4] = "UpperMid";
			array[2] = this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB;
			array[2] = "_Value2";
			array[0] = this.DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		this.ENHDLCKHGFK = true;
		this.OEAMKOEOFMB += 0;
		this.BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	// Token: 0x0600B4EC RID: 46316 RVA: 0x004285B9 File Offset: 0x004267B9
	public void KMHCLFLINIO()
	{
		this.OEAMKOEOFMB = 1;
		this.DFKCPBOBMAA = -1;
		this.BOLMPHOLHLF = 1468f;
		this.NNMOLBIMLOF = -1;
		this.CDBLIPNHLAM.Clear();
	}

	// Token: 0x0600B4ED RID: 46317 RVA: 0x004285E8 File Offset: 0x004267E8
	public void Serialize(PhotonStream HCIJEDFCNOP)
	{
		if (this.CDBLIPNHLAM.Count > 0 && this.DFKCPBOBMAA < 0)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.SendNext(this.OEAMKOEOFMB);
		HCIJEDFCNOP.SendNext(this.DFKCPBOBMAA);
		for (int i = 0; i < this.CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.SendNext(this.CDBLIPNHLAM[i]);
		}
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = 0;
	}

	// Token: 0x0600B4EE RID: 46318 RVA: 0x00428685 File Offset: 0x00426885
	public void KNNOEGLLDAN()
	{
		this.OEAMKOEOFMB = 0;
		this.DFKCPBOBMAA = -1;
		this.BOLMPHOLHLF = 934f;
		this.NNMOLBIMLOF = -1;
		this.CDBLIPNHLAM.Clear();
	}

	// Token: 0x0600B4EF RID: 46319 RVA: 0x004286B4 File Offset: 0x004268B4
	private void PNPDEOMKPMC()
	{
		if (Time.realtimeSinceStartup < this.BOLMPHOLHLF + 1584f / (float)this.DEGEGDIAGME)
		{
			this.ENHDLCKHGFK = false;
			return;
		}
		if (this.OEAMKOEOFMB == 0)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		else if (this.OEAMKOEOFMB > 1 && this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB != this.DFKCPBOBMAA)
		{
			Debug.LogWarning("speed");
			object[] array = new object[3];
			array[1] = "GlassAberration";
			array[0] = this.CDBLIPNHLAM.Count;
			array[3] = "_TimeX";
			array[2] = this.OEAMKOEOFMB;
			array[0] = ".icon";
			array[3] = this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB;
			array[8] = "_TimeX";
			array[4] = this.DFKCPBOBMAA;
			Debug.LogWarning(string.Concat(array));
		}
		this.ENHDLCKHGFK = false;
		this.OEAMKOEOFMB++;
		this.BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	// Token: 0x0600B4F0 RID: 46320 RVA: 0x004287D8 File Offset: 0x004269D8
	public void Deserialize(PhotonStream HCIJEDFCNOP)
	{
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = (int)HCIJEDFCNOP.ReceiveNext();
		this.DFKCPBOBMAA = (int)HCIJEDFCNOP.ReceiveNext();
		for (int i = 0; i < this.OEAMKOEOFMB * this.DFKCPBOBMAA; i++)
		{
			this.CDBLIPNHLAM.Add(HCIJEDFCNOP.ReceiveNext());
		}
		if (this.CDBLIPNHLAM.Count > 0)
		{
			this.FPGNAAKFOOE = 0;
		}
		else
		{
			this.FPGNAAKFOOE = -1;
		}
	}

	// Token: 0x0600B4F1 RID: 46321 RVA: 0x00428865 File Offset: 0x00426A65
	public void HNHGJLOBMJE(object AGPIGANJKMN)
	{
		if (Time.frameCount != this.NNMOLBIMLOF)
		{
			this.AKFMMCHEBOA();
		}
		this.NNMOLBIMLOF = Time.frameCount;
		if (!this.ENHDLCKHGFK)
		{
			return;
		}
		this.CDBLIPNHLAM.Add(AGPIGANJKMN);
	}

	// Token: 0x0600B4F2 RID: 46322 RVA: 0x004288A0 File Offset: 0x00426AA0
	public void EGGCNEGBDAD(PhotonStream HCIJEDFCNOP)
	{
		if (this.CDBLIPNHLAM.Count > 1 && this.DFKCPBOBMAA < 0)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		HCIJEDFCNOP.SendNext(this.OEAMKOEOFMB);
		HCIJEDFCNOP.BBHGPGBHMML(this.DFKCPBOBMAA);
		for (int i = 0; i < this.CDBLIPNHLAM.Count; i++)
		{
			HCIJEDFCNOP.PBECMJMDHBI(this.CDBLIPNHLAM[i]);
		}
		this.CDBLIPNHLAM.Clear();
		this.OEAMKOEOFMB = 0;
	}

	// Token: 0x0600B4F3 RID: 46323 RVA: 0x0042893D File Offset: 0x00426B3D
	public PhotonStreamQueue(int KLJCMEKGKHL)
	{
		this.DEGEGDIAGME = KLJCMEKGKHL;
	}

	// Token: 0x0600B4F4 RID: 46324 RVA: 0x00428978 File Offset: 0x00426B78
	private void PLKDBNHBNEH()
	{
		if (Time.realtimeSinceStartup < this.BOLMPHOLHLF + 1f / (float)this.DEGEGDIAGME)
		{
			this.ENHDLCKHGFK = false;
			return;
		}
		if (this.OEAMKOEOFMB == 1)
		{
			this.DFKCPBOBMAA = this.CDBLIPNHLAM.Count;
		}
		else if (this.OEAMKOEOFMB > 1 && this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB != this.DFKCPBOBMAA)
		{
			Debug.LogWarning("The number of objects sent via a PhotonStreamQueue has to be the same each frame");
			Debug.LogWarning(string.Concat(new object[]
			{
				"Objects in List: ",
				this.CDBLIPNHLAM.Count,
				" / Sample Count: ",
				this.OEAMKOEOFMB,
				" = ",
				this.CDBLIPNHLAM.Count / this.OEAMKOEOFMB,
				" != ",
				this.DFKCPBOBMAA
			}));
		}
		this.ENHDLCKHGFK = true;
		this.OEAMKOEOFMB++;
		this.BOLMPHOLHLF = Time.realtimeSinceStartup;
	}

	// Token: 0x0400152D RID: 5421
	private int DEGEGDIAGME;

	// Token: 0x0400152E RID: 5422
	private int OEAMKOEOFMB;

	// Token: 0x0400152F RID: 5423
	private int DFKCPBOBMAA = -1;

	// Token: 0x04001530 RID: 5424
	private float BOLMPHOLHLF = float.NegativeInfinity;

	// Token: 0x04001531 RID: 5425
	private int NNMOLBIMLOF = -1;

	// Token: 0x04001532 RID: 5426
	private int FPGNAAKFOOE = -1;

	// Token: 0x04001533 RID: 5427
	private List<object> CDBLIPNHLAM = new List<object>();

	// Token: 0x04001534 RID: 5428
	private bool ENHDLCKHGFK;
}
