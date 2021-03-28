using System;
using UnityEngine;

// Token: 0x020003BA RID: 954
public class GizmosController : MonoBehaviour
{
	// Token: 0x0600D697 RID: 54935 RVA: 0x004C85C0 File Offset: 0x004C67C0
	private void FGNFILLNPJK()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.PHFOIIGIBFN());
		}
	}

	// Token: 0x0600D698 RID: 54936 RVA: 0x004C8628 File Offset: 0x004C6828
	private void MMOMODMCGAG()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 588f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1199f)
			{
				vector.x = 1662f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 429f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(false);
		}
	}

	// Token: 0x0600D699 RID: 54937 RVA: 0x004C8730 File Offset: 0x004C6930
	private void JIENIAGLCJO()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1145f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D69A RID: 54938 RVA: 0x004C8794 File Offset: 0x004C6994
	private void BLEMAGIAGJA()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1665f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D69B RID: 54939 RVA: 0x004C87F8 File Offset: 0x004C69F8
	private void PLBADDFPCPO()
	{
		this.PHFOIIGIBFN().EOEDBFHBPEI();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("{0,-18} {1,18}", true);
	}

	// Token: 0x0600D69C RID: 54940 RVA: 0x004C8820 File Offset: 0x004C6A20
	private void DNENFLNCIJP()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.NMLINPHFOJJ());
		}
	}

	// Token: 0x0600D69D RID: 54941 RVA: 0x004C8888 File Offset: 0x004C6A88
	private void GCHBGCGBMCK()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.DAJEEPICDLD());
		}
	}

	// Token: 0x0600D69E RID: 54942 RVA: 0x004C88EE File Offset: 0x004C6AEE
	private void OnMouseUp()
	{
		this.GetEditorEvent().UpdateEvent();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Moved event", false);
	}

	// Token: 0x0600D69F RID: 54943 RVA: 0x004C8918 File Offset: 0x004C6B18
	private void BCFMIBKENIH()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 587f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1470f)
			{
				vector.x = 1738f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 464f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(true);
		}
	}

	// Token: 0x0600D6A0 RID: 54944 RVA: 0x004C8A20 File Offset: 0x004C6C20
	private void FDBPLMOCJFH()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 386f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6A1 RID: 54945 RVA: 0x004C8A84 File Offset: 0x004C6C84
	private void HBKFNDMDLBP()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1475f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6A2 RID: 54946 RVA: 0x004C8AE8 File Offset: 0x004C6CE8
	private void GPFJMKCGHGB()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.NMLINPHFOJJ());
		}
	}

	// Token: 0x0600D6A3 RID: 54947 RVA: 0x004C8B50 File Offset: 0x004C6D50
	private void PGHOOCPIEAJ()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1791f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6A4 RID: 54948 RVA: 0x004C8BB4 File Offset: 0x004C6DB4
	private void JHPOIOELNCG()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.NMEPOAEPNFM());
		}
	}

	// Token: 0x0600D6A5 RID: 54949 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent BDAFJCNJNMC()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6A6 RID: 54950 RVA: 0x004C8C1C File Offset: 0x004C6E1C
	private void LLJLDLLNFBH()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.NGJPHBAPIKJ());
		}
	}

	// Token: 0x0600D6A7 RID: 54951 RVA: 0x004C8C84 File Offset: 0x004C6E84
	private void KKLMPKLKAEM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.LJABCHJFAAA());
		}
	}

	// Token: 0x0600D6A8 RID: 54952 RVA: 0x004C8CEC File Offset: 0x004C6EEC
	private void BMOPLCBCIOM()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 818f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1050f)
			{
				vector.x = 179f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1176f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	// Token: 0x0600D6A9 RID: 54953 RVA: 0x004C8DF4 File Offset: 0x004C6FF4
	private void NNOEAHIHOFC()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1100f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6AA RID: 54954 RVA: 0x004C8E58 File Offset: 0x004C7058
	private void NCPAFCKGJEA()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.FMHIJJNLJIE());
		}
	}

	// Token: 0x0600D6AB RID: 54955 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent GKEAKHFGHHH()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6AC RID: 54956 RVA: 0x004C8EC0 File Offset: 0x004C70C0
	private void FJGPHHNCFBM()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 226f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 513f)
			{
				vector.x = 1681f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1623f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(true);
		}
	}

	// Token: 0x0600D6AD RID: 54957 RVA: 0x004C8FC8 File Offset: 0x004C71C8
	private void GHEFAJABADL()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1897f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 704f)
			{
				vector.x = 540f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 81f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA(false);
		}
	}

	// Token: 0x0600D6AE RID: 54958 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent NMLINPHFOJJ()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6AF RID: 54959 RVA: 0x004C90D0 File Offset: 0x004C72D0
	private void EPJJDKJEDMM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(this.PIANIMBGNEG());
		}
	}

	// Token: 0x0600D6B0 RID: 54960 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent BPMBNNJMINL()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6B1 RID: 54961 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent EFJFMOANNMJ()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6B2 RID: 54962 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent DAJEEPICDLD()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6B3 RID: 54963 RVA: 0x004C9138 File Offset: 0x004C7338
	private void MANDOGNJJBD()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.LJABCHJFAAA());
		}
	}

	// Token: 0x0600D6B4 RID: 54964 RVA: 0x004C919E File Offset: 0x004C739E
	private void IBGONHDCDIH()
	{
		this.HBNKOCHGKBI().NCMDCMHLIKD();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(false);
		Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("_SSAO", true);
	}

	// Token: 0x0600D6B5 RID: 54965 RVA: 0x004C91C8 File Offset: 0x004C73C8
	private void HOFEFJDDKDJ()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1304f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 422f)
			{
				vector.x = 659f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 971f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	// Token: 0x0600D6B6 RID: 54966 RVA: 0x004C92D0 File Offset: 0x004C74D0
	private void POJFHDFJOPE()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(this.GetEditorEvent());
		}
	}

	// Token: 0x0600D6B7 RID: 54967 RVA: 0x004C9338 File Offset: 0x004C7538
	private void FABMDEHEDNO()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(this.HFAMJIHOJCH());
		}
	}

	// Token: 0x0600D6B8 RID: 54968 RVA: 0x004C93A0 File Offset: 0x004C75A0
	private void CGBHOELMAOC()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.LJABCHJFAAA());
		}
	}

	// Token: 0x0600D6B9 RID: 54969 RVA: 0x004C9408 File Offset: 0x004C7608
	private void PIFLFGFMIID()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 354f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1419f)
			{
				vector.x = 1967f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1392f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	// Token: 0x0600D6BA RID: 54970 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent POPOCHKFGIM()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6BB RID: 54971 RVA: 0x004C9510 File Offset: 0x004C7710
	private void KNKCANBEHMH()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1877f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6BC RID: 54972 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent NHGKAAPBNAO()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6BD RID: 54973 RVA: 0x004C9574 File Offset: 0x004C7774
	private void AHKMGGICKOH()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1546f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1719f)
			{
				vector.x = 482f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1801f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(true);
		}
	}

	// Token: 0x0600D6BE RID: 54974 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent MLALBGFHDCB()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6BF RID: 54975 RVA: 0x004C967C File Offset: 0x004C787C
	private void INLDEHPAMJC()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.PHFOIIGIBFN());
		}
	}

	// Token: 0x0600D6C0 RID: 54976 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent HIGBPDDOABN()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6C1 RID: 54977 RVA: 0x004C96E4 File Offset: 0x004C78E4
	private void ELMKPIHFNEB()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 435f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1316f)
			{
				vector.x = 1484f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1697f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA(true);
		}
	}

	// Token: 0x0600D6C2 RID: 54978 RVA: 0x004C97EC File Offset: 0x004C79EC
	private void ECCNFNBOOEJ()
	{
		this.NGJPHBAPIKJ().EOEDBFHBPEI();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("Show Image", true);
	}

	// Token: 0x0600D6C3 RID: 54979 RVA: 0x004C9814 File Offset: 0x004C7A14
	private void HPNNCNNFMGK()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.NMLINPHFOJJ());
		}
	}

	// Token: 0x0600D6C4 RID: 54980 RVA: 0x004C987C File Offset: 0x004C7A7C
	private void NIEGGPFAFJF()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1355f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1278f)
			{
				vector.x = 1850f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1120f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(false);
		}
	}

	// Token: 0x0600D6C5 RID: 54981 RVA: 0x004C9984 File Offset: 0x004C7B84
	private void PACCEJJBCFH()
	{
		this.HFAMJIHOJCH().FMGBIHDGKBI();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().NGDDLPLEHHA(false);
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("_TimeX", false);
	}

	// Token: 0x0600D6C6 RID: 54982 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent PIANIMBGNEG()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6C7 RID: 54983 RVA: 0x004C99AC File Offset: 0x004C7BAC
	private void LOJFCLFDCED()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 725f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6C8 RID: 54984 RVA: 0x004C9A10 File Offset: 0x004C7C10
	private void FBCHBMPPEKA()
	{
		this.BPMBNNJMINL().UpdateEvent();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(false);
		Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_Value3", true);
	}

	// Token: 0x0600D6C9 RID: 54985 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent ECGGFGJJOEL()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6CA RID: 54986 RVA: 0x004C9A38 File Offset: 0x004C7C38
	private void PBKHGNKHICG()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 141f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6CB RID: 54987 RVA: 0x004C9A9C File Offset: 0x004C7C9C
	private void GCBPIGJDIIC()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 271f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6CC RID: 54988 RVA: 0x004C9B00 File Offset: 0x004C7D00
	private void NDAJBJFJGCF()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(this.DAJEEPICDLD());
		}
	}

	// Token: 0x0600D6CD RID: 54989 RVA: 0x004C9B66 File Offset: 0x004C7D66
	private void BOAIEKJJDOK()
	{
		this.HIGBPDDOABN().FMGBIHDGKBI();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK(" not exist", true);
	}

	// Token: 0x0600D6CE RID: 54990 RVA: 0x004C9B90 File Offset: 0x004C7D90
	private void BGDONBMDPGM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.JCKAGIDMKFN());
		}
	}

	// Token: 0x0600D6CF RID: 54991 RVA: 0x004C9BF8 File Offset: 0x004C7DF8
	private void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.GetEditorEvent());
		}
	}

	// Token: 0x0600D6D0 RID: 54992 RVA: 0x004C9C60 File Offset: 0x004C7E60
	private void KCDBBPKIFNJ()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.PHFOIIGIBFN());
		}
	}

	// Token: 0x0600D6D1 RID: 54993 RVA: 0x004C9CC6 File Offset: 0x004C7EC6
	private void JLPHDJKLDDJ()
	{
		this.JCKAGIDMKFN().UpdateEvent();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(false);
		Singleton<EditorHistoryHandler>.Instance.SaveState("[NetworkManager] roomInfo.name: ", true);
	}

	// Token: 0x0600D6D2 RID: 54994 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent HMCKEOGAHJM()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6D4 RID: 54996 RVA: 0x004C9CFD File Offset: 0x004C7EFD
	private void ALDINMIABAM()
	{
		this.JJPCJPPPOLF().KJJODHJJEOH();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(false);
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("(scene)", false);
	}

	// Token: 0x0600D6D5 RID: 54997 RVA: 0x004C9D25 File Offset: 0x004C7F25
	private void NDCCJONMODD()
	{
		this.FMHIJJNLJIE().NJDJHMPAIFE();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(false);
		Singleton<EditorHistoryHandler>.Instance.SaveState("z", false);
	}

	// Token: 0x0600D6D6 RID: 54998 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent NGJPHBAPIKJ()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6D7 RID: 54999 RVA: 0x004C9D50 File Offset: 0x004C7F50
	private void NLFMHCLMACL()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1068f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6D8 RID: 55000 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent HBNKOCHGKBI()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6D9 RID: 55001 RVA: 0x004C9DB4 File Offset: 0x004C7FB4
	private void OnMouseDown()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6DA RID: 55002 RVA: 0x004C9E18 File Offset: 0x004C8018
	private void EHCGBJDFMHG()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.BDAFJCNJNMC());
		}
	}

	// Token: 0x0600D6DB RID: 55003 RVA: 0x004C9E7E File Offset: 0x004C807E
	private void GLGLAIFGACN()
	{
		this.JCKAGIDMKFN().FMGBIHDGKBI();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().NGDDLPLEHHA(true);
		Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB(".sawoutdatedmessage", true);
	}

	// Token: 0x0600D6DC RID: 55004 RVA: 0x004C9EA8 File Offset: 0x004C80A8
	private void LDNHGEEIOPA()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 671f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 199f)
			{
				vector.x = 649f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1275f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA(true);
		}
	}

	// Token: 0x0600D6DD RID: 55005 RVA: 0x004C9FB0 File Offset: 0x004C81B0
	private void OBDEJFCNOBF()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.DBJLJKDGOOF());
		}
	}

	// Token: 0x0600D6DE RID: 55006 RVA: 0x004CA018 File Offset: 0x004C8218
	private void FEJJKFDDBOM()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 143f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 353f)
			{
				vector.x = 830f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 591f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(true);
		}
	}

	// Token: 0x0600D6DF RID: 55007 RVA: 0x004CA120 File Offset: 0x004C8320
	private void AGMJDGHLBMN()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.PHFOIIGIBFN());
		}
	}

	// Token: 0x0600D6E0 RID: 55008 RVA: 0x004CA188 File Offset: 0x004C8388
	private void JLNDHGEEKON()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 150f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6E1 RID: 55009 RVA: 0x004CA1EC File Offset: 0x004C83EC
	private void HAOOJEDEHAL()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 299f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1148f)
			{
				vector.x = 14f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 528f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	// Token: 0x0600D6E2 RID: 55010 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent GetEditorEvent()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6E3 RID: 55011 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent IJIJEKKMFEO()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6E4 RID: 55012 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent ECAMHMKKJPF()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6E5 RID: 55013 RVA: 0x004CA2F4 File Offset: 0x004C84F4
	private void KJMIFKCFBDO()
	{
		this.BPMBNNJMINL().EOEDBFHBPEI();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().NGDDLPLEHHA(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("id", false);
	}

	// Token: 0x0600D6E6 RID: 55014 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent GJKNIBHFAMK()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6E7 RID: 55015 RVA: 0x004CA31C File Offset: 0x004C851C
	private void MOMICHIKBAL()
	{
		this.PCCANFLFPJD().NCMDCMHLIKD();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(false);
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("_ForceYSwap", true);
	}

	// Token: 0x0600D6E8 RID: 55016 RVA: 0x004CA344 File Offset: 0x004C8544
	private void ABLAIDHNFFP()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1463f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1688f)
			{
				vector.x = 211f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1519f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	// Token: 0x0600D6E9 RID: 55017 RVA: 0x004CA44C File Offset: 0x004C864C
	private void ENDIOFDAKGM()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1441f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6EA RID: 55018 RVA: 0x004CA4B0 File Offset: 0x004C86B0
	private void LNNCJBHJPPI()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 320f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6EB RID: 55019 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent FMHIJJNLJIE()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6EC RID: 55020 RVA: 0x004CA514 File Offset: 0x004C8714
	private void ABFNJCEBIKA()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.GJKNIBHFAMK());
		}
	}

	// Token: 0x0600D6ED RID: 55021 RVA: 0x004CA57C File Offset: 0x004C877C
	private void DHDAMOMCAMK()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1007f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1885f)
			{
				vector.x = 245f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 414f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(false);
		}
	}

	// Token: 0x0600D6EE RID: 55022 RVA: 0x004CA684 File Offset: 0x004C8884
	private void PNEMHGPAMDP()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1600f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6EF RID: 55023 RVA: 0x004CA6E8 File Offset: 0x004C88E8
	private void MHEEHIHPHNH()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1727f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6F0 RID: 55024 RVA: 0x004CA74C File Offset: 0x004C894C
	private void MOACKDCEJBC()
	{
		this.PCCANFLFPJD().NCMDCMHLIKD();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("SelectorMapsCountSlider", false);
	}

	// Token: 0x0600D6F1 RID: 55025 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent NMEPOAEPNFM()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6F2 RID: 55026 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent LJABCHJFAAA()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6F3 RID: 55027 RVA: 0x004CA774 File Offset: 0x004C8974
	private void AMEJDNKEBJN()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1598f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6F4 RID: 55028 RVA: 0x004CA7D8 File Offset: 0x004C89D8
	private void BPOMMPCBFMG()
	{
		this.DBJLJKDGOOF().EOEDBFHBPEI();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(true);
		Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("Bad modpack name: {0}", true);
	}

	// Token: 0x0600D6F5 RID: 55029 RVA: 0x004CA800 File Offset: 0x004C8A00
	private void IGDLDJHJJHM()
	{
		this.HMCKEOGAHJM().NJDJHMPAIFE();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().NGDDLPLEHHA(false);
		Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("_ColorKey", false);
	}

	// Token: 0x0600D6F6 RID: 55030 RVA: 0x004CA828 File Offset: 0x004C8A28
	private void HCIPECAOGIA()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.NGJPHBAPIKJ());
		}
	}

	// Token: 0x0600D6F7 RID: 55031 RVA: 0x004CA890 File Offset: 0x004C8A90
	private void JAAJECBCCFM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.GJKNIBHFAMK());
		}
	}

	// Token: 0x0600D6F8 RID: 55032 RVA: 0x004CA8F6 File Offset: 0x004C8AF6
	private void FFIBICKCENJ()
	{
		this.BPMBNNJMINL().FMGBIHDGKBI();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(false);
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("SaveButton", true);
	}

	// Token: 0x0600D6F9 RID: 55033 RVA: 0x004CA920 File Offset: 0x004C8B20
	private void PAHNLCPOGCH()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1234f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1018f)
			{
				vector.x = 1347f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1223f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA(false);
		}
	}

	// Token: 0x0600D6FA RID: 55034 RVA: 0x004CAA28 File Offset: 0x004C8C28
	private void JBCNIPJDPJB()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(this.PIANIMBGNEG());
		}
	}

	// Token: 0x0600D6FB RID: 55035 RVA: 0x004CAA90 File Offset: 0x004C8C90
	private void KGPJACPLNEK()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1292f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D6FC RID: 55036 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent PCCANFLFPJD()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D6FD RID: 55037 RVA: 0x004CAAF4 File Offset: 0x004C8CF4
	private void LEAHIBJDMBI()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(this.POPOCHKFGIM());
		}
	}

	// Token: 0x0600D6FE RID: 55038 RVA: 0x004CAB5A File Offset: 0x004C8D5A
	private void CPDIDLOJGIN()
	{
		this.GKEAKHFGHHH().UpdateEvent();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(false);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Tab2Content", true);
	}

	// Token: 0x0600D6FF RID: 55039 RVA: 0x004CAB84 File Offset: 0x004C8D84
	private void BMNOHLNANIP()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.ECGGFGJJOEL());
		}
	}

	// Token: 0x0600D700 RID: 55040 RVA: 0x004CABEC File Offset: 0x004C8DEC
	private void OnMouseDrag()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 0.01f)
			{
				vector.x = 0.01f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 0f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	// Token: 0x0600D701 RID: 55041 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent JJPCJPPPOLF()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D702 RID: 55042 RVA: 0x004CACF4 File Offset: 0x004C8EF4
	private void BGFJOEPFOPM()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.LJABCHJFAAA());
		}
	}

	// Token: 0x0600D703 RID: 55043 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent JCKAGIDMKFN()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D704 RID: 55044 RVA: 0x004CAD5C File Offset: 0x004C8F5C
	private void BFGIMALGMAJ()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.HBNKOCHGKBI());
		}
	}

	// Token: 0x0600D705 RID: 55045 RVA: 0x004CADC2 File Offset: 0x004C8FC2
	private void PCHCOGMLIJN()
	{
		this.FMHIJJNLJIE().NJDJHMPAIFE();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(true);
		Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("Tab2Content", false);
	}

	// Token: 0x0600D706 RID: 55046 RVA: 0x004CADEC File Offset: 0x004C8FEC
	private void MECJHOJPODB()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.HFAMJIHOJCH());
		}
	}

	// Token: 0x0600D707 RID: 55047 RVA: 0x004CAE54 File Offset: 0x004C9054
	private void HLDFOJMHKNL()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(this.NMEPOAEPNFM());
		}
	}

	// Token: 0x0600D708 RID: 55048 RVA: 0x004CAEBC File Offset: 0x004C90BC
	private void EIIDKPHBOLM()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1238f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 810f)
			{
				vector.x = 1192f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 670f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(false);
		}
	}

	// Token: 0x0600D709 RID: 55049 RVA: 0x004CAFC4 File Offset: 0x004C91C4
	private void LCHBFNIPBHB()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.PHFOIIGIBFN());
		}
	}

	// Token: 0x0600D70A RID: 55050 RVA: 0x004CB02C File Offset: 0x004C922C
	private void OKEHGHNHJFJ()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1415f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D70B RID: 55051 RVA: 0x004CB090 File Offset: 0x004C9290
	private void HNOGGFCINIJ()
	{
		this.PHFOIIGIBFN().KJJODHJJEOH();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().JHGKNFJBKJD(true);
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("#FFDA44CC", false);
	}

	// Token: 0x0600D70C RID: 55052 RVA: 0x004CB0B8 File Offset: 0x004C92B8
	private void ABOJLAKEHOI()
	{
		this.PCCANFLFPJD().UpdateEvent();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(false);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Scrollbar", false);
	}

	// Token: 0x0600D70D RID: 55053 RVA: 0x004CB0E0 File Offset: 0x004C92E0
	private void MJNPIDGNJMK()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).PNIOEINKMOF(this.ECAMHMKKJPF());
		}
	}

	// Token: 0x0600D70E RID: 55054 RVA: 0x004CB148 File Offset: 0x004C9348
	private void PINALAPAPDD()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 345f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 978f)
			{
				vector.x = 1670f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1945f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA(true);
		}
	}

	// Token: 0x0600D70F RID: 55055 RVA: 0x004CB250 File Offset: 0x004C9450
	private void EJNPAAMMMIL()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1825f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D710 RID: 55056 RVA: 0x004CB2B4 File Offset: 0x004C94B4
	private void MOKPIANAFEJ()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1876f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 519f)
			{
				vector.x = 518f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 745f);
			((LevelEditorScene)Singleton<Scene>.Instance).FindNearestEvent(true);
		}
	}

	// Token: 0x0600D711 RID: 55057 RVA: 0x004CB3BC File Offset: 0x004C95BC
	private void JDOCNDBKJLB()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1467f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D712 RID: 55058 RVA: 0x004CB420 File Offset: 0x004C9620
	private void HEHPKMABGAJ()
	{
		this.JCKAGIDMKFN().FMGBIHDGKBI();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("Drop_Far", false);
	}

	// Token: 0x0600D713 RID: 55059 RVA: 0x004CB448 File Offset: 0x004C9648
	private void DNACNEMCJFA()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 525f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x0600D714 RID: 55060 RVA: 0x004CB4AC File Offset: 0x004C96AC
	private void KICGCKKEGPF()
	{
		this.HFAMJIHOJCH().KJJODHJJEOH();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("_Value", true);
	}

	// Token: 0x0600D715 RID: 55061 RVA: 0x004CB4D4 File Offset: 0x004C96D4
	private void OCMKCBBCEFG()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(0) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).MLIMHHINNPE(this.IJIJEKKMFEO());
		}
	}

	// Token: 0x0600D716 RID: 55062 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent DBJLJKDGOOF()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D717 RID: 55063 RVA: 0x004CB53C File Offset: 0x004C973C
	private void HFAEOGMPGIG()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 414f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 526f)
			{
				vector.x = 1142f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 500f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(false);
		}
	}

	// Token: 0x0600D718 RID: 55064 RVA: 0x004CB644 File Offset: 0x004C9844
	private void ONKDMMJPEMN()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit) && Input.GetMouseButton(1) && raycastHit.collider.gameObject == base.gameObject)
		{
			((LevelEditorScene)Singleton<Scene>.Instance).RemoveEvent(this.PCCANFLFPJD());
		}
	}

	// Token: 0x0600D719 RID: 55065 RVA: 0x004CB6AA File Offset: 0x004C98AA
	private void HLIOOCEPPLH()
	{
		this.HBNKOCHGKBI().UpdateEvent();
		UnityEngine.Object.FindObjectOfType<LevelEditorScene>().NGDDLPLEHHA(true);
		Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("isVisible", false);
	}

	// Token: 0x0600D71A RID: 55066 RVA: 0x004CB6D4 File Offset: 0x004C98D4
	private void AIEILPCFHHN()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 63f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1832f)
			{
				vector.x = 596f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 1150f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA(false);
		}
	}

	// Token: 0x0600D71B RID: 55067 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent PHFOIIGIBFN()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D71C RID: 55068 RVA: 0x004CB7DC File Offset: 0x004C99DC
	private void APEBKMGJMKI()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1129f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 488f)
			{
				vector.x = 554f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 312f);
			((LevelEditorScene)Singleton<Scene>.Instance).JHGKNFJBKJD(true);
		}
	}

	// Token: 0x0600D71D RID: 55069 RVA: 0x004CB8E4 File Offset: 0x004C9AE4
	private void KECFHJMDLLK()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1664f);
			Vector3 a = Camera.main.ScreenToWorldPoint(position);
			Vector3 vector = a + this.INLGAOLENMD;
			if (vector.x < 1114f)
			{
				vector.x = 1931f;
			}
			if (vector.x > ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[1].clip.length)
			{
				vector.x = ((LevelEditorScene)Singleton<Scene>.Instance).asampler.audioSources[0].clip.length;
			}
			this.dragObj.transform.position = new Vector3(vector.x, vector.y, 898f);
			((LevelEditorScene)Singleton<Scene>.Instance).NGDDLPLEHHA(false);
		}
	}

	// Token: 0x0600D71E RID: 55070 RVA: 0x004B8940 File Offset: 0x004B6B40
	public EditorEvent HFAMJIHOJCH()
	{
		if (base.gameObject.GetComponent<EditorEvent>())
		{
			return base.gameObject.GetComponent<EditorEvent>();
		}
		return base.gameObject.GetComponentInParent<EditorEvent>();
	}

	// Token: 0x0600D71F RID: 55071 RVA: 0x004CB9EC File Offset: 0x004C9BEC
	private void CJMPDPOPCNH()
	{
		if (this.dragEnabled)
		{
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 610f);
			this.INLGAOLENMD = this.dragObj.transform.position - Camera.main.ScreenToWorldPoint(position);
		}
	}

	// Token: 0x04001861 RID: 6241
	public GameObject dragObj;

	// Token: 0x04001862 RID: 6242
	public bool dragEnabled = true;

	// Token: 0x04001863 RID: 6243
	private Vector3 KAOOCILPJCN;

	// Token: 0x04001864 RID: 6244
	private Vector3 INLGAOLENMD;
}
