using System;
using UnityEngine;

// Token: 0x02000342 RID: 834
public class InputToEvent : MonoBehaviour
{
	// Token: 0x0600BC6B RID: 48235 RVA: 0x0044995E File Offset: 0x00447B5E
	private void AANKFBFFODO(Vector2 OPDCNOOGBIF)
	{
		this.GGKIGGBGLOA = OPDCNOOGBIF;
		this.Dragging = true;
		this.AAEFEIGCJGG = this.DEEMBJNPOIJ(OPDCNOOGBIF);
		if (this.AAEFEIGCJGG != null)
		{
			this.AAEFEIGCJGG.SendMessage("}", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x0600BC6C RID: 48236 RVA: 0x004499A0 File Offset: 0x00447BA0
	private void Update()
	{
		if (this.DetectPointedAtGameObject)
		{
			InputToEvent.goPointedAt = this.AFGBEEIODHH(Input.mousePosition);
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			this.GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				this.IMLHKBFBBGK(touch.position);
			}
			else if (touch.phase == TouchPhase.Ended)
			{
				this.MFMMDDJFMGI(touch.position);
			}
			return;
		}
		this.GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			this.IMLHKBFBBGK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			this.MFMMDDJFMGI(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			this.GGKIGGBGLOA = Input.mousePosition;
			this.AAEFEIGCJGG = this.AFGBEEIODHH(this.GGKIGGBGLOA);
			if (this.AAEFEIGCJGG != null)
			{
				this.AAEFEIGCJGG.SendMessage("OnPressRight", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	// Token: 0x0600BC6D RID: 48237 RVA: 0x00449ABC File Offset: 0x00447CBC
	private GameObject GFGALLDGNHP(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 1425f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC6E RID: 48238 RVA: 0x00449B05 File Offset: 0x00447D05
	private void JILOMOBDPIA()
	{
		this.CMMMNLFGCJB = base.GetComponent<Camera>();
	}

	// Token: 0x0600BC6F RID: 48239 RVA: 0x00449B13 File Offset: 0x00447D13
	private void DEFPCJMGMFI(Vector2 OPDCNOOGBIF)
	{
		this.GGKIGGBGLOA = OPDCNOOGBIF;
		this.Dragging = false;
		this.AAEFEIGCJGG = this.OPFCKEAEPGC(OPDCNOOGBIF);
		if (this.AAEFEIGCJGG != null)
		{
			this.AAEFEIGCJGG.SendMessage("_ColorBuffer", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x0600BC70 RID: 48240 RVA: 0x00449B05 File Offset: 0x00447D05
	private void Start()
	{
		this.CMMMNLFGCJB = base.GetComponent<Camera>();
	}

	// Token: 0x0600BC71 RID: 48241 RVA: 0x00449B54 File Offset: 0x00447D54
	private GameObject AANABPBOBEG(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 927f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC72 RID: 48242 RVA: 0x00449B9D File Offset: 0x00447D9D
	private void IMLHKBFBBGK(Vector2 OPDCNOOGBIF)
	{
		this.GGKIGGBGLOA = OPDCNOOGBIF;
		this.Dragging = true;
		this.AAEFEIGCJGG = this.AFGBEEIODHH(OPDCNOOGBIF);
		if (this.AAEFEIGCJGG != null)
		{
			this.AAEFEIGCJGG.SendMessage("OnPress", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x0600BC73 RID: 48243 RVA: 0x00449BDC File Offset: 0x00447DDC
	public static GameObject KKKHLHDPFHE()
	{
		return InputToEvent.<DDEJNLMHIAE>k__BackingField;
	}

	// Token: 0x0600BC74 RID: 48244 RVA: 0x00449BE4 File Offset: 0x00447DE4
	private void LCJHDLKJEOM()
	{
		if (this.DetectPointedAtGameObject)
		{
			InputToEvent.LFLGENLBCCE(this.LLCBANNMBJB(Input.mousePosition));
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			this.GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				this.OFPBJLNIPDF(touch.position);
			}
			else if (touch.phase == (TouchPhase)6)
			{
				this.GLEMAAPOJLO(touch.position);
			}
			return;
		}
		this.GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			this.OHJJJFCOJPP(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			this.GLEMAAPOJLO(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			this.GGKIGGBGLOA = Input.mousePosition;
			this.AAEFEIGCJGG = this.JJHIFDNOPBI(this.GGKIGGBGLOA);
			if (this.AAEFEIGCJGG != null)
			{
				this.AAEFEIGCJGG.SendMessage("_Value2", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	// Token: 0x0600BC75 RID: 48245 RVA: 0x00449CFE File Offset: 0x00447EFE
	private static void PGJNJBFBDFD(GameObject DPNHODJHGJL)
	{
		InputToEvent.<DDEJNLMHIAE>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC77 RID: 48247 RVA: 0x00449D24 File Offset: 0x00447F24
	public Vector2 MLNMIBBFOBM()
	{
		return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
	}

	// Token: 0x0600BC78 RID: 48248 RVA: 0x00449D4C File Offset: 0x00447F4C
	private void AOGKEMMCNIF(Vector2 OPDCNOOGBIF)
	{
		if (this.AAEFEIGCJGG != null)
		{
			GameObject x = this.BNPIECAMPNK(OPDCNOOGBIF);
			if (x == this.AAEFEIGCJGG)
			{
				this.AAEFEIGCJGG.SendMessage("Cause: ", SendMessageOptions.DontRequireReceiver);
			}
			this.AAEFEIGCJGG.SendMessage("note.6", SendMessageOptions.RequireReceiver);
			this.AAEFEIGCJGG = null;
		}
		this.GGKIGGBGLOA = Vector2.zero;
		this.Dragging = false;
	}

	// Token: 0x0600BC79 RID: 48249 RVA: 0x00449DC0 File Offset: 0x00447FC0
	private GameObject EBEHLENFGHA(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 1084f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC7A RID: 48250 RVA: 0x00449D24 File Offset: 0x00447F24
	public Vector2 LDFGLJMDNCL()
	{
		return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
	}

	// Token: 0x0600BC7B RID: 48251 RVA: 0x00449E0C File Offset: 0x0044800C
	private void MFMMDDJFMGI(Vector2 OPDCNOOGBIF)
	{
		if (this.AAEFEIGCJGG != null)
		{
			GameObject x = this.AFGBEEIODHH(OPDCNOOGBIF);
			if (x == this.AAEFEIGCJGG)
			{
				this.AAEFEIGCJGG.SendMessage("OnClick", SendMessageOptions.DontRequireReceiver);
			}
			this.AAEFEIGCJGG.SendMessage("OnRelease", SendMessageOptions.DontRequireReceiver);
			this.AAEFEIGCJGG = null;
		}
		this.GGKIGGBGLOA = Vector2.zero;
		this.Dragging = false;
	}

	// Token: 0x0600BC7C RID: 48252 RVA: 0x00449E80 File Offset: 0x00448080
	private void ABIAEEHOAKE(Vector2 OPDCNOOGBIF)
	{
		if (this.AAEFEIGCJGG != null)
		{
			GameObject x = this.JJHIFDNOPBI(OPDCNOOGBIF);
			if (x == this.AAEFEIGCJGG)
			{
				this.AAEFEIGCJGG.SendMessage("BestRegion checks region: ", SendMessageOptions.DontRequireReceiver);
			}
			this.AAEFEIGCJGG.SendMessage("Horizontal", SendMessageOptions.RequireReceiver);
			this.AAEFEIGCJGG = null;
		}
		this.GGKIGGBGLOA = Vector2.zero;
		this.Dragging = false;
	}

	// Token: 0x0600BC7D RID: 48253 RVA: 0x00449B05 File Offset: 0x00447D05
	private void OHFOLGANOLC()
	{
		this.CMMMNLFGCJB = base.GetComponent<Camera>();
	}

	// Token: 0x0600BC7E RID: 48254 RVA: 0x00449EF4 File Offset: 0x004480F4
	private GameObject LLCBANNMBJB(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 474f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC7F RID: 48255 RVA: 0x00449B05 File Offset: 0x00447D05
	private void FHPFJBFCOOF()
	{
		this.CMMMNLFGCJB = base.GetComponent<Camera>();
	}

	// Token: 0x0600BC80 RID: 48256 RVA: 0x00449D24 File Offset: 0x00447F24
	public Vector2 MBAKAHMAOAP()
	{
		return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
	}

	// Token: 0x0600BC81 RID: 48257 RVA: 0x00449D24 File Offset: 0x00447F24
	public Vector2 NGBOLLLOLAO()
	{
		return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
	}

	// Token: 0x0600BC82 RID: 48258 RVA: 0x00449F40 File Offset: 0x00448140
	private GameObject DEEMBJNPOIJ(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 226f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC83 RID: 48259 RVA: 0x00449BDC File Offset: 0x00447DDC
	public static GameObject CDAGDJMAHLH()
	{
		return InputToEvent.<DDEJNLMHIAE>k__BackingField;
	}

	// Token: 0x0600BC84 RID: 48260 RVA: 0x00449F8C File Offset: 0x0044818C
	private GameObject GFHLGLEEKHC(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 728f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC85 RID: 48261 RVA: 0x00449B05 File Offset: 0x00447D05
	private void FIKFJDFELIP()
	{
		this.CMMMNLFGCJB = base.GetComponent<Camera>();
	}

	// Token: 0x0600BC86 RID: 48262 RVA: 0x00449FD5 File Offset: 0x004481D5
	private void OHJJJFCOJPP(Vector2 OPDCNOOGBIF)
	{
		this.GGKIGGBGLOA = OPDCNOOGBIF;
		this.Dragging = true;
		this.AAEFEIGCJGG = this.JJHIFDNOPBI(OPDCNOOGBIF);
		if (this.AAEFEIGCJGG != null)
		{
			this.AAEFEIGCJGG.SendMessage("note.4", SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x0600BC87 RID: 48263 RVA: 0x00449CFE File Offset: 0x00447EFE
	private static void ALBOOMNODCL(GameObject DPNHODJHGJL)
	{
		InputToEvent.<DDEJNLMHIAE>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC88 RID: 48264 RVA: 0x00449D24 File Offset: 0x00447F24
	public Vector2 NJHOKAJGCID()
	{
		return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
	}

	// Token: 0x0600BC89 RID: 48265 RVA: 0x0044A014 File Offset: 0x00448214
	private void BGDONBMDPGM()
	{
		if (this.DetectPointedAtGameObject)
		{
			InputToEvent.PGJNJBFBDFD(this.AANABPBOBEG(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(1);
			this.GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				this.AANKFBFFODO(touch.position);
			}
			else if (touch.phase == (TouchPhase)6)
			{
				this.OEOEIIGKLPA(touch.position);
			}
			return;
		}
		this.GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			this.OFPBJLNIPDF(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(0))
		{
			this.GLEMAAPOJLO(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(0))
		{
			this.GGKIGGBGLOA = Input.mousePosition;
			this.AAEFEIGCJGG = this.PMFFFFPFKEG(this.GGKIGGBGLOA);
			if (this.AAEFEIGCJGG != null)
			{
				this.AAEFEIGCJGG.SendMessage("_Value", SendMessageOptions.RequireReceiver);
			}
		}
	}

	// Token: 0x0600BC8A RID: 48266 RVA: 0x0044A130 File Offset: 0x00448330
	private GameObject JJHIFDNOPBI(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 1172f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC8B RID: 48267 RVA: 0x00449CFE File Offset: 0x00447EFE
	private static void LFLGENLBCCE(GameObject DPNHODJHGJL)
	{
		InputToEvent.<DDEJNLMHIAE>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC8C RID: 48268 RVA: 0x00449CFE File Offset: 0x00447EFE
	private static void FMFGAIGOJHG(GameObject DPNHODJHGJL)
	{
		InputToEvent.<DDEJNLMHIAE>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BC8D RID: 48269 RVA: 0x0044A179 File Offset: 0x00448379
	private void OFPBJLNIPDF(Vector2 OPDCNOOGBIF)
	{
		this.GGKIGGBGLOA = OPDCNOOGBIF;
		this.Dragging = true;
		this.AAEFEIGCJGG = this.DEEMBJNPOIJ(OPDCNOOGBIF);
		if (this.AAEFEIGCJGG != null)
		{
			this.AAEFEIGCJGG.SendMessage("CameraFilterPack/Drawing_Crosshatch", SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x0600BC8E RID: 48270 RVA: 0x00449BDC File Offset: 0x00447DDC
	public static GameObject JHMGPBIPOFP()
	{
		return InputToEvent.<DDEJNLMHIAE>k__BackingField;
	}

	// Token: 0x170002D9 RID: 729
	// (get) Token: 0x0600BC8F RID: 48271 RVA: 0x00449BDC File Offset: 0x00447DDC
	// (set) Token: 0x0600BCA7 RID: 48295 RVA: 0x00449CFE File Offset: 0x00447EFE
	public static GameObject goPointedAt { get; private set; }

	// Token: 0x0600BC90 RID: 48272 RVA: 0x00449BDC File Offset: 0x00447DDC
	public static GameObject EPNIEGKMAHG()
	{
		return InputToEvent.<DDEJNLMHIAE>k__BackingField;
	}

	// Token: 0x0600BC91 RID: 48273 RVA: 0x00449BDC File Offset: 0x00447DDC
	public static GameObject BHMCMOMJNEB()
	{
		return InputToEvent.<DDEJNLMHIAE>k__BackingField;
	}

	// Token: 0x0600BC92 RID: 48274 RVA: 0x0044A1B8 File Offset: 0x004483B8
	private GameObject DGGEDPILEMJ(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 1687f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC93 RID: 48275 RVA: 0x00449BDC File Offset: 0x00447DDC
	public static GameObject HKPJGDBCCIJ()
	{
		return InputToEvent.<DDEJNLMHIAE>k__BackingField;
	}

	// Token: 0x0600BC94 RID: 48276 RVA: 0x0044A201 File Offset: 0x00448401
	private void DEAIEEAGCBB(Vector2 OPDCNOOGBIF)
	{
		this.GGKIGGBGLOA = OPDCNOOGBIF;
		this.Dragging = true;
		this.AAEFEIGCJGG = this.BNPIECAMPNK(OPDCNOOGBIF);
		if (this.AAEFEIGCJGG != null)
		{
			this.AAEFEIGCJGG.SendMessage("player.abstract", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x170002DA RID: 730
	// (get) Token: 0x0600BC95 RID: 48277 RVA: 0x00449D24 File Offset: 0x00447F24
	public Vector2 DragVector
	{
		get
		{
			return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
		}
	}

	// Token: 0x0600BC96 RID: 48278 RVA: 0x00449BDC File Offset: 0x00447DDC
	public static GameObject NLBLELFIJJC()
	{
		return InputToEvent.<DDEJNLMHIAE>k__BackingField;
	}

	// Token: 0x0600BC97 RID: 48279 RVA: 0x00449B05 File Offset: 0x00447D05
	private void FANADGBGCPI()
	{
		this.CMMMNLFGCJB = base.GetComponent<Camera>();
	}

	// Token: 0x0600BC98 RID: 48280 RVA: 0x0044A240 File Offset: 0x00448440
	private GameObject PMFFFFPFKEG(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 671f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC99 RID: 48281 RVA: 0x00449D24 File Offset: 0x00447F24
	public Vector2 GKHHOANMMDC()
	{
		return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
	}

	// Token: 0x0600BC9A RID: 48282 RVA: 0x0044A28C File Offset: 0x0044848C
	private void NKLIHNJCHOG()
	{
		if (this.DetectPointedAtGameObject)
		{
			InputToEvent.goPointedAt = this.AANABPBOBEG(Input.mousePosition);
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(1);
			this.GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				this.IMLHKBFBBGK(touch.position);
			}
			else if (touch.phase == TouchPhase.Stationary)
			{
				this.OEOEIIGKLPA(touch.position);
			}
			return;
		}
		this.GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			this.IMLHKBFBBGK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			this.FOALLFHOGOI(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			this.GGKIGGBGLOA = Input.mousePosition;
			this.AAEFEIGCJGG = this.LLCBANNMBJB(this.GGKIGGBGLOA);
			if (this.AAEFEIGCJGG != null)
			{
				this.AAEFEIGCJGG.SendMessage("maps.", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	// Token: 0x0600BC9B RID: 48283 RVA: 0x0044A3A8 File Offset: 0x004485A8
	private void OCMKCBBCEFG()
	{
		if (this.DetectPointedAtGameObject)
		{
			InputToEvent.PGJNJBFBDFD(this.DEEMBJNPOIJ(Input.mousePosition));
		}
		if (Input.touchCount > 1)
		{
			Touch touch = Input.GetTouch(1);
			this.GMMIPJMMMEI = touch.position;
			if (touch.phase == TouchPhase.Began)
			{
				this.OHJJJFCOJPP(touch.position);
			}
			else if (touch.phase == (TouchPhase)5)
			{
				this.GLEMAAPOJLO(touch.position);
			}
			return;
		}
		this.GMMIPJMMMEI = Input.mousePosition;
		if (Input.GetMouseButtonDown(1))
		{
			this.IMLHKBFBBGK(Input.mousePosition);
		}
		if (Input.GetMouseButtonUp(1))
		{
			this.GLEMAAPOJLO(Input.mousePosition);
		}
		if (Input.GetMouseButtonDown(1))
		{
			this.GGKIGGBGLOA = Input.mousePosition;
			this.AAEFEIGCJGG = this.OPFCKEAEPGC(this.GGKIGGBGLOA);
			if (this.AAEFEIGCJGG != null)
			{
				this.AAEFEIGCJGG.SendMessage("^", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	// Token: 0x0600BC9C RID: 48284 RVA: 0x0044A4C4 File Offset: 0x004486C4
	private GameObject OPFCKEAEPGC(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 1218f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC9D RID: 48285 RVA: 0x0044A510 File Offset: 0x00448710
	private void GLEMAAPOJLO(Vector2 OPDCNOOGBIF)
	{
		if (this.AAEFEIGCJGG != null)
		{
			GameObject x = this.DGGEDPILEMJ(OPDCNOOGBIF);
			if (x == this.AAEFEIGCJGG)
			{
				this.AAEFEIGCJGG.SendMessage("[SteamManager] Connecting to server", SendMessageOptions.DontRequireReceiver);
			}
			this.AAEFEIGCJGG.SendMessage("ChatHistoryInputField", SendMessageOptions.RequireReceiver);
			this.AAEFEIGCJGG = null;
		}
		this.GGKIGGBGLOA = Vector2.zero;
		this.Dragging = true;
	}

	// Token: 0x0600BC9E RID: 48286 RVA: 0x0044A584 File Offset: 0x00448784
	private GameObject AFGBEEIODHH(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 200f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BC9F RID: 48287 RVA: 0x00449D24 File Offset: 0x00447F24
	public Vector2 BEFJDBLCHDI()
	{
		return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
	}

	// Token: 0x0600BCA0 RID: 48288 RVA: 0x0044A5D0 File Offset: 0x004487D0
	private GameObject BNPIECAMPNK(Vector2 OPDCNOOGBIF)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CMMMNLFGCJB.ScreenPointToRay(OPDCNOOGBIF), out raycastHit, 1495f))
		{
			InputToEvent.inputHitPos = raycastHit.point;
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	// Token: 0x0600BCA1 RID: 48289 RVA: 0x00449D24 File Offset: 0x00447F24
	public Vector2 DGGCDNLCMLA()
	{
		return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
	}

	// Token: 0x0600BCA2 RID: 48290 RVA: 0x00449BDC File Offset: 0x00447DDC
	public static GameObject ALBDFMNBNMM()
	{
		return InputToEvent.<DDEJNLMHIAE>k__BackingField;
	}

	// Token: 0x0600BCA3 RID: 48291 RVA: 0x0044A61C File Offset: 0x0044881C
	private void FOALLFHOGOI(Vector2 OPDCNOOGBIF)
	{
		if (this.AAEFEIGCJGG != null)
		{
			GameObject x = this.JJHIFDNOPBI(OPDCNOOGBIF);
			if (x == this.AAEFEIGCJGG)
			{
				this.AAEFEIGCJGG.SendMessage("colorD", SendMessageOptions.DontRequireReceiver);
			}
			this.AAEFEIGCJGG.SendMessage("player.currentrank", SendMessageOptions.DontRequireReceiver);
			this.AAEFEIGCJGG = null;
		}
		this.GGKIGGBGLOA = Vector2.zero;
		this.Dragging = false;
	}

	// Token: 0x0600BCA4 RID: 48292 RVA: 0x00449D24 File Offset: 0x00447F24
	public Vector2 MLGAPCMGGEI()
	{
		return (!this.Dragging) ? Vector2.zero : (this.GMMIPJMMMEI - this.GGKIGGBGLOA);
	}

	// Token: 0x0600BCA5 RID: 48293 RVA: 0x00449BDC File Offset: 0x00447DDC
	public static GameObject GOPJFDFJDEE()
	{
		return InputToEvent.<DDEJNLMHIAE>k__BackingField;
	}

	// Token: 0x0600BCA6 RID: 48294 RVA: 0x0044A690 File Offset: 0x00448890
	private void OEOEIIGKLPA(Vector2 OPDCNOOGBIF)
	{
		if (this.AAEFEIGCJGG != null)
		{
			GameObject x = this.AANABPBOBEG(OPDCNOOGBIF);
			if (x == this.AAEFEIGCJGG)
			{
				this.AAEFEIGCJGG.SendMessage("#savemapchanges?", SendMessageOptions.RequireReceiver);
			}
			this.AAEFEIGCJGG.SendMessage("y", SendMessageOptions.DontRequireReceiver);
			this.AAEFEIGCJGG = null;
		}
		this.GGKIGGBGLOA = Vector2.zero;
		this.Dragging = false;
	}

	// Token: 0x0600BCA8 RID: 48296 RVA: 0x0044A704 File Offset: 0x00448904
	private void BIJPCIFBDAJ(Vector2 OPDCNOOGBIF)
	{
		if (this.AAEFEIGCJGG != null)
		{
			GameObject x = this.JJHIFDNOPBI(OPDCNOOGBIF);
			if (x == this.AAEFEIGCJGG)
			{
				this.AAEFEIGCJGG.SendMessage("#", SendMessageOptions.RequireReceiver);
			}
			this.AAEFEIGCJGG.SendMessage(".completedCount", SendMessageOptions.DontRequireReceiver);
			this.AAEFEIGCJGG = null;
		}
		this.GGKIGGBGLOA = Vector2.zero;
		this.Dragging = false;
	}

	// Token: 0x04001626 RID: 5670
	private GameObject AAEFEIGCJGG;

	// Token: 0x04001627 RID: 5671
	public static Vector3 inputHitPos;

	// Token: 0x04001628 RID: 5672
	public bool DetectPointedAtGameObject;

	// Token: 0x0400162A RID: 5674
	private Vector2 GGKIGGBGLOA = Vector2.zero;

	// Token: 0x0400162B RID: 5675
	private Vector2 GMMIPJMMMEI = Vector2.zero;

	// Token: 0x0400162C RID: 5676
	public bool Dragging;

	// Token: 0x0400162D RID: 5677
	private Camera CMMMNLFGCJB;
}
