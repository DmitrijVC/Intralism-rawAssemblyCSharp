using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200022D RID: 557
public class ClickedWaveAnimation : MonoBehaviour
{
	// Token: 0x06008732 RID: 34610 RVA: 0x002F90A4 File Offset: 0x002F72A4
	private void DBEMDAJDDDA()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.IECHADGJJBN(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008733 RID: 34611 RVA: 0x002F90D0 File Offset: 0x002F72D0
	public GameObject LLPBMMMJKMN()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008734 RID: 34612 RVA: 0x002F9170 File Offset: 0x002F7370
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.UiHitted();
			if (gameObject)
			{
				this.LNBJBGFCBLC(gameObject.transform);
			}
		}
	}

	// Token: 0x06008735 RID: 34613 RVA: 0x002F91A6 File Offset: 0x002F73A6
	private void EGEPLFGKGLI()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.CreatePool(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008736 RID: 34614 RVA: 0x002F91D0 File Offset: 0x002F73D0
	private void FJKCOMIKDAG(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.OJLOOIEONGI();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(359f, 128f, 854f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1196f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 28f;
			a.z = 1369f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().NIOMFNEEMDF();
		}
	}

	// Token: 0x06008737 RID: 34615 RVA: 0x002F92DC File Offset: 0x002F74DC
	private void GINIGCEOCMH(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.JLLHOBJBDNN();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(582f, 1714f, 1605f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 535f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1563f;
			a.z = 1379f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008738 RID: 34616 RVA: 0x002F93E5 File Offset: 0x002F75E5
	private void KMCPMOGKDEH()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.ABBHFBOBILM(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008739 RID: 34617 RVA: 0x002F9410 File Offset: 0x002F7610
	private void GHILDCBCDJI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.UiHitted();
			if (gameObject)
			{
				this.PPGAIGGNAFH(gameObject.transform);
			}
		}
	}

	// Token: 0x0600873A RID: 34618 RVA: 0x002F9448 File Offset: 0x002F7648
	public GameObject DMGFNONDPGB()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600873B RID: 34619 RVA: 0x002F94E8 File Offset: 0x002F76E8
	public GameObject MKCFBEHEFJP()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600873C RID: 34620 RVA: 0x002F9588 File Offset: 0x002F7788
	private void ANCKKLFPGDI()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.LONKKOFBDDN(this.WaveObject, this.PoolSize);
	}

	// Token: 0x0600873D RID: 34621 RVA: 0x002F95B4 File Offset: 0x002F77B4
	private void GELKNIJFHBJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.PBCCDPILANO();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(43f, 1644f, 341f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1618f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1587f;
			a.z = 235f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x0600873E RID: 34622 RVA: 0x002F96C0 File Offset: 0x002F78C0
	private void AIJGAJIOJDJ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.JGHJFAJAJON();
			if (gameObject)
			{
				this.MLPCEOOGPEI(gameObject.transform);
			}
		}
	}

	// Token: 0x0600873F RID: 34623 RVA: 0x002F96F8 File Offset: 0x002F78F8
	public GameObject CJHDCLBOLED()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008740 RID: 34624 RVA: 0x002F9798 File Offset: 0x002F7998
	private void FANADGBGCPI()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.KJFGJDHMLHJ(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008741 RID: 34625 RVA: 0x002F97C4 File Offset: 0x002F79C4
	private void JOACBIEHHCE()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.LPFLGOBJDFI();
			if (gameObject)
			{
				this.FLNBKOEMOIP(gameObject.transform);
			}
		}
	}

	// Token: 0x06008742 RID: 34626 RVA: 0x002F97FC File Offset: 0x002F79FC
	private void IPMGONDHOIP(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.DACIIEBNKBN();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1678f, 1419f, 1849f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1843f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 969f;
			a.z = 187f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008743 RID: 34627 RVA: 0x002F91A6 File Offset: 0x002F73A6
	private void Start()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.CreatePool(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008744 RID: 34628 RVA: 0x002F9908 File Offset: 0x002F7B08
	private void IOFBEKPNMAM(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.IAOPMEFNKKB();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1073f, 553f, 164f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 595f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1788f;
			a.z = 756f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008745 RID: 34629 RVA: 0x002F9A14 File Offset: 0x002F7C14
	public GameObject CNEMDIBCCEK()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008746 RID: 34630 RVA: 0x002F9AB4 File Offset: 0x002F7CB4
	private void GANGJOMAAIL(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.KABEIEDMAJK();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1966f, 678f, 1788f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 805f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1165f;
			a.z = 373f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008747 RID: 34631 RVA: 0x002F9BC0 File Offset: 0x002F7DC0
	public GameObject JGHJFAJAJON()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008748 RID: 34632 RVA: 0x002F9C60 File Offset: 0x002F7E60
	private void LEAHIBJDMBI()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.DMGFNONDPGB();
			if (gameObject)
			{
				this.IOFBEKPNMAM(gameObject.transform);
			}
		}
	}

	// Token: 0x06008749 RID: 34633 RVA: 0x002F9C98 File Offset: 0x002F7E98
	private void EFLDOJLPBHA(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.GCKMCKGHKJB();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(998f, 1549f, 1066f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1519f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1735f;
			a.z = 1498f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().NIOMFNEEMDF();
		}
	}

	// Token: 0x0600874A RID: 34634 RVA: 0x002F9DA4 File Offset: 0x002F7FA4
	private void NEKCPLGFOFD()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.FCJEPGJIPAB();
			if (gameObject)
			{
				this.IPMGONDHOIP(gameObject.transform);
			}
		}
	}

	// Token: 0x0600874B RID: 34635 RVA: 0x002F9DDC File Offset: 0x002F7FDC
	public GameObject DALHGPAIBAE()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600874C RID: 34636 RVA: 0x002F9E7C File Offset: 0x002F807C
	private void PMPKMGKAAJH()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.FAMGGJOHJFK(this.WaveObject, this.PoolSize);
	}

	// Token: 0x0600874D RID: 34637 RVA: 0x002F9EA8 File Offset: 0x002F80A8
	public GameObject NGBLCKIIOEE()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600874E RID: 34638 RVA: 0x002F9F48 File Offset: 0x002F8148
	public GameObject PPFGNIFIAGO()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600874F RID: 34639 RVA: 0x002F9798 File Offset: 0x002F7998
	private void GPNAOAKCMHC()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.KJFGJDHMLHJ(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008750 RID: 34640 RVA: 0x002F9FE8 File Offset: 0x002F81E8
	public GameObject NJJPKMBOMHJ()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008751 RID: 34641 RVA: 0x002FA088 File Offset: 0x002F8288
	public GameObject LFJBAIEJAIN()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008752 RID: 34642 RVA: 0x002F9E7C File Offset: 0x002F807C
	private void DIPDEHOOBPG()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.FAMGGJOHJFK(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008753 RID: 34643 RVA: 0x002FA128 File Offset: 0x002F8328
	private void LNBJBGFCBLC(Transform KFHEOLKCAJK)
	{
		GameObject @object = this.MHCIODHIFGG.GetObject();
		if (@object)
		{
			@object.transform.SetParent(this.CanvasMain.transform);
			@object.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(0.1f, 0.1f, 0.1f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 2f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 2f;
			a.z = 0f;
			@object.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			@object.transform.SetParent(KFHEOLKCAJK);
			@object.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008754 RID: 34644 RVA: 0x002FA234 File Offset: 0x002F8434
	private void PDGFFPLDPJJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.DACIIEBNKBN();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(59f, 1808f, 845f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 897f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 49f;
			a.z = 1855f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008755 RID: 34645 RVA: 0x002FA340 File Offset: 0x002F8540
	public GameObject CLNBFFNIDFG()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008756 RID: 34646 RVA: 0x002FA3E0 File Offset: 0x002F85E0
	public GameObject BMBAHHBCLBE()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008757 RID: 34647 RVA: 0x002FA480 File Offset: 0x002F8680
	public GameObject OBFAGLBLMKH()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008758 RID: 34648 RVA: 0x002FA520 File Offset: 0x002F8720
	public GameObject FCJEPGJIPAB()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008759 RID: 34649 RVA: 0x002FA5C0 File Offset: 0x002F87C0
	public GameObject EKOHHBHAMND()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600875A RID: 34650 RVA: 0x002FA660 File Offset: 0x002F8860
	private void MAOCOEGAFND()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.MKCFBEHEFJP();
			if (gameObject)
			{
				this.LNBJBGFCBLC(gameObject.transform);
			}
		}
	}

	// Token: 0x0600875B RID: 34651 RVA: 0x002FA698 File Offset: 0x002F8898
	private void ICPNIMIFGHA(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.FIFJDDBGONJ();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1733f, 346f, 1295f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1542f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 135f;
			a.z = 846f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x0600875C RID: 34652 RVA: 0x002FA7A4 File Offset: 0x002F89A4
	private void JNBPKNNBMDI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.JGHJFAJAJON();
			if (gameObject)
			{
				this.IPMGONDHOIP(gameObject.transform);
			}
		}
	}

	// Token: 0x0600875D RID: 34653 RVA: 0x002FA7DC File Offset: 0x002F89DC
	public GameObject ILGGAMKKFMK()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600875E RID: 34654 RVA: 0x002FA87C File Offset: 0x002F8A7C
	private void MLPCEOOGPEI(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.AFCDLOLBNNM();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1384f, 495f, 617f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 265f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 159f;
			a.z = 1725f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008760 RID: 34656 RVA: 0x002FA988 File Offset: 0x002F8B88
	private void FCNBDNMMAML(Transform KFHEOLKCAJK)
	{
		GameObject @object = this.MHCIODHIFGG.GetObject();
		if (@object)
		{
			@object.transform.SetParent(this.CanvasMain.transform);
			@object.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(505f, 585f, 485f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 160f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1276f;
			a.z = 1485f;
			@object.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			@object.transform.SetParent(KFHEOLKCAJK);
			@object.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008761 RID: 34657 RVA: 0x002FAA94 File Offset: 0x002F8C94
	private void GICHJOJPCOC(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.KFJOEEDEODL();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(242f, 77f, 46f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 783f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1668f;
			a.z = 1328f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008762 RID: 34658 RVA: 0x002FABA0 File Offset: 0x002F8DA0
	private void AEIJFLJEABG()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.GCNOKDFCDPL();
			if (gameObject)
			{
				this.LOLIELBLLBJ(gameObject.transform);
			}
		}
	}

	// Token: 0x06008763 RID: 34659 RVA: 0x002FABD6 File Offset: 0x002F8DD6
	private void KDMKDEKCELE()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.HDPNDDHNFOJ(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008764 RID: 34660 RVA: 0x002FAC00 File Offset: 0x002F8E00
	private void BMODOIJGIOO()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.MKCFBEHEFJP();
			if (gameObject)
			{
				this.GINIGCEOCMH(gameObject.transform);
			}
		}
	}

	// Token: 0x06008765 RID: 34661 RVA: 0x002FAC38 File Offset: 0x002F8E38
	private void PPGAIGGNAFH(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.NBIKOBBNFGM();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(894f, 756f, 78f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 636f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1449f;
			a.z = 716f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008766 RID: 34662 RVA: 0x002FAD44 File Offset: 0x002F8F44
	private void JMMABGLJNMF(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.FGCEDMAPAGA();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(198f, 1916f, 0f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1951f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1548f;
			a.z = 1385f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008767 RID: 34663 RVA: 0x002FAE50 File Offset: 0x002F9050
	private void EGEGNHLODAA()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.PFGAFEPCIMH();
			if (gameObject)
			{
				this.EFLDOJLPBHA(gameObject.transform);
			}
		}
	}

	// Token: 0x06008768 RID: 34664 RVA: 0x002FAE88 File Offset: 0x002F9088
	private void JONCLDHGLCA(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.NNMEAEKODCB();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1456f, 637f, 531f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1667f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1281f;
			a.z = 790f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().NIOMFNEEMDF();
		}
	}

	// Token: 0x06008769 RID: 34665 RVA: 0x002FAF94 File Offset: 0x002F9194
	private void LOLIELBLLBJ(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.NNMEAEKODCB();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1400f, 747f, 805f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1092f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1415f;
			a.z = 248f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().NIOMFNEEMDF();
		}
	}

	// Token: 0x0600876A RID: 34666 RVA: 0x002FB0A0 File Offset: 0x002F92A0
	public GameObject UiHitted()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600876B RID: 34667 RVA: 0x002FB140 File Offset: 0x002F9340
	private void KLILJHJNICK()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.NPGADDCHIEF(this.WaveObject, this.PoolSize);
	}

	// Token: 0x0600876C RID: 34668 RVA: 0x002FB16A File Offset: 0x002F936A
	private void EPEGAEGDJAM()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.DOPLKFDBGAM(this.WaveObject, this.PoolSize);
	}

	// Token: 0x0600876D RID: 34669 RVA: 0x002FB194 File Offset: 0x002F9394
	private void DKOPKPBLDHH()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.MJKODGBPPJI(this.WaveObject, this.PoolSize);
	}

	// Token: 0x0600876E RID: 34670 RVA: 0x002FB1C0 File Offset: 0x002F93C0
	public GameObject PFGAFEPCIMH()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600876F RID: 34671 RVA: 0x002FB260 File Offset: 0x002F9460
	public GameObject DDHCBHGALBN()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008770 RID: 34672 RVA: 0x002FB300 File Offset: 0x002F9500
	private void FLNBKOEMOIP(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.DPHGKHICPLP();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(104f, 384f, 1117f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1472f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 1455f;
			a.z = 1766f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008771 RID: 34673 RVA: 0x002FB40C File Offset: 0x002F960C
	private void DPIPGGDNGHN()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.LGKFHICIJFG();
			if (gameObject)
			{
				this.JMMABGLJNMF(gameObject.transform);
			}
		}
	}

	// Token: 0x06008772 RID: 34674 RVA: 0x002FB444 File Offset: 0x002F9644
	private void LGDDAJEAMOG(Transform KFHEOLKCAJK)
	{
		GameObject gameObject = this.MHCIODHIFGG.PBCCDPILANO();
		if (gameObject)
		{
			gameObject.transform.SetParent(this.CanvasMain.transform);
			gameObject.GetComponent<MaskableGraphic>().color = KFHEOLKCAJK.GetComponent<MaskableGraphic>().color - new Color(1949f, 1951f, 420f);
			Vector3 a = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			a.x = a.x * (float)Screen.width - (float)Screen.width / 1890f;
			a.y = a.y * (float)Screen.height - (float)Screen.height / 371f;
			a.z = 519f;
			gameObject.GetComponent<RectTransform>().localPosition = a / this.CanvasMain.transform.localScale.x;
			gameObject.transform.SetParent(KFHEOLKCAJK);
			gameObject.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		}
	}

	// Token: 0x06008773 RID: 34675 RVA: 0x002FB550 File Offset: 0x002F9750
	private void LCJHDLKJEOM()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject gameObject = this.CJHDCLBOLED();
			if (gameObject)
			{
				this.PDGFFPLDPJJ(gameObject.transform);
			}
		}
	}

	// Token: 0x06008774 RID: 34676 RVA: 0x002FB588 File Offset: 0x002F9788
	private void KIEJKBNBHMD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.LKENFFLHPFN();
			if (gameObject)
			{
				this.GANGJOMAAIL(gameObject.transform);
			}
		}
	}

	// Token: 0x06008775 RID: 34677 RVA: 0x002FABD6 File Offset: 0x002F8DD6
	private void JILOMOBDPIA()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.HDPNDDHNFOJ(this.WaveObject, this.PoolSize);
	}

	// Token: 0x06008776 RID: 34678 RVA: 0x002FB5C0 File Offset: 0x002F97C0
	private void CGBHOELMAOC()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.JGHJFAJAJON();
			if (gameObject)
			{
				this.PPGAIGGNAFH(gameObject.transform);
			}
		}
	}

	// Token: 0x06008777 RID: 34679 RVA: 0x002FB5F8 File Offset: 0x002F97F8
	public GameObject LKENFFLHPFN()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008778 RID: 34680 RVA: 0x002FB698 File Offset: 0x002F9898
	public GameObject LGKFHICIJFG()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x06008779 RID: 34681 RVA: 0x002FB738 File Offset: 0x002F9938
	public GameObject GCNOKDFCDPL()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600877A RID: 34682 RVA: 0x002FB7D8 File Offset: 0x002F99D8
	private void JKBMKPDGCHG()
	{
		this.MHCIODHIFGG = base.gameObject.AddComponent<Pool>();
		this.MHCIODHIFGG.EAANLGHMLDE(this.WaveObject, this.PoolSize);
	}

	// Token: 0x0600877B RID: 34683 RVA: 0x002FB804 File Offset: 0x002F9A04
	public GameObject LPFLGOBJDFI()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x0600877C RID: 34684 RVA: 0x002FB8A4 File Offset: 0x002F9AA4
	public GameObject PJHFIEFCHOB()
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].gameObject.GetComponent<Button>() && list[i].gameObject.GetComponent<Mask>())
			{
				return list[i].gameObject;
			}
		}
		return null;
	}

	// Token: 0x04000FB1 RID: 4017
	public GameObject WaveObject;

	// Token: 0x04000FB2 RID: 4018
	public GameObject CanvasMain;

	// Token: 0x04000FB3 RID: 4019
	public int PoolSize;

	// Token: 0x04000FB4 RID: 4020
	private Pool MHCIODHIFGG;
}
