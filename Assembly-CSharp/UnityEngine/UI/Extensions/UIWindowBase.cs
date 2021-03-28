using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002A5 RID: 677
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Extensions/UI Window Base")]
	public class UIWindowBase : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IEventSystemHandler
	{
		// Token: 0x0600A383 RID: 41859 RVA: 0x003D6465 File Offset: 0x003D4665
		public void PBNAADCFJEJ(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x003D6465 File Offset: 0x003D4665
		public void CHFGACLKMIG(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x003D646E File Offset: 0x003D466E
		private void CAKBOMDEBGL()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = true;
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x003D6487 File Offset: 0x003D4687
		private void BGDPIHMAACO()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x003D64C4 File Offset: 0x003D46C4
		private Vector3 PFJFAIEMJPN(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceCamera && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("Is it practically possible?");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A388 RID: 41864 RVA: 0x003D662E File Offset: 0x003D482E
		private void LJIHHJOAJCN()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.NDBOHPODBEM();
			}
		}

		// Token: 0x0600A389 RID: 41865 RVA: 0x003D646E File Offset: 0x003D466E
		private void NNMLBLFHCDC()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = true;
		}

		// Token: 0x0600A38A RID: 41866 RVA: 0x003D6487 File Offset: 0x003D4687
		private void JOPCCCCHNLI()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A38B RID: 41867 RVA: 0x003D6640 File Offset: 0x003D4840
		private void BGFJOEPFOPM()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.PKKEJKEEIJH();
			}
		}

		// Token: 0x0600A38C RID: 41868 RVA: 0x003D6652 File Offset: 0x003D4852
		private void LCANKPPGBCM()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = false;
		}

		// Token: 0x0600A38D RID: 41869 RVA: 0x003D6465 File Offset: 0x003D4665
		public void IKENMCHKHKM(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A38E RID: 41870 RVA: 0x003D666C File Offset: 0x003D486C
		public void OnDrag(PointerEventData OLIIPKODDIN)
		{
			if (this.NDGBBDKAJEN)
			{
				Vector3 b = this.PFJFAIEMJPN(OLIIPKODDIN.position) - this.PFJFAIEMJPN(OLIIPKODDIN.position - OLIIPKODDIN.delta);
				this.EEFEMMFGDAG.localPosition += b;
			}
		}

		// Token: 0x0600A38F RID: 41871 RVA: 0x003D66D0 File Offset: 0x003D48D0
		private Vector3 GCANCAMANKA(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("_Colored");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A390 RID: 41872 RVA: 0x003D6487 File Offset: 0x003D4687
		private void ILCFPCIPENO()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A391 RID: 41873 RVA: 0x003D683C File Offset: 0x003D4A3C
		public void MJJPDAHKGPN(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject == null)
			{
				return;
			}
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject.name == base.name)
			{
				this.NDGBBDKAJEN = true;
			}
		}

		// Token: 0x0600A392 RID: 41874 RVA: 0x003D6652 File Offset: 0x003D4852
		private void MJMMNKBAAJD()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = false;
		}

		// Token: 0x0600A393 RID: 41875 RVA: 0x003D6890 File Offset: 0x003D4A90
		public void LGACGLHLGKL(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject == null)
			{
				return;
			}
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject.name == base.name)
			{
				this.NDGBBDKAJEN = false;
			}
		}

		// Token: 0x0600A394 RID: 41876 RVA: 0x003D68E4 File Offset: 0x003D4AE4
		private Vector3 IKPKEKPJBJN(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception(" (");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A395 RID: 41877 RVA: 0x003D6652 File Offset: 0x003D4852
		private void EJHHAJPLGAF()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = false;
		}

		// Token: 0x0600A396 RID: 41878 RVA: 0x003D6A4E File Offset: 0x003D4C4E
		public void DBDAKJEPJID(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x0600A397 RID: 41879 RVA: 0x003D6487 File Offset: 0x003D4687
		private void FDNONDCGGCG()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A398 RID: 41880 RVA: 0x003D6A4E File Offset: 0x003D4C4E
		public void MOOECPLMJBG(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x0600A399 RID: 41881 RVA: 0x003D646E File Offset: 0x003D466E
		private void KJHOPIOBENJ()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = true;
		}

		// Token: 0x0600A39A RID: 41882 RVA: 0x003D6A57 File Offset: 0x003D4C57
		private void GPFJMKCGHGB()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.OBPMHAIOGEM();
			}
		}

		// Token: 0x0600A39B RID: 41883 RVA: 0x003D6A4E File Offset: 0x003D4C4E
		public void HEFBIFIBBNI(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x0600A39C RID: 41884 RVA: 0x003D6640 File Offset: 0x003D4840
		private void PFNFPINPCMH()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.PKKEJKEEIJH();
			}
		}

		// Token: 0x0600A39D RID: 41885 RVA: 0x003D6A69 File Offset: 0x003D4C69
		private void LBIOIEANMGI()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.NMKGLCCKMAF();
			}
		}

		// Token: 0x0600A39E RID: 41886 RVA: 0x003D6A4E File Offset: 0x003D4C4E
		public void CAOEDPKHNEE(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x0600A39F RID: 41887 RVA: 0x003D6A7C File Offset: 0x003D4C7C
		public void NGEEOJPIHAG(PointerEventData OLIIPKODDIN)
		{
			if (this.NDGBBDKAJEN)
			{
				Vector3 b = this.MBPDKDJLMDL(OLIIPKODDIN.position) - this.FCAHICLFDAO(OLIIPKODDIN.position - OLIIPKODDIN.delta);
				this.EEFEMMFGDAG.localPosition += b;
			}
		}

		// Token: 0x0600A3A0 RID: 41888 RVA: 0x003D6465 File Offset: 0x003D4665
		public void OnEndDrag(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A3A1 RID: 41889 RVA: 0x003D6487 File Offset: 0x003D4687
		private void CIPKEPDELJB()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A3A2 RID: 41890 RVA: 0x003D6465 File Offset: 0x003D4665
		public void FHDADIFDFFO(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x003D6487 File Offset: 0x003D4687
		private void BMIOFJFMCBG()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A3A4 RID: 41892 RVA: 0x003D6465 File Offset: 0x003D4665
		public void CHDIDJFMOME(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A3A5 RID: 41893 RVA: 0x003D6AE0 File Offset: 0x003D4CE0
		private Vector3 FCAHICLFDAO(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceCamera && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("Map: ");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A3A6 RID: 41894 RVA: 0x003D6C4C File Offset: 0x003D4E4C
		private Vector3 IIEAEBCIDKH(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceCamera && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("_TimeX");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A3A7 RID: 41895 RVA: 0x003D6465 File Offset: 0x003D4665
		public void ENKHGEKPKOL(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x003D6487 File Offset: 0x003D4687
		private void Start()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A3A9 RID: 41897 RVA: 0x003D6DB8 File Offset: 0x003D4FB8
		public void IJJAAOOBFEE(PointerEventData OLIIPKODDIN)
		{
			if (this.NDGBBDKAJEN)
			{
				Vector3 b = this.IKPKEKPJBJN(OLIIPKODDIN.position) - this.AMMHIDPOKBK(OLIIPKODDIN.position - OLIIPKODDIN.delta);
				this.EEFEMMFGDAG.localPosition += b;
			}
		}

		// Token: 0x0600A3AB RID: 41899 RVA: 0x003D6E1A File Offset: 0x003D501A
		private void JOACBIEHHCE()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.ICJAGOHCJKG();
			}
		}

		// Token: 0x0600A3AC RID: 41900 RVA: 0x003D6652 File Offset: 0x003D4852
		private void IPPPLLDFKFC()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = false;
		}

		// Token: 0x0600A3AD RID: 41901 RVA: 0x003D6487 File Offset: 0x003D4687
		private void HIPEHGNBJMN()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A3AE RID: 41902 RVA: 0x003D6E2C File Offset: 0x003D502C
		private void KCDOMIJBFLL()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.EJLLKLODDBF();
			}
		}

		// Token: 0x0600A3AF RID: 41903 RVA: 0x003D6E40 File Offset: 0x003D5040
		public void PDDLKDGBEBH(PointerEventData OLIIPKODDIN)
		{
			if (this.NDGBBDKAJEN)
			{
				Vector3 b = this.LJIPMLENJFN(OLIIPKODDIN.position) - this.LFONPMBGMEA(OLIIPKODDIN.position - OLIIPKODDIN.delta);
				this.EEFEMMFGDAG.localPosition += b;
			}
		}

		// Token: 0x0600A3B0 RID: 41904 RVA: 0x003D6EA4 File Offset: 0x003D50A4
		public void BPFLEOPNLJK(PointerEventData OLIIPKODDIN)
		{
			if (this.NDGBBDKAJEN)
			{
				Vector3 b = this.AMMHIDPOKBK(OLIIPKODDIN.position) - this.KBGNNHPPDFJ(OLIIPKODDIN.position - OLIIPKODDIN.delta);
				this.EEFEMMFGDAG.localPosition += b;
			}
		}

		// Token: 0x0600A3B1 RID: 41905 RVA: 0x003D6F08 File Offset: 0x003D5108
		public void OnBeginDrag(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject == null)
			{
				return;
			}
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject.name == base.name)
			{
				this.NDGBBDKAJEN = true;
			}
		}

		// Token: 0x0600A3B2 RID: 41906 RVA: 0x003D646E File Offset: 0x003D466E
		private void OCIMFODABAO()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = true;
		}

		// Token: 0x0600A3B3 RID: 41907 RVA: 0x003D6487 File Offset: 0x003D4687
		private void DNNFHBOOPIN()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A3B4 RID: 41908 RVA: 0x003D6E1A File Offset: 0x003D501A
		private void HLDFOJMHKNL()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.ICJAGOHCJKG();
			}
		}

		// Token: 0x0600A3B5 RID: 41909 RVA: 0x003D646E File Offset: 0x003D466E
		private void ICJAGOHCJKG()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = true;
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x003D6F59 File Offset: 0x003D5159
		private void DDBOODLPCAM()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.CJGIIDMEICB();
			}
		}

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x003D6F6C File Offset: 0x003D516C
		public void HEDOKPEHCKE(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject == null)
			{
				return;
			}
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject.name == base.name)
			{
				this.NDGBBDKAJEN = true;
			}
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x003D6FC0 File Offset: 0x003D51C0
		private Vector3 KBGNNHPPDFJ(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("3");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A3B9 RID: 41913 RVA: 0x003D6487 File Offset: 0x003D4687
		private void JHANGPCOCIG()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A3BA RID: 41914 RVA: 0x003D712A File Offset: 0x003D532A
		private void Update()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.IPPPLLDFKFC();
			}
		}

		// Token: 0x0600A3BB RID: 41915 RVA: 0x003D6652 File Offset: 0x003D4852
		private void GJANJMBPEAG()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = false;
		}

		// Token: 0x0600A3BC RID: 41916 RVA: 0x003D6A4E File Offset: 0x003D4C4E
		public void HPEAHCAPNDC(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x0600A3BD RID: 41917 RVA: 0x003D713C File Offset: 0x003D533C
		public void BPJBOILFGKB(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject == null)
			{
				return;
			}
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject.name == base.name)
			{
				this.NDGBBDKAJEN = false;
			}
		}

		// Token: 0x0600A3BE RID: 41918 RVA: 0x003D7190 File Offset: 0x003D5390
		private Vector3 BPEIAADMHLN(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("Hidden/ScreenSpaceReflection");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A3BF RID: 41919 RVA: 0x003D6A4E File Offset: 0x003D4C4E
		public void KIEGDCLCJIB(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x0600A3C0 RID: 41920 RVA: 0x003D646E File Offset: 0x003D466E
		private void NDBOHPODBEM()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = true;
		}

		// Token: 0x0600A3C1 RID: 41921 RVA: 0x003D646E File Offset: 0x003D466E
		private void PKKEJKEEIJH()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = true;
		}

		// Token: 0x0600A3C2 RID: 41922 RVA: 0x003D72FC File Offset: 0x003D54FC
		public void FNEMGJIABDO(PointerEventData OLIIPKODDIN)
		{
			if (this.NDGBBDKAJEN)
			{
				Vector3 b = this.FCAHICLFDAO(OLIIPKODDIN.position) - this.MBPDKDJLMDL(OLIIPKODDIN.position - OLIIPKODDIN.delta);
				this.EEFEMMFGDAG.localPosition += b;
			}
		}

		// Token: 0x0600A3C3 RID: 41923 RVA: 0x003D6465 File Offset: 0x003D4665
		public void FMFFGBNCJJD(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A3C4 RID: 41924 RVA: 0x003D6487 File Offset: 0x003D4687
		private void JMEOGJHCONJ()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A3C5 RID: 41925 RVA: 0x003D7360 File Offset: 0x003D5560
		private Vector3 AMMHIDPOKBK(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("white");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A3C6 RID: 41926 RVA: 0x003D74CA File Offset: 0x003D56CA
		private void LMBDNPLDGIJ()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.AMGJIDNADDN();
			}
		}

		// Token: 0x0600A3C7 RID: 41927 RVA: 0x003D6465 File Offset: 0x003D4665
		public void OHOECPEIBMI(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A3C8 RID: 41928 RVA: 0x003D6465 File Offset: 0x003D4665
		public void JNHGJEIBIAA(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x003D74DC File Offset: 0x003D56DC
		private void HPNNCNNFMGK()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.MJMMNKBAAJD();
			}
		}

		// Token: 0x0600A3CA RID: 41930 RVA: 0x003D74F0 File Offset: 0x003D56F0
		private Vector3 MBPDKDJLMDL(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("float,1.5");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A3CB RID: 41931 RVA: 0x003D765C File Offset: 0x003D585C
		private Vector3 LFONPMBGMEA(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceCamera && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("_Blue_C");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A3CC RID: 41932 RVA: 0x003D6652 File Offset: 0x003D4852
		private void NMKGLCCKMAF()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = false;
		}

		// Token: 0x0600A3CD RID: 41933 RVA: 0x003D77C8 File Offset: 0x003D59C8
		public void HFKDDAMLINH(PointerEventData OLIIPKODDIN)
		{
			if (this.NDGBBDKAJEN)
			{
				Vector3 b = this.KBGNNHPPDFJ(OLIIPKODDIN.position) - this.LJIPMLENJFN(OLIIPKODDIN.position - OLIIPKODDIN.delta);
				this.EEFEMMFGDAG.localPosition += b;
			}
		}

		// Token: 0x0600A3CF RID: 41935 RVA: 0x003D646E File Offset: 0x003D466E
		private void IONDCKEOIIN()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = true;
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x003D7844 File Offset: 0x003D5A44
		private Vector3 LJIPMLENJFN(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceCamera && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("B:");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x003D6652 File Offset: 0x003D4852
		private void OBPMHAIOGEM()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = false;
		}

		// Token: 0x0600A3D2 RID: 41938 RVA: 0x003D6A69 File Offset: 0x003D4C69
		private void JBNPEHMDCMI()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.NMKGLCCKMAF();
			}
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x003D6652 File Offset: 0x003D4852
		private void EFCGNMNGNGM()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = false;
		}

		// Token: 0x0600A3D4 RID: 41940 RVA: 0x003D6487 File Offset: 0x003D4687
		private void JKBMKPDGCHG()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A3D5 RID: 41941 RVA: 0x003D6465 File Offset: 0x003D4665
		public void CBABDHFNPGB(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x0600A3D6 RID: 41942 RVA: 0x003D79B0 File Offset: 0x003D5BB0
		public void HEBJABMKHND(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject == null)
			{
				return;
			}
			if (OLIIPKODDIN.pointerCurrentRaycast.gameObject.name == base.name)
			{
				this.NDGBBDKAJEN = false;
			}
		}

		// Token: 0x0600A3D7 RID: 41943 RVA: 0x003D6A4E File Offset: 0x003D4C4E
		public void NOMEIEGJMGL(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x003D6487 File Offset: 0x003D4687
		private void DBLILJGKGHJ()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x003D646E File Offset: 0x003D466E
		private void CJGIIDMEICB()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = true;
		}

		// Token: 0x0600A3DA RID: 41946 RVA: 0x003D6640 File Offset: 0x003D4840
		private void FOMNCPKKCFN()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.PKKEJKEEIJH();
			}
		}

		// Token: 0x0600A3DB RID: 41947 RVA: 0x003D712A File Offset: 0x003D532A
		private void OIBMHPIFAKK()
		{
			if (UIWindowBase.ResetCoords)
			{
				this.IPPPLLDFKFC();
			}
		}

		// Token: 0x0600A3DC RID: 41948 RVA: 0x003D7A04 File Offset: 0x003D5C04
		private Vector3 JFNMACAHKAC(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceCamera && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("_TimeX");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A3DD RID: 41949 RVA: 0x003D6487 File Offset: 0x003D4687
		private void CHOPDIGHJNH()
		{
			this.EEFEMMFGDAG = base.GetComponent<RectTransform>();
			this.CBPIELIMLAC = this.EEFEMMFGDAG.position;
			this.MNOBLOPJHNG = base.GetComponentInParent<Canvas>();
			this.LANGENBACJB = this.MNOBLOPJHNG.GetComponent<RectTransform>();
		}

		// Token: 0x0600A3DE RID: 41950 RVA: 0x003D7B70 File Offset: 0x003D5D70
		private Vector3 JMLAJAKHCMP(Vector3 FBKGOCMAEJN)
		{
			Vector2 sizeDelta = this.LANGENBACJB.sizeDelta;
			Vector3 result;
			Vector2 vector;
			Vector2 vector2;
			if (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceOverlay || (this.MNOBLOPJHNG.renderMode == RenderMode.ScreenSpaceCamera && this.MNOBLOPJHNG.worldCamera == null))
			{
				result = FBKGOCMAEJN;
				vector = Vector2.zero;
				vector2 = sizeDelta;
			}
			else
			{
				Ray ray = this.MNOBLOPJHNG.worldCamera.ScreenPointToRay(FBKGOCMAEJN);
				Plane plane = new Plane(this.LANGENBACJB.forward, this.LANGENBACJB.position);
				float d;
				if (!plane.Raycast(ray, out d))
				{
					throw new Exception("Unknown player asked for PickupItems");
				}
				Vector3 position = ray.origin + ray.direction * d;
				result = this.LANGENBACJB.InverseTransformPoint(position);
				vector = -Vector2.Scale(sizeDelta, this.LANGENBACJB.pivot);
				vector2 = Vector2.Scale(sizeDelta, Vector2.one - this.LANGENBACJB.pivot);
			}
			result.x = Mathf.Clamp(result.x, vector.x + (float)this.KeepWindowInCanvas, vector2.x - (float)this.KeepWindowInCanvas);
			result.y = Mathf.Clamp(result.y, vector.y + (float)this.KeepWindowInCanvas, vector2.y - (float)this.KeepWindowInCanvas);
			return result;
		}

		// Token: 0x0600A3DF RID: 41951 RVA: 0x003D6652 File Offset: 0x003D4852
		private void LKHBFKGBLCA()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = false;
		}

		// Token: 0x0600A3E0 RID: 41952 RVA: 0x003D646E File Offset: 0x003D466E
		private void EJLLKLODDBF()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = true;
		}

		// Token: 0x0600A3E1 RID: 41953 RVA: 0x003D7CDC File Offset: 0x003D5EDC
		public void MNMOHFPHHAP(PointerEventData OLIIPKODDIN)
		{
			if (this.NDGBBDKAJEN)
			{
				Vector3 b = this.LJIPMLENJFN(OLIIPKODDIN.position) - this.LFONPMBGMEA(OLIIPKODDIN.position - OLIIPKODDIN.delta);
				this.EEFEMMFGDAG.localPosition += b;
			}
		}

		// Token: 0x0600A3E2 RID: 41954 RVA: 0x003D6652 File Offset: 0x003D4852
		private void AMGJIDNADDN()
		{
			this.EEFEMMFGDAG.position = this.CBPIELIMLAC;
			UIWindowBase.ResetCoords = false;
		}

		// Token: 0x0400127D RID: 4733
		private RectTransform EEFEMMFGDAG;

		// Token: 0x0400127E RID: 4734
		private bool NDGBBDKAJEN;

		// Token: 0x0400127F RID: 4735
		public static bool ResetCoords;

		// Token: 0x04001280 RID: 4736
		private Vector3 CBPIELIMLAC = Vector3.zero;

		// Token: 0x04001281 RID: 4737
		private Canvas MNOBLOPJHNG;

		// Token: 0x04001282 RID: 4738
		private RectTransform LANGENBACJB;

		// Token: 0x04001283 RID: 4739
		public int KeepWindowInCanvas = 5;
	}
}
