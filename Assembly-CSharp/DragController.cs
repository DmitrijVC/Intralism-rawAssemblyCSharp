using System;
using UnityEngine;

// Token: 0x020003AC RID: 940
public class DragController : MonoBehaviour
{
	// Token: 0x0600D2F6 RID: 54006 RVA: 0x004B8920 File Offset: 0x004B6B20
	public void AIMAEDIEEGI(Vector3 KMDIKEAGGHB)
	{
		this.INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		this.ODOEHCEMDKB = false;
	}

	// Token: 0x0600D2F7 RID: 54007 RVA: 0x004B8920 File Offset: 0x004B6B20
	public void CCPFGCKHHCN(Vector3 KMDIKEAGGHB)
	{
		this.INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		this.ODOEHCEMDKB = false;
	}

	// Token: 0x0600D2F8 RID: 54008 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent FIEKNFJBJKP()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D2F9 RID: 54009 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent GetEditorEvent()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D2FA RID: 54010 RVA: 0x004B8970 File Offset: 0x004B6B70
	public void OnDragEnd()
	{
		this.ODOEHCEMDKB = false;
		this.GetEditorEvent().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		this.GetEditorEvent().UpdateEvent();
	}

	// Token: 0x0600D2FB RID: 54011 RVA: 0x004B8920 File Offset: 0x004B6B20
	public void AIOJCNCPCEG(Vector3 KMDIKEAGGHB)
	{
		this.INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		this.ODOEHCEMDKB = false;
	}

	// Token: 0x0600D2FC RID: 54012 RVA: 0x004B8920 File Offset: 0x004B6B20
	public void ADPFOONOBBA(Vector3 KMDIKEAGGHB)
	{
		this.INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		this.ODOEHCEMDKB = false;
	}

	// Token: 0x0600D2FE RID: 54014 RVA: 0x004B89BC File Offset: 0x004B6BBC
	private void GHILDCBCDJI()
	{
		if (this.ODOEHCEMDKB)
		{
			Vector3 a = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector = a + this.INLGAOLENMD;
			vector.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector.x), vector.y, 1055f);
		}
	}

	// Token: 0x0600D2FF RID: 54015 RVA: 0x004B8A38 File Offset: 0x004B6C38
	public void NCJNAIBOBJF()
	{
		this.ODOEHCEMDKB = false;
		this.EFKICKGLPAA().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		this.FIEKNFJBJKP().UpdateEvent();
	}

	// Token: 0x0600D300 RID: 54016 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent HCBHBLNKMGD()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D301 RID: 54017 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent LDGJPECJDKD()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D302 RID: 54018 RVA: 0x004B8A84 File Offset: 0x004B6C84
	private void MFMIODIAKNI()
	{
		if (this.ODOEHCEMDKB)
		{
			Vector3 a = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector = a + this.INLGAOLENMD;
			vector.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector.x), vector.y, 984f);
		}
	}

	// Token: 0x0600D303 RID: 54019 RVA: 0x004B8B00 File Offset: 0x004B6D00
	private void NKLIHNJCHOG()
	{
		if (this.ODOEHCEMDKB)
		{
			Vector3 a = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector = a + this.INLGAOLENMD;
			vector.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector.x), vector.y, 686f);
		}
	}

	// Token: 0x0600D304 RID: 54020 RVA: 0x004B8B7C File Offset: 0x004B6D7C
	public void HDBMLLJFIAJ()
	{
		this.ODOEHCEMDKB = false;
		this.FIEKNFJBJKP().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		this.GetEditorEvent().NCMDCMHLIKD();
	}

	// Token: 0x0600D305 RID: 54021 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent EKLLANBFINH()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D306 RID: 54022 RVA: 0x004B8BC8 File Offset: 0x004B6DC8
	public void OnDragStart(Vector3 KMDIKEAGGHB)
	{
		this.INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		this.ODOEHCEMDKB = true;
	}

	// Token: 0x0600D307 RID: 54023 RVA: 0x004B8920 File Offset: 0x004B6B20
	public void OFLMBGFOMIL(Vector3 KMDIKEAGGHB)
	{
		this.INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		this.ODOEHCEMDKB = false;
	}

	// Token: 0x0600D308 RID: 54024 RVA: 0x004B8BE8 File Offset: 0x004B6DE8
	private void Update()
	{
		if (this.ODOEHCEMDKB)
		{
			Vector3 a = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector = a + this.INLGAOLENMD;
			vector.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector.x), vector.y, 0f);
		}
	}

	// Token: 0x0600D309 RID: 54025 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent HMCKEOGAHJM()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D30A RID: 54026 RVA: 0x004B8BC8 File Offset: 0x004B6DC8
	public void CLCAABBGECG(Vector3 KMDIKEAGGHB)
	{
		this.INLGAOLENMD = base.transform.position - KMDIKEAGGHB;
		this.ODOEHCEMDKB = true;
	}

	// Token: 0x0600D30B RID: 54027 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent JPCLJPBKBCD()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D30C RID: 54028 RVA: 0x004B8C64 File Offset: 0x004B6E64
	public void GDPOALKKBHE()
	{
		this.ODOEHCEMDKB = true;
		this.FIEKNFJBJKP().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		this.HCBHBLNKMGD().FMGBIHDGKBI();
	}

	// Token: 0x0600D30D RID: 54029 RVA: 0x004B8CB0 File Offset: 0x004B6EB0
	private void ONMGIPAILOH()
	{
		if (this.ODOEHCEMDKB)
		{
			Vector3 a = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector = a + this.INLGAOLENMD;
			vector.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector.x), vector.y, 1317f);
		}
	}

	// Token: 0x0600D30E RID: 54030 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent EFKICKGLPAA()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D30F RID: 54031 RVA: 0x004B8D2C File Offset: 0x004B6F2C
	private void AAPKBNDHBLI()
	{
		if (this.ODOEHCEMDKB)
		{
			Vector3 a = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 vector = a + this.INLGAOLENMD;
			vector.y = base.transform.localPosition.y;
			base.transform.position = new Vector3(Singleton<MapEditor>.Instance.GetSnappedBPM(vector.x), vector.y, 156f);
		}
	}

	// Token: 0x0600D310 RID: 54032 RVA: 0x004B8DA8 File Offset: 0x004B6FA8
	public void MGAJMKHJCOJ()
	{
		this.ODOEHCEMDKB = false;
		this.HMCKEOGAHJM().mapEvent.time = Singleton<MapEditor>.Instance.GetSnappedBPM(base.transform.localPosition.x);
		this.GetEditorEvent().NJDJHMPAIFE();
	}

	// Token: 0x04001825 RID: 6181
	private Vector3 KAOOCILPJCN;

	// Token: 0x04001826 RID: 6182
	private Vector3 INLGAOLENMD;

	// Token: 0x04001827 RID: 6183
	private bool ODOEHCEMDKB;
}
