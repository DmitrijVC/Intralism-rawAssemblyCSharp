using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200029D RID: 669
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("UI/Extensions/Selection Box")]
	public class SelectionBox : MonoBehaviour
	{
		// Token: 0x0600A0FD RID: 41213 RVA: 0x003C36B4 File Offset: 0x003C18B4
		private void BHNOEHEJIFH()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			this.IJPPFHCFIHJ.gameObject.SetActive(true);
			this.GEMDHBEGEFH = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			if (!this.CHBKIHMJHOG(this.GEMDHBEGEFH))
			{
				this.EKOMMKBCKEC();
				return;
			}
			this.IJPPFHCFIHJ.anchoredPosition = this.GEMDHBEGEFH;
			MonoBehaviour[] array;
			if (this.KHDFNFGNPEK == null)
			{
				array = Object.FindObjectsOfType<MonoBehaviour>();
			}
			else
			{
				array = this.KHDFNFGNPEK;
			}
			List<IBoxSelectable> list = new List<IBoxSelectable>();
			foreach (MonoBehaviour monoBehaviour in array)
			{
				IBoxSelectable boxSelectable = monoBehaviour as IBoxSelectable;
				if (boxSelectable != null)
				{
					list.Add(boxSelectable);
					if (!Input.GetKey(KeyCode.LeftShift))
					{
						boxSelectable.selected = false;
					}
				}
			}
			this.OIIEBOFIGGH = list.ToArray();
			this.IECCCKDHMNL = this.OABAKMNNFHA();
		}

		// Token: 0x0600A0FE RID: 41214 RVA: 0x003C37BC File Offset: 0x003C19BC
		private Vector2 JAADADFEJJH(IBoxSelectable NHFCLJILACH)
		{
			RectTransform rectTransform = NHFCLJILACH.transform as RectTransform;
			if (rectTransform)
			{
				Camera cam = this.PEBAOKFLLPD(rectTransform);
				return RectTransformUtility.WorldToScreenPoint(cam, NHFCLJILACH.transform.position);
			}
			return Camera.main.WorldToScreenPoint(NHFCLJILACH.transform.position);
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x003C3814 File Offset: 0x003C1A14
		private void ALHGBCKIIIC()
		{
			if (this.IECCCKDHMNL == null)
			{
				return;
			}
			if (this.OIFDMONEMPH != null && this.IECCCKDHMNL.selected && this.IECCCKDHMNL.transform == this.OIFDMONEMPH.transform)
			{
				this.IECCCKDHMNL.selected = false;
				this.IECCCKDHMNL.preSelected = true;
			}
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x003C3880 File Offset: 0x003C1A80
		private void HACOEDCHKCP()
		{
			if (this.IECCCKDHMNL == null)
			{
				return;
			}
			if (this.OIFDMONEMPH != null && this.IECCCKDHMNL.selected && this.IECCCKDHMNL.transform == this.OIFDMONEMPH.transform)
			{
				this.IECCCKDHMNL.selected = false;
				this.IECCCKDHMNL.preSelected = false;
			}
		}

		// Token: 0x0600A101 RID: 41217 RVA: 0x003C38EC File Offset: 0x003C1AEC
		private void OAOPOKKDBGJ()
		{
			Image component = this.IJPPFHCFIHJ.GetComponent<Image>();
			component.color = this.color;
			component.sprite = this.art;
			this.GEMDHBEGEFH = Vector2.zero;
			this.IJPPFHCFIHJ.anchoredPosition = Vector2.zero;
			this.IJPPFHCFIHJ.sizeDelta = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMax = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMin = Vector2.zero;
			this.IJPPFHCFIHJ.pivot = Vector2.zero;
			this.IJPPFHCFIHJ.gameObject.SetActive(true);
		}

		// Token: 0x0600A102 RID: 41218 RVA: 0x003C398C File Offset: 0x003C1B8C
		private void HDJEHMHKJMF()
		{
			if (!Input.GetMouseButton(0) || !this.IJPPFHCFIHJ.gameObject.activeSelf)
			{
				return;
			}
			Vector2 a = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			Vector2 sizeDelta = a - this.GEMDHBEGEFH;
			Vector2 gemdhbegefh = this.GEMDHBEGEFH;
			if (sizeDelta.x < 0f)
			{
				gemdhbegefh.x = a.x;
				sizeDelta.x = -sizeDelta.x;
			}
			if (sizeDelta.y < 0f)
			{
				gemdhbegefh.y = a.y;
				sizeDelta.y = -sizeDelta.y;
			}
			this.IJPPFHCFIHJ.anchoredPosition = gemdhbegefh;
			this.IJPPFHCFIHJ.sizeDelta = sizeDelta;
			foreach (IBoxSelectable boxSelectable in this.OIIEBOFIGGH)
			{
				Vector3 v = this.CCMHLLKDFKA(boxSelectable);
				boxSelectable.preSelected = (RectTransformUtility.RectangleContainsScreenPoint(this.IJPPFHCFIHJ, v, null) && this.CHBKIHMJHOG(v));
			}
			if (this.IECCCKDHMNL != null)
			{
				this.IECCCKDHMNL.preSelected = true;
			}
		}

		// Token: 0x0600A103 RID: 41219 RVA: 0x003C3AE4 File Offset: 0x003C1CE4
		private void AENAFCKHDIN()
		{
			if (!Input.GetMouseButtonUp(1) || !this.IJPPFHCFIHJ.gameObject.activeSelf)
			{
				return;
			}
			this.OIFDMONEMPH = this.OABAKMNNFHA();
			this.KLBKDLGPBJK();
			this.DMFDIPNIHEM();
			this.PMBNLGLILGF();
			this.onSelectionChange.Invoke(this.KADOEEOLGFN());
		}

		// Token: 0x0600A104 RID: 41220 RVA: 0x003C3B44 File Offset: 0x003C1D44
		private void JHIBKDIFJFF()
		{
			Image component = this.IJPPFHCFIHJ.GetComponent<Image>();
			component.color = this.color;
			component.sprite = this.art;
			this.GEMDHBEGEFH = Vector2.zero;
			this.IJPPFHCFIHJ.anchoredPosition = Vector2.zero;
			this.IJPPFHCFIHJ.sizeDelta = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMax = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMin = Vector2.zero;
			this.IJPPFHCFIHJ.pivot = Vector2.zero;
			this.IJPPFHCFIHJ.gameObject.SetActive(true);
		}

		// Token: 0x0600A105 RID: 41221 RVA: 0x003C3BE4 File Offset: 0x003C1DE4
		private void KOODEADIDOP()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			this.IJPPFHCFIHJ.gameObject.SetActive(true);
			this.GEMDHBEGEFH = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			if (!this.CPGJEGEJKAN(this.GEMDHBEGEFH))
			{
				this.HPPNDMHDMAG();
				return;
			}
			this.IJPPFHCFIHJ.anchoredPosition = this.GEMDHBEGEFH;
			MonoBehaviour[] array;
			if (this.KHDFNFGNPEK == null)
			{
				array = Object.FindObjectsOfType<MonoBehaviour>();
			}
			else
			{
				array = this.KHDFNFGNPEK;
			}
			List<IBoxSelectable> list = new List<IBoxSelectable>();
			foreach (MonoBehaviour monoBehaviour in array)
			{
				IBoxSelectable boxSelectable = monoBehaviour as IBoxSelectable;
				if (boxSelectable != null)
				{
					list.Add(boxSelectable);
					if (!Input.GetKey((KeyCode)(-182)))
					{
						boxSelectable.selected = true;
					}
				}
			}
			this.OIIEBOFIGGH = list.ToArray();
			this.IECCCKDHMNL = this.MPGFEAKDKBE();
		}

		// Token: 0x0600A106 RID: 41222 RVA: 0x003C3CEC File Offset: 0x003C1EEC
		private bool CPGJEGEJKAN(Vector2 KAOOCILPJCN)
		{
			if (!this.selectionMask)
			{
				return false;
			}
			Camera cam = this.PEBAOKFLLPD(this.selectionMask);
			return RectTransformUtility.RectangleContainsScreenPoint(this.selectionMask, KAOOCILPJCN, cam);
		}

		// Token: 0x0600A107 RID: 41223 RVA: 0x003C3D28 File Offset: 0x003C1F28
		private Vector2 CCMHLLKDFKA(IBoxSelectable NHFCLJILACH)
		{
			RectTransform rectTransform = NHFCLJILACH.transform as RectTransform;
			if (rectTransform)
			{
				Camera cam = this.PEBAOKFLLPD(rectTransform);
				return RectTransformUtility.WorldToScreenPoint(cam, NHFCLJILACH.transform.position);
			}
			return Camera.main.WorldToScreenPoint(NHFCLJILACH.transform.position);
		}

		// Token: 0x0600A108 RID: 41224 RVA: 0x003C3D80 File Offset: 0x003C1F80
		private void KEEPAMPBGHL()
		{
			if (!Input.GetMouseButtonUp(0) || !this.IJPPFHCFIHJ.gameObject.activeSelf)
			{
				return;
			}
			this.OIFDMONEMPH = this.JCJPJNOELOI();
			this.HACOEDCHKCP();
			this.DMFDIPNIHEM();
			this.OAOPOKKDBGJ();
			this.onSelectionChange.Invoke(this.KADOEEOLGFN());
		}

		// Token: 0x0600A109 RID: 41225 RVA: 0x003C3DDD File Offset: 0x003C1FDD
		private void Start()
		{
			this.MKANEFACBOC();
			this.JLFOJABEJNP();
			this.EKOMMKBCKEC();
		}

		// Token: 0x0600A10B RID: 41227 RVA: 0x003C3E04 File Offset: 0x003C2004
		private void DIPDEHOOBPG()
		{
			this.BPPEAHBGFCL();
			this.JLFOJABEJNP();
			this.HPPNDMHDMAG();
		}

		// Token: 0x0600A10C RID: 41228 RVA: 0x003C3E18 File Offset: 0x003C2018
		private void EKBNFHJGBKJ()
		{
			Image component = this.IJPPFHCFIHJ.GetComponent<Image>();
			component.color = this.color;
			component.sprite = this.art;
			this.GEMDHBEGEFH = Vector2.zero;
			this.IJPPFHCFIHJ.anchoredPosition = Vector2.zero;
			this.IJPPFHCFIHJ.sizeDelta = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMax = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMin = Vector2.zero;
			this.IJPPFHCFIHJ.pivot = Vector2.zero;
			this.IJPPFHCFIHJ.gameObject.SetActive(true);
		}

		// Token: 0x0600A10D RID: 41229 RVA: 0x003C3EB8 File Offset: 0x003C20B8
		private void KLBKDLGPBJK()
		{
			if (this.IECCCKDHMNL == null)
			{
				return;
			}
			if (this.OIFDMONEMPH != null && this.IECCCKDHMNL.selected && this.IECCCKDHMNL.transform == this.OIFDMONEMPH.transform)
			{
				this.IECCCKDHMNL.selected = false;
				this.IECCCKDHMNL.preSelected = true;
			}
		}

		// Token: 0x0600A10E RID: 41230 RVA: 0x003C3F24 File Offset: 0x003C2124
		private void FPNNILCDLMD()
		{
			if (!Input.GetMouseButtonUp(1) || !this.IJPPFHCFIHJ.gameObject.activeSelf)
			{
				return;
			}
			this.OIFDMONEMPH = this.OABAKMNNFHA();
			this.KLBKDLGPBJK();
			this.DMFDIPNIHEM();
			this.JHIBKDIFJFF();
			this.onSelectionChange.Invoke(this.GetAllSelected());
		}

		// Token: 0x0600A10F RID: 41231 RVA: 0x003C3F84 File Offset: 0x003C2184
		private IBoxSelectable JCJPJNOELOI()
		{
			if (!this.CPGJEGEJKAN(Input.mousePosition))
			{
				return null;
			}
			IBoxSelectable[] oiiebofiggh = this.OIIEBOFIGGH;
			for (int i = 1; i < oiiebofiggh.Length; i++)
			{
				IBoxSelectable boxSelectable = oiiebofiggh[i];
				RectTransform rectTransform = boxSelectable.transform as RectTransform;
				if (rectTransform)
				{
					Camera cam = this.PEBAOKFLLPD(rectTransform);
					if (RectTransformUtility.RectangleContainsScreenPoint(rectTransform, Input.mousePosition, cam))
					{
						return boxSelectable;
					}
				}
				else
				{
					float magnitude = boxSelectable.transform.GetComponent<Renderer>().bounds.extents.magnitude;
					Vector2 a = this.JAADADFEJJH(boxSelectable);
					if (Vector2.Distance(a, Input.mousePosition) <= magnitude)
					{
						return boxSelectable;
					}
				}
			}
			return null;
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x003C4050 File Offset: 0x003C2250
		private Camera PEBAOKFLLPD(RectTransform KPEGABCNLKE)
		{
			RectTransform rectTransform = KPEGABCNLKE;
			Canvas canvas;
			do
			{
				canvas = rectTransform.GetComponent<Canvas>();
				if (canvas && !canvas.isRootCanvas)
				{
					canvas = null;
				}
				rectTransform = (RectTransform)rectTransform.parent;
			}
			while (canvas == null);
			switch (canvas.renderMode)
			{
			case RenderMode.ScreenSpaceOverlay:
				return null;
			case RenderMode.ScreenSpaceCamera:
				return (!canvas.worldCamera) ? Camera.main : canvas.worldCamera;
			}
			return Camera.main;
		}

		// Token: 0x0600A111 RID: 41233 RVA: 0x003C40DE File Offset: 0x003C22DE
		private void MMBPLGGLPDB()
		{
			this.KOODEADIDOP();
			this.HDJEHMHKJMF();
			this.FPNNILCDLMD();
		}

		// Token: 0x0600A112 RID: 41234 RVA: 0x003C40F4 File Offset: 0x003C22F4
		private bool CHBKIHMJHOG(Vector2 KAOOCILPJCN)
		{
			if (!this.selectionMask)
			{
				return true;
			}
			Camera cam = this.PEBAOKFLLPD(this.selectionMask);
			return RectTransformUtility.RectangleContainsScreenPoint(this.selectionMask, KAOOCILPJCN, cam);
		}

		// Token: 0x0600A113 RID: 41235 RVA: 0x003C4130 File Offset: 0x003C2330
		private void MKANEFACBOC()
		{
			Canvas component = base.gameObject.GetComponent<Canvas>();
			if (component.renderMode != RenderMode.ScreenSpaceOverlay)
			{
				throw new Exception("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.");
			}
			CanvasScaler component2 = base.gameObject.GetComponent<CanvasScaler>();
			if (component2 && component2.enabled && (!Mathf.Approximately(component2.scaleFactor, 1f) || component2.uiScaleMode != CanvasScaler.ScaleMode.ConstantPixelSize))
			{
				Object.Destroy(component2);
				Debug.LogWarning("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.");
			}
		}

		// Token: 0x0600A114 RID: 41236 RVA: 0x003C41B4 File Offset: 0x003C23B4
		private void APPDGMKHBLE()
		{
			if (!Input.GetMouseButtonUp(1) || !this.IJPPFHCFIHJ.gameObject.activeSelf)
			{
				return;
			}
			this.OIFDMONEMPH = this.OABAKMNNFHA();
			this.HDMHCMPEIGJ();
			this.DMFDIPNIHEM();
			this.JHIBKDIFJFF();
			this.onSelectionChange.Invoke(this.GetAllSelected());
		}

		// Token: 0x0600A115 RID: 41237 RVA: 0x003C4214 File Offset: 0x003C2414
		private Vector2 PBDLNOHIHII(IBoxSelectable NHFCLJILACH)
		{
			RectTransform rectTransform = NHFCLJILACH.transform as RectTransform;
			if (rectTransform)
			{
				Camera cam = this.PEBAOKFLLPD(rectTransform);
				return RectTransformUtility.WorldToScreenPoint(cam, NHFCLJILACH.transform.position);
			}
			return Camera.main.WorldToScreenPoint(NHFCLJILACH.transform.position);
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x003C426C File Offset: 0x003C246C
		private void CBOBJLHBKLC()
		{
			if (!Input.GetMouseButtonUp(0) || !this.IJPPFHCFIHJ.gameObject.activeSelf)
			{
				return;
			}
			this.OIFDMONEMPH = this.OABAKMNNFHA();
			this.HACOEDCHKCP();
			this.DMFDIPNIHEM();
			this.EKOMMKBCKEC();
			this.onSelectionChange.Invoke(this.GetAllSelected());
		}

		// Token: 0x0600A117 RID: 41239 RVA: 0x003C42CC File Offset: 0x003C24CC
		private void HPPNDMHDMAG()
		{
			Image component = this.IJPPFHCFIHJ.GetComponent<Image>();
			component.color = this.color;
			component.sprite = this.art;
			this.GEMDHBEGEFH = Vector2.zero;
			this.IJPPFHCFIHJ.anchoredPosition = Vector2.zero;
			this.IJPPFHCFIHJ.sizeDelta = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMax = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMin = Vector2.zero;
			this.IJPPFHCFIHJ.pivot = Vector2.zero;
			this.IJPPFHCFIHJ.gameObject.SetActive(false);
		}

		// Token: 0x0600A118 RID: 41240 RVA: 0x003C436C File Offset: 0x003C256C
		private void MCOJCDIDPKB(IEnumerable<MonoBehaviour> NDOKEDMMBBM)
		{
			if (NDOKEDMMBBM == null)
			{
				this.KHDFNFGNPEK = null;
				return;
			}
			List<MonoBehaviour> list = new List<MonoBehaviour>();
			foreach (MonoBehaviour monoBehaviour in NDOKEDMMBBM)
			{
				if (monoBehaviour is IBoxSelectable)
				{
					list.Add(monoBehaviour);
				}
			}
			this.KHDFNFGNPEK = list.ToArray();
		}

		// Token: 0x0600A119 RID: 41241 RVA: 0x003C43EC File Offset: 0x003C25EC
		private void JLFOJABEJNP()
		{
			GameObject gameObject = new GameObject();
			gameObject.name = "Selection Box";
			gameObject.transform.parent = base.transform;
			gameObject.AddComponent<Image>();
			this.IJPPFHCFIHJ = (gameObject.transform as RectTransform);
		}

		// Token: 0x0600A11A RID: 41242 RVA: 0x003C4434 File Offset: 0x003C2634
		private void EKOMMKBCKEC()
		{
			Image component = this.IJPPFHCFIHJ.GetComponent<Image>();
			component.color = this.color;
			component.sprite = this.art;
			this.GEMDHBEGEFH = Vector2.zero;
			this.IJPPFHCFIHJ.anchoredPosition = Vector2.zero;
			this.IJPPFHCFIHJ.sizeDelta = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMax = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMin = Vector2.zero;
			this.IJPPFHCFIHJ.pivot = Vector2.zero;
			this.IJPPFHCFIHJ.gameObject.SetActive(false);
		}

		// Token: 0x0600A11B RID: 41243 RVA: 0x003C44D4 File Offset: 0x003C26D4
		public IBoxSelectable[] KADOEEOLGFN()
		{
			if (this.OIIEBOFIGGH == null)
			{
				return new IBoxSelectable[0];
			}
			List<IBoxSelectable> list = new List<IBoxSelectable>();
			IBoxSelectable[] oiiebofiggh = this.OIIEBOFIGGH;
			for (int i = 0; i < oiiebofiggh.Length; i += 0)
			{
				IBoxSelectable boxSelectable = oiiebofiggh[i];
				if (boxSelectable.selected)
				{
					list.Add(boxSelectable);
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600A11C RID: 41244 RVA: 0x003C4530 File Offset: 0x003C2730
		private void AFIMONDAKPB()
		{
			Canvas component = base.gameObject.GetComponent<Canvas>();
			if (component.renderMode != RenderMode.ScreenSpaceOverlay)
			{
				throw new Exception("_TimeX");
			}
			CanvasScaler component2 = base.gameObject.GetComponent<CanvasScaler>();
			if (component2 && component2.enabled && (!Mathf.Approximately(component2.scaleFactor, 1625f) || component2.uiScaleMode != CanvasScaler.ScaleMode.ConstantPixelSize))
			{
				Object.Destroy(component2);
				Debug.LogWarning("_Value3");
			}
		}

		// Token: 0x0600A11D RID: 41245 RVA: 0x003C45B4 File Offset: 0x003C27B4
		private void PMBNLGLILGF()
		{
			Image component = this.IJPPFHCFIHJ.GetComponent<Image>();
			component.color = this.color;
			component.sprite = this.art;
			this.GEMDHBEGEFH = Vector2.zero;
			this.IJPPFHCFIHJ.anchoredPosition = Vector2.zero;
			this.IJPPFHCFIHJ.sizeDelta = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMax = Vector2.zero;
			this.IJPPFHCFIHJ.anchorMin = Vector2.zero;
			this.IJPPFHCFIHJ.pivot = Vector2.zero;
			this.IJPPFHCFIHJ.gameObject.SetActive(true);
		}

		// Token: 0x0600A11E RID: 41246 RVA: 0x003C4651 File Offset: 0x003C2851
		private void Update()
		{
			this.BHNOEHEJIFH();
			this.HDJEHMHKJMF();
			this.CBOBJLHBKLC();
		}

		// Token: 0x0600A11F RID: 41247 RVA: 0x003C4668 File Offset: 0x003C2868
		private void DMFDIPNIHEM()
		{
			foreach (IBoxSelectable boxSelectable in this.OIIEBOFIGGH)
			{
				if (boxSelectable.preSelected)
				{
					boxSelectable.selected = true;
					boxSelectable.preSelected = false;
				}
			}
		}

		// Token: 0x0600A120 RID: 41248 RVA: 0x003C46B0 File Offset: 0x003C28B0
		private IBoxSelectable MPGFEAKDKBE()
		{
			if (!this.CHBKIHMJHOG(Input.mousePosition))
			{
				return null;
			}
			IBoxSelectable[] oiiebofiggh = this.OIIEBOFIGGH;
			for (int i = 1; i < oiiebofiggh.Length; i++)
			{
				IBoxSelectable boxSelectable = oiiebofiggh[i];
				RectTransform rectTransform = boxSelectable.transform as RectTransform;
				if (rectTransform)
				{
					Camera cam = this.PEBAOKFLLPD(rectTransform);
					if (RectTransformUtility.RectangleContainsScreenPoint(rectTransform, Input.mousePosition, cam))
					{
						return boxSelectable;
					}
				}
				else
				{
					float magnitude = boxSelectable.transform.GetComponent<Renderer>().bounds.extents.magnitude;
					Vector2 a = this.PBDLNOHIHII(boxSelectable);
					if (Vector2.Distance(a, Input.mousePosition) <= magnitude)
					{
						return boxSelectable;
					}
				}
			}
			return null;
		}

		// Token: 0x0600A121 RID: 41249 RVA: 0x003C477C File Offset: 0x003C297C
		private IBoxSelectable OABAKMNNFHA()
		{
			if (!this.CHBKIHMJHOG(Input.mousePosition))
			{
				return null;
			}
			foreach (IBoxSelectable boxSelectable in this.OIIEBOFIGGH)
			{
				RectTransform rectTransform = boxSelectable.transform as RectTransform;
				if (rectTransform)
				{
					Camera cam = this.PEBAOKFLLPD(rectTransform);
					if (RectTransformUtility.RectangleContainsScreenPoint(rectTransform, Input.mousePosition, cam))
					{
						return boxSelectable;
					}
				}
				else
				{
					float magnitude = boxSelectable.transform.GetComponent<Renderer>().bounds.extents.magnitude;
					Vector2 a = this.CCMHLLKDFKA(boxSelectable);
					if (Vector2.Distance(a, Input.mousePosition) <= magnitude)
					{
						return boxSelectable;
					}
				}
			}
			return null;
		}

		// Token: 0x0600A122 RID: 41250 RVA: 0x003C4848 File Offset: 0x003C2A48
		private void DLKCJPIHNBJ()
		{
			if (!Input.GetMouseButton(1) || !this.IJPPFHCFIHJ.gameObject.activeSelf)
			{
				return;
			}
			Vector2 a = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			Vector2 sizeDelta = a - this.GEMDHBEGEFH;
			Vector2 gemdhbegefh = this.GEMDHBEGEFH;
			if (sizeDelta.x < 1479f)
			{
				gemdhbegefh.x = a.x;
				sizeDelta.x = -sizeDelta.x;
			}
			if (sizeDelta.y < 917f)
			{
				gemdhbegefh.y = a.y;
				sizeDelta.y = -sizeDelta.y;
			}
			this.IJPPFHCFIHJ.anchoredPosition = gemdhbegefh;
			this.IJPPFHCFIHJ.sizeDelta = sizeDelta;
			foreach (IBoxSelectable boxSelectable in this.OIIEBOFIGGH)
			{
				Vector3 v = this.PBDLNOHIHII(boxSelectable);
				boxSelectable.preSelected = (RectTransformUtility.RectangleContainsScreenPoint(this.IJPPFHCFIHJ, v, null) && this.CHBKIHMJHOG(v));
			}
			if (this.IECCCKDHMNL != null)
			{
				this.IECCCKDHMNL.preSelected = true;
			}
		}

		// Token: 0x0600A123 RID: 41251 RVA: 0x003C49A0 File Offset: 0x003C2BA0
		private void BPPEAHBGFCL()
		{
			Canvas component = base.gameObject.GetComponent<Canvas>();
			if (component.renderMode != RenderMode.ScreenSpaceOverlay)
			{
				throw new Exception("_Value");
			}
			CanvasScaler component2 = base.gameObject.GetComponent<CanvasScaler>();
			if (component2 && component2.enabled && (!Mathf.Approximately(component2.scaleFactor, 1783f) || component2.uiScaleMode != CanvasScaler.ScaleMode.ConstantPixelSize))
			{
				Object.Destroy(component2);
				Debug.LogWarning("_ScreenResolution");
			}
		}

		// Token: 0x0600A124 RID: 41252 RVA: 0x003C4A21 File Offset: 0x003C2C21
		private void DNNFHBOOPIN()
		{
			this.MKANEFACBOC();
			this.JLFOJABEJNP();
			this.PMBNLGLILGF();
		}

		// Token: 0x0600A125 RID: 41253 RVA: 0x003C4A38 File Offset: 0x003C2C38
		public IBoxSelectable[] GetAllSelected()
		{
			if (this.OIIEBOFIGGH == null)
			{
				return new IBoxSelectable[0];
			}
			List<IBoxSelectable> list = new List<IBoxSelectable>();
			foreach (IBoxSelectable boxSelectable in this.OIIEBOFIGGH)
			{
				if (boxSelectable.selected)
				{
					list.Add(boxSelectable);
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600A126 RID: 41254 RVA: 0x003C4A94 File Offset: 0x003C2C94
		private void HDMHCMPEIGJ()
		{
			if (this.IECCCKDHMNL == null)
			{
				return;
			}
			if (this.OIFDMONEMPH != null && this.IECCCKDHMNL.selected && this.IECCCKDHMNL.transform == this.OIFDMONEMPH.transform)
			{
				this.IECCCKDHMNL.selected = false;
				this.IECCCKDHMNL.preSelected = true;
			}
		}

		// Token: 0x0400124C RID: 4684
		public Color color;

		// Token: 0x0400124D RID: 4685
		public Sprite art;

		// Token: 0x0400124E RID: 4686
		private Vector2 GEMDHBEGEFH;

		// Token: 0x0400124F RID: 4687
		public RectTransform selectionMask;

		// Token: 0x04001250 RID: 4688
		private RectTransform IJPPFHCFIHJ;

		// Token: 0x04001251 RID: 4689
		private IBoxSelectable[] OIIEBOFIGGH;

		// Token: 0x04001252 RID: 4690
		private MonoBehaviour[] KHDFNFGNPEK;

		// Token: 0x04001253 RID: 4691
		private IBoxSelectable IECCCKDHMNL;

		// Token: 0x04001254 RID: 4692
		private IBoxSelectable OIFDMONEMPH;

		// Token: 0x04001255 RID: 4693
		public SelectionBox.SelectionEvent onSelectionChange = new SelectionBox.SelectionEvent();

		// Token: 0x0200029E RID: 670
		public class SelectionEvent : UnityEvent<IBoxSelectable[]>
		{
		}
	}
}
